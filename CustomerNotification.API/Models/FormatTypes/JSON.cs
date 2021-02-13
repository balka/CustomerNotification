using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models.FormatTypes
{
    public static class JSON
    {
        public static string GetMessage(Customer customer)
        {
           return JsonSerializer.Serialize(customer);
        }
    }
}
