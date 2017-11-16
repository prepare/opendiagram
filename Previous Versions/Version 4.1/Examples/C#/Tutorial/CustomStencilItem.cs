using System;
using System.Drawing;
using System.Drawing.Drawing2D;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	[Serializable]
	public class CustomStencilItem: StencilItem
	{
		public override GraphicsPath Draw(float width, float height)
		{
			GraphicsPath path = new GraphicsPath();

			//Draw the arrow using a 100x100 grid 
			path.AddLine(0,30,60,30);
			path.AddLine(60,30,60,0);
			path.AddLine(60,0,100,50);
			path.AddLine(100,50,60,100);
			path.AddLine(60,100,60,70);
			path.AddLine(60,70,0,70);
			
			//Close the figure
			path.CloseFigure(); 

			//Scale the path to the width and height provided
			Matrix translateMatrix = new Matrix();

			translateMatrix.Scale(width / 100, height / 100);
			path.Transform(translateMatrix);
			
			return path;
		}
	}
}
