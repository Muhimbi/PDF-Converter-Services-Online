# JavaScript Sample code

Details about using the *[Muhimbi PDF Converter Services Online](https://support.muhimbi.com/hc/en-us/articles/115002813708-About-the-PDF-Converter-Services-Online)* from JavaScript, can be found below. 

*If a cloud-based service is not suitable to your needs (e.g. for security or regulatory reasons), and you have the ability to deploy software to your own (Windows) server, then check out the [Muhimbi PDF Converter Services](http://www.muhimbi.com/Products/PDF-Converter-Services/summary.aspx).*

<br/>

## Table of contents

- [Prerequisites](#prerequisites)
- [Client libraries](#client-libraries)
- [Sample code](#sample-code)
- [API / Documentation](#api--documentation)

<br/>

## Prerequisites

There are very few prerequisites to run these samples. A modern browser and an internet connection (to fetch jQuery and talk to the REST API) is all that is needed.

<br/>


## Client libraries

Unlike our [sample code for other languages](../../), the JavaScript samples do not depend on pre-generated client libraries. JavaScript can deal with REST / JSON natively. Adding pre-generated client libraries will just complicated matters.

You are naturally free to take our Swagger API definition file, load it into [editor.swagger.io](http://editor.swagger.io/), and generate JavaScript clients.

The steps are as follows:

1. Open [editor.swagger.io](http://editor.swagger.io)
2. From the `File` menu select `Import URL`
3. Enter `https://raw.githubusercontent.com/Muhimbi/PDF-Converter-Services-Online/master/swagger/v1/muhimbi-pdf-online-swagger.json`
4. From the `Generate Client` menu select the language of your choice.

<br/>


## Sample code

Sample code, and related files, for the various facilities provided by this service can be found below. It is recommended to copy all samples to your local system using one of the following options:

- **Git:** Use the following command to clone the entire repository to your system. This will download all files associated with this repository, and is most likely overkill, but it is the only easy way to download files using Git. Once downloaded, you can find the examples under the `clients/v1/javascript/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online/`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the JavaScript sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/javascript`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/javascript/samples` folder.

<br/>

An example is provided for each individual REST endpoint. A full overview can be found below.

Sample								| Description
------------------------------------|---------------------------------------------------------
[convert](samples/convert/)					| Convert a single file to PDF or other [supported output format](https://support.muhimbi.com/hc/en-us/articles/228089047-What-file-formats-types-are-supported-for-conversion-).
[convert_LRO](samples/convert_LRO/)			| Convert a single file to PDF or other formats using asynchronous pattern for long running uperations.
[convert_to_pdfa](samples/convert_to_pdfa/)	| Convert a single file to a PDF/A document (or to other PDF profiles).
[export_form_data](samples/export_form_data/)					| Export PDF Forms Data into various formats (.fdf, .xfdf and .xml).
[import_form_data](samples/import_form_data/)					| Import data (.fdf, .xfdf or .xml) into PDF forms.
[merge_to_pdf](samples/merge_to_pdf/)		| Combine multiple files, and URLs, into a single PDF.
[merge_to_pdf (SharePoint)](samples/merge_to_pdf%20%28SharePoint%29/)		| Combine multiple SharePoint files (by path), and URLs, into a single PDF.
[ocr_pdf](samples/ocr_pdf/)					| Convert a scan, fax or other image into a searchable PDF.
[ocr_text](samples/ocr_text/)				| Use OCR to extract text from a scan, fax or other image.
[secure_document](samples/secure_document/)	| Apply security settings, passwords and restrictions to a PDF or and MS Office document.
[secure_pdf](samples/secure_pdf/)			| Apply security settings, passwords and restrictions to a PDF.
[split_pdf](samples/split_pdf/)				| Split a large PDF into smaller PDFs.
**Specialized Conversions**										| 
&nbsp;&nbsp;&nbsp;[convert_cad](samples/convert_cad/)			| Convert a CAD drawing to PDF.
&nbsp;&nbsp;&nbsp;[convert_email](samples/convert_email/)		| Convert an email (.msg or .eml) into PDF.
&nbsp;&nbsp;&nbsp;[convert_excel](samples/convert_excel/)		| Convert a Microsoft Excel document into PDF (or other formats).
&nbsp;&nbsp;&nbsp;[convert_html](samples/convert_html/)			| Convert an HTML fragment, or URL, to PDF.
&nbsp;&nbsp;&nbsp;[convert_infopath](samples/convert_infopath/)	| Convert an InfoPath document into PDF (or other formats).
&nbsp;&nbsp;&nbsp;[convert_pdfa](samples/convert_pdfa/)			| Convert a PDF into a PDF/A document (or other PDF profiles).
&nbsp;&nbsp;&nbsp;[convert_powerpoint](samples/convert_powerpoint/)	| Convert a Microsoft PowerPoint document into PDF (or other formats).
&nbsp;&nbsp;&nbsp;[convert_visio](samples/convert_visio/)		| Convert a Visio document into PDF (or other formats).
&nbsp;&nbsp;&nbsp;[convert_word](samples/convert_word/)			| Convert a Microsoft Word document into PDF (or other formats).
**[watermarking](samples/watermarking/)**	| 
&nbsp;&nbsp;&nbsp;[composite_watermark](samples/watermarking/composite_watermark/)	| Add a number of different watermarks to a PDF or MS Office documents in a single operation.
&nbsp;&nbsp;&nbsp;[ellipse_watermark](samples/watermarking/ellipse_watermark/)		| Add an ellipse based watermark to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[image_watermark](samples/watermarking/image_watermark/)			| Add an image based watermark to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[linear_barcode_watermark](samples/watermarking/linear_barcode_watermark/)	| Add a Linear Barcode to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[line_watermark](samples/watermarking/line_watermark/)			| Add a line based watermark to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[pdf_watermark](samples/watermarking/pdf_watermark/)				| Add a PDF based watermark to a PDF file.
&nbsp;&nbsp;&nbsp;[qr_code_watermark](samples/watermarking/qr_code_watermark/)		| Add a QR Code to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[rectangle_watermark](samples/watermarking/rectangle_watermark/)	| Add a rectangle based watermark to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[rtf_watermark](samples/watermarking/rtf_watermark/)				| Add a rich text (RTF) based watermark to a PDF or MS Office documents.
&nbsp;&nbsp;&nbsp;[text_watermark](samples/watermarking/text_watermark/)			| Add a simple text watermark to a PDF or MS Office documents.

<br/>


## API / Documentation

Although the API is largely self-describing, from time to time it may be easier to consult the full API documentation. An overview of the entire object model can be found [in the Wiki](https://github.com/Muhimbi/PDF-Converter-Services-Online/wiki/API).


<br/>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
