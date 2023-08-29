using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_SS.UserControls
{
    public partial class UC_Job : UserControl
    {
        public int idx_updateChoosed = 0;
        int countChangeName = -1;
        int countChangeSchema = -1;

        string currEmpId = "";
        string currSchemaID = "";
        string currTime = "";

        string newEmpid;
        string newSchemaid;
        string newTime;
        string username = DataProvider.Instance.getUsername();

        int isAdding = 0;

        int currRowIdx = 0;
        DataGridViewButtonColumn doWork = new DataGridViewButtonColumn();
        DataGridViewButtonColumn doWork1 = new DataGridViewButtonColumn();
        public UC_Job()
        {
            InitializeComponent();
            getAssignment();
            dtgvDSPHANCONG.RowHeadersWidth = 50;
           cbxName.SelectedIndex = -1;
            cbxSchema.SelectedIndex = -1;
            loadEmpListCombobox();
            loadSchemaListCombobox();
            panel1.Hide();
            txbName.Text = "";
            txbSchema.Text = "";
            dtgvDSPHANCONG.Columns.Insert(dtgvDSPHANCONG.Columns.Count, doWork);
            dtgvDSPHANCONG.Columns.Insert(dtgvDSPHANCONG.Columns.Count, doWork1);




        }
        private void getAssignment()
        {
            try
            {
                DataTable dataTable = new DataTable();
                string query = "select pc.MAda as \"SchemaID\", da.TENDA as \"Schema\", nv.manv as EmpID, nv.tennv as Emp, pc.thoigian as Time from QLCONGTY.phancong pc join QLCONGTY.dean da on pc.mada = da.mada join QLCONGTY.nhanvien nv on pc.manv=nv.manv";
                //string query = "SELECT * FROM QLCONGTY.NHANVIEN";
                dtgvDSPHANCONG.DataSource = DataProvider.Instance.ExecuteQuery(query);
                for (int i = 0; i < dtgvDSPHANCONG.Rows.Count; i++)
                {
                    dtgvDSPHANCONG.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                /* for (int i = 0; i < dtgvDSPHANCONG.Columns.Count - 1; i++)
                 {
                     dtgvDSPHANCONG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                 }
                 dtgvDSPHANCONG.Columns[dtgvDSPHANCONG.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
     */
                dtgvDSPHANCONG.Columns[0].Width = 70;
                dtgvDSPHANCONG.Columns[2].Width = 70;
                dtgvDSPHANCONG.Columns[1].Width = 150;
                dtgvDSPHANCONG.Columns[4].Width = 100;


                doWork.HeaderText = "Delete";
                doWork.Name = "Delete";
                doWork.Text = "x";
                doWork.DefaultCellStyle.BackColor = Color.Red;
                doWork.Width = 60;
                doWork.UseColumnTextForButtonValue = true;


                doWork1.HeaderText = "Update";
                doWork1.Name = "Update";
                doWork1.Text = "+";
                doWork1.Width = 60;
                doWork1.DefaultCellStyle.BackColor = Color.Green;
                doWork1.UseColumnTextForButtonValue = true;

                dtgvDSPHANCONG.ReadOnly = true;
                for (int i = 0; i < dtgvDSPHANCONG.Columns.Count; i++)
                {
                    int colw = dtgvDSPHANCONG.Columns[i].Width;
                    dtgvDSPHANCONG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dtgvDSPHANCONG.Columns[i].Width = colw;
                    //dtgvDSPHANCONG.Columns[i].ReadOnly = true;

                }
                for (int i = 0; i < dtgvDSPHANCONG.Rows.Count; i++)
                {
                    dtgvDSPHANCONG.Rows[i].HeaderCell.Value = (i + i).ToString();
                }



                //MessageBox.Show("hihi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Have some error, please try again!");

            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAdding == 1)
            {
                //txbCurrEmp.Text = cbxSchema.SelectedItem.ToString();
                txbCurrSchema.Text = cbxSchema.Text;
                //txbCurrTime.Text = "";
                return;
            }
            countChangeSchema++;
            if ((cbxSchema.SelectedIndex >= 0 && countChangeSchema>0))
            {
                dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["SchemaID"].Value = cbxSchema.SelectedValue;
                dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["Schema"].Value = cbxSchema.Text.Substring(8);
            }
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadEmpListCombobox()
        {
            string nameemp = txbName.Text;
            string query = "select manv, tennv , concat(manv, concat(' - ', tennv)) as combineName from QLCONGTY.nhanvien nv join QLCONGTY.phongban pb on nv.PHG = pb.mapb where pb.trphg = '"+username+"' and upper(tennv) like concat('%', concat(upper('" + nameemp + "'), '%'))";
            cbxName.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxName.SelectedIndex = -1;
            cbxSchema.SelectedIndex = -1;
            cbxName.ValueMember = "manv";
            cbxName.DisplayMember = "combineName";

        }
        private void loadSchemaListCombobox()
        {

            string schemaId = txbSchema.Text;
            string query = "select mada, tenda , concat(mada, concat('- ', tenda)) as combineName from QLCONGTY.dean where upper(tenda) like concat('%', concat(upper('" + schemaId + "'), '%'))";
            cbxSchema.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbxSchema.ValueMember = "mada";
            cbxSchema.DisplayMember = "combineName";
        }
        private void dtgvDSPHANCONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string schemaid = dtgvDSPHANCONG.Rows[e.RowIndex].Cells["SchemaID"].Value.ToString();
            string empid = dtgvDSPHANCONG.Rows[e.RowIndex].Cells["EmpID"].Value.ToString();
            currTime = dtgvDSPHANCONG.Rows[e.RowIndex].Cells["Time"].Value.ToString();
            int count = dtgvDSPHANCONG.ColumnCount;
            int count1 = e.ColumnIndex;
            newEmpid = empid;
            newSchemaid = schemaid;
            newTime = currTime;
            if (e.RowIndex == currRowIdx)
            {
                dtgvDSPHANCONG.ReadOnly = false;
            }
            else
            {
                dtgvDSPHANCONG.ReadOnly = true;

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex ==0)
            {

                if ( (MessageBox.Show("Are you sure to delete this assignment?", "The Title",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    string query = "delete from QLCONGTY.PHANCONG where manv= '" + empid + "' and mada = '" + schemaid+ "'";
                    int res = DataProvider.Instance.ExecuteNonQuery(query);
                    if (res > 0)
                    {
                        MessageBox.Show("Delete successfully!");
                        getAssignment();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Delete fail, please try again!");
                        return;
                    }
                }
             else { return; }
                
            }
            
 
            //update
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 1)//&& senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==""
            {

                currRowIdx = e.RowIndex;
             
                panel1.Show();
                //dtgvDSPHANCONG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "x";
               


                //string v = dtgvDSPHANCONG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string schemaId = txbSchema.Text;
                countChangeSchema = 0;
                countChangeName = 0;

                //string query = "select manv, tennv from nhanvien where tennv like '%' + '"+nameemp+"'+'%'";
                idx_updateChoosed = e.RowIndex;

                currEmpId = empid;
                currSchemaID = schemaid;
                txbCurrEmp.Text= currEmpId + " - " + dtgvDSPHANCONG.Rows[e.RowIndex].Cells["Emp"].Value.ToString();
                txbCurrSchema.Text = currSchemaID + " - " + dtgvDSPHANCONG.Rows[e.RowIndex].Cells["Schema"].Value.ToString();
                txbCurrTime.Text= currTime.ToString();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAdding == 1)
            {
                //txbCurrEmp.Text = cbxSchema.SelectedItem.ToString();
                txbCurrEmp.Text =cbxName.Text;
                //txbCurrTime.Text = "";
                return;
            }
            countChangeName++;
            if (cbxName.SelectedIndex >= 0 && countChangeName>0)
            {
                dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["EmpID"].Value = cbxName.SelectedValue;
                dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["Emp"].Value = cbxName.Text.Substring(8);
            }
        
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            loadEmpListCombobox(); 

        }

        private void txbSchema_TextChanged(object sender, EventArgs e)
        {
            loadSchemaListCombobox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(isAdding == 1)
            {
                panel1.Hide();
                isAdding = 0;
                return;
            }
            dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["EmpID"].Value = currEmpId;
            dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["Emp"].Value = txbCurrEmp.Text.Substring(8);

            dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["SchemaID"].Value = currSchemaID;
            dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["Schema"].Value = txbCurrSchema.Text.Substring(8);

            dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["Time"].Value = currTime;
            panel1.Hide();
          

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try {
                int res;
                if (isAdding == 1)
                {
                    newEmpid = txbCurrEmp.Text.Substring(0, 5);
                    newSchemaid = txbCurrSchema.Text.Substring(0, 5);
                    for (int i = 0; i < dtgvDSPHANCONG.RowCount - 1; i++)
                    {
                        if (dtgvDSPHANCONG.Rows[i].Cells["EmpID"].Value.ToString() == newEmpid && dtgvDSPHANCONG.Rows[i].Cells["SchemaID"].Value.ToString().Substring(0, 5) == newSchemaid && i!=idx_updateChoosed)
                        {
                            int num = i + 1;
                            MessageBox.Show("Already this assignment in row " + num + ", please update this row instead.");
                            return;
                        }
                    }
                    newTime = txbCurrTime.Text;
                    string query1 = "insert into QLCONGTY.phancong(manv, mada, thoigian)" +
    "values('" + newEmpid + "', '" + newSchemaid + "', to_date('" + newTime + "', 'mm:dd:yyyy hh:mi:ss AM'))";

                    res = DataProvider.Instance.ExecuteNonQuery(query1);
                    if (res > 0)
                    {

                        MessageBox.Show("Add successfully!");
                        getAssignment();
                    }
                    else
                    {
                        MessageBox.Show("Add fail. Please try again.");
                        isAdding = 0;
                    }

                    return;
                }
                newEmpid = dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["EmpID"].Value.ToString();
                newSchemaid = dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["SchemaID"].Value.ToString().Substring(0, 5);
                //newTime = dtgvDSPHANCONG.Rows[idx_updateChoosed].Cells["Time"].Value.ToString();
                newTime = txbCurrTime.Text;

                for (int i = 0; i < dtgvDSPHANCONG.RowCount - 1; i++)
                {
                    if (dtgvDSPHANCONG.Rows[i].Cells["EmpID"].Value.ToString() == newEmpid && dtgvDSPHANCONG.Rows[i].Cells["SchemaID"].Value.ToString().Substring(0, 5) == newSchemaid && i != idx_updateChoosed)
                    {
                        int num = i + 1;
                        MessageBox.Show("Already this assignment in row " + num + ", please update this row instead.");
                        return;
                    }
                }
                string query = "update QLCONGTY.phancong " +
                    "set manv = '" + newEmpid + "', mada = '" + newSchemaid + "',  thoigian = to_date('" + newTime + "', 'mm/dd/yyyy HH:MI:SS AM')" +
                    " where manv = '" + currEmpId + "' and mada = '" + currSchemaID + "'";

                res = DataProvider.Instance.ExecuteNonQuery(query);
                if (res != 0)
                {
                    MessageBox.Show("Update successfully!");
                    panel1.Hide();
                    getAssignment();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                    panel1.Hide();
                    getAssignment();
                }
            }
            catch
            {
                MessageBox.Show("Cannot Update.");
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAdding = 1;
            panel1.Show();
            
            txbCurrEmp.Text = "";
            txbCurrSchema.Text = "";
            txbCurrTime.Text = "";
        }

        private void txbCurrTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_PhanCong_Load(object sender, EventArgs e)
        {

        }
    }
}
