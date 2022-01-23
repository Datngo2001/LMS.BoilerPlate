using Abp.Application.Services;
using LMS.BoilerPlate.MultiTenancy.Dto;

namespace LMS.BoilerPlate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

