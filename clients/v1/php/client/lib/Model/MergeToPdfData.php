<?php
/**
 * MergeToPdfData
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
 * MergeToPdfData Class Doc Comment
 *
 * @category    Class
 * @description Parameters for MergeToPdf operation
 * @package     MuhimbiPDFOnline\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class MergeToPdfData implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'merge_to_pdf_data';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'use_async_pattern' => 'bool',
        'source_file_name_1' => 'string',
        'source_file_content_1' => 'string',
        'source_file_name_2' => 'string',
        'source_file_content_2' => 'string',
        'source_file_name_3' => 'string',
        'source_file_content_3' => 'string',
        'source_file_name_4' => 'string',
        'source_file_content_4' => 'string',
        'source_file_name_5' => 'string',
        'source_file_content_5' => 'string',
        'sharepoint_file' => '\MuhimbiPDFOnline\Client\Model\SharepointFile',
        'sharepoint_field_name' => 'string',
        'document_start_page' => 'string',
        'source_files' => '\MuhimbiPDFOnline\Client\Model\MergeSourceFile[]',
        'override_settings' => 'string',
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
        'source_file_name_1' => 'source_file_name_1',
        'source_file_content_1' => 'source_file_content_1',
        'source_file_name_2' => 'source_file_name_2',
        'source_file_content_2' => 'source_file_content_2',
        'source_file_name_3' => 'source_file_name_3',
        'source_file_content_3' => 'source_file_content_3',
        'source_file_name_4' => 'source_file_name_4',
        'source_file_content_4' => 'source_file_content_4',
        'source_file_name_5' => 'source_file_name_5',
        'source_file_content_5' => 'source_file_content_5',
        'sharepoint_file' => 'sharepoint_file',
        'sharepoint_field_name' => 'sharepoint_field_name',
        'document_start_page' => 'document_start_page',
        'source_files' => 'source_files',
        'override_settings' => 'override_settings',
        'fail_on_error' => 'fail_on_error'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'use_async_pattern' => 'setUseAsyncPattern',
        'source_file_name_1' => 'setSourceFileName1',
        'source_file_content_1' => 'setSourceFileContent1',
        'source_file_name_2' => 'setSourceFileName2',
        'source_file_content_2' => 'setSourceFileContent2',
        'source_file_name_3' => 'setSourceFileName3',
        'source_file_content_3' => 'setSourceFileContent3',
        'source_file_name_4' => 'setSourceFileName4',
        'source_file_content_4' => 'setSourceFileContent4',
        'source_file_name_5' => 'setSourceFileName5',
        'source_file_content_5' => 'setSourceFileContent5',
        'sharepoint_file' => 'setSharepointFile',
        'sharepoint_field_name' => 'setSharepointFieldName',
        'document_start_page' => 'setDocumentStartPage',
        'source_files' => 'setSourceFiles',
        'override_settings' => 'setOverrideSettings',
        'fail_on_error' => 'setFailOnError'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'use_async_pattern' => 'getUseAsyncPattern',
        'source_file_name_1' => 'getSourceFileName1',
        'source_file_content_1' => 'getSourceFileContent1',
        'source_file_name_2' => 'getSourceFileName2',
        'source_file_content_2' => 'getSourceFileContent2',
        'source_file_name_3' => 'getSourceFileName3',
        'source_file_content_3' => 'getSourceFileContent3',
        'source_file_name_4' => 'getSourceFileName4',
        'source_file_content_4' => 'getSourceFileContent4',
        'source_file_name_5' => 'getSourceFileName5',
        'source_file_content_5' => 'getSourceFileContent5',
        'sharepoint_file' => 'getSharepointFile',
        'sharepoint_field_name' => 'getSharepointFieldName',
        'document_start_page' => 'getDocumentStartPage',
        'source_files' => 'getSourceFiles',
        'override_settings' => 'getOverrideSettings',
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

    const DOCUMENT_START_PAGE_DEFAULT_PAGE = 'Starts on the default page';
    const DOCUMENT_START_PAGE_NEXT_PAGE = 'Starts on the next page';
    const DOCUMENT_START_PAGE_NEXT_ODD_PAGE = 'Starts on the next odd page';
    const DOCUMENT_START_PAGE_NEXT_EVEN_PAGE = 'Starts on the next even page';
    

    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getDocumentStartPageAllowableValues()
    {
        return [
            self::DOCUMENT_START_PAGE_DEFAULT_PAGE,
            self::DOCUMENT_START_PAGE_NEXT_PAGE,
            self::DOCUMENT_START_PAGE_NEXT_ODD_PAGE,
            self::DOCUMENT_START_PAGE_NEXT_EVEN_PAGE,
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
        $this->container['source_file_name_1'] = isset($data['source_file_name_1']) ? $data['source_file_name_1'] : null;
        $this->container['source_file_content_1'] = isset($data['source_file_content_1']) ? $data['source_file_content_1'] : null;
        $this->container['source_file_name_2'] = isset($data['source_file_name_2']) ? $data['source_file_name_2'] : null;
        $this->container['source_file_content_2'] = isset($data['source_file_content_2']) ? $data['source_file_content_2'] : null;
        $this->container['source_file_name_3'] = isset($data['source_file_name_3']) ? $data['source_file_name_3'] : null;
        $this->container['source_file_content_3'] = isset($data['source_file_content_3']) ? $data['source_file_content_3'] : null;
        $this->container['source_file_name_4'] = isset($data['source_file_name_4']) ? $data['source_file_name_4'] : null;
        $this->container['source_file_content_4'] = isset($data['source_file_content_4']) ? $data['source_file_content_4'] : null;
        $this->container['source_file_name_5'] = isset($data['source_file_name_5']) ? $data['source_file_name_5'] : null;
        $this->container['source_file_content_5'] = isset($data['source_file_content_5']) ? $data['source_file_content_5'] : null;
        $this->container['sharepoint_file'] = isset($data['sharepoint_file']) ? $data['sharepoint_file'] : null;
        $this->container['sharepoint_field_name'] = isset($data['sharepoint_field_name']) ? $data['sharepoint_field_name'] : null;
        $this->container['document_start_page'] = isset($data['document_start_page']) ? $data['document_start_page'] : 'Starts on the next page';
        $this->container['source_files'] = isset($data['source_files']) ? $data['source_files'] : null;
        $this->container['override_settings'] = isset($data['override_settings']) ? $data['override_settings'] : null;
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
        $allowed_values = ["Starts on the default page", "Starts on the next page", "Starts on the next odd page", "Starts on the next even page"];
        if (!in_array($this->container['document_start_page'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'document_start_page', must be one of 'Starts on the default page', 'Starts on the next page', 'Starts on the next odd page', 'Starts on the next even page'.";
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
        $allowed_values = ["Starts on the default page", "Starts on the next page", "Starts on the next odd page", "Starts on the next even page"];
        if (!in_array($this->container['document_start_page'], $allowed_values)) {
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
     * Gets source_file_name_1
     * @return string
     */
    public function getSourceFileName1()
    {
        return $this->container['source_file_name_1'];
    }

    /**
     * Sets source_file_name_1
     * @param string $source_file_name_1 Name of the source file including extension
     * @return $this
     */
    public function setSourceFileName1($source_file_name_1)
    {
        $this->container['source_file_name_1'] = $source_file_name_1;

        return $this;
    }

    /**
     * Gets source_file_content_1
     * @return string
     */
    public function getSourceFileContent1()
    {
        return $this->container['source_file_content_1'];
    }

    /**
     * Sets source_file_content_1
     * @param string $source_file_content_1 Content of the file to merge
     * @return $this
     */
    public function setSourceFileContent1($source_file_content_1)
    {
        $this->container['source_file_content_1'] = $source_file_content_1;

        return $this;
    }

    /**
     * Gets source_file_name_2
     * @return string
     */
    public function getSourceFileName2()
    {
        return $this->container['source_file_name_2'];
    }

    /**
     * Sets source_file_name_2
     * @param string $source_file_name_2 Name of the source file including extension
     * @return $this
     */
    public function setSourceFileName2($source_file_name_2)
    {
        $this->container['source_file_name_2'] = $source_file_name_2;

        return $this;
    }

    /**
     * Gets source_file_content_2
     * @return string
     */
    public function getSourceFileContent2()
    {
        return $this->container['source_file_content_2'];
    }

    /**
     * Sets source_file_content_2
     * @param string $source_file_content_2 Content of the file to merge
     * @return $this
     */
    public function setSourceFileContent2($source_file_content_2)
    {
        $this->container['source_file_content_2'] = $source_file_content_2;

        return $this;
    }

    /**
     * Gets source_file_name_3
     * @return string
     */
    public function getSourceFileName3()
    {
        return $this->container['source_file_name_3'];
    }

    /**
     * Sets source_file_name_3
     * @param string $source_file_name_3 Name of the source file including extension
     * @return $this
     */
    public function setSourceFileName3($source_file_name_3)
    {
        $this->container['source_file_name_3'] = $source_file_name_3;

        return $this;
    }

    /**
     * Gets source_file_content_3
     * @return string
     */
    public function getSourceFileContent3()
    {
        return $this->container['source_file_content_3'];
    }

    /**
     * Sets source_file_content_3
     * @param string $source_file_content_3 Content of the file to merge
     * @return $this
     */
    public function setSourceFileContent3($source_file_content_3)
    {
        $this->container['source_file_content_3'] = $source_file_content_3;

        return $this;
    }

    /**
     * Gets source_file_name_4
     * @return string
     */
    public function getSourceFileName4()
    {
        return $this->container['source_file_name_4'];
    }

    /**
     * Sets source_file_name_4
     * @param string $source_file_name_4 Name of the source file including extension
     * @return $this
     */
    public function setSourceFileName4($source_file_name_4)
    {
        $this->container['source_file_name_4'] = $source_file_name_4;

        return $this;
    }

    /**
     * Gets source_file_content_4
     * @return string
     */
    public function getSourceFileContent4()
    {
        return $this->container['source_file_content_4'];
    }

    /**
     * Sets source_file_content_4
     * @param string $source_file_content_4 Content of the file to merge
     * @return $this
     */
    public function setSourceFileContent4($source_file_content_4)
    {
        $this->container['source_file_content_4'] = $source_file_content_4;

        return $this;
    }

    /**
     * Gets source_file_name_5
     * @return string
     */
    public function getSourceFileName5()
    {
        return $this->container['source_file_name_5'];
    }

    /**
     * Sets source_file_name_5
     * @param string $source_file_name_5 Name of the source file including extension
     * @return $this
     */
    public function setSourceFileName5($source_file_name_5)
    {
        $this->container['source_file_name_5'] = $source_file_name_5;

        return $this;
    }

    /**
     * Gets source_file_content_5
     * @return string
     */
    public function getSourceFileContent5()
    {
        return $this->container['source_file_content_5'];
    }

    /**
     * Sets source_file_content_5
     * @param string $source_file_content_5 Content of the file to merge
     * @return $this
     */
    public function setSourceFileContent5($source_file_content_5)
    {
        $this->container['source_file_content_5'] = $source_file_content_5;

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
     * Gets sharepoint_field_name
     * @return string
     */
    public function getSharepointFieldName()
    {
        return $this->container['sharepoint_field_name'];
    }

    /**
     * Sets sharepoint_field_name
     * @param string $sharepoint_field_name Bookmark field name (For SharePoint only)
     * @return $this
     */
    public function setSharepointFieldName($sharepoint_field_name)
    {
        $this->container['sharepoint_field_name'] = $sharepoint_field_name;

        return $this;
    }

    /**
     * Gets document_start_page
     * @return string
     */
    public function getDocumentStartPage()
    {
        return $this->container['document_start_page'];
    }

    /**
     * Sets document_start_page
     * @param string $document_start_page Document start page
     * @return $this
     */
    public function setDocumentStartPage($document_start_page)
    {
        $allowed_values = array('Starts on the default page', 'Starts on the next page', 'Starts on the next odd page', 'Starts on the next even page');
        if (!is_null($document_start_page) && (!in_array($document_start_page, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'document_start_page', must be one of 'Starts on the default page', 'Starts on the next page', 'Starts on the next odd page', 'Starts on the next even page'");
        }
        $this->container['document_start_page'] = $document_start_page;

        return $this;
    }

    /**
     * Gets source_files
     * @return \MuhimbiPDFOnline\Client\Model\MergeSourceFile[]
     */
    public function getSourceFiles()
    {
        return $this->container['source_files'];
    }

    /**
     * Sets source_files
     * @param \MuhimbiPDFOnline\Client\Model\MergeSourceFile[] $source_files List of files to merge
     * @return $this
     */
    public function setSourceFiles($source_files)
    {
        $this->container['source_files'] = $source_files;

        return $this;
    }

    /**
     * Gets override_settings
     * @return string
     */
    public function getOverrideSettings()
    {
        return $this->container['override_settings'];
    }

    /**
     * Sets override_settings
     * @param string $override_settings Optional settings using Muhimbi's XML syntax
     * @return $this
     */
    public function setOverrideSettings($override_settings)
    {
        $this->container['override_settings'] = $override_settings;

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


