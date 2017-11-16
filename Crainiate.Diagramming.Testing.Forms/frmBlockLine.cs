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
    public partial class frmBlockLine : Form
    {
        public frmBlockLine()
        {
            InitializeComponent();

            Model model = model1.Model;

            BlockLine blockLine = new BlockLine();

            blockLine.Start.Location  = new PointF(100, 100);
            blockLine.End.Location = new PointF(200, 200);

            model.Lines.Add(blockLine);

            Shape shape = new Shape();
            shape.Location = new PointF(320, 320);
            shape.BorderColor = Color.Green;
            model.Shapes.Add(shape);

            Shape shape2 = new Shape();
            shape2.Location = new PointF(20, 20);
            shape2.BorderColor = Color.Blue;
            model.Shapes.Add(shape2);

            
        }
    }
}