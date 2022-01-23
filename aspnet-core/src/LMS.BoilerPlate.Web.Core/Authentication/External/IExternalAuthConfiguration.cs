using System.Collections.Generic;

namespace LMS.BoilerPlate.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
