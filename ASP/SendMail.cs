 //Add mail
 using System.Net.Mail;
 //send mail
 MailMessage Mail = new MailMessage("sender@kuku.bg", "recpnt@kuku.bg");
 Mail.Subject = "Test";
 Mail.Body = "This is my test mail.";
 SmtpClient sm = new SmtpClient();
 sm.Host = "mail.ue-varna.bg";
 sm.Send(Mail);
