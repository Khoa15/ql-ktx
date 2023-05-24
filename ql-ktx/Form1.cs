using System;
using System.Windows.Forms;
using DTO;
using BLL;
namespace ql_ktx
{
    public partial class mainFormKTX : Form
    {
        public mainFormKTX()
        {
            InitializeComponent();
        }

        private void mainFormKTX_Load(object sender, EventArgs e)
        {
            SinhVien_BLL SinhVien = new SinhVien_BLL();
            dataGridViewSinhVien.DataSource = SinhVien.Load();
        }
    }
}
