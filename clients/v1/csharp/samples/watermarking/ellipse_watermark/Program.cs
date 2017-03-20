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

                // ** Fill out the data for the security operation.
                EllipseWatermarkData inputData = new EllipseWatermarkData(
                    SourceFileName: testFile,                                       // ** Always specify a file name with the correct extension (file must be a PDF file when watermarking)
                    SourceFileContent: sourceFile,                                  // ** The file content to watermark
                    Position: EllipseWatermarkData.PositionEnum.MiddleCenter,       // ** The location where the watermark will be positioned on the page.
                    X: "0",                                                         // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
                    Y: "0",                                                         // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
                    Width: "144",                                                   // ** The width of the watermark in pts (1/72nd of an inch). For example 144 is 2 inches wide.
                    Height: "144",                                                  // ** The height of the watermark.
                    Layer: EllipseWatermarkData.LayerEnum.Foreground,               // ** Position the watermark in front of the page's content, or behind it
                    Rotation: "0",                                                  // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
                    Opacity: "50",                                                  // ** A value between 0 (completely transparent) and 100 (fully visible)
                    FillColor: "#990000",                                           // ** The fill color of the watermark in #RRGGBB notation.
                    LineColor: "#000000",                                           // ** The (out)line color of the watermark in #RRGGBB notation.
                    LineWidth: "10",                                                // ** The width of the line in pts (1/72nd of an inch). 0 = hairline, -1 = no line
                    StartPage: 0,                                                   // ** The first page in the document the watermark applies to.
                    EndPage: 0,                                                     // ** The last page in the document the watermark applies to.
                    PageInterval: 1,                                                // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
                    PageOrientation: EllipseWatermarkData.PageOrientationEnum.Both  // ** The page orientation the watermark applies to. 
                    );

                // ** Watermark the file
                Console.WriteLine("[INFO] Watermarking...");
                var response = watermarkAPI.EllipseWatermark(inputData);

                // ** Write the results back to the file system
                File.WriteAllBytes(@"result.pdf", response.ProcessedFileContent);

                Console.WriteLine("[INFO] 'result.pdf' written to output folder.");

                // ** On Windows open the generated file in the system PDF viewer
                Process.Start(@"result.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
