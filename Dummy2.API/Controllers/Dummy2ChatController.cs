using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dummy2.API.Models;
using Dummy2.API.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dummy2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dummy2ChatController : ControllerBase
    {
        private readonly IMessageRepository messageRepository;

        public Dummy2ChatController(IMessageRepository _messageRepository)
        {
            messageRepository = _messageRepository;
        }

        [HttpGet]
        public ActionResult<string> Greet()
        {
            return "Hello World !!!";
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<List<Message>> GetAllMessages()
        {
            return messageRepository.GetSent("Dummy1").ToList();
        }
    }
}
