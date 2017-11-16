using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Examples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbZoom;
		private System.Windows.Forms.Button btnClose;
		private Crainiate.Diagramming.Model model1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbZoom = new System.Windows.Forms.ComboBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.model1 = new Crainiate.Diagramming.Model();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Exit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(860, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Zoom";
			// 
			// cmbZoom
			// 
			this.cmbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZoom.Items.AddRange(new object[] {
														 "50 %",
														 "75 %",
														 "100 %",
														 "200 %"});
			this.cmbZoom.Location = new System.Drawing.Point(859, 34);
			this.cmbZoom.Name = "cmbZoom";
			this.cmbZoom.Size = new System.Drawing.Size(141, 21);
			this.cmbZoom.TabIndex = 3;
			this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(937, 690);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(72, 24);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// model1
			// 
			this.model1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.model1.AutoScroll = true;
			this.model1.AutoScrollMinSize = new System.Drawing.Size(1000, 1000);
			this.model1.BackColor = System.Drawing.SystemColors.Window;
			this.model1.DiagramSize = new System.Drawing.Size(1000, 1000);
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(841, 737);
			this.model1.TabIndex = 0;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(1016, 721);
			this.Controls.Add(this.model1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.cmbZoom);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Network Diagram";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Component.Instance.DefaultFont = new Font("Tahoma",8);
			Application.Run(new Form1());
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadModel();
		}

		private void LoadModel()
		{
			Crainiate.Diagramming.Component.Instance.DefaultFont = new Font("Tahoma",8);
		
			//Add the DMZ zone to the model
			Zone dmz = new Zone();
			dmz.Location = new Point(40,20);
			dmz.Size = new SizeF(220,180);
			dmz.Label.Text="DMZ";

			model1.Shapes.Add("dmz",dmz);
			
			//Add a server to the zone
			Server server = new Server();
			server.Location = new PointF(50,30);
			server.ServerType = ServerType.Web;
			
			SolidElement application = (SolidElement) server.Children["application"];
			application.Label.Text = "Company Website";

			dmz.Shapes.Add("server",server);

			//Add two ports to the zone
			Port port;

			port = new Port(PortOrientation.Top);
			dmz.Ports.Add("top",port);

			port = new Port(PortOrientation.Bottom);
			dmz.Ports.Add("bottom",port);

			//Add the internal zone to the model
			Zone intranet = new Zone();
			intranet.Location = new Point(300,20);
			intranet.Size = new SizeF(220,180);
			intranet.Label.Text = "Internal";

			model1.Shapes.Add("internal",intranet);

			//Add a server to the zone
			server = new Server();
			server.Location = new PointF(50,30);
			server.ServerType = ServerType.Web;

			application = (SolidElement) server.Children["application"];
			application.Label.Text = "Intranet";

			intranet.Shapes.Add("server",server);

			//Add a port to the zone
			port = new Port(PortOrientation.Bottom);
			intranet.Ports.Add("bottom",port);

			//Add zone3 to the model
			Zone zone3 = new Zone();
			zone3.Location = new Point(300,250);
			zone3.Size = new SizeF(220,280);
			zone3.Label.Text = "Zone3";

			model1.Shapes.Add("zone3",zone3);

			//Add two servers to the zone
			server = new Server();
			server.Location = new PointF(50,30);
			server.ServerType = ServerType.Web;
			zone3.Shapes.Add("server",server);

			server = new Server();
			server.Location = new PointF(50,150);
			server.ServerType = ServerType.Generic;
			zone3.Shapes.Add("server2",server);

			//Add two servers outside any zones
			Server business = new Server();
			business.Location = new PointF(90,260);
			business.ServerType = ServerType.Business;

			//Add a port to business
			port = new Port(PortOrientation.Right);
			business.Ports.Add("right",port);

			model1.Shapes.Add("business",business);

			Server sql = new Server();
			sql.Location = new PointF(90,400);
			sql.ServerType = ServerType.SQL;
			model1.Shapes.Add("database",sql);

			//Connect the dmz to the business server
			Connector connector = new Connector((Port) dmz.Ports["bottom"],(Port) business.Ports["top"]);
			connector.BorderColor = business.BorderColor;
			connector.BorderWidth = 2;
			connector.DrawShadow = false;

			//Set up line marker (line cap)
			connector.End.Marker = new Arrow();
			connector.End.Marker.BorderColor = business.BorderColor;
			connector.End.Marker.BackColor = business.BorderColor;

			model1.Lines.Add("dmztobusiness",connector);

			//Connect intranet to business server
			connector = new Connector((Port) intranet.Ports["bottom"],(Port) business.Ports["right"]);
			connector.BorderColor = business.BorderColor;
			connector.BorderWidth = 2;
			connector.DrawShadow = false;

			//Set up line marker (line cap)
			connector.End.Marker = new Arrow();
			connector.End.Marker.BorderColor = business.BorderColor;
			connector.End.Marker.BackColor = business.BorderColor;

			model1.Lines.Add("intranettobusiness",connector);		

			//Connect business to sql server
			connector = new Connector((Port) business.Ports["bottom"],(Port) sql.Ports["top"]);
			connector.BorderColor = sql.BorderColor;
			connector.BorderWidth = 2;
			connector.DrawShadow = false;

			//Set up line marker (line cap)
			connector.End.Marker = new Arrow();
			connector.End.Marker.BorderColor = sql.BorderColor;
			connector.End.Marker.BackColor = sql.BorderColor;

			model1.Lines.Add("businesstosql",connector);

			model1.Invalidate();
		}

		private void cmbZoom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			model1.Zoom = int.Parse(cmbZoom.Text.Substring(0, cmbZoom.Text.Length - 1));
			model1.Refresh();
		}
	}
}
