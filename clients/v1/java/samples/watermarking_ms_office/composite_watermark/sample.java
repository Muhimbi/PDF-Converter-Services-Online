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
import java.nio.file.*;
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
            WatermarkApi apiInstance = new WatermarkApi();

            // ** Read the file we wish to process
            byte[] sourceFile = Files.readAllBytes(new File("test.docx").toPath());

            // ** Read the complex watermark XML we wish to apply
            String watermarkXml = new String(Files.readAllBytes(Paths.get("watermark.xml")));

            // ** Fill out all data for this operation
            CompositeWatermarkData inputData = new CompositeWatermarkData();
            inputData.setSourceFileName("test.docx");                   // ** Always specify a file name with the correct extension (file must be a PDF, docx, xlsx or pptx file)
            inputData.setSourceFileContent(encode(sourceFile));         // ** The file content to watermark
            inputData.setWatermarkData(watermarkXml);                   // ** Load the XML Definition for the composite watermark

            // ** Carry out the operation
            System.out.println("[INFO] Processing...");
            OperationResponse result = apiInstance.compositeWatermark(inputData);

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