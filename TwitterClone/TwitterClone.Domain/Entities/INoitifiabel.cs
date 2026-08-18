using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public interface INoitifiabel
    {
        void AddNotification(Guid notificationId);
    }
}
