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
        SqlConnection sqlConnection = new SqlConnection("Data Source=BRADFORD-DB;Integrated Security=False;User ID=BERP;Password=berp;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter("select * from Users where UserID = '" + textBoxUsername.Text + "' and Password = '" + textBoxPassword.Text + "' ", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdaptor.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                formBERP berp = new formBERP();
                this.Hide();
                berp.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password", "ERROR",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
