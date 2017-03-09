<?php

// ** Make sure all objects associated with the Muhimbi client can be resolved
require_once(__DIR__ . '/../../client/autoload.php');

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

	// ** We are dealing with OCR, so instantiate the relevant class
    $api_instance = new MuhimbiPDFOnline\Client\Api\OCRApi();

	// ** We need to fill out the data for the OCR operation
    $input_data = new MuhimbiPDFOnline\Client\Model\OcrPdfData();

    // ** Always pass the name of the input file, or if unknown pass any name, but with the correct file extension.
    $input_data->setSourceFileName($_FILES["file"]["name"]);

	// ** Pass the content of the uploaded file, making sure it is base64 encoded.
    $input_data->setSourceFileContent(base64_encode(file_get_contents($_FILES["file"]["tmp_name"])));

	// ** Specify the language used in the document.
	$input_data->setLanguage($input_data::LANGUAGE_ENGLISH);

	// ** Unless you have a good reason not to, use SLOW_BUT_ACCURATE.
	$input_data->setPerformance($input_data::PERFORMANCE_SLOW_BUT_ACCURATE);

	// ** Whitelist or blacklist any characters?
	$input_data->setCharactersOption($input_data::CHARACTERS_OPTION_NONE);
	$input_data->setCharacters('');

	// ** Only 'paginate' when your documents have images that span multiple pages.
	$input_data->setPaginate(false);

	// ** We want to OCR the entire document, not just specific areas.
	$input_data->setRegions('');

    //** If you are expecting long running operations then consider longer timeouts
	//** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
		// ** Carry out OCR
        $result = $api_instance->ocrPdf($input_data);

        // ** Send the OCRed file back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");
        header("Content-Disposition: attachment; filename=\"ocr.pdf\"");
        echo base64_decode($result->getProcessedFileContent());
        exit;
    } catch (Exception $e) {
        echo 'Exception when calling ConvertApi->convert: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="ocr_pdf.php" method="post" enctype="multipart/form-data">

      <p>Select a scan, fax or image to OCR<p>
      <input type="file" name="file" />

	  <br/><br>
      <input type="submit" value="Submit" />
    </form>
  </body>
</html>