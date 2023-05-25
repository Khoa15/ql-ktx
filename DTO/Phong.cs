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
        static int giaPhong = 300000;
        public Phong()
        {

        }
        public Phong(int maPhong, int tang, string tenPhong)
        {
            this.maPhong = maPhong;
            this.tang = tang;
            this.TenPhong = tenPhong;
        }
        public Phong(string tenPhong)
        {
            string[] tenPhong_ = tenPhong.Split('.');
            this.tang = int.Parse(tenPhong_[1].ElementAt(0).ToString());
            this.maPhong = int.Parse(tenPhong_[1].Remove(0, 1).ToString());
            this.MaDay = int.Parse(tenPhong_[0]);
        }

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public static int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }

    }
}
