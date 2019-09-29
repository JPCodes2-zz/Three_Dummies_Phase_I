using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dummy1.API.Models;
using Dummy1.API.Repository;
using Dummy1.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dummy1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IMessageRepository messageRepository;

        public ChatController( IMessageRepository _messageRepository)
        {
            messageRepository = _messageRepository;
        }

        [HttpGet]
        public ActionResult<string> Greet()
        {
            return   "Hello World !!!";
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<List<Message>> GetAllMessages()
        {
            return messageRepository.GetSent("Dummy1").ToList();
        }

        [HttpPost]
        [Route("postmsg")]
        public ActionResult SendMessage(Message message)
        {
            messageRepository.Send(message);

            return Ok();
        }
    }
}