using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_BaiTapThangNam
{
    public partial class FrmThangNam : Form
    {
        public FrmThangNam()
        {
            InitializeComponent();
        }

        private void FrmThangNam_Load(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            String s;
            s = "My Name is : " + txtName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            s = s + "Age : " + age.ToString();
            MessageBox.Show(s);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn thoát  ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("Quay về màn hình chính");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            txtName.Clear();
            txtName.Focus();//đối tượng đang dc focus 
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))//ngăn ký tự nhập vào k phải số và k phải các control di chuyển chuột
                e.Handled = true;//k dc nhấn phím k hơp lệ
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //isDigit là kiểm tra xem phím vừa nhập có phải ký tự số hay không trả về kiểu bool
            //control(ky tu điều khiển  vd delete,insert...)
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
