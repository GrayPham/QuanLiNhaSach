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

        internal object GetManager()
        {
            var manager = db.fun_DanhSachQuanLy();
            return manager;
        }
    }
}
