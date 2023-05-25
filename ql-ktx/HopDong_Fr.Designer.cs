namespace ql_ktx
{
    partial class HopDong_Fr
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
            this.dataGridView_HopDong = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimHopDong = new System.Windows.Forms.Button();
            this.textBox_TimHopDong = new System.Windows.Forms.TextBox();
            this.btn_ThemHopDong = new System.Windows.Forms.Button();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_CapNhatHopDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HopDong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_HopDong
            // 
            this.dataGridView_HopDong.AllowUserToAddRows = false;
            this.dataGridView_HopDong.AllowUserToDeleteRows = false;
            this.dataGridView_HopDong.AutoGenerateColumns = false;
            this.dataGridView_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.maPhongDataGridViewTextBoxColumn,
            this.TenPhong,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridView_HopDong.DataSource = this.hopDongBindingSource;
            this.dataGridView_HopDong.Location = new System.Drawing.Point(3, 32);
            this.dataGridView_HopDong.Name = "dataGridView_HopDong";
            this.dataGridView_HopDong.ReadOnly = true;
            this.dataGridView_HopDong.Size = new System.Drawing.Size(646, 391);
            this.dataGridView_HopDong.TabIndex = 1;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_CapNhatHopDong);
            this.panel1.Controls.Add(this.btn_TimHopDong);
            this.panel1.Controls.Add(this.textBox_TimHopDong);
            this.panel1.Controls.Add(this.btn_ThemHopDong);
            this.panel1.Controls.Add(this.dataGridView_HopDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 426);
            this.panel1.TabIndex = 2;
            // 
            // btn_TimHopDong
            // 
            this.btn_TimHopDong.Location = new System.Drawing.Point(574, 4);
            this.btn_TimHopDong.Name = "btn_TimHopDong";
            this.btn_TimHopDong.Size = new System.Drawing.Size(75, 23);
            this.btn_TimHopDong.TabIndex = 4;
            this.btn_TimHopDong.Text = "Tìm kiếm";
            this.btn_TimHopDong.UseVisualStyleBackColor = true;
            // 
            // textBox_TimHopDong
            // 
            this.textBox_TimHopDong.Location = new System.Drawing.Point(166, 4);
            this.textBox_TimHopDong.Name = "textBox_TimHopDong";
            this.textBox_TimHopDong.Size = new System.Drawing.Size(402, 20);
            this.textBox_TimHopDong.TabIndex = 3;
            // 
            // btn_ThemHopDong
            // 
            this.btn_ThemHopDong.Location = new System.Drawing.Point(3, 3);
            this.btn_ThemHopDong.Name = "btn_ThemHopDong";
            this.btn_ThemHopDong.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemHopDong.TabIndex = 2;
            this.btn_ThemHopDong.Text = "Thêm";
            this.btn_ThemHopDong.UseVisualStyleBackColor = true;
            this.btn_ThemHopDong.Click += new System.EventHandler(this.btnAddHopDong_Click);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã SV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
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
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "Mã Phòng";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "Ngày Bắt Đầu";
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            this.ngayBatDauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày Hết Hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hopDongBindingSource
            // 
            this.hopDongBindingSource.DataSource = typeof(DTO.HopDong);
            // 
            // button_CapNhatHopDong
            // 
            this.button_CapNhatHopDong.Location = new System.Drawing.Point(84, 3);
            this.button_CapNhatHopDong.Name = "button_CapNhatHopDong";
            this.button_CapNhatHopDong.Size = new System.Drawing.Size(75, 23);
            this.button_CapNhatHopDong.TabIndex = 5;
            this.button_CapNhatHopDong.Text = "Cập Nhật";
            this.button_CapNhatHopDong.UseVisualStyleBackColor = true;
            this.button_CapNhatHopDong.Click += new System.EventHandler(this.button_CapNhatHopDong_Click);
            // 
            // HopDong_Fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 426);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HopDong_Fr";
            this.Text = "HopDong_Fr";
            this.Load += new System.EventHandler(this.HopDong_Fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HopDong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hopDongBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_HopDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ThemHopDong;
        private System.Windows.Forms.Button btn_TimHopDong;
        private System.Windows.Forms.TextBox textBox_TimHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_CapNhatHopDong;
    }
}