/*
 * Muhimbi PDF
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.15
 * 
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
 * Parameters for ImageWatermark operation
 */
@ApiModel(description = "Parameters for ImageWatermark operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2021-12-10T11:11:05.941Z")
public class ImageWatermarkData {
  @SerializedName("source_file_name")
  private String sourceFileName = null;

  @SerializedName("use_async_pattern")
  private Boolean useAsyncPattern = false;

  @SerializedName("source_file_content")
  private String sourceFileContent = null;

  @SerializedName("image_file")
  private String imageFile = null;

  @SerializedName("sharepoint_file")
  private SharepointFile sharepointFile = null;

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

  @SerializedName("line_width")
  private String lineWidth = null;

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

  public ImageWatermarkData sourceFileName(String sourceFileName) {
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

  public ImageWatermarkData useAsyncPattern(Boolean useAsyncPattern) {
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

  public ImageWatermarkData sourceFileContent(String sourceFileContent) {
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

  public ImageWatermarkData imageFile(String imageFile) {
    this.imageFile = imageFile;
    return this;
  }

   /**
   * Image content or URL
   * @return imageFile
  **/
  @ApiModelProperty(example = "null", required = true, value = "Image content or URL")
  public String getImageFile() {
    return imageFile;
  }

  public void setImageFile(String imageFile) {
    this.imageFile = imageFile;
  }

  public ImageWatermarkData sharepointFile(SharepointFile sharepointFile) {
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

  public ImageWatermarkData position(PositionEnum position) {
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

  public ImageWatermarkData width(String width) {
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

  public ImageWatermarkData height(String height) {
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

  public ImageWatermarkData x(String x) {
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

  public ImageWatermarkData y(String y) {
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

  public ImageWatermarkData layer(LayerEnum layer) {
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

  public ImageWatermarkData rotation(String rotation) {
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

  public ImageWatermarkData opacity(String opacity) {
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

  public ImageWatermarkData fillColor(String fillColor) {
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

  public ImageWatermarkData lineColor(String lineColor) {
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

  public ImageWatermarkData lineWidth(String lineWidth) {
    this.lineWidth = lineWidth;
    return this;
  }

   /**
   * Width of the watermark outline (in Pts, 1/72 of an inch)
   * @return lineWidth
  **/
  @ApiModelProperty(example = "null", value = "Width of the watermark outline (in Pts, 1/72 of an inch)")
  public String getLineWidth() {
    return lineWidth;
  }

  public void setLineWidth(String lineWidth) {
    this.lineWidth = lineWidth;
  }

  public ImageWatermarkData startPage(Integer startPage) {
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

  public ImageWatermarkData endPage(Integer endPage) {
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

  public ImageWatermarkData pageInterval(Integer pageInterval) {
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

  public ImageWatermarkData pageOrientation(PageOrientationEnum pageOrientation) {
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

  public ImageWatermarkData printOnly(PrintOnlyEnum printOnly) {
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

  public ImageWatermarkData startSection(Integer startSection) {
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

  public ImageWatermarkData endSection(Integer endSection) {
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

  public ImageWatermarkData pageType(String pageType) {
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

  public ImageWatermarkData failOnError(Boolean failOnError) {
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
    ImageWatermarkData imageWatermarkData = (ImageWatermarkData) o;
    return Objects.equals(this.sourceFileName, imageWatermarkData.sourceFileName) &&
        Objects.equals(this.useAsyncPattern, imageWatermarkData.useAsyncPattern) &&
        Objects.equals(this.sourceFileContent, imageWatermarkData.sourceFileContent) &&
        Objects.equals(this.imageFile, imageWatermarkData.imageFile) &&
        Objects.equals(this.sharepointFile, imageWatermarkData.sharepointFile) &&
        Objects.equals(this.position, imageWatermarkData.position) &&
        Objects.equals(this.width, imageWatermarkData.width) &&
        Objects.equals(this.height, imageWatermarkData.height) &&
        Objects.equals(this.x, imageWatermarkData.x) &&
        Objects.equals(this.y, imageWatermarkData.y) &&
        Objects.equals(this.layer, imageWatermarkData.layer) &&
        Objects.equals(this.rotation, imageWatermarkData.rotation) &&
        Objects.equals(this.opacity, imageWatermarkData.opacity) &&
        Objects.equals(this.fillColor, imageWatermarkData.fillColor) &&
        Objects.equals(this.lineColor, imageWatermarkData.lineColor) &&
        Objects.equals(this.lineWidth, imageWatermarkData.lineWidth) &&
        Objects.equals(this.startPage, imageWatermarkData.startPage) &&
        Objects.equals(this.endPage, imageWatermarkData.endPage) &&
        Objects.equals(this.pageInterval, imageWatermarkData.pageInterval) &&
        Objects.equals(this.pageOrientation, imageWatermarkData.pageOrientation) &&
        Objects.equals(this.printOnly, imageWatermarkData.printOnly) &&
        Objects.equals(this.startSection, imageWatermarkData.startSection) &&
        Objects.equals(this.endSection, imageWatermarkData.endSection) &&
        Objects.equals(this.pageType, imageWatermarkData.pageType) &&
        Objects.equals(this.failOnError, imageWatermarkData.failOnError);
  }

  @Override
  public int hashCode() {
    return Objects.hash(sourceFileName, useAsyncPattern, sourceFileContent, imageFile, sharepointFile, position, width, height, x, y, layer, rotation, opacity, fillColor, lineColor, lineWidth, startPage, endPage, pageInterval, pageOrientation, printOnly, startSection, endSection, pageType, failOnError);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ImageWatermarkData {\n");
    
    sb.append("    sourceFileName: ").append(toIndentedString(sourceFileName)).append("\n");
    sb.append("    useAsyncPattern: ").append(toIndentedString(useAsyncPattern)).append("\n");
    sb.append("    sourceFileContent: ").append(toIndentedString(sourceFileContent)).append("\n");
    sb.append("    imageFile: ").append(toIndentedString(imageFile)).append("\n");
    sb.append("    sharepointFile: ").append(toIndentedString(sharepointFile)).append("\n");
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
    sb.append("    lineWidth: ").append(toIndentedString(lineWidth)).append("\n");
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

