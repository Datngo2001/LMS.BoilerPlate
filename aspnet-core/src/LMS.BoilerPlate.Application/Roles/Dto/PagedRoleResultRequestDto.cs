using Abp.Application.Services.Dto;

namespace LMS.BoilerPlate.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

