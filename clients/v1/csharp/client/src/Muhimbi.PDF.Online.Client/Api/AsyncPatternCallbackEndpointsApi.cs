/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.16
 * Contact: support@muhimbi.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Muhimbi.PDF.Online.Client.Client;
using Muhimbi.PDF.Online.Client.Model;

namespace Muhimbi.PDF.Online.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAsyncPatternCallbackEndpointsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>OperationResponse</returns>
        OperationResponse ActionTask (string taskId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of OperationResponse</returns>
        ApiResponse<OperationResponse> ActionTaskWithHttpInfo (string taskId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>OcrOperationResponse</returns>
        OcrOperationResponse OcrTextTask (string taskId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of OcrOperationResponse</returns>
        ApiResponse<OcrOperationResponse> OcrTextTaskWithHttpInfo (string taskId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>SplitOperationResponse</returns>
        SplitOperationResponse SplitPdfTask (string taskId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of SplitOperationResponse</returns>
        ApiResponse<SplitOperationResponse> SplitPdfTaskWithHttpInfo (string taskId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of OperationResponse</returns>
        System.Threading.Tasks.Task<OperationResponse> ActionTaskAsync (string taskId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of ApiResponse (OperationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResponse>> ActionTaskAsyncWithHttpInfo (string taskId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of OcrOperationResponse</returns>
        System.Threading.Tasks.Task<OcrOperationResponse> OcrTextTaskAsync (string taskId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of ApiResponse (OcrOperationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OcrOperationResponse>> OcrTextTaskAsyncWithHttpInfo (string taskId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of SplitOperationResponse</returns>
        System.Threading.Tasks.Task<SplitOperationResponse> SplitPdfTaskAsync (string taskId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of ApiResponse (SplitOperationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SplitOperationResponse>> SplitPdfTaskAsyncWithHttpInfo (string taskId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AsyncPatternCallbackEndpointsApi : IAsyncPatternCallbackEndpointsApi
    {
        private Muhimbi.PDF.Online.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncPatternCallbackEndpointsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AsyncPatternCallbackEndpointsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Muhimbi.PDF.Online.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncPatternCallbackEndpointsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AsyncPatternCallbackEndpointsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Muhimbi.PDF.Online.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Muhimbi.PDF.Online.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>OperationResponse</returns>
        public OperationResponse ActionTask (string taskId)
        {
             ApiResponse<OperationResponse> localVarResponse = ActionTaskWithHttpInfo(taskId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of OperationResponse</returns>
        public ApiResponse< OperationResponse > ActionTaskWithHttpInfo (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling AsyncPatternCallbackEndpointsApi->ActionTask");

            var localVarPath = "/v1/operations/action_task";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskId != null) localVarQueryParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // query parameter

            // authentication (oauth2_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActionTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationResponse)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of OperationResponse</returns>
        public async System.Threading.Tasks.Task<OperationResponse> ActionTaskAsync (string taskId)
        {
             ApiResponse<OperationResponse> localVarResponse = await ActionTaskAsyncWithHttpInfo(taskId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of ApiResponse (OperationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperationResponse>> ActionTaskAsyncWithHttpInfo (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling AsyncPatternCallbackEndpointsApi->ActionTask");

            var localVarPath = "/v1/operations/action_task";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskId != null) localVarQueryParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // query parameter

            // authentication (oauth2_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActionTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationResponse)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>OcrOperationResponse</returns>
        public OcrOperationResponse OcrTextTask (string taskId)
        {
             ApiResponse<OcrOperationResponse> localVarResponse = OcrTextTaskWithHttpInfo(taskId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of OcrOperationResponse</returns>
        public ApiResponse< OcrOperationResponse > OcrTextTaskWithHttpInfo (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling AsyncPatternCallbackEndpointsApi->OcrTextTask");

            var localVarPath = "/v1/operations/ocr_text_task";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskId != null) localVarQueryParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // query parameter

            // authentication (oauth2_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrTextTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OcrOperationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OcrOperationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OcrOperationResponse)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of OcrOperationResponse</returns>
        public async System.Threading.Tasks.Task<OcrOperationResponse> OcrTextTaskAsync (string taskId)
        {
             ApiResponse<OcrOperationResponse> localVarResponse = await OcrTextTaskAsyncWithHttpInfo(taskId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of ApiResponse (OcrOperationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OcrOperationResponse>> OcrTextTaskAsyncWithHttpInfo (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling AsyncPatternCallbackEndpointsApi->OcrTextTask");

            var localVarPath = "/v1/operations/ocr_text_task";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskId != null) localVarQueryParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // query parameter

            // authentication (oauth2_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrTextTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OcrOperationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OcrOperationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OcrOperationResponse)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>SplitOperationResponse</returns>
        public SplitOperationResponse SplitPdfTask (string taskId)
        {
             ApiResponse<SplitOperationResponse> localVarResponse = SplitPdfTaskWithHttpInfo(taskId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of SplitOperationResponse</returns>
        public ApiResponse< SplitOperationResponse > SplitPdfTaskWithHttpInfo (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling AsyncPatternCallbackEndpointsApi->SplitPdfTask");

            var localVarPath = "/v1/operations/split_pdf_task";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskId != null) localVarQueryParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // query parameter

            // authentication (oauth2_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SplitPdfTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SplitOperationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SplitOperationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SplitOperationResponse)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of SplitOperationResponse</returns>
        public async System.Threading.Tasks.Task<SplitOperationResponse> SplitPdfTaskAsync (string taskId)
        {
             ApiResponse<SplitOperationResponse> localVarResponse = await SplitPdfTaskAsyncWithHttpInfo(taskId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Muhimbi.PDF.Online.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task of ApiResponse (SplitOperationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SplitOperationResponse>> SplitPdfTaskAsyncWithHttpInfo (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling AsyncPatternCallbackEndpointsApi->SplitPdfTask");

            var localVarPath = "/v1/operations/split_pdf_task";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskId != null) localVarQueryParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // query parameter

            // authentication (oauth2_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SplitPdfTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SplitOperationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SplitOperationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SplitOperationResponse)));
            
        }

    }
}
