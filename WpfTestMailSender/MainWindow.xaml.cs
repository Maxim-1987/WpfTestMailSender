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
            EmailSendServiceClass.sendEmail(LoginEdit.Text, PasswordEdit.SecurePassword, Subject.Text, Text.Text);
        }
    }
}
