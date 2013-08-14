namespace GlobeVisualization
{
    partial class PropertyBase
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
            this.tcPropertyBase = new System.Windows.Forms.TabControl();
            this.tpGlobeGeneral = new System.Windows.Forms.TabPage();
            this.gbDistanceRange = new System.Windows.Forms.GroupBox();
            this.chbCheckVisibility = new System.Windows.Forms.CheckBox();
            this.btnFeatureProperty = new System.Windows.Forms.Button();
            this.tbZoomMinDistance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbZoomMaxDistance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbZoomLimitation = new System.Windows.Forms.RadioButton();
            this.rbShowingLayer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbLayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSource = new System.Windows.Forms.TabPage();
            this.gBoxDataSource = new System.Windows.Forms.GroupBox();
            this.btnSetDataSource = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tpGlobeDisplay = new System.Windows.Forms.TabPage();
            this.tpDisplay = new System.Windows.Forms.TabPage();
            this.tpSymbology = new System.Windows.Forms.TabPage();
            this.tpElevation = new System.Windows.Forms.TabPage();
            this.tpCache = new System.Windows.Forms.TabPage();
            this.tpExtent = new System.Windows.Forms.TabPage();
            this.chbElevation = new System.Windows.Forms.CheckBox();
            this.gbElevationFromSurfaces = new System.Windows.Forms.GroupBox();
            this.rbDrapedOnSurface = new System.Windows.Forms.RadioButton();
            this.rbFloatingNoSurface = new System.Windows.Forms.RadioButton();
            this.rbFloatingOnCustomSurface = new System.Windows.Forms.RadioButton();
            this.tbCustomSurfaceDirectory = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbElevationFromFeatures = new System.Windows.Forms.GroupBox();
            this.rbNoFeatureBaseHeights = new System.Windows.Forms.RadioButton();
            this.rbUsingLayerElevationValue = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cbConvertionChoice = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnExpression = new System.Windows.Forms.Button();
            this.tbConvertionFactor = new System.Windows.Forms.TextBox();
            this.gbLayerOffset = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLayerOffset = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCacheStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCacheLacation = new System.Windows.Forms.Label();
            this.gbRasterData = new System.Windows.Forms.GroupBox();
            this.chbLossyCompression = new System.Windows.Forms.CheckBox();
            this.cbRasterImageTypes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.trbQuality = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chbCompressPixelRange = new System.Windows.Forms.CheckBox();
            this.gbRasterResolution = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbSourceCellSize = new System.Windows.Forms.TextBox();
            this.tbMinCellSize = new System.Windows.Forms.TextBox();
            this.gbCacheUsageAndRemoval = new System.Windows.Forms.GroupBox();
            this.chbNoDiskCache = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chbStorageNeeded = new System.Windows.Forms.CheckBox();
            this.chbExitAppOrRemoveLayer = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcPropertyBase.SuspendLayout();
            this.tpGlobeGeneral.SuspendLayout();
            this.gbDistanceRange.SuspendLayout();
            this.tpSource.SuspendLayout();
            this.gBoxDataSource.SuspendLayout();
            this.tpGlobeDisplay.SuspendLayout();
            this.tpElevation.SuspendLayout();
            this.tpCache.SuspendLayout();
            this.gbElevationFromSurfaces.SuspendLayout();
            this.gbElevationFromFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbLayerOffset.SuspendLayout();
            this.gbRasterData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbQuality)).BeginInit();
            this.gbRasterResolution.SuspendLayout();
            this.gbCacheUsageAndRemoval.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPropertyBase
            // 
            this.tcPropertyBase.Controls.Add(this.tpGlobeGeneral);
            this.tcPropertyBase.Controls.Add(this.tpSource);
            this.tcPropertyBase.Controls.Add(this.tpGlobeDisplay);
            this.tcPropertyBase.Controls.Add(this.tpDisplay);
            this.tcPropertyBase.Controls.Add(this.tpSymbology);
            this.tcPropertyBase.Controls.Add(this.tpElevation);
            this.tcPropertyBase.Controls.Add(this.tpCache);
            this.tcPropertyBase.Controls.Add(this.tpExtent);
            this.tcPropertyBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcPropertyBase.Location = new System.Drawing.Point(0, 0);
            this.tcPropertyBase.Name = "tcPropertyBase";
            this.tcPropertyBase.SelectedIndex = 0;
            this.tcPropertyBase.Size = new System.Drawing.Size(602, 461);
            this.tcPropertyBase.TabIndex = 0;
            // 
            // tpGlobeGeneral
            // 
            this.tpGlobeGeneral.Controls.Add(this.gbDistanceRange);
            this.tpGlobeGeneral.Controls.Add(this.tbCredits);
            this.tpGlobeGeneral.Controls.Add(this.tbDescription);
            this.tpGlobeGeneral.Controls.Add(this.tbLayerName);
            this.tpGlobeGeneral.Controls.Add(this.label3);
            this.tpGlobeGeneral.Controls.Add(this.label2);
            this.tpGlobeGeneral.Controls.Add(this.label1);
            this.tpGlobeGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGlobeGeneral.Name = "tpGlobeGeneral";
            this.tpGlobeGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGlobeGeneral.Size = new System.Drawing.Size(594, 447);
            this.tpGlobeGeneral.TabIndex = 0;
            this.tpGlobeGeneral.Text = "Globe常规";
            this.tpGlobeGeneral.UseVisualStyleBackColor = true;
            // 
            // gbDistanceRange
            // 
            this.gbDistanceRange.Controls.Add(this.chbCheckVisibility);
            this.gbDistanceRange.Controls.Add(this.btnFeatureProperty);
            this.gbDistanceRange.Controls.Add(this.tbZoomMinDistance);
            this.gbDistanceRange.Controls.Add(this.label8);
            this.gbDistanceRange.Controls.Add(this.label7);
            this.gbDistanceRange.Controls.Add(this.label6);
            this.gbDistanceRange.Controls.Add(this.tbZoomMaxDistance);
            this.gbDistanceRange.Controls.Add(this.label5);
            this.gbDistanceRange.Controls.Add(this.rbZoomLimitation);
            this.gbDistanceRange.Controls.Add(this.rbShowingLayer);
            this.gbDistanceRange.Controls.Add(this.label4);
            this.gbDistanceRange.Location = new System.Drawing.Point(29, 173);
            this.gbDistanceRange.Name = "gbDistanceRange";
            this.gbDistanceRange.Size = new System.Drawing.Size(502, 249);
            this.gbDistanceRange.TabIndex = 6;
            this.gbDistanceRange.TabStop = false;
            this.gbDistanceRange.Text = "距离范围";
            // 
            // chbCheckVisibility
            // 
            this.chbCheckVisibility.AutoSize = true;
            this.chbCheckVisibility.Location = new System.Drawing.Point(66, 156);
            this.chbCheckVisibility.Name = "chbCheckVisibility";
            this.chbCheckVisibility.Size = new System.Drawing.Size(156, 16);
            this.chbCheckVisibility.TabIndex = 10;
            this.chbCheckVisibility.Text = "基于每一瓷砖检验可见性";
            this.chbCheckVisibility.UseVisualStyleBackColor = true;
            // 
            // btnFeatureProperty
            // 
            this.btnFeatureProperty.Location = new System.Drawing.Point(42, 189);
            this.btnFeatureProperty.Name = "btnFeatureProperty";
            this.btnFeatureProperty.Size = new System.Drawing.Size(102, 23);
            this.btnFeatureProperty.TabIndex = 9;
            this.btnFeatureProperty.Text = "要素属性...";
            this.btnFeatureProperty.UseVisualStyleBackColor = true;
            // 
            // tbZoomMinDistance
            // 
            this.tbZoomMinDistance.Location = new System.Drawing.Point(175, 126);
            this.tbZoomMinDistance.Name = "tbZoomMinDistance";
            this.tbZoomMinDistance.Size = new System.Drawing.Size(100, 21);
            this.tbZoomMinDistance.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "(最小距离)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "(最大距离)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "缩小低于";
            // 
            // tbZoomMaxDistance
            // 
            this.tbZoomMaxDistance.Location = new System.Drawing.Point(175, 100);
            this.tbZoomMaxDistance.Name = "tbZoomMaxDistance";
            this.tbZoomMaxDistance.Size = new System.Drawing.Size(100, 21);
            this.tbZoomMaxDistance.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "放大超过";
            // 
            // rbZoomLimitation
            // 
            this.rbZoomLimitation.AutoSize = true;
            this.rbZoomLimitation.Location = new System.Drawing.Point(24, 80);
            this.rbZoomLimitation.Name = "rbZoomLimitation";
            this.rbZoomLimitation.Size = new System.Drawing.Size(143, 16);
            this.rbZoomLimitation.TabIndex = 2;
            this.rbZoomLimitation.TabStop = true;
            this.rbZoomLimitation.Text = "不显示图层，当缩放为";
            this.rbZoomLimitation.UseVisualStyleBackColor = true;
            // 
            // rbShowingLayer
            // 
            this.rbShowingLayer.AutoSize = true;
            this.rbShowingLayer.Location = new System.Drawing.Point(24, 58);
            this.rbShowingLayer.Name = "rbShowingLayer";
            this.rbShowingLayer.Size = new System.Drawing.Size(143, 16);
            this.rbShowingLayer.TabIndex = 1;
            this.rbShowingLayer.TabStop = true;
            this.rbShowingLayer.Text = "在任意距离上显示图层";
            this.rbShowingLayer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "你可以指定该图层上显示的距离的范围";
            // 
            // tbCredits
            // 
            this.tbCredits.Location = new System.Drawing.Point(131, 132);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(400, 21);
            this.tbCredits.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(131, 45);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(400, 80);
            this.tbDescription.TabIndex = 4;
            // 
            // tbLayerName
            // 
            this.tbLayerName.Location = new System.Drawing.Point(131, 18);
            this.tbLayerName.Name = "tbLayerName";
            this.tbLayerName.Size = new System.Drawing.Size(400, 21);
            this.tbLayerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "描述：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图层名称：";
            // 
            // tpSource
            // 
            this.tpSource.Controls.Add(this.gBoxDataSource);
            this.tpSource.Location = new System.Drawing.Point(4, 22);
            this.tpSource.Name = "tpSource";
            this.tpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tpSource.Size = new System.Drawing.Size(594, 447);
            this.tpSource.TabIndex = 1;
            this.tpSource.Text = "源";
            this.tpSource.UseVisualStyleBackColor = true;
            // 
            // gBoxDataSource
            // 
            this.gBoxDataSource.Controls.Add(this.btnSetDataSource);
            this.gBoxDataSource.Controls.Add(this.listView1);
            this.gBoxDataSource.Location = new System.Drawing.Point(8, 232);
            this.gBoxDataSource.Name = "gBoxDataSource";
            this.gBoxDataSource.Size = new System.Drawing.Size(578, 207);
            this.gBoxDataSource.TabIndex = 0;
            this.gBoxDataSource.TabStop = false;
            this.gBoxDataSource.Text = "数据源";
            // 
            // btnSetDataSource
            // 
            this.btnSetDataSource.Location = new System.Drawing.Point(422, 154);
            this.btnSetDataSource.Name = "btnSetDataSource";
            this.btnSetDataSource.Size = new System.Drawing.Size(131, 23);
            this.btnSetDataSource.TabIndex = 1;
            this.btnSetDataSource.Text = "设置数据源...";
            this.btnSetDataSource.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 116);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tpGlobeDisplay
            // 
            this.tpGlobeDisplay.Controls.Add(this.groupBox1);
            this.tpGlobeDisplay.Location = new System.Drawing.Point(4, 22);
            this.tpGlobeDisplay.Name = "tpGlobeDisplay";
            this.tpGlobeDisplay.Size = new System.Drawing.Size(594, 435);
            this.tpGlobeDisplay.TabIndex = 2;
            this.tpGlobeDisplay.Text = "Globe显示";
            this.tpGlobeDisplay.UseVisualStyleBackColor = true;
            // 
            // tpDisplay
            // 
            this.tpDisplay.Location = new System.Drawing.Point(4, 22);
            this.tpDisplay.Name = "tpDisplay";
            this.tpDisplay.Size = new System.Drawing.Size(594, 435);
            this.tpDisplay.TabIndex = 3;
            this.tpDisplay.Text = "显示";
            this.tpDisplay.UseVisualStyleBackColor = true;
            // 
            // tpSymbology
            // 
            this.tpSymbology.Location = new System.Drawing.Point(4, 22);
            this.tpSymbology.Name = "tpSymbology";
            this.tpSymbology.Size = new System.Drawing.Size(594, 447);
            this.tpSymbology.TabIndex = 4;
            this.tpSymbology.Text = "符号";
            this.tpSymbology.UseVisualStyleBackColor = true;
            // 
            // tpElevation
            // 
            this.tpElevation.Controls.Add(this.gbLayerOffset);
            this.tpElevation.Controls.Add(this.gbElevationFromFeatures);
            this.tpElevation.Controls.Add(this.gbElevationFromSurfaces);
            this.tpElevation.Controls.Add(this.chbElevation);
            this.tpElevation.Location = new System.Drawing.Point(4, 22);
            this.tpElevation.Name = "tpElevation";
            this.tpElevation.Size = new System.Drawing.Size(594, 435);
            this.tpElevation.TabIndex = 5;
            this.tpElevation.Text = "高程";
            this.tpElevation.UseVisualStyleBackColor = true;
            // 
            // tpCache
            // 
            this.tpCache.Controls.Add(this.btnAdvanced);
            this.tpCache.Controls.Add(this.gbCacheUsageAndRemoval);
            this.tpCache.Controls.Add(this.gbRasterResolution);
            this.tpCache.Controls.Add(this.gbRasterData);
            this.tpCache.Controls.Add(this.lbCacheLacation);
            this.tpCache.Controls.Add(this.label12);
            this.tpCache.Controls.Add(this.lbCacheStatus);
            this.tpCache.Controls.Add(this.label11);
            this.tpCache.Location = new System.Drawing.Point(4, 22);
            this.tpCache.Name = "tpCache";
            this.tpCache.Size = new System.Drawing.Size(594, 435);
            this.tpCache.TabIndex = 6;
            this.tpCache.Text = "缓存";
            this.tpCache.UseVisualStyleBackColor = true;
            // 
            // tpExtent
            // 
            this.tpExtent.Location = new System.Drawing.Point(4, 22);
            this.tpExtent.Name = "tpExtent";
            this.tpExtent.Size = new System.Drawing.Size(594, 447);
            this.tpExtent.TabIndex = 7;
            this.tpExtent.Text = "区间";
            this.tpExtent.UseVisualStyleBackColor = true;
            // 
            // chbElevation
            // 
            this.chbElevation.AutoSize = true;
            this.chbElevation.Location = new System.Drawing.Point(23, 13);
            this.chbElevation.Name = "chbElevation";
            this.chbElevation.Size = new System.Drawing.Size(180, 16);
            this.chbElevation.TabIndex = 0;
            this.chbElevation.Text = "此图层向球表面提供高程数据";
            this.chbElevation.UseVisualStyleBackColor = true;
            // 
            // gbElevationFromSurfaces
            // 
            this.gbElevationFromSurfaces.Controls.Add(this.btnSave);
            this.gbElevationFromSurfaces.Controls.Add(this.btnOpen);
            this.gbElevationFromSurfaces.Controls.Add(this.tbCustomSurfaceDirectory);
            this.gbElevationFromSurfaces.Controls.Add(this.rbFloatingOnCustomSurface);
            this.gbElevationFromSurfaces.Controls.Add(this.rbFloatingNoSurface);
            this.gbElevationFromSurfaces.Controls.Add(this.rbDrapedOnSurface);
            this.gbElevationFromSurfaces.Location = new System.Drawing.Point(8, 35);
            this.gbElevationFromSurfaces.Name = "gbElevationFromSurfaces";
            this.gbElevationFromSurfaces.Size = new System.Drawing.Size(578, 122);
            this.gbElevationFromSurfaces.TabIndex = 1;
            this.gbElevationFromSurfaces.TabStop = false;
            this.gbElevationFromSurfaces.Text = "表面高程数据";
            // 
            // rbDrapedOnSurface
            // 
            this.rbDrapedOnSurface.AutoSize = true;
            this.rbDrapedOnSurface.Location = new System.Drawing.Point(32, 20);
            this.rbDrapedOnSurface.Name = "rbDrapedOnSurface";
            this.rbDrapedOnSurface.Size = new System.Drawing.Size(95, 16);
            this.rbDrapedOnSurface.TabIndex = 0;
            this.rbDrapedOnSurface.TabStop = true;
            this.rbDrapedOnSurface.Text = "悬挂在表面上";
            this.rbDrapedOnSurface.UseVisualStyleBackColor = true;
            // 
            // rbFloatingNoSurface
            // 
            this.rbFloatingNoSurface.AutoSize = true;
            this.rbFloatingNoSurface.Location = new System.Drawing.Point(32, 43);
            this.rbFloatingNoSurface.Name = "rbFloatingNoSurface";
            this.rbFloatingNoSurface.Size = new System.Drawing.Size(107, 16);
            this.rbFloatingNoSurface.TabIndex = 1;
            this.rbFloatingNoSurface.TabStop = true;
            this.rbFloatingNoSurface.Text = "不在表面上浮动";
            this.rbFloatingNoSurface.UseVisualStyleBackColor = true;
            // 
            // rbFloatingOnCustomSurface
            // 
            this.rbFloatingOnCustomSurface.AutoSize = true;
            this.rbFloatingOnCustomSurface.Location = new System.Drawing.Point(32, 66);
            this.rbFloatingOnCustomSurface.Name = "rbFloatingOnCustomSurface";
            this.rbFloatingOnCustomSurface.Size = new System.Drawing.Size(131, 16);
            this.rbFloatingOnCustomSurface.TabIndex = 2;
            this.rbFloatingOnCustomSurface.TabStop = true;
            this.rbFloatingOnCustomSurface.Text = "浮动在自定义表面上";
            this.rbFloatingOnCustomSurface.UseVisualStyleBackColor = true;
            // 
            // tbCustomSurfaceDirectory
            // 
            this.tbCustomSurfaceDirectory.Location = new System.Drawing.Point(32, 88);
            this.tbCustomSurfaceDirectory.Name = "tbCustomSurfaceDirectory";
            this.tbCustomSurfaceDirectory.Size = new System.Drawing.Size(367, 21);
            this.tbCustomSurfaceDirectory.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(421, 86);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(54, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(493, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbElevationFromFeatures
            // 
            this.gbElevationFromFeatures.Controls.Add(this.tbConvertionFactor);
            this.gbElevationFromFeatures.Controls.Add(this.btnExpression);
            this.gbElevationFromFeatures.Controls.Add(this.numericUpDown1);
            this.gbElevationFromFeatures.Controls.Add(this.radioButton3);
            this.gbElevationFromFeatures.Controls.Add(this.cbConvertionChoice);
            this.gbElevationFromFeatures.Controls.Add(this.label9);
            this.gbElevationFromFeatures.Controls.Add(this.rbUsingLayerElevationValue);
            this.gbElevationFromFeatures.Controls.Add(this.rbNoFeatureBaseHeights);
            this.gbElevationFromFeatures.Location = new System.Drawing.Point(9, 177);
            this.gbElevationFromFeatures.Name = "gbElevationFromFeatures";
            this.gbElevationFromFeatures.Size = new System.Drawing.Size(577, 155);
            this.gbElevationFromFeatures.TabIndex = 2;
            this.gbElevationFromFeatures.TabStop = false;
            this.gbElevationFromFeatures.Text = "要素高程数据";
            // 
            // rbNoFeatureBaseHeights
            // 
            this.rbNoFeatureBaseHeights.AutoSize = true;
            this.rbNoFeatureBaseHeights.Location = new System.Drawing.Point(31, 21);
            this.rbNoFeatureBaseHeights.Name = "rbNoFeatureBaseHeights";
            this.rbNoFeatureBaseHeights.Size = new System.Drawing.Size(119, 16);
            this.rbNoFeatureBaseHeights.TabIndex = 0;
            this.rbNoFeatureBaseHeights.TabStop = true;
            this.rbNoFeatureBaseHeights.Text = "无基于要素的高度";
            this.rbNoFeatureBaseHeights.UseVisualStyleBackColor = true;
            // 
            // rbUsingLayerElevationValue
            // 
            this.rbUsingLayerElevationValue.AutoSize = true;
            this.rbUsingLayerElevationValue.Location = new System.Drawing.Point(31, 44);
            this.rbUsingLayerElevationValue.Name = "rbUsingLayerElevationValue";
            this.rbUsingLayerElevationValue.Size = new System.Drawing.Size(143, 16);
            this.rbUsingLayerElevationValue.TabIndex = 1;
            this.rbUsingLayerElevationValue.TabStop = true;
            this.rbUsingLayerElevationValue.Text = "使用图层中的高程数据";
            this.rbUsingLayerElevationValue.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "将图层高程数据转换为米的因子";
            // 
            // cbConvertionChoice
            // 
            this.cbConvertionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvertionChoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbConvertionChoice.FormattingEnabled = true;
            this.cbConvertionChoice.Items.AddRange(new object[] {
            "英寸转换成米",
            "自定义"});
            this.cbConvertionChoice.Location = new System.Drawing.Point(336, 68);
            this.cbConvertionChoice.Name = "cbConvertionChoice";
            this.cbConvertionChoice.Size = new System.Drawing.Size(121, 20);
            this.cbConvertionChoice.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(31, 93);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(131, 16);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "使用常量值或表达式";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(365, 21);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnExpression
            // 
            this.btnExpression.Location = new System.Drawing.Point(420, 115);
            this.btnExpression.Name = "btnExpression";
            this.btnExpression.Size = new System.Drawing.Size(54, 23);
            this.btnExpression.TabIndex = 7;
            this.btnExpression.Text = "表达式";
            this.btnExpression.UseVisualStyleBackColor = true;
            // 
            // tbConvertionFactor
            // 
            this.tbConvertionFactor.Location = new System.Drawing.Point(477, 67);
            this.tbConvertionFactor.Name = "tbConvertionFactor";
            this.tbConvertionFactor.Size = new System.Drawing.Size(94, 21);
            this.tbConvertionFactor.TabIndex = 8;
            // 
            // gbLayerOffset
            // 
            this.gbLayerOffset.Controls.Add(this.tbLayerOffset);
            this.gbLayerOffset.Controls.Add(this.label10);
            this.gbLayerOffset.Location = new System.Drawing.Point(9, 347);
            this.gbLayerOffset.Name = "gbLayerOffset";
            this.gbLayerOffset.Size = new System.Drawing.Size(577, 40);
            this.gbLayerOffset.TabIndex = 3;
            this.gbLayerOffset.TabStop = false;
            this.gbLayerOffset.Text = "图层补偿";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "添加常量图层补偿值（米）";
            // 
            // tbLayerOffset
            // 
            this.tbLayerOffset.Location = new System.Drawing.Point(336, 14);
            this.tbLayerOffset.Name = "tbLayerOffset";
            this.tbLayerOffset.Size = new System.Drawing.Size(100, 21);
            this.tbLayerOffset.TabIndex = 1;
            this.tbLayerOffset.Text = "0";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(252, 468);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(511, 468);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "状态";
            // 
            // lbCacheStatus
            // 
            this.lbCacheStatus.AutoSize = true;
            this.lbCacheStatus.Location = new System.Drawing.Point(91, 17);
            this.lbCacheStatus.Name = "lbCacheStatus";
            this.lbCacheStatus.Size = new System.Drawing.Size(0, 12);
            this.lbCacheStatus.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "位置";
            // 
            // lbCacheLacation
            // 
            this.lbCacheLacation.AutoSize = true;
            this.lbCacheLacation.Location = new System.Drawing.Point(91, 42);
            this.lbCacheLacation.Name = "lbCacheLacation";
            this.lbCacheLacation.Size = new System.Drawing.Size(0, 12);
            this.lbCacheLacation.TabIndex = 3;
            // 
            // gbRasterData
            // 
            this.gbRasterData.Controls.Add(this.chbCompressPixelRange);
            this.gbRasterData.Controls.Add(this.label15);
            this.gbRasterData.Controls.Add(this.label14);
            this.gbRasterData.Controls.Add(this.trbQuality);
            this.gbRasterData.Controls.Add(this.label13);
            this.gbRasterData.Controls.Add(this.cbRasterImageTypes);
            this.gbRasterData.Controls.Add(this.chbLossyCompression);
            this.gbRasterData.Location = new System.Drawing.Point(8, 70);
            this.gbRasterData.Name = "gbRasterData";
            this.gbRasterData.Size = new System.Drawing.Size(578, 102);
            this.gbRasterData.TabIndex = 4;
            this.gbRasterData.TabStop = false;
            this.gbRasterData.Text = "栅格数据";
            // 
            // chbLossyCompression
            // 
            this.chbLossyCompression.AutoSize = true;
            this.chbLossyCompression.Location = new System.Drawing.Point(28, 21);
            this.chbLossyCompression.Name = "chbLossyCompression";
            this.chbLossyCompression.Size = new System.Drawing.Size(120, 16);
            this.chbLossyCompression.TabIndex = 0;
            this.chbLossyCompression.Text = "使用有损空间压缩";
            this.chbLossyCompression.UseVisualStyleBackColor = true;
            // 
            // cbRasterImageTypes
            // 
            this.cbRasterImageTypes.FormattingEnabled = true;
            this.cbRasterImageTypes.Location = new System.Drawing.Point(57, 44);
            this.cbRasterImageTypes.Name = "cbRasterImageTypes";
            this.cbRasterImageTypes.Size = new System.Drawing.Size(104, 20);
            this.cbRasterImageTypes.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "品质：";
            // 
            // trbQuality
            // 
            this.trbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbQuality.AutoSize = false;
            this.trbQuality.Location = new System.Drawing.Point(396, 35);
            this.trbQuality.Name = "trbQuality";
            this.trbQuality.Size = new System.Drawing.Size(104, 19);
            this.trbQuality.TabIndex = 3;
            this.trbQuality.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(358, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "低";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(524, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "高";
            // 
            // chbCompressPixelRange
            // 
            this.chbCompressPixelRange.AutoSize = true;
            this.chbCompressPixelRange.Location = new System.Drawing.Point(28, 79);
            this.chbCompressPixelRange.Name = "chbCompressPixelRange";
            this.chbCompressPixelRange.Size = new System.Drawing.Size(144, 16);
            this.chbCompressPixelRange.TabIndex = 6;
            this.chbCompressPixelRange.Text = "压缩像素值范围至16位";
            this.chbCompressPixelRange.UseVisualStyleBackColor = true;
            // 
            // gbRasterResolution
            // 
            this.gbRasterResolution.Controls.Add(this.tbMinCellSize);
            this.gbRasterResolution.Controls.Add(this.tbSourceCellSize);
            this.gbRasterResolution.Controls.Add(this.label18);
            this.gbRasterResolution.Controls.Add(this.label17);
            this.gbRasterResolution.Controls.Add(this.label16);
            this.gbRasterResolution.Location = new System.Drawing.Point(9, 178);
            this.gbRasterResolution.Name = "gbRasterResolution";
            this.gbRasterResolution.Size = new System.Drawing.Size(578, 87);
            this.gbRasterResolution.TabIndex = 5;
            this.gbRasterResolution.TabStop = false;
            this.gbRasterResolution.Text = "栅格分辨率";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "增加最小单元大小以减小缓存";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(260, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "源单元大小";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(260, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "最小单元大小";
            // 
            // tbSourceCellSize
            // 
            this.tbSourceCellSize.Location = new System.Drawing.Point(382, 35);
            this.tbSourceCellSize.Name = "tbSourceCellSize";
            this.tbSourceCellSize.ReadOnly = true;
            this.tbSourceCellSize.Size = new System.Drawing.Size(100, 21);
            this.tbSourceCellSize.TabIndex = 3;
            // 
            // tbMinCellSize
            // 
            this.tbMinCellSize.Location = new System.Drawing.Point(382, 60);
            this.tbMinCellSize.Name = "tbMinCellSize";
            this.tbMinCellSize.Size = new System.Drawing.Size(100, 21);
            this.tbMinCellSize.TabIndex = 4;
            // 
            // gbCacheUsageAndRemoval
            // 
            this.gbCacheUsageAndRemoval.Controls.Add(this.label20);
            this.gbCacheUsageAndRemoval.Controls.Add(this.chbExitAppOrRemoveLayer);
            this.gbCacheUsageAndRemoval.Controls.Add(this.chbStorageNeeded);
            this.gbCacheUsageAndRemoval.Controls.Add(this.label19);
            this.gbCacheUsageAndRemoval.Controls.Add(this.chbNoDiskCache);
            this.gbCacheUsageAndRemoval.Location = new System.Drawing.Point(9, 271);
            this.gbCacheUsageAndRemoval.Name = "gbCacheUsageAndRemoval";
            this.gbCacheUsageAndRemoval.Size = new System.Drawing.Size(577, 100);
            this.gbCacheUsageAndRemoval.TabIndex = 6;
            this.gbCacheUsageAndRemoval.TabStop = false;
            this.gbCacheUsageAndRemoval.Text = "缓存使用和移除选项";
            // 
            // chbNoDiskCache
            // 
            this.chbNoDiskCache.AutoSize = true;
            this.chbNoDiskCache.Location = new System.Drawing.Point(27, 20);
            this.chbNoDiskCache.Name = "chbNoDiskCache";
            this.chbNoDiskCache.Size = new System.Drawing.Size(108, 16);
            this.chbNoDiskCache.TabIndex = 0;
            this.chbNoDiskCache.Text = "不使用硬盘缓存";
            this.chbNoDiskCache.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "完整移除缓存数据，当：";
            // 
            // chbStorageNeeded
            // 
            this.chbStorageNeeded.AutoSize = true;
            this.chbStorageNeeded.Location = new System.Drawing.Point(93, 54);
            this.chbStorageNeeded.Name = "chbStorageNeeded";
            this.chbStorageNeeded.Size = new System.Drawing.Size(174, 16);
            this.chbStorageNeeded.TabIndex = 2;
            this.chbStorageNeeded.Text = "需要缓存所在的存储空间时 ";
            this.chbStorageNeeded.UseVisualStyleBackColor = true;
            // 
            // chbExitAppOrRemoveLayer
            // 
            this.chbExitAppOrRemoveLayer.AutoSize = true;
            this.chbExitAppOrRemoveLayer.Location = new System.Drawing.Point(93, 77);
            this.chbExitAppOrRemoveLayer.Name = "chbExitAppOrRemoveLayer";
            this.chbExitAppOrRemoveLayer.Size = new System.Drawing.Size(156, 16);
            this.chbExitAppOrRemoveLayer.TabIndex = 3;
            this.chbExitAppOrRemoveLayer.Text = "退出程序或图层被移除时";
            this.chbExitAppOrRemoveLayer.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(308, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(253, 19);
            this.label20.TabIndex = 4;
            this.label20.Text = "要保留缓存数据，请保存整个文档或相应图层";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(433, 392);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnAdvanced.TabIndex = 7;
            this.btnAdvanced.Text = "高级...";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PropertyBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 512);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tcPropertyBase);
            this.Name = "PropertyBase";
            this.Text = "属性基类";
            this.tcPropertyBase.ResumeLayout(false);
            this.tpGlobeGeneral.ResumeLayout(false);
            this.tpGlobeGeneral.PerformLayout();
            this.gbDistanceRange.ResumeLayout(false);
            this.gbDistanceRange.PerformLayout();
            this.tpSource.ResumeLayout(false);
            this.gBoxDataSource.ResumeLayout(false);
            this.tpGlobeDisplay.ResumeLayout(false);
            this.tpElevation.ResumeLayout(false);
            this.tpElevation.PerformLayout();
            this.tpCache.ResumeLayout(false);
            this.tpCache.PerformLayout();
            this.gbElevationFromSurfaces.ResumeLayout(false);
            this.gbElevationFromSurfaces.PerformLayout();
            this.gbElevationFromFeatures.ResumeLayout(false);
            this.gbElevationFromFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbLayerOffset.ResumeLayout(false);
            this.gbLayerOffset.PerformLayout();
            this.gbRasterData.ResumeLayout(false);
            this.gbRasterData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbQuality)).EndInit();
            this.gbRasterResolution.ResumeLayout(false);
            this.gbRasterResolution.PerformLayout();
            this.gbCacheUsageAndRemoval.ResumeLayout(false);
            this.gbCacheUsageAndRemoval.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPropertyBase;
        private System.Windows.Forms.TabPage tpGlobeGeneral;
        private System.Windows.Forms.TabPage tpSource;
        private System.Windows.Forms.TabPage tpGlobeDisplay;
        private System.Windows.Forms.TabPage tpDisplay;
        private System.Windows.Forms.TabPage tpSymbology;
        private System.Windows.Forms.TabPage tpElevation;
        private System.Windows.Forms.TabPage tpCache;
        private System.Windows.Forms.TabPage tpExtent;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbLayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDistanceRange;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.CheckBox chbCheckVisibility;
        private System.Windows.Forms.Button btnFeatureProperty;
        private System.Windows.Forms.TextBox tbZoomMinDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbZoomMaxDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbZoomLimitation;
        private System.Windows.Forms.RadioButton rbShowingLayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gBoxDataSource;
        private System.Windows.Forms.Button btnSetDataSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox chbElevation;
        private System.Windows.Forms.GroupBox gbElevationFromSurfaces;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbCustomSurfaceDirectory;
        private System.Windows.Forms.RadioButton rbFloatingOnCustomSurface;
        private System.Windows.Forms.RadioButton rbFloatingNoSurface;
        private System.Windows.Forms.RadioButton rbDrapedOnSurface;
        private System.Windows.Forms.GroupBox gbElevationFromFeatures;
        private System.Windows.Forms.Button btnExpression;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox cbConvertionChoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbUsingLayerElevationValue;
        private System.Windows.Forms.RadioButton rbNoFeatureBaseHeights;
        private System.Windows.Forms.TextBox tbConvertionFactor;
        private System.Windows.Forms.GroupBox gbLayerOffset;
        private System.Windows.Forms.TextBox tbLayerOffset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbRasterData;
        private System.Windows.Forms.TrackBar trbQuality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbRasterImageTypes;
        private System.Windows.Forms.CheckBox chbLossyCompression;
        private System.Windows.Forms.Label lbCacheLacation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbCacheStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbCompressPixelRange;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbRasterResolution;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMinCellSize;
        private System.Windows.Forms.TextBox tbSourceCellSize;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.GroupBox gbCacheUsageAndRemoval;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chbExitAppOrRemoveLayer;
        private System.Windows.Forms.CheckBox chbStorageNeeded;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chbNoDiskCache;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}