#!/bin/bash 

rm -rf client/bin
rm -rf client/packages
rm -rf client/src

java -Dmodels -Dapis -DmodelTests=false -DmodelDocs=false -DapiDocs=false -DapiTests=false \
	-DsupportingFiles \
	-jar ../../../swagger/swagger-codegen-cli/swagger-codegen-cli.jar \
	generate \
	-i https://api.muhimbi.com/api-docs/v1/swagger.json \
	-l csharp \
	-o client/ \
	-c codegen-csharp.cfg \

cp client/AssemblyInfo.cs client/src/Muhimbi.PDF.Online.Client/Properties/

cd client
source build.sh
cd ..