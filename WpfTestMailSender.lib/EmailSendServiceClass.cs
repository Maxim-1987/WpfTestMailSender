using System;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Security;

namespace WpfTestMailSender.lib
{
    class EmailSendServiceClass
    {
        EmailSendServiceClass()
        {

        }

        //public static void sendEmail(string LoginEdit, SecureString PasswordEdit, string Subject, string Text)
        //{
        //    var client = new SmtpClient(Variables.smtpServer, Variables.port);
        //    client.EnableSsl = true;
        //    client.Credentials = new NetworkCredential(LoginEdit, PasswordEdit);

        //    var to = new MailAddress(Variables.toAddress, Variables.toName);
        //    var from = new MailAddress(Variables.fromAddress, Variables.fromName);

        //    var message = new MailMessage(from, to);

        //    message.Subject =Subject + DateTime.Now;
        //    message.Body = Text + DateTime.Now;

        //    try
        //    {
        //        client.Send(message);
        //        MessageBox.Show("Успех!");
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message, "Ошибка отправки");
        //    }
        //}
    }
}
