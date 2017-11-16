#define DEBUG

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Crainiate.Diagramming;
using Crainiate.Diagramming.Editing;

namespace Crainiate.Diagramming.Examples
{
	public class frmDiagram : System.Windows.Forms.Form
	{
		//Property variables
		private string mTitle;
		private string mPath;
		private Crainiate.Diagramming.Model model1;
		private Crainiate.Diagramming.Editing.Ruler ruler1;
		private Crainiate.Diagramming.Editing.Ruler ruler2;
		private System.ComponentModel.Container components = null;

		public frmDiagram()
		{
			InitializeComponent();
			DocumentTitle = "";
			Path = "";
			AllowDrop = true;
			ruler1.Diagram = model1;
			ruler2.Diagram = model1;
			
			model1.Zoom = 100;
			model1.Margin = new Margin(20,20,20,20);

			model1.AlignGrid = false;
			model1.CheckBounds = true;
			model1.DrawGrid = true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDiagram));
			this.model1 = new Crainiate.Diagramming.Model();
			this.ruler1 = new Crainiate.Diagramming.Editing.Ruler();
			this.ruler2 = new Crainiate.Diagramming.Editing.Ruler();
			this.SuspendLayout();
			// 
			// model1
			// 
			this.model1.AllowDrop = true;
			this.model1.AutoScroll = true;
			this.model1.AutoScrollMinSize = new System.Drawing.Size(785, 604);
			this.model1.DiagramSize = new System.Drawing.Size(745, 564);
			this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.model1.DragElement = null;
			this.model1.GridColor = System.Drawing.Color.Silver;
			this.model1.GridSize = new System.Drawing.Size(20, 20);
			this.model1.Location = new System.Drawing.Point(20, 18);
			this.model1.Name = "model1";
			this.model1.Paged = true;
			this.model1.PageLineSize = ((System.Drawing.SizeF)(resources.GetObject("model1.PageLineSize")));
			this.model1.Size = new System.Drawing.Size(780, 582);
			this.model1.TabIndex = 0;
			this.model1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.model1.Zoom = 100F;
			// 
			// ruler1
			// 
			this.ruler1.BorderStyle = Editing.RulerBorderStyle.Edge;
			this.ruler1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ruler1.GradientColor = System.Drawing.SystemColors.Control;
			this.ruler1.Location = new System.Drawing.Point(0, 0);
			this.ruler1.Major = 100F;
			this.ruler1.Mid = 50F;
			this.ruler1.Minor = 10F;
			this.ruler1.Name = "ruler1";
			this.ruler1.Padding = 20F;
			this.ruler1.Size = new System.Drawing.Size(800, 18);
			this.ruler1.Start = 0F;
			this.ruler1.TabIndex = 1;
			this.ruler1.Text = "ruler1";
			// 
			// ruler2
			// 
			this.ruler2.BorderStyle = Editing.RulerBorderStyle.Edge;
			this.ruler2.Dock = System.Windows.Forms.DockStyle.Left;
			this.ruler2.GradientColor = System.Drawing.SystemColors.Control;
			this.ruler2.Location = new System.Drawing.Point(0, 18);
			this.ruler2.Major = 100F;
			this.ruler2.Mid = 50F;
			this.ruler2.Minor = 10F;
			this.ruler2.Name = "ruler2";
			this.ruler2.Orientation = Editing.RulerOrientation.Left;
			this.ruler2.Size = new System.Drawing.Size(20, 582);
			this.ruler2.Start = 0F;
			this.ruler2.TabIndex = 2;
			this.ruler2.Text = "ruler2";
			// 
			// frmDiagram
			// 
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.ControlBox = false;
			this.Controls.Add(this.model1);
			this.Controls.Add(this.ruler2);
			this.Controls.Add(this.ruler1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDiagram";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmDiagram_Load);
			this.ResumeLayout(false);

		}
		#endregion

		//Properties
		public virtual string DocumentTitle
		{
			get
			{
				return mTitle;
			}
			set
			{
				mTitle = value;
			}
		}

		//Returns in the path
		public string Path
		{
			get
			{
				return mPath;
			}
			set
			{
				mPath = value;
			}
		}

		public virtual Model Model
		{
			get
			{	
				return model1;
			}
		}

		public virtual bool Open(string path)
		{
			if (path == "")
			{
				OpenFileDialog openDialog = new OpenFileDialog();

				openDialog.InitialDirectory = Application.StartupPath;
				openDialog.Filter = "Diagram files (*.dgm)|*.dgm|Diagram files (xml) (*.dgmx)|*.dgmx|All files (*.*)|*.*";
				openDialog.FilterIndex = 2;

				if (! (openDialog.ShowDialog() == DialogResult.OK))
				{
					return false;
				}

				path = openDialog.FileName;
				this.Path = openDialog.FileName;
				this.DocumentTitle = System.IO.Path.GetFileName(openDialog.FileName);
			}

			//Determine the extension so can be laoded in correct format
			string ext = System.IO.Path.GetExtension(path);

			switch (ext)
			{
				case ".dgmx":
					model1.Open(path,LoadFormat.Xml);
					break;
				case ".xml":
					model1.Open(path,LoadFormat.Xml);
					break;
				default:
					model1.Open(path);
					break;
			}

			return true;
		}

		//Save the file with the given path, requesting a path if required
		public virtual bool Save(string path)
		{
			if (path == "")
			{
				SaveFileDialog saveDialog = new SaveFileDialog();

				saveDialog.InitialDirectory = Application.StartupPath;
				saveDialog.FileName = this.DocumentTitle;
				saveDialog.AddExtension = true;
				saveDialog.Filter = "Diagram files (*.dgm)|*.dgm|Diagram files (xml) (*.dgmx)|*.dgmx|Svg files (*.svg)|*.svg|Metafile (*.emf)|*.emf|Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|Jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
				saveDialog.FilterIndex = 2;
				saveDialog.DefaultExt = "dgmx";

				if (saveDialog.ShowDialog() != DialogResult.OK) return false;

				this.DocumentTitle = System.IO.Path.GetFileName(saveDialog.FileName);
				this.Path = saveDialog.FileName;
				path = saveDialog.FileName;
			}

			//Determine the extension so can be saved in different formatds
			string ext = System.IO.Path.GetExtension(path);

			switch (ext)
			{
				case ".svg":
					model1.Save(path,SaveFormat.Svg);
					break;
				case ".emf":
					model1.Save(path,SaveFormat.Metafile);
					break;
				case ".bmp":
					model1.Save(path,SaveFormat.Bmp);
					break;
				case ".gif":
					model1.Save(path,SaveFormat.Gif);
					break;
				case ".jpg":
					model1.Save(path,SaveFormat.Jpeg);
					break;
				case ".png":
					model1.Save(path,SaveFormat.Png);
					break;
				case ".dgmx":
					model1.Save(path,SaveFormat.Xml);
					break;
				case ".xml":
					model1.Save(path,SaveFormat.Xml);
					break;
				default:
					model1.Save(path);
					break;
			}

			return true;
		}

		//Calculate zoom best fit
		public void ZoomBestFit()
		{
			//Get width of control, less PagedMargin divided by diagram size as a percent
			float sx = (model1.Width - Component.Instance.PagePadding.Width) / model1.DiagramSize.Width;
			float sy = (model1.Height - Component.Instance.PagePadding.Height) / model1.DiagramSize.Height;
				
			//Convert to whole percentage
			sx = Convert.ToSingle(Math.Round(sx * 100,0));
			sy = Convert.ToSingle(Math.Round(sy * 100,0));

			//Select zoom
			float zoom = (sx < sy) ?  sx : sy;
				
			if (zoom > 100) zoom = 100;
				
			model1.Zoom = zoom;
		}

		//Methods
		//Adds a line at the diagram point specified
		public virtual void AddLine(PointF point)
		{
			PointF start = new PointF(point.X - 50,point.Y - 50);
			PointF end = new PointF(point.X + 50,point.Y + 50);				
			
			Line line = new Line(start,end);
			model1.Lines.Add(model1.Lines.CreateKey(),line);
		}

		//Adds a connector at the diagram point specified
		public virtual void AddConnector(PointF point)
		{
			PointF start = new PointF(point.X - 50,point.Y - 50);
			PointF end = new PointF(point.X + 50,point.Y + 50);				
			
			Connector connector = new Connector(start,end);
			model1.Lines.Add(model1.Lines.CreateKey(),connector);
		}

		//Adds a connector at the diagram point specified
		public virtual void AddGroup(PointF point)
		{
			PointF location = new PointF(point.X - 200,point.Y - 200);
			SizeF size = new SizeF(400,400);
			
			if (location.X < 0) location.X = 0;
			if (location.Y < 0) location.Y = 0;

			Group group = new Group();

			group.Location = location;
			group.Size = size;
			
			model1.Shapes.Add(model1.Shapes.CreateKey(),group);
		}

		private void frmDiagram_Load(object sender, System.EventArgs e)
		{
			model1.UndoList.Resume();
		}
	}
}
