/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.16
 * Contact: support@muhimbi.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Muhimbi.PDF.Online.Client.Model
{
    /// <summary>
    /// Parameters for SecureDocument operation
    /// </summary>
    [DataContract]
    public partial class SecureDocumentData :  IEquatable<SecureDocumentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureDocumentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecureDocumentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureDocumentData" /> class.
        /// </summary>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="SourceFileName">Name of the source file including extension (required).</param>
        /// <param name="SourceFileContent">Content of the file to secure (required).</param>
        /// <param name="SharepointFile">SharepointFile.</param>
        /// <param name="OpenPassword">Password required to open the document.</param>
        /// <param name="OwnerPassword">Password required to edit the document (and for PDF apply restrictions defined below).</param>
        /// <param name="SecurityOptions">Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly.</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public SecureDocumentData(bool? UseAsyncPattern = false, string SourceFileName = default(string), byte[] SourceFileContent = default(byte[]), SharepointFile SharepointFile = default(SharepointFile), string OpenPassword = default(string), string OwnerPassword = default(string), string SecurityOptions = default(string), bool? FailOnError = true)
        {
            // to ensure "UseAsyncPattern" is required (not null)
            if (UseAsyncPattern == null)
            {
                throw new InvalidDataException("UseAsyncPattern is a required property for SecureDocumentData and cannot be null");
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            // to ensure "SourceFileName" is required (not null)
            if (SourceFileName == null)
            {
                throw new InvalidDataException("SourceFileName is a required property for SecureDocumentData and cannot be null");
            }
            else
            {
                this.SourceFileName = SourceFileName;
            }
            // to ensure "SourceFileContent" is required (not null)
            if (SourceFileContent == null)
            {
                throw new InvalidDataException("SourceFileContent is a required property for SecureDocumentData and cannot be null");
            }
            else
            {
                this.SourceFileContent = SourceFileContent;
            }
            this.SharepointFile = SharepointFile;
            this.OpenPassword = OpenPassword;
            this.OwnerPassword = OwnerPassword;
            this.SecurityOptions = SecurityOptions;
            // use default value if no "FailOnError" provided
            if (FailOnError == null)
            {
                this.FailOnError = true;
            }
            else
            {
                this.FailOnError = FailOnError;
            }
        }
        
        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name="use_async_pattern", EmitDefaultValue=false)]
        public bool? UseAsyncPattern { get; set; }
        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name", EmitDefaultValue=false)]
        public string SourceFileName { get; set; }
        /// <summary>
        /// Content of the file to secure
        /// </summary>
        /// <value>Content of the file to secure</value>
        [DataMember(Name="source_file_content", EmitDefaultValue=false)]
        public byte[] SourceFileContent { get; set; }
        /// <summary>
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name="sharepoint_file", EmitDefaultValue=false)]
        public SharepointFile SharepointFile { get; set; }
        /// <summary>
        /// Password required to open the document
        /// </summary>
        /// <value>Password required to open the document</value>
        [DataMember(Name="open_password", EmitDefaultValue=false)]
        public string OpenPassword { get; set; }
        /// <summary>
        /// Password required to edit the document (and for PDF apply restrictions defined below)
        /// </summary>
        /// <value>Password required to edit the document (and for PDF apply restrictions defined below)</value>
        [DataMember(Name="owner_password", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }
        /// <summary>
        /// Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly
        /// </summary>
        /// <value>Print|HighResolutionPrint|ContentCopy|Annotations|FormFields|ContentAccessibility|DocumentAssembly</value>
        [DataMember(Name="security_options", EmitDefaultValue=false)]
        public string SecurityOptions { get; set; }
        /// <summary>
        /// Fail on error
        /// </summary>
        /// <value>Fail on error</value>
        [DataMember(Name="fail_on_error", EmitDefaultValue=false)]
        public bool? FailOnError { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecureDocumentData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  OpenPassword: ").Append(OpenPassword).Append("\n");
            sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  FailOnError: ").Append(FailOnError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SecureDocumentData);
        }

        /// <summary>
        /// Returns true if SecureDocumentData instances are equal
        /// </summary>
        /// <param name="other">Instance of SecureDocumentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecureDocumentData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UseAsyncPattern == other.UseAsyncPattern ||
                    this.UseAsyncPattern != null &&
                    this.UseAsyncPattern.Equals(other.UseAsyncPattern)
                ) && 
                (
                    this.SourceFileName == other.SourceFileName ||
                    this.SourceFileName != null &&
                    this.SourceFileName.Equals(other.SourceFileName)
                ) && 
                (
                    this.SourceFileContent == other.SourceFileContent ||
                    this.SourceFileContent != null &&
                    this.SourceFileContent.Equals(other.SourceFileContent)
                ) && 
                (
                    this.SharepointFile == other.SharepointFile ||
                    this.SharepointFile != null &&
                    this.SharepointFile.Equals(other.SharepointFile)
                ) && 
                (
                    this.OpenPassword == other.OpenPassword ||
                    this.OpenPassword != null &&
                    this.OpenPassword.Equals(other.OpenPassword)
                ) && 
                (
                    this.OwnerPassword == other.OwnerPassword ||
                    this.OwnerPassword != null &&
                    this.OwnerPassword.Equals(other.OwnerPassword)
                ) && 
                (
                    this.SecurityOptions == other.SecurityOptions ||
                    this.SecurityOptions != null &&
                    this.SecurityOptions.Equals(other.SecurityOptions)
                ) && 
                (
                    this.FailOnError == other.FailOnError ||
                    this.FailOnError != null &&
                    this.FailOnError.Equals(other.FailOnError)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.UseAsyncPattern != null)
                    hash = hash * 59 + this.UseAsyncPattern.GetHashCode();
                if (this.SourceFileName != null)
                    hash = hash * 59 + this.SourceFileName.GetHashCode();
                if (this.SourceFileContent != null)
                    hash = hash * 59 + this.SourceFileContent.GetHashCode();
                if (this.SharepointFile != null)
                    hash = hash * 59 + this.SharepointFile.GetHashCode();
                if (this.OpenPassword != null)
                    hash = hash * 59 + this.OpenPassword.GetHashCode();
                if (this.OwnerPassword != null)
                    hash = hash * 59 + this.OwnerPassword.GetHashCode();
                if (this.SecurityOptions != null)
                    hash = hash * 59 + this.SecurityOptions.GetHashCode();
                if (this.FailOnError != null)
                    hash = hash * 59 + this.FailOnError.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
