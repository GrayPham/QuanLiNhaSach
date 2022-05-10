﻿using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM.BLL
{
    public class NhanVien : QuanLyNhaSach
    {

        internal object hienThi()
        {
            var sach = db.fun_SachCon();
            return sach;
        }

        internal object search(string chuoi)
        {
            var timKiem = db.fun_SearchSach(chuoi);
            return timKiem; 
        }

        internal object hienThiNV()
        {
            var nv = db.fun_DanhSachNhanVien();
            return nv;
        }

        internal object searchNV(string chuoi)
        {
            var timKiem = db.fun_SearchNhanVien(chuoi);
            return timKiem;
        }
    }
}
