

namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification : Notification
    {


        public LikeNotification(Guid likeByUseId):base("Like", Guid.NewGuid(), Guid.NewGuid())
        {
            LikeByUserId = likeByUseId;
        }

        public Guid LikeByUserId { get; private set; }


        public void Message(string message)
        {
            MessageType = message;
        }



        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, LikedByUserId: {LikeByUserId}, ";

        }



    }
}
