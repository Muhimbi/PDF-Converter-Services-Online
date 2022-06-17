#!/bin/bash 

echo "[INFO] Cleaning"
rm -rf ./client/.openapi-generator
rm -rf ./client/src
rm -f ./client/.gitignore
rm -f ./client/.openapi-generator-ignore
rm -f ./client/appveyor.yml
rm -f ./client/git_push.sh
rm -f ./client/README.md

rm -f ./client/Muhimbi.PDF.Online.Client.sln

java -Dmodels -Dapis -DmodelTests=false -DmodelDocs=false -DapiDocs=false -DapiTests=false \
	-DsupportingFiles \
	-jar ../../../swagger/openapi-generator-cli/openapi-generator-cli.jar \
	generate \
	-g csharp-netcore \
	-i https://api.muhimbi.com/api-docs/v1/swagger.json \
	-o client \
	-c openapi-generator.cfg \

echo "[INFO] Removing unnecessary files"
rm -rf ./client/.openapi-generator
rm -f ./client/.gitignore
rm -f ./client/.openapi-generator-ignore
rm -f ./client/appveyor.yml
rm -f ./client/git_push.sh
rm -f ./client/README.md

cp ./client/AssemblyInfo.cs ./client/src/Muhimbi.PDF.Online.Client

cd ./client
source build.sh
cd ..
