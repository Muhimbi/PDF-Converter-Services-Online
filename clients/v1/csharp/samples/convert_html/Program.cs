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
            try
            {
                // ** Make sure an api key has been entered
                if (API_KEY == string.Empty)
                {
                    Console.WriteLine("[ERROR] Please update the sample code and enter the API Key that came with your subscription.");
                    return;
                }

                // ** Specify the API key associated with your subscription.
                Configuration.Default.AddApiKey("api_key", API_KEY);

                // ** Accept all SSL Certificates, this makes life under mono a lot easier. This line is not needed on Windows
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
                Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri("https://api.muhimbi.com/api");

                // ** We are dealing with the ConvertApi, so instantiate the relevant class
                ConvertApi convertAPI = new ConvertApi();

                // ** Fill out the data for the conversion operation.
                ConvertHtmlData inputData = new ConvertHtmlData(
                    SourceUrlOrHtml: "http://blog.muhimbi.com/2017/01/the-how-and-why-of-ocr-providing.html",   // ** The URL or raw HTML fragment, to convert 
                    PageOrientation: ConvertHtmlData.PageOrientationEnum.Portrait,                              // ** The page orientation of the generated page
                    Username: null,                                                                             // ** Optional user name to authenticate using the specified AuthenticationType
                    Password: null,                                                                             // ** Optional password to authenticate using the specified AuthenticationType
                    AuthenticationType: ConvertHtmlData.AuthenticationTypeEnum.Basic                            // ** The type of authentication to use
                    );

                // ** Carry out the conversion
                Console.WriteLine("[INFO] Converting HTML...");
                var response = convertAPI.ConvertHtml(inputData);

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
