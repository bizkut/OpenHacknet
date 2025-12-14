![](https://github.com/CarysT/OpenHacknet/workflows/CoreRun/badge.svg)
# OpenHacknet

OpenHacknet is a decompile of Hacknet, a game written in C# and FNA (XNA reimplementation).

OpenHacknet is supposed to support modding of Hacknet, not to encourage piracy.

To acquire the game resource files, buy Hacknet on Steam. Steam client is **not required** to run the game.

## Prerequisites

- Visual Studio 2022 or later (with .NET Framework 4.8 targeting pack)
- Hacknet game files (for Content and runtime DLLs)

## Setup

1. **Create the lib folder and copy FNA.dll:**
   ```powershell
   mkdir lib
   copy "<GamePath>\FNA.dll" lib\
   ```

2. **Create output directories and copy runtime DLLs:**
   ```powershell
   mkdir bin\x86\Debug
   mkdir bin\x86\Release
   
   # Copy runtime DLLs (excluding Steam-related ones)
   copy "<GamePath>\FNA.dll" bin\x86\Debug\
   copy "<GamePath>\SDL2.dll" bin\x86\Debug\
   copy "<GamePath>\SDL2_image.dll" bin\x86\Debug\
   copy "<GamePath>\soft_oal.dll" bin\x86\Debug\
   copy "<GamePath>\MojoShader.dll" bin\x86\Debug\
   copy "<GamePath>\libcef.dll" bin\x86\Debug\
   copy "<GamePath>\libEGL.dll" bin\x86\Debug\
   copy "<GamePath>\libGLESv2.dll" bin\x86\Debug\
   
   # Copy same DLLs for Release
   copy "<GamePath>\*.dll" bin\x86\Release\
   
   # Copy locales folder (required for web rendering)
   xcopy "<GamePath>\locales" bin\x86\Debug\locales\ /E /I
   xcopy "<GamePath>\locales" bin\x86\Release\locales\ /E /I
   ```

3. **Link game Content folder:**
   ```cmd
   mklink /J "bin\x86\Debug\Content" "<GamePath>\Content"
   mklink /J "bin\x86\Release\Content" "<GamePath>\Content"
   ```

4. **Build the project:**
   ```powershell
   msbuild Hacknet.sln -p:Configuration=Debug -p:Platform=x86
   ```

Replace `<GamePath>` with your Hacknet installation path (e.g., `C:\Program Files (x86)\Steam\steamapps\common\Hacknet`).

## Note on Steam

Steam integration has been stubbed out. The game runs completely offline without requiring the Steam client.

## Contributing

Please do not contribute your own mods to the master branch. If you wish to modify Hacknet's functionality 
(other than fixing typos), create a fork. Contributions should consist of source cleanups or typo fixes only 
and should not change the gameplay or functionality of Hacknet.

## Support

Please support the developer by purchasing Hacknet on Steam.

