# Sample - Apply a PDF based watermark using C#

The C# sample provided in this section uses the [*Muhimbi PDF Converter Services Online*](https://github.com/Muhimbi/PDF-Converter-Services-Online) to apply an existing PDF file as a watermark to another PDF file. 

Additional sample code to *convert, merge, watermark, secure* and *OCR* files [can be found here](../../).

Full details about the `pdf_watermark` method, fields and properties can be found [in the Wiki](https://github.com/Muhimbi/PDF-Converter-Services-Online/wiki/API:-pdf_watermark).

<br>

## Downloading the sample

Download the sample code using a method of your choice. Some examples are provided below.

- **Git:** Clone the entire repository to your system. You can find the examples under the `clients/v1/csharp/samples` folder.<br>
   
     `git clone https://github.com/Muhimbi/PDF-Converter-Services-Online`

- **SVN:** A common trick to download only part of a Git repository  is to use `svn`. Download only the C# client and sample code using the following command.<br>

     `svn export https://github.com/Muhimbi/PDF-Converter-Services-Online/trunk/clients/v1/csharp`

- **ZIP:** [Download](https://github.com/Muhimbi/PDF-Converter-Services-Online/zipball/master/) a ZIP archive of the entire repository. Once downloaded, you can find the examples under the `clients/v1/csharp/samples` folder.

<br>

## Use a valid (or trial) subscription

In order to successfully execute the sample code, make sure you have a valid subscription, either a full one or [the 30 day trial](https://support.muhimbi.com/hc/en-us/articles/115002816048-Getting-started-with-the-PDF-Converter-Services-Online).

:exclamation: Each subscription comes with a unique `api_key`. Before executing the sample, please insert your key in the code. :exclamation:


<br>

## Building and running the sample

Make sure [the prerequisites](https://github.com/Muhimbi/PDF-Converter-Services-Online/tree/master/clients/v1/csharp#prerequisites) are in place. The sample code expects the client libraries to be present under `../../client/bin`.

There are many ways to compile C# code. Use one of the following:

- **msbuild:** Execute `build_and_run.bat` to compile the code (using the stock .NET 4 compiler) and run the example. To use a different version of `msbuild`, change the path in the batch file.

- **xbuild (mono):** Execute `build_and_run.sh` on a system with Mono 3 or later installed. This will compile the sample and run it.

- **Visual Studio:** Open `sample.csproj` in Visual Studio and use CTRL-F5 to build and execute the sample.

Once the sample has finished executing, it will attempt to launch the generated PDF in the system's default PDF Viewer. If this is not configured (or not possible under Linux) then the generated PDF file can be found in the `bin/Debug` folder.

<br>

If you have any questions or comments then please contact [our friendly support desk](http://www.muhimbi-online.com/contact).
