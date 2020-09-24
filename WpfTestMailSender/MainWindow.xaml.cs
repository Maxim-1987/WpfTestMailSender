using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WpfTestMailSender
{
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        private void OnSendButtonClick(object sender, RoutedEventArgs e)
        {
            EmailSendServiceClass.sendEmail(LoginEdit.Text, PasswordEdit.SecurePassword, Subject.Text, Text.Text);
        }
    }
}
