using System;
using System.Collections.Generic;
using Dummy2.API.Models;

namespace Dummy2.API.Repositories
{
    public interface IMessageRepository
    {
        Message Get(Guid Id);
        IEnumerable<Message> GetSent(string senderId);
        IEnumerable<Message> GetRecieved(string recieverId);
        bool Send(Message message);
        bool Update(Guid id, Message message);
        void Delete(Guid id);
        void MarkRead(Guid id);
    }
}
