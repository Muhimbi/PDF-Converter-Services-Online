using Muhimbi.PDF.Online.Client.Api;
using Muhimbi.PDF.Online.Client.Client;
using Muhimbi.PDF.Online.Client.Model;
using System;
using System.Net;

namespace sample
{
    class Program
    {
        // !!!! ENTER YOUR API KEY HERE !!!!
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

                // ** Accept all SSL Certificates, this makes life under mono a lot easier. This line is not needed on Windows
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // ** Create config
                Configuration config = new Configuration();
                // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
                config.BasePath = "https://api.muhimbi.com/api";
                // ** Specify the API key associated with your subscription.
                config.ApiKey.Add("api_key", API_KEY);

                // ** We are dealing with merging, so instantiate the relevant class
                MergeApi mergeApi = new MergeApi(config);

                // ** Specify details about the SharePoint environment, and the files to merge
                SharepointFile spf = new SharepointFile(
                    siteUrl: "https://acme.sharepoint.com/sites/SomeSite",                  // ** URL to the site collection, e.g. https://acme.sharepoint.com/sites/SomeSite
                    sourceFileUrl:                                                          // ** List of files to merge including optional ';' separated parameters.
                                                                                            // **   filepath;generate bookmarks (optional);name of bookmark (Optional)
                        @"Shared Documents\SomeFolder\SomeFile.docx;true;My Bookmark
                          Shared Documents\SomeFolder\SomeFile.xlsx;false",
                    destinationFileUrl: @"Shared Documents\MergedFile.pdf",                 // ** Path and filename to write the results to. See http://goo.gl/YqKXM
                    username: null,                                                         // ** If the Muhimbi App is installed on the site collection then there is no
                    password: null                                                          // ** no need to specify credentials. If App is not present, specify login details.
                    );

                // ** Fill out the data for the merge operation.
                MergeToPdfData inputData = new MergeToPdfData(
                    sharepointFile: spf,                                                    // ** Details for the merge operation, see above.
                    sharepointFieldName: "Title",                                           // ** SharePoint field name to use to automatically create a bookmark for each file
                    documentStartPage: MergeToPdfData.DocumentStartPageEnum.NextPage,       // ** On what page should each merged document start (important for double sided docs and printing).
                    sourceFileName1: "",                                                    // ** Mandatory field, so specify empty data
                    sourceFileContent1: new byte[] { 0 },                                     // ** Mandatory field, so specify empty data
                    sourceFileName2: "",                                                    // ** Mandatory field, so specify empty data
                    sourceFileContent2: new byte[] { 0 }                                      // ** Mandatory field, so specify empty data
                );

                // ** Carry out the merge operation
                Console.WriteLine("[INFO] Merging...");
                var response = mergeApi.MergeToPdf(inputData);

                Console.WriteLine("[INFO] Operation completed - " + response.ResultCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
