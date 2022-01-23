using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LMS.BoilerPlate.Configuration.Dto;

namespace LMS.BoilerPlate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoilerPlateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
