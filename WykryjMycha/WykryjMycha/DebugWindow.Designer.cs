namespace WykryjMycha
{
    partial class DebugWindow
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
            this.picTest = new System.Windows.Forms.PictureBox();
            this.btnAddPattern = new System.Windows.Forms.Button();
            this.txtPatternName = new System.Windows.Forms.TextBox();
            this.lblPatternName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // picTest
            // 
            this.picTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTest.Location = new System.Drawing.Point(12, 12);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(300, 300);
            this.picTest.TabIndex = 1;
            this.picTest.TabStop = false;
            this.picTest.Paint += new System.Windows.Forms.PaintEventHandler(this.picTest_Paint);
            this.picTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picTest_MouseClick);
            this.picTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTest_MouseDown);
            this.picTest.MouseLeave += new System.EventHandler(this.picTest_MouseLeave);
            this.picTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTest_MouseMove);
            this.picTest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTest_MouseUp);
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Location = new System.Drawing.Point(237, 318);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(75, 23);
            this.btnAddPattern.TabIndex = 2;
            this.btnAddPattern.Text = "Add";
            this.btnAddPattern.UseVisualStyleBackColor = true;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // txtPatternName
            // 
            this.txtPatternName.Location = new System.Drawing.Point(96, 318);
            this.txtPatternName.Name = "txtPatternName";
            this.txtPatternName.Size = new System.Drawing.Size(135, 23);
            this.txtPatternName.TabIndex = 3;
            // 
            // lblPatternName
            // 
            this.lblPatternName.AutoSize = true;
            this.lblPatternName.Location = new System.Drawing.Point(12, 322);
            this.lblPatternName.Name = "lblPatternName";
            this.lblPatternName.Size = new System.Drawing.Size(78, 15);
            this.lblPatternName.TabIndex = 4;
            this.lblPatternName.Text = "Pattern name";
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 353);
            this.Controls.Add(this.lblPatternName);
            this.Controls.Add(this.txtPatternName);
            this.Controls.Add(this.btnAddPattern);
            this.Controls.Add(this.picTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugWindow";
            this.Text = "DebugWindow";
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picTest;
        private Button btnAddPattern;
        private TextBox txtPatternName;
        private Label lblPatternName;
    }
}