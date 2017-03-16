@echo off

echo [INFO] Removing old files
rmdir /S /Q bin
rmdir /S /Q obj

SET MSBUILDPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

echo [INFO] Starting Build
%MSBUILDPATH%\msbuild.exe sample.csproj

if errorlevel 1 (
   echo [ERROR] Compilation failed
   exit /b
)
echo [INFO] Executable created successfully

echo [INFO] Running 
cd bin\Debug
convert.exe
cd ..\..

pause