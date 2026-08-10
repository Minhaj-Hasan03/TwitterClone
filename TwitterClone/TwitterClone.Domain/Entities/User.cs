using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _email;
        private DateTime _createdBy;


        public User() 
        {
            _id = Guid.NewGuid();
            _createdBy = DateTime.UtcNow;
        }

        public Guid Id { get { return _id; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public void SetAll( string firstname, string lastName, string userName)
        {
            FirstName = firstname; 
            LastName = lastName;
            UserName = userName;
        }


    }
}
