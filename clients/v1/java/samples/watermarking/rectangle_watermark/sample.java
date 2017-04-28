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
            byte[] sourceFile = Files.readAllBytes(new File("test.pdf").toPath());

            // ** Fill out all data for this operation
            RectangleWatermarkData inputData = new RectangleWatermarkData();
            inputData.setSourceFileName("test.pdf");                                        // ** Always specify a file name with the correct extension (file must be a PDF file when watermarking)
            inputData.setSourceFileContent(encode(sourceFile));                             // ** The file content to watermark
            inputData.setPosition(RectangleWatermarkData.PositionEnum.MIDDLE_CENTER);       // ** The location where the watermark will be positioned on the page.
            inputData.setX("0");                                                            // ** The x-coordinate of the watermark. Only used when Position is set to Absolute.
            inputData.setY("0");                                                            // ** The y-coordinate of the watermark. Only used when Position is set to Absolute.
            inputData.setWidth("144");                                                      // ** The width of the watermark in pts (1/72nd of an inch). For example 144 is 2 inches wide.
            inputData.setHeight("144");                                                     // ** The height of the watermark.
            inputData.setLayer(RectangleWatermarkData.LayerEnum.FOREGROUND);                // ** Position the watermark in front of the page's content, or behind it
            inputData.setRotation("0");                                                     // ** Rotate the watermark, specify a value in degrees. Negative values are accepted.
            inputData.setOpacity("50");                                                     // ** A value between 0 (completely transparent) and 100 (fully visible)
            inputData.setFillColor("#990000");                                              // ** The fill color of the watermark in #RRGGBB notation.
            inputData.setLineColor("#000000");                                              // ** The (out)line color of the watermark in #RRGGBB notation.
            inputData.setLineWidth("10");                                                   // ** The width of the line in pts (1/72nd of an inch). 0 = hairline, -1 = no line
            inputData.setStartPage(0);                                                      // ** The first page in the document the watermark applies to.
            inputData.setEndPage(0);                                                        // ** The last page in the document the watermark applies to.
            inputData.setPageInterval(1);                                                   // ** Which pages to apply the watermark on (1 = every page, 2 = every other page etc).
            inputData.setPageOrientation(RectangleWatermarkData.PageOrientationEnum.BOTH);  // ** The page orientation the watermark applies to. 

            // ** Carry out the operation
            System.out.println("[INFO] Processing...");
            OperationResponse result = apiInstance.rectangleWatermark(inputData);

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