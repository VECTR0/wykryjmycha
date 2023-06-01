namespace WykryjMycha
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDrawing = new System.Windows.Forms.TabPage();
            this.lblSeqence = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnAddStroke = new System.Windows.Forms.Button();
            this.btnAddPattern = new System.Windows.Forms.Button();
            this.picDrawing = new System.Windows.Forms.PictureBox();
            this.txtNewPatternName = new System.Windows.Forms.TextBox();
            this.tpVisualisation = new System.Windows.Forms.TabPage();
            this.lstStepPatterns = new System.Windows.Forms.ListBox();
            this.trbSteps = new System.Windows.Forms.TrackBar();
            this.picSteps = new System.Windows.Forms.PictureBox();
            this.tpPatterns = new System.Windows.Forms.TabPage();
            this.lblDistanceWeight = new System.Windows.Forms.Label();
            this.lblAngleWeight = new System.Windows.Forms.Label();
            this.btnSaveWeights = new System.Windows.Forms.Button();
            this.numDistanceWeight = new System.Windows.Forms.NumericUpDown();
            this.numAngleWeight = new System.Windows.Forms.NumericUpDown();
            this.btnImportPatterns = new System.Windows.Forms.Button();
            this.btnDeletePattern = new System.Windows.Forms.Button();
            this.btnExportPatterns = new System.Windows.Forms.Button();
            this.picPattern = new System.Windows.Forms.PictureBox();
            this.lstEditorPatterns = new System.Windows.Forms.ListBox();
            this.tpTests = new System.Windows.Forms.TabPage();
            this.btnClearStrokes = new System.Windows.Forms.Button();
            this.btnDeleteStroke = new System.Windows.Forms.Button();
            this.btnImportStrokes = new System.Windows.Forms.Button();
            this.btnExportStrokes = new System.Windows.Forms.Button();
            this.picStroke = new System.Windows.Forms.PictureBox();
            this.lstStrokes = new System.Windows.Forms.ListBox();
            this.btnRunTests = new System.Windows.Forms.Button();
            this.tpGenetic = new System.Windows.Forms.TabPage();
            this.btnOptimise = new System.Windows.Forms.Button();
            this.numTargetQuality = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numMutationProbability = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numSelectedSize = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numMaxItertions = new System.Windows.Forms.NumericUpDown();
            this.lblGeneticAlgorithmSettings = new System.Windows.Forms.Label();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.numDrawingTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblProgramSettings = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.angleRefPointMinDist = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.angleLimitDegree = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxMergeDistance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numMetricAngleWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMetricDistanceWeight = new System.Windows.Forms.NumericUpDown();
            this.tmrDrawing = new System.Windows.Forms.Timer(this.components);
            this.ofdStrokes = new System.Windows.Forms.OpenFileDialog();
            this.sfdStrokes = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
            this.tpVisualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteps)).BeginInit();
            this.tpPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngleWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).BeginInit();
            this.tpTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStroke)).BeginInit();
            this.tpGenetic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectedSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxItertions)).BeginInit();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawingTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleRefPointMinDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleLimitDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMergeDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMetricAngleWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMetricDistanceWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(14, 393);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(677, 85);
            this.txtConsole.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpDrawing);
            this.tabControl1.Controls.Add(this.tpVisualisation);
            this.tabControl1.Controls.Add(this.tpPatterns);
            this.tabControl1.Controls.Add(this.tpTests);
            this.tabControl1.Controls.Add(this.tpGenetic);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 373);
            this.tabControl1.TabIndex = 2;
            // 
            // tpDrawing
            // 
            this.tpDrawing.Controls.Add(this.lblSeqence);
            this.tpDrawing.Controls.Add(this.txtSequence);
            this.tpDrawing.Controls.Add(this.btnAddStroke);
            this.tpDrawing.Controls.Add(this.btnAddPattern);
            this.tpDrawing.Controls.Add(this.picDrawing);
            this.tpDrawing.Controls.Add(this.txtNewPatternName);
            this.tpDrawing.Location = new System.Drawing.Point(4, 24);
            this.tpDrawing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDrawing.Name = "tpDrawing";
            this.tpDrawing.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDrawing.Size = new System.Drawing.Size(669, 345);
            this.tpDrawing.TabIndex = 0;
            this.tpDrawing.Text = "Drawing";
            this.tpDrawing.UseVisualStyleBackColor = true;
            // 
            // lblSeqence
            // 
            this.lblSeqence.AutoSize = true;
            this.lblSeqence.Location = new System.Drawing.Point(314, 7);
            this.lblSeqence.Name = "lblSeqence";
            this.lblSeqence.Size = new System.Drawing.Size(63, 15);
            this.lblSeqence.TabIndex = 7;
            this.lblSeqence.Text = "Sequences";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(314, 25);
            this.txtSequence.Multiline = true;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(348, 282);
            this.txtSequence.TabIndex = 6;
            // 
            // btnAddStroke
            // 
            this.btnAddStroke.Location = new System.Drawing.Point(225, 312);
            this.btnAddStroke.Name = "btnAddStroke";
            this.btnAddStroke.Size = new System.Drawing.Size(82, 23);
            this.btnAddStroke.TabIndex = 5;
            this.btnAddStroke.Text = "Add Stroke";
            this.btnAddStroke.UseVisualStyleBackColor = true;
            this.btnAddStroke.Click += new System.EventHandler(this.btnAddStroke_Click);
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Location = new System.Drawing.Point(136, 312);
            this.btnAddPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(82, 23);
            this.btnAddPattern.TabIndex = 4;
            this.btnAddPattern.Text = "Add Pattern";
            this.btnAddPattern.UseVisualStyleBackColor = true;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // picDrawing
            // 
            this.picDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrawing.Location = new System.Drawing.Point(7, 7);
            this.picDrawing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDrawing.Name = "picDrawing";
            this.picDrawing.Size = new System.Drawing.Size(300, 300);
            this.picDrawing.TabIndex = 2;
            this.picDrawing.TabStop = false;
            this.picDrawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDrawing_MouseClick);
            this.picDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawing_MouseDown);
            this.picDrawing.MouseLeave += new System.EventHandler(this.picDrawing_MouseLeave);
            this.picDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawing_MouseMove);
            this.picDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawing_MouseUp);
            // 
            // txtNewPatternName
            // 
            this.txtNewPatternName.Location = new System.Drawing.Point(7, 313);
            this.txtNewPatternName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewPatternName.Name = "txtNewPatternName";
            this.txtNewPatternName.PlaceholderText = "New Pattern Name";
            this.txtNewPatternName.Size = new System.Drawing.Size(121, 23);
            this.txtNewPatternName.TabIndex = 3;
            // 
            // tpVisualisation
            // 
            this.tpVisualisation.Controls.Add(this.lstStepPatterns);
            this.tpVisualisation.Controls.Add(this.trbSteps);
            this.tpVisualisation.Controls.Add(this.picSteps);
            this.tpVisualisation.Location = new System.Drawing.Point(4, 24);
            this.tpVisualisation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpVisualisation.Name = "tpVisualisation";
            this.tpVisualisation.Size = new System.Drawing.Size(669, 345);
            this.tpVisualisation.TabIndex = 3;
            this.tpVisualisation.Text = "Algorithm Visualisation";
            this.tpVisualisation.UseVisualStyleBackColor = true;
            // 
            // lstStepPatterns
            // 
            this.lstStepPatterns.FormattingEnabled = true;
            this.lstStepPatterns.ItemHeight = 15;
            this.lstStepPatterns.Location = new System.Drawing.Point(8, 6);
            this.lstStepPatterns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstStepPatterns.Name = "lstStepPatterns";
            this.lstStepPatterns.Size = new System.Drawing.Size(160, 304);
            this.lstStepPatterns.TabIndex = 8;
            this.lstStepPatterns.SelectedIndexChanged += new System.EventHandler(this.lstStepPatterns_SelectedIndexChanged);
            // 
            // trbSteps
            // 
            this.trbSteps.Location = new System.Drawing.Point(484, 6);
            this.trbSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trbSteps.Name = "trbSteps";
            this.trbSteps.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbSteps.Size = new System.Drawing.Size(45, 300);
            this.trbSteps.TabIndex = 7;
            this.trbSteps.Scroll += new System.EventHandler(this.trbSteps_Scroll);
            // 
            // picSteps
            // 
            this.picSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSteps.Location = new System.Drawing.Point(176, 6);
            this.picSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picSteps.Name = "picSteps";
            this.picSteps.Size = new System.Drawing.Size(300, 300);
            this.picSteps.TabIndex = 6;
            this.picSteps.TabStop = false;
            // 
            // tpPatterns
            // 
            this.tpPatterns.Controls.Add(this.lblDistanceWeight);
            this.tpPatterns.Controls.Add(this.lblAngleWeight);
            this.tpPatterns.Controls.Add(this.btnSaveWeights);
            this.tpPatterns.Controls.Add(this.numDistanceWeight);
            this.tpPatterns.Controls.Add(this.numAngleWeight);
            this.tpPatterns.Controls.Add(this.btnImportPatterns);
            this.tpPatterns.Controls.Add(this.btnDeletePattern);
            this.tpPatterns.Controls.Add(this.btnExportPatterns);
            this.tpPatterns.Controls.Add(this.picPattern);
            this.tpPatterns.Controls.Add(this.lstEditorPatterns);
            this.tpPatterns.Location = new System.Drawing.Point(4, 24);
            this.tpPatterns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpPatterns.Name = "tpPatterns";
            this.tpPatterns.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpPatterns.Size = new System.Drawing.Size(669, 345);
            this.tpPatterns.TabIndex = 1;
            this.tpPatterns.Text = "Patterns Editor";
            this.tpPatterns.UseVisualStyleBackColor = true;
            // 
            // lblDistanceWeight
            // 
            this.lblDistanceWeight.AutoSize = true;
            this.lblDistanceWeight.Location = new System.Drawing.Point(483, 35);
            this.lblDistanceWeight.Name = "lblDistanceWeight";
            this.lblDistanceWeight.Size = new System.Drawing.Size(93, 15);
            this.lblDistanceWeight.TabIndex = 17;
            this.lblDistanceWeight.Text = "Distance Weight";
            // 
            // lblAngleWeight
            // 
            this.lblAngleWeight.AutoSize = true;
            this.lblAngleWeight.Location = new System.Drawing.Point(483, 6);
            this.lblAngleWeight.Name = "lblAngleWeight";
            this.lblAngleWeight.Size = new System.Drawing.Size(79, 15);
            this.lblAngleWeight.TabIndex = 17;
            this.lblAngleWeight.Text = "Angle Weight";
            // 
            // btnSaveWeights
            // 
            this.btnSaveWeights.Location = new System.Drawing.Point(582, 62);
            this.btnSaveWeights.Name = "btnSaveWeights";
            this.btnSaveWeights.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWeights.TabIndex = 16;
            this.btnSaveWeights.Text = "Save";
            this.btnSaveWeights.UseVisualStyleBackColor = true;
            this.btnSaveWeights.Click += new System.EventHandler(this.btnSaveWeights_Click);
            // 
            // numDistanceWeight
            // 
            this.numDistanceWeight.Location = new System.Drawing.Point(582, 33);
            this.numDistanceWeight.Name = "numDistanceWeight";
            this.numDistanceWeight.Size = new System.Drawing.Size(75, 23);
            this.numDistanceWeight.TabIndex = 15;
            // 
            // numAngleWeight
            // 
            this.numAngleWeight.Location = new System.Drawing.Point(582, 6);
            this.numAngleWeight.Name = "numAngleWeight";
            this.numAngleWeight.Size = new System.Drawing.Size(75, 23);
            this.numAngleWeight.TabIndex = 15;
            // 
            // btnImportPatterns
            // 
            this.btnImportPatterns.Location = new System.Drawing.Point(8, 316);
            this.btnImportPatterns.Name = "btnImportPatterns";
            this.btnImportPatterns.Size = new System.Drawing.Size(75, 23);
            this.btnImportPatterns.TabIndex = 14;
            this.btnImportPatterns.Text = "Import DB";
            this.btnImportPatterns.UseVisualStyleBackColor = true;
            this.btnImportPatterns.Click += new System.EventHandler(this.btnImportPatterns_Click);
            // 
            // btnDeletePattern
            // 
            this.btnDeletePattern.Location = new System.Drawing.Point(401, 312);
            this.btnDeletePattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePattern.TabIndex = 13;
            this.btnDeletePattern.Text = "Delete";
            this.btnDeletePattern.UseVisualStyleBackColor = true;
            this.btnDeletePattern.Click += new System.EventHandler(this.btnDeletePattern_Click);
            // 
            // btnExportPatterns
            // 
            this.btnExportPatterns.Location = new System.Drawing.Point(93, 316);
            this.btnExportPatterns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportPatterns.Name = "btnExportPatterns";
            this.btnExportPatterns.Size = new System.Drawing.Size(75, 23);
            this.btnExportPatterns.TabIndex = 12;
            this.btnExportPatterns.Text = "Export DB";
            this.btnExportPatterns.UseVisualStyleBackColor = true;
            this.btnExportPatterns.Click += new System.EventHandler(this.btnExportPatterns_Click);
            // 
            // picPattern
            // 
            this.picPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPattern.Location = new System.Drawing.Point(176, 6);
            this.picPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPattern.Name = "picPattern";
            this.picPattern.Size = new System.Drawing.Size(300, 300);
            this.picPattern.TabIndex = 10;
            this.picPattern.TabStop = false;
            this.picPattern.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPattern_MouseDown);
            this.picPattern.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPattern_MouseMove);
            this.picPattern.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPattern_MouseUp);
            // 
            // lstEditorPatterns
            // 
            this.lstEditorPatterns.FormattingEnabled = true;
            this.lstEditorPatterns.ItemHeight = 15;
            this.lstEditorPatterns.Location = new System.Drawing.Point(8, 6);
            this.lstEditorPatterns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstEditorPatterns.Name = "lstEditorPatterns";
            this.lstEditorPatterns.Size = new System.Drawing.Size(160, 304);
            this.lstEditorPatterns.TabIndex = 9;
            this.lstEditorPatterns.SelectedIndexChanged += new System.EventHandler(this.lstEditorPatterns_SelectedIndexChanged);
            // 
            // tpTests
            // 
            this.tpTests.Controls.Add(this.btnClearStrokes);
            this.tpTests.Controls.Add(this.btnDeleteStroke);
            this.tpTests.Controls.Add(this.btnImportStrokes);
            this.tpTests.Controls.Add(this.btnExportStrokes);
            this.tpTests.Controls.Add(this.picStroke);
            this.tpTests.Controls.Add(this.lstStrokes);
            this.tpTests.Controls.Add(this.btnRunTests);
            this.tpTests.Location = new System.Drawing.Point(4, 24);
            this.tpTests.Name = "tpTests";
            this.tpTests.Size = new System.Drawing.Size(669, 345);
            this.tpTests.TabIndex = 4;
            this.tpTests.Text = "Testing";
            this.tpTests.UseVisualStyleBackColor = true;
            // 
            // btnClearStrokes
            // 
            this.btnClearStrokes.Location = new System.Drawing.Point(320, 312);
            this.btnClearStrokes.Name = "btnClearStrokes";
            this.btnClearStrokes.Size = new System.Drawing.Size(75, 23);
            this.btnClearStrokes.TabIndex = 16;
            this.btnClearStrokes.Text = "Delete All";
            this.btnClearStrokes.UseVisualStyleBackColor = true;
            this.btnClearStrokes.Click += new System.EventHandler(this.btnClearStrokes_Click);
            // 
            // btnDeleteStroke
            // 
            this.btnDeleteStroke.Location = new System.Drawing.Point(401, 312);
            this.btnDeleteStroke.Name = "btnDeleteStroke";
            this.btnDeleteStroke.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStroke.TabIndex = 15;
            this.btnDeleteStroke.Text = "Delete";
            this.btnDeleteStroke.UseVisualStyleBackColor = true;
            this.btnDeleteStroke.Click += new System.EventHandler(this.btnDeleteStroke_Click);
            // 
            // btnImportStrokes
            // 
            this.btnImportStrokes.Location = new System.Drawing.Point(8, 316);
            this.btnImportStrokes.Name = "btnImportStrokes";
            this.btnImportStrokes.Size = new System.Drawing.Size(75, 23);
            this.btnImportStrokes.TabIndex = 14;
            this.btnImportStrokes.Text = "Import";
            this.btnImportStrokes.UseVisualStyleBackColor = true;
            this.btnImportStrokes.Click += new System.EventHandler(this.btnImportStrokes_Click);
            // 
            // btnExportStrokes
            // 
            this.btnExportStrokes.Location = new System.Drawing.Point(93, 316);
            this.btnExportStrokes.Name = "btnExportStrokes";
            this.btnExportStrokes.Size = new System.Drawing.Size(75, 23);
            this.btnExportStrokes.TabIndex = 13;
            this.btnExportStrokes.Text = "Export";
            this.btnExportStrokes.UseVisualStyleBackColor = true;
            this.btnExportStrokes.Click += new System.EventHandler(this.btnExportStrokes_Click);
            // 
            // picStroke
            // 
            this.picStroke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStroke.Location = new System.Drawing.Point(176, 6);
            this.picStroke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picStroke.Name = "picStroke";
            this.picStroke.Size = new System.Drawing.Size(300, 300);
            this.picStroke.TabIndex = 12;
            this.picStroke.TabStop = false;
            // 
            // lstStrokes
            // 
            this.lstStrokes.FormattingEnabled = true;
            this.lstStrokes.ItemHeight = 15;
            this.lstStrokes.Location = new System.Drawing.Point(8, 6);
            this.lstStrokes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstStrokes.Name = "lstStrokes";
            this.lstStrokes.Size = new System.Drawing.Size(160, 304);
            this.lstStrokes.TabIndex = 11;
            this.lstStrokes.SelectedIndexChanged += new System.EventHandler(this.lstStrokes_SelectedIndexChanged);
            // 
            // btnRunTests
            // 
            this.btnRunTests.Location = new System.Drawing.Point(174, 312);
            this.btnRunTests.Name = "btnRunTests";
            this.btnRunTests.Size = new System.Drawing.Size(75, 23);
            this.btnRunTests.TabIndex = 2;
            this.btnRunTests.Text = "Run Tests";
            this.btnRunTests.UseVisualStyleBackColor = true;
            this.btnRunTests.Click += new System.EventHandler(this.btnRunTests_Click);
            // 
            // tpGenetic
            // 
            this.tpGenetic.Controls.Add(this.btnOptimise);
            this.tpGenetic.Controls.Add(this.numTargetQuality);
            this.tpGenetic.Controls.Add(this.label18);
            this.tpGenetic.Controls.Add(this.label17);
            this.tpGenetic.Controls.Add(this.label16);
            this.tpGenetic.Controls.Add(this.numMutationProbability);
            this.tpGenetic.Controls.Add(this.label15);
            this.tpGenetic.Controls.Add(this.numSelectedSize);
            this.tpGenetic.Controls.Add(this.label14);
            this.tpGenetic.Controls.Add(this.numPopulationSize);
            this.tpGenetic.Controls.Add(this.numMaxItertions);
            this.tpGenetic.Controls.Add(this.lblGeneticAlgorithmSettings);
            this.tpGenetic.Location = new System.Drawing.Point(4, 24);
            this.tpGenetic.Name = "tpGenetic";
            this.tpGenetic.Size = new System.Drawing.Size(669, 345);
            this.tpGenetic.TabIndex = 5;
            this.tpGenetic.Text = "Genetic";
            this.tpGenetic.UseVisualStyleBackColor = true;
            // 
            // btnOptimise
            // 
            this.btnOptimise.Location = new System.Drawing.Point(249, 17);
            this.btnOptimise.Name = "btnOptimise";
            this.btnOptimise.Size = new System.Drawing.Size(75, 23);
            this.btnOptimise.TabIndex = 24;
            this.btnOptimise.Text = "Optimise";
            this.btnOptimise.UseVisualStyleBackColor = true;
            this.btnOptimise.Click += new System.EventHandler(this.btnOptimise_Click);
            // 
            // numTargetQuality
            // 
            this.numTargetQuality.DecimalPlaces = 2;
            this.numTargetQuality.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numTargetQuality.Location = new System.Drawing.Point(30, 151);
            this.numTargetQuality.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTargetQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numTargetQuality.Name = "numTargetQuality";
            this.numTargetQuality.Size = new System.Drawing.Size(64, 23);
            this.numTargetQuality.TabIndex = 23;
            this.numTargetQuality.Value = new decimal(new int[] {
            84,
            0,
            0,
            131072});
            this.numTargetQuality.ValueChanged += new System.EventHandler(this.numTargetQuality_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(99, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 15);
            this.label18.TabIndex = 22;
            this.label18.Text = "target quality";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(100, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "mutation probability";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(100, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "selected size";
            // 
            // numMutationProbability
            // 
            this.numMutationProbability.DecimalPlaces = 2;
            this.numMutationProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMutationProbability.Location = new System.Drawing.Point(30, 122);
            this.numMutationProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMutationProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numMutationProbability.Name = "numMutationProbability";
            this.numMutationProbability.Size = new System.Drawing.Size(64, 23);
            this.numMutationProbability.TabIndex = 21;
            this.numMutationProbability.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMutationProbability.ValueChanged += new System.EventHandler(this.numMutationProbability_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "population size";
            // 
            // numSelectedSize
            // 
            this.numSelectedSize.Location = new System.Drawing.Point(30, 93);
            this.numSelectedSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSelectedSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSelectedSize.Name = "numSelectedSize";
            this.numSelectedSize.Size = new System.Drawing.Size(64, 23);
            this.numSelectedSize.TabIndex = 21;
            this.numSelectedSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSelectedSize.ValueChanged += new System.EventHandler(this.numSelectedSize_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "max iterations";
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Location = new System.Drawing.Point(30, 64);
            this.numPopulationSize.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numPopulationSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(64, 23);
            this.numPopulationSize.TabIndex = 21;
            this.numPopulationSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPopulationSize.ValueChanged += new System.EventHandler(this.numPopulationSize_ValueChanged);
            // 
            // numMaxItertions
            // 
            this.numMaxItertions.Location = new System.Drawing.Point(29, 35);
            this.numMaxItertions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxItertions.Name = "numMaxItertions";
            this.numMaxItertions.Size = new System.Drawing.Size(64, 23);
            this.numMaxItertions.TabIndex = 21;
            this.numMaxItertions.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMaxItertions.ValueChanged += new System.EventHandler(this.numMaxItertions_ValueChanged);
            // 
            // lblGeneticAlgorithmSettings
            // 
            this.lblGeneticAlgorithmSettings.AutoSize = true;
            this.lblGeneticAlgorithmSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeneticAlgorithmSettings.Location = new System.Drawing.Point(26, 17);
            this.lblGeneticAlgorithmSettings.Name = "lblGeneticAlgorithmSettings";
            this.lblGeneticAlgorithmSettings.Size = new System.Drawing.Size(159, 15);
            this.lblGeneticAlgorithmSettings.TabIndex = 20;
            this.lblGeneticAlgorithmSettings.Text = "Genetic Algorithm Settings";
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.label9);
            this.tpSettings.Controls.Add(this.numDrawingTimeout);
            this.tpSettings.Controls.Add(this.lblProgramSettings);
            this.tpSettings.Controls.Add(this.label8);
            this.tpSettings.Controls.Add(this.label6);
            this.tpSettings.Controls.Add(this.angleRefPointMinDist);
            this.tpSettings.Controls.Add(this.label7);
            this.tpSettings.Controls.Add(this.angleLimitDegree);
            this.tpSettings.Controls.Add(this.label4);
            this.tpSettings.Controls.Add(this.minDistance);
            this.tpSettings.Controls.Add(this.label5);
            this.tpSettings.Controls.Add(this.maxMergeDistance);
            this.tpSettings.Controls.Add(this.label3);
            this.tpSettings.Controls.Add(this.numMetricAngleWeight);
            this.tpSettings.Controls.Add(this.label2);
            this.tpSettings.Controls.Add(this.label1);
            this.tpSettings.Controls.Add(this.numMetricDistanceWeight);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(669, 345);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "timeout for input drawing";
            // 
            // numDrawingTimeout
            // 
            this.numDrawingTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDrawingTimeout.Location = new System.Drawing.Point(29, 250);
            this.numDrawingTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrawingTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDrawingTimeout.Name = "numDrawingTimeout";
            this.numDrawingTimeout.Size = new System.Drawing.Size(64, 23);
            this.numDrawingTimeout.TabIndex = 15;
            this.numDrawingTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDrawingTimeout.ValueChanged += new System.EventHandler(this.numDrawingTimeout_ValueChanged);
            // 
            // lblProgramSettings
            // 
            this.lblProgramSettings.AutoSize = true;
            this.lblProgramSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgramSettings.Location = new System.Drawing.Point(26, 232);
            this.lblProgramSettings.Name = "lblProgramSettings";
            this.lblProgramSettings.Size = new System.Drawing.Size(104, 15);
            this.lblProgramSettings.TabIndex = 14;
            this.lblProgramSettings.Text = "Program Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(27, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Characteristic Points Finder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "angle reference point min distance";
            // 
            // angleRefPointMinDist
            // 
            this.angleRefPointMinDist.DecimalPlaces = 2;
            this.angleRefPointMinDist.Location = new System.Drawing.Point(27, 194);
            this.angleRefPointMinDist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.angleRefPointMinDist.Name = "angleRefPointMinDist";
            this.angleRefPointMinDist.Size = new System.Drawing.Size(66, 23);
            this.angleRefPointMinDist.TabIndex = 11;
            this.angleRefPointMinDist.ValueChanged += new System.EventHandler(this.angleRefPointMinDist_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "angle lmit degrees";
            // 
            // angleLimitDegree
            // 
            this.angleLimitDegree.DecimalPlaces = 2;
            this.angleLimitDegree.Location = new System.Drawing.Point(27, 167);
            this.angleLimitDegree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.angleLimitDegree.Name = "angleLimitDegree";
            this.angleLimitDegree.Size = new System.Drawing.Size(66, 23);
            this.angleLimitDegree.TabIndex = 9;
            this.angleLimitDegree.ValueChanged += new System.EventHandler(this.angleLimitDegree_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "min distance";
            // 
            // minDistance
            // 
            this.minDistance.DecimalPlaces = 2;
            this.minDistance.Location = new System.Drawing.Point(27, 141);
            this.minDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minDistance.Name = "minDistance";
            this.minDistance.Size = new System.Drawing.Size(66, 23);
            this.minDistance.TabIndex = 7;
            this.minDistance.ValueChanged += new System.EventHandler(this.minDistance_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "max merge distance";
            // 
            // maxMergeDistance
            // 
            this.maxMergeDistance.DecimalPlaces = 2;
            this.maxMergeDistance.Location = new System.Drawing.Point(27, 86);
            this.maxMergeDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxMergeDistance.Name = "maxMergeDistance";
            this.maxMergeDistance.Size = new System.Drawing.Size(66, 23);
            this.maxMergeDistance.TabIndex = 5;
            this.maxMergeDistance.ValueChanged += new System.EventHandler(this.maxMergeDistance_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "metric angle weight";
            // 
            // numMetricAngleWeight
            // 
            this.numMetricAngleWeight.DecimalPlaces = 2;
            this.numMetricAngleWeight.Location = new System.Drawing.Point(27, 59);
            this.numMetricAngleWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numMetricAngleWeight.Name = "numMetricAngleWeight";
            this.numMetricAngleWeight.Size = new System.Drawing.Size(66, 23);
            this.numMetricAngleWeight.TabIndex = 3;
            this.numMetricAngleWeight.ValueChanged += new System.EventHandler(this.numMetricAngleWeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pattern Matcher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "metric distance weight ";
            // 
            // numMetricDistanceWeight
            // 
            this.numMetricDistanceWeight.DecimalPlaces = 2;
            this.numMetricDistanceWeight.Location = new System.Drawing.Point(27, 33);
            this.numMetricDistanceWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numMetricDistanceWeight.Name = "numMetricDistanceWeight";
            this.numMetricDistanceWeight.Size = new System.Drawing.Size(66, 23);
            this.numMetricDistanceWeight.TabIndex = 0;
            this.numMetricDistanceWeight.ValueChanged += new System.EventHandler(this.numMetricDistanceWeight_ValueChanged);
            // 
            // tmrDrawing
            // 
            this.tmrDrawing.Interval = 1000;
            this.tmrDrawing.Tick += new System.EventHandler(this.tmrDrawing_Tick);
            // 
            // ofdStrokes
            // 
            this.ofdStrokes.DefaultExt = "json";
            this.ofdStrokes.Filter = "JSON|*.json|All files|*.*";
            // 
            // sfdStrokes
            // 
            this.sfdStrokes.DefaultExt = "json";
            this.sfdStrokes.Filter = "JSON|*.json|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtConsole);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Wykryj Mycha 2023";
            this.tabControl1.ResumeLayout(false);
            this.tpDrawing.ResumeLayout(false);
            this.tpDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).EndInit();
            this.tpVisualisation.ResumeLayout(false);
            this.tpVisualisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteps)).EndInit();
            this.tpPatterns.ResumeLayout(false);
            this.tpPatterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngleWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).EndInit();
            this.tpTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStroke)).EndInit();
            this.tpGenetic.ResumeLayout(false);
            this.tpGenetic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectedSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxItertions)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawingTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleRefPointMinDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleLimitDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMergeDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMetricAngleWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMetricDistanceWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDrawing;
        private System.Windows.Forms.TabPage tpPatterns;
        private System.Windows.Forms.PictureBox picDrawing;
        private System.Windows.Forms.TextBox txtNewPatternName;
        private System.Windows.Forms.Button btnAddPattern;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpVisualisation;
        private System.Windows.Forms.ListBox lstStepPatterns;
        private System.Windows.Forms.TrackBar trbSteps;
        private System.Windows.Forms.PictureBox picSteps;
        private System.Windows.Forms.Button btnDeletePattern;
        private System.Windows.Forms.Button btnExportPatterns;
        private System.Windows.Forms.PictureBox picPattern;
        private System.Windows.Forms.ListBox lstEditorPatterns;
        private System.Windows.Forms.NumericUpDown numMetricDistanceWeight;
        private Label label8;
        private Label label6;
        private NumericUpDown angleRefPointMinDist;
        private Label label7;
        private NumericUpDown angleLimitDegree;
        private Label label4;
        private NumericUpDown minDistance;
        private Label label5;
        private NumericUpDown maxMergeDistance;
        private Label label3;
        private NumericUpDown numMetricAngleWeight;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer tmrDrawing;
        private NumericUpDown numDrawingTimeout;
        private Label lblProgramSettings;
        private Label label9;
        private TabPage tpTests;
        private Button btnAddStroke;
        private Button btnRunTests;
        private PictureBox picStroke;
        private ListBox lstStrokes;
        private Button btnImportPatterns;
        private Button btnImportStrokes;
        private Button btnExportStrokes;
        private OpenFileDialog ofdStrokes;
        private SaveFileDialog sfdStrokes;
        private Button btnDeleteStroke;
        private Button btnClearStrokes;
        private NumericUpDown numDistanceWeight;
        private NumericUpDown numAngleWeight;
        private Button btnSaveWeights;
        private Label lblDistanceWeight;
        private Label lblAngleWeight;
        private TabPage tpGenetic;
        private Button btnOptimise;
        private NumericUpDown numTargetQuality;
        private Label label18;
        private Label label17;
        private Label label16;
        private NumericUpDown numMutationProbability;
        private Label label15;
        private NumericUpDown numSelectedSize;
        private Label label14;
        private NumericUpDown numPopulationSize;
        private NumericUpDown numMaxItertions;
        private Label lblGeneticAlgorithmSettings;
        private TextBox txtSequence;
        private Label lblSeqence;
    }
}

