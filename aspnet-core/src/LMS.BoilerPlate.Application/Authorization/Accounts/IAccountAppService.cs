using System.Threading.Tasks;
using Abp.Application.Services;
using LMS.BoilerPlate.Authorization.Accounts.Dto;

namespace LMS.BoilerPlate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
