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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * SharePoint file information for operation
 */
@ApiModel(description = "SharePoint file information for operation")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2020-06-02T17:07:48.610+01:00")
public class SharepointFile {
  @SerializedName("site_url")
  private String siteUrl = null;

  @SerializedName("source_file_url")
  private String sourceFileUrl = null;

  @SerializedName("destination_file_url")
  private String destinationFileUrl = null;

  @SerializedName("username")
  private String username = null;

  @SerializedName("password")
  private String password = null;

  public SharepointFile siteUrl(String siteUrl) {
    this.siteUrl = siteUrl;
    return this;
  }

   /**
   * SharePoint site url (example: http://contoso.sharepoint.com/sites/mysite)
   * @return siteUrl
  **/
  @ApiModelProperty(example = "null", value = "SharePoint site url (example: http://contoso.sharepoint.com/sites/mysite)")
  public String getSiteUrl() {
    return siteUrl;
  }

  public void setSiteUrl(String siteUrl) {
    this.siteUrl = siteUrl;
  }

  public SharepointFile sourceFileUrl(String sourceFileUrl) {
    this.sourceFileUrl = sourceFileUrl;
    return this;
  }

   /**
   * Path to the source file
   * @return sourceFileUrl
  **/
  @ApiModelProperty(example = "null", value = "Path to the source file")
  public String getSourceFileUrl() {
    return sourceFileUrl;
  }

  public void setSourceFileUrl(String sourceFileUrl) {
    this.sourceFileUrl = sourceFileUrl;
  }

  public SharepointFile destinationFileUrl(String destinationFileUrl) {
    this.destinationFileUrl = destinationFileUrl;
    return this;
  }

   /**
   * Path to the destination file
   * @return destinationFileUrl
  **/
  @ApiModelProperty(example = "null", value = "Path to the destination file")
  public String getDestinationFileUrl() {
    return destinationFileUrl;
  }

  public void setDestinationFileUrl(String destinationFileUrl) {
    this.destinationFileUrl = destinationFileUrl;
  }

  public SharepointFile username(String username) {
    this.username = username;
    return this;
  }

   /**
   * User name to log in to the SharePoint site
   * @return username
  **/
  @ApiModelProperty(example = "null", value = "User name to log in to the SharePoint site")
  public String getUsername() {
    return username;
  }

  public void setUsername(String username) {
    this.username = username;
  }

  public SharepointFile password(String password) {
    this.password = password;
    return this;
  }

   /**
   * Password to log in to the SharePoint site’
   * @return password
  **/
  @ApiModelProperty(example = "null", value = "Password to log in to the SharePoint site’")
  public String getPassword() {
    return password;
  }

  public void setPassword(String password) {
    this.password = password;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SharepointFile sharepointFile = (SharepointFile) o;
    return Objects.equals(this.siteUrl, sharepointFile.siteUrl) &&
        Objects.equals(this.sourceFileUrl, sharepointFile.sourceFileUrl) &&
        Objects.equals(this.destinationFileUrl, sharepointFile.destinationFileUrl) &&
        Objects.equals(this.username, sharepointFile.username) &&
        Objects.equals(this.password, sharepointFile.password);
  }

  @Override
  public int hashCode() {
    return Objects.hash(siteUrl, sourceFileUrl, destinationFileUrl, username, password);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SharepointFile {\n");
    
    sb.append("    siteUrl: ").append(toIndentedString(siteUrl)).append("\n");
    sb.append("    sourceFileUrl: ").append(toIndentedString(sourceFileUrl)).append("\n");
    sb.append("    destinationFileUrl: ").append(toIndentedString(destinationFileUrl)).append("\n");
    sb.append("    username: ").append(toIndentedString(username)).append("\n");
    sb.append("    password: ").append(toIndentedString(password)).append("\n");
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

