

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _tweetId;
        private Guid _authorId;
        private DateTime _tweetedAt;
        private DateTime? _modifyedAt;
        private string _content;



        public Guid Id
        {
            get { return _tweetId; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public DateTime TweetedAt
        {
            get { return _tweetedAt; }
            set
            {
                _tweetedAt = DateTime.UtcNow;
            }
        }


        public  Tweet()

    }
}
