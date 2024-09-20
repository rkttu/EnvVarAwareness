namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Authentication and Authorization)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppAuthNAuthZEnv : EnvBase
    {
        /// <summary>
        /// When set to true, disables assigning the thread principal identity in ASP.NET-based web applications (including v1 Function Apps). This is designed to allow developers to protect access to their site with auth, but still have it use a separate sign-in mechanism within their app logic. The default is false.
        /// </summary>
        public string? WebsiteAuthDisableIdentifyFlow => this["WEBSITE_AUTH_DISABLE_IDENTITY_FLOW"];

        /// <summary>
        /// true or false. The default value is false. This is a setting for the legacy Azure Mobile Apps integration for Azure App Service. Setting this to true resolves an issue where the SID (security ID) generated for authenticated users might change if the user changes their profile information. Changing this value may result in existing Azure Mobile Apps user IDs changing. Most apps don't need to use this setting.
        /// </summary>
        public string? WebsiteAuthHideDeprecatedSid => this["WEBSITE_AUTH_HIDE_DEPRECATED_SID"];

        /// <summary>
        /// A timespan value in the form _hours_:_minutes_:_seconds_. The default value is 00:05:00, or 5 minutes. This setting controls the lifetime of the cryptographic nonce generated for all browser-driven logins. If a sign-in fails to complete in the specified time, the sign-in flow will be retried automatically. This application setting is intended for use with the V1 (classic) configuration experience. If using the V2 authentication configuration schema, you should instead use the login.nonce.nonceExpirationInterval configuration value.
        /// </summary>
        public string? WebsiteAuthNonceDuration => this["WEBSITE_AUTH_NONCE_DURATION"];

        /// <summary>
        /// When set to true and users select on app links that contain URL fragments, the sign-in process will ensure that the URL fragment part of your URL doesn't get lost in the sign-in redirect process. For more information, see Customize sign-in and sign-out in Azure App Service authentication.
        /// </summary>
        public string? WebsiteAuthPreserveUrlFragment => this["WEBSITE_AUTH_PRESERVE_URL_FRAGMENT"];

        /// <summary>
        /// To maintain backward compatibility across upgrades, the authentication module uses the legacy claims mapping of short to long names in the /.auth/me API, so certain mappings are excluded (e.g. "roles"). To get the more modern version of the claims mappings, set this variable to False. In the "roles" example, it would be mapped to the long claim name "http://schemas.microsoft.com/ws/2008/06/identity/claims/role".
        /// </summary>
        public string? WebsiteAuthUseLegacyClaims => this["WEBSITE_AUTH_USE_LEGACY_CLAIMS"];

        /// <summary>
        /// true or false. The default value is false. When set to true, removes the WWW-Authenticate HTTP response header from module-generated HTTP 401 responses. This application setting is intended for use with the V1 (classic) configuration experience. If using the V2 authentication configuration schema, you should instead use the identityProviders.azureActiveDirectory.login.disableWwwAuthenticate configuration value.
        /// </summary>
        public string? WebsiteAuthDisableWWWAuthenticate => this["WEBSITE_AUTH_DISABLE_WWWAUTHENTICATE"];

        /// <summary>
        /// A local file system directory path where tokens are stored when the file-based token store is enabled. The default value is %HOME%\Data\.auth. This application setting is intended for use with the V1 (classic) configuration experience. If using the V2 authentication configuration schema, you should instead use the login.tokenStore.fileSystem.directory configuration value.
        /// </summary>
        public string? WebsiteAuthStateDirectory => this["WEBSITE_AUTH_STATE_DIRECTORY"];

        /// <summary>
        /// A fully qualified blob container URL. Instructs the auth module to store and load all encrypted tokens to the specified blob storage container instead of using the default local file system.
        /// </summary>
        public string? WebsiteAuthTokenContainerSASUrl => this["WEBSITE_AUTH_TOKEN_CONTAINER_SASURL"];

        /// <summary>
        /// Any positive decimal number. The default value is 72 (hours). This setting controls the amount of time after a session token expires that the /.auth/refresh API can be used to refresh it. Refresh attempts after this period will fail and end users will be required to sign-in again. This application setting is intended for use with the V1 (classic) configuration experience. If using the V2 authentication configuration schema, you should instead use the login.tokenStore.tokenRefreshExtensionHours configuration value.
        /// </summary>
        public string? WebsiteAuthTokenRefreshHours => this["WEBSITE_AUTH_TOKEN_REFRESH_HOURS"];

        /// <summary>
        /// Controls the verbosity of authentication traces written to Application Logging. Valid values are Off, Error, Warning, Information, and Verbose. The default value is Verbose.
        /// </summary>
        public string? WebsiteAuthTraceLevel => this["WEBSITE_AUTH_TRACE_LEVEL"];

        /// <summary>
        /// true or false. The default value is true. This value should never be set to false except when temporarily debugging cryptographic nonce validation failures that occur during interactive logins. This application setting is intended for use with the V1 (classic) configuration experience. If using the V2 authentication configuration schema, you should instead use the login.nonce.validateNonce configuration value.
        /// </summary>
        public string? WebsiteAuthValidateNonce => this["WEBSITE_AUTH_VALIDATE_NONCE"];

        /// <summary>
        /// This environment variable is populated automatically by the Azure App Service platform and is used to configure the integrated authentication module. The value of this environment variable corresponds to the V2 (non-classic) authentication configuration for the current app in Azure Resource Manager. It's not intended to be configured explicitly.
        /// </summary>
        public string? WebsiteAuthV2ConfigJson => this["WEBSITE_AUTH_V2_CONFIG_JSON"];

        /// <summary>
        /// Read-only. Injected into a Windows or Linux app to indicate whether App Service authentication is enabled.
        /// </summary>
        public string? WebsiteAuthEnabled => this["WEBSITE_AUTH_ENABLED"];

        /// <summary>
        /// By default, the automatically generated key is used as the encryption key. To override, set to a desired key. This is recommended if you want to share tokens or sessions across multiple apps. If specified, it supersedes the MACHINEKEY_DecryptionKey setting.
        /// </summary>
        public string? WebsiteAuthEncryptionKey => this["WEBSITE_AUTH_ENCRYPTION_KEY"];

        /// <summary>
        /// By default, the automatically generated key is used as the signing key. To override, set to a desired key. This is recommended if you want to share tokens or sessions across multiple apps. If specified, it supersedes the MACHINEKEY_ValidationKey setting.
        /// </summary>
        public string? WebsiteAuthSigningKey => this["WEBSITE_AUTH_SIGNING_KEY"];
    }
}
