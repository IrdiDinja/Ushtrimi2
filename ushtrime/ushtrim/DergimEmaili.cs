using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace ushtrim
{
    public class DergimEmaili
    {
   
       LeximSkedari ls = new LeximSkedari();
       Ruaj r = new Ruaj();


       public void SendEmail(string pass)
       {
           try
           {
               MailMessage mail = new MailMessage();
               SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

               mail.From = new MailAddress(ls.fromEmail);
               mail.To.Add(ls.toEmail);
               mail.Subject = ls.subject;
               mail.Body = ls.body;

               SmtpServer.Port = 587;
               SmtpServer.Credentials = new System.Net.NetworkCredential(ls.fromEmail, pass);
               SmtpServer.EnableSsl = true;

               SmtpServer.Send(mail);

               Console.WriteLine("mail send");

                r.RuajNeDB(ls.toEmail, ls.subject, ls.body, "u dergua me sukses!");
              
           }

           catch (Exception ex)
           {
               Console.WriteLine("mail not send!");
             
                r.RuajNeDB(ls.toEmail,ls.subject,ls.body,ex.Message);
           }
           
       }
        public bool SendEmailTest(string pass)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(ls.fromEmail);
                mail.To.Add(ls.toEmail);
                mail.Subject = ls.subject;
                mail.Body = ls.body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(ls.fromEmail, pass);
                SmtpServer.EnableSsl = true;

                

                Console.WriteLine("mail send");
                
                r.RuajNeDBTest(ls.toEmail,ls.subject,ls.body,"Email u dergua me suskes! TEST");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                r.RuajNeDBTest(ls.toEmail, ls.subject, ls.body, ex.Message+"Dergimi i Email deshtoi! TEST");
            }
            return true;
        }
    }
}
