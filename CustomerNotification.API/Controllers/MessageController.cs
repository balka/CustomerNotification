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
        [Route("register")]
        public async Task<IActionResult> RegisterCustomer(Customer customer,[FromQuery]Format format) 
        {
            string message = string.Empty;
            if (customer != null)
            {
                message =  MessageFormater.GetMessage(customer,format,MessageType.Register);
            }
            await _messagingService.SendMessageAsync(customer.UserId, message);
            return StatusCode(201,customer);

            
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> DeleteCustomer(Customer customer, [FromQuery] Format format)
        {
            string message = string.Empty;
            if (customer != null)
            {
                message = MessageFormater.GetMessage(customer, format, MessageType.Delete);
            }
            await _messagingService.SendMessageAsync(customer.UserId, message);
            return StatusCode(200,$"User with id {customer.UserId} successfully deleted");


        }
        [HttpPost]
        public async Task<IActionResult> BlockCustomer(Customer customer, [FromQuery] Format format)
        {
            string message = string.Empty;
            if (customer != null)
            {
                message = MessageFormater.GetMessage(customer, format, MessageType.Block);
            }
            await _messagingService.SendMessageAsync(customer.UserId, message);
            return StatusCode(200, $"User with id {customer.UserId} successfully blocked");


        }
    }
}
