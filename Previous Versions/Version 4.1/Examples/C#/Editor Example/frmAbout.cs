using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Crainiate.Diagramming.Examples
{
	internal class frmAbout : Form
	{

		#region Windows Form Designer generated code

		public frmAbout() : base()
		{

			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (! (components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label lbl;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Button cmdOK;
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAbout));
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(-24, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(500, 58);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			// 
			// lbl
			// 
			this.lbl.BackColor = System.Drawing.Color.White;
			this.lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl.Location = new System.Drawing.Point(16, 20);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(328, 16);
			this.lbl.TabIndex = 2;
			this.lbl.Text = "Editor Example";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Location = new System.Drawing.Point(0, 56);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(540, 4);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			// 
			// GroupBox2
			// 
			this.GroupBox2.Location = new System.Drawing.Point(0, 264);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(540, 4);
			this.GroupBox2.TabIndex = 4;
			this.GroupBox2.TabStop = false;
			// 
			// cmdOK
			// 
			this.cmdOK.Location = new System.Drawing.Point(384, 280);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(84, 24);
			this.cmdOK.TabIndex = 10;
			this.cmdOK.Text = "OK";
			this.cmdOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(16, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 48);
			this.label1.TabIndex = 13;
			this.label1.Text = "Editor uses portions of code from Diagram Studio 4.0. Source code subscribers rec" +
				"ieve full c# code listings of the ERM Diagram 4 component and the Diagram Studio" +
				" application.";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(16, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(392, 24);
			this.label2.TabIndex = 14;
			this.label2.Text = "Editor source code can be used and distibuted without restriction.";
			// 
			// frmAbout
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(474, 311);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ERM Diagram 4.1";
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		#region Events

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}