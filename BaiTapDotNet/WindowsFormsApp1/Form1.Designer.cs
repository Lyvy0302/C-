namespace WindowsFormsApp1
{
    partial class FrmQuanLy
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwthongKe = new System.Windows.Forms.ListView();
            this.lblIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSoLuong = new System.Windows.Forms.ComboBox();
            this.radTre = new System.Windows.Forms.RadioButton();
            this.radDung = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.imgLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgSmall = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwthongKe);
            this.groupBox2.Location = new System.Drawing.Point(119, 415);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(548, 126);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // lvwthongKe
            // 
            this.lvwthongKe.HideSelection = false;
            this.lvwthongKe.Location = new System.Drawing.Point(16, 25);
            this.lvwthongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwthongKe.Name = "lvwthongKe";
            this.lvwthongKe.Size = new System.Drawing.Size(515, 95);
            this.lvwthongKe.TabIndex = 0;
            this.lvwthongKe.UseCompatibleStateImageBehavior = false;
            // 
            // lblIndex
            // 
            this.lblIndex.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIndex.Location = new System.Drawing.Point(575, 376);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(92, 32);
            this.lblIndex.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ THUÊ CD";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSoLuong);
            this.groupBox1.Controls.Add(this.radTre);
            this.groupBox1.Controls.Add(this.radDung);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(119, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(563, 282);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin KH";
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSoLuong.Location = new System.Drawing.Point(218, 108);
            this.cboSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(214, 33);
            this.cboSoLuong.TabIndex = 4;
            this.cboSoLuong.Text = "10";
            // 
            // radTre
            // 
            this.radTre.AutoSize = true;
            this.radTre.Location = new System.Drawing.Point(218, 222);
            this.radTre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radTre.Name = "radTre";
            this.radTre.Size = new System.Drawing.Size(219, 29);
            this.radTre.TabIndex = 3;
            this.radTre.TabStop = true;
            this.radTre.Text = "Tăng 5% Thành Tiền";
            this.radTre.UseVisualStyleBackColor = true;
            // 
            // radDung
            // 
            this.radDung.AutoSize = true;
            this.radDung.Location = new System.Drawing.Point(218, 192);
            this.radDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDung.Name = "radDung";
            this.radDung.Size = new System.Drawing.Size(219, 29);
            this.radDung.TabIndex = 3;
            this.radDung.TabStop = true;
            this.radDung.Text = "Giảm 3% Thành Tiền";
            this.radDung.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(458, 144);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(458, 106);
            this.btnTong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(90, 32);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tổng Tiền";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(458, 65);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(458, 26);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(90, 32);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính Thuê";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(218, 146);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(214, 30);
            this.txtDonGia.TabIndex = 1;
            this.txtDonGia.Text = "10";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(218, 71);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(214, 30);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Nguyễn Văn Hoàng";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(218, 32);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(214, 30);
            this.txtMa.TabIndex = 1;
            this.txtMa.Text = "123";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trả Trễ Hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trả Đúng Hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Lượng CD Thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(143, 376);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(90, 32);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(467, 376);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(90, 32);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(359, 376);
            this.btnTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(90, 32);
            this.btnTo.TabIndex = 9;
            this.btnTo.Text = ">";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(251, 376);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 32);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imgLarge
            // 
            this.imgLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLarge.ImageSize = new System.Drawing.Size(48, 48);
            this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgSmall
            // 
            this.imgSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnNext);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLy";
            this.Text = "Quản Lý Thuê CD";
            this.Load += new System.EventHandler(this.FrmQuanLy_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwthongKe;
        private System.Windows.Forms.Label lblIndex;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSoLuong;
        private System.Windows.Forms.RadioButton radTre;
        private System.Windows.Forms.RadioButton radDung;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ImageList imgLarge;
        private System.Windows.Forms.ImageList imgSmall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

