using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models
{
    public static class MessageTypeText
    {
        public const string NewUserRegistered = "NewUserRegistered";
        public const string UserDeleted = "UserDeleted";
        public const string UserBlocked = "UserBlocked";
    }
}
