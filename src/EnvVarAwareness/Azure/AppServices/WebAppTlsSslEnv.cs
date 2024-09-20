namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (TLS/SSL)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppTlsSslEnv : EnvBase
    {
        /// <summary>
        /// Comma-separate thumbprint values to the certificate you want to load in your code, or * to allow all certificates to be loaded in code. Only certificates added to your app can be loaded.
        /// </summary>
        public string? WebsiteLoadCertificates => this["WEBSITE_LOAD_CERTIFICATES"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Path in a Windows container to the loaded private certificates.
        /// </summary>
        public string? WebsitePrivateCertsPath => this["WEBSITE_PRIVATE_CERTS_PATH"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Path in a Windows container to the loaded public certificates.
        /// </summary>
        public string? WebsitePublicCertsPath => this["WEBSITE_PUBLIC_CERTS_PATH"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Path in a Windows container to the loaded intermediate certificates.
        /// </summary>
        public string? WebsiteIntermediateCertsPath => this["WEBSITE_INTERMEDIATE_CERTS_PATH"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Path in a Windows container to the loaded root certificates.
        /// </summary>
        public string? WebsiteRootCertsPath => this["WEBSITE_ROOT_CERTS_PATH"];
    }
}
