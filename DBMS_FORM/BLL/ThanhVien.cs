using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_FORM.Model;

namespace DBMS_FORM.BLL
{
    public class ThanhVien : QuanLyNhaSach
    {
        internal object hienThiTV()
        {
            var tv = db.fun_ThanhVien();
            return tv;

        }

        internal object searchTV(string chuoi)
        {
            var timKiem = db.fun_SearchThanhVien(chuoi);
            return timKiem;
        }

        //internal object AddTV ()
        //{
        //    var addTV = db.SettingThanhVien();
        //}
    }
}
