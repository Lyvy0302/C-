using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChuongTrinhBanVeXemPhim
{
    public partial class FrmRapPhim : Form
    {
        public FrmRapPhim()
        {
            InitializeComponent();
        }

        const int DAYA = 100;
        const int DAYB = 200;
        const int DAYC = 300;

        private void FrmRapPhim_Load(object sender, EventArgs e)
        {
            createButton(21);
        }

        void createButton(int n)
        {
            Button btn;
            for (int i = 1; i <= n; i++)
            {
                btn = new Button();//khoi tai bien lbl kieu label
                btn.Text = i.ToString();
                btn.BackColor = Color.Gray;
                btn.Width = 80;
                btn.Height = 80;
                btn.Name = "x" + i.ToString();
                btn.Click += new EventHandler(ChonTui);
                flowLayoutPanel1.Controls.Add(btn);
         

            }
        }
        private void ChonTui(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Gray)
            {
                btn.BackColor = Color.Blue;
                lblThanhtien.Text = tinhTien().ToString();
            }
            else if (btn.BackColor == Color.Gray)
                btn.BackColor = Color.Yellow; 
            else
                MessageBox.Show("Ghế " + btn.Text + " bạn đã chọn rồi.", "Chú ý");
        }

        private int tinhTien()
        {
            int tong = 0;
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if(btn.BackColor == Color.Blue)
                {
                    int tt = Int32.Parse(btn.Text);
                    if (tt < 8)
                        tong += DAYA;
                    else if (tt < 15)
                        tong += DAYB;
                    else if (tt <= 21)
                        tong += DAYC;
                    else
                        tong += 0;
                
                }
            }
            return tong;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int nTien = 0;
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Yellow;
                    if (Int32.Parse(btn.Text) < 8)
                    {
                        nTien += DAYA;
                     
                    }
                    else if (Int32.Parse(btn.Text) < 15)
                    {
                        nTien += DAYB;
                    }
                    else
                    {
                        nTien += DAYC;
                       
                    }
                }
              
            }
           
            lblThanhtien.Text = string.Format("{0} VND", nTien);
        }
      
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flowLayoutPanel1.Controls)
                if (btn.BackColor == Color.Blue)
                    btn.BackColor = Color.Gray; // đổi màu label xanh thành xxam
            lblThanhtien.Text = ""; 
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Chon Thoat",MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
            else if(res == DialogResult.No)
            {
                MessageBox.Show("Quay ve man hinh chinh");
            }
        }
    }
}

