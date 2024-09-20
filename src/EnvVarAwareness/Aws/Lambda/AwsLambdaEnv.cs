namespace EnvVarAwareness.Aws.Lambda
{
    /// <summary>
    /// Represents a collection of environment variables used in Amazon Web Services Labmda.
    /// </summary>
    /// <see href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html"/>
    public sealed class AwsLambdaEnv : EnvBase
    {
        /// <summary>
        /// The handler location configured on the function.
        /// </summary>
        public string? Handler => this["_HANDLER"];

        /// <summary>
        /// The default AWS Region where the Lambda function is executed.
        /// </summary>
        public string? AWSDefaultRegion => this["AWS_DEFAULT_REGION"];

        /// <summary>
        /// The runtime identifier, prefixed by AWS_Lambda_ (for example, AWS_Lambda_java8). This environment variable is not defined for OS-only runtimes (the provided runtime family).
        /// </summary>
        public string? AWSExecutionEnvironment => this["AWS_EXECUTION_ENV"];

        /// <summary>
        /// The name of the function.
        /// </summary>
        public string? AWSLambdaFunctionName => this["AWS_LAMBDA_FUNCTION_NAME"];

        /// <summary>
        /// The amount of memory available to the function in MB.
        /// </summary>
        public string? AWSLambdaFunctionMemorySize => this["AWS_LAMBDA_FUNCTION_MEMORY_SIZE"];

        /// <summary>
        /// The version of the function being executed.
        /// </summary>
        public string? AWSLambdaFunctionVersion => this["AWS_LAMBDA_FUNCTION_VERSION"];

        /// <summary>
        /// The initialization type of the function, which is on-demand, provisioned-concurrency, or snap-start. For information, see Configuring provisioned concurrency or Improving startup performance with Lambda SnapStart.
        /// </summary>
        public string? AWSLambdaInitializationType => this["AWS_LAMBDA_INITIALIZATION_TYPE"];

        /// <summary>
        /// The name of the Amazon CloudWatch Logs group for the function. The AWS_LAMBDA_LOG_GROUP_NAME environment variable is not available in Lambda SnapStart functions.
        /// </summary>
        public string? AWSLambdaLogGroupName => this["AWS_LAMBDA_LOG_GROUP_NAME"];

        /// <summary>
        /// The name of the Amazon CloudWatch Logs stream for the function. The AWS_LAMBDA_LOG_STREAM_NAME environment variable is not available in Lambda SnapStart functions.
        /// </summary>
        public string? AWSLambdaLogStreamName => this["AWS_LAMBDA_LOG_STREAM_NAME"];

        /// <summary>
        /// (Custom runtime) The host and port of the runtime API.
        /// </summary>
        public string? AWSLambdaRuntimeApi => this["AWS_LAMBDA_RUNTIME_API"];

        /// <summary>
        /// The path to your Lambda function code.
        /// </summary>
        public string? LambdaTaskRoot => this["LAMBDA_TASK_ROOT"];

        /// <summary>
        /// The path to runtime libraries.
        /// </summary>
        public string? LambdaRuntimeDirectory => this["LAMBDA_RUNTIME_DIR"];

        /// <summary>
        /// The Node.js library path (/opt/nodejs/node12/node_modules/:/opt/nodejs/node_modules:$LAMBDA_RUNTIME_DIR/node_modules).
        /// </summary>
        public string? NodePath => this["NODE_PATH"];

        /// <summary>
        /// (Python 2.7, 3.6, 3.8) The Python library path ($LAMBDA_RUNTIME_DIR).
        /// </summary>
        public string? PythonPath => this["PYTHONPATH"];

        /// <summary>
        /// (Ruby) The Ruby library path ($LAMBDA_TASK_ROOT/vendor/bundle/ruby/2.5.0:/opt/ruby/gems/2.5.0).
        /// </summary>
        public string? GemPath => this["GEM_PATH"];

        /// <summary>
        /// For the .NET 6 and .NET 7 runtimes, set this variable to enable or disable .NET specific runtime optimizations. Values include always, never, and provisioned-concurrency. For more information, see Configuring provisioned concurrency for a function.
        /// </summary>
        public string? AWSLambdaDotnetPreJIT => this["AWS_LAMBDA_DOTNET_PREJIT"];
    }
}
