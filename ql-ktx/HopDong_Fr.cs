using System;
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
    public partial class HopDong_Fr : Form
    {
        public HopDong_Fr()
        {
            InitializeComponent();
        }

        private void btnAddHopDong_Click(object sender, EventArgs e)
        {
            ThemHopDong_Fr themHopDong = new ThemHopDong_Fr();
            themHopDong.Show();
        }

        private void HopDong_Fr_Load(object sender, EventArgs e)
        {
            HopDong_BLL hopdong_bll = new HopDong_BLL();
            dataGridView_HopDong.DataSource = hopdong_bll.Load();
        }
    }
}
