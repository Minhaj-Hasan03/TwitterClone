using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Constants;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.SeedData
{
    public static class SeedData
    {

        public static Role[] Roles()
        {
            return new Role[]
            {
                new Role(Guid.Parse("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745")) { Name = RoleNames.Admin },
    new Role(Guid.Parse("7a7513f6-60f0-4f86-bd59-c42c8146181e")) { Name = RoleNames.Moderator },
    new Role(Guid.Parse("35c51d71-265b-4d16-8bf2-0133c505769c")) { Name = RoleNames.User }

            };

        }


        public static Permission[] Permissions()
        {
            return new Permission[]{
               new Permission(Guid.Parse("ed986696-6f4a-49a6-a4da-cd072c4a3020")) { Name = PermissionName.UsersRead },
    new Permission(Guid.Parse("ab069366-28e0-485a-81ca-9c1bc439ec10")) { Name = PermissionName.UsersDelete },
    new Permission(Guid.Parse("d2d58110-2690-460c-9f11-05633234ea37")) { Name = PermissionName.RolesManage }


            };
        }


        public static RolePermission[] RolePermissions()
        {
            return new RolePermission[]
            {

                new RolePermission(Guid.NewGuid()){ RoleId = Guid.Parse("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745"), PermissionId= Guid.Parse("ed986696-6f4a-49a6-a4da-cd072c4a3020")},
                new RolePermission(Guid.NewGuid()){ RoleId = Guid.Parse("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745"), PermissionId= Guid.Parse("ab069366-28e0-485a-81ca-9c1bc439ec10")},
                new RolePermission(Guid.NewGuid()){ RoleId = Guid.Parse("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745"), PermissionId= Guid.Parse("d2d58110-2690-460c-9f11-05633234ea37")},



                new RolePermission(Guid.NewGuid()){ RoleId = Guid.Parse("7a7513f6-60f0-4f86-bd59-c42c8146181e"), PermissionId= Guid.Parse("ed986696-6f4a-49a6-a4da-cd072c4a3020")},
                new RolePermission(Guid.NewGuid()){ RoleId = Guid.Parse("7a7513f6-60f0-4f86-bd59-c42c8146181e"), PermissionId= Guid.Parse("ab069366-28e0-485a-81ca-9c1bc439ec10")}

            };
        }

    }
}
