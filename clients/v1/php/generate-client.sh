rm -rf client/lib
rm -f client/autoload.php
rm -f muhimbi-pdf-online-client-php.zip

java -Dmodels -Dapis -DmodelTests=false -DmodelDocs=false -DapiDocs=false -DapiTests=false \
	-DsupportingFiles \
	-jar ../../../swagger/swagger-codegen-cli/swagger-codegen-cli.jar \
	generate \
	-i https://api.muhimbi.com/api-docs/v1/swagger.json \
	-l php \
	-o client/ \
	-c codegen-php.cfg \

zip -r muhimbi-pdf-online-client-php.zip client