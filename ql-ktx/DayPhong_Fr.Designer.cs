﻿namespace ql_ktx
{
    partial class DayPhong_Fr
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
            this.dataGridView_DayPhong = new System.Windows.Forms.DataGridView();
            this.maDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DayPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_DayPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 233);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_DayPhong
            // 
            this.dataGridView_DayPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DayPhong.AutoGenerateColumns = false;
            this.dataGridView_DayPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DayPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDayDataGridViewTextBoxColumn,
            this.tenDayDataGridViewTextBoxColumn});
            this.dataGridView_DayPhong.DataSource = this.dayPhongBindingSource;
            this.dataGridView_DayPhong.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_DayPhong.Name = "dataGridView_DayPhong";
            this.dataGridView_DayPhong.Size = new System.Drawing.Size(534, 227);
            this.dataGridView_DayPhong.TabIndex = 0;
            // 
            // maDayDataGridViewTextBoxColumn
            // 
            this.maDayDataGridViewTextBoxColumn.DataPropertyName = "MaDay";
            this.maDayDataGridViewTextBoxColumn.HeaderText = "Mã Dãy";
            this.maDayDataGridViewTextBoxColumn.Name = "maDayDataGridViewTextBoxColumn";
            // 
            // tenDayDataGridViewTextBoxColumn
            // 
            this.tenDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDayDataGridViewTextBoxColumn.DataPropertyName = "TenDay";
            this.tenDayDataGridViewTextBoxColumn.HeaderText = "Tên Dãy";
            this.tenDayDataGridViewTextBoxColumn.Name = "tenDayDataGridViewTextBoxColumn";
            // 
            // dayPhongBindingSource
            // 
            this.dayPhongBindingSource.DataSource = typeof(DTO.DayPhong);
            // 
            // DayPhong_Fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 233);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DayPhong_Fr";
            this.Text = "DayPhong_Fr";
            this.Load += new System.EventHandler(this.DayPhong_Fr_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DayPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPhongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_DayPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dayPhongBindingSource;
    }
}