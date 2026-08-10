

namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _reTweetId;
        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;
        private string _content;



        public Retweet()
        {
            _reTweetId = Guid.NewGuid();
            _createdBy = Guid.NewGuid();
        }


        public Guid UserId { get; private set;  }
        public DateTime CreatedAt { get; private set; } 

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }


        public void SetContent( string content)
        {
            Content = content;
        }


    }
}
