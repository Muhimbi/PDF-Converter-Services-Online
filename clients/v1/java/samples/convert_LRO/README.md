# Sample - Convert file to PDF using asynchronous pattern in Java

The Java sample provided in this section uses the [*Muhimbi PDF Converter Services Online*](https://github.com/Muhimbi/PDF-Converter-Services-Online) to convert a file to PDF (or other formats). It is using the asynchronous pattern for long running operations (LRO).
Additional sample code to *convert, merge, watermark, secure* and *OCR* files [can be found here](../).

Full details about the `convert` method, fields and properties can be found [in the Wiki](https://github.com/Muhimbi/PDF-Converter-Services-Online/wiki/API:-convert).

<br>

## Downloading the sample

Download the sample code using a method of your choice. Some examples are provided below.

- **Git:** Clone the entire repository to your system. You can find the examples under the `clients/v1/java/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the Java client and sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/java`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/java/samples` folder.

<br>

## Use a valid (or trial) subscription

In order to successfully execute the sample code, make sure you have a valid subscription, either a full one or [the 30 day trial](https://support.muhimbi.com/hc/en-us/articles/115002816048-Getting-started-with-the-PDF-Converter-Services-Online).

:exclamation: Each subscription comes with a unique `api_key`. Before executing the sample, please insert your key in the code. :exclamation:


<br>

## Building and running the sample

Make sure [the prerequisites](https://github.com/Muhimbi/PDF-Converter-Services-Online/tree/master/clients/v1/java#prerequisites) are in place. The sample code expects the client libraries to be present under `../../client/lib`.

Scripts are provided to build and execute the sample code:
- **Linux:** `build_and_run.sh`
- **Windows:** `build_and_run.bat`

Once the sample has completed the file conversion process, the results are written to `result.pdf`. Open it in your favourite PDF reader to have a look.

<br>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
