﻿namespace WykryjMycha
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tpPatterns = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tpDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
            this.tpVisualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tpPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(14, 436);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(804, 125);
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
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 415);
            this.tabControl1.TabIndex = 2;
            // 
            // tpDrawing
            // 
            this.tpDrawing.Controls.Add(this.btnAddPattern);
            this.tpDrawing.Controls.Add(this.picDrawing);
            this.tpDrawing.Controls.Add(this.txtNewPatternName);
            this.tpDrawing.Location = new System.Drawing.Point(4, 24);
            this.tpDrawing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDrawing.Name = "tpDrawing";
            this.tpDrawing.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDrawing.Size = new System.Drawing.Size(802, 387);
            this.tpDrawing.TabIndex = 0;
            this.tpDrawing.Text = "Drawing";
            this.tpDrawing.UseVisualStyleBackColor = true;
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Location = new System.Drawing.Point(270, 354);
            this.btnAddPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(88, 27);
            this.btnAddPattern.TabIndex = 4;
            this.btnAddPattern.Text = "Add Pattern";
            this.btnAddPattern.UseVisualStyleBackColor = true;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // picDrawing
            // 
            this.picDrawing.Location = new System.Drawing.Point(7, 7);
            this.picDrawing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDrawing.Name = "picDrawing";
            this.picDrawing.Size = new System.Drawing.Size(350, 346);
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
            this.txtNewPatternName.Location = new System.Drawing.Point(7, 357);
            this.txtNewPatternName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewPatternName.Name = "txtNewPatternName";
            this.txtNewPatternName.PlaceholderText = "New Pattern Name";
            this.txtNewPatternName.Size = new System.Drawing.Size(255, 23);
            this.txtNewPatternName.TabIndex = 3;
            // 
            // tpVisualisation
            // 
            this.tpVisualisation.Controls.Add(this.listBox1);
            this.tpVisualisation.Controls.Add(this.trackBar1);
            this.tpVisualisation.Controls.Add(this.pictureBox3);
            this.tpVisualisation.Location = new System.Drawing.Point(4, 24);
            this.tpVisualisation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpVisualisation.Name = "tpVisualisation";
            this.tpVisualisation.Size = new System.Drawing.Size(802, 387);
            this.tpVisualisation.TabIndex = 3;
            this.tpVisualisation.Text = "Algorithm Visualisation";
            this.tpVisualisation.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(4, 3);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 349);
            this.listBox1.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(528, 3);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 350);
            this.trackBar1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(172, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 346);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // tpPatterns
            // 
            this.tpPatterns.Controls.Add(this.button4);
            this.tpPatterns.Controls.Add(this.Save);
            this.tpPatterns.Controls.Add(this.pictureBox1);
            this.tpPatterns.Controls.Add(this.listBox2);
            this.tpPatterns.Location = new System.Drawing.Point(4, 24);
            this.tpPatterns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpPatterns.Name = "tpPatterns";
            this.tpPatterns.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpPatterns.Size = new System.Drawing.Size(802, 387);
            this.tpPatterns.TabIndex = 1;
            this.tpPatterns.Text = "Patterns Editor";
            this.tpPatterns.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 27);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(532, 43);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 27);
            this.Save.TabIndex = 12;
            this.Save.Text = "button3";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 346);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(7, 7);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(160, 349);
            this.listBox2.TabIndex = 9;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.numericUpDown3);
            this.tpSettings.Controls.Add(this.numericUpDown2);
            this.tpSettings.Controls.Add(this.numericUpDown1);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(802, 387);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(4, 63);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(140, 23);
            this.numericUpDown3.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(4, 33);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(140, 23);
            this.numericUpDown2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(4, 3);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpDrawing.ResumeLayout(false);
            this.tpDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).EndInit();
            this.tpVisualisation.ResumeLayout(false);
            this.tpVisualisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tpPatterns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

