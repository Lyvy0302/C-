using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmQuanLy : Form
    {
        DSKhachThue objds = new DSKhachThue();
        int viTriHienTai = 0;
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            for (int i = 4; i <= 1000; i++)
            {
                cboSoLuong.Items.Add(i);
            }
            radDung.Checked = true;
            cboSoLuong.SelectedIndex = 9;
            ThietDatListView(lvwthongKe);
            TaoCungDS();//tạo cứng trước ds thuê CD
            LoadDSVaoListView(objds.LayToanBoDS(), lvwthongKe);//load tạo cứng ds vào listview
        }

        void ThietDatListView(ListView lvw)
        {
            lvw.GridLines = true;//chon co buoc
            lvw.FullRowSelect = true;//chon nguyen
            lvw.LargeImageList = imgLarge;//mac dinh cot 1
            lvw.SmallImageList = imgSmall;
            TaoHeader(lvw);
            lvw.View = View.Details;//thay cac cot
        }

        void TaoHeader(ListView lvw)
        {
            lvw.Columns.Add("Ma", 100);
            lvw.Columns.Add("Ho Ten", 170);
            lvw.Columns.Add("So Luong", 100);
            lvw.Columns.Add("Don Gia", 100);
            lvw.Columns.Add("Thuong/Phat", 100);
            lvw.Columns.Add("Thanh Tien", 100);
        }

        void TaoCungDS()
        {
            KhachThue cd1 = new KhachThue(112,"KH01",12,1200,true);
            KhachThue cd2 = new KhachThue(113, "KH02", 13, 1201, false);
            KhachThue cd3 = new KhachThue(114, "KH03", 14, 1202, true);
            KhachThue cd4 = new KhachThue(115, "KH04", 15, 1203, false);
            objds.ThemKhachThue(cd1);
            objds.ThemKhachThue(cd2);
            objds.ThemKhachThue(cd3);
            objds.ThemKhachThue(cd4);
        }
        void LoadDSVaoListView(ArrayList ds, ListView lvw)
        {
            lvw.Items.Clear();
            ListViewItem lvwItem;
            float tienPhaiTra;
            foreach (KhachThue cd in ds)
            {
                lvwItem = new ListViewItem();
                lvwItem.Text = cd.Ma.ToString();
                lvwItem.SubItems.Add(cd.HoTen);
                lvwItem.SubItems.Add(cd.SoLuong.ToString());
                lvwItem.SubItems.Add(cd.DonGia.ToString());
                if (cd.Dungtre1)
                {
                    lvwItem.SubItems.Add("Đúng hạn");
                    tienPhaiTra = (cd.SoLuong * cd.DonGia) * 0.97F;
                }
                else
                {
                    lvwItem.SubItems.Add("Trễ hạn");
                    tienPhaiTra = (cd.SoLuong * cd.DonGia) * 1.05F;
                }
                lvwItem.SubItems.Add(tienPhaiTra.ToString());
                lvwItem.Tag = cd; //phục vụ cho xoá
                lvw.Items.Add(lvwItem);//thêm item vào listview
            }
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double Tp = 0, thanhTien;
            int sl, dg;
            ListViewItem lvwItem = new ListViewItem(txtMa.Text);
            lvwItem.SubItems.Add(txtHoTen.Text);
            sl = Convert.ToInt32(cboSoLuong.SelectedItem.ToString());
            dg = Convert.ToInt32(txtDonGia.Text);
            lvwItem.SubItems.Add(sl.ToString());
            lvwItem.SubItems.Add(dg.ToString());
            if (radDung.Checked)
            {
                Tp = (dg * sl) * 0.03;
                thanhTien = (dg * sl) - Tp;
            }
            else
            {
                Tp = (dg * sl) * 0.05;
                thanhTien = (dg * sl) + Tp;
            }
            lvwItem.SubItems.Add(Tp.ToString());
            lvwItem.SubItems.Add(thanhTien.ToString("#,##0.0"));
            lvwthongKe.Items.Add(lvwItem);
            lvwItem.ImageIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon xoa khong ?","Xac nhan ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                lvwthongKe.Items.Clear();
            }
            else if(res == DialogResult.No)
            {
                MessageBox.Show("Huy");
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            
            double tong = 0;
            for (int i = 0; i < lvwthongKe.Items.Count; i++)
            {
                tong += double.Parse(lvwthongKe.Items[i].SubItems[5].Text);
            }
            lblIndex.Text = tong.ToString("#,##0.0");
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban Co Muon Thoat Khong ?", "Xac Nhan Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();

            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("Chon Huy");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            if (lvwthongKe.Items.Count > 0)
            {
                if (viTriHienTai > 0 && viTriHienTai < lvwthongKe.Items.Count)
                    lvwthongKe.Items[viTriHienTai].Selected = false;
                viTriHienTai = 0;
                lvwthongKe.Items[viTriHienTai].Selected = true;
                lvwthongKe.Focus();
                changePage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lvwthongKe.Items.Count > 0)
            {
                if (viTriHienTai < lvwthongKe.Items.Count - 1)
                {
                    lvwthongKe.Items[viTriHienTai].Selected = false;
                    viTriHienTai += 1;
                    lvwthongKe.Items[viTriHienTai].Selected = true;
                    lvwthongKe.Focus();
                    changePage();
                }
            }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            if (viTriHienTai > 0 && viTriHienTai < lvwthongKe.Items.Count)
            {
                lvwthongKe.Items[viTriHienTai].Selected = false;
                viTriHienTai -= 1;
                lvwthongKe.Items[viTriHienTai].Selected = true;
                lvwthongKe.Focus();
                changePage();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lvwthongKe.Items.Count > 0)
            {
                lvwthongKe.Items[viTriHienTai].Selected = false;
                viTriHienTai = lvwthongKe.Items.Count - 1;
                lvwthongKe.Items[viTriHienTai].Selected = true;
                lvwthongKe.Focus();
                changePage();
            }
        }

        private void changePage()
        {
            if (lvwthongKe.SelectedItems.Count > 0)
            {
                int i = lvwthongKe.SelectedIndices[0];
                lblIndex.Text = i + 1 + " / " + lvwthongKe.Items.Count;
                txtMa.Text = lvwthongKe.Items[i].SubItems[0].Text;
                txtHoTen.Text = lvwthongKe.Items[i].SubItems[1].Text;
                cboSoLuong.Text = lvwthongKe.Items[i].SubItems[2].Text;
                txtDonGia.Text = lvwthongKe.Items[i].SubItems[3].Text;
            }
        }
    }
}
