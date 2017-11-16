using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Crainiate.Diagramming;
using Crainiate.Diagramming.Flowcharting;

namespace Crainiate.Diagramming.Examples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Crainiate.Diagramming.Flowcharting.Flowchart flowchart1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ComboBox cmbZoom;
		private System.Windows.Forms.Label label1;
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
			this.flowchart1 = new Crainiate.Diagramming.Flowcharting.Flowchart();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.btnClose = new System.Windows.Forms.Button();
			this.cmbZoom = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// flowchart1
			// 
			this.flowchart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.flowchart1.AutoScroll = true;
			this.flowchart1.AutoScrollMinSize = new System.Drawing.Size(1000, 1000);
			this.flowchart1.DiagramSize = new System.Drawing.Size(1000, 1000);
			this.flowchart1.DragElement = null;
			this.flowchart1.GridColor = System.Drawing.Color.Silver;
			this.flowchart1.GridSize = new System.Drawing.Size(20, 20);
			this.flowchart1.Location = new System.Drawing.Point(0, 0);
			this.flowchart1.Name = "flowchart1";
			this.flowchart1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("flowchart1.PageLineSize")));
			this.flowchart1.Size = new System.Drawing.Size(864, 721);
			this.flowchart1.Spacing = ((System.Drawing.SizeF)(resources.GetObject("flowchart1.Spacing")));
			this.flowchart1.TabIndex = 0;
			this.flowchart1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.flowchart1.Zoom = 100F;
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
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(945, 683);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(66, 27);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// cmbZoom
			// 
			this.cmbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbZoom.Items.AddRange(new object[] {
														 "50 %",
														 "75 %",
														 "100 %",
														 "200 %"});
			this.cmbZoom.Location = new System.Drawing.Point(879, 32);
			this.cmbZoom.Name = "cmbZoom";
			this.cmbZoom.Size = new System.Drawing.Size(120, 21);
			this.cmbZoom.TabIndex = 5;
			this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(879, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Zoom";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(1016, 721);
			this.Controls.Add(this.cmbZoom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.flowchart1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Flowchart Example";
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
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadModel();
		}

		//Use high level flowcharting methods to create a flowchart. 
		private void LoadModel()
		{
			//Set the line mode to Connector so tht all lines created are conenctors
			flowchart1.LineMode = LineCreateMode.Connector;

			//Set up the spacing between items that are created
			flowchart1.Spacing = new SizeF(80,40);

			//Add the begin shape
			Shape begin = flowchart1.AddFlowShape("begin",new PointF(150,40),FlowchartStencilType.Connector);
			begin.Size = new SizeF(40,40);
			begin.Label = new TextLabel("start");

			//Add the ip address permitted as a shape
			Process ipaddress = flowchart1.AddProcess("ipaddress",begin,FlowchartStencilType.Decision);
			ipaddress.Shape.Label = new TextLabel("IP Address");
			ipaddress.Shape.Tooltip = "IP Address and domain permitted?";

			Connector conn = (Connector) ipaddress.Line;
			
			//Add the user authenticated decision
			Decision authenticated = flowchart1.AddDecision(ipaddress.Shape,"authenticated","authenticatedtrue",FlowchartStencilType.Process2,"authenticatedfalse",FlowchartStencilType.Process2);
			
			authenticated.DecisionShape.Label = new TextLabel("Authenticate");
			authenticated.DecisionShape.Tooltip = "User Authenticated?";
			
			authenticated.TrueShape.Label = new TextLabel("Launch ASP.NET");
			authenticated.TrueShape.Tooltip = "Launch ASP.NET Application";
	
			authenticated.FalseShape.Label = new TextLabel("Access Denied");
			
			//Link from ipaddress to access denied
			Connector connector = flowchart1.AddConnector("ipaddressdenied",ipaddress.Shape,authenticated.FalseShape);
			connector.End.Marker = new Arrow(false);

			//Add impersonation decision
			Decision impersonation = flowchart1.AddDecision(authenticated.TrueShape,"impersonation","impersonationtrue",FlowchartStencilType.Process2,"impersonationfalse",FlowchartStencilType.Process2);
			
			impersonation.DecisionShape.Label = new TextLabel("Impersonate");
			impersonation.DecisionShape.Tooltip = "ASP.NET Impersonation Enabled?";
			
			impersonation.TrueShape.Label = new TextLabel("Assume Identity");
			impersonation.TrueShape.Tooltip = "ASP.NET Assumes client identity";
	
			impersonation.FalseShape.Label = new TextLabel("Local Machine");
			impersonation.FalseShape.Tooltip = "ASP.NET runs with local machine identity";
						
			//Add access check as process
			Process access = flowchart1.AddProcess("access",impersonation.TrueShape,FlowchartStencilType.Decision);
			access.Shape.Label = new TextLabel("Access Check");
			access.Shape.Tooltip = "Access Check OK?";

		
			//Link to access denied

			//Add a port so that the line leaves the shape at the correct point
			Port port = new Port(PortOrientation.Right);
			port.Style = PortStyle.Simple;
			port.Visible = false;
			access.Shape.Ports.Add("right", port);
			connector = flowchart1.AddConnector("accessdenied",port,authenticated.FalseShape);
			connector.End.Marker = new Arrow(false);

			//Add access granted process
			Process success = flowchart1.AddProcess("success",access.Shape,FlowchartStencilType.Terminator);
			success.Shape.Label = new TextLabel("Granted");
			success.Shape.Tooltip = "Access Granted";

			//Change appearance of elements
			SetChartAppearance();
		}

		private void SetChartAppearance()
		{
			//Set default internal font
			Crainiate.Diagramming.Component.Instance.DefaultFont = new Font("Tahoma",8);

			//Set shape borders and colors
			foreach (Shape shape in flowchart1.Shapes.Values)
			{
				
				shape.BorderWidth = 2;
				shape.GradientColor = Color.FromArgb(192,132,169,202);
				shape.BorderColor = Color.FromArgb(132,169,202);

				//Set label
				if (shape.Label != null)
				{
					shape.Label.Color = Color.FromArgb(66,65,66);
				}
			}

			//Set line borders and colors
			foreach (Line line in flowchart1.Lines.Values)
			{
				line.BorderColor = Color.FromArgb(132,169,202);
				line.BorderWidth = 2;

				//Set up arrow, if any
				if (line.End.Marker != null)
				{
					line.End.Marker.BorderColor = Color.FromArgb(132,169,202);
					line.End.Marker.BackColor = Color.FromArgb(132,169,202);
					line.End.Marker.DrawBackground = true;
				}

				//Adjust if connector
				if (line is Connector)
				{
					Connector conn = (Connector)  line;
					conn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
					conn.Jump = true;
					conn.Rounded = true;
				}
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmbZoom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			flowchart1.Zoom = int.Parse(cmbZoom.Text.Substring(0, cmbZoom.Text.Length - 1));
			flowchart1.Refresh();
		}
	}
}
