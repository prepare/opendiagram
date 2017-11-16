using Crainiate.Diagramming;
using Crainiate.Diagramming.Forms;

namespace Crainiate.Diagramming.Testing
{
    partial class frmPalette
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
            Crainiate.Diagramming.Forms.Paging paging1 = new Crainiate.Diagramming.Forms.Paging();
            Crainiate.Diagramming.Forms.Margin margin1 = new Crainiate.Diagramming.Forms.Margin();
            Crainiate.Diagramming.Forms.Paging paging2 = new Crainiate.Diagramming.Forms.Paging();
            Crainiate.Diagramming.Forms.Margin margin2 = new Crainiate.Diagramming.Forms.Margin();
            this.palette1 = new Crainiate.Diagramming.Forms.Palette();
            this.diagram1 = new Crainiate.Diagramming.Forms.Diagram();
            this.SuspendLayout();
            // 
            // palette1
            // 
            this.palette1.AllowDrop = true;
            this.palette1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.palette1.BackColor = System.Drawing.SystemColors.Control;
            this.palette1.BorderColor = System.Drawing.Color.Black;
            this.palette1.Dock = System.Windows.Forms.DockStyle.Left;
            this.palette1.DragElement = null;
            this.palette1.DragSelect = false;
            this.palette1.DrawGrid = false;
            this.palette1.DrawSelections = false;
            this.palette1.FillColor = System.Drawing.Color.White;
            this.palette1.ForeColor = System.Drawing.Color.Black;
            this.palette1.GradientColor = System.Drawing.SystemColors.Control;
            this.palette1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.palette1.GridSize = new System.Drawing.Size(20, 20);
            this.palette1.ItemSize = new System.Drawing.Size(18, 18);
            this.palette1.Location = new System.Drawing.Point(0, 0);
            this.palette1.Name = "palette1";
            paging1.Enabled = true;
            margin1.Bottom = 0F;
            margin1.Left = 0F;
            margin1.Right = 0F;
            margin1.Top = 0F;
            paging1.Margin = margin1;
            paging1.Padding = new System.Drawing.SizeF(40F, 40F);
            paging1.Page = 1;
            paging1.PageSize = new System.Drawing.SizeF(793.7008F, 1122.52F);
            paging1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
            this.palette1.Paging = paging1;
            this.palette1.Size = new System.Drawing.Size(188, 551);
            this.palette1.Spacing = new System.Drawing.Size(20, 22);
            this.palette1.TabIndex = 0;
            this.palette1.Zoom = 100F;
            // 
            // diagram1
            // 
            this.diagram1.AllowDrop = true;
            this.diagram1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.DragElement = null;
            this.diagram1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.diagram1.GridSize = new System.Drawing.Size(20, 20);
            this.diagram1.Location = new System.Drawing.Point(188, 0);
            this.diagram1.Name = "diagram1";
            paging2.Enabled = true;
            margin2.Bottom = 0F;
            margin2.Left = 0F;
            margin2.Right = 0F;
            margin2.Top = 0F;
            paging2.Margin = margin2;
            paging2.Padding = new System.Drawing.SizeF(40F, 40F);
            paging2.Page = 1;
            paging2.PageSize = new System.Drawing.SizeF(793.7008F, 1122.52F);
            paging2.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
            this.diagram1.Paging = paging2;
            this.diagram1.Size = new System.Drawing.Size(552, 551);
            this.diagram1.TabIndex = 1;
            this.diagram1.Zoom = 100F;
            // 
            // frmPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 551);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.palette1);
            this.Name = "frmPalette";
            this.Text = "Palette Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Palette palette1;
        private Diagram diagram1;



    }
}

