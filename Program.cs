namespace EmailSender
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mail = EmailSender.CreateMailData();
            EmailSender.SendMail(mail);
            // comm 4 teamcity check
        }
    }
}
