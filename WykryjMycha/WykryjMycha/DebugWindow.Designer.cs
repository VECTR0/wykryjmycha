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
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 326);
            this.Controls.Add(this.picTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugWindow";
            this.Text = "DebugWindow";
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picTest;
    }
}