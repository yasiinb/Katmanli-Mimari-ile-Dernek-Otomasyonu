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
using DernekOtomasyonu.Bussiness.Concrete;

namespace DernekOtomasyonu.UI.PersonelForm
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        UyeManager uyeManager = new UyeManager();
        OdemelerManager odemelerManager = new OdemelerManager();
        private void AidatMail_Click(object sender, EventArgs e)
        {         
            var tcList =odemelerManager.GetUnpaidMembersTC();

            if (tcList != null && tcList.Count > 0)
            {
                // Şimdi bu TC numaralarını kullanarak üye tablosundan e-posta adreslerini alalım
                var emailList =uyeManager.GetEmailsByTC(tcList);
                
                // Şimdi e-posta gönderme işlemine geçelim
                SendEmails(emailList);
            }
            else
            {
                MessageBox.Show("Ödemesi beklenen üye bulunmamaktadır.");
            }
            MessageBox.Show($"Bütün e-postalar başarıyla gönderildi.");
        }
        private void SendEmails(List<string> emailList)
        {
            MailMessage mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Credentials = new System.Net.NetworkCredential("gorselprogramlama61@outlook.com", "gorselprogramlama1");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.office365.com";
            smtpClient.EnableSsl = true; // SSL bağlantısını etkinleştir

            mailMessage.From = new MailAddress("gorselprogramlama61@outlook.com");
            mailMessage.Subject = "Aidat Ödemesi";
            mailMessage.Body = textBox1.Text;

            foreach (var email in emailList)
            {
                mailMessage.To.Clear(); // Her seferinde önceki alıcıyı temizle
                mailMessage.To.Add(email);

                try
                {
                    smtpClient.Send(mailMessage);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"hata oluştu: {ex.Message}");
                }
                
            }
        }
    }
}
