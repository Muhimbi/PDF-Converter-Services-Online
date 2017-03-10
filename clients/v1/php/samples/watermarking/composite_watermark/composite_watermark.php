<?php

// ** Make sure all objects associated with the Muhimbi client can be resolved
require_once(__DIR__ . '../../../../client/autoload.php');

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
    $input_data = new MuhimbiPDFOnline\Client\Model\CompositeWatermarkData();

    // ** Always pass the name of the input file, or if unknown pass any name, but with the correct file extension.
    $input_data->setSourceFileName($_FILES["file"]["name"]);

    // ** Pass the content of the uploaded file, making sure it is base64 encoded.
    $input_data->setSourceFileContent(base64_encode(file_get_contents($_FILES["file"]["tmp_name"])));

    // ** Pass in the watermark definition in XML format
    $input_data->setWatermarkData($_POST["watermark_xml"]);

    //** If you are expecting long running operations then consider longer timeouts
    //** Also keep an eye on the maximum upload size in your php.ini (e.g. post_max_size = 10M, upload_max_filesize = 10M)
    ini_set('default_socket_timeout', 300);
    set_time_limit ( 300 );

    try { 
        // ** Carry out the watermark operation
        $result = $api_instance->compositeWatermark($input_data);

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
    <form action="composite_watermark.php" method="post" enctype="multipart/form-data">

      <p>Please specify the PDF file to add multiple watermarks to.</p>
      <input type="file" name="file" />
      <br/><br/>

      <p>Apply multiple watermarks using Muhimbi's <a href="http://blog.muhimbi.com/2010/10/watermarking-pdf-documents-using_25.html">watermarking XML syntax</a>.</p>
      <textarea name="watermark_xml" rows="15" cols="100">
<watermarks>

  <!-- ** First watermark contains a single image element with the logo -->
  <watermark 
    hPosition="right" 
    vPosition="top" 
    width="50"
    height="39"
    zOrder="1"
    opacity="100"
    pageOrientation="both">
    <image
      width="50"
      height="39"
      scaleMode="maintainaspectratio"
      imageFilePath="http://p6.zdassets.com/hc/settings_assets/151641/200306747/zqddxxwHivjxBISR26GNpQ-MuhimbiLogo.png"/>
  </watermark>

  <!-- ** Second watermark places text in the background -->
  <watermark 
    hPosition="random" 
    vPosition="random" 
    width="300"
    height="200"
    zOrder="-1"
    rotation="-30"
    opacity="15"
    pageOrientation="both">
    <text
      width="200"
      height="200"
      fillColor="#FF0000"
      content="CONFIDENTIAL"
      fontFamilyName="Times New Roman"
      fontSize="24"
      fontStyle="bold|italic"
      wordWrap="word"
      />
  </watermark>

  <!-- ** Third watermark adds page numbering -->
  <watermark 
    hPosition="right" 
    vPosition="bottom" 
    width="100"
    height="40"
    zOrder="1"
    pageOrientation="both">
    <text
      hPosition="left"
      vPosition="top"
      width="100"
      height="40"
      content="Page {PAGE} of {NUMPAGES}"
      fontFamilyName="Arial"
      fontSize="11"
      hAlign="left"
      vAlign="top"
      />
  </watermark>

</watermarks>
      </textarea>


      <br/><br/>
      <input type="submit" value="Watermark" />



    </form>
  </body>
</html>