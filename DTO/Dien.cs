using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dien: DichVu
    {
        public Dien()
        {
            GiaTien = 2000;
        }
        public override double TinhTien()
        {
            return GiaTien * (ChiSoMoi - ChiSoCu);
        }
    }
}
