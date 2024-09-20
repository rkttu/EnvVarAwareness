namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (WordPress/PHP)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WordPressWebAppEnv : EnvBase
    {
        /// <summary>
        /// When set to TRUE, file contents are preserved during restarts.
        /// </summary>
        public string? WebsitesEnableAppServiceStorage => this["WEBSITES_ENABLE_APP_SERVICE_STORAGE"];

        /// <summary>
        /// Frontend or general wordpress PHP memory limit (per script). Can't be more than PHP_MEMORY_LIMIT
        /// </summary>
        public string? WordPressMemoryLimit => this["WP_MEMORY_LIMIT"];

        /// <summary>
        /// Admin dashboard PHP memory limit (per script). Generally Admin dashboard/ backend scripts takes lot of memory compared to frontend scripts. Can't be more than PHP_MEMORY_LIMIT.
        /// </summary>
        public string? WordPressMaxMemoryLimit => this["WP_MAX_MEMORY_LIMIT"];

        /// <summary>
        /// Memory limits for general PHP script. It can only be decreased.
        /// </summary>
        public string? PHPMemoryLimit => this["PHP_MEMORY_LIMIT"];

        /// <summary>
        /// Can be either On or Off. Note that values are case sensitive. Enables or disables file uploads.
        /// </summary>
        public string? FileUploads => this["FILE_UPLOADS"];

        /// <summary>
        /// Allowed maximum file size for upload. 256M Max file upload size limit. Can be increased up to 256M.	
        /// </summary>
        public string? UploadMaxFileSize => this["UPLOAD_MAX_FILESIZE"];

        /// <summary>
        /// Can be increased up to 256M. Generally should be more than UPLOAD_MAX_FILESIZE.
        /// </summary>
        public string? PostMaxSize => this["POST_MAX_SIZE"];

        /// <summary>
        /// Can only be decreased. Please break down the scripts if it is taking more than 120 seconds. Added to avoid bad scripts from slowing the system.
        /// </summary>
        public string? MaxExecutionTime => this["MAX_EXECUTION_TIME"];

        /// <summary>
        /// Max time limit for parsing the input requests. Can only be decreased.
        /// </summary>
        public string? MaxInputTime => this["MAX_INPUT_TIME"];

        /// <summary>
        /// Max input variables for input requests. Can only be positive integer values.
        /// </summary>
        public string? MaxInputVars => this["MAX_INPUT_VARS"];

        /// <summary>
        /// Database host used to connect to WordPress.
        /// </summary>
        public string? DatabaseHost => this["DATABASE_HOST"];

        /// <summary>
        /// Database name used to connect to WordPress.
        /// </summary>
        public string? DatabaseName => this["DATABASE_NAME"];

        /// <summary>
        /// Database username used to connect to WordPress.
        /// </summary>
        public string? DatabaseUsername => this["DATABASE_USERNAME"];

        /// <summary>
        /// Database password used to connect to the MySQL database. To change the MySQL database password, see update admin password. Whenever the MySQL database password is changed, the Application Settings also need to be updated.
        /// </summary>
        public string? DatabasePassword => this["DATABASE_PASSWORD"];

        /// <summary>
        /// WordPress admin email.
        /// </summary>
        public string? WordPressAdminEmail => this["WORDPRESS_ADMIN_EMAIL"];

        /// <summary>
        /// WordPress admin password. This is only for deployment purposes. Modifying this value has no effect on the WordPress installation. To change the WordPress admin password, see resetting your password.
        /// </summary>
        public string? WordPressAdminPassword => this["WORDPRESS_ADMIN_PASSWORD"];

        /// <summary>
        /// WordPress admin username
        /// </summary>
        public string? WordPressAdminUser => this["WORDPRESS_ADMIN_USER"];

        /// <summary>
        /// Database username used to connect to WordPress.
        /// </summary>
        public string? WordPressAdminLocaleCode => this["WORDPRESS_ADMIN_LOCALE_CODE"];
    }
}
