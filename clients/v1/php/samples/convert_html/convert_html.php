<?php

// ** Make sure all objects associated with the Muhimbi client can be resolved
require_once(__DIR__ . '/../../client/autoload.php');

$api_key = '';

//** Was a button clicked?
if(isset($_POST["btnConvertURL"]) == true || isset($_POST["btnConvertHTML"]) == true)
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
	
	// ** We need to fill out the data for the HTML conversion operation
    $input_data = new MuhimbiPDFOnline\Client\Model\ConvertHtmlData();

	// ** Is the user looking to convert a URL
	if(isset($_POST["btnConvertURL"]) == true)
	{
		// ** Then pass in the URL to convert.
		$input_data->setSourceUrlOrHtml($_POST["url"]);	
	}

	// ** Is the user looking to convert an HTML fragment?
	if(isset($_POST["btnConvertHTML"]) == true)
	{
		// ** Then pass in the HTML to convert.
		$input_data->setSourceUrlOrHtml($_POST["html"]);	
	}
	
	// ** Set the page orientation to Portrait or Landscape depending on your needs
	$input_data->setPageOrientation($input_data::PAGE_ORIENTATION_PORTRAIT);

    //** Although unlikely for HTML Conversion, if you are expecting long running operations then consider longer timeouts
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
		// ** Carry out the conversion
        $result = $api_instance->convertHtml($input_data);

        // ** Send the converted file back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");
        header("Content-Disposition: attachment; filename=\"convert.pdf\"");
        echo base64_decode($result->getProcessedFileContent());
        exit;
    } catch (Exception $e) {
        echo 'Exception when calling ConvertApi->convert: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="convert_html.php" method="post" enctype="multipart/form-data">

		<p>URL to convert:</p>
		<input type="text" name="url" size="50" value="http://blog.muhimbi.com/2017/01/the-how-and-why-of-ocr-providing.html">
		<br><br>
		<input type="submit" name="btnConvertURL" value="Convert URL" />

		<br><br><br>
		<p>HTML fragment to convert:</p>
		<textarea name="html" rows="10" cols="51">
<html>
	<body style="font-family: Arial">
		<strong>Hello World</strong>
	</body>
</html>
		</textarea>
		<br/><br>
		<input type="submit" name="btnConvertHTML" value="Convert HTML" />
    
	</form>
  </body>
</html>