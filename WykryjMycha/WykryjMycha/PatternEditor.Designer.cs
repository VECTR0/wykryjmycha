namespace WykryjMycha
{
    partial class PatternEditor
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
            this.picPattern = new System.Windows.Forms.PictureBox();
            this.lstPatterns = new System.Windows.Forms.ListBox();
            this.btnSavePattern = new System.Windows.Forms.Button();
            this.btnDeletePattern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // picPattern
            // 
            this.picPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPattern.Location = new System.Drawing.Point(12, 12);
            this.picPattern.Name = "picPattern";
            this.picPattern.Size = new System.Drawing.Size(300, 300);
            this.picPattern.TabIndex = 2;
            this.picPattern.TabStop = false;
            // 
            // lstPatterns
            // 
            this.lstPatterns.FormattingEnabled = true;
            this.lstPatterns.ItemHeight = 15;
            this.lstPatterns.Location = new System.Drawing.Point(318, 12);
            this.lstPatterns.Name = "lstPatterns";
            this.lstPatterns.Size = new System.Drawing.Size(156, 274);
            this.lstPatterns.TabIndex = 3;
            this.lstPatterns.SelectedIndexChanged += new System.EventHandler(this.lstPatterns_SelectedIndexChanged);
            // 
            // btnSavePattern
            // 
            this.btnSavePattern.Location = new System.Drawing.Point(318, 290);
            this.btnSavePattern.Name = "btnSavePattern";
            this.btnSavePattern.Size = new System.Drawing.Size(75, 23);
            this.btnSavePattern.TabIndex = 4;
            this.btnSavePattern.Text = "Save";
            this.btnSavePattern.UseVisualStyleBackColor = true;
            this.btnSavePattern.Click += new System.EventHandler(this.btnSavePattern_Click);
            // 
            // btnDeletePattern
            // 
            this.btnDeletePattern.Location = new System.Drawing.Point(399, 290);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePattern.TabIndex = 5;
            this.btnDeletePattern.Text = "Delete";
            this.btnDeletePattern.UseVisualStyleBackColor = true;
            this.btnDeletePattern.Click += new System.EventHandler(this.btnDeletePattern_Click);
            // 
            // PatternEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 325);
            this.Controls.Add(this.btnDeletePattern);
            this.Controls.Add(this.btnSavePattern);
            this.Controls.Add(this.lstPatterns);
            this.Controls.Add(this.picPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PatternEditor";
            this.Text = "PatternEditor";
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picPattern;
        private ListBox lstPatterns;
        private Button btnSavePattern;
        private Button btnDeletePattern;
    }
}