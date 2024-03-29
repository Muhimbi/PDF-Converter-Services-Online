/*
 * Muhimbi PDF
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.16
 * Contact: support@muhimbi.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.muhimbi.online.client.api;

import com.muhimbi.online.client.ApiCallback;
import com.muhimbi.online.client.ApiClient;
import com.muhimbi.online.client.ApiException;
import com.muhimbi.online.client.ApiResponse;
import com.muhimbi.online.client.Configuration;
import com.muhimbi.online.client.Pair;
import com.muhimbi.online.client.ProgressRequestBody;
import com.muhimbi.online.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.muhimbi.online.client.model.OcrOperationResponse;
import com.muhimbi.online.client.model.OcrPdfData;
import com.muhimbi.online.client.model.OcrTextData;
import com.muhimbi.online.client.model.OperationResponse;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class OCRApi {
    private ApiClient apiClient;

    public OCRApi() {
        this(Configuration.getDefaultApiClient());
    }

    public OCRApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /* Build call for ocrPdf */
    private com.squareup.okhttp.Call ocrPdfCall(OcrPdfData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = inputData;
        
        // create path and map variables
        String localVarPath = "/v1/operations/ocr_pdf".replaceAll("\\{format\\}","json");

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "oauth2_auth", "api_key" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call ocrPdfValidateBeforeCall(OcrPdfData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'inputData' is set
        if (inputData == null) {
            throw new ApiException("Missing the required parameter 'inputData' when calling ocrPdf(Async)");
        }
        
        
        com.squareup.okhttp.Call call = ocrPdfCall(inputData, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Convert to OCRed PDF
     * Convert a file to an OCRed PDF.
     * @param inputData  (required)
     * @return OperationResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public OperationResponse ocrPdf(OcrPdfData inputData) throws ApiException {
        ApiResponse<OperationResponse> resp = ocrPdfWithHttpInfo(inputData);
        return resp.getData();
    }

    /**
     * Convert to OCRed PDF
     * Convert a file to an OCRed PDF.
     * @param inputData  (required)
     * @return ApiResponse&lt;OperationResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<OperationResponse> ocrPdfWithHttpInfo(OcrPdfData inputData) throws ApiException {
        com.squareup.okhttp.Call call = ocrPdfValidateBeforeCall(inputData, null, null);
        Type localVarReturnType = new TypeToken<OperationResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Convert to OCRed PDF (asynchronously)
     * Convert a file to an OCRed PDF.
     * @param inputData  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call ocrPdfAsync(OcrPdfData inputData, final ApiCallback<OperationResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = ocrPdfValidateBeforeCall(inputData, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<OperationResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /* Build call for ocrText */
    private com.squareup.okhttp.Call ocrTextCall(OcrTextData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = inputData;
        
        // create path and map variables
        String localVarPath = "/v1/operations/ocr_text".replaceAll("\\{format\\}","json");

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "oauth2_auth", "api_key" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call ocrTextValidateBeforeCall(OcrTextData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'inputData' is set
        if (inputData == null) {
            throw new ApiException("Missing the required parameter 'inputData' when calling ocrText(Async)");
        }
        
        
        com.squareup.okhttp.Call call = ocrTextCall(inputData, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Extract text using OCR
     * Extract text from a file using OCR.
     * @param inputData  (required)
     * @return OcrOperationResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public OcrOperationResponse ocrText(OcrTextData inputData) throws ApiException {
        ApiResponse<OcrOperationResponse> resp = ocrTextWithHttpInfo(inputData);
        return resp.getData();
    }

    /**
     * Extract text using OCR
     * Extract text from a file using OCR.
     * @param inputData  (required)
     * @return ApiResponse&lt;OcrOperationResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<OcrOperationResponse> ocrTextWithHttpInfo(OcrTextData inputData) throws ApiException {
        com.squareup.okhttp.Call call = ocrTextValidateBeforeCall(inputData, null, null);
        Type localVarReturnType = new TypeToken<OcrOperationResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Extract text using OCR (asynchronously)
     * Extract text from a file using OCR.
     * @param inputData  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call ocrTextAsync(OcrTextData inputData, final ApiCallback<OcrOperationResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = ocrTextValidateBeforeCall(inputData, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<OcrOperationResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
