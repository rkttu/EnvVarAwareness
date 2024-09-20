using System.Collections.Generic;

namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppEnv : EnvBase
    {
        /// <summary>
        /// Signifies that a variable is set by the customer as an app setting in the app configuration. It's injected into a .NET app as an app setting.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAppSettingVariables()
            => GetEnvironmentVariables("APPSETTING_");

        /// <summary>
        /// Signifies a variable is specific to the app itself.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetMainSiteVariables()
            => GetEnvironmentVariables("MAINSITE_");

        /// <summary>
        /// Signifies a variable is specific to the Kudu app.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetScmSiteVariables()
            => GetEnvironmentVariables("SCMSITE_");

        /// <summary>
        /// Signifies a SQL Server connection string in the app configuration. It's injected into a .NET app as a connection string.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetSqlConnectionStringVariables()
            => GetEnvironmentVariables("SQLCONNSTR_");

        /// <summary>
        /// Signifies an Azure SQL Database connection string in the app configuration. It's injected into a .NET app as a connection string.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAzureSqlDatabaseConnectionStringVariables()
            => GetEnvironmentVariables("SQLAZURECONNSTR_");

        /// <summary>
        /// Signifies a PostgreSQL connection string in the app configuration. It's injected into a .NET app as a connection string.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetPgsqlDatabaseConnectionStringVariables()
            => GetEnvironmentVariables("POSTGRESQLCONNSTR_");

        /// <summary>
        /// Signifies a custom connection string in the app configuration. It's injected into a .NET app as a connection string.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetCustomConnectionStringVariables()
            => GetEnvironmentVariables("CUSTOMCONNSTR_");

        /// <summary>
        /// Signifies a MySQL Database connection string in the app configuration. It's injected into a .NET app as a connection string.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetMySqlConnectionStringVariables()
            => GetEnvironmentVariables("MYSQLCONNSTR_");

        /// <summary>
        /// A connection string to a custom share for a custom container in Azure Files.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAzureFileStorageConnectionStringVariables()
            => GetEnvironmentVariables("AZUREFILESSTORAGE_");

        /// <summary>
        /// A connection string to a custom storage account for a custom container in Azure Blob Storage.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAzureBlobStorageConnectionStringVariables()
            => GetEnvironmentVariables("AZUREBLOBSTORAGE_");

        /// <summary>
        /// Signifies a connection string to a notification hub in Azure Notification Hubs.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetNotificationHubConnectionStringVariables()
            => GetEnvironmentVariables("NOTIFICATIONHUBCONNSTR_");

        /// <summary>
        /// Signifies a connection string to an instance of Azure Service Bus.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetServiceBusConnectionStringVariables()
            => GetEnvironmentVariables("SERVICEBUSCONNSTR_");

        /// <summary>
        /// Signifies a connection string to an event hub in Azure Event Hubs.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetEventHubConnectionStringVariables()
            => GetEnvironmentVariables("EVENTHUBCONNSTR_");

        /// <summary>
        /// Signifies a connection string to a database in Azure Cosmos DB.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAzureCosmosDBConnectionStringVariables()
            => GetEnvironmentVariables("DOCDBCONNSTR_");

        /// <summary>
        /// Signifies a connection string to a cache in Azure Cache for Redis.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAzureCacheForRedisConnectionStringVariables()
             => GetEnvironmentVariables("REDISCACHECONNSTR_");

        /// <summary>
        /// Signifies a connection string to a custom file share.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetCustomFileShareStorageConnectionStringVariables()
            => GetEnvironmentVariables("FILESHARESTORAGE_");

        /// <summary>
        /// (Configured by Azure Web Apps system only) App name.
        /// </summary>
        public string? WebsiteSiteName => this["WEBSITE_SITE_NAME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Azure resource group name that contains the app resource.
        /// </summary>
        public string? WebsiteResourceGroup => this["WEBSITE_RESOURCE_GROUP"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Contains the Azure subscription ID that owns the app, the resource group, and the webspace.
        /// </summary>
        public string? WebsiteOwnerName => this["WEBSITE_OWNER_NAME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Region name of the app.
        /// </summary>
        public string? RegionName => this["REGION_NAME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) App Service platform version.
        /// </summary>
        public string? WebsitePlatformVersion => this["WEBSITE_PLATFORM_VERSION"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Path to the home directory (for example, D:\home for Windows).
        /// </summary>
        public string? Home => this["HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) The port the app should listen to.
        /// </summary>
        public string? ServerPort => this["SERVER_PORT"];

        /// <summary>
        /// A relative path to ping to warm up the app, beginning with a slash. The default is /, which pings the root path. The specific path can be pinged by an unauthenticated client, such as Azure Traffic Manager, even if App Service authentication is set to reject unauthenticated clients. (NOTE: This app setting doesn't change the path used by AlwaysOn.)	
        /// </summary>
        public string? WebsiteWarmupPath => this["WEBSITE_WARMUP_PATH"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Specifies whether app runs on dedicated (Dedicated) or shared (Shared) VM/s.
        /// </summary>
        public string? WebsiteComputeMode => this["WEBSITE_COMPUTE_MODE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) SKU of the app. Possible values are Free, Shared, Basic, and Standard.
        /// </summary>
        public string? WebsiteSku => this["WEBSITE_SKU"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Shows whether the app is 32-bit (x86) or 64-bit (AMD64).
        /// </summary>
        public string? SiteBitness => this["SITE_BITNESS"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Primary hostname for the app. Custom hostnames aren't accounted for here.
        /// </summary>
        public string? WebsiteHostname => this["WEBSITE_HOSTNAME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Shows the storage volume type currently in use.
        /// </summary>
        public string? WebsiteVolumeType => this["WEBSITE_VOLUME_TYPE"];

        /// <summary>
        /// Default npm version the app is using.
        /// </summary>
        public string? WebsiteNPMDefaultVersion => this["WEBSITE_NPM_DEFAULT_VERSION"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Limit for websocket's concurrent requests. For Standard tier and above, the value is -1, but there's still a per VM limit based on your VM size (see Cross VM Numerical Limits).
        /// </summary>
        public string? WebsocketConcurrentRequestLimit => this["WEBSOCKET_CONCURRENT_REQUEST_LIMIT"];

        /// <summary>
        /// Set to 0 to disable the use of private site extensions.
        /// </summary>
        public string? WebsitePrivateExtensions => this["WEBSITE_PRIVATE_EXTENSIONS"];

        /// <summary>
        /// By default, the time zone for the app is always UTC. You can change it to any of the valid values that are listed in Default Time Zones. If the specified value isn't recognized, UTC is used.
        /// </summary>
        public string? WebsiteTimeZone => this["WEBSITE_TIME_ZONE"];

        /// <summary>
        /// After slot swaps, the app may experience unexpected restarts. This is because after a swap, the hostname binding configuration goes out of sync, which by itself doesn't cause restarts. However, certain underlying storage events (such as storage volume failovers) may detect these discrepancies and force all worker processes to restart. To minimize these types of restarts, set the app setting value to 1on all slots (default is0). However, don't set this value if you're running a Windows Communication Foundation (WCF) application. For more information, see Troubleshoot swaps.
        /// </summary>
        public string? WebsiteAddSitenameBindingsInApphostConfig => this["WEBSITE_ADD_SITENAME_BINDINGS_IN_APPHOST_CONFIG"];

        /// <summary>
        /// By default, a VM instance is proactively "autohealed" when it's using more than 90% of allocated memory for more than 30 seconds, or when 80% of the total requests in the last two minutes take longer than 200 seconds. If a VM instance has triggered one of these rules, the recovery process is an overlapping restart of the instance. Set to false to disable this recovery behavior. The default is true. For more information, see Proactive Auto Heal.
        /// </summary>
        public string? WebsiteProactiveAutohealEnabled => this["WEBSITE_PROACTIVE_AUTOHEAL_ENABLED"];

        /// <summary>
        /// Whenever the w3wp.exe process on a VM instance of your app crashes due to an unhandled exception for more than three times in 24 hours, a debugger process is attached to the main worker process on that instance, and collects a memory dump when the worker process crashes again. This memory dump is then analyzed and the call stack of the thread that caused the crash is logged in your App Service's logs. Set to false to disable this automatic monitoring behavior. The default is true. For more information, see Proactive Crash Monitoring.
        /// </summary>
        public string? WebsiteProactiveCrashMonitoringEnabled => this["WEBSITE_PROACTIVE_CRASHMONITORING_ENABLED"];

        /// <summary>
        /// During crash monitoring (proactive or manual), the memory dumps are deleted by default. To save the memory dumps to a storage blob container, specify the SAS URI.
        /// </summary>
        public string? WebsiteDAASStorageSASURI => this["WEBSITE_DAAS_STORAGE_SASURI"];

        /// <summary>
        /// Set to true to enable crash monitoring manually. You must also set WEBSITE_DAAS_STORAGE_SASURI and WEBSITE_CRASHMONITORING_SETTINGS. The default is false. This setting has no effect if remote debugging is enabled. Also, if this setting is set to true, proactive crash monitoring is disabled.
        /// </summary>
        public string? WebsiteCrashMonitoringEnabled => this["WEBSITE_CRASHMONITORING_ENABLED"];

        /// <summary>
        /// A JSON with the following format:{"StartTimeUtc": "2020-02-10T08:21","MaxHours": "&lt;elapsed-hours-from-StartTimeUtc&gt;","MaxDumpCount": "&lt;max-number-of-crash-dumps&gt;"}. Required to configure crash monitoring if WEBSITE_CRASHMONITORING_ENABLED is specified. To only log the call stack without saving the crash dump in the storage account, add ,"UseStorageAccount":"false" in the JSON.
        /// </summary>
        public string? WebsiteCrashMonitoringSettings => this["WEBSITE_CRASHMONITORING_SETTINGS"];

        /// <summary>
        /// Remote debugging version.
        /// </summary>
        public string? RemoteDebuggingVersion => this["REMOTEDEBUGGINGVERSION"];

        /// <summary>
        /// By default, App Service creates a shared storage for you at app creation. To use a custom storage account instead, set to the connection string of your storage account. For functions, see App settings reference for Functions.
        /// </summary>
        public string? WebsiteContentAzureFileConnectionString => this["WEBSITE_CONTENTAZUREFILECONNECTIONSTRING"];

        /// <summary>
        /// When you use specify a custom storage account with WEBSITE_CONTENTAZUREFILECONNECTIONSTRING, App Service creates a file share in that storage account for your app. To use a custom name, set this variable to the name you want. If a file share with the specified name doesn't exist, App Service creates it for you.
        /// </summary>
        public string? WebsiteContentShare => this["WEBSITE_CONTENTSHARE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Shows whether Always On is enabled (1) or not (0).
        /// </summary>
        public string? WebsiteScmAlwaysOnEnabled => this["WEBSITE_SCM_ALWAYS_ON_ENABLED"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Shows whether the Kudu app is running in a separate process (1) or not (0).
        /// </summary>
        public string? WebsiteScmSeparateStatus => this["WEBSITE_SCM_SEPARATE_STATUS"];

        /// <summary>
        /// Number of times to try name resolve.
        /// </summary>
        public string? WebsiteDnsAttempts => this["WEBSITE_DNS_ATTEMPTS"];

        /// <summary>
        /// Number of seconds to wait for name resolve
        /// </summary>
        public string? WebsiteDnsTimeout => this["WEBSITE_DNS_TIMEOUT"];
    }
}
