<?php
/**
 * SplitApi
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
 * OpenAPI spec version: 9.14.1
 * 
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
 * SplitApi Class Doc Comment
 *
 * @category Class
 * @package  MuhimbiPDFOnline\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class SplitApi
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
     * @return SplitApi
     */
    public function setApiClient(\MuhimbiPDFOnline\Client\ApiClient $apiClient)
    {
        $this->apiClient = $apiClient;
        return $this;
    }

    /**
     * Operation splitPdf
     *
     * Split PDF
     *
     * @param \MuhimbiPDFOnline\Client\Model\SplitPdfData $input_data  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return \MuhimbiPDFOnline\Client\Model\SplitOperationResponse
     */
    public function splitPdf($input_data)
    {
        list($response) = $this->splitPdfWithHttpInfo($input_data);
        return $response;
    }

    /**
     * Operation splitPdfWithHttpInfo
     *
     * Split PDF
     *
     * @param \MuhimbiPDFOnline\Client\Model\SplitPdfData $input_data  (required)
     * @throws \MuhimbiPDFOnline\Client\ApiException on non-2xx response
     * @return array of \MuhimbiPDFOnline\Client\Model\SplitOperationResponse, HTTP status code, HTTP response headers (array of strings)
     */
    public function splitPdfWithHttpInfo($input_data)
    {
        // verify the required parameter 'input_data' is set
        if ($input_data === null) {
            throw new \InvalidArgumentException('Missing the required parameter $input_data when calling splitPdf');
        }
        // parse inputs
        $resourcePath = "/v1/operations/split_pdf";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // default format to json
        $resourcePath = str_replace("{format}", "json", $resourcePath);

        // body params
        $_tempBody = null;
        if (isset($input_data)) {
            $_tempBody = $input_data;
        }

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
                'POST',
                $queryParams,
                $httpBody,
                $headerParams,
                '\MuhimbiPDFOnline\Client\Model\SplitOperationResponse',
                '/v1/operations/split_pdf'
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
