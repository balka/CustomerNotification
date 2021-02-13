using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace CustomerNotification.API.Models.FormatTypes
{
    public static class MessageConverter
    {
        
        public static string CSV( Customer customer, MessageType type)
        {
            CsvConfig<Customer>.OmitHeaders = true;
            string message = CsvSerializer.SerializeToString(customer);
            switch (type)
            {
                case MessageType.Register:
                    return MessageTypeText.NewUserRegistered + "," + message;
                case MessageType.Delete:
                    return MessageTypeText.UserDeleted + "," + customer.UserId;
                case MessageType.Block:
                    return MessageTypeText.UserDeleted + ", " + customer.UserId;
                default:
                    break;
            }
            return message;
        }
        public static string SMS(Customer customer, MessageType type)
        {
            string message =$"FirstName: {customer.FirstName}, LastName {customer.LastName}";
            switch (type)
            {
                case MessageType.Register:
                    return MessageTypeText.NewUserRegistered + "," + message;
                case MessageType.Delete:
                    return MessageTypeText.UserDeleted + "," + customer.UserId;
                case MessageType.Block:
                    return MessageTypeText.UserDeleted + "," + customer.UserId;
                default:
                    break;
            }
            return message;


        }
        public static string JSON(Customer customer, MessageType type)
        {
            string message = System.Text.Json.JsonSerializer.Serialize(customer);
            switch (type)
            {
                case MessageType.Register:
                    break;
                case MessageType.Delete:
                    break;
                case MessageType.Block:
                    break;
                default:
                    break;
            }
            return message;
        }

    }
}
