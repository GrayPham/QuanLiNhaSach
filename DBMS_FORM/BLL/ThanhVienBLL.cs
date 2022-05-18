using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM.BLL
{
    internal class ThanhVienBLL : QuanLyNhaSach
    {
        internal object SearchTV(string searchTV)
        {
            var search = db.fun_SearchThanhVien(searchTV);
            return search;
        }

        private string methodDelete = "DeleteTV";
        private const string ExpireTV = "ExpireTV";
        internal bool MethodTV( int idTv, string name, string phone, string address, string email,int useTv, int level)
        {

                db.Add_ThanhVien( idTv, name, phone, address, email, useTv, level);
                return true;
        }
        public object GetTV()
        {
            var tv = db.ThanhViens.Where(t => t.ConSD == true).Select(s=> new
            {
                MaTV = s.MTV,
                Name = s.HoVaTenTV,
                Address = s.Diachi,
                Phone = s.SoDT,
                Email = s.Mail,
                Level = s.MDThanThiet
            }).ToList();
            return tv;
        }

        internal void editThanhvien(int idTv,int macu, string name, string phone, string address, string email, int usetv, int level)
        {
            try
            {
                //System.Data.Objects.ObjectParameter ketqua = new ObjectParameter("ketqua", typeof(char));
                db.thanhvienUpdate( idTv, macu, name, phone, address, email, level);
                //string myCheck = ketqua.Value.ToString();
                //MessageBox.Show(myCheck, "Add Staff");
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Edit Staff");
            }
        }

        internal void DeleteTV(int ma)
        {
            try
            {
                //System.Data.Objects.ObjectParameter ketqua = new ObjectParameter("ketqua", typeof(char));
                db.Tv_Delete(ma, methodDelete);
                db.SaveChanges(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Edit Staff");
            }
            
        }

        internal void Expiretv(int ma)
        {
            db.Tv_Delete(ma, ExpireTV);
        }
    }
}
