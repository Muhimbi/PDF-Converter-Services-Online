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

                // ** Was a 'file to OCR' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to OCR specified, using default file.");
                    testFile = Directory.GetFiles(".", "*.tif")[0];
                }
                else
                    testFile = args[0];

                // ** Specify the API key associated with your subscription.
                Configuration.Default.AddApiKey("api_key", API_KEY);

                // ** Accept all SSL Certificates, this makes life under mono a lot easier. This line is not needed on Windows
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
                Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri("https://api.muhimbi.com/api");

                // ** We are dealing with OCR, so instantiate the relevant class
                OCRApi ocrApi = new OCRApi();

                // ** Read the file we wish to OCR
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the OCR operation.
                OcrTextData inputData = new OcrTextData(
                    SourceFileName: testFile,                                       // ** The name of the file to OCR. Always include the correct extension
                    SourceFileContent: sourceFile,                                  // ** The content of the file to OCR
                    Language: OcrTextData.LanguageEnum.English,                     // ** The document's primary language
                    Performance: OcrTextData.PerformanceEnum.Slowbutaccurate,       // ** Unless you have a good reason not to, always use the 'Slow' option.
                    CharactersOption: OcrTextData.CharactersOptionEnum.Blacklist,   // ** Any characters to black list or white list (e.g. 1234567890 to deal with numerical data)
                    Characters: "|",                                                // ** In this example we blacklist the '|' (pipe) as it looks similar to l (L) 1 (one) and I (capital I)
                    Paginate: false,                                                // ** Only 'paginate' when your documents have images that span multiple pages.
                    X: "36",                                                        // ** By default the entire page is OCRed, optionally specify an area (in pt., 1/72nd of an inch)
                    Y: "72",
                    Width: "400",
                    Height: "30",
                    PageNumber: "1"
                    );

                // ** Carry out the OCR operation
                Console.WriteLine("[INFO] Running OCR...");
                var response =  ocrApi.OcrText(inputData);

                // ** Writing the recognised text to the console
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("[INFO] Extraced text: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(response.OutText);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
