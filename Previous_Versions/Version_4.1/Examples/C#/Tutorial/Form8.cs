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
	/// Summary description for Form8.
	/// </summary>
	public class Form8 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Model model1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form8()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form8));
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
			// Form8
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.model1);
			this.Name = "Form8";
			this.Text = "Form8";
			this.Load += new System.EventHandler(this.Form8_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form8_Load(object sender, System.EventArgs e)
		{
			//Create a new Shape
			Shape shape = new Shape();
			shape.Location = new PointF(260,180);
			shape.Label = new TextLabel("Animation Example");
			
			//Set the animation
			//shape.Animation = new Animation();
			//shape.Animation.FramesPerSecond = 2;
			//shape.Animation.TotalFrames = 8;
			//shape.Animation.AnimateElement +=new AnimateElementEventHandler(Animation_AnimateElement);
			shape.Animation = new CustomAnimation();
			
			model1.Shapes.Add("shape", shape);

			//Begin animation
			model1.Animator.Start();
		}

		private void Animation_AnimateElement(object sender, Element e)
		{
			Shape shape = (Shape) e;
			shape.Rotation = shape.Animation.CurrentFrame * 45F;
		}
	}
}
