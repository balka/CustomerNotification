using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models
{
    public class Customer
    {
        public string UserId { get; set; }
        public string Email{ get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}
