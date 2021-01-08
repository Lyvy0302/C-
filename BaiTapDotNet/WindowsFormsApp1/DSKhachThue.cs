using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class DSKhachThue
    {
        ArrayList ds;
        public DSKhachThue()
        {
            ds = new ArrayList();
        }
        public bool ThemKhachThue(KhachThue khach)
        {
            if (ds.Contains(khach))
                return false;
            else
            {
                ds.Add(khach);
                return true;
            }
        }

        public ArrayList LayToanBoDS()
        {
            return ds;
        }
        public bool XoaKhachThue(KhachThue khach)
        {
            if (khach != null)
            {
                ds.Remove(khach);
                return true;
            }
            else
                return false;
        }
        void SuaThongTinKhach(KhachThue khachDaSua)
        {
            int vitriTimThay = ds.IndexOf(khachDaSua);
            if (vitriTimThay > 0)
            {
                ds[vitriTimThay] = khachDaSua;
            }
        }
        public double TongTien()
        {
            double sum = 0;
            foreach (KhachThue item in ds)
            {
                if (item.Dungtre1)
                {
                    sum += item.SoLuong * item.DonGia * 0.97;
                }
                else
                    sum += item.SoLuong * item.DonGia * 1.05;
            }
            return sum;
        }
    }
}
