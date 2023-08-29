using DAO_HotelManagement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS
{
    public partial class UC_Employee : UserControl
    {
        string selectedID;
        public UC_Employee()
        {
            InitializeComponent();
            setData();
            try
            {
                if (DataProvider.Instance.getUsername().IndexOf("TC") >= 0)
                {
                    for (int i = 0; i < NHANVIEN_DataGrid.Rows.Count; i++)
                    {
                        if (NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value != null && NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString().Length != 0)
                        {
                            //MessageBox.Show(i + "Luong " + NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString().Length.ToString());
                            //MessageBox.Show(decrypt(NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString()));
                            NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value = decrypt(NHANVIEN_DataGrid.Rows[i].Cells["Luong"].Value.ToString());
                        }

                        if (NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value != null && NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value.ToString().Length != 0)
                        {
                            //MessageBox.Show(i + "Phu cap " + NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value.ToString().Length.ToString());
                            //MessageBox.Show(decrypt(NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value.ToString()));

                            NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value = decrypt(NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value.ToString()); ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get data.");
                MessageBox.Show(ex.ToString());
            }

        }
        void setData()
        {
            try
            {
                string procName = "QLCONGTY.SELECT_NHANVIEN";
                NHANVIEN_DataGrid.DataSource = DataProvider.Instance.ExecuteProc(procName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get data.");
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                
                string procName = "QLCONGTY.USP_ADDEMPLOYEE";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("NAMEEMP", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(Name_Text.Text) ? (object)null : Name_Text.Text;
                        command.Parameters.Add("GENDER", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(gender_Text.Text) ? (object)null : gender_Text.Text;
                        command.Parameters.Add("BIRTHDAY", OracleDbType.Date).Value = birthday_Datetime.Value;
                        command.Parameters.Add("ADDRESS", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(address_Text.Text) ? (object)null : address_Text.Text;
                        command.Parameters.Add("PHONE", OracleDbType.Char).Value = string.IsNullOrEmpty(phone_Text.Text) ? (object)null : phone_Text.Text;
                        command.Parameters.Add("SALARY", OracleDbType.Char).Value = string.IsNullOrEmpty(salary_Text.Text) ? (object)null : encrypt(salary_Text.Text);
                        command.Parameters.Add("ALLOWANCE", OracleDbType.Char).Value = string.IsNullOrEmpty(allowance_Text.Text) ? (object)null : encrypt(allowance_Text.Text);
                        command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(role_Text.Text) ? (object)null : role_Text.Text;
                        command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = string.IsNullOrEmpty(manager_Text.Text) ? (object)null : manager_Text.Text;
                        command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = string.IsNullOrEmpty(department_Text.Text) ? (object)null : Int32.Parse(department_Text.Text);
                        index = command.ExecuteNonQuery();
                    }
                }
                setData();            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't insert");
                MessageBox.Show(ex.ToString());

            }
        }

        private void role_Text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                MessageBox.Show(null);

                string procName = "QLCONGTY.USP_UPDATEEMPLOYEE";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("IDEMP", OracleDbType.Char).Value = string.IsNullOrEmpty(selectedID) ? (object)null : selectedID;
                        command.Parameters.Add("NAMEEMP", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(Name_Text.Text) ? (object)null : Name_Text.Text;
                        command.Parameters.Add("GENDER", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(gender_Text.Text) ? (object)null : gender_Text.Text;
                        command.Parameters.Add("BIRTHDAY", OracleDbType.Date).Value = birthday_Datetime.Value;
                        command.Parameters.Add("ADDRESS", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(address_Text.Text) ? (object)null : address_Text.Text;
                        command.Parameters.Add("PHONE", OracleDbType.Char).Value = string.IsNullOrEmpty(phone_Text.Text) ? (object)null : phone_Text.Text;
                        command.Parameters.Add("SALARY", OracleDbType.Char).Value = string.IsNullOrEmpty(salary_Text.Text) ? (object)null : encrypt(salary_Text.Text);
                        command.Parameters.Add("ALLOWANCE", OracleDbType.Char).Value = string.IsNullOrEmpty(allowance_Text.Text) ? (object)null : encrypt(allowance_Text.Text);
                        command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(role_Text.Text) ? (object)null : role_Text.Text;
                        command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = string.IsNullOrEmpty(manager_Text.Text) ? (object)null : manager_Text.Text;
                        command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = string.IsNullOrEmpty(department_Text.Text) ? (object)null : int.Parse(department_Text.Text);

                        index = command.ExecuteNonQuery();
                    }
                }
                setData();
                MessageBox.Show(index.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update");
                // Handle or display the exception message
                MessageBox.Show(ex.ToString());
            }
        }
        void showDataEmp(string selectedID)
        {
            string procName = "SELECT * FROM QLCONGTY.NHANVIEN WHERE MANV = '" + selectedID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(procName);
            string userInfo = "";
            foreach (DataRow dr in dt.Rows)
            {
                userInfo = dr["TENNV"].ToString() + "\n" + dr["PHAI"].ToString() + "\n" +
                           dr["NGAYSINH"].ToString() + "\n" + dr["DIACHI"].ToString() + "\n" +
                           dr["SODT"].ToString() + "\n" + dr["LUONG"].ToString() + "\n" +
                           dr["PHUCAP"].ToString() + "\n" + dr["VAITRO"].ToString() + "\n" +
                           dr["MANQL"].ToString() + "\n" + dr["PHG"].ToString() + "\n"; 
            }
            Name_Text.Text = userInfo.Split('\n')[0];
            gender_Text.Text = userInfo.Split('\n')[1];
            if (userInfo.Split('\n')[2] == "") birthday_Datetime.Value = DateTime.Today;
            else birthday_Datetime.Value = DateTime.Parse(userInfo.Split('\n')[2]);
            address_Text.Text = userInfo.Split('\n')[3];
            phone_Text.Text = userInfo.Split('\n')[4];
            salary_Text.Text = (userInfo.Split('\n')[5]);
            allowance_Text.Text = (userInfo.Split('\n')[6]);
            role_Text.Text = userInfo.Split('\n')[7];
            manager_Text.Text = userInfo.Split('\n')[8];
            department_Text.Text = userInfo.Split('\n')[9];
        }
        private void NHANVIEN_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == NHANVIEN_DataGrid.Columns["MANV"].Index && e.RowIndex >= 0)
            {
                selectedID = NHANVIEN_DataGrid.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                showDataEmp(selectedID);
            }
            else return;
        }

        string hash = "f0xle@rn";
        string encrypt(string value)
        {
            string newValue = "";
            byte[] data = UTF8Encoding.UTF8.GetBytes(value);
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = MD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tf = tripDes.CreateEncryptor();
                    byte[] rs = tf.TransformFinalBlock(data, 0, data.Length);
                    newValue = Convert.ToBase64String(rs, 0, rs.Length);
                }
            }
            MessageBox.Show(newValue);
            MessageBox.Show(newValue.Length.ToString());

            return newValue;
        }
        string decrypt(string value)
        {
            string newValue = "";
            byte[] data = Convert.FromBase64String(value);
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = MD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tf = tripDes.CreateDecryptor();
                    byte[] rs = tf.TransformFinalBlock(data, 0, data.Length);
                    newValue = UTF8Encoding.UTF8.GetString(rs);
                }
            }
            return newValue;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (salary_Text.Text != "") salary_Text.Text = encrypt(salary_Text.Text);
            if (allowance_Text.Text != "") allowance_Text.Text = encrypt(allowance_Text.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (salary_Text.Text != "") salary_Text.Text = decrypt(salary_Text.Text);
            if (allowance_Text.Text != "") allowance_Text.Text = decrypt(allowance_Text.Text);
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            Encrypt_Form encryptF = new Encrypt_Form();
            encryptF.ShowDialog();
        }
    }
}
