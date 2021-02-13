using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models
{
    public interface IMessagingService
    {
        Task SendMessageAsync(string userId, string newUserRegistered);
    }
}
