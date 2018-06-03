using System;
using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    public class EmailSender
    {
        public static void SendMail(MessageData data)
        {
            try
            {
                var mail = new MailMessage
                {
                    From = new MailAddress(data.From),
                    Subject = data.Subject,
                    Body = data.Message
                };
                mail.To.Add(new MailAddress(data.Mailto));
                if (!string.IsNullOrEmpty(data.AttachFile))
                    mail.Attachments.Add(new Attachment(data.AttachFile));

                var client = new SmtpClient
                {
                    Host = data.SmtpServer,
                    Port = 25, // 587 for gmail
                    //EnableSsl = true,
                    //Credentials = new NetworkCredential(data.From.Split('@')[0], data.Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        public static MessageData CreateMailData()
        {
            return new MessageData
            {
                SmtpServer = "127.0.0.1", // smtp.gmail.com for gmail
                From = "from@gmail.com",
                Password = "notrequired",
                Mailto = "mymail@gmail.com",
                Subject = "test",
                Message = "Test message body",
                AttachFile = @"C:\myFile.pdf"
            };
        }
    }
}
