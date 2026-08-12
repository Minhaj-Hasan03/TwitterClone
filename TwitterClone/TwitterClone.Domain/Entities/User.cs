using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class User:BaseEnitiies
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

        

        public Guid UserId { get { return _userId;  } private set { _userId = value; } }

        public string FirstName { get { return _firstName;  } private set { _firstName = value; }  }
        public string LastName { get { return _lastName; } private set { _lastName = value; } }
        public string Email { get { return _email; } private set { _email = value; } }
        public string UserName { get { return _userName; } private set { _userName = value; } }





       




    }
}
