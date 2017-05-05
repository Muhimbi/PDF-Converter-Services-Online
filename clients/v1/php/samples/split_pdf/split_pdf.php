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

    // ** We are dealing with the Splitting Api, so instantiate the relevant class
    $api_instance = new MuhimbiPDFOnline\Client\Api\SplitApi();

    // ** We need to fill out the data for the Split operation
    $input_data = new MuhimbiPDFOnline\Client\Model\SplitPdfData();

    // ** Always pass the name of the input file, or if unknown pass any name, but with the correct file extension.
    $input_data->setSourceFileName($_FILES["file"]["name"]);

    // ** Pass the content of the uploaded file, making sure it is base64 encoded.
    $input_data->setSourceFileContent(base64_encode(file_get_contents($_FILES["file"]["tmp_name"])));

    // ** We want to split based on the number of pages.
    $input_data->setFileSplitBy($input_data::FILE_SPLIT_BY_NUMBER_OF_PAGES);

    // ** In this example in batches of 2 pages per PDF file.
    $input_data->setSplitParameter(2);

    // ** Optionally generate output file names using .NET's formatting syntax
    // ** When splitting by bookmark then an optional {1} parameter represents the bookmark name
    $input_data->setFileNameTemplate('split-{0:D3}.pdf');

    //** If you are expecting long running operations then consider longer timeouts
    //** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
        // ** Carry out the split operation
        $result = $api_instance->splitPdf($input_data);

        // ** Send one of the split files back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");

        // ** If we got 2 or more files back then, in this demo, send the 2nd generated file, otherwise send the first
        if(count($result->getProcessedFiles()) >= 2)
        {
            header("Content-Disposition: attachment; filename=\"" . $result->getProcessedFiles()[1]->getProcessedFileName() . "\"");
            echo base64_decode($result->getProcessedFiles()[1]->getProcessedFileContent());
        }
        else
        {
            header("Content-Disposition: attachment; filename=\"" . $result->getProcessedFiles()[0]->getProcessedFileName() . "\"");
            echo base64_decode($result->getProcessedFiles()[0]->getProcessedFileContent());
        }

        exit;
    } catch (Exception $e) {
        echo 'Exception when calling API: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="split_pdf.php" method="post" enctype="multipart/form-data">

      <p>Please specify the PDF file to split.</p>
      <input type="file" name="file" />

      <br/><br>
      <p>In this example the resulting PDF will be split into PDF files of 2 pages.<br/>
      As we can only return a single file to the browser we return the 2nd generated file.</p>
      <input type="submit" value="Split" />
    </form>
  </body>
</html>