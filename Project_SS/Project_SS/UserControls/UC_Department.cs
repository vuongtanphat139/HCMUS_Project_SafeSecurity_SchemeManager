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

namespace Project_SS.UserControls
{
    public partial class UC_Department : UserControl
    {
        string selectedID;

        public UC_Department()
        {
            InitializeComponent();
            setData();
        }
        void setData()
        {
            try
            {
                string selectName = "SELECT * FROM QLCONGTY.PHONGBAN";
                department_DataGrid.DataSource = DataProvider.Instance.ExecuteQuery(selectName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get data.");
            }
        }

        private void department_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == department_DataGrid.Columns["MAPB"].Index && e.RowIndex >= 0)
            {
                selectedID = department_DataGrid.Rows[e.RowIndex].Cells["MAPB"].Value.ToString();
                showDataPB(selectedID);
            }
            else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index;

                string procName = "QLCONGTY.USP_ADDDEPART";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("NAMEDEPART", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(name_Text.Text) ? (object)null : name_Text.Text;
                        command.Parameters.Add("TRGPHG", OracleDbType.Char).Value = string.IsNullOrEmpty(idTP_Text.Text) ? (object)null : idTP_Text.Text;
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

        private void idPB_Label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                MessageBox.Show(null);

                string procName = "QLCONGTY.USP_UPDATEDEPART";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("IDDEPART", OracleDbType.Char).Value = string.IsNullOrEmpty(selectedID) ? (object)null : selectedID;
                        command.Parameters.Add("NAMEDEPART", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(name_Text.Text) ? (object)null : name_Text.Text;
                        command.Parameters.Add("TRGPHG", OracleDbType.Char).Value = string.IsNullOrEmpty(idTP_Text.Text) ? (object)null : idTP_Text.Text;
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
        void showDataPB(string selectedID)
        {
            string procName = "SELECT * FROM QLCONGTY.PHONGBAN WHERE MAPB = '" + selectedID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(procName);
            string userInfo = "";
            foreach (DataRow dr in dt.Rows)
            {
                userInfo = dr["TENPB"].ToString() + "\n" + dr["TRPHG"].ToString();
            }
            name_Text.Text = userInfo.Split('\n')[0];
            idTP_Text.Text = userInfo.Split('\n')[1];
        }
    }
}
