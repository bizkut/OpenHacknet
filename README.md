![](https://github.com/CarysT/OpenHacknet/workflows/CoreRun/badge.svg)
# OpenHacknet

OpenHacknet is a decompile of Hacknet, a game written in C# and FNA (XNA reimplementation).

OpenHacknet is supposed to support modding of Hacknet, not to encourage piracy.

To acquire the game resource files, buy Hacknet on Steam.

## Prerequisites

- Visual Studio 2022 or later (with .NET Framework 4.8 targeting pack)
- Hacknet game installed via Steam

## Setup

1. **Create the lib folder and copy required DLLs:**
   ```powershell
   mkdir lib
   copy "<Steam>\steamapps\common\Hacknet\Steamworks.NET.dll" lib\
   copy "<Steam>\steamapps\common\Hacknet\FNA.dll" lib\
   ```

2. **Create output directories and copy all game DLLs:**
   ```powershell
   mkdir bin\x86\Debug
   mkdir bin\x86\Release
   
   # Copy all DLLs from the original game
   copy "<Steam>\steamapps\common\Hacknet\*.dll" bin\x86\Debug\
   copy "<Steam>\steamapps\common\Hacknet\*.dll" bin\x86\Release\
   
   # Copy locales folder (required for web rendering)
   xcopy "<Steam>\steamapps\common\Hacknet\locales" bin\x86\Debug\locales\ /E /I
   xcopy "<Steam>\steamapps\common\Hacknet\locales" bin\x86\Release\locales\ /E /I
   ```

3. **Link game Content folder:**
   ```cmd
   mklink /J "bin\x86\Debug\Content" "<Steam>\steamapps\common\Hacknet\Content"
   mklink /J "bin\x86\Release\Content" "<Steam>\steamapps\common\Hacknet\Content"
   ```

4. **Build the project:**
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
