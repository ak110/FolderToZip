@echo off
path %windir%\Microsoft.NET\Framework64\v4.0.30319;%PATH%
csc /optimize+ /debug- /reference:System.IO.Compression.FileSystem.dll FolderToZip.cs
pause
