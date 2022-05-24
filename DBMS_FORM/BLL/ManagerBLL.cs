using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM.BLL
{
    internal class ManagerBLL : QuanLyNhaSach
    {

        internal void AddNV(int ma, string hoTen, string sdt, string dc, int sachBan, int luong, string username, string pass,int typeid, int vang, int maNQL)
        {
            try
            {
                //System.Data.Objects.ObjectParameter ketqua = new ObjectParameter("ketqua", typeof(char));
                //db.sp_AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, username, pass, typeid, maNQL,0);
                //string myCheck = ketqua.Value.ToString();
                //MessageBox.Show(myCheck, "Add Staff");
                //db.SaveChanges();
                DB addnv = new DB();
                addnv.openconnection();
                SqlCommand comand = new SqlCommand();
                comand.CommandText = "sp_AddNV";
                comand.CommandType = CommandType.StoredProcedure;
                comand.Connection = addnv.getConnection;
                try
                {
                    comand.Parameters.Add("@manv", SqlDbType.Int).Value = ma;
                    comand.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoTen;
                    comand.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
                    comand.Parameters.Add("@dc", SqlDbType.VarChar).Value = dc;
                    comand.Parameters.Add("@sosachban", SqlDbType.Int).Value = sachBan;
                    comand.Parameters.Add("@luongnv", SqlDbType.Int).Value = luong;
                    comand.Parameters.Add("@ngayvang", SqlDbType.Int).Value = vang;
                    comand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                    comand.Parameters.Add("@password", SqlDbType.NVarChar).Value = pass;
                    comand.Parameters.Add("@TypeId", SqlDbType.Int).Value = typeid;
                    comand.Parameters.Add("@manql", SqlDbType.Int).Value = maNQL;
                    comand.Parameters.Add("@danghi", SqlDbType.Int).Value = 0;

                    comand.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show("ERROR" + E.Message, "Add NV");

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Add Staff");
            }
        }

        internal object GetTurnOver(int type)
        {
            
            if(type == 1)
            {
               var turnOver = db.TurnoverByDay();
                return turnOver;
            }
            else if(type == 2)
            {
                DateTime temp = DateTime.Now;
                var turnOver = db.TurnoverByMonth(temp);
                return turnOver;
            }   
            else if (type == 3)
            {
                var turnOver = db.TurnoverByYear();
                return turnOver;
            }
            return null;
        }

        internal List<UserType> GetTypeUser()
        {
            List<UserType> typeUser = db.UserTypes.ToList<UserType>();
            
            return typeUser;
        }

        internal object GetManager()
        {
            //var manager = db.fun_DanhSachQuanLy();
            var manager = db.NVs.Where(u => u.MNQL == null).ToList();
            return manager;
        }

        internal void EditNV(int ma,int manvOld,  string hoTen, string sdt, string dc, int luong, int vang, int maNQL)
        {
            try
            {
                //System.Data.Objects.ObjectParameter ketqua = new ObjectParameter("ketqua", typeof(char));
                db.sp_EditNV(ma, manvOld, hoTen, sdt, dc, luong, vang);
                //string myCheck = ketqua.Value.ToString();
                //MessageBox.Show(myCheck, "Add Staff");
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Add Staff");
            }
        }
        private string fileNV = "FireUser";
        private string deleteNV = "DeleteUser";
        internal void RemoveNV(int ma)
        {
            db.SP_DeleteUSER_MANAGEMENT(ma,fileNV);
        }
        internal void DeleteNV(int ma)
        {
            db.SP_DeleteUSER_MANAGEMENT(ma, deleteNV);
        }
    }
}
