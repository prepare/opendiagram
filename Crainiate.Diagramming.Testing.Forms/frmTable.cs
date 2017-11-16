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
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();

            Model model = diagram1.Model;
            diagram1.Paging.Enabled = false;
            diagram1.Model.SetSize(new Size(1000, 1000));

            Table table = new Table();
            table.Location = new PointF(100, 100);

            TableGroup group = new TableGroup("Group 1");
            TableRow row = new TableRow("Group 1 Item");
            table.Rows.Add(new TableRow("Table row item"));

            group.Rows.Add(row);
            table.Groups.Add(group);

            TablePort tablePort = new TablePort(row);
            table.Ports.Add(tablePort);

            model.Shapes.Add(table);

            diagram1.Refresh();
        }
    }
}