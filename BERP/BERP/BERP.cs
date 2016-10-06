﻿using System;
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
        formCustomers frmCustomers;
        formTitle frmTitle;

        public static void reopenTheForm(Type t)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == t)
                    f.Activate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formHome>().Count() == 0)
            {
                frmHome = new formHome();
                frmHome.MdiParent = this;
                frmHome.Dock = DockStyle.Fill;
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
                frmJobs.MdiParent = this;
                frmJobs.Dock = DockStyle.Fill;
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
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCustomers>().Count() == 0)
            {
                frmCustomers = new formCustomers();
                frmCustomers.MdiParent = this;
                frmCustomers.Dock = DockStyle.Fill;
                frmCustomers.Show();
                frmCustomers.BringToFront();
                frmCustomers.WindowState = FormWindowState.Minimized;
                frmCustomers.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmCustomers.Activate();
            }
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formTitle>().Count() == 0)
            {
                frmTitle = new formTitle();
                frmTitle.MdiParent = this;
                frmTitle.Dock = DockStyle.Fill;
                frmTitle.Show();
                frmTitle.BringToFront();
                frmTitle.WindowState = FormWindowState.Minimized;
                frmTitle.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmTitle.Activate();
            }
        }
    }
}
