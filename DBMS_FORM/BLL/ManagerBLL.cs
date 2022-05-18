using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM.BLL
{
    internal class ManagerBLL : QuanLyNhaSach
    {
        internal void AddNV(int ma, string hoTen, string sdt, string dc, int sachBan, int luong, int vang, int maNQL)
        {
            try
            {
                //System.Data.Objects.ObjectParameter ketqua = new ObjectParameter("ketqua", typeof(char));
                db.sp_AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, maNQL);
                //string myCheck = ketqua.Value.ToString();
                //MessageBox.Show(myCheck, "Add Staff");
                db.SaveChanges();
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

        internal object GetManager()
        {
            var manager = db.fun_DanhSachQuanLy();
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
