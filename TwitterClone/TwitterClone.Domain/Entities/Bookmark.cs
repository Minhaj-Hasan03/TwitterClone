

namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _bookmarkId;
        private string _bookmarkContent;
        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;



        public Bookmark( string  content ) { 
        
            _bookmarkId = Guid.NewGuid();
            _bookmarkContent = content;
            _createdBy = Guid.NewGuid();
        }


        public Guid UserId { get { return _userId; } private set { _userId = value; }  }


        public void SetUserId( Guid userId)
        {
            UserId = userId;
        }

        public Guid UpdateBy {  get { return _updatedBy; } private set { _updatedBy = value; } }

        public void CreatedAt() {
            _createdAt = DateTime.UtcNow;
        }

        public void UpdateAt() {
            _updatedAt = DateTime.UtcNow;
        }

    }
}
