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

                // ** Was a 'file to merge' specified on the command line?
                if (args.Count() == 0)
                {
                    Console.WriteLine("[INFO] No file to merge specified, using default file.");
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

                // ** We are dealing with merging, so instantiate the relevant class
                MergeApi mergeApi = new MergeApi();

                // ** Read the file we wish to Merge
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the merge operation.
                MergeToPdfData inputData = new MergeToPdfData(
                    SourceFileName1: testFile + ";true;" + testFile,                                            // ** The name of the file to merge, always include the correct extension. 
                                                                                                                //    Optionally add ';true' to auto generate PDF bookmarks based on document structure, 
                                                                                                                //    optionally followed by a ';' and the PDF bookmark name of the document.
                    SourceFileContent1: sourceFile,                                                             // ** Content of the file to merge.
                    SourceFileName2: "test.html;true;Some HTML content",                                        // ** The same again, but as we are merging in HTML content, use a name with '.html' extension.
                    SourceFileContent2: System.Text.Encoding.Unicode.GetBytes("<h1>Merged HTML Content</h1>"),  // ** HTML or URL to convert and merge. 
                    SourceFileName3: testFile + ";true;" + testFile + " (again).",                              // ** The same again for the 3rd file.
                    SourceFileContent3: sourceFile,                                                             // ** Content of the 3rd file to merge.
                    DocumentStartPage: MergeToPdfData.DocumentStartPageEnum.Nextpage                            // ** On what page should each merged document start (important for double sided docs and printing).
                );

                // ** Carry out the merge operation
                Console.WriteLine("[INFO] Merging...");
                var response = mergeApi.MergeToPdf(inputData);

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
