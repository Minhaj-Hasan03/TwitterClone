

using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Message :BaseEnitiies
    {
       

        
        private string _messageContent;
        private Guid _messageSenderId;
        private Guid _messageRecieverId;
        private bool _isRead;
        private DateTime _sentAt;

        


        public Message(string messageContent , Guid messageId , Guid messageSentId, Guid userId ):base(Guid.NewGuid())
        {
            
        }



        public Guid MessageSenderId { get { return _messageSenderId; } private set { _messageSenderId = value; } }
        public string MessageContent { get { return _messageContent;  } private set { _messageContent = value; }   }

        public Guid MessageRecieverId { get { return _messageRecieverId; } private set { _messageRecieverId = value; }  }
        public DateTime SentAt
        {
            get { return _sentAt; }
            set { _sentAt = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, SenderId: {MessageSenderId}, ReceiverId: {MessageRecieverId}, Content: {MessageContent}, SentAt: {SentAt}, IsRead: {IsRead}";
        }

    }
}
