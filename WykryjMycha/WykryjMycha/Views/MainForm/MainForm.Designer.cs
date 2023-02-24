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
            this.txtConsole = new System.Windows.Forms.TextBox();
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
            this.btnDeletePattern = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.picPattern = new System.Windows.Forms.PictureBox();
            this.lstEditorPatterns = new System.Windows.Forms.ListBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.maxSearchDistance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxAllowedRotation = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxMergeDistance = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.angleRefPointMinDist = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.angleLimitDegree = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
            this.tpVisualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteps)).BeginInit();
            this.tpPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).BeginInit();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSearchDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAllowedRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMergeDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleRefPointMinDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleLimitDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(16, 581);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(918, 165);
            this.txtConsole.TabIndex = 0;
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
            this.tpPatterns.Controls.Add(this.btnDeletePattern);
            this.tpPatterns.Controls.Add(this.Save);
            this.tpPatterns.Controls.Add(this.picPattern);
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
            // btnDeletePattern
            // 
            this.btnDeletePattern.Location = new System.Drawing.Point(608, 12);
            this.btnDeletePattern.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(101, 36);
            this.btnDeletePattern.TabIndex = 13;
            this.btnDeletePattern.Text = "Delete";
            this.btnDeletePattern.UseVisualStyleBackColor = true;
            this.btnDeletePattern.Click += new System.EventHandler(this.btnDeletePattern_Click);
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
            // picPattern
            // 
            this.picPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPattern.Location = new System.Drawing.Point(200, 12);
            this.picPattern.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picPattern.Name = "picPattern";
            this.picPattern.Size = new System.Drawing.Size(400, 461);
            this.picPattern.TabIndex = 10;
            this.picPattern.TabStop = false;
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
            this.lstEditorPatterns.SelectedIndexChanged += new System.EventHandler(this.lstEditorPatterns_SelectedIndexChanged);
            // 
            // tpSettings
            // 
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
            this.tpSettings.Controls.Add(this.maxAllowedRotation);
            this.tpSettings.Controls.Add(this.label2);
            this.tpSettings.Controls.Add(this.label1);
            this.tpSettings.Controls.Add(this.maxSearchDistance);
            this.tpSettings.Location = new System.Drawing.Point(4, 29);
            this.tpSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(918, 520);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // maxSearchDistance
            // 
            this.maxSearchDistance.DecimalPlaces = 2;
            this.maxSearchDistance.Location = new System.Drawing.Point(31, 44);
            this.maxSearchDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxSearchDistance.Name = "maxSearchDistance";
            this.maxSearchDistance.Size = new System.Drawing.Size(75, 27);
            this.maxSearchDistance.TabIndex = 0;
            this.maxSearchDistance.ValueChanged += new System.EventHandler(this.maxSearchDistance_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "max search distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pattern Matcher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "max allowed rotation";
            // 
            // maxAllowedRotation
            // 
            this.maxAllowedRotation.DecimalPlaces = 2;
            this.maxAllowedRotation.Location = new System.Drawing.Point(31, 79);
            this.maxAllowedRotation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxAllowedRotation.Name = "maxAllowedRotation";
            this.maxAllowedRotation.Size = new System.Drawing.Size(75, 27);
            this.maxAllowedRotation.TabIndex = 3;
            this.maxAllowedRotation.ValueChanged += new System.EventHandler(this.maxAllowedRotation_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "min distance";
            // 
            // minDistance
            // 
            this.minDistance.DecimalPlaces = 2;
            this.minDistance.Location = new System.Drawing.Point(31, 188);
            this.minDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.minDistance.Name = "minDistance";
            this.minDistance.Size = new System.Drawing.Size(75, 27);
            this.minDistance.TabIndex = 7;
            this.minDistance.ValueChanged += new System.EventHandler(this.minDistance_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "max merge distance";
            // 
            // maxMergeDistance
            // 
            this.maxMergeDistance.DecimalPlaces = 2;
            this.maxMergeDistance.Location = new System.Drawing.Point(31, 114);
            this.maxMergeDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxMergeDistance.Name = "maxMergeDistance";
            this.maxMergeDistance.Size = new System.Drawing.Size(75, 27);
            this.maxMergeDistance.TabIndex = 5;
            this.maxMergeDistance.ValueChanged += new System.EventHandler(this.maxMergeDistance_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "angle reference point min distance";
            // 
            // angleRefPointMinDist
            // 
            this.angleRefPointMinDist.DecimalPlaces = 2;
            this.angleRefPointMinDist.Location = new System.Drawing.Point(31, 258);
            this.angleRefPointMinDist.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.angleRefPointMinDist.Name = "angleRefPointMinDist";
            this.angleRefPointMinDist.Size = new System.Drawing.Size(75, 27);
            this.angleRefPointMinDist.TabIndex = 11;
            this.angleRefPointMinDist.ValueChanged += new System.EventHandler(this.angleRefPointMinDist_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "angle lmit degrees";
            // 
            // angleLimitDegree
            // 
            this.angleLimitDegree.DecimalPlaces = 2;
            this.angleLimitDegree.Location = new System.Drawing.Point(31, 223);
            this.angleLimitDegree.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.angleLimitDegree.Name = "angleLimitDegree";
            this.angleLimitDegree.Size = new System.Drawing.Size(75, 27);
            this.angleLimitDegree.TabIndex = 9;
            this.angleLimitDegree.ValueChanged += new System.EventHandler(this.angleLimitDegree_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Characteristic Points Finder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 768);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtConsole);
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
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSearchDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAllowedRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMergeDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleRefPointMinDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleLimitDegree)).EndInit();
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
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox picPattern;
        private System.Windows.Forms.ListBox lstEditorPatterns;
        private System.Windows.Forms.NumericUpDown maxSearchDistance;
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
        private NumericUpDown maxAllowedRotation;
        private Label label2;
        private Label label1;
    }
}

