// (c) Copyright Crainiate Software 2010




using System;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.Text;

namespace Crainiate.Diagramming.Web.Svg
{
	public class ImageRef
	{
		private Image _image;
		private Solid _solid;

		#region  Interface 

		public ImageRef()
		{

		}

		public ImageRef(Solid solid, Image image)
		{
			_image = image;
			_solid = solid;
		}

		//Extracts SVG image information for a given image
		public virtual string ExtractImage()
		{
			return ExtractImageImplementation();
		}

		//Sets or gets the ERM Image associated with this class
		public virtual Image Image
		{
			get
			{
				return _image;
			}
			set
			{
				_image = value;
			}
		}

		//Sets or gets the shape containing this image
		public virtual Solid SolidElement
		{
			get
			{
				return _solid;
			}
			set
			{
				_solid = value;
			}
		}

		#endregion

		#region  Implementation 

		private string ExtractImageImplementation()
		{
			if (_image == null || _solid == null) return null;

			StringBuilder builder = new StringBuilder();
			string newPath = _image.Path;

			PointF location = new PointF();

			location = _image.Location;

			builder.Append("<image id=\"");
			if (_solid != null) builder.Append(_solid.Key);
			builder.Append("\"");

			//Add class if clipping required
			if (_solid.Clip) builder.Append(" class=\"\"");
		
			builder.Append(" x = \"");
			builder.Append(location.X.ToString());
			builder.Append("\" y=\"");
			builder.Append(location.Y.ToString());
			builder.Append("\" width=\"");
			builder.Append(_image.Bitmap.Width.ToString());
			builder.Append("\" height=\"");
			builder.Append(_image.Bitmap.Height.ToString());
			builder.Append("\" href=\"");
			builder.Append(newPath);
			builder.Append("\"/>");

			return builder.ToString();
		}

	#endregion

	}

}