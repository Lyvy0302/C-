using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class KhachThue
    {
        private int ma;
        private String hoTen;
        private int soLuong;
        private int donGia;
        private bool Dungtre;


        public KhachThue(int ma, string hoTen, int soLuong, int donGia, bool dungtre)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.soLuong = soLuong;
            this.donGia = donGia;
            Dungtre = dungtre;
        }

        public KhachThue()
        {
        }

        public int Ma
        {
            get
            {
                return ma;
            }

            set
            {
                //ma = (value > 0) ? value : -1;
                if (value.ToString().Length > 0)
                {
                    ma = value;
                }
                else
                    throw new Exception("Phải nhập mã");
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public bool Dungtre1
        {
            get
            {
                return Dungtre;
            }

            set
            {
                Dungtre = value;
            }
        }

        public double ThanhTien(bool dungHan)
        {
            double Tp = 0, thanhTien;
            if (dungHan)
            {
                Tp = (donGia * soLuong) * 0.03;
                thanhTien = (donGia * soLuong) - Tp;
            }
            else
            {
                Tp = (donGia * soLuong) * 0.05;
                thanhTien = (donGia * soLuong) + Tp;
            }
            return thanhTien;
        }

        public override bool Equals(object obj)
        {
            //ktra trùng mã là 2 obj bằng nhau
            return this.Ma.Equals(((KhachThue)obj).Ma);
        }

    }


}
