namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/Golang Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxGolangEnv : EnvBase
    {
        /// <summary>
        /// Specify which Golang version the app is using
        /// </summary>
        public string? GolangVersion => this["GOLANG_VERSION"];

        /// <summary>
        /// Specify which Golang version the app defaults to if none detected
        /// </summary>
        public string? GolangDefaultVersion => this["GOLANG_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the Golang build disabled even if repo indicates it
        /// </summary>
        public string? DisableGolangBuild => this["DISABLE_GOLANG_BUILD"];
    }
}
