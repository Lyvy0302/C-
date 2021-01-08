using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_ChuongTrinhCafe
{
    public partial class Form1 : Form
    {
        private const int CAFEDEN = 12000;
        private const int CAFEDA = 13000;
        private const int CAFESUA = 14000;
        private const int CAFEKEM = 15000;
        private const int CAFESUADA = 16000;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Chon Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("Quay ve man hinh chinh");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            chbsinhVien.Checked = false;
            rdCafeDen.Checked = false;
            txtTenKhach.Focus();
            txtTongKH.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = true;
            Double TongKH = 0;
            if (chbsinhVien.Checked == true)
            {
                if (rdCafeKem.Checked == true)
                {
                    TongKH += CAFEKEM * 0.3;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }

                else if (rdCafeDen.Checked == true)
                {
                    TongKH += CAFEDEN * 0.3;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }

                else if (rdCafeSua.Checked == true)
                {
                    TongKH += CAFESUA * 0.3;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }

                else if (rdDa.Checked == true)
                {
                    TongKH += CAFEDA * 0.3;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }
                else if (rdSuaDa.Checked == true)
                {
                    TongKH += CAFESUADA * 0.3;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }
            }
            else
            {
                if (rdCafeKem.Checked == true)
                {
                    TongKH += CAFEKEM;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }

                else if (rdCafeDen.Checked == true)
                {
                    TongKH += CAFEDEN;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }

                else if (rdCafeSua.Checked == true)
                {
                    TongKH += CAFESUA;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }

                else if (rdDa.Checked == true)
                {
                    TongKH += CAFEDA;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }
                else if (rdSuaDa.Checked == true)
                {
                    TongKH += CAFESUADA;
                    txtTongKH.Text = TongKH.ToString("#,###.##");
                }
            }
        }

        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnTinh.Enabled = false;
            Double Tong = 0;
            Tong = Double.Parse(txtTongKH.Text.ToString());
            txtTongTien.Text = Tong.ToString("#,###.##");
            txtTongKH.Clear();
        }

        private void lblCafe_Click(object sender, EventArgs e)
        {

        }
    }
}
