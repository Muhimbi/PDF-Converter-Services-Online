/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.15
 * 
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
    /// Parameters for RTFWatermark operation
    /// </summary>
    [DataContract]
    public partial class RtfWatermarkData :  IEquatable<RtfWatermarkData>, IValidatableObject
    {
        /// <summary>
        /// Watermark position on the page
        /// </summary>
        /// <value>Watermark position on the page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionEnum
        {
            
            /// <summary>
            /// Enum TopLeft for "Top Left"
            /// </summary>
            [EnumMember(Value = "Top Left")]
            TopLeft,
            
            /// <summary>
            /// Enum TopCenter for "Top Center"
            /// </summary>
            [EnumMember(Value = "Top Center")]
            TopCenter,
            
            /// <summary>
            /// Enum TopRight for "Top Right"
            /// </summary>
            [EnumMember(Value = "Top Right")]
            TopRight,
            
            /// <summary>
            /// Enum MiddleLeft for "Middle Left"
            /// </summary>
            [EnumMember(Value = "Middle Left")]
            MiddleLeft,
            
            /// <summary>
            /// Enum MiddleCenter for "Middle Center"
            /// </summary>
            [EnumMember(Value = "Middle Center")]
            MiddleCenter,
            
            /// <summary>
            /// Enum MiddleRight for "Middle Right"
            /// </summary>
            [EnumMember(Value = "Middle Right")]
            MiddleRight,
            
            /// <summary>
            /// Enum BottomLeft for "Bottom Left"
            /// </summary>
            [EnumMember(Value = "Bottom Left")]
            BottomLeft,
            
            /// <summary>
            /// Enum BottomCenter for "Bottom Center"
            /// </summary>
            [EnumMember(Value = "Bottom Center")]
            BottomCenter,
            
            /// <summary>
            /// Enum BottomRight for "Bottom Right"
            /// </summary>
            [EnumMember(Value = "Bottom Right")]
            BottomRight,
            
            /// <summary>
            /// Enum Absolute for "Absolute"
            /// </summary>
            [EnumMember(Value = "Absolute")]
            Absolute,
            
            /// <summary>
            /// Enum Random for "Random"
            /// </summary>
            [EnumMember(Value = "Random")]
            Random
        }

        /// <summary>
        /// Watermark layer
        /// </summary>
        /// <value>Watermark layer</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayerEnum
        {
            
            /// <summary>
            /// Enum Background for "Background"
            /// </summary>
            [EnumMember(Value = "Background")]
            Background,
            
            /// <summary>
            /// Enum Foreground for "Foreground"
            /// </summary>
            [EnumMember(Value = "Foreground")]
            Foreground
        }

        /// <summary>
        /// Orientation of pages the watermark applies to.
        /// </summary>
        /// <value>Orientation of pages the watermark applies to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageOrientationEnum
        {
            
            /// <summary>
            /// Enum Portrait for "Portrait"
            /// </summary>
            [EnumMember(Value = "Portrait")]
            Portrait,
            
            /// <summary>
            /// Enum Landscape for "Landscape"
            /// </summary>
            [EnumMember(Value = "Landscape")]
            Landscape,
            
            /// <summary>
            /// Enum Both for "Both"
            /// </summary>
            [EnumMember(Value = "Both")]
            Both
        }

        /// <summary>
        /// Tells if the watermark is only visible when the document is printed
        /// </summary>
        /// <value>Tells if the watermark is only visible when the document is printed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintOnlyEnum
        {
            
            /// <summary>
            /// Enum False for "false"
            /// </summary>
            [EnumMember(Value = "false")]
            False,
            
            /// <summary>
            /// Enum True for "true"
            /// </summary>
            [EnumMember(Value = "true")]
            True
        }

        /// <summary>
        /// Watermark position on the page
        /// </summary>
        /// <value>Watermark position on the page</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionEnum? Position { get; set; }
        /// <summary>
        /// Watermark layer
        /// </summary>
        /// <value>Watermark layer</value>
        [DataMember(Name="layer", EmitDefaultValue=false)]
        public LayerEnum? Layer { get; set; }
        /// <summary>
        /// Orientation of pages the watermark applies to.
        /// </summary>
        /// <value>Orientation of pages the watermark applies to.</value>
        [DataMember(Name="page_orientation", EmitDefaultValue=false)]
        public PageOrientationEnum? PageOrientation { get; set; }
        /// <summary>
        /// Tells if the watermark is only visible when the document is printed
        /// </summary>
        /// <value>Tells if the watermark is only visible when the document is printed</value>
        [DataMember(Name="print_only", EmitDefaultValue=false)]
        public PrintOnlyEnum? PrintOnly { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RtfWatermarkData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RtfWatermarkData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RtfWatermarkData" /> class.
        /// </summary>
        /// <param name="SourceFileName">Name of the source file including extension.</param>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="SourceFileContent">Content of the file to watermark (required).</param>
        /// <param name="RtfData">Watermark text in RTF format (required).</param>
        /// <param name="SharepointFile">SharepointFile.</param>
        /// <param name="Position">Watermark position on the page (required) (default to PositionEnum.MiddleCenter).</param>
        /// <param name="Width">Width of the watermark (in Pts, 1/72 of an inch) (required).</param>
        /// <param name="Height">Height of the watermark (in Pts, 1/72 of an inch) (required).</param>
        /// <param name="X">X Coordinate when &#39;Position&#39; is set to &#39;Absolute&#39; (in Pts, 1/72 of an inch).</param>
        /// <param name="Y">Y Coordinate when &#39;Position&#39; is set to &#39;Absolute&#39; (in Pts, 1/72 of an inch).</param>
        /// <param name="Layer">Watermark layer (default to LayerEnum.Foreground).</param>
        /// <param name="Rotation">Angle of rotation.</param>
        /// <param name="Opacity">Opacity in % (100 is fully visible and 1 is barely visible) (default to &quot;100&quot;).</param>
        /// <param name="FillColor">Color in #RRGGBB notation.</param>
        /// <param name="LineColor">Color in #RRGGBB notation.</param>
        /// <param name="LineWidth">Width of the watermark outline (in Pts, 1/72 of an inch).</param>
        /// <param name="StartPage">Number of the first page the watermark applies to.</param>
        /// <param name="EndPage">Number of the last page the watermark applies to.</param>
        /// <param name="PageInterval">Which pages to display the watermark on (1&#x3D;every page, 2&#x3D;every other, etc).</param>
        /// <param name="PageOrientation">Orientation of pages the watermark applies to. (default to PageOrientationEnum.Both).</param>
        /// <param name="PrintOnly">Tells if the watermark is only visible when the document is printed (default to PrintOnlyEnum.False).</param>
        /// <param name="StartSection">The first section in a Word or Excel document the watermark is visible.</param>
        /// <param name="EndSection">The last section in a Word or Excel document the watermark is visible.</param>
        /// <param name="PageType">One or more page types for Word and Excel documents, eg. default|first|even.</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public RtfWatermarkData(string SourceFileName = default(string), bool? UseAsyncPattern = false, byte[] SourceFileContent = default(byte[]), string RtfData = default(string), SharepointFile SharepointFile = default(SharepointFile), PositionEnum? Position = PositionEnum.MiddleCenter, string Width = default(string), string Height = default(string), string X = default(string), string Y = default(string), LayerEnum? Layer = LayerEnum.Foreground, string Rotation = default(string), string Opacity = "100", string FillColor = default(string), string LineColor = default(string), string LineWidth = default(string), int? StartPage = default(int?), int? EndPage = default(int?), int? PageInterval = default(int?), PageOrientationEnum? PageOrientation = PageOrientationEnum.Both, PrintOnlyEnum? PrintOnly = PrintOnlyEnum.False, int? StartSection = default(int?), int? EndSection = default(int?), string PageType = default(string), bool? FailOnError = true)
        {
            // to ensure "UseAsyncPattern" is required (not null)
            if (UseAsyncPattern == null)
            {
                throw new InvalidDataException("UseAsyncPattern is a required property for RtfWatermarkData and cannot be null");
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            // to ensure "SourceFileContent" is required (not null)
            if (SourceFileContent == null)
            {
                throw new InvalidDataException("SourceFileContent is a required property for RtfWatermarkData and cannot be null");
            }
            else
            {
                this.SourceFileContent = SourceFileContent;
            }
            // to ensure "RtfData" is required (not null)
            if (RtfData == null)
            {
                throw new InvalidDataException("RtfData is a required property for RtfWatermarkData and cannot be null");
            }
            else
            {
                this.RtfData = RtfData;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for RtfWatermarkData and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "Width" is required (not null)
            if (Width == null)
            {
                throw new InvalidDataException("Width is a required property for RtfWatermarkData and cannot be null");
            }
            else
            {
                this.Width = Width;
            }
            // to ensure "Height" is required (not null)
            if (Height == null)
            {
                throw new InvalidDataException("Height is a required property for RtfWatermarkData and cannot be null");
            }
            else
            {
                this.Height = Height;
            }
            this.SourceFileName = SourceFileName;
            this.SharepointFile = SharepointFile;
            this.X = X;
            this.Y = Y;
            // use default value if no "Layer" provided
            if (Layer == null)
            {
                this.Layer = LayerEnum.Foreground;
            }
            else
            {
                this.Layer = Layer;
            }
            this.Rotation = Rotation;
            // use default value if no "Opacity" provided
            if (Opacity == null)
            {
                this.Opacity = "100";
            }
            else
            {
                this.Opacity = Opacity;
            }
            this.FillColor = FillColor;
            this.LineColor = LineColor;
            this.LineWidth = LineWidth;
            this.StartPage = StartPage;
            this.EndPage = EndPage;
            this.PageInterval = PageInterval;
            // use default value if no "PageOrientation" provided
            if (PageOrientation == null)
            {
                this.PageOrientation = PageOrientationEnum.Both;
            }
            else
            {
                this.PageOrientation = PageOrientation;
            }
            // use default value if no "PrintOnly" provided
            if (PrintOnly == null)
            {
                this.PrintOnly = PrintOnlyEnum.False;
            }
            else
            {
                this.PrintOnly = PrintOnly;
            }
            this.StartSection = StartSection;
            this.EndSection = EndSection;
            this.PageType = PageType;
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
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name", EmitDefaultValue=false)]
        public string SourceFileName { get; set; }
        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name="use_async_pattern", EmitDefaultValue=false)]
        public bool? UseAsyncPattern { get; set; }
        /// <summary>
        /// Content of the file to watermark
        /// </summary>
        /// <value>Content of the file to watermark</value>
        [DataMember(Name="source_file_content", EmitDefaultValue=false)]
        public byte[] SourceFileContent { get; set; }
        /// <summary>
        /// Watermark text in RTF format
        /// </summary>
        /// <value>Watermark text in RTF format</value>
        [DataMember(Name="rtf_data", EmitDefaultValue=false)]
        public string RtfData { get; set; }
        /// <summary>
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name="sharepoint_file", EmitDefaultValue=false)]
        public SharepointFile SharepointFile { get; set; }
        /// <summary>
        /// Width of the watermark (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Width of the watermark (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public string Width { get; set; }
        /// <summary>
        /// Height of the watermark (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Height of the watermark (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public string Height { get; set; }
        /// <summary>
        /// X Coordinate when &#39;Position&#39; is set to &#39;Absolute&#39; (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>X Coordinate when &#39;Position&#39; is set to &#39;Absolute&#39; (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public string X { get; set; }
        /// <summary>
        /// Y Coordinate when &#39;Position&#39; is set to &#39;Absolute&#39; (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Y Coordinate when &#39;Position&#39; is set to &#39;Absolute&#39; (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public string Y { get; set; }
        /// <summary>
        /// Angle of rotation
        /// </summary>
        /// <value>Angle of rotation</value>
        [DataMember(Name="rotation", EmitDefaultValue=false)]
        public string Rotation { get; set; }
        /// <summary>
        /// Opacity in % (100 is fully visible and 1 is barely visible)
        /// </summary>
        /// <value>Opacity in % (100 is fully visible and 1 is barely visible)</value>
        [DataMember(Name="opacity", EmitDefaultValue=false)]
        public string Opacity { get; set; }
        /// <summary>
        /// Color in #RRGGBB notation
        /// </summary>
        /// <value>Color in #RRGGBB notation</value>
        [DataMember(Name="fill_color", EmitDefaultValue=false)]
        public string FillColor { get; set; }
        /// <summary>
        /// Color in #RRGGBB notation
        /// </summary>
        /// <value>Color in #RRGGBB notation</value>
        [DataMember(Name="line_color", EmitDefaultValue=false)]
        public string LineColor { get; set; }
        /// <summary>
        /// Width of the watermark outline (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Width of the watermark outline (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="line_width", EmitDefaultValue=false)]
        public string LineWidth { get; set; }
        /// <summary>
        /// Number of the first page the watermark applies to
        /// </summary>
        /// <value>Number of the first page the watermark applies to</value>
        [DataMember(Name="start_page", EmitDefaultValue=false)]
        public int? StartPage { get; set; }
        /// <summary>
        /// Number of the last page the watermark applies to
        /// </summary>
        /// <value>Number of the last page the watermark applies to</value>
        [DataMember(Name="end_page", EmitDefaultValue=false)]
        public int? EndPage { get; set; }
        /// <summary>
        /// Which pages to display the watermark on (1&#x3D;every page, 2&#x3D;every other, etc)
        /// </summary>
        /// <value>Which pages to display the watermark on (1&#x3D;every page, 2&#x3D;every other, etc)</value>
        [DataMember(Name="page_interval", EmitDefaultValue=false)]
        public int? PageInterval { get; set; }
        /// <summary>
        /// The first section in a Word or Excel document the watermark is visible
        /// </summary>
        /// <value>The first section in a Word or Excel document the watermark is visible</value>
        [DataMember(Name="start_section", EmitDefaultValue=false)]
        public int? StartSection { get; set; }
        /// <summary>
        /// The last section in a Word or Excel document the watermark is visible
        /// </summary>
        /// <value>The last section in a Word or Excel document the watermark is visible</value>
        [DataMember(Name="end_section", EmitDefaultValue=false)]
        public int? EndSection { get; set; }
        /// <summary>
        /// One or more page types for Word and Excel documents, eg. default|first|even
        /// </summary>
        /// <value>One or more page types for Word and Excel documents, eg. default|first|even</value>
        [DataMember(Name="page_type", EmitDefaultValue=false)]
        public string PageType { get; set; }
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
            sb.Append("class RtfWatermarkData {\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  RtfData: ").Append(RtfData).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Layer: ").Append(Layer).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
            sb.Append("  LineColor: ").Append(LineColor).Append("\n");
            sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
            sb.Append("  StartPage: ").Append(StartPage).Append("\n");
            sb.Append("  EndPage: ").Append(EndPage).Append("\n");
            sb.Append("  PageInterval: ").Append(PageInterval).Append("\n");
            sb.Append("  PageOrientation: ").Append(PageOrientation).Append("\n");
            sb.Append("  PrintOnly: ").Append(PrintOnly).Append("\n");
            sb.Append("  StartSection: ").Append(StartSection).Append("\n");
            sb.Append("  EndSection: ").Append(EndSection).Append("\n");
            sb.Append("  PageType: ").Append(PageType).Append("\n");
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
            return this.Equals(obj as RtfWatermarkData);
        }

        /// <summary>
        /// Returns true if RtfWatermarkData instances are equal
        /// </summary>
        /// <param name="other">Instance of RtfWatermarkData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RtfWatermarkData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceFileName == other.SourceFileName ||
                    this.SourceFileName != null &&
                    this.SourceFileName.Equals(other.SourceFileName)
                ) && 
                (
                    this.UseAsyncPattern == other.UseAsyncPattern ||
                    this.UseAsyncPattern != null &&
                    this.UseAsyncPattern.Equals(other.UseAsyncPattern)
                ) && 
                (
                    this.SourceFileContent == other.SourceFileContent ||
                    this.SourceFileContent != null &&
                    this.SourceFileContent.Equals(other.SourceFileContent)
                ) && 
                (
                    this.RtfData == other.RtfData ||
                    this.RtfData != null &&
                    this.RtfData.Equals(other.RtfData)
                ) && 
                (
                    this.SharepointFile == other.SharepointFile ||
                    this.SharepointFile != null &&
                    this.SharepointFile.Equals(other.SharepointFile)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.X == other.X ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) && 
                (
                    this.Y == other.Y ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
                ) && 
                (
                    this.Layer == other.Layer ||
                    this.Layer != null &&
                    this.Layer.Equals(other.Layer)
                ) && 
                (
                    this.Rotation == other.Rotation ||
                    this.Rotation != null &&
                    this.Rotation.Equals(other.Rotation)
                ) && 
                (
                    this.Opacity == other.Opacity ||
                    this.Opacity != null &&
                    this.Opacity.Equals(other.Opacity)
                ) && 
                (
                    this.FillColor == other.FillColor ||
                    this.FillColor != null &&
                    this.FillColor.Equals(other.FillColor)
                ) && 
                (
                    this.LineColor == other.LineColor ||
                    this.LineColor != null &&
                    this.LineColor.Equals(other.LineColor)
                ) && 
                (
                    this.LineWidth == other.LineWidth ||
                    this.LineWidth != null &&
                    this.LineWidth.Equals(other.LineWidth)
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
                    this.PageInterval == other.PageInterval ||
                    this.PageInterval != null &&
                    this.PageInterval.Equals(other.PageInterval)
                ) && 
                (
                    this.PageOrientation == other.PageOrientation ||
                    this.PageOrientation != null &&
                    this.PageOrientation.Equals(other.PageOrientation)
                ) && 
                (
                    this.PrintOnly == other.PrintOnly ||
                    this.PrintOnly != null &&
                    this.PrintOnly.Equals(other.PrintOnly)
                ) && 
                (
                    this.StartSection == other.StartSection ||
                    this.StartSection != null &&
                    this.StartSection.Equals(other.StartSection)
                ) && 
                (
                    this.EndSection == other.EndSection ||
                    this.EndSection != null &&
                    this.EndSection.Equals(other.EndSection)
                ) && 
                (
                    this.PageType == other.PageType ||
                    this.PageType != null &&
                    this.PageType.Equals(other.PageType)
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
                if (this.SourceFileName != null)
                    hash = hash * 59 + this.SourceFileName.GetHashCode();
                if (this.UseAsyncPattern != null)
                    hash = hash * 59 + this.UseAsyncPattern.GetHashCode();
                if (this.SourceFileContent != null)
                    hash = hash * 59 + this.SourceFileContent.GetHashCode();
                if (this.RtfData != null)
                    hash = hash * 59 + this.RtfData.GetHashCode();
                if (this.SharepointFile != null)
                    hash = hash * 59 + this.SharepointFile.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
                if (this.Layer != null)
                    hash = hash * 59 + this.Layer.GetHashCode();
                if (this.Rotation != null)
                    hash = hash * 59 + this.Rotation.GetHashCode();
                if (this.Opacity != null)
                    hash = hash * 59 + this.Opacity.GetHashCode();
                if (this.FillColor != null)
                    hash = hash * 59 + this.FillColor.GetHashCode();
                if (this.LineColor != null)
                    hash = hash * 59 + this.LineColor.GetHashCode();
                if (this.LineWidth != null)
                    hash = hash * 59 + this.LineWidth.GetHashCode();
                if (this.StartPage != null)
                    hash = hash * 59 + this.StartPage.GetHashCode();
                if (this.EndPage != null)
                    hash = hash * 59 + this.EndPage.GetHashCode();
                if (this.PageInterval != null)
                    hash = hash * 59 + this.PageInterval.GetHashCode();
                if (this.PageOrientation != null)
                    hash = hash * 59 + this.PageOrientation.GetHashCode();
                if (this.PrintOnly != null)
                    hash = hash * 59 + this.PrintOnly.GetHashCode();
                if (this.StartSection != null)
                    hash = hash * 59 + this.StartSection.GetHashCode();
                if (this.EndSection != null)
                    hash = hash * 59 + this.EndSection.GetHashCode();
                if (this.PageType != null)
                    hash = hash * 59 + this.PageType.GetHashCode();
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
