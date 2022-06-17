/*
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * The version of the OpenAPI document: 9.16
 * Contact: support@muhimbi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Muhimbi.PDF.Online.Client.Client.OpenAPIDateConverter;

namespace Muhimbi.PDF.Online.Client.Model
{
    /// <summary>
    /// Parameters for Convert Infopath operation
    /// </summary>
    [DataContract(Name = "import_form_data")]
    public partial class ImportFormData : IEquatable<ImportFormData>, IValidatableObject
    {
        /// <summary>
        /// Flatten the result
        /// </summary>
        /// <value>Flatten the result</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlattenEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 2,

            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 3

        }


        /// <summary>
        /// Flatten the result
        /// </summary>
        /// <value>Flatten the result</value>
        [DataMember(Name = "flatten", EmitDefaultValue = false)]
        public FlattenEnum? Flatten { get; set; }
        /// <summary>
        /// Make the result read-only 
        /// </summary>
        /// <value>Make the result read-only </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReadOnlyEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 2,

            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 3

        }


        /// <summary>
        /// Make the result read-only 
        /// </summary>
        /// <value>Make the result read-only </value>
        [DataMember(Name = "read_only", EmitDefaultValue = false)]
        public ReadOnlyEnum? ReadOnly { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFormData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportFormData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFormData" /> class.
        /// </summary>
        /// <param name="useAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="sourceFileName">Name of the source file including extension (required).</param>
        /// <param name="sharepointFile">sharepointFile.</param>
        /// <param name="sourceFileContent">Content of the file to convert (required).</param>
        /// <param name="copyMetadata">Copy metadata (Only for SharePoint operations) (required) (default to false).</param>
        /// <param name="pdfTemplateFileContent">Content of the PDF Form file.</param>
        /// <param name="pdfTemplateUrl">URL of the PDF Form.</param>
        /// <param name="pdfTemplateUsername">Username to access PDF Form URL.</param>
        /// <param name="pdfTemplateDomain">Domain for Username to access PDF Form URL.</param>
        /// <param name="pdfTemplatePassword">Password to access PDF Form URL.</param>
        /// <param name="flatten">Flatten the result (default to FlattenEnum.Default).</param>
        /// <param name="readOnly">Make the result read-only  (default to ReadOnlyEnum.Default).</param>
        /// <param name="overrideSettings">Optional settings using Muhimbi&#39;s XML syntax.</param>
        /// <param name="failOnError">Fail on error (default to true).</param>
        public ImportFormData(bool useAsyncPattern = false, string sourceFileName = default(string), SharepointFile sharepointFile = default(SharepointFile), byte[] sourceFileContent = default(byte[]), bool copyMetadata = false, byte[] pdfTemplateFileContent = default(byte[]), string pdfTemplateUrl = default(string), string pdfTemplateUsername = default(string), string pdfTemplateDomain = default(string), string pdfTemplatePassword = default(string), FlattenEnum? flatten = FlattenEnum.Default, ReadOnlyEnum? readOnly = ReadOnlyEnum.Default, string overrideSettings = default(string), bool failOnError = true)
        {
            this.UseAsyncPattern = useAsyncPattern;
            // to ensure "sourceFileName" is required (not null)
            if (sourceFileName == null)
            {
                throw new ArgumentNullException("sourceFileName is a required property for ImportFormData and cannot be null");
            }
            this.SourceFileName = sourceFileName;
            // to ensure "sourceFileContent" is required (not null)
            if (sourceFileContent == null)
            {
                throw new ArgumentNullException("sourceFileContent is a required property for ImportFormData and cannot be null");
            }
            this.SourceFileContent = sourceFileContent;
            this.CopyMetadata = copyMetadata;
            this.SharepointFile = sharepointFile;
            this.PdfTemplateFileContent = pdfTemplateFileContent;
            this.PdfTemplateUrl = pdfTemplateUrl;
            this.PdfTemplateUsername = pdfTemplateUsername;
            this.PdfTemplateDomain = pdfTemplateDomain;
            this.PdfTemplatePassword = pdfTemplatePassword;
            this.Flatten = flatten;
            this.ReadOnly = readOnly;
            this.OverrideSettings = overrideSettings;
            this.FailOnError = failOnError;
        }

        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name = "use_async_pattern", IsRequired = true, EmitDefaultValue = true)]
        public bool UseAsyncPattern { get; set; }

        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name = "source_file_name", IsRequired = true, EmitDefaultValue = false)]
        public string SourceFileName { get; set; }

        /// <summary>
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name = "sharepoint_file", EmitDefaultValue = false)]
        public SharepointFile SharepointFile { get; set; }

        /// <summary>
        /// Content of the file to convert
        /// </summary>
        /// <value>Content of the file to convert</value>
        [DataMember(Name = "source_file_content", IsRequired = true, EmitDefaultValue = false)]
        public byte[] SourceFileContent { get; set; }

        /// <summary>
        /// Copy metadata (Only for SharePoint operations)
        /// </summary>
        /// <value>Copy metadata (Only for SharePoint operations)</value>
        [DataMember(Name = "copy_metadata", IsRequired = true, EmitDefaultValue = true)]
        public bool CopyMetadata { get; set; }

        /// <summary>
        /// Content of the PDF Form file
        /// </summary>
        /// <value>Content of the PDF Form file</value>
        [DataMember(Name = "pdf_template_file_content", EmitDefaultValue = false)]
        public byte[] PdfTemplateFileContent { get; set; }

        /// <summary>
        /// URL of the PDF Form
        /// </summary>
        /// <value>URL of the PDF Form</value>
        [DataMember(Name = "pdf_template_url", EmitDefaultValue = false)]
        public string PdfTemplateUrl { get; set; }

        /// <summary>
        /// Username to access PDF Form URL
        /// </summary>
        /// <value>Username to access PDF Form URL</value>
        [DataMember(Name = "pdf_template_username", EmitDefaultValue = false)]
        public string PdfTemplateUsername { get; set; }

        /// <summary>
        /// Domain for Username to access PDF Form URL
        /// </summary>
        /// <value>Domain for Username to access PDF Form URL</value>
        [DataMember(Name = "pdf_template_domain", EmitDefaultValue = false)]
        public string PdfTemplateDomain { get; set; }

        /// <summary>
        /// Password to access PDF Form URL
        /// </summary>
        /// <value>Password to access PDF Form URL</value>
        [DataMember(Name = "pdf_template_password", EmitDefaultValue = false)]
        public string PdfTemplatePassword { get; set; }

        /// <summary>
        /// Optional settings using Muhimbi&#39;s XML syntax
        /// </summary>
        /// <value>Optional settings using Muhimbi&#39;s XML syntax</value>
        [DataMember(Name = "override_settings", EmitDefaultValue = false)]
        public string OverrideSettings { get; set; }

        /// <summary>
        /// Fail on error
        /// </summary>
        /// <value>Fail on error</value>
        [DataMember(Name = "fail_on_error", EmitDefaultValue = true)]
        public bool FailOnError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImportFormData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  CopyMetadata: ").Append(CopyMetadata).Append("\n");
            sb.Append("  PdfTemplateFileContent: ").Append(PdfTemplateFileContent).Append("\n");
            sb.Append("  PdfTemplateUrl: ").Append(PdfTemplateUrl).Append("\n");
            sb.Append("  PdfTemplateUsername: ").Append(PdfTemplateUsername).Append("\n");
            sb.Append("  PdfTemplateDomain: ").Append(PdfTemplateDomain).Append("\n");
            sb.Append("  PdfTemplatePassword: ").Append(PdfTemplatePassword).Append("\n");
            sb.Append("  Flatten: ").Append(Flatten).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  OverrideSettings: ").Append(OverrideSettings).Append("\n");
            sb.Append("  FailOnError: ").Append(FailOnError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportFormData);
        }

        /// <summary>
        /// Returns true if ImportFormData instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportFormData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportFormData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UseAsyncPattern == input.UseAsyncPattern ||
                    this.UseAsyncPattern.Equals(input.UseAsyncPattern)
                ) && 
                (
                    this.SourceFileName == input.SourceFileName ||
                    (this.SourceFileName != null &&
                    this.SourceFileName.Equals(input.SourceFileName))
                ) && 
                (
                    this.SharepointFile == input.SharepointFile ||
                    (this.SharepointFile != null &&
                    this.SharepointFile.Equals(input.SharepointFile))
                ) && 
                (
                    this.SourceFileContent == input.SourceFileContent ||
                    (this.SourceFileContent != null &&
                    this.SourceFileContent.Equals(input.SourceFileContent))
                ) && 
                (
                    this.CopyMetadata == input.CopyMetadata ||
                    this.CopyMetadata.Equals(input.CopyMetadata)
                ) && 
                (
                    this.PdfTemplateFileContent == input.PdfTemplateFileContent ||
                    (this.PdfTemplateFileContent != null &&
                    this.PdfTemplateFileContent.Equals(input.PdfTemplateFileContent))
                ) && 
                (
                    this.PdfTemplateUrl == input.PdfTemplateUrl ||
                    (this.PdfTemplateUrl != null &&
                    this.PdfTemplateUrl.Equals(input.PdfTemplateUrl))
                ) && 
                (
                    this.PdfTemplateUsername == input.PdfTemplateUsername ||
                    (this.PdfTemplateUsername != null &&
                    this.PdfTemplateUsername.Equals(input.PdfTemplateUsername))
                ) && 
                (
                    this.PdfTemplateDomain == input.PdfTemplateDomain ||
                    (this.PdfTemplateDomain != null &&
                    this.PdfTemplateDomain.Equals(input.PdfTemplateDomain))
                ) && 
                (
                    this.PdfTemplatePassword == input.PdfTemplatePassword ||
                    (this.PdfTemplatePassword != null &&
                    this.PdfTemplatePassword.Equals(input.PdfTemplatePassword))
                ) && 
                (
                    this.Flatten == input.Flatten ||
                    this.Flatten.Equals(input.Flatten)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
                ) && 
                (
                    this.OverrideSettings == input.OverrideSettings ||
                    (this.OverrideSettings != null &&
                    this.OverrideSettings.Equals(input.OverrideSettings))
                ) && 
                (
                    this.FailOnError == input.FailOnError ||
                    this.FailOnError.Equals(input.FailOnError)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.UseAsyncPattern.GetHashCode();
                if (this.SourceFileName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileName.GetHashCode();
                }
                if (this.SharepointFile != null)
                {
                    hashCode = (hashCode * 59) + this.SharepointFile.GetHashCode();
                }
                if (this.SourceFileContent != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileContent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CopyMetadata.GetHashCode();
                if (this.PdfTemplateFileContent != null)
                {
                    hashCode = (hashCode * 59) + this.PdfTemplateFileContent.GetHashCode();
                }
                if (this.PdfTemplateUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PdfTemplateUrl.GetHashCode();
                }
                if (this.PdfTemplateUsername != null)
                {
                    hashCode = (hashCode * 59) + this.PdfTemplateUsername.GetHashCode();
                }
                if (this.PdfTemplateDomain != null)
                {
                    hashCode = (hashCode * 59) + this.PdfTemplateDomain.GetHashCode();
                }
                if (this.PdfTemplatePassword != null)
                {
                    hashCode = (hashCode * 59) + this.PdfTemplatePassword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Flatten.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadOnly.GetHashCode();
                if (this.OverrideSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FailOnError.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
