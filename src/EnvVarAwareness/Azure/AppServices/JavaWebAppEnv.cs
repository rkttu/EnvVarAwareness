namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Java)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class JavaWebAppEnv : EnvBase
    {
        /// <summary>
        /// Path of the Java installation directory
        /// </summary>
        public string? JavaHome => this["JAVA_HOME"];

        /// <summary>
        /// Environment variable can be used by custom scripts so they have a location for app.jar after it's copied to local.
        /// </summary>
        public string? AzureJavaAppPath => this["AZURE_JAVA_APP_PATH"];

        /// <summary>
        /// value of 1 to disable App Service from loading the certificates into the key store automatically
        /// </summary>
        public string? SkipJavaKeystoreLoad => this["SKIP_JAVA_KEYSTORE_LOAD"];

        /// <summary>
        /// The .jar file to use. Appends .jar if the string doesn't end in .jar. Defaults to app.jar
        /// </summary>
        public string? WebsiteJavaJarFileName => this["WEBSITE_JAVA_JAR_FILE_NAME"];

        /// <summary>
        /// The .war file to use. Appends .war if the string doesn't end in .war. Defaults to app.war
        /// </summary>
        public string? WebsiteJavaWarFileName => this["WEBSITE_JAVA_WAR_FILE_NAME"];

        /// <summary>
        /// java opts required by different java webserver. Defaults to -noverify -Djava.net.preferIPv4Stack=true
        /// </summary>
        public string? JavaArguments => this["JAVA_ARGS"];

        /// <summary>
        /// environment variables used by popular Java web frameworks for server port. Some frameworks included are: Spring, Micronaut, Grails, MicroProfile Thorntail, Helidon, Ratpack, and Quarkus
        /// </summary>
        public string? JavaWebServerPortEnvironmentVariables => this["JAVA_WEBSERVER_PORT_ENVIRONMENT_VARIABLES"];

        /// <summary>
        /// Added to Java args as -Dsite.tempdir. Defaults to TEMP.
        /// </summary>
        public string? JavaTempDirectory => this["JAVA_TMP_DIR"];

        /// <summary>
        /// By default, the deployed app.jar is copied from /home/site/wwwroot to a local location. To disable this behavior and load app.jar directly from /home/site/wwwroot, set this variable 1 or true. This setting has no effect if local cache is enabled.
        /// </summary>
        public string? WebsiteSkipLocalCopy => this["WEBSITE_SKIP_LOCAL_COPY"];

        /// <summary>
        /// Native Windows apps only. By default, the Tomcat server is started with its startup.bat. To initiate using its catalina.bat instead, set to 0 or False.
        /// </summary>
        public string? TomcatUseStartupBat => this["TOMCAT_USE_STARTUP_BAT"];

        /// <summary>
        /// For Tomcat apps, environment variables to pass into the java command. Can contain system variables.
        /// </summary>
        public string? CatalinaOptions => this["CATALINA_OPTS"];

        /// <summary>
        /// To use a custom Tomcat installation, set to the installation's location.
        /// </summary>
        public string? CatalinaBase => this["CATALINA_BASE"];

        /// <summary>
        /// The Java maximum heap in MB. This setting is effective only when an experimental Tomcat version is used.
        /// </summary>
        public string? WebsiteJavaMaxHeapMb => this["WEBSITE_JAVA_MAX_HEAP_MB"];

        /// <summary>
        /// Manually disable WEBSITE_JAVA_MAX_HEAP_MB by setting this variable to true or 1.
        /// </summary>
        public string? WebsiteDisableJavaHeapConfiguration => this["WEBSITE_DISABLE_JAVA_HEAP_CONFIGURATION"];

        /// <summary>
        /// By default, the following Tomcat HttpServletRequest interface are hydrated when you enable the built-in authentication: isSecure, getRemoteAddr, getRemoteHost, getScheme, getServerPort. To disable it, set to 1.
        /// </summary>
        public string? WebsiteAuthSkipPrincipal => this["WEBSITE_AUTH_SKIP_PRINCIPAL"];

        /// <summary>
        /// To disable all servlet filters added by App Service, set to 1.
        /// </summary>
        public string? WebsiteSkipFilters => this["WEBSITE_SKIP_FILTERS"];

        /// <summary>
        /// By default, App Service checks if the Tomcat variable CATALINA_BASE is defined. If not, it looks for the existence of %HOME%\tomcat\conf\server.xml. If the file exists, it sets CATALINA_BASE to %HOME%\tomcat. To disable this behavior and remove CATALINA_BASE, set this variable to 1 or true.
        /// </summary>
        public string? IgnoreCatalinaBase => this["IGNORE_CATALINA_BASE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For Linux apps, port that the Java runtime listens to in the container.
        /// </summary>
        public string? Port => this["PORT"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For JBoss (Linux) apps, WildFly version.
        /// </summary>
        public string? WildFlyVersion => this["WILDFLY_VERSION"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For Linux Tomcat apps, Tomcat version.
        /// </summary>
        public string? TomcatVersion => this["TOMCAT_VERSION"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For JBoss (Linux) apps, path of the WildFly installation.
        /// </summary>
        public string? JBossHome => this["JBOSS_HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, command-line arguments for starting Jetty 9.
        /// </summary>
        public string? AzureJetty9Cmdline => this["AZURE_JETTY9_CMDLINE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, path to the Jetty 9 installation.
        /// </summary>
        public string? AzureJetty9Home => this["AZURE_JETTY9_HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, command-line arguments for starting Jetty 9.3.
        /// </summary>
        public string? AzureJetty93Cmdline => this["AZURE_JETTY93_CMDLINE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, path to the Jetty 9.3 installation.
        /// </summary>
        public string? AzureJetty93Home => this["AZURE_JETTY93_HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, command-line arguments for starting Tomcat 7.
        /// </summary>
        public string? AzureTomcat7Cmdline => this["AZURE_TOMCAT7_CMDLINE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, path to the Tomcat 7 installation.
        /// </summary>
        public string? AzureTomcat7Home => this["AZURE_TOMCAT7_HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, command-line arguments for starting Tomcat 8.
        /// </summary>
        public string? AzureTomcat8Cmdline => this["AZURE_TOMCAT8_CMDLINE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, path to the Tomcat 8 installation.
        /// </summary>
        public string? AzureTomcat8Home => this["AZURE_TOMCAT8_HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, command-line arguments for starting Tomcat 8.5.
        /// </summary>
        public string? AzureTomcat85Cmdline => this["AZURE_TOMCAT85_CMDLINE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, path to the Tomcat 8.5 installation.
        /// </summary>
        public string? AzureTomcat85Home => this["AZURE_TOMCAT85_HOME"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, command-line arguments for starting Tomcat 9.
        /// </summary>
        public string? AzureTomcat90Cmdline => this["AZURE_TOMCAT90_CMDLINE"];

        /// <summary>
        /// (Configured by Azure Web Apps system only) For native Windows apps, path to the Tomcat 9 installation.
        /// </summary>
        public string? AzureTomcat90Home => this["AZURE_TOMCAT90_HOME"];

        /// <summary>
        /// The value added to the Java args as -Dsite.home. The default is the value of HOME.
        /// </summary>
        public string? AzureSiteHome => this["AZURE_SITE_HOME"];

        /// <summary>
        /// Added to Java args as -Dport.http. The following environment variables used by different Java web frameworks are also set to this value: SERVER_PORT, MICRONAUT_SERVER_PORT, THORNTAIL_HTTP_PORT, RATPACK_PORT, QUARKUS_HTTP_PORT, PAYARAMICRO_PORT.
        /// </summary>
        public string? HttpPlatformPort => this["HTTP_PLATFORM_PORT"];

        /// <summary>
        /// Environment variables for Spring Boot. Environment variables set together with HTTP_PLATFORM_PORT.
        /// </summary>
        public string? ServerPort => this["SERVER_PORT"];

        /// <summary>
        /// Environment variables for Micronaut. Environment variables set together with HTTP_PLATFORM_PORT.
        /// </summary>
        public string? MicronautServerPort => this["MICRONAUT_SERVER_PORT"];

        /// <summary>
        /// Environment variables for Thorntail (former WildFly Swarm). Environment variables set together with HTTP_PLATFORM_PORT.
        /// </summary>
        public string? ThorntailHttpPort => this["THORNTAIL_HTTP_PORT"];

        /// <summary>
        /// Environment variables for Ratpack. Environment variables set together with HTTP_PLATFORM_PORT.
        /// </summary>
        public string? RatpackPort => this["RATPACK_PORT"];

        /// <summary>
        /// Environment variables for Quarkus. Environment variables set together with HTTP_PLATFORM_PORT.
        /// </summary>
        public string? QuarkusHttpPort => this["QUARKUS_HTTP_PORT"];

        /// <summary>
        /// Environment variables for Payara Micro. Environment variables set together with HTTP_PLATFORM_PORT.
        /// </summary>
        public string? PayaraMicroPort => this["PAYARAMICRO_PORT"];

        /// <summary>
        /// For Windows Apps, added to Java args as -Dsite.logdir. The default is %HOME%\LogFiles\. Default value in Linux is AZURE_LOGGING_DIR=/home/LogFiles.
        /// </summary>
        public string? AzureLoggingDirectory => this["AZURE_LOGGING_DIR"];
    }
}
