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
    public partial class DayPhong_Fr : Form
    {
        public DayPhong_Fr()
        {
            InitializeComponent();
        }

        private void DayPhong_Fr_Load(object sender, EventArgs e)
        {
            DayPhong_BLL dayPhong_bll = new DayPhong_BLL();
            dataGridView_DayPhong.DataSource = dayPhong_bll.Load();
        }
    }
}
