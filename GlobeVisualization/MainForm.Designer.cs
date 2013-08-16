namespace GlobeVisualization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.axGlobeControl1 = new ESRI.ArcGIS.Controls.AxGlobeControl();
			this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
			this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
			this.tocContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
			this.AttributeTable = new System.Windows.Forms.ToolStripMenuItem();
			this.Property = new System.Windows.Forms.ToolStripMenuItem();
			this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
			this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusStrip();
			this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.RemoveLayer = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.axGlobeControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
			this.tocContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// axGlobeControl1
			// 
			this.axGlobeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axGlobeControl1.Location = new System.Drawing.Point(196, 52);
			this.axGlobeControl1.Name = "axGlobeControl1";
			this.axGlobeControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGlobeControl1.OcxState")));
			this.axGlobeControl1.Size = new System.Drawing.Size(627, 475);
			this.axGlobeControl1.TabIndex = 0;
			this.axGlobeControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IGlobeControlEvents_Ax_OnMouseMoveEventHandler(this.axGlobeControl1_OnMouseMove);
			// 
			// axToolbarControl1
			// 
			this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.axToolbarControl1.Location = new System.Drawing.Point(0, 24);
			this.axToolbarControl1.Name = "axToolbarControl1";
			this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
			this.axToolbarControl1.Size = new System.Drawing.Size(823, 28);
			this.axToolbarControl1.TabIndex = 1;
			// 
			// axTOCControl1
			// 
			this.axTOCControl1.AllowDrop = true;
			this.axTOCControl1.ContextMenuStrip = this.tocContextMenu;
			this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.axTOCControl1.Location = new System.Drawing.Point(0, 52);
			this.axTOCControl1.Name = "axTOCControl1";
			this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
			this.axTOCControl1.Size = new System.Drawing.Size(196, 475);
			this.axTOCControl1.TabIndex = 2;
			this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
			this.axTOCControl1.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.axTOCControl1_OnMouseUp);
			this.axTOCControl1.OnMouseMove += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseMoveEventHandler(this.axTOCControl1_OnMouseMove);
			// 
			// tocContextMenu
			// 
			this.tocContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveLayer,
            this.ZoomToLayer,
            this.AttributeTable,
            this.Property});
			this.tocContextMenu.Name = "tocContextMenu";
			this.tocContextMenu.Size = new System.Drawing.Size(153, 114);
			// 
			// ZoomToLayer
			// 
			this.ZoomToLayer.Name = "ZoomToLayer";
			this.ZoomToLayer.Size = new System.Drawing.Size(152, 22);
			this.ZoomToLayer.Text = "缩放到该图层";
			this.ZoomToLayer.Click += new System.EventHandler(this.ZoomToLayer_Click);
			// 
			// AttributeTable
			// 
			this.AttributeTable.Name = "AttributeTable";
			this.AttributeTable.Size = new System.Drawing.Size(152, 22);
			this.AttributeTable.Text = "打开属性表";
			this.AttributeTable.Click += new System.EventHandler(this.AttributeTable_Click);
			// 
			// Property
			// 
			this.Property.Name = "Property";
			this.Property.Size = new System.Drawing.Size(152, 22);
			this.Property.Text = "属性";
			this.Property.Click += new System.EventHandler(this.Property_Click);
			// 
			// axLicenseControl1
			// 
			this.axLicenseControl1.Enabled = true;
			this.axLicenseControl1.Location = new System.Drawing.Point(366, 298);
			this.axLicenseControl1.Name = "axLicenseControl1";
			this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
			this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
			this.axLicenseControl1.TabIndex = 3;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(823, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuFile";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenDoc,
            this.separatorToolStripMenuItem,
            this.menuExitApp});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(43, 20);
			this.menuFile.Text = "文件";
			// 
			// menuOpenDoc
			// 
			this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
			this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
			this.menuOpenDoc.Name = "menuOpenDoc";
			this.menuOpenDoc.Size = new System.Drawing.Size(131, 22);
			this.menuOpenDoc.Text = "打开文档...";
			this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
			// 
			// separatorToolStripMenuItem
			// 
			this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
			this.separatorToolStripMenuItem.Size = new System.Drawing.Size(128, 6);
			// 
			// menuExitApp
			// 
			this.menuExitApp.Name = "menuExitApp";
			this.menuExitApp.Size = new System.Drawing.Size(131, 22);
			this.menuExitApp.Text = "退出";
			this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
			this.statusBar1.Location = new System.Drawing.Point(0, 527);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(823, 22);
			this.statusBar1.TabIndex = 5;
			// 
			// statusBarXY
			// 
			this.statusBarXY.Name = "statusBarXY";
			this.statusBarXY.Size = new System.Drawing.Size(0, 17);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(196, 52);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 475);
			this.splitter1.TabIndex = 6;
			this.splitter1.TabStop = false;
			// 
			// RemoveLayer
			// 
			this.RemoveLayer.Name = "RemoveLayer";
			this.RemoveLayer.Size = new System.Drawing.Size(152, 22);
			this.RemoveLayer.Text = "移除";
			this.RemoveLayer.Click += new System.EventHandler(this.RemoveLayer_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 549);
			this.Controls.Add(this.axLicenseControl1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.axGlobeControl1);
			this.Controls.Add(this.axTOCControl1);
			this.Controls.Add(this.axToolbarControl1);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GlobeVisualization";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.axGlobeControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
			this.tocContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusBar1.ResumeLayout(false);
			this.statusBar1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxGlobeControl axGlobeControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusBar1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.ContextMenuStrip tocContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Property;
        private System.Windows.Forms.ToolStripMenuItem AttributeTable;
        private System.Windows.Forms.ToolStripMenuItem ZoomToLayer;
		private System.Windows.Forms.ToolStripMenuItem RemoveLayer;
    }
}

