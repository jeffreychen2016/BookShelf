namespace BookShelf
{
    partial class frmTitles
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
            this.txtConn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtConn
            // 
            this.txtConn.Location = new System.Drawing.Point(94, 408);
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(614, 22);
            this.txtConn.TabIndex = 0;
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConn);
            this.Name = "frmTitles";
            this.Text = "Titles Database";
            this.Load += new System.EventHandler(this.frmTitles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConn;
    }
}

