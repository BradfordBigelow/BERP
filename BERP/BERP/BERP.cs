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

        formHome frmHome;
        formJobs frmJobs;

        private void HideForms()
        {
            int frmCount = this.MdiChildren.Count<Form>();
            if (frmCount > 0)
            {
                for (int i = 0; i < frmCount; i++)
                {
                    this.MdiChildren[i].Hide();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForms();
            // check to see if the Home form has already been initiated. If it hasn't, initiate it.
            if (frmHome == null)
            {
                formHome frmHome = new formHome();
                // Set the Parent Form of the Child window.
                frmHome.MdiParent = this;
                // Fill the parent form and bring it to front.
                frmHome.Dock = DockStyle.Fill;
                frmHome.BringToFront();
                // Display the new form.
                frmHome.Show();
            }
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForms();
            // check to see if the Home form has already been initiated. If it hasn't, initiate it.
            if (frmJobs == null)
            {
                formJobs frmJobs = new formJobs();
                // Set the Parent Form of the Child window.
                frmJobs.MdiParent = this;
                // Fill the parent form and bring it to front.
                frmJobs.Dock = DockStyle.Fill;
                frmJobs.BringToFront();
                // Display the new form.
                frmJobs.Show();
            }
        }
    }
}
