using DAO_HotelManagement;
using System;
using System.Collections;
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
    public partial class F_Audit : Form
    {
        public F_Audit()
        {
            InitializeComponent();
            showData();
        }
        void showData()
        {

            try
            {
                string procName = "SELECT SESSION_ID, TIMESTAMP, DB_USER, OBJECT_SCHEMA, OBJECT_NAME, SQL_TEXT,STATEMENT_TYPE,EXTENDED_TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_SCHEMA = 'QLCONGTY'";
                audit_DataGrid.DataSource = DataProvider.Instance.ExecuteQuery(procName);

                //AUDIT
                //AUDIT 1ST
                string countquery1st = "SELECT COUNT(*) AS AMOUNT FROM DBA_AUDIT_POLICIES WHERE POLICY_NAME = 'CHANGETIME'";
                DataTable countQuery1st = DataProvider.Instance.ExecuteQuery(countquery1st);
                int count_1st = 0;
                foreach (DataRow row in countQuery1st.Rows)
                {
                    string audit_count1st = row["AMOUNT"].ToString();
                    count_1st = int.Parse(audit_count1st);
                }
                if(count_1st != 0)
                {
                    changetime_button.Text = "DISABLE AUDIT";
                }
                else changetime_button.Text = "ENABLE AUDIT";

                //AUDIT 2ND
                string countquery2nd = "SELECT COUNT(*) AS AMOUNT FROM DBA_AUDIT_POLICIES WHERE POLICY_NAME = 'CHANGE_LP'";
                DataTable countQuery2nd = DataProvider.Instance.ExecuteQuery(countquery2nd);
                int count_2nd = 0;
                foreach (DataRow row in countQuery2nd.Rows)
                {
                    string audit_count2nd = row["AMOUNT"].ToString();
                    count_2nd = int.Parse(audit_count2nd);
                }
                if (count_2nd != 0)
                {
                    change_LP_Button.Text = "DISABLE AUDIT";
                }
                else change_LP_Button.Text = "ENABLE AUDIT";

                //AUDIT 3RD
                string countquery3rd = "SELECT COUNT(*) AS AMOUNT FROM DBA_AUDIT_POLICIES WHERE POLICY_NAME = 'CHANGENHANVIEN'";
                DataTable countQuery3rd = DataProvider.Instance.ExecuteQuery(countquery3rd);
                int count_3rd = 0;
                foreach (DataRow row in countQuery3rd.Rows)
                {
                    string audit_count3rd = row["AMOUNT"].ToString();
                    count_3rd = int.Parse(audit_count3rd);
                }
                if (count_3rd != 0)
                {
                    changenhanvien_Button.Text = "DISABLE AUDIT";
                }
                else changenhanvien_Button.Text = "ENABLE AUDIT";

                //VPD
                //VPD1ST
                string countvpd1sd = "SELECT COUNT(*) AS AMOUNT \r\nFROM DBA_POLICIES\r\nWHERE OBJECT_OWNER = 'QLCONGTY'\r\nAND POLICY_NAME = 'UID_NHANVIEN'";
                DataTable count1st = DataProvider.Instance.ExecuteQuery(countvpd1sd);
                int countVPD1st = 0;
                foreach (DataRow row in count1st.Rows)
                {
                    string vpd_1st = row["AMOUNT"].ToString();
                    countVPD1st = int.Parse(vpd_1st);
                }
                if (countVPD1st != 0)
                {
                    uid_nhanvien_button.Text = "DISABLE VPD";
                }
                else uid_nhanvien_button.Text = "ENABLE VPD";

                //VPD2ND
                string countvpd2nd = "SELECT COUNT(*) AS AMOUNT \r\nFROM DBA_POLICIES\r\nWHERE OBJECT_OWNER = 'QLCONGTY'\r\nAND POLICY_NAME = 'QLPHANCONG'";
                DataTable count2nd = DataProvider.Instance.ExecuteQuery(countvpd2nd);
                int countVPD2nd = 0;
                foreach (DataRow row in count2nd.Rows)
                {
                    string vpd_2nd = row["AMOUNT"].ToString();
                    countVPD2nd = int.Parse(vpd_2nd);
                }
                if (countVPD2nd != 0)
                {
                    qlphancong_Button.Text = "DISABLE VPD";
                }
                else qlphancong_Button.Text = "ENABLE VPD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get data.");
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(changetime_button.Text == "DISABLE AUDIT")
            {
                try
                {
                    string disable = "BEGIN\r\n  DBMS_FGA.drop_policy(\r\n    OBJECT_SCHEMA => 'QLCONGTY',\r\n    OBJECT_NAME => 'PHANCONG',\r\n    POLICY_NAME => 'CHANGETIME'\r\n    );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(disable);
                    changetime_button.Text = "ENABLE AUDIT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't disable");
                    MessageBox.Show(ex.ToString());

                }
            }
            else if (changetime_button.Text == "ENABLE AUDIT")
            {
                try
                {
                    string enable = "BEGIN \r\n DBMS_FGA.ADD_POLICY(\r\n    OBJECT_SCHEMA => 'QLCONGTY',\r\n    OBJECT_NAME => 'PHANCONG',\r\n    POLICY_NAME => 'CHANGETIME',\r\n    AUDIT_COLUMN => 'THOIGIAN',\r\n    ENABLE => TRUE,\r\n    STATEMENT_TYPES => 'UPDATE',\r\n    AUDIT_COLUMN_OPTS => DBMS_FGA.ALL_COLUMNS\r\n    );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(enable);
                    changetime_button.Text = "DISABLE AUDIT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't enable");
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (change_LP_Button.Text == "DISABLE AUDIT")
            {
                try
                {
                    string disable = "BEGIN\r\n  DBMS_FGA.drop_policy(\r\n    OBJECT_SCHEMA => 'QLCONGTY',\r\n    OBJECT_NAME => 'NHANVIEN',\r\n    POLICY_NAME => 'CHANGE_LP'\r\n    );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(disable);
                    change_LP_Button.Text = "ENABLE AUDIT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't disable");
                    MessageBox.Show(ex.ToString());

                }
            }
            else if (change_LP_Button.Text == "ENABLE AUDIT")
            {
                try
                {
                    string enable = "BEGIN \r\n DBMS_FGA.ADD_POLICY(\r\n    OBJECT_SCHEMA => 'QLCONGTY',\r\n    OBJECT_NAME => 'NHANVIEN',\r\n    POLICY_NAME => 'CHANGE_LP',\r\n    AUDIT_COLUMN => 'LUONG, PHUCAP',\r\n    AUDIT_CONDITION => 'MANV != ''' || SYS_CONTEXT('USERENV', 'SESSION_USER') || '''',\r\n    ENABLE => TRUE,\r\n    STATEMENT_TYPES => 'SELECT',\r\n    AUDIT_COLUMN_OPTS => DBMS_FGA.ALL_COLUMNS\r\n    );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(enable);
                    change_LP_Button.Text = "DISABLE AUDIT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't enable");
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (changenhanvien_Button.Text == "DISABLE AUDIT")
            {
                try
                {
                    string disable = "BEGIN\r\n  DBMS_FGA.drop_policy(\r\n    OBJECT_SCHEMA => 'QLCONGTY',\r\n    OBJECT_NAME => 'NHANVIEN',\r\n    POLICY_NAME => 'CHANGENHANVIEN'\r\n    );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(disable);
                    changenhanvien_Button.Text = "ENABLE AUDIT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't disable");
                    MessageBox.Show(ex.ToString());

                }
            }
            else if (changenhanvien_Button.Text == "ENABLE AUDIT")
            {
                try
                {
                    string enable = "BEGIN \r\n DBMS_FGA.ADD_POLICY(\r\n    OBJECT_SCHEMA => 'QLCONGTY',\r\n    OBJECT_NAME => 'NHANVIEN',\r\n    POLICY_NAME => 'CHANGENHANVIEN',\r\n    AUDIT_COLUMN => 'LUONG,PHUCAP',\r\n    AUDIT_CONDITION => SYS_CONTEXT('USERENV', 'SESSION_USER') || ' NOT LIKE (TC%)',\r\n    ENABLE => TRUE,\r\n    STATEMENT_TYPES => 'UPDATE',\r\n    AUDIT_COLUMN_OPTS => DBMS_FGA.ALL_COLUMNS\r\n    );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(enable);
                    changenhanvien_Button.Text = "DISABLE AUDIT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't enable");
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void uid_nhanvien_button_Click(object sender, EventArgs e)
        {
            if (uid_nhanvien_button.Text == "DISABLE VPD")
            {
                try
                {
                    string disable = "BEGIN\r\n  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',\r\n                        object_name       => 'NHANVIEN',\r\n                        policy_name       => 'UID_NHANVIEN');\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(disable);
                    uid_nhanvien_button.Text = "ENABLE VPD";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't disable");
                    MessageBox.Show(ex.ToString());

                }
            }
            else if (uid_nhanvien_button.Text == "ENABLE VPD")
            {
                try
                {
                    string enable = "BEGIN\r\n    DBMS_RLS.ADD_POLICY(\r\n        object_schema   => 'QLCONGTY',\r\n        object_name     => 'NHANVIEN',\r\n        policy_name     => 'UID_NHANVIEN',\r\n        function_schema => 'QLCONGTY',\r\n        policy_function => 'CHANGENHANVIEN',\r\n        statement_types => 'INSERT,UPDATE',\r\n        update_check    => true\r\n        );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(enable);
                    uid_nhanvien_button.Text = "DISABLE VPD";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't enable");
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void qlphancong_Button_Click(object sender, EventArgs e)
        {
            if (qlphancong_Button.Text == "DISABLE VPD")
            {
                try
                {
                    string disable = "BEGIN\r\n  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',\r\n                        object_name       => 'PHANCONG',\r\n                        policy_name       => 'QLPHANCONG');\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(disable);
                    qlphancong_Button.Text = "ENABLE VPD";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't disable");
                    MessageBox.Show(ex.ToString());

                }
            }
            else if (qlphancong_Button.Text == "ENABLE VPD")
            {
                try
                {
                    string enable = "BEGIN\r\n    DBMS_RLS.ADD_POLICY(\r\n        object_schema   => 'QLCONGTY',\r\n        object_name     => 'PHANCONG',\r\n        policy_name     => 'QLPHANCONG',\r\n        function_schema => 'QLCONGTY',\r\n        policy_function => 'MANAGEPHANCONG',\r\n        statement_types => 'INSERT,UPDATE,DELETE,SELECT',\r\n        update_check    => true\r\n        );\r\nEND;";
                    int index = DataProvider.Instance.ExecuteNonQuery(enable);
                    qlphancong_Button.Text = "DISABLE VPD";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't enable");
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
