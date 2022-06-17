#!/bin/bash

echo "[INFO] Removing old and unnecessary files"
rm -rf ./src/Muhimbi.PDF.Online.Client/bin
rm -rf ./src/Muhimbi.PDF.Online.Client/obj
rm -rf ./bin
rm -f ../muhimbi-pdf-online-client-dotnetcore.zip

dotnet publish ./Muhimbi.PDF.Online.Client.sln -o ./bin -c Release

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Muhimbi.PDF.Online.Client.dll was created successfully"
fi

echo "[INFO] Removing unnecessary files"
rm -rf ./src/Muhimbi.PDF.Online.Client/bin
rm -rf ./src/Muhimbi.PDF.Online.Client/obj

echo "[INFO] Creating zip archive"
zip -j ../muhimbi-pdf-online-client-dotnetcore.zip ./bin/*