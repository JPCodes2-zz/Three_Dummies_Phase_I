using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dummy1.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dummy1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChat chat;

        public ChatController(IChat _chat)
        {
            //chat = new Chat();
            chat = _chat;
        }

        [HttpGet]
        public ActionResult<string> Greet()
        {
            return   chat.Greet().Result;
        }
    }
}