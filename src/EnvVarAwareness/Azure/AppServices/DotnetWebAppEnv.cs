namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (.NET)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class DotnetWebAppEnv : EnvBase
    {
        /// <summary>
        /// (Configured by Azure Web Apps system only) For Linux apps, port that the .NET runtime listens to in the container.
        /// </summary>
        public string? Port => this["PORT"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) ID of the current instance.
        /// </summary>
        public string? WebsiteRoleInstanceId => this["WEBSITE_ROLE_INSTANCE_ID"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Directory that points to shared storage (/home).
        /// </summary>
        public string? Home => this["HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) Directory for the crash dumps (/home/logs/dumps).
        /// </summary>
        public string? DumpDirectory => this["DUMP_DIR"];

        /// <summary>
        /// Linux apps only. By default, the app is run from /home/site/wwwroot, a shared directory for all scaled-out instances. Set this variable to true to copy the app to a local directory in your container and run it from there. When using this option, be sure not to hard-code any reference to /home/site/wwwroot. Instead, use a path relative to /home/site/wwwroot.
        /// </summary>
        public string? AppServiceRunFromCopy => this["APP_SVC_RUN_FROM_COPY"];

        /// <summary>
        /// For Windows native apps or Windows containerized apps, this variable is injected into app environment or container to enable ASP.NET cryptographic routines (see machineKey Element. To override the default decryption value, configure it as an App Service app setting, or set it directly in the machineKey element of the Web.config file.
        /// </summary>
        public string? MachineKeyDecryption => this["MACHINEKEY_Decryption"];

        /// <summary>
        /// For Windows native apps or Windows containerized apps, this variable is injected into the app environment or container to enable ASP.NET cryptographic routines (see machineKey Element. To override the automatically generated decryptionKey value, configure it as an App Service app setting, or set it directly in the machineKey element of the Web.config file.
        /// </summary>
        public string? MachineKeyDecryptionKey => this["MACHINEKEY_DecryptionKey"];

        /// <summary>
        /// For Windows native apps or Windows containerized apps, this variable is injected into the app environment or container to enable ASP.NET cryptographic routines (see machineKey Element. To override the default validation value, configure it as an App Service app setting, or set it directly in the machineKey element of the Web.config file.
        /// </summary>
        public string? MachineKeyValidation => this["MACHINEKEY_Validation"];

        /// <summary>
        /// For Windows native apps or Windows containerized apps, this variable is injected into the app environment or container to enable ASP.NET cryptographic routines (see machineKey Element. To override the automatically generated validationKey value, configure it as an App Service app setting, or set it directly in the machineKey element of the Web.config file.
        /// </summary>
        public string? MachineKeyValidationKey => this["MACHINEKEY_ValidationKey"];
    }
}
