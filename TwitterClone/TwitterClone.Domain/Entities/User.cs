using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class User:BaseEnitiies, IFollowable, INotifiable
    {
        private Guid _userId;
        
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _email;

       

        public User(string firstname, string lastName, string userName, string email ) :base(Guid.NewGuid())
        {
            FirstName = firstname; 
            LastName = lastName;
            UserName = userName;
            Email = email;
        }

        

        public Guid UserId { get { return _userId;  }  set { _userId = value; } }

        public string FirstName { get { return _firstName;  }  set { _firstName = value; }  }
        public string LastName { get { return _lastName; }  set { _lastName = value; } }
        public string Email { get { return _email; }  set { _email = value; } }
        public string UserName { get { return _userName; }  set { _userName = value; } }




        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _recievingNotification = new List<Guid>();
       


        public void Follow(Guid userId)
        {
            if( !_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }

        public void UnFollow( Guid userId)
        {
            if( _followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if (!_recievingNotification.Contains(notificationId))
            {
                _recievingNotification.Add(notificationId);
            }
        }


    }
}
