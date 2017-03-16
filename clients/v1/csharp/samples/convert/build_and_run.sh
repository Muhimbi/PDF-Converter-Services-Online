#!/bin/bash

echo "[INFO] Removing old files"
rm -rf bin
rm -rf obj

echo "[INFO] Starting Build"
xbuild sample.csproj

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] Executable created successfully"
fi

echo "[INFO] Running "
cd bin/Debug
mono convert.exe
cd ../..