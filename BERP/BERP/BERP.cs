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
            //homeToolStripMenuItem.PerformClick();        
        }

        formHome frmHome;
        formJobs frmJobs;

                private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formHome>().Count() == 0)
            {
                frmHome = new formHome();
                // Set the Parent Form of the Child window.
                frmHome.MdiParent = this;
                // Fill the parent form and bring it to front.
                frmHome.Dock = DockStyle.Fill;
                // Display the new form and maximize to fill the parent MDI.
                frmHome.Show();
                frmHome.WindowState = FormWindowState.Minimized;
                frmHome.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmHome.Activate();
            }
            
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formJobs>().Count() == 0)
            {
                frmJobs = new formJobs();
                // Set the Parent Form of the Child window.
                frmJobs.MdiParent = this;
                // Fill the parent form and bring it to front.
                frmJobs.Dock = DockStyle.Fill;
                // Display the new form and maximize to fill the parent MDI.
                frmJobs.Show();
                frmJobs.BringToFront();
                frmJobs.WindowState = FormWindowState.Minimized;
                frmJobs.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmJobs.Activate();
            }
        }

    }
}
