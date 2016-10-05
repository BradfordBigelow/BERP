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

        public formHome()
        {
            InitializeComponent();
        }
        
        private void btnJobs_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formJobs>().Count() == 0)
            {
                frmJobs = new formJobs();
                // Set the Parent Form of the Child window.
                frmJobs.MdiParent = MdiParent;
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
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(formJobs))
                    {

                        f.Activate();
                    }
                }

            }
        }

    }
}
