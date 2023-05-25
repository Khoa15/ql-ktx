using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class HopDong_BLL
    {
        HopDong_DAL hopDong = new HopDong_DAL();
        public HopDong_BLL()
        {

        }
        public List<HopDong> Load()
        {
            return hopDong.Load();
        }
        public int Save(HopDong hd)
        {
            return hopDong.Save(hd);
        }
    }
}
