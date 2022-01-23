using Abp.MultiTenancy;
using LMS.BoilerPlate.Authorization.Users;

namespace LMS.BoilerPlate.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
