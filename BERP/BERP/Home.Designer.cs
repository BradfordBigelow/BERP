namespace BERP
{
    partial class formHome
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
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJobs
            // 
            this.btnJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobs.Location = new System.Drawing.Point(70, 119);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(150, 50);
            this.btnJobs.TabIndex = 3;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(70, 189);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(150, 50);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers/   Prospects";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(975, 725);
            this.ControlBox = false;
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnJobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnCustomers;
    }
}