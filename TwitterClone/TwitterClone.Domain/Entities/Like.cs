

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Like:BaseEnitiies
    {
        

        private Guid _likeId;
        private Guid _tweetId;
        private Guid _userId;
        
        



        public Like( Guid likeId, Guid userId, Guid tweetId): base(Guid.NewGuid())

        {
          

        }


        public Guid UserId { get { return _userId; } private set { _userId = value; } }

        public Guid LikeId { get { return _likeId; } private set { _likeId = value; } }

        public Guid TweetId { get { return _tweetId; } private set { _tweetId = value; } }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, TweetId: {TweetId}, LikeId: {LikeId}  ";
        }



    }
}
