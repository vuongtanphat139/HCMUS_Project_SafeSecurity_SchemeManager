using DAO_HotelManagement;
using Oracle.ManagedDataAccess.Client;
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
    public partial class UC_DEAN : UserControl
    {
        string selectedID;

        public UC_DEAN()
        {
            InitializeComponent();
            setData();
            //foreach (DataGridViewColumn c in Dean_DataGrid.Columns)
            //{
            //    c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void setData()
        {
            try
            {
                string selectName = "SELECT * FROM QLCONGTY.DEAN";
                Dean_DataGrid.DataSource = DataProvider.Instance.ExecuteQuery(selectName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get data.");
            }
        }
        private void Dean_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dean_DataGrid.Columns["MADA"].Index && e.RowIndex >= 0)
            {
                selectedID = Dean_DataGrid.Rows[e.RowIndex].Cells["MADA"].Value.ToString();
                showDataDEAN(selectedID);
            }
            else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index;

                string procName = "QLCONGTY.USP_ADDPROJECT";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("NAMEPROJECT", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(name_Text.Text) ? (object)null : name_Text.Text;
                        command.Parameters.Add("START_TIME", OracleDbType.Date).Value = date_Datetime.Value;
                        command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = string.IsNullOrEmpty(room_Text.Text) ? (object)null : Int32.Parse(room_Text.Text);
                        index = command.ExecuteNonQuery();
                    }
                }
                setData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't insert");
                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                MessageBox.Show(null);

                string procName = "QLCONGTY.USP_UPDATEPROJECT";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("IDPROJECT", OracleDbType.Char).Value = string.IsNullOrEmpty(selectedID) ? (object)null : selectedID;
                        command.Parameters.Add("NAMEPROJECT", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(name_Text.Text) ? (object)null : name_Text.Text;
                        command.Parameters.Add("START_TIME", OracleDbType.Date).Value = date_Datetime.Value;
                        command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = string.IsNullOrEmpty(room_Text.Text) ? (object)null : Int32.Parse(room_Text.Text);
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
        void showDataDEAN(string selectedID)
        {
            string procName = "SELECT * FROM QLCONGTY.DEAN WHERE MADA = '" + selectedID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(procName);
            string userInfo = "";
            foreach (DataRow dr in dt.Rows)
            {
                userInfo = dr["TENDA"].ToString() + "\n" + dr["NGAYBD"].ToString() +
                           "\n" + dr["PHONG"].ToString() + "\n";
            }
            name_Text.Text = userInfo.Split('\n')[0];
            if (userInfo.Split('\n')[2] == "") date_Datetime.Value = DateTime.Today;
            else date_Datetime.Value = DateTime.Parse(userInfo.Split('\n')[1]);
            room_Text.Text = userInfo.Split('\n')[2];
        }
    }
}
