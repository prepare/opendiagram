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
    public partial class frmConnector : Form
    {
        public frmConnector()
        {
            InitializeComponent();

            Model model = diagram1.Model;

            Shape shape = new Shape();
            shape.Location = new PointF(170, 80);
            model.Shapes.Add(shape);

            shape = new Shape();
            shape.Location = new PointF(300, 300);
            model.Shapes.Add(shape);

            shape = new Shape();
            shape.Location = new PointF(500, 500);
            model.Shapes.Add(shape);

            shape = new Shape();
            shape.Location = new PointF(400, 400);
            model.Shapes.Add(shape);

            shape = new Shape();
            shape.AllowRotate = true;
            shape.Location = new PointF(100, 100);
            model.Shapes.Add(shape);

            Connector connector = new Connector();
            connector.Start.Location = new PointF(20, 20);
            connector.End.Location = new PointF(440, 330); //300,140
            connector.Avoid = true;
            connector.End.Marker = new Arrow();
            connector.Start.Marker = new Marker(MarkerStyle.Ellipse);

            model.Lines.Add(connector);

            model.ApplyTheme(Themes.LightBlue);
        }
    }
}