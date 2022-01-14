/*
 * Muhimbi PDF
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.15
 * 
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


import com.muhimbi.online.client.model.OperationResponse;
import com.muhimbi.online.client.model.SecureDocumentData;
import com.muhimbi.online.client.model.SecurePdfData;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class SecureApi {
    private ApiClient apiClient;

    public SecureApi() {
        this(Configuration.getDefaultApiClient());
    }

    public SecureApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /* Build call for secureDocument */
    private com.squareup.okhttp.Call secureDocumentCall(SecureDocumentData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = inputData;
        
        // create path and map variables
        String localVarPath = "/v1/operations/secure_document".replaceAll("\\{format\\}","json");

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
    private com.squareup.okhttp.Call secureDocumentValidateBeforeCall(SecureDocumentData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'inputData' is set
        if (inputData == null) {
            throw new ApiException("Missing the required parameter 'inputData' when calling secureDocument(Async)");
        }
        
        
        com.squareup.okhttp.Call call = secureDocumentCall(inputData, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * 
     * Secure document. Apply security and encryption settings to PDF and Office documents.
     * @param inputData  (required)
     * @return OperationResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public OperationResponse secureDocument(SecureDocumentData inputData) throws ApiException {
        ApiResponse<OperationResponse> resp = secureDocumentWithHttpInfo(inputData);
        return resp.getData();
    }

    /**
     * 
     * Secure document. Apply security and encryption settings to PDF and Office documents.
     * @param inputData  (required)
     * @return ApiResponse&lt;OperationResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<OperationResponse> secureDocumentWithHttpInfo(SecureDocumentData inputData) throws ApiException {
        com.squareup.okhttp.Call call = secureDocumentValidateBeforeCall(inputData, null, null);
        Type localVarReturnType = new TypeToken<OperationResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     *  (asynchronously)
     * Secure document. Apply security and encryption settings to PDF and Office documents.
     * @param inputData  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call secureDocumentAsync(SecureDocumentData inputData, final ApiCallback<OperationResponse> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = secureDocumentValidateBeforeCall(inputData, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<OperationResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /* Build call for securePdf */
    private com.squareup.okhttp.Call securePdfCall(SecurePdfData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = inputData;
        
        // create path and map variables
        String localVarPath = "/v1/operations/secure_pdf".replaceAll("\\{format\\}","json");

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
    private com.squareup.okhttp.Call securePdfValidateBeforeCall(SecurePdfData inputData, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'inputData' is set
        if (inputData == null) {
            throw new ApiException("Missing the required parameter 'inputData' when calling securePdf(Async)");
        }
        
        
        com.squareup.okhttp.Call call = securePdfCall(inputData, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Secure document
     * Apply security and encryption settings.
     * @param inputData  (required)
     * @return OperationResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public OperationResponse securePdf(SecurePdfData inputData) throws ApiException {
        ApiResponse<OperationResponse> resp = securePdfWithHttpInfo(inputData);
        return resp.getData();
    }

    /**
     * Secure document
     * Apply security and encryption settings.
     * @param inputData  (required)
     * @return ApiResponse&lt;OperationResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<OperationResponse> securePdfWithHttpInfo(SecurePdfData inputData) throws ApiException {
        com.squareup.okhttp.Call call = securePdfValidateBeforeCall(inputData, null, null);
        Type localVarReturnType = new TypeToken<OperationResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Secure document (asynchronously)
     * Apply security and encryption settings.
     * @param inputData  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call securePdfAsync(SecurePdfData inputData, final ApiCallback<OperationResponse> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = securePdfValidateBeforeCall(inputData, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<OperationResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
