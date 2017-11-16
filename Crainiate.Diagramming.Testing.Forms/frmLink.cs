using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Crainiate.Diagramming;
using Crainiate.Diagramming.Forms;

namespace Crainiate.Diagramming.Testing
{
    public partial class frmLink : Form
    {
        public frmLink()
        {
            InitializeComponent();

            Model model = diagram1.Model;
            diagram1.Paging.Enabled = false;
            diagram1.Model.SetSize(new Size(1000, 1000));
            

            Link link = new Link(new PointF(100, 100), new PointF(100, 200));

            model.Lines.Add(link);

            Shape shape = new Shape();
            shape.Location = new PointF(320, 320);
            shape.BorderColor = Color.Green;
            model.Shapes.Add(shape);

            Shape shape2 = new Shape();
            shape2.Location = new PointF(20, 20);
            shape2.BorderColor = Color.Blue;
            model.Shapes.Add(shape2);

            diagram1.Refresh();
        }
    }
}