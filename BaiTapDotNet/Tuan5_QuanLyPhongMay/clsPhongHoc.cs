using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongMay
{
    public class clsPhongHoc:KetNoiCSDL
    {
        public DBQLPhongHocMayTinhDataContext dt;
        public clsPhongHoc()
        {
            dt = getDatacontext();//ở lớp cha
        }
        public IEnumerable<lblPhong> getPhongHoc()
        {
            IEnumerable<lblPhong> p = from n in dt.lblPhongs
                                         select n;
            return p;
        }

        public bool ThemPhong(lblPhong p)
        {
            try
            {
                dt.lblPhongs.InsertOnSubmit(p);
                dt.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
