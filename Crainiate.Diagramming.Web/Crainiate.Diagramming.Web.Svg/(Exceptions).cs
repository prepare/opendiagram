// (c) Copyright Crainiate Software 2010




using System;

namespace Crainiate.Diagramming.Web.Svg
{
	public class DefinitionException: Exception 
	{
		public DefinitionException(string message) : base(message)
		{}
	}
	public class SvgDocumentException: Exception 
	{
		public SvgDocumentException(string message) : base(message)
		{}
	}
	public class PolylineException: Exception 
	{
		public PolylineException(string message) : base(message)
		{}
	}
	public class TextException: Exception 
	{
		public TextException(string message) : base(message)
		{}
	}
}
