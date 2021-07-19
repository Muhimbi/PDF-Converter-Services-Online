#!/bin/bash 

rm -rf client/src
rm -f client/pom.xml

java -Dmodels -Dapis -DmodelTests=false -DmodelDocs=false -DapiDocs=false -DapiTests=false \
	-DsupportingFiles \
	-jar ../../../swagger/swagger-codegen-cli/swagger-codegen-cli.jar \
	generate \
	-i https://api.muhimbi.com/api-docs/v1/swagger.json \
	-l java \
	-o client/ \
	-c codegen-java.cfg \
    --type-mappings ByteArray=String

rm -rf client/gradle
rm -f client/pom.xml
cp pom.xml client

cd client
source build.sh
cd ..
