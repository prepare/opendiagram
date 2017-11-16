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
    public partial class frmPalette : Form
    {
        public frmPalette()
        {
            InitializeComponent();

            palette1.AddStencil(Singleton.Instance.GetStencil(typeof(BasicStencil)));

            diagram1.ElementInserted += new Crainiate.Diagramming.Collections.ElementsEventHandler(diagram1_ElementInserted);
        }

        private void diagram1_ElementInserted(object sender, ElementsEventArgs e)
        {
            e.Value.ApplyTheme(Singleton.Instance.GetTheme(Themes.Green));
        }
    }
}