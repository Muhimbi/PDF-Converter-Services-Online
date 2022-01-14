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
    $input_data = new MuhimbiPDFOnline\Client\Model\ConvertData();

    // ** Always pass the name of the input file, or if unknown pass any name, but with the correct file extension.
    $input_data->setSourceFileName($_FILES["file"]["name"]);

    // ** Pass the content of the uploaded file, making sure it is base64 encoded.
    $input_data->setSourceFileContent(base64_encode(file_get_contents($_FILES["file"]["tmp_name"])));

    // ** Specify the format of the file type we wish to convert to.
    $input_data->setOutputFormat("PDF");

    // ** Specify additional settings for the PDF Converter. This can be omitted for most cases.
    // ** In this example we set the desired PDF profile. For more details see
    // ** http://blog.muhimbi.com/2012/09/overriding-default-conversion-settings.html
    $input_data->setOverrideSettings(   "<Override>" .
                                        "<ConversionSettings>" .
                                        "<PDFProfile>" . $_POST["pdfProfile"] . "</PDFProfile>" .
                                        "</ConversionSettings>" .
                                        "</Override>");

    // ** If you are expecting long running operations then consider longer timeouts
    // ** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
        // ** Carry out the conversion
        $result = $api_instance->convert($input_data);

        // ** Send the converted file back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");
        header("Content-Disposition: attachment; filename=\"convert." . $input_data->getOutputFormat() . "\"");
        echo base64_decode($result->getProcessedFileContent());
        exit;
    } catch (Exception $e) {
        echo 'Exception when calling API: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="convert_to_pdfa.php" method="post" enctype="multipart/form-data">

      PDF Profile: 
      <select name="pdfProfile">
        <option value="Default">Default</option>
        <option value="PDF_A1B">PDF/A-1b</option>
        <option value="PDF_A2B" selected>PDF/A-2b</option>
        <option value="PDF_A2U">PDF/A-2u</option>
        <option value="PDF_A3B">PDF/A-3b</option>
        <option value="PDF_A3U">PDF/A-3u</option>
        <option value="PDF_1_1">PDF 1.1</option>
        <option value="PDF_1_2">PDF 1.2</option>
        <option value="PDF_1_3">PDF 1.3</option>
        <option value="PDF_1_4">PDF 1.4</option>
        <option value="PDF_1_5">PDF 1.5</option>
        <option value="PDF_1_6">PDF 1.6</option>
        <option value="PDF_1_7">PDF 1.7</option>
      </select>

      &nbsp;&nbsp;&nbsp;
      <input type="file" name="file" />

      <br/><br>
      <input type="submit" value="Convert" />
    </form>
  </body>
</html>