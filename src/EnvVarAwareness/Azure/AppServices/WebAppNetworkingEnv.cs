namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Networking)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppNetworkingEnv : EnvBase
    {
        /// <summary>
        /// Read-only. Data needed to configure the Hybrid Connection, including endpoints and service bus data.
        /// </summary>
        public string? WebsiteRelays => this["WEBSITE_RELAYS"];

        /// <summary>
        /// Read-only. Used at runtime to do the lookups and rewrite connections appropriately.
        /// </summary>
        public string? WebsiteRewriteTable => this["WEBSITE_REWRITE_TABLE"];

        /// <summary>
        /// By default, if you use regional VNet Integration, your app only routes RFC1918 traffic into your VNet. Set to 1 to route all outbound traffic into your VNet and be subject to the same NSGs and UDRs. The setting lets you access non-RFC1918 endpoints through your VNet, secure all outbound traffic leaving your app, and force tunnel all outbound traffic to a network appliance of your own choosing.
        /// </summary>
        public string? WebsiteVnetRouteAll => this["WEBSITE_VNET_ROUTE_ALL"];

        /// <summary>
        /// Read-only. IP address associated with the app when integrated with a VNet. For Regional VNet Integration, the value is an IP from the address range of the delegated subnet, and for Gateway-required VNet Integration, the value is an IP from the address range of the point-to-site address pool configured on the Virtual Network Gateway. This IP is used by the app to connect to the resources through the VNet. Also, it can change within the described address range.
        /// </summary>
        public string? WebsitePrivateIP => this["WEBSITE_PRIVATE_IP"];

        /// <summary>
        /// Read-only. In VNet integration, shows which ports are useable by the app to communicate with other nodes.
        /// </summary>
        public string? WebsitePrivatePorts => this["WEBSITE_PRIVATE_PORTS"];

        /// <summary>
        /// If you are mounting an Azure File Share on the App Service and the Storage account is restricted to a VNET, ensure to enable this setting with a value of 1.
        /// </summary>
        public string? WebsiteContentOverVNet => this["WEBSITE_CONTENTOVERVNET"];
    }
}
