using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Crainiate.Diagramming.Forms;

namespace Crainiate.Diagramming.Examples.Forms.Editor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadPalette();
            LoadChildForm();
            this.Size = new Size(900, 720);
            this.CenterToScreen();
        }

        //Loads the palette with the basic and flowchart stencils
        private void LoadPalette()
        {
            //Set default tab
            palette1.AllowDrop = true;
            palette1.AddStencil(Singleton.Instance.GetStencil(typeof(BasicStencil)));
            palette1.Tabs.CurrentTab.Name = "Basic Shapes";

            //Add flowchart tab
            Tab tab = new Tab();
            tab.Name = "Flowchart";
            palette1.Tabs.Add(tab);
            palette1.Tabs.CurrentTab = palette1.Tabs[1] as Tab;

            palette1.AddStencil(Singleton.Instance.GetStencil(typeof(Flowcharting.FlowchartStencil)));

            //Set first tab as default
            palette1.Tabs.CurrentTab = palette1.Tabs[0] as Tab;
            palette1.Refresh();
        }

        //Loads a new child Form and configues it to be displayed correctly
        private frmDiagram LoadChildForm()
        {
            frmDiagram form = new frmDiagram();

            //Set child form properties
            form.MdiParent = this;
            form.Text = "";
            form.WindowState = FormWindowState.Normal;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ControlBox = false;
            form.ShowInTaskbar = false;
            form.Dock = DockStyle.Fill;

            form.Show();

            return form;
        }
    }
}
