using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class MessageData
    {
        public string SmtpServer { get; set; }
        public string From { get; set; }
        public string Password { get; set; }
        public string Mailto { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string AttachFile { get; set; }
    }
}
