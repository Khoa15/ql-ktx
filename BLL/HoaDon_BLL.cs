using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net.Mail;
using System.Net;

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
        public bool SendMail(List<HopDong> dsHopDong)
        {
            SmtpClient client = new SmtpClient("smtp.office365.com");

            client.Port = 587;

            client.Credentials = new NetworkCredential("nguyenkhoa72@outlook.com", "bY!7)-L_32/ChsvFymwPq:FN^3Q,\"\\\"Fb=4BnLq~'JG\"vs}XuLCa_H9'SF)6tt\\tF67%!V2LajFs<tBc!EL-\\FbU>VUm2sSR_Fq{>[.NRZ~=p6{y:+Yf>x*]wwWkA$A}d\\p8aVLysA#{}\"ZhB>B8KPe&xRGX8Z#Y^sX2F`CLRH&UKsud%R6Z/?&5@c-:juw+,.U+\\.p~KKxqZ()zQ%pc&$t/m_FEx2kh2v'SZu2h'@C?g]sT3G^EZ*g.$BZp+nH2C'BrR,hLXsF_~\\Q9q>fA;:a3Kn)LTz;j*M&:j,QtX+keE<e`;G7e(+z2KC7Vwu)z+nH[LvR\\,kZ#)as)83t9\"jvUf&QwuL%;=y'sf')}Kt9:C=Q]<SgHaY7m&R94nM_2wW8$VWaVP'dj#)55cKk*K,%^aR.Lya46KJF'`nX97W@/!X%P\"G^&y^$XC=E@_6,'zZf\\;wks3Y:6nR?pbJj;22K?@MDJ4GWv\"H&z)4vu,!@3M/^<c,DQp2HyuhPLp<&4k)&NT4D8f4?;Kr/\"4P},7z:`:FA9L/Hr`D}U@K{dL4vULycm4H;dCB2^S!\\'/))dW}354_:fbA'?AA]#.#YW?V_]>WB:#\"+c]fBs#Q:b)gug!A};_)r8?K7C&vRDw@RThUhY3rJH+yhV'Sn8F\"v{}x_cB~;Ceg![/,h-(8<^Q22W#(]@6`UEH!C=9CW8?9_=LT$hJ[dYE?N%\"KY\"b&(JQ,C)tKHn[f\\VMsdv[zt`PLtymwmR##92@xnw$zM+xv/jzQf`@8bgf-~=>6qhtS>&GC%uHu'`)@<FsWAaQZ8Xb.cMj\"ac9$v@E[+NW'pg=:vA!j$-NW.\"fRLA}-=dPL#:ShV)g,m'XX$}mj`{QM@?U2KbajT`MJwZep&Hs&4bd^r_ghv){&+7k%~fm##a,dd]?&-{RDy{4%~X9Cbh5HYx*}E-z}R9fx%k^fz{a^T!WA)%jkhq75}&`Fh/)['8u4J_x/V3X(E+yLsYqzkSdS}t`JJ[]P3W'C7(Ey^9Y[Y`@P)+");

            client.EnableSsl = true;

            MailMessage message = new MailMessage();

            message.From = new MailAddress("nguyenkhoa72@outlook.com");
            List<string> emails = dsHopDong.Select(hd => hd.Email).ToList();
            emails.ForEach(email =>
            {
                message.To.Add(new MailAddress(email));
            });
            //message.To.Add(new MailAddress("nguyentrongdangkhoa15@gmail.com"));

            message.Subject = "This is a test email";
            message.Priority = MailPriority.High;
            message.Body = "<h1>This is the body of the email.</h1>";
            message.IsBodyHtml = true;
            client.Send(message);

            return true;
        }
        public bool Save(List<HopDong> DsHopDong, List<HoaDon> DsHoaDon)
        {
            var x = DsHopDong;
            var y = DsHoaDon;
            return true;
        }
    }
}
