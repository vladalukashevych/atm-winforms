using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ClassLibrary.Classes
{
    public class EmailNotification
    {
        private readonly string sender = "ipz211_lvv@student.ztu.edu.ua";

        public EmailNotification(string recipient, string topic, string message)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(sender, "#####"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(sender, recipient, topic, message);
        }
    }
}
