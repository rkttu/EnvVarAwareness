namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/Hugo Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxHugoEnv : EnvBase
    {
        /// <summary>
        /// Specify which Hugo version the app is using
        /// </summary>
        public string? HugoVersion => this["HUGO_VERSION"];

        /// <summary>
        /// Specify which Hugo version the app defaults to if none detected
        /// </summary>
        public string? HugoDefaultVersion => this["HUGO_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the Hugo build disabled even if repo indicates it
        /// </summary>
        public string? DisableHugoBuild => this["DISABLE_HUGO_BUILD"];
    }
}
