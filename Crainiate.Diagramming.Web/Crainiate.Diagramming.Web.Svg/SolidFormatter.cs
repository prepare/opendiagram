// (c) Copyright Crainiate Software 2010




using System;
using System.Xml;
using System.Text;
using System.Drawing;

namespace Crainiate.Diagramming.Web.Svg
{
	public class SolidFormatter: Formatter
	{
		private string _definitionId;
		private string _classId;
		private string _clipId;

		public SolidFormatter()
		{
			Reset();
		}

		public virtual string DefinitionId
		{
			get
			{
				return _definitionId;
			}
			set
			{
				_definitionId = value;
			}
		}

		public virtual string ClassId
		{
			get
			{
				return _classId;
			}
			set
			{
				_classId = value;
			}
		}

		public virtual string ClipId
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

		public override void Reset()
		{
			_definitionId = string.Empty;
			_classId = string.Empty;
			_clipId = string.Empty;
		}

		public override void WriteElement(SvgDocument document, Element element)
		{
			Solid solid = (Solid) element;

			Definition definition = new Definition(solid.GetPath());
			Style style = null;

			//Add the definition
			//Determine definition
			DefinitionId = document.AddDefinition(definition.ExtractDefinition(), "");

			//Get style, no clipping path as this time
			style = new Style(solid);

			//Add the shadow use only if background is drawn, layer has shadows, and is a subclass of solid
			if (solid.DrawBackground && solid.Layer.DrawShadows && solid.GetType() != typeof(Solid) && solid.GetType() != typeof(Port))
			{
				StringBuilder stringBuilder = new System.Text.StringBuilder();
				double opacity = Math.Round(Convert.ToDouble(solid.Opacity / 1000F), 2);

				stringBuilder.Append("fill:");
				stringBuilder.Append(ColorTranslator.ToHtml(solid.Layer.ShadowColor));
				stringBuilder.Append(";fill-opacity:");
				stringBuilder.Append(opacity.ToString());
				stringBuilder.Append(";");

				ClassId = document.AddClass(stringBuilder.ToString(), "");

				document.AddUse(solid.Key.ToString() + "Shadow", DefinitionId, ClassId, "", solid.X + element.Layer.ShadowOffset.X, solid.Y + element.Layer.ShadowOffset.Y);
			}

			//Determine style
			ClassId = document.AddClass(style.GetStyle(), style.LinearGradient);

			//Add the use
			document.AddUse(solid.Key.ToString(), DefinitionId, ClassId, "", solid.X, solid.Y);

			SetNode(document.Node);

			if (solid.Image !=null || solid.Label != null)
			{
				ClipId = document.AddClipPath(DefinitionId, 0, 0);

				//Add a group for the complex shape
				XmlElement newElement = null;

				StringBuilder builder = new StringBuilder();
				builder.Append("translate(");
				builder.Append(XmlConvert.ToString(solid.X));
				builder.Append(",");
				builder.Append(XmlConvert.ToString(solid.Y));
				builder.Append(")");

				newElement = document.CreateElement("g");
				newElement.SetAttribute("id", solid.Key + "Container");
				newElement.SetAttribute("transform", builder.ToString());

				document.ContainerNode.AppendChild(newElement);

				//Set the element as the temporary container node
				XmlNode temp = document.ContainerNode;
				document.ContainerNode = newElement;

				//Add images
				if (solid.Image != null) AddShapeImage(document, solid, DefinitionId, ClipId);

				//Add text with a clipping path
				if (solid.Label != null) AddShapeText(document, solid, ClipId);

				document.ContainerNode = temp;
			}
		}

		private void AddShapeText(SvgDocument document, Solid solid, string strClipId)
		{
			if (solid.Label.Text.Trim() == "") return;

			Style style = new Style();

			//Add clipping to style if required
			style.ClipPathId = strClipId;

			//Set up text object
			Text text = new Text();
			text.Label = solid.Label;
			text.LayoutRectangle = solid.InternalRectangle;

			//Get style
			string classId = null;
			classId = document.AddClass(text.GetStyle(strClipId), "");

			//Create fragment and add to document
			XmlDocumentFragment frag = null;
			XmlNode newElementNode = null;

			frag = document.CreateDocumentFragment();
			frag.InnerXml = text.ExtractText(0, 0, solid.Key +"Text");
			frag.FirstChild.Attributes.GetNamedItem("class").InnerText = classId;
			newElementNode = document.ContainerNode.AppendChild(frag);
		}

		private void AddShapeImage(SvgDocument document, Solid solid, string definitionId, string clipId)
		{
			ImageRef image = new ImageRef();

			XmlDocumentFragment frag = null;
			XmlElement newElement = null;

			string classId = null;
			string id = null;

			image.SolidElement = solid;

			//Set up clipping if required
			if (solid.Clip)
			{
				System.Text.StringBuilder objBuilder = new System.Text.StringBuilder();

				objBuilder.Append("clip-path:url(\"#");
				objBuilder.Append(clipId);
				objBuilder.Append("\");");

				classId = document.AddClass(objBuilder.ToString(), "");
			}

			//Extract image
			image.Image = solid.Image;

			frag = document.CreateDocumentFragment();
			frag.InnerXml = image.ExtractImage();

			//Create image element
			newElement = document.CreateElement("image");

			newElement.SetAttribute("href", "http://www.w3.org/1999/xlink", frag.FirstChild.Attributes.GetNamedItem("href").InnerXml);
			newElement.SetAttribute("x", frag.FirstChild.Attributes.GetNamedItem("x").InnerText);
			newElement.SetAttribute("y", frag.FirstChild.Attributes.GetNamedItem("y").InnerText);
			newElement.SetAttribute("width", frag.FirstChild.Attributes.GetNamedItem("width").InnerText);
			newElement.SetAttribute("height", frag.FirstChild.Attributes.GetNamedItem("height").InnerText);

			id = frag.FirstChild.Attributes.GetNamedItem("id").InnerText;
			newElement.SetAttribute("id", id);

			if (solid.Clip) newElement.SetAttribute("class", classId);

			//Append image to the current container
			document.ContainerNode.AppendChild(newElement);

		}
	}
}
