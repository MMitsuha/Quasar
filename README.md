# Quasar Enhanced

[![Github CI Badge](https://github.com/WINKILLERS/Musubi/actions/workflows/msbuild.yml/badge.svg)](https://github.com/MMitsuha/Quasar/actions/workflows/msbuild.yml)
[![Downloads](https://img.shields.io/github/downloads/MMitsuha/Quasar/total.svg)](https://github.com/MMitsuha/Quasar/releases)
[![License](https://img.shields.io/github/license/MMitsuha/Quasar.svg)](LICENSE)

**Free, Open-Source Remote Administration Tool for Windows**

Quasar is a fast and light-weight remote administration tool coded in C#. The usage ranges from user support through day-to-day administrative work to employee monitoring. Providing high stability and an easy-to-use user interface, Quasar is the perfect remote administration solution for you.

*I forked the project from original repo, adding my custom feature and rename it to: "Quasar Enhanced"*

Please check out the [Getting Started](https://github.com/MMitsuha/Quasar/wiki/Getting-Started) guide.

## Screenshots

![remote-shell](Images/remote-shell.png)

![remote-desktop](Images/remote-desktop.png)

![remote-files](Images/remote-files.png)

## Features

* TCP network stream (IPv4 & IPv6 support)
* Fast network serialization (Protocol Buffers)
* Encrypted communication (TLS)
* UPnP Support (automatic port forwarding)
* Task Manager
* File Manager
* Startup Manager
* Remote Desktop
* Remote Shell
* Remote Execution
* System Information
* Registry Editor
* System Power Commands (Restart, Shutdown, Standby)
* Keylogger (Unicode Support)
* Reverse Proxy (SOCKS5)
* Password Recovery (Common Browsers and FTP Clients)
* ... and many more!

## Download

* [Latest stable release](https://github.com/MMitsuha/Quasar/releases) (recommended)

## Supported runtimes and operating systems

* .NET Framework 4.5.2 or higher
* Supported operating systems (32- and 64-bit)
  * Windows 11
  * Windows Server 2022
  * Windows 10
  * Windows Server 2019
  * Windows Server 2016
  * Windows 8/8.1
  * Windows Server 2012
  * Windows 7
  * Windows Server 2008 R2
* For older systems please use [Quasar version 1.3.0](https://github.com/MMitsuha/Quasar/releases/tag/v1.3.0.0)

## Compiling

Open the project `Quasar.sln` in Visual Studio 2019+ with installed .NET desktop development features and [restore the NuGET packages](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore). Once all packages are installed the project can be compiled as usual by clicking `Build` at the top or by pressing `F6`. The resulting executables can be found in the `Bin` directory. See below which build configuration to choose from.

## Building a client

| Build configuration         | Usage scenario | Description
| ----------------------------|----------------|--------------
| Debug configuration         | Testing        | The pre-defined [Settings.cs](/Quasar.Client/Config/Settings.cs) will be used, so edit this file before compiling the client. You can execute the client directly with the specified settings.
| Release configuration       | Production     | Start `Quasar.exe` and use the client builder.

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md)

## Roadmap

See [ROADMAP.md](ROADMAP.md)

## Documentation

See the [wiki](https://github.com/MMitsuha/Quasar/wiki) for usage instructions and other documentation.

## License

Quasar is distributed under the [MIT License](LICENSE).  
Third-party licenses are located [here](Licenses).

## Thank you

I really appreciate all kinds of feedback and contributions. Thanks for using and supporting Quasar!
