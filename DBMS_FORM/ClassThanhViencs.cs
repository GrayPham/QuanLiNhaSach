using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM
{
    class ClassThanhViencs
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - KF2J8C6; User ID = ThanhPhong; Password=12345");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        //open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        //close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
