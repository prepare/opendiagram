using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Model model1;
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
			this.model1 = new Crainiate.ERM4.Model();
			this.SuspendLayout();
			// 
			// model1
			// 
			this.model1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.model1.DiagramSize = new System.Drawing.Size(599, 473);
			this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(442, 323);
			this.model1.TabIndex = 0;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 323);
			this.Controls.Add(this.model1);
			this.Name = "Form1";
			this.Text = "Form1";
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
			Application.Run(new Form6());
		}

		private void model1_Load(object sender, System.EventArgs e)
		{

		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//Create a new group object
			Group group = new Group();
			group.Location = new PointF(50,50);
			model1.Shapes.Add("group1",group);
			
			//Create a shape and add to the group
			Shape shape = new Shape();
			shape.Location = new PointF(50,50);
			shape.DrawGradient = true;
			shape.GradientColor = Color.PaleGoldenrod;
			shape.Opacity = 80;

			//Add the shape to the group instead of the diagram
			group.Shapes.Add("shape1",shape);

			//Create another shape and use previous shape as a prototype
			Shape shape2 = new Shape(shape);
			shape2.Location = new PointF(200,200);
			group.Shapes.Add("shape2",shape2);

			//Add a connector with an arrow between the two shapes
			Connector connector = new Connector();
			connector.Start.Shape = shape;
			connector.End.Shape = shape2;
			connector.End.Marker = new Arrow();

			//Add the connector to the group
			group.Lines.Add(model1.Lines.CreateKey(),connector);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Crainiate.ERM4.Printing.PrintDocument print = new Crainiate.ERM4.Printing.PrintDocument(model1);
			print.PrintPreview(new Point(100,100),new Size(600,480));

			model1.Save("c:\\diagram.png",SaveFormat.Png);

			
		}
	}
}
