



namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEnitiies, ILikeabe
    {

        private Guid _tweetId;
        private Guid _authorId;
        private string _content;
        private Guid _userId;


        public static int ContentLengthMaximum = 280;




        public Tweet(Guid tweetId, Guid authorId, Guid userId, string content) : base(Guid.NewGuid())
        {
            UserId = userId;
            AuthorId = authorId;
            TweetId = tweetId;
            Content = content;
        }

        public Tweet( string content) : base(Guid.NewGuid())
        {
            _content = content;
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


        public bool CanLike()
        {
            if( string.IsNullOrWhiteSpace(Content))
            {
                return false;
            }
            return true;
        }
    }
}
