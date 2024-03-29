<?php
/**
 * SplitPdfData
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
 * SplitPdfData Class Doc Comment
 *
 * @category    Class
 * @description Parameters for SplitPdf operation
 * @package     MuhimbiPDFOnline\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class SplitPdfData implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'split_pdf_data';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'use_async_pattern' => 'bool',
        'source_file_name' => 'string',
        'source_file_content' => 'string',
        'sharepoint_file' => '\MuhimbiPDFOnline\Client\Model\SharepointFile',
        'file_name_template' => 'string',
        'file_split_by' => 'string',
        'split_parameter' => 'int',
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
        'file_name_template' => 'file_name_template',
        'file_split_by' => 'file_split_by',
        'split_parameter' => 'split_parameter',
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
        'file_name_template' => 'setFileNameTemplate',
        'file_split_by' => 'setFileSplitBy',
        'split_parameter' => 'setSplitParameter',
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
        'file_name_template' => 'getFileNameTemplate',
        'file_split_by' => 'getFileSplitBy',
        'split_parameter' => 'getSplitParameter',
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

    const FILE_SPLIT_BY_NUMBER_OF_PAGES = 'Number of Pages';
    const FILE_SPLIT_BY_BOOKMARK_LEVEL = 'Bookmark Level';
    

    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getFileSplitByAllowableValues()
    {
        return [
            self::FILE_SPLIT_BY_NUMBER_OF_PAGES,
            self::FILE_SPLIT_BY_BOOKMARK_LEVEL,
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
        $this->container['use_async_pattern'] = isset($data['use_async_pattern']) ? $data['use_async_pattern'] : false;
        $this->container['source_file_name'] = isset($data['source_file_name']) ? $data['source_file_name'] : null;
        $this->container['source_file_content'] = isset($data['source_file_content']) ? $data['source_file_content'] : null;
        $this->container['sharepoint_file'] = isset($data['sharepoint_file']) ? $data['sharepoint_file'] : null;
        $this->container['file_name_template'] = isset($data['file_name_template']) ? $data['file_name_template'] : null;
        $this->container['file_split_by'] = isset($data['file_split_by']) ? $data['file_split_by'] : 'Number of Pages';
        $this->container['split_parameter'] = isset($data['split_parameter']) ? $data['split_parameter'] : 1;
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
        if ($this->container['file_split_by'] === null) {
            $invalid_properties[] = "'file_split_by' can't be null";
        }
        $allowed_values = ["Number of Pages", "Bookmark Level"];
        if (!in_array($this->container['file_split_by'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'file_split_by', must be one of 'Number of Pages', 'Bookmark Level'.";
        }

        if ($this->container['split_parameter'] === null) {
            $invalid_properties[] = "'split_parameter' can't be null";
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
        if ($this->container['file_split_by'] === null) {
            return false;
        }
        $allowed_values = ["Number of Pages", "Bookmark Level"];
        if (!in_array($this->container['file_split_by'], $allowed_values)) {
            return false;
        }
        if ($this->container['split_parameter'] === null) {
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
     * @param string $source_file_content Content of the file to split
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
     * Gets file_name_template
     * @return string
     */
    public function getFileNameTemplate()
    {
        return $this->container['file_name_template'];
    }

    /**
     * Sets file_name_template
     * @param string $file_name_template File name template for returned files
     * @return $this
     */
    public function setFileNameTemplate($file_name_template)
    {
        $this->container['file_name_template'] = $file_name_template;

        return $this;
    }

    /**
     * Gets file_split_by
     * @return string
     */
    public function getFileSplitBy()
    {
        return $this->container['file_split_by'];
    }

    /**
     * Sets file_split_by
     * @param string $file_split_by Split by option
     * @return $this
     */
    public function setFileSplitBy($file_split_by)
    {
        $allowed_values = array('Number of Pages', 'Bookmark Level');
        if ((!in_array($file_split_by, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'file_split_by', must be one of 'Number of Pages', 'Bookmark Level'");
        }
        $this->container['file_split_by'] = $file_split_by;

        return $this;
    }

    /**
     * Gets split_parameter
     * @return int
     */
    public function getSplitParameter()
    {
        return $this->container['split_parameter'];
    }

    /**
     * Sets split_parameter
     * @param int $split_parameter Split parameter (number of pages or level)
     * @return $this
     */
    public function setSplitParameter($split_parameter)
    {
        $this->container['split_parameter'] = $split_parameter;

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


