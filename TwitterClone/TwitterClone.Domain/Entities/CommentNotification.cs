

namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification:Notification
    {


        public CommentNotification(Guid commentedUserId) : base("Comment", Guid.NewGuid(), Guid.NewGuid())
        {
            CommentedUserId = commentedUserId;
        }

        public Guid CommentedUserId { get; private set; }

        public void Message(string message)
        {
            MessageType = message;
        }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, CommentedUserId: {CommentedUserId}, ";

        }

        public override string GetMessage()
        {
            return $"{CommentedUserId} is comment on your tweet";
        }
    }
}
