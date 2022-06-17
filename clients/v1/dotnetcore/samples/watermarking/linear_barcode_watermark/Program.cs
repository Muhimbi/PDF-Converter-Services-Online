using Muhimbi.PDF.Online.Client.Api;
using Muhimbi.PDF.Online.Client.Client;
using Muhimbi.PDF.Online.Client.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace sample
{
    class Program
    {
        // !!!! ENTER YOUR API KEY HERE !!!!
        static string API_KEY = "";

        static void Main(string[] args)
        {
            string testFile = null;

            try
            {
                // ** Make sure an api key has been entered
                if (API_KEY == string.Empty)
                {
                    Console.WriteLine("[ERROR] Please update the sample code and enter the API Key that came with your subscription.");
                    return;
                }

                // ** Was a 'file to watermark' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to watermark specified, using default file.");
                    testFile = Directory.GetFiles(".", "*.pdf")[0];
                }
                else
                    testFile = args[0];

                // ** Accept all SSL Certificates, this makes life under mono a lot easier. This line is not needed on Windows
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // ** Create config
                Configuration config = new Configuration();
                // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
                config.BasePath = "https://api.muhimbi.com/api";
                // ** Specify the API key associated with your subscription.
                config.ApiKey.Add("api_key", API_KEY);

                // ** We are dealing with watermarking, so instantiate the relevant class
                WatermarkApi watermarkAPI = new WatermarkApi(config);

                // ** Read the file we wish to watermark
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the watermark operation.
                LinearBarcodeWatermarkData inputData = new LinearBarcodeWatermarkData(
                    sourceFileName: testFile,                                       // ** Always specify a file name with the correct extension 
                                                                                    // ** (file must be a PDF, DOCX, XXLSX or PPTX file when watermarking)
                    sourceFileContent: sourceFile,                                  // ** The file content to watermark
                    content: "123456789012",                                        // ** Data to embed in the barcode
                    barcodeType: LinearBarcodeWatermarkData.BarcodeTypeEnum.UPCA,   // ** The barcode Version
                    omitStartStopSymbols: LinearBarcodeWatermarkData.OmitStartStopSymbolsEnum.False,    // ** In some cases, stop and start symbols are not needed
                    disableCheckdigit: LinearBarcodeWatermarkData.DisableCheckdigitEnum.False,          // ** Set whether you wish to omit check digits
                    showCheckdigit: LinearBarcodeWatermarkData.ShowCheckdigitEnum.True,                 // ** Set whether you wish to show the check digit or not
                    labelPlacement: LinearBarcodeWatermarkData.LabelPlacementEnum.BottomCenter,         // ** The location of the label for the barcode
                    position: LinearBarcodeWatermarkData.PositionEnum.MiddleCenter, // ** The location where the watermark will be positioned on the page.
                    x: "0",                                                         // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
                    y: "0",                                                         // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
                    width: "300",                                                   // ** The width of the watermark in pts (1/72nd of an inch). For example 144 is 2 inches wide.
                    height: "200",                                                  // ** The height of the watermark.
                    layer: LinearBarcodeWatermarkData.LayerEnum.Foreground,         // ** Position the watermark in front of the page's content, or behind it
                    rotation: "0",                                                  // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
                    opacity: "50",                                                  // ** A value between 0 (completely transparent) and 100 (fully visible)
                    fillColor: null,                                                // ** The fill color of the watermark in #RRGGBB notation.
                    lineColor: null,                                                // ** The line color of the watermark in #RRGGBB notation.
                    startPage: 0,                                                   // ** The first page in the document the watermark applies to.
                    endPage: 0,                                                     // ** The last page in the document the watermark applies to.
                    pageInterval: 1,                                                // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
                    pageOrientation: LinearBarcodeWatermarkData.PageOrientationEnum.Both, // ** The page orientation the watermark applies to. 
                    printOnly: LinearBarcodeWatermarkData.PrintOnlyEnum.False       // ** If set to true then watermarks only appear during print
                    );

                // ** Watermark the file
                Console.WriteLine("[INFO] Watermarking...");
                var response = watermarkAPI.LinearBarcodeWatermark(inputData);

                // ** Write the results back to the file system
                File.WriteAllBytes(@"result.pdf", response.ProcessedFileContent);

                Console.WriteLine("[INFO] 'result.pdf' written to output folder.");

                // ** On Windows open the generated file in the default application
                try { Process.Start(new ProcessStartInfo() { FileName = "result.pdf", UseShellExecute = true }); } catch { /* Ignore silently*/ }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
