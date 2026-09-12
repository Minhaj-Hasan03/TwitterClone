

namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEnitiies
    {
        

      
        private Guid _bookmarkId;
        private string _bookmarkContent;
        private Guid _userId;
        private Guid _tweetId;
        



        public Bookmark( string  content, Guid bookmarkId, Guid userId ):base(Guid.NewGuid()) { 
        
            
           
            
            
        }


        public Guid UserId { get { return _userId; } private set { _userId = value; }  }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }
        public string Content { get { return _bookmarkContent; } private set { _bookmarkContent = value; } }

        public Guid BookmarkId { get { return _bookmarkId; } private set { _bookmarkId = value; } }




        public override string Description()
        {
            var baseDescription = base.Description();
            return  $"{baseDescription}, UserId: {UserId}, BookmarkId: {BookmarkId}";
        }
        

       

       
    }
}
