﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace ql_ktx
{
    public partial class Phong_Fr : Form
    {
        public Phong_Fr()
        {
            InitializeComponent();
        }

        private void Phong_Fr_Load(object sender, EventArgs e)
        {
            Phong_BLL phong = new Phong_BLL();
            dataGridViewPhong.DataSource = phong.Load();
            phong = null;
        }

        private void dataGridViewPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dataGridViewPhong.Columns[e.ColumnIndex].HeaderText;
            if(x == "Xem")
            {
                XemPhong_Fr xemPhong = new XemPhong_Fr(dataGridViewPhong.CurrentRow);
                xemPhong.Show();
            }
        }

    }
}
