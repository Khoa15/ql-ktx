﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace ql_ktx
{
    public partial class XemPhong_Fr : Form
    {
        Phong phong;
        List<HopDong> dsHopDong;
        public XemPhong_Fr(DataGridViewRow currentRow)
        {
            InitializeComponent();
            phong = currentRow.DataBoundItem as Phong;
        }

        private void XemPhong_Fr_Load(object sender, EventArgs e)
        {
            HopDong_BLL hopDong_bll = new HopDong_BLL();
            dsHopDong = hopDong_bll.Load(phong);
            
            dataGridView_SinhVien.DataSource = dsHopDong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new SmtpClient object.
            SmtpClient client = new SmtpClient("smtp.office365.com");

            // Set the port number.
            client.Port = 587;

            // Set the username and password.
            client.Credentials = new NetworkCredential("nguyenkhoa72@outlook.com", "baotrung123");

            // Enable SSL.
            client.EnableSsl = true;

            // Create a new MailMessage object.
            MailMessage message = new MailMessage();

            // Set the sender.
            message.From = new MailAddress("nguyenkhoa72@outlook.com");

            // Set the recipient.
            message.To.Add(new MailAddress("nguyentrongdangkhoa15@gmail.com"));

            // Set the subject.
            message.Subject = "This is a test email";
            message.Priority = MailPriority.High;
            // Set the body.
            message.Body = "This is the body of the email.";

            // Send the email.
            client.Send(message);

            // Display a message to indicate that the email was sent successfully.
            MessageBox.Show("SuccessFully");

        }
    }
}