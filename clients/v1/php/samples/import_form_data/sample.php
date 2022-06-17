<?php

// ** Make sure all objects associated with the Muhimbi client can be resolved
require_once(__DIR__ . '/../../client/autoload.php');

// !!!! ENTER YOUR API KEY HERE !!!!
$api_key = '';

//** Was a file uploaded?
if($_FILES["file"]['size'] > 0)
{
    //** Make sure an api key has been entered
    if($api_key == '') {
        echo 'Please update the sample code and enter the API Key that came with your subscription.';
        exit;
    }

    // ** Specify the API key associated with your subscription.
    MuhimbiPDFOnline\Client\Configuration::getDefaultConfiguration()->setApiKey('api_key', $api_key);

    // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
    MuhimbiPDFOnline\Client\Configuration::getDefaultConfiguration()->setHost('https://api.muhimbi.com/api');

    // ** We are dealing with the ConvertApi, so instantiate the relevant class
    $api_instance = new MuhimbiPDFOnline\Client\Api\ConvertApi();

    // ** We need to fill out the data for the conversion operation
    $input_data = new MuhimbiPDFOnline\Client\Model\ImportFormData();

    // ** Always pass the name of the input file, or if unknown pass any name, but with the correct file extension.
    $input_data->setSourceFileName($_FILES["file"]["name"]);

    // ** Pass the content of the uploaded file, making sure it is base64 encoded.
    $input_data->setSourceFileContent(base64_encode(file_get_contents($_FILES["file"]["tmp_name"])));

    // ** Always pass the content of the PDF template to import the data into
    $input_data->setPdfTemplateFileContent(base64_encode(file_get_contents($_FILES["template"]["tmp_name"])));

    //** If you are expecting long running operations then consider longer timeouts
    //** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
        // ** Carry out the conversion
        $result = $api_instance->importFormData($input_data);

        // ** Send the converted file back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");
        header("Content-Disposition: attachment; filename=\"result.pdf\"");
        echo base64_decode($result->getProcessedFileContent());
        exit;
    } catch (Exception $e) {
        echo 'Exception when calling API: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="sample.php" method="post" enctype="multipart/form-data">
      Data document: <input type="file" name="file" accept=".fdf,.xfdf,.xml"/>

      <br/><br/>
      PDF template: <input type="file" name="template" accept=".pdf"/>

      <br/><br/>
      <input type="submit" value="Import data" />
    </form>
  </body>
</html>