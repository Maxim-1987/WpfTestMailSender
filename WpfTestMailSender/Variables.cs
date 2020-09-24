using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WpfTestMailSender
{
    public static class Variables
    {
       public static int port = 25;
       public static string smtpServer = "smtp.yandex.ru";
       public static string toAddress = "max-tenigin1987@mail.ru";
       public static string fromAddress = "max-tenigin1987@yandex.ru";
       public static string toName = "Максим";
       public static string fromName = "Макс";
       public static string subject = "Заголовок письма от " + DateTime.Now;
       public static string text = "Текст тестового письма + " + DateTime.Now;

    }
}
