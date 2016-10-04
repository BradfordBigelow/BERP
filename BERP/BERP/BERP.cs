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
    public partial class formBERP : Form
    {
        public formBERP()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHome formHome = new formHome();
            // Set the Parent Form of the Child window.
            formHome.MdiParent = this;
            // Display the new form.
            formHome.Show();
        }
    }
}
