// (c) Copyright Crainiate Software 2010




using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace Crainiate.Diagramming.Web.Svg
{
	public class Style
	{
		private Solid _solid;
		private Link _line;
		private Curve _curve;
		private Label _label;

		private string _linearGradient;
		private string mStyle;
		private string _clipId;

		static char[] _hexDigits = {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};

		#region Interface 

		public Style()
		{

		}

		public Style(Link line)
		{
			_line = line;
			mStyle = StyleFromLineImplementation(line);
		}

		public Style(Curve curve)
		{
			_curve = curve;
			mStyle = StyleFromCurveImplementation(curve);
		}

		public Style(Solid solid)
		{
			_solid = solid;
			mStyle = StyleFromShapeImplementation(solid, "");
		}

		public Style(Solid solid, string clipId)
		{
			_solid = solid;
			_clipId = clipId;
			mStyle = StyleFromShapeImplementation(solid, clipId);
		}

		public Style(Label label)
		{
			_label = label;
			mStyle = StyleFromLabelImplementation(label, "");
		}

		//Sets or gets the shape used to create this style
		public virtual Solid SolidElement
		{
			get
			{
				return _solid;
			}
			set
			{
				_solid = value;
				mStyle = StyleFromShapeImplementation(value, _clipId);
			}
		}

		//Sets or gets the Line used to create this style
		public virtual Link Line
		{
			get
			{
				return _line;
			}
			set
			{
				_line = value;
				mStyle = StyleFromLineImplementation(value);
			}
		}

		//Sets or gets the Label used to create this style
		public virtual Label Label
		{
			get
			{
				return _label;
			}
			set
			{
				_label = value;
				mStyle = StyleFromLabelImplementation(value, _clipId);
			}
		}

		//Sets or gets the lineargradient, if applicable
		public virtual string LinearGradient
		{
			get
			{
				return _linearGradient;
			}
		}

		//Return the style definition from a shape
		public virtual string GetStyle()
		{
			return mStyle;
		}

		//Gets or sets the clipping path id
		public virtual string ClipPathId
		{
			get
			{
				return _clipId;
			}
			set
			{
				_clipId = value;
			}
		}

		#endregion

		#region  Implementation 

		private string StyleFromShapeImplementation(Solid solid, string clipId)
		{
			StringBuilder style = new StringBuilder();

			//Sort out the fill
			style.Append("fill:");
			
			if (!solid.DrawBackground)
			{
				style.Append("none;");
			}
			else
			{
				if (solid.DrawGradient && solid.BackColor != solid.GradientColor)
				{
					_linearGradient = ExtractLinearGradient(solid.GradientMode, solid.BackColor, solid.GradientColor);
					style.Append("url(#none);");
				}
				else
				{
					_linearGradient = "";
					style.Append(GetCompatibleColor(solid.BackColor));
					style.Append(";");
				}

				if (solid.Opacity < 100)
				{
					style.Append("fill-opacity:0.");
					style.Append(solid.Opacity.ToString());
					style.Append(";");
				}
			}

			//Sort out the stroke, ignore custom pens and use defaults
			style.Append("stroke:");
			style.Append(GetCompatibleColor(solid.BorderColor));
			style.Append(";");
			style.Append("stroke-width:");
			style.Append(solid.BorderWidth);
			style.Append(";");
			style.Append(GetDashStyle(_solid.BorderStyle, _solid.BorderWidth));

			//Add clipping path id if required
			if (clipId != "")
			{
				style.Append("clip-path:url(#");
				style.Append(clipId);
				style.Append(");");
			}

			return style.ToString();
		}

		private string StyleFromLineImplementation(Link line)
		{
			StringBuilder style = new StringBuilder();
			string colorString = GetCompatibleColor(line.BorderColor);

			style.Append("stroke:");
			style.Append(colorString);
			style.Append(";");
			style.Append("stroke-width:");
			style.Append(line.BorderWidth);
			style.Append(";");
			style.Append(GetDashStyle(line.BorderStyle, line.BorderWidth));
			style.Append("fill:none");
			style.Append(";");

			return style.ToString();
		}

		private string StyleFromCurveImplementation(Curve curve)
		{
			StringBuilder style = new StringBuilder();
			string colorString = GetCompatibleColor(curve.BorderColor);

			style.Append("stroke:");
			style.Append(colorString);
			style.Append(";");
			style.Append("stroke-width:");
			style.Append(curve.BorderWidth);
			style.Append(";");
			style.Append(GetDashStyle(curve.BorderStyle, curve.BorderWidth));
			style.Append("fill:none");
			style.Append(";");

			return style.ToString();
		}

		private string StyleFromLabelImplementation(Label label, string clipId)
		{
			StringBuilder style = new StringBuilder();

			//Sort out the fill
			style.Append("fill:none;");

			//Sort out the stroke, ignore custom pens and use defaults
			//If _shape.CustomPen Is Nothing Then
			style.Append("stroke:");
			style.Append(GetCompatibleColor(label.Color));
			style.Append(";");
			style.Append("stroke-width:1;");

			return style.ToString();
		}

		public static string ExtractLinearGradient(LinearGradientMode gradientMode, Color backColor, Color gradientColor)
		{
			StringBuilder gradient = new StringBuilder();

			gradient.Append("<linearGradient id=\"\" gradientUnits=\"objectBoundingBox\" ");

			//Rotate if not horizontal gradient
			switch (gradientMode)
			{
				case System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal:
					gradient.Append("gradientTransform=\"rotate(225)\"");
					break;
				case System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal:
					gradient.Append("gradientTransform=\"rotate(45)\"");
					break;
				case System.Drawing.Drawing2D.LinearGradientMode.Vertical:
					gradient.Append("gradientTransform=\"rotate(90)\"");
				break;
			}

			gradient.Append(">");

			//Add the 2 stops - change for blends here
			gradient.Append("\r");
			gradient.Append("\t");
			gradient.Append("<stop offset=\"0%\" style=\"stop-color:");
			gradient.Append(GetCompatibleColor(backColor));
			gradient.Append("\"/>");
			gradient.Append("\r");
			gradient.Append("\t");
			gradient.Append("<stop offset=\"100%\" style=\"stop-color:");
			gradient.Append(GetCompatibleColor(gradientColor));
			gradient.Append("\"/>");

			gradient.Append("</linearGradient>");

			return gradient.ToString();
		}

		public static string GetCompatibleColor(Color color)
		{
			byte[] bytes = new byte[3];
			bytes[0] = color.R;
			bytes[1] = color.G;
			bytes[2] = color.B;
			char[] chars = new char[bytes.Length * 2];
			for (int i = 0; i < bytes.Length; i++) 
			{
				int b = bytes[i];
				chars[i * 2] = _hexDigits[b >> 4];
				chars[i * 2 + 1] = _hexDigits[b & 0xF];
			}
			return "#" + new string(chars);
		}

		public static string GetDashStyle(DashStyle dashStyle, float lineWidth)
		{
			if (dashStyle == DashStyle.Custom || dashStyle == DashStyle.Solid) return "";

			StringBuilder dash = new StringBuilder();
			string bigDash = XmlConvert.ToString(lineWidth * 3);
			string littleDash = XmlConvert.ToString(lineWidth);

			dash.Append("stroke-dasharray:");
			switch (dashStyle)
			{
				case DashStyle.Dash:
					dash.Append(bigDash);
					dash.Append(",");
					dash.Append(littleDash);
					break;

				case DashStyle.DashDot:
					dash.Append(bigDash);
					dash.Append(",");
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
					break;

				case DashStyle.DashDotDot:
					dash.Append(bigDash);
					dash.Append(",");
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
					break;

				case DashStyle.Dot:
					dash.Append(littleDash);
					dash.Append(",");
					dash.Append(littleDash);
				break;
			}
			dash.Append(";");

			return dash.ToString();
		}
	#endregion

	}
}