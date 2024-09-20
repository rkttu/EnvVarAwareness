using System.Collections.Generic;

namespace EnvVarAwareness.Aws
{
    /// <summary>
    /// Represents a collection of environment variables used in Amazon Web Services.
    /// </summary>
    /// <see href="https://docs.aws.amazon.com/sdkref/latest/guide/environment-variables.html"/>
    public sealed class KnownAwsEnv : EnvBase
    {
        /// <summary>
        /// The access key currently configured.
        /// </summary>
        public string? AWSAccessKey => this["AWS_ACCESS_KEY"];

        /// <summary>
        /// The access key ID currently configured.
        /// </summary>
        public string? AWSAccessKeyId => this["AWS_ACCESS_KEY_ID"];

        /// <summary>
        /// The secret access key currently configured.
        /// </summary>
        public string? AWSSecretAccessKey => this["AWS_SECRET_ACCESS_KEY"];

        /// <summary>
        /// The AWS Region currently configured. If defined, this value overrides the AWS_DEFAULT_REGION.
        /// </summary>
        public string? AWSRegion => this["AWS_REGION"];

        /// <summary>
        /// Signifies Github configuration values.
        /// </summary>
        public IDictionary<string, string> GetAWSVariables()
            => GetEnvironmentVariables("AWS_");
    }
}
