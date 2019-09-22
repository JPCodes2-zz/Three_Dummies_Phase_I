using System;
namespace Dummy1.API.Models
{
    public class Message
    {
        public Guid Id { get; private set; }

        public string MessageText { get; private set; }

        public string SenderId { get; private set; }

        public string RecieverId { get; private set; }

        public DateTime TimeStamp { get; private set; }

        public bool IsRead { get;private set; }

        public Message(Guid guid, string messageText, string senderId, string recieverId,DateTime dateTime, bool isRead)
        {
            Id = guid;
            SenderId = senderId;
            RecieverId = recieverId;
            TimeStamp = dateTime;
            MessageText = messageText;
            IsRead = isRead;
        }
        public Message(string messageText, string senderId, string recieverId)
            : this (Guid.NewGuid(), messageText, senderId, recieverId, DateTime.Now, false)
        {
        }

       
        public override string ToString()
        {
            return MessageText+"--"+SenderId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Id==((Message)obj).Id && TimeStamp == ((Message)obj).TimeStamp;
        }

        public void MarkAsRead()=>  IsRead = true;

        public void Update(Message message)
        {
            this.IsRead = message.IsRead;
            this.MessageText = message.MessageText;
            this.RecieverId = message.RecieverId;
            this.SenderId = message.SenderId;
            this.TimeStamp = DateTime.Now;
        }
        
    }
}
