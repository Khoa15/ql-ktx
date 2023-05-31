using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

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
        public bool SendMail(List<HopDong> dsHopDong, List<HoaDon> dsHoaDon, int TongTien)
        {
            SmtpClient client = new SmtpClient("smtp.office365.com");

            client.Port = 587;

            client.Credentials = new NetworkCredential("email", "email");

            client.EnableSsl = true;

            MailMessage message = new MailMessage();

            message.From = new MailAddress("email");
            List<string> emails = dsHopDong.Select(hd => hd.Email).ToList();
            emails.ForEach(email =>
            {
                message.To.Add(new MailAddress(email));
            });
            //message.To.Add(new MailAddress("nguyentrongdangkhoa15@gmail.com"));

            message.Subject = "HOA DON";
            message.Priority = MailPriority.High;
            string html = "";
            dsHopDong.ForEach(hd =>
            {
                html += Node("Mã", hd.MaSV.ToString());
                html += Node("Họ và tên", hd.HoTen);
                html += Node("Lớp", hd.Lop);
            });
            dsHoaDon.ForEach((hd) =>
            {
                if(hd.Loai == true)
                {
                    html += Node("Loại", "Nước");
                }
                else
                {
                    html += Node("Loại", "Điện");
                }
                html += Node("Chỉ số cũ: ", hd.ChiSoCu.ToString());
                html += Node("Chỉ số mới: ", hd.ChiSoMoi.ToString());
                html += Node("Thành tiền: ", hd.Tongtien.ToString());
            });

            html += Node("Wifi: ", Mang.Gia.ToString());

            html += Node("Số người: ", dsHopDong.Count().ToString());
            html += Node("Tiền phòng: ", Phong.GiaPhong.ToString());
            html += Node("Tổng cộng: ", TongTien.ToString());

            message.Body = html;
            message.IsBodyHtml = true;
            client.Send(message);

            return true;
        }
        private string Node(string field, string value)
        {
            return $"<p><strong>{field}:</strong> {value}</p>";
        }
        public bool Save(List<HopDong> DsHopDong, List<HoaDon> DsHoaDon)
        {
            var x = DsHopDong;
            var y = DsHoaDon;
            string sql = "";
            DsHoaDon.ForEach(hoaDon =>
            {
                DsHoaDon.ForEach(hd =>
                {
                    sql += $"INSERT INTO HOADON (MA_HOPDONG, MA_DICHVU, LOAI, TONGTIEN, NGAYCAP) VALUES ({hoaDon.Ma_HopDong}, {hd.Ma_DichVu}, {hd.Loai}, {hd.Tongtien}, '{DateTime.Now.ToShortDateString()}');";
                });
            });
            Database db = new Database();
            db.Conn.Open();
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            int result = cmd.ExecuteNonQuery();
            db.Conn.Close();
            return true;
        }
    }
}
