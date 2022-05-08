using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM.BLL
{
    public class NhanVien : QuanLyNhaSach
    {
        internal object capDuoi(int maNQL)
        {
            
            var nv = db.fuNhanvienOfQl(maNQL);
            return nv;
        }

        internal object hoaDon(int maNV)
        {
            var hd = db.fun_HoaDonOfNhanVien(maNV);
            return hd;
        }
    }
}
