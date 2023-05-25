using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mang
    {
        static int gia = 300000;
        public Mang() { }

        public static int Gia { get => gia; set => gia = value; }
    }
}
