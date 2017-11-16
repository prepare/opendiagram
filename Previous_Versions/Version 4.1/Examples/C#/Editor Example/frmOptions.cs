using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using Crainiate.Diagramming;

namespace Crainiate.Diagramming.Examples
{
	/// <summary>
	/// Summary description for frmOptions.
	/// </summary>
	public class frmOptions : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button cmdOK;
		internal System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkAlign;
		private System.Windows.Forms.CheckBox chkHideElements;
		private System.Windows.Forms.CheckBox chkFeedback;
		private System.Windows.Forms.CheckBox chkActionStyle;
		private System.Windows.Forms.CheckBox chkDrawGrid;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmOptions()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		public bool DrawGrid
		{
			get
			{
				return chkDrawGrid.Checked;
			}
			set
			{
				chkDrawGrid.Checked = value;
			}
		}

		public bool AlignGrid
		{
			get
			{
				return chkAlign.Checked;
			}
			set
			{
				chkAlign.Checked = value;
			}
		}

		public bool HideActions
		{
			get
			{
				return chkHideElements.Checked;
			}
			set
			{
				chkHideElements.Checked = value;
			}
		}

		public bool Feedback
		{
			get
			{
				return chkFeedback.Checked;
			}
			set
			{
				chkFeedback.Checked = value;
			}
		}

		public bool BasicActions
		{
			get
			{
				return chkActionStyle.Checked;
			}
			set
			{
				chkActionStyle.Checked = value;
			}
		}

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
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkDrawGrid = new System.Windows.Forms.CheckBox();
			this.chkActionStyle = new System.Windows.Forms.CheckBox();
			this.chkFeedback = new System.Windows.Forms.CheckBox();
			this.chkHideElements = new System.Windows.Forms.CheckBox();
			this.chkAlign = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdOK
			// 
			this.cmdOK.Location = new System.Drawing.Point(312, 259);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(79, 23);
			this.cmdOK.TabIndex = 12;
			this.cmdOK.Text = "OK";
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Location = new System.Drawing.Point(396, 259);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(79, 23);
			this.cmdCancel.TabIndex = 13;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkDrawGrid);
			this.groupBox1.Controls.Add(this.chkActionStyle);
			this.groupBox1.Controls.Add(this.chkFeedback);
			this.groupBox1.Controls.Add(this.chkHideElements);
			this.groupBox1.Controls.Add(this.chkAlign);
			this.groupBox1.Location = new System.Drawing.Point(8, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(467, 232);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Editing";
			// 
			// chkDrawGrid
			// 
			this.chkDrawGrid.Location = new System.Drawing.Point(23, 41);
			this.chkDrawGrid.Name = "chkDrawGrid";
			this.chkDrawGrid.Size = new System.Drawing.Size(252, 19);
			this.chkDrawGrid.TabIndex = 9;
			this.chkDrawGrid.Text = "Draw grid";
			// 
			// chkActionStyle
			// 
			this.chkActionStyle.Location = new System.Drawing.Point(23, 169);
			this.chkActionStyle.Name = "chkActionStyle";
			this.chkActionStyle.Size = new System.Drawing.Size(252, 19);
			this.chkActionStyle.TabIndex = 8;
			this.chkActionStyle.Text = "Only show outline of objects being updated";
			// 
			// chkFeedback
			// 
			this.chkFeedback.Location = new System.Drawing.Point(23, 137);
			this.chkFeedback.Name = "chkFeedback";
			this.chkFeedback.Size = new System.Drawing.Size(307, 19);
			this.chkFeedback.TabIndex = 7;
			this.chkFeedback.Text = "Display user  feedback";
			// 
			// chkHideElements
			// 
			this.chkHideElements.Location = new System.Drawing.Point(23, 105);
			this.chkHideElements.Name = "chkHideElements";
			this.chkHideElements.Size = new System.Drawing.Size(252, 19);
			this.chkHideElements.TabIndex = 1;
			this.chkHideElements.Text = "Hide elements when moving or scaling";
			// 
			// chkAlign
			// 
			this.chkAlign.Location = new System.Drawing.Point(23, 73);
			this.chkAlign.Name = "chkAlign";
			this.chkAlign.Size = new System.Drawing.Size(252, 19);
			this.chkAlign.TabIndex = 0;
			this.chkAlign.Text = "Align elements to grid";
			// 
			// frmOptions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(484, 290);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOK);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmOptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
