using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace CAUtility
{
    public class EmailUtility
    {
        public void SendEmail(string from, string to, string subject, string msgBody)
        {
            try
            {
                
                MailMessage message = new MailMessage(from, to);   // From address has to be GMAIL only             
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = msgBody;
                string fromPswd = "srlvjkbaoucqaeeq";

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";           // This is free SMTP given by gmail
                smtp.Port = 587;                        // 587 is for free account
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(from, fromPswd);
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = NetworkCred;

                smtp.Send(message);
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
        }
    }
}
