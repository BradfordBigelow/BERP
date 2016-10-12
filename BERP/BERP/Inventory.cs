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
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bERPDataSetInventory);

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bERPDataSetInventory.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.bERPDataSetInventory.Inventory);

        }
    }
}
