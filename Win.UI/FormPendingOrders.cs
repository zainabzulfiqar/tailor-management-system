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
    public partial class FormPendingOrders : Form
    {
        public FormPendingOrders()
        {
            InitializeComponent();
        }

        private void FormPendingOrders_Load(object sender, EventArgs e)
        {
            List<Order> list= new TMS.BLL.OrderBLL().GetPendingOrders();
            tableOrders.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
