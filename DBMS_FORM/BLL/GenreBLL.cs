using DBMS_FORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FORM.BLL
{
    internal class GenreBLL: QuanLyNhaSach
    {


            internal bool MethodGenre(int MTL, string TenTL, bool BiLoaiBo)
            {

                db.Add_TheLoai(MTL, TenTL, BiLoaiBo);
                return true;
            }

            public object GetGenre()
            {
                var genre = db.TheLoais.Where(t => t.BiLoaiBo == false).Select(s => new
                {
                    MTL = s.MTL,
                    TenTL = s.TenTL,
                    BiLoaiBo = s.BiLoaiBo
                }).ToList();
                return genre;
            }

    }
}
