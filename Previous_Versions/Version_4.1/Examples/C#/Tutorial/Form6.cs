using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form6.
	/// </summary>
	public class Form6 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Model model1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form6()
		{
//			Crainiate.ERM4.Component.Instance.DefaultActionStyle = ActionStyle.Basic;
//			Crainiate.ERM4.Component.Instance.ActionBrush = new SolidBrush(Color.FromArgb(32,Color.Green));
//			Crainiate.ERM4.Component.Instance.ActionPen= new Pen(Color.FromArgb(128,Color.Green),2);
//			
//			GraphicsPath path = new GraphicsPath();
//			path.AddRectangle(new Rectangle(0,0,6,6));
//			Crainiate.ERM4.Component.Instance.DefaultHandlePath = path;
//			Crainiate.ERM4.Component.Instance.SelectionBrush = new SolidBrush(Color.White);
//			Crainiate.ERM4.Component.Instance.SelectionPen = new Pen(Color.Black);
//
//			HatchBrush brush = new HatchBrush(HatchStyle.Percent25, Color.FromArgb(48,Color.Black),Color.FromArgb(0,Color.White));
//			Crainiate.ERM4.Component.Instance.SelectionHatchPen = new Pen(brush,6);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form6));
			this.model1 = new Crainiate.ERM4.Model();
			this.SuspendLayout();
			// 
			// model1
			// 
			this.model1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.model1.DiagramSize = new System.Drawing.Size(632, 473);
			this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(632, 453);
			this.model1.TabIndex = 1;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// Form6
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.model1);
			this.Name = "Form6";
			this.Text = "Form6";
			this.Load += new System.EventHandler(this.Form6_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form6_Load(object sender, System.EventArgs e)
		{
			CustomStencil stencil = new CustomStencil();

			Server shape = new Server();
			shape.Location = new PointF(100,100);
			shape.ServerType = ServerType.Generic;
			shape.Available = true;
			
			model1.Shapes.Add("left",shape);

			shape = new Server();
			shape.Location = new PointF(190,120);
			shape.ServerType = ServerType.Web ;
			shape.Available = true;
						
			model1.Shapes.Add("right",shape);

			model1.Runtime = new CustomRuntime();
			//model1.Runtime.InteractiveMode = InteractiveMode.AddComplexShape;

		}

	}
}
