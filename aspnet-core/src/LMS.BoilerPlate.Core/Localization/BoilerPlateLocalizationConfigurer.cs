using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LMS.BoilerPlate.Localization
{
    public static class BoilerPlateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BoilerPlateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BoilerPlateLocalizationConfigurer).GetAssembly(),
                        "LMS.BoilerPlate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
