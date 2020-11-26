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
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.UserMenu = new System.Windows.Forms.TableLayoutPanel();
            this.MenuFilters = new System.Windows.Forms.TableLayoutPanel();
            this.MenuBrushType = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLabels = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatic = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMode = new System.Windows.Forms.Label();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.buttonAddPolygon = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonDeletePolygon = new System.Windows.Forms.Button();
            this.buttonWholePicture = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.radioButtonNoFilter = new System.Windows.Forms.RadioButton();
            this.radioButtonNegation = new System.Windows.Forms.RadioButton();
            this.radioButtonBrightness = new System.Windows.Forms.RadioButton();
            this.radioButtonGamma = new System.Windows.Forms.RadioButton();
            this.radioButtonContrast = new System.Windows.Forms.RadioButton();
            this.radioButtonOwn = new System.Windows.Forms.RadioButton();
            this.pictureBoxOwnFunction = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelHistograms = new System.Windows.Forms.TableLayoutPanel();
            this.labelR = new System.Windows.Forms.Label();
            this.pictureBoxHisR = new System.Windows.Forms.PictureBox();
            this.labelG = new System.Windows.Forms.Label();
            this.pictureBoxHisG = new System.Windows.Forms.PictureBox();
            this.labelB = new System.Windows.Forms.Label();
            this.pictureBoxHisB = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.UserMenu.SuspendLayout();
            this.MenuFilters.SuspendLayout();
            this.MenuBrushType.SuspendLayout();
            this.tableLayoutPanelLabels.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnFunction)).BeginInit();
            this.tableLayoutPanelHistograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHisR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHisG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHisB)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 2;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27236F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72764F));
            this.MainPanel.Controls.Add(this.pictureBox, 0, 0);
            this.MainPanel.Controls.Add(this.UserMenu, 1, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 1;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Size = new System.Drawing.Size(984, 537);
            this.MainPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(469, 531);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // UserMenu
            // 
            this.UserMenu.ColumnCount = 2;
            this.UserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.54865F));
            this.UserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.45135F));
            this.UserMenu.Controls.Add(this.MenuFilters, 0, 0);
            this.UserMenu.Controls.Add(this.tableLayoutPanelHistograms, 1, 0);
            this.UserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserMenu.Location = new System.Drawing.Point(478, 3);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.RowCount = 1;
            this.UserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserMenu.Size = new System.Drawing.Size(503, 531);
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
            this.MenuFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.03489F));
            this.MenuFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.96511F));
            this.MenuFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.MenuFilters.Size = new System.Drawing.Size(223, 525);
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
            this.MenuBrushType.Size = new System.Drawing.Size(217, 173);
            this.MenuBrushType.TabIndex = 0;
            // 
            // tableLayoutPanelLabels
            // 
            this.tableLayoutPanelLabels.ColumnCount = 2;
            this.tableLayoutPanelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.57576F));
            this.tableLayoutPanelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tableLayoutPanelLabels.Controls.Add(this.labelMode, 1, 0);
            this.tableLayoutPanelLabels.Controls.Add(this.labelStatic, 0, 0);
            this.tableLayoutPanelLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLabels.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLabels.Name = "tableLayoutPanelLabels";
            this.tableLayoutPanelLabels.RowCount = 1;
            this.tableLayoutPanelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLabels.Size = new System.Drawing.Size(211, 19);
            this.tableLayoutPanelLabels.TabIndex = 0;
            // 
            // labelStatic
            // 
            this.labelStatic.AutoSize = true;
            this.labelStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatic.Location = new System.Drawing.Point(3, 0);
            this.labelStatic.Name = "labelStatic";
            this.labelStatic.Size = new System.Drawing.Size(115, 19);
            this.labelStatic.TabIndex = 0;
            this.labelStatic.Text = "Selected mode:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMode.Location = new System.Drawing.Point(124, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(84, 19);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Brush";
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.buttonWholePicture);
            this.groupBoxMode.Controls.Add(this.buttonDeletePolygon);
            this.groupBoxMode.Controls.Add(this.buttonBrush);
            this.groupBoxMode.Controls.Add(this.buttonAddPolygon);
            this.groupBoxMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMode.Location = new System.Drawing.Point(3, 28);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(211, 142);
            this.groupBoxMode.TabIndex = 1;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // buttonAddPolygon
            // 
            this.buttonAddPolygon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPolygon.Location = new System.Drawing.Point(6, 19);
            this.buttonAddPolygon.Name = "buttonAddPolygon";
            this.buttonAddPolygon.Size = new System.Drawing.Size(202, 23);
            this.buttonAddPolygon.TabIndex = 0;
            this.buttonAddPolygon.Text = "Add Polygon";
            this.buttonAddPolygon.UseVisualStyleBackColor = true;
            // 
            // buttonBrush
            // 
            this.buttonBrush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrush.Location = new System.Drawing.Point(6, 77);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(202, 23);
            this.buttonBrush.TabIndex = 1;
            this.buttonBrush.Text = "Brush";
            this.buttonBrush.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePolygon
            // 
            this.buttonDeletePolygon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePolygon.Location = new System.Drawing.Point(6, 48);
            this.buttonDeletePolygon.Name = "buttonDeletePolygon";
            this.buttonDeletePolygon.Size = new System.Drawing.Size(202, 23);
            this.buttonDeletePolygon.TabIndex = 2;
            this.buttonDeletePolygon.Text = "Delete Polygon";
            this.buttonDeletePolygon.UseVisualStyleBackColor = true;
            // 
            // buttonWholePicture
            // 
            this.buttonWholePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWholePicture.Location = new System.Drawing.Point(6, 106);
            this.buttonWholePicture.Name = "buttonWholePicture";
            this.buttonWholePicture.Size = new System.Drawing.Size(202, 23);
            this.buttonWholePicture.TabIndex = 3;
            this.buttonWholePicture.Text = "The whole picture";
            this.buttonWholePicture.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.radioButtonOwn);
            this.groupBoxFilters.Controls.Add(this.radioButtonContrast);
            this.groupBoxFilters.Controls.Add(this.radioButtonGamma);
            this.groupBoxFilters.Controls.Add(this.radioButtonBrightness);
            this.groupBoxFilters.Controls.Add(this.radioButtonNegation);
            this.groupBoxFilters.Controls.Add(this.radioButtonNoFilter);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilters.Location = new System.Drawing.Point(3, 182);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(217, 159);
            this.groupBoxFilters.TabIndex = 1;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
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
            // 
            // radioButtonNegation
            // 
            this.radioButtonNegation.AutoSize = true;
            this.radioButtonNegation.Location = new System.Drawing.Point(9, 42);
            this.radioButtonNegation.Name = "radioButtonNegation";
            this.radioButtonNegation.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNegation.TabIndex = 1;
            this.radioButtonNegation.Text = "Negation";
            this.radioButtonNegation.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrightness
            // 
            this.radioButtonBrightness.AutoSize = true;
            this.radioButtonBrightness.Location = new System.Drawing.Point(9, 65);
            this.radioButtonBrightness.Name = "radioButtonBrightness";
            this.radioButtonBrightness.Size = new System.Drawing.Size(113, 17);
            this.radioButtonBrightness.TabIndex = 2;
            this.radioButtonBrightness.Text = "Brightness change";
            this.radioButtonBrightness.UseVisualStyleBackColor = true;
            // 
            // radioButtonGamma
            // 
            this.radioButtonGamma.AutoSize = true;
            this.radioButtonGamma.Location = new System.Drawing.Point(9, 88);
            this.radioButtonGamma.Name = "radioButtonGamma";
            this.radioButtonGamma.Size = new System.Drawing.Size(111, 17);
            this.radioButtonGamma.TabIndex = 3;
            this.radioButtonGamma.Text = "Gamma correction";
            this.radioButtonGamma.UseVisualStyleBackColor = true;
            // 
            // radioButtonContrast
            // 
            this.radioButtonContrast.AutoSize = true;
            this.radioButtonContrast.Location = new System.Drawing.Point(9, 111);
            this.radioButtonContrast.Name = "radioButtonContrast";
            this.radioButtonContrast.Size = new System.Drawing.Size(64, 17);
            this.radioButtonContrast.TabIndex = 4;
            this.radioButtonContrast.Text = "Contrast";
            this.radioButtonContrast.UseVisualStyleBackColor = true;
            // 
            // radioButtonOwn
            // 
            this.radioButtonOwn.AutoSize = true;
            this.radioButtonOwn.Location = new System.Drawing.Point(9, 134);
            this.radioButtonOwn.Name = "radioButtonOwn";
            this.radioButtonOwn.Size = new System.Drawing.Size(88, 17);
            this.radioButtonOwn.TabIndex = 5;
            this.radioButtonOwn.Text = "Own function";
            this.radioButtonOwn.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOwnFunction
            // 
            this.pictureBoxOwnFunction.BackColor = System.Drawing.Color.White;
            this.pictureBoxOwnFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOwnFunction.Location = new System.Drawing.Point(3, 347);
            this.pictureBoxOwnFunction.Name = "pictureBoxOwnFunction";
            this.pictureBoxOwnFunction.Size = new System.Drawing.Size(217, 175);
            this.pictureBoxOwnFunction.TabIndex = 2;
            this.pictureBoxOwnFunction.TabStop = false;
            // 
            // tableLayoutPanelHistograms
            // 
            this.tableLayoutPanelHistograms.ColumnCount = 1;
            this.tableLayoutPanelHistograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHistograms.Controls.Add(this.labelB, 0, 4);
            this.tableLayoutPanelHistograms.Controls.Add(this.labelG, 0, 2);
            this.tableLayoutPanelHistograms.Controls.Add(this.labelR, 0, 0);
            this.tableLayoutPanelHistograms.Controls.Add(this.pictureBoxHisR, 0, 1);
            this.tableLayoutPanelHistograms.Controls.Add(this.pictureBoxHisG, 0, 3);
            this.tableLayoutPanelHistograms.Controls.Add(this.pictureBoxHisB, 0, 5);
            this.tableLayoutPanelHistograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHistograms.Location = new System.Drawing.Point(232, 3);
            this.tableLayoutPanelHistograms.Name = "tableLayoutPanelHistograms";
            this.tableLayoutPanelHistograms.RowCount = 6;
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanelHistograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.72277F));
            this.tableLayoutPanelHistograms.Size = new System.Drawing.Size(268, 525);
            this.tableLayoutPanelHistograms.TabIndex = 1;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelR.Location = new System.Drawing.Point(3, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(262, 25);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "R:";
            // 
            // pictureBoxHisR
            // 
            this.pictureBoxHisR.BackColor = System.Drawing.Color.White;
            this.pictureBoxHisR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHisR.Location = new System.Drawing.Point(3, 28);
            this.pictureBoxHisR.Name = "pictureBoxHisR";
            this.pictureBoxHisR.Size = new System.Drawing.Size(262, 144);
            this.pictureBoxHisR.TabIndex = 2;
            this.pictureBoxHisR.TabStop = false;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelG.Location = new System.Drawing.Point(3, 175);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(262, 25);
            this.labelG.TabIndex = 3;
            this.labelG.Text = "G:";
            // 
            // pictureBoxHisG
            // 
            this.pictureBoxHisG.BackColor = System.Drawing.Color.White;
            this.pictureBoxHisG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHisG.Location = new System.Drawing.Point(3, 203);
            this.pictureBoxHisG.Name = "pictureBoxHisG";
            this.pictureBoxHisG.Size = new System.Drawing.Size(262, 144);
            this.pictureBoxHisG.TabIndex = 4;
            this.pictureBoxHisG.TabStop = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.Location = new System.Drawing.Point(3, 350);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(262, 25);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B:";
            // 
            // pictureBoxHisB
            // 
            this.pictureBoxHisB.BackColor = System.Drawing.Color.White;
            this.pictureBoxHisB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHisB.Location = new System.Drawing.Point(3, 378);
            this.pictureBoxHisB.Name = "pictureBoxHisB";
            this.pictureBoxHisB.Size = new System.Drawing.Size(262, 144);
            this.pictureBoxHisB.TabIndex = 6;
            this.pictureBoxHisB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Photo Filters";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.UserMenu.ResumeLayout(false);
            this.MenuFilters.ResumeLayout(false);
            this.MenuBrushType.ResumeLayout(false);
            this.tableLayoutPanelLabels.ResumeLayout(false);
            this.tableLayoutPanelLabels.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnFunction)).EndInit();
            this.tableLayoutPanelHistograms.ResumeLayout(false);
            this.tableLayoutPanelHistograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHisR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHisG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHisB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel UserMenu;
        private System.Windows.Forms.TableLayoutPanel MenuFilters;
        private System.Windows.Forms.TableLayoutPanel MenuBrushType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
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
        private System.Windows.Forms.PictureBox pictureBoxHisR;
        private System.Windows.Forms.PictureBox pictureBoxHisG;
        private System.Windows.Forms.PictureBox pictureBoxHisB;
    }
}

