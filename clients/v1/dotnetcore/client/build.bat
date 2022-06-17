@echo off

@echo ** Removing old and unneeded files
rmdir /S /Q src\Muhimbi.PDF.Online.Client\bin
rmdir /S /Q src\Muhimbi.PDF.Online.Client\obj
rmdir /S /Q bin
del /Q

@echo ** Downloading zip
if not exist ".\zip.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('http://stahlworks.com/dev/zip.exe', '.\zip.exe')"

dotnet publish Muhimbi.PDF.Online.Client.sln -o bin -c Release

@echo ** Removing files again as we don't want them in source control
rmdir /S /Q src\Muhimbi.PDF.Online.Client\bin
rmdir /S /Q src\Muhimbi.PDF.Online.Client\obj

@echo ** Creating zip archive
zip -j ../muhimbi-pdf-online-client-dotnetcore.zip bin/*

@echo ** Done