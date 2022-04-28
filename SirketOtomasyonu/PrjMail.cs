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

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("yonlendirilmiscalisma2022@gmail.com");
                msg.To.Add(TxtMail.Text);
                msg.Subject = TxtKonu.Text;
                msg.Body = RchMesaj.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "yonlendirilmiscalisma2022@gmail.com";
                ntcd.Password = "123456789Aa.";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
