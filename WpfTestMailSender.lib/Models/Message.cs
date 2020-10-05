using System;
using System.Collections.Generic;
using System.Text;
using WpfTestMailSender.lib.Models.Base;

namespace WpfTestMailSender.lib.Models
{
    public class Message:Entity
    {
        public string Subject { get; set; }
        public string Text  { get; set; }
    }
}
