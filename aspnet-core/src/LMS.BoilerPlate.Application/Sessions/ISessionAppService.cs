using System.Threading.Tasks;
using Abp.Application.Services;
using LMS.BoilerPlate.Sessions.Dto;

namespace LMS.BoilerPlate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
