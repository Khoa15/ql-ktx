using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nuoc: DichVu
    {
        public Nuoc()
        {
            GiaTien = 3000;
        }
        public override double TinhTien()
        {
            return GiaTien * (ChiSoMoi - ChiSoCu);
        }
    }
}
