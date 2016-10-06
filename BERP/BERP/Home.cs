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
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(formJobs))
                    {

                        f.Activate();
                    }
                }
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
                foreach (Form f in Application.OpenForms) {if (f.GetType() == typeof(formCustomers)) {f.Activate();}}
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
                {
                    foreach (Form f in Application.OpenForms) { if (f.GetType() == typeof(formTitle)) { f.Activate(); } }
                }

            }
        }
    }
}
