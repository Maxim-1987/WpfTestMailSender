using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WpfTestMailSender
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSendButtonClick(object sender, RoutedEventArgs e)
        {            
            var to = new MailAddress(Variables.toAddress, Variables.toName);
            var from = new MailAddress(Variables.fromAddress, Variables.fromName);

            var message = new MailMessage(from, to);

            message.Subject = Variables.subject;
            message.Body = Variables.text;

            var client = new SmtpClient(Variables.smtpServer, Variables.port);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = LoginEdit.Text,
                SecurePassword = PasswordEdit.SecurePassword
            };

            client.Send(message);
        }
    }
}
