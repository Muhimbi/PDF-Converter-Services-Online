<?php
/**
 * CopyMetadataData
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

namespace MuhimbiPDFOnline\Client\Model;

use \ArrayAccess;

/**
 * CopyMetadataData Class Doc Comment
 *
 * @category    Class
 * @description Parameters for CopyMetadata operation
 * @package     MuhimbiPDFOnline\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class CopyMetadataData implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'copy_metadata_data';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'site_url' => 'string',
        'source_file_url' => 'string',
        'destination_file_url' => 'string',
        'username' => 'string',
        'password' => 'string',
        'copy_fields' => 'string',
        'content_type' => 'string',
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
        'site_url' => 'site_url',
        'source_file_url' => 'source_file_url',
        'destination_file_url' => 'destination_file_url',
        'username' => 'username',
        'password' => 'password',
        'copy_fields' => 'copy_fields',
        'content_type' => 'content_type',
        'fail_on_error' => 'fail_on_error'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'site_url' => 'setSiteUrl',
        'source_file_url' => 'setSourceFileUrl',
        'destination_file_url' => 'setDestinationFileUrl',
        'username' => 'setUsername',
        'password' => 'setPassword',
        'copy_fields' => 'setCopyFields',
        'content_type' => 'setContentType',
        'fail_on_error' => 'setFailOnError'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'site_url' => 'getSiteUrl',
        'source_file_url' => 'getSourceFileUrl',
        'destination_file_url' => 'getDestinationFileUrl',
        'username' => 'getUsername',
        'password' => 'getPassword',
        'copy_fields' => 'getCopyFields',
        'content_type' => 'getContentType',
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
        $this->container['site_url'] = isset($data['site_url']) ? $data['site_url'] : null;
        $this->container['source_file_url'] = isset($data['source_file_url']) ? $data['source_file_url'] : null;
        $this->container['destination_file_url'] = isset($data['destination_file_url']) ? $data['destination_file_url'] : null;
        $this->container['username'] = isset($data['username']) ? $data['username'] : null;
        $this->container['password'] = isset($data['password']) ? $data['password'] : null;
        $this->container['copy_fields'] = isset($data['copy_fields']) ? $data['copy_fields'] : null;
        $this->container['content_type'] = isset($data['content_type']) ? $data['content_type'] : null;
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

        if ($this->container['site_url'] === null) {
            $invalid_properties[] = "'site_url' can't be null";
        }
        if ($this->container['source_file_url'] === null) {
            $invalid_properties[] = "'source_file_url' can't be null";
        }
        if ($this->container['destination_file_url'] === null) {
            $invalid_properties[] = "'destination_file_url' can't be null";
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

        if ($this->container['site_url'] === null) {
            return false;
        }
        if ($this->container['source_file_url'] === null) {
            return false;
        }
        if ($this->container['destination_file_url'] === null) {
            return false;
        }
        return true;
    }


    /**
     * Gets site_url
     * @return string
     */
    public function getSiteUrl()
    {
        return $this->container['site_url'];
    }

    /**
     * Sets site_url
     * @param string $site_url SharePoint site url (example: http://contoso.sharepoint.com/sites/mysite)
     * @return $this
     */
    public function setSiteUrl($site_url)
    {
        $this->container['site_url'] = $site_url;

        return $this;
    }

    /**
     * Gets source_file_url
     * @return string
     */
    public function getSourceFileUrl()
    {
        return $this->container['source_file_url'];
    }

    /**
     * Sets source_file_url
     * @param string $source_file_url Path to the source file
     * @return $this
     */
    public function setSourceFileUrl($source_file_url)
    {
        $this->container['source_file_url'] = $source_file_url;

        return $this;
    }

    /**
     * Gets destination_file_url
     * @return string
     */
    public function getDestinationFileUrl()
    {
        return $this->container['destination_file_url'];
    }

    /**
     * Sets destination_file_url
     * @param string $destination_file_url Path to the destination file
     * @return $this
     */
    public function setDestinationFileUrl($destination_file_url)
    {
        $this->container['destination_file_url'] = $destination_file_url;

        return $this;
    }

    /**
     * Gets username
     * @return string
     */
    public function getUsername()
    {
        return $this->container['username'];
    }

    /**
     * Sets username
     * @param string $username User name to log in to the SharePoint site
     * @return $this
     */
    public function setUsername($username)
    {
        $this->container['username'] = $username;

        return $this;
    }

    /**
     * Gets password
     * @return string
     */
    public function getPassword()
    {
        return $this->container['password'];
    }

    /**
     * Sets password
     * @param string $password Password to log in to the SharePoint site
     * @return $this
     */
    public function setPassword($password)
    {
        $this->container['password'] = $password;

        return $this;
    }

    /**
     * Gets copy_fields
     * @return string
     */
    public function getCopyFields()
    {
        return $this->container['copy_fields'];
    }

    /**
     * Sets copy_fields
     * @param string $copy_fields Optional comma separated list of fields
     * @return $this
     */
    public function setCopyFields($copy_fields)
    {
        $this->container['copy_fields'] = $copy_fields;

        return $this;
    }

    /**
     * Gets content_type
     * @return string
     */
    public function getContentType()
    {
        return $this->container['content_type'];
    }

    /**
     * Sets content_type
     * @param string $content_type Optional content type for the destination file
     * @return $this
     */
    public function setContentType($content_type)
    {
        $this->container['content_type'] = $content_type;

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


