using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Model model1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.model1 = new Crainiate.ERM4.Model();
			this.SuspendLayout();
			// 
			// model1
			// 
			this.model1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.model1.DiagramSize = new System.Drawing.Size(529, 396);
			this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(529, 396);
			this.model1.TabIndex = 0;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(529, 396);
			this.Controls.Add(this.model1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form2_Load(object sender, System.EventArgs e)
		{
			Table table = new Table();

			//Set Element properties
			table.BackColor = Color.White;
			table.GradientColor = Color.FromArgb(96,SystemColors.Highlight);
			table.Location = new PointF(100,50);
			table.Width = 140;
			table.Height = 500;
			table.Indent = 10;
			table.Heading = "Element";
			table.SubHeading = "Class";

			//Add the fields group
			TableGroup fieldGroup = new TableGroup();
			fieldGroup.Text = "Fields";
			table.Groups.Add(fieldGroup);

			//Add the fields rows
			//Layer
			TableRow row = new TableRow();
			row.Text="Layer";
			row.Image = new Crainiate.ERM4.Image("Resource.publicfield.gif","Crainiate.ERM4.Component");
			fieldGroup.Rows.Add(row);

			//SuspendEvents
			row = new TableRow();
			row.Text="SuspendEvents";
			row.Image = new Crainiate.ERM4.Image("Resource.protectedfield.gif","Crainiate.ERM4.Component");
			fieldGroup.Rows.Add(row);

			//Add the methods group
			TableGroup methodGroup = new TableGroup();
			methodGroup.Text = "Methods";
			table.Groups.Add(methodGroup);

			//Add the methods rows
			//AddPath
			row = new TableRow();
			row.Text="AddPath";
			row.Image = new Crainiate.ERM4.Image("Resource.publicmethod.gif","Crainiate.ERM4.Component");
			methodGroup.Rows.Add(row);

			row = new TableRow();
			row.Image = new Crainiate.ERM4.Image("Resource.protectedmethod.gif","Crainiate.ERM4.Component");
			row.Text="SetLayer";
			methodGroup.Rows.Add(row);

			//Add Element to model
			model1.Shapes.Add("Element",table);

			//Add a complex shape
			ComplexShape complex = new ComplexShape();

			//Set the shape appearance
			complex.Location = new PointF(200,100);
			complex.Size = new SizeF(120,100);
			complex.BorderWidth = 2;
			complex.BorderColor = Color.FromArgb(255,24,54,118);
			complex.BackColor = Color.FromArgb(255,241,243,255);
					
			//Add the internal shape
			SolidElement solid = new SolidElement();
			solid.Location = new PointF(10,10);
			solid.Label = new TextLabel();
			solid.Label.Text = "Website";
			solid.BorderColor = Color.FromArgb(255,141,163,212);

			//Add the internal shape to the complex shape
			complex.Children.Add("solid",solid);

			//Add the complex shape to the model
			model1.Shapes.Add("complex",complex);
		}
	}
}
