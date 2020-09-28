using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace WpfTestMailSender.lib
{
   public class EmailSendServiceClass
    {
        public string ServerAddress { get; set; }

        public int ServerPort { get; set; }

        public bool UseSSL { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public void sendEmail(string SenderAddress, string RecipientAddress, string Subject, string Text)
        {
            var from = new MailAddress(SenderAddress);
            var to = new MailAddress(RecipientAddress);

            using (var message = new MailMessage(from, to))
            {

                message.Subject = Subject;
                message.Body = Text;

                using (var client = new SmtpClient(ServerAddress, ServerPort))
                {
                    client.EnableSsl = UseSSL;

                    client.Credentials = new NetworkCredential
                    {
                        UserName = Login,
                        Password = Password
                    };

                    try
                    {
                        client.Send(message);
                    }
                    catch (SmtpException e)
                    {
                        Trace.TraceError(e.ToString());
                        throw;
                    }
                }
            }
        }
   }
   
}
