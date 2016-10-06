using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERP
{
    public partial class formCustomers : Form
    {
        public formCustomers()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bERPDataSetCustomer);

        }

        private void formCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bERPDataSetCustomer.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bERPDataSetCustomer.Customer);

        }
    }
}
