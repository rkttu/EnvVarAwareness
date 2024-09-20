namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Deployment Slot related)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class DeploymentSlotsEnv : EnvBase
    {
        /// <summary>
        /// By default, the versions for site extensions are specific to each slot. This prevents unanticipated application behavior due to changing extension versions after a swap. If you want the extension versions to swap as well, set to 0 on all slots.
        /// </summary>
        public string? WebsiteOverrideStickyExtensionVersions => this["WEBSITE_OVERRIDE_STICKY_EXTENSION_VERSIONS"];

        /// <summary>
        /// Designates certain settings as sticky or not swappable by default. Default is true. Set this setting to false or 0 for all deployment slots to make them swappable instead. There's no fine-grain control for specific setting types.
        /// </summary>
        public string? WebsiteOverridePreserveDefaultStickySlotSettings => this["WEBSITE_OVERRIDE_PRESERVE_DEFAULT_STICKY_SLOT_SETTINGS"];

        /// <summary>
        /// Path to ping to warm up the target slot in a swap, beginning with a slash. The default is /, which pings the root path over HTTP.
        /// </summary>
        public string? WebsiteSwapWarmupPingPath => this["WEBSITE_SWAP_WARMUP_PING_PATH"];

        /// <summary>
        /// Valid HTTP response codes for the warm-up operation during a swap. If the returned status code isn't in the list, the warmup and swap operations are stopped. By default, all response codes are valid.
        /// </summary>
        public string? WebsiteSwapWarmupPingStatuses => this["WEBSITE_SWAP_WARMUP_PING_STATUSES"];

        /// <summary>
        /// During a slot swap, maximum number of timeouts after which we force restart the site on a specific VM instance. The default is 3.
        /// </summary>
        public string? WebsiteSlotNumberOfTimeoutsBeforeRestart => this["WEBSITE_SLOT_NUMBER_OF_TIMEOUTS_BEFORE_RESTART"];

        /// <summary>
        /// During a slot swap, maximum number of timeout requests for a single URL to make before giving up. The default is 5.
        /// </summary>
        public string? WebsiteSlotMaxNumberOfTimeouts => this["WEBSITE_SLOT_MAX_NUMBER_OF_TIMEOUTS"];

        /// <summary>
        /// Set to true or 1 to skip all bindings in applicationHost.config. The default is false. If your app triggers a restart because applicationHost.config is updated with the swapped hostnames of th slots, set this variable to true to avoid a restart of this kind. If you're running a Windows Communication Foundation (WCF) app, don't set this variable.
        /// </summary>
        public string? WebsiteSkipAllBindingsInAppHostConfig => this["WEBSITE_SKIP_ALL_BINDINGS_IN_APPHOST_CONFIG"];
    }
}
