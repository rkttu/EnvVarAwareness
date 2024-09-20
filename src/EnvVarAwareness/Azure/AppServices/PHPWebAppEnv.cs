namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (PHP)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class PHPWebAppEnv : EnvBase
    {
        /// <summary>
        /// Comma-separated list of PHP extensions.
        /// </summary>
        public string? PHPExtensions => this["PHP_Extensions"];

        /// <summary>
        /// For Linux apps, set to xdebug to use the XDebug version of the PHP container.
        /// </summary>
        public string? PHPZendExtensions => this["PHP_ZENDEXTENSIONS"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) The selected PHP version.
        /// </summary>
        public string? PHPVersion => this["PHP_VERSION"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Port that Apache server listens to in the container.
        /// </summary>
        public string? WebsitePort => this["WEBSITE_PORT"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) ID of the current instance.
        /// </summary>
        public string? WebsiteRoleInstanceId => this["WEBSITE_ROLE_INSTANCE_ID"];

        /// <summary>
        /// Set to TRUE to add xdebug.profiler_enable_trigger=1 and xdebug.profiler_enable=0 to the default php.ini.
        /// </summary>
        public string? WebsiteProfilerEnableTrigger => this["WEBSITE_PROFILER_ENABLE_TRIGGER"];
    }
}
