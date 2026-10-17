

using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Message :BaseEnitiies
    {



        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;
        private bool _isRead;

        public Message() : base(Guid.NewGuid())
        {

        }

        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

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


        public void UpdateContent(string content)
        {
            
            _content = content;
            MarkAsModified();
        }

        public void MarkAsRead()
        {
           
            _isRead = true;
            MarkAsModified();
        }

        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription},  SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, SentAt: {SentAt}, IsRead: {IsRead}";
        }

    }
}
