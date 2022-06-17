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

                // ** Was a 'file to split' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to split specified, using default file.");
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

                // ** We are dealing with splitting, so instantiate the relevant class
                SplitApi splitAPI = new SplitApi(config);

                // ** Read the file we wish to split
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the split operation.
                SplitPdfData inputData = new SplitPdfData(
                    sourceFileName: testFile,                                       // ** Always specify a file name with the correct extension (file must be a PDF file)
                    sourceFileContent: sourceFile,                                  // ** The file content to split
                    fileSplitBy: SplitPdfData.FileSplitByEnum.NumberOfPages,        // ** Based on what criteria do we want to split
                    splitParameter: 2,                                              // ** How many pages per split file?
                    fileNameTemplate: "split-{0:D3}.pdf"                            // ** Optionally generate output file names using .NET's formatting syntax
                    );                                                              //    When splitting by bookmark then an optional {1} parameter represents the bookmark name

                // ** Split the file
                Console.WriteLine("[INFO] Splitting...");
                var response = splitAPI.SplitPdf(inputData);

                string latest = string.Empty;

                // ** Iterate over al returned files and write them to disk.
                foreach (var f in response.ProcessedFiles)
                {
                    latest = f.ProcessedFileName;
                    File.WriteAllBytes(latest, f.ProcessedFileContent);
                    Console.WriteLine("[INFO] '" + latest + "' written to output folder.");
                }

                // ** On Windows open the last generated file in the default application
                try { Process.Start(new ProcessStartInfo() { FileName = latest, UseShellExecute = true }); } catch { /* Ignore silently*/ }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
