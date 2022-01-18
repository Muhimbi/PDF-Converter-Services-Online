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
                LineWatermarkData inputData = new LineWatermarkData(
                    SourceFileName: testFile,                                       // ** Always specify a file name with the correct extension (file must be a PDF file when watermarking)
                    SourceFileContent: sourceFile,                                  // ** The file content to watermark
                    Position: LineWatermarkData.PositionEnum.MiddleCenter,          // ** The location where the watermark will be positioned on the page.
                    X: "72",                                                        // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
                    Y: "72",                                                        // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
                    EndX: "523",                                                    // ** The end x-coordinate of the line in pts (1/72nd of an inch). 
                    EndY: "770",                                                    // ** The end y-coordinate of the line in pts (1/72nd of an inch). 
                    Layer: LineWatermarkData.LayerEnum.Foreground,                  // ** Position the watermark in front of the page's content, or behind it
                    Rotation: "0",                                                  // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
                    Opacity: "50",                                                  // ** A value between 0 (completely transparent) and 100 (fully visible)
                    LineColor: "#000000",                                           // ** The (out)line color of the watermark in #RRGGBB notation.
                    LineWidth: "10",                                                // ** The width of the line in pts (1/72nd of an inch). 0 = hairline, -1 = no line
                    StartPage: 0,                                                   // ** The first page in the document the watermark applies to.
                    EndPage: 0,                                                     // ** The last page in the document the watermark applies to.
                    PageInterval: 1,                                                // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
                    PageOrientation: LineWatermarkData.PageOrientationEnum.Both,    // ** The page orientation the watermark applies to. 
                    PrintOnly: LineWatermarkData.PrintOnlyEnum.False                // ** If set to true then watermarks only appear during print
                    );

                // ** Watermark the file
                Console.WriteLine("[INFO] Watermarking...");
                var response = watermarkAPI.LineWatermark(inputData);

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
