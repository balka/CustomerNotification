using CustomerNotification.API.Models;
using CustomerNotificaton.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CustomerNotification.API.Controllers
{
    [ApiController]
    [Route("api/message")]
    public class MessageController : ControllerBase
    {
        private MessagingService _messagingService;

        public MessageController(MessagingService messagingService)
        {
            _messagingService = messagingService;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterCustomer(Customer customer,[FromQuery]Format format) 
        {
            if (customer == null)
            {
              var message =  MessageFormater.GetMessage(customer,format);
            }
            await _messagingService.SendMessageAsync(customer.UserId, MessageType.NewUserRegistered);
            return null;

            
        }
        //[HttpGet]
        //public async Task<IActionResult> DeleteCustomer(int id)
        //{
        //    _messagingService.SendMessageAsync(id, MessageType.UserDeleted);
        //}
        //[HttpGet]
        //public async Task<IActionResult> BlockCustomer()
        //{
        //    _messagingService.SendMessageAsync(int id, MessageType.UserBlocked);
        //}
    } 
}
