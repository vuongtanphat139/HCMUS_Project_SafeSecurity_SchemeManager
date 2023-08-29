using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO_HotelManagement;
using Oracle.ManagedDataAccess.Client;
using Project_SS.UserControls;


namespace Project_SS
{
    public partial class Login : Form
    {
        ConnectionString str = new ConnectionString();
        string username;
        string password;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Pass.Checked == true)
            {
                tb_Pass.UseSystemPasswordChar = false;
            }
            else
                tb_Pass.UseSystemPasswordChar = true;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            // 2 dòng này lấy username pass nè
            username = tb_User.Text;
            password = tb_Pass.Text;
            //username = "TC008";
            //password = "DOAN";
            //MessageBox.Show(username, password);
            try
            {
                if (
                                  username.IndexOf("NS") >= 0 ||
                                  username.IndexOf("TP") >= 0 ||
                                  username.IndexOf("TA") >= 0 ||
                                  username.IndexOf("TC") >= 0 ||
                                  username.IndexOf("NV") >= 0 ||
                                  username.IndexOf("GD") >= 0)
                {
                    // set username pass vào dataprovider nè. cái instance có thể xem như là một bản sao của dataprovider, nên là nó sẽ giữ giá trị và sử dụng được cho mọi class
                    // nên không cần tạo new nè
                    DataProvider.Instance.setUserPass(username, password);
                    //test lấy tên thôi, nên là cmt lại 
                    //MessageBox.Show(DataProvider.Instance.getUsername());

                    //gọi form mới
                    Dashboard Dashboard = new Dashboard();
                    Dashboard.Show();
              
                    this.Hide();
                }
                

                else if (username == "QLCONGTY") { 
                    DataProvider.Instance.setUserPass(username, password);

                    ChooseRole chooseRole = new ChooseRole();
                    chooseRole.Show();

                    this.Hide();

                }
                else
                {
                    //something
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid name or password.");
                //MessageBox.Show(ex.ToString());
            }

        }

        private bool isFormValid()
        {
            if (tb_User.Text.Trim() == string.Empty || tb_Pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username and Password both are required.", "Enter Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
