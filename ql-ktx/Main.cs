using System;
using System.Windows.Forms;
using DTO;
using BLL;
namespace ql_ktx
{
    public partial class mainFormKTX : Form
    {
        private Form currentForm;
        public mainFormKTX()
        {
            InitializeComponent();
        }

        private void mainFormKTX_Load(object sender, EventArgs e)
        {
            SinhVien_BLL SinhVien = new SinhVien_BLL();
            dataGridViewSinhVien.DataSource = SinhVien.Load();
        }
        void OpenForm(Form fr)
        {
            if(currentForm!= null)
            {
                currentForm.Close();
            }
            currentForm = fr;
            fr.TopLevel = false;
            fr.FormBorderStyle= FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Height = 656;
            fr.Width = 426;
            panelBody.Controls.Add(fr);
            panelBody.Tag = fr;
            fr.BringToFront();
            fr.Show();
        }
        private void btnNaviHopDong_Click(object sender, EventArgs e)
        {
            OpenForm(new HopDong_Fr());
        }

        private void btnNaviSinhVien_Click(object sender, EventArgs e)
        {
            //OpenForm(new SinhVien_Fr());
            if (currentForm != null)
            {
                currentForm.Close();
            }
        }

        private void btnDayPhong_Click(object sender, EventArgs e)
        {
            OpenForm(new DayPhong_Fr());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenForm(new Phong_Fr());
        }
    }
}
