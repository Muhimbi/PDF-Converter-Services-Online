<?php
/**
 * AsyncPatternCallbackEndpointsApi
 * PHP version 5
 *
 * @category Class
 * @package  MuhimbiPDFOnline\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.16
 * Contact: support@muhimbi.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace MuhimbiPDFOnline\Client\Api;

use \MuhimbiPDFOnline\Client\ApiClient;
use \MuhimbiPDFOnline\Client\ApiException;
use \MuhimbiPDFOnline\Client\Configuration;
use \MuhimbiPDFOnline\Client\ObjectSerializer;

/**
 * AsyncPatternCallbackEndpointsApi Class Doc Comment
 *
 * @category Class
 * @package  MuhimbiPDFOnline\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class AsyncPatternCallbackEndpointsApi
{
    /**
     * API Client
     *
     * @var \MuhimbiPDFOnline\Client\ApiClient instance of the ApiClient
     */
    protected $apiClient;

    /**
     * Constructor
     *
     * @param \MuhimbiPDFOnline\Client\ApiClient|null $apiClient The api client to use
     */
    public function __construct(\MuhimbiPDFOnline\Client\ApiClient $apiClient = null)
    {
        if ($apiClient === null) {
            $apiClient = new ApiClient();
        }

        $this->apiClient = $apiClient;
    }

    /**
     * Get API client
     *
     * @return \MuhimbiPDFOnline\Client\ApiClient get the API client
     */
    public function getApiClient()
    {
        return $this->apiClient;
    }

    /**
     * Set the API client
     *
     * @param \MuhimbiPDFOnline\Client\ApiClient $apiClient set the API client
     *
     * @return AsyncPatternCallbackEndpointsApi
     */
    public function setApiClient(\MuhimbiPDFOnline\Client\ApiClient $apiClient)
    {
        $this->apiClient = $apiClient;
        return $this;
    }

    /**
     * Operation actionTask
     *
     * 
     *
     * @param string $task_id  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return \MuhimbiPDFOnline\Client\Model\OperationResponse
     */
    public function actionTask($task_id)
    {
        list($response) = $this->actionTaskWithHttpInfo($task_id);
        return $response;
    }

    /**
     * Operation actionTaskWithHttpInfo
     *
     * 
     *
     * @param string $task_id  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return array of \MuhimbiPDFOnline\Client\Model\OperationResponse, HTTP status code, HTTP response headers (array of strings)
     */
    public function actionTaskWithHttpInfo($task_id)
    {
        // verify the required parameter 'task_id' is set
        if ($task_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $task_id when calling actionTask');
        }
        // parse inputs
        $resourcePath = "/v1/operations/action_task";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // query params
        if ($task_id !== null) {
            $queryParams['task_id'] = $this->apiClient->getSerializer()->toQueryValue($task_id);
        }
        // default format to json
        $resourcePath = str_replace("{format}", "json", $resourcePath);

        
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires OAuth (access token)
        if (strlen($this->apiClient->getConfig()->getAccessToken()) !== 0) {
            $headerParams['Authorization'] = 'Bearer ' . $this->apiClient->getConfig()->getAccessToken();
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('api_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['api_key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\MuhimbiPDFOnline\Client\Model\OperationResponse',
                '/v1/operations/action_task'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\MuhimbiPDFOnline\Client\Model\OperationResponse', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\MuhimbiPDFOnline\Client\Model\OperationResponse', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation ocrTextTask
     *
     * 
     *
     * @param string $task_id  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return \MuhimbiPDFOnline\Client\Model\OcrOperationResponse
     */
    public function ocrTextTask($task_id)
    {
        list($response) = $this->ocrTextTaskWithHttpInfo($task_id);
        return $response;
    }

    /**
     * Operation ocrTextTaskWithHttpInfo
     *
     * 
     *
     * @param string $task_id  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return array of \MuhimbiPDFOnline\Client\Model\OcrOperationResponse, HTTP status code, HTTP response headers (array of strings)
     */
    public function ocrTextTaskWithHttpInfo($task_id)
    {
        // verify the required parameter 'task_id' is set
        if ($task_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $task_id when calling ocrTextTask');
        }
        // parse inputs
        $resourcePath = "/v1/operations/ocr_text_task";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // query params
        if ($task_id !== null) {
            $queryParams['task_id'] = $this->apiClient->getSerializer()->toQueryValue($task_id);
        }
        // default format to json
        $resourcePath = str_replace("{format}", "json", $resourcePath);

        
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires OAuth (access token)
        if (strlen($this->apiClient->getConfig()->getAccessToken()) !== 0) {
            $headerParams['Authorization'] = 'Bearer ' . $this->apiClient->getConfig()->getAccessToken();
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('api_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['api_key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\MuhimbiPDFOnline\Client\Model\OcrOperationResponse',
                '/v1/operations/ocr_text_task'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\MuhimbiPDFOnline\Client\Model\OcrOperationResponse', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\MuhimbiPDFOnline\Client\Model\OcrOperationResponse', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation splitPdfTask
     *
     * 
     *
     * @param string $task_id  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return \MuhimbiPDFOnline\Client\Model\SplitOperationResponse
     */
    public function splitPdfTask($task_id)
    {
        list($response) = $this->splitPdfTaskWithHttpInfo($task_id);
        return $response;
    }

    /**
     * Operation splitPdfTaskWithHttpInfo
     *
     * 
     *
     * @param string $task_id  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return array of \MuhimbiPDFOnline\Client\Model\SplitOperationResponse, HTTP status code, HTTP response headers (array of strings)
     */
    public function splitPdfTaskWithHttpInfo($task_id)
    {
        // verify the required parameter 'task_id' is set
        if ($task_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $task_id when calling splitPdfTask');
        }
        // parse inputs
        $resourcePath = "/v1/operations/split_pdf_task";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // query params
        if ($task_id !== null) {
            $queryParams['task_id'] = $this->apiClient->getSerializer()->toQueryValue($task_id);
        }
        // default format to json
        $resourcePath = str_replace("{format}", "json", $resourcePath);

        
        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires OAuth (access token)
        if (strlen($this->apiClient->getConfig()->getAccessToken()) !== 0) {
            $headerParams['Authorization'] = 'Bearer ' . $this->apiClient->getConfig()->getAccessToken();
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('api_key');
        if (strlen($apiKey) !== 0) {
            $headerParams['api_key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\MuhimbiPDFOnline\Client\Model\SplitOperationResponse',
                '/v1/operations/split_pdf_task'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\MuhimbiPDFOnline\Client\Model\SplitOperationResponse', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\MuhimbiPDFOnline\Client\Model\SplitOperationResponse', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }
}
