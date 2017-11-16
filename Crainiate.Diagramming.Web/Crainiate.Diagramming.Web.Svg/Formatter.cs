// (c) Copyright Crainiate Software 2010




using System;
using System.Xml;

namespace Crainiate.Diagramming.Web.Svg
{
	public abstract class Formatter
	{
		private XmlNode _node;

		public virtual XmlNode Node
		{
			get
			{
				return _node;
			}
		}

		protected virtual void SetNode(XmlNode node)
		{
			_node = node;
		}
		
		public virtual void Reset()
		{
			_node = null;
		}

		public abstract void WriteElement(SvgDocument document, Element element);
		
	}
}
