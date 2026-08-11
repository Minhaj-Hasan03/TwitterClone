



namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEnitiies
    {

        private Guid _tweetId;
        private Guid _authorId;
        private string _content;
        private Guid _userId;







        public Tweet(Guid tweetId, Guid authorId, Guid userId, string content) : base(Guid.NewGuid())
        {
            UserId = userId;
            AuthorId = authorId;
            TweetId = tweetId;
            Content = content;
        }


        public Guid UserId { get { return _userId; } private set { _userId = value; } }

        public Guid AuthorId { get { return _authorId; } private set { _authorId = value; } }
        public string Content { get { return _content; } private set { _content = value; } }
        public Guid TweetId
        {
            get { return _tweetId; }
            private set { _tweetId = value; }




        }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, TweetID: {TweetId}, AuthorId: {AuthorId}, Content: {Content} ";
        }
    }
}
