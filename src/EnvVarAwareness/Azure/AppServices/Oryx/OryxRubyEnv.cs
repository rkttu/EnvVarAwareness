namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/Ruby Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxRubyEnv : EnvBase
    {
        /// <summary>
        /// Specify which Ruby version the app is using
        /// </summary>
        public string? RubyVersion => this["RUBY_VERSION"];

        /// <summary>
        /// Specify which Ruby version the app defaults to if none detected
        /// </summary>
        public string? RubyDefaultVersion => this["RUBY_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the Ruby build disabled even if repo indicates it
        /// </summary>
        public string? DisableRubyBuild => this["DISABLE_RUBY__BUILD"];
    }
}
