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

                // ** Was a 'file to convert' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to convert specified, using default file.");
                    testFile = Directory.GetFiles(".", "*.doc")[0];
                }
                else
                    testFile = args[0];

                // ** Specify the API key associated with your subscription.
                Configuration.Default.AddApiKey("api_key", API_KEY);

                // ** Accept all SSL Certificates, this makes life under mono a lot easier. This line is not needed on Windows
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
                Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri("https://api.muhimbi.com/api");

                // ** We are dealing with the ConvertApi, so instantiate the relevant class
                ConvertApi convertAPI = new ConvertApi();

                // ** Read the file we wish to Convert
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the conversion operation.
                ConvertData inputData = new ConvertData(
                    UseAsyncPattern: true,                              // ** Set to true for large file conversion.
                    SourceFileName: testFile,                           // ** Always specify a file name with the correct extension
                    SourceFileContent: sourceFile,                      // ** The file content to convert
                    OutputFormat: ConvertData.OutputFormatEnum.PDF,     // ** The format to convert the file to (not all combinations are supported)
                    OverrideSettings: null,                             // ** Additional settings, see http://blog.muhimbi.com/2012/09/overriding-default-conversion-settings.html
                    TemplateFileContent: null                           // ** Optional template file, e.g. the InfoPath XSN
                    );

                // ** Carry out the conversion
                Console.WriteLine("[INFO] Converting...");
                var response = convertAPI.Convert(inputData);

                Console.WriteLine("[INFO] Response: {0}", response.ResultCode.ToString());

                if (response.ResultCode.HasValue && response.ResultCode == OperationResponse.ResultCodeEnum.Accepted)
                {
                    string taskId = response.ResultDetails.Replace("task_id=", "");

                    AsyncPatternCallbackEndpointsApi asyncPatternSAPI = new AsyncPatternCallbackEndpointsApi();

                    // ** Loop until we get the result
                    while (response.ResultCode.HasValue && response.ResultCode == OperationResponse.ResultCodeEnum.Accepted)
                    {
                        // ** Check job status every 5 seconds
                        System.Threading.Thread.Sleep(5000);
                        response = asyncPatternSAPI.ActionTask(taskId);
                        Console.WriteLine("[INFO] Checking for Status: {0}", response.ResultCode.ToString());
                    }
                }

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
