

using System.Security.Cryptography;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEnitiies
    {
       


        private Guid _followedUserId;
        private Guid _followerUserId;
        private Guid _userId;
       
        public Follow(Guid followedUserId, Guid userId, Guid followerUserId ) : base(Guid.NewGuid())
        {
            UserId = userId;
            FollowedUserId = followedUserId;
            _followerUserId = followerUserId;
        }




        public Guid UserId { get { return _userId; } private set { _userId = value; } }

        public Guid FollowedUserId { get { return _followedUserId; } private set { _followedUserId = value; } }

        public Guid FollowerUserId { get {return  _followerUserId; } private set { _followerUserId = value; } }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, FollowedUserId: {FollowedUserId}, FollowerUserId: {FollowerUserId}";
        }



    }
}
