#!/bin/bash

echo "[INFO] Removing old and unneeded files"
rm -rf target
rm -rf lib
rm -rf ../muhimbi-pdf-online-client-java.zip

echo "[INFO] Run 'maven' to build target/muhimbi-online-pdf-client-#.jar"
mvn clean package

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] target/muhimbi-online-pdf-client-#.jar was created successfully"
fi

echo "[INFO] Moving all jars to 'lib' folder for distribution"
mkdir lib
cp target/lib/* lib
rm -f target/*-javadoc.jar
rm -f target/*-sources.jar
rm -f target/*-tests.jar
cp target/muhimbi-online-pdf-client-*.jar lib

echo "[INFO] removing unused jars from 'lib' folder"
rm -f lib/hamcrest-core-1.3.jar
rm -f lib/junit-4.12.jar
rm -f lib/logging-interceptor-2.7.5.jar
rm -f lib/swagger-annotations-1.5.12.jar

echo "[INFO] Creating zip archive"
zip -j ../muhimbi-pdf-online-client-java.zip lib/*

echo "[INFO] Removing 'target' again as we do not want them in source control"
rm -rf target
