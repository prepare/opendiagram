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
			this.label1.Location = new System.Drawing.Point(880, 8);
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
			this.cmbZoom.Location = new System.Drawing.Point(880, 32);
			this.cmbZoom.Name = "cmbZoom";
			this.cmbZoom.Size = new System.Drawing.Size(120, 21);
			this.cmbZoom.TabIndex = 3;
			this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(936, 692);
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
			this.model1.DiagramSize = new System.Drawing.Size(1000, 1000);
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(854, 721);
			this.model1.TabIndex = 5;
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
			this.Text = "Class Diagram";
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
			Table table = new Table();

			//Set Element properties
			table.BackColor = Color.White;
			table.GradientColor = Color.FromArgb(96,SystemColors.Highlight);
			table.Location = new PointF(100,50);
			table.Width = 140;
			table.Height = 200;
			table.Indent = 10;
			table.Heading = "Element";
			table.SubHeading = "Class";
			table.DrawExpand = true;
						
			//Add the fields group
			TableGroup fieldGroup = new TableGroup();
			fieldGroup.Text = "Fields";
			table.Groups.Add(fieldGroup);

			//Add the fields rows
			//Layer
			TableRow row = new TableRow();
			row.Text="Layer";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);

			//SuspendEvents
			row = new TableRow();
			row.Text="SuspendEvents";
			row.Image = new Crainiate.Diagramming.Image("Resource.protectedfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);

			//Add the methods group
			TableGroup methodGroup = new TableGroup();
			methodGroup.Text = "Methods";
			table.Groups.Add(methodGroup);

			//Add the methods rows
			//AddPath
			row = new TableRow();
			row.Text="AddPath";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicmethod.gif","Crainiate.Diagramming.Component");
			methodGroup.Rows.Add(row);

			row = new TableRow();
			row.Image = new Crainiate.Diagramming.Image("Resource.protectedmethod.gif","Crainiate.Diagramming.Component");
			row.Text="SetLayer";
			methodGroup.Rows.Add(row);
			
			//Add Element to model
			model1.Shapes.Add("Element",table);

			table = new Table();

			//Set SolidElement properties
			table.BackColor = Color.White;
			table.GradientColor = Color.FromArgb(96,SystemColors.Highlight);
			table.Location = new PointF(100,250);
			table.Width = 140;
			table.Height = 500;
			table.Indent = 10;
			table.Heading = "SolidElement";
			table.SubHeading = "Class";
			table.DrawExpand = true;

			//Add the fields group
			fieldGroup = new TableGroup();
			fieldGroup.Text = "Fields";
			table.Groups.Add(fieldGroup);

			//Add the fields rows
			//BackColor
			row = new TableRow();
			row.Text="BackColor";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);

			//Add the methods group
			methodGroup = new TableGroup();
			methodGroup.Text = "Methods";
			table.Groups.Add(methodGroup);

			//Add the methods rows
			//ScalePath
			row = new TableRow();
			row.Text="ScalePath";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicmethod.gif","Crainiate.Diagramming.Component");
			methodGroup.Rows.Add(row);

			//Add Element to model
			model1.Shapes.Add("SolidElement",table);	
		
			table = new Table();

			//Set Shape properties
			table.BackColor = Color.White;
			table.GradientColor = Color.FromArgb(96,SystemColors.Highlight);
			table.Location = new PointF(100,410);
			table.Width = 140;
			table.Height = 500;
			table.Indent = 10;
			table.Heading = "Shape";
			table.SubHeading = "Class";
			table.DrawExpand = true;

			//Add the fields group
			fieldGroup = new TableGroup();
			fieldGroup.Text = "Fields";
			table.Groups.Add(fieldGroup);

			//Add the fields rows
			//AllowMove
			row = new TableRow();
			row.Text="AllowMove";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);

			//Add the methods group
			methodGroup = new TableGroup();
			methodGroup.Text = "Methods";
			table.Groups.Add(methodGroup);

			//Add the methods rows
			//Rotate
			row = new TableRow();
			row.Text="Rotate";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicmethod.gif","Crainiate.Diagramming.Component");
			methodGroup.Rows.Add(row);

			//Add Element to model
			model1.Shapes.Add("Shape",table);
			
			//Add a Layer class
			table = new Table();

			//Set Shape properties
			table.BackColor = Color.White;
			table.GradientColor = Color.FromArgb(96,SystemColors.Highlight);
			table.Location = new PointF(400,100);
			table.Width = 140;
			table.Height = 500;
			table.Indent = 10;
			table.Heading = "Layer";
			table.SubHeading = "Class";
			table.DrawExpand = true;

			//Add the fields group
			fieldGroup = new TableGroup();
			fieldGroup.Text = "Fields";
			table.Groups.Add(fieldGroup);

			//Add the fields rows
			//DrawShadows
			row = new TableRow();
			row.Text="DrawShadows";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);

			//Elements
			row = new TableRow();
			row.Text="Elements";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);

			//Opacity
			row = new TableRow();
			row.Text="Opacity";
			row.Image = new Crainiate.Diagramming.Image("Resource.publicfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);
			
			//SuspendEvents
			row = new TableRow();
			row.Text="SuspendEvents";
			row.Image = new Crainiate.Diagramming.Image("Resource.protectedfield.gif","Crainiate.Diagramming.Component");
			fieldGroup.Rows.Add(row);
			
			//Add Layer to model
			model1.Shapes.Add("Layer",table);

			//Add GradientMode enumeration shape
			table = new Table();

			//Set Shape properties
			table.BackColor = Color.White;
			table.GradientColor = Color.FromArgb(128,Color.GreenYellow);
			table.Location = new PointF(400,300);
			table.Width = 140;
			table.Height = 500;
			table.Indent = 10;
			table.Heading = "GradientMode";
			table.SubHeading = "Enum";
			table.DrawExpand = true;

			//Add the fields rows
			//BackwardDiagonal
			row = new TableRow();
			row.Text="BackwardDiagonal";
			table.Rows.Add(row);
		
			//ForwardDiagonal
			row = new TableRow();
			row.Text="ForwardDiagonal";
			table.Rows.Add(row);

			//Vertical
			row = new TableRow();
			row.Text="Vertical";
			table.Rows.Add(row);

			//Horizontal
			row = new TableRow();
			row.Text="Horizontal";
			table.Rows.Add(row);
			
			//Add GradientMode to model
			model1.Shapes.Add("GradientMode",table);
			
			//Connect
			//Create an arrow line marker
			Arrow arrow = new Arrow();
			arrow.DrawBackground = false;
			arrow.Inset = 8;

			//Add link between shape and solid
			Connector line = new Connector((Shape) model1.Shapes["Shape"],(Shape) model1.Shapes["SolidElement"]);
			line.End.Marker = arrow;
			model1.Lines.Add(model1.Lines.CreateKey(),line);

			//Add link between solid and element
			line = new Connector((Shape) model1.Shapes["SolidElement"],(Shape) model1.Shapes["Element"]);
			line.End.Marker = arrow;
			model1.Lines.Add(model1.Lines.CreateKey(),line);

			//Dependancies
			//Add dependancy between element and layer
			arrow = new Arrow();
			arrow.DrawBackground = false;
			arrow.Inset = 0;

			line = new Connector((Shape) model1.Shapes["Element"],(Shape) model1.Shapes["Layer"]);
			line.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			line.End.Marker = arrow;

			model1.Lines.Add(model1.Lines.CreateKey(),line);
		}

		private void cmbZoom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			model1.Zoom = int.Parse(cmbZoom.Text.Substring(0, cmbZoom.Text.Length - 1));
			model1.Refresh();
		}
	}
}
