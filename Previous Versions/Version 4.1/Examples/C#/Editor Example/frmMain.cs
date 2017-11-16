using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Crainiate.Diagramming;
using Crainiate.Diagramming.Editing;

namespace Crainiate.Diagramming.Examples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.ToolBar toolBar1;
		private Crainiate.Diagramming.Editing.Palette palette1;
		private System.Windows.Forms.Splitter splitter1;
		internal System.Windows.Forms.ImageList ilStandard;
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
		private System.Windows.Forms.ToolBarButton btnAddLine;
		private System.Windows.Forms.ToolBarButton btnAddConnector;
		private System.Windows.Forms.MenuItem mnuFileNew;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem mnuFileSave;
		private System.Windows.Forms.MenuItem mnuFileSaveAs;
		private System.Windows.Forms.MenuItem mnuFilePrint;
		private System.Windows.Forms.MenuItem mnuFilePrintPreview;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem mnuEdit;
		private System.Windows.Forms.MenuItem mnuEditUndo;
		private System.Windows.Forms.MenuItem mnuEditRedo;
		private System.Windows.Forms.MenuItem mnuEditCut;
		private System.Windows.Forms.MenuItem mnuEditCopy;
		private System.Windows.Forms.MenuItem mnuEditPaste;
		private System.Windows.Forms.MenuItem mnuEditDelete;
		private System.Windows.Forms.MenuItem mnuEditSelectAll;
		private System.Windows.Forms.MenuItem mnuView;
		private System.Windows.Forms.MenuItem mnuTools;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem mnuLayers;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnuZoom;
		private System.Windows.Forms.MenuItem mnuZoom50;
		private System.Windows.Forms.MenuItem mnuZoom75;
		private System.Windows.Forms.MenuItem mnuZoom100;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem mnuZoomBestFit;
		private System.Windows.Forms.MenuItem mnuAddLine;
		private System.Windows.Forms.MenuItem mnuAddConnector;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuAddLayer;
		private System.Windows.Forms.MenuItem mnuAddGroup;
		private System.Windows.Forms.MenuItem mnuToolsOptions;
		private System.Windows.Forms.MenuItem mnuHelpAbout;
		private System.Windows.Forms.MenuItem mnuZoom200;
		private System.Windows.Forms.ToolBarButton btnNormal;
		private System.Windows.Forms.ToolBarButton btnAddComplex;
		private System.ComponentModel.IContainer components;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
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
			this.btnAddLine = new System.Windows.Forms.ToolBarButton();
			this.btnAddConnector = new System.Windows.Forms.ToolBarButton();
			this.ilStandard = new System.Windows.Forms.ImageList(this.components);
			this.palette1 = new Crainiate.Diagramming.Editing.Palette();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.btnNormal = new System.Windows.Forms.ToolBarButton();
			this.btnAddComplex = new System.Windows.Forms.ToolBarButton();
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
			this.mnuFileNew.Click += new System.EventHandler(this.mnuFile_Click);
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Index = 1;
			this.mnuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.mnuFileOpen.Text = "&Open ...";
			this.mnuFileOpen.Click += new System.EventHandler(this.mnuFile_Click);
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
			this.mnuFileSave.Click += new System.EventHandler(this.mnuFile_Click);
			// 
			// mnuFileSaveAs
			// 
			this.mnuFileSaveAs.Index = 4;
			this.mnuFileSaveAs.Text = "Save &As";
			this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFile_Click);
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
			this.mnuFilePrint.Click += new System.EventHandler(this.mnuFile_Click);
			// 
			// mnuFilePrintPreview
			// 
			this.mnuFilePrintPreview.Index = 7;
			this.mnuFilePrintPreview.Text = "Print Pre&view ...";
			this.mnuFilePrintPreview.Click += new System.EventHandler(this.mnuFile_Click);
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
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFile_Click);
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
			this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuEditUndo
			// 
			this.mnuEditUndo.Index = 0;
			this.mnuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.mnuEditUndo.Text = "&Undo";
			this.mnuEditUndo.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuEditRedo
			// 
			this.mnuEditRedo.Index = 1;
			this.mnuEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
			this.mnuEditRedo.Text = "&Redo";
			this.mnuEditRedo.Click += new System.EventHandler(this.mnuEdit_Click);
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
			this.mnuEditCut.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuEditCopy
			// 
			this.mnuEditCopy.Index = 4;
			this.mnuEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.mnuEditCopy.Text = "&Copy";
			this.mnuEditCopy.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuEditPaste
			// 
			this.mnuEditPaste.Index = 5;
			this.mnuEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.mnuEditPaste.Text = "&Paste";
			this.mnuEditPaste.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuEditDelete
			// 
			this.mnuEditDelete.Index = 6;
			this.mnuEditDelete.Text = "&Delete";
			this.mnuEditDelete.Click += new System.EventHandler(this.mnuEdit_Click);
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
			this.mnuEditSelectAll.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuView
			// 
			this.mnuView.Index = 2;
			this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuLayers,
																					this.menuItem5,
																					this.mnuZoom});
			this.mnuView.Text = "&View";
			this.mnuView.Popup += new System.EventHandler(this.mnuView_Popup);
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
			this.mnuZoom.Click += new System.EventHandler(this.mnuZoom_Click);
			// 
			// mnuZoom50
			// 
			this.mnuZoom50.Index = 0;
			this.mnuZoom50.Text = "50%";
			this.mnuZoom50.Click += new System.EventHandler(this.mnuZoom_Click);
			// 
			// mnuZoom75
			// 
			this.mnuZoom75.Index = 1;
			this.mnuZoom75.Text = "75%";
			this.mnuZoom75.Click += new System.EventHandler(this.mnuZoom_Click);
			// 
			// mnuZoom100
			// 
			this.mnuZoom100.Index = 2;
			this.mnuZoom100.Text = "100%";
			this.mnuZoom100.Click += new System.EventHandler(this.mnuZoom_Click);
			// 
			// mnuZoom200
			// 
			this.mnuZoom200.Index = 3;
			this.mnuZoom200.Text = "200%";
			this.mnuZoom200.Click += new System.EventHandler(this.mnuZoom_Click);
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
			this.mnuZoomBestFit.Click += new System.EventHandler(this.mnuZoom_Click);
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
			this.mnuAddLine.Click += new System.EventHandler(this.mnuTools_Click);
			// 
			// mnuAddConnector
			// 
			this.mnuAddConnector.Index = 1;
			this.mnuAddConnector.Text = "Add Connector";
			this.mnuAddConnector.Click += new System.EventHandler(this.mnuTools_Click);
			// 
			// mnuAddGroup
			// 
			this.mnuAddGroup.Index = 2;
			this.mnuAddGroup.Text = "Add Group";
			this.mnuAddGroup.Click += new System.EventHandler(this.mnuTools_Click);
			// 
			// mnuAddLayer
			// 
			this.mnuAddLayer.Index = 3;
			this.mnuAddLayer.Text = "Add Layer";
			this.mnuAddLayer.Click += new System.EventHandler(this.mnuTools_Click);
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
			this.mnuToolsOptions.Click += new System.EventHandler(this.mnuTools_Click);
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
			this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
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
			this.toolBar1.Size = new System.Drawing.Size(892, 28);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// btnNew
			// 
			this.btnNew.ImageIndex = 0;
			// 
			// btnOpen
			// 
			this.btnOpen.ImageIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.ImageIndex = 2;
			// 
			// sep1
			// 
			this.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnPrint
			// 
			this.btnPrint.ImageIndex = 3;
			// 
			// sep2
			// 
			this.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnCut
			// 
			this.btnCut.ImageIndex = 4;
			// 
			// btnCopy
			// 
			this.btnCopy.ImageIndex = 5;
			// 
			// btnPaste
			// 
			this.btnPaste.ImageIndex = 6;
			// 
			// sep3
			// 
			this.sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnUndo
			// 
			this.btnUndo.ImageIndex = 7;
			// 
			// btnRedo
			// 
			this.btnRedo.ImageIndex = 8;
			// 
			// sep4
			// 
			this.sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnAddLine
			// 
			this.btnAddLine.ImageIndex = 9;
			this.btnAddLine.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			// 
			// btnAddConnector
			// 
			this.btnAddConnector.ImageIndex = 10;
			this.btnAddConnector.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			// 
			// ilStandard
			// 
			this.ilStandard.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilStandard.ImageSize = new System.Drawing.Size(16, 16);
			this.ilStandard.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStandard.ImageStream")));
			this.ilStandard.TransparentColor = System.Drawing.Color.Silver;
			// 
			// palette1
			// 
			this.palette1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.palette1.BackColor = System.Drawing.SystemColors.Control;
			this.palette1.BorderColor = System.Drawing.Color.Black;
			this.palette1.DiagramSize = new System.Drawing.Size(189, 679);
			this.palette1.Dock = System.Windows.Forms.DockStyle.Left;
			this.palette1.FillColor = System.Drawing.Color.White;
			this.palette1.ForeColor = System.Drawing.Color.Black;
			this.palette1.GradientColor = System.Drawing.SystemColors.Control;
			this.palette1.ItemSize = new System.Drawing.Size(18, 18);
			this.palette1.Location = new System.Drawing.Point(0, 28);
			this.palette1.Name = "palette1";
			this.palette1.Size = new System.Drawing.Size(178, 645);
			this.palette1.Spacing = new System.Drawing.Size(20, 22);
			this.palette1.TabIndex = 1;
			this.palette1.WorkspaceColor = System.Drawing.SystemColors.AppWorkspace;
			this.palette1.Zoom = 100F;
			this.palette1.ElementMouseDown += new System.Windows.Forms.MouseEventHandler(this.palette1_ElementMouseDown);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(178, 28);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(2, 645);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// btnNormal
			// 
			this.btnNormal.ImageIndex = 11;
			this.btnNormal.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			// 
			// btnAddComplex
			// 
			this.btnAddComplex.ImageIndex = 12;
			this.btnAddComplex.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(892, 673);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.palette1);
			this.Controls.Add(this.toolBar1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmMain";
			this.Text = "Editor Example";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		#region Events

		//Occurs Loading the main form
		private void frmMain_Load(object sender, System.EventArgs e)
		{
			//Load the palette
			LoadPalette();
			LoadChildForm();
			this.Size = new Size(900, 720);
			this.CenterToScreen();
		}

		//Start drag drop
		private void palette1_ElementMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (sender is Element)
			{
				//Start the drag operation
				Shape prototype = (Shape) sender;
			
				Shape shape = new Shape(prototype);
				shape.MinimumSize = new Size(32,32);
				shape.MaximumSize = new Size(320,320);
				shape.Scale(3,3,0,0,false);

				shape.Label = null;
				shape.Image = null;
			
				palette1.DoDragDrop(shape, DragDropEffects.All);
			}
		}

		//Click on a file menu item
		private void mnuFile_Click(object sender, System.EventArgs e)
		{
			DoFileAction(sender);
		}

		//Click on an Edit menu item
		private void mnuEdit_Click(object sender, System.EventArgs e)
		{
			DoEditAction(sender);
		}

		//Click on a toolbar button
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			frmDiagram active = (frmDiagram) this.ActiveMdiChild;

			if (e.Button == btnNew || e.Button == btnOpen || e.Button == btnSave || e.Button == btnPrint) DoFileAction(e.Button);
			if (e.Button == btnUndo || e.Button == btnRedo || e.Button == btnCut || e.Button == btnCopy || e.Button == btnPaste) DoEditAction(e.Button);


			if (e.Button == btnNormal)
			{
				btnAddLine.Pushed = false;
				btnAddConnector.Pushed = false;
				btnAddComplex.Pushed = false;
				btnNormal.Pushed = true;
				active.Model.Runtime.InteractiveMode = InteractiveMode.Normal;
			}

			else if (e.Button == btnAddLine)
			{
				btnNormal.Pushed = !btnAddLine.Pushed;
				btnAddConnector.Pushed = false;
				btnAddComplex.Pushed = false;
				active.Model.Runtime.InteractiveMode = InteractiveMode.Normal;

				if (btnAddLine.Pushed) 	active.Model.Runtime.InteractiveMode = InteractiveMode.AddLine;
			}
			
			else if (e.Button == btnAddConnector)
			{
				btnNormal.Pushed = !btnAddConnector.Pushed;
				btnAddLine.Pushed = false;
				btnAddComplex.Pushed = false;
				active.Model.Runtime.InteractiveMode = InteractiveMode.Normal;

				if (btnAddConnector.Pushed) active.Model.Runtime.InteractiveMode = InteractiveMode.AddConnector;
			}

			else if (e.Button == btnAddComplex)
			{
				btnNormal.Pushed = !btnAddComplex.Pushed;;
				btnAddLine.Pushed = false;
				btnAddConnector.Pushed = false;
				active.Model.Runtime.InteractiveMode = InteractiveMode.Normal;

				if (btnAddComplex.Pushed) active.Model.Runtime.InteractiveMode = InteractiveMode.AddComplexLine;
			}
		}

		//Load the current layers
		private void mnuView_Popup(object sender, System.EventArgs e)
		{
			MenuItem menu;
			frmDiagram active = (frmDiagram) this.ActiveMdiChild;
			
			//Clear old layers
			mnuLayers.MenuItems.Clear();
			            
			//Add existing layers
			foreach (Layer layer in active.Model.Layers)
			{
				menu = new MenuItem(layer.Name);
				if (layer == active.Model.Layers.CurrentLayer) menu.Checked = true;
				menu.Click += new EventHandler(mnuLayer_Click);

				mnuLayers.MenuItems.Add(0,menu);
			}
		}

		//Occurs when a layer menu is clicked
		private void mnuLayer_Click(object sender, System.EventArgs e)
		{
			//Uncheck old menu item
			foreach (MenuItem menu in mnuLayers.MenuItems)
			{
				menu.Checked = false;
			}

			frmDiagram active = (frmDiagram) this.ActiveMdiChild;
			MenuItem menu2 = (MenuItem) sender;
			Layer layer = active.Model.Layers[menu2.Text];

			menu2.Checked = true;
			active.Model.Layers.CurrentLayer = layer;			
		}

		private void mnuTools_Click(object sender, System.EventArgs e)
		{
			frmDiagram active = (frmDiagram) this.ActiveMdiChild;

			//Get a diagram point that is in the middle of the current display area
			PointF point = active.Model.PointToDiagram(active.Model.Size.Width / 2, active.Model.Size.Height / 2);
				
			//Add line
			if (sender == mnuAddLine) active.AddLine(point);

			//Add connector
			if (sender == mnuAddConnector) active.AddConnector(point);

			//Add group 				
			if (sender == mnuAddGroup) active.AddGroup(point);

			//Add layer
			if (sender == mnuAddLayer)
			{
				Layer layer = new Layer();
				layer.Name = "layer " + (active.Model.Layers.Count + 1).ToString();
				active.Model.Layers.Add(layer);
				active.Model.Layers.CurrentLayer = layer;
			}

			//Options
			if (sender == mnuToolsOptions)
			{
				frmOptions form = new frmOptions();
				form.DrawGrid = active.Model.DrawGrid;
				form.AlignGrid = active.Model.AlignGrid;
				form.HideActions = Crainiate.Diagramming.Component.Instance.HideActions;
				form.Feedback = active.Model.Runtime.Feedback;
				form.BasicActions = (active.Model.RenderDesign.ActionStyle == ActionStyle.Basic);

				if (form.ShowDialog() == DialogResult.OK)
				{
					active.Model.DrawGrid = form.DrawGrid;
					active.Model.AlignGrid = form.AlignGrid;
					Crainiate.Diagramming.Component.Instance.HideActions = form.HideActions;
					active.Model.Runtime.Feedback = form.Feedback;
					active.Model.RenderDesign.ActionStyle = (form.BasicActions) ? ActionStyle.Basic: ActionStyle.Default;
				}
			}
		}

		private void mnuZoom_Click(object sender, System.EventArgs e)
		{
			frmDiagram active = (frmDiagram) this.ActiveMdiChild;
			if (sender == mnuZoom50) active.Model.Zoom = 50;
			if (sender == mnuZoom75) active.Model.Zoom = 75;
			if (sender == mnuZoom100) active.Model.Zoom = 100;
			if (sender == mnuZoom200)active.Model.Zoom = 200;
			if (sender == mnuZoomBestFit) active.ZoomBestFit();

			active.Model.Refresh();
		}

		private void mnuHelpAbout_Click(object sender, System.EventArgs e)
		{
			if (sender == mnuHelpAbout)
			{
				frmAbout form = new frmAbout();
				form.ShowDialog();
			}
		}

		#endregion

		#region Implementation

		//Loads the palette with the basic and flowchart stencils
		private void LoadPalette()
		{
			//Set default tab
			palette1.AllowDrop = true;
			palette1.AddStencil(Crainiate.Diagramming.Component.Instance.GetStencil(typeof(BasicStencil)));
			palette1.Tabs.CurrentTab.Name = "Basic Shapes";

			//Add flowchart tab
			Tab tab = new Tab();
			tab.Name = "Flowchart";
			palette1.Tabs.Add(tab);
			palette1.Tabs.CurrentTab = tab;

			palette1.AddStencil(Crainiate.Diagramming.Component.Instance.GetStencil(typeof(Crainiate.Diagramming.Flowcharting.FlowchartStencil)));

			//Set first tab as default
			palette1.Tabs.CurrentTab = palette1.Tabs[0];
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

		//Perform file and print actions
		private void DoFileAction(object sender)
		{
			frmDiagram active = (frmDiagram) this.ActiveMdiChild;

			//Open
			if (sender == mnuFileOpen || sender == btnOpen)
			{
				active.Open("");
			}

			//Save
			if (sender == mnuFileSave || sender == btnSave)
			{
				active.Save(active.Path);
			}

			//Save as
			if (sender == mnuFileSaveAs)
			{
				active.Save("");
			}

			//Print preview
			if (sender == mnuFilePrintPreview)
			{
				Crainiate.Diagramming.Printing.PrintDocument print = new Crainiate.Diagramming.Printing.PrintDocument(active.Model);
				print.PrintPreview(new Point(100, 100), new Size(800, 600));
				return;
			}

			//Print with settings
			if (sender == mnuFilePrint || sender == btnPrint)
			{
				Crainiate.Diagramming.Printing.PrintDocument print = new Crainiate.Diagramming.Printing.PrintDocument(active.Model);
				System.Windows.Forms.PrintDialog printDialogue = new System.Windows.Forms.PrintDialog();
				printDialogue.Document = print;

				if (printDialogue.ShowDialog() == DialogResult.OK)
				{
					print.Print();
				}
				return;
			}

			if (sender == mnuFileExit)
			{
				this.Close();
			}
		}

		//Performs edit functions
		private void DoEditAction(object sender)
		{
			frmDiagram active = (frmDiagram) this.ActiveMdiChild;

			//Undo
			if (sender == btnUndo || sender == mnuEditUndo)
			{
				active.Model.DoCommand("undo");
			}

			//Redo
			if (sender == btnRedo || sender == mnuEditRedo)
			{
				active.Model.DoCommand("redo");
			}

			//Cut
			if (sender == btnCut || sender == mnuEditCut)
			{
				active.Model.DoCommand("cut");
			}

			//Copy
			if (sender == btnCopy || sender == mnuEditCopy)
			{
				active.Model.DoCommand("copy");
			}

			//Paste
			if (sender == btnPaste || sender == mnuEditPaste)
			{
				active.Model.DoCommand("paste");
			}

			//Delete
			if (sender == mnuEditDelete)
			{
				active.Model.DoCommand("delete");
			}

			//Select all
			if (sender == mnuEditSelectAll)
			{
				active.Model.SelectElements(true);
			}
		}

		#endregion

	}
}
