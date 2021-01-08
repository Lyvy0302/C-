using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongMay
{
    public class KetNoiCSDL
    {
        private DBQLPhongHocMayTinhDataContext dt;
        public DBQLPhongHocMayTinhDataContext getDatacontext()
        {
            String strKetNoi = @"Data Source=DESKTOP-RFV2GND;Initial Catalog=QuanLyPhongMay;Integrated Security=True";
            dt = new DBQLPhongHocMayTinhDataContext(strKetNoi);
            dt.Connection.Open();
            return dt;
        }
    }
}
