namespace EnvVarAwareness
{
    /// <summary>
    /// Represents a collection of environment variables used in Linux operating systems.
    /// </summary>
    public sealed class KnownLinuxEnv : EnvBase
    {
        /// <summary>
        /// Holds the version of this instance of bash.
        /// </summary>
        public string? BashVersion => this["BASH_VERSION"];

        /// <summary>
        /// Set X display name
        /// </summary>
        public string? Display => this["DISPLAY"];

        /// <summary>
        /// Set name of default text editor.
        /// </summary>
        public string? Editor => this["EDITOR"];

        /// <summary>
        /// The name of the your computer.
        /// </summary>
        public string? HostName => this["HOSTNAME"];

        /// <summary>
        /// The name of the file in which command history is saved.
        /// </summary>
        public string? HistoryFile => this["HISTFILE"];

        /// <summary>
        /// The maximum number of lines contained in the history file.
        /// </summary>
        public string? HistoryFileSize => this["HISTFILESIZE"];

        /// <summary>
        /// The number of commands to remember in the command history. The default value is 500.
        /// </summary>
        public string? HistorySize => this["HISTSIZE"];

        /// <summary>
        /// The home directory of the current user.
        /// </summary>
        public string? Home => this["HOME"];

        /// <summary>
        /// A string describing the machine Bash is running on.
        /// </summary>
        public string? HostType => this["HOSTTYPE"];

        /// <summary>
        /// The Internal Field Separator that is used for word splitting after expansion and to split lines into words with the read builtin command. The default value is [space][tab][newline].
        /// </summary>
        public string? IFS => this["IFS"];

        /// <summary>
        /// The locale of the runtime (en_US.UTF-8).
        /// </summary>
        public string? Lang => this["LANG"];

        /// <summary>
        /// The system library path (/var/lang/lib:/lib64:/usr/lib64:$LAMBDA_RUNTIME_DIR:$LAMBDA_RUNTIME_DIR/lib:$LAMBDA_TASK_ROOT:$LAMBDA_TASK_ROOT/lib:/opt/lib).
        /// </summary>
        public string? LdLibraryPath => this["LD_LIBRARY_PATH"];

        /// <summary>
        /// The execution path.
        /// </summary>
        public string? Path => this["PATH"];

        /// <summary>
        /// Your prompt settings.
        /// </summary>
        public string? PS1 => this["PS1"];

        /// <summary>
        /// Current directory path.
        /// </summary>
        public string? Pwd => this["PWD"];

        /// <summary>
        /// Set path to login shell.
        /// </summary>
        public string? Shell => this["SHELL"];

        /// <summary>
        /// The default timeout for the read builtin command. Also in an interactive shell, the value is interpreted as the number of seconds to wait for input after issuing the command. If not input provided it will logou user.
        /// </summary>
        public string? Timeout => this["TMOUT"];

        /// <summary>
        /// Your login terminal type.
        /// </summary>
        public string? Terminal => this["TERM"];

        /// <summary>
        /// The environment's time zone (:UTC).
        /// </summary>
        public string? Tz => this["TZ"];

        /// <summary>
        /// Gives user ID of current user.
        /// </summary>
        public string? Uid => this["UID"];

        /// <summary>
        /// Configures Debian-based systems to avoid interactive prompts during package installation.
        /// </summary>
        public string? DebianFrontend => this["DEBIAN_FRONTEND"];

        /// <summary>
        /// The user that is executing the build script, typically set to "travis".
        /// </summary>
        public string? User => this["USER"];

        /// <summary>
        /// Ensures that all locale settings are consistent and set to US English (UTF-8).
        /// </summary>
        public string? LCAll => this["LC_ALL"];
    }
}
