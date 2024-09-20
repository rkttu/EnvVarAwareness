namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Caching)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class CachingEnv : EnvBase
    {
        /// <summary>
        /// Whether local cache is enabled. Available options are:
        /// </summary>
        public string? WebsiteLocalCacheOption => this["WEBSITE_LOCAL_CACHE_OPTION"];

        /// <summary>
        /// Read-write options of the local cache. Available options are:
        /// </summary>
        public string? WebsiteLocalCacheReadWriteOption => this["WEBSITE_LOCAL_CACHE_READWRITE_OPTION"];

        /// <summary>
        /// Size of the local cache in MB. Default is 1000 (1 GB).
        /// </summary>
        public string? WebsiteLocalCacheSizeInMB => this["WEBSITE_LOCAL_CACHE_SIZEINMB"];

        /// <summary>
        /// Read-only flag indicating if the app using local cache.
        /// </summary>
        public string? WebsiteLocalCacheReady => this["WEBSITE_LOCALCACHE_READY"];

        /// <summary>
        /// Due to network file shared nature to allow access for multiple instances, the dynamic cache improves performance by caching the recently accessed files locally on an instance. Cache is invalidated when file is modified. The cache location is %SYSTEMDRIVE%\local\DynamicCache (same %SYSTEMDRIVE%\local quota is applied). To enable full content caching, set to 1, which includes both file content and directory/file metadata (timestamps, size, directory content). To conserve local disk use, set to 2 to cache only directory/file metadata (timestamps, size, directory content). To turn off caching, set to 0. For Windows apps and for Linux apps created with the WordPress template, the default is 1. For all other Linux apps, the default is 0.
        /// </summary>
        public string? WebsiteDynamicCache => this["WEBSITE_DYNAMIC_CACHE"];

        /// <summary>
        /// When using dynamic cache, you can disable write access to the app root (D:\home\site\wwwroot or /home/site/wwwroot) by setting this variable to 1. Except for the App_Data directory, no exclusive locks are allowed, so that deployments don't get blocked by locked files.
        /// </summary>
        public string? WebsiteReadOnlyApp => this["WEBSITE_READONLY_APP"];
    }
}
