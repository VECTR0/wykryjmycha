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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDrawing = new System.Windows.Forms.TabPage();
            this.btnAddPattern = new System.Windows.Forms.Button();
            this.picDrawing = new System.Windows.Forms.PictureBox();
            this.txtNewPatternName = new System.Windows.Forms.TextBox();
            this.tpVisualisation = new System.Windows.Forms.TabPage();
            this.lstStepPatterns = new System.Windows.Forms.ListBox();
            this.trbSteps = new System.Windows.Forms.TrackBar();
            this.picSteps = new System.Windows.Forms.PictureBox();
            this.tpPatterns = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstEditorPatterns = new System.Windows.Forms.ListBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.lblAngleRefPointMinDist = new System.Windows.Forms.Label();
            this.angleRefPointMinDist = new System.Windows.Forms.NumericUpDown();
            this.lblAngleLimitDegree = new System.Windows.Forms.Label();
            this.angleLimitDegree = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMinDistance = new System.Windows.Forms.Label();
            this.minDistance = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMergeDistance = new System.Windows.Forms.Label();
            this.maxMergeDistance = new System.Windows.Forms.NumericUpDown();
            this.lblMaxAllowedRotation = new System.Windows.Forms.Label();
            this.maxAllowedRotation = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxSearchDistance = new System.Windows.Forms.Label();
            this.maxSearchDistance = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tpDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
            this.tpVisualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteps)).BeginInit();
            this.tpPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleRefPointMinDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleLimitDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMergeDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAllowedRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSearchDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(16, 581);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(918, 165);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpDrawing);
            this.tabControl1.Controls.Add(this.tpVisualisation);
            this.tabControl1.Controls.Add(this.tpPatterns);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Location = new System.Drawing.Point(16, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 553);
            this.tabControl1.TabIndex = 2;
            // 
            // tpDrawing
            // 
            this.tpDrawing.Controls.Add(this.btnAddPattern);
            this.tpDrawing.Controls.Add(this.picDrawing);
            this.tpDrawing.Controls.Add(this.txtNewPatternName);
            this.tpDrawing.Location = new System.Drawing.Point(4, 29);
            this.tpDrawing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpDrawing.Name = "tpDrawing";
            this.tpDrawing.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpDrawing.Size = new System.Drawing.Size(918, 520);
            this.tpDrawing.TabIndex = 0;
            this.tpDrawing.Text = "Drawing";
            this.tpDrawing.UseVisualStyleBackColor = true;
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Location = new System.Drawing.Point(309, 472);
            this.btnAddPattern.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(101, 36);
            this.btnAddPattern.TabIndex = 4;
            this.btnAddPattern.Text = "Add Pattern";
            this.btnAddPattern.UseVisualStyleBackColor = true;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // picDrawing
            // 
            this.picDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrawing.Location = new System.Drawing.Point(8, 9);
            this.picDrawing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picDrawing.Name = "picDrawing";
            this.picDrawing.Size = new System.Drawing.Size(400, 461);
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
            this.txtNewPatternName.Location = new System.Drawing.Point(8, 476);
            this.txtNewPatternName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNewPatternName.Name = "txtNewPatternName";
            this.txtNewPatternName.PlaceholderText = "New Pattern Name";
            this.txtNewPatternName.Size = new System.Drawing.Size(291, 27);
            this.txtNewPatternName.TabIndex = 3;
            // 
            // tpVisualisation
            // 
            this.tpVisualisation.Controls.Add(this.lstStepPatterns);
            this.tpVisualisation.Controls.Add(this.trbSteps);
            this.tpVisualisation.Controls.Add(this.picSteps);
            this.tpVisualisation.Location = new System.Drawing.Point(4, 29);
            this.tpVisualisation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpVisualisation.Name = "tpVisualisation";
            this.tpVisualisation.Size = new System.Drawing.Size(918, 520);
            this.tpVisualisation.TabIndex = 3;
            this.tpVisualisation.Text = "Algorithm Visualisation";
            this.tpVisualisation.UseVisualStyleBackColor = true;
            // 
            // lstStepPatterns
            // 
            this.lstStepPatterns.FormattingEnabled = true;
            this.lstStepPatterns.ItemHeight = 20;
            this.lstStepPatterns.Location = new System.Drawing.Point(5, 4);
            this.lstStepPatterns.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstStepPatterns.Name = "lstStepPatterns";
            this.lstStepPatterns.Size = new System.Drawing.Size(182, 464);
            this.lstStepPatterns.TabIndex = 8;
            this.lstStepPatterns.SelectedIndexChanged += new System.EventHandler(this.lstStepPatterns_SelectedIndexChanged);
            // 
            // trbSteps
            // 
            this.trbSteps.Location = new System.Drawing.Point(603, 4);
            this.trbSteps.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.trbSteps.Name = "trbSteps";
            this.trbSteps.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbSteps.Size = new System.Drawing.Size(56, 467);
            this.trbSteps.TabIndex = 7;
            this.trbSteps.Scroll += new System.EventHandler(this.trbSteps_Scroll);
            // 
            // picSteps
            // 
            this.picSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSteps.Location = new System.Drawing.Point(197, 4);
            this.picSteps.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picSteps.Name = "picSteps";
            this.picSteps.Size = new System.Drawing.Size(400, 461);
            this.picSteps.TabIndex = 6;
            this.picSteps.TabStop = false;
            // 
            // tpPatterns
            // 
            this.tpPatterns.Controls.Add(this.button4);
            this.tpPatterns.Controls.Add(this.Save);
            this.tpPatterns.Controls.Add(this.pictureBox1);
            this.tpPatterns.Controls.Add(this.lstEditorPatterns);
            this.tpPatterns.Location = new System.Drawing.Point(4, 29);
            this.tpPatterns.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpPatterns.Name = "tpPatterns";
            this.tpPatterns.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpPatterns.Size = new System.Drawing.Size(918, 520);
            this.tpPatterns.TabIndex = 1;
            this.tpPatterns.Text = "Patterns Editor";
            this.tpPatterns.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(608, 57);
            this.Save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 36);
            this.Save.TabIndex = 12;
            this.Save.Text = "button3";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 461);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lstEditorPatterns
            // 
            this.lstEditorPatterns.FormattingEnabled = true;
            this.lstEditorPatterns.ItemHeight = 20;
            this.lstEditorPatterns.Location = new System.Drawing.Point(8, 9);
            this.lstEditorPatterns.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstEditorPatterns.Name = "lstEditorPatterns";
            this.lstEditorPatterns.Size = new System.Drawing.Size(182, 464);
            this.lstEditorPatterns.TabIndex = 9;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.lblAngleRefPointMinDist);
            this.tpSettings.Controls.Add(this.angleRefPointMinDist);
            this.tpSettings.Controls.Add(this.lblAngleLimitDegree);
            this.tpSettings.Controls.Add(this.angleLimitDegree);
            this.tpSettings.Controls.Add(this.label7);
            this.tpSettings.Controls.Add(this.lblMinDistance);
            this.tpSettings.Controls.Add(this.minDistance);
            this.tpSettings.Controls.Add(this.lblMaxMergeDistance);
            this.tpSettings.Controls.Add(this.maxMergeDistance);
            this.tpSettings.Controls.Add(this.lblMaxAllowedRotation);
            this.tpSettings.Controls.Add(this.maxAllowedRotation);
            this.tpSettings.Controls.Add(this.label1);
            this.tpSettings.Controls.Add(this.lblMaxSearchDistance);
            this.tpSettings.Controls.Add(this.maxSearchDistance);
            this.tpSettings.Location = new System.Drawing.Point(4, 29);
            this.tpSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(918, 520);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // lblAngleRefPointMinDist
            // 
            this.lblAngleRefPointMinDist.AutoSize = true;
            this.lblAngleRefPointMinDist.Location = new System.Drawing.Point(106, 263);
            this.lblAngleRefPointMinDist.Name = "lblAngleRefPointMinDist";
            this.lblAngleRefPointMinDist.Size = new System.Drawing.Size(239, 20);
            this.lblAngleRefPointMinDist.TabIndex = 20;
            this.lblAngleRefPointMinDist.Text = "angle reference point min distance";
            // 
            // angleRefPointMinDist
            // 
            this.angleRefPointMinDist.DecimalPlaces = 2;
            this.angleRefPointMinDist.Location = new System.Drawing.Point(18, 261);
            this.angleRefPointMinDist.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.angleRefPointMinDist.Name = "angleRefPointMinDist";
            this.angleRefPointMinDist.Size = new System.Drawing.Size(80, 27);
            this.angleRefPointMinDist.TabIndex = 19;
            this.angleRefPointMinDist.ValueChanged += new System.EventHandler(this.angleRefPointMinDist_ValueChanged);
            // 
            // lblAngleLimitDegree
            // 
            this.lblAngleLimitDegree.AutoSize = true;
            this.lblAngleLimitDegree.Location = new System.Drawing.Point(106, 228);
            this.lblAngleLimitDegree.Name = "lblAngleLimitDegree";
            this.lblAngleLimitDegree.Size = new System.Drawing.Size(131, 20);
            this.lblAngleLimitDegree.TabIndex = 18;
            this.lblAngleLimitDegree.Text = "angle limit degree";
            // 
            // angleLimitDegree
            // 
            this.angleLimitDegree.DecimalPlaces = 2;
            this.angleLimitDegree.Location = new System.Drawing.Point(18, 226);
            this.angleLimitDegree.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.angleLimitDegree.Name = "angleLimitDegree";
            this.angleLimitDegree.Size = new System.Drawing.Size(80, 27);
            this.angleLimitDegree.TabIndex = 17;
            this.angleLimitDegree.ValueChanged += new System.EventHandler(this.angleLimitDegree_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Characteristic Points Finder";
            // 
            // lblMinDistance
            // 
            this.lblMinDistance.AutoSize = true;
            this.lblMinDistance.Location = new System.Drawing.Point(106, 193);
            this.lblMinDistance.Name = "lblMinDistance";
            this.lblMinDistance.Size = new System.Drawing.Size(93, 20);
            this.lblMinDistance.TabIndex = 15;
            this.lblMinDistance.Text = "min distance";
            // 
            // minDistance
            // 
            this.minDistance.DecimalPlaces = 2;
            this.minDistance.Location = new System.Drawing.Point(18, 191);
            this.minDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.minDistance.Name = "minDistance";
            this.minDistance.Size = new System.Drawing.Size(80, 27);
            this.minDistance.TabIndex = 14;
            this.minDistance.ValueChanged += new System.EventHandler(this.minDistance_ValueChanged);
            // 
            // lblMaxMergeDistance
            // 
            this.lblMaxMergeDistance.AutoSize = true;
            this.lblMaxMergeDistance.Location = new System.Drawing.Point(106, 118);
            this.lblMaxMergeDistance.Name = "lblMaxMergeDistance";
            this.lblMaxMergeDistance.Size = new System.Drawing.Size(143, 20);
            this.lblMaxMergeDistance.TabIndex = 13;
            this.lblMaxMergeDistance.Text = "max merge distance";
            // 
            // maxMergeDistance
            // 
            this.maxMergeDistance.DecimalPlaces = 2;
            this.maxMergeDistance.Location = new System.Drawing.Point(18, 116);
            this.maxMergeDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxMergeDistance.Name = "maxMergeDistance";
            this.maxMergeDistance.Size = new System.Drawing.Size(80, 27);
            this.maxMergeDistance.TabIndex = 12;
            this.maxMergeDistance.ValueChanged += new System.EventHandler(this.maxMergeDistance_ValueChanged);
            // 
            // lblMaxAllowedRotation
            // 
            this.lblMaxAllowedRotation.AutoSize = true;
            this.lblMaxAllowedRotation.Location = new System.Drawing.Point(106, 83);
            this.lblMaxAllowedRotation.Name = "lblMaxAllowedRotation";
            this.lblMaxAllowedRotation.Size = new System.Drawing.Size(151, 20);
            this.lblMaxAllowedRotation.TabIndex = 11;
            this.lblMaxAllowedRotation.Text = "max allowed rotation";
            // 
            // maxAllowedRotation
            // 
            this.maxAllowedRotation.DecimalPlaces = 2;
            this.maxAllowedRotation.Location = new System.Drawing.Point(18, 81);
            this.maxAllowedRotation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxAllowedRotation.Name = "maxAllowedRotation";
            this.maxAllowedRotation.Size = new System.Drawing.Size(80, 27);
            this.maxAllowedRotation.TabIndex = 10;
            this.maxAllowedRotation.ValueChanged += new System.EventHandler(this.maxAllowedRotation_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pattern Matcher";
            // 
            // lblMaxSearchDistance
            // 
            this.lblMaxSearchDistance.AutoSize = true;
            this.lblMaxSearchDistance.Location = new System.Drawing.Point(106, 48);
            this.lblMaxSearchDistance.Name = "lblMaxSearchDistance";
            this.lblMaxSearchDistance.Size = new System.Drawing.Size(142, 20);
            this.lblMaxSearchDistance.TabIndex = 8;
            this.lblMaxSearchDistance.Text = "max search distance";
            // 
            // maxSearchDistance
            // 
            this.maxSearchDistance.DecimalPlaces = 2;
            this.maxSearchDistance.Location = new System.Drawing.Point(18, 46);
            this.maxSearchDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxSearchDistance.Name = "maxSearchDistance";
            this.maxSearchDistance.Size = new System.Drawing.Size(80, 27);
            this.maxSearchDistance.TabIndex = 7;
            this.maxSearchDistance.ValueChanged += new System.EventHandler(this.maxSearchDistance_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 768);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpDrawing.ResumeLayout(false);
            this.tpDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).EndInit();
            this.tpVisualisation.ResumeLayout(false);
            this.tpVisualisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteps)).EndInit();
            this.tpPatterns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleRefPointMinDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleLimitDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMergeDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAllowedRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSearchDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstEditorPatterns;
        private Label lblAngleRefPointMinDist;
        private NumericUpDown angleRefPointMinDist;
        private Label lblAngleLimitDegree;
        private NumericUpDown angleLimitDegree;
        private Label label7;
        private Label lblMinDistance;
        private NumericUpDown minDistance;
        private Label lblMaxMergeDistance;
        private NumericUpDown maxMergeDistance;
        private Label lblMaxAllowedRotation;
        private NumericUpDown maxAllowedRotation;
        private Label label1;
        private Label lblMaxSearchDistance;
        private NumericUpDown maxSearchDistance;
    }
}

