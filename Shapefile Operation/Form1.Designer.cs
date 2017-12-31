namespace Shapefile_Operation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.spatialToolStrip1 = new DotSpatial.Controls.SpatialToolStrip();
            this.map1 = new DotSpatial.Controls.Map();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapefileOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beijing1954ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asiaNorthAlbersEqualAreaConicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riverCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeTableOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAttributeTableToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAttribute = new System.Windows.Forms.Panel();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLengend = new System.Windows.Forms.Panel();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAttribute.SuspendLayout();
            this.spatialStatusStrip1.SuspendLayout();
            this.pnlLengend.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.spatialToolStrip1);
            this.pnlOperations.Controls.Add(this.menuStrip1);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(924, 52);
            this.pnlOperations.TabIndex = 0;
            // 
            // spatialToolStrip1
            // 
            this.spatialToolStrip1.ApplicationManager = null;
            this.spatialToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.spatialToolStrip1.Map = this.map1;
            this.spatialToolStrip1.Name = "spatialToolStrip1";
            this.spatialToolStrip1.Size = new System.Drawing.Size(924, 25);
            this.spatialToolStrip1.TabIndex = 1;
            this.spatialToolStrip1.Text = "spatialToolStrip1";
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.AutoSize = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.legend1;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(747, 455);
            this.map1.TabIndex = 0;
            this.map1.GeoMouseMove += new System.EventHandler<DotSpatial.Controls.GeoMouseArgs>(this.map1_GeoMouseMove);
            this.map1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map1_MouseDown);
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 172, 455);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(172, 455);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapefileOperationToolStripMenuItem,
            this.mapOptionToolStripMenuItem,
            this.projectionToolStripMenuItem,
            this.riverCurveToolStripMenuItem,
            this.attributeTableOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(103, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shapefileOperationToolStripMenuItem
            // 
            this.shapefileOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.polylineToolStripMenuItem,
            this.polygonToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveShapefileToolStripMenuItem});
            this.shapefileOperationToolStripMenuItem.Name = "shapefileOperationToolStripMenuItem";
            this.shapefileOperationToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.shapefileOperationToolStripMenuItem.Text = "Create Shape";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.pointToolStripMenuItem.Text = "Create Point Shapefile";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.createPointShapefileToolStripMenuItem_Click);
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.polylineToolStripMenuItem.Text = "Create Polyline Shapefile";
            this.polylineToolStripMenuItem.Click += new System.EventHandler(this.createPolylineShapefileToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.polygonToolStripMenuItem.Text = "Create Polygon Shapefile";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.createPloygonShapefileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // saveShapefileToolStripMenuItem
            // 
            this.saveShapefileToolStripMenuItem.Name = "saveShapefileToolStripMenuItem";
            this.saveShapefileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saveShapefileToolStripMenuItem.Text = "Save Shapefile";
            this.saveShapefileToolStripMenuItem.Click += new System.EventHandler(this.saveShapefileToolStripMenuItem_Click);
            // 
            // mapOptionToolStripMenuItem
            // 
            this.mapOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panToolStripMenuItem,
            this.defaultToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.zoomToExtentToolStripMenuItem,
            this.measurementToolStripMenuItem,
            this.toolStripSeparator2,
            this.printMapToolStripMenuItem});
            this.mapOptionToolStripMenuItem.Name = "mapOptionToolStripMenuItem";
            this.mapOptionToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.mapOptionToolStripMenuItem.Text = "Map Option";
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.panToolStripMenuItem.Text = "Pan";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.defaultToolStripMenuItem.Text = "Select";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // zoomToExtentToolStripMenuItem
            // 
            this.zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
            this.zoomToExtentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zoomToExtentToolStripMenuItem.Text = "Zoom to Extent";
            this.zoomToExtentToolStripMenuItem.Click += new System.EventHandler(this.zoomToExtentToolStripMenuItem_Click);
            // 
            // measurementToolStripMenuItem
            // 
            this.measurementToolStripMenuItem.Name = "measurementToolStripMenuItem";
            this.measurementToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.measurementToolStripMenuItem.Text = "Measurement";
            this.measurementToolStripMenuItem.Click += new System.EventHandler(this.measurementToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // printMapToolStripMenuItem
            // 
            this.printMapToolStripMenuItem.Name = "printMapToolStripMenuItem";
            this.printMapToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.printMapToolStripMenuItem.Text = "Print Map";
            this.printMapToolStripMenuItem.Click += new System.EventHandler(this.printMapToolStripMenuItem_Click);
            // 
            // projectionToolStripMenuItem
            // 
            this.projectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geographyToolStripMenuItem,
            this.projectedToolStripMenuItem});
            this.projectionToolStripMenuItem.Name = "projectionToolStripMenuItem";
            this.projectionToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.projectionToolStripMenuItem.Text = "Projection";
            // 
            // geographyToolStripMenuItem
            // 
            this.geographyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldToolStripMenuItem,
            this.asiaToolStripMenuItem});
            this.geographyToolStripMenuItem.Name = "geographyToolStripMenuItem";
            this.geographyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.geographyToolStripMenuItem.Text = "Geographic";
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.worldToolStripMenuItem.Text = "World";
            this.worldToolStripMenuItem.Click += new System.EventHandler(this.worldToolStripMenuItem_Click);
            // 
            // asiaToolStripMenuItem
            // 
            this.asiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beijing1954ToolStripMenuItem});
            this.asiaToolStripMenuItem.Name = "asiaToolStripMenuItem";
            this.asiaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.asiaToolStripMenuItem.Text = "Asia";
            // 
            // beijing1954ToolStripMenuItem
            // 
            this.beijing1954ToolStripMenuItem.Name = "beijing1954ToolStripMenuItem";
            this.beijing1954ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.beijing1954ToolStripMenuItem.Text = "Beijing 1954";
            this.beijing1954ToolStripMenuItem.Click += new System.EventHandler(this.beijing1954ToolStripMenuItem_Click);
            // 
            // projectedToolStripMenuItem
            // 
            this.projectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldToolStripMenuItem1,
            this.asiaNorthAlbersEqualAreaConicToolStripMenuItem});
            this.projectedToolStripMenuItem.Name = "projectedToolStripMenuItem";
            this.projectedToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.projectedToolStripMenuItem.Text = "Projected";
            // 
            // worldToolStripMenuItem1
            // 
            this.worldToolStripMenuItem1.Name = "worldToolStripMenuItem1";
            this.worldToolStripMenuItem1.Size = new System.Drawing.Size(278, 22);
            this.worldToolStripMenuItem1.Text = "World Mecator";
            this.worldToolStripMenuItem1.Click += new System.EventHandler(this.worldToolStripMenuItem1_Click);
            // 
            // asiaNorthAlbersEqualAreaConicToolStripMenuItem
            // 
            this.asiaNorthAlbersEqualAreaConicToolStripMenuItem.Name = "asiaNorthAlbersEqualAreaConicToolStripMenuItem";
            this.asiaNorthAlbersEqualAreaConicToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.asiaNorthAlbersEqualAreaConicToolStripMenuItem.Text = "Asia North Albers EqualArea Conic";
            this.asiaNorthAlbersEqualAreaConicToolStripMenuItem.Click += new System.EventHandler(this.asiaNorthAlbersEqualAreaConicToolStripMenuItem_Click);
            // 
            // riverCurveToolStripMenuItem
            // 
            this.riverCurveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem});
            this.riverCurveToolStripMenuItem.Name = "riverCurveToolStripMenuItem";
            this.riverCurveToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.riverCurveToolStripMenuItem.Text = "RiverCurve";
            this.riverCurveToolStripMenuItem.Click += new System.EventHandler(this.riverCurveToolStripMenuItem_Click);
            // 
            // attributeTableOperationsToolStripMenuItem
            // 
            this.attributeTableOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAttributeTableToExcelToolStripMenuItem});
            this.attributeTableOperationsToolStripMenuItem.Name = "attributeTableOperationsToolStripMenuItem";
            this.attributeTableOperationsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.attributeTableOperationsToolStripMenuItem.Text = "Attribute";
            // 
            // exportAttributeTableToExcelToolStripMenuItem
            // 
            this.exportAttributeTableToExcelToolStripMenuItem.Name = "exportAttributeTableToExcelToolStripMenuItem";
            this.exportAttributeTableToExcelToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.exportAttributeTableToExcelToolStripMenuItem.Text = "Export Attribute table to Excel";
            this.exportAttributeTableToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportAttributeTableToExcelToolStripMenuItem_Click);
            // 
            // pnlAttribute
            // 
            this.pnlAttribute.Controls.Add(this.spatialStatusStrip1);
            this.pnlAttribute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAttribute.Location = new System.Drawing.Point(0, 507);
            this.pnlAttribute.Name = "pnlAttribute";
            this.pnlAttribute.Size = new System.Drawing.Size(924, 25);
            this.pnlAttribute.TabIndex = 1;
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 3);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.ProgressBar = null;
            this.spatialStatusStrip1.ProgressLabel = this.toolStripStatusLabel1;
            this.spatialStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(924, 22);
            this.spatialStatusStrip1.TabIndex = 1;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel1.Text = "Longitude, Latitude";
            // 
            // pnlLengend
            // 
            this.pnlLengend.Controls.Add(this.legend1);
            this.pnlLengend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLengend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLengend.Location = new System.Drawing.Point(0, 52);
            this.pnlLengend.Name = "pnlLengend";
            this.pnlLengend.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlLengend.Size = new System.Drawing.Size(177, 455);
            this.pnlLengend.TabIndex = 2;
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(177, 52);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(747, 455);
            this.pnlMap.TabIndex = 3;
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(924, 532);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlLengend);
            this.Controls.Add(this.pnlAttribute);
            this.Controls.Add(this.pnlOperations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Basic Map";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAttribute.ResumeLayout(false);
            this.pnlAttribute.PerformLayout();
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.pnlLengend.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.pnlMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlAttribute;
        private System.Windows.Forms.Panel pnlLengend;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapefileOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeTableOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAttributeTableToExcelToolStripMenuItem;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem projectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem geographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asiaNorthAlbersEqualAreaConicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beijing1954ToolStripMenuItem;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riverCurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
    }
}

