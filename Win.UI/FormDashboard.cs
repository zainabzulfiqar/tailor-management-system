using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.UI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnCreateWorker_Click(object sender, EventArgs e)
        {
            new FormCreateWorker().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormViewWorkers().ShowDialog();
        }

        private void createWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCreateWorker().ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void btnViewWorkers_Click(object sender, EventArgs e)
        {
            new FormViewWorkers().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            new FormNewProduct().ShowDialog();
        }

        private void btnAssignedOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnPendingOrders_Click(object sender, EventArgs e)
        {
            new FormPendingOrders().ShowDialog();
        }

        private void createProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNewProduct().ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPendingOrders().ShowDialog();
        }
    }
}
