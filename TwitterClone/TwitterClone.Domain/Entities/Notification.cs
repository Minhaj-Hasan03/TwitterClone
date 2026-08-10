using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    internal class Notification
    {
        private Guid _notificationId;
        private string _notificationType;

        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _updatedBy;




        public Notification(string Type )
        {
            _notificationType = Type;
            _notificationId = Guid.NewGuid();
            _createdBy = Guid.NewGuid();
        }


        public Guid UserId { get; set; }

        public void SetUserId( Guid userId ) { UserId = userId; }


        public Guid UpdateBy { get { return _updatedBy; } private set { _updatedBy = value; } }

        public void CreatedAt()
        {
            _createdAt = DateTime.UtcNow;
        }

        public void UpdateAt()
        {
            _updatedAt = DateTime.UtcNow;
        }


    }
}
