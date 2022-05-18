using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM.BLL
{
    public class Login : QuanLyNhaSach
    {
        internal object CheckLogin(string username, string password)
        {
            var login = db.fun_checkLogin(username, password);
            return login;
        }
    }
}
