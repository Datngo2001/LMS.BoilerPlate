using LMS.BoilerPlate.Debugging;

namespace LMS.BoilerPlate
{
    public class BoilerPlateConsts
    {
        public const string LocalizationSourceName = "BoilerPlate";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "eba175d9a9a241e1828b9467bb511984";
    }
}
