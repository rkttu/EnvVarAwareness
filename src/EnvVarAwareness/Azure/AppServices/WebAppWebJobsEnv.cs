namespace EnvVarAwareness.Azure.AppServices
{

    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Web Jobs)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppWebJobsEnv : EnvBase
    {
        /// <summary>
        /// For continuous jobs, delay in seconds when a job's process goes down for any reason before relaunching it.
        /// </summary>
        public string? WebJobsRestartTime => this["WEBJOBS_RESTART_TIME"];

        /// <summary>
        /// For triggered jobs, timeout in seconds, after which the job is aborted if it's in idle, has no CPU time or output.
        /// </summary>
        public string? WebJobsIdleTimeout => this["WEBJOBS_IDLE_TIMEOUT"];

        /// <summary>
        /// For triggered jobs, maximum number of runs kept in the history directory per job. The default is 50.
        /// </summary>
        public string? WebJobsHistorySize => this["WEBJOBS_HISTORY_SIZE"];

        /// <summary>
        /// Set to 1 to disable running any job, and stop all currently running jobs.
        /// </summary>
        public string? WebJobsStopped => this["WEBJOBS_STOPPED"];

        /// <summary>
        /// Set to 1 to turn off all scheduled triggering. Jobs can still be manually invoked.
        /// </summary>
        public string? WebJobsDisableSchedule => this["WEBJOBS_DISABLE_SCHEDULE"];

        /// <summary>
        /// Absolute or relative path of webjob files. For a relative path, the value is combined with the default root path (D:/home/site/wwwroot/ or /home/site/wwwroot/).
        /// </summary>
        public string? WebJobsRootPath => this["WEBJOBS_ROOT_PATH"];

        /// <summary>
        /// Set to true to send output from triggered WebJobs to the application logs pipeline (which supports file system, blobs, and tables).
        /// </summary>
        public string? WebJobsTriggeredJobsToAppLogs => this["WEBJOBS_LOG_TRIGGERED_JOBS_TO_APP_LOGS"];

        /// <summary>
        /// File that App Service creates when a shutdown request is detected. It's the web job process's responsibility to detect the presence of this file and initiate shutdown. When using the WebJobs SDK, this part is handled automatically.
        /// </summary>
        public string? WebJobsShutdownFile => this["WEBJOBS_SHUTDOWN_FILE"];

        /// <summary>
        /// Read-only. Root path of currently running job (will be under some temporary directory).
        /// </summary>
        public string? WebJobsPath => this["WEBJOBS_PATH"];

        /// <summary>
        /// Read-only. Current job name.
        /// </summary>
        public string? WebJobsName => this["WEBJOBS_NAME"];

        /// <summary>
        /// Read-only. Current job type (triggered or continuous).
        /// </summary>
        public string? WebJobsType => this["WEBJOBS_TYPE"];

        /// <summary>
        /// Read-only. Current job metadata path to contain the job's logs, history, and any artifact of the job.
        /// </summary>
        public string? WebJobsDataPath => this["WEBJOBS_DATA_PATH"];

        /// <summary>
        /// Read-only. For triggered jobs, current run ID of the job.
        /// </summary>
        public string? WebJobsRunId => this["WEBJOBS_RUN_ID"];
    }
}
