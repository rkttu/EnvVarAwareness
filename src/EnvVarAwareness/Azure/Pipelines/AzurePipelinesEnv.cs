namespace EnvVarAwareness.Azure.Pipelines
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Pipelines.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/devops/pipelines/build/variables"/>
    public sealed class AzurePipelinesEnv : EnvBase
    {
        /// <summary>
        /// The local path on the agent where all folders for a given build pipeline are created. This variable has the same value as Pipeline.Workspace. For example: /home/vsts/work/1.
        /// </summary>
        public string? AgentBuildDirectory => this["Agent.BuildDirectory"];

        /// <summary>
        /// A mapping from container resource names in YAML to their Docker IDs at runtime.
        /// </summary>
        public string? AgentContainerMapping => this["Agent.ContainerMapping"];

        /// <summary>
        /// The directory the agent is installed into. This contains the agent software. For example: c:\agent.
        /// </summary>
        public string? AgentHomeDirectory => this["Agent.HomeDirectory"];

        /// <summary>
        /// The ID of the agent.
        /// </summary>
        public string? AgentId => this["Agent.Id"];

        /// <summary>
        /// The name of the running job. This will usually be "Job"; or "__default", but in multi-config scenarios, will be the configuration.
        /// </summary>
        public string? AgentJobName => this["Agent.JobName"];

        /// <summary>
        /// The status of the build.
        /// </summary>
        public string? AgentJobStatus => this["Agent.JobStatus"];

        /// <summary>
        /// The name of the machine on which the agent is installed.
        /// </summary>
        public string? AgentMachineName => this["Agent.MachineName"];

        /// <summary>
        /// The name of the agent that is registered with the pool.
        /// </summary>
        public string? AgentName => this["Agent.Name"];

        /// <summary>
        /// The operating system of the agent host. Valid values are:
        /// </summary>
        public string? AgentOS => this["Agent.OS"];

        /// <summary>
        /// The operating system processor architecture of the agent host. Valid values are:
        /// </summary>
        public string? AgentOSArchitecture => this["Agent.OSArchitecture"];

        /// <summary>
        /// A temporary folder that is cleaned after each pipeline job. This directory is used by tasks such as .NET Core CLI task to hold temporary items like test results before they're published.
        /// </summary>
        public string? AgentTempDirectory => this["Agent.TempDirectory"];

        /// <summary>
        /// The directory used by tasks such as Node Tool Installer and Use Python Version to switch between multiple versions of a tool.
        /// </summary>
        public string? AgentToolsDirectory => this["Agent.ToolsDirectory"];

        /// <summary>
        /// The working directory for this agent.
        /// </summary>
        public string? AgentWorkFolder => this["Agent.WorkFolder"];

        /// <summary>
        /// The local path on the agent where any artifacts are copied to before being pushed to their destination. For example: c:\agent_work\1\a.
        /// </summary>
        public string? BuildArtifactStagingDirectory => this["Build.ArtifactStagingDirectory"];

        /// <summary>
        /// The ID of the record for the completed build.
        /// </summary>
        public string? BuildBuildId => this["Build.BuildId"];

        /// <summary>
        /// The name of the completed build, also known as the run number. You can specify what is included in this value.
        /// </summary>
        public string? BuildBuildNumber => this["Build.BuildNumber"];

        /// <summary>
        /// The URI for the build. For example: vstfs:///Build/Build/1430.
        /// </summary>
        public string? BuildBuildUri => this["Build.BuildUri"];

        /// <summary>
        /// The local path on the agent you can use as an output folder for compiled binaries.
        /// </summary>
        public string? BuildBinariesDirectory => this["Build.BinariesDirectory"];

        /// <summary>
        /// The ID of the container for your artifact. When you upload an artifact in your pipeline, it's added to a container that is specific for that particular artifact.
        /// </summary>
        public string? BuildContainerId => this["Build.ContainerId"];

        /// <summary>
        /// The displayName of the cron schedule that triggered the pipeline run. This variable is only set if the pipeline run is triggered by a YAML scheduled trigger. For more information, see schedules.cron definition - Build.CronSchedule.DisplayName variable
        /// </summary>
        public string? BuildCronScheduleDisplayName => this["Build.CronSchedule.DisplayName"];

        /// <summary>
        /// The name of the build pipeline.
        /// </summary>
        public string? BuildDefinitionName => this["Build.DefinitionName"];

        /// <summary>
        /// The version of the build pipeline.
        /// </summary>
        public string? BuildDefinitionVersion => this["Build.DefinitionVersion"];

        /// <summary>
        /// See "How are the identity variables set?".
        /// </summary>
        public string? BuildQueuedBy => this["Build.QueuedBy"];

        /// <summary>
        /// See "How are the identity variables set?".
        /// </summary>
        public string? BuildQueuedById => this["Build.QueuedById"];

        /// <summary>
        /// The event that caused the build to run.
        /// </summary>
        public string? BuildReason => this["Build.Reason"];

        /// <summary>
        /// The value you've selected for Clean in the source repository settings.
        /// </summary>
        public string? BuildRepositoryClean => this["Build.Repository.Clean"];

        /// <summary>
        /// The local path on the agent where your source code files are downloaded. For example: c:\agent_work\1\s.
        /// </summary>
        public string? BuildRepositoryLocalPath => this["Build.Repository.LocalPath"];

        /// <summary>
        /// The unique identifier of the repository.
        /// </summary>
        public string? BuildRepositoryID => this["Build.Repository.ID"];

        /// <summary>
        /// The name of the triggering repository.
        /// </summary>
        public string? BuildRepositoryName => this["Build.Repository.Name"];

        /// <summary>
        /// The type of the triggering repository.
        /// </summary>
        public string? BuildRepositoryProvider => this["Build.Repository.Provider"];

        /// <summary>
        /// Defined if your repository is Team Foundation Version Control. The name of the TFVC workspace used by the build agent.
        /// </summary>
        public string? BuildRepositoryTfvcWorkspace => this["Build.Repository.Tfvc.Workspace"];

        /// <summary>
        /// The URL for the triggering repository. For example:
        /// </summary>
        public string? BuildRepositoryUri => this["Build.Repository.Uri"];

        /// <summary>
        /// See "How are the identity variables set?".
        /// </summary>
        public string? BuildRequestedFor => this["Build.RequestedFor"];

        /// <summary>
        /// See "How are the identity variables set?".
        /// </summary>
        public string? BuildRequestedForEmail => this["Build.RequestedForEmail"];

        /// <summary>
        /// See "How are the identity variables set?".
        /// </summary>
        public string? BuildRequestedForId => this["Build.RequestedForId"];

        /// <summary>
        /// The branch of the triggering repo the build was queued for. Some examples:
        /// </summary>
        public string? BuildSourceBranch => this["Build.SourceBranch"];

        /// <summary>
        /// The name of the branch in the triggering repo the build was queued for.
        /// </summary>
        public string? BuildSourceBranchName => this["Build.SourceBranchName"];

        /// <summary>
        /// The local path on the agent where your source code files are downloaded. For example: c:\agent_work\1\s.
        /// </summary>
        public string? BuildSourcesDirectory => this["Build.SourcesDirectory"];

        /// <summary>
        /// The latest version control change of the triggering repo that is included in this build.
        /// </summary>
        public string? BuildSourceVersion => this["Build.SourceVersion"];

        /// <summary>
        /// The comment of the commit or changeset for the triggering repo. We truncate the message to the first line or 200 characters, whichever is shorter.
        /// </summary>
        public string? BuildSourceVersionMessage => this["Build.SourceVersionMessage"];

        /// <summary>
        /// The local path on the agent where any artifacts are copied to before being pushed to their destination. For example: c:\agent_work\1\a.
        /// </summary>
        public string? BuildStagingDirectory => this["Build.StagingDirectory"];

        /// <summary>
        /// The value you've selected for Checkout submodules on the repository tab. With multiple repos checked out, this value tracks the triggering repository's setting.
        /// </summary>
        public string? BuildRepositoryGitSubmoduleCheckout => this["Build.Repository.Git.SubmoduleCheckout"];

        /// <summary>
        /// Defined if your repository is Team Foundation Version Control.
        /// </summary>
        public string? BuildSourceTfvcShelveset => this["Build.SourceTfvcShelveset"];

        /// <summary>
        /// If the build was triggered by another build, then this variable is set to the BuildID of the triggering build. In Classic pipelines, this variable is triggered by a build completion trigger.
        /// </summary>
        public string? BuildTriggeredByBuildId => this["Build.TriggeredBy.BuildId"];

        /// <summary>
        /// If the build was triggered by another build, then this variable is set to the DefinitionID of the triggering build. In Classic pipelines, this variable is triggered by a build completion trigger.
        /// </summary>
        public string? BuildTriggeredByDefinitionId => this["Build.TriggeredBy.DefinitionId"];

        /// <summary>
        /// If the build was triggered by another build, then this variable is set to the name of the triggering build pipeline. In Classic pipelines, this variable is triggered by a build completion trigger.
        /// </summary>
        public string? BuildTriggeredByDefinitionName => this["Build.TriggeredBy.DefinitionName"];

        /// <summary>
        /// If the build was triggered by another build, then this variable is set to the number of the triggering build. In Classic pipelines, this variable is triggered by a build completion trigger.
        /// </summary>
        public string? BuildTriggeredByBuildNumber => this["Build.TriggeredBy.BuildNumber"];

        /// <summary>
        /// If the build was triggered by another build, then this variable is set to ID of the project that contains the triggering build. In Classic pipelines, this variable is triggered by a build completion trigger.
        /// </summary>
        public string? BuildTriggeredByProjectID => this["Build.TriggeredBy.ProjectID"];

        /// <summary>
        /// The local path on the agent where the test results are created. For example: c:\agent_work\1\TestResults.
        /// </summary>
        public string? CommonTestResultsDirectory => this["Common.TestResultsDirectory"];

        /// <summary>
        /// Workspace directory for a particular pipeline. This variable has the same value as Agent.BuildDirectory. For example, /home/vsts/work/1.
        /// </summary>
        public string? PipelineWorkspace => this["Pipeline.Workspace"];

        /// <summary>
        /// Name of the environment targeted in the deployment job to run the deployment steps and record the deployment history. For example, smarthotel-dev.
        /// </summary>
        public string? EnvironmentName => this["Environment.Name"];

        /// <summary>
        /// ID of the environment targeted in the deployment job. For example, 10.
        /// </summary>
        public string? EnvironmentId => this["Environment.Id"];

        /// <summary>
        /// Name of the specific resource within the environment targeted in the deployment job to run the deployment steps and record the deployment history. For example, bookings which is a Kubernetes namespace that has been added as a resource to the environment smarthotel-dev.
        /// </summary>
        public string? EnvironmentResourceName => this["Environment.ResourceName"];

        /// <summary>
        /// ID of the specific resource within the environment targeted in the deployment job to run the deployment steps. For example, 4.
        /// </summary>
        public string? EnvironmentResourceId => this["Environment.ResourceId"];

        /// <summary>
        /// The name of the deployment strategy: canary, runOnce, or rolling.
        /// </summary>
        public string? StrategyName => this["Strategy.Name"];

        /// <summary>
        /// The current cycle name in a deployment. Options are PreIteration, Iteration, or PostIteration.
        /// </summary>
        public string? StrategyCycleName => this["Strategy.CycleName"];

        /// <summary>
        /// Use the OAuth token to access the REST API.
        /// </summary>
        public string? SystemAccessToken => this["System.AccessToken"];

        /// <summary>
        /// The GUID of the TFS collection or Azure DevOps organization.
        /// </summary>
        public string? SystemCollectionId => this["System.CollectionId"];

        /// <summary>
        /// The URI of the TFS collection or Azure DevOps organization. For example: https://dev.azure.com/fabrikamfiber/.
        /// </summary>
        public string? SystemCollectionUri => this["System.CollectionUri"];

        /// <summary>
        /// The local path on the agent where your source code files are downloaded. For example: c:\agent_work\1\s
        /// </summary>
        public string? SystemDefaultWorkingDirectory => this["System.DefaultWorkingDirectory"];

        /// <summary>
        /// The ID of the build pipeline.
        /// </summary>
        public string? SystemDefinitionId => this["System.DefinitionId"];

        /// <summary>
        /// Set to build if the pipeline is a build. For a release, the values are deployment for a Deployment group job, gates during evaluation of gates, and release for other (Agent and Agentless) jobs.
        /// </summary>
        public string? SystemHostType => this["System.HostType"];

        /// <summary>
        /// Set to 1 the first time this job is attempted, and increments every time the job is retried.
        /// </summary>
        public string? SystemJobAttempt => this["System.JobAttempt"];

        /// <summary>
        /// The human-readable name given to a job.
        /// </summary>
        public string? SystemJobDisplayName => this["System.JobDisplayName"];

        /// <summary>
        /// A unique identifier for a single attempt of a single job. The value is unique to the current pipeline.
        /// </summary>
        public string? SystemJobId => this["System.JobId"];

        /// <summary>
        /// The name of the job, typically used for expressing dependencies and accessing output variables.
        /// </summary>
        public string? SystemJobName => this["System.JobName"];

        /// <summary>
        /// Generate an idToken for authentication with Entra ID using OpenID Connect (OIDC). Learn more.
        /// </summary>
        public string? SystemOidcRequestUri => this["System.OidcRequestUri"];

        /// <summary>
        /// Set to 1 the first time this phase is attempted, and increments every time the job is retried.
        /// </summary>
        public string? SystemPhaseAttempt => this["System.PhaseAttempt"];

        /// <summary>
        /// The human-readable name given to a phase.
        /// </summary>
        public string? SystemPhaseDisplayName => this["System.PhaseDisplayName"];

        /// <summary>
        /// A string-based identifier for a job, typically used for expressing dependencies and accessing output variables.
        /// </summary>
        public string? SystemPhaseName => this["System.PhaseName"];

        /// <summary>
        /// A string-based identifier for a single pipeline run.
        /// </summary>
        public string? SystemPlanId => this["System.PlanId"];

        /// <summary>
        /// If the pull request is from a fork of the repository, this variable is set to True.
        /// </summary>
        public string? SystemPullRequestIsFork => this["System.PullRequest.IsFork"];

        /// <summary>
        /// The ID of the pull request that caused this build. For example: 17. (This variable is initialized only if the build ran because of a Git PR affected by a branch policy).
        /// </summary>
        public string? SystemPullRequestPullRequestId => this["System.PullRequest.PullRequestId"];

        /// <summary>
        /// The number of the pull request that caused this build. This variable is populated for pull requests from GitHub that have a different pull request ID and pull request number. This variable is only available in a YAML pipeline if the PR is affected by a branch policy.
        /// </summary>
        public string? SystemPullRequestPullRequestNumber => this["System.PullRequest.PullRequestNumber"];

        /// <summary>
        /// The name of the target branch for a pull request. This variable can be used in a pipeline to conditionally execute tasks or steps based on the target branch of the pull request. For example, you might want to trigger a different set of tests or code analysis tools depending on the branch that the changes are being merged into.
        /// </summary>
        public string? SystemPullRequesttargetBranchName => this["System.PullRequest.targetBranchName"];

        /// <summary>
        /// The branch that is being reviewed in a pull request. For example: refs/heads/users/raisa/new-feature for Azure Repos. (This variable is initialized only if the build ran because of a Git PR affected by a branch policy). This variable is only available in a YAML pipeline if the PR is affected by a branch policy.
        /// </summary>
        public string? SystemPullRequestSourceBranch => this["System.PullRequest.SourceBranch"];

        /// <summary>
        /// The commit that is being reviewed in a pull request. (This variable is initialized only if the build ran because of a Git PR affected by a branch policy). This variable is only available in a YAML pipeline if the PR is affected by a branch policy.
        /// </summary>
        public string? SystemPullRequestSourceCommitId => this["System.PullRequest.SourceCommitId"];

        /// <summary>
        /// The URL to the repo that contains the pull request. For example: https://dev.azure.com/ouraccount/_git/OurProject.
        /// </summary>
        public string? SystemPullRequestSourceRepositoryURI => this["System.PullRequest.SourceRepositoryURI"];

        /// <summary>
        /// The branch that is the target of a pull request. For example: refs/heads/main when your repository is in Azure Repos and main when your repository is in GitHub. This variable is initialized only if the build ran because of a Git PR affected by a branch policy. This variable is only available in a YAML pipeline if the PR is affected by a branch policy.
        /// </summary>
        public string? SystemPullRequestTargetBranch => this["System.PullRequest.TargetBranch"];

        /// <summary>
        /// Set to 1 the first time this stage is attempted, and increments every time the job is retried.
        /// </summary>
        public string? SystemStageAttempt => this["System.StageAttempt"];

        /// <summary>
        /// The human-readable name given to a stage.
        /// </summary>
        public string? SystemStageDisplayName => this["System.StageDisplayName"];

        /// <summary>
        /// A string-based identifier for a stage, typically used for expressing dependencies and accessing output variables.
        /// </summary>
        public string? SystemStageName => this["System.StageName"];

        /// <summary>
        /// The URI of the TFS collection or Azure DevOps organization. For example: https://dev.azure.com/fabrikamfiber/.
        /// </summary>
        public string? SystemTeamFoundationCollectionUri => this["System.TeamFoundationCollectionUri"];

        /// <summary>
        /// The name of the project that contains this build.
        /// </summary>
        public string? SystemTeamProject => this["System.TeamProject"];

        /// <summary>
        /// The ID of the project that this build belongs to.
        /// </summary>
        public string? SystemTeamProjectId => this["System.TeamProjectId"];

        /// <summary>
        /// A string-based identifier for the execution details and logs of a single pipeline run.
        /// </summary>
        public string? SystemTimelineId => this["System.TimelineId"];

        /// <summary>
        /// Set to True if the script is being run by a build task.
        /// </summary>
        public string? TeamFoundationBuildTask => this["TF_BUILD"];

        /// <summary>
        /// Set to 1 the first time this stage is attempted, and increments every time the stage is retried.
        /// </summary>
        public string? ChecksStageAttempt => this["Checks.StageAttempt"];
    }
}
