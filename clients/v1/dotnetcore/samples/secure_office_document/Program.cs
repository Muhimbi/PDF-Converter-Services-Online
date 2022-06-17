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
                    testFile = Directory.GetFiles(".", "*.docx")[0];
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

                // ** We are dealing with security, so instantiate the relevant class
                SecureApi secureAPI = new SecureApi(config);

                // ** Read the file we wish to secure
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the security operation.
                SecureDocumentData inputData = new SecureDocumentData(
                    sourceFileName: testFile,               // ** Always specify a file name with the correct extension (file must be a PDF, DOCX, XLSX or PPTX file)
                    sourceFileContent: sourceFile,          // ** The file content to secure
                    openPassword: "open",                   // ** Optionally specify a password for 'opening' the document
                    ownerPassword: "owner"                  // ** Optionally specify a password lifting edit restrictions
                );

                // ** Secure the file
                Console.WriteLine("[INFO] Securing...");
                var response = secureAPI.SecureDocument(inputData);

                // ** Create file name for the result
                string resultFileName = string.Format("result{0}", Path.GetExtension(testFile));

                // ** Write the results back to the file system
                File.WriteAllBytes(resultFileName, response.ProcessedFileContent);

                Console.WriteLine(string.Format("[INFO] '{0}' written to output folder.", resultFileName));

                // ** On Windows open the generated file in the default application
                try { Process.Start(new ProcessStartInfo() { FileName = resultFileName, UseShellExecute = true }); } catch { /* Ignore silently*/ }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
