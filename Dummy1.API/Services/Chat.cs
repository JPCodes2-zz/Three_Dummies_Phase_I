using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dummy1.API.Services
{
    public class Chat : IChat
    {
        public Chat()
        {

        }
        public Task<string> Greet()
        {
           return Task.Factory.StartNew(()=>"Helo World!!!");
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
