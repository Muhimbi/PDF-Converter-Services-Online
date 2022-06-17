# Muhimbi PDF Converter Services Online
<br>

## About

The [*Muhimbi PDF Converter Service Online*](https://support.muhimbi.com/hc/en-us/articles/115002813708-About-the-PDF-Converter-Services-Online) is a REST based service that makes it easy to add *document conversion, merging, watermarking, securing* and *optical character recognition (OCR)* to most programming languages, operating systems and development platforms.

This service is also available as a traditional 'on-premise' solution, for more details see [this separate GitHub repository](https://github.com/Muhimbi/PDF-Converter-Services). A separate [SharePoint Online version](http://www.muhimbi-online.com/) is available as well.

Key features:
- Hosted platform, nothing to install.
- Convert a wide variety of file types including *Word, Excel, PowerPoint, InfoPath, AutoCAD, Visio, EML, MSG, HTML, TIFF, PNG, JPG* to PDF [and other formats](https://support.muhimbi.com/hc/en-us/articles/228089047-What-file-formats-types-are-supported-for-conversion-).
- Merge multiple files and URLs into a single PDF file.
- Apply watermarks including *rich text, images, PDFs, QR Codes, page numbers, lines, circles* etc.
- Secure PDF files, apply encryption and PDF restrictions to prevent such operations as printing and content copying.
- Split a PDF into multiple files.
- Use OCR to convert scans, faxes and other images to fully searchable PDF files.
- Supports PDF/A output for long term archiving and compliance with guidelines set by regulatory bodies.
- High fidelity output.
- [Swagger](http://www.swagger.io) based API definition.
- Sample files and pre-generated client code for *PHP, Ruby, Python, Java, C#, Curl, JavaScript* and *SharePoint*.
- Support for [Microsoft Flow, Azure Logic Apps, and PowerApps](https://support.muhimbi.com/hc/en-us/articles/115005900168-Microsoft-Flow-Logic-Apps-PowerApps-Tutorials-and-Blog-posts).
- Authenticate using API Key or oAuth.
- Backed by a professional and high quality [support desk](http://www.muhimbi-online.com/Contact). 


<br>

## Getting started

It couldn't be easier to get going. Please [follow these instructions](https://support.muhimbi.com/hc/en-us/articles/115002816048) and activate the subscription by clicking the link in the confirmation email.

Once activated, follow the instructions below for the language of your choice. For each listed language, detailed instructions are included for generating libraries from scratch. For languages that are not explicitly listed below, use [editor.swagger.io](http://editor.swagger.io).

- [C# Libraries and sample code](clients/v1/csharp/)
- [C# .Net Core Libraries and sample code](clients/v1/dotnetcore/)
- [Java Libraries and sample code](clients/v1/java/)
- [JavaScript Libraries and sample code](clients/v1/javascript/)
- [PHP Libraries and sample code](clients/v1/php/)
- [Use Swagger to generate clients](swagger/)
<!--
- [Curl sample code](clients/v1/curl/)
- [Generic JSON sample code](clients/v1/json/)
- [Python Libraries and sample code](clients/v1/python/)
- [Ruby Libraries and sample code](clients/v1/ruby/)
- [SharePoint Libraries and sample code](clients/v1/sharepoint/)
-->

Any questions? [Drop us a line](http://www.muhimbi-online.com/Contact), we love to help.


<br>

## Core concepts
 
To make life as easy as possible for developers who use this service, we have made sure that all operations follow the same model and core concepts.

The various fields and operations are largely self-describing, the facilities shared between most operations are described below.

<br>

### Output variables

Succesfull operations typically return an object containing the following fields:

- **processed_file_content:** The most important field shared by almost all actions as it contains the result of the operation. Depending on the actual operation, this typically contains a converted PDF file, a watermarked file, the results of a merge operation etc. This field can then be fed into other operations, written to disk, attached to an email or returned to the end-user in some other fashion. 

  Please note that this data is BASE64 encoded and will need to be decoded using the appropriate facilities in the language of your choice. For details see the [sample code](clients/v1/).

- **base_file_name:** This utility variable contains the name of the input file without extension. Most languages have no use for this field as it is easy to generate using built-in string manipulation facilities. However, for platforms that do not come with these facilities, e.g. Microsoft Flow, this field can be extremely useful when it comes to generating the name of the output file.

- **result_code**: The status of the operation, typically `Success` in case all went well. For details see the section about Error handling below.

- **result_details**: Additional details that can be used in combination with the `result_code`. For more information see the Error handling section below.

<br>

### Error handling

Dealing with errors in an appropriate manner is always an important topic. 
This service supports two ways of dealing with errors, either by throwing an exception or manually testing the status of the operation.

Each operation accepts the `fail_on_error` field. Its value can be set either to 

- **True (default)**: When set, an exception is thrown when an error occurs.  

- **False:** The operation always completes without an exception. Once the operation has finished, the status can be found in the `result_code` field.

<br>

The Result code will be set to one of the following values:

- **Success:** The operation succeeded without error.

- **ProcessingError:** An unexpected error has occurred. E.g. the input file is corrupt or there are connectivity problems.

- **SubscriptionNotFound:** Your subscription was not found.

- **SubscriptionExpired:** Your subscription was found, but has expired.

- **ActivationPending:** Your subscription was found, but the activation link sent by email was not clicked.

- **TrialExpired:** Your trial subscription has expired.

- **OperationSizeExceeded:** The maximum operation size for your subscription level has been exceeded.

- **OperationsExceeded:** The maximum number of operations for your subscription level has been exceeded.

- **InputFileTypeNotSupported:** The specified input file type is either not supported by the PDF Converter or not supported by your subscription level.

- **OutputFileTypeNotSupported:** The specified output file type is either not supported by the PDF Converter or not supported by your subscription level.

- **OperationNotSupported:** The specified operation is not supported by your subscription level.

- **Accepted:** The operation was accepted, and is running asynchronously. This is typically used in combination with the *Long Running Operation* pattern. For detail see below.

- **AccessDenied:** The specified API_KEY or user details are incorrect.

<br>

### Logging

When it comes to troubleshooting, especially when you are dealing with our [friendly support desk](http://www.muhimbi-online.com/Contact), it is essential that we can differentiate between the various operations that you are executing. For this reason it is recommended to always specify the `source file name` field with the actual, or at least a unique, file name.

This may appear obvious for actions such as *Convert Document*, which require this field to be filled out. However, for other actions - specifically the various watermarking related ones - this field is optional. 

Please make it a habit to populate this field with sensible data.

<br>

### Watermarking

All watermarking facilities follow a similar pattern as well. Some fields are obviously unique to each action, but most share the following:

- **position:** The location where the watermark will be positioned on the page.

- **width:** The width of the watermark in pts (1/72nd of an inch). For example 144 is 2 inches wide.

- **height:** The height of the watermark.

- **x:** The x-coordinate of the watermark. Only used when *Position* is set to *Absolute*.

- **y:** The y-coordinate of the watermark. Only used when *Position* is set to *Absolute*.

- **layer:** Position the watermark in front of the page's content, or behind it. This is particularly important when dealing with images or PowerPoint content which always cover any content positioned in the background (So set it to *Foreground* for those file types)

- **rotation:** Rotate the watermark, specify a value in degrees. Negative values are accepted.

- **opacity:** A value between 0 (completely transparent) and 100 (fully visible)

- **start_page:** The first page in the document the watermark applies to.

- **end_page:** The last page in the document the watermark applies to.

- **page_interval:** Which pages to apply the watermark on (1 = every page, 2 = every other page etc). This allows such functionality as having different watermarks on odd and even pages.

- **page_orientation:** The page orientation the watermark applies to. Please note that this does not change the orientation of the page, instead it allows different watermarks to be defined for landscape and portrait pages.

<br>

### The Long Running Operation (LRO) Pattern 

Unlike many other REST based services, where typical operations take less than a second to complete, the nature of the work carried out by the *PDF Converter Services Online* means that operations in some cases may take minutes to run, especially for large merge and OCR operations. 

Although the default behaviour is for operations to run synchronously (the request doesn't complete until the operation has finished), for operations that you expect to take 60 seconds or more you should consider using the *Long Running Operation* pattern. A generic overview of this pattern [can be found here](http://farazdagi.com/blog/2014/rest-long-running-jobs/), samples are available [for the various languages](clients/v1/).

Please note that the provided client (wrapper) libraries often contain `async` and related methods, these do not utilise the LRO pattern.



<br>

If you have any questions regarding this topic, or any other topic, then please contact our [support desk](http://www.muhimbi-online.com/Contact), we are here to help.

<br>
