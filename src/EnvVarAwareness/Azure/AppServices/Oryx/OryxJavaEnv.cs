namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/Java Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxJavaEnv : EnvBase
    {
        /// <summary>
        /// Specify which Java version the app is using
        /// </summary>
        public string? JavaVersion => this["JAVA_VERSION"];

        /// <summary>
        /// Specify which Java version the app defaults to if none detected
        /// </summary>
        public string? JavaDefaultVersion => this["JAVA_DEFAULT_VERSION"];

        /// <summary>
        /// Specify which Maven version the app is using
        /// </summary>
        public string? MavenVersion => this["MAVEN_VERSION"];

        /// <summary>
        /// Specify which Maven version the app defaults to if none detected
        /// </summary>
        public string? MavenDefaultVersion => this["MAVEN_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the Java build disabled even if repo indicates it
        /// </summary>
        public string? DisableJavaBuild => this["DISABLE_JAVA__BUILD"];
    }
}
