// (c) Copyright Crainiate Software 2010




using System;
using System.Xml;

namespace Crainiate.Diagramming.Web.Svg
{
	public class LineFormatter: Formatter
	{
		//Working variables
		private Marker _marker;
		private Polyline _polyLine;

		public override void WriteElement(SvgDocument document, Element element)
		{
			Link line = (Link) element;
			
			Style style = new Style(line);

			XmlNode newNode = null;
			XmlDocumentFragment fragment = null;

			string classId = null;

			//Add the line
			_polyLine.Line = line;
			fragment = document.CreateDocumentFragment();
			fragment.InnerXml = _polyLine.ExtractPolyline();

			newNode = document.ContainerNode.AppendChild(fragment);

			//Determine style
			classId = document.AddClass(style.GetStyle(), "");
			newNode.Attributes.GetNamedItem("class").InnerText = classId;
			
			//Reset the key if in a container
			if (document.ContainerKey != null && document.ContainerKey != string.Empty) 
			{
				newNode.Attributes.GetNamedItem("id").Value  = document.ContainerKey + "," + line.Key;
			}

			//Check for start marker
			if (line.Start.Marker != null)
			{
				_marker.MarkerBase = line.Start.Marker;

				//Check for a definition or add a new one
				string defId = document.AddDefinition(_marker.ExtractMarker(-90, true));
				
				XmlElement newElement = (XmlElement) newNode;
				newElement.SetAttribute("marker-start","url(#" + defId + ")");
			}

			//Check for end marker
			if (line.End.Marker != null)
			{
				_marker.MarkerBase = line.End.Marker;

				//Check for a definition or add a new one
				string defId = document.AddDefinition(_marker.ExtractMarker(90, false));
				
				XmlElement newElement = (XmlElement) newNode;
				newElement.SetAttribute("marker-end","url(#" + defId + ")");
			}

			//Set the xml element
			SetNode(newNode);
		}

		public override void Reset()
		{
			base.Reset();
			if (_marker == null) _marker = new Marker(null);
			if (_polyLine == null) _polyLine = new Polyline(null);
		}
	}
}
