using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM.BLL
{
    internal class ProviderBLL: QuanLyNhaSach
    {
        private string methodDelete = "DeleteProvider";
        internal bool MethodProvider(int mncc, string namencc, string address, string email, bool ConHD)
        {

            db.Add_NhaCungCap(mncc, namencc, address, email, ConHD);
            return true;
        }
        public object GetProvider()
        {
            var pv = db.NhaCungCaps.Where(t => t.ConHD == true).Select(s => new
            {
                mncc = s.MNCC,
                namencc = s.TenNCC,
                address = s.DiaChi,
                email = s.Mail,
                ConHD = s.ConHD
            }).ToList();
            return pv;
        }

        internal void DeleteProvider(int ma)
        {
            try
            {
                //System.Data.Objects.ObjectParameter ketqua = new ObjectParameter("ketqua", typeof(char));
                db.Delete_Providers(ma, methodDelete);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete Provider");
            }

        }
    }
}
