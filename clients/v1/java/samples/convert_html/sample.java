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
            ConvertApi apiInstance = new ConvertApi();

            // ** Fill out all date for this operation
            ConvertHtmlData inputData = new ConvertHtmlData();
            inputData.setSourceUrlOrHtml("http://blog.muhimbi.com/2017/01/the-how-and-why-of-ocr-providing.html");  // ** Either specify the URL to convert
            //inputData.setSourceUrlOrHtml("Hello <i>world</i>");                                                   // ** or raw HTML
            inputData.setPageOrientation(ConvertHtmlData.PageOrientationEnum.PORTRAIT);                             // ** The page orientation of the generated page
            inputData.setUsername(null);                                                                            // ** Optional user name to authenticate using the specified AuthenticationType
            inputData.setPassword(null);                                                                            // ** Optional password to authenticate using the specified AuthenticationType
            inputData.setAuthenticationType(ConvertHtmlData.AuthenticationTypeEnum.BASIC);                          // ** The type of authentication to use

            // ** Carry out the operation
            System.out.println("[INFO] Processing...");
            OperationResponse result = apiInstance.convertHtml(inputData);

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

    public static byte[] decode(String value) throws Exception {
        return DatatypeConverter.parseBase64Binary(value);
    }

}