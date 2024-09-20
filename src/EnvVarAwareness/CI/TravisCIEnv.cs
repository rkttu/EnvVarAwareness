namespace EnvVarAwareness.CI
{
    /// <summary>
    /// Represents a collection of environment variables used in Travis CI.
    /// </summary>
    /// <see href="https://docs.travis-ci.com/user/environment-variables/"/>
    public sealed class TravisCIEnv : EnvBase
    {
        /// <summary>
        /// Indicates that the build is running in a Continuous Integration (CI) environment.
        /// </summary>
        public string? CI => this["CI"];

        /// <summary>
        /// Indicates that the build is running in the Travis CI environment.
        /// </summary>
        public string? Travis => this["TRAVIS"];

        /// <summary>
        /// Also indicates the build is running in a Continuous Integration environment, similar to CI=true.
        /// </summary>
        public string? ContinuousIntegration => this["CONTINUOUS_INTEGRATION"];

        /// <summary>
        /// A humorous default variable included by Travis CI.
        /// </summary>
        public string? HasJoshKSealOfApproval => this["HAS_JOSH_K_SEAL_OF_APPROVAL"];

        /// <summary>
        /// Used in Ruby on Rails builds to specify the environment as "test".
        /// </summary>
        public string? RailsEnv => this["RAILS_ENV"];

        /// <summary>
        /// Used in Rack-based Ruby applications to specify the environment as "test".
        /// </summary>
        public string? RackEnv => this["RACK_ENV"];

        /// <summary>
        /// Used in Merb (another Ruby framework) builds to specify the environment as "test".
        /// </summary>
        public string? MerbEnv => this["MERB_ENV"];

        /// <summary>
        /// JRuby configuration options to optimize build performance.
        /// </summary>
        public string? JRubyOpts => this["JRUBY_OPTS"];

        /// <summary>
        /// Set to the appropriate Java home directory based on the version being used.
        /// </summary>
        public string? JavaHome => this["JAVA_HOME"];

        /// <summary>
        /// Indicates if the job is allowed to fail (true) or not allowed to fail (false).
        /// </summary>
        public string? TravisAllowFailure => this["TRAVIS_ALLOW_FAILURE"];

        /// <summary>
        /// The name of the server that compiles the build script and serves helper files (e.g., gimme, nvm, sbt).
        /// </summary>
        public string? TravisAppHost => this["TRAVIS_APP_HOST"];

        /// <summary>
        /// For push builds or builds not triggered by a pull request, this is the name of the branch. For PR builds, it's the branch targeted by the PR.
        /// </summary>
        public string? TravisBranch => this["TRAVIS_BRANCH"];

        /// <summary>
        /// The absolute path to the directory where the repository being built is copied on the worker.
        /// </summary>
        public string? TravisBuildDir => this["TRAVIS_BUILD_DIR"];

        /// <summary>
        /// The unique identifier for the current build, used internally by Travis CI.
        /// </summary>
        public string? TravisBuildId => this["TRAVIS_BUILD_ID"];

        /// <summary>
        /// The build number of the current build (e.g., "4").
        /// </summary>
        public string? TravisBuildNumber => this["TRAVIS_BUILD_NUMBER"];

        /// <summary>
        /// URL to the build log.
        /// </summary>
        public string? TravisBuildWebUrl => this["TRAVIS_BUILD_WEB_URL"];

        /// <summary>
        /// The commit SHA that the current build is testing.
        /// </summary>
        public string? TravisCommit => this["TRAVIS_COMMIT"];

        /// <summary>
        /// The commit subject and body (unwrapped), or a custom commit message if provided.
        /// </summary>
        public string? TravisCommitMessage => this["TRAVIS_COMMIT_MESSAGE"];

        /// <summary>
        /// The range of commits included in the push or pull request (empty for builds triggered by the initial commit of a new branch).
        /// </summary>
        public string? TravisCommitRange => this["TRAVIS_COMMIT_RANGE"];

        /// <summary>
        /// Indicates the compiler used by the current job (e.g., clang, gcc).
        /// </summary>
        public string? TravisCompiler => this["TRAVIS_COMPILER"];

        /// <summary>
        /// Set to true if the job is running in debug mode.
        /// </summary>
        public string? TravisDebugMode => this["TRAVIS_DEBUG_MODE"];

        /// <summary>
        /// The distribution the current job is running on.
        /// </summary>
        public string? TravisDist => this["TRAVIS_DIST"];

        /// <summary>
        /// Indicates how the build was triggered (push, pull_request, api, or cron).
        /// </summary>
        public string? TravisEventType => this["TRAVIS_EVENT_TYPE"];

        /// <summary>
        /// The unique identifier for the current job, used internally by Travis CI.
        /// </summary>
        public string? TravisJobId => this["TRAVIS_JOB_ID"];

        /// <summary>
        /// The job name if specified, otherwise an empty string.
        /// </summary>
        public string? TravisJobName => this["TRAVIS_JOB_NAME"];

        /// <summary>
        /// The number of the current job (e.g., "4.1").
        /// </summary>
        public string? TravisJobNumber => this["TRAVIS_JOB_NUMBER"];

        /// <summary>
        /// URL to the job log.
        /// </summary>
        public string? TravisJobWebUrl => this["TRAVIS_JOB_WEB_URL"];

        /// <summary>
        /// Indicates the platform on which the job is running (e.g., linux, osx, windows).
        /// </summary>
        public string? TravisOsName => this["TRAVIS_OS_NAME"];

        /// <summary>
        /// Indicates the CPU architecture the job is running on (e.g., amd64, arm64, ppc64le, s390x).
        /// </summary>
        public string? TravisCPUArch => this["TRAVIS_CPU_ARCH"];

        /// <summary>
        /// The osx_image value configured in .travis.yml, or empty if not set.
        /// </summary>
        public string? TravisOSXImage => this["TRAVIS_OSX_IMAGE"];

        /// <summary>
        /// The pull request number if the current job is a pull request, or "false" if it’s not a pull request.
        /// </summary>
        public string? TravisPullRequest => this["TRAVIS_PULL_REQUEST"];

        /// <summary>
        /// The branch from which the pull request originated, or empty if the job is a push build.
        /// </summary>
        public string? TravisPullRequestBranch => this["TRAVIS_PULL_REQUEST_BRANCH"];

        /// <summary>
        /// The commit SHA of the HEAD commit of the pull request, or empty if the job is a push build.
        /// </summary>
        public string? TraivsPullRequestData => this["TRAVIS_PULL_REQUEST_SHA"];

        /// <summary>
        /// The slug (in the form owner_name/repo_name) of the repository from which the PR originated, or empty if the job is a push build.
        /// </summary>
        public string? TravisPullRequestSlug => this["TRAVIS_PULL_REQUEST_SLUG"];

        /// <summary>
        /// Set to true if the pull request is in a draft state, false otherwise. If it's a push build, the value is empty.
        /// </summary>
        public string? TravisPullRequestIsDraft => this["TRAVIS_PULL_REQUEST_IS_DRAFT"];

        /// <summary>
        /// The slug (in the form owner_name/repo_name) of the repository currently being built.
        /// </summary>
        public string? TravisRepoSlug => this["TRAVIS_REPO_SLUG"];

        /// <summary>
        /// Set to true if encrypted environment variables are available, false otherwise.
        /// </summary>
        public string? TravisSecureEnvVars => this["TRAVIS_SECURE_ENV_VARS"];

        /// <summary>
        /// Indicates whether sudo is enabled (true or false).
        /// </summary>
        public string? TravisSudo => this["TRAVIS_SUDO"];

        /// <summary>
        /// Set to 0 if all commands in the script section have exited successfully, 1 otherwise.
        /// </summary>
        public string? TravisTestResult => this["TRAVIS_TEST_RESULT"];

        /// <summary>
        /// The tag name if the current build is for a git tag, or empty otherwise.
        /// </summary>
        public string? TravisTag => this["TRAVIS_TAG"];

        /// <summary>
        /// The build stage name. If the build does not use build stages, this is empty.
        /// </summary>
        public string? TravisBuildStageName => this["TRAVIS_BUILD_STAGE_NAME"];

        /// <summary>
        /// Set to true if the build has been restarted, false otherwise.
        /// </summary>
        public string? TravisJobRestarted => this["TRAVIS_JOB_RESTARTED"];

        /// <summary>
        /// The username of the person who restarted the build.
        /// </summary>
        public string? TravisJobRestartedBy => this["TRAVIS_JOB_RESTARTED_BY"];

        /// <summary>
        /// The version of Dart used for the build.
        /// </summary>
        public string? TravisDartVersion => this["TRAVIS_DART_VERSION"];

        /// <summary>
        /// The version of Go used for the build.
        /// </summary>
        public string? TravisGoVersion => this["TRAVIS_GO_VERSION"];

        /// <summary>
        /// The version of Haxe used for the build.
        /// </summary>
        public string? TravisHaxeVersion => this["TRAVIS_HAXE_VERSION"];

        /// <summary>
        /// The version of JDK used for the build.
        /// </summary>
        public string? TravisJdkVersion => this["TRAVIS_JDK_VERSION"];

        /// <summary>
        /// The version of Julia used for the build.
        /// </summary>
        public string? TravisJuliaVersion => this["TRAVIS_JULIA_VERSION"];

        /// <summary>
        /// The version of Node.js used for the build.
        /// </summary>
        public string? TravisNodeVersion => this["TRAVIS_NODE_VERSION"];

        /// <summary>
        /// The OTP release used for the build (for Erlang).
        /// </summary>
        public string? TravisOtpRelease => this["TRAVIS_OTP_RELEASE"];

        /// <summary>
        /// The version of Perl used for the build.
        /// </summary>
        public string? TravisPerlVersion => this["TRAVIS_PERL_VERSION"];

        /// <summary>
        /// The version of PHP used for the build.
        /// </summary>
        public string? TravisPHPVersion => this["TRAVIS_PHP_VERSION"];

        /// <summary>
        /// The version of Python used for the build.
        /// </summary>
        public string? TRAVIS_PYTHON_VERSION => this["TRAVIS_PYTHON_VERSION"];

        /// <summary>
        /// The version of R used for the build.
        /// </summary>
        public string? TravisRVersion => this["TRAVIS_R_VERSION"];

        /// <summary>
        /// The version of Ruby used for the build.
        /// </summary>
        public string? TravisRubyVersion => this["TRAVIS_RUBY_VERSION"];

        /// <summary>
        /// The version of Rust used for the build.
        /// </summary>
        public string? TravisRustVersion => this["TRAVIS_RUST_VERSION"];

        /// <summary>
        /// The version of Scala used for the build.
        /// </summary>
        public string? TravisScalaVersion => this["TRAVIS_SCALA_VERSION"];

        /// <summary>
        /// The version of MariaDB used in the build environment.
        /// </summary>
        public string? TravisMariaDBVersion => this["TRAVIS_MARIADB_VERSION"];

        /// <summary>
        /// The Xcode SDK used for Objective-C builds.
        /// </summary>
        public string? TravisXcodeSdk => this["TRAVIS_XCODE_SDK"];

        /// <summary>
        /// The Xcode scheme used for Objective-C builds.
        /// </summary>
        public string? TravisXcodeScheme => this["TRAVIS_XCODE_SCHEME"];

        /// <summary>
        /// The Xcode project used for Objective-C builds.
        /// </summary>
        public string? TravisXcodeProject => this["TRAVIS_XCODE_PROJECT"];

        /// <summary>
        /// The Xcode workspace used for Objective-C builds.
        /// </summary>
        public string? TravisXcodeWorkspace => this["TRAVIS_XCODE_WORKSPACE"];
    }
}
