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
    /// Parameters for Convert Word operation
    /// </summary>
    [DataContract]
    public partial class ConvertWordData :  IEquatable<ConvertWordData>, IValidatableObject
    {
        /// <summary>
        /// Output format
        /// </summary>
        /// <value>Output format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutputFormatEnum
        {
            
            /// <summary>
            /// Enum PDF for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF,
            
            /// <summary>
            /// Enum XPS for "XPS"
            /// </summary>
            [EnumMember(Value = "XPS")]
            XPS,
            
            /// <summary>
            /// Enum DOCX for "DOCX"
            /// </summary>
            [EnumMember(Value = "DOCX")]
            DOCX,
            
            /// <summary>
            /// Enum DOC for "DOC"
            /// </summary>
            [EnumMember(Value = "DOC")]
            DOC,
            
            /// <summary>
            /// Enum ODT for "ODT"
            /// </summary>
            [EnumMember(Value = "ODT")]
            ODT,
            
            /// <summary>
            /// Enum RTF for "RTF"
            /// </summary>
            [EnumMember(Value = "RTF")]
            RTF,
            
            /// <summary>
            /// Enum TXT for "TXT"
            /// </summary>
            [EnumMember(Value = "TXT")]
            TXT,
            
            /// <summary>
            /// Enum MHT for "MHT"
            /// </summary>
            [EnumMember(Value = "MHT")]
            MHT,
            
            /// <summary>
            /// Enum HTML for "HTML"
            /// </summary>
            [EnumMember(Value = "HTML")]
            HTML,
            
            /// <summary>
            /// Enum XML for "XML"
            /// </summary>
            [EnumMember(Value = "XML")]
            XML,
            
            /// <summary>
            /// Enum XLS for "XLS"
            /// </summary>
            [EnumMember(Value = "XLS")]
            XLS,
            
            /// <summary>
            /// Enum XLSX for "XLSX"
            /// </summary>
            [EnumMember(Value = "XLSX")]
            XLSX,
            
            /// <summary>
            /// Enum CSV for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV,
            
            /// <summary>
            /// Enum ODS for "ODS"
            /// </summary>
            [EnumMember(Value = "ODS")]
            ODS
        }

        /// <summary>
        /// Choose what changes would you like to see in this document
        /// </summary>
        /// <value>Choose what changes would you like to see in this document</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RevisionsAndCommentsDisplayModeEnum
        {
            
            /// <summary>
            /// Enum Final for "Final"
            /// </summary>
            [EnumMember(Value = "Final")]
            Final,
            
            /// <summary>
            /// Enum Original for "Original"
            /// </summary>
            [EnumMember(Value = "Original")]
            Original,
            
            /// <summary>
            /// Enum FinalShowingMarkup for "FinalShowingMarkup"
            /// </summary>
            [EnumMember(Value = "FinalShowingMarkup")]
            FinalShowingMarkup,
            
            /// <summary>
            /// Enum OriginalShowingMarkup for "OriginalShowingMarkup"
            /// </summary>
            [EnumMember(Value = "OriginalShowingMarkup")]
            OriginalShowingMarkup
        }

        /// <summary>
        /// Choose how you would like to see changes in this document
        /// </summary>
        /// <value>Choose how you would like to see changes in this document</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RevisionsAndCommentsMarkupModeEnum
        {
            
            /// <summary>
            /// Enum Balloon for "Balloon"
            /// </summary>
            [EnumMember(Value = "Balloon")]
            Balloon,
            
            /// <summary>
            /// Enum InLine for "InLine"
            /// </summary>
            [EnumMember(Value = "InLine")]
            InLine,
            
            /// <summary>
            /// Enum Mixed for "Mixed"
            /// </summary>
            [EnumMember(Value = "Mixed")]
            Mixed
        }

        /// <summary>
        /// Choose weather you would like to generate bookmarks based on the document structure
        /// </summary>
        /// <value>Choose weather you would like to generate bookmarks based on the document structure</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenerateBookmarksEnum
        {
            
            /// <summary>
            /// Enum Disabled for "Disabled"
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled,
            
            /// <summary>
            /// Enum Automatic for "Automatic"
            /// </summary>
            [EnumMember(Value = "Automatic")]
            Automatic,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom
        }

        /// <summary>
        /// Quality of the output file
        /// </summary>
        /// <value>Quality of the output file</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QualityEnum
        {
            
            /// <summary>
            /// Enum OptimizeForPrint for "OptimizeForPrint"
            /// </summary>
            [EnumMember(Value = "OptimizeForPrint")]
            OptimizeForPrint,
            
            /// <summary>
            /// Enum OptimizeForOnScreen for "OptimizeForOnScreen"
            /// </summary>
            [EnumMember(Value = "OptimizeForOnScreen")]
            OptimizeForOnScreen,
            
            /// <summary>
            /// Enum Original for "Original"
            /// </summary>
            [EnumMember(Value = "Original")]
            Original
        }

        /// <summary>
        /// Output format
        /// </summary>
        /// <value>Output format</value>
        [DataMember(Name="output_format", EmitDefaultValue=false)]
        public OutputFormatEnum? OutputFormat { get; set; }
        /// <summary>
        /// Choose what changes would you like to see in this document
        /// </summary>
        /// <value>Choose what changes would you like to see in this document</value>
        [DataMember(Name="revisions_and_comments_display_mode", EmitDefaultValue=false)]
        public RevisionsAndCommentsDisplayModeEnum? RevisionsAndCommentsDisplayMode { get; set; }
        /// <summary>
        /// Choose how you would like to see changes in this document
        /// </summary>
        /// <value>Choose how you would like to see changes in this document</value>
        [DataMember(Name="revisions_and_comments_markup_mode", EmitDefaultValue=false)]
        public RevisionsAndCommentsMarkupModeEnum? RevisionsAndCommentsMarkupMode { get; set; }
        /// <summary>
        /// Choose weather you would like to generate bookmarks based on the document structure
        /// </summary>
        /// <value>Choose weather you would like to generate bookmarks based on the document structure</value>
        [DataMember(Name="generate_bookmarks", EmitDefaultValue=false)]
        public GenerateBookmarksEnum? GenerateBookmarks { get; set; }
        /// <summary>
        /// Quality of the output file
        /// </summary>
        /// <value>Quality of the output file</value>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public QualityEnum? Quality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertWordData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertWordData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertWordData" /> class.
        /// </summary>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="SourceFileName">Name of the source file including extension (required).</param>
        /// <param name="SharepointFile">SharepointFile.</param>
        /// <param name="SourceFileContent">Content of the file to convert (required).</param>
        /// <param name="OutputFormat">Output format (required) (default to OutputFormatEnum.PDF).</param>
        /// <param name="CopyMetadata">Copy metadata (Only for SharePoint operations) (required) (default to false).</param>
        /// <param name="RevisionsAndCommentsDisplayMode">Choose what changes would you like to see in this document (default to RevisionsAndCommentsDisplayModeEnum.Final).</param>
        /// <param name="RevisionsAndCommentsMarkupMode">Choose how you would like to see changes in this document (default to RevisionsAndCommentsMarkupModeEnum.InLine).</param>
        /// <param name="GenerateBookmarks">Choose weather you would like to generate bookmarks based on the document structure.</param>
        /// <param name="StartPage">The first page to include.</param>
        /// <param name="EndPage">The last page to include.</param>
        /// <param name="Quality">Quality of the output file.</param>
        /// <param name="OverrideSettings">Optional settings using Muhimbi&#39;s XML syntax.</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public ConvertWordData(bool? UseAsyncPattern = false, string SourceFileName = default(string), SharepointFile SharepointFile = default(SharepointFile), byte[] SourceFileContent = default(byte[]), OutputFormatEnum? OutputFormat = OutputFormatEnum.PDF, bool? CopyMetadata = false, RevisionsAndCommentsDisplayModeEnum? RevisionsAndCommentsDisplayMode = RevisionsAndCommentsDisplayModeEnum.Final, RevisionsAndCommentsMarkupModeEnum? RevisionsAndCommentsMarkupMode = RevisionsAndCommentsMarkupModeEnum.InLine, GenerateBookmarksEnum? GenerateBookmarks = default(GenerateBookmarksEnum?), int? StartPage = default(int?), int? EndPage = default(int?), QualityEnum? Quality = default(QualityEnum?), string OverrideSettings = default(string), bool? FailOnError = true)
        {
            // to ensure "UseAsyncPattern" is required (not null)
            if (UseAsyncPattern == null)
            {
                throw new InvalidDataException("UseAsyncPattern is a required property for ConvertWordData and cannot be null");
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            // to ensure "SourceFileName" is required (not null)
            if (SourceFileName == null)
            {
                throw new InvalidDataException("SourceFileName is a required property for ConvertWordData and cannot be null");
            }
            else
            {
                this.SourceFileName = SourceFileName;
            }
            // to ensure "SourceFileContent" is required (not null)
            if (SourceFileContent == null)
            {
                throw new InvalidDataException("SourceFileContent is a required property for ConvertWordData and cannot be null");
            }
            else
            {
                this.SourceFileContent = SourceFileContent;
            }
            // to ensure "OutputFormat" is required (not null)
            if (OutputFormat == null)
            {
                throw new InvalidDataException("OutputFormat is a required property for ConvertWordData and cannot be null");
            }
            else
            {
                this.OutputFormat = OutputFormat;
            }
            // to ensure "CopyMetadata" is required (not null)
            if (CopyMetadata == null)
            {
                throw new InvalidDataException("CopyMetadata is a required property for ConvertWordData and cannot be null");
            }
            else
            {
                this.CopyMetadata = CopyMetadata;
            }
            this.SharepointFile = SharepointFile;
            // use default value if no "RevisionsAndCommentsDisplayMode" provided
            if (RevisionsAndCommentsDisplayMode == null)
            {
                this.RevisionsAndCommentsDisplayMode = RevisionsAndCommentsDisplayModeEnum.Final;
            }
            else
            {
                this.RevisionsAndCommentsDisplayMode = RevisionsAndCommentsDisplayMode;
            }
            // use default value if no "RevisionsAndCommentsMarkupMode" provided
            if (RevisionsAndCommentsMarkupMode == null)
            {
                this.RevisionsAndCommentsMarkupMode = RevisionsAndCommentsMarkupModeEnum.InLine;
            }
            else
            {
                this.RevisionsAndCommentsMarkupMode = RevisionsAndCommentsMarkupMode;
            }
            this.GenerateBookmarks = GenerateBookmarks;
            this.StartPage = StartPage;
            this.EndPage = EndPage;
            this.Quality = Quality;
            this.OverrideSettings = OverrideSettings;
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
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name="sharepoint_file", EmitDefaultValue=false)]
        public SharepointFile SharepointFile { get; set; }
        /// <summary>
        /// Content of the file to convert
        /// </summary>
        /// <value>Content of the file to convert</value>
        [DataMember(Name="source_file_content", EmitDefaultValue=false)]
        public byte[] SourceFileContent { get; set; }
        /// <summary>
        /// Copy metadata (Only for SharePoint operations)
        /// </summary>
        /// <value>Copy metadata (Only for SharePoint operations)</value>
        [DataMember(Name="copy_metadata", EmitDefaultValue=false)]
        public bool? CopyMetadata { get; set; }
        /// <summary>
        /// The first page to include
        /// </summary>
        /// <value>The first page to include</value>
        [DataMember(Name="start_page", EmitDefaultValue=false)]
        public int? StartPage { get; set; }
        /// <summary>
        /// The last page to include
        /// </summary>
        /// <value>The last page to include</value>
        [DataMember(Name="end_page", EmitDefaultValue=false)]
        public int? EndPage { get; set; }
        /// <summary>
        /// Optional settings using Muhimbi&#39;s XML syntax
        /// </summary>
        /// <value>Optional settings using Muhimbi&#39;s XML syntax</value>
        [DataMember(Name="override_settings", EmitDefaultValue=false)]
        public string OverrideSettings { get; set; }
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
            sb.Append("class ConvertWordData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  CopyMetadata: ").Append(CopyMetadata).Append("\n");
            sb.Append("  RevisionsAndCommentsDisplayMode: ").Append(RevisionsAndCommentsDisplayMode).Append("\n");
            sb.Append("  RevisionsAndCommentsMarkupMode: ").Append(RevisionsAndCommentsMarkupMode).Append("\n");
            sb.Append("  GenerateBookmarks: ").Append(GenerateBookmarks).Append("\n");
            sb.Append("  StartPage: ").Append(StartPage).Append("\n");
            sb.Append("  EndPage: ").Append(EndPage).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  OverrideSettings: ").Append(OverrideSettings).Append("\n");
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
            return this.Equals(obj as ConvertWordData);
        }

        /// <summary>
        /// Returns true if ConvertWordData instances are equal
        /// </summary>
        /// <param name="other">Instance of ConvertWordData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertWordData other)
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
                    this.SharepointFile == other.SharepointFile ||
                    this.SharepointFile != null &&
                    this.SharepointFile.Equals(other.SharepointFile)
                ) && 
                (
                    this.SourceFileContent == other.SourceFileContent ||
                    this.SourceFileContent != null &&
                    this.SourceFileContent.Equals(other.SourceFileContent)
                ) && 
                (
                    this.OutputFormat == other.OutputFormat ||
                    this.OutputFormat != null &&
                    this.OutputFormat.Equals(other.OutputFormat)
                ) && 
                (
                    this.CopyMetadata == other.CopyMetadata ||
                    this.CopyMetadata != null &&
                    this.CopyMetadata.Equals(other.CopyMetadata)
                ) && 
                (
                    this.RevisionsAndCommentsDisplayMode == other.RevisionsAndCommentsDisplayMode ||
                    this.RevisionsAndCommentsDisplayMode != null &&
                    this.RevisionsAndCommentsDisplayMode.Equals(other.RevisionsAndCommentsDisplayMode)
                ) && 
                (
                    this.RevisionsAndCommentsMarkupMode == other.RevisionsAndCommentsMarkupMode ||
                    this.RevisionsAndCommentsMarkupMode != null &&
                    this.RevisionsAndCommentsMarkupMode.Equals(other.RevisionsAndCommentsMarkupMode)
                ) && 
                (
                    this.GenerateBookmarks == other.GenerateBookmarks ||
                    this.GenerateBookmarks != null &&
                    this.GenerateBookmarks.Equals(other.GenerateBookmarks)
                ) && 
                (
                    this.StartPage == other.StartPage ||
                    this.StartPage != null &&
                    this.StartPage.Equals(other.StartPage)
                ) && 
                (
                    this.EndPage == other.EndPage ||
                    this.EndPage != null &&
                    this.EndPage.Equals(other.EndPage)
                ) && 
                (
                    this.Quality == other.Quality ||
                    this.Quality != null &&
                    this.Quality.Equals(other.Quality)
                ) && 
                (
                    this.OverrideSettings == other.OverrideSettings ||
                    this.OverrideSettings != null &&
                    this.OverrideSettings.Equals(other.OverrideSettings)
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
                if (this.SharepointFile != null)
                    hash = hash * 59 + this.SharepointFile.GetHashCode();
                if (this.SourceFileContent != null)
                    hash = hash * 59 + this.SourceFileContent.GetHashCode();
                if (this.OutputFormat != null)
                    hash = hash * 59 + this.OutputFormat.GetHashCode();
                if (this.CopyMetadata != null)
                    hash = hash * 59 + this.CopyMetadata.GetHashCode();
                if (this.RevisionsAndCommentsDisplayMode != null)
                    hash = hash * 59 + this.RevisionsAndCommentsDisplayMode.GetHashCode();
                if (this.RevisionsAndCommentsMarkupMode != null)
                    hash = hash * 59 + this.RevisionsAndCommentsMarkupMode.GetHashCode();
                if (this.GenerateBookmarks != null)
                    hash = hash * 59 + this.GenerateBookmarks.GetHashCode();
                if (this.StartPage != null)
                    hash = hash * 59 + this.StartPage.GetHashCode();
                if (this.EndPage != null)
                    hash = hash * 59 + this.EndPage.GetHashCode();
                if (this.Quality != null)
                    hash = hash * 59 + this.Quality.GetHashCode();
                if (this.OverrideSettings != null)
                    hash = hash * 59 + this.OverrideSettings.GetHashCode();
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
