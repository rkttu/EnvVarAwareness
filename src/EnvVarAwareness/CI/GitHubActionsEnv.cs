using System.Collections.Generic;

namespace EnvVarAwareness.CI
{
    /// <summary>
    /// Represents a collection of environment variables used in GitHub Actions.
    /// </summary>
    /// <seealso href="https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does/store-information-in-variables"/>
    public sealed class GitHubActionsEnv : EnvBase
    {
        /// <summary>
        /// Signifies Github configuration values.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetGithubVariables()
            => GetEnvironmentVariables("GITHUB_");

        /// <summary>
        /// Signifies Github action runner configuration values.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetGithubActionRunnerVariables()
            => GetEnvironmentVariables("RUNNER_");

        /// <summary>
        /// Always set to true.
        /// </summary>
        public string? CI => this["CI"];

        /// <summary>
        /// The name of the action currently running, or the id of a step. For example, for an action, __repo-owner_name-of-action-repo.
        /// </summary>
        public string? GitHubAction => this["GITHUB_ACTION"];

        /// <summary>
        /// The path where an action is located. This property is only supported in composite actions. You can use this path to change directories to where the action is located and access other files in that same repository. For example, /home/runner/work/_actions/repo-owner/name-of-action-repo/v1.
        /// </summary>
        public string? GitHubActionPath => this["GITHUB_ACTION_PATH"];

        /// <summary>
        /// For a step executing an action, this is the owner and repository name of the action. For example, actions/checkout.
        /// </summary>
        public string? GitHubActionRepository => this["GITHUB_ACTION_REPOSITORY"];

        /// <summary>
        /// Always set to true when GitHub Actions is running the workflow. You can use this variable to differentiate when tests are being run locally or by GitHub Actions.
        /// </summary>
        public string? GitHubActions => this["GITHUB_ACTIONS"];

        /// <summary>
        /// The name of the person or app that initiated the workflow. For example, octocat.
        /// </summary>
        public string? GitHubActor => this["GITHUB_ACTOR"];

        /// <summary>
        /// The account ID of the person or app that triggered the initial workflow run. For example, 1234567. Note that this is different from the actor username.
        /// </summary>
        public string? GitHubActorId => this["GITHUB_ACTOR_ID"];

        /// <summary>
        /// Returns the API URL. For example: https://api.github.com.
        /// </summary>
        public string? GitHubApiUrl => this["GITHUB_API_URL"];

        /// <summary>
        /// The name of the base ref or target branch of the pull request in a workflow run. This is only set when the event that triggers a workflow run is either pull_request or pull_request_target. For example, main.
        /// </summary>
        public string? GitHubBaseRef => this["GITHUB_BASE_REF"];

        /// <summary>
        /// The path on the runner to the file that sets variables from workflow commands. The path to this file is unique to the current step and changes for each step in a job. For example, /home/runner/work/_temp/_runner_file_commands/set_env_87406d6e-4979-4d42-98e1-3dab1f48b13a. For more information, see "Workflow commands for GitHub Actions."
        /// </summary>
        public string? GitHubEnv => this["GITHUB_ENV"];

        /// <summary>
        /// The name of the event that triggered the workflow. For example, workflow_dispatch.
        /// </summary>
        public string? GitHubEventName => this["GITHUB_EVENT_NAME"];

        /// <summary>
        /// The path to the file on the runner that contains the full event webhook payload. For example, /github/workflow/event.json.
        /// </summary>
        public string? GitHubEventPath => this["GITHUB_EVENT_PATH"];

        /// <summary>
        /// Returns the GraphQL API URL. For example: https://api.github.com/graphql.
        /// </summary>
        public string? GitHubGraphQLUrl => this["GITHUB_GRAPHQL_URL"];

        /// <summary>
        /// The head ref or source branch of the pull request in a workflow run. This property is only set when the event that triggers a workflow run is either pull_request or pull_request_target. For example, feature-branch-1.
        /// </summary>
        public string? GitHubHeadRef => this["GITHUB_HEAD_REF"];

        /// <summary>
        /// The job_id of the current job. For example, greeting_job.
        /// </summary>
        public string? GitHubJob => this["GITHUB_JOB"];

        /// <summary>
        /// The path on the runner to the file that sets the current step's outputs from workflow commands. The path to this file is unique to the current step and changes for each step in a job. For example, /home/runner/work/_temp/_runner_file_commands/set_output_a50ef383-b063-46d9-9157-57953fc9f3f0. For more information, see "Workflow commands for GitHub Actions."
        /// </summary>
        public string? GitHubOutput => this["GITHUB_OUTPUT"];

        /// <summary>
        /// The path on the runner to the file that sets system PATH variables from workflow commands. The path to this file is unique to the current step and changes for each step in a job. For example, /home/runner/work/_temp/_runner_file_commands/add_path_899b9445-ad4a-400c-aa89-249f18632cf5. For more information, see "Workflow commands for GitHub Actions."
        /// </summary>
        public string? GitHubPath => this["GITHUB_PATH"];

        /// <summary>
        /// The fully-formed ref of the branch or tag that triggered the workflow run. For workflows triggered by push, this is the branch or tag ref that was pushed. For workflows triggered by pull_request, this is the pull request merge branch. For workflows triggered by release, this is the release tag created. For other triggers, this is the branch or tag ref that triggered the workflow run. This is only set if a branch or tag is available for the event type. The ref given is fully-formed, meaning that for branches the format is refs/heads/&lt;branch_name&gt;, for pull requests it is refs/pull/&lt;pr_number&gt;/merge, and for tags it is refs/tags/&lt;tag_name&gt;. For example, refs/heads/feature-branch-1.
        /// </summary>
        public string? GitHubRef => this["GITHUB_REF"];

        /// <summary>
        /// The short ref name of the branch or tag that triggered the workflow run. This value matches the branch or tag name shown on GitHub. For example, feature-branch-1. For pull requests, the format is &lt;pr_number&gt;/merge.
        /// </summary>
        public string? GitHubRefName => this["GITHUB_REF_NAME"];

        /// <summary>
        /// true if branch protections or rulesets are configured for the ref that triggered the workflow run.
        /// </summary>
        public string? GitHubRefProtected => this["GITHUB_REF_PROTECTED"];

        /// <summary>
        /// The type of ref that triggered the workflow run. Valid values are branch or tag.
        /// </summary>
        public string? GitHubRefType => this["GITHUB_REF_TYPE"];

        /// <summary>
        /// The owner and repository name. For example, octocat/Hello-World.
        /// </summary>
        public string? GitHubRepository => this["GITHUB_REPOSITORY"];

        /// <summary>
        /// The ID of the repository. For example, 123456789. Note that this is different from the repository name.
        /// </summary>
        public string? GitHubRepositoryId => this["GITHUB_REPOSITORY_ID"];

        /// <summary>
        /// The repository owner's name. For example, octocat.
        /// </summary>
        public string? GitHubRepositoryOwner => this["GITHUB_REPOSITORY_OWNER"];

        /// <summary>
        /// The repository owner's account ID. For example, 1234567. Note that this is different from the owner's name.
        /// </summary>
        public string? GitHubRepositoryOwnerId => this["GITHUB_REPOSITORY_OWNER_ID"];

        /// <summary>
        /// The number of days that workflow run logs and artifacts are kept. For example, 90.
        /// </summary>
        public string? GitHubRetentionDays => this["GITHUB_RETENTION_DAYS"];

        /// <summary>
        /// A unique number for each attempt of a particular workflow run in a repository. This number begins at 1 for the workflow run's first attempt, and increments with each re-run. For example, 3.
        /// </summary>
        public string? GitHubRunAttempt => this["GITHUB_RUN_ATTEMPT"];

        /// <summary>
        /// A unique number for each workflow run within a repository. This number does not change if you re-run the workflow run. For example, 1658821493.
        /// </summary>
        public string? GitHubRunId => this["GITHUB_RUN_ID"];

        /// <summary>
        /// A unique number for each run of a particular workflow in a repository. This number begins at 1 for the workflow's first run, and increments with each new run. This number does not change if you re-run the workflow run. For example, 3.
        /// </summary>
        public string? GitHubRunNumber => this["GITHUB_RUN_NUMBER"];

        /// <summary>
        /// The URL of the GitHub server. For example: https://github.com.
        /// </summary>
        public string? GitHubServerUrl => this["GITHUB_SERVER_URL"];

        /// <summary>
        /// The commit SHA that triggered the workflow. The value of this commit SHA depends on the event that triggered the workflow. For more information, see "Events that trigger workflows." For example, ffac537e6cbbf934b08745a378932722df287a53.
        /// </summary>
        public string? GitHubSHA => this["GITHUB_SHA"];

        /// <summary>
        /// The path on the runner to the file that contains job summaries from workflow commands. The path to this file is unique to the current step and changes for each step in a job. For example, /home/runner/_layout/_work/_temp/_runner_file_commands/step_summary_1cb22d7f-5663-41a8-9ffc-13472605c76c. For more information, see "Workflow commands for GitHub Actions."
        /// </summary>
        public string? GitHubStepSummary => this["GITHUB_STEP_SUMMARY"];

        /// <summary>
        /// The username of the user that initiated the workflow run. If the workflow run is a re-run, this value may differ from github.actor. Any workflow re-runs will use the privileges of github.actor, even if the actor initiating the re-run (github.triggering_actor) has different privileges.
        /// </summary>
        public string? GitHubTriggeringActor => this["GITHUB_TRIGGERING_ACTOR"];

        /// <summary>
        /// The name of the workflow. For example, My test workflow. If the workflow file doesn't specify a name, the value of this variable is the full path of the workflow file in the repository.
        /// </summary>
        public string? GitHubWorkflow => this["GITHUB_WORKFLOW"];

        /// <summary>
        /// The ref path to the workflow. For example, octocat/hello-world/.github/workflows/my-workflow.yml@refs/heads/my_branch.
        /// </summary>
        public string? GitHubWorkflowRef => this["GITHUB_WORKFLOW_REF"];

        /// <summary>
        /// The commit SHA for the workflow file.
        /// </summary>
        public string? GitHubWorkflowSHA => this["GITHUB_WORKFLOW_SHA"];

        /// <summary>
        /// The default working directory on the runner for steps, and the default location of your repository when using the checkout action. For example, /home/runner/work/my-repo-name/my-repo-name.
        /// </summary>
        public string? GitHubWorkspace => this["GITHUB_WORKSPACE"];

        /// <summary>
        /// The architecture of the runner executing the job. Possible values are X86, X64, ARM, or ARM64.
        /// </summary>
        public string? RunnerArch => this["RUNNER_ARCH"];

        /// <summary>
        /// This is set only if debug logging is enabled, and always has the value of 1. It can be useful as an indicator to enable additional debugging or verbose logging in your own job steps.
        /// </summary>
        public string? RunnerDebug => this["RUNNER_DEBUG"];

        /// <summary>
        /// The environment of the runner executing the job. Possible values are: github-hosted for GitHub-hosted runners provided by GitHub, and self-hosted for self-hosted runners configured by the repository owner.
        /// </summary>
        public string? RunnerEnvironment => this["RUNNER_ENVIRONMENT"];

        /// <summary>
        /// The name of the runner executing the job. This name may not be unique in a workflow run as runners at the repository and organization levels could use the same name. For example, Hosted Agent
        /// </summary>
        public string? RunnerName => this["RUNNER_NAME"];

        /// <summary>
        /// The operating system of the runner executing the job. Possible values are Linux, Windows, or macOS. For example, Windows
        /// </summary>
        public string? RunnerOS => this["RUNNER_OS"];

        /// <summary>
        /// The path to a temporary directory on the runner. This directory is emptied at the beginning and end of each job. Note that files will not be removed if the runner's user account does not have permission to delete them. For example, D:\a\_temp
        /// </summary>
        public string? RunnerTemp => this["RUNNER_TEMP"];

        /// <summary>
        /// The path to the directory containing preinstalled tools for GitHub-hosted runners. For more information, see "Using GitHub-hosted runners". For example, C:\hostedtoolcache\windows
        /// </summary>
        public string? RunnerToolCache => this["RUNNER_TOOL_CACHE"];
    }
}
