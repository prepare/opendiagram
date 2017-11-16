namespace Crainiate.Diagramming.Examples.Forms.Editor
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Crainiate.Diagramming.Forms.Paging paging1 = new Crainiate.Diagramming.Forms.Paging();
            Crainiate.Diagramming.Forms.Margin margin1 = new Crainiate.Diagramming.Forms.Margin();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileNew = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.mnuFileSave = new System.Windows.Forms.MenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnuFilePrint = new System.Windows.Forms.MenuItem();
            this.mnuFilePrintPreview = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuEditUndo = new System.Windows.Forms.MenuItem();
            this.mnuEditRedo = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.mnuEditCut = new System.Windows.Forms.MenuItem();
            this.mnuEditCopy = new System.Windows.Forms.MenuItem();
            this.mnuEditPaste = new System.Windows.Forms.MenuItem();
            this.mnuEditDelete = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.mnuEditSelectAll = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuLayers = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuZoom = new System.Windows.Forms.MenuItem();
            this.mnuZoom50 = new System.Windows.Forms.MenuItem();
            this.mnuZoom75 = new System.Windows.Forms.MenuItem();
            this.mnuZoom100 = new System.Windows.Forms.MenuItem();
            this.mnuZoom200 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.mnuZoomBestFit = new System.Windows.Forms.MenuItem();
            this.mnuTools = new System.Windows.Forms.MenuItem();
            this.mnuAddLine = new System.Windows.Forms.MenuItem();
            this.mnuAddConnector = new System.Windows.Forms.MenuItem();
            this.mnuAddGroup = new System.Windows.Forms.MenuItem();
            this.mnuAddLayer = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuToolsOptions = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            this.ilStandard = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.btnNew = new System.Windows.Forms.ToolBarButton();
            this.btnOpen = new System.Windows.Forms.ToolBarButton();
            this.btnSave = new System.Windows.Forms.ToolBarButton();
            this.sep1 = new System.Windows.Forms.ToolBarButton();
            this.btnPrint = new System.Windows.Forms.ToolBarButton();
            this.sep2 = new System.Windows.Forms.ToolBarButton();
            this.btnCut = new System.Windows.Forms.ToolBarButton();
            this.btnCopy = new System.Windows.Forms.ToolBarButton();
            this.btnPaste = new System.Windows.Forms.ToolBarButton();
            this.sep3 = new System.Windows.Forms.ToolBarButton();
            this.btnUndo = new System.Windows.Forms.ToolBarButton();
            this.btnRedo = new System.Windows.Forms.ToolBarButton();
            this.sep4 = new System.Windows.Forms.ToolBarButton();
            this.btnNormal = new System.Windows.Forms.ToolBarButton();
            this.btnAddLine = new System.Windows.Forms.ToolBarButton();
            this.btnAddConnector = new System.Windows.Forms.ToolBarButton();
            this.btnAddComplex = new System.Windows.Forms.ToolBarButton();
            this.palette1 = new Crainiate.Diagramming.Forms.Palette();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuTools,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.menuItem8,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.menuItem9,
            this.mnuFilePrint,
            this.mnuFilePrintPreview,
            this.menuItem10,
            this.mnuFileExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Index = 0;
            this.mnuFileNew.Text = "&New";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Index = 1;
            this.mnuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuFileOpen.Text = "&Open ...";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Index = 3;
            this.mnuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuFileSave.Text = "&Save";
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Index = 4;
            this.mnuFileSaveAs.Text = "Save &As";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 5;
            this.menuItem9.Text = "-";
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Index = 6;
            this.mnuFilePrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.mnuFilePrint.Text = "&Print";
            // 
            // mnuFilePrintPreview
            // 
            this.mnuFilePrintPreview.Index = 7;
            this.mnuFilePrintPreview.Text = "Print Pre&view ...";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 8;
            this.menuItem10.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 9;
            this.mnuFileExit.Text = "E&xit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditUndo,
            this.mnuEditRedo,
            this.menuItem14,
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.mnuEditDelete,
            this.menuItem19,
            this.mnuEditSelectAll});
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditUndo
            // 
            this.mnuEditUndo.Index = 0;
            this.mnuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.mnuEditUndo.Text = "&Undo";
            // 
            // mnuEditRedo
            // 
            this.mnuEditRedo.Index = 1;
            this.mnuEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.mnuEditRedo.Text = "&Redo";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "-";
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.Index = 3;
            this.mnuEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mnuEditCut.Text = "C&ut";
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Index = 4;
            this.mnuEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuEditCopy.Text = "&Copy";
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Index = 5;
            this.mnuEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.mnuEditPaste.Text = "&Paste";
            // 
            // mnuEditDelete
            // 
            this.mnuEditDelete.Index = 6;
            this.mnuEditDelete.Text = "&Delete";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 7;
            this.menuItem19.Text = "-";
            // 
            // mnuEditSelectAll
            // 
            this.mnuEditSelectAll.Index = 8;
            this.mnuEditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.mnuEditSelectAll.Text = "Select &All";
            // 
            // mnuView
            // 
            this.mnuView.Index = 2;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuLayers,
            this.menuItem5,
            this.mnuZoom});
            this.mnuView.Text = "&View";
            // 
            // mnuLayers
            // 
            this.mnuLayers.Index = 0;
            this.mnuLayers.Text = "Layers";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // mnuZoom
            // 
            this.mnuZoom.Index = 2;
            this.mnuZoom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuZoom50,
            this.mnuZoom75,
            this.mnuZoom100,
            this.mnuZoom200,
            this.menuItem15,
            this.mnuZoomBestFit});
            this.mnuZoom.Text = "Zoom";
            // 
            // mnuZoom50
            // 
            this.mnuZoom50.Index = 0;
            this.mnuZoom50.Text = "50%";
            // 
            // mnuZoom75
            // 
            this.mnuZoom75.Index = 1;
            this.mnuZoom75.Text = "75%";
            // 
            // mnuZoom100
            // 
            this.mnuZoom100.Index = 2;
            this.mnuZoom100.Text = "100%";
            // 
            // mnuZoom200
            // 
            this.mnuZoom200.Index = 3;
            this.mnuZoom200.Text = "200%";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 4;
            this.menuItem15.Text = "-";
            // 
            // mnuZoomBestFit
            // 
            this.mnuZoomBestFit.Index = 5;
            this.mnuZoomBestFit.Text = "Best Fit";
            // 
            // mnuTools
            // 
            this.mnuTools.Index = 3;
            this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAddLine,
            this.mnuAddConnector,
            this.mnuAddGroup,
            this.mnuAddLayer,
            this.menuItem2,
            this.mnuToolsOptions});
            this.mnuTools.Text = "&Tools";
            // 
            // mnuAddLine
            // 
            this.mnuAddLine.Index = 0;
            this.mnuAddLine.Text = "Add Line";
            // 
            // mnuAddConnector
            // 
            this.mnuAddConnector.Index = 1;
            this.mnuAddConnector.Text = "Add Connector";
            // 
            // mnuAddGroup
            // 
            this.mnuAddGroup.Index = 2;
            this.mnuAddGroup.Text = "Add Group";
            // 
            // mnuAddLayer
            // 
            this.mnuAddLayer.Index = 3;
            this.mnuAddLayer.Text = "Add Layer";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.Text = "-";
            // 
            // mnuToolsOptions
            // 
            this.mnuToolsOptions.Index = 5;
            this.mnuToolsOptions.Text = "Options ...";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 4;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Index = 0;
            this.mnuHelpAbout.Text = "About Editor";
            // 
            // ilStandard
            // 
            this.ilStandard.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStandard.ImageStream")));
            this.ilStandard.TransparentColor = System.Drawing.Color.Silver;
            this.ilStandard.Images.SetKeyName(0, "");
            this.ilStandard.Images.SetKeyName(1, "");
            this.ilStandard.Images.SetKeyName(2, "");
            this.ilStandard.Images.SetKeyName(3, "");
            this.ilStandard.Images.SetKeyName(4, "");
            this.ilStandard.Images.SetKeyName(5, "");
            this.ilStandard.Images.SetKeyName(6, "");
            this.ilStandard.Images.SetKeyName(7, "");
            this.ilStandard.Images.SetKeyName(8, "");
            this.ilStandard.Images.SetKeyName(9, "");
            this.ilStandard.Images.SetKeyName(10, "");
            this.ilStandard.Images.SetKeyName(11, "");
            this.ilStandard.Images.SetKeyName(12, "");
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.sep1,
            this.btnPrint,
            this.sep2,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.sep3,
            this.btnUndo,
            this.btnRedo,
            this.sep4,
            this.btnNormal,
            this.btnAddLine,
            this.btnAddConnector,
            this.btnAddComplex});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.ilStandard;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(784, 28);
            this.toolBar1.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.ImageIndex = 0;
            this.btnNew.Name = "btnNew";
            // 
            // btnOpen
            // 
            this.btnOpen.ImageIndex = 1;
            this.btnOpen.Name = "btnOpen";
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 2;
            this.btnSave.Name = "btnSave";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnPrint
            // 
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.Name = "btnPrint";
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnCut
            // 
            this.btnCut.ImageIndex = 4;
            this.btnCut.Name = "btnCut";
            // 
            // btnCopy
            // 
            this.btnCopy.ImageIndex = 5;
            this.btnCopy.Name = "btnCopy";
            // 
            // btnPaste
            // 
            this.btnPaste.ImageIndex = 6;
            this.btnPaste.Name = "btnPaste";
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnUndo
            // 
            this.btnUndo.ImageIndex = 7;
            this.btnUndo.Name = "btnUndo";
            // 
            // btnRedo
            // 
            this.btnRedo.ImageIndex = 8;
            this.btnRedo.Name = "btnRedo";
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnNormal
            // 
            this.btnNormal.ImageIndex = 11;
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // btnAddLine
            // 
            this.btnAddLine.ImageIndex = 9;
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // btnAddConnector
            // 
            this.btnAddConnector.ImageIndex = 10;
            this.btnAddConnector.Name = "btnAddConnector";
            this.btnAddConnector.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // btnAddComplex
            // 
            this.btnAddComplex.ImageIndex = 12;
            this.btnAddComplex.Name = "btnAddComplex";
            this.btnAddComplex.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // palette1
            // 
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
            this.palette1.Location = new System.Drawing.Point(0, 28);
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
            this.palette1.Size = new System.Drawing.Size(195, 492);
            this.palette1.Spacing = new System.Drawing.Size(20, 22);
            this.palette1.TabIndex = 3;
            this.palette1.Zoom = 100F;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(195, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 492);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.palette1);
            this.Controls.Add(this.toolBar1);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Editor Example";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuFileNew;
        private System.Windows.Forms.MenuItem mnuFileOpen;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem mnuFileSave;
        private System.Windows.Forms.MenuItem mnuFileSaveAs;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem mnuFilePrint;
        private System.Windows.Forms.MenuItem mnuFilePrintPreview;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem mnuFileExit;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuEditUndo;
        private System.Windows.Forms.MenuItem mnuEditRedo;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem mnuEditCut;
        private System.Windows.Forms.MenuItem mnuEditCopy;
        private System.Windows.Forms.MenuItem mnuEditPaste;
        private System.Windows.Forms.MenuItem mnuEditDelete;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem mnuEditSelectAll;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.MenuItem mnuLayers;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem mnuZoom;
        private System.Windows.Forms.MenuItem mnuZoom50;
        private System.Windows.Forms.MenuItem mnuZoom75;
        private System.Windows.Forms.MenuItem mnuZoom100;
        private System.Windows.Forms.MenuItem mnuZoom200;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem mnuZoomBestFit;
        private System.Windows.Forms.MenuItem mnuTools;
        private System.Windows.Forms.MenuItem mnuAddLine;
        private System.Windows.Forms.MenuItem mnuAddConnector;
        private System.Windows.Forms.MenuItem mnuAddGroup;
        private System.Windows.Forms.MenuItem mnuAddLayer;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnuToolsOptions;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuHelpAbout;
        internal System.Windows.Forms.ImageList ilStandard;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton btnNew;
        private System.Windows.Forms.ToolBarButton btnOpen;
        private System.Windows.Forms.ToolBarButton btnSave;
        private System.Windows.Forms.ToolBarButton sep1;
        private System.Windows.Forms.ToolBarButton btnPrint;
        private System.Windows.Forms.ToolBarButton sep2;
        private System.Windows.Forms.ToolBarButton btnCut;
        private System.Windows.Forms.ToolBarButton btnCopy;
        private System.Windows.Forms.ToolBarButton btnPaste;
        private System.Windows.Forms.ToolBarButton sep3;
        private System.Windows.Forms.ToolBarButton btnUndo;
        private System.Windows.Forms.ToolBarButton btnRedo;
        private System.Windows.Forms.ToolBarButton sep4;
        private System.Windows.Forms.ToolBarButton btnNormal;
        private System.Windows.Forms.ToolBarButton btnAddLine;
        private System.Windows.Forms.ToolBarButton btnAddConnector;
        private System.Windows.Forms.ToolBarButton btnAddComplex;
        private Crainiate.Diagramming.Forms.Palette palette1;
        private System.Windows.Forms.Splitter splitter1;
    }
}