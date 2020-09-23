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
            SecureApi apiInstance = new SecureApi();

            // ** Read the file we wish to process
            byte[] sourceFile = Files.readAllBytes(new File("test.docx").toPath());

            // ** Fill out all data for this operation
            SecureDocumentData inputData = new SecureDocumentData();
            inputData.setSourceFileName("test.docx");               // ** Always specify a file name with the correct extension (file must be a PDF, docx, xlsx or pptx file)
            inputData.setSourceFileContent(encode(sourceFile));     // ** The file content to secure
            inputData.setOpenPassword("open");                      // ** Optionally specify a password for 'opening' the document
            inputData.setOwnerPassword("owner");                    // ** When applying PDF security restrictions (e.g. 'Print|ContentCopy'), always specify an 'owner password', 
                                                                    //    in this example the password is set to 'owner'
            inputData.setSecurityOptions("Print|ContentCopy");      // ** Optionally specify the PDF security restrictions to apply, a combination of 
                                                                    //    'Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly''

            // ** Carry out the operation
            System.out.println("[INFO] Processing...");
            OperationResponse result = apiInstance.secureDocument(inputData);

            // ** Write the results back to the file system
            FileOutputStream fos = new FileOutputStream("result.docx");
            fos.write(decode(result.getProcessedFileContent()));
            fos.close();

            System.out.println("[INFO] 'result.docx' written to output folder.");
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