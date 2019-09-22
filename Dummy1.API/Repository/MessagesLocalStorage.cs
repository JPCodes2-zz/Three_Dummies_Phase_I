using System;
using System.Collections.Generic;
using Dummy1.API.Models;

namespace Dummy1.API.Repository
{
    public class MessagesLocalStorage
    {
        public static  IList<Message> Messages = new List<Message>() {
        new Message("Hello", "Dummy1", "Dummy2"),
        new Message("Hello back...", "Dummy2", "Dummy1"),
        new Message("lol", "Dummy1", "Dummy2")
        };
    }
}
