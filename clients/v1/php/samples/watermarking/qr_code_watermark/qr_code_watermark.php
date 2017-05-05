<?php

// ** Make sure all objects associated with the Muhimbi client can be resolved
require_once(__DIR__ . '../../../../client/autoload.php');

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

    // ** We are dealing with watermarking, so instantiate the relevant class
    $api_instance = new MuhimbiPDFOnline\Client\Api\WatermarkApi();

    // ** We need to fill out the data for the watermark operation
    $input_data = new MuhimbiPDFOnline\Client\Model\QrCodeWatermarkData();

    // ** Always pass the name of the input file, or if unknown pass any name, but with the correct file extension.
    $input_data->setSourceFileName($_FILES["file"]["name"]);

    // ** Pass the content of the uploaded file, making sure it is base64 encoded.
    $input_data->setSourceFileContent(base64_encode(file_get_contents($_FILES["file"]["tmp_name"])));

    // ** Setup the type and content for the QR Code
    $input_data->setContent('Hello World');
    $input_data->setVersion($input_data::VERSION_AUTO);
    $input_data->setInputMode($input_data::INPUT_MODE_BINARY);
    $input_data->setErrorCorrectionLevel($input_data::ERROR_CORRECTION_LEVEL_MEDIUM);

    // ** Set the various properties associated with the watermark
    $input_data->setPosition($input_data::POSITION_MIDDLE_CENTER);          // ** The location where the watermark will be positioned on the page.
    //$input_data->setX(0);                                                 // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
    //$input_data->setY(0);                                                 // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
    $input_data->setWidth(200);                                             // ** The width of the watermark in pts (1/72nd of an inch). For example 144 is 2 inches wide.
    $input_data->setHeight(286);                                            // ** The height of the watermark.
    $input_data->setLayer($input_data::LAYER_FOREGROUND);                   // ** Position the watermark in front of the page's content, or behind it
    $input_data->setRotation(0);                                            // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
    $input_data->setOpacity(50);                                            // ** A value between 0 (completely transparent) and 100 (fully visible)
    //$input_data->setFillColor("#990000");                                 // ** The fill color of the watermark in #RRGGBB notation.
    //$input_data->setLineColor("#000000");                                 // ** The (out)line color of the watermark in #RRGGBB notation.
    //$input_data->setLineWidth(10);                                        // ** The width of the line in pts (1/72nd of an inch). 0 = hairline, -1 = no line
    $input_data->setStartPage(0);                                           // ** The first page in the document the watermark applies to.
    $input_data->setEndPage(0);                                             // ** The last page in the document the watermark applies to.
    $input_data->setPageInterval(1);                                        // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
    $input_data->setPageOrientation($input_data::PAGE_ORIENTATION_BOTH);    // ** The page orientation the watermark applies to. 

    //** If you are expecting long running operations then consider longer timeouts
    //** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
        // ** Carry out the watermark operation
        $result = $api_instance->qrCodeWatermark($input_data);

        // ** Send the watermarked file back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");
        header("Content-Disposition: attachment; filename=\"watermarked.pdf\"");
        echo base64_decode($result->getProcessedFileContent());
        exit;
    } catch (Exception $e) {
        echo 'Exception when calling API: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="qr_code_watermark.php" method="post" enctype="multipart/form-data">

      <p>Please specify the PDF file to add a watermark to.</p>
      <input type="file" name="file" />

      <br/><br/>
      <input type="submit" value="Watermark" />

    </form>
  </body>
</html>