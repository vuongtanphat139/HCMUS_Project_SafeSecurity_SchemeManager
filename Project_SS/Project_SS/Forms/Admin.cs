using Project_SS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            UC_User uC = new UC_User();
            addControls(uC);
        }

        private void addControls(UserControl uc)
        {
            panel_Container.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel_Container.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            UC_User uc = new UC_User();
            addControls(uc);
        }

        private void btn_Role_Click(object sender, EventArgs e)
        {
            UC_Role uc = new UC_Role();
            addControls(uc);
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            F_Audit auditform = new F_Audit();
            auditform.ShowDialog();
        }
    }
}
