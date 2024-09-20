namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (KeyVault References)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppKeyVaultRefEnv : EnvBase
    {
        /// <summary>
        /// Read-only. Contains information (including statuses) for all Key Vault references that are currently configured in the app.
        /// </summary>
        public string? WebsiteKeyvaultReferences => this["WEBSITE_KEYVAULT_REFERENCES"];

        /// <summary>
        /// If you set the shared storage connection of your app (using WEBSITE_CONTENTAZUREFILECONNECTIONSTRING) to a Key Vault reference, the app can't resolve the key vault reference at app creation or update if one of the following conditions is true:
        /// </summary>
        public string? WebsiteSkipContentShareValidation => this["WEBSITE_SKIP_CONTENTSHARE_VALIDATION"];

        /// <summary>
        /// This env var can be set to 1 by users in order to ensure that a certificate that a worker process is dependent upon isn't deleted until it exits.
        /// </summary>
        public string? WebsiteDelayCertDeletion => this["WEBSITE_DELAY_CERT_DELETION"];
    }
}
