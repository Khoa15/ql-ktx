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
            ThemSuaHopDong_Fr themHopDong = new ThemSuaHopDong_Fr();
            themHopDong.Show();
        }

        private void HopDong_Fr_Load(object sender, EventArgs e)
        {
            HopDong_BLL hopdong_bll = new HopDong_BLL();
            dsHopDong = hopdong_bll.Load();
            hopdong_bll = null;
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
            dataGridView_HopDong.DataSource = DSHopDong;
        }

        private void dataGridView_HopDong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HopDong hd = dataGridView_HopDong.CurrentRow.DataBoundItem as HopDong;
            hd = dsHopDong.First(h => h.MaHD == hd.MaHD);
            ThemSuaHopDong_Fr themHopDong_Fr = new ThemSuaHopDong_Fr(hd);
            themHopDong_Fr.Show();
        }

        private void btn_TimHopDong_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox_TimHopDong.Text);
            loadDataGridView_HopDong(dsHopDong.Where(hd => hd.MaHD == t).ToList());
        }
    }
}
