namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Ruby)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class RubyWebAppEnv : EnvBase
    {
        /// <summary>
        /// (Configured by Azure Web Apps system only) Port that the Rails app listens to in the container.
        /// </summary>
        public string? Port => this["PORT"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) ID of the current instance.
        /// </summary>
        public string? WebsiteRoleInstanceId => this["WEBSITE_ROLE_INSTANCE_ID"];

        /// <summary>
        /// By default, a default splash page is displayed when no Gemfile is found. Set this variable to any value to disable the splash page.
        /// </summary>
        public string? RailsIgnoreSplash => this["RAILS_IGNORE_SPLASH"];

        /// <summary>
        /// To add --without options to bundle install, set the variable to the groups you want to exclude, separated by space. By default, all Gems are installed.
        /// </summary>
        public string? BundleWithout => this["BUNDLE_WITHOUT"];

        /// <summary>
        /// Directory to install gems. The default is /tmp/bundle.
        /// </summary>
        public string? BundleInstallLocation => this["BUNDLE_INSTALL_LOCATION"];

        /// <summary>
        /// Site config directory. The default is /home/site/config. The container checks for zipped gems in this directory.
        /// </summary>
        public string? RubySiteConfigDirectory => this["RUBY_SITE_CONFIG_DIR"];

        /// <summary>
        /// By default, A random secret key base is generated. To use a custom secret key base, set this variable to the desired key base.
        /// </summary>
        public string? SecretKeyBase => this["SECRET_KEY_BASE"];

        /// <summary>
        /// Rails environment. The default is production.
        /// </summary>
        public string? RailsEnv => this["RAILS_ENV"];

        /// <summary>
        /// Set this variable to any value to run gem pristine --all.
        /// </summary>
        public string? GemPristine => this["GEM_PRISTINE"];
    }
}
