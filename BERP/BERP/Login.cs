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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(this, new EventArgs());
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SQLConnectionToBERP sqlConnectionToBERP = new SQLConnectionToBERP();
            SqlDataAdapter sqlDataAdaptorToBERP = new SqlDataAdapter("select * from Users where UserID = '" + textBox_Username.Text + "' and Password = '" + textBox_Password.Text + "' ", sqlConnectionToBERP.ActiveCon());
            DataTable dataTable = new DataTable();
           
            sqlDataAdaptorToBERP.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                formBERP berp = new formBERP();
                this.Hide();
                berp.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}