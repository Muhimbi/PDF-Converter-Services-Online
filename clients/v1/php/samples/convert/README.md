# Sample - Convert file using PHP

The PHP sample provided in this section uses the *Muhimbi PDF Converter Services Online* to convert uploaded documents to PDF (or other) format.
Additonal samples code, to convert, merge, watermark, secure and OCR files [can be found here](../).

<br>

## Downloading the sample

Download the sample code using a method of your choice. Some examples are provided below.

- **Git:** Use the following command to clone the entire repository to your system. This will download all files associated with this repository, and is most likely overkill, but it is the only easy way to download files using Git. Once downloaded, you can find the examples under the `clients/v1/php/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online/`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the PHP client and sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/php`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/php/samples` folder.

<br>

## Ensure a valid (or trial) subscription

In order to successfully execute the sample code, make sure you have a valid subscription, either a full one or [the 30 day trial](https://support.muhimbi.com/hc/en-us/articles/115002816048-Getting-started-with-the-PDF-Converter-Services-Online).

Each subscription comes with a unique `api_key`. Before executing the sample, please insert your api_key.

REMOVE API KEY FROM SAMPLE CODE


<br>

## Running the sample

Make sure [the prerequisites](https://github.com/Muhimbi/PDF-Converter-Services-Online/tree/master/clients/v1/php#prerequisites) are in place. The sample code expects the client libraries to be present under `../../client/`, which is the default location when the sample code is donwloaded using any of the means provided above.

There are many ways to run PHP code, in this example we use PHP's internal web server, but naturally it will work equally well from Apache, IIS or any other PHP capable platform.

The command to launch PHP and activate the built-in web server is the same for Linux and Windows:

```
php -S localhost:8080 -t some_path_to/PDF-Converter-Services-Online/clients/v1/php/samples/convert
```

You may want to change the port number and naturally you must specify the full path to this example.

With PHP running - and in this example - listening on port 8080, open a browser and navigate to `http://localhost:8080/convert.php`.

Choose a file, select an output format that the input file [can be converted to](https://support.muhimbi.com/hc/en-us/articles/228089047-What-file-formats-types-are-supported-for-conversion-) (just accept the default `PDF` option) and clck the `convert` button. Depending on the size and complexity of the source file, after a few seconds the converted file will be downloaded automatically.

<br>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
