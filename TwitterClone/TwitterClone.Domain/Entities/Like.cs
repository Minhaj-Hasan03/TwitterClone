

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _likeId;
        private Guid _tweetId;
        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;
        



        public Like()
        {
            _likeId = Guid.NewGuid();
            _createdBy = Guid.NewGuid();
            _createdAt = DateTime.UtcNow; 

        }


        public Guid UserId { get;  set; }
        public Guid TweetId { get;private set; }
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
