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
 * Parameters for OCRText operation
 */
@ApiModel(description = "Parameters for OCRText operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2021-12-10T11:11:05.941Z")
public class OcrPdfData {
  @SerializedName("use_async_pattern")
  private Boolean useAsyncPattern = false;

  @SerializedName("source_file_name")
  private String sourceFileName = null;

  @SerializedName("source_file_content")
  private String sourceFileContent = null;

  @SerializedName("sharepoint_file")
  private SharepointFile sharepointFile = null;

  @SerializedName("copy_metadata")
  private Boolean copyMetadata = false;

  /**
   * Language
   */
  public enum LanguageEnum {
    @SerializedName("English")
    ENGLISH("English"),
    
    @SerializedName("Arabic")
    ARABIC("Arabic"),
    
    @SerializedName("Danish")
    DANISH("Danish"),
    
    @SerializedName("German")
    GERMAN("German"),
    
    @SerializedName("Dutch")
    DUTCH("Dutch"),
    
    @SerializedName("Finnish")
    FINNISH("Finnish"),
    
    @SerializedName("French")
    FRENCH("French"),
    
    @SerializedName("Hebrew")
    HEBREW("Hebrew"),
    
    @SerializedName("Hungarian")
    HUNGARIAN("Hungarian"),
    
    @SerializedName("Italian")
    ITALIAN("Italian"),
    
    @SerializedName("Norwegian")
    NORWEGIAN("Norwegian"),
    
    @SerializedName("Portuguese")
    PORTUGUESE("Portuguese"),
    
    @SerializedName("Spanish")
    SPANISH("Spanish"),
    
    @SerializedName("Swedish")
    SWEDISH("Swedish"),
    
    @SerializedName("Russian")
    RUSSIAN("Russian");

    private String value;

    LanguageEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("language")
  private LanguageEnum language = LanguageEnum.ENGLISH;

  /**
   * Performance
   */
  public enum PerformanceEnum {
    @SerializedName("Slow but accurate")
    SLOW_BUT_ACCURATE("Slow but accurate"),
    
    @SerializedName("Faster and less accurate")
    FASTER_AND_LESS_ACCURATE("Faster and less accurate"),
    
    @SerializedName("Fastest and least accurate")
    FASTEST_AND_LEAST_ACCURATE("Fastest and least accurate");

    private String value;

    PerformanceEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("performance")
  private PerformanceEnum performance = PerformanceEnum.SLOW_BUT_ACCURATE;

  /**
   * Characters option
   */
  public enum CharactersOptionEnum {
    @SerializedName("None")
    NONE("None"),
    
    @SerializedName("Whitelist")
    WHITELIST("Whitelist"),
    
    @SerializedName("Blacklist")
    BLACKLIST("Blacklist");

    private String value;

    CharactersOptionEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("characters_option")
  private CharactersOptionEnum charactersOption = CharactersOptionEnum.NONE;

  @SerializedName("characters")
  private String characters = null;

  @SerializedName("paginate")
  private Boolean paginate = false;

  @SerializedName("regions")
  private String regions = null;

  @SerializedName("fail_on_error")
  private Boolean failOnError = true;

  public OcrPdfData useAsyncPattern(Boolean useAsyncPattern) {
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

  public OcrPdfData sourceFileName(String sourceFileName) {
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

  public OcrPdfData sourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
    return this;
  }

   /**
   * Content of the file to OCR
   * @return sourceFileContent
  **/
  @ApiModelProperty(example = "null", required = true, value = "Content of the file to OCR")
  public String getSourceFileContent() {
    return sourceFileContent;
  }

  public void setSourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
  }

  public OcrPdfData sharepointFile(SharepointFile sharepointFile) {
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

  public OcrPdfData copyMetadata(Boolean copyMetadata) {
    this.copyMetadata = copyMetadata;
    return this;
  }

   /**
   * Copy metadata (For SharePoint only)
   * @return copyMetadata
  **/
  @ApiModelProperty(example = "null", required = true, value = "Copy metadata (For SharePoint only)")
  public Boolean getCopyMetadata() {
    return copyMetadata;
  }

  public void setCopyMetadata(Boolean copyMetadata) {
    this.copyMetadata = copyMetadata;
  }

  public OcrPdfData language(LanguageEnum language) {
    this.language = language;
    return this;
  }

   /**
   * Language
   * @return language
  **/
  @ApiModelProperty(example = "null", value = "Language")
  public LanguageEnum getLanguage() {
    return language;
  }

  public void setLanguage(LanguageEnum language) {
    this.language = language;
  }

  public OcrPdfData performance(PerformanceEnum performance) {
    this.performance = performance;
    return this;
  }

   /**
   * Performance
   * @return performance
  **/
  @ApiModelProperty(example = "null", value = "Performance")
  public PerformanceEnum getPerformance() {
    return performance;
  }

  public void setPerformance(PerformanceEnum performance) {
    this.performance = performance;
  }

  public OcrPdfData charactersOption(CharactersOptionEnum charactersOption) {
    this.charactersOption = charactersOption;
    return this;
  }

   /**
   * Characters option
   * @return charactersOption
  **/
  @ApiModelProperty(example = "null", value = "Characters option")
  public CharactersOptionEnum getCharactersOption() {
    return charactersOption;
  }

  public void setCharactersOption(CharactersOptionEnum charactersOption) {
    this.charactersOption = charactersOption;
  }

  public OcrPdfData characters(String characters) {
    this.characters = characters;
    return this;
  }

   /**
   * Characters to blacklist or whitelist
   * @return characters
  **/
  @ApiModelProperty(example = "null", value = "Characters to blacklist or whitelist")
  public String getCharacters() {
    return characters;
  }

  public void setCharacters(String characters) {
    this.characters = characters;
  }

  public OcrPdfData paginate(Boolean paginate) {
    this.paginate = paginate;
    return this;
  }

   /**
   * Paginate
   * @return paginate
  **/
  @ApiModelProperty(example = "null", value = "Paginate")
  public Boolean getPaginate() {
    return paginate;
  }

  public void setPaginate(Boolean paginate) {
    this.paginate = paginate;
  }

  public OcrPdfData regions(String regions) {
    this.regions = regions;
    return this;
  }

   /**
   * Limit the area to OCR to one or more specific areas
   * @return regions
  **/
  @ApiModelProperty(example = "null", value = "Limit the area to OCR to one or more specific areas")
  public String getRegions() {
    return regions;
  }

  public void setRegions(String regions) {
    this.regions = regions;
  }

  public OcrPdfData failOnError(Boolean failOnError) {
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
    OcrPdfData ocrPdfData = (OcrPdfData) o;
    return Objects.equals(this.useAsyncPattern, ocrPdfData.useAsyncPattern) &&
        Objects.equals(this.sourceFileName, ocrPdfData.sourceFileName) &&
        Objects.equals(this.sourceFileContent, ocrPdfData.sourceFileContent) &&
        Objects.equals(this.sharepointFile, ocrPdfData.sharepointFile) &&
        Objects.equals(this.copyMetadata, ocrPdfData.copyMetadata) &&
        Objects.equals(this.language, ocrPdfData.language) &&
        Objects.equals(this.performance, ocrPdfData.performance) &&
        Objects.equals(this.charactersOption, ocrPdfData.charactersOption) &&
        Objects.equals(this.characters, ocrPdfData.characters) &&
        Objects.equals(this.paginate, ocrPdfData.paginate) &&
        Objects.equals(this.regions, ocrPdfData.regions) &&
        Objects.equals(this.failOnError, ocrPdfData.failOnError);
  }

  @Override
  public int hashCode() {
    return Objects.hash(useAsyncPattern, sourceFileName, sourceFileContent, sharepointFile, copyMetadata, language, performance, charactersOption, characters, paginate, regions, failOnError);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OcrPdfData {\n");
    
    sb.append("    useAsyncPattern: ").append(toIndentedString(useAsyncPattern)).append("\n");
    sb.append("    sourceFileName: ").append(toIndentedString(sourceFileName)).append("\n");
    sb.append("    sourceFileContent: ").append(toIndentedString(sourceFileContent)).append("\n");
    sb.append("    sharepointFile: ").append(toIndentedString(sharepointFile)).append("\n");
    sb.append("    copyMetadata: ").append(toIndentedString(copyMetadata)).append("\n");
    sb.append("    language: ").append(toIndentedString(language)).append("\n");
    sb.append("    performance: ").append(toIndentedString(performance)).append("\n");
    sb.append("    charactersOption: ").append(toIndentedString(charactersOption)).append("\n");
    sb.append("    characters: ").append(toIndentedString(characters)).append("\n");
    sb.append("    paginate: ").append(toIndentedString(paginate)).append("\n");
    sb.append("    regions: ").append(toIndentedString(regions)).append("\n");
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

