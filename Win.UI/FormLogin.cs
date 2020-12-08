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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            List<Users> users = new TMS.BLL.UserBLL().GetAllUsers();
            cbxUsername.DataSource = users;
            cbxUsername.DisplayMember = "Username";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxUsername.SelectedIndex == -1)
                MessageBox.Show("Please Select User First", "Error");
            else if(txtPassword.Text.Trim() == "")
                MessageBox.Show("Incorrect Password", "Error");
            else
            {
                Users user = (Users)cbxUsername.SelectedItem;
                if(user.Password == txtPassword.Text)
                {
                    this.Hide();
                    FormDashboard form = new FormDashboard();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Error");
                }
            }

        }
    }
}
