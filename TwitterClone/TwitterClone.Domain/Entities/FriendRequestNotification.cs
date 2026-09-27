
namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
            
        public FriendRequestNotification(Guid frientRequestId ) :base("FrientRequest", Guid.NewGuid(), Guid.NewGuid())
        { 
            
        }

        public Guid FriendRequestUserId { get; private  set; }

        public void Message(string message)
        {
            MessageType = message;
        }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, FriendRequestUserId: {FriendRequestUserId}, ";

        }


        public override string GetMessage()
        {
            return $"The get friend request from {FriendRequestUserId}";
        }

    }
}
