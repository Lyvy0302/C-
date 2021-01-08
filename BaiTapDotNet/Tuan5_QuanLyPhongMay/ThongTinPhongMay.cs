using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_QuanLyPhongMay
{
    public partial class frmQuanLyPhongMay : Form
    {
        public frmQuanLyPhongMay()
        {
            InitializeComponent();
        }
        TreeNode nGoc;
        clsPhongHoc objPhong = new clsPhongHoc();//tự chạy constructor
        clsMayTinh objMay = new clsMayTinh();//tự chạy constructor
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvwDanhSachMay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanLyPhongMay_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            trePhong.ImageList = imageList;
            trePhong.SelectedImageIndex = 1;//trạng thái chọn
            trePhong.ImageIndex = 0;//hình trạng thái thường
            nGoc = new TreeNode("Danh sách phòng");//cây cấp 0
            trePhong.Nodes.Add(nGoc);
            IEnumerable<lblPhong> lstPhong = objPhong.getPhongHoc();
            LoadTree(lstPhong);
            IEnumerable<lblMay> lstAllMayTinh = objMay.GetAllMayTinh();//hàm lọc dữ liệu
            dgrMayTinh.DataSource = lstAllMayTinh;//hàm lấy tất cả trong datagridview 
            FormatDaTaGrid(dgrMayTinh);//format lại datagridview
           
            
        }
        void FormatDaTaGrid(DataGridView dgr)//dung der format lai datagridview
        {
            dgr.Columns["id_Phong"].Visible = false;
           dgr.Columns["lblPhong"].Visible = false;
            dgr.Columns["CPU"].Width = 150;
            dgr.Columns[0].Width = 100;
            dgr.Columns[0].HeaderText = "Mã máy";
            // dgr.Columns["msMay"].HeaderText = "Mã máy";
        }
        void LoadTree(IEnumerable<lblPhong> lstPhong)//tạo cây cấp 1
        {
            TreeNode nConPhong;
            IEnumerable<lblMay> lstMayThuocPhong;
            foreach (lblPhong p in lstPhong)
            {
                nConPhong = new TreeNode("Phòng: " + p.tenPhong);
                lstMayThuocPhong = objMay.GetMayTinhThuocPhongHoc(p.id_Phong);
                LoadMayThuocPhong(nConPhong, lstMayThuocPhong);
                nConPhong.Tag = p.id_Phong;
                nGoc.Nodes.Add(nConPhong);
            }
            trePhong.ExpandAll();
        }
       
        void LoadMayThuocPhong(TreeNode nPhong, IEnumerable<lblMay> lstMT)//cây cấp 2
        {
            TreeNode nConMay;
            foreach (lblMay mTinh in lstMT)
            {
                nConMay = new TreeNode("Mã máy: " + mTinh.id);
                nConMay.Tag = mTinh;
                nPhong.Nodes.Add(nConMay);
            }
        }
        private void trePhong_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
           lblMay mt = null;
            if (trePhong.SelectedNode != null)//có node chọn
                if (trePhong.SelectedNode.Level == 2)//chọn nút con cấp 2
                {
                    mt = (lblMay)trePhong.SelectedNode.Tag;
                   LoadTreeViewToText(mt);//load dl từ treeview xuống textbox
                    objectToText(mt);
                }
                else if (trePhong.SelectedNode.Level == 1)//chọn nút con cấp 1
                {
                    String strMTinh = trePhong.SelectedNode.Tag.ToString();
                    IEnumerable<lblMay> lstmayTinhThuocPhong = objMay.GetMayTinhThuocPhongHoc(strMTinh);
                    dgrMayTinh.DataSource = lstmayTinhThuocPhong;
                    FormatDaTaGrid(dgrMayTinh);
                    
                }
        }
        void LoadTreeViewToText(lblMay mt)//load dl từ treeview xuống textbox
        {
            txtMSMay.Text = mt.id;
            txtCPU.Text = mt.cpu;
            txtHardDisk.Text = mt.hdd;
            txtRam.Text = mt.ram;
            txtVGA.Text = mt.vga;
            txtMonitor.Text = mt.monitor;
        }

        void objectToText(lblMay mt)
        {
            txtMSMay.Text = mt.id;
            txtCPU.Text = mt.cpu;
            txtHardDisk.Text = mt.hdd;
            txtRam.Text = mt.ram;
            txtVGA.Text = mt.vga;
            txtMonitor.Text = mt.monitor;
        }
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();//xoá hết column
            lvw.View = View.Details;//show các cột
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã máy", 80);
            lvw.Columns.Add("CPU", 150);
            lvw.Columns.Add("HardDisk", 150);
            lvw.Columns.Add("RAM", 150);
            lvw.Columns.Add("VGA", 150);
            lvw.Columns.Add("Monitor", 150);
            lvw.Columns.Add("Mã số phòng", 80);
        }
        void LoadTreeViewToListView(ListView lvw, IEnumerable<lblMay> lstAllMT)//load dữ liệu từ treeview qua bên listview khi chọn vào node cấp 1
        {
            lvw.Items.Clear();
            ListViewItem lvwItem;
            foreach (lblMay mt in lstAllMT)
            {
                lvwItem = new ListViewItem();
                lvwItem.Text = mt.id;
                lvwItem.SubItems.Add(mt.cpu);
                lvwItem.SubItems.Add(mt.hdd);
                lvwItem.SubItems.Add(mt.ram);
                lvwItem.SubItems.Add(mt.vga);
                lvwItem.SubItems.Add(mt.monitor);
                lvwItem.SubItems.Add(mt.id_Phong);
                lvwItem.Tag = mt;
                lvw.Items.Add(lvwItem);
            }
        }
        private void dgrMayTinh_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)//chèn từ datagridview vào textbox
        {
            if (dgrMayTinh.SelectedRows.Count > 0)//có chọn
            {
                txtMSMay.Text = e.Row.Cells["msMay"].Value.ToString();
                txtCPU.Text = e.Row.Cells["CPU"].Value.ToString();
                txtHardDisk.Text = e.Row.Cells["HardDisk"].Value.ToString();
                txtRam.Text = e.Row.Cells["RAM"].Value.ToString();
                txtVGA.Text = e.Row.Cells["VGA"].Value.ToString();
                txtMonitor.Text = e.Row.Cells["Monitor"].Value.ToString();
            }
        }
        private void lvwMayTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMay mt = null;
            if(dgrMayTinh.SelectedRows.Count > 0)
            {
                mt = (lblMay)dgrMayTinh.SelectedRows[0].Tag;
                objectToText(mt);
            }
        }
        void LoadListViewToText(lblMay mt)//load dữ liệu từ listview xuống textbox
        {
            txtMSMay.Text = mt.id;
            txtCPU.Text = mt.cpu;
            txtHardDisk.Text = mt.hdd;
            txtRam.Text = mt.ram;
            txtVGA.Text = mt.vga;
            txtMonitor.Text = mt.monitor;
        }
        bool KiemTraDuLieu()//hàm kiểm tra dl nhập vào có đúng hay không
        {
            //tuỳ yêu cầu đề bài để set điều kiện
            if (txtCPU.Text.Equals("") && txtHardDisk.Text.Equals(""))
                return false;
            //kiểm tra trùng mã
            if (objMay.TimKhiBietMa(txtMSMay.Text) != null)//hàm TimKhiBietMa viết ở clsMayTinh
                return false;
            return true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //1 ktra tính đúng của dữ liệu
            //2 lưu vào csdl khi đã đúng dl
            //2.1 tạo đối tượng obj
            //2.2 cập nhật obj vào CSDL
            //3 tái hiện lại cho user xem
            if (KiemTraDuLieu())
            {
                if (btnXoaTrang.Text.Equals("Huỷ thêm mới"))// tình trạng có thể thêm mới
                {
                    lblMay newmt = new lblMay();
                    string strMaPhong = trePhong.SelectedNode.Tag.ToString();
                    newmt.id = txtMSMay.Text;
                    newmt.cpu = txtCPU.Text;
                    newmt.hdd = txtHardDisk.Text;
                    newmt.ram = txtRam.Text;
                    newmt.vga = txtVGA.Text;
                    newmt.monitor = txtMonitor.Text;
                    newmt.id_Phong = strMaPhong;
                    objMay.ThemMTMoi(newmt);
                    //load to listview
                    IEnumerable<lblMay> lstmayTinhThuocPhong = objMay.GetMayTinhThuocPhongHoc(strMaPhong);
                    dgrMayTinh.DataSource = lstmayTinhThuocPhong;
                    FormatDaTaGrid(dgrMayTinh);
                    
                }
            }
            else
            {
                int a = 8;
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            if (btnXoaTrang.Text.Equals("Xoá trắng thêm mới"))
            {
                btnXoaTrang.Text = "Huỷ thêm mới";
            }
            else//huỷ thêm mới
                btnXoaTrang.Text = "Xoá trắng thêm mới";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoiThoat;
            hoiThoat = MessageBox.Show("Bạn có chắc muốn thoát??", "Thông báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (hoiThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void trePhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = trePhong.SelectedNode;
            if(node.Level == 0)
            {
                string idPhong = node.Text.Split(':')[1].Trim();
                IEnumerable<lblMay> list = objMay.GetMayTinhThuocPhong(idPhong);
                LoadDataToListView(list);
            }
            else if (node.Level == 2)
            {
                lblMay mt = (lblMay)node.Tag;
                
                objectToText(mt);
            }
        }

        private void LoadDataToListView(IEnumerable<lblMay> list)
        {
            
        }

        private void txtMSMay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }
    }
}
