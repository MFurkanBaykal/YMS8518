using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var smtp = new SMTP()
            {
                Email = "test@enguzelyerler.com",
                Server = "server.enguzelyerler.com",
                Port = 587,
                Password = "A123456!"
            };
            var outgoingEmail = new OutgoingEmail()
            {
                To = "baykalmikailfurkan@gmail.com",
                Subject = "Bu bir deneme emailidir",
                Body = "bu benim istediğim içerik <b>olabilir</b>."
            };
            MailHelper.Send(SendCompletedCallback, smtp, outgoingEmail);
            Console.ReadLine();
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //mail gönderimi iptal edildi
            }
            else if (e.Error != null)
            {
                //gönderim sırasında hata oluştu
            }
            else
            {
                //mail başarıyla gönderildi
            }
        }


        public class SMTP
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string Server { get; set; }
            public int Port { get; set; }
        }

        public class OutgoingEmail
        {
            //??
            public string To { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
        }

        public class MailHelper
        {
            public static void Send(EventHandler<System.ComponentModel.AsyncCompletedEventArgs> sendCompletedCallback, SMTP smtp, OutgoingEmail outgoingEmail)
            {
                SmtpClient smtpClient = new SmtpClient(smtp.Server, smtp.Port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(smtp.Email, smtp.Password)
                };

                MailAddress fromMailAddress = new MailAddress(smtp.Email, "Bilge Adam", Encoding.UTF8);
                MailAddress toMailAddress = new MailAddress(outgoingEmail.To);

                MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress)
                {
                    IsBodyHtml = true,
                    Body = outgoingEmail.Body,
                    Subject = outgoingEmail.Subject,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8
                };
                smtpClient.SendCompleted += new SendCompletedEventHandler((sender, args) => sendCompletedCallback?.Invoke(null, args));
                smtpClient.SendAsync(mailMessage, 123/*açıkla*/);
            }
        }
        //SMTP == mail göndermek için kullanılır.
        //pop3 == mail almak için kullanılır.
    }
}
