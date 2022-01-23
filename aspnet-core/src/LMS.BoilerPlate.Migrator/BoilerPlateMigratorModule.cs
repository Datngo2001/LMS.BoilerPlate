using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LMS.BoilerPlate.Configuration;
using LMS.BoilerPlate.EntityFrameworkCore;
using LMS.BoilerPlate.Migrator.DependencyInjection;

namespace LMS.BoilerPlate.Migrator
{
    [DependsOn(typeof(BoilerPlateEntityFrameworkModule))]
    public class BoilerPlateMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerPlateMigratorModule(BoilerPlateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(BoilerPlateMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                BoilerPlateConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
