﻿using Muhimbi.PDF.Online.Client.Api;
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
                LineWatermarkData inputData = new LineWatermarkData(
                    sourceFileName: testFile,                                       // ** Always specify a file name with the correct extension (file must be a PDF file when watermarking)
                    sourceFileContent: sourceFile,                                  // ** The file content to watermark
                    position: LineWatermarkData.PositionEnum.MiddleCenter,          // ** The location where the watermark will be positioned on the page.
                    x: "72",                                                        // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
                    y: "72",                                                        // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
                    endX: "523",                                                    // ** The end x-coordinate of the line in pts (1/72nd of an inch). 
                    endY: "770",                                                    // ** The end y-coordinate of the line in pts (1/72nd of an inch). 
                    layer: LineWatermarkData.LayerEnum.Foreground,                  // ** Position the watermark in front of the page's content, or behind it
                    rotation: "0",                                                  // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
                    opacity: "50",                                                  // ** A value between 0 (completely transparent) and 100 (fully visible)
                    lineColor: "#000000",                                           // ** The (out)line color of the watermark in #RRGGBB notation.
                    lineWidth: "10",                                                // ** The width of the line in pts (1/72nd of an inch). 0 = hairline, -1 = no line
                    startPage: 0,                                                   // ** The first page in the document the watermark applies to.
                    endPage: 0,                                                     // ** The last page in the document the watermark applies to.
                    pageInterval: 1,                                                // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
                    pageOrientation: LineWatermarkData.PageOrientationEnum.Both,    // ** The page orientation the watermark applies to. 
                    printOnly: LineWatermarkData.PrintOnlyEnum.False                // ** If set to true then watermarks only appear during print
                    );

                // ** Watermark the file
                Console.WriteLine("[INFO] Watermarking...");
                var response = watermarkAPI.LineWatermark(inputData);

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
