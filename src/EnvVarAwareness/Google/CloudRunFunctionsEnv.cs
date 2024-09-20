namespace EnvVarAwareness.Google
{
    /// <summary>
    /// Google Cloud Run Functions environment variables.
    /// </summary>
    /// <see href="https://cloud.google.com/functions/docs/configuring/env-var?hl=en"/>
    public sealed class CloudRunFunctionsEnv : EnvBase
    {
        /// <summary>
        /// Reserved: The function to be executed.
        /// </summary>
        public string? FunctionTarget => this["FUNCTION_TARGET"];

        /// <summary>
        /// Reserved: The type of the function: http for HTTP functions, and event for event-driven functions.
        /// </summary>
        public string? FunctionSignatureType => this["FUNCTION_SIGNATURE_TYPE"];
    }
}
