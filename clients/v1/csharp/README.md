# C# Client & Sample code

Details about using the *[Muhimbi PDF Converter Services Online](https://support.muhimbi.com/hc/en-us/articles/115002813708-About-the-PDF-Converter-Services-Online)* from .NET, specifically C#, can be found below. If you prefer to bypass these wrapper libraries, and rather send JSON code to the REST based service directly, then please see the section containing [raw JSON examples](../json)

*If a cloud-based service is not suitable to your needs (e.g. for security or regulatory reasons), and you have the ability to deploy software to your own (Windows) server, then check out the [Muhimbi PDF Converter Services](http://www.muhimbi.com/Products/PDF-Converter-Services/summary.aspx) and [this sample code](https://support.muhimbi.com/hc/en-us/articles/228089807-Where-can-I-find-sample-code-).*

<br/>

## Table of contents

- [Prerequisites](#prerequisites)
  - [Linux](#linux)
  - [Windows](#windows)
- [Client libraries](#client-libraries)
  - [Installing the pre-generated client](#installing-the-pre-generated-client)
  - [Generating the client from scratch](#generating-the-client-from-scratch)
    - [Using the command line](#using-the-command-line)
    - [Using editor.swagger.io](#using-editorswaggerio)
- [Sample code](#sample-code)
- [API / Documentation](#api--documentation)

<br/>

## Prerequisites

Prerequisites for using the PDF Converter in combination with C# are as follows:

- .NET framework v4.0 and later (or mono 3.0 and later)

The PDF Converter client has the following dependencies:

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

These dependencies are shipped alongside our libraries. However, if you integrate our software in an existing product / solution that utilise the same dependencies, then make sure the version numbers are correct.

Exact deployment and configuration steps for the various platforms vary slightly. The ones for Linux, tested with Ubuntu, and Windows are provided below. 

<br/>

### Linux

There are multiple options for executing C# code on Linux, the examples provided in this section use [`mono`](http://www.mono-project.com/).

```
sudo apt-get install mono-devel
```

This single install is sufficient for executing code that use our pre-built libraries.


If, for whatever reason, you need to renegerate and / or recompile the client then you may need to run the following commands to make sure `nuget` works without error..

```
sudo mozroots --import --machine --sync
sudo certmgr -ssl -m https://go.microsoft.com
sudo certmgr -ssl -m https://nugetgallery.blob.core.windows.net
sudo certmgr -ssl -m https://nuget.org
```

<br/>

### Windows

If you are a Windows developer, the appropriate .NET framework version is most likely already installed on your system. In case it is not, install it [as described here](https://msdn.microsoft.com/en-us/library/5a4x27ek(v=vs.110).aspx).

<br/>


## Client libraries

With the prerequisites in place, install the PDF Converter's client libraries using one of the methods described below. 

<br/>

### Installing the pre-generated client

Time is precious, so with that in mind, the easiest way to get going is to [download the pre-generated client libraries](https://github.com/Muhimbi/PDF-Converter-Services-Online/raw/master/clients/v1/csharp/muhimbi-pdf-online-client-dotnet.zip) and unzip them to a location in your project. Add the extracted DLLs as a reference in your project.

<br/>

### Generating the client from scratch

:exclamation: **This is an advanced topic, most developers do not need to generate the client from scratch** :exclamation: 

If the pre-generated client libraries are not suiting your needs, then you may want to manually generate them. If you need more control over namespaces, or need to target a specific .NET framework version, then this is the way forward. 

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

Regardless of `swagger-codegen-cli.jar` being downloaded or compiled, the .NET libraries can now be generated as follows:

```sh
java -jar swagger-codegen-cli.jar \
     generate \
     -i https://api.muhimbi.com/api-docs/v1/swagger.json \
     -l csharp \
     -o MuhimbiPDFOnline-client
```

You may need to adjust the path to the jar file.

The command provided above generates the C# client using the default settings, including a unit-test framework and incomplete documentation. As this is of no use to us, and we need to tweak some other settings as well, you can find the exact command we used in [`generate-client.sh`](generate-client.sh)

Once the client code has been generated it must be build using the C# compiler. The commands for carrying out the build can be found in `client\build.bat` (Windows) and `client\build.sh` (Linux). You may need to make some changes to suit your requirements. 

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

- **Git:** Use the following command to clone the entire repository to your system. This will download all files associated with this repository, and is most likely overkill, but it is the only easy way to download files using Git. Once downloaded, you can find the examples under the `clients/v1/csharp/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online/`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the C# client and sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/csharp`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/csharp/samples` folder.

<br/>

An example is provided for each individual REST endpoint. A full overview can be found below.

Sample								| Description
------------------------------------|---------------------------------------------------------
[convert](samples/convert/)					| Convert a single file to PDF or other [supported output format](https://support.muhimbi.com/hc/en-us/articles/228089047-What-file-formats-types-are-supported-for-conversion-).
[convert_html](samples/convert_html/)		| Convert an HTML fragment, or URL, to PDF.
[convert_LRO](samples/convert_LRO/)			| Convert a single file to PDF or other formats using asynchronous pattern for long running uperations.
[convert_to_pdfa](samples/convert_to_pdfa/)	| Convert a single file to a PDF/A document (or to other PDF profiles).
[extract_pdf_forms_data](samples/extract_pdf_forms_data/)		| Export PDF Forms Data from PDF document.
[merge_to_pdf](samples/merge_to_pdf/)		| Combine multiple files, and URLs, into a single PDF.
[merge_to_pdf (SharePoint)](samples/merge_to_pdf%20%28SharePoint%29/)		| Combine multiple SharePoint files (by path), and URLs, into a single PDF.
[ocr_pdf](samples/ocr_pdf/)					| Convert a scan, fax or other image into a searchable PDF.
[ocr_text](samples/ocr_text/)				| Use OCR to extract text from a scan, fax or other image.
[secure_document (MS Office)](samples/secure_document%20%28MS%20Office%29/)	| Apply security settings and passwords to an MS Office.
[secure_pdf](samples/secure_pdf/)			| Apply security settings, passwords and restrictions to a PDF.
[split_pdf](samples/split_pdf/)				| Split a large PDF into smaller PDFs.
**[watermarking](samples/watermarking/)**	| 
&nbsp;&nbsp;&nbsp;[composite_watermark](samples/watermarking/composite_watermark/)	| Add a number of different watermarks to a PDF file in a single operation.
&nbsp;&nbsp;&nbsp;[ellipse_watermark](samples/watermarking/ellipse_watermark/)		| Add an ellipse based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[image_watermark](samples/watermarking/image_watermark/)			| Add an image based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[linear_barcode_watermark](samples/watermarking/linear_barcode_watermark/)	| Add a Linear Barcode to a PDF file.
&nbsp;&nbsp;&nbsp;[line_watermark](samples/watermarking/line_watermark/)			| Add a line based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[pdf_watermark](samples/watermarking/pdf_watermark/)				| Add a PDF based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[qr_code_watermark](samples/watermarking/qr_code_watermark/)		| Add a QR Code to a PDF file.
&nbsp;&nbsp;&nbsp;[rectangle_watermark](samples/watermarking/rectangle_watermark/)	| Add a rectangle based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[rtf_watermark](samples/watermarking/rtf_watermark/)				| Add a rich text (RTF) based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[text_watermark](samples/watermarking/text_watermark/)			| Add a simple text watermark to a PDF file.
**[watermarking (MS Office)](samples/watermarking%20%28MS%20Office%29/)**	| 
&nbsp;&nbsp;&nbsp;[composite_watermark](samples/watermarking%20%28MS%20Office%29/composite_watermark/)	| Add a number of different watermarks to a Word document in a single operation.
&nbsp;&nbsp;&nbsp;[qr_code_watermark](samples/watermarking%20%28MS%20Office%29/qr_code_watermark/)		| Add a QR Code to an Excel document.
&nbsp;&nbsp;&nbsp;[text_watermark](samples/watermarking%20%28MS%20Office%29/text_watermark/)			| Add a simple text watermark to a PowerPoint document.

<br/>


## API / Documentation

Although the API is largely self-describing, especially when used in code editors with *intellisense* and *code-complete*, from time to time it may be easier to consult the full API documentation. An overview of the entire object model can be found [in the Wiki](https://github.com/Muhimbi/PDF-Converter-Services-Online/wiki/API).


<br/>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
