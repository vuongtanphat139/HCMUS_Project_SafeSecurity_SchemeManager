using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAO_HotelManagement
{
    public class DataProvider
    {
        public string username = "QLCONGTY";
        public string password="DOAN";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        private DataProvider() { }

        public void setUserPass(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string getUsername() { return this.username; }
        public string getconnecStr() { return this.connectStr; }
        public string PATH = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XE)))";
        // connect string for the rest
        private string connectStr = "Data Source=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = LocalHost)(Port=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl1))); User ID=";
       
        // connect string tuyetanh for docker
        //private string connectStr = "Data Source = " + "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 15212)))(CONNECT_DATA = (SERVICE_NAME = XE)))" + ";User Id = ";
        public DataSet ExecuteQuery1(string query)
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;
            DataSet dataset = new DataSet();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataset);
                connection.Close();
            }
            return dataset;
        }
        public DataTable ExecuteProc(string query)
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
        public DataTable ExecuteProcWithStringParameter(string query, int numOfParameter, string[] parameterNames, string[] parameterValues )
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                for(int i=0; i<parameterNames.Length; i++)
                {
                    command.Parameters.Add(parameterNames[i], OracleDbType.Varchar2).Value = parameterValues[i];
                }
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
        public int ExecuteProcWithStringParameter_NonQuery(string query, int numOfParameter, string[] parameterNames, string[] parameterValues)
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;

            int res;
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameterNames.Length; i++)
                {
                    command.Parameters.Add(parameterNames[i], OracleDbType.Varchar2).Value = parameterValues[i];
                }
                //OracleDataAdapter adapter = new OracleDataAdapter(command);
                res = command.ExecuteNonQuery();
                connection.Close();
            }
            return res;
        }
        public DataTable ExecuteQuery(string query)
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

            return dataTable;
        }
        public int ExecuteNonQuery(string query)
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;
            int result = 0;
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result;
        }
        public string ExecuteScalar(string query)
        {
            connectStr = connectStr + this.username + ";Password =" + this.password;
            string result = "";
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                result = command.ExecuteScalar().ToString();
                connection.Close();
            }
            return result;
        }
        
    } 

}
