using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class RolePermission : BaseEnitiies
    {
        public RolePermission(Guid Id) : base(Id) { }
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null;


        public Guid PermissionId { get; set; }
        public Permission Permission { get; set; } = null;
    }
}
