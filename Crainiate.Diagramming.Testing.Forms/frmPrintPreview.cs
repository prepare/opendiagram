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
    public partial class frmPrintPreview : Form
    {
        public frmPrintPreview()
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

            model.ApplyTheme(Themes.Orange);

            foreach (Shape item in model.Shapes.Values)
            {
                item.Width = 60;
            }

            Crainiate.Diagramming.Printing.PrintDocument MyDocument = new Crainiate.Diagramming.Printing.PrintDocument(diagram1);
            MyDocument.View = diagram1;
            MyDocument.PrintPreview();
        }
    }
}