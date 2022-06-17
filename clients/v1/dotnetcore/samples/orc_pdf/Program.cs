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

                // ** Was a 'file to OCR' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to OCR specified, using default file.");
                    testFile = Directory.GetFiles(".", "*.tif")[0];
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

                // ** We are dealing with OCR, so instantiate the relevant class
                OCRApi ocrApi = new OCRApi(config);

                // ** Read the file we wish to OCR
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the OCR operation.
                OcrPdfData inputData = new OcrPdfData(
                    sourceFileName: testFile,                                   // ** The name of the file to OCR. Always include the correct extension
                    sourceFileContent: sourceFile,                              // ** The content of the file to OCR
                    language: OcrPdfData.LanguageEnum.English,                  // ** The document's primary language
                    performance: OcrPdfData.PerformanceEnum.SlowButAccurate,    // ** Unless you have a good reason not to, always use the 'Slow' option.
                    charactersOption: OcrPdfData.CharactersOptionEnum.None,     // ** Any characters to black list or white list (e.g. 1234567890 to deal with numerical data)
                    characters: null,                                           // ** The characters to black or white list.
                    paginate: false,                                            // ** Only 'paginate' when your documents have images that span multiple pages.
                    regions: null                                               // ** We want to OCR the entire document, not just specific areas.
                    );

                // ** Carry out the OCR operation
                Console.WriteLine("[INFO] Running OCR...");
                var response = ocrApi.OcrPdf(inputData);

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
