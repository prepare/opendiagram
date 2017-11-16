using System;
using System.Drawing;
using System.Runtime.Serialization;
using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Examples
{
	public enum ServerType
	{
		Web = 0,
		Business =1,
		SQL = 2,
		Generic = 3
	}
	
	//A complex shape that represents a server in a network diagram
	[Serializable]
	public class Server: ComplexShape, ISerializable
	{
		private ServerType mServerType;
		
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
		
			//Add the internal applicationshape
			SolidElement application = new SolidElement();
			application.Location = new PointF(10,10);
			application.Label = new TextLabel();
			application.Label.Text = "Application";
			application.Label.Color = Color.FromArgb(66,65,66);

			Children.Add("application",application);

			//Set up default server colors
			ServerType = ServerType.Web;

			MinimumSize = new Size(32,32);
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

		private void SetColors(ServerType serverType)
		{
			//Get the application child element
			SolidElement application = (SolidElement) Children["application"];
			Port port;

			if (serverType == ServerType.Web)
			{				
				BorderColor = Color.FromArgb(255,24,54,118);
				GradientColor = Color.FromArgb(255,221,223,235);
				application.BorderColor = Color.FromArgb(255,141,163,212);
				application.Label.Text="Website";

				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,141,163,212);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,141,163,212);
			}
			else if (serverType == ServerType.Business)
			{
				BorderColor = Color.FromArgb(255,91,172,17);
				GradientColor = Color.FromArgb(255,217,233,213);
				application.BorderColor = Color.FromArgb(255,91,172,17);
				application.Label.Text="Business Objects";

				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,202,210,187);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,202,210,187);
			}
			else if (serverType == ServerType.SQL)
			{
				BorderColor = Color.FromArgb(255,189,182,110);
				GradientColor = Color.FromArgb(255,235,230,216);
				application.BorderColor = Color.FromArgb(255,215,214,196);
				application.Label.Text="Database";

				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,215,214,196);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,215,214,196);
			}
			else if (serverType == ServerType.Generic)
			{
				BorderColor = Color.FromArgb(255,101,28,35);
				GradientColor = Color.FromArgb(255,234,224,222);
				application.BorderColor = Color.FromArgb(255,195,172,166);
				application.Label.Text="Application";
			
				port = (Port) Ports["top"];
				port.BorderColor = Color.FromArgb(255,195,172,166);

				port = (Port) Ports["bottom"];
				port.BorderColor = Color.FromArgb(255,195,172,166);
			}

		}
	}
}
