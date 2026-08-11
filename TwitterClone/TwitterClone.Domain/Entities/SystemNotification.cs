

namespace TwitterClone.Domain.Entities
{
    public sealed class SystemNotification:Notification
    {
        public SystemNotification():base("System", Guid.NewGuid(), Guid.NewGuid() )
        {

        }

        public void Message(string message)
        {
            MessageType = message;
        }

        public override string Description()
        {
            return base.Description();
        }

    }
}
