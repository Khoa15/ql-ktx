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
        List<HopDong> dsHopDong;
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
            dsHopDong = hopdong_bll.Load();
            loadDataGridView_HopDong(dsHopDong);
        }

        private void button_CapNhatHopDong_Click(object sender, EventArgs e)
        {
            dsHopDong.ForEach(hopDong =>
            {
                if(hopDong.NgayHetHan < DateTime.Now)
                {
                    hopDong.TrangThai = 3;
                }
            });
            loadDataGridView_HopDong(dsHopDong);
        }

        private void loadDataGridView_HopDong(List<HopDong> DSHopDong)
        {
            dataGridView_HopDong.Refresh();
            dataGridView_HopDong.DataSource = dsHopDong;
        }
    }
}
