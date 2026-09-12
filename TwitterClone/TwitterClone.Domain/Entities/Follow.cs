

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEnitiies
    {
       


        private Guid _followingUserId;
        private Guid _followerUserId;
        private Guid _userId;
       
        public Follow(Guid followedUserId, Guid userId, Guid followerUserId ) : base(Guid.NewGuid())
        {

        }




        public Guid UserId { get { return _userId; } private set { _userId = value; } }

        public Guid FollowingUserId { get { return _followingUserId; } private set { _followingUserId = value; } }

        public Guid FollowerUserId { get {return  _followerUserId; } private set { _followerUserId = value; } }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, FollowedUserId: {FollowingUserId}, FollowerUserId: {FollowerUserId}";
        }



    }
}
