using Crainiate.Diagramming;
using Crainiate.Diagramming.Forms;

namespace Crainiate.Diagramming.Testing
{
    partial class frmBlockLine
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
            this.model1 = new Crainiate.Diagramming.Forms.Diagram();
            this.SuspendLayout();
            // 
            // model1
            // 
            this.model1.AutoScroll = true;
            this.model1.AutoScrollMinSize = new System.Drawing.Size(540, 540);
            this.model1.BackColor = System.Drawing.SystemColors.Window;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.DragElement = null;
            this.model1.Feedback = true;
            this.model1.GridColor = System.Drawing.Color.Silver;
            this.model1.GridSize = new System.Drawing.Size(20, 20);
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.Name = "model1";
            this.model1.Size = new System.Drawing.Size(740, 551);
            this.model1.TabIndex = 0;
            this.model1.Zoom = 100F;
            // 
            // frmBlockLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 551);
            this.Controls.Add(this.model1);
            this.Name = "frmBlockLine";
            this.Text = "Block Line";
            this.ResumeLayout(false);

        }

        #endregion

        private Diagram model1;

    }
}

