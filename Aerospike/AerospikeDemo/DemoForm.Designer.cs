namespace Aerospike.Demo
{
    partial class DemoForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.benchmarkPanel = new System.Windows.Forms.Panel();
            this.replicaBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.batchSizeLabel = new System.Windows.Forms.Label();
            this.batchSizeBox = new System.Windows.Forms.TextBox();
            this.batchReadBox = new System.Windows.Forms.CheckBox();
            this.initializePanel = new System.Windows.Forms.Panel();
            this.initPctLabel = new System.Windows.Forms.Label();
            this.initPctBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workloadPanel = new System.Windows.Forms.Panel();
            this.readModeSCBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.readModeAPBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.writeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.readBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dynamicValueButton = new System.Windows.Forms.RadioButton();
            this.fixedValueButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threadPanel = new System.Windows.Forms.Panel();
            this.limitTpsBox = new System.Windows.Forms.CheckBox();
            this.throughputBox = new System.Windows.Forms.TextBox();
            this.syncThreadBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.asyncButton = new System.Windows.Forms.RadioButton();
            this.syncButton = new System.Windows.Forms.RadioButton();
            this.maxCommandPanel = new System.Windows.Forms.Panel();
            this.asyncThreadBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.maxCommandBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.latencyGroup = new System.Windows.Forms.GroupBox();
            this.latencyAltFormatBox = new System.Windows.Forms.CheckBox();
            this.latencyDisplayLabel = new System.Windows.Forms.TextBox();
            this.latencyColumnsLabel = new System.Windows.Forms.Label();
            this.latencyColumnsBox = new System.Windows.Forms.TextBox();
            this.latencyShiftLabel = new System.Windows.Forms.Label();
            this.latencyShiftBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.debugBox = new System.Windows.Forms.CheckBox();
            this.latencyBox = new System.Windows.Forms.CheckBox();
            this.sleepBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.maxRetriesBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timeoutBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.binSizeBox = new System.Windows.Forms.TextBox();
            this.binSizeLabel = new System.Windows.Forms.Label();
            this.binTypeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recordsBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.nsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.setBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.examplesView = new System.Windows.Forms.TreeView();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.benchmarkPanel.SuspendLayout();
            this.initializePanel.SuspendLayout();
            this.workloadPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.threadPanel.SuspendLayout();
            this.maxCommandPanel.SuspendLayout();
            this.latencyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(207, 49);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.benchmarkPanel);
            this.splitContainer1.Panel1.Controls.Add(this.codeBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.consoleBox);
            this.splitContainer1.Panel2.Controls.Add(this.stopButton);
            this.splitContainer1.Panel2.Controls.Add(this.runButton);
            this.splitContainer1.Size = new System.Drawing.Size(1368, 1120);
            this.splitContainer1.SplitterDistance = 593;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 0;
            // 
            // benchmarkPanel
            // 
            this.benchmarkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.benchmarkPanel.Controls.Add(this.replicaBox);
            this.benchmarkPanel.Controls.Add(this.label19);
            this.benchmarkPanel.Controls.Add(this.batchSizeLabel);
            this.benchmarkPanel.Controls.Add(this.batchSizeBox);
            this.benchmarkPanel.Controls.Add(this.batchReadBox);
            this.benchmarkPanel.Controls.Add(this.initializePanel);
            this.benchmarkPanel.Controls.Add(this.workloadPanel);
            this.benchmarkPanel.Controls.Add(this.panel1);
            this.benchmarkPanel.Controls.Add(this.groupBox1);
            this.benchmarkPanel.Controls.Add(this.latencyGroup);
            this.benchmarkPanel.Controls.Add(this.label20);
            this.benchmarkPanel.Controls.Add(this.debugBox);
            this.benchmarkPanel.Controls.Add(this.latencyBox);
            this.benchmarkPanel.Controls.Add(this.sleepBox);
            this.benchmarkPanel.Controls.Add(this.label17);
            this.benchmarkPanel.Controls.Add(this.maxRetriesBox);
            this.benchmarkPanel.Controls.Add(this.label16);
            this.benchmarkPanel.Controls.Add(this.label15);
            this.benchmarkPanel.Controls.Add(this.timeoutBox);
            this.benchmarkPanel.Controls.Add(this.label14);
            this.benchmarkPanel.Controls.Add(this.binSizeBox);
            this.benchmarkPanel.Controls.Add(this.binSizeLabel);
            this.benchmarkPanel.Controls.Add(this.binTypeBox);
            this.benchmarkPanel.Controls.Add(this.label6);
            this.benchmarkPanel.Controls.Add(this.recordsBox);
            this.benchmarkPanel.Controls.Add(this.label24);
            this.benchmarkPanel.Location = new System.Drawing.Point(0, 0);
            this.benchmarkPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.benchmarkPanel.Name = "benchmarkPanel";
            this.benchmarkPanel.Size = new System.Drawing.Size(1366, 600);
            this.benchmarkPanel.TabIndex = 9;
            this.benchmarkPanel.Visible = false;
            // 
            // replicaBox
            // 
            this.replicaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.replicaBox.FormattingEnabled = true;
            this.replicaBox.Location = new System.Drawing.Point(351, 214);
            this.replicaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.replicaBox.Name = "replicaBox";
            this.replicaBox.Size = new System.Drawing.Size(156, 28);
            this.replicaBox.TabIndex = 121;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(292, 222);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 151;
            this.label19.Text = "Replica";
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Location = new System.Drawing.Point(340, 134);
            this.batchSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(36, 20);
            this.batchSizeLabel.TabIndex = 113;
            this.batchSizeLabel.Text = "Size";
            this.batchSizeLabel.Visible = false;
            // 
            // batchSizeBox
            // 
            this.batchSizeBox.Location = new System.Drawing.Point(377, 129);
            this.batchSizeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.batchSizeBox.Name = "batchSizeBox";
            this.batchSizeBox.Size = new System.Drawing.Size(84, 27);
            this.batchSizeBox.TabIndex = 109;
            this.batchSizeBox.Text = "100";
            this.batchSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.batchSizeBox.Visible = false;
            // 
            // batchReadBox
            // 
            this.batchReadBox.AutoSize = true;
            this.batchReadBox.Location = new System.Drawing.Point(237, 132);
            this.batchReadBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.batchReadBox.Name = "batchReadBox";
            this.batchReadBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.batchReadBox.Size = new System.Drawing.Size(106, 24);
            this.batchReadBox.TabIndex = 108;
            this.batchReadBox.Text = "Batch Read";
            this.batchReadBox.UseVisualStyleBackColor = true;
            this.batchReadBox.CheckedChanged += new System.EventHandler(this.BatchReadChanged);
            // 
            // initializePanel
            // 
            this.initializePanel.Controls.Add(this.initPctLabel);
            this.initializePanel.Controls.Add(this.initPctBox);
            this.initializePanel.Controls.Add(this.label5);
            this.initializePanel.Location = new System.Drawing.Point(19, 254);
            this.initializePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.initializePanel.Name = "initializePanel";
            this.initializePanel.Size = new System.Drawing.Size(215, 43);
            this.initializePanel.TabIndex = 125;
            // 
            // initPctLabel
            // 
            this.initPctLabel.AutoSize = true;
            this.initPctLabel.Location = new System.Drawing.Point(179, 9);
            this.initPctLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initPctLabel.Name = "initPctLabel";
            this.initPctLabel.Size = new System.Drawing.Size(21, 20);
            this.initPctLabel.TabIndex = 107;
            this.initPctLabel.Text = "%";
            // 
            // initPctBox
            // 
            this.initPctBox.Location = new System.Drawing.Point(119, 5);
            this.initPctBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.initPctBox.Name = "initPctBox";
            this.initPctBox.Size = new System.Drawing.Size(59, 27);
            this.initPctBox.TabIndex = 131;
            this.initPctBox.Text = "100";
            this.initPctBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Initialize Percent";
            // 
            // workloadPanel
            // 
            this.workloadPanel.Controls.Add(this.readModeSCBox);
            this.workloadPanel.Controls.Add(this.label21);
            this.workloadPanel.Controls.Add(this.readModeAPBox);
            this.workloadPanel.Controls.Add(this.label18);
            this.workloadPanel.Controls.Add(this.label10);
            this.workloadPanel.Controls.Add(this.writeBox);
            this.workloadPanel.Controls.Add(this.label11);
            this.workloadPanel.Controls.Add(this.label9);
            this.workloadPanel.Controls.Add(this.readBox);
            this.workloadPanel.Controls.Add(this.label8);
            this.workloadPanel.Controls.Add(this.label7);
            this.workloadPanel.Location = new System.Drawing.Point(19, 254);
            this.workloadPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workloadPanel.Name = "workloadPanel";
            this.workloadPanel.Size = new System.Drawing.Size(911, 43);
            this.workloadPanel.TabIndex = 130;
            // 
            // readModeSCBox
            // 
            this.readModeSCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readModeSCBox.FormattingEnabled = true;
            this.readModeSCBox.Location = new System.Drawing.Point(632, 2);
            this.readModeSCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readModeSCBox.Name = "readModeSCBox";
            this.readModeSCBox.Size = new System.Drawing.Size(208, 28);
            this.readModeSCBox.TabIndex = 134;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(524, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 20);
            this.label21.TabIndex = 155;
            this.label21.Text = "Read Mode SC";
            // 
            // readModeAPBox
            // 
            this.readModeAPBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readModeAPBox.FormattingEnabled = true;
            this.readModeAPBox.Location = new System.Drawing.Point(437, 2);
            this.readModeAPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readModeAPBox.Name = "readModeAPBox";
            this.readModeAPBox.Size = new System.Drawing.Size(67, 28);
            this.readModeAPBox.TabIndex = 133;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(327, 9);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 20);
            this.label18.TabIndex = 153;
            this.label18.Text = "Read Mode AP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "%";
            // 
            // writeBox
            // 
            this.writeBox.Location = new System.Drawing.Point(255, 5);
            this.writeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.writeBox.Name = "writeBox";
            this.writeBox.Size = new System.Drawing.Size(45, 27);
            this.writeBox.TabIndex = 132;
            this.writeBox.Text = "50";
            this.writeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "Write";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "%";
            // 
            // readBox
            // 
            this.readBox.Location = new System.Drawing.Point(133, 5);
            this.readBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readBox.Name = "readBox";
            this.readBox.Size = new System.Drawing.Size(45, 27);
            this.readBox.TabIndex = 85;
            this.readBox.Text = "50";
            this.readBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 88;
            this.label8.Text = "Read";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 87;
            this.label7.Text = "Work Load";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dynamicValueButton);
            this.panel1.Controls.Add(this.fixedValueButton);
            this.panel1.Location = new System.Drawing.Point(20, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 45);
            this.panel1.TabIndex = 120;
            // 
            // dynamicValueButton
            // 
            this.dynamicValueButton.AutoSize = true;
            this.dynamicValueButton.Location = new System.Drawing.Point(125, 9);
            this.dynamicValueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dynamicValueButton.Name = "dynamicValueButton";
            this.dynamicValueButton.Size = new System.Drawing.Size(132, 24);
            this.dynamicValueButton.TabIndex = 41;
            this.dynamicValueButton.Text = "Random Values";
            this.dynamicValueButton.UseVisualStyleBackColor = true;
            // 
            // fixedValueButton
            // 
            this.fixedValueButton.AutoSize = true;
            this.fixedValueButton.Checked = true;
            this.fixedValueButton.Location = new System.Drawing.Point(7, 9);
            this.fixedValueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fixedValueButton.Name = "fixedValueButton";
            this.fixedValueButton.Size = new System.Drawing.Size(105, 24);
            this.fixedValueButton.TabIndex = 40;
            this.fixedValueButton.TabStop = true;
            this.fixedValueButton.Text = "Fixed Value";
            this.fixedValueButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.threadPanel);
            this.groupBox1.Controls.Add(this.asyncButton);
            this.groupBox1.Controls.Add(this.syncButton);
            this.groupBox1.Controls.Add(this.maxCommandPanel);
            this.groupBox1.Location = new System.Drawing.Point(16, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(507, 115);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Mode";
            // 
            // threadPanel
            // 
            this.threadPanel.Controls.Add(this.limitTpsBox);
            this.threadPanel.Controls.Add(this.throughputBox);
            this.threadPanel.Controls.Add(this.syncThreadBox);
            this.threadPanel.Controls.Add(this.label25);
            this.threadPanel.Location = new System.Drawing.Point(4, 65);
            this.threadPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.threadPanel.Name = "threadPanel";
            this.threadPanel.Size = new System.Drawing.Size(477, 40);
            this.threadPanel.TabIndex = 66;
            // 
            // limitTpsBox
            // 
            this.limitTpsBox.AutoSize = true;
            this.limitTpsBox.Location = new System.Drawing.Point(253, 8);
            this.limitTpsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.limitTpsBox.Name = "limitTpsBox";
            this.limitTpsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.limitTpsBox.Size = new System.Drawing.Size(92, 24);
            this.limitTpsBox.TabIndex = 5;
            this.limitTpsBox.Text = "Limit TPS";
            this.limitTpsBox.UseVisualStyleBackColor = true;
            this.limitTpsBox.CheckedChanged += new System.EventHandler(this.LimitTPSChanged);
            // 
            // throughputBox
            // 
            this.throughputBox.Location = new System.Drawing.Point(351, 5);
            this.throughputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.throughputBox.Name = "throughputBox";
            this.throughputBox.Size = new System.Drawing.Size(68, 27);
            this.throughputBox.TabIndex = 6;
            this.throughputBox.Text = "1000";
            this.throughputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.throughputBox.Visible = false;
            // 
            // syncThreadBox
            // 
            this.syncThreadBox.Location = new System.Drawing.Point(91, 5);
            this.syncThreadBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.syncThreadBox.Name = "syncThreadBox";
            this.syncThreadBox.Size = new System.Drawing.Size(105, 27);
            this.syncThreadBox.TabIndex = 4;
            this.syncThreadBox.Text = "8";
            this.syncThreadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(0, 9);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "Threads";
            // 
            // asyncButton
            // 
            this.asyncButton.AutoSize = true;
            this.asyncButton.Location = new System.Drawing.Point(132, 29);
            this.asyncButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(121, 24);
            this.asyncButton.TabIndex = 3;
            this.asyncButton.Text = "Asynchronous";
            this.asyncButton.UseVisualStyleBackColor = true;
            // 
            // syncButton
            // 
            this.syncButton.AutoSize = true;
            this.syncButton.Checked = true;
            this.syncButton.Location = new System.Drawing.Point(8, 29);
            this.syncButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(113, 24);
            this.syncButton.TabIndex = 2;
            this.syncButton.TabStop = true;
            this.syncButton.Text = "Synchronous";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.CheckedChanged += new System.EventHandler(this.SyncCheckChanged);
            // 
            // maxCommandPanel
            // 
            this.maxCommandPanel.Controls.Add(this.asyncThreadBox);
            this.maxCommandPanel.Controls.Add(this.label26);
            this.maxCommandPanel.Controls.Add(this.maxCommandBox);
            this.maxCommandPanel.Controls.Add(this.label27);
            this.maxCommandPanel.Location = new System.Drawing.Point(4, 65);
            this.maxCommandPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxCommandPanel.Name = "maxCommandPanel";
            this.maxCommandPanel.Size = new System.Drawing.Size(477, 40);
            this.maxCommandPanel.TabIndex = 67;
            this.maxCommandPanel.Visible = false;
            // 
            // asyncThreadBox
            // 
            this.asyncThreadBox.Location = new System.Drawing.Point(400, 5);
            this.asyncThreadBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asyncThreadBox.Name = "asyncThreadBox";
            this.asyncThreadBox.Size = new System.Drawing.Size(65, 27);
            this.asyncThreadBox.TabIndex = 9;
            this.asyncThreadBox.Text = "16";
            this.asyncThreadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(271, 9);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(131, 20);
            this.label26.TabIndex = 8;
            this.label26.Text = "Generator Threads";
            // 
            // maxCommandBox
            // 
            this.maxCommandBox.Location = new System.Drawing.Point(195, 5);
            this.maxCommandBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxCommandBox.Name = "maxCommandBox";
            this.maxCommandBox.Size = new System.Drawing.Size(65, 27);
            this.maxCommandBox.TabIndex = 7;
            this.maxCommandBox.Text = "12";
            this.maxCommandBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 9);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 20);
            this.label27.TabIndex = 6;
            this.label27.Text = "Max Concurrent Commands";
            // 
            // latencyGroup
            // 
            this.latencyGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latencyGroup.Controls.Add(this.latencyAltFormatBox);
            this.latencyGroup.Controls.Add(this.latencyDisplayLabel);
            this.latencyGroup.Controls.Add(this.latencyColumnsLabel);
            this.latencyGroup.Controls.Add(this.latencyColumnsBox);
            this.latencyGroup.Controls.Add(this.latencyShiftLabel);
            this.latencyGroup.Controls.Add(this.latencyShiftBox);
            this.latencyGroup.Location = new System.Drawing.Point(20, 383);
            this.latencyGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyGroup.Name = "latencyGroup";
            this.latencyGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyGroup.Size = new System.Drawing.Size(1342, 160);
            this.latencyGroup.TabIndex = 150;
            this.latencyGroup.TabStop = false;
            this.latencyGroup.Text = "Latency Format";
            this.latencyGroup.Visible = false;
            // 
            // latencyAltFormatBox
            // 
            this.latencyAltFormatBox.AutoSize = true;
            this.latencyAltFormatBox.Location = new System.Drawing.Point(387, 37);
            this.latencyAltFormatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyAltFormatBox.Name = "latencyAltFormatBox";
            this.latencyAltFormatBox.Size = new System.Drawing.Size(143, 24);
            this.latencyAltFormatBox.TabIndex = 153;
            this.latencyAltFormatBox.Text = "Alternate Format";
            this.latencyAltFormatBox.UseVisualStyleBackColor = true;
            this.latencyAltFormatBox.CheckedChanged += new System.EventHandler(this.LatencyValueChanged);
            // 
            // latencyDisplayLabel
            // 
            this.latencyDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latencyDisplayLabel.BackColor = System.Drawing.SystemColors.Control;
            this.latencyDisplayLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latencyDisplayLabel.Location = new System.Drawing.Point(4, 92);
            this.latencyDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyDisplayLabel.Multiline = true;
            this.latencyDisplayLabel.Name = "latencyDisplayLabel";
            this.latencyDisplayLabel.ReadOnly = true;
            this.latencyDisplayLabel.Size = new System.Drawing.Size(1329, 59);
            this.latencyDisplayLabel.TabIndex = 154;
            this.latencyDisplayLabel.Text = "<=1ms >1ms >8ms >64ms\r\n   x%   x%   x%    x%";
            // 
            // latencyColumnsLabel
            // 
            this.latencyColumnsLabel.AutoSize = true;
            this.latencyColumnsLabel.Location = new System.Drawing.Point(8, 42);
            this.latencyColumnsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latencyColumnsLabel.Name = "latencyColumnsLabel";
            this.latencyColumnsLabel.Size = new System.Drawing.Size(66, 20);
            this.latencyColumnsLabel.TabIndex = 96;
            this.latencyColumnsLabel.Text = "Columns";
            // 
            // latencyColumnsBox
            // 
            this.latencyColumnsBox.Location = new System.Drawing.Point(75, 37);
            this.latencyColumnsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyColumnsBox.Name = "latencyColumnsBox";
            this.latencyColumnsBox.Size = new System.Drawing.Size(68, 27);
            this.latencyColumnsBox.TabIndex = 151;
            this.latencyColumnsBox.Text = "4";
            this.latencyColumnsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.latencyColumnsBox.TextChanged += new System.EventHandler(this.LatencyValueChanged);
            // 
            // latencyShiftLabel
            // 
            this.latencyShiftLabel.AutoSize = true;
            this.latencyShiftLabel.Location = new System.Drawing.Point(179, 42);
            this.latencyShiftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latencyShiftLabel.Name = "latencyShiftLabel";
            this.latencyShiftLabel.Size = new System.Drawing.Size(105, 20);
            this.latencyShiftLabel.TabIndex = 98;
            this.latencyShiftLabel.Text = "Exponent Shift";
            // 
            // latencyShiftBox
            // 
            this.latencyShiftBox.Location = new System.Drawing.Point(283, 37);
            this.latencyShiftBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyShiftBox.Name = "latencyShiftBox";
            this.latencyShiftBox.Size = new System.Drawing.Size(68, 27);
            this.latencyShiftBox.TabIndex = 152;
            this.latencyShiftBox.Text = "3";
            this.latencyShiftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.latencyShiftBox.TextChanged += new System.EventHandler(this.LatencyValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(629, 305);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 20);
            this.label20.TabIndex = 94;
            this.label20.Text = "ms";
            // 
            // debugBox
            // 
            this.debugBox.AutoSize = true;
            this.debugBox.Location = new System.Drawing.Point(237, 348);
            this.debugBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.debugBox.Name = "debugBox";
            this.debugBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.debugBox.Size = new System.Drawing.Size(119, 24);
            this.debugBox.TabIndex = 144;
            this.debugBox.Text = "Debug Mode";
            this.debugBox.UseVisualStyleBackColor = true;
            // 
            // latencyBox
            // 
            this.latencyBox.AutoSize = true;
            this.latencyBox.Location = new System.Drawing.Point(28, 348);
            this.latencyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latencyBox.Name = "latencyBox";
            this.latencyBox.Size = new System.Drawing.Size(189, 24);
            this.latencyBox.TabIndex = 143;
            this.latencyBox.Text = "Enable Latency Tracking";
            this.latencyBox.UseVisualStyleBackColor = true;
            this.latencyBox.CheckedChanged += new System.EventHandler(this.LatencyChanged);
            // 
            // sleepBox
            // 
            this.sleepBox.Location = new System.Drawing.Point(559, 300);
            this.sleepBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sleepBox.Name = "sleepBox";
            this.sleepBox.Size = new System.Drawing.Size(68, 27);
            this.sleepBox.TabIndex = 142;
            this.sleepBox.Text = "0";
            this.sleepBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(403, 305);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 20);
            this.label17.TabIndex = 93;
            this.label17.Text = "Sleep Between Retries";
            // 
            // maxRetriesBox
            // 
            this.maxRetriesBox.Location = new System.Drawing.Point(320, 300);
            this.maxRetriesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxRetriesBox.Name = "maxRetriesBox";
            this.maxRetriesBox.Size = new System.Drawing.Size(68, 27);
            this.maxRetriesBox.TabIndex = 141;
            this.maxRetriesBox.Text = "0";
            this.maxRetriesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(231, 305);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 92;
            this.label16.Text = "Max Retries";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(197, 305);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 20);
            this.label15.TabIndex = 91;
            this.label15.Text = "ms";
            // 
            // timeoutBox
            // 
            this.timeoutBox.Location = new System.Drawing.Point(109, 300);
            this.timeoutBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeoutBox.Name = "timeoutBox";
            this.timeoutBox.Size = new System.Drawing.Size(87, 27);
            this.timeoutBox.TabIndex = 140;
            this.timeoutBox.Text = "0";
            this.timeoutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 305);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "Timeout";
            // 
            // binSizeBox
            // 
            this.binSizeBox.Location = new System.Drawing.Point(292, 172);
            this.binSizeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binSizeBox.Name = "binSizeBox";
            this.binSizeBox.Size = new System.Drawing.Size(84, 27);
            this.binSizeBox.TabIndex = 111;
            this.binSizeBox.Text = "50";
            this.binSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // binSizeLabel
            // 
            this.binSizeLabel.AutoSize = true;
            this.binSizeLabel.Location = new System.Drawing.Point(231, 177);
            this.binSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binSizeLabel.Name = "binSizeLabel";
            this.binSizeLabel.Size = new System.Drawing.Size(61, 20);
            this.binSizeLabel.TabIndex = 75;
            this.binSizeLabel.Text = "Bin Size";
            // 
            // binTypeBox
            // 
            this.binTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.binTypeBox.FormattingEnabled = true;
            this.binTypeBox.Location = new System.Drawing.Point(109, 171);
            this.binTypeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binTypeBox.Name = "binTypeBox";
            this.binTypeBox.Size = new System.Drawing.Size(107, 28);
            this.binTypeBox.TabIndex = 110;
            this.binTypeBox.SelectedIndexChanged += new System.EventHandler(this.BinTypeChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Bin Type";
            // 
            // recordsBox
            // 
            this.recordsBox.Location = new System.Drawing.Point(109, 129);
            this.recordsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recordsBox.Name = "recordsBox";
            this.recordsBox.Size = new System.Drawing.Size(105, 27);
            this.recordsBox.TabIndex = 107;
            this.recordsBox.Text = "1000000";
            this.recordsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 134);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 20);
            this.label24.TabIndex = 68;
            this.label24.Text = "Records";
            // 
            // codeBox
            // 
            this.codeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeBox.BackColor = System.Drawing.SystemColors.Window;
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeBox.Location = new System.Drawing.Point(0, 0);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.codeBox.MinimumSize = new System.Drawing.Size(1360, 596);
            this.codeBox.Name = "codeBox";
            this.codeBox.ReadOnly = true;
            this.codeBox.Size = new System.Drawing.Size(1360, 596);
            this.codeBox.TabIndex = 8;
            this.codeBox.Text = "";
            // 
            // consoleBox
            // 
            this.consoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleBox.BackColor = System.Drawing.SystemColors.Window;
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consoleBox.Location = new System.Drawing.Point(0, 52);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consoleBox.MinimumSize = new System.Drawing.Size(1360, 377);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(1360, 377);
            this.consoleBox.TabIndex = 11;
            this.consoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleKeyDown);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(109, 8);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 35);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopExample);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(1, 8);
            this.runButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 35);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Start";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RunExample);
            // 
            // nsBox
            // 
            this.nsBox.Location = new System.Drawing.Point(828, 9);
            this.nsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nsBox.Name = "nsBox";
            this.nsBox.Size = new System.Drawing.Size(132, 27);
            this.nsBox.TabIndex = 3;
            this.nsBox.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Namespace";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(267, 9);
            this.portBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(65, 27);
            this.portBox.TabIndex = 2;
            this.portBox.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Host";
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(87, 9);
            this.hostBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(132, 27);
            this.hostBox.TabIndex = 1;
            this.hostBox.Text = "localhost";
            // 
            // setBox
            // 
            this.setBox.Location = new System.Drawing.Point(1005, 9);
            this.setBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setBox.Name = "setBox";
            this.setBox.Size = new System.Drawing.Size(132, 27);
            this.setBox.TabIndex = 4;
            this.setBox.Text = "demoset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Set";
            // 
            // examplesView
            // 
            this.examplesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.examplesView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.examplesView.FullRowSelect = true;
            this.examplesView.HideSelection = false;
            this.examplesView.Indent = 5;
            this.examplesView.Location = new System.Drawing.Point(7, 49);
            this.examplesView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.examplesView.Name = "examplesView";
            this.examplesView.ShowLines = false;
            this.examplesView.Size = new System.Drawing.Size(191, 1120);
            this.examplesView.TabIndex = 14;
            this.examplesView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ExampleSelected);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(600, 9);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(132, 27);
            this.passwordBox.TabIndex = 16;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Password";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(384, 9);
            this.userBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(132, 27);
            this.userBox.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "User";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 1175);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.examplesView);
            this.Controls.Add(this.setBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.passwordBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DemoForm";
            this.Text = "Aerospike Database Client Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.benchmarkPanel.ResumeLayout(false);
            this.benchmarkPanel.PerformLayout();
            this.initializePanel.ResumeLayout(false);
            this.initializePanel.PerformLayout();
            this.workloadPanel.ResumeLayout(false);
            this.workloadPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.threadPanel.ResumeLayout(false);
            this.threadPanel.PerformLayout();
            this.maxCommandPanel.ResumeLayout(false);
            this.maxCommandPanel.PerformLayout();
            this.latencyGroup.ResumeLayout(false);
            this.latencyGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.TextBox nsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox setBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox consoleBox;
		private System.Windows.Forms.TreeView examplesView;
        private System.Windows.Forms.Panel benchmarkPanel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox debugBox;
        private System.Windows.Forms.CheckBox latencyBox;
        private System.Windows.Forms.TextBox latencyShiftBox;
        private System.Windows.Forms.Label latencyShiftLabel;
        private System.Windows.Forms.TextBox latencyColumnsBox;
        private System.Windows.Forms.Label latencyColumnsLabel;
        private System.Windows.Forms.TextBox sleepBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox maxRetriesBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox timeoutBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox binSizeBox;
        private System.Windows.Forms.Label binSizeLabel;
        private System.Windows.Forms.ComboBox binTypeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recordsBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox latencyDisplayLabel;
        private System.Windows.Forms.GroupBox latencyGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton asyncButton;
        private System.Windows.Forms.RadioButton syncButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton dynamicValueButton;
        private System.Windows.Forms.RadioButton fixedValueButton;
        private System.Windows.Forms.Panel threadPanel;
        private System.Windows.Forms.TextBox syncThreadBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel maxCommandPanel;
        private System.Windows.Forms.TextBox asyncThreadBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox maxCommandBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel workloadPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox writeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel initializePanel;
        private System.Windows.Forms.Label initPctLabel;
        private System.Windows.Forms.TextBox initPctBox;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox userBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox latencyAltFormatBox;
		private System.Windows.Forms.Label batchSizeLabel;
		private System.Windows.Forms.TextBox batchSizeBox;
		private System.Windows.Forms.CheckBox batchReadBox;
		private System.Windows.Forms.TextBox throughputBox;
		private System.Windows.Forms.CheckBox limitTpsBox;
		private System.Windows.Forms.ComboBox replicaBox;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox readModeAPBox;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox readModeSCBox;
		private System.Windows.Forms.Label label21;
    }
}