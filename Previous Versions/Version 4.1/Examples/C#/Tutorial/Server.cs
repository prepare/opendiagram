using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using Crainiate.ERM4;

namespace WindowsApplication1
{
	public enum ServerType
	{
		Web = 0,
		Business =1,
		SQL = 2,
		Generic = 3
	}

	[Serializable]
	public class Server: ComplexShape
	{
		private ServerType mServerType;
		private bool mAvailable;

		public Server()
		{
			//Add two ports to the server
			Port port;

			port = new Port(PortOrientation.Top);
			port.BorderWidth = 2;
			Ports.Add("top",port);

			port = new Port(PortOrientation.Bottom);
			port.BorderWidth = 2;
			Ports.Add("bottom",port);
			
			//Set the shape appearance
			Size = new SizeF(120,100);
			BorderWidth = 2;
		
			//Add the internal solidshape
			SolidElement solid = new SolidElement();
			solid.Location = new PointF(10,10);
			solid.Label = new TextLabel();
			solid.Label.Text = "Server";

			Children.Add("solid",solid);

			ServerType = ServerType.Generic;
			Available = false;
		}

		protected Server(SerializationInfo info, StreamingContext context): base(info, context)
		{
			mServerType = (ServerType) Enum.Parse(typeof(ServerType), info.GetString("ServerType"),true);
			mAvailable = info.GetBoolean("Available");
		}

		public ServerType ServerType
		{
			get
			{
				return mServerType;
			}
			set
			{
				mServerType = value;
				SetColors(value);
			}
		}

		public bool Available
		{
			get
			{
				return mAvailable;
			}
			set
			{
				mAvailable = value;
				Invalidate();
			}
		}

		private void SetColors(ServerType serverType)
		{
			//Get the application child element
			SolidElement solid = (SolidElement) Children["solid"];
			Port port;
			
			if (solid == null) return;

			if (serverType == ServerType.Web)
			{				
				BorderColor = Color.FromArgb(255,24,54,118);
				BackColor = Color.FromArgb(255,241,243,255);
				solid.BorderColor = Color.FromArgb(255,141,163,212);
				solid.Label.Text="Website";

				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,141,163,212);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,141,163,212);
			}
			else if (serverType == ServerType.Business)
			{
				BorderColor = Color.FromArgb(255,91,172,17);
				BackColor = Color.FromArgb(255,247,253,243);
				solid.BorderColor = Color.FromArgb(255,202,210,187);
				solid.Label.Text="Business Objects";

				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,202,210,187);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,202,210,187);
			}
			else if (serverType == ServerType.SQL)
			{
				BorderColor = Color.FromArgb(255,189,182,110);
				BackColor = Color.FromArgb(255,255,250,236);
				solid.BorderColor = Color.FromArgb(255,215,214,196);
				solid.Label.Text="Database";

				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,215,214,196);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,215,214,196);
			}
			else if (serverType == ServerType.Generic)
			{
				BorderColor = Color.FromArgb(255,101,28,35);
				BackColor = Color.FromArgb(255,254,244,242);
				solid.BorderColor = Color.FromArgb(255,195,172,166);
				solid.Label.Text="Application";
			
				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,195,172,166);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,195,172,166);
			}

		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ServerType",Convert.ToInt32(ServerType).ToString());
			info.AddValue("Available",mAvailable);
			base.GetObjectData (info, context);
		}

		//Add custom rendered status "icon"
		protected override void Render(Graphics graphics, IRender render)
		{
			base.Render (graphics, render);

			//Save value of smoothign mode
			SmoothingMode smoothing = graphics.SmoothingMode;

			//Set up pens and brushes
			Pen pen = new Pen(Color.FromArgb(128,Color.Gray),1);
			SolidBrush brush = new SolidBrush(Color.White);

			//Move the drawing origin to the icon location
			graphics.TranslateTransform(Width-20,5);

			//Set up the circle path
			GraphicsPath path = new GraphicsPath();
			path.AddEllipse(0,0,16,16);

			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.FillPath(brush,path); //Fill Circle
			graphics.DrawPath(pen,path); //Outline

			//Set up the cross path
			if (Available)
			{
				//Set up the tick path
				GraphicsPath tick = new GraphicsPath();
				tick.AddLine(3,8,5,6);
				tick.AddLine(5,6,8,8);
				tick.AddLine(8,8,12,3);
				tick.AddLine(12,3,13,4);
				tick.AddLine(13,4,9,13);
				tick.AddLine(9,13,3,8);
	
				graphics.FillPath(new SolidBrush(BorderColor),tick);
			}
			else
			{
				GraphicsPath cross = new GraphicsPath();
				cross.AddLine(3,5,5,3);
				cross.AddLine(5,3,8,6);
				cross.AddLine(8,6,11,3);
				cross.AddLine(11,3,13,5);
				cross.AddLine(13,5,10,8);

				cross.AddLine(10,8,13,11);
				cross.AddLine(13,11,11,13);
				cross.AddLine(11,13,8,10);
				cross.AddLine(8,10,5,13);
				cross.AddLine(5,13,3,11);
				cross.AddLine(3,11,6,8);
						
				graphics.FillPath(new SolidBrush(Color.DarkRed),cross);
			}

			//Reset the translate and smoothing mode
			graphics.TranslateTransform(-(Width-20),-(Height-20));
			graphics.SmoothingMode = SmoothingMode;
		}
	}
}
