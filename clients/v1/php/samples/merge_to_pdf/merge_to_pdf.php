<?php

// ** Make sure all objects associated with the Muhimbi client can be resolved
require_once(__DIR__ . '/../../client/autoload.php');

$api_key = '';

//** Were both files uploaded?
if( ($_FILES["file1"]['size'] > 0) && ($_FILES["file2"]['size'] > 0))
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

    // ** We are dealing with the MergeApi, so instantiate the relevant class
    $api_instance = new MuhimbiPDFOnline\Client\Api\MergeApi();

    // ** We need to fill out the data for the merge operation
    $input_data = new MuhimbiPDFOnline\Client\Model\MergeToPdfData();

    // ** Set the name and file content for the first two files to merge. (Specify up to 5 in a single operation)
    // ** Note that we add some settings to the file name to 'auto generate PDF bookmarks' and the name of the top level bookmark.
    $input_data->setSourceFileName1($_FILES["file1"]["name"] . ';true;First file');
    $input_data->setSourceFileContent1(base64_encode(file_get_contents($_FILES["file1"]["tmp_name"])));
    $input_data->setSourceFileName2($_FILES["file2"]["name"] . ';true;Another file');
    $input_data->setSourceFileContent2(base64_encode(file_get_contents($_FILES["file2"]["tmp_name"])));
    // ** And add the URL we want to convert and merge as well.
    $input_data->setSourceFileName3("URL Content;;URL Content");
    $input_data->setSourceFileContent3($_POST["url"]);

    // ** We want each document to be merged DIRECTLY after the previous, no white pages for double sided printing.
    $input_data->setDocumentStartPage($input_data::DOCUMENT_START_PAGE_NEXT_PAGE);

    //** If you are expecting long running operations then consider longer timeouts
    //** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
        // ** Carry out the convert and merge operation.
        $result = $api_instance->mergeToPdf($input_data);

        // ** Send the merged file back to the user
        header("Cache-Control: must-revalidate, post-check=0, pre-check=0");
        header("Content-type: application/octet-stream");
        header("Content-Disposition: attachment; filename=\"merged.pdf\"");
        echo base64_decode($result->getProcessedFileContent());
        exit;
    } catch (Exception $e) {
        echo 'Exception when calling API: ', $e->getMessage(), PHP_EOL;
    }
}
?>

<html>
  <body>
    <form action="merge_to_pdf.php" method="post" enctype="multipart/form-data">

        <p>Please specify two documents and a URL to merge.</p>
        File 1: <input type="file" name="file1" /><br>
        File 2: <input type="file" name="file2" /><br>
        URL:&nbsp; <input type="text" name="url" size="50" value="http://blog.muhimbi.com/2017/01/the-how-and-why-of-ocr-providing.html">
        <br/><br>
        <input type="submit" value="Merge" />

    </form>
  </body>
</html>