using System.Collections.Generic;

namespace EnvVarAwareness.Google
{
    /// <summary>
    /// Google CloudRun environment variables.
    /// </summary>
    /// <see href="https://cloud.google.com/run/docs/container-contract?hl=en"/>
    public sealed class CloudRunEnv : EnvBase
    {
        /// <summary>
        /// Signifies a variable is specific to the Google reserved settings.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetGoogleEnvironmentVariables()
            => GetEnvironmentVariables("X_GOOGLE_");

        /// <summary>
        /// Signifies a variable is specific to the K-native reserved settings.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetKEnvironmentVariables()
            => GetEnvironmentVariables("K_");

        /// <summary>
        /// Signifies a variable is specific to the Google Cloud reserved settings.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetCloudEnvironmentVariables()
            => GetEnvironmentVariables("CLOUD_");

        /// <summary>
        /// The port your HTTP server should listen on.	
        /// </summary>
        public string? Port => this["PORT"];

        /// <summary>
        /// The name of the Cloud Run service being run.
        /// </summary>
        public string? KService => this["K_SERVICE"];

        /// <summary>
        /// The name of the Cloud Run revision being run.
        /// </summary>
        public string? KRevision => this["K_REVISION"];

        /// <summary>
        /// The name of the Cloud Run configuration that created the revision.
        /// </summary>
        public string? KConfiguration => this["K_CONFIGURATION"];

        /// <summary>
        /// Project name.
        /// </summary>
        public string? GoogleCloudProject => this["GOOGLE_CLOUD_PROJECT"];

        /// <summary>
        /// Region name.
        /// </summary>
        public string? GoogleCloudRegion => this["GOOGLE_CLOUD_REGION"];
    }
}
