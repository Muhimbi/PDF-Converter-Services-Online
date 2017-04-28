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
        defaultClient.getHttpClient().setConnectTimeout(300, TimeUnit.SECONDS); // connect timeout
        defaultClient.getHttpClient().setReadTimeout(300, TimeUnit.SECONDS);    // socket timeout

        try {
            // ** Instantiate the relevant class for the API we are invoking
            OCRApi apiInstance = new OCRApi();

            // ** Read the file we wish to process
            byte[] sourceFile = Files.readAllBytes(new File("scan.tif").toPath());

            // ** Fill out all data for this operation
            OcrPdfData inputData = new OcrPdfData();
            inputData.setSourceFileName("scan.tif");                                // ** The name of the file to OCR. Always include the correct extension
            inputData.setSourceFileContent(encode(sourceFile));                     // ** The content of the file to OCR
            inputData.setLanguage(OcrPdfData.LanguageEnum.ENGLISH);                 // ** The document's primary language
            inputData.setPerformance(OcrPdfData.PerformanceEnum.SLOW_BUT_ACCURATE); // ** Unless you have a good reason not to, always use the 'Slow' option.
            inputData.setCharactersOption(OcrPdfData.CharactersOptionEnum.NONE);    // ** Any characters to black list or white list (e.g. 1234567890 to deal with numerical data)
            inputData.setCharacters(null);                                          // ** The characters to black or white list.
            inputData.setPaginate(false);                                           // ** Only 'paginate' when your documents have images that span multiple pages.
            inputData.setRegions(null);                                             // ** We want to OCR the entire document, not just specific areas.

            // ** Carry out the operation
            System.out.println("[INFO] Processing...");
            OperationResponse result = apiInstance.ocrPdf(inputData);

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