using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class DichVu : Phong
    {
        private int ma;
        private int chiSoCu;
        private int chiSoMoi;
        private double giaTien;

        protected int ChiSoCu { get => chiSoCu; set => chiSoCu = value; }
        protected int ChiSoMoi
        {
            get => chiSoMoi;
            set
            {
                if(value < ChiSoCu) return;
                chiSoMoi = value;
            }
        }
        protected double GiaTien { get => giaTien; set => giaTien = value; }
        public DichVu() { }
        public abstract double TinhTien();
    }
}
