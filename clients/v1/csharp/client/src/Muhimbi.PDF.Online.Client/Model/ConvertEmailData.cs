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
    /// Parameters for Convert Email operation
    /// </summary>
    [DataContract]
    public partial class ConvertEmailData :  IEquatable<ConvertEmailData>, IValidatableObject
    {
        /// <summary>
        /// What to do with attachments
        /// </summary>
        /// <value>What to do with attachments</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttachmentMergeModeEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum Merge for "Merge"
            /// </summary>
            [EnumMember(Value = "Merge")]
            Merge,
            
            /// <summary>
            /// Enum AttachAsPDF for "AttachAsPDF"
            /// </summary>
            [EnumMember(Value = "AttachAsPDF")]
            AttachAsPDF,
            
            /// <summary>
            /// Enum AttachOriginal for "AttachOriginal"
            /// </summary>
            [EnumMember(Value = "AttachOriginal")]
            AttachOriginal
        }

        /// <summary>
        /// What to do with attachments which cannot be converted into PDF
        /// </summary>
        /// <value>What to do with attachments which cannot be converted into PDF</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnsupportedAttachmentBehaviourEnum
        {
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Remove for "Remove"
            /// </summary>
            [EnumMember(Value = "Remove")]
            Remove,
            
            /// <summary>
            /// Enum AttachOriginal for "AttachOriginal"
            /// </summary>
            [EnumMember(Value = "AttachOriginal")]
            AttachOriginal
        }

        /// <summary>
        /// Paper size for the output
        /// </summary>
        /// <value>Paper size for the output</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaperSizeEnum
        {
            
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>
            [EnumMember(Value = "A3")]
            A3,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>
            [EnumMember(Value = "A4")]
            A4,
            
            /// <summary>
            /// Enum A5 for "A5"
            /// </summary>
            [EnumMember(Value = "A5")]
            A5,
            
            /// <summary>
            /// Enum Legal for "Legal"
            /// </summary>
            [EnumMember(Value = "Legal")]
            Legal,
            
            /// <summary>
            /// Enum Letter for "Letter"
            /// </summary>
            [EnumMember(Value = "Letter")]
            Letter,
            
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
        /// What to do with attachments
        /// </summary>
        /// <value>What to do with attachments</value>
        [DataMember(Name="attachment_merge_mode", EmitDefaultValue=false)]
        public AttachmentMergeModeEnum? AttachmentMergeMode { get; set; }
        /// <summary>
        /// What to do with attachments which cannot be converted into PDF
        /// </summary>
        /// <value>What to do with attachments which cannot be converted into PDF</value>
        [DataMember(Name="unsupported_attachment_behaviour", EmitDefaultValue=false)]
        public UnsupportedAttachmentBehaviourEnum? UnsupportedAttachmentBehaviour { get; set; }
        /// <summary>
        /// Paper size for the output
        /// </summary>
        /// <value>Paper size for the output</value>
        [DataMember(Name="paper_size", EmitDefaultValue=false)]
        public PaperSizeEnum? PaperSize { get; set; }
        /// <summary>
        /// Quality of the output file
        /// </summary>
        /// <value>Quality of the output file</value>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public QualityEnum? Quality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertEmailData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertEmailData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertEmailData" /> class.
        /// </summary>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="SourceFileName">Name of the source file including extension (required).</param>
        /// <param name="SharepointFile">SharepointFile.</param>
        /// <param name="SourceFileContent">Content of the file to convert (required).</param>
        /// <param name="CopyMetadata">Copy metadata (Only for SharePoint operations) (required) (default to false).</param>
        /// <param name="ConvertAttachments">Include attachments (default to true).</param>
        /// <param name="AttachmentMergeMode">What to do with attachments.</param>
        /// <param name="DisplayAttachmentSummary">Display attachment name in the email header (default to true).</param>
        /// <param name="UnsupportedAttachmentBehaviour">What to do with attachments which cannot be converted into PDF (default to UnsupportedAttachmentBehaviourEnum.Error).</param>
        /// <param name="IncludeAttachmentTypes">Comma separated values, e.g. *.txt, June???.docx.</param>
        /// <param name="ExcludeAttachmentTypes">Comma separated values, e.g. *.txt, June???.docx.</param>
        /// <param name="ViewportSize">Specify the viewport size for the conversion in pixels. E.g. 1024x768 (default to &quot;Paper&quot;).</param>
        /// <param name="PaperSize">Paper size for the output (default to PaperSizeEnum.Letter).</param>
        /// <param name="PaperSizeCustom">Applicable if &#39;Paper size&#39; is set to &#39;Custom&#39;.</param>
        /// <param name="PageMargins">E.g. &#39;1.5cm&#39; (for uniform) or &#39;0.5in,0.25in,0.5in,0.25in&#39; (for non-uniform) margins. (default to &quot;0.5,0.5,0.5,0.5&quot;).</param>
        /// <param name="BreakMergeOnError">How to deal with failure when converting attachments.</param>
        /// <param name="MinimumImageAttachmentDimension">Exclude images smaller than the specified number of pixels (default to 150).</param>
        /// <param name="EnableOfflineMode">In offline mode external resources are disabled (default to false).</param>
        /// <param name="StartPage">The first page to include.</param>
        /// <param name="EndPage">The last page to include.</param>
        /// <param name="Quality">Quality of the output file.</param>
        /// <param name="OverrideSettings">Optional settings using Muhimbi&#39;s XML syntax.</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public ConvertEmailData(bool? UseAsyncPattern = false, string SourceFileName = default(string), SharepointFile SharepointFile = default(SharepointFile), byte[] SourceFileContent = default(byte[]), bool? CopyMetadata = false, bool? ConvertAttachments = true, AttachmentMergeModeEnum? AttachmentMergeMode = default(AttachmentMergeModeEnum?), bool? DisplayAttachmentSummary = true, UnsupportedAttachmentBehaviourEnum? UnsupportedAttachmentBehaviour = UnsupportedAttachmentBehaviourEnum.Error, string IncludeAttachmentTypes = default(string), string ExcludeAttachmentTypes = default(string), string ViewportSize = "Paper", PaperSizeEnum? PaperSize = PaperSizeEnum.Letter, string PaperSizeCustom = default(string), string PageMargins = "0.5,0.5,0.5,0.5", bool? BreakMergeOnError = default(bool?), int? MinimumImageAttachmentDimension = 150, bool? EnableOfflineMode = false, int? StartPage = default(int?), int? EndPage = default(int?), QualityEnum? Quality = default(QualityEnum?), string OverrideSettings = default(string), bool? FailOnError = true)
        {
            // to ensure "UseAsyncPattern" is required (not null)
            if (UseAsyncPattern == null)
            {
                throw new InvalidDataException("UseAsyncPattern is a required property for ConvertEmailData and cannot be null");
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            // to ensure "SourceFileName" is required (not null)
            if (SourceFileName == null)
            {
                throw new InvalidDataException("SourceFileName is a required property for ConvertEmailData and cannot be null");
            }
            else
            {
                this.SourceFileName = SourceFileName;
            }
            // to ensure "SourceFileContent" is required (not null)
            if (SourceFileContent == null)
            {
                throw new InvalidDataException("SourceFileContent is a required property for ConvertEmailData and cannot be null");
            }
            else
            {
                this.SourceFileContent = SourceFileContent;
            }
            // to ensure "CopyMetadata" is required (not null)
            if (CopyMetadata == null)
            {
                throw new InvalidDataException("CopyMetadata is a required property for ConvertEmailData and cannot be null");
            }
            else
            {
                this.CopyMetadata = CopyMetadata;
            }
            this.SharepointFile = SharepointFile;
            // use default value if no "ConvertAttachments" provided
            if (ConvertAttachments == null)
            {
                this.ConvertAttachments = true;
            }
            else
            {
                this.ConvertAttachments = ConvertAttachments;
            }
            this.AttachmentMergeMode = AttachmentMergeMode;
            // use default value if no "DisplayAttachmentSummary" provided
            if (DisplayAttachmentSummary == null)
            {
                this.DisplayAttachmentSummary = true;
            }
            else
            {
                this.DisplayAttachmentSummary = DisplayAttachmentSummary;
            }
            // use default value if no "UnsupportedAttachmentBehaviour" provided
            if (UnsupportedAttachmentBehaviour == null)
            {
                this.UnsupportedAttachmentBehaviour = UnsupportedAttachmentBehaviourEnum.Error;
            }
            else
            {
                this.UnsupportedAttachmentBehaviour = UnsupportedAttachmentBehaviour;
            }
            this.IncludeAttachmentTypes = IncludeAttachmentTypes;
            this.ExcludeAttachmentTypes = ExcludeAttachmentTypes;
            // use default value if no "ViewportSize" provided
            if (ViewportSize == null)
            {
                this.ViewportSize = "Paper";
            }
            else
            {
                this.ViewportSize = ViewportSize;
            }
            // use default value if no "PaperSize" provided
            if (PaperSize == null)
            {
                this.PaperSize = PaperSizeEnum.Letter;
            }
            else
            {
                this.PaperSize = PaperSize;
            }
            this.PaperSizeCustom = PaperSizeCustom;
            // use default value if no "PageMargins" provided
            if (PageMargins == null)
            {
                this.PageMargins = "0.5,0.5,0.5,0.5";
            }
            else
            {
                this.PageMargins = PageMargins;
            }
            this.BreakMergeOnError = BreakMergeOnError;
            // use default value if no "MinimumImageAttachmentDimension" provided
            if (MinimumImageAttachmentDimension == null)
            {
                this.MinimumImageAttachmentDimension = 150;
            }
            else
            {
                this.MinimumImageAttachmentDimension = MinimumImageAttachmentDimension;
            }
            // use default value if no "EnableOfflineMode" provided
            if (EnableOfflineMode == null)
            {
                this.EnableOfflineMode = false;
            }
            else
            {
                this.EnableOfflineMode = EnableOfflineMode;
            }
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
        /// Include attachments
        /// </summary>
        /// <value>Include attachments</value>
        [DataMember(Name="convert_attachments", EmitDefaultValue=false)]
        public bool? ConvertAttachments { get; set; }
        /// <summary>
        /// Display attachment name in the email header
        /// </summary>
        /// <value>Display attachment name in the email header</value>
        [DataMember(Name="display_attachment_summary", EmitDefaultValue=false)]
        public bool? DisplayAttachmentSummary { get; set; }
        /// <summary>
        /// Comma separated values, e.g. *.txt, June???.docx
        /// </summary>
        /// <value>Comma separated values, e.g. *.txt, June???.docx</value>
        [DataMember(Name="include_attachment_types", EmitDefaultValue=false)]
        public string IncludeAttachmentTypes { get; set; }
        /// <summary>
        /// Comma separated values, e.g. *.txt, June???.docx
        /// </summary>
        /// <value>Comma separated values, e.g. *.txt, June???.docx</value>
        [DataMember(Name="exclude_attachment_types", EmitDefaultValue=false)]
        public string ExcludeAttachmentTypes { get; set; }
        /// <summary>
        /// Specify the viewport size for the conversion in pixels. E.g. 1024x768
        /// </summary>
        /// <value>Specify the viewport size for the conversion in pixels. E.g. 1024x768</value>
        [DataMember(Name="viewport_Size", EmitDefaultValue=false)]
        public string ViewportSize { get; set; }
        /// <summary>
        /// Applicable if &#39;Paper size&#39; is set to &#39;Custom&#39;
        /// </summary>
        /// <value>Applicable if &#39;Paper size&#39; is set to &#39;Custom&#39;</value>
        [DataMember(Name="paper_size_custom", EmitDefaultValue=false)]
        public string PaperSizeCustom { get; set; }
        /// <summary>
        /// E.g. &#39;1.5cm&#39; (for uniform) or &#39;0.5in,0.25in,0.5in,0.25in&#39; (for non-uniform) margins.
        /// </summary>
        /// <value>E.g. &#39;1.5cm&#39; (for uniform) or &#39;0.5in,0.25in,0.5in,0.25in&#39; (for non-uniform) margins.</value>
        [DataMember(Name="page_margins", EmitDefaultValue=false)]
        public string PageMargins { get; set; }
        /// <summary>
        /// How to deal with failure when converting attachments
        /// </summary>
        /// <value>How to deal with failure when converting attachments</value>
        [DataMember(Name="break_merge_on_error", EmitDefaultValue=false)]
        public bool? BreakMergeOnError { get; set; }
        /// <summary>
        /// Exclude images smaller than the specified number of pixels
        /// </summary>
        /// <value>Exclude images smaller than the specified number of pixels</value>
        [DataMember(Name="minimum_image_attachment_dimension", EmitDefaultValue=false)]
        public int? MinimumImageAttachmentDimension { get; set; }
        /// <summary>
        /// In offline mode external resources are disabled
        /// </summary>
        /// <value>In offline mode external resources are disabled</value>
        [DataMember(Name="enable_offline_mode", EmitDefaultValue=false)]
        public bool? EnableOfflineMode { get; set; }
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
            sb.Append("class ConvertEmailData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  CopyMetadata: ").Append(CopyMetadata).Append("\n");
            sb.Append("  ConvertAttachments: ").Append(ConvertAttachments).Append("\n");
            sb.Append("  AttachmentMergeMode: ").Append(AttachmentMergeMode).Append("\n");
            sb.Append("  DisplayAttachmentSummary: ").Append(DisplayAttachmentSummary).Append("\n");
            sb.Append("  UnsupportedAttachmentBehaviour: ").Append(UnsupportedAttachmentBehaviour).Append("\n");
            sb.Append("  IncludeAttachmentTypes: ").Append(IncludeAttachmentTypes).Append("\n");
            sb.Append("  ExcludeAttachmentTypes: ").Append(ExcludeAttachmentTypes).Append("\n");
            sb.Append("  ViewportSize: ").Append(ViewportSize).Append("\n");
            sb.Append("  PaperSize: ").Append(PaperSize).Append("\n");
            sb.Append("  PaperSizeCustom: ").Append(PaperSizeCustom).Append("\n");
            sb.Append("  PageMargins: ").Append(PageMargins).Append("\n");
            sb.Append("  BreakMergeOnError: ").Append(BreakMergeOnError).Append("\n");
            sb.Append("  MinimumImageAttachmentDimension: ").Append(MinimumImageAttachmentDimension).Append("\n");
            sb.Append("  EnableOfflineMode: ").Append(EnableOfflineMode).Append("\n");
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
            return this.Equals(obj as ConvertEmailData);
        }

        /// <summary>
        /// Returns true if ConvertEmailData instances are equal
        /// </summary>
        /// <param name="other">Instance of ConvertEmailData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertEmailData other)
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
                    this.CopyMetadata == other.CopyMetadata ||
                    this.CopyMetadata != null &&
                    this.CopyMetadata.Equals(other.CopyMetadata)
                ) && 
                (
                    this.ConvertAttachments == other.ConvertAttachments ||
                    this.ConvertAttachments != null &&
                    this.ConvertAttachments.Equals(other.ConvertAttachments)
                ) && 
                (
                    this.AttachmentMergeMode == other.AttachmentMergeMode ||
                    this.AttachmentMergeMode != null &&
                    this.AttachmentMergeMode.Equals(other.AttachmentMergeMode)
                ) && 
                (
                    this.DisplayAttachmentSummary == other.DisplayAttachmentSummary ||
                    this.DisplayAttachmentSummary != null &&
                    this.DisplayAttachmentSummary.Equals(other.DisplayAttachmentSummary)
                ) && 
                (
                    this.UnsupportedAttachmentBehaviour == other.UnsupportedAttachmentBehaviour ||
                    this.UnsupportedAttachmentBehaviour != null &&
                    this.UnsupportedAttachmentBehaviour.Equals(other.UnsupportedAttachmentBehaviour)
                ) && 
                (
                    this.IncludeAttachmentTypes == other.IncludeAttachmentTypes ||
                    this.IncludeAttachmentTypes != null &&
                    this.IncludeAttachmentTypes.Equals(other.IncludeAttachmentTypes)
                ) && 
                (
                    this.ExcludeAttachmentTypes == other.ExcludeAttachmentTypes ||
                    this.ExcludeAttachmentTypes != null &&
                    this.ExcludeAttachmentTypes.Equals(other.ExcludeAttachmentTypes)
                ) && 
                (
                    this.ViewportSize == other.ViewportSize ||
                    this.ViewportSize != null &&
                    this.ViewportSize.Equals(other.ViewportSize)
                ) && 
                (
                    this.PaperSize == other.PaperSize ||
                    this.PaperSize != null &&
                    this.PaperSize.Equals(other.PaperSize)
                ) && 
                (
                    this.PaperSizeCustom == other.PaperSizeCustom ||
                    this.PaperSizeCustom != null &&
                    this.PaperSizeCustom.Equals(other.PaperSizeCustom)
                ) && 
                (
                    this.PageMargins == other.PageMargins ||
                    this.PageMargins != null &&
                    this.PageMargins.Equals(other.PageMargins)
                ) && 
                (
                    this.BreakMergeOnError == other.BreakMergeOnError ||
                    this.BreakMergeOnError != null &&
                    this.BreakMergeOnError.Equals(other.BreakMergeOnError)
                ) && 
                (
                    this.MinimumImageAttachmentDimension == other.MinimumImageAttachmentDimension ||
                    this.MinimumImageAttachmentDimension != null &&
                    this.MinimumImageAttachmentDimension.Equals(other.MinimumImageAttachmentDimension)
                ) && 
                (
                    this.EnableOfflineMode == other.EnableOfflineMode ||
                    this.EnableOfflineMode != null &&
                    this.EnableOfflineMode.Equals(other.EnableOfflineMode)
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
                if (this.CopyMetadata != null)
                    hash = hash * 59 + this.CopyMetadata.GetHashCode();
                if (this.ConvertAttachments != null)
                    hash = hash * 59 + this.ConvertAttachments.GetHashCode();
                if (this.AttachmentMergeMode != null)
                    hash = hash * 59 + this.AttachmentMergeMode.GetHashCode();
                if (this.DisplayAttachmentSummary != null)
                    hash = hash * 59 + this.DisplayAttachmentSummary.GetHashCode();
                if (this.UnsupportedAttachmentBehaviour != null)
                    hash = hash * 59 + this.UnsupportedAttachmentBehaviour.GetHashCode();
                if (this.IncludeAttachmentTypes != null)
                    hash = hash * 59 + this.IncludeAttachmentTypes.GetHashCode();
                if (this.ExcludeAttachmentTypes != null)
                    hash = hash * 59 + this.ExcludeAttachmentTypes.GetHashCode();
                if (this.ViewportSize != null)
                    hash = hash * 59 + this.ViewportSize.GetHashCode();
                if (this.PaperSize != null)
                    hash = hash * 59 + this.PaperSize.GetHashCode();
                if (this.PaperSizeCustom != null)
                    hash = hash * 59 + this.PaperSizeCustom.GetHashCode();
                if (this.PageMargins != null)
                    hash = hash * 59 + this.PageMargins.GetHashCode();
                if (this.BreakMergeOnError != null)
                    hash = hash * 59 + this.BreakMergeOnError.GetHashCode();
                if (this.MinimumImageAttachmentDimension != null)
                    hash = hash * 59 + this.MinimumImageAttachmentDimension.GetHashCode();
                if (this.EnableOfflineMode != null)
                    hash = hash * 59 + this.EnableOfflineMode.GetHashCode();
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
