using System;
using System.Collections.Generic;
using System.Linq;
using Dummy1.API.Models;

namespace Dummy1.API.Repository
{
    public class MessageRepository: IMessageRepository
    {
        MessagesLocalStorage dbx;
        public MessageRepository()
        {
            dbx = new MessagesLocalStorage();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Message Get(Guid Id)
        {
           return dbx.Messages.Where(m => m.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Message> GetRecieved(string recieverId)
        {
            return dbx.Messages.Where(m => m.RecieverId == recieverId).ToList();
        }

        public IEnumerable<Message> GetSent(string senderId)
        {
            return dbx.Messages.Where(m => m.SenderId == senderId).ToList();
        }

        public void MarkRead(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Send(Message message)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid id, Message message)
        {
            throw new NotImplementedException();
        }
    }
}
