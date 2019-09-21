using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dummy1.API.Repository;

namespace Dummy1.API.Services
{
    public class Chat : IChat
    {
        IMessageRepository messageRepository;
        public Chat(IMessageRepository _messageRepository)
        {
            messageRepository = _messageRepository;
        }
        public Task<string> Greet()
        {
           return Task.Factory.StartNew(()=>"Hello World!!!");
        }

        public Task<string> ReadMessage()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ReadMessages()
        {
            throw new NotImplementedException();
        }

        public Task<string> Respond(string message)
        {
            throw new NotImplementedException();
        }
    }
}
