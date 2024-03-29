<?php
/**
 * ConvertCadData
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
 * ConvertCadData Class Doc Comment
 *
 * @category    Class
 * @description Parameters for Convert CAD operation
 * @package     MuhimbiPDFOnline\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class ConvertCadData implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'convert_cad_data';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'use_async_pattern' => 'bool',
        'source_file_name' => 'string',
        'sharepoint_file' => '\MuhimbiPDFOnline\Client\Model\SharepointFile',
        'source_file_content' => 'string',
        'copy_metadata' => 'bool',
        'paper_size' => 'string',
        'paper_size_custom' => 'string',
        'page_margins' => 'string',
        'background_color' => 'string',
        'foreground_color' => 'string',
        'foreground_color_custom' => 'string',
        'empty_layout_detection_mode' => 'string',
        'layout_sort_order' => 'string',
        'start_page' => 'int',
        'end_page' => 'int',
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
        'source_file_name' => 'source_file_name',
        'sharepoint_file' => 'sharepoint_file',
        'source_file_content' => 'source_file_content',
        'copy_metadata' => 'copy_metadata',
        'paper_size' => 'paper_size',
        'paper_size_custom' => 'paper_size_custom',
        'page_margins' => 'page_margins',
        'background_color' => 'background_color',
        'foreground_color' => 'foreground_color',
        'foreground_color_custom' => 'foreground_color_custom',
        'empty_layout_detection_mode' => 'empty_layout_detection_mode',
        'layout_sort_order' => 'layout_sort_order',
        'start_page' => 'start_page',
        'end_page' => 'end_page',
        'override_settings' => 'override_settings',
        'fail_on_error' => 'fail_on_error'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'use_async_pattern' => 'setUseAsyncPattern',
        'source_file_name' => 'setSourceFileName',
        'sharepoint_file' => 'setSharepointFile',
        'source_file_content' => 'setSourceFileContent',
        'copy_metadata' => 'setCopyMetadata',
        'paper_size' => 'setPaperSize',
        'paper_size_custom' => 'setPaperSizeCustom',
        'page_margins' => 'setPageMargins',
        'background_color' => 'setBackgroundColor',
        'foreground_color' => 'setForegroundColor',
        'foreground_color_custom' => 'setForegroundColorCustom',
        'empty_layout_detection_mode' => 'setEmptyLayoutDetectionMode',
        'layout_sort_order' => 'setLayoutSortOrder',
        'start_page' => 'setStartPage',
        'end_page' => 'setEndPage',
        'override_settings' => 'setOverrideSettings',
        'fail_on_error' => 'setFailOnError'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'use_async_pattern' => 'getUseAsyncPattern',
        'source_file_name' => 'getSourceFileName',
        'sharepoint_file' => 'getSharepointFile',
        'source_file_content' => 'getSourceFileContent',
        'copy_metadata' => 'getCopyMetadata',
        'paper_size' => 'getPaperSize',
        'paper_size_custom' => 'getPaperSizeCustom',
        'page_margins' => 'getPageMargins',
        'background_color' => 'getBackgroundColor',
        'foreground_color' => 'getForegroundColor',
        'foreground_color_custom' => 'getForegroundColorCustom',
        'empty_layout_detection_mode' => 'getEmptyLayoutDetectionMode',
        'layout_sort_order' => 'getLayoutSortOrder',
        'start_page' => 'getStartPage',
        'end_page' => 'getEndPage',
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

    const PAPER_SIZE_A3 = 'A3';
    const PAPER_SIZE_A4 = 'A4';
    const PAPER_SIZE_A5 = 'A5';
    const PAPER_SIZE_LEGAL = 'Legal';
    const PAPER_SIZE_LETTER = 'Letter';
    const PAPER_SIZE_CUSTOM = 'Custom';
    const FOREGROUND_COLOR_DEFAULT = 'Default';
    const FOREGROUND_COLOR_CORRECT_FOR_BACKGROUND = 'CorrectForBackground';
    const FOREGROUND_COLOR_GREYSCALE = 'Greyscale';
    const FOREGROUND_COLOR_GREYSCALE_DARKEN = 'GreyscaleDarken';
    const FOREGROUND_COLOR_GREYSCALE_LIGHTEN = 'GreyscaleLighten';
    const FOREGROUND_COLOR_DARKEN = 'Darken';
    const FOREGROUND_COLOR_LIGHTEN = 'Lighten';
    const FOREGROUND_COLOR_CUSTOM = 'Custom';
    const EMPTY_LAYOUT_DETECTION_MODE_DEFAULT = 'Default';
    const EMPTY_LAYOUT_DETECTION_MODE_SKIP_NONE = 'SkipNone';
    const EMPTY_LAYOUT_DETECTION_MODE_SKIP_EMPTY_LAYOUTS = 'SkipEmptyLayouts';
    const EMPTY_LAYOUT_DETECTION_MODE_SKIP_LAYOUTS_WITHOUT_VIEWPORTS = 'SkipLayoutsWithoutViewports';
    const LAYOUT_SORT_ORDER_DEFAULT = 'Default';
    const LAYOUT_SORT_ORDER_ASCENDING = 'Ascending';
    const LAYOUT_SORT_ORDER_DESCENDING = 'Descending';
    const LAYOUT_SORT_ORDER_TAB_ORDER = 'TabOrder';
    

    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getPaperSizeAllowableValues()
    {
        return [
            self::PAPER_SIZE_A3,
            self::PAPER_SIZE_A4,
            self::PAPER_SIZE_A5,
            self::PAPER_SIZE_LEGAL,
            self::PAPER_SIZE_LETTER,
            self::PAPER_SIZE_CUSTOM,
        ];
    }
    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getForegroundColorAllowableValues()
    {
        return [
            self::FOREGROUND_COLOR_DEFAULT,
            self::FOREGROUND_COLOR_CORRECT_FOR_BACKGROUND,
            self::FOREGROUND_COLOR_GREYSCALE,
            self::FOREGROUND_COLOR_GREYSCALE_DARKEN,
            self::FOREGROUND_COLOR_GREYSCALE_LIGHTEN,
            self::FOREGROUND_COLOR_DARKEN,
            self::FOREGROUND_COLOR_LIGHTEN,
            self::FOREGROUND_COLOR_CUSTOM,
        ];
    }
    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getEmptyLayoutDetectionModeAllowableValues()
    {
        return [
            self::EMPTY_LAYOUT_DETECTION_MODE_DEFAULT,
            self::EMPTY_LAYOUT_DETECTION_MODE_SKIP_NONE,
            self::EMPTY_LAYOUT_DETECTION_MODE_SKIP_EMPTY_LAYOUTS,
            self::EMPTY_LAYOUT_DETECTION_MODE_SKIP_LAYOUTS_WITHOUT_VIEWPORTS,
        ];
    }
    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getLayoutSortOrderAllowableValues()
    {
        return [
            self::LAYOUT_SORT_ORDER_DEFAULT,
            self::LAYOUT_SORT_ORDER_ASCENDING,
            self::LAYOUT_SORT_ORDER_DESCENDING,
            self::LAYOUT_SORT_ORDER_TAB_ORDER,
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
        $this->container['sharepoint_file'] = isset($data['sharepoint_file']) ? $data['sharepoint_file'] : null;
        $this->container['source_file_content'] = isset($data['source_file_content']) ? $data['source_file_content'] : null;
        $this->container['copy_metadata'] = isset($data['copy_metadata']) ? $data['copy_metadata'] : false;
        $this->container['paper_size'] = isset($data['paper_size']) ? $data['paper_size'] : 'Letter';
        $this->container['paper_size_custom'] = isset($data['paper_size_custom']) ? $data['paper_size_custom'] : null;
        $this->container['page_margins'] = isset($data['page_margins']) ? $data['page_margins'] : '0.25';
        $this->container['background_color'] = isset($data['background_color']) ? $data['background_color'] : 'White';
        $this->container['foreground_color'] = isset($data['foreground_color']) ? $data['foreground_color'] : 'GreyscaleDarken';
        $this->container['foreground_color_custom'] = isset($data['foreground_color_custom']) ? $data['foreground_color_custom'] : null;
        $this->container['empty_layout_detection_mode'] = isset($data['empty_layout_detection_mode']) ? $data['empty_layout_detection_mode'] : 'SkipEmptyLayouts';
        $this->container['layout_sort_order'] = isset($data['layout_sort_order']) ? $data['layout_sort_order'] : 'Ascending';
        $this->container['start_page'] = isset($data['start_page']) ? $data['start_page'] : null;
        $this->container['end_page'] = isset($data['end_page']) ? $data['end_page'] : null;
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
        if ($this->container['source_file_name'] === null) {
            $invalid_properties[] = "'source_file_name' can't be null";
        }
        if ($this->container['source_file_content'] === null) {
            $invalid_properties[] = "'source_file_content' can't be null";
        }
        if ($this->container['copy_metadata'] === null) {
            $invalid_properties[] = "'copy_metadata' can't be null";
        }
        $allowed_values = ["A3", "A4", "A5", "Legal", "Letter", "Custom"];
        if (!in_array($this->container['paper_size'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'paper_size', must be one of 'A3', 'A4', 'A5', 'Legal', 'Letter', 'Custom'.";
        }

        $allowed_values = ["Default", "CorrectForBackground", "Greyscale", "GreyscaleDarken", "GreyscaleLighten", "Darken", "Lighten", "Custom"];
        if (!in_array($this->container['foreground_color'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'foreground_color', must be one of 'Default', 'CorrectForBackground', 'Greyscale', 'GreyscaleDarken', 'GreyscaleLighten', 'Darken', 'Lighten', 'Custom'.";
        }

        $allowed_values = ["Default", "SkipNone", "SkipEmptyLayouts", "SkipLayoutsWithoutViewports"];
        if (!in_array($this->container['empty_layout_detection_mode'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'empty_layout_detection_mode', must be one of 'Default', 'SkipNone', 'SkipEmptyLayouts', 'SkipLayoutsWithoutViewports'.";
        }

        $allowed_values = ["Default", "Ascending", "Descending", "TabOrder"];
        if (!in_array($this->container['layout_sort_order'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'layout_sort_order', must be one of 'Default', 'Ascending', 'Descending', 'TabOrder'.";
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
        if ($this->container['copy_metadata'] === null) {
            return false;
        }
        $allowed_values = ["A3", "A4", "A5", "Legal", "Letter", "Custom"];
        if (!in_array($this->container['paper_size'], $allowed_values)) {
            return false;
        }
        $allowed_values = ["Default", "CorrectForBackground", "Greyscale", "GreyscaleDarken", "GreyscaleLighten", "Darken", "Lighten", "Custom"];
        if (!in_array($this->container['foreground_color'], $allowed_values)) {
            return false;
        }
        $allowed_values = ["Default", "SkipNone", "SkipEmptyLayouts", "SkipLayoutsWithoutViewports"];
        if (!in_array($this->container['empty_layout_detection_mode'], $allowed_values)) {
            return false;
        }
        $allowed_values = ["Default", "Ascending", "Descending", "TabOrder"];
        if (!in_array($this->container['layout_sort_order'], $allowed_values)) {
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
     * Gets source_file_content
     * @return string
     */
    public function getSourceFileContent()
    {
        return $this->container['source_file_content'];
    }

    /**
     * Sets source_file_content
     * @param string $source_file_content Content of the file to convert
     * @return $this
     */
    public function setSourceFileContent($source_file_content)
    {
        $this->container['source_file_content'] = $source_file_content;

        return $this;
    }

    /**
     * Gets copy_metadata
     * @return bool
     */
    public function getCopyMetadata()
    {
        return $this->container['copy_metadata'];
    }

    /**
     * Sets copy_metadata
     * @param bool $copy_metadata Copy metadata (Only for SharePoint operations)
     * @return $this
     */
    public function setCopyMetadata($copy_metadata)
    {
        $this->container['copy_metadata'] = $copy_metadata;

        return $this;
    }

    /**
     * Gets paper_size
     * @return string
     */
    public function getPaperSize()
    {
        return $this->container['paper_size'];
    }

    /**
     * Sets paper_size
     * @param string $paper_size Paper size for the output
     * @return $this
     */
    public function setPaperSize($paper_size)
    {
        $allowed_values = array('A3', 'A4', 'A5', 'Legal', 'Letter', 'Custom');
        if (!is_null($paper_size) && (!in_array($paper_size, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'paper_size', must be one of 'A3', 'A4', 'A5', 'Legal', 'Letter', 'Custom'");
        }
        $this->container['paper_size'] = $paper_size;

        return $this;
    }

    /**
     * Gets paper_size_custom
     * @return string
     */
    public function getPaperSizeCustom()
    {
        return $this->container['paper_size_custom'];
    }

    /**
     * Sets paper_size_custom
     * @param string $paper_size_custom Applicable if 'Paper size' is set to 'Custom'
     * @return $this
     */
    public function setPaperSizeCustom($paper_size_custom)
    {
        $this->container['paper_size_custom'] = $paper_size_custom;

        return $this;
    }

    /**
     * Gets page_margins
     * @return string
     */
    public function getPageMargins()
    {
        return $this->container['page_margins'];
    }

    /**
     * Sets page_margins
     * @param string $page_margins E.g. '1.5cm' (for uniform) or '0.5in, 0.25in, 0.5in, 0.25in' (for non-uniform) margins
     * @return $this
     */
    public function setPageMargins($page_margins)
    {
        $this->container['page_margins'] = $page_margins;

        return $this;
    }

    /**
     * Gets background_color
     * @return string
     */
    public function getBackgroundColor()
    {
        return $this->container['background_color'];
    }

    /**
     * Sets background_color
     * @param string $background_color .Net color name or hex color (#aarrggbb or #rrggbb)
     * @return $this
     */
    public function setBackgroundColor($background_color)
    {
        $this->container['background_color'] = $background_color;

        return $this;
    }

    /**
     * Gets foreground_color
     * @return string
     */
    public function getForegroundColor()
    {
        return $this->container['foreground_color'];
    }

    /**
     * Sets foreground_color
     * @param string $foreground_color The foreground effect or color
     * @return $this
     */
    public function setForegroundColor($foreground_color)
    {
        $allowed_values = array('Default', 'CorrectForBackground', 'Greyscale', 'GreyscaleDarken', 'GreyscaleLighten', 'Darken', 'Lighten', 'Custom');
        if (!is_null($foreground_color) && (!in_array($foreground_color, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'foreground_color', must be one of 'Default', 'CorrectForBackground', 'Greyscale', 'GreyscaleDarken', 'GreyscaleLighten', 'Darken', 'Lighten', 'Custom'");
        }
        $this->container['foreground_color'] = $foreground_color;

        return $this;
    }

    /**
     * Gets foreground_color_custom
     * @return string
     */
    public function getForegroundColorCustom()
    {
        return $this->container['foreground_color_custom'];
    }

    /**
     * Sets foreground_color_custom
     * @param string $foreground_color_custom .Net color name or hex color (#aarrggbb or #rrggbb). Applicable if 'Foreground color' is set to 'Custom'
     * @return $this
     */
    public function setForegroundColorCustom($foreground_color_custom)
    {
        $this->container['foreground_color_custom'] = $foreground_color_custom;

        return $this;
    }

    /**
     * Gets empty_layout_detection_mode
     * @return string
     */
    public function getEmptyLayoutDetectionMode()
    {
        return $this->container['empty_layout_detection_mode'];
    }

    /**
     * Sets empty_layout_detection_mode
     * @param string $empty_layout_detection_mode Select which layouts should be skipped
     * @return $this
     */
    public function setEmptyLayoutDetectionMode($empty_layout_detection_mode)
    {
        $allowed_values = array('Default', 'SkipNone', 'SkipEmptyLayouts', 'SkipLayoutsWithoutViewports');
        if (!is_null($empty_layout_detection_mode) && (!in_array($empty_layout_detection_mode, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'empty_layout_detection_mode', must be one of 'Default', 'SkipNone', 'SkipEmptyLayouts', 'SkipLayoutsWithoutViewports'");
        }
        $this->container['empty_layout_detection_mode'] = $empty_layout_detection_mode;

        return $this;
    }

    /**
     * Gets layout_sort_order
     * @return string
     */
    public function getLayoutSortOrder()
    {
        return $this->container['layout_sort_order'];
    }

    /**
     * Sets layout_sort_order
     * @param string $layout_sort_order Specify the sort order in which the layouts are converted
     * @return $this
     */
    public function setLayoutSortOrder($layout_sort_order)
    {
        $allowed_values = array('Default', 'Ascending', 'Descending', 'TabOrder');
        if (!is_null($layout_sort_order) && (!in_array($layout_sort_order, $allowed_values))) {
            throw new \InvalidArgumentException("Invalid value for 'layout_sort_order', must be one of 'Default', 'Ascending', 'Descending', 'TabOrder'");
        }
        $this->container['layout_sort_order'] = $layout_sort_order;

        return $this;
    }

    /**
     * Gets start_page
     * @return int
     */
    public function getStartPage()
    {
        return $this->container['start_page'];
    }

    /**
     * Sets start_page
     * @param int $start_page The first page to include
     * @return $this
     */
    public function setStartPage($start_page)
    {
        $this->container['start_page'] = $start_page;

        return $this;
    }

    /**
     * Gets end_page
     * @return int
     */
    public function getEndPage()
    {
        return $this->container['end_page'];
    }

    /**
     * Sets end_page
     * @param int $end_page The last page to include
     * @return $this
     */
    public function setEndPage($end_page)
    {
        $this->container['end_page'] = $end_page;

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


