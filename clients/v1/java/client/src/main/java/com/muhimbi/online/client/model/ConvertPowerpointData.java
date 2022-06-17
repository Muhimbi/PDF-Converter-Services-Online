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
 * Parameters for Convert Excel operation
 */
@ApiModel(description = "Parameters for Convert Excel operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-05-17T15:20:03.344+01:00")
public class ConvertPowerpointData {
  @SerializedName("use_async_pattern")
  private Boolean useAsyncPattern = false;

  @SerializedName("source_file_name")
  private String sourceFileName = null;

  @SerializedName("sharepoint_file")
  private SharepointFile sharepointFile = null;

  @SerializedName("source_file_content")
  private String sourceFileContent = null;

  /**
   * Output format
   */
  public enum OutputFormatEnum {
    @SerializedName("PDF")
    PDF("PDF"),
    
    @SerializedName("XPS")
    XPS("XPS"),
    
    @SerializedName("MHT")
    MHT("MHT"),
    
    @SerializedName("XML")
    XML("XML"),
    
    @SerializedName("PPT")
    PPT("PPT"),
    
    @SerializedName("PPTX")
    PPTX("PPTX"),
    
    @SerializedName("ODP")
    ODP("ODP"),
    
    @SerializedName("PPS")
    PPS("PPS"),
    
    @SerializedName("PPSX")
    PPSX("PPSX");

    private String value;

    OutputFormatEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("output_format")
  private OutputFormatEnum outputFormat = OutputFormatEnum.PDF;

  @SerializedName("copy_metadata")
  private Boolean copyMetadata = false;

  /**
   * Specify which parts of the document to process
   */
  public enum RangeEnum {
    @SerializedName("VisibleDocuments")
    VISIBLEDOCUMENTS("VisibleDocuments"),
    
    @SerializedName("AllDocuments")
    ALLDOCUMENTS("AllDocuments"),
    
    @SerializedName("ActiveDocuments")
    ACTIVEDOCUMENTS("ActiveDocuments");

    private String value;

    RangeEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("range")
  private RangeEnum range = null;

  /**
   * Specify how you would like the output to be arranged
   */
  public enum PrintOutputTypeEnum {
    @SerializedName("Slides")
    SLIDES("Slides"),
    
    @SerializedName("OneSlideHandouts")
    ONESLIDEHANDOUTS("OneSlideHandouts"),
    
    @SerializedName("TwoSlideHandouts")
    TWOSLIDEHANDOUTS("TwoSlideHandouts"),
    
    @SerializedName("ThreeSlideHandouts")
    THREESLIDEHANDOUTS("ThreeSlideHandouts"),
    
    @SerializedName("FourSlideHandouts")
    FOURSLIDEHANDOUTS("FourSlideHandouts"),
    
    @SerializedName("SixSlideHandouts")
    SIXSLIDEHANDOUTS("SixSlideHandouts"),
    
    @SerializedName("NineSlideHandouts")
    NINESLIDEHANDOUTS("NineSlideHandouts"),
    
    @SerializedName("NotesPages")
    NOTESPAGES("NotesPages"),
    
    @SerializedName("Outline")
    OUTLINE("Outline");

    private String value;

    PrintOutputTypeEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("print_output_type")
  private PrintOutputTypeEnum printOutputType = PrintOutputTypeEnum.SLIDES;

  @SerializedName("frame_slides")
  private Boolean frameSlides = true;

  @SerializedName("start_page")
  private Integer startPage = null;

  @SerializedName("end_page")
  private Integer endPage = null;

  /**
   * Quality of the output file
   */
  public enum QualityEnum {
    @SerializedName("OptimizeForPrint")
    OPTIMIZEFORPRINT("OptimizeForPrint"),
    
    @SerializedName("OptimizeForOnScreen")
    OPTIMIZEFORONSCREEN("OptimizeForOnScreen"),
    
    @SerializedName("Original")
    ORIGINAL("Original");

    private String value;

    QualityEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("quality")
  private QualityEnum quality = null;

  @SerializedName("override_settings")
  private String overrideSettings = null;

  @SerializedName("fail_on_error")
  private Boolean failOnError = true;

  public ConvertPowerpointData useAsyncPattern(Boolean useAsyncPattern) {
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

  public ConvertPowerpointData sourceFileName(String sourceFileName) {
    this.sourceFileName = sourceFileName;
    return this;
  }

   /**
   * Name of the source file including extension
   * @return sourceFileName
  **/
  @ApiModelProperty(example = "null", required = true, value = "Name of the source file including extension")
  public String getSourceFileName() {
    return sourceFileName;
  }

  public void setSourceFileName(String sourceFileName) {
    this.sourceFileName = sourceFileName;
  }

  public ConvertPowerpointData sharepointFile(SharepointFile sharepointFile) {
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

  public ConvertPowerpointData sourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
    return this;
  }

   /**
   * Content of the file to convert
   * @return sourceFileContent
  **/
  @ApiModelProperty(example = "null", required = true, value = "Content of the file to convert")
  public String getSourceFileContent() {
    return sourceFileContent;
  }

  public void setSourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
  }

  public ConvertPowerpointData outputFormat(OutputFormatEnum outputFormat) {
    this.outputFormat = outputFormat;
    return this;
  }

   /**
   * Output format
   * @return outputFormat
  **/
  @ApiModelProperty(example = "null", required = true, value = "Output format")
  public OutputFormatEnum getOutputFormat() {
    return outputFormat;
  }

  public void setOutputFormat(OutputFormatEnum outputFormat) {
    this.outputFormat = outputFormat;
  }

  public ConvertPowerpointData copyMetadata(Boolean copyMetadata) {
    this.copyMetadata = copyMetadata;
    return this;
  }

   /**
   * Copy metadata (Only for SharePoint operations)
   * @return copyMetadata
  **/
  @ApiModelProperty(example = "null", required = true, value = "Copy metadata (Only for SharePoint operations)")
  public Boolean getCopyMetadata() {
    return copyMetadata;
  }

  public void setCopyMetadata(Boolean copyMetadata) {
    this.copyMetadata = copyMetadata;
  }

  public ConvertPowerpointData range(RangeEnum range) {
    this.range = range;
    return this;
  }

   /**
   * Specify which parts of the document to process
   * @return range
  **/
  @ApiModelProperty(example = "null", value = "Specify which parts of the document to process")
  public RangeEnum getRange() {
    return range;
  }

  public void setRange(RangeEnum range) {
    this.range = range;
  }

  public ConvertPowerpointData printOutputType(PrintOutputTypeEnum printOutputType) {
    this.printOutputType = printOutputType;
    return this;
  }

   /**
   * Specify how you would like the output to be arranged
   * @return printOutputType
  **/
  @ApiModelProperty(example = "null", value = "Specify how you would like the output to be arranged")
  public PrintOutputTypeEnum getPrintOutputType() {
    return printOutputType;
  }

  public void setPrintOutputType(PrintOutputTypeEnum printOutputType) {
    this.printOutputType = printOutputType;
  }

  public ConvertPowerpointData frameSlides(Boolean frameSlides) {
    this.frameSlides = frameSlides;
    return this;
  }

   /**
   * Include a frame / border around the slides
   * @return frameSlides
  **/
  @ApiModelProperty(example = "null", value = "Include a frame / border around the slides")
  public Boolean getFrameSlides() {
    return frameSlides;
  }

  public void setFrameSlides(Boolean frameSlides) {
    this.frameSlides = frameSlides;
  }

  public ConvertPowerpointData startPage(Integer startPage) {
    this.startPage = startPage;
    return this;
  }

   /**
   * The first page to include
   * @return startPage
  **/
  @ApiModelProperty(example = "null", value = "The first page to include")
  public Integer getStartPage() {
    return startPage;
  }

  public void setStartPage(Integer startPage) {
    this.startPage = startPage;
  }

  public ConvertPowerpointData endPage(Integer endPage) {
    this.endPage = endPage;
    return this;
  }

   /**
   * The last page to include
   * @return endPage
  **/
  @ApiModelProperty(example = "null", value = "The last page to include")
  public Integer getEndPage() {
    return endPage;
  }

  public void setEndPage(Integer endPage) {
    this.endPage = endPage;
  }

  public ConvertPowerpointData quality(QualityEnum quality) {
    this.quality = quality;
    return this;
  }

   /**
   * Quality of the output file
   * @return quality
  **/
  @ApiModelProperty(example = "null", value = "Quality of the output file")
  public QualityEnum getQuality() {
    return quality;
  }

  public void setQuality(QualityEnum quality) {
    this.quality = quality;
  }

  public ConvertPowerpointData overrideSettings(String overrideSettings) {
    this.overrideSettings = overrideSettings;
    return this;
  }

   /**
   * Optional settings using Muhimbi's XML syntax
   * @return overrideSettings
  **/
  @ApiModelProperty(example = "null", value = "Optional settings using Muhimbi's XML syntax")
  public String getOverrideSettings() {
    return overrideSettings;
  }

  public void setOverrideSettings(String overrideSettings) {
    this.overrideSettings = overrideSettings;
  }

  public ConvertPowerpointData failOnError(Boolean failOnError) {
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
    ConvertPowerpointData convertPowerpointData = (ConvertPowerpointData) o;
    return Objects.equals(this.useAsyncPattern, convertPowerpointData.useAsyncPattern) &&
        Objects.equals(this.sourceFileName, convertPowerpointData.sourceFileName) &&
        Objects.equals(this.sharepointFile, convertPowerpointData.sharepointFile) &&
        Objects.equals(this.sourceFileContent, convertPowerpointData.sourceFileContent) &&
        Objects.equals(this.outputFormat, convertPowerpointData.outputFormat) &&
        Objects.equals(this.copyMetadata, convertPowerpointData.copyMetadata) &&
        Objects.equals(this.range, convertPowerpointData.range) &&
        Objects.equals(this.printOutputType, convertPowerpointData.printOutputType) &&
        Objects.equals(this.frameSlides, convertPowerpointData.frameSlides) &&
        Objects.equals(this.startPage, convertPowerpointData.startPage) &&
        Objects.equals(this.endPage, convertPowerpointData.endPage) &&
        Objects.equals(this.quality, convertPowerpointData.quality) &&
        Objects.equals(this.overrideSettings, convertPowerpointData.overrideSettings) &&
        Objects.equals(this.failOnError, convertPowerpointData.failOnError);
  }

  @Override
  public int hashCode() {
    return Objects.hash(useAsyncPattern, sourceFileName, sharepointFile, sourceFileContent, outputFormat, copyMetadata, range, printOutputType, frameSlides, startPage, endPage, quality, overrideSettings, failOnError);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConvertPowerpointData {\n");
    
    sb.append("    useAsyncPattern: ").append(toIndentedString(useAsyncPattern)).append("\n");
    sb.append("    sourceFileName: ").append(toIndentedString(sourceFileName)).append("\n");
    sb.append("    sharepointFile: ").append(toIndentedString(sharepointFile)).append("\n");
    sb.append("    sourceFileContent: ").append(toIndentedString(sourceFileContent)).append("\n");
    sb.append("    outputFormat: ").append(toIndentedString(outputFormat)).append("\n");
    sb.append("    copyMetadata: ").append(toIndentedString(copyMetadata)).append("\n");
    sb.append("    range: ").append(toIndentedString(range)).append("\n");
    sb.append("    printOutputType: ").append(toIndentedString(printOutputType)).append("\n");
    sb.append("    frameSlides: ").append(toIndentedString(frameSlides)).append("\n");
    sb.append("    startPage: ").append(toIndentedString(startPage)).append("\n");
    sb.append("    endPage: ").append(toIndentedString(endPage)).append("\n");
    sb.append("    quality: ").append(toIndentedString(quality)).append("\n");
    sb.append("    overrideSettings: ").append(toIndentedString(overrideSettings)).append("\n");
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

