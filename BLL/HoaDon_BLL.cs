using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class HoaDon_BLL
    {
        HoaDon_DAL hoaDon_DAL = new HoaDon_DAL();
        public HoaDon_BLL()
        {

        }
        public List<HoaDon> Load()
        {
            return hoaDon_DAL.Load();
        }
        public List<HoaDon> Load(int MaPhong, int MaDay, int Tang)
        {
            return hoaDon_DAL.Load(MaPhong, MaDay, Tang);
        }
        public List<HoaDon> Load(Phong phong)
        {
            return this.Load(phong.MaPhong, phong.MaDay, phong.Tang);
        }
    }
}
