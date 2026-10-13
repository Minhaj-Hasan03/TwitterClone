

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Retweet:BaseEnitiies
    {
       
        private Guid _tweetId;
        private Guid _userId;
        
        private string _comment;



        public Retweet():base(Guid.NewGuid())
        {
            
        }


        public Guid UserId { get {return _userId; }  set { _userId = value; }  }


        public Guid TweetId { get { return _tweetId; }  set { _tweetId = value; } }
        public string Comment { get { return _comment ; }  set { _comment = value; } }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, ReTweetId: {TweetId}, Content: {Comment}";
        }


    }
}
