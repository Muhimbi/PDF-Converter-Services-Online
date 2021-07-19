<?php
/**
 * OperationResponseCommon
 *
 * PHP version 5
 *
 * @category Class
 * @package  MuhimbiPDFOnline\Client
 * @author   Swaagger Codegen team
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

namespace MuhimbiPDFOnline\Client\Model;

use \ArrayAccess;

/**
 * OperationResponseCommon Class Doc Comment
 *
 * @category    Class
 * @description Response data for all operations
 * @package     MuhimbiPDFOnline\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class OperationResponseCommon implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'operation_response_common';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'base_file_name' => 'string',
        'result_code' => 'string',
        'result_details' => 'string'
    ];

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = [
        'base_file_name' => 'base_file_name',
        'result_code' => 'result_code',
        'result_details' => 'result_details'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'base_file_name' => 'setBaseFileName',
        'result_code' => 'setResultCode',
        'result_details' => 'setResultDetails'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'base_file_name' => 'getBaseFileName',
        'result_code' => 'getResultCode',
        'result_details' => 'getResultDetails'
    ];

    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    public static function setters()
    {
        return self::$setters;
    }

    public static function getters()
    {
        return self::$getters;
    }

    const RESULT_CODE_SUCCESS = 'Success';
    const RESULT_CODE_PROCESSING_ERROR = 'ProcessingError';
    const RESULT_CODE_SUBSCRIPTION_NOT_FOUND = 'SubscriptionNotFound';
    const RESULT_CODE_SUBSCRIPTION_EXPIRED = 'SubscriptionExpired';
    const RESULT_CODE_ACTIVATION_PENDING = 'ActivationPending';
    const RESULT_CODE_TRIAL_EXPIRED = 'TrialExpired';
    const RESULT_CODE_OPERATION_SIZE_EXCEEDED = 'OperationSizeExceeded';
    const RESULT_CODE_OPERATIONS_EXCEEDED = 'OperationsExceeded';
    const RESULT_CODE_INPUT_FILE_TYPE_NOT_SUPPORTED = 'InputFileTypeNotSupported';
    const RESULT_CODE_OUTPUT_FILE_TYPE_NOT_SUPPORTED = 'OutputFileTypeNotSupported';
    const RESULT_CODE_OPERATION_NOT_SUPPORTED = 'OperationNotSupported';
    const RESULT_CODE_ACCEPTED = 'Accepted';
    const RESULT_CODE_ACCESS_DENIED = 'AccessDenied';
    const RESULT_CODE_INVALID_EXTENSION = 'InvalidExtension';
    

    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getResultCodeAllowableValues()
    {
        return [
            self::RESULT_CODE_SUCCESS,
            self::RESULT_CODE_PROCESSING_ERROR,
            self::RESULT_CODE_SUBSCRIPTION_NOT_FOUND,
            self::RESULT_CODE_SUBSCRIPTION_EXPIRED,
            self::RESULT_CODE_ACTIVATION_PENDING,
            self::RESULT_CODE_TRIAL_EXPIRED,
            self::RESULT_CODE_OPERATION_SIZE_EXCEEDED,
            self::RESULT_CODE_OPERATIONS_EXCEEDED,
            self::RESULT_CODE_INPUT_FILE_TYPE_NOT_SUPPORTED,
            self::RESULT_CODE_OUTPUT_FILE_TYPE_NOT_SUPPORTED,
            self::RESULT_CODE_OPERATION_NOT_SUPPORTED,
            self::RESULT_CODE_ACCEPTED,
            self::RESULT_CODE_ACCESS_DENIED,
            self::RESULT_CODE_INVALID_EXTENSION,
        ];
    }
    

    /**
     * Associative array for storing property values
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     * @param mixed[] $data Associated array of property values initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['base_file_name'] = isset($data['base_file_name']) ? $data['base_file_name'] : null;
        $this->container['result_code'] = isset($data['result_code']) ? $data['result_code'] : null;
        $this->container['result_details'] = isset($data['result_details']) ? $data['result_details'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = [];

        $allowed_values = ["Success", "ProcessingError", "SubscriptionNotFound", "SubscriptionExpired", "ActivationPending", "TrialExpired", "OperationSizeExceeded", "OperationsExceeded", "InputFileTypeNotSupported", "OutputFileTypeNotSupported", "OperationNotSupported", "Accepted", "AccessDenied", "InvalidExtension"];
        if (!in_array($this->container['result_code'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'result_code', must be one of 'Success', 'ProcessingError', 'SubscriptionNotFound', 'SubscriptionExpired', 'ActivationPending', 'TrialExpired', 'OperationSizeExceeded', 'OperationsExceeded', 'InputFileTypeNotSupported', 'OutputFileTypeNotSupported', 'OperationNotSupported', 'Accepted', 'AccessDenied', 'InvalidExtension'.";
        }

        return $invalid_properties;
    }

    /**
     * validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {

        $allowed_values = ["Success", "ProcessingError", "SubscriptionNotFound", "SubscriptionExpired", "ActivationPending", "TrialExpired", "OperationSizeExceeded", "OperationsExceeded", "InputFileTypeNotSupported", "OutputFileTypeNotSupported", "OperationNotSupported", "Accepted", "AccessDenied", "InvalidExtension"];
        if (!in_array($this->container['result_code'], $allowed_values)) {
            return false;
        }
        return true;
    }


    /**
     * Gets base_file_name
     * @return string
     */
    public function getBaseFileName()
    {
        return $this->container['base_file_name'];
    }

    /**
     * Sets base_file_name
     * @param string $base_file_name Name of the input file without the extension.
     * @return $this
     */
    public function setBaseFileName($base_file_name)
    {
        $this->container['base_file_name'] = $base_file_name;

        return $this;
    }

    /**
     * Gets result_code
     * @return string
     */
    public function getResultCode()
    {
        return $this->container['result_code'];
    }

    /**
     * Sets result_code
     * @param string $result_code Operation result code.
     * @return $this
     */
    public function setResultCode($result_code)
    {
        $allowed_values = array('Success', 'ProcessingError', 'SubscriptionNotFound', 'SubscriptionExpired', 'ActivationPending', 'TrialExpired', 'OperationSizeExceeded', 'OperationsExceeded', 'InputFileTypeNotSupported', 'OutputFileTypeNotSupported', 'OperationNotSupported', 'Accepted', 'AccessDenied', 'InvalidExtension');
        if (!is_null($result_code) && (!in_array($result_code, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'result_code', must be one of 'Success', 'ProcessingError', 'SubscriptionNotFound', 'SubscriptionExpired', 'ActivationPending', 'TrialExpired', 'OperationSizeExceeded', 'OperationsExceeded', 'InputFileTypeNotSupported', 'OutputFileTypeNotSupported', 'OperationNotSupported', 'Accepted', 'AccessDenied', 'InvalidExtension'");
        }
        $this->container['result_code'] = $result_code;

        return $this;
    }

    /**
     * Gets result_details
     * @return string
     */
    public function getResultDetails()
    {
        return $this->container['result_details'];
    }

    /**
     * Sets result_details
     * @param string $result_details Operation result details.
     * @return $this
     */
    public function setResultDetails($result_details)
    {
        $this->container['result_details'] = $result_details;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     * @param  integer $offset Offset
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     * @param  integer $offset Offset
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     * @param  integer $offset Offset
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(\MuhimbiPDFOnline\Client\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\MuhimbiPDFOnline\Client\ObjectSerializer::sanitizeForSerialization($this));
    }
}


