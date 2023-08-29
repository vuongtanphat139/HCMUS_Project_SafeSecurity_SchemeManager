using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SS
{
    internal class ConnectionString
    {
        string PATH = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 15212)))(CONNECT_DATA = (SERVICE_NAME = XE)))";
        string conStr = "";
        string user = "";
        string pass = "";

        public void setConStr(string username, string password)
        {
            /*
            if (username == "QLCONGTY" )
                conStr = "Data Source = " + PATH + "; DBA Privilege = SYSDBA; User Id = " + username + "; Password = " + password;
            else
            */
            this.conStr = "Data Source = " + PATH + "; User Id = " + username + "; Password = " + password;
            this.user = username;
            this.pass = password;
        }

        public string getString()
        {
            return conStr;
        }

        public string getUser()
        {
            return user;
        }
        public string getPass()
        {
            return pass;
        }
    }
}
