using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace ResCheker
{
    class SendMailMessage
    {
        public static async Task SendMailAsync(string message)
        {
            MailAddress from = new MailAddress("resourse.monitor@gmail.com", "AppResChecker");
            MailAddress to = new MailAddress("acer12619@gmail.com");
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = "Help Message";
            mailMessage.Body = message;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("resourse.monitor@gmail.com", "2klCv9w4M");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(mailMessage);
        }
        public static void SendMail(string email, string message)
        {
            MailAddress from = new MailAddress("resourse.monitor@gmail.com", "Tom");
            MailAddress to = new MailAddress("acer12619@gmail.com");
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = email;
            mailMessage.Body = "<h2>"+ message +"</h2>";
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("resourse.monitor@gmail.com", "2klCv9w4M");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mailMessage);
            }
            catch(SmtpException smtpEx)
            {
                MessageBox.Show($"Невозможно послать сообщение, возникла ошибка {smtpEx.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Возникло исключение {e.Message}");
            }
        }
    }
}
