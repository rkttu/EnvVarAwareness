namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Scaling)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppScalingEnv : EnvBase
    {
        /// <summary>
        /// Read-only. Unique ID of the current VM instance, when the app is scaled out to multiple instances.
        /// </summary>
        public string? WebsiteInstanceId => this["WEBSITE_INSTANCE_ID"];

        /// <summary>
        /// Deprecated. Use WEBSITE_INSTANCE_ID.
        /// </summary>
        public string? WebsiteIISSiteName => this["WEBSITE_IIS_SITE_NAME"];

        /// <summary>
        /// Overlapped recycling makes it so that before the current VM instance of an app is shut down, a new VM instance starts. In some cases, it can cause file locking issues. You can try turning it off by setting to 1.
        /// </summary>
        public string? WebsiteDisableOverlappedRecycling => this["WEBSITE_DISABLE_OVERLAPPED_RECYCLING"];

        /// <summary>
        /// By default, apps are allowed to scale across stamps if they use Azure Files or a Docker container. Set to 1 or true to disable cross-stamp scaling within the app's region. The default is 0. Custom Docker containers that set WEBSITES_ENABLE_APP_SERVICE_STORAGE to true or 1 can't scale cross-stamps because their content isn't completely encapsulated in the Docker container.
        /// </summary>
        public string? WebsiteDisableCrossStampScale => this["WEBSITE_DISABLE_CROSS_STAMP_SCALE"];
    }
}
