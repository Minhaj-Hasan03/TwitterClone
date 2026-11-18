using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Role : BaseEnitiies 
    {
        public Role(Guid id ) : base(id) { }
        public string Name { get; set; }


        public List<UserRole> UserRoles = new List<UserRole>();
        public List<RolePermission> RolePermissions = new List<RolePermission>(); 
    }
}
