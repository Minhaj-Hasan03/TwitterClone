

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {

        private Guid _followedUserId;
        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;



        public Follow()
        {
            _followedUserId = Guid.NewGuid();
            _createdBy = Guid.NewGuid();
        }


        public Guid UserId { get; private set; }

        public void SetUserId(Guid userId)
        {
            UserId = userId;
        }

        public Guid UpdateBy { get { return _updatedBy; } private set { _updatedBy = value; } }

        public void CreatedAt()
        {
            _createdAt = DateTime.UtcNow;
        }

        public void UpdateAt()
        {
            _updatedAt = DateTime.UtcNow;
        }



    }
}
