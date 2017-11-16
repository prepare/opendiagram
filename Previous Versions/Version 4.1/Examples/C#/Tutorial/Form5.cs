using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Crainiate.ERM4;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form5.
	/// </summary>
	public class Form5 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Model model1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbType;
		internal System.Windows.Forms.CheckBox chkAvailable;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form5()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form5));
			this.model1 = new Crainiate.ERM4.Model();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.chkAvailable = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// model1
			// 
			this.model1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.model1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.model1.DiagramSize = new System.Drawing.Size(592, 473);
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(481, 473);
			this.model1.TabIndex = 0;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(550, 140);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(64, 26);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(550, 178);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(64, 26);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(502, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Serialization";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(553, 443);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 26);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(502, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Custom Property";
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.Location = new System.Drawing.Point(503, 39);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(111, 21);
			this.cmbType.TabIndex = 6;
			this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
			// 
			// chkAvailable
			// 
			this.chkAvailable.Location = new System.Drawing.Point(505, 75);
			this.chkAvailable.Name = "chkAvailable";
			this.chkAvailable.Size = new System.Drawing.Size(104, 14);
			this.chkAvailable.TabIndex = 14;
			this.chkAvailable.Text = "Available";
			this.chkAvailable.CheckedChanged += new System.EventHandler(this.chkAvailable_CheckedChanged);
			// 
			// Form5
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(622, 473);
			this.Controls.Add(this.chkAvailable);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.model1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form5";
			this.Text = "Form5";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form5_Load(object sender, System.EventArgs e)
		{
			Server server = new Server();
			server.Location = new PointF(100,100);
			model1.Shapes.Add("server1",server);

			model1.UndoList.Suspend();

			//Load server type combo
			cmbType.Items.AddRange(System.Enum.GetNames(typeof(ServerType)));
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			model1.Save("diagram.xml",SaveFormat.Xml);
		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			model1.Open("diagram.xml",LoadFormat.Xml);
		}

		private void cmbType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Server server = (Server) model1.Shapes["server1"];
			server.ServerType = (ServerType) Enum.Parse(typeof(ServerType),cmbType.Text);
		}

		private void chkAvailable_CheckedChanged(object sender, System.EventArgs e)
		{
			Server server = (Server) model1.Shapes["server1"];
			server.Available = chkAvailable.Checked;
		}
	}
}
