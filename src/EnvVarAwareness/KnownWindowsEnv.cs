namespace EnvVarAwareness
{
    /// <summary>
    /// Represents a collection of environment variables used in Windows operating systems.
    /// </summary>
    /// <seealso href="https://ss64.com/nt/syntax-variables.html" />
    public sealed class KnownWindowsEnv : EnvBase
    {
        /// <summary>
        /// A directory path like C:\ProgramData\
        /// </summary>
        public string? AllUsersProfile => this["ALLUSERSPROFILE"];

        /// <summary>
        /// A directory path like C:\Users\{username}\AppData\Roaming
        /// </summary>
        public string? AppData => this["APPDATA"];

        /// <summary>
        /// Terminal servers only - the ComputerName of a remote host.
        /// </summary>
        public string? ClientName => this["ClientName"];

        /// <summary>
        /// The current Command Processor Extensions version number. (Before Windows 2000 (NT): 1, Windows 2000 and later: 2)
        /// </summary>
        public string? CmdExtVersion => this["CMDEXTVERSION"];

        /// <summary>
        /// Same as CSIDL_PROGRAM_FILES_COMMON.
        /// </summary>
        public string? CommonProgramFiles => this["COMMONPROGRAMFILES"];

        /// <summary>
        /// Refers to the C:\Program Files (x86)\Common Files folder on 64-bit systems.
        /// </summary>
        public string? CommonProgramFilesX86 => this["COMMONPROGRAMFILES(X86)"];

        /// <summary>
        /// This computer name
        /// </summary>
        public string? ComputerName => this["COMPUTERNAME"];

        /// <summary>
        /// Refers to the C:\Windows\System32\cmd.exe.
        /// </summary>
        public string? ComSpec => this["COMSPEC"];

        /// <summary>
        /// Refers to C:\
        /// </summary>
        public string? HomeDrive => this["HOMEDRIVE"];

        /// <summary>
        /// Refers to \Users\{username}
        /// </summary>
        public string? HomePath => this["HOMEPATH"];

        /// <summary>
        /// Network home folder.
        /// </summary>
        public string? HomeShare => this["HOMESHARE"];

        /// <summary>
        /// A directory path like C:\Users\{username}\AppData\Local
        /// </summary>
        public string? LocalAppData => this["LOCALAPPDATA"];

        /// <summary>
        /// A UNC path like \\{domain_logon_server}
        /// </summary>
        public string? LogonServer => this["LOGONSERVER"];

        /// <summary>
        /// The Number of processors running on the machine.
        /// </summary>
        public string? NumberOfProcessors => this["NUMBER_OF_PROCESSORS"];

        /// <summary>
        /// OneDrive synchronisation folder. Typically C:\users\%username%\OneDrive. If only a single OneDrive client is installed then use %OneDrive%.
        /// </summary>
        public string? OneDrive => this["OneDrive"];

        /// <summary>
        /// OneDrive for Organizations' synchronisation folder (if installed). Typically C:\users\%username%\OneDrive.
        /// </summary>
        public string? OneDriveCommercial => this["OneDriveCommercial"];

        /// <summary>
        /// OneDrive Personal synchronisation folder. Typically C:\users\%username%\OneDrive
        /// </summary>
        public string? OneDriveConsumer => this["OneDriveConsumer"];

        /// <summary>
        /// Operating system on the user’s workstation.
        /// </summary>
        public string? OS => this["OS"];

        /// <summary>
        /// The execution path.
        /// </summary>
        public string? Path => this["PATH"];

        /// <summary>
        /// Determine the default executable file extensions to search for and use, and in which order, left to right.
        /// </summary>
        public string? PathExtensions => this["PATHEXT"];

        /// <summary>
        /// (AMD64/IA64/x86) This doesn’t tell you the architecture of the processor but only of the current process, so it returns "x86" for a 32 bit WOW process running on 64 bit Windows.
        /// </summary>
        public string? ProcessorArchitecture => this["PROCESSOR_ARCHITECTURE"];

        /// <summary>
        /// Same as %PROCESSOR_ARCHITECTURE% (but only available to 64 bit processes)
        /// </summary>
        public string? ProcessorArchitectureW6432 => this["PROCESSOR_ARCHITEW6432"];

        /// <summary>
        /// Processor ID of the user’s workstation.
        /// </summary>
        public string? ProcessorIdentifier => this["PROCESSOR_IDENTIFIER"];

        /// <summary>
        /// Processor level of the user’s workstation.
        /// </summary>
        public string? ProcessorLevel => this["PROCESSOR_LEVEL"];

        /// <summary>
        /// Processor version of the user’s workstation.
        /// </summary>
        public string? ProcessorRevision => this["PROCESSOR_REVISION"];

        /// <summary>
        /// A directory path like C:\ProgramData
        /// </summary>
        public string? ProgramData => this["ProgramData"];

        /// <summary>
        /// Same as CSIDL_PROGRAM_FILES.
        /// </summary>
        public string? ProgramFiles => this["PROGRAMFILES"];

        /// <summary>
        /// Refers to the C:\Program Files (x86) folder on 64-bit systems.
        /// </summary>
        public string? ProgramFilesX86 => this["PROGRAMFILES(X86)"];

        /// <summary>
        /// Same as %ProgramFiles% (but only available when running under a 64 bit OS)
        /// </summary>
        public string? ProgramW6432 => this["ProgramW6432"];

        /// <summary>
        /// A directory path like %SystemRoot%\system32\WindowsPowerShell\v1.0\Modules\
        /// </summary>
        public string? WindowsPowerShellModulePath => this["PSModulePath"];

        /// <summary>
        /// A directory path like C:\Users\Public
        /// </summary>
        public string? Public => this["Public"];

        /// <summary>
        /// Terminal servers only - for a terminal server session, SessionName is a combination of the connection name, followed by #SessionNumber. For a console session, SessionName returns "Console".
        /// </summary>
        public string? SessionName => this["SessionName"];

        /// <summary>
        /// The drive that holds the Windows folder. This value is a drive name and not a folder name (C: not C:\).
        /// </summary>
        public string? SystemDrive => this["SYSTEMDRIVE"];

        /// <summary>
        /// Same as WINDIR.
        /// </summary>
        public string? SystemRoot => this["SYSTEMROT"];

        /// <summary>
        /// Temporary directory (TEMP)
        /// </summary>
        public string? Temp => this["TEMP"];

        /// <summary>
        /// Temporary directory (TMP)
        /// </summary>
        public string? Tmp => this["TMP"];

        /// <summary>
        /// Set if a user is a logged on to a domain and returns the fully qualified DNS domain that the currently logged on user’s account belongs to.
        /// </summary>
        public string? UserDnsDomain => this["UserDnsDomain"];

        /// <summary>
        /// Current user domain name
        /// </summary>
        public string? UserDomain => this["USERDOMAIN"];

        /// <summary>
        /// The user domain for RDS or standard roaming profile paths. Windows 8, Windows Server 2012 or higher version required.
        /// </summary>
        public string? UserDomainRoamingProfile => this["USERDOMAIN_roamingprofile"];

        /// <summary>
        /// Current Username
        /// </summary>
        public string? UserName => this["USERNAME"];

        /// <summary>
        /// User profile directory path
        /// </summary>
        public string? UserProfile => this["USERPROFILE"];

        /// <summary>
        /// Refers to the Windows folder located on the system drive.
        /// </summary>
        public string? WinDir => this["WINDIR"];

        /// <summary>
        /// System Resource Management library, Windows 11. Enables driver initialization and dependencies for system management. Set to 0 to disable.
        /// </summary>
        public string? ZESEnableSysman => this["ZES_ENABLE_SYSMAN"];
    }
}
