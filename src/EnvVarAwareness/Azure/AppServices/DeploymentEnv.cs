using System;

namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Deployment)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class DeploymentEnv : EnvBase
    {
        /// <summary>
        /// For local Git or cloud Git deployment (such as GitHub), set to the branch in Azure you want to deploy to. By default, it's master.
        /// </summary>
        public string? DeploymentBranch => this["DEPLOYMENT_BRANCH"];

        /// <summary>
        /// Set to 1 to run the app from a local ZIP package, or set to the URL of an external URL to run the app from a remote ZIP package. For more information, see Run your app in Azure App Service directly from a ZIP package.
        /// </summary>
        public string? WebsiteRunFromPackage => this["WEBSITE_RUN_FROM_PACKAGE"];

        /// <summary>
        /// Deprecated. Use WEBSITE_RUN_FROM_PACKAGE.
        /// </summary>
        [Obsolete("Deprecated. Use WebsiteRunFromPackage.")]
        public string? WebsiteUseZip => this["WEBSITE_USE_ZIP"];

        /// <summary>
        /// Deprecated. Use WEBSITE_RUN_FROM_PACKAGE.
        /// </summary>
        [Obsolete("Deprecated. Use WebsiteRunFromPackage.")]
        public string? WebsiteRunFromZip => this["WEBSITE_RUN_FROM_ZIP"];

        /// <summary>
        /// Your app keeps 5 of the most recent zip files deployed using zip deploy. You can keep more or less by setting the app setting to a different number.
        /// </summary>
        public string? ScmMaxZipPackageCount => this["SCM_MAX_ZIP_PACKAGE_COUNT"];

        /// <summary>
        /// Set to false for WebDeploy to stop using the Kudu deployment engine. The default is true. To deploy to Linux apps using Visual Studio (WebDeploy/MSDeploy), set it to false.
        /// </summary>
        public string? WebsiteWebDeployUseScm => this["WEBSITE_WEBDEPLOY_USE_SCM"];

        /// <summary>
        /// Set to 1 to attempt to rename DLLs if they can't be copied during a WebDeploy deployment. This setting isn't applicable if WEBSITE_WEBDEPLOY_USE_SCM is set to false.
        /// </summary>
        public string? MsdeployRenameLockedFiles => this["MSDEPLOY_RENAME_LOCKED_FILES"];

        /// <summary>
        /// By default, the main app and the Kudu app run in different sandboxes. When you stop the app, the Kudu app is still running, and you can continue to use Git deploy and MSDeploy. Each app has its own local files. Turning off this separation (setting to true) is a legacy mode that's no longer fully supported.
        /// </summary>
        public string? WebsiteDisableScmSeparation => this["WEBSITE_DISABLE_SCM_SEPARATION"];

        /// <summary>
        /// Set to 1 ensure that REST API calls to update site and siteconfig are completely applied to all instances before returning. The default is 1 if deploying with an ARM template, to avoid race conditions with subsequent ARM calls.
        /// </summary>
        public string? WebsiteEnableSyncUpdateSite => this["WEBSITE_ENABLE_SYNC_UPDATE_SITE"];

        /// <summary>
        /// In an ARM template deployment, set to 1 in the ARM template to pre-start the Kudu app as part of app creation.
        /// </summary>
        public string? WebsiteStartScmOnSiteCreation => this["WEBSITE_START_SCM_ON_SITE_CREATION"];

        /// <summary>
        /// For Linux apps, set to true to force preloading the Kudu app when Always On is enabled by pinging its URL. The default is false. For Windows apps, the Kudu app is always preloaded.
        /// </summary>
        public string? WebsiteStartScmWithPreload => this["WEBSITE_START_SCM_WITH_PRELOAD"];
    }
}
