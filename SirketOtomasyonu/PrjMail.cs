using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SirketOtomasyonu
{
    public partial class PrjMail : Form
    {
        public PrjMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void PrjMail_Load(object sender, EventArgs e)
        {
            TxtMail.Text = mail;
        }

        private void Btn_Gonder_Click(object sender, EventArgs e)
        {

            try
            {

                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.office365.com";
                sc.EnableSsl = true;


                //sc.Credentials = new NetworkCredential("yonlendirilmiscalisma2022@gmail.com", "123456789Aa."); // gönderen kişi
                sc.Credentials = new NetworkCredential("yoncal2@outlook.com", "123456789Aa."); // gönderen kişi

                MailMessage mail = new MailMessage();

                //mail.From = new MailAddress("yonlendirilmiscalisma2022@gmail.com", "EO Tic.Ltd.Şti.");
                mail.From = new MailAddress("yoncal2@outlook.com", "EO Tic.Ltd.Şti.");

                mail.To.Add(TxtMail.Text.ToString()); // giden kişi

                mail.Subject = TxtKonu.Text;
                mail.IsBodyHtml = true;
                mail.Body = RchMesaj.Text;

                sc.Send(mail);

                MessageBox.Show("Mail gönderildi");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
