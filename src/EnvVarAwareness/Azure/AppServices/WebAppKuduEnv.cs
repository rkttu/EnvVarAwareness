namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Kudu Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppKuduEnv : EnvBase
    {
        /// <summary>
        /// Add things at the end of the msbuild command line, such that it overrides any previous parts of the default command line.
        /// </summary>
        public string? ScmBuildArguments => this["SCM_BUILD_ARGS"];

        /// <summary>
        /// Kudu uses the azure site deploymentscript command described here to generate a deployment script. It automatically detects the language framework type and determines the parameters to pass to the command. This setting overrides the automatically generated parameters.
        /// </summary>
        public string? ScmScriptGeneratorArguments => this["SCM_SCRIPT_GENERATOR_ARGS"];

        /// <summary>
        /// Build trace level. The default is 1. Set to higher values, up to 4, for more tracing.
        /// </summary>
        public string? ScmTraceLevel => this["SCM_TRACE_LEVEL"];

        /// <summary>
        /// Time out in seconds for each command that the build process launches to wait before without producing any output. After that, the command is considered idle and killed. The default is 60 (one minute). In Azure, there's also a general idle request timeout that disconnects clients after 230 seconds. However, the command will still continue running server-side after that.
        /// </summary>
        public string? ScmCommandIdleTimeout => this["SCM_COMMAND_IDLE_TIMEOUT"];

        /// <summary>
        /// Time-out of inactivity in seconds before stopping log streaming. The default is 1800 (30 minutes).
        /// </summary>
        public string? ScmLogstreamTimeout => this["SCM_LOGSTREAM_TIMEOUT"];

        /// <summary>
        /// URL of the site extensions gallery. The default is https://www.nuget.org/api/v2/. The URL of the old feed is http://www.siteextensions.net/api/v2/.
        /// </summary>
        public string? ScmSiteExtensionsFeedUrl => this["SCM_SITEEXTENSIONS_FEED_URL"];

        /// <summary>
        /// Set to 0 to use git.exe instead of libgit2sharp for git operations.
        /// </summary>
        public string? ScmUseLibGit2SharpRepository => this["SCM_USE_LIBGIT2SHARP_REPOSITORY"];

        /// <summary>
        /// In case of the error The specified user does not have a valid profile. during ASP.NET build automation (such as during Git deployment), set this variable to 1 to load a full user profile in the build environment. This setting is only applicable when WEBSITE_COMPUTE_MODE is Dedicated.
        /// </summary>
        public string? WebsiteLoadUserProfile => this["WEBSITE_LOAD_USER_PROFILE"];

        /// <summary>
        /// Time out in minutes for the SCM (Kudu) site. The default is 20.
        /// </summary>
        public string? WebsiteScmIdleTimeoutInMinutes => this["WEBSITE_SCM_IDLE_TIMEOUT_IN_MINUTES"];

        /// <summary>
        /// With ZIP deploy, the deployment engine assumes that a ZIP file is ready to run as-is and doesn't run any build automation. To enable the same build automation as in Git deploy, set to true.
        /// </summary>
        public string? ScmDoBuildDuringDeployment => this["SCM_DO_BUILD_DURING_DEPLOYMENT"];
    }
}
