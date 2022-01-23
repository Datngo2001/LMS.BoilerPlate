using Abp.Authorization;
using LMS.BoilerPlate.Authorization.Roles;
using LMS.BoilerPlate.Authorization.Users;

namespace LMS.BoilerPlate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
