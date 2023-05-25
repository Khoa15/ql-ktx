using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        string ma;
        string ten;
        string sdt;
        string hoTen;
        string diaChi;
        public NhaCungCap()
        {

        }

        public NhaCungCap(string ten, string sdt, string hoTen, string diaChi)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
