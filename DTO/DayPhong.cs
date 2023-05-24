using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DayPhong
    {
        int maDay;
        string tenDay;

        public DayPhong() { }

        public DayPhong(int maDay, string tenDay)
        {
            this.maDay = maDay;
            this.tenDay = tenDay;
        }

        public int MaDay { get => maDay; set => maDay = value; }
        public string TenDay { get => tenDay; set => tenDay = value; }
    }
}
