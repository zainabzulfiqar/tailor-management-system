using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Common;

namespace Win.UI
{
    public partial class FormCreateWorker : Form
    {
        public FormCreateWorker()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            //GET WORKER DATA FROM FORM
            worker.FirstName = txtFirstName.Text;
            worker.LastName = txtLastName.Text;
            worker.Address = txtAddress.Text;
            worker.ContactNumber = txtContact.Text;
            worker.JoiningDate = dateJoining.Text;
            worker.Salary = Convert.ToInt32(txtSalary.Text);
            
            //ADD NEW WORKER TO WORKERS LIST
            new TMS.BLL.WorkerBLL().CreateNewWorker(worker);

            MessageBox.Show("Worker Added Successfuly!", "Success");
            ResetFormData();
        }

        private void ResetFormData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtSalary.Text = "";
        }
    }
}
