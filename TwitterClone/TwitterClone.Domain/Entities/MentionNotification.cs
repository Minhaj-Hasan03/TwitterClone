

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification :Notification
    {

        public MentionNotification(Guid mentionId) : base("Mention", Guid.NewGuid(), Guid.NewGuid())
        {
             
        }


        public Guid MentionId { get; private set; }

        public void Message(string message)
        {
            MessageType = message;
        }


        public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, MentionId: {MentionId}, ";

        }


        public override string GetMessage()
        {
            return $"You have been mentioned by {MentionId} in a tweet ";
        }
    }
}
