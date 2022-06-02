using EventCloud.Debugging;

namespace EventCloud
{
    public class EventCloudConsts
    {
        public const string LocalizationSourceName = "EventCloud";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1a2244c9e80d4d5ebb9cf9cb6d8fdb59";
    }
}
