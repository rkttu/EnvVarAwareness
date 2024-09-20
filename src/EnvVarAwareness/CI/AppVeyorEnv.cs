using System.Collections.Generic;

namespace EnvVarAwareness.CI
{
    /// <summary>
    /// Represents a collection of environment variables used in AppVeyor.
    /// </summary>
    /// <see href="https://www.appveyor.com/docs/environment-variables/"/>
    public sealed class AppVeyorEnv : EnvBase
    {
        /// <summary>
        /// Signifies AppVeyor CI configuration values.
        /// </summary>
        /// <returns>
        /// A dictionary of app settings matched by the prefix.
        /// </returns>
        public IDictionary<string, string> GetAppVeyorCIVariables()
            => GetEnvironmentVariables("APPVEYOR_");

        /// <summary>
        /// True (or true on Ubuntu image) if the build is running in the AppVeyor environment.
        /// </summary>
        public string? AppVeyor => this["APPVEYOR"];

        /// <summary>
        /// True (or true on Ubuntu image) if the build is running in the AppVeyor environment.
        /// </summary>
        public string? CI => this["CI"];

        /// <summary>
        /// The URL of AppVeyor's central server(s). For hosted service, it is https://ci.appveyor.com; for on-premise, it is a specific server URL.
        /// </summary>
        public string? AppVeyorUrl => this["APPVEYOR_URL"];

        /// <summary>
        /// The URL of AppVeyor Build Agent API.
        /// </summary>
        public string? AppVeyorApiUrl => this["APPVEYOR_API_URL"];

        /// <summary>
        /// The name of the AppVeyor account.
        /// </summary>
        public string? AppVeyorAccountName => this["APPVEYOR_ACCOUNT_NAME"];

        /// <summary>
        /// The unique project ID in AppVeyor.
        /// </summary>
        public string? AppVeyorProjectId => this["APPVEYOR_PROJECT_ID"];

        /// <summary>
        /// The name of the project in AppVeyor.
        /// </summary>
        public string? AppVeyorProjectName => this["APPVEYOR_PROJECT_NAME"];

        /// <summary>
        /// The project slug (used in the project details URL).
        /// </summary>
        public string? AppVeyorProjectSlug => this["APPVEYOR_PROJECT_SLUG"];

        /// <summary>
        /// The path to the directory where the repository is cloned.
        /// </summary>
        public string? AppVeyorBuildFolder => this["APPVEYOR_BUILD_FOLDER"];

        /// <summary>
        /// The unique build ID in AppVeyor.
        /// </summary>
        public string? AppVeyorBuildId => this["APPVEYOR_BUILD_ID"];

        /// <summary>
        /// The build number.
        /// </summary>
        public string? AppVeyorBuildNumber => this["APPVEYOR_BUILD_NUMBER"];

        /// <summary>
        /// The build version.
        /// </summary>
        public string? AppVeyorBuildVersion => this["APPVEYOR_BUILD_VERSION"];

        /// <summary>
        /// The build worker image the build is running on (e.g., Visual Studio 2015).
        /// </summary>
        public string? AppVeyorBuildWorkerImage => this["APPVEYOR_BUILD_WORKER_IMAGE"];

        /// <summary>
        /// The Pull (Merge) Request number.
        /// </summary>
        public string? AppVeyorPullRequestNumber => this["APPVEYOR_PULL_REQUEST_NUMBER"];

        /// <summary>
        /// The title of the Pull (Merge) Request.
        /// </summary>
        public string? AppVeyorPullRequestTitle => this["APPVEYOR_PULL_REQUEST_TITLE"];

        /// <summary>
        /// The source repository of the Pull (Merge) Request.
        /// </summary>
        public string? AppVeyorPullRequestHeadRepoName => this["APPVEYOR_PULL_REQUEST_HEAD_REPO_NAME"];

        /// <summary>
        /// The source branch of the Pull (Merge) Request.
        /// </summary>
        public string? AppVeyorPullRequestHeadRepoBranch => this["APPVEYOR_PULL_REQUEST_HEAD_REPO_BRANCH"];

        /// <summary>
        /// The commit ID (SHA) of the source commit in the Pull (Merge) Request.
        /// </summary>
        public string? AppVeyorPullRequestHeadCommit => this["APPVEYOR_PULL_REQUEST_HEAD_COMMIT"];

        /// <summary>
        /// The unique job ID in AppVeyor.
        /// </summary>
        public string? AppVeyorJobId => this["APPVEYOR_JOB_ID"];

        /// <summary>
        /// The name of the job.
        /// </summary>
        public string? AppVeyorJobName => this["APPVEYOR_JOB_NAME"];

        /// <summary>
        /// The job number (e.g., 1, 2, etc.).
        /// </summary>
        public string? AppVeyorJobNumber => this["APPVEYOR_JOB_NUMBER"];

        /// <summary>
        /// The repository provider (e.g., gitHub, bitBucket, gitLab, git, subversion, etc.).
        /// </summary>
        public string? AppVeyorRepoProvider => this["APPVEYOR_REPO_PROVIDER"];

        /// <summary>
        /// The source control management system used (git or mercurial).
        /// </summary>
        public string? AppVeyorRepoSCM => this["APPVEYOR_REPO_SCM"];

        /// <summary>
        /// The name of the repository in the format owner-name/repo-name.
        /// </summary>
        public string? AppVeyorRepoName => this["APPVEYOR_REPO_NAME"];

        /// <summary>
        /// The branch on which the build is running. For Pull Requests, this is the base branch the PR is merging into.
        /// </summary>
        public string? AppVeyorRepoBranch => this["APPVEYOR_REPO_BRANCH"];

        /// <summary>
        /// True if the build was triggered by a pushed tag, false otherwise.
        /// </summary>
        public string? AppVeyorRepoTag => this["APPVEYOR_REPO_TAG"];

        /// <summary>
        /// The tag name for builds triggered by a tag (undefined otherwise).
        /// </summary>
        public string? AppVeyorRepoTagName => this["APPVEYOR_REPO_TAG_NAME"];

        /// <summary>
        /// The commit ID (SHA) of the current build.
        /// </summary>
        public string? AppVeyorRepoCommit => this["APPVEYOR_REPO_COMMIT"];

        /// <summary>
        /// The author of the commit.
        /// </summary>
        public string? AppVeyorRepoCommitAuthor => this["APPVEYOR_REPO_COMMIT_AUTHOR"];

        /// <summary>
        /// The email address of the commit author.
        /// </summary>
        public string? AppVeyorRepoCommitAuthorEmail => this["APPVEYOR_REPO_COMMIT_AUTHOR_EMAIL"];

        /// <summary>
        /// The date and time of the commit in ISO 8601 format.
        /// </summary>
        public string? AppVeyorRepoCommitTimestamp => this["APPVEYOR_REPO_COMMIT_TIMESTAMP"];

        /// <summary>
        /// The message of the commit.
        /// </summary>
        public string? AppVeyorRepoCommitMessage => this["APPVEYOR_REPO_COMMIT_MESSAGE"];

        /// <summary>
        /// The rest of the commit message after the line break (if any).
        /// </summary>
        public string? AppVeyorRepoCommitMessageExtended => this["APPVEYOR_REPO_COMMIT_MESSAGE_EXTENDED"];

        /// <summary>
        /// True if the build was triggered by a scheduler.
        /// </summary>
        public string? AppVeyorScheduledBuild => this["APPVEYOR_SCHEDULED_BUILD"];

        /// <summary>
        /// True if the build was started by the "New build" button or via the API.
        /// </summary>
        public string? AppVeyorForcedBuild => this["APPVEYOR_FORCED_BUILD"];

        /// <summary>
        /// True if the build was restarted by the "Re-build commit/PR" button or via the API.
        /// </summary>
        public string? AppVeyorReBuild => this["APPVEYOR_RE_BUILD"];

        /// <summary>
        /// True if the job was restarted by the "Re-run incomplete" button or via the API.
        /// </summary>
        public string? AppVeyorReRunIncomplete => this["APPVEYOR_RE_RUN_INCOMPLETE"];

        /// <summary>
        /// The platform name set on the Build tab of the project settings or specified in the appveyor.yml file.
        /// </summary>
        public string? Platform => this["PLATFORM"];

        /// <summary>
        /// The configuration name set on the Build tab of the project settings or specified in the appveyor.yml file.
        /// </summary>
        public string? Configuration => this["CONFIGURATION"];

        /// <summary>
        /// The timeout (in seconds) for uploading artifacts (default is 600 seconds).
        /// </summary>
        public string? AppVeyorArtifactUploadTimeout => this["APPVEYOR_ARTIFACT_UPLOAD_TIMEOUT"];

        /// <summary>
        /// The timeout (in seconds) for downloading arbitrary files using the DownloadFile command (default is 300 seconds).
        /// </summary>
        public string? AppVeyorFileDownloadTimeout => this["APPVEYOR_FILE_DOWNLOAD_TIMEOUT"];

        /// <summary>
        /// The timeout (in seconds) for shallow cloning the repository (default is 1800 seconds).
        /// </summary>
        public string? AppVeyorRepositoryShallowCloneTimeout => this["APPVEYOR_REPOSITORY_SHALLOW_CLONE_TIMEOUT"];

        /// <summary>
        /// The timeout (in seconds) for downloading or uploading each cache entry (default is 300 seconds).
        /// </summary>
        public string? AppVeyorCacheEntryUploadDownloadTimeout => this["APPVEYOR_CACHE_ENTRY_UPLOAD_DOWNLOAD_TIMEOUT"];

        /// <summary>
        /// Set to true to disable cache restore.
        /// </summary>
        public string? AppVeyorCacheSkipRestore => this["APPVEYOR_CACHE_SKIP_RESTORE"];

        /// <summary>
        /// Set to true to disable cache update.
        /// </summary>
        public string? AppVeyorCacheSkipSave => this["APPVEYOR_CACHE_SKIP_SAVE"];

        /// <summary>
        /// Custom name for the Web Application Package (WAP) artifact (default is the same as the project name).
        /// </summary>
        public string? AppVeyorWapArtifactName => this["APPVEYOR_WAP_ARTIFACT_NAME"];

        /// <summary>
        /// Set to true to create a WAP package that prevents Web Deploy from updating Access Control Lists (ACLs).
        /// </summary>
        public string? AppVeyorWapSkipAcls => this["APPVEYOR_WAP_SKIP_ACLS"];

        /// <summary>
        /// If set to true, skips the Finalize steps (e.g., on_success, on_finish scripts, and build cache save) when exiting the build early.
        /// </summary>
        public string? AppVeyorSkipFinalizeOnExit => this["APPVEYOR_SKIP_FINALIZE_ON_EXIT"];

        /// <summary>
        /// Set to true to save the build cache even if the build fails (by default, the cache is saved only during successful build finalize steps).
        /// </summary>
        public string? AppVeyorSaveCacheOnError => this["APPVEYOR_SAVE_CACHE_ON_ERROR"];

        /// <summary>
        /// Specifies the DeploymentUpgradeMode when deploying an Azure Cloud Service (default is Auto, can be changed to Manual or Simultaneous).
        /// </summary>
        public string? AppVeyorAcsDeploymentUpgradeMode => this["APPVEYOR_ACS_DEPLOYMENT_UPGRADE_MODE"];

        /// <summary>
        /// If set to true, a tagged build ignores commit filtering, branch whitelisting/blacklisting, and skip_tags: true settings, except for [skip ci].
        /// </summary>
        public string? AppVeyorIgnoreCommitFilteringOnTag => this["APPVEYOR_IGNORE_COMMIT_FILTERING_ON_TAG"];
    }
}
