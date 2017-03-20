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

                // ** Was a 'file to split' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to split specified, using default file.");
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

                // ** We are dealing with splitting, so instantiate the relevant class
                SplitApi splitAPI = new SplitApi();

                // ** Read the file we wish to split
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the split operation.
                SplitPdfData inputData = new SplitPdfData(
                    SourceFileName: testFile,                                       // ** Always specify a file name with the correct extension (file must be a PDF file)
                    SourceFileContent: sourceFile,                                  // ** The file content to split
                    FileSplitType: SplitPdfData.FileSplitTypeEnum.ByNumberOfPages,  // ** Based on what criteria do we want to split
                    SplitParameter: 2                                               // ** How many pages per split file?
                    );

                // ** Split the file
                Console.WriteLine("[INFO] Splitting...");
                var response = splitAPI.SplitPdf(inputData);

                // ** If more than 2 files were returned, write the 2nd file, otherwise the first (Hey, it is just an example!)
                if(response.ProcessedFileContents.Count > 1)
                   File.WriteAllBytes(@"result.pdf", response.ProcessedFileContents[1]);
                else
                   File.WriteAllBytes(@"result.pdf", response.ProcessedFileContents[0]);

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
