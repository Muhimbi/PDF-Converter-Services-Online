# PHP Client & Sample code

In this section you will find details about how to use the PHP client libraries for the *Muhimbi PDF Converter Services Online*. If you prefer to bypass these wrapper libraries, and rather send JSON code to the REST based service directly, then please see the section containing [raw JSON examples](../json)

*If a cloud-based service is not suitable to your needs (e.g. for security or regulatory reasons), and you have the ability to deploy software to your own (Windows) server, then check out the [Muhimbi PDF Converter Services](http://www.muhimbi.com/Products/PDF-Converter-Services/summary.aspx) and [this PHP sample code](http://blog.muhimbi.com/2013/02/converting-files-to-pdf-and-other.html).*

<br/>

## Table of contents

- [Prerequisites](#prerequisites)
  - [Linux](#linux)
  - [Windows](#windows)
  - [Configure PHP](#configure-php-same-for-all-platforms)
- [Client libraries](#client-libraries)
  - [Installing the pre-generated client](#installing-the-pre-generated-client)
  - [Generating the client from scratch](#generating-the-client-from-scratch)
    - [Using the command line](#using-the-command-line)
    - [Using editor.swagger.io](#using-editorswaggerio)
- [Sample code](#sample-code)
- [API / Documentation](#api--documentation)

<br/>

## Prerequisites

The prerequisites to access the PDF Converter from PHP are as follows:

- PHP 5.4.0 and later
- PHP Curl libraries (See platform specific steps below)
- PHP Open SSL libraries (See platform specific steps below)

Exact deployment and configuration steps for the various platforms vary slightly. The ones for Linux, tested with Ubuntu, and Windows are provided below. 

<br/>

### Linux

Deployment of the prerequisites is straight-forward. Feel free to adjust the steps if you need to deploy a different PHP version, providing it is version 5.4.0 or later.

```
sudo apt-get install php5
sudo apt-get install php5-curl
```

The OpenSSL libraries are typically pre-compiled into PHP and don't need to be installed separately. To verify that OpenSSL is available in your PHP version, create and execute a PHP file with the following content:

```php
<?php phpinfo() ?>
```

Access this page via a browser and check '*OpenSSL support*' shows as *enabled*.

<br/>

### Windows

Deploy the prerequisites for Windows as follows:

1. [Download and install](http://windows.php.net/download) the appropriate PHP version. We recommend installing it in `c:\php`.
2. Edit php.ini and check that the following two extensions are enabled.
   * extension=php_curl.dll
   * extension=php_openssl.dll
3. To prevent SSL related errors, either switch the sample code to use `http://api.muhimbi.com` (not the default `https`) or install the appropriate certificates as follows. 
   * [Download ca-bundle.crt](https://raw.githubusercontent.com/bagder/ca-bundle/e9175fec5d0c4d42de24ed6d84a06d504d5e5a09/ca-bundle.crt) and save it in a location of your choice (in this example we use `c:\php`)
   * Add the following lines to `php.ini`:
   ```
   curl.cainfo="C:/php/ca-bundle.crt"
   openssl.cafile="C:/php/ca-bundle.crt"
   ```

<br/>

### Configure PHP (same for all platforms)

When dealing with document conversions and merge operations, the default values for `upload_max_filesize` and `post_max_size` may be too conservative and should be increased to a value that matches your requirements [and subscription level](http://www.muhimbi-online.com/pricing).

This can be achieved by updating, or adding, the following values in 'php.ini':

```
upload_max_filesize = 10M
post_max_size = 10M
```

<br/>



## Client libraries

With the prerequisites in place, install the PDF Converter's client libraries using one of the methods described below. 

<br/>

### Installing the pre-generated client

Time is precious, so with that in mind, the easiest way to get going is to [download the pre-generated client libraries](https://github.com/Muhimbi/PDF-Converter-Services-Online/raw/master/clients/v1/php/muhimbi-pdf-online-client-php.zip) and unzip them to a location in your PHP project.

<br/>

### Generating the client from scratch

:exclamation: **This is an advanced topic, most developers do not need to generate the client from scratch** :exclamation: 

If the pre-generated client libraries are not suiting your needs, then you may want to manually generate them. If you need more control over namespaces, or feel very strongly about the variable naming convention used by our default client, then this is the way forward. `snake_case` vs `camelCase`, important stuff!

<br/>

#### Using the command line

All the PDF Converter's client libraries are generated from the [Swagger API definition file](../../../swagger/) using [swagger-codegen](https://github.com/swagger-api/swagger-codegen). 

You can either download a precompiled version of `swagger-codegen` or build it from scratch.

Download the precompiled version as follows:

```sh
wget https://oss.sonatype.org/content/repositories/releases/io/swagger/swagger-codegen-cli/2.2.2/swagger-codegen-cli-2.2.2.jar -O swagger-codegen-cli.jar

java -jar swagger-codegen-cli.jar help
```

This downloads version 2.2.2 and, assuming all is well, shows a brief help section. As newer versions are released from time to time, you may want to [check what the latest version number is](https://github.com/swagger-api/swagger-codegen#prerequisites).

<br/>

If, rather than taking a 'fixed-in-time' precompiled version of `swagger-codegen`, you prefer the very latest version then you can compile it as described below.

To build from source, you need the following installed and available in your $PATH:
- JDK 7 or 8
- Apache maven 3.3.3 or greater

Instructions for Linux (Tested in Ubuntu) are as follows. 

```sh
sudo apt-get install default-jdk
sudo apt-get install maven
git clone https://github.com/swagger-api/swagger-codegen
cd swagger-codegen
mvn clean package
```

This installs the Java Development Kit, the Maven build system, downloads the latest `swagger-codegen` source and builds it. Assuming the build process completes without error, `swagger-codegen-cli.jar` can be found under `modules/swagger-codegen-cli/target/`.


Instructions are correct at the time of writing, but for the latest details about building codegen, compiling on different platforms, or downloading a pre-compiled version of `swagger-codegen-cli.jar`, see [codegen's Readme file](https://github.com/swagger-api/swagger-codegen/blob/master/README.md).


<br/>

Regardless of `swagger-codegen-cli.jar` being downloaded or compiled, the PHP libraries can now be generated as follows:

```sh
java -jar swagger-codegen-cli.jar \
     generate \
     -i https://api.muhimbi.com/api-docs/v1/swagger.json \
     -l php \
     -o MuhimbiPDFOnline-client
```

You may need to adjust the path to the jar file.

The command provided above generates the PHP client using the default settings, including a unit-test framework and incomplete documentation. As this is of no use to us, and we need to tweak some other settings, you can find the exact command we used in [`generate-client.sh`](generate-client.sh)

<br/>


#### Using editor.swagger.io

For a quick-and-dirty way to generate client libraries for the language of your choice, use the web based `editor.swagger.io` system.

1. Open [editor.swagger.io](http://editor.swagger.io)
2. From the `File` menu select `Import URL`
3. Enter `https://raw.githubusercontent.com/Muhimbi/PDF-Converter-Services-Online/master/swagger/v1/muhimbi-pdf-online-swagger.json`
4. From the `Generate Client` menu select the language of your choice.

<br/>


## Sample code

Sample code, and related files, for the various facilities provided by this service can be found below. It is recommended to copy all samples to your local system using one of the following options:

- **Git:** Use the following command to clone the entire repository to your system. This will download all files associated with this repository, and is most likely overkill, but it is the only easy way to download files using Git. Once downloaded, you can find the examples under the `clients/v1/php/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online/`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the PHP client and sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/php`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/php/samples` folder.

<br/>

An example is provided for each individual REST endpoint. A full overview can be found below.

Sample								| Description
------------------------------------|---------------------------------------------------------
[convert](samples/convert/)					| Convert a single file to PDF or other [supported output format](https://support.muhimbi.com/hc/en-us/articles/228089047-What-file-formats-types-are-supported-for-conversion-).
[convert_html](samples/convert_html/)		| Convert an HTML fragment, or URL, to PDF.
[merge_to_pdf](samples/merge_to_pdf/)		| Combine multiple files, and URLs, into a single PDF.
[ocr_pdf](samples/ocr_pdf/)					| Convert a scan, fax or other image into a searchable PDF.
[ocr_text](samples/ocr_text/)				| Use OCR to extract text from a scan, fax or other image.
[secure_pdf](samples/secure_pdf/)			| Apply security settings, passwords and restrictions to a PDF.
[split_pdf](samples/split_pdf/)				| Split a large PDF into smaller PDFs.
**[watermarking](watermarking/)**	| 
&nbsp;&nbsp;&nbsp;[text_watermark](samples/watermarking/text_watermark/)			| Add a simple text watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[rtf_watermark](samples/watermarking/rtf_watermark/)				| Add a rich text (RTF) based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[image_watermark](samples/watermarking/image_watermark/)			| Add an image based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[qr_code_watermark](samples/watermarking/qr_code_watermark/)		| Add a QR Code to a PDF file.
&nbsp;&nbsp;&nbsp;[pdf_watermark](samples/watermarking/pdf_watermark/)				| Add a PDF based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[ellipse_watermark](samples/watermarking/ellipse_watermark/)		| Add an ellipse based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[line_watermark](samples/watermarking/line_watermark/)			| Add a line based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[rectangle_watermark](samples/watermarking/rectangle_watermark/)	| Add a rectangle based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[composite_watermark](samples/watermarking/composite_watermark/)	| Add a number of different watermarks to a PDF file in a single operation.

<br/>


## API / Documentation

Although the API is largely self-describing, especially when used in code editors with *intellisense* and *code-complete*, from time to time it may be easier to consult the full API documentation. An overview of the entire object model can be found [in the Wiki](https://github.com/Muhimbi/PDF-Converter-Services-Online/wiki/API).


<br/>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
