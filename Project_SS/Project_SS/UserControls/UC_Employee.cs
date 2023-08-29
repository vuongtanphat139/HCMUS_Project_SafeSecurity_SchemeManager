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
        }
        void setData()
        {
            try
            {
                string procName = "QLCONGTY.SELECT_NHANVIEN";
                NHANVIEN_DataGrid.DataSource = DataProvider.Instance.ExecuteProc(procName);
                //get QL trực tiếp ID
                string queryID = "SELECT MANV FROM QLCONGTY.NHANVIEN WHERE VAITRO = N'QL trực tiếp'";
                DataTable dtID = DataProvider.Instance.ExecuteQuery(queryID);
                List<string> idList = new List<string>();
                idList.Add("<None>");
                foreach (DataRow row in dtID.Rows)
                {
                    string idQL = row["MANV"].ToString();
                    idList.Add(idQL);
                }
                manager_ComboBox.DataSource = idList;

                //get PHONGBAN
                string queryPHG = "SELECT MAPB FROM QLCONGTY.PHONGBAN";
                DataTable dtPHG = DataProvider.Instance.ExecuteQuery(queryPHG);

                List<string> idPHG = new List<string>();
                idPHG.Add("<None>");
                foreach (DataRow row in dtPHG.Rows)
                {
                    string idPHGBAN = row["MAPB"].ToString();
                    idPHG.Add(idPHGBAN);
                }
                room_ComboBox.DataSource = idPHG;

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
                else
                {
                    for (int i = 0; i < NHANVIEN_DataGrid.Rows.Count; i++)
                    {
                        if (NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value != null && NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString().Length != 0 && NHANVIEN_DataGrid.Rows[i].Cells["MANV"].Value.ToString() == DataProvider.Instance.getUsername())
                        {
                            //MessageBox.Show(i + "Luong " + NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString().Length.ToString());
                            //MessageBox.Show(decrypt(NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString()));
                            NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value = decrypt(NHANVIEN_DataGrid.Rows[i].Cells["LUONG"].Value.ToString());
                        }

                        if (NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value != null && NHANVIEN_DataGrid.Rows[i].Cells["PHUCAP"].Value.ToString().Length != 0 && NHANVIEN_DataGrid.Rows[i].Cells["MANV"].Value.ToString() == DataProvider.Instance.getUsername())
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
                MessageBox.Show("Can't get some data.");
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
                        command.Parameters.Add("GENDER", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(gender_ComboBox.Text) ? (object)null : gender_ComboBox.Text;
                        command.Parameters.Add("BIRTHDAY", OracleDbType.Date).Value = birthday_Datetime.Value;
                        command.Parameters.Add("ADDRESS", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(address_Text.Text) ? (object)null : address_Text.Text;
                        command.Parameters.Add("PHONE", OracleDbType.Char).Value = string.IsNullOrEmpty(phone_Text.Text) ? (object)null : phone_Text.Text;
                        command.Parameters.Add("SALARY", OracleDbType.Char).Value = string.IsNullOrEmpty(salary_Text.Text) ? (object)null : (salary_Text.Text);
                        command.Parameters.Add("ALLOWANCE", OracleDbType.Char).Value = string.IsNullOrEmpty(allowance_Text.Text) ? (object)null : (allowance_Text.Text);
                        //command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(role_ComboBox.Text) ? (object)null : role_ComboBox.Text;
                        if (role_ComboBox.Text == "QLTT") command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = "QL trực tiếp";
                        else command.Parameters.Add("USERROLE", OracleDbType.Char).Value = string.IsNullOrEmpty(role_ComboBox.Text) ? (object)null : role_ComboBox.Text;
                        if (manager_ComboBox.Text == "<None>") command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = null;
                        else command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = manager_ComboBox.Text;

                        if (room_ComboBox.Text == "<None>") command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = null;
                        else command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = int.Parse(room_ComboBox.Text);

                        index = command.ExecuteNonQuery();
                    }
                }
                setData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't insert");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void role_Text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.getUsername().IndexOf("NS") >= 0)
            {
                try
                {
                    int index;
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
                            command.Parameters.Add("GENDER", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(gender_ComboBox.Text) ? (object)null : gender_ComboBox.Text;
                            command.Parameters.Add("BIRTHDAY", OracleDbType.Date).Value = birthday_Datetime.Value;
                            command.Parameters.Add("ADDRESS", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(address_Text.Text) ? (object)null : address_Text.Text;
                            command.Parameters.Add("PHONE", OracleDbType.Char).Value = string.IsNullOrEmpty(phone_Text.Text) ? (object)null : phone_Text.Text;
                            command.Parameters.Add("SALARY", OracleDbType.Char).Value = string.IsNullOrEmpty(salary_Text.Text) ? (object)null : encrypt(salary_Text.Text);
                            command.Parameters.Add("ALLOWANCE", OracleDbType.Char).Value = string.IsNullOrEmpty(allowance_Text.Text) ? (object)null : encrypt(allowance_Text.Text);
                            //command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(role_ComboBox.Text) ? (object)null : role_ComboBox.Text;
                            if (role_ComboBox.Text == "QLTT") command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = "Quản lí trực tiếp";
                            else command.Parameters.Add("USERROLE", OracleDbType.Char).Value = string.IsNullOrEmpty(role_ComboBox.Text) ? (object)null : role_ComboBox.Text;

                            if (manager_ComboBox.Text == "<None>") command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = null;
                            else command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = manager_ComboBox.Text;

                            if (room_ComboBox.Text == "<None>") command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = null;
                            else command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = int.Parse(room_ComboBox.Text);
                            //command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = string.IsNullOrEmpty(manager_ComboBox.Text) ? (object)null : manager_ComboBox.Text;
                            //command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = string.IsNullOrEmpty(room_ComboBox.Text) ? (object)null : int.Parse(room_ComboBox.Text);

                            index = command.ExecuteNonQuery();
                        }
                    }
                    setData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't update");
                    // Handle or display the exception message
                }
            }
            else if (DataProvider.Instance.getUsername().IndexOf("TC") >= 0)
            {
                string salary = string.IsNullOrEmpty(salary_Text.Text) ? null : encrypt(salary_Text.Text);
                string allowance = string.IsNullOrEmpty(allowance_Text.Text) ? null : encrypt(allowance_Text.Text);
                string procName = "UPDATE QLCONGTY.NHANVIEN \n" +
                                  "SET LUONG = N'" + salary + "', PHUCAP = N'" + allowance + "' \n" +
                                  "WHERE MANV = N'" + selectedID + "'";
                int index = DataProvider.Instance.ExecuteNonQuery(procName);
                if (index > 0) MessageBox.Show("Update complete!");
                else MessageBox.Show("Can't update!");
                setData();
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
            gender_ComboBox.Text = userInfo.Split('\n')[1];
            if (userInfo.Split('\n')[2] == "") birthday_Datetime.Value = DateTime.Today;
            else birthday_Datetime.Value = DateTime.Parse(userInfo.Split('\n')[2]);
            address_Text.Text = userInfo.Split('\n')[3];
            phone_Text.Text = userInfo.Split('\n')[4];

            if(DataProvider.Instance.getUsername().IndexOf("TC") >= 0) salary_Text.Text = decrypt(userInfo.Split('\n')[5]);
            else if(selectedID == DataProvider.Instance.getUsername()) salary_Text.Text = decrypt(userInfo.Split('\n')[5]);
            else salary_Text.Text = (userInfo.Split('\n')[5]);

            if (DataProvider.Instance.getUsername().IndexOf("TC") >= 0) allowance_Text.Text = decrypt(userInfo.Split('\n')[6]);
            else if (selectedID == DataProvider.Instance.getUsername()) allowance_Text.Text = decrypt(userInfo.Split('\n')[6]);
            else allowance_Text.Text = (userInfo.Split('\n')[6]);
            //else allowance_Text.Text = (userInfo.Split('\n')[6]);

            role_ComboBox.Text = userInfo.Split('\n')[7];
            manager_ComboBox.Text = userInfo.Split('\n')[8];
            room_ComboBox.Text = userInfo.Split('\n')[9];
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

        //string hash = "f0xle@rn";
        string encrypt(string value)
        {
            string query = "SELECT KEY FROM QLCONGTY.KEY_ENCRYPT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string hash = "";
            foreach (DataRow dr in dt.Rows)
            {
                hash = dr["KEY"].ToString();
                break;
            }
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
            return newValue;
        }
        string decrypt(string value)
        {
            string query = "SELECT KEY FROM QLCONGTY.KEY_ENCRYPT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string hash = "";
            foreach (DataRow dr in dt.Rows)
            {
                hash = dr["KEY"].ToString();
                break;
            }
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
        private void Demo_Click(object sender, EventArgs e)
        {
            Encrypt_Form encryptF = new Encrypt_Form();
            encryptF.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                string procName = "QLCONGTY.USP_UPDATEYOURSELF";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("IDEMP", OracleDbType.Char).Value = string.IsNullOrEmpty(selectedID) ? (object)null : selectedID;
                        command.Parameters.Add("BIRTHDAY", OracleDbType.Date).Value = birthday_Datetime.Value;
                        command.Parameters.Add("ADDRESS", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(address_Text.Text) ? (object)null : address_Text.Text;
                        command.Parameters.Add("PHONE", OracleDbType.Char).Value = string.IsNullOrEmpty(phone_Text.Text) ? (object)null : phone_Text.Text;

                        index = command.ExecuteNonQuery();
                    }
                }
                setData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update");
                // Handle or display the exception message
            }
        }
    }
}
