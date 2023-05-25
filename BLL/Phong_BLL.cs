using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class Phong_BLL
    {
        Phong_DAL phong_dal = new Phong_DAL();
        public Phong_BLL()
        {

        }
        public List<Phong> Load()
        {
            return phong_dal.Load();
        }
    }
}
