

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _messageId;
        private string _messageContent;
        private Guid _messageSentId;
        private Guid _userId;

        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;


        public Message()
        {
            _messageId = Guid.NewGuid();
            _createdBy = Guid.NewGuid();
        }



        public Guid MessageSentId { get { return _messageId; } private set { _messageId = value; } }
        public Guid UserId { get; private set; }
        public void  MessageContent(string value ) { 
            _messageContent = value; 
        } 

        public void Set( Guid userId, Guid messageSentId)
        {
            MessageSentId = messageSentId;
            UserId = userId;

        }


        public Guid UpdateBy { get { return _updatedBy; } private set { _updatedBy = value; } }

        public void CreatedAt()
        {
            _createdAt = DateTime.UtcNow;
        }

        public void UpdateAt()
        {
            _updatedAt = DateTime.UtcNow;
        }


    }
}
