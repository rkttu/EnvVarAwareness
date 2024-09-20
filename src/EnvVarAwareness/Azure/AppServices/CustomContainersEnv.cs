namespace EnvVarAwareness.Azure.AppServices
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Custom Container)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class CustomContainersEnv : EnvBase
    {
        /// <summary>
        /// For Linux custom containers: set to true to enable the /home directory to be shared across scaled instances. The default is false for Linux custom containers.
        /// </summary>
        public string? WebsitesEnableAppServiceStorage => this["WEBSITES_ENABLE_APP_SERVICE_STORAGE"];

        /// <summary>
        /// Amount of time in seconds to wait for the container to complete start-up before restarting the container. Default is 230. You can increase it up to the maximum of 1800.
        /// </summary>
        public string? WebsitesContainerSTartTimeLimit => this["WEBSITES_CONTAINER_START_TIME_LIMIT"];

        /// <summary>
        /// Amount of time in seconds to wait for the container to terminate gracefully. Default is 5. You can increase to a maximum of 120
        /// </summary>
        public string? WebsitesContainerStopTimeLimit => this["WEBSITES_CONTAINER_STOP_TIME_LIMIT"];

        /// <summary>
        /// URL of the registry server, when running a custom container in App Service. For security, this variable isn't passed on to the container.
        /// </summary>
        public string? DockerRegistryServerUrl => this["DOCKER_REGISTRY_SERVER_URL"];

        /// <summary>
        /// Username to authenticate with the registry server at DOCKER_REGISTRY_SERVER_URL. For security, this variable isn't passed on to the container.
        /// </summary>
        public string? DockerRegistryServerUsername => this["DOCKER_REGISTRY_SERVER_USERNAME"];

        /// <summary>
        /// Password to authenticate with the registry server at DOCKER_REGISTRY_SERVER_URL. For security, this variable isn't passed on to the container.
        /// </summary>
        public string? DockerRegistryServerPassword => this["DOCKER_REGISTRY_SERVER_PASSWORD"];

        /// <summary>
        /// Set to true to enable the continuous deployment for custom containers. The default is false for custom containers.
        /// </summary>
        public string? DockerEnableCI => this["DOCKER_ENABLE_CI"];

        /// <summary>
        /// Connect and pull from a registry inside a Virtual Network or on-premises. Your app will need to be connected to a Virtual Network using VNet integration feature. This setting is also needed for Azure Container Registry with Private Endpoint.
        /// </summary>
        public string? WebsitePullImageOverVirtualNetwork => this["WEBSITE_PULL_IMAGE_OVER_VNET"];

        /// <summary>
        /// In a Docker Compose app, only one of the containers can be internet accessible. Set to the name of the container defined in the configuration file to override the default container selection. By default, the internet accessible container is the first container to define port 80 or 8080, or, when no such container is found, the first container defined in the configuration file.
        /// </summary>
        public string? WebsitesWebContainerName => this["WEBSITES_WEB_CONTAINER_NAME"];

        /// <summary>
        /// For a custom container, the custom port number on the container for App Service to route requests to. By default, App Service attempts automatic port detection of ports 80 and 8080. This setting isn't injected into the container as an environment variable.
        /// </summary>
        public string? WebsitesPort => this["WEBSITES_PORT"];

        /// <summary>
        /// By default, a Windows container runs with all available cores for your chosen pricing tier. To reduce the number of cores, set to the number of desired cores limit. For more information, see Customize the number of compute cores.
        /// </summary>
        public string? WebsiteCPUCoresLImit => this["WEBSITE_CPU_CORES_LIMIT"];

        /// <summary>
        /// By default all Windows Containers deployed in Azure App Service have a memory limit configured depending on the App Service Plan SKU. Set to the desired memory limit in MB. The cumulative total of this setting across apps in the same plan must not exceed the amount allowed by the chosen pricing tier. For more information, see Customize container memory.
        /// </summary>
        public string? WebsiteMemoryLimitMB => this["WEBSITE_MEMORY_LIMIT_MB"];
    }
}
