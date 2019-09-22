using Dummy1.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dummy1.API.Repository
{
    public class MessageRepository : IMessageRepository
    {
        //MessagesLocalStorage dbx;
        public MessageRepository()
        {
            //dbx = new MessagesLocalStorage();
        }

        public void Delete(Guid id)
        {
            MessagesLocalStorage.Delete(id);
        }

        public Message Get(Guid Id)
        {
            return MessagesLocalStorage.Messages.Where(m => m.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Message> GetRecieved(string recieverId)
        {
            return MessagesLocalStorage.Messages.Where(m => m.RecieverId == recieverId).ToList();
        }

        public IEnumerable<Message> GetSent(string senderId)
        {
            return MessagesLocalStorage.Messages.Where(m => m.SenderId == senderId).ToList();
        }

        public void MarkRead(Guid id)
        {
            MessagesLocalStorage.MarkAsRead(id);
        }

        public void Send(Message message)
        {
            MessagesLocalStorage.Add(message);
        }

        public void Update(Guid id, Message message)
        {
            MessagesLocalStorage.Update(id, message);
        }
    }
}
