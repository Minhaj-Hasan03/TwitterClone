

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _tweetId;
        private Guid _authorId;
        private DateTime _tweetedAt;
        private DateTime? _modifyedAt;
        private string _content;



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
            _tweetId = Guid.NewGuid();
            _tweetedAt = DateTime.UtcNow;
        }


        public void Content( string content)
        {
            _content = content;
        }

    }
}
