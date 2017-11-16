using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Crainiate.ERM4;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form7.
	/// </summary>
	public class Form7 : System.Windows.Forms.Form
	{
		private WindowsApplication1.CustomDiagram customDiagram1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form7()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form7));
			this.customDiagram1 = new WindowsApplication1.CustomDiagram();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// customDiagram1
			// 
			this.customDiagram1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.customDiagram1.DiagramSize = new System.Drawing.Size(517, 401);
			this.customDiagram1.Dock = System.Windows.Forms.DockStyle.Top;
			this.customDiagram1.DragElement = null;
			this.customDiagram1.GridColor = System.Drawing.Color.Silver;
			this.customDiagram1.GridSize = new System.Drawing.Size(20, 20);
			this.customDiagram1.Location = new System.Drawing.Point(0, 0);
			this.customDiagram1.Name = "customDiagram1";
			this.customDiagram1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("customDiagram1.PageLineSize")));
			this.customDiagram1.Size = new System.Drawing.Size(517, 357);
			this.customDiagram1.TabIndex = 0;
			this.customDiagram1.Watermark = "Watermark";
			this.customDiagram1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.customDiagram1.Zoom = 100F;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 369);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(435, 368);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 24);
			this.button2.TabIndex = 2;
			this.button2.Text = "Load";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form7
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(517, 401);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.customDiagram1);
			this.Name = "Form7";
			this.Text = "Form7";
			this.Load += new System.EventHandler(this.Form7_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form7_Load(object sender, System.EventArgs e)
		{
			Shape shape = new Shape();
			customDiagram1.Shapes.Add("shape1",shape);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			customDiagram1.Save("watermark.xml");
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			customDiagram1.Open("watermark.xml");
		}
	}
}
