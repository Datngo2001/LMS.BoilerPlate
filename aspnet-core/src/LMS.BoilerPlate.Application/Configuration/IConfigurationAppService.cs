using System.Threading.Tasks;
using LMS.BoilerPlate.Configuration.Dto;

namespace LMS.BoilerPlate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
