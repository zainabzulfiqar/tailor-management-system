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
    public partial class FormViewWorkers : Form
    {
        public FormViewWorkers()
        {
            InitializeComponent();
        }

        private void FormViewWorkers_Load(object sender, EventArgs e)
        {
            List<Worker> list = new TMS.BLL.WorkerBLL().GetAllWorkers();
            tbWorkers.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
