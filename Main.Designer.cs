namespace BumpMaker
{
    partial class _frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmMain));
            this._btnProcess = new System.Windows.Forms.Button();
            this._btnOpenFileLoc = new System.Windows.Forms.Button();
            this._txtFileLoc = new System.Windows.Forms.TextBox();
            this._tabControl0 = new System.Windows.Forms.TabControl();
            this._tabLoaded = new System.Windows.Forms.TabPage();
            this._pbLoaded = new System.Windows.Forms.PictureBox();
            this._tabResult = new System.Windows.Forms.TabPage();
            this._pbResult = new System.Windows.Forms.PictureBox();
            this._statStrip0 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lblWidth = new System.Windows.Forms.Label();
            this._lblHeight = new System.Windows.Forms.Label();
            this._pgbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._tbBumpAmount = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this._cboMapType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cboOutputFileExt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtOutputFileNamer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtOutputFilename = new System.Windows.Forms.TextBox();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tbContrast = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this._lblBumpAmount = new System.Windows.Forms.TextBox();
            this._lblContrastValue = new System.Windows.Forms.TextBox();
            this._tabControl0.SuspendLayout();
            this._tabLoaded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbLoaded)).BeginInit();
            this._tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbResult)).BeginInit();
            this._statStrip0.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbBumpAmount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnProcess
            // 
            this._btnProcess.BackColor = System.Drawing.Color.Lime;
            this._btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnProcess.Location = new System.Drawing.Point(12, 320);
            this._btnProcess.Name = "_btnProcess";
            this._btnProcess.Size = new System.Drawing.Size(126, 55);
            this._btnProcess.TabIndex = 0;
            this._btnProcess.Text = "Process";
            this._btnProcess.UseVisualStyleBackColor = false;
            this._btnProcess.Click += new System.EventHandler(this._btnProcess_Click);
            // 
            // _btnOpenFileLoc
            // 
            this._btnOpenFileLoc.Location = new System.Drawing.Point(74, 45);
            this._btnOpenFileLoc.Name = "_btnOpenFileLoc";
            this._btnOpenFileLoc.Size = new System.Drawing.Size(26, 23);
            this._btnOpenFileLoc.TabIndex = 0;
            this._btnOpenFileLoc.Text = "...";
            this._btnOpenFileLoc.UseVisualStyleBackColor = true;
            this._btnOpenFileLoc.Click += new System.EventHandler(this._btnOpenFileLoc_Click);
            // 
            // _txtFileLoc
            // 
            this._txtFileLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFileLoc.Location = new System.Drawing.Point(102, 45);
            this._txtFileLoc.Name = "_txtFileLoc";
            this._txtFileLoc.Size = new System.Drawing.Size(202, 22);
            this._txtFileLoc.TabIndex = 2;
            // 
            // _tabControl0
            // 
            this._tabControl0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl0.Controls.Add(this._tabLoaded);
            this._tabControl0.Controls.Add(this._tabResult);
            this._tabControl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabControl0.Location = new System.Drawing.Point(12, 401);
            this._tabControl0.Name = "_tabControl0";
            this._tabControl0.SelectedIndex = 0;
            this._tabControl0.Size = new System.Drawing.Size(351, 262);
            this._tabControl0.TabIndex = 3;
            // 
            // _tabLoaded
            // 
            this._tabLoaded.Controls.Add(this._pbLoaded);
            this._tabLoaded.Location = new System.Drawing.Point(4, 25);
            this._tabLoaded.Name = "_tabLoaded";
            this._tabLoaded.Padding = new System.Windows.Forms.Padding(3);
            this._tabLoaded.Size = new System.Drawing.Size(343, 233);
            this._tabLoaded.TabIndex = 0;
            this._tabLoaded.Text = "Loaded";
            this._tabLoaded.UseVisualStyleBackColor = true;
            // 
            // _pbLoaded
            // 
            this._pbLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pbLoaded.Location = new System.Drawing.Point(3, 3);
            this._pbLoaded.Name = "_pbLoaded";
            this._pbLoaded.Size = new System.Drawing.Size(337, 227);
            this._pbLoaded.TabIndex = 0;
            this._pbLoaded.TabStop = false;
            // 
            // _tabResult
            // 
            this._tabResult.Controls.Add(this._pbResult);
            this._tabResult.Location = new System.Drawing.Point(4, 22);
            this._tabResult.Name = "_tabResult";
            this._tabResult.Padding = new System.Windows.Forms.Padding(3);
            this._tabResult.Size = new System.Drawing.Size(252, 242);
            this._tabResult.TabIndex = 1;
            this._tabResult.Text = "Result";
            this._tabResult.UseVisualStyleBackColor = true;
            // 
            // _pbResult
            // 
            this._pbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pbResult.Location = new System.Drawing.Point(3, 3);
            this._pbResult.Name = "_pbResult";
            this._pbResult.Size = new System.Drawing.Size(246, 236);
            this._pbResult.TabIndex = 0;
            this._pbResult.TabStop = false;
            // 
            // _statStrip0
            // 
            this._statStrip0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._pgbProgress,
            this._lblStatus});
            this._statStrip0.Location = new System.Drawing.Point(0, 666);
            this._statStrip0.Name = "_statStrip0";
            this._statStrip0.Size = new System.Drawing.Size(375, 22);
            this._statStrip0.TabIndex = 4;
            this._statStrip0.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._lblHeight);
            this.groupBox1.Controls.Add(this._lblWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(144, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height:";
            // 
            // _lblWidth
            // 
            this._lblWidth.AutoSize = true;
            this._lblWidth.Location = new System.Drawing.Point(90, 20);
            this._lblWidth.Name = "_lblWidth";
            this._lblWidth.Size = new System.Drawing.Size(15, 16);
            this._lblWidth.TabIndex = 0;
            this._lblWidth.Text = "0";
            this._lblWidth.Click += new System.EventHandler(this._lblWidth_Click);
            // 
            // _lblHeight
            // 
            this._lblHeight.AutoSize = true;
            this._lblHeight.Location = new System.Drawing.Point(90, 37);
            this._lblHeight.Name = "_lblHeight";
            this._lblHeight.Size = new System.Drawing.Size(15, 16);
            this._lblHeight.TabIndex = 0;
            this._lblHeight.Text = "0";
            this._lblHeight.Click += new System.EventHandler(this._lblHeight_Click);
            // 
            // _pgbProgress
            // 
            this._pgbProgress.Name = "_pgbProgress";
            this._pgbProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._lblContrastValue);
            this.groupBox2.Controls.Add(this._lblBumpAmount);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this._cboMapType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this._tbContrast);
            this.groupBox2.Controls.Add(this._tbBumpAmount);
            this.groupBox2.Controls.Add(this._txtFileLoc);
            this.groupBox2.Controls.Add(this._btnOpenFileLoc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // _tbBumpAmount
            // 
            this._tbBumpAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbBumpAmount.LargeChange = 10000;
            this._tbBumpAmount.Location = new System.Drawing.Point(74, 74);
            this._tbBumpAmount.Maximum = 100000;
            this._tbBumpAmount.Name = "_tbBumpAmount";
            this._tbBumpAmount.Size = new System.Drawing.Size(219, 45);
            this._tbBumpAmount.TabIndex = 0;
            this._tbBumpAmount.TickStyle = System.Windows.Forms.TickStyle.None;
            this._tbBumpAmount.Value = 80000;
            this._tbBumpAmount.Scroll += new System.EventHandler(this._tbBumpAmount_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bumpiness:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _cboMapType
            // 
            this._cboMapType.FormattingEnabled = true;
            this._cboMapType.Items.AddRange(new object[] {
            "Normal",
            "Bump"});
            this._cboMapType.Location = new System.Drawing.Point(82, 132);
            this._cboMapType.Name = "_cboMapType";
            this._cboMapType.Size = new System.Drawing.Size(132, 24);
            this._cboMapType.TabIndex = 2;
            this._cboMapType.Text = "Bump";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Map Type:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(48, 17);
            this._lblStatus.Text = "Waiting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "File Path:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveResultToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsageToolStripMenuItem
            // 
            this.aboutUsageToolStripMenuItem.Name = "aboutUsageToolStripMenuItem";
            this.aboutUsageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutUsageToolStripMenuItem.Text = "About / Usage";
            this.aboutUsageToolStripMenuItem.Click += new System.EventHandler(this.aboutUsageToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single Image",
            "Batch"});
            this.comboBox1.Location = new System.Drawing.Point(111, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Single Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Program Mode:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._cboOutputFileExt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._txtOutputFilename);
            this.groupBox3.Controls.Add(this._txtOutputFileNamer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 112);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // _cboOutputFileExt
            // 
            this._cboOutputFileExt.FormattingEnabled = true;
            this._cboOutputFileExt.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".gif",
            ".bmp"});
            this._cboOutputFileExt.Location = new System.Drawing.Point(82, 46);
            this._cboOutputFileExt.Name = "_cboOutputFileExt";
            this._cboOutputFileExt.Size = new System.Drawing.Size(72, 24);
            this._cboOutputFileExt.TabIndex = 4;
            this._cboOutputFileExt.Text = ".png";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Save As:";
            // 
            // _txtOutputFileNamer
            // 
            this._txtOutputFileNamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOutputFileNamer.Location = new System.Drawing.Point(149, 79);
            this._txtOutputFileNamer.Name = "_txtOutputFileNamer";
            this._txtOutputFileNamer.Size = new System.Drawing.Size(82, 22);
            this._txtOutputFileNamer.TabIndex = 2;
            this._txtOutputFileNamer.Text = "_n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "File Name \"modifier\":";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Filename:";
            // 
            // _txtOutputFilename
            // 
            this._txtOutputFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOutputFilename.Location = new System.Drawing.Point(82, 16);
            this._txtOutputFilename.Name = "_txtOutputFilename";
            this._txtOutputFilename.Size = new System.Drawing.Size(146, 22);
            this._txtOutputFilename.TabIndex = 2;
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveResultToolStripMenuItem.Text = "Save As..";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // _tbContrast
            // 
            this._tbContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbContrast.LargeChange = 10000;
            this._tbContrast.Location = new System.Drawing.Point(62, 106);
            this._tbContrast.Maximum = 100000;
            this._tbContrast.Name = "_tbContrast";
            this._tbContrast.Size = new System.Drawing.Size(179, 45);
            this._tbContrast.TabIndex = 0;
            this._tbContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this._tbContrast.Value = 80000;
            this._tbContrast.Scroll += new System.EventHandler(this._tbBumpAmount_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Contrast:";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // _lblBumpAmount
            // 
            this._lblBumpAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblBumpAmount.Location = new System.Drawing.Point(300, 74);
            this._lblBumpAmount.Name = "_lblBumpAmount";
            this._lblBumpAmount.Size = new System.Drawing.Size(55, 22);
            this._lblBumpAmount.TabIndex = 3;
            this._lblBumpAmount.TextChanged += new System.EventHandler(this._lblBumpAmount_TextChanged);
            // 
            // _lblContrastValue
            // 
            this._lblContrastValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblContrastValue.Location = new System.Drawing.Point(300, 103);
            this._lblContrastValue.Name = "_lblContrastValue";
            this._lblContrastValue.Size = new System.Drawing.Size(55, 22);
            this._lblContrastValue.TabIndex = 3;
            this._lblContrastValue.TextChanged += new System.EventHandler(this._lblContrastValue_TextChanged);
            // 
            // _frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 688);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._statStrip0);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._tabControl0);
            this.Controls.Add(this._btnProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_frmMain";
            this.Text = "Normal/Bump Map Maker";
            this._tabControl0.ResumeLayout(false);
            this._tabLoaded.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbLoaded)).EndInit();
            this._tabResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbResult)).EndInit();
            this._statStrip0.ResumeLayout(false);
            this._statStrip0.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbBumpAmount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnProcess;
        private System.Windows.Forms.Button _btnOpenFileLoc;
        private System.Windows.Forms.TextBox _txtFileLoc;
        private System.Windows.Forms.TabControl _tabControl0;
        private System.Windows.Forms.TabPage _tabLoaded;
        private System.Windows.Forms.PictureBox _pbLoaded;
        private System.Windows.Forms.TabPage _tabResult;
        private System.Windows.Forms.PictureBox _pbResult;
        private System.Windows.Forms.StatusStrip _statStrip0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblHeight;
        private System.Windows.Forms.Label _lblWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripProgressBar _pgbProgress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar _tbBumpAmount;
        private System.Windows.Forms.ComboBox _cboMapType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsageToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _cboOutputFileExt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtOutputFileNamer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtOutputFilename;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar _tbContrast;
        private System.Windows.Forms.TextBox _lblContrastValue;
        private System.Windows.Forms.TextBox _lblBumpAmount;
    }
}

