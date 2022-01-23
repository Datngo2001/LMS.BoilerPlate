using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LMS.BoilerPlate.Authorization.Roles;
using LMS.BoilerPlate.Authorization.Users;
using LMS.BoilerPlate.MultiTenancy;

namespace LMS.BoilerPlate.EntityFrameworkCore
{
    public class BoilerPlateDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerPlateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerPlateDbContext(DbContextOptions<BoilerPlateDbContext> options)
            : base(options)
        {
        }
    }
}
