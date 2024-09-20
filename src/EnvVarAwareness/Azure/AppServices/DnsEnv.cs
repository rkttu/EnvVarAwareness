namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (DNS)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class DnsEnv : EnvBase
    {
        /// <summary>
        /// IP address of primary DNS server for outgoing connections (such as to a back-end service). The default DNS server for App Service is Azure DNS, whose IP address is 168.63.129.16. If your app uses VNet integration or is in an App Service environment, it inherits the DNS server configuration from the VNet by default.
        /// </summary>
        public string? WebsiteDnsServer => this["WEBSITE_DNS_SERVER"];

        /// <summary>
        /// IP address of fallback DNS server for outgoing connections. See WEBSITE_DNS_SERVER.
        /// </summary>
        public string? WebsiteDnsAltServer => this["WEBSITE_DNS_ALT_SERVER"];

        /// <summary>
        /// Allows successful DNS resolutions to be cached. By Default expired DNS cache entries will be flushed &amp; in addition to the existing cache to be flushed every 4.5 mins.
        /// </summary>
        public string? WebsiteEnableDnsCache => this["WEBSITE_ENABLE_DNS_CACHE"];
    }
}
