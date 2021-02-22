namespace GK3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UserMenu = new System.Windows.Forms.TableLayoutPanel();
            this.MenuFilters = new System.Windows.Forms.TableLayoutPanel();
            this.MenuBrushType = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLabels = new System.Windows.Forms.TableLayoutPanel();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelStatic = new System.Windows.Forms.Label();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.buttonWholePicture = new System.Windows.Forms.Button();
            this.buttonDeletePolygon = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonAddPolygon = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.contrastAdd = new System.Windows.Forms.Button();
            this.contrastSub = new System.Windows.Forms.Button();
            this.gammaAdd = new System.Windows.Forms.Button();
            this.gammaSub = new System.Windows.Forms.Button();
            this.BrightnessAdd = new System.Windows.Forms.Button();
            this.BrightnessSub = new System.Windows.Forms.Button();
            this.radioButtonOwn = new System.Windows.Forms.RadioButton();
            this.radioButtonContrast = new System.Windows.Forms.RadioButton();
            this.radioButtonGamma = new System.Windows.Forms.RadioButton();
            this.radioButtonBrightness = new System.Windows.Forms.RadioButton();
            this.radioButtonNegation = new System.Windows.Forms.RadioButton();
            this.radioButtonNoFilter = new System.Windows.Forms.RadioButton();
            this.pictureBoxOwnFunction = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelHistograms = new System.Windows.Forms.TableLayoutPanel();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.histR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.UserMenu.SuspendLayout();
            this.MenuFilters.SuspendLayout();
            this.MenuBrushType.SuspendLayout();
            this.tableLayoutPanelLabels.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnFunction)).BeginInit();
            this.tableLayoutPanelHistograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histB)).BeginInit();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 2;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.MainPanel.Controls.Add(this.UserMenu, 1, 0);
            this.MainPanel.Controls.Add(this.panelPhoto, 0, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 1;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Size = new System.Drawing.Size(1084, 587);
            this.MainPanel.TabIndex = 0;
            // 
            // UserMenu
            // 
            this.UserMenu.ColumnCount = 2;
            this.UserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.05447F));
            this.UserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.94553F));
            this.UserMenu.Controls.Add(this.MenuFilters, 0, 0);
            this.UserMenu.Controls.Add(this.tableLayoutPanelHistograms, 1, 0);
            this.UserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserMenu.Location = new System.Drawing.Point(587, 3);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.RowCount = 1;
            this.UserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserMenu.Size = new System.Drawing.Size(494, 581);
            this.UserMenu.TabIndex = 1;
            // 
            // MenuFilters
            // 
            this.MenuFilters.ColumnCount = 1;
            this.MenuFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuFilters.Controls.Add(this.MenuBrushType, 0, 0);
            this.MenuFilters.Controls.Add(this.groupBoxFilters, 0, 1);
            this.MenuFilters.Controls.Add(this.pictureBoxOwnFunction, 0, 2);
            this.MenuFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuFilters.Location = new System.Drawing.Point(3, 3);
            this.MenuFilters.Name = "MenuFilters";
            this.MenuFilters.RowCount = 3;
            this.MenuFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.83202F));
            this.MenuFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.16798F));
            this.MenuFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.MenuFilters.Size = new System.Drawing.Size(231, 575);
            this.MenuFilters.TabIndex = 0;
            // 
            // MenuBrushType
            // 
            this.MenuBrushType.ColumnCount = 1;
            this.MenuBrushType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuBrushType.Controls.Add(this.tableLayoutPanelLabels, 0, 0);
            this.MenuBrushType.Controls.Add(this.groupBoxMode, 0, 1);
            this.MenuBrushType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuBrushType.Location = new System.Drawing.Point(3, 3);
            this.MenuBrushType.Name = "MenuBrushType";
            this.MenuBrushType.RowCount = 2;
            this.MenuBrushType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90683F));
            this.MenuBrushType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.09317F));
            this.MenuBrushType.Size = new System.Drawing.Size(225, 161);
            this.MenuBrushType.TabIndex = 0;
            // 
            // tableLayoutPanelLabels
            // 
            this.tableLayoutPanelLabels.ColumnCount = 2;
            this.tableLayoutPanelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.13514F));
            this.tableLayoutPanelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.86487F));
            this.tableLayoutPanelLabels.Controls.Add(this.labelMode, 1, 0);
            this.tableLayoutPanelLabels.Controls.Add(this.labelStatic, 0, 0);
            this.tableLayoutPanelLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLabels.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLabels.Name = "tableLayoutPanelLabels";
            this.tableLayoutPanelLabels.RowCount = 1;
            this.tableLayoutPanelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLabels.Size = new System.Drawing.Size(219, 17);
            this.tableLayoutPanelLabels.TabIndex = 0;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMode.Location = new System.Drawing.Point(79, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(137, 17);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Brush";
            // 
            // labelStatic
            // 
            this.labelStatic.AutoSize = true;
            this.labelStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatic.Location = new System.Drawing.Point(3, 0);
            this.labelStatic.Name = "labelStatic";
            this.labelStatic.Size = new System.Drawing.Size(70, 17);
            this.labelStatic.TabIndex = 0;
            this.labelStatic.Text = "Selected:";
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.buttonWholePicture);
            this.groupBoxMode.Controls.Add(this.buttonDeletePolygon);
            this.groupBoxMode.Controls.Add(this.buttonBrush);
            this.groupBoxMode.Controls.Add(this.buttonAddPolygon);
            this.groupBoxMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMode.Location = new System.Drawing.Point(3, 26);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(219, 132);
            this.groupBoxMode.TabIndex = 1;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // buttonWholePicture
            // 
            this.buttonWholePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWholePicture.Location = new System.Drawing.Point(6, 106);
            this.buttonWholePicture.Name = "buttonWholePicture";
            this.buttonWholePicture.Size = new System.Drawing.Size(210, 23);
            this.buttonWholePicture.TabIndex = 3;
            this.buttonWholePicture.Text = "The whole picture";
            this.buttonWholePicture.UseVisualStyleBackColor = true;
            this.buttonWholePicture.Click += new System.EventHandler(this.buttonWholePicture_Click);
            // 
            // buttonDeletePolygon
            // 
            this.buttonDeletePolygon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePolygon.Location = new System.Drawing.Point(6, 48);
            this.buttonDeletePolygon.Name = "buttonDeletePolygon";
            this.buttonDeletePolygon.Size = new System.Drawing.Size(210, 23);
            this.buttonDeletePolygon.TabIndex = 2;
            this.buttonDeletePolygon.Text = "Delete Polygon";
            this.buttonDeletePolygon.UseVisualStyleBackColor = true;
            this.buttonDeletePolygon.Click += new System.EventHandler(this.buttonDeletePolygon_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrush.Location = new System.Drawing.Point(6, 77);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(210, 23);
            this.buttonBrush.TabIndex = 1;
            this.buttonBrush.Text = "Brush";
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonAddPolygon
            // 
            this.buttonAddPolygon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPolygon.Location = new System.Drawing.Point(6, 19);
            this.buttonAddPolygon.Name = "buttonAddPolygon";
            this.buttonAddPolygon.Size = new System.Drawing.Size(210, 23);
            this.buttonAddPolygon.TabIndex = 0;
            this.buttonAddPolygon.Text = "Add Polygon";
            this.buttonAddPolygon.UseVisualStyleBackColor = true;
            this.buttonAddPolygon.Click += new System.EventHandler(this.buttonAddPolygon_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.contrastAdd);
            this.groupBoxFilters.Controls.Add(this.contrastSub);
            this.groupBoxFilters.Controls.Add(this.gammaAdd);
            this.groupBoxFilters.Controls.Add(this.gammaSub);
            this.groupBoxFilters.Controls.Add(this.BrightnessAdd);
            this.groupBoxFilters.Controls.Add(this.BrightnessSub);
            this.groupBoxFilters.Controls.Add(this.radioButtonOwn);
            this.groupBoxFilters.Controls.Add(this.radioButtonContrast);
            this.groupBoxFilters.Controls.Add(this.radioButtonGamma);
            this.groupBoxFilters.Controls.Add(this.radioButtonBrightness);
            this.groupBoxFilters.Controls.Add(this.radioButtonNegation);
            this.groupBoxFilters.Controls.Add(this.radioButtonNoFilter);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilters.Location = new System.Drawing.Point(3, 170);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(225, 208);
            this.groupBoxFilters.TabIndex = 1;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // contrastAdd
            // 
            this.contrastAdd.Location = new System.Drawing.Point(173, 149);
            this.contrastAdd.Name = "contrastAdd";
            this.contrastAdd.Size = new System.Drawing.Size(28, 23);
            this.contrastAdd.TabIndex = 11;
            this.contrastAdd.Text = "+";
            this.contrastAdd.UseVisualStyleBackColor = true;
            this.contrastAdd.Click += new System.EventHandler(this.contrastAdd_Click);
            // 
            // contrastSub
            // 
            this.contrastSub.Location = new System.Drawing.Point(128, 149);
            this.contrastSub.Name = "contrastSub";
            this.contrastSub.Size = new System.Drawing.Size(28, 23);
            this.contrastSub.TabIndex = 10;
            this.contrastSub.Text = "-";
            this.contrastSub.UseVisualStyleBackColor = true;
            this.contrastSub.Click += new System.EventHandler(this.contrastSub_Click);
            // 
            // gammaAdd
            // 
            this.gammaAdd.Location = new System.Drawing.Point(173, 117);
            this.gammaAdd.Name = "gammaAdd";
            this.gammaAdd.Size = new System.Drawing.Size(28, 23);
            this.gammaAdd.TabIndex = 9;
            this.gammaAdd.Text = "+";
            this.gammaAdd.UseVisualStyleBackColor = true;
            this.gammaAdd.Click += new System.EventHandler(this.gammaAdd_Click);
            // 
            // gammaSub
            // 
            this.gammaSub.Location = new System.Drawing.Point(128, 117);
            this.gammaSub.Name = "gammaSub";
            this.gammaSub.Size = new System.Drawing.Size(28, 23);
            this.gammaSub.TabIndex = 8;
            this.gammaSub.Text = "-";
            this.gammaSub.UseVisualStyleBackColor = true;
            this.gammaSub.Click += new System.EventHandler(this.gammaSub_Click);
            // 
            // BrightnessAdd
            // 
            this.BrightnessAdd.Location = new System.Drawing.Point(173, 84);
            this.BrightnessAdd.Name = "BrightnessAdd";
            this.BrightnessAdd.Size = new System.Drawing.Size(28, 23);
            this.BrightnessAdd.TabIndex = 7;
            this.BrightnessAdd.Text = "+";
            this.BrightnessAdd.UseVisualStyleBackColor = true;
            this.BrightnessAdd.Click += new System.EventHandler(this.BrightnessAdd_Click);
            // 
            // BrightnessSub
            // 
            this.BrightnessSub.Location = new System.Drawing.Point(128, 84);
            this.BrightnessSub.Name = "BrightnessSub";
            this.BrightnessSub.Size = new System.Drawing.Size(28, 23);
            this.BrightnessSub.TabIndex = 6;
            this.BrightnessSub.Text = "-";
            this.BrightnessSub.UseVisualStyleBackColor = true;
            this.BrightnessSub.Click += new System.EventHandler(this.BrightnessSub_Click);
            // 
            // radioButtonOwn
            // 
            this.radioButtonOwn.AutoSize = true;
            this.radioButtonOwn.Location = new System.Drawing.Point(9, 181);
            this.radioButtonOwn.Name = "radioButtonOwn";
            this.radioButtonOwn.Size = new System.Drawing.Size(88, 17);
            this.radioButtonOwn.TabIndex = 5;
            this.radioButtonOwn.Text = "Own function";
            this.radioButtonOwn.UseVisualStyleBackColor = true;
            this.radioButtonOwn.Click += new System.EventHandler(this.radioButtonOwn_Click);
            // 
            // radioButtonContrast
            // 
            this.radioButtonContrast.AutoSize = true;
            this.radioButtonContrast.Location = new System.Drawing.Point(9, 152);
            this.radioButtonContrast.Name = "radioButtonContrast";
            this.radioButtonContrast.Size = new System.Drawing.Size(64, 17);
            this.radioButtonContrast.TabIndex = 4;
            this.radioButtonContrast.Text = "Contrast";
            this.radioButtonContrast.UseVisualStyleBackColor = true;
            this.radioButtonContrast.Click += new System.EventHandler(this.radioButtonContrast_Click);
            // 
            // radioButtonGamma
            // 
            this.radioButtonGamma.AutoSize = true;
            this.radioButtonGamma.Location = new System.Drawing.Point(9, 120);
            this.radioButtonGamma.Name = "radioButtonGamma";
            this.radioButtonGamma.Size = new System.Drawing.Size(111, 17);
            this.radioButtonGamma.TabIndex = 3;
            this.radioButtonGamma.Text = "Gamma correction";
            this.radioButtonGamma.UseVisualStyleBackColor = true;
            this.radioButtonGamma.Click += new System.EventHandler(this.radioButtonGamma_Click);
            // 
            // radioButtonBrightness
            // 
            this.radioButtonBrightness.AutoSize = true;
            this.radioButtonBrightness.Location = new System.Drawing.Point(9, 87);
            this.radioButtonBrightness.Name = "radioButtonBrightness";
            this.radioButtonBrightness.Size = new System.Drawing.Size(113, 17);
            this.radioButtonBrightness.TabIndex = 2;
            this.radioButtonBrightness.Text = "Brightness change";
            this.radioButtonBrightness.UseVisualStyleBackColor = true;
            this.radioButtonBrightness.Click += new System.EventHandler(this.radioButtonBrightness_Click);
            // 
            // radioButtonNegation
            // 
            this.radioButtonNegation.AutoSize = true;
            this.radioButtonNegation.Location = new System.Drawing.Point(9, 54);
            this.radioButtonNegation.Name = "radioButtonNegation";
            this.radioButtonNegation.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNegation.TabIndex = 1;
            this.radioButtonNegation.Text = "Negation";
            this.radioButtonNegation.UseVisualStyleBackColor = true;
            this.radioButtonNegation.Click += new System.EventHandler(this.radioButtonNegation_Click);
            // 
            // radioButtonNoFilter
            // 
            this.radioButtonNoFilter.AutoSize = true;
            this.radioButtonNoFilter.Checked = true;
            this.radioButtonNoFilter.Location = new System.Drawing.Point(9, 19);
            this.radioButtonNoFilter.Name = "radioButtonNoFilter";
            this.radioButtonNoFilter.Size = new System.Drawing.Size(61, 17);
            this.radioButtonNoFilter.TabIndex = 0;
            this.radioButtonNoFilter.TabStop = true;
            this.radioButtonNoFilter.Text = "No filter";
            this.radioButtonNoFilter.UseVisualStyleBackColor = true;
            this.radioButtonNoFilter.Click += new System.EventHandler(this.radioButtonNoFilter_Click);
            // 
            // pictureBoxOwnFunction
            // 
            this.pictureBoxOwnFunction.BackColor = System.Drawing.Color.White;
            this.pictureBoxOwnFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOwnFunction.Location = new System.Drawing.Point(3, 384);
            this.pictureBoxOwnFunction.Name = "pictureBoxOwnFunction";
            this.pictureBoxOwnFunction.Size = new System.Drawing.Size(225, 188);
            this.pictureBoxOwnFunction.TabIndex = 2;
            this.pictureBoxOwnFunction.TabStop = false;
            this.pictureBoxOwnFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOwnFunction_MouseDown);
            this.pictureBoxOwnFunction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOwnFunction_MouseMove);
            this.pictureBoxOwnFunction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOwnFunction_MouseUp);
            // 
            // tableLayoutPanelHistograms
            // 
            this.tableLayoutPanelHistograms.ColumnCount = 1;
            this.tableLayoutPanelHistograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHistograms.Controls.Add(this.labelB, 0, 4);
            this.tableLayoutPanelHistograms.Controls.Add(this.labelG, 0, 2);
            this.tableLayoutPanelHistograms.Controls.Add(this.labelR, 0, 0);
            this.tableLayoutPanelHistograms.Controls.Add(this.histR, 0, 1);
            this.tableLayoutPanelHistograms.Controls.Add(this.histG, 0, 3);
            this.tableLayoutPanelHistograms.Controls.Add(this.histB, 0, 5);
            this.tableLayoutPanelHistograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHistograms.Location = new System.Drawing.Point(240, 3);
            this.tableLayoutPanelHistograms.Name = "tableLayoutPanelHistograms";
            this.tableLayoutPanelHistograms.RowCount = 6;
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.72277F));
            this.tableLayoutPanelHistograms.Size = new System.Drawing.Size(251, 575);
            this.tableLayoutPanelHistograms.TabIndex = 1;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.Location = new System.Drawing.Point(3, 386);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(245, 28);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B:";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelG.Location = new System.Drawing.Point(3, 193);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(245, 28);
            this.labelG.TabIndex = 3;
            this.labelG.Text = "G:";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelR.Location = new System.Drawing.Point(3, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(245, 28);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "R:";
            // 
            // histR
            // 
            chartArea7.Name = "ChartArea1";
            this.histR.ChartAreas.Add(chartArea7);
            this.histR.Location = new System.Drawing.Point(3, 31);
            this.histR.Name = "histR";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.histR.Series.Add(series7);
            this.histR.Size = new System.Drawing.Size(245, 144);
            this.histR.TabIndex = 7;
            this.histR.Text = "histogramr";
            // 
            // histG
            // 
            chartArea8.Name = "ChartArea1";
            this.histG.ChartAreas.Add(chartArea8);
            this.histG.Location = new System.Drawing.Point(3, 224);
            this.histG.Name = "histG";
            series8.ChartArea = "ChartArea1";
            series8.Name = "Series1";
            this.histG.Series.Add(series8);
            this.histG.Size = new System.Drawing.Size(245, 144);
            this.histG.TabIndex = 8;
            this.histG.Text = "chart1";
            // 
            // histB
            // 
            chartArea9.Name = "ChartArea1";
            this.histB.ChartAreas.Add(chartArea9);
            this.histB.Location = new System.Drawing.Point(3, 417);
            this.histB.Name = "histB";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.histB.Series.Add(series9);
            this.histB.Size = new System.Drawing.Size(245, 144);
            this.histB.TabIndex = 9;
            this.histB.Text = "chart1";
            // 
            // panelPhoto
            // 
            this.panelPhoto.AutoScroll = true;
            this.panelPhoto.Controls.Add(this.pictureBox);
            this.panelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhoto.Location = new System.Drawing.Point(3, 3);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(578, 581);
            this.panelPhoto.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.MaximumSize = new System.Drawing.Size(0, 9999);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(0, 531);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveFunctionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveFunctionToolStripMenuItem
            // 
            this.saveFunctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem1});
            this.saveFunctionToolStripMenuItem.Name = "saveFunctionToolStripMenuItem";
            this.saveFunctionToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.saveFunctionToolStripMenuItem.Text = "Own function";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.Text = "Photo Filters";
            this.MainPanel.ResumeLayout(false);
            this.UserMenu.ResumeLayout(false);
            this.MenuFilters.ResumeLayout(false);
            this.MenuBrushType.ResumeLayout(false);
            this.tableLayoutPanelLabels.ResumeLayout(false);
            this.tableLayoutPanelLabels.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnFunction)).EndInit();
            this.tableLayoutPanelHistograms.ResumeLayout(false);
            this.tableLayoutPanelHistograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histB)).EndInit();
            this.panelPhoto.ResumeLayout(false);
            this.panelPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel UserMenu;
        private System.Windows.Forms.TableLayoutPanel MenuFilters;
        private System.Windows.Forms.TableLayoutPanel MenuBrushType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLabels;
        private System.Windows.Forms.Label labelStatic;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Button buttonDeletePolygon;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonAddPolygon;
        private System.Windows.Forms.Button buttonWholePicture;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.RadioButton radioButtonOwn;
        private System.Windows.Forms.RadioButton radioButtonContrast;
        private System.Windows.Forms.RadioButton radioButtonGamma;
        private System.Windows.Forms.RadioButton radioButtonBrightness;
        private System.Windows.Forms.RadioButton radioButtonNegation;
        private System.Windows.Forms.RadioButton radioButtonNoFilter;
        private System.Windows.Forms.PictureBox pictureBoxOwnFunction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHistograms;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart histR;
        private System.Windows.Forms.DataVisualization.Charting.Chart histG;
        private System.Windows.Forms.DataVisualization.Charting.Chart histB;
        private System.Windows.Forms.Button BrightnessAdd;
        private System.Windows.Forms.Button BrightnessSub;
        private System.Windows.Forms.Button gammaAdd;
        private System.Windows.Forms.Button gammaSub;
        private System.Windows.Forms.Button contrastAdd;
        private System.Windows.Forms.Button contrastSub;
        private System.Windows.Forms.ToolStripMenuItem saveFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
    }
}

