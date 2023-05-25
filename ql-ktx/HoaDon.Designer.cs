namespace ql_ktx
{
    partial class HoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHopDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGiuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 236);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn,
            this.ngayCapDataGridViewTextBoxColumn,
            this.maHopDongDataGridViewTextBoxColumn,
            this.maDichVuDataGridViewTextBoxColumn,
            this.ngayThanhToanDataGridViewTextBoxColumn,
            this.maPhongDataGridViewTextBoxColumn,
            this.tangDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.soGiuongDataGridViewTextBoxColumn,
            this.soSvDataGridViewTextBoxColumn,
            this.maDayDataGridViewTextBoxColumn,
            this.tenDayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(DTO.HoaDon);
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "Ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "Ma";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "Tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Tongtien";
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            // 
            // maHopDongDataGridViewTextBoxColumn
            // 
            this.maHopDongDataGridViewTextBoxColumn.DataPropertyName = "Ma_HopDong";
            this.maHopDongDataGridViewTextBoxColumn.HeaderText = "Ma_HopDong";
            this.maHopDongDataGridViewTextBoxColumn.Name = "maHopDongDataGridViewTextBoxColumn";
            // 
            // maDichVuDataGridViewTextBoxColumn
            // 
            this.maDichVuDataGridViewTextBoxColumn.DataPropertyName = "Ma_DichVu";
            this.maDichVuDataGridViewTextBoxColumn.HeaderText = "Ma_DichVu";
            this.maDichVuDataGridViewTextBoxColumn.Name = "maDichVuDataGridViewTextBoxColumn";
            // 
            // ngayThanhToanDataGridViewTextBoxColumn
            // 
            this.ngayThanhToanDataGridViewTextBoxColumn.DataPropertyName = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.HeaderText = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.Name = "ngayThanhToanDataGridViewTextBoxColumn";
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            // 
            // tangDataGridViewTextBoxColumn
            // 
            this.tangDataGridViewTextBoxColumn.DataPropertyName = "Tang";
            this.tangDataGridViewTextBoxColumn.HeaderText = "Tang";
            this.tangDataGridViewTextBoxColumn.Name = "tangDataGridViewTextBoxColumn";
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            // 
            // soGiuongDataGridViewTextBoxColumn
            // 
            this.soGiuongDataGridViewTextBoxColumn.DataPropertyName = "SoGiuong";
            this.soGiuongDataGridViewTextBoxColumn.HeaderText = "SoGiuong";
            this.soGiuongDataGridViewTextBoxColumn.Name = "soGiuongDataGridViewTextBoxColumn";
            // 
            // soSvDataGridViewTextBoxColumn
            // 
            this.soSvDataGridViewTextBoxColumn.DataPropertyName = "SoSv";
            this.soSvDataGridViewTextBoxColumn.HeaderText = "SoSv";
            this.soSvDataGridViewTextBoxColumn.Name = "soSvDataGridViewTextBoxColumn";
            // 
            // maDayDataGridViewTextBoxColumn
            // 
            this.maDayDataGridViewTextBoxColumn.DataPropertyName = "MaDay";
            this.maDayDataGridViewTextBoxColumn.HeaderText = "MaDay";
            this.maDayDataGridViewTextBoxColumn.Name = "maDayDataGridViewTextBoxColumn";
            // 
            // tenDayDataGridViewTextBoxColumn
            // 
            this.tenDayDataGridViewTextBoxColumn.DataPropertyName = "TenDay";
            this.tenDayDataGridViewTextBoxColumn.HeaderText = "TenDay";
            this.tenDayDataGridViewTextBoxColumn.Name = "tenDayDataGridViewTextBoxColumn";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHopDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGiuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
    }
}