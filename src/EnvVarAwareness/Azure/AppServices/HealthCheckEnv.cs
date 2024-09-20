namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Health check)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class HealthCheckEnv : EnvBase
    {
        /// <summary>
        /// The maximum number of failed pings before removing the instance. Set to a value between 2 and 100. When you're scaling up or out, App Service pings the Health check path to ensure new instances are ready. For more information, see Health check.
        /// </summary>
        public string? WebsiteHealthcheckMaxPingFailures => this["WEBSITE_HEALTHCHECK_MAXPINGFAILURES"];

        /// <summary>
        /// To avoid overwhelming healthy instances, no more than half of the instances will be excluded. For example, if an App Service Plan is scaled to four instances and three are unhealthy, at most two will be excluded. The other two instances (one healthy and one unhealthy) will continue to receive requests. In the worst-case scenario where all instances are unhealthy, none will be excluded. To override this behavior, set to a value between 1 and 100. A higher value means more unhealthy instances will be removed. The default is 50 (50%).
        /// </summary>
        public string? WebsiteHealthcheckMaxUnhealthyWorkerPercent => this["WEBSITE_HEALTHCHECK_MAXUNHEALTHYWORKERPERCENT"];
    }
}
