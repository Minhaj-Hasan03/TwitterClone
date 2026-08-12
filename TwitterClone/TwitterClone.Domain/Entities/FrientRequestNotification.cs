
namespace TwitterClone.Domain.Entities
{
    public sealed class FrientRequestNotification : Notification
    {
            
        public FrientRequestNotification(Guid frientRequestId ) :base("FrientRequest", Guid.NewGuid(), Guid.NewGuid())
        { 
            FriendRequestUserId = frientRequestId;
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

    }
}
