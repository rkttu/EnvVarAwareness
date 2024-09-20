namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/Node.JS Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxNodeEnv : EnvBase
    {
        /// <summary>
        /// Specify which Node version the app is using
        /// </summary>
        public string? NodeVersion => this["NODE_VERSION"];

        /// <summary>
        /// Specify which Node version the app defaults to if none detected
        /// </summary>
        public string? NodeDefaultVersion => this["NODE_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the Node.js build disabled even if repo indicates it
        /// </summary>
        public string? DisableNodejsBuild => this["DISABLE_NODEJS_BUILD"];

        /// <summary>
        /// Custom build command to be run to build Node app
        /// </summary>
        public string? CustomBuildCommand => this["CUSTOM_BUILD_COMMAND"];

        /// <summary>
        /// Custom run build command to be run after package install commands
        /// </summary>
        public string? RunBuildCommand => this["RUN_BUILD_COMMAND"];

        /// <summary>
        /// Apply node monorepo build if repo indicates it
        /// </summary>
        public string? EnableNodeMonoRepoBuild => this["ENABLE_NODE_MONOREPO_BUILD"];

        /// <summary>
        /// Indicates if the entire output directory needs to be compressed.
        /// </summary>
        public string? CompressDestinationDirectory => this["COMPRESS_DESTINATION_DIR"];

        /// <summary>
        /// Only the prod dependencies are copied to the output for Node apps.
        /// </summary>
        public string? PruneDevDependencies => this["PRUNE_DEV_DEPENDENCIES"];

        /// <summary>
        /// Specify the npm registry url.
        /// </summary>
        public string? NpmRegistryUrl => this["NPM_REGISTRY_URL"];

        /// <summary>
        /// Specify the yarn timeout config with a delay in milliseconds.
        /// </summary>
        public string? YarnTimeoutConfig => this["YARN_TIMEOUT_CONFIG"];
    }
}
