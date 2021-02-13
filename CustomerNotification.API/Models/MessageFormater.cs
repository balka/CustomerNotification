using CustomerNotification.API.Models.FormatTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models
{
    public static class MessageFormater
    {
        public static string GetMessage(Customer customer,Format format)
        {
            string message = string.Empty;
            switch (format)
            {
                case Format.JSON:
                    message = JSON.GetMessage(customer);
                    break;
                case Format.XML:
                    break;
                case Format.SMS:
                    break;
                default:
                    break;
            }

            return message;
        }
        public static string GetJson()
        {
            return string.Empty;
        }
    }
}
