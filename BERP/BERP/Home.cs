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
    public partial class formHome : Form
    {
        //formHome frmHome;
        formJobs frmJobs;
        formCustomers frmCustomers;
        formTitle frmTitle;
        formInventory frmInventory;

        public formHome()
        {
            InitializeComponent();
        }
        


        private void btnJobs_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formJobs>().Count() == 0)
            {
                frmJobs = new formJobs();
                frmJobs.MdiParent = MdiParent;
                frmJobs.Dock = DockStyle.Fill;
                frmJobs.Show();
                frmJobs.BringToFront();
                frmJobs.WindowState = FormWindowState.Minimized;
                frmJobs.WindowState = FormWindowState.Maximized;
            }
            else
            {
                    formBERP.reopenTheForm(typeof(formJobs));
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formTitle>().Count() == 0)
            {
                frmTitle = new formTitle();
                // Set the Parent Form of the Child window.
                frmTitle.MdiParent = MdiParent;
                // Fill the parent form and bring it to front.
                frmTitle.Dock = DockStyle.Fill;
                // Display the new form and maximize to fill the parent MDI.
                frmTitle.Show();
                frmTitle.BringToFront();
                frmTitle.WindowState = FormWindowState.Minimized;
                frmTitle.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formBERP.reopenTheForm(typeof(formTitle));
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCustomers>().Count() == 0)
            {
                frmCustomers = new formCustomers();
                // Set the Parent Form of the Child window.
                frmCustomers.MdiParent = MdiParent;
                // Fill the parent form and bring it to front.
                frmCustomers.Dock = DockStyle.Fill;
                // Display the new form and maximize to fill the parent MDI.
                frmCustomers.Show();
                frmCustomers.BringToFront();
                frmCustomers.WindowState = FormWindowState.Minimized;
                frmCustomers.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formBERP.reopenTheForm(typeof(formCustomers));
            }
        }

        private void btnInventoryItems_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formInventory>().Count() == 0)
            {
                frmInventory = new formInventory();
                // Set the Parent Form of the Child window.
                frmInventory.MdiParent = MdiParent;
                // Fill the parent form and bring it to front.
                frmInventory.Dock = DockStyle.Fill;
                // Display the new form and maximize to fill the parent MDI.
                frmInventory.Show();
                frmInventory.BringToFront();
                frmInventory.WindowState = FormWindowState.Minimized;
                frmInventory.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formBERP.reopenTheForm(typeof(formInventory));
            }
        }
    }
}
