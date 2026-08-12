

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Message :BaseEnitiies
    {
       

        private Guid _messageId;
        private string _messageContent;
        private Guid _messageSentId;
        private Guid _userId;

        


        public Message(string messageContent , Guid messageId , Guid messageSentId, Guid userId ):base(Guid.NewGuid())
        {
            MessageContent = messageContent;
            MessageId = messageId;
            UserId = userId;
            MessageSentId = messageSentId;
        }



        public Guid MessageSentId { get { return _messageId; } private set { _messageId = value; } }
        public string MessageContent { get { return _messageContent;  } private set { _messageContent = value; }   }

        public Guid MessageId { get { return _messageId; } private set { _messageId = value; }  }
        public Guid UserId { get { return _userId; } private set { _userId = value; }  }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, MessageId: {MessageId}, MessageContent: {MessageContent}, MessageSentId: {MessageSentId}";
        }

    }
}
