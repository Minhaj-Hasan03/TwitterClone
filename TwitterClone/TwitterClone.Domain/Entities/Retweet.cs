

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Retweet:BaseEnitiies
    {
       
        private Guid _reTweetId;
        private Guid _userId;
        
        private string _content;



        public Retweet(Guid reTweetId , string content):base(Guid.NewGuid())
        {
            ReTweetId = reTweetId;
            Content = content;
        }


        public Guid UserId { get {return _userId; } private set { _userId = value; }  }


        public Guid ReTweetId { get { return _reTweetId; } private set { _reTweetId = value; } }
        public string Content { get { return _content ; } private set { _content = value; } }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, ReTweetId: {ReTweetId}, Content: {Content}";
        }


    }
}
