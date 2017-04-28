import com.muhimbi.online.client.ApiClient;
import com.muhimbi.online.client.ApiException;
import com.muhimbi.online.client.Configuration;
import com.muhimbi.online.client.auth.*;
import com.muhimbi.online.client.api.*;
import com.muhimbi.online.client.model.*;
import com.squareup.okhttp.OkHttpClient;
import javax.xml.bind.DatatypeConverter;
import java.util.Arrays;
import java.io.*;
import java.nio.file.Files;
import java.util.concurrent.TimeUnit;

public class sample {

    // !!!! ENTER YOUR API KEY HERE !!!!
    static final String API_KEY = "";

    public static void main(String[] args) {

        // ** Make sure an api key has been entered
        if(API_KEY.isEmpty() == true) {
            System.out.println("[ERROR] Please update the sample code and enter the API Key that came with your subscription.");
            return;
        }

        ApiClient defaultClient = Configuration.getDefaultApiClient();

        // ** Specify the API key associated with your subscription.
        ApiKeyAuth api_key = (ApiKeyAuth) defaultClient.getAuthentication("api_key");
        api_key.setApiKey(API_KEY);

        // ** The service's host name is already set, but for debugging purposes you may want to switch between 'http' and 'https'.'
        defaultClient.setBasePath("https://api.muhimbi.com/api");

        // ** Some operations take a while, so set the timeout to an appropriate amount
        defaultClient.getHttpClient().setConnectTimeout(60, TimeUnit.SECONDS); // connect timeout
        defaultClient.getHttpClient().setReadTimeout(60, TimeUnit.SECONDS);    // socket timeout

        try {
            // ** Instantiate the relevant class for the API we are invoking
            MergeApi apiInstance = new MergeApi();

            // ** Read the file we wish to process
            byte[] sourceFile = Files.readAllBytes(new File("ms-word.doc").toPath());

            // ** Fill out all data for this operation
            MergeToPdfData inputData = new MergeToPdfData();
            inputData.setSourceFileName1("ms-word.doc;true;ms-word");                       // ** The name of the file to merge, always include the correct extension. 
                                                                                            //    Optionally add ';true' to auto generate PDF bookmarks based on document structure, 
                                                                                            //    optionally followed by a ';' and the PDF bookmark name of the document.
            inputData.setSourceFileContent1(encode(sourceFile));                            // ** The file content to merge, make sure it is base 64 encoded
            inputData.setSourceFileName2("test.html;true;Some HTML content");               // ** The same again, but as we are merging in HTML content, use a name with '.html' extension.
            inputData.setSourceFileContent2(encode("<h1>Merged HTML Content</h1>"));                // ** HTML or URL to convert and merge. 
            inputData.setSourceFileName3("ms-word.doc;true;ms-word (again)");               // ** The same again for the 3rd file.
            inputData.setSourceFileContent3(encode(sourceFile));                            // ** Content of the 3rd file to merge.
            inputData.setDocumentStartPage(MergeToPdfData.DocumentStartPageEnum.NEXT_PAGE);  // ** On what page should each merged document start (important for double sided docs and printing).

            // ** Carry out the operation
            System.out.println("[INFO] Processing...");
            OperationResponse result = apiInstance.mergeToPdf(inputData);

            // ** Write the results back to the file system
            FileOutputStream fos = new FileOutputStream("result.pdf");
            fos.write(decode(result.getProcessedFileContent()));
            fos.close();

            System.out.println("[INFO] 'result.pdf' written to output folder.");
        } catch (ApiException e) {
            System.err.println("[ERROR] Exception when calling Muhimbi API.");
            e.printStackTrace();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }

    public static String encode(String value) throws Exception {
      return  DatatypeConverter.printBase64Binary
          (value.getBytes("utf-8"));
    }

    public static String encode(byte[] value) throws Exception {
      return  DatatypeConverter.printBase64Binary(value);
    }

    public static byte[] decode(String value) throws Exception {
        return DatatypeConverter.parseBase64Binary(value);
    }

}