using System;
using System.Drawing;
using System.Runtime.Serialization;
using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Examples
{
	[Serializable]
	public class Zone: Group, ISerializable
	{
		//Creates a new zone
		public Zone()
		{
			DrawBackground = true;
			BorderWidth = 2;
			BorderColor = Color.FromArgb(128,127,128);
			BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			
			Label = new TextLabel();

			Label.Italic = true;
			Label.Offset = new PointF(10,10);
			Label.Size = new SizeF(100,20);
			Label.Alignment = StringAlignment.Near;
			Label.Color = Color.FromArgb(66,65,66);
			Label.Text="Zone";
		}
	}
}
