namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/PHP Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxPHPEnv : EnvBase
    {
        /// <summary>
        /// Specify which Php version the app is using
        /// </summary>
        public string? PhpVersion => this["PHP_VERSION"];

        /// <summary>
        /// Specify which Php version the app defaults to if none detected
        /// </summary>
        public string? PhpDefaultVersion => this["PHP_DEFAULT_VERSION"];

        /// <summary>
        /// Specify which Php composer version the app is using
        /// </summary>
        public string? PhpComposerVersion => this["PHP_COMPOSER_VERSION"];

        /// <summary>
        /// Specify which Php composer version the app defaults to if none detected
        /// </summary>
        public string? PhpComposerDefaultVersion => this["PHP__COMPOSER_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the PHP build disabled even if repo indicates it
        /// </summary>
        public string? DisablePhpBuild => this["DISABLE_PHP_BUILD"];

        /// <summary>
        /// The maximum number of child processes to be created
        /// </summary>
        public string? FpmMaxChildren => this["FPM_MAX_CHILDREN"];

        /// <summary>
        /// The number of child processes created on startup
        /// </summary>
        public string? FpmStartServers => this["FPM_START_SERVERS"];

        /// <summary>
        /// The desired maximum number of idle server processes
        /// </summary>
        public string? FpmMaxSpareServers => this["FPM_MAX_SPARE_SERVERS"];

        /// <summary>
        /// The desired minimum number of idle server processes
        /// </summary>
        public string? FpmMinSpareServers => this["FPM_MIN_SPARE_SERVERS"];
    }
}
