using System.Collections.Generic;

namespace EnvVarAwareness.CI
{
    /// <summary>
    /// Represents a collection of environment variables used in CircleCI.
    /// </summary>
    /// <see href="https://circleci.com/docs/variables/"/>
    public sealed class CircleCIEnv : EnvBase
    {
        /// <summary>
        /// Signifies Circle CI configuration values.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetCircleCIVariables()
            => GetEnvironmentVariables("CIRCLE_");

        /// <summary>
        /// Represents whether the current environment is a CI environment
        /// </summary>
        public string? CI => this["CI"];

        /// <summary>
        /// Represents whether the current environment is a CircleCI environment
        /// </summary>
        public string? CircleCI => this["CIRCLECI"];

        /// <summary>
        /// The name of the Git branch currently being built.
        /// </summary>
        public string? CircleBranch => this["CIRCLE_BRANCH"];

        /// <summary>
        /// The number of the current job. Job numbers are unique for each job.
        /// </summary>
        public string? CircleBuildNum => this["CIRCLE_BUILD_NUM"];

        /// <summary>
        /// The URL for the current job on CircleCI.
        /// </summary>
        public string? CircleBuildUrl => this["CIRCLE_BUILD_URL"];

        /// <summary>
        /// The name of the current job.
        /// </summary>
        public string? CircleJob => this["CIRCLE_JOB"];

        /// <summary>
        /// For jobs that run with parallelism enabled, this is the index of the current parallel run. The value ranges from 0 to (CIRCLE_NODE_TOTAL - 1)
        /// </summary>
        public string? CircleNodeIndex => this["CIRCLE_NODE_INDEX"];

        /// <summary>
        /// For jobs that run with parallelism enabled, this is the number of parallel runs. This is equivalent to the value of parallelism in your config file.
        /// </summary>
        public string? CircleNodeTotal => this["CIRCLE_NODE_TOTAL"];

        /// <summary>
        /// An OpenID Connect token signed by CircleCI which includes details about the current job.
        /// </summary>
        public string? CircleOidcToken => this["CIRCLE_OIDC_TOKEN"];

        /// <summary>
        /// An OpenID Connect token signed by CircleCI which includes details about the current job.
        /// </summary>
        public string? CircleOidcTokenV2 => this["CIRCLE_OIDC_TOKEN_V2"];

        /// <summary>
        /// A unique identifier for the CircleCI organization.
        /// </summary>
        public string? CircleOrganizationId => this["CIRCLE_ORGANIZATION_ID"];

        /// <summary>
        /// A unique identifier for the current pipeline.
        /// </summary>
        public string? CirclePipelineId => this["CIRCLE_PIPELINE_ID"];

        /// <summary>
        /// The number of the associated GitHub or Bitbucket pull request. Only available on forked PRs.
        /// </summary>
        public string? CirclePrNumber => this["CIRCLE_PR_NUMBER"];

        /// <summary>
        /// The name of the GitHub or Bitbucket repository where the pull request was created. Only available on forked PRs.
        /// </summary>
        public string? CirclePrRepoName => this["CIRCLE_PR_REPONAME"];

        /// <summary>
        /// The GitHub or Bitbucket username of the user who created the pull request. Only available on forked PRs.
        /// </summary>
        public string? CirclePrUsername => this["CIRCLE_PR_USERNAME"];

        /// <summary>
        /// The largest job number in a given branch that is less than the current job number. Note: The variable is not always set, and is not deterministic. It is also not set on runner executors. This variable is likely to be deprecated, and CircleCI recommends users to avoid using it.
        /// </summary>
        public string? CirclePreviousBuildNum => this["CIRCLE_PREVIOUS_BUILD_NUM"];

        /// <summary>
        /// A unique identifier for the current project.
        /// </summary>
        public string? CircleProjectId => this["CIRCLE_PROJECT_ID"];

        /// <summary>
        /// The name of the repository of the current project.
        /// </summary>
        public string? CircleProjectRepoName => this["CIRCLE_PROJECT_REPONAME"];

        /// <summary>
        /// The GitHub or Bitbucket username of the current project.
        /// </summary>
        public string? CircleProjectUsername => this["CIRCLE_PROJECT_USERNAME"];

        /// <summary>
        /// The URL of the associated pull request. If there are multiple associated pull requests, one URL is randomly chosen.
        /// </summary>
        public string? CirclePullRequest => this["CIRCLE_PULL_REQUEST"];

        /// <summary>
        /// Comma-separated list of URLs of the current build’s associated pull requests.
        /// </summary>
        public string? CirclePullRequests => this["CIRCLE_PULL_REQUESTS"];

        /// <summary>
        /// The URL of your GitHub or Bitbucket repository.
        /// </summary>
        public string? CircleRepositoryUrl => this["CIRCLE_REPOSITORY_URL"];

        /// <summary>
        /// The SHA1 hash of the last commit of the current build.
        /// </summary>
        public string? CircleSHA1 => this["CIRCLE_SHA1"];

        /// <summary>
        /// The name of the git tag, if the current build is tagged. For more information, see the Git tag job execution section of the Workflows page.
        /// </summary>
        public string? CircleTag => this["CIRCLE_TAG"];

        /// <summary>
        /// The GitHub or Bitbucket username of the user who triggered the pipeline (only if the user has a CircleCI account).
        /// </summary>
        public string? CircleUsername => this["CIRCLE_USERNAME"];

        /// <summary>
        /// A unique identifier for the workflow instance of the current job. This identifier is the same for every job in a given workflow instance.
        /// </summary>
        public string? CircleWorkflowId => this["CIRCLE_WORKFLOW_ID"];

        /// <summary>
        /// A unique identifier for the current job.
        /// </summary>
        public string? CircleWorkflowJobId => this["CIRCLE_WORKFLOW_JOB_ID"];

        /// <summary>
        /// An identifier for the workspace of the current job. This identifier is the same for every job in a given workflow.
        /// </summary>
        public string? CircleWorkflowWorkspaceId => this["CIRCLE_WORKFLOW_WORKSPACE_ID"];

        /// <summary>
        /// The value of the working_directory key of the current job.
        /// </summary>
        public string? CircleWorkingDirectory => this["CIRCLE_WORKING_DIRECTORY"];

        /// <summary>
        /// Internal. A directory where internal data related to the job is stored. We do not document the contents of this directory; the data schema is subject to change.
        /// </summary>
        public string? CircleInternalTaskData => this["CIRCLE_INTERNAL_TASK_DATA"];
    }
}
