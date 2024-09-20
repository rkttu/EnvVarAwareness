namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Node.JS)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class NodeWebAppEnv : EnvBase
    {
        /// <summary>
        /// (Configured by Azure Web Apps system only) For Linux apps, port that the Node.js app listens to in the container.
        /// </summary>
        public string? Port => this["PORT"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) ID of the current instance.
        /// </summary>
        public string? WebsiteRoleInstanceId => this["WEBSITE_ROLE_INSTANCE_ID"];

        /// <summary>
        /// The home directory for the PM2 process manager.
        /// </summary>
        public string? Pm2Home => this["PM2HOME"];

        /// <summary>
        /// For native Windows apps, default node version the app is using. Any of the supported Node.js versions can be used here.
        /// </summary>
        public string? WebsiteNodeDefaultVersion => this["WEBSITE_NODE_DEFAULT_VERSION"];
    }
}
