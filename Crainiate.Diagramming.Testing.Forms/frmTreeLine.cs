using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Crainiate.Diagramming;
using Crainiate.Diagramming.Forms;

namespace Crainiate.Diagramming.Testing
{
    public partial class frmTreeLine : Form
    {
        public frmTreeLine()
        {
            InitializeComponent();

            Model model = diagram1.Model;
            diagram1.Model.SetSize(new Size(1000, 1000));

            Shape shape = new Shape();
            shape.Location = new PointF(300, 50);
            model.Shapes.Add("a1", shape);

            shape = new Shape();
            shape.Location = new PointF(200, 200);
            model.Shapes.Add("b1", shape);

            shape = new Shape();
            shape.Location = new PointF(400, 200);
            model.Shapes.Add("b2", shape);

            shape = new Shape();
            shape.Location = new PointF(100, 300);
            model.Shapes.Add("c1", shape);

            shape = new Shape();
            shape.Location = new PointF(200, 300);
            model.Shapes.Add("c2", shape);

            shape = new Shape();
            shape.Location = new PointF(300, 300);
            model.Shapes.Add("c3", shape);

            shape = new Shape();
            shape.Location = new PointF(400, 300);
            model.Shapes.Add("c4", shape);

            shape = new Shape();
            shape.Location = new PointF(500, 300);
            model.Shapes.Add("c5", shape);

            //Add tree lines
            Link line = new Link();
            
            TreeLine treeLine = new TreeLine();
            treeLine.AddStart(model.Shapes["a1"]);
            treeLine.AddEnd(model.Shapes["b1"]);
            treeLine.AddEnd(model.Shapes["b2"]);

            model.Lines.Add(treeLine);

            treeLine = new TreeLine();
            treeLine.AddStart(model.Shapes["b1"]);

            treeLine.AddEnd(model.Shapes["c1"]);
            treeLine.AddEnd(model.Shapes["c2"]);
            treeLine.AddEnd(model.Shapes["c3"]);

            model.Lines.Add(treeLine);

            treeLine = new TreeLine();
            treeLine.AddStart(model.Shapes["b2"]);

            treeLine.AddEnd(model.Shapes["c4"]);
            treeLine.AddEnd(model.Shapes["c5"]);

            model.Lines.Add(treeLine);

            model.ApplyTheme(Themes.LightBlue);

            foreach (Shape item in model.Shapes.Values)
            {
                item.Width = 60;
            }
        }
    }
}