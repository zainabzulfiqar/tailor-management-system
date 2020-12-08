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
    public partial class FormNewProduct : Form
    {
        public FormNewProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }


        private void ResetFormData()
        {
            txtCustomerAddress.Text = "";
            txtCustomerContact.Text = "";
            txtCustomerName.Text = "";
            txtHeight.Text = "";
            txtPrice.Text = "";
            txtWidth.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.ContactNumber = txtCustomerContact.Text;
            o.CustomerAddress = txtCustomerAddress.Text;
            o.CustomerName = txtCustomerName.Text;
            o.OrderDate = dateOrder.Text;
            o.Price = Convert.ToInt32(txtPrice.Text);
            o.Type = cbxType.Text;
            o.Width = Convert.ToDouble(txtWidth.Text);
            o.Height = Convert.ToDouble(txtHeight.Text);

            new TMS.BLL.OrderBLL().AddNewOrder(o);

            MessageBox.Show("Order Added Successfuly!", "Success");
            ResetFormData();
        }

        private void FormNewProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
