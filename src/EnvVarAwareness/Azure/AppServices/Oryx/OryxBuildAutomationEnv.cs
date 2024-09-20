namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxBuildAutomationEnv : EnvBase
    {
        /// <summary>
        /// Command to a shell script to be run before build
        /// </summary>
        public string? PreBuildCommand => this["PRE_BUILD_COMMAND"];

        /// <summary>
        /// A repo-relative path to a shell script to be run before build
        /// </summary>
        public string? PreBuildScriptPath => this["PRE_BUILD_SCRIPT_PATH"];

        /// <summary>
        /// Command to a shell script to be run after build
        /// </summary>
        public string? PostBuildCommand => this["POST_BUILD_COMMAND"];

        /// <summary>
        /// A repo-relative path to a shell script to be run after build
        /// </summary>
        public string? PostBuildScriptPath => this["POST_BUILD_SCRIPT_PATH"];

        /// <summary>
        /// Enable dynamically install platform binaries if not presented inside the image
        /// </summary>
        public string? EnableDynamicInstall => this["ENABLE_DYNAMIC_INSTALL"];

        /// <summary>
        /// The storage base url from where oryx dynamically install sdks
        /// </summary>
        public string? OryxSdkStorageBaseUrl => this["ORYX_SDK_STORAGE_BASE_URL"];

        /// <summary>
        /// Root directory path under which dynamically installed SDKs are created.
        /// </summary>
        public string? DynamicInstallRootDirectory => this["DYNAMIC_INSTALL_ROOT_DIR"];

        /// <summary>
        /// Disable running version checkers during the build.
        /// </summary>
        public string? DisableCheckers => this["DISABLE_CHECKERS"];

        /// <summary>
        /// Disable Oryx command line tools from collecting any data.
        /// </summary>
        public string? OryxDisableTelemetry => this["ORYX_DISABLE_TELEMETRY"];

        /// <summary>
        /// Type of application that the the source directory has.
        /// </summary>
        public string? OryxAppType => this["ORYX_APP_TYPE"];

        /// <summary>
        /// Indicates if detectors should consider looking into sub-directories for files
        /// </summary>
        public string? DisableRecursiveLookup => this["DISABLE_RECURSIVE_LOOKUP"];

        /// <summary>
        /// Apply more than one toolset if repo indicates it
        /// </summary>
        public string? EnableMultiplatformBuild => this["ENABLE_MULTIPLATFORM_BUILD"];

        /// <summary>
        /// Specify which platform the app is using. Possible values are: nodejs, hugo, python, dotnet, php, ruby, java.
        /// </summary>
        public string? PlatformName => this["PLATFORM_NAME"];

        /// <summary>
        /// Specify which platform version the app is using
        /// </summary>
        public string? PlatformVersion => this["PLATFORM_VERSION"];

        /// <summary>
        /// Indicate if it requires OS packages for Node or Python packages
        /// </summary>
        public string? RequiredOsPackages => this["REQUIRED_OS_PACKAGES"];

        /// <summary>
        /// Indicate if it should create packages for the app
        /// </summary>
        public string? CreatePackage => this["CREATE_PACKAGE"];
    }
}
