namespace ql_ktx
{
    partial class Phong_Fr
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
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 221);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.AllowUserToAddRows = false;
            this.dataGridViewPhong.AllowUserToDeleteRows = false;
            this.dataGridViewPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPhong.AutoGenerateColumns = false;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tangDataGridViewTextBoxColumn,
            this.maDayDataGridViewTextBoxColumn,
            this.tenDayDataGridViewTextBoxColumn,
            this.TenPhong});
            this.dataGridViewPhong.DataSource = this.phongBindingSource;
            this.dataGridViewPhong.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.ReadOnly = true;
            this.dataGridViewPhong.Size = new System.Drawing.Size(463, 215);
            this.dataGridViewPhong.TabIndex = 0;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "Mã Phòng";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tangDataGridViewTextBoxColumn
            // 
            this.tangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tangDataGridViewTextBoxColumn.DataPropertyName = "Tang";
            this.tangDataGridViewTextBoxColumn.HeaderText = "Tầng";
            this.tangDataGridViewTextBoxColumn.Name = "tangDataGridViewTextBoxColumn";
            this.tangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maDayDataGridViewTextBoxColumn
            // 
            this.maDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maDayDataGridViewTextBoxColumn.DataPropertyName = "MaDay";
            this.maDayDataGridViewTextBoxColumn.HeaderText = "Mã Dãy";
            this.maDayDataGridViewTextBoxColumn.Name = "maDayDataGridViewTextBoxColumn";
            this.maDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDayDataGridViewTextBoxColumn
            // 
            this.tenDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDayDataGridViewTextBoxColumn.DataPropertyName = "TenDay";
            this.tenDayDataGridViewTextBoxColumn.HeaderText = "Tên Dãy";
            this.tenDayDataGridViewTextBoxColumn.Name = "tenDayDataGridViewTextBoxColumn";
            this.tenDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(DTO.Phong);
            // 
            // phongBindingSource1
            // 
            this.phongBindingSource1.DataSource = typeof(DTO.Phong);
            // 
            // Phong_Fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 221);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong_Fr";
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Fr_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.BindingSource phongBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
    }
}