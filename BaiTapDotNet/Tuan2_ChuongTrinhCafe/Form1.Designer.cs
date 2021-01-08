namespace Tuan2_ChuongTrinhCafe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCafe = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCafeKem = new System.Windows.Forms.RadioButton();
            this.rdSuaDa = new System.Windows.Forms.RadioButton();
            this.rdDa = new System.Windows.Forms.RadioButton();
            this.rdCafeSua = new System.Windows.Forms.RadioButton();
            this.rdCafeDen = new System.Windows.Forms.RadioButton();
            this.chbsinhVien = new System.Windows.Forms.CheckBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.lblTongKH = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCafe
            // 
            this.lblCafe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCafe.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCafe.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCafe.Location = new System.Drawing.Point(0, 0);
            this.lblCafe.Name = "lblCafe";
            this.lblCafe.Size = new System.Drawing.Size(1188, 83);
            this.lblCafe.TabIndex = 1;
            this.lblCafe.Text = "CAFE SINH VIÊN";
            this.lblCafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCafe.Click += new System.EventHandler(this.lblCafe_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1188, 401);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCafeKem);
            this.groupBox1.Controls.Add(this.rdSuaDa);
            this.groupBox1.Controls.Add(this.rdDa);
            this.groupBox1.Controls.Add(this.rdCafeSua);
            this.groupBox1.Controls.Add(this.rdCafeDen);
            this.groupBox1.Location = new System.Drawing.Point(500, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại cafe";
            // 
            // rdCafeKem
            // 
            this.rdCafeKem.AutoSize = true;
            this.rdCafeKem.Location = new System.Drawing.Point(246, 117);
            this.rdCafeKem.Name = "rdCafeKem";
            this.rdCafeKem.Size = new System.Drawing.Size(117, 29);
            this.rdCafeKem.TabIndex = 2;
            this.rdCafeKem.Text = "Cafe kem";
            this.rdCafeKem.UseVisualStyleBackColor = true;
            // 
            // rdSuaDa
            // 
            this.rdSuaDa.AutoSize = true;
            this.rdSuaDa.Location = new System.Drawing.Point(50, 188);
            this.rdSuaDa.Name = "rdSuaDa";
            this.rdSuaDa.Size = new System.Drawing.Size(139, 29);
            this.rdSuaDa.TabIndex = 4;
            this.rdSuaDa.Text = "Cafe sữa đá";
            this.rdSuaDa.UseVisualStyleBackColor = true;
            // 
            // rdDa
            // 
            this.rdDa.AutoSize = true;
            this.rdDa.Location = new System.Drawing.Point(246, 48);
            this.rdDa.Name = "rdDa";
            this.rdDa.Size = new System.Drawing.Size(102, 29);
            this.rdDa.TabIndex = 1;
            this.rdDa.Text = "Cafe đá";
            this.rdDa.UseVisualStyleBackColor = true;
            // 
            // rdCafeSua
            // 
            this.rdCafeSua.AutoSize = true;
            this.rdCafeSua.Location = new System.Drawing.Point(50, 117);
            this.rdCafeSua.Name = "rdCafeSua";
            this.rdCafeSua.Size = new System.Drawing.Size(112, 29);
            this.rdCafeSua.TabIndex = 3;
            this.rdCafeSua.Text = "Cafe sữa";
            this.rdCafeSua.UseVisualStyleBackColor = true;
            // 
            // rdCafeDen
            // 
            this.rdCafeDen.AutoSize = true;
            this.rdCafeDen.Checked = true;
            this.rdCafeDen.Location = new System.Drawing.Point(50, 48);
            this.rdCafeDen.Name = "rdCafeDen";
            this.rdCafeDen.Size = new System.Drawing.Size(113, 29);
            this.rdCafeDen.TabIndex = 0;
            this.rdCafeDen.TabStop = true;
            this.rdCafeDen.Text = "Cafe đen";
            this.rdCafeDen.UseVisualStyleBackColor = true;
            // 
            // chbsinhVien
            // 
            this.chbsinhVien.AutoSize = true;
            this.chbsinhVien.Checked = true;
            this.chbsinhVien.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbsinhVien.Location = new System.Drawing.Point(500, 174);
            this.chbsinhVien.Name = "chbsinhVien";
            this.chbsinhVien.Size = new System.Drawing.Size(131, 29);
            this.chbsinhVien.TabIndex = 3;
            this.chbsinhVien.Text = "Sinh viên ?";
            this.chbsinhVien.UseVisualStyleBackColor = true;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(500, 115);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(353, 30);
            this.txtTenKhach.TabIndex = 2;
            this.txtTenKhach.Text = "Nguyễn Văn A";
            this.txtTenKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhach_KeyPress);
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.Location = new System.Drawing.Point(135, 115);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(177, 33);
            this.lblTenKhach.TabIndex = 0;
            this.lblTenKhach.Text = "Tên Khách Hàng: ";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(122, 505);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(150, 46);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "&Tính Tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(383, 505);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(150, 46);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "&Nhập Lại";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(644, 505);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 46);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "T&hanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(905, 505);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 46);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(178, 650);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(235, 33);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "Tổng Tiền Khách Hàng: ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AcceptsTab = true;
            this.txtTongTien.Location = new System.Drawing.Point(499, 647);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(351, 30);
            this.txtTongTien.TabIndex = 12;
            // 
            // txtTongKH
            // 
            this.txtTongKH.Location = new System.Drawing.Point(499, 581);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(351, 30);
            this.txtTongKH.TabIndex = 10;
            // 
            // lblTongKH
            // 
            this.lblTongKH.AllowDrop = true;
            this.lblTongKH.Location = new System.Drawing.Point(178, 584);
            this.lblTongKH.Name = "lblTongKH";
            this.lblTongKH.Size = new System.Drawing.Size(235, 33);
            this.lblTongKH.TabIndex = 9;
            this.lblTongKH.Text = "Tổng Khách Hàng: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 704);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbsinhVien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTongKH);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lblTongKH);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCafe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCafe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCafeKem;
        private System.Windows.Forms.RadioButton rdSuaDa;
        private System.Windows.Forms.RadioButton rdDa;
        private System.Windows.Forms.RadioButton rdCafeSua;
        private System.Windows.Forms.RadioButton rdCafeDen;
        private System.Windows.Forms.CheckBox chbsinhVien;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label lblTongKH;
    }
}

