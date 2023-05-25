using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SinhVien_BLL
    {
        SinhVien_DAL SinhVien = new SinhVien_DAL();
        public SinhVien_BLL() { }
        public List<SinhVien> Load()
        {
            return SinhVien.Load();
        }
        public List<SinhVien> Load(Phong phong)
        {
            List<SinhVien> dsSinhVien = SinhVien.Load(phong);
            
            return SinhVien.Load(phong);
        }
    }
}
