

namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEnitiies
    {
        

      
       
        private Guid _userId;
        private Guid _tweetId;
        

        public Bookmark():base(Guid.NewGuid())
        {

        }

        public Bookmark( string  content, Guid bookmarkId, Guid userId ):base(Guid.NewGuid()) { 
        
            
           
            
            
        }


        public Guid UserId { get { return _userId; }  set { _userId = value; }  }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }
       




        public override string Description()
        {
            var baseDescription = base.Description();
            return  $"{baseDescription}, UserId: {UserId}, TweetId: {TweetId}";
        }
        

       

       
    }
}
