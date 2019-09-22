using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void Add(Message message)
        {
            Messages.Add(message);
        }

        public static void MarkAsRead(Guid guid)
        {
            var msg = Messages.Where(m => m.Id == guid).FirstOrDefault();

            if (msg != null)
                msg.MarkAsRead();
        }

        public static bool Update(Guid guid, Message message)
        {
            var msg = Messages.Where(m=>m.Id==guid).FirstOrDefault();

            if(msg!=null)
            {
                // msg.Update(message);
                Messages.Remove(msg);
                Messages.Add(message);

                return true;
            }
            return false;
        }

        public static bool Delete(Guid guid)
        {
            var msg = Messages.Where(m => m.Id == guid).FirstOrDefault();

            if (msg != null)
            {
                Messages.Remove(msg);
                return true;
            }

            return false;


        }
    }
}
