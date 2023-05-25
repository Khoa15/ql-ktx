namespace ql_ktx
{
    partial class mainFormKTX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavi = new System.Windows.Forms.Panel();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDayPhong = new System.Windows.Forms.Button();
            this.btnNaviHopDong = new System.Windows.Forms.Button();
            this.btnNaviSinhVien = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_TimSinhVien = new System.Windows.Forms.TextBox();
            this.comboBox_TimSinhVien = new System.Windows.Forms.ComboBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.button_NaviHoaDon = new System.Windows.Forms.Button();
            this.button_NaviNhaCungCap = new System.Windows.Forms.Button();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelNavi.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavi
            // 
            this.panelNavi.Controls.Add(this.button_NaviNhaCungCap);
            this.panelNavi.Controls.Add(this.button_NaviHoaDon);
            this.panelNavi.Controls.Add(this.btnPhong);
            this.panelNavi.Controls.Add(this.btnDayPhong);
            this.panelNavi.Controls.Add(this.btnNaviHopDong);
            this.panelNavi.Controls.Add(this.btnNaviSinhVien);
            this.panelNavi.Location = new System.Drawing.Point(12, 12);
            this.panelNavi.Name = "panelNavi";
            this.panelNavi.Size = new System.Drawing.Size(117, 426);
            this.panelNavi.TabIndex = 0;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(3, 123);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(111, 34);
            this.btnPhong.TabIndex = 3;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnDayPhong
            // 
            this.btnDayPhong.Location = new System.Drawing.Point(3, 83);
            this.btnDayPhong.Name = "btnDayPhong";
            this.btnDayPhong.Size = new System.Drawing.Size(111, 34);
            this.btnDayPhong.TabIndex = 2;
            this.btnDayPhong.Text = "Dãy Phòng";
            this.btnDayPhong.UseVisualStyleBackColor = true;
            this.btnDayPhong.Click += new System.EventHandler(this.btnDayPhong_Click);
            // 
            // btnNaviHopDong
            // 
            this.btnNaviHopDong.Location = new System.Drawing.Point(3, 43);
            this.btnNaviHopDong.Name = "btnNaviHopDong";
            this.btnNaviHopDong.Size = new System.Drawing.Size(111, 34);
            this.btnNaviHopDong.TabIndex = 1;
            this.btnNaviHopDong.Text = "Hợp Đồng";
            this.btnNaviHopDong.UseVisualStyleBackColor = true;
            this.btnNaviHopDong.Click += new System.EventHandler(this.btnNaviHopDong_Click);
            // 
            // btnNaviSinhVien
            // 
            this.btnNaviSinhVien.Location = new System.Drawing.Point(3, 3);
            this.btnNaviSinhVien.Name = "btnNaviSinhVien";
            this.btnNaviSinhVien.Size = new System.Drawing.Size(111, 34);
            this.btnNaviSinhVien.TabIndex = 0;
            this.btnNaviSinhVien.Text = "Sinh Viên";
            this.btnNaviSinhVien.UseVisualStyleBackColor = true;
            this.btnNaviSinhVien.Click += new System.EventHandler(this.btnNaviSinhVien_Click);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.button1);
            this.panelBody.Controls.Add(this.textBox_TimSinhVien);
            this.panelBody.Controls.Add(this.comboBox_TimSinhVien);
            this.panelBody.Controls.Add(this.dataGridViewSinhVien);
            this.panelBody.Location = new System.Drawing.Point(136, 12);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(652, 426);
            this.panelBody.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_TimSinhVien
            // 
            this.textBox_TimSinhVien.Location = new System.Drawing.Point(133, 4);
            this.textBox_TimSinhVien.Name = "textBox_TimSinhVien";
            this.textBox_TimSinhVien.Size = new System.Drawing.Size(429, 20);
            this.textBox_TimSinhVien.TabIndex = 2;
            // 
            // comboBox_TimSinhVien
            // 
            this.comboBox_TimSinhVien.FormattingEnabled = true;
            this.comboBox_TimSinhVien.Items.AddRange(new object[] {
            "Mã SV",
            "Họ và tên",
            "Lớp"});
            this.comboBox_TimSinhVien.Location = new System.Drawing.Point(4, 4);
            this.comboBox_TimSinhVien.Name = "comboBox_TimSinhVien";
            this.comboBox_TimSinhVien.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TimSinhVien.TabIndex = 1;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AllowUserToAddRows = false;
            this.dataGridViewSinhVien.AllowUserToDeleteRows = false;
            this.dataGridViewSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSinhVien.AutoGenerateColumns = false;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn});
            this.dataGridViewSinhVien.DataSource = this.sinhVienBindingSource;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.ReadOnly = true;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(646, 391);
            this.dataGridViewSinhVien.TabIndex = 0;
            // 
            // button_NaviHoaDon
            // 
            this.button_NaviHoaDon.Location = new System.Drawing.Point(3, 163);
            this.button_NaviHoaDon.Name = "button_NaviHoaDon";
            this.button_NaviHoaDon.Size = new System.Drawing.Size(111, 34);
            this.button_NaviHoaDon.TabIndex = 4;
            this.button_NaviHoaDon.Text = "Hóa Đơn";
            this.button_NaviHoaDon.UseVisualStyleBackColor = true;
            // 
            // button_NaviNhaCungCap
            // 
            this.button_NaviNhaCungCap.Location = new System.Drawing.Point(3, 203);
            this.button_NaviNhaCungCap.Name = "button_NaviNhaCungCap";
            this.button_NaviNhaCungCap.Size = new System.Drawing.Size(111, 34);
            this.button_NaviNhaCungCap.TabIndex = 5;
            this.button_NaviNhaCungCap.Text = "Nhà Cung Cấp";
            this.button_NaviNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.ngaySinhDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "Nữ";
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(DTO.SinhVien);
            // 
            // sinhVienBindingSource1
            // 
            this.sinhVienBindingSource1.DataSource = typeof(DTO.SinhVien);
            // 
            // mainFormKTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelNavi);
            this.Name = "mainFormKTX";
            this.Text = "Quản lý ký túc xá";
            this.Load += new System.EventHandler(this.mainFormKTX_Load);
            this.panelNavi.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavi;
        private System.Windows.Forms.Button btnNaviSinhVien;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.Button btnNaviHopDong;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDayPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_TimSinhVien;
        private System.Windows.Forms.ComboBox comboBox_TimSinhVien;
        private System.Windows.Forms.BindingSource sinhVienBindingSource1;
        private System.Windows.Forms.Button button_NaviNhaCungCap;
        private System.Windows.Forms.Button button_NaviHoaDon;
    }
}

