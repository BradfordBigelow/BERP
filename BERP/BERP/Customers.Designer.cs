namespace BERP
{
    partial class formCustomers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxBillToID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCreditTermsID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCSRID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSalespersonID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddress3 = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSalesCategoryID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSalesCategory = new System.Windows.Forms.TextBox();
            this.textBoxBillToName = new System.Windows.Forms.TextBox();
            this.textBoxCreditTermsDescription = new System.Windows.Forms.TextBox();
            this.textBoxSalespersonName = new System.Windows.Forms.TextBox();
            this.textBoxCSRName = new System.Windows.Forms.TextBox();
            this.textBoxActive = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(956, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID :";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(136, 77);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 2;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(242, 77);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(274, 20);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // textBoxBillToID
            // 
            this.textBoxBillToID.Location = new System.Drawing.Point(647, 77);
            this.textBoxBillToID.Name = "textBoxBillToID";
            this.textBoxBillToID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillToID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BillTo ID : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCreditTermsID
            // 
            this.textBoxCreditTermsID.Location = new System.Drawing.Point(647, 103);
            this.textBoxCreditTermsID.Name = "textBoxCreditTermsID";
            this.textBoxCreditTermsID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditTermsID.TabIndex = 7;
            this.textBoxCreditTermsID.Text = "Net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credit Terms ID : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCSRID
            // 
            this.textBoxCSRID.Location = new System.Drawing.Point(136, 103);
            this.textBoxCSRID.Name = "textBoxCSRID";
            this.textBoxCSRID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCSRID.TabIndex = 9;
            this.textBoxCSRID.Text = "PA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CSR ID :";
            // 
            // textBoxSalespersonID
            // 
            this.textBoxSalespersonID.Location = new System.Drawing.Point(136, 129);
            this.textBoxSalespersonID.Name = "textBoxSalespersonID";
            this.textBoxSalespersonID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalespersonID.TabIndex = 11;
            this.textBoxSalespersonID.Text = "31";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salesperson ID :";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 35);
            this.buttonNew.TabIndex = 12;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(118, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(330, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 35);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(224, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 35);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Credit Limit : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(647, 129);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditLimit.TabIndex = 17;
            this.textBoxCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCreditLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreditLimit_KeyPress);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(136, 181);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(380, 20);
            this.textBoxAddress1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address :";
            // 
            // textBoxAddress3
            // 
            this.textBoxAddress3.Location = new System.Drawing.Point(136, 233);
            this.textBoxAddress3.Name = "textBoxAddress3";
            this.textBoxAddress3.Size = new System.Drawing.Size(380, 20);
            this.textBoxAddress3.TabIndex = 20;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(136, 207);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(380, 20);
            this.textBoxAddress2.TabIndex = 21;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(136, 259);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(188, 20);
            this.textBoxCity.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "CIty, State Zip :";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(330, 259);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(44, 20);
            this.textBoxState.TabIndex = 25;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(380, 259);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(136, 20);
            this.textBoxZip.TabIndex = 26;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(136, 155);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(380, 20);
            this.textBoxPhoneNumber.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Phone :";
            // 
            // textBoxSalesCategoryID
            // 
            this.textBoxSalesCategoryID.Location = new System.Drawing.Point(647, 155);
            this.textBoxSalesCategoryID.Name = "textBoxSalesCategoryID";
            this.textBoxSalesCategoryID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalesCategoryID.TabIndex = 30;
            this.textBoxSalesCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Sales Category :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSalesCategory
            // 
            this.textBoxSalesCategory.Location = new System.Drawing.Point(753, 155);
            this.textBoxSalesCategory.Name = "textBoxSalesCategory";
            this.textBoxSalesCategory.Size = new System.Drawing.Size(215, 20);
            this.textBoxSalesCategory.TabIndex = 31;
            this.textBoxSalesCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBillToName
            // 
            this.textBoxBillToName.Location = new System.Drawing.Point(753, 77);
            this.textBoxBillToName.Name = "textBoxBillToName";
            this.textBoxBillToName.Size = new System.Drawing.Size(215, 20);
            this.textBoxBillToName.TabIndex = 32;
            // 
            // textBoxCreditTermsDescription
            // 
            this.textBoxCreditTermsDescription.Location = new System.Drawing.Point(753, 103);
            this.textBoxCreditTermsDescription.Name = "textBoxCreditTermsDescription";
            this.textBoxCreditTermsDescription.Size = new System.Drawing.Size(215, 20);
            this.textBoxCreditTermsDescription.TabIndex = 33;
            this.textBoxCreditTermsDescription.Text = "Net";
            // 
            // textBoxSalespersonName
            // 
            this.textBoxSalespersonName.Location = new System.Drawing.Point(242, 129);
            this.textBoxSalespersonName.Name = "textBoxSalespersonName";
            this.textBoxSalespersonName.Size = new System.Drawing.Size(274, 20);
            this.textBoxSalespersonName.TabIndex = 34;
            // 
            // textBoxCSRName
            // 
            this.textBoxCSRName.Location = new System.Drawing.Point(242, 103);
            this.textBoxCSRName.Name = "textBoxCSRName";
            this.textBoxCSRName.Size = new System.Drawing.Size(274, 20);
            this.textBoxCSRName.TabIndex = 35;
            // 
            // textBoxActive
            // 
            this.textBoxActive.Location = new System.Drawing.Point(647, 181);
            this.textBoxActive.MaxLength = 1;
            this.textBoxActive.Name = "textBoxActive";
            this.textBoxActive.Size = new System.Drawing.Size(22, 20);
            this.textBoxActive.TabIndex = 37;
            this.textBoxActive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxActive_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Active :";
            // 
            // formCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.textBoxActive);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCSRName);
            this.Controls.Add(this.textBoxSalespersonName);
            this.Controls.Add(this.textBoxCreditTermsDescription);
            this.Controls.Add(this.textBoxBillToName);
            this.Controls.Add(this.textBoxSalesCategory);
            this.Controls.Add(this.textBoxSalesCategoryID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxAddress3);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCreditLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.textBoxSalespersonID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCSRID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCreditTermsID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBillToID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.formCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxBillToID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCreditTermsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCSRID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSalespersonID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAddress3;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSalesCategoryID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSalesCategory;
        private System.Windows.Forms.TextBox textBoxBillToName;
        private System.Windows.Forms.TextBox textBoxCreditTermsDescription;
        private System.Windows.Forms.TextBox textBoxSalespersonName;
        private System.Windows.Forms.TextBox textBoxCSRName;
        private System.Windows.Forms.TextBox textBoxActive;
        private System.Windows.Forms.Label label11;
    }
}