using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private const int VND_TO_USD = 23070;
        private const int VND_TO_EUR = 27968;
        public Form1()
        {
            InitializeComponent();
        }
        private bool validate()
        {
            return !string.IsNullOrEmpty(txtTien.Text);
        }
        //vnd->usd

        private void btnVndToUsd_Click(object sender, EventArgs e)
        {
            if (validate())//kiem tra dl co phu hop hay k
            {
                int vnd = int.Parse(txtTien.Text);
                double usd = 1.0 * vnd / VND_TO_USD;
                txtKetQua.Text = usd.ToString("#,##0.0");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }

          //vnd->eur
        private void btnVndToEur_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int vnd = int.Parse(txtTien.Text);
                double eur = 1.0 * vnd / VND_TO_EUR;
                txtKetQua.Text = eur.ToString("#,##0.0");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }

        private void btnUsdToVnd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int usd = int.Parse(txtTien.Text);
                double vnd = usd * VND_TO_USD;
                txtKetQua.Text = vnd.ToString("#,##0.0");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }

        private void btnEurToVnd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int eur = int.Parse(txtTien.Text);
                double vnd = eur * VND_TO_EUR;
                txtKetQua.Text = vnd.ToString("#,##0.0");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }
    }
}
