#!/bin/bash

echo "[INFO] Removing old files"
rm -f *.class
rm -f result.pdf

echo "[INFO] Starting Build"
javac -cp ../../client/lib/*:. *.java

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] Executable created successfully"
fi

echo "[INFO] Running "
java -cp ../../client/lib/*:. sample
