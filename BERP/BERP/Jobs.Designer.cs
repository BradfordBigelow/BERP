namespace BERP
{
    partial class formJobs
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
            this.labelJobs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJobs
            // 
            this.labelJobs.AutoSize = true;
            this.labelJobs.Location = new System.Drawing.Point(125, 125);
            this.labelJobs.Name = "labelJobs";
            this.labelJobs.Size = new System.Drawing.Size(29, 13);
            this.labelJobs.TabIndex = 1;
            this.labelJobs.Text = "Jobs";
            // 
            // formJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.labelJobs);
            this.Name = "formJobs";
            this.Text = "Jobs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJobs;
    }
}