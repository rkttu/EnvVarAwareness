namespace EnvVarAwareness.Azure.AppServices.Oryx
{
    /// <summary>
    /// Represents a collection of environment variables used in Azure Web Apps. (Oryx/Python Build Automation)
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings"/>
    /// <seealso href="https://github.com/microsoft/Oryx/blob/main/doc/configuration.md"/>
    /// <seealso href="https://learn.microsoft.com/en-us/azure/azure-functions/functions-app-settings"/>
    public sealed class OryxPythonEnv : EnvBase
    {
        /// <summary>
        /// Specify which Python version the app is using
        /// </summary>
        public string? PythonVersion => this["PYTHON_VERSION"];

        /// <summary>
        /// Specify which Python version the app defaults to if none detected
        /// </summary>
        public string? PythonDefaultVersion => this["PYTHON_DEFAULT_VERSION"];

        /// <summary>
        /// Indicates that the Python build disabled even if repo indicates it
        /// </summary>
        public string? DisablePythonBuild => this["DISABLE_PYTHON_BUILD"];

        /// <summary>
        /// Specify Python virtual environment name
        /// </summary>
        public string? VirtualEnvName => this["VIRTUALENV_NAME"];

        /// <summary>
        /// Disable running collectstatic when building Django apps.
        /// </summary>
        public string? DisableCollectStatic => this["DISABLE_COLLECTSTATIC"];

        /// <summary>
        /// Specify where a requirements.txt is locating. If not set, default is at root of the repo.
        /// </summary>
        public string? CustomRequirementsTxtPath => this["CUSTOM_REQUIREMENTSTXT_PATH"];

        /// <summary>
        /// Enable Gunicorn multi worker multi thread config.
        /// </summary>
        public string? PythonEnableGunicornMultiworkers => this["PYTHON_ENABLE_GUNICORN_MULTIWORKERS"];

        /// <summary>
        /// Only works when PYTHON\_ENABLE\_GUNICORN\_MULTIWORKERS is set to true. Specify Gunicorn multi worker number. If not set, default is (2 * CPU core num) + 1
        /// </summary>
        public string? PythonGunicornCustomWorkerNum => this["PYTHON_GUNICORN_CUSTOM_WORKER_NUM"];

        /// <summary>
        /// Only works when PYTHON\_ENABLE\_GUNICORN\_MULTIWORKERS is set to true. Specify Gunicorn multi thread number. If not set, default is single thread.
        /// </summary>
        public string? PythonGunicornCustomThreadNum => this["PYTHON_GUNICORN_CUSTOM_THREAD_NUM"];

        /// <summary>
        /// Remove the --upgrade flag from the pip install command when targeting a specific package installation directory.
        /// </summary>
        public string? OryxDisablePipUpgrade => this["ORYX_DISABLE_PIP_UPGRADE"];

        /// <summary>
        /// Specify a customized configuration file to modify nginx.conf file
        /// </summary>
        public string? NginxConfFile => this["NGINX_CONF_FILE"];
    }
}
