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
        public List<HopDong> Load(Phong phong)
        {
            return hopDong.Load(phong);
        }
        public int Save(HopDong hd)
        {
            if (hd == null) return 0;
            Phong_DAL phong_dal = new Phong_DAL();
            List<Phong> dsPhong = phong_dal.Load();
            var t = hd.TenPhong;
            if (dsPhong.Exists(phong => hd.TenPhong == phong.TenPhong && phong.SoGiuong > phong.SoSv + 1) == false)
            {
                return 0;
            }
            SinhVien_DAL sinhVien_dal = new SinhVien_DAL();
            List<SinhVien> dsSinhVien = sinhVien_dal.Load();
            if(dsSinhVien.Exists(sv => hd.MaSV == sv.MaSV) == false)
            {
                sinhVien_dal.Insert(hd);
            }
            phong_dal = null;
            return hopDong.Save(hd);
        }
    }
}
