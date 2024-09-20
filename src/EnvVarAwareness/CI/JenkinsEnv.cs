namespace EnvVarAwareness.CI
{
    /// <summary>
    /// Represents a collection of environment variables used in Jenkins.
    /// </summary>
    /// <seealso href="https://www.jenkins.io/doc/book/pipeline/jenkinsfile/#using-environment-variables"/>
    public sealed class JenkinsEnv : EnvBase
    {
        /// <summary>
        /// The current build ID, identical to BUILD_NUMBER for builds created in Jenkins versions 1.597+
        /// </summary>
        public string? BuildId => this["BUILD_ID"];

        /// <summary>
        /// The current build number, such as "153"
        /// </summary>
        public string? BuildNumber => this["BUILD_NUMBER"];

        /// <summary>
        /// String of jenkins-${JOB_NAME}-${BUILD_NUMBER}. Convenient to put into a resource file, a jar file, etc for easier identification
        /// </summary>
        public string? BuildTag => this["BUILD_TAG"];

        /// <summary>
        /// The URL where the results of this build can be found (for example http://buildserver/jenkins/job/MyJobName/17/ )
        /// </summary>
        public string? BuildUrl => this["BUILD_URL"];

        /// <summary>
        /// The unique number that identifies the current executor (among executors of the same machine) performing this build. This is the number you see in the "build executor status", except that the number starts from 0, not 1
        /// </summary>
        public string? ExecutionNumber => this["EXECUTOR_NUMBER"];

        /// <summary>
        /// If your job is configured to use a specific JDK, this variable is set to the JAVA_HOME of the specified JDK. When this variable is set, PATH is also updated to include the bin subdirectory of JAVA_HOME
        /// </summary>
        public string? JavaHome => this["JAVA_HOME"];

        /// <summary>
        /// Full URL of Jenkins, such as https://example.com:port/jenkins/ (NOTE: only available if Jenkins URL set in "System Configuration")
        /// </summary>
        public string? JenkinsUrl => this["JENKINS_URL"];

        /// <summary>
        /// Name of the project of this build, such as "foo" or "foo/bar".
        /// </summary>
        public string? JobName => this["JOB_NAME"];

        /// <summary>
        /// The name of the node the current build is running on. Set to 'master' for the Jenkins controller.
        /// </summary>
        public string? NodeName => this["NODE_NAME"];

        /// <summary>
        /// The absolute path of the workspace
        /// </summary>
        public string? Workspace => this["WORKSPACE"];
    }
}
