using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WpfTestMailSender.Models;
using WpfTestMailSender.lib.Service;


namespace WpfTestMailSender.Data
{
    class TestData
    {
        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10)
           .Select(i => new Sender
           {
               FromName = $"Отправитель {i}",
               FromAddress = $"sender_{i}@server.ru"
           })
           .ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 10)
           .Select(i => new Recipient
           {
               ToName = $"Получатель {i}",
               ToAddress = $"recipient_{i}@server.ru"
           })
           .ToList();

        public static List<Server> Servers { get; } = Enumerable.Range(1, 10)
           .Select(i => new Server
           {
               Address = $"smtp.server{i}.com",
               Login = $"Login-{i}",
               Password = TextEncoder.Encode($"Password-{i}"),
               UseSSL = i % 2 == 0
           })
           .ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 20)
           .Select(i => new Message
           {
               Subject = $"Сообщение {i}",
               Text = $"Текст сообщения {i}"
           })
           .ToList();
    }
}
