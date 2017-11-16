using Crainiate.Diagramming;
using Crainiate.Diagramming.Forms;

namespace Crainiate.Diagramming.Testing
{
    partial class frmConnector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diagram1 = new Crainiate.Diagramming.Forms.Diagram();
            this.SuspendLayout();
            // 
            // model1
            // 
            this.diagram1.AutoScroll = true;
            this.diagram1.AutoScrollMinSize = new System.Drawing.Size(540, 540);
            this.diagram1.BackColor = System.Drawing.SystemColors.Window;
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.DragElement = null;
            this.diagram1.Feedback = false;
            this.diagram1.GridSize = new System.Drawing.Size(20, 20);
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Name = "model1";
            this.diagram1.Size = new System.Drawing.Size(740, 551);
            this.diagram1.TabIndex = 0;
            this.diagram1.Zoom = 100F;
            // 
            // frmConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 551);
            this.Controls.Add(this.diagram1);
            this.Name = "frmConnector";
            this.Text = "Connector Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Diagram diagram1;

    }
}

