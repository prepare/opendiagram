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
		private System.Windows.Forms.Button btnClose;
		private Crainiate.Diagramming.Model model1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnStop;
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
			this.btnClose = new System.Windows.Forms.Button();
			this.model1 = new Crainiate.Diagramming.Model();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
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
			this.label1.Location = new System.Drawing.Point(652, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Animation Controls";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(712, 524);
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
			this.model1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.model1.BackColor = System.Drawing.SystemColors.Window;
			this.model1.DiagramSize = new System.Drawing.Size(630, 655);
			this.model1.DragElement = null;
			this.model1.DragSelect = false;
			this.model1.DrawSelections = false;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(620, 553);
			this.model1.TabIndex = 5;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(711, 43);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(72, 24);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnPause
			// 
			this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPause.Location = new System.Drawing.Point(711, 105);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(72, 24);
			this.btnPause.TabIndex = 7;
			this.btnPause.Text = "Pause";
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStop.Location = new System.Drawing.Point(711, 74);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(72, 24);
			this.btnStop.TabIndex = 8;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(792, 553);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.model1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Sales Process Diagram";
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
			//Hide elements during an action
			Component.Instance.HideActions = true;
			
			//Get a stencil containing some basic shapes
			BasicStencil stencil = (BasicStencil) Component.Instance.GetStencil(typeof(BasicStencil));

			//Set up "prospect"
			Shape shape = new Shape(stencil[BasicStencilType.Circle]);
			shape.Size = new Size(70,70);
			shape.Label = new TextLabel("Prospect");
			shape.GradientColor = Color.Brown;
			shape.BorderColor = Color.Brown;
			shape.BorderWidth = 2;
			shape.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			shape.Visible = false;
			shape.Animation = new SalesAnimation(12);
			
			model1.Shapes.Add("Prospect", shape);
			
			//Set up "Qualify", using previous shape as a prototype
			shape = new Shape(shape);
			shape.Label = new TextLabel("Qualify");
			shape.GradientColor = Color.Red;
			shape.BorderColor = Color.Red;
			shape.Animation = new SalesAnimation(24);
			
			model1.Shapes.Add("Qualify", shape);

			//Set up "Propose", using previous shape as a prototype
			shape = new Shape(shape);
			shape.Label = new TextLabel("Propose");
			shape.GradientColor = Color.Purple;
			shape.BorderColor = Color.Purple;
			shape.Animation = new SalesAnimation(36);
			
			model1.Shapes.Add("Propose", shape);

			//Set up "Pilot", using previous shape as a prototype
			shape = new Shape(shape);
			shape.Label = new TextLabel("Pilot");
			shape.GradientColor = Color.Blue;
			shape.BorderColor = Color.Blue;
			shape.Animation = new SalesAnimation(48);
			
			model1.Shapes.Add("Pilot", shape);

			//Set up "Close", using previous shape as a prototype
			shape = new Shape(shape);
			shape.Label = new TextLabel("Close");
			shape.GradientColor = Color.GreenYellow;
			shape.BorderColor = Color.GreenYellow;
			shape.Animation = new SalesAnimation(60);
			
			model1.Shapes.Add("Green", shape);

			//Set up "Deploy", using previous shape as a prototype
			shape = new Shape(shape);
			shape.Label = new TextLabel("Deploy");
			shape.GradientColor = Color.Orange;
			shape.BorderColor = Color.Orange;
			shape.Animation = new SalesAnimation(72);
			
			model1.Shapes.Add("Deploy", shape);

			//Add the arrow
			ArrowStencil stencil2 = (ArrowStencil) Component.Instance.GetStencil(typeof(ArrowStencil));
			Shape arrow = new Shape(stencil2[ArrowStencilType.Left]);
			arrow.Size = new Size(30,18);
			arrow.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			arrow.BorderWidth = 2;
			arrow.Visible = false;
			arrow.DrawBackground = false;
			arrow.Animation = new ArrowAnimation();

			model1.Shapes.Add("Arrow", arrow);

			//Begin Animation
			model1.Animator.AnimatorStart += new EventHandler(Animator_AnimatorStart);
			model1.Animator.AnimatorPause += new EventHandler(Animator_AnimatorPause);
			model1.Animator.AnimatorEnd += new EventHandler(Animator_AnimatorEnd);

			model1.Animator.FinalTick = 84;
			model1.Animator.Start();
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			model1.Animator.Start();
		}

		private void btnPause_Click(object sender, System.EventArgs e)
		{
			model1.Animator.Pause();
		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			model1.Animator.Stop();
		}

		private void Animator_AnimatorStart(object sender, EventArgs e)
		{
			btnStart.Enabled = false;
			btnPause.Enabled = true;
			btnStop.Enabled = true;
		}

		private void Animator_AnimatorPause(object sender, EventArgs e)
		{
			btnStart.Enabled = true;
			btnPause.Enabled = false;
			btnStop.Enabled = true;
		}

		private void Animator_AnimatorEnd(object sender, EventArgs e)
		{
			btnStart.Enabled = true;
			btnPause.Enabled = false;
			btnStop.Enabled = false;
		}
	}
}
