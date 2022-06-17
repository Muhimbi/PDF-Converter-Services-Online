# Sample - Convert CAD file to PDF using PHP

The PHP sample provided in this section uses the [*Muhimbi PDF Converter Services Online*](https://github.com/Muhimbi/PDF-Converter-Services-Online) to convert a CAD file (.dwg or .dxf) to PDF.
Additional sample code to *convert, merge, watermark, secure* and *OCR* files [can be found here](../).

Full details about the `convert_cad` method, fields and properties can be found [in the Wiki](https://github.com/Muhimbi/PDF-Converter-Services-Online/wiki/API:-convert_cad).

<br>

## Downloading the sample

Download the sample code using a method of your choice. Some examples are provided below.

- **Git:** Clone the entire repository to your system. You can find the examples under the `clients/v1/php/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the PHP client and sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/php`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/php/samples` folder.

<br>

## Use a valid (or trial) subscription

In order to successfully execute the sample code, make sure you have a valid subscription, either a full one or [the 30 day trial](https://support.muhimbi.com/hc/en-us/articles/115002816048-Getting-started-with-the-PDF-Converter-Services-Online).

:exclamation: Each subscription comes with a unique `api_key`. Before executing the sample, please insert your key in the code. :exclamation:


<br>

## Running the sample

Make sure [the prerequisites](https://github.com/Muhimbi/PDF-Converter-Services-Online/tree/master/clients/v1/php#prerequisites) are in place. The sample code expects the client libraries to be present under `../../client/`.

There are many ways to execute PHP code, in this example we use PHP's internal web server, but naturally it will work equally well using Apache, IIS or any other PHP capable platform.

Launch PHP and activate the built-in web server as follows:

```
php -S localhost:8080 -t some_path_to/PDF-Converter-Services-Online/clients/v1/php/samples/convert
```

You may want to change the port number and naturally you must specify the full path to the folder containing this sample.

With PHP running - and in this example - listening on port 8080, open a browser and navigate to `http://localhost:8080/convert.php`.

Choose a file, select an output format that the input file [can be converted to](https://support.muhimbi.com/hc/en-us/articles/228089047-What-file-formats-types-are-supported-for-conversion-) (start with the `PDF` option) and click the `Convert` button. 

<br>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
