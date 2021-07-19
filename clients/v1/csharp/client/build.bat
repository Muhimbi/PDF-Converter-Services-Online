@echo off

@echo ** Removing old and unneeded files
rmdir /S /Q src\Muhimbi.PDF.Online.Client\bin
rmdir /S /Q src\Muhimbi.PDF.Online.Client\obj
rmdir /S /Q bin

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

@echo ** Downloading nuget
if not exist ".\nuget.exe" powershell -Command "[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12;(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"

@echo ** Downloading zip
if not exist ".\zip.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('http://stahlworks.com/dev/zip.exe', '.\zip.exe')"

@echo ** Downloading packages using nuget
.\nuget.exe install src\Muhimbi.PDF.Online.Client\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.8.0.3\lib\net40\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.1.0\lib\net4\RestSharp.dll bin\RestSharp.dll

@echo ** Compiling
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\Muhimbi.PDF.Online.Client.dll /recurse:src\*.cs /doc:bin\Muhimbi.PDF.Online.Client.xml /nowarn:1591 /nologo

@echo ** Removing packages again as we don't want them in source control
rmdir /S /Q packages

@echo ** Creating zip archive
zip -j ../muhimbi-pdf-online-client-dotnet.zip bin/*

@echo ** Done