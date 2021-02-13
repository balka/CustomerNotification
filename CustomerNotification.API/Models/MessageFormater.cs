using CustomerNotification.API.Models.FormatTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models
{
    public static class MessageFormater
    {
        public static string GetMessage(Customer customer, Format format, MessageType type)
        {
            string message = string.Empty;
            switch (format)
            {

                case Format.CSV:
                    message = MessageConverter.CSV(customer, type);
                    break;
                case Format.SMS:
                    message = MessageConverter.SMS(customer, type);
                    break;
                case Format.JSON:
                    message = MessageConverter.JSON(customer, type);
                    break;
                default:
                    break;
            }

            return message;
        }

    }
}
