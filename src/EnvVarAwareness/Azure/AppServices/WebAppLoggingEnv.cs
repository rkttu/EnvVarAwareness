namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Logging)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppLoggingEnv : EnvBase
    {
        /// <summary>
        /// Read-only. Shows whether the web server logging for Windows native apps is enabled (1) or not (0).
        /// </summary>
        public string? WebsiteHttpLoggingEnabled => this["WEBSITE_HTTPLOGGING_ENABLED"];

        /// <summary>
        /// Retention period in days of web server logs for Windows native apps, if web server logs are enabled.
        /// </summary>
        public string? WebsiteHttpLoggingRetentionDays => this["WEBSITE_HTTPLOGGING_RETENTION_DAYS"];

        /// <summary>
        /// SAS URL of the blob storage container to store web server logs for Windows native apps, if web server logs are enabled. If not set, web server logs are stored in the app's file system (default shared storage).
        /// </summary>
        public string? WebsiteHttpLoggingContainerUrl => this["WEBSITE_HTTPLOGGING_CONTAINER_URL"];

        /// <summary>
        /// Retention period in days of application logs for Windows native apps, if application logs are enabled.
        /// </summary>
        public string? DiagnosticsAzureBlobRetentionInDays => this["DIAGNOSTICS_AZUREBLOBRETENTIONINDAYS"];

        /// <summary>
        /// SAS URL of the blob storage container to store application logs for Windows native apps, if application logs are enabled.
        /// </summary>
        public string? DiagnosticsAzureBlobContainerSASUrl => this["DIAGNOSTICS_AZUREBLOBCONTAINERSASURL"];

        /// <summary>
        /// Minimum log level to ship to Log Analytics for the AppServiceAppLogs log type.
        /// </summary>
        public string? AppServiceAppLogsTraceLevel => this["APPSERVICEAPPLOGS_TRACE_LEVEL"];

        /// <summary>
        /// The filename to create, or a relative path to the log directory, for logging internal errors for troubleshooting the listener. The default is logging-errors.txt.
        /// </summary>
        public string? DiagnosticsLastResortFile => this["DIAGNOSTICS_LASTRESORTFILE"];

        /// <summary>
        /// Path to the log settings file, relative to D:\home or /home. The default is site\diagnostics\settings.json.
        /// </summary>
        public string? DiagnosticsLoggingSettngsFile => this["DIAGNOSTICS_LOGGINGSETTINGSFILE"];

        /// <summary>
        /// The log folder, relative to the app root (D:\home\site\wwwroot or /home/site/wwwroot).
        /// </summary>
        public string? DiagnosticsTextTraceLogDirectory => this["DIAGNOSTICS_TEXTTRACELOGDIRECTORY"];

        /// <summary>
        /// Maximum size of the log file in bytes. The default is 131072 (128 KB).
        /// </summary>
        public string? DiagnosticsTextTraceMaxLogFileSizeBytes => this["DIAGNOSTICS_TEXTTRACEMAXLOGFILESIZEBYTES"];

        /// <summary>
        /// Maximum size of the log folder in bytes. The default is 1048576 (1 MB).
        /// </summary>
        public string? DiagnosticsTextTraceMaxLogFolderSizeBytes => this["DIAGNOSTICS_TEXTTRACEMAXLOGFOLDERSIZEBYTES"];

        /// <summary>
        /// Maximum number of log files to keep. The default is 20.
        /// </summary>
        public string? DiagnosticsTextTraceMaxNumLogFiles => this["DIAGNOSTICS_TEXTTRACEMAXNUMLOGFILES"];

        /// <summary>
        /// Time out in milliseconds to keep application logging enabled. The default is 43200000 (12 hours).
        /// </summary>
        public string? DiagnosticsTextTraceTurnOffPeriod => this["DIAGNOSTICS_TEXTTRACETURNOFFPERIOD"];

        /// <summary>
        /// By default, log buffering is enabled. Set to 0 to disable it.
        /// </summary>
        public string? WebsiteLogBuffering => this["WEBSITE_LOG_BUFFERING"];

        /// <summary>
        /// For native Windows apps, set to TRUE to turn off IIS log entries for successful requests returned within 10 seconds. This is a quick way to do performance benchmarking by removing extended logging.
        /// </summary>
        public string? WebsiteEnablePerfMode => this["WEBSITE_ENABLE_PERF_MODE"];
    }
}
