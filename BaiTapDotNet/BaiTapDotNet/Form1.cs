using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapDotNet
{
    public partial class FrmQuanLy : Form
    {
        int viTriHienTai = 0;
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

		//Nhung event khi được click vào
        private void radDung_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click_1(object sender, EventArgs e)
        {
			double Tp = 0, thanhTien;
			int sl, dg;
			ListViewItem lvwItem = new ListViewItem(txtMa.Text);
			// lvwItem.SubItems.Add();
			lvwItem.SubItems.Add(txtHoTen.Text);
			sl = Convert.ToInt32(cboSoLuong.SelectedItem.ToString());
			dg = Convert.ToInt32(txtDonGia.Text);
			lvwItem.SubItems.Add(sl.ToString());
			lvwItem.SubItems.Add(dg.ToString());
			//String dangChon = cboSoLuong.Text;
			//lblIndex.Text = dangChon;
			// dangChon = cboSoLuong.Items[cboSoLuong.SelectedIndex].ToString();
			//xoa ptu theo  vi tri dang chon 
			// cboSoLuong.Items.RemoveAt(cboSoLuong.SelectedIndex);
			//xoa ptu theo gia tri
			// cboSoLuong.Items.Remove(20);
			// radDung.Checked = true;
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
			DialogResult res = MessageBox.Show("Ban Co Muon Xoa Khong ?", "Xac Nhan Xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				MessageBox.Show("Chon Xoa");
				lvwthongKe.Items.Clear();
			}
			else if (res == DialogResult.No)
			{
				MessageBox.Show("Chon Huy");
			}
		}

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
			DialogResult res = MessageBox.Show("Ban Co Muon Thoat Khong ?", "Xac Nhan Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				MessageBox.Show("Chon Thoat");
				this.Close();

			}
			else if (res == DialogResult.No)
			{
				MessageBox.Show("Chon Huy");
			}

		}

        private void btnTong_Click_1(object sender, EventArgs e)
        {
			double tong = 0;
			for (int i = 0; i < lvwthongKe.Items.Count; i++)
			{
				tong += double.Parse(lvwthongKe.Items[i].SubItems[5].Text);
			}
			lblIndex.Text = tong.ToString("#,##0.0");

		}

        private void btnFirst_Click_1(object sender, EventArgs e)
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

        private void btnNext_Click_1(object sender, EventArgs e)
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

        private void btnTo_Click_1(object sender, EventArgs e)
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

        private void btnLast_Click_1(object sender, EventArgs e)
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

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

