using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crainiate.Diagramming.Examples.Forms.Editor
{
    public partial class frmDiagram : Form
    {
        public frmDiagram()
        {
            InitializeComponent();

            DocumentTitle = "";
            Path = "";
            AllowDrop = true;

            diagram1.Zoom = 100;
        }

        //Properties
        public virtual string DocumentTitle {get; set;}
        public string Path {get; set;}

        public virtual Model Model
        {
            get
            {
                return diagram1.Model;
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

                if (!(openDialog.ShowDialog() == DialogResult.OK))
                {
                    return false;
                }

                path = openDialog.FileName;
                this.Path = openDialog.FileName;
                this.DocumentTitle = System.IO.Path.GetFileName(openDialog.FileName);
            }

            //Determine the extension so can be laoded in correct format
            string ext = System.IO.Path.GetExtension(path);

            //switch (ext)
            //{
            //    case ".dgmx":
            //        Model.Open(path, LoadFormat.Xml);
            //        break;
            //    case ".xml":
            //        diagram1.Open(path, LoadFormat.Xml);
            //        break;
            //    default:
            //        diagram1.Open(path);
            //        break;
            //}

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

            //switch (ext)
            //{
            //    case ".svg":
            //        diagram1.Save(path, SaveFormat.Svg);
            //        break;
            //    case ".emf":
            //        diagram1.Save(path, SaveFormat.Metafile);
            //        break;
            //    case ".bmp":
            //        diagram1.Save(path, SaveFormat.Bmp);
            //        break;
            //    case ".gif":
            //        diagram1.Save(path, SaveFormat.Gif);
            //        break;
            //    case ".jpg":
            //        diagram1.Save(path, SaveFormat.Jpeg);
            //        break;
            //    case ".png":
            //        diagram1.Save(path, SaveFormat.Png);
            //        break;
            //    case ".dgmx":
            //        diagram1.Save(path, SaveFormat.Xml);
            //        break;
            //    case ".xml":
            //        diagram1.Save(path, SaveFormat.Xml);
            //        break;
            //    default:
            //        diagram1.Save(path);
            //        break;
            //}

            return true;
        }

        //Methods
        //Adds a line at the diagram point specified
        public virtual void AddLink(PointF point)
        {
            PointF start = new PointF(point.X - 50, point.Y - 50);
            PointF end = new PointF(point.X + 50, point.Y + 50);

            Line line = new Link(start, end);
            Model.Lines.Add(Model.Lines.CreateKey(), line);
        }

        //Adds a connector at the diagram point specified
        public virtual void AddConnector(PointF point)
        {
            PointF start = new PointF(point.X - 50, point.Y - 50);
            PointF end = new PointF(point.X + 50, point.Y + 50);

            Connector connector = new Connector(start, end);
            Model.Lines.Add(Model.Lines.CreateKey(), connector);
        }

        //Adds a connector at the diagram point specified
        public virtual void AddGroup(PointF point)
        {
            PointF location = new PointF(point.X - 200, point.Y - 200);
            SizeF size = new SizeF(400, 400);

            if (location.X < 0) location.X = 0;
            if (location.Y < 0) location.Y = 0;

            Group group = new Group();

            group.Location = location;
            group.Size = size;

            Model.Shapes.Add(Model.Shapes.CreateKey(), group);
        }

    }
}
