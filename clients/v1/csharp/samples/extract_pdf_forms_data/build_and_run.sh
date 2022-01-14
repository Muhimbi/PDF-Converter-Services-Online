#!/bin/bash

echo "[INFO] Removing old files"
rm -rf bin
rm -rf obj

echo "[INFO] Starting Build"
xbuild sample.csproj /p:TargetFrameworkVersion="v4.5"

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?. Please check if the 'TargetFrameworkVersion' specified in this script matches your version."
  exit 1
else
  echo "[INFO] Executable created successfully"
fi

echo "[INFO] Running "
cd bin/Debug
mono sample.exe
cd ../..