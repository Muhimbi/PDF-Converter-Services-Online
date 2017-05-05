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

                // ** Was a 'file to secure' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to secure specified, using default file.");
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

                // ** We are dealing with security, so instantiate the relevant class
                SecureApi secureAPI = new SecureApi();

                // ** Read the file we wish to secure
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the security operation.
                SecurePdfData inputData = new SecurePdfData(
                    SourceFileName: testFile,               // ** Always specify a file name with the correct extension (file must be a PDF file)
                    SourceFileContent: sourceFile,          // ** The file content to secure
                    OpenPassword: "open",                   // ** Optionally specify a password for 'opening' the document
                    OwnerPassword: "owner",                 // ** When applying security restrictions (e.g. 'Print|ContentCopy'), always specify an 'owner password', 
                                                            //    in this example the password is set to 'owner'
                    SecurityOptions: "Print|ContentCopy"    // ** Optionally specify the PDF security restrictions to apply, a combination of 
                                                            //    'Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly''
                );

                // ** Secure the file
                Console.WriteLine("[INFO] Securing...");
                var response = secureAPI.SecurePdf(inputData);

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
