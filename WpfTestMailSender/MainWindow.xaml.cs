using System;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using WpfTestMailSender.Models;

namespace WpfTestMailSender
{
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        //private void OnSendButtonClick(object sender, RoutedEventArgs e)
        //{
        //    EmailSendServiceClass.sendEmail(LoginEdit.Text, PasswordEdit.SecurePassword, Subject.Text, Text.Text);
        //}

        private void miClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GoScheduler_Click(object sender, RoutedEventArgs e)
        {
            tc.SelectedIndex = 1;
            
        }
    }
}
