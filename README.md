![](https://github.com/CarysT/OpenHacknet/workflows/CoreRun/badge.svg)
# OpenHacknet

OpenHacknet is a decompile of Hacknet, a game written in C# and XNA/MonoGame.

OpenHacknet is supposed to support modding of Hacknet, not to encourage piracy.

To acquire the game resource files, buy Hacknet on Steam.

## Prerequisites

- Visual Studio 2022 or later (with .NET Framework 4.8 targeting pack)
- NuGet CLI (will be downloaded automatically if not present)
- Hacknet game installed via Steam

## Setup

1. **Create the lib folder and copy Steamworks.NET:**
   ```
   mkdir lib
   copy "<Steam>\steamapps\common\Hacknet\Steamworks.NET.dll" lib\
   ```

2. **Restore NuGet packages:**
   ```powershell
   # Download nuget.exe if not present
   Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile "nuget.exe"
   
   # Add NuGet source and restore packages
   .\nuget.exe sources add -Name nuget.org -Source https://api.nuget.org/v3/index.json
   .\nuget.exe restore Hacknet.sln
   ```

3. **Create output directories and copy Steam DLLs:**
   ```powershell
   mkdir bin\x86\Debug
   mkdir bin\x86\Release
   
   copy "<Steam>\steamapps\common\Hacknet\CSteamworks.dll" bin\x86\Debug\
   copy "<Steam>\steamapps\common\Hacknet\steam_api.dll" bin\x86\Debug\
   copy "<Steam>\steamapps\common\Hacknet\CSteamworks.dll" bin\x86\Release\
   copy "<Steam>\steamapps\common\Hacknet\steam_api.dll" bin\x86\Release\
   ```

4. **Link game Content folder:**
   ```cmd
   mklink /J "bin\x86\Debug\Content" "<Steam>\steamapps\common\Hacknet\Content"
   mklink /J "bin\x86\Release\Content" "<Steam>\steamapps\common\Hacknet\Content"
   ```

5. **Build the project:**
   ```powershell
   msbuild Hacknet.sln -p:Configuration=Debug -p:Platform=x86
   ```

Replace `<Steam>` with your Steam installation path (e.g., `C:\Program Files (x86)\Steam`).

## Contributing

Please do not contribute your own mods to the master branch. If you wish to modify Hacknet's functionality 
(other than fixing typos), create a fork. Contributions should consist of source cleanups or typo fixes only 
and should not change the gameplay or functionality of Hacknet.

## Support

Please support the developer by purchasing Hacknet on Steam.
