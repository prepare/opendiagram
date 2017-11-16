using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Crainiate.ERM4;
using Crainiate.ERM4.Navigation;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form4.
	/// </summary>
	public class Form4 : System.Windows.Forms.Form
	{
		private Crainiate.ERM4.Model model1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form4()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form4));
			this.model1 = new Crainiate.ERM4.Model();
			this.SuspendLayout();
			// 
			// model1
			// 
			this.model1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.model1.DiagramSize = new System.Drawing.Size(592, 473);
			this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(0, 0);
			this.model1.Name = "model1";
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(592, 473);
			this.model1.TabIndex = 0;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			this.model1.ElementClick += new System.EventHandler(this.model1_ElementClick);
			// 
			// Form4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 473);
			this.Controls.Add(this.model1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form4_Load(object sender, System.EventArgs e)
		{
			//Add 10 shapes to the model
			Shape shape;

			for(int i=1;i<=10;i++)
			{
				shape = new Shape();
				shape.Location = new PointF(i*50,((i%3) * 50)+50);
				shape.Width=10;
				shape.Height = 10;
				shape.Label = new Crainiate.ERM4.TextLabel();
				shape.Label.Text = i.ToString();

				//shape.Stencil = stencil[BasicStencilType.Circle];
				model1.Shapes.Add(model1.Shapes.CreateKey(),shape);
			}

			//Link the shapes with some lines
			Line line;

			line = model1.AddLine((Shape) model1.Shapes["Shape1"],(Shape) model1.Shapes["Shape2"]);
			line.End.Marker = new Arrow();

			line = model1.AddLine((Shape) model1.Shapes["Shape1"],(Shape) model1.Shapes["Shape3"]);
			line.End.Marker = new Arrow();
						
			line = model1.AddLine((Shape) model1.Shapes["Shape2"],(Shape) model1.Shapes["Shape3"]);
			line.End.Marker = new Arrow();
			
			line = model1.AddLine((Shape) model1.Shapes["Shape1"],(Shape) model1.Shapes["Shape4"]);
			line.End.Marker = new Arrow();
			
			line = model1.AddLine((Shape) model1.Shapes["Shape2"],(Shape) model1.Shapes["Shape5"]);
			line.End.Marker = new Arrow();
			
			line = model1.AddLine((Shape) model1.Shapes["Shape6"],(Shape) model1.Shapes["Shape7"]);
			line.End.Marker = new Arrow();
			
			line = model1.AddLine((Shape) model1.Shapes["Shape5"],(Shape) model1.Shapes["Shape7"]);
			line.End.Marker = new Arrow();
			
			line = model1.AddLine((Shape) model1.Shapes["Shape8"],(Shape) model1.Shapes["Shape1"]);
			line.End.Marker = new Arrow();
			
			line = model1.AddLine((Shape) model1.Shapes["Shape10"],(Shape) model1.Shapes["Shape8"]);
			line.End.Marker = new Arrow();

			//Set layer opacity
			model1.Layers.CurrentLayer.Opacity = 50;
			model1.Refresh();

			//Add another layer and set it as current
			Layer layer = new Layer();
			model1.Layers.Add(layer);
			model1.Layers.CurrentLayer = layer;

			//Add some shapes to the new layer
			for(int i=1;i<=10;i++)
			{
				shape = new Shape();
				shape.Location = new PointF(i*50,((i%3) * 50)+200);
				shape.Width=10;
				shape.Height = 10;
				shape.Label = new Crainiate.ERM4.TextLabel();
				shape.Label.Text = i.ToString();

				model1.Shapes.Add(model1.Shapes.CreateKey(),shape);
			}
		}

		private void model1_ElementClick(object sender, System.EventArgs e)
		{
			//Check that the sender is shape
			if (sender is Shape)
			{
				Shape shape = (Shape) sender;
				
				//Create a navigate object and set the lines and shapes
				Navigate navigate = new Navigate();

				navigate.Lines = model1.Lines;
				navigate.Shapes = model1.Shapes;

				//Set the starting shape
				navigate.Start = shape;
				
				//Return all the children at any level for the shape clicked
				Elements elements = navigate.AllChildren();
	
				//Select all the children of the shape that was clicked
				foreach (Element element in elements.Values)
				{	
					if (element is ISelectable)
					{
						ISelectable selectable = (ISelectable) element;
						selectable.Selected = true;
					}
				}
			}
		}
	}
}
