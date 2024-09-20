namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Push Notification)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppPushNotificationEnv : EnvBase
    {
        /// <summary>
        /// Read-only. Added when push notifications are enabled.
        /// </summary>
        public string? WebsitePushEnabled => this["WEBSITE_PUSH_ENABLED"];

        /// <summary>
        /// Read-only. Contains the tags in the notification registration.
        /// </summary>
        public string? WebsitePushTagWhitelist => this["WEBSITE_PUSH_TAG_WHITELIST"];

        /// <summary>
        /// Read-only. Contains a list of tags in the notification registration that requires user authentication.
        /// </summary>
        public string? WebsitePushTagsRequiringAuth => this["WEBSITE_PUSH_TAGS_REQUIRING_AUTH"];

        /// <summary>
        /// Read-only. Contains a list of tags in the notification registration that were added automatically.
        /// </summary>
        public string? WebsitePushTagsDynamic => this["WEBSITE_PUSH_TAGS_DYNAMIC"];
    }
}
