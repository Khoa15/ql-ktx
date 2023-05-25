using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThai
    {
        int maTrangThai;
        string tenTrangThai;
        Enum<int, string> trangThai;
        
        public TrangThai()
        {

        }

        public int MaTrangThai
        {
            get => maTrangThai;
            set
            {
                if(maTrangThai == 0)
                {
                    tenTrangThai = "Chờ cọc";
                }else if(maTrangThai == 1)
                {
                    tenTrangThai = "Đang ở";
                }else if(maTrangThai == 2)
                {
                    tenTrangThai = "Hết hạn";
                }
                maTrangThai = value;
            }
        }
        public string TenTrangThai { get => tenTrangThai;}
    }
}
