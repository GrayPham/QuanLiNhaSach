using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM.BLL
{
    public class Login : QuanLyNhaSach
    {
        DB db = new DB();
        internal object CheckLogin(string username, string password)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.fun_checkLogin('" + username + "', '" + password + "')", db.getConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
