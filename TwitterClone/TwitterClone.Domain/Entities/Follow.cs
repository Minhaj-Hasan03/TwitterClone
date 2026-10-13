

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEnitiies
    {



        private Guid _followerId;
        private Guid _followingId;

        public Follow() : base(Guid.NewGuid())
        {

        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, FollowerId: {FollowerId}, FollowingId: {FollowingId}";
        }



    }
}
