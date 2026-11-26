using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Constants
{
    public class RoleNames
    {

        public const string ClaimType = "role";
        public const string Admin = "Admin";
        public const string Moderator = "Moderator";
        public const string User = "User";

    }


    public static class PermissionName
    {

        public const string ClaimType = "permission";

        public const string UsersRead = "users.read";
        public const string UsersDelete = "users.delete";

        public const string RolesManage = "roles.manage";


        public static readonly string[] All = {UsersRead, UsersDelete, RolesManage};

    }
}