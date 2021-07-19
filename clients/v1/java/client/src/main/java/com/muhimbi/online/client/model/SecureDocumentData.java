/*
 * Muhimbi PDF
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.14.1
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
 * Parameters for SecureDocument operation
 */
@ApiModel(description = "Parameters for SecureDocument operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2020-12-15T15:24:28.962Z")
public class SecureDocumentData {
  @SerializedName("use_async_pattern")
  private Boolean useAsyncPattern = false;

  @SerializedName("source_file_name")
  private String sourceFileName = null;

  @SerializedName("source_file_content")
  private String sourceFileContent = null;

  @SerializedName("sharepoint_file")
  private SharepointFile sharepointFile = null;

  @SerializedName("open_password")
  private String openPassword = null;

  @SerializedName("owner_password")
  private String ownerPassword = null;

  @SerializedName("security_options")
  private String securityOptions = null;

  @SerializedName("fail_on_error")
  private Boolean failOnError = true;

  public SecureDocumentData useAsyncPattern(Boolean useAsyncPattern) {
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

  public SecureDocumentData sourceFileName(String sourceFileName) {
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

  public SecureDocumentData sourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
    return this;
  }

   /**
   * Content of the file to secure
   * @return sourceFileContent
  **/
  @ApiModelProperty(example = "null", required = true, value = "Content of the file to secure")
  public String getSourceFileContent() {
    return sourceFileContent;
  }

  public void setSourceFileContent(String sourceFileContent) {
    this.sourceFileContent = sourceFileContent;
  }

  public SecureDocumentData sharepointFile(SharepointFile sharepointFile) {
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

  public SecureDocumentData openPassword(String openPassword) {
    this.openPassword = openPassword;
    return this;
  }

   /**
   * Password required to open the document
   * @return openPassword
  **/
  @ApiModelProperty(example = "null", value = "Password required to open the document")
  public String getOpenPassword() {
    return openPassword;
  }

  public void setOpenPassword(String openPassword) {
    this.openPassword = openPassword;
  }

  public SecureDocumentData ownerPassword(String ownerPassword) {
    this.ownerPassword = ownerPassword;
    return this;
  }

   /**
   * Password required to edit the document (and for PDF apply restrictions defined below)
   * @return ownerPassword
  **/
  @ApiModelProperty(example = "null", value = "Password required to edit the document (and for PDF apply restrictions defined below)")
  public String getOwnerPassword() {
    return ownerPassword;
  }

  public void setOwnerPassword(String ownerPassword) {
    this.ownerPassword = ownerPassword;
  }

  public SecureDocumentData securityOptions(String securityOptions) {
    this.securityOptions = securityOptions;
    return this;
  }

   /**
   * Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly
   * @return securityOptions
  **/
  @ApiModelProperty(example = "null", value = "Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly")
  public String getSecurityOptions() {
    return securityOptions;
  }

  public void setSecurityOptions(String securityOptions) {
    this.securityOptions = securityOptions;
  }

  public SecureDocumentData failOnError(Boolean failOnError) {
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
    SecureDocumentData secureDocumentData = (SecureDocumentData) o;
    return Objects.equals(this.useAsyncPattern, secureDocumentData.useAsyncPattern) &&
        Objects.equals(this.sourceFileName, secureDocumentData.sourceFileName) &&
        Objects.equals(this.sourceFileContent, secureDocumentData.sourceFileContent) &&
        Objects.equals(this.sharepointFile, secureDocumentData.sharepointFile) &&
        Objects.equals(this.openPassword, secureDocumentData.openPassword) &&
        Objects.equals(this.ownerPassword, secureDocumentData.ownerPassword) &&
        Objects.equals(this.securityOptions, secureDocumentData.securityOptions) &&
        Objects.equals(this.failOnError, secureDocumentData.failOnError);
  }

  @Override
  public int hashCode() {
    return Objects.hash(useAsyncPattern, sourceFileName, sourceFileContent, sharepointFile, openPassword, ownerPassword, securityOptions, failOnError);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SecureDocumentData {\n");
    
    sb.append("    useAsyncPattern: ").append(toIndentedString(useAsyncPattern)).append("\n");
    sb.append("    sourceFileName: ").append(toIndentedString(sourceFileName)).append("\n");
    sb.append("    sourceFileContent: ").append(toIndentedString(sourceFileContent)).append("\n");
    sb.append("    sharepointFile: ").append(toIndentedString(sharepointFile)).append("\n");
    sb.append("    openPassword: ").append(toIndentedString(openPassword)).append("\n");
    sb.append("    ownerPassword: ").append(toIndentedString(ownerPassword)).append("\n");
    sb.append("    securityOptions: ").append(toIndentedString(securityOptions)).append("\n");
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

