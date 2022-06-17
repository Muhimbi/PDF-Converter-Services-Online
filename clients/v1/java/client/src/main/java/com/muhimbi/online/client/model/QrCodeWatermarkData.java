/*
 * Muhimbi PDF
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.16
 * Contact: support@muhimbi.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.muhimbi.online.client.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import com.muhimbi.online.client.model.SharepointFile;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * Parameters for QRCodeWatermark operation
 */
@ApiModel(description = "Parameters for QRCodeWatermark operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-05-17T15:20:03.344+01:00")
public class QrCodeWatermarkData {
  @SerializedName("source_file_name")
  private String sourceFileName = null;

  @SerializedName("use_async_pattern")
  private Boolean useAsyncPattern = false;

  @SerializedName("source_file_content")
  private String sourceFileContent = null;

  @SerializedName("content")
  private String content = null;

  @SerializedName("sharepoint_file")
  private SharepointFile sharepointFile = null;

  /**
   * Version
   */
  public enum VersionEnum {
    @SerializedName("Auto")
    AUTO("Auto"),
    
    @SerializedName("Version 1")
    VERSION_1("Version 1"),
    
    @SerializedName("Version 2")
    VERSION_2("Version 2"),
    
    @SerializedName("Version 3")
    VERSION_3("Version 3"),
    
    @SerializedName("Version 4")
    VERSION_4("Version 4"),
    
    @SerializedName("Version 5")
    VERSION_5("Version 5"),
    
    @SerializedName("Version 6")
    VERSION_6("Version 6"),
    
    @SerializedName("Version 7")
    VERSION_7("Version 7"),
    
    @SerializedName("Version 8")
    VERSION_8("Version 8"),
    
    @SerializedName("Version 9")
    VERSION_9("Version 9"),
    
    @SerializedName("Version 10")
    VERSION_10("Version 10"),
    
    @SerializedName("Version 11")
    VERSION_11("Version 11"),
    
    @SerializedName("Version 12")
    VERSION_12("Version 12"),
    
    @SerializedName("Version 13")
    VERSION_13("Version 13"),
    
    @SerializedName("Version 14")
    VERSION_14("Version 14"),
    
    @SerializedName("Version 15")
    VERSION_15("Version 15"),
    
    @SerializedName("Version 16")
    VERSION_16("Version 16"),
    
    @SerializedName("Version 17")
    VERSION_17("Version 17"),
    
    @SerializedName("Version 18")
    VERSION_18("Version 18"),
    
    @SerializedName("Version 19")
    VERSION_19("Version 19"),
    
    @SerializedName("Version 20")
    VERSION_20("Version 20"),
    
    @SerializedName("Version 21")
    VERSION_21("Version 21"),
    
    @SerializedName("Version 22")
    VERSION_22("Version 22"),
    
    @SerializedName("Version 23")
    VERSION_23("Version 23"),
    
    @SerializedName("Version 24")
    VERSION_24("Version 24"),
    
    @SerializedName("Version 25")
    VERSION_25("Version 25"),
    
    @SerializedName("Version 26")
    VERSION_26("Version 26"),
    
    @SerializedName("Version 27")
    VERSION_27("Version 27"),
    
    @SerializedName("Version 28")
    VERSION_28("Version 28"),
    
    @SerializedName("Version 29")
    VERSION_29("Version 29"),
    
    @SerializedName("Version 30")
    VERSION_30("Version 30"),
    
    @SerializedName("Version 31")
    VERSION_31("Version 31"),
    
    @SerializedName("Version 32")
    VERSION_32("Version 32"),
    
    @SerializedName("Version 33")
    VERSION_33("Version 33"),
    
    @SerializedName("Version 34")
    VERSION_34("Version 34"),
    
    @SerializedName("Version 35")
    VERSION_35("Version 35"),
    
    @SerializedName("Version 36")
    VERSION_36("Version 36"),
    
    @SerializedName("Version 37")
    VERSION_37("Version 37"),
    
    @SerializedName("Version 38")
    VERSION_38("Version 38"),
    
    @SerializedName("Version 39")
    VERSION_39("Version 39"),
    
    @SerializedName("Version 40")
    VERSION_40("Version 40");

    private String value;

    VersionEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("version")
  private VersionEnum version = VersionEnum.AUTO;

  /**
   * Input mode
   */
  public enum InputModeEnum {
    @SerializedName("Binary")
    BINARY("Binary"),
    
    @SerializedName("Alphanumeric")
    ALPHANUMERIC("Alphanumeric"),
    
    @SerializedName("Numeric")
    NUMERIC("Numeric");

    private String value;

    InputModeEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("input_mode")
  private InputModeEnum inputMode = InputModeEnum.BINARY;

  /**
   * Error correction level
   */
  public enum ErrorCorrectionLevelEnum {
    @SerializedName("Low")
    LOW("Low"),
    
    @SerializedName("Medium")
    MEDIUM("Medium"),
    
    @SerializedName("High")
    HIGH("High"),
    
    @SerializedName("Quartile")
    QUARTILE("Quartile");

    private String value;

    ErrorCorrectionLevelEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("error_correction_level")
  private ErrorCorrectionLevelEnum errorCorrectionLevel = ErrorCorrectionLevelEnum.LOW;

  /**
   * Watermark position on the page
   */
  public enum PositionEnum {
    @SerializedName("Top Left")
    TOP_LEFT("Top Left"),
    
    @SerializedName("Top Center")
    TOP_CENTER("Top Center"),
    
    @SerializedName("Top Right")
    TOP_RIGHT("Top Right"),
    
    @SerializedName("Middle Left")
    MIDDLE_LEFT("Middle Left"),
    
    @SerializedName("Middle Center")
    MIDDLE_CENTER("Middle Center"),
    
    @SerializedName("Middle Right")
    MIDDLE_RIGHT("Middle Right"),
    
    @SerializedName("Bottom Left")
    BOTTOM_LEFT("Bottom Left"),
    
    @SerializedName("Bottom Center")
    BOTTOM_CENTER("Bottom Center"),
    
    @SerializedName("Bottom Right")
    BOTTOM_RIGHT("Bottom Right"),
    
    @SerializedName("Absolute")
    ABSOLUTE("Absolute"),
    
    @SerializedName("Random")
    RANDOM("Random");

    private String value;

    PositionEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("position")
  private PositionEnum position = PositionEnum.MIDDLE_CENTER;

  @SerializedName("width")
  private String width = null;

  @SerializedName("height")
  private String height = null;

  @SerializedName("x")
  private String x = null;

  @SerializedName("y")
  private String y = null;

  /**
   * Watermark layer
   */
  public enum LayerEnum {
    @SerializedName("Background")
    BACKGROUND("Background"),
    
    @SerializedName("Foreground")
    FOREGROUND("Foreground");

    private String value;

    LayerEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("layer")
  private LayerEnum layer = LayerEnum.FOREGROUND;

  @SerializedName("rotation")
  private String rotation = null;

  @SerializedName("opacity")
  private String opacity = "100";

  @SerializedName("fill_color")
  private String fillColor = null;

  @SerializedName("line_color")
  private String lineColor = null;

  @SerializedName("start_page")
  private Integer startPage = null;

  @SerializedName("end_page")
  private Integer endPage = null;

  @SerializedName("page_interval")
  private Integer pageInterval = null;

  /**
   * Orientation of pages the watermark applies to.
   */
  public enum PageOrientationEnum {
    @SerializedName("Portrait")
    PORTRAIT("Portrait"),
    
    @SerializedName("Landscape")
    LANDSCAPE("Landscape"),
    
    @SerializedName("Both")
    BOTH("Both");

    private String value;

    PageOrientationEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("page_orientation")
  private PageOrientationEnum pageOrientation = PageOrientationEnum.BOTH;

  /**
   * Tells if the watermark is only visible when the document is printed
   */
  public enum PrintOnlyEnum {
    @SerializedName("false")
    FALSE("false"),
    
    @SerializedName("true")
    TRUE("true");

    private String value;

    PrintOnlyEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("print_only")
  private PrintOnlyEnum printOnly = PrintOnlyEnum.FALSE;

  @SerializedName("start_section")
  private Integer startSection = null;

  @SerializedName("end_section")
  private Integer endSection = null;

  @SerializedName("page_type")
  private String pageType = null;

  @SerializedName("fail_on_error")
  private Boolean failOnError = true;

  public QrCodeWatermarkData sourceFileName(String sourceFileName) {
    this.sourceFileName = sourceFileName;
    return this;
  }

   /**
   * Name of the source file including extension
   * @return sourceFileName
  **/
  @ApiModelProperty(example = "null", value = "Name of the source file including extension")
  public String getSourceFileName() {
    return sourceFileName;
  }

  public void setSourceFileName(String sourceFileName) {
    this.sourceFileName = sourceFileName;
  }

  public QrCodeWatermarkData useAsyncPattern(Boolean useAsyncPattern) {
    this.useAsyncPattern = useAsyncPattern;
    return this;
  }

   /**
   * Use async behaviour for API request
   * @return useAsyncPattern
  **/
  @ApiModelProperty(example = "null", required = true, value = "Use async behaviour for API request")
  public Boolean getUseAsyncPattern() {
    return useAsyncPattern;
  }

  public void setUseAsyncPattern(Boolean useAsyncPattern) {
    this.useAsyncPattern = useAsyncPattern;
  }

  public QrCodeWatermarkData sourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
    return this;
  }

   /**
   * Content of the file to watermark
   * @return sourceFileContent
  **/
  @ApiModelProperty(example = "null", required = true, value = "Content of the file to watermark")
  public String getSourceFileContent() {
    return sourceFileContent;
  }

  public void setSourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
  }

  public QrCodeWatermarkData content(String content) {
    this.content = content;
    return this;
  }

   /**
   * Data to embed in the QR Code
   * @return content
  **/
  @ApiModelProperty(example = "null", required = true, value = "Data to embed in the QR Code")
  public String getContent() {
    return content;
  }

  public void setContent(String content) {
    this.content = content;
  }

  public QrCodeWatermarkData sharepointFile(SharepointFile sharepointFile) {
    this.sharepointFile = sharepointFile;
    return this;
  }

   /**
   * Get sharepointFile
   * @return sharepointFile
  **/
  @ApiModelProperty(example = "null", value = "")
  public SharepointFile getSharepointFile() {
    return sharepointFile;
  }

  public void setSharepointFile(SharepointFile sharepointFile) {
    this.sharepointFile = sharepointFile;
  }

  public QrCodeWatermarkData version(VersionEnum version) {
    this.version = version;
    return this;
  }

   /**
   * Version
   * @return version
  **/
  @ApiModelProperty(example = "null", required = true, value = "Version")
  public VersionEnum getVersion() {
    return version;
  }

  public void setVersion(VersionEnum version) {
    this.version = version;
  }

  public QrCodeWatermarkData inputMode(InputModeEnum inputMode) {
    this.inputMode = inputMode;
    return this;
  }

   /**
   * Input mode
   * @return inputMode
  **/
  @ApiModelProperty(example = "null", required = true, value = "Input mode")
  public InputModeEnum getInputMode() {
    return inputMode;
  }

  public void setInputMode(InputModeEnum inputMode) {
    this.inputMode = inputMode;
  }

  public QrCodeWatermarkData errorCorrectionLevel(ErrorCorrectionLevelEnum errorCorrectionLevel) {
    this.errorCorrectionLevel = errorCorrectionLevel;
    return this;
  }

   /**
   * Error correction level
   * @return errorCorrectionLevel
  **/
  @ApiModelProperty(example = "null", required = true, value = "Error correction level")
  public ErrorCorrectionLevelEnum getErrorCorrectionLevel() {
    return errorCorrectionLevel;
  }

  public void setErrorCorrectionLevel(ErrorCorrectionLevelEnum errorCorrectionLevel) {
    this.errorCorrectionLevel = errorCorrectionLevel;
  }

  public QrCodeWatermarkData position(PositionEnum position) {
    this.position = position;
    return this;
  }

   /**
   * Watermark position on the page
   * @return position
  **/
  @ApiModelProperty(example = "null", required = true, value = "Watermark position on the page")
  public PositionEnum getPosition() {
    return position;
  }

  public void setPosition(PositionEnum position) {
    this.position = position;
  }

  public QrCodeWatermarkData width(String width) {
    this.width = width;
    return this;
  }

   /**
   * Width of the watermark (in Pts, 1/72 of an inch)
   * @return width
  **/
  @ApiModelProperty(example = "null", required = true, value = "Width of the watermark (in Pts, 1/72 of an inch)")
  public String getWidth() {
    return width;
  }

  public void setWidth(String width) {
    this.width = width;
  }

  public QrCodeWatermarkData height(String height) {
    this.height = height;
    return this;
  }

   /**
   * Height of the watermark (in Pts, 1/72 of an inch)
   * @return height
  **/
  @ApiModelProperty(example = "null", required = true, value = "Height of the watermark (in Pts, 1/72 of an inch)")
  public String getHeight() {
    return height;
  }

  public void setHeight(String height) {
    this.height = height;
  }

  public QrCodeWatermarkData x(String x) {
    this.x = x;
    return this;
  }

   /**
   * X Coordinate when 'Position' is set to 'Absolute' (in Pts, 1/72 of an inch)
   * @return x
  **/
  @ApiModelProperty(example = "null", value = "X Coordinate when 'Position' is set to 'Absolute' (in Pts, 1/72 of an inch)")
  public String getX() {
    return x;
  }

  public void setX(String x) {
    this.x = x;
  }

  public QrCodeWatermarkData y(String y) {
    this.y = y;
    return this;
  }

   /**
   * Y Coordinate when 'Position' is set to 'Absolute' (in Pts, 1/72 of an inch)
   * @return y
  **/
  @ApiModelProperty(example = "null", value = "Y Coordinate when 'Position' is set to 'Absolute' (in Pts, 1/72 of an inch)")
  public String getY() {
    return y;
  }

  public void setY(String y) {
    this.y = y;
  }

  public QrCodeWatermarkData layer(LayerEnum layer) {
    this.layer = layer;
    return this;
  }

   /**
   * Watermark layer
   * @return layer
  **/
  @ApiModelProperty(example = "null", value = "Watermark layer")
  public LayerEnum getLayer() {
    return layer;
  }

  public void setLayer(LayerEnum layer) {
    this.layer = layer;
  }

  public QrCodeWatermarkData rotation(String rotation) {
    this.rotation = rotation;
    return this;
  }

   /**
   * Angle of rotation
   * @return rotation
  **/
  @ApiModelProperty(example = "null", value = "Angle of rotation")
  public String getRotation() {
    return rotation;
  }

  public void setRotation(String rotation) {
    this.rotation = rotation;
  }

  public QrCodeWatermarkData opacity(String opacity) {
    this.opacity = opacity;
    return this;
  }

   /**
   * Opacity in % (100 is fully visible and 1 is barely visible)
   * @return opacity
  **/
  @ApiModelProperty(example = "null", value = "Opacity in % (100 is fully visible and 1 is barely visible)")
  public String getOpacity() {
    return opacity;
  }

  public void setOpacity(String opacity) {
    this.opacity = opacity;
  }

  public QrCodeWatermarkData fillColor(String fillColor) {
    this.fillColor = fillColor;
    return this;
  }

   /**
   * Color in #RRGGBB notation
   * @return fillColor
  **/
  @ApiModelProperty(example = "null", value = "Color in #RRGGBB notation")
  public String getFillColor() {
    return fillColor;
  }

  public void setFillColor(String fillColor) {
    this.fillColor = fillColor;
  }

  public QrCodeWatermarkData lineColor(String lineColor) {
    this.lineColor = lineColor;
    return this;
  }

   /**
   * Color in #RRGGBB notation
   * @return lineColor
  **/
  @ApiModelProperty(example = "null", value = "Color in #RRGGBB notation")
  public String getLineColor() {
    return lineColor;
  }

  public void setLineColor(String lineColor) {
    this.lineColor = lineColor;
  }

  public QrCodeWatermarkData startPage(Integer startPage) {
    this.startPage = startPage;
    return this;
  }

   /**
   * Number of the first page the watermark applies to
   * @return startPage
  **/
  @ApiModelProperty(example = "null", value = "Number of the first page the watermark applies to")
  public Integer getStartPage() {
    return startPage;
  }

  public void setStartPage(Integer startPage) {
    this.startPage = startPage;
  }

  public QrCodeWatermarkData endPage(Integer endPage) {
    this.endPage = endPage;
    return this;
  }

   /**
   * Number of the last page the watermark applies to
   * @return endPage
  **/
  @ApiModelProperty(example = "null", value = "Number of the last page the watermark applies to")
  public Integer getEndPage() {
    return endPage;
  }

  public void setEndPage(Integer endPage) {
    this.endPage = endPage;
  }

  public QrCodeWatermarkData pageInterval(Integer pageInterval) {
    this.pageInterval = pageInterval;
    return this;
  }

   /**
   * Which pages to display the watermark on (1=every page, 2=every other, etc)
   * @return pageInterval
  **/
  @ApiModelProperty(example = "null", value = "Which pages to display the watermark on (1=every page, 2=every other, etc)")
  public Integer getPageInterval() {
    return pageInterval;
  }

  public void setPageInterval(Integer pageInterval) {
    this.pageInterval = pageInterval;
  }

  public QrCodeWatermarkData pageOrientation(PageOrientationEnum pageOrientation) {
    this.pageOrientation = pageOrientation;
    return this;
  }

   /**
   * Orientation of pages the watermark applies to.
   * @return pageOrientation
  **/
  @ApiModelProperty(example = "null", value = "Orientation of pages the watermark applies to.")
  public PageOrientationEnum getPageOrientation() {
    return pageOrientation;
  }

  public void setPageOrientation(PageOrientationEnum pageOrientation) {
    this.pageOrientation = pageOrientation;
  }

  public QrCodeWatermarkData printOnly(PrintOnlyEnum printOnly) {
    this.printOnly = printOnly;
    return this;
  }

   /**
   * Tells if the watermark is only visible when the document is printed
   * @return printOnly
  **/
  @ApiModelProperty(example = "null", value = "Tells if the watermark is only visible when the document is printed")
  public PrintOnlyEnum getPrintOnly() {
    return printOnly;
  }

  public void setPrintOnly(PrintOnlyEnum printOnly) {
    this.printOnly = printOnly;
  }

  public QrCodeWatermarkData startSection(Integer startSection) {
    this.startSection = startSection;
    return this;
  }

   /**
   * The first section in a Word or Excel document the watermark is visible
   * @return startSection
  **/
  @ApiModelProperty(example = "null", value = "The first section in a Word or Excel document the watermark is visible")
  public Integer getStartSection() {
    return startSection;
  }

  public void setStartSection(Integer startSection) {
    this.startSection = startSection;
  }

  public QrCodeWatermarkData endSection(Integer endSection) {
    this.endSection = endSection;
    return this;
  }

   /**
   * The last section in a Word or Excel document the watermark is visible
   * @return endSection
  **/
  @ApiModelProperty(example = "null", value = "The last section in a Word or Excel document the watermark is visible")
  public Integer getEndSection() {
    return endSection;
  }

  public void setEndSection(Integer endSection) {
    this.endSection = endSection;
  }

  public QrCodeWatermarkData pageType(String pageType) {
    this.pageType = pageType;
    return this;
  }

   /**
   * One or more page types for Word and Excel documents, eg. default|first|even
   * @return pageType
  **/
  @ApiModelProperty(example = "null", value = "One or more page types for Word and Excel documents, eg. default|first|even")
  public String getPageType() {
    return pageType;
  }

  public void setPageType(String pageType) {
    this.pageType = pageType;
  }

  public QrCodeWatermarkData failOnError(Boolean failOnError) {
    this.failOnError = failOnError;
    return this;
  }

   /**
   * Fail on error
   * @return failOnError
  **/
  @ApiModelProperty(example = "null", value = "Fail on error")
  public Boolean getFailOnError() {
    return failOnError;
  }

  public void setFailOnError(Boolean failOnError) {
    this.failOnError = failOnError;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    QrCodeWatermarkData qrCodeWatermarkData = (QrCodeWatermarkData) o;
    return Objects.equals(this.sourceFileName, qrCodeWatermarkData.sourceFileName) &&
        Objects.equals(this.useAsyncPattern, qrCodeWatermarkData.useAsyncPattern) &&
        Objects.equals(this.sourceFileContent, qrCodeWatermarkData.sourceFileContent) &&
        Objects.equals(this.content, qrCodeWatermarkData.content) &&
        Objects.equals(this.sharepointFile, qrCodeWatermarkData.sharepointFile) &&
        Objects.equals(this.version, qrCodeWatermarkData.version) &&
        Objects.equals(this.inputMode, qrCodeWatermarkData.inputMode) &&
        Objects.equals(this.errorCorrectionLevel, qrCodeWatermarkData.errorCorrectionLevel) &&
        Objects.equals(this.position, qrCodeWatermarkData.position) &&
        Objects.equals(this.width, qrCodeWatermarkData.width) &&
        Objects.equals(this.height, qrCodeWatermarkData.height) &&
        Objects.equals(this.x, qrCodeWatermarkData.x) &&
        Objects.equals(this.y, qrCodeWatermarkData.y) &&
        Objects.equals(this.layer, qrCodeWatermarkData.layer) &&
        Objects.equals(this.rotation, qrCodeWatermarkData.rotation) &&
        Objects.equals(this.opacity, qrCodeWatermarkData.opacity) &&
        Objects.equals(this.fillColor, qrCodeWatermarkData.fillColor) &&
        Objects.equals(this.lineColor, qrCodeWatermarkData.lineColor) &&
        Objects.equals(this.startPage, qrCodeWatermarkData.startPage) &&
        Objects.equals(this.endPage, qrCodeWatermarkData.endPage) &&
        Objects.equals(this.pageInterval, qrCodeWatermarkData.pageInterval) &&
        Objects.equals(this.pageOrientation, qrCodeWatermarkData.pageOrientation) &&
        Objects.equals(this.printOnly, qrCodeWatermarkData.printOnly) &&
        Objects.equals(this.startSection, qrCodeWatermarkData.startSection) &&
        Objects.equals(this.endSection, qrCodeWatermarkData.endSection) &&
        Objects.equals(this.pageType, qrCodeWatermarkData.pageType) &&
        Objects.equals(this.failOnError, qrCodeWatermarkData.failOnError);
  }

  @Override
  public int hashCode() {
    return Objects.hash(sourceFileName, useAsyncPattern, sourceFileContent, content, sharepointFile, version, inputMode, errorCorrectionLevel, position, width, height, x, y, layer, rotation, opacity, fillColor, lineColor, startPage, endPage, pageInterval, pageOrientation, printOnly, startSection, endSection, pageType, failOnError);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class QrCodeWatermarkData {\n");
    
    sb.append("    sourceFileName: ").append(toIndentedString(sourceFileName)).append("\n");
    sb.append("    useAsyncPattern: ").append(toIndentedString(useAsyncPattern)).append("\n");
    sb.append("    sourceFileContent: ").append(toIndentedString(sourceFileContent)).append("\n");
    sb.append("    content: ").append(toIndentedString(content)).append("\n");
    sb.append("    sharepointFile: ").append(toIndentedString(sharepointFile)).append("\n");
    sb.append("    version: ").append(toIndentedString(version)).append("\n");
    sb.append("    inputMode: ").append(toIndentedString(inputMode)).append("\n");
    sb.append("    errorCorrectionLevel: ").append(toIndentedString(errorCorrectionLevel)).append("\n");
    sb.append("    position: ").append(toIndentedString(position)).append("\n");
    sb.append("    width: ").append(toIndentedString(width)).append("\n");
    sb.append("    height: ").append(toIndentedString(height)).append("\n");
    sb.append("    x: ").append(toIndentedString(x)).append("\n");
    sb.append("    y: ").append(toIndentedString(y)).append("\n");
    sb.append("    layer: ").append(toIndentedString(layer)).append("\n");
    sb.append("    rotation: ").append(toIndentedString(rotation)).append("\n");
    sb.append("    opacity: ").append(toIndentedString(opacity)).append("\n");
    sb.append("    fillColor: ").append(toIndentedString(fillColor)).append("\n");
    sb.append("    lineColor: ").append(toIndentedString(lineColor)).append("\n");
    sb.append("    startPage: ").append(toIndentedString(startPage)).append("\n");
    sb.append("    endPage: ").append(toIndentedString(endPage)).append("\n");
    sb.append("    pageInterval: ").append(toIndentedString(pageInterval)).append("\n");
    sb.append("    pageOrientation: ").append(toIndentedString(pageOrientation)).append("\n");
    sb.append("    printOnly: ").append(toIndentedString(printOnly)).append("\n");
    sb.append("    startSection: ").append(toIndentedString(startSection)).append("\n");
    sb.append("    endSection: ").append(toIndentedString(endSection)).append("\n");
    sb.append("    pageType: ").append(toIndentedString(pageType)).append("\n");
    sb.append("    failOnError: ").append(toIndentedString(failOnError)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

