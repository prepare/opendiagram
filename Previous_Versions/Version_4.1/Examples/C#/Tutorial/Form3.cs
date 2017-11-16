using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Crainiate.ERM4;
using Crainiate.ERM4.Flowcharting;
using Crainiate.ERM4.Editing;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Flowcharting.Flowchart flowchart1;
		private Crainiate.ERM4.Editing.Ruler ruler2;
		private Crainiate.ERM4.Editing.Ruler ruler1;
		private System.Windows.Forms.Splitter splitter1;
		private Crainiate.ERM4.Editing.Palette palette1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form3));
			this.flowchart1 = new Crainiate.ERM4.Flowcharting.Flowchart();
			this.ruler2 = new Crainiate.ERM4.Editing.Ruler();
			this.ruler1 = new Crainiate.ERM4.Editing.Ruler();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.palette1 = new Crainiate.ERM4.Editing.Palette();
			this.SuspendLayout();
			// 
			// flowchart1
			// 
			this.flowchart1.AllowDrop = true;
			this.flowchart1.AutoScroll = true;
			this.flowchart1.AutoScrollMinSize = new System.Drawing.Size(1040, 1040);
			this.flowchart1.DiagramSize = new System.Drawing.Size(1000, 1000);
			this.flowchart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowchart1.DragElement = null;
			this.flowchart1.GridColor = System.Drawing.Color.Silver;
			this.flowchart1.GridSize = new System.Drawing.Size(20, 20);
			this.flowchart1.Location = new System.Drawing.Point(177, 23);
			this.flowchart1.Name = "flowchart1";
			this.flowchart1.Paged = true;
			this.flowchart1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("flowchart1.PageLineSize")));
			this.flowchart1.Size = new System.Drawing.Size(415, 450);
			this.flowchart1.Spacing = ((System.Drawing.SizeF)(resources.GetObject("flowchart1.Spacing")));
			this.flowchart1.TabIndex = 0;
			this.flowchart1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.flowchart1.Zoom = 100F;
			// 
			// ruler2
			// 
			this.ruler2.BorderStyle = Crainiate.ERM4.Editing.RulerBorderStyle.Edge;
			this.ruler2.Diagram = null;
			this.ruler2.Dock = System.Windows.Forms.DockStyle.Left;
			this.ruler2.Location = new System.Drawing.Point(157, 23);
			this.ruler2.Major = 100F;
			this.ruler2.Mid = 50F;
			this.ruler2.Minor = 10F;
			this.ruler2.Name = "ruler2";
			this.ruler2.Orientation = Crainiate.ERM4.Editing.RulerOrientation.Left;
			this.ruler2.Size = new System.Drawing.Size(20, 450);
			this.ruler2.Start = 0F;
			this.ruler2.TabIndex = 2;
			this.ruler2.Text = "ruler2";
			// 
			// ruler1
			// 
			this.ruler1.BorderStyle = Crainiate.ERM4.Editing.RulerBorderStyle.Edge;
			this.ruler1.Diagram = null;
			this.ruler1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ruler1.Location = new System.Drawing.Point(157, 0);
			this.ruler1.Major = 100F;
			this.ruler1.Mid = 50F;
			this.ruler1.Minor = 10F;
			this.ruler1.Name = "ruler1";
			this.ruler1.Padding = 20F;
			this.ruler1.Size = new System.Drawing.Size(435, 23);
			this.ruler1.Start = 0F;
			this.ruler1.TabIndex = 1;
			this.ruler1.Text = "ruler1";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(152, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(5, 473);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// palette1
			// 
			this.palette1.AllowDrop = true;
			this.palette1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.palette1.BackColor = System.Drawing.SystemColors.Control;
			this.palette1.BorderColor = System.Drawing.Color.Black;
			this.palette1.DiagramSize = new System.Drawing.Size(152, 473);
			this.palette1.Dock = System.Windows.Forms.DockStyle.Left;
			this.palette1.FillColor = System.Drawing.Color.White;
			this.palette1.ForeColor = System.Drawing.Color.Black;
			this.palette1.GradientColor = System.Drawing.Color.White;
			this.palette1.Location = new System.Drawing.Point(0, 0);
			this.palette1.Name = "palette1";
			this.palette1.Size = new System.Drawing.Size(152, 473);
			this.palette1.Spacing = new System.Drawing.Size(20, 22);
			this.palette1.TabIndex = 5;
			this.palette1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.palette1.Zoom = 100F;
			this.palette1.ElementMouseDown += new System.Windows.Forms.MouseEventHandler(this.palette1_ElementMouseDown);
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 473);
			this.Controls.Add(this.flowchart1);
			this.Controls.Add(this.ruler2);
			this.Controls.Add(this.ruler1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.palette1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form3_Load(object sender, System.EventArgs e)
		{
			//Add the begin shape
			Shape begin = flowchart1.AddFlowShape("begin",new PointF(200,40),FlowchartStencilType.Connector);
			begin.GradientColor = Color.PaleGoldenrod;			
			begin.Label = new TextLabel("start");

			//Add a process
			Process process = flowchart1.AddProcess("process1",begin);
			process.Shape.GradientColor = Color.LightSteelBlue;
			process.Shape.Label = new TextLabel("process");

			//Add a decision
			Decision decision = flowchart1.AddDecision(process.Shape,"decision1","decision1true",FlowchartStencilType.Process2,"decision1false",FlowchartStencilType.Process2);
			decision.DecisionShape.GradientColor = Color.PaleGoldenrod;
			decision.DecisionShape.Label = new TextLabel("decision");

			//Set the true element properties
			decision.TrueShape.GradientColor = Color.PaleGreen;
			decision.TrueShape.Label = new TextLabel("true");
			
			//Set the false element properties
			decision.FalseShape.GradientColor = Color.Red;
			decision.FalseShape.Label = new TextLabel("false");

			//Link rulers to the diagram
			ruler1.Diagram = flowchart1;
			ruler2.Diagram = flowchart1;

			//Add elements to palette
			palette1.AddStencil(new BasicStencil());

			//Add another tab to the palette			
			Tab tab = new Tab();
			tab.Name = "Flowcharting";
			palette1.Tabs.Add(tab);
			palette1.Tabs.CurrentTab = tab;

			//Add flowcharting elements to tab
			palette1.AddStencil(new FlowchartStencil());
			palette1.Refresh();

		}

		private void palette1_ElementMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (sender is Element)
			{
				//Start the drag operation
				Shape prototype = (Shape) sender;
				
				Shape shape = new Shape(prototype);
				shape.MinimumSize = new Size(32,32);
				shape.MaximumSize = new Size(320,320);
				shape.Scale(3,3,0,0,false);
				shape.Label = null;
				
				//Reset text
				shape.Label.Reset();

				palette1.DoDragDrop(shape, DragDropEffects.All);
			}
		}


	}
}
