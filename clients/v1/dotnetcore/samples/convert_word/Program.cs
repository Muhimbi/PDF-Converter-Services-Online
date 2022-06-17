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

                // ** Was a 'file to convert' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to convert specified, using default file.");
                    testFile = Directory.GetFiles(".", "*.doc")[0];
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

                // ** We are dealing with the ConvertApi, so instantiate the relevant class
                ConvertApi convertAPI = new ConvertApi(config);

                // ** Read the file we wish to Convert
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the conversion operation.
                ConvertWordData inputData = new ConvertWordData(
                    sourceFileName: testFile,                            // ** Always specify a file name with the correct extension
                    sourceFileContent: sourceFile,                       // ** The file content to convert
                    outputFormat: ConvertWordData.OutputFormatEnum.PDF,  // ** The format to convert the file to (not all combinations are supported)
                    overrideSettings: null                               // ** Additional settings, see http://blog.muhimbi.com/2012/09/overriding-default-conversion-settings.html
                    );

                // ** Carry out the conversion
                Console.WriteLine("[INFO] Converting...");
                var response = convertAPI.ConvertWord(inputData);

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
