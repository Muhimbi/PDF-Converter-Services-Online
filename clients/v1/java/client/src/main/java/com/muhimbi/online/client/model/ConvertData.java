/*
 * Muhimbi PDF
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.14
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
 * Parameters for Convert operation
 */
@ApiModel(description = "Parameters for Convert operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2020-06-02T17:07:48.610+01:00")
public class ConvertData {
  @SerializedName("use_async_pattern")
  private Boolean useAsyncPattern = false;

  @SerializedName("source_file_name")
  private String sourceFileName = null;

  @SerializedName("source_file_content")
  private String sourceFileContent = null;

  @SerializedName("sharepoint_file")
  private SharepointFile sharepointFile = null;

  /**
   * Output format
   */
  public enum OutputFormatEnum {
    @SerializedName("PDF")
    PDF("PDF"),
    
    @SerializedName("XPS")
    XPS("XPS"),
    
    @SerializedName("DOCX")
    DOCX("DOCX"),
    
    @SerializedName("DOC")
    DOC("DOC"),
    
    @SerializedName("ODT")
    ODT("ODT"),
    
    @SerializedName("RTF")
    RTF("RTF"),
    
    @SerializedName("TXT")
    TXT("TXT"),
    
    @SerializedName("MHT")
    MHT("MHT"),
    
    @SerializedName("HTML")
    HTML("HTML"),
    
    @SerializedName("XML")
    XML("XML"),
    
    @SerializedName("XLS")
    XLS("XLS"),
    
    @SerializedName("XLSX")
    XLSX("XLSX"),
    
    @SerializedName("CSV")
    CSV("CSV"),
    
    @SerializedName("ODS")
    ODS("ODS"),
    
    @SerializedName("PPT")
    PPT("PPT"),
    
    @SerializedName("PPTX")
    PPTX("PPTX"),
    
    @SerializedName("ODP")
    ODP("ODP"),
    
    @SerializedName("PPS")
    PPS("PPS"),
    
    @SerializedName("PPSX")
    PPSX("PPSX"),
    
    @SerializedName("TIFF")
    TIFF("TIFF"),
    
    @SerializedName("PNG")
    PNG("PNG"),
    
    @SerializedName("GIF")
    GIF("GIF"),
    
    @SerializedName("JPG")
    JPG("JPG"),
    
    @SerializedName("BMP")
    BMP("BMP"),
    
    @SerializedName("PS")
    PS("PS"),
    
    @SerializedName("PCL")
    PCL("PCL"),
    
    @SerializedName("EPS")
    EPS("EPS");

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

  @SerializedName("override_settings")
  private String overrideSettings = null;

  @SerializedName("template_file_content")
  private String templateFileContent = null;

  @SerializedName("fail_on_error")
  private Boolean failOnError = true;

  public ConvertData useAsyncPattern(Boolean useAsyncPattern) {
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

  public ConvertData sourceFileName(String sourceFileName) {
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

  public ConvertData sourceFileContent(String sourceFileContent) {
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

  public ConvertData sharepointFile(SharepointFile sharepointFile) {
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

  public ConvertData outputFormat(OutputFormatEnum outputFormat) {
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

  public ConvertData copyMetadata(Boolean copyMetadata) {
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

  public ConvertData overrideSettings(String overrideSettings) {
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

  public ConvertData templateFileContent(String templateFileContent) {
    this.templateFileContent = templateFileContent;
    return this;
  }

   /**
   * Optional template file content (e.g. infopath XSN file)
   * @return templateFileContent
  **/
  @ApiModelProperty(example = "null", value = "Optional template file content (e.g. infopath XSN file)")
  public String getTemplateFileContent() {
    return templateFileContent;
  }

  public void setTemplateFileContent(String templateFileContent) {
    this.templateFileContent = templateFileContent;
  }

  public ConvertData failOnError(Boolean failOnError) {
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
    ConvertData convertData = (ConvertData) o;
    return Objects.equals(this.useAsyncPattern, convertData.useAsyncPattern) &&
        Objects.equals(this.sourceFileName, convertData.sourceFileName) &&
        Objects.equals(this.sourceFileContent, convertData.sourceFileContent) &&
        Objects.equals(this.sharepointFile, convertData.sharepointFile) &&
        Objects.equals(this.outputFormat, convertData.outputFormat) &&
        Objects.equals(this.copyMetadata, convertData.copyMetadata) &&
        Objects.equals(this.overrideSettings, convertData.overrideSettings) &&
        Objects.equals(this.templateFileContent, convertData.templateFileContent) &&
        Objects.equals(this.failOnError, convertData.failOnError);
  }

  @Override
  public int hashCode() {
    return Objects.hash(useAsyncPattern, sourceFileName, sourceFileContent, sharepointFile, outputFormat, copyMetadata, overrideSettings, templateFileContent, failOnError);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConvertData {\n");
    
    sb.append("    useAsyncPattern: ").append(toIndentedString(useAsyncPattern)).append("\n");
    sb.append("    sourceFileName: ").append(toIndentedString(sourceFileName)).append("\n");
    sb.append("    sourceFileContent: ").append(toIndentedString(sourceFileContent)).append("\n");
    sb.append("    sharepointFile: ").append(toIndentedString(sharepointFile)).append("\n");
    sb.append("    outputFormat: ").append(toIndentedString(outputFormat)).append("\n");
    sb.append("    copyMetadata: ").append(toIndentedString(copyMetadata)).append("\n");
    sb.append("    overrideSettings: ").append(toIndentedString(overrideSettings)).append("\n");
    sb.append("    templateFileContent: ").append(toIndentedString(templateFileContent)).append("\n");
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

