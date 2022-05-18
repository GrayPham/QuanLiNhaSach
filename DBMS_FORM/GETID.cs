using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM
{
    class GETID
    {
        public static int GlobalUserID { get; private set; }
        public static void SetGlobalUserid(int userID)
        {
            GlobalUserID = userID;
        }
    }
}
