<?php
/**
 * SecureDocumentData
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
 * OpenAPI spec version: 9.14
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
 * SecureDocumentData Class Doc Comment
 *
 * @category    Class
 * @description Parameters for SecureDocument operation
 * @package     MuhimbiPDFOnline\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class SecureDocumentData implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'secure_document_data';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'use_async_pattern' => 'bool',
        'source_file_name' => 'string',
        'source_file_content' => 'string',
        'sharepoint_file' => '\MuhimbiPDFOnline\Client\Model\SharepointFile',
        'open_password' => 'string',
        'owner_password' => 'string',
        'security_options' => 'string',
        'fail_on_error' => 'bool'
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
        'use_async_pattern' => 'use_async_pattern',
        'source_file_name' => 'source_file_name',
        'source_file_content' => 'source_file_content',
        'sharepoint_file' => 'sharepoint_file',
        'open_password' => 'open_password',
        'owner_password' => 'owner_password',
        'security_options' => 'security_options',
        'fail_on_error' => 'fail_on_error'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'use_async_pattern' => 'setUseAsyncPattern',
        'source_file_name' => 'setSourceFileName',
        'source_file_content' => 'setSourceFileContent',
        'sharepoint_file' => 'setSharepointFile',
        'open_password' => 'setOpenPassword',
        'owner_password' => 'setOwnerPassword',
        'security_options' => 'setSecurityOptions',
        'fail_on_error' => 'setFailOnError'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'use_async_pattern' => 'getUseAsyncPattern',
        'source_file_name' => 'getSourceFileName',
        'source_file_content' => 'getSourceFileContent',
        'sharepoint_file' => 'getSharepointFile',
        'open_password' => 'getOpenPassword',
        'owner_password' => 'getOwnerPassword',
        'security_options' => 'getSecurityOptions',
        'fail_on_error' => 'getFailOnError'
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
        $this->container['use_async_pattern'] = isset($data['use_async_pattern']) ? $data['use_async_pattern'] : false;
        $this->container['source_file_name'] = isset($data['source_file_name']) ? $data['source_file_name'] : null;
        $this->container['source_file_content'] = isset($data['source_file_content']) ? $data['source_file_content'] : null;
        $this->container['sharepoint_file'] = isset($data['sharepoint_file']) ? $data['sharepoint_file'] : null;
        $this->container['open_password'] = isset($data['open_password']) ? $data['open_password'] : null;
        $this->container['owner_password'] = isset($data['owner_password']) ? $data['owner_password'] : null;
        $this->container['security_options'] = isset($data['security_options']) ? $data['security_options'] : null;
        $this->container['fail_on_error'] = isset($data['fail_on_error']) ? $data['fail_on_error'] : true;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = [];

        if ($this->container['use_async_pattern'] === null) {
            $invalid_properties[] = "'use_async_pattern' can't be null";
        }
        if ($this->container['source_file_name'] === null) {
            $invalid_properties[] = "'source_file_name' can't be null";
        }
        if ($this->container['source_file_content'] === null) {
            $invalid_properties[] = "'source_file_content' can't be null";
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

        if ($this->container['use_async_pattern'] === null) {
            return false;
        }
        if ($this->container['source_file_name'] === null) {
            return false;
        }
        if ($this->container['source_file_content'] === null) {
            return false;
        }
        return true;
    }


    /**
     * Gets use_async_pattern
     * @return bool
     */
    public function getUseAsyncPattern()
    {
        return $this->container['use_async_pattern'];
    }

    /**
     * Sets use_async_pattern
     * @param bool $use_async_pattern Use async behaviour for API request
     * @return $this
     */
    public function setUseAsyncPattern($use_async_pattern)
    {
        $this->container['use_async_pattern'] = $use_async_pattern;

        return $this;
    }

    /**
     * Gets source_file_name
     * @return string
     */
    public function getSourceFileName()
    {
        return $this->container['source_file_name'];
    }

    /**
     * Sets source_file_name
     * @param string $source_file_name Name of the source file including extension
     * @return $this
     */
    public function setSourceFileName($source_file_name)
    {
        $this->container['source_file_name'] = $source_file_name;

        return $this;
    }

    /**
     * Gets source_file_content
     * @return string
     */
    public function getSourceFileContent()
    {
        return $this->container['source_file_content'];
    }

    /**
     * Sets source_file_content
     * @param string $source_file_content Content of the file to secure
     * @return $this
     */
    public function setSourceFileContent($source_file_content)
    {
        $this->container['source_file_content'] = $source_file_content;

        return $this;
    }

    /**
     * Gets sharepoint_file
     * @return \MuhimbiPDFOnline\Client\Model\SharepointFile
     */
    public function getSharepointFile()
    {
        return $this->container['sharepoint_file'];
    }

    /**
     * Sets sharepoint_file
     * @param \MuhimbiPDFOnline\Client\Model\SharepointFile $sharepoint_file
     * @return $this
     */
    public function setSharepointFile($sharepoint_file)
    {
        $this->container['sharepoint_file'] = $sharepoint_file;

        return $this;
    }

    /**
     * Gets open_password
     * @return string
     */
    public function getOpenPassword()
    {
        return $this->container['open_password'];
    }

    /**
     * Sets open_password
     * @param string $open_password Password required to open the document
     * @return $this
     */
    public function setOpenPassword($open_password)
    {
        $this->container['open_password'] = $open_password;

        return $this;
    }

    /**
     * Gets owner_password
     * @return string
     */
    public function getOwnerPassword()
    {
        return $this->container['owner_password'];
    }

    /**
     * Sets owner_password
     * @param string $owner_password Password for making non-PDF document readonly or PDF document restrictions defined below
     * @return $this
     */
    public function setOwnerPassword($owner_password)
    {
        $this->container['owner_password'] = $owner_password;

        return $this;
    }

    /**
     * Gets security_options
     * @return string
     */
    public function getSecurityOptions()
    {
        return $this->container['security_options'];
    }

    /**
     * Sets security_options
     * @param string $security_options Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly
     * @return $this
     */
    public function setSecurityOptions($security_options)
    {
        $this->container['security_options'] = $security_options;

        return $this;
    }

    /**
     * Gets fail_on_error
     * @return bool
     */
    public function getFailOnError()
    {
        return $this->container['fail_on_error'];
    }

    /**
     * Sets fail_on_error
     * @param bool $fail_on_error Fail on error
     * @return $this
     */
    public function setFailOnError($fail_on_error)
    {
        $this->container['fail_on_error'] = $fail_on_error;

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


