// (c) Copyright Crainiate Software 2010




using System;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.Xml;
using System.Text;

namespace Crainiate.Diagramming.Web.Svg
{
	public class Text
	{
		private Label _label;
		private RectangleF[] _rectangles;
		private RectangleF _layoutRectangle;
		private StringFormat _format; 

		#region  Interface 

		public Text()
		{
			_format = new StringFormat();
		}

		public Text(Label label)
		{
			_format = new StringFormat();
			Label = label;
		}

		//Sets the internal label object
		public virtual Label Label
		{
			get
			{
				return _label;
			}
			set
			{
				_label = value;
			}
		}

		public virtual RectangleF LayoutRectangle
		{
			get
			{
				return _layoutRectangle;
			}
			set
			{
				_layoutRectangle = value;
			}
		}

		public virtual StringFormat Format
		{
			get
			{
				return _format;
			}
			set
			{
				_format = value;
			}
		}

		//Returns the text element for the internal label object
		public virtual string ExtractText(float x, float y, string id)
		{
			if (_label == null) throw new TextException("Text cannot be extracted using this method without a valid Label reference.");
			MeasureCharacters();
			return ExtractTextImplementation(_label.Text, _label.Font,  x, y, id);
		}

		//Returns the text element for the internal label object
		public virtual string ExtractText(string text, Font font, float x, float y, string id)
		{
			MeasureCharactersImplementation(text, font, _format);
			return ExtractTextImplementation(text, font,  x, y, id);
		}

		//Return the style definition from a shape
		public virtual string GetStyle()
		{
			if (_label == null) throw new TextException("Style cannot be extracted using this method without a valid Label reference.");
			return ExtractStyleImplementation(_label.Font, _label.Color, "");
		}

		//Return the style definition with clipping path from a shape
		public virtual string GetStyle(string ClipPathId)
		{
			if (_label == null) throw new TextException("Style cannot be extracted using this method without a valid Label reference.");
			return ExtractStyleImplementation(_label.Font, _label.Color, ClipPathId);
		}

		//Return the style definition from a shape
		public virtual string GetStyle(Font font, Color color)
		{
			return ExtractStyleImplementation(font, color, "");
		}

		//Return the style definition with clipping path from a shape
		public virtual string GetStyle(Font font, Color color, string ClipPathId)
		{
			return ExtractStyleImplementation(font, color, ClipPathId);
		}

		public virtual void MeasureCharacters()
		{
			if (_label == null) throw new TextException("Characters cannot be measured using this method without a valid Label reference.");
			
			_format = _label.GetStringFormat();
			MeasureCharactersImplementation(_label.Text, _label.Font, _format);
		}

		public virtual void Reset()
		{
			_label = null;
			_layoutRectangle = new RectangleF();
		}

		#endregion

		#region  Implementation 

		private void SetLabel(Label label)
		{
			_label = label;
		}

		private void MeasureCharactersImplementation(string text, Font font, StringFormat format)
		{
			Graphics graphics = Singleton.Instance.CreateGraphics();
			Region[] regions = null;
			CharacterRange[] ranges = new CharacterRange[1];

			//Get the text
			int i = 0;
			int count = text.Length;
			if (text == "") text = ".";

			if (_layoutRectangle.IsEmpty)
			{
				SizeF size = graphics.MeasureString(text, font);
				size.Width += 10;
				size.Height += 10;
				_layoutRectangle = new RectangleF(new PointF(0,0), size);
			}
			
			//Measure each character
			_rectangles = new RectangleF[count+1];
			for (i = 0; i < count; i++)
			{
				ranges[0].First = i;
				ranges[0].Length = 1;
				format.SetMeasurableCharacterRanges(ranges);
				regions = graphics.MeasureCharacterRanges(text, font, _layoutRectangle, format);
				_rectangles[i + 1] = regions[0].GetBounds(graphics);
			}

			//Reset the first rectangle
			_rectangles[0] = _rectangles[1];
			_rectangles[0].Width = 1;
			_rectangles[0].X -= 1;

			graphics.Dispose();
		}

		private string ExtractTextImplementation(string text, Font font, float x, float y, string key)
		{
			if (text == "") return "";

			int i = 0;
			float top = 0F;
			char[] arrText = text.ToCharArray();
			StringBuilder builder = new StringBuilder();

			int ascent = font.FontFamily.GetCellAscent(font.Style);

			// 14.484375 = 16.0 * 1854 / 2048
			float ascentPixel =	font.Size * ascent / font.FontFamily.GetEmHeight(font.Style);

			builder.Append("<text id=\"");
			builder.Append(key);
			builder.Append("\" class=\"\">");
			builder.Append("\r");
			builder.Append("\t");

			for (i = 0; i <= arrText.GetUpperBound(0); i++)
			{
				//Exit if top is less than last top (measure character reverts Y to 0 when clipped)
				//Line return comes in at empty
				if (top > _rectangles[i + 1].Top && i > 0 && !_rectangles[i + 1].IsEmpty) break;

				if (top < _rectangles[i + 1].Top || i == 0)
				{
					//Close previous tspan tag
					if (i > 0)
					{
						builder.Append("</tspan>");
					}

					top = _rectangles[i + 1].Top;
					builder.Append("<tspan x=\"");
					builder.Append(XmlConvert.ToString((_rectangles[i + 1].Left + x)));
					builder.Append("\" y=\"");
					builder.Append(XmlConvert.ToString((_rectangles[i + 1].Top + Convert.ToInt32(ascentPixel) + y)));
					builder.Append("\">");
				}

				//Check here for reserved chacters like <,>,&
				string strChar = arrText[i].ToString();

				if (strChar == "<") 
				{
					strChar = "&lt;";
				}
				else if (strChar == ">")
				{
					strChar = "&gt;";
				}
				else if (strChar == "&")
				{
					strChar = "&amp;";
				}
				else if (strChar == "\"")
				{
					strChar = "&quot;";
				}

				builder.Append(strChar);
			}

			builder.Append("</tspan>");
			builder.Append("</text>");

			return builder.ToString();
		}

		private string ExtractStyleImplementation(Font font, Color color, string clipPathId)
		{
			StringBuilder builder = new StringBuilder();
			
			builder.Append("text-rendering:auto;");

			builder.Append("font-family:'");
			builder.Append(font.FontFamily.Name.ToString());
			builder.Append("';");			

			if (font.Bold) builder.Append("font-weight:bold;");
			if (font.Italic) builder.Append("font-style:italic;");

			builder.Append("font-size:");
			builder.Append(XmlConvert.ToString(font.SizeInPoints));
			builder.Append("pt;color:");
			builder.Append(Style.GetCompatibleColor(color));
			builder.Append(";");

			//Add the clip path id if required
			if (clipPathId != "")
			{
				builder.Append("clip-path:url(#");
				builder.Append(clipPathId);
				builder.Append(");");
			}

			return builder.ToString();
		}

		#endregion
	}
}