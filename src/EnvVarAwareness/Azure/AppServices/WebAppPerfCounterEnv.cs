namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Performance Counters)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class WebAppPerfCounterEnv : EnvBase
    {
        /// <summary>
        /// A JSON object containing the ASP.NET perf counters.
        /// </summary>
        public string? WebsiteCountersAspnet => this["WEBSITE_COUNTERS_ASPNET"];

        /// <summary>
        /// A JSON object containing sandbox counters.
        /// </summary>
        public string? WebsiteCountersApp => this["WEBSITE_COUNTERS_APP"];

        /// <summary>
        /// A JSON object containing CLR counters.
        /// </summary>
        public string? WebsiteCountersClr => this["WEBSITE_COUNTERS_CLR"];

        /// <summary>
        /// A JSON object containing the combination of the other three variables.
        /// </summary>
        public string? WebsiteCountersAll => this["WEBSITE_COUNTERS_ALL"];
    }
}
