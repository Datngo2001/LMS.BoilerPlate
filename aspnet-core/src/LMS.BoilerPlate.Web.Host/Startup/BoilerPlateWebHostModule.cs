using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LMS.BoilerPlate.Configuration;

namespace LMS.BoilerPlate.Web.Host.Startup
{
    [DependsOn(
       typeof(BoilerPlateWebCoreModule))]
    public class BoilerPlateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerPlateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateWebHostModule).GetAssembly());
        }
    }
}
