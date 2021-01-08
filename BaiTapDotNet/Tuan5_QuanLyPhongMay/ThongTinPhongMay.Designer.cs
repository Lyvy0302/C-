namespace Tuan5_QuanLyPhongMay
{
    partial class frmQuanLyPhongMay
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHardDisk = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.txtMSMay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrMayTinh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trePhong = new System.Windows.Forms.TreeView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMayTinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCPU);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtHardDisk);
            this.groupBox3.Controls.Add(this.txtRam);
            this.groupBox3.Controls.Add(this.txtVGA);
            this.groupBox3.Controls.Add(this.txtMonitor);
            this.groupBox3.Controls.Add(this.txtMSMay);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(315, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 290);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin máy tính";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(221, 63);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(427, 30);
            this.txtCPU.TabIndex = 3;
            this.txtCPU.Text = "Intel core i7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPU";
            // 
            // txtHardDisk
            // 
            this.txtHardDisk.Location = new System.Drawing.Point(221, 108);
            this.txtHardDisk.Name = "txtHardDisk";
            this.txtHardDisk.Size = new System.Drawing.Size(427, 30);
            this.txtHardDisk.TabIndex = 1;
            this.txtHardDisk.Text = "SamSung SSD Evo 980";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(221, 151);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(427, 30);
            this.txtRam.TabIndex = 1;
            this.txtRam.Text = "Corsair DDR4 32GB";
            // 
            // txtVGA
            // 
            this.txtVGA.Location = new System.Drawing.Point(221, 202);
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(427, 30);
            this.txtVGA.TabIndex = 1;
            this.txtVGA.Text = "CoirSair";
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(221, 248);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(427, 30);
            this.txtMonitor.TabIndex = 1;
            this.txtMonitor.Text = "Dell Utral 4K";
            // 
            // txtMSMay
            // 
            this.txtMSMay.Location = new System.Drawing.Point(221, 23);
            this.txtMSMay.Name = "txtMSMay";
            this.txtMSMay.Size = new System.Drawing.Size(427, 30);
            this.txtMSMay.TabIndex = 1;
            this.txtMSMay.Text = "A11       ";
            this.txtMSMay.TextChanged += new System.EventHandler(this.txtMSMay_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "VGA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "HardDisk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số máy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrMayTinh);
            this.groupBox2.Location = new System.Drawing.Point(315, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng máy";
            // 
            // dgrMayTinh
            // 
            this.dgrMayTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMayTinh.Location = new System.Drawing.Point(20, 29);
            this.dgrMayTinh.Name = "dgrMayTinh";
            this.dgrMayTinh.RowHeadersWidth = 51;
            this.dgrMayTinh.RowTemplate.Height = 24;
            this.dgrMayTinh.Size = new System.Drawing.Size(628, 166);
            this.dgrMayTinh.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trePhong);
            this.groupBox1.Location = new System.Drawing.Point(-3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 545);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DS Phòng Máy";
            // 
            // trePhong
            // 
            this.trePhong.Location = new System.Drawing.Point(6, 51);
            this.trePhong.Name = "trePhong";
            this.trePhong.Size = new System.Drawing.Size(287, 479);
            this.trePhong.TabIndex = 0;
            this.trePhong.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trePhong_AfterSelect);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(59, 560);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(163, 50);
            this.btnThemPhong.TabIndex = 8;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(291, 656);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(195, 38);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(520, 656);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(195, 38);
            this.btnXoaTrang.TabIndex = 10;
            this.btnXoaTrang.Text = "Xoá trắng thêm mới";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(743, 656);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(195, 38);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.UseVisualStyleBackColor = true;

            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(976, 656);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(195, 38);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmQuanLyPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 730);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyPhongMay";
            this.Text = "Quản Lý Phòng Máy";
            this.Load += new System.EventHandler(this.frmQuanLyPhongMay_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMayTinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHardDisk;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.TextBox txtMSMay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrMayTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView trePhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imageList;
    }
}

