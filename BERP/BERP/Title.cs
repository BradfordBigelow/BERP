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
    public partial class formTitle : Form
    {
        public formTitle()
        {
            InitializeComponent();
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bERPDataSetTitle);

        }

        private void formTitle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bERPDataSetTitle.Title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.bERPDataSetTitle.Title);

        }
    }
}
