namespace EnvVarAwareness.Google
{
    /// <summary>
    /// Google CloudRun Jobs environment variables.
    /// </summary>
    /// <see href="https://cloud.google.com/run/docs/container-contract?hl=en"/>
    public sealed class CloudRunJobsEnv : EnvBase
    {
        /// <summary>
        /// The name of the Cloud Run job being run.
        /// </summary>
        public string? CloudRunJob => this["CLOUD_RUN_JOB"];

        /// <summary>
        /// The name of the Cloud Run execution being run.
        /// </summary>
        public string? CloudRunExecution => this["CLOUD_RUN_EXECUTION"];

        /// <summary>
        /// The index of this task. Starts at 0 for the first task and increments by 1 for every successive task, up to the maximum number of tasks minus 1. If you set --parallelism to greater than 1, tasks might not follow the index order. For example, it would be possible for task 2 to start before task 1.
        /// </summary>
        public string? CloudRunTaskIndex => this["CLOUD_RUN_TASK_INDEX"];

        /// <summary>
        /// The number of times this task has been retried. Starts at 0 for the first attempt and increments by 1 for every successive retry, up to the maximum retries value.
        /// </summary>
        public string? CloudRunTaskAttempt => this["CLOUD_RUN_TASK_ATTEMPT"];

        /// <summary>
        /// The number of tasks defined in the --tasks parameter.
        /// </summary>
        public string? CloudRunTaskCount => this["CLOUD_RUN_TASK_COUNT"];
    }
}
