using Muhimbi.PDF.Online.Client.Api;
using Muhimbi.PDF.Online.Client.Client;
using Muhimbi.PDF.Online.Client.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

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

                // ** We are dealing with merging, so instantiate the relevant class
                MergeApi mergeApi = new MergeApi(config);

                // ** Read the file we wish to Merge
                byte[] sourceFile = File.ReadAllBytes(testFile);

                // ** Fill out the data for the merge operation.
                MergeToPdfData inputData = new MergeToPdfData(
                    sourceFileName1: testFile + ";true;" + testFile,                                            // ** The name of the file to merge, always include the correct extension. 
                                                                                                                //    Optionally add ';true' to auto generate PDF bookmarks based on document structure, 
                                                                                                                //    optionally followed by a ';' and the PDF bookmark name of the document.
                    sourceFileContent1: sourceFile,                                                             // ** Content of the file to merge.
                    sourceFileName2: "test.html;true;Some HTML content",                                        // ** The same again, but as we are merging in HTML content, use a name with '.html' extension.
                    sourceFileContent2: GetUnicodeBytesWithBom("<h1>Merged <i>HTML</i> Content</h1>"),          // ** HTML or URL to convert and merge. 
                    sourceFileName3: testFile + ";true;" + testFile + " (again).",                              // ** The same again for the 3rd file.
                    sourceFileContent3: sourceFile,                                                             // ** Content of the 3rd file to merge.
                    documentStartPage: MergeToPdfData.DocumentStartPageEnum.NextPage                            // ** On what page should each merged document start (important for double sided docs and printing).
                );

                // ** Carry out the merge operation
                Console.WriteLine("[INFO] Merging...");
                var response = mergeApi.MergeToPdf(inputData);

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

        /// <summary>
        /// Helper function to get the text as a byte array and add the 'Unicode Byte Order Mark'
        /// See https://www.w3.org/International/questions/qa-byte-order-mark. 
        /// </summary>
        protected static byte[] GetUnicodeBytesWithBom(string text)
        {
            // Use BOM when encoding
            Encoding encodingWithBom = new UnicodeEncoding(false, true);

            // Concatenate BOM bytes with content bytes
            byte[] bom = encodingWithBom.GetPreamble();
            byte[] content = encodingWithBom.GetBytes(text);
            byte[] bytes = new byte[bom.Length + content.Length];
            Buffer.BlockCopy(bom, 0, bytes, 0, bom.Length);
            Buffer.BlockCopy(content, 0, bytes, bom.Length, content.Length);

            return bytes;
        }
    }
}
