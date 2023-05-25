using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DayPhong_BLL
    {
        DayPhong_DAL dayPhong_dal = new DayPhong_DAL();
        public DayPhong_BLL()
        {

        }
        public List<DayPhong> Load()
        {
            return dayPhong_dal.Load();
        }
    }
}
