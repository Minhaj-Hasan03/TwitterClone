using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Permission : BaseEnitiies
    {
        public Permission(Guid id) : base(id) { }
        public string Name { get; set; }



        public List<RolePermission> RolePermissions = new List<RolePermission>();
    }
}
