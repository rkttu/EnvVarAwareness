namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/.NET Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxDotnetEnv : EnvBase
    {
        /// <summary>
        /// Specify which .NET version the app is using
        /// </summary>
        public string? DotnetVersion => this["DOTNET_VERSION"];

        /// <summary>
        /// Specify which .NET version the app defaults to if none detected
        /// </summary>
        public string? DotnetDefaultVersion => this["DOTNET_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the .NET Core build disabled even if repo indicates it
        /// </summary>
        public string? DisableDotnetCoreBuild => this["DISABLE_DOTNETCORE_BUILD"];

        /// <summary>
        /// repo-relative path to directory with .csproj file for build
        /// </summary>
        public string? Project => this["PROJECT"];

        /// <summary>
        /// Configuration (Debug or Release) that is used to build a .NET Core project
        /// </summary>
        public string? MsbuildConfiguration => this["MSBUILD_CONFIGURATION"];
    }
}
