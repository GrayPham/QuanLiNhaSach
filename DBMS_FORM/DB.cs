using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM
{
    class DB
    {
        //// Tạo kết nối
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF2J8C6;Initial Catalog=DOAN_QUANLYNHASACH_DBMS;User ID=ThanhPhong;Password=12345");


        public SqlConnection getConnection
        {
            get
            {
                return con;
            }

        }
        //hàm kết nối database
        public void openconnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        // hàm ngắt kết nối database
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }



        }
    }
}

