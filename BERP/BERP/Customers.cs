using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BERP
{
    public partial class formCustomers : Form
    {
        public formCustomers()
        {
            InitializeComponent();
        }

        private void formCustomers_Load(object sender, EventArgs e)
        {

        }

        void AddRecord()
        {
            // will adda record with an SQL INSERT. Need to check to make sure the CustomerID does not already exist in the table, as it is a unique Primary Key
            SQLConnectionToBERP sqlConnectionToBERP = new SQLConnectionToBERP();
            SqlDataAdapter sqlDataAdaptorToBERP = new SqlDataAdapter("select CustomerID from Customer where CustomerID = '" + textBoxCustomerID.Text + "' ", sqlConnectionToBERP.ActiveCon());
            DataTable dataTable = new DataTable();
            sqlDataAdaptorToBERP.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                // the CustomerID already exists. Show message box and DO NOT insert into table
                MessageBox.Show("CustomerID " + textBoxCustomerID.Text + " already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // the CustomerID does not already exist. OK to insert into table
                SqlCommand sqlCommandToBERP = new SqlCommand(@"
                INSERT INTO Customer
                    ([CustomerID]
                    ,[CustomerName]
                    ,[BillToID]
                    ,[CreditTermsID]
                    ,[CSRID]
                    ,[SalespersonID]
                    ,[Address1]
                    ,[Address2]
                    ,[Address3]
                    ,[City]
                    ,[State]
                    ,[Zip]
                    ,[PhoneNumber]
                    ,[Active]
                    ,[SalesCategoryIDDefault]
                    ,[PhoneNumber]
                    ,[Active]
                    ,[SalesCategoryIDDefault])
                VALUES
                    ('" + textBoxCustomerID.Text.ToString() + "','"
                    + textBoxCustomerName.Text.ToString() + "','"
                    + textBoxBillToID.Text.ToString() + "','"
                    + textBoxCreditTermsID.Text.ToString() + "','"
                    + textBoxCSRID.Text.ToString() + "','"
                    + textBoxSalespersonID.Text.ToString() + "','"
                    + textBoxAddress1.Text.ToString() + "','"
                    + textBoxAddress2.Text.ToString() + "','"
                    + textBoxAddress3.Text.ToString() + "','"
                    + textBoxCity.Text.ToString() + "','"
                    + textBoxState.Text.ToString() + "','"
                    + textBoxZip.Text.ToString() + "','"
                    + textBoxCreditLimit.Text + "','"
                    + textBoxPhoneNumber.Text.ToString() + "','"
                    + textBoxActive.Text.ToString() + "','"
                    + textBoxSalesCategoryID.Text.ToString() + 
                "')"
                , sqlConnectionToBERP.ActiveCon());
                sqlCommandToBERP.ExecuteNonQuery();
                clearFields();
            }
        }

        void clearFields()
        {
            textBoxCustomerID.Text = "";
            textBoxCustomerName.Text = "";
            textBoxBillToID.Text = "";
            textBoxCreditTermsID.Text = "";
            textBoxCSRID.Text = "";
            textBoxSalespersonID.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void textBoxCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBoxActive_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    e.Handled = false;
                    break;
                case "0":
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }
    }
}