namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Python)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class PythonWebAppEnv : EnvBase
    {
        /// <summary>
        /// (Configured by Azure Web Apps system only) Specify Python virtual environment name
        /// </summary>
        public string? AppServiceVirtualEnvironment => this["APPSVC_VIRTUAL_ENV"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For Linux apps, port that the Python app listens to in the container.
        /// </summary>
        public string? Port => this["PORT"];
    }
}
