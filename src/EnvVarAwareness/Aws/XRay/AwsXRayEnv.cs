namespace EnvVarAwareness.Aws.XRay
{
    /// <summary>
    /// Represents a collection of environment variables used in Amazon Web Services X-Ray tracing.
    /// </summary>
    /// <see href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html"/>
    public sealed class AwsXRayEnv : EnvBase
    {
        /// <summary>
        /// The X-Ray tracing header. This environment variable changes with each invocation.
        /// </summary>
        public string? AmazonTraceId => this["_X_AMZN_TRACE_ID"];

        /// <summary>
        /// For X-Ray tracing, Lambda sets this to LOG_ERROR to avoid throwing runtime errors from the X-Ray SDK.
        /// </summary>
        public string? AWSXRayContextMissing => this["AWS_XRAY_CONTEXT_MISSING"];

        /// <summary>
        /// For X-Ray tracing, the IP address and port of the X-Ray daemon.
        /// </summary>
        public string? AWSXRayDaemonAddress => this["AWS_XRAY_DAEMON_ADDRESS"];
    }
}
