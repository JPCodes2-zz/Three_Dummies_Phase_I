using System;
using System.Collections.Generic;
using Dummy2.API.Models;

namespace Dummy2.API.Repositories
{
    public class MessagesLocalStorage
    {
        public IList<Message> Messages = new List<Message>();

        public MessagesLocalStorage()
        {
            Messages.Add(new Message("Hello", "Dummy1", "Dummy2"));
            Messages.Add(new Message("Hello back...", "Dummy2", "Dummy1"));
            Messages.Add(new Message("lol", "Dummy1", "Dummy2"));
        }
    }
}
