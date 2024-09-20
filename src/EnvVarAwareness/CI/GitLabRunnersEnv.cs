using System;
using System.Collections.Generic;

namespace EnvVarAwareness.CI
{
    /// <summary>
    /// Represents a collection of environment variables used in GitLab Runners.
    /// </summary>
    /// <seealso href="https://docs.gitlab.com/ee/ci/variables/predefined_variables.html"/>
    public sealed class GitLabRunnersEnv : EnvBase
    {
        /// <summary>
        /// Signifies CI configuration values.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetCIVariables()
            => GetEnvironmentVariables("CI_");

        /// <summary>
        /// The Source chat channel that triggered the ChatOps command.
        /// </summary>
        public string? ChatChannel => this["CHAT_CHANNEL"];

        /// <summary>
        /// The additional arguments passed with the ChatOps command.
        /// </summary>
        public string? ChatInput => this["CHAT_INPUT"];

        /// <summary>
        /// The chat service’s user ID of the user who triggered the ChatOps command.
        /// </summary>
        public string? ChatUserId => this["CHAT_USER_ID"];

        /// <summary>
        /// Available for all jobs executed in CI/CD. true when available.
        /// </summary>
        public string? CI => this["CI"];

        /// <summary>
        /// The GitLab API v4 root URL.
        /// </summary>
        public string? CIApiv4Url => this["CI_API_V4_URL"];

        /// <summary>
        /// The GitLab API GraphQL root URL. Introduced in GitLab 15.11.
        /// </summary>
        public string? CIApiGraphQLUrl => this["CI_API_GRAPHQL_URL"];

        /// <summary>
        /// The top-level directory where builds are executed.
        /// </summary>
        public string? CIBuildsDir => this["CI_BUILDS_DIR"];

        /// <summary>
        /// The author of the commit in Name &lt;email&gt; format.
        /// </summary>
        public string? CICommitAuthor => this["CI_COMMIT_AUTHOR"];

        /// <summary>
        /// The previous latest commit present on a branch or tag. Is always 0000000000000000000000000000000000000000 for merge request pipelines, the first commit in pipelines for branches or tags, or when manually running a pipeline.
        /// </summary>
        public string? CICommitBeforeSHA => this["CI_COMMIT_BEFORE_SHA"];

        /// <summary>
        /// The commit branch name. Available in branch pipelines, including pipelines for the default branch. Not available in merge request pipelines or tag pipelines.
        /// </summary>
        public string? CICommitBranch => this["CI_COMMIT_BRANCH"];

        /// <summary>
        /// The description of the commit. If the title is shorter than 100 characters, the message without the first line.
        /// </summary>
        public string? CICommitDescription => this["CI_COMMIT_DESCRIPTION"];

        /// <summary>
        /// The full commit message.
        /// </summary>
        public string? CICommitMessage => this["CI_COMMIT_MESSAGE"];

        /// <summary>
        /// The branch or tag name for which project is built.
        /// </summary>
        public string? CICommitRefName => this["CI_COMMIT_REF_NAME"];

        /// <summary>
        /// true if the job is running for a protected reference, false otherwise.
        /// </summary>
        public string? CICommitRefProtected => this["CI_COMMIT_REF_PROTECTED"];

        /// <summary>
        /// CI_COMMIT_REF_NAME in lowercase, shortened to 63 bytes, and with everything except 0-9 and a-z replaced with -. No leading / trailing -. Use in URLs, host names and domain names.
        /// </summary>
        public string? CICommitRefSlug => this["CI_COMMIT_REF_SLUG"];

        /// <summary>
        /// The commit revision the project is built for.
        /// </summary>
        public string? CICommitSHA => this["CI_COMMIT_SHA"];

        /// <summary>
        /// The first eight characters of CI_COMMIT_SHA.
        /// </summary>
        public string? CICommitShortSHA => this["CI_COMMIT_SHORT_SHA"];

        /// <summary>
        /// The commit tag name. Available only in pipelines for tags.
        /// </summary>
        public string? CICommitTag => this["CI_COMMIT_TAG"];

        /// <summary>
        /// The commit tag message. Available only in pipelines for tags. Introduced in GitLab 15.5.
        /// </summary>
        public string? CICommitTagMessage => this["CI_COMMIT_TAG_MESSAGE"];

        /// <summary>
        /// The timestamp of the commit in the ISO 8601 format. For example, 2022-01-31T16:47:55Z. UTC by default.
        /// </summary>
        public string? CICommitTimestamp => this["CI_COMMIT_TIMESTAMP"];

        /// <summary>
        /// The title of the commit. The full first line of the message.
        /// </summary>
        public string? CICommitTitle => this["CI_COMMIT_TITLE"];

        /// <summary>
        /// The unique ID of build execution in a single executor.
        /// </summary>
        public string? CIConcurrentId => this["CI_CONCURRENT_ID"];

        /// <summary>
        /// The unique ID of build execution in a single executor and project.
        /// </summary>
        public string? CIConcurrentProjectId => this["CI_CONCURRENT_PROJECT_ID"];

        /// <summary>
        /// The path to the CI/CD configuration file. Defaults to .gitlab-ci.yml.
        /// </summary>
        public string? CIConfigPath => this["CI_CONFIG_PATH"];

        /// <summary>
        /// true if debug logging (tracing) is enabled.
        /// </summary>
        public string? CIDebugTrace => this["CI_DEBUG_TRACE"];

        /// <summary>
        /// true if service container logging is enabled. Introduced in GitLab 15.7. Requires GitLab Runner 15.7.
        /// </summary>
        public string? CIDebugServices => this["CI_DEBUG_SERVICES"];

        /// <summary>
        /// The name of the project’s default branch.
        /// </summary>
        public string? CIDefaultBranch => this["CI_DEFAULT_BRANCH"];

        /// <summary>
        /// The direct group image prefix for pulling images through the Dependency Proxy.
        /// </summary>
        public string? CIDependencyProxyDirectGroupImagePrefix => this["CI_DEPENDENCY_PROXY_DIRECT_GROUP_IMAGE_PREFIX"];

        /// <summary>
        /// The top-level group image prefix for pulling images through the Dependency Proxy.
        /// </summary>
        public string? CIDependencyProxyGroupImagePrefix => this["CI_DEPENDENCY_PROXY_GROUP_IMAGE_PREFIX"];

        /// <summary>
        /// The password to pull images through the Dependency Proxy.
        /// </summary>
        public string? CIDependencyProxyPassword => this["CI_DEPENDENCY_PROXY_PASSWORD"];

        /// <summary>
        /// The server for logging in to the Dependency Proxy. This variable is equivalent to $CI_SERVER_HOST:$CI_SERVER_PORT.
        /// </summary>
        public string? CIDependencyProxyServer => this["CI_DEPENDENCY_PROXY_SERVER"];

        /// <summary>
        /// The username to pull images through the Dependency Proxy.
        /// </summary>
        public string? CIDependencyProxyUser => this["CI_DEPENDENCY_PROXY_USER"];

        /// <summary>
        /// Only available if the pipeline runs during a deploy freeze window. true when available.
        /// </summary>
        public string? CIDeployFreeze => this["CI_DEPLOY_FREEZE"];

        /// <summary>
        /// The authentication password of the GitLab Deploy Token, if the project has one.
        /// </summary>
        public string? CIDeployPassword => this["CI_DEPLOY_PASSWORD"];

        /// <summary>
        /// The authentication username of the GitLab Deploy Token, if the project has one.
        /// </summary>
        public string? CIDeployUser => this["CI_DEPLOY_USER"];

        /// <summary>
        /// Only available if the job is executed in a disposable environment (something that is created only for this job and disposed of/destroyed after the execution - all executors except shell and ssh). true when available.
        /// </summary>
        public string? CIDisposableEnvironment => this["CI_DISPOSABLE_ENVIRONMENT"];

        /// <summary>
        /// The name of the environment for this job. Available if environment:name is set.
        /// </summary>
        public string? CIEnvironmentName => this["CI_ENVIRONMENT_NAME"];

        /// <summary>
        /// The simplified version of the environment name, suitable for inclusion in DNS, URLs, Kubernetes labels, and so on. Available if environment:name is set. The slug is truncated to 24 characters. A random suffix is automatically added to uppercase environment names.
        /// </summary>
        public string? CIEnvironmentSlug => this["CI_ENVIRONMENT_SLUG"];

        /// <summary>
        /// The URL of the environment for this job. Available if environment:url is set.
        /// </summary>
        public string? CIEnvironmentUrl => this["CI_ENVIRONMENT_URL"];

        /// <summary>
        /// The action annotation specified for this job’s environment. Available if environment:action is set. Can be start, prepare, or stop.
        /// </summary>
        public string? CIEnvironmentAction => this["CI_ENVIRONMENT_ACTION"];

        /// <summary>
        /// The deployment tier of the environment for this job.
        /// </summary>
        public string? CIEnvironmentTier => this["CI_ENVIRONMENT_TIER"];

        /// <summary>
        /// Only available if FIPS mode is enabled in the GitLab instance. true when available.
        /// </summary>
        public string? CIGitLabFIPSMode => this["CI_GITLAB_FIPS_MODE"];

        /// <summary>
        /// Only available if the pipeline’s project has an open requirement. true when available.
        /// </summary>
        public string? CIHasOpenRequirements => this["CI_HAS_OPEN_REQUIREMENTS"];

        /// <summary>
        /// The internal ID of the job, unique across all jobs in the GitLab instance.
        /// </summary>
        public string? CIJobId => this["CI_JOB_ID"];

        /// <summary>
        /// The name of the Docker image running the job.
        /// </summary>
        public string? CIJobImage => this["CI_JOB_IMAGE"];

        /// <summary>
        /// A RS256 JSON web token to authenticate with third party systems that support JWT authentication, for example HashiCorp’s Vault. Deprecated in GitLab 15.9 and scheduled to be removed in GitLab 17.0. Use ID tokens instead.
        /// </summary>
        [Obsolete("Use ID tokens instead.")]
        public string? CIJobJwt => this["CI_JOB_JWT"];

        /// <summary>
        /// The same value as CI_JOB_JWT. Deprecated in GitLab 15.9 and scheduled to be removed in GitLab 17.0. Use ID tokens instead.
        /// </summary>
        [Obsolete("Use ID tokens instead.")]
        public string? CIJobJwtV1 => this["CI_JOB_JWT_V1"];

        /// <summary>
        /// A newly formatted RS256 JSON web token to increase compatibility. Similar to CI_JOB_JWT, except the issuer (iss) claim is changed from gitlab.com to https://gitlab.com, sub has changed from job_id to a string that contains the project path, and an aud claim is added. The aud field is a constant value. Trusting JWTs in multiple relying parties can lead to one RP sending a JWT to another one and acting maliciously as a job. Deprecated in GitLab 15.9 and scheduled to be removed in GitLab 17.0. Use ID tokens instead.
        /// </summary>
        [Obsolete("Use ID tokens instead.")]
        public string? CIJobJwtV2 => this["CI_JOB_JWT_V2"];

        /// <summary>
        /// Only available if the job was started manually. true when available.
        /// </summary>
        public string? CIJobManual => this["CI_JOB_MANUAL"];

        /// <summary>
        /// The name of the job.
        /// </summary>
        public string? CIJobName => this["CI_JOB_NAME"];

        /// <summary>
        /// CI_JOB_NAME in lowercase, shortened to 63 bytes, and with everything except 0-9 and a-z replaced with -. No leading / trailing -. Use in paths. Introduced in GitLab 15.4.
        /// </summary>
        public string? CIJobNameSlug => this["CI_JOB_NAME_SLUG"];

        /// <summary>
        /// The name of the job’s stage.
        /// </summary>
        public string? CIJobStage => this["CI_JOB_STAGE"];

        /// <summary>
        /// The status of the job as each runner stage is executed. Use with after_script. Can be success, failed, or canceled.
        /// </summary>
        public string? CIJobStatus => this["CI_JOB_STATUS"];

        /// <summary>
        /// The job timeout, in seconds. Introduced in GitLab 15.7. Requires GitLab Runner 15.7.
        /// </summary>
        public string? CIJobTimeout => this["CI_JOB_TIMEOUT"];

        /// <summary>
        /// A token to authenticate with certain API endpoints. The token is valid as long as the job is running.
        /// </summary>
        public string? CIJobToken => this["CI_JOB_TOKEN"];

        /// <summary>
        /// The job details URL.
        /// </summary>
        public string? CIJobUrl => this["CI_JOB_URL"];

        /// <summary>
        /// The date and time when a job started, in ISO 8601 format. For example, 2022-01-31T16:47:55Z. UTC by default.
        /// </summary>
        public string? CIJobStartedAt => this["CI_JOB_STARTED_AT"];

        /// <summary>
        /// Only available if the pipeline has a Kubernetes cluster available for deployments. true when available.
        /// </summary>
        public string? CIKubernetesActive => this["CI_KUBERNETES_ACTIVE"];

        /// <summary>
        /// The index of the job in the job set. Only available if the job uses parallel.
        /// </summary>
        public string? CINodeIndex => this["CI_NODE_INDEX"];

        /// <summary>
        /// The total number of instances of this job running in parallel. Set to 1 if the job does not use parallel.
        /// </summary>
        public string? CINodeTotal => this["CI_NODE_TOTAL"];

        /// <summary>
        /// A comma-separated list of up to four merge requests that use the current branch and project as the merge request source. Only available in branch and merge request pipelines if the branch has an associated merge request. For example, gitlab-org/gitlab!333,gitlab-org/gitlab-foss!11.
        /// </summary>
        public string? CIOpenMergeRequests => this["CI_OPEN_MERGE_REQUESTS"];

        /// <summary>
        /// The configured domain that hosts GitLab Pages.
        /// </summary>
        public string? CIPagesDomain => this["CI_PAGES_DOMAIN"];

        /// <summary>
        /// The URL for a GitLab Pages site. Always a subdomain of CI_PAGES_DOMAIN.
        /// </summary>
        public string? CIPagesUrl => this["CI_PAGES_URL"];

        /// <summary>
        /// The instance-level ID of the current pipeline. This ID is unique across all projects on the GitLab instance.
        /// </summary>
        public string? CIPipelineId => this["CI_PIPELINE_ID"];

        /// <summary>
        /// The project-level IID (internal ID) of the current pipeline. This ID is unique only in the current project.
        /// </summary>
        public string? CIPipelineInternalId => this["CI_PIPELINE_IID"];

        /// <summary>
        /// How the pipeline was triggered. The value can be one of the pipeline sources.
        /// </summary>
        public string? CIPipelineSource => this["CI_PIPELINE_SOURCE"];

        /// <summary>
        /// true if the job was triggered.
        /// </summary>
        public string? CIPipelineTriggered => this["CI_PIPELINE_TRIGGERED"];

        /// <summary>
        /// The URL for the pipeline details.
        /// </summary>
        public string? CIPipelineUrl => this["CI_PIPELINE_URL"];

        /// <summary>
        /// The date and time when the pipeline was created, in ISO 8601 format. For example, 2022-01-31T16:47:55Z. UTC by default.
        /// </summary>
        public string? CIPipelineCreatedAt => this["CI_PIPELINE_CREATED_AT"];

        /// <summary>
        /// The pipeline name defined in workflow:name. Introduced in GitLab 16.3.
        /// </summary>
        public string? CIPipelineName => this["CI_PIPELINE_NAME"];

        /// <summary>
        /// The full path the repository is cloned to, and where the job runs from. If the GitLab Runner builds_dir parameter is set, this variable is set relative to the value of builds_dir. For more information, see the Advanced GitLab Runner configuration.
        /// </summary>
        public string? CIProjectDirectory => this["CI_PROJECT_DIR"];

        /// <summary>
        /// The ID of the current project. This ID is unique across all projects on the GitLab instance.
        /// </summary>
        public string? CIProjectId => this["CI_PROJECT_ID"];

        /// <summary>
        /// The name of the directory for the project. For example if the project URL is gitlab.example.com/group-name/project-1, CI_PROJECT_NAME is project-1.
        /// </summary>
        public string? CIProjectName => this["CI_PROJECT_NAME"];

        /// <summary>
        /// The project namespace (username or group name) of the job.
        /// </summary>
        public string? CIProjectNamespace => this["CI_PROJECT_NAMESPACE"];

        /// <summary>
        /// The project namespace ID of the job. Introduced in GitLab 15.7.
        /// </summary>
        public string? CIProjectNamespaceId => this["CI_PROJECT_NAMESPACE_ID"];

        /// <summary>
        /// $CI_PROJECT_PATH in lowercase with characters that are not a-z or 0-9 replaced with - and shortened to 63 bytes. Use in URLs and domain names.
        /// </summary>
        public string? CIProjectPathSlug => this["CI_PROJECT_PATH_SLUG"];

        /// <summary>
        /// The project namespace with the project name included.
        /// </summary>
        public string? CIProjectPath => this["CI_PROJECT_PATH"];

        /// <summary>
        /// A comma-separated, lowercase list of the languages used in the repository. For example ruby,javascript,html,css. The maximum number of languages is limited to 5. An issue proposes to increase the limit.
        /// </summary>
        public string? CIProjectRepositoryLanguages => this["CI_PROJECT_REPOSITORY_LANGUAGES"];

        /// <summary>
        /// The root project namespace (username or group name) of the job. For example, if CI_PROJECT_NAMESPACE is root-group/child-group/grandchild-group, CI_PROJECT_ROOT_NAMESPACE is root-group.
        /// </summary>
        public string? CIProjectRootNamespace => this["CI_PROJECT_ROOT_NAMESPACE"];

        /// <summary>
        /// The human-readable project name as displayed in the GitLab web interface.
        /// </summary>
        public string? CIProjectTitle => this["CI_PROJECT_TITLE"];

        /// <summary>
        /// The project description as displayed in the GitLab web interface. Introduced in GitLab 15.1.
        /// </summary>
        public string? CIProjectDescription => this["CI_PROJECT_DESCRIPTION"];

        /// <summary>
        /// The HTTP(S) address of the project.
        /// </summary>
        public string? CIProjectUrl => this["CI_PROJECT_URL"];

        /// <summary>
        /// The project visibility. Can be internal, private, or public.
        /// </summary>
        public string? CIProjectVisibility => this["CI_PROJECT_VISIBILITY"];

        /// <summary>
        /// The project external authorization classification label.
        /// </summary>
        public string? CIProjectClassificationLevel => this["CI_PROJECT_CLASSIFICATION_LABEL"];

        /// <summary>
        /// Address of the container registry server, formatted as &lt;host&gt;[:&lt;port&gt;]. For example: registry.gitlab.example.com. Only available if the container registry is enabled for the GitLab instance.
        /// </summary>
        public string? CIRegistry => this["CI_REGISTRY"];

        /// <summary>
        /// Base address for the container registry to push, pull, or tag project’s images, formatted as &lt;host&gt;[:&lt;port&gt;]/&lt;project_full_path&gt;. For example: registry.gitlab.example.com/my_group/my_project. Image names must follow the container registry naming convention. Only available if the container registry is enabled for the project.
        /// </summary>
        public string? CIRegistryImage => this["CI_REGISTRY_IMAGE"];

        /// <summary>
        /// The password to push containers to the GitLab project’s container registry. Only available if the container registry is enabled for the project. This password value is the same as the CI_JOB_TOKEN and is valid only as long as the job is running. Use the CI_DEPLOY_PASSWORD for long-lived access to the registry
        /// </summary>
        public string? CIRegistryPassword => this["CI_REGISTRY_PASSWORD"];

        /// <summary>
        /// The username to push containers to the project’s GitLab container registry. Only available if the container registry is enabled for the project.
        /// </summary>
        public string? CIRegistryUser => this["CI_REGISTRY_USER"];

        /// <summary>
        /// The description of the release. Available only on pipelines for tags. Description length is limited to first 1024 characters. Introduced in GitLab 15.5.
        /// </summary>
        public string? CIReleaseDescription => this["CI_RELEASE_DESCRIPTION"];

        /// <summary>
        /// The full path to Git clone (HTTP) the repository with a CI/CD job token, in the format https://gitlab-ci-token:$CI_JOB_TOKEN@gitlab.example.com/my-group/my-project.git.
        /// </summary>
        public string? CIRepositoryUrl => this["CI_REPOSITORY_URL"];

        /// <summary>
        /// The description of the runner.
        /// </summary>
        public string? CIRunnerDescription => this["CI_RUNNER_DESCRIPTION"];

        /// <summary>
        /// The OS/architecture of the GitLab Runner executable. Might not be the same as the environment of the executor.
        /// </summary>
        public string? CIRunnerExecutableArch => this["CI_RUNNER_EXECUTABLE_ARCH"];

        /// <summary>
        /// The unique ID of the runner being used.
        /// </summary>
        public string? CIRunnerId => this["CI_RUNNER_ID"];

        /// <summary>
        /// The revision of the runner running the job.
        /// </summary>
        public string? CIRunnerRevision => this["CI_RUNNER_REVISION"];

        /// <summary>
        /// The runner’s unique ID, used to authenticate new job requests. The token contains a prefix, and the first 17 characters are used.
        /// </summary>
        public string? CIRunnerShortToken => this["CI_RUNNER_SHORT_TOKEN"];

        /// <summary>
        /// A comma-separated list of the runner tags.
        /// </summary>
        public string? CIRunnerTags => this["CI_RUNNER_TAGS"];

        /// <summary>
        /// The version of the GitLab Runner running the job.
        /// </summary>
        public string? CIRunnerVersion => this["CI_RUNNER_VERSION"];

        /// <summary>
        /// The fully qualified domain name (FQDN) of the instance. For example gitlab.example.com:8080. Introduced in GitLab 16.10.
        /// </summary>
        public string? CIServerFQDN => this["CI_SERVER_FQDN"];

        /// <summary>
        /// The host of the GitLab instance URL, without protocol or port. For example gitlab.example.com.
        /// </summary>
        public string? CIServerHost => this["CI_SERVER_HOST"];

        /// <summary>
        /// The name of CI/CD server that coordinates jobs.
        /// </summary>
        public string? CIServerName => this["CI_SERVER_NAME"];

        /// <summary>
        /// The port of the GitLab instance URL, without host or protocol. For example 8080.
        /// </summary>
        public string? CIServerPort => this["CI_SERVER_PORT"];

        /// <summary>
        /// The protocol of the GitLab instance URL, without host or port. For example https.
        /// </summary>
        public string? CIServerProtocol => this["CI_SERVER_PROTOCOL"];

        /// <summary>
        /// The SSH host of the GitLab instance, used for access to Git repositories through SSH. For example gitlab.com. Introduced in GitLab 15.11.
        /// </summary>
        public string? CIServerShellSSHHost => this["CI_SERVER_SHELL_SSH_HOST"];

        /// <summary>
        /// The SSH port of the GitLab instance, used for access to Git repositories through SSH. For example 22. Introduced in GitLab 15.11.
        /// </summary>
        public string? CIServerShellSSHPort => this["CI_SERVER_SHELL_SSH_PORT"];

        /// <summary>
        /// GitLab revision that schedules jobs.
        /// </summary>
        public string? CIServerRevision => this["CI_SERVER_REVISION"];

        /// <summary>
        /// File containing the TLS CA certificate to verify the GitLab server when tls-ca-file set in runner settings.
        /// </summary>
        public string? CIServerTlsCAFile => this["CI_SERVER_TLS_CA_FILE"];

        /// <summary>
        /// File containing the TLS certificate to verify the GitLab server when tls-cert-file set in runner settings.
        /// </summary>
        public string? CIServerTlsCertFile => this["CI_SERVER_TLS_CERT_FILE"];

        /// <summary>
        /// File containing the TLS key to verify the GitLab server when tls-key-file set in runner settings.
        /// </summary>
        public string? CIServerTlsKeyFile => this["CI_SERVER_TLS_KEY_FILE"];

        /// <summary>
        /// The base URL of the GitLab instance, including protocol and port. For example https://gitlab.example.com:8080.
        /// </summary>
        public string? CIServerUrl => this["CI_SERVER_URL"];

        /// <summary>
        /// The major version of the GitLab instance. For example, if the GitLab version is 17.2.1, the CI_SERVER_VERSION_MAJOR is 17.
        /// </summary>
        public string? CIServerVersionMajor => this["CI_SERVER_VERSION_MAJOR"];

        /// <summary>
        /// The minor version of the GitLab instance. For example, if the GitLab version is 17.2.1, the CI_SERVER_VERSION_MINOR is 2.
        /// </summary>
        public string? CIServerVersionMinor => this["CI_SERVER_VERSION_MINOR"];

        /// <summary>
        /// The patch version of the GitLab instance. For example, if the GitLab version is 17.2.1, the CI_SERVER_VERSION_PATCH is 1.
        /// </summary>
        public string? CIServerVersionPatch => this["CI_SERVER_VERSION_PATCH"];

        /// <summary>
        /// The full version of the GitLab instance.
        /// </summary>
        public string? CIServerVersion => this["CI_SERVER_VERSION"];

        /// <summary>
        /// Available for all jobs executed in CI/CD. yes when available.
        /// </summary>
        public string? CIServer => this["CI_SERVER"];

        /// <summary>
        /// Only available if the job is executed in a shared environment (something that is persisted across CI/CD invocations, like the shell or ssh executor). true when available.
        /// </summary>
        public string? CISharedEnvironment => this["CI_SHARED_ENVIRONMENT"];

        /// <summary>
        /// The host of the registry used by CI/CD templates. Defaults to registry.gitlab.com. Introduced in GitLab 15.3.
        /// </summary>
        public string? CITemplateRegistryHost => this["CI_TEMPLATE_REGISTRY_HOST"];

        /// <summary>
        /// First 4 characters of the trigger token of the current job. Only available if the pipeline was triggered with a trigger token. For example, for a trigger token of glptt-dbf556605bcad4d9db3ec5fcef84f78f9b4fec28, CI_TRIGGER_SHORT_TOKEN would be dbf5. Introduced in GitLab 17.0.
        /// </summary>
        public string? CITriggerShortToken => this["CI_TRIGGER_SHORT_TOKEN"];

        /// <summary>
        /// Available for all jobs executed in CI/CD. true when available.
        /// </summary>
        public string? GitLabCI => this["GITLAB_CI"];

        /// <summary>
        /// The comma-separated list of licensed features available for the GitLab instance and license.
        /// </summary>
        public string? GitLabFeatures => this["GITLAB_FEATURES"];

        /// <summary>
        /// The email of the user who started the pipeline, unless the job is a manual job. In manual jobs, the value is the email of the user who started the job.
        /// </summary>
        public string? GitLabUserEmail => this["GITLAB_USER_EMAIL"];

        /// <summary>
        /// The numeric ID of the user who started the pipeline, unless the job is a manual job. In manual jobs, the value is the ID of the user who started the job.
        /// </summary>
        public string? GitLabUserId => this["GITLAB_USER_ID"];

        /// <summary>
        /// The unique username of the user who started the pipeline, unless the job is a manual job. In manual jobs, the value is the username of the user who started the job.
        /// </summary>
        public string? GitLabUserLogin => this["GITLAB_USER_LOGIN"];

        /// <summary>
        /// The display name (user-defined Full name in the profile settings) of the user who started the pipeline, unless the job is a manual job. In manual jobs, the value is the name of the user who started the job.
        /// </summary>
        public string? GitLabUsername => this["GITLAB_USER_NAME"];

        /// <summary>
        /// The path to the kubeconfig file with contexts for every shared agent connection. Only available when a GitLab agent is authorized to access the project.
        /// </summary>
        public string? Kubeconfig => this["KUBECONFIG"];

        /// <summary>
        /// The webhook payload. Only available when a pipeline is triggered with a webhook.
        /// </summary>
        public string? TriggerPayload => this["TRIGGER_PAYLOAD"];

        /// <summary>
        /// Approval status of the merge request. true when merge request approvals is available and the merge request has been approved.
        /// </summary>
        public string? CIMergeRequestApproved => this["CI_MERGE_REQUEST_APPROVED"];

        /// <summary>
        /// Comma-separated list of usernames of assignees for the merge request.
        /// </summary>
        public string? CIMergeRequestAssignees => this["CI_MERGE_REQUEST_ASSIGNEES"];

        /// <summary>
        /// The base SHA of the merge request diff.
        /// </summary>
        public string? CIMergeRequestDiffBaseSHA => this["CI_MERGE_REQUEST_DIFF_BASE_SHA"];

        /// <summary>
        /// The version of the merge request diff.
        /// </summary>
        public string? CIMergeRequestDiffId => this["CI_MERGE_REQUEST_DIFF_ID"];

        /// <summary>
        /// The event type of the merge request. Can be detached, merged_result or merge_train.
        /// </summary>
        public string? CIMergeRequestEventType => this["CI_MERGE_REQUEST_EVENT_TYPE"];

        /// <summary>
        /// The description of the merge request. If the description is more than 2700 characters long, only the first 2700 characters are stored in the variable. Introduced in GitLab 16.7.
        /// </summary>
        public string? CIMergeRequestDescription => this["CI_MERGE_REQUEST_DESCRIPTION"];

        /// <summary>
        /// true if CI_MERGE_REQUEST_DESCRIPTION is truncated down to 2700 characters because the description of the merge request is too long. Introduced in GitLab 16.8.
        /// </summary>
        public string? CIMergeRequestDescriptionIsTruncated => this["CI_MERGE_REQUEST_DESCRIPTION_IS_TRUNCATED"];

        /// <summary>
        /// The instance-level ID of the merge request. The ID is unique across all projects on the GitLab instance.
        /// </summary>
        public string? CIMergeRequestId => this["CI_MERGE_REQUEST_ID"];

        /// <summary>
        /// The project-level IID (internal ID) of the merge request. This ID is unique for the current project, and is the number used in the merge request URL, page title, and other visible locations.
        /// </summary>
        public string? CIMergeRequestInternalId => this["CI_MERGE_REQUEST_IID"];

        /// <summary>
        /// Comma-separated label names of the merge request.
        /// </summary>
        public string? CIMergeRequestLabels => this["CI_MERGE_REQUEST_LABELS"];

        /// <summary>
        /// The milestone title of the merge request.
        /// </summary>
        public string? CIMergeRequestMilestone => this["CI_MERGE_REQUEST_MILESTONE"];

        /// <summary>
        /// The ID of the project of the merge request.
        /// </summary>
        public string? CIMergeRequestProjectId => this["CI_MERGE_REQUEST_PROJECT_ID"];

        /// <summary>
        /// The path of the project of the merge request. For example namespace/awesome-project.
        /// </summary>
        public string? CIMergeRequestProjectPath => this["CI_MERGE_REQUEST_PROJECT_PATH"];

        /// <summary>
        /// The URL of the project of the merge request. For example, http://192.168.10.15:3000/namespace/awesome-project.
        /// </summary>
        public string? CIMergeRequestProjectUrl => this["CI_MERGE_REQUEST_PROJECT_URL"];

        /// <summary>
        /// The ref path of the merge request. For example, refs/merge-requests/1/head.
        /// </summary>
        public string? CIMergeRequestRefPath => this["CI_MERGE_REQUEST_REF_PATH"];

        /// <summary>
        /// The source branch name of the merge request.
        /// </summary>
        public string? CIMergeRequestSourceBranchName => this["CI_MERGE_REQUEST_SOURCE_BRANCH_NAME"];

        /// <summary>
        /// true when the source branch of the merge request is protected. Introduced in GitLab 16.4.
        /// </summary>
        public string? CIMergeRequestSourceBranchProtected => this["CI_MERGE_REQUEST_SOURCE_BRANCH_PROTECTED"];

        /// <summary>
        /// The HEAD SHA of the source branch of the merge request. The variable is empty in merge request pipelines. The SHA is present only in merged results pipelines.
        /// </summary>
        public string? CIMergeRequestSourceBranchSHA => this["CI_MERGE_REQUEST_SOURCE_BRANCH_SHA"];

        /// <summary>
        /// The ID of the source project of the merge request.
        /// </summary>
        public string? CIMergeRequestSourceProjectId => this["CI_MERGE_REQUEST_SOURCE_PROJECT_ID"];

        /// <summary>
        /// The path of the source project of the merge request.
        /// </summary>
        public string? CIMergeRequestSourceProjectPath => this["CI_MERGE_REQUEST_SOURCE_PROJECT_PATH"];

        /// <summary>
        /// The URL of the source project of the merge request.
        /// </summary>
        public string? CIMergeRequestSourceProjectUrl => this["CI_MERGE_REQUEST_SOURCE_PROJECT_URL"];

        /// <summary>
        /// true when the squash on merge option is set. Introduced in GitLab 16.4.
        /// </summary>
        public string? CIMergeRequestSquashOnMerge => this["CI_MERGE_REQUEST_SQUASH_ON_MERGE"];

        /// <summary>
        /// The target branch name of the merge request.
        /// </summary>
        public string? CIMergeRequestTargetBranchName => this["CI_MERGE_REQUEST_TARGET_BRANCH_NAME"];

        /// <summary>
        /// true when the target branch of the merge request is protected. Introduced in GitLab 15.2.
        /// </summary>
        public string? CIMergeRequestTargetBranchProtected => this["CI_MERGE_REQUEST_TARGET_BRANCH_PROTECTED"];

        /// <summary>
        /// The HEAD SHA of the target branch of the merge request. The variable is empty in merge request pipelines. The SHA is present only in merged results pipelines.
        /// </summary>
        public string? CIMergeRequestTargetBranchSHA => this["CI_MERGE_REQUEST_TARGET_BRANCH_SHA"];

        /// <summary>
        /// The title of the merge request.
        /// </summary>
        public string? CIMergeRequestTitle => this["CI_MERGE_REQUEST_TITLE"];

        /// <summary>
        /// Pull request ID from GitHub.
        /// </summary>
        public string? CIExternalPullRequestId => this["CI_EXTERNAL_PULL_REQUEST_IID"];

        /// <summary>
        /// The source repository name of the pull request.
        /// </summary>
        public string? CIExternalPullRequestSourceRepository => this["CI_EXTERNAL_PULL_REQUEST_SOURCE_REPOSITORY"];

        /// <summary>
        /// The target repository name of the pull request.
        /// </summary>
        public string? CIExternalPullRequestTargetRepository => this["CI_EXTERNAL_PULL_REQUEST_TARGET_REPOSITORY"];

        /// <summary>
        /// The source branch name of the pull request.
        /// </summary>
        public string? CIExternalPullRequestSourceBranchName => this["CI_EXTERNAL_PULL_REQUEST_SOURCE_BRANCH_NAME"];

        /// <summary>
        /// The HEAD SHA of the source branch of the pull request.
        /// </summary>
        public string? CIExternalPullRequestSourceBranchSHA => this["CI_EXTERNAL_PULL_REQUEST_SOURCE_BRANCH_SHA"];

        /// <summary>
        /// The target branch name of the pull request.
        /// </summary>
        public string? CIExternalPullRequestTargetBranchName => this["CI_EXTERNAL_PULL_REQUEST_TARGET_BRANCH_NAME"];

        /// <summary>
        /// The HEAD SHA of the target branch of the pull request.
        /// </summary>
        public string? CIExternalPullRequestTargetBranchSHA => this["CI_EXTERNAL_PULL_REQUEST_TARGET_BRANCH_SHA"];

        /// <summary>
        /// The URL of the Harbor registry.
        /// </summary>
        public string? HarborUrl => this["HARBOR_URL"];

        /// <summary>
        /// The host name of the Harbor registry.
        /// </summary>
        public string? HarborHost => this["HARBOR_HOST"];

        /// <summary>
        /// OCI (Open Container Initiative) registry information used in Harbor.
        /// </summary>
        public string? HarborOCI => this["HARBOR_OCI"];

        /// <summary>
        /// The project name used in the Harbor registry.
        /// </summary>
        public string? HarborProject => this["HARBOR_PROJECT"];

        /// <summary>
        /// The username to access the Harbor registry.
        /// </summary>
        public string? HarborUsername => this["HARBOR_USERNAME"];

        /// <summary>
        /// The password to access the Harbor registry.
        /// </summary>
        public string? HarborPassword => this["HARBOR_PASSWORD"];

        /// <summary>
        /// The issuer ID of the Apple App Store Connect API key.
        /// </summary>
        public string? AppStoreConnectApiKeyIssuerId => this["APP_STORE_CONNECT_API_KEY_ISSUER_ID"];

        /// <summary>
        /// The key ID of the Apple App Store Connect API key.
        /// </summary>
        public string? AppStoreConnectApiKeyId => this["APP_STORE_CONNECT_API_KEY_KEY_ID"];

        /// <summary>
        /// The actual Apple App Store Connect API key.
        /// </summary>
        public string? AppStoreConnectApiKeyKey => this["APP_STORE_CONNECT_API_KEY_KEY"];

        /// <summary>
        /// Indicates whether the Apple App Store Connect API key is Base64 encoded.
        /// </summary>
        public string? AppStoreConnectApiKeyIsKeyContentBase64 => this["APP_STORE_CONNECT_API_KEY_IS_KEY_CONTENT_BASE64"];

        /// <summary>
        /// The package name for deployment to Google Play Store.
        /// </summary>
        public string? GooglePlaySupplyPackageName => this["SUPPLY_PACKAGE_NAME"];

        /// <summary>
        /// The data of the authentication key (in JSON format) for deployment to Google Play Store.
        /// </summary>
        public string? GooglePlaySupplyJsonKeyData => this["SUPPLY_JSON_KEY_DATA"];

        /// <summary>
        /// The license key used by Diffblue.
        /// </summary>
        public string? DiffblueLicenseKey => this["DIFFBLUE_LICENSE_KEY"];

        /// <summary>
        /// The name of the access token used by Diffblue.
        /// </summary>
        public string? DiffblueAccessTokenName => this["DIFFBLUE_ACCESS_TOKEN_NAME"];

        /// <summary>
        /// The access token used by Diffblue.
        /// </summary>
        public string? DiffblueAccessToken => this["DIFFBLUE_ACCESS_TOKEN"];
    }
}
