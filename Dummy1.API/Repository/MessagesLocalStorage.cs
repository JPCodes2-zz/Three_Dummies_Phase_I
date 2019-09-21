using System;
using System.Collections.Generic;
using Dummy1.API.Models;

namespace Dummy1.API.Repository
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
