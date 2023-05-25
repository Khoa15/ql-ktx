using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu : Phong
    {
        private int ma;
        private bool loai;// {0: dien, 1: nuoc}
        private int chiSoCu;
        private int chiSoMoi;
        private double giaTien;

        public int ChiSoCu { get => chiSoCu; set => chiSoCu = value; }
        public int ChiSoMoi
        {
            get => chiSoMoi;
            set
            {
                if(value < ChiSoCu) return;
                chiSoMoi = value;
            }
        }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public bool Loai { get => loai; set => loai = value; }

        public DichVu() { }
        public double TinhTien()
        {
            return giaTien * (chiSoMoi - chiSoCu);
        }
    }
}
