using System;
using System.Drawing;
using System.Drawing.Text;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	public class CustomRender: Render 
	{
		private string mWatermark;
		
		//Constructor
		public CustomRender(): base()
		{
			Watermark = string.Empty;

			base.DrawSelections = true;
			base.DrawGrid = true;
		}

		//Properties
		public virtual string Watermark
		{
			get
			{
				return mWatermark;
			}
			set
			{
				mWatermark = value;
			}
		}

		//Overrides
		protected override void OnPreRender(System.Drawing.Graphics graphics)
		{
			if (Watermark != string.Empty)
			{
				SolidBrush brush = new SolidBrush(Color.FromArgb(128,Color.LightGray));
				Font font = new Font("Arial",72,FontStyle.Bold);
				
				graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
				graphics.DrawString(Watermark, font, brush, new PointF(30,30));
				graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
			}

			base.OnPreRender (graphics);
		}
	}
}
