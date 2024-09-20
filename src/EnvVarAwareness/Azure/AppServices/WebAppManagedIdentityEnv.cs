using System;

namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Managed Identity)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppManagedIdentityEnv : EnvBase
    {
        /// <summary>
        /// Read-only. The URL to retrieve the token for the app's managed identity.
        /// </summary>
        public string? IdentityEndpoint => this["IDENTITY_ENDPOINT"];

        /// <summary>
        /// Deprecated. Use IDENTITY_ENDPOINT.
        /// </summary>
        [Obsolete("Deprecated. Use IdentityEndpoint.")]
        public string? MSIEndpoint => this["MSI_ENDPOINT"];

        /// <summary>
        /// Read-only. Value that must be added to the X-IDENTITY-HEADER header when making an HTTP GET request to IDENTITY_ENDPOINT. The value is rotated by the platform.
        /// </summary>
        public string? IdentityHeader => this["IDENTITY_HEADER"];

        /// <summary>
        /// Deprecated. Use IDENTITY_HEADER.
        /// </summary>
        [Obsolete("Deprecated. Use IdentityHeader.")]
        public string? MSISecret => this["MSI_SECRET"];
    }
}
