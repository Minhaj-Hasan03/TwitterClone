

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _tweetId;
        private Guid _authorId;
        private DateTime _tweetedAt;
        private DateTime? _modifyedAt;
        private string _content;

        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;



        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        

        public Tweet()
        {
            _id = Guid.NewGuid();

            _tweetId = Guid.NewGuid();
            _tweetedAt = DateTime.UtcNow;
        }


        public void Content( string content)
        {
            _content = content;
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
