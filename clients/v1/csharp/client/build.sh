#!/bin/bash

echo "[INFO] Removing old and unneeded files"
rm -rf src/Muhimbi.PDF.Online.Client/bin
rm -rf src/Muhimbi.PDF.Online.Client/obj
rm -rf bin
rm -f ../muhimbi-pdf-online-client-dotnet.zip

echo "[INFO] Download nuget and packages"
wget -nc https://nuget.org/nuget.exe;
mozroots --import --machine --sync
mono nuget.exe install src/Muhimbi.PDF.Online.Client/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;

cp packages/Newtonsoft.Json.8.0.3/lib/net40/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.1.0/lib/net4/RestSharp.dll bin/RestSharp.dll;

echo "[INFO] Run 'mcs' to build bin/Muhimbi.PDF.Online.Client.dll"
mcs -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/Muhimbi.PDF.Online.Client.dll \
-recurse:'src/Muhimbi.PDF.Online.Client/*.cs' \
-doc:bin/Muhimbi.PDF.Online.Client.xml \
-platform:anycpu \
/nowarn:1591 

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Muhimbi.PDF.Online.Client.dll was created successfully"
fi

echo "[INFO] Removing 'packages' again as we do not want them in source control"
rm -rf packages

echo "[INFO] Creating zip archive"
zip -j ../muhimbi-pdf-online-client-dotnet.zip bin/*