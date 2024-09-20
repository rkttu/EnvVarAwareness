# EnvVarAwareness

[![NuGet Version](https://img.shields.io/nuget/v/EnvVarAwareness)](https://www.nuget.org/packages/EnvVarAwareness/) ![Build Status](https://github.com/rkttu/EnvVarAwareness/actions/workflows/dotnet.yml/badge.svg) [![GitHub Sponsors](https://img.shields.io/github/sponsors/rkttu)](https://github.com/sponsors/rkttu/)

A library that organizes environment variables pre-specified by suppliers in CI/CD, serverless environments, and container environments to find them by type

## Supported Platforms

This library provides bindings for environment variables pre-provided on the following platforms.

- Windows, Bash (Linux, macOS, etc...)
- Amazon Web Services: SDK-related, Lambda, XRay
- Microsoft Azure: Pipelines, WebApps (Kudu, Oryx, Functions)
- Google Cloud: CloudRun Task, Job, K-native related
- CI/CDs: GitHub Actions, GitLab Runners, Jenkins, TravisCI, CircleCI, AppVeyor

I am accepting contributions for more pre-defined environment variable information. Your contributions are welcome.

## Requirements

- Requires a platform with .NET Standard 2.0 or later
  - Supported .NET Version: .NET Core 2.0+, .NET 5+, .NET Framework 4.6.1+, Mono 5.4+, UWP 10.0.16299+, Unity 2018.1+

## How to use

```csharp
using EnvVarAwareness;

// Windows Example
var windowsEnv = new KnownWindowsEnv();
Console.WriteLine(windowsEnv.UserProfile);

// Linux Example
var linuxEnv = new KnownLinuxEnv();
Console.WriteLine(linuxEnv.Home);
```

```csharp
using EnvVarAwareness.Aws;

// AWS Example
var awsEnv = new KnownAwsEnv();
Console.WriteLine(awsEnv.AWSRegion);
```

## License

This library follows Apache-2.0 license. See [LICENSE](./LICENSE) file for more information.
