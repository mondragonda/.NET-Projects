using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class EmailService
    {
        /// <summary>
        /// Sends Email Message
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="recipient"></param>
        /// <returns>Email Sent Confirmation</returns>
        public string SendMessage(string subject, string message, string recipient)
        {
            //code to send an email

            var confirmation = "Message sent: " + subject;
            LoggingService.LogAction(confirmation);

            return confirmation;
        }
    }
}
