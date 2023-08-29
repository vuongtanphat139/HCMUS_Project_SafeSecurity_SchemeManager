using Project_SS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS
{
    public partial class ChooseRole : Form
    {
        public ChooseRole()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(username);
            Admin f_admin = new Admin();
            f_admin.Show();
            this.Hide();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Dashboard f_dashboard = new Dashboard();
            f_dashboard.Show();
            this.Hide();
        }
    }
}
