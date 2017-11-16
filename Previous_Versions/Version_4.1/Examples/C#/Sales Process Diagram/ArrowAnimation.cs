using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Examples
{
	public class ArrowAnimation: Animation
	{
		public ArrowAnimation()
		{
			FramesPerSecond = 1;
			TotalFrames = 8;
		}

		protected override void OnAnimateElement(Element e)
		{
			base.OnAnimateElement (e);

			Shape arrow = (Shape) e;

			//Reset arrow
			if (CurrentFrame == 1) 
			{
				arrow.Visible = false;
				arrow.Rotation = 315;
			}

			//Set the arrow location
			if (CurrentFrame > 2)
			{
				arrow.Visible = true;

				//Set the arrow location
				float degrees = Convert.ToSingle((CurrentFrame * 60) - 180);

				Matrix matrix = new Matrix();
				matrix.RotateAt(degrees, new PointF(120,120));

				arrow.Center = new PointF(180 + matrix.OffsetX, 150 + matrix.OffsetY);
			}

			//Set the rotation of the arrow
			if (CurrentFrame > 3)
			{
				arrow.Rotate(60);
			}

			//Set the color
			if (CurrentFrame == 2)
			{
				arrow.BorderColor = Color.Brown;
			}
			else if (CurrentFrame == 3)
			{
				arrow.BorderColor = Color.Red;
			}
			else if (CurrentFrame == 4)
			{
				arrow.BorderColor = Color.Purple;
			}
			else if (CurrentFrame == 5)
			{
				arrow.BorderColor = Color.Blue;
			}
			else if (CurrentFrame == 6)
			{
				arrow.BorderColor = Color.GreenYellow;
			}
			else if (CurrentFrame == 7)
			{
				arrow.BorderColor = Color.Orange;
			}
		}
	}
}
