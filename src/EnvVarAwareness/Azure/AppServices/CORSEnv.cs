namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (CORS)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class CORSEnv : EnvBase
    {
        /// <summary>
        /// Read-only. Shows the allowed origins for CORS.
        /// </summary>
        public string? WebsiteCORSAllowedOrigins => this["WEBSITE_CORS_ALLOWED_ORIGINS"];

        /// <summary>
        /// Read-only. Shows whether setting the Access-Control-Allow-Credentials header to true is enabled (True) or not (False).
        /// </summary>
        public string? WebsiteCORSSupportCredentials => this["WEBSITE_CORS_SUPPORT_CREDENTIALS"];
    }
}
