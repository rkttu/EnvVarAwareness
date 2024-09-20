using System;
using System.Collections;
using System.Collections.Generic;

namespace EnvVarAwareness
{
    /// <summary>
    /// Abstract base class of typed environment variables.
    /// </summary>
    public class EnvBase
    {
        /// <summary>
        /// Indicates whether the current platform is Windows NT.
        /// </summary>
        public bool IsWin32NTPlatform
            => (Environment.OSVersion.Platform == PlatformID.Win32NT);

        /// <summary>
        /// Gets the appropriate environment variable name comparer for the current platform.
        /// </summary>
        /// <remarks>
        /// On Windows NT platforms, the environment variable name comparison is case-insensitive. Otherwise, it is case-sensitive.
        /// </remarks>
        /// <returns>
        /// The appropriate environment variable name comparer for the current platform.
        /// </returns>
        protected virtual StringComparer GetAppropriateComparer()
            => IsWin32NTPlatform
                ? StringComparer.OrdinalIgnoreCase
                : StringComparer.Ordinal;

        /// <summary>
        /// Gets the appropriate environment variable name comparison flag for the current platform.
        /// </summary>
        /// <remarks>
        /// On Windows NT platforms, the environment variable name comparison is case-insensitive. Otherwise, it is case-sensitive.
        /// </remarks>
        /// <returns>
        /// The appropriate environment variable name comparison flag for the current platform.
        /// </returns>
        protected virtual StringComparison GetAppropriateComparison()
            => IsWin32NTPlatform
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal;

        /// <summary>
        /// Gets the value of the environment variable with the specified name.
        /// </summary>
        /// <param name="variableName">
        /// The name of the environment variable.
        /// </param>
        /// <param name="target">
        /// One of the enumeration values that specifies the location of the environment variable.
        /// </param>
        /// <returns>
        /// The value of the environment variable specified by variableName, or null if the environment variable is not found.
        /// </returns>
        public string? this[string variableName, EnvironmentVariableTarget target = default]
            => GetEnvironmentVariable(variableName, target);

        /// <summary>
        /// Gets the value of the environment variable with the specified name.
        /// </summary>
        /// <param name="variableName">
        /// The name of the environment variable.
        /// </param>
        /// <param name="target">
        /// One of the enumeration values that specifies the location of the environment variable.
        /// </param>
        /// <returns>
        /// The value of the environment variable specified by variableName, or null if the environment variable is not found.
        /// </returns>
        public string? GetEnvironmentVariable(string variableName, EnvironmentVariableTarget target = default)
            => Environment.GetEnvironmentVariable(variableName, target);

        /// <summary>
        /// Gets the multiple environment variable values with the specified name prefix. If no prefix specified, all environment variables currently declared are returned.
        /// </summary>
        /// <param name="variableNamePrefix">
        /// The prefix of the environment variable name.
        /// </param>
        /// <param name="target">
        /// One of the enumeration values that specifies the location of the environment variable.
        /// </param>
        /// <returns>
        /// A dictionary that contains the environment variable names and values.
        /// </returns>
        public IDictionary<string, string> GetEnvironmentVariables(string? variableNamePrefix = default, EnvironmentVariableTarget target = default)
        {
            var results = new Dictionary<string, string>();

            foreach (DictionaryEntry eachVariable in Environment.GetEnvironmentVariables(target))
            {
                var key = eachVariable.Key as string;
                if (key == null)
                    continue;

                var value = eachVariable.Value as string;
                if (value == null)
                    continue;

                if (variableNamePrefix != null)
                {
                    if (!key.StartsWith(variableNamePrefix, GetAppropriateComparison()))
                        continue;
                }

                results.Add(key, value);
            }

            return results;
        }
    }
}
