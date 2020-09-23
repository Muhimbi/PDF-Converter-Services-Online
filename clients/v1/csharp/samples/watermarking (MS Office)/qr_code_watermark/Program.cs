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
                    testFile = Directory.GetFiles(".", "*.xlsx")[0];
                }
                else
                    testFile = args[0];

                // ** Specify the API key associated with your subscription.
                Configuration.Default.AddApiKey("api_key", API_KEY);

                // ** Accept all SSL Certificates, this makes life under mono a lot easier. This line is not needed on Windows
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
                Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri("https://api.muhimbi.com/api");

                // ** We are dealing with watermarking, so instantiate the relevant class
                WatermarkApi watermarkAPI = new WatermarkApi();
                
                // ** Read the file we wish to watermark
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the watermark operation.
                QrCodeWatermarkData inputData = new QrCodeWatermarkData(
                    SourceFileName: testFile,                                       // ** Always specify a file name with the correct extension (file must be a PDF, DOCX, XLSX or PPTX file)
                    SourceFileContent: sourceFile,                                  // ** The file content to watermark
                    Content: "Hello World",                                         // ** Data to embed in the QR Code
                    Version: QrCodeWatermarkData.VersionEnum.Auto,                  // ** The QR Version
                    InputMode: QrCodeWatermarkData.InputModeEnum.Binary,            // ** The type of content
                    ErrorCorrectionLevel: QrCodeWatermarkData.ErrorCorrectionLevelEnum.Medium,  // ** The level of error correction to embed in the generated qr-code.
                    Position: QrCodeWatermarkData.PositionEnum.MiddleCenter,        // ** The location where the watermark will be positioned on the page.
                    X: "0",                                                         // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
                    Y: "0",                                                         // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
                    Width: "144",                                                   // ** The width of the watermark in pts (1/72nd of an inch). For example 144 is 2 inches wide.
                    Height: "144",                                                  // ** The height of the watermark.
                    Layer: QrCodeWatermarkData.LayerEnum.Foreground,                // ** Position the watermark in front of the page's content, or behind it
                    Rotation: "0",                                                  // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
                    Opacity: "50",                                                  // ** A value between 0 (completely transparent) and 100 (fully visible)
                    FillColor: null,                                                // ** The fill color of the watermark in #RRGGBB notation.
                    LineColor: null,                                                // ** The (out)line color of the watermark in #RRGGBB notation.
                    StartPage: 0,                                                   // ** The first page in the document the watermark applies to.
                    EndPage: 0,                                                     // ** The last page in the document the watermark applies to.
                    PageInterval: 1,                                                // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
                    PageOrientation: QrCodeWatermarkData.PageOrientationEnum.Both   // ** The page orientation the watermark applies to. 
                    );

                // ** Watermark the file
                Console.WriteLine("[INFO] Watermarking...");
                var response = watermarkAPI.QrCodeWatermark(inputData);

                // ** Create file name for the result
                string resultFileName = string.Format("result{0}", Path.GetExtension(testFile));

                // ** Write the results back to the file system
                File.WriteAllBytes(resultFileName, response.ProcessedFileContent);

                Console.WriteLine(string.Format("[INFO] '{0}' written to output folder.", resultFileName));

                // ** On Windows open the generated file in the default application
                Process.Start(resultFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
