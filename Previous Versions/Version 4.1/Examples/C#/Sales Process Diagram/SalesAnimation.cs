using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Examples
{
	public class SalesAnimation: Animation
	{
		//Stores the starting animation stop
		private long mBegin;
		private long mEnd;
 
		public SalesAnimation(long begin)
		{
			FramesPerSecond = 12;
			mBegin = begin;
			mEnd = begin + 12;
		}

		protected override void OnAnimateElement(Element e)
		{
			base.OnAnimateElement (e);

			Shape shape = (Shape) e;

			if (Animator.CurrentTick == 1) shape.Visible = false;

			//Calculate the position
			if (Animator.CurrentTick == mBegin)
			{
				float degrees = Convert.ToSingle((Animator.CurrentTick * 5) - 90);

				Matrix matrix = new Matrix();
				matrix.RotateAt(degrees, new PointF(120,120));

				shape.Center = new PointF(180 + matrix.OffsetX, 150 + matrix.OffsetY);
				shape.Opacity = 4;
				shape.Visible = true;
			}

			//Calculate the opacity
			if (Animator.CurrentTick > mBegin && Animator.CurrentTick < mEnd)
			{
				shape.Opacity = Convert.ToByte(4 + ((Animator.CurrentTick - mBegin) * 8));
			}
		}

	}
}
