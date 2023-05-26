using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong: DayPhong
    {
        string tenPhong;
        int maPhong;
        int tang;
        int soGiuong = 8;
        int soSv;
        static int giaPhong = 300000;
        public Phong()
        {

        }
        public Phong(int maPhong, int tang, string tenPhong, int SoGiuong = 0, int soSv = 0)
        {
            this.maPhong = maPhong;
            this.tang = tang;
            this.TenPhong = tenPhong;
            this.soGiuong = SoGiuong;
            this.SoSv = soSv;
        }
        public Phong(string tenPhong)
        {
            if(tenPhong.Length == 0)
            {
                return;
            }
            this.MaDay = int.Parse(tenPhong[0].ToString());
            this.tang = int.Parse(tenPhong[1].ToString());
            this.MaPhong = int.Parse(tenPhong.Substring(2));
            tenPhong = tenPhong;
        }

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public static int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int SoGiuong { get => soGiuong; set => soGiuong = value; }
        public int SoSv { get => soSv; set => soSv = value; }
        public int TinhTien()
        {
            return giaPhong * soSv;
        }
    }
}
