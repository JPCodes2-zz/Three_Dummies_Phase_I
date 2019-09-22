using System;
using System.Collections.Generic;
using Dummy1.API.Models;

namespace Dummy1.API.Repository
{
    public interface IMessageRepository
    {
        Message Get(Guid Id);
        IEnumerable<Message> GetSent(string senderId);
        IEnumerable<Message> GetRecieved(string recieverId);
        void Send(Message message);
        void Update(Guid id, Message message);
        void Delete(Guid id);
        void MarkRead(Guid id);
    }
}