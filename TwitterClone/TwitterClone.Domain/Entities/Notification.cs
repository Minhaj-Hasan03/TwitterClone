using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public abstract class Notification:BaseEnitiies
    {
       
        private Guid _notificationId;
        private string? _notificationType;

        private Guid _userId;
        private string? _message;
       




        public Notification(string notificationType , Guid notificationId , Guid userId ):base(Guid.NewGuid())
        {
            UserId = userId;
            NotificationId = notificationId;
            NotificationType = notificationType;
        }


        public Guid UserId { get { return _userId; } private set { _userId = value; }  }

        public Guid NotificationId { get { return _notificationId; } private  set { _notificationId = value; } }
        public string NotificationType { get { return _notificationType; } private set { _notificationType = value; } }


        protected string MessageType
        {
            get { return _message; }
            set { _message = value; }
        }

         public override string Description()
        {
            var baseDescription = base.Description();
            return $"{baseDescription}, UserId: {UserId}, NotificationId: {NotificationId}, NotificationType: {NotificationType}, MessageType: {MessageType}";
        }


        public abstract string GetMessage();
       



        

    }
}
