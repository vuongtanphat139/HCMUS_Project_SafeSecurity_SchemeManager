using Bunifu.UI.WinForms.Helpers.Transitions;
using DAO_HotelManagement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS.UserControls
{
    public partial class UC_Role : UserControl
    {

        DataTable dt_role=new DataTable();
        DataTable dt_user;
        DataTable dt_table = new DataTable();
        // contain list of column in a table, of select and update zone
        DataTable dt_cols = new DataTable();
        DataTable dt_cols2 = new DataTable();
        DataTable dt_schema = new DataTable();
        DataTable dt_userOfRole=    new DataTable();
        DataTable dt_SIDpriv = new DataTable();
        DataTable dt_colOfSelect=new DataTable();
        DataTable dt_colOfUpdate=new DataTable();
        

        bool[] currGrantable = new bool[4] {false, false, false, false};
        bool[] currIsPriv = new bool[4] { false, false, false, false };
        string[] currSelectCol;
        string[] currUpdateCol;
        string[] privs = new string[4] { "SELECT", "INSERT", "DELETE", "UPDATE" };

        //string[] cbxGrantedPrivList = new string[4] {"cbxSelect", "cbx"}
        string selectedRole="NHANVIEN";
        string selectedTable="NHANVIEN";
        string selectedSchema="QLCONGTY";
        bool isSelectChange = false;
        bool isDeleteChange = false;
        bool isInsertChange = false;
        bool isUpdateChange = false;

        string[] newColsOfSelect;
        string[] newColsOfUpdate;

       
        public UC_Role()
        {
            InitializeComponent();

            dtgvRoleList.RowHeadersWidth = 50;
            dtgvTableList.RowHeadersWidth = 50;
            //dtgvRoleList.ReadOnly = false;
            Load_Roles_List();
            Load_schemas_List();
            //Load_Tables_List(selectedSchema);
            dt_cols.Columns.Add("COLUMN_NAME", typeof(string));
            dt_userOfRole.Columns.Add("GRANTEE");

            dt_SIDpriv.Columns.Add("PRIVILEGE", typeof(string));
            dt_SIDpriv.Columns.Add("GRANTABLE", typeof(string));
            dt_SIDpriv.Columns.Add("TYPE", typeof(string));

            dt_colOfSelect.Columns.Add("COLUMN_NAME");
            dt_colOfUpdate.Columns.Add("COLUMN_NAME");

            // disable all checkbox
            /*  cbxSelect.Enabled = false;
              cbxUpdate.Enabled = false;
              cbxInsert.Enabled = false;
              cbxDelete.Enabled = false;*/

           // dtgvUsersOfRole.Columns.Insert(dtgvUsersOfRole.Columns.Count, doWork);

        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dtgvRoleList.Rows)
            {
                row.HeaderCell.Value = (1).ToString();
            }
        }
        private void Load_Roles_List()
        {
            dt_role.Columns.Add("granted_role", typeof(string));
            dt_role = DataProvider.Instance.ExecuteProc("LIST_ROLE");
          
            dtgvRoleList.DataSource = dt_role;

            //setRowNumber(dtgvRoleList);



        }

        private void Load_Tables_List(string schema)
        {


            string[] tableTille, tableValue;
            tableTille = new string[1] { "schemaname" };
            tableValue = new string[1] { selectedSchema };
            DataTable dt_table = new DataTable();
            dt_table.Columns.Add("TABLE_NAME", typeof(string));
            dt_table = DataProvider.Instance.ExecuteProcWithStringParameter("qlcongty.LIST_TABLE_wSchemaName", 1, tableTille, tableValue);
            dtgvTableList.DataSource = dt_table;


        }
        private void Load_Columns_List(string tablename)
        {

        
            string[] tableTille, tableValue;
            tableTille = new string[2] { "tablename", "schemaname" };
            tableValue = new string[2] { tablename, selectedSchema };
  
            
            dt_cols = DataProvider.Instance.ExecuteProcWithStringParameter("ColsOfTable", 1, tableTille, tableValue);
            dt_cols2 = DataProvider.Instance.ExecuteProcWithStringParameter("ColsOfTable", 1, tableTille, tableValue);
            clbColumnSelect.DataSource = dt_cols;
            clbColumnSelect.DisplayMember = "COLUMN_NAME";
            clbColumnSelect.ValueMember = "COLUMN_NAME";
            clbColumnUpdate.DataSource = dt_cols2;
            clbColumnUpdate.DisplayMember = "COLUMN_NAME";
            clbColumnUpdate.ValueMember = "COLUMN_NAME";
        }
        private void Load_schemas_List()
        {


            dt_schema.Columns.Add("OWNER", typeof(string));
            dt_schema = DataProvider.Instance.ExecuteProc("list_schema_having_table");
            cbxSchemaList.DataSource = dt_schema;
            cbxSchemaList.DisplayMember = "OWNER";
            cbxSchemaList.ValueMember = "OWNER";
        
        }
        private void Load_SIDPriv_List()
        {
            // set default value
            currGrantable = new bool[4] { false, false, false, false };
            currIsPriv = new bool[4] { false, false, false, false };
            // load data
            string[] tableTille, tableValue;
            //RoUname varchar, tablename varchar, schemaname varchar
            tableTille = new string[3] { "RoRname", "tablename", "schemaname" };
            tableValue = new string[3] { selectedRole, selectedTable, selectedSchema };
            dt_SIDpriv = DataProvider.Instance.ExecuteProcWithStringParameter("usp_SID_PRIV_OF_ROU", 3, tableTille, tableValue);
            // SIDU
            // set result on relevant global var
            for (int i = 0; i < dt_SIDpriv.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string str = dt_SIDpriv.Rows[i].ItemArray[0].ToString();
                    string priv = privs[j];
                    if (dt_SIDpriv.Rows[i].ItemArray[0].Equals(privs[j]))
                    {
                        
                        currIsPriv[j] = true;
                        if (dt_SIDpriv.Rows[i].ItemArray[1].Equals("YES"))
                        {
                            currGrantable[j] = true;
                        }
                    }
                }
              
            }
            // render on checkbox

            // SID
           /* cbxSelect.Enabled = true;
            cbxUpdate.Enabled = true;
            cbxInsert.Enabled = true;
            cbxDelete.Enabled = true;*/
            for (int i = 0; i < currIsPriv.Length - 1; i++)
            {
            
                if (i == 0)
                {
                cbxSelect.Checked = currIsPriv[i];
                cbxGrantable3.Checked = currGrantable[i];

                    }
                if (i == 1)
                {
                    cbxInsert.Checked = currIsPriv[i];
                    cbxGrantable1.Checked = currGrantable[i];
                }
                if (i == 2)
                {
                    cbxDelete.Checked = currIsPriv[i];
                    cbxGrantable2.Checked = currGrantable[i];
                }

            }


        }
        private void Load_SelectCols_List()
        {

            cbxSelect.Checked = false;

            string[] tableTille, tableValue;
            //(tablename in varchar, UoRname in varchar, schemaname in varchar)
            tableTille = new string[3] { "RoRname", "tablename", "schemaname" };
            tableValue = new string[3] { selectedRole, selectedTable, selectedSchema };
            dt_colOfSelect = DataProvider.Instance.ExecuteProcWithStringParameter("colsOfView", 3, tableTille, tableValue);
            if (dt_colOfSelect.Rows.Count > 0)
            {
                currIsPriv[0] = true;
                cbxSelect.Checked = true;
            }
            else
            {
                currIsPriv[0] = false;
                cbxSelect.Checked = false;
            }
            for (int j = 0; j < dt_cols.Rows.Count; j++)
            {
                
                    clbColumnSelect.SetItemChecked(j, false);
    
            }
            for (int i = 0; i < dt_colOfSelect.Rows.Count; i++)
            {
                for(int j = 0; j < dt_cols.Rows.Count; j++)
                {
                    if (dt_colOfSelect.Rows[i][0].Equals(clbColumnSelect.GetItemText(clbColumnSelect.Items[j])))
                    {
                        clbColumnSelect.SetItemChecked(j, true);
                    }
                }
            }

            clbColumnSelect.SelectionMode = SelectionMode.None;
        }
        private void Load_UpdatableCols_List()
        {
            cbxUpdate.Checked = false;
            string[] tableTille, tableValue;
           
            //(tablename in varchar, UoRname in varchar, schemaname in varchar)
            tableTille = new string[3] { "RoRname", "tablename", "schemaname" };
            tableValue = new string[3] { selectedRole, selectedTable, selectedSchema };
            dt_colOfUpdate = DataProvider.Instance.ExecuteProcWithStringParameter("colsOfUpdate", 3, tableTille, tableValue);
            if(dt_colOfUpdate.Rows.Count > 0)
            {
                currIsPriv[3] = true;
                cbxUpdate.Checked = true;
            }
            else
            {
                currIsPriv[3] = false;
                cbxUpdate.Checked = false;
            }
            // set all checked value to false
            for (int j = 0; j < dt_cols.Rows.Count; j++)
            {

                clbColumnUpdate.SetItemChecked(j, false);

            }
            for (int i = 0; i < dt_colOfUpdate.Rows.Count; i++)
            {
                for (int j = 0; j < dt_cols2.Rows.Count; j++)
                {
                    //clbColumnUpdate.SetItemChecked(j, false);
                    if (dt_colOfUpdate.Rows[i][0].Equals(clbColumnUpdate.GetItemText(clbColumnUpdate.Items[j])))
                    {
                        clbColumnUpdate.SetItemChecked(j, true);
                        
                        break;
                    }
               
                }
            }
            clbColumnUpdate.SelectionMode = SelectionMode.None;


        }

        private void dtgvRoleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRole= dtgvRoleList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbSelectedRoleLeft.Text= selectedRole;
          
           
            string[] tableTille, tableValue;
            tableTille = new string[1] { "rolename" };
            tableValue = new string[1] { selectedRole };
            DataTable dt_user = new DataTable();

            dt_user = DataProvider.Instance.ExecuteProcWithStringParameter("list_user_of_role", 1, tableTille, tableValue);
            dtgvUsersOfRole.DataSource = dt_user;

            // txbSelectedRoleRight.Text = selectedRole;

        }

        private void dtgvTableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cbxSelect.Enabled = true;
            cbxUpdate.Enabled = true;
            cbxInsert.Enabled = true;
            cbxDelete.Enabled = true;
            selectedTable = dtgvTableList.Rows[e.RowIndex].Cells[0].Value.ToString();
            Load_Columns_List(dtgvTableList.Rows[e.RowIndex].Cells[0].Value.ToString());
            Load_SIDPriv_List();
            Load_SelectCols_List();
            Load_UpdatableCols_List();
            isDeleteChange = false;
            isInsertChange = false;
            isUpdateChange = false;
            isSelectChange = false;
            //disable of checkbox
            cbxSelect.Enabled = false;
            cbxUpdate.Enabled = false;
            cbxInsert.Enabled = false;
            cbxDelete.Enabled = false;

        }

        private void clbColumnSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelectChange = true;
        }

        private void clbColumnUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            isUpdateChange=true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        void checkAllItemChecklistbox(CheckedListBox clb, DataTable dt, bool value)
        {
            for (int j = 0; j < dt.Rows.Count; j++)
            {

                clb.SetItemChecked(j, value);

            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isInsertChange = !isInsertChange;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            isDeleteChange = !isDeleteChange;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            isSelectChange = !isSelectChange;
            if (cbxSelect.Checked == false)
            {
                for (int j = 0; j < dt_cols2.Rows.Count; j++)
                {

                    clbColumnSelect.SetItemChecked(j, false);

                }
            }
            else
            {
                checkAllItemChecklistbox(clbColumnSelect, dt_cols, true);
            }
        }

     
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            isUpdateChange = !isUpdateChange;
            
            if (cbxUpdate.Checked== false) { 
                for (int j = 0; j < dt_cols2.Rows.Count; j++)
                {

                    clbColumnUpdate.SetItemChecked(j, false);

                }
            }
            else
            {
                checkAllItemChecklistbox(clbColumnUpdate, dt_cols2, true);
            }
        }

        private void btnEditPriv_Click(object sender, EventArgs e)
        {
            //enable of checkbox
            cbxSelect.Enabled = true;
            cbxUpdate.Enabled = true;
            cbxInsert.Enabled = true;
            cbxDelete.Enabled = true;
            clbColumnSelect.SelectionMode = SelectionMode.One;
            clbColumnUpdate.SelectionMode = SelectionMode.One;
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbxSchemaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSchema = cbxSchemaList.Text;
            Load_Tables_List(selectedSchema);

        }

        private void btnUpdatePriv_Click(object sender, EventArgs e)
        {
            int res1 = 1, res2 = 1, res3 = 1, res4 = 1;
            string[] paraTitles, paraValues;
            if (isInsertChange)
            {
                //  exec GRANTPRI4ROLE('NHANVIEN', 'NHANVIEN','qlcongty', 'SELECT', 'manv, tennv');
                if (cbxInsert.Checked)
                {
                    string colums;

                    paraTitles = new string[5] { "UORNAME", "TABLENAME", "SCHEMANAME", "PRIV", "LISTCOLUMN" };
                    paraValues = new string[5] { selectedRole, selectedTable, selectedSchema, "insert", "" };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("GRANTPRI4ROLE", 5, paraTitles, paraValues);
                    if (res1 ==-1)
                    {
                        MessageBox.Show("Grant Insert successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Grant Insert failed.");
                    }
                  
                }else
                {
                    paraTitles = new string[4] { "UORNAME", "TABLENAME", "SCHEMA", "PRIV" };
                    paraValues = new string[4] { selectedRole, selectedTable, selectedSchema, "insert" };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("ROVOKEPRIVFROMROLE", 4, paraTitles, paraValues);
                    if (res1==-1)
                    {
                        MessageBox.Show("Revoke insert successfully");
                    }
                    else
                    {
                        MessageBox.Show("Revoke insert failed.");
                    }
                }
                isInsertChange = false;
            }
            if (isDeleteChange)
            {
                //  exec GRANTPRI4ROLE('NHANVIEN', 'NHANVIEN','qlcongty', 'SELECT', 'manv, tennv');
                if (cbxDelete.Checked)
                {
                    string colums;

                    paraTitles = new string[5] { "UORNAME", "TABLENAME", "SCHEMANAME", "PRIV", "LISTCOLUMN" };
                    paraValues = new string[5] { selectedRole, selectedTable, selectedSchema, "Delete", "" };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("GRANTPRI4ROLE", 5, paraTitles, paraValues);
                    if (res1 == -1)
                    {
                        MessageBox.Show("Grant Delete successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Grant Delete failed.");
                    }

                }
                else
                {
                    paraTitles = new string[4] { "UORNAME", "TABLENAME", "SCHEMA", "PRIV" };
                    paraValues = new string[4] { selectedRole, selectedTable, selectedSchema, "Delete" };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("ROVOKEPRIVFROMROLE", 4, paraTitles, paraValues);
                    if (res1 == -1)
                    {
                        MessageBox.Show("Revoke Delete successfully");
                    }
                    else
                    {
                        MessageBox.Show("Revoke Delete failed.");
                    }
                }
                isDeleteChange = false;
            }
            if (isUpdateChange)
            {
                //  exec GRANTPRI4ROLE('NHANVIEN', 'NHANVIEN','qlcongty', 'SELECT', 'manv, tennv');
                if (cbxUpdate.Checked)
                {
                    string columns="";
                    // clbColumnSelect.GetItemText(clbColumnSelect.Items[j])
                    for (int i = 0; i < clbColumnUpdate.CheckedItems.Count; i++)
                    {
                        columns = columns + clbColumnUpdate.GetItemText(clbColumnUpdate.Items[i]) + ",";
                    }
                    columns = columns.Substring(0, columns.Length - 1);
                    paraTitles = new string[5] { "UORNAME", "TABLENAME", "SCHEMANAME", "PRIV", "LISTCOLUMN" };
                    paraValues = new string[5] { selectedRole, selectedTable, selectedSchema, "Update", columns };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("GRANTPRI4ROLE", 5, paraTitles, paraValues);
                    if (res1 == -1)
                    {
                        MessageBox.Show("Grant Update successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Grant Update failed.");
                    }

                }
                else
                {
                    paraTitles = new string[4] { "UORNAME", "TABLENAME", "SCHEMA", "PRIV" };
                    paraValues = new string[4] { selectedRole, selectedTable, selectedSchema, "Update" };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("ROVOKEPRIVFROMROLE", 4, paraTitles, paraValues);
                    if (res1 == -1)
                    {
                        MessageBox.Show("Revoke Update successfully");
                    }
                    else
                    {
                        MessageBox.Show("Revoke Update failed.");
                    }
                }
                isUpdateChange = false;
            }
            if (isSelectChange)
            {
                //  exec GRANTPRI4ROLE('NHANVIEN', 'NHANVIEN','qlcongty', 'SELECT', 'manv, tennv');
                if (cbxSelect.Checked)
                {
                    string columns = "";
                    // clbColumnSelect.GetItemText(clbColumnSelect.Items[j])
                    for (int i = 0; i < clbColumnSelect.CheckedItems.Count; i++)
                    {
                        columns = columns + clbColumnSelect.GetItemText(clbColumnSelect.Items[i]) + ",";
                    }
                    columns = columns.Substring(0, columns.Length - 1);
                    paraTitles = new string[5] { "UORNAME", "TABLENAME", "SCHEMANAME", "PRIV", "LISTCOLUMN" };
                    paraValues = new string[5] { selectedRole, selectedTable, selectedSchema, "Select", columns };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("GRANTPRI4ROLE", 5, paraTitles, paraValues);
                    if (res1 == -1)
                    {
                        MessageBox.Show("Grant Select successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Grant Select failed.");
                    }

                }
                else
                {
                    paraTitles = new string[4] { "UORNAME", "TABLENAME", "SCHEMA", "PRIV" };
                    paraValues = new string[4] { selectedRole, selectedTable, selectedSchema, "Select" };
                    res1 = DataProvider.Instance.ExecuteProcWithStringParameter_NonQuery("ROVOKEPRIVFROMROLE", 4, paraTitles, paraValues);
                    if (res1 == -1)
                    {
                        MessageBox.Show("Revoke Select successfully");
                    }
                    else
                    {
                        MessageBox.Show("Revoke Select failed.");
                    }
                }
                isSelectChange = false;
            }

            // if (isDeleteChange)


            //GRANTPRI4ROLE
            //UORNAME IN VARCHAR2, 
            //    TABLENAME IN VARCHAR2,
            //PRIV IN VARCHAR2,
            // LISTCOLUMN IN SYS.ODCIVARCHAR2LIST
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            // set back current value SID
            for (int i = 0; i < currIsPriv.Length - 1; i++)
            {

                if (i == 0)
                {
                    cbxSelect.Checked = currIsPriv[i];
                    cbxGrantable3.Checked = currGrantable[i];

                }
                if (i == 1)
                {
                    cbxInsert.Checked = currIsPriv[i];
                    cbxGrantable1.Checked = currGrantable[i];
                }
                if (i == 2)
                {
                    cbxDelete.Checked = currIsPriv[i];
                    cbxGrantable2.Checked = currGrantable[i];
                }

            }
            // set back current value of select col
            if (dt_colOfSelect.Rows.Count > 0)
            {
                currIsPriv[0] = true;
                cbxSelect.Checked = true;
            }
            else
            {
                currIsPriv[0] = false;
                cbxSelect.Checked = false;
            }
            for (int j = 0; j < dt_cols.Rows.Count; j++)
            {

                clbColumnSelect.SetItemChecked(j, false);

            }
            for (int i = 0; i < dt_colOfSelect.Rows.Count; i++)
            {
                for (int j = 0; j < dt_cols.Rows.Count; j++)
                {
                    if (dt_colOfSelect.Rows[i][0].Equals(clbColumnSelect.GetItemText(clbColumnSelect.Items[j])))
                    {
                        clbColumnSelect.SetItemChecked(j, true);
                    }
                }
            }
            // set back current value of update col
            if (dt_colOfUpdate.Rows.Count > 0)
            {
                currIsPriv[3] = true;
                cbxUpdate.Checked = true;
            }
            else
            {
                currIsPriv[3] = false;
                cbxUpdate.Checked = false;
            }
            // set all checked value to false
            for (int j = 0; j < dt_cols.Rows.Count; j++)
            {

                clbColumnUpdate.SetItemChecked(j, false);

            }
            for (int i = 0; i < dt_colOfUpdate.Rows.Count; i++)
            {
                for (int j = 0; j < dt_cols2.Rows.Count; j++)
                {
                    //clbColumnUpdate.SetItemChecked(j, false);
                    if (dt_colOfUpdate.Rows[i][0].Equals(clbColumnUpdate.GetItemText(clbColumnUpdate.Items[j])))
                    {
                        clbColumnUpdate.SetItemChecked(j, true);

                        break;
                    }

                }
            }
            //disable of checkbox
            cbxSelect.Enabled = false;
            cbxUpdate.Enabled = false;
            cbxInsert.Enabled = false;
            cbxDelete.Enabled = false;
            clbColumnSelect.SelectionMode = SelectionMode.None;
            clbColumnUpdate.SelectionMode = SelectionMode.None;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                string procName = "QLCONGTY.CREATE_ROLE";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("ROLENAME", OracleDbType.Varchar2).Value = name_Text.Text;
                        index = command.ExecuteNonQuery();
                    }
                }
                dtgvRoleList.AutoGenerateColumns = false;
                dt_role.Columns.Remove("GRANTED_ROLE");
                //dtgvRoleList.Columns.Remove("USERNAME");
                //dtgvRoleList.Columns.Clear();
                Load_Roles_List();
                MessageBox.Show(index.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't add");
                // Handle or display the exception message
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                string procName = "QLCONGTY.DROP_ROLE";
                string connectionString = DataProvider.Instance.getconnecStr();
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(procName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("ROLENAME", OracleDbType.Varchar2).Value = name_Text.Text;
                        index = command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(index.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't drop");
                // Handle or display the exception message
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
