/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.14.1
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
    /// Parameters for LineWatermark operation
    /// </summary>
    [DataContract]
    public partial class LineWatermarkData :  IEquatable<LineWatermarkData>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="LineWatermarkData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineWatermarkData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineWatermarkData" /> class.
        /// </summary>
        /// <param name="SourceFileName">Name of the source file including extension.</param>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="SourceFileContent">Content of the file to watermark (required).</param>
        /// <param name="Position">Watermark position on the page (required) (default to PositionEnum.MiddleCenter).</param>
        /// <param name="SharepointFile">SharepointFile.</param>
        /// <param name="X">Start X Coordinate of the line (in Pts, 1/72 of an inch) (required).</param>
        /// <param name="Y">Start Y Coordinate of the line (in Pts, 1/72 of an inch) (required).</param>
        /// <param name="EndX">End X Coordinate of the line (in Pts, 1/72 of an inch) (required).</param>
        /// <param name="EndY">End Y Coordinate of the line (in Pts, 1/72 of an inch) (required).</param>
        /// <param name="Layer">Watermark layer (default to LayerEnum.Foreground).</param>
        /// <param name="Rotation">Angle of rotation.</param>
        /// <param name="Opacity">Opacity in % (100 is fully visible and 1 is barely visible) (default to &quot;100&quot;).</param>
        /// <param name="LineColor">Color in #RRGGBB notation.</param>
        /// <param name="LineWidth">Width of the line (in Pts, 1/72 of an inch).</param>
        /// <param name="StartPage">Number of the first page the watermark applies to.</param>
        /// <param name="EndPage">Number of the last page the watermark applies to.</param>
        /// <param name="PageInterval">Which pages to display the watermark on (1&#x3D;every page, 2&#x3D;every other, etc).</param>
        /// <param name="PageOrientation">Orientation of pages the watermark applies to. (default to PageOrientationEnum.Both).</param>
        /// <param name="PrintOnly">Tells if the watermark is only visible when the document is printed (default to PrintOnlyEnum.False).</param>
        /// <param name="StartSection">The first section in a Word or Excel document the watermark is visible.</param>
        /// <param name="EndSection">The last section in a Word or Excel document the watermark is visible.</param>
        /// <param name="PageType">One or more page types for Word and Excel documents, eg. default|first|even.</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public LineWatermarkData(string SourceFileName = default(string), bool? UseAsyncPattern = false, byte[] SourceFileContent = default(byte[]), PositionEnum? Position = PositionEnum.MiddleCenter, SharepointFile SharepointFile = default(SharepointFile), string X = default(string), string Y = default(string), string EndX = default(string), string EndY = default(string), LayerEnum? Layer = LayerEnum.Foreground, string Rotation = default(string), string Opacity = "100", string LineColor = default(string), string LineWidth = default(string), int? StartPage = default(int?), int? EndPage = default(int?), int? PageInterval = default(int?), PageOrientationEnum? PageOrientation = PageOrientationEnum.Both, PrintOnlyEnum? PrintOnly = PrintOnlyEnum.False, int? StartSection = default(int?), int? EndSection = default(int?), string PageType = default(string), bool? FailOnError = true)
        {
            // to ensure "UseAsyncPattern" is required (not null)
            if (UseAsyncPattern == null)
            {
                throw new InvalidDataException("UseAsyncPattern is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            // to ensure "SourceFileContent" is required (not null)
            if (SourceFileContent == null)
            {
                throw new InvalidDataException("SourceFileContent is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.SourceFileContent = SourceFileContent;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "X" is required (not null)
            if (X == null)
            {
                throw new InvalidDataException("X is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.X = X;
            }
            // to ensure "Y" is required (not null)
            if (Y == null)
            {
                throw new InvalidDataException("Y is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.Y = Y;
            }
            // to ensure "EndX" is required (not null)
            if (EndX == null)
            {
                throw new InvalidDataException("EndX is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.EndX = EndX;
            }
            // to ensure "EndY" is required (not null)
            if (EndY == null)
            {
                throw new InvalidDataException("EndY is a required property for LineWatermarkData and cannot be null");
            }
            else
            {
                this.EndY = EndY;
            }
            this.SourceFileName = SourceFileName;
            this.SharepointFile = SharepointFile;
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
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name="sharepoint_file", EmitDefaultValue=false)]
        public SharepointFile SharepointFile { get; set; }
        /// <summary>
        /// Start X Coordinate of the line (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Start X Coordinate of the line (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public string X { get; set; }
        /// <summary>
        /// Start Y Coordinate of the line (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Start Y Coordinate of the line (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public string Y { get; set; }
        /// <summary>
        /// End X Coordinate of the line (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>End X Coordinate of the line (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="end_x", EmitDefaultValue=false)]
        public string EndX { get; set; }
        /// <summary>
        /// End Y Coordinate of the line (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>End Y Coordinate of the line (in Pts, 1/72 of an inch)</value>
        [DataMember(Name="end_y", EmitDefaultValue=false)]
        public string EndY { get; set; }
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
        [DataMember(Name="line_color", EmitDefaultValue=false)]
        public string LineColor { get; set; }
        /// <summary>
        /// Width of the line (in Pts, 1/72 of an inch)
        /// </summary>
        /// <value>Width of the line (in Pts, 1/72 of an inch)</value>
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
            sb.Append("class LineWatermarkData {\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  EndX: ").Append(EndX).Append("\n");
            sb.Append("  EndY: ").Append(EndY).Append("\n");
            sb.Append("  Layer: ").Append(Layer).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
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
            return this.Equals(obj as LineWatermarkData);
        }

        /// <summary>
        /// Returns true if LineWatermarkData instances are equal
        /// </summary>
        /// <param name="other">Instance of LineWatermarkData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineWatermarkData other)
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
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.SharepointFile == other.SharepointFile ||
                    this.SharepointFile != null &&
                    this.SharepointFile.Equals(other.SharepointFile)
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
                    this.EndX == other.EndX ||
                    this.EndX != null &&
                    this.EndX.Equals(other.EndX)
                ) && 
                (
                    this.EndY == other.EndY ||
                    this.EndY != null &&
                    this.EndY.Equals(other.EndY)
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
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.SharepointFile != null)
                    hash = hash * 59 + this.SharepointFile.GetHashCode();
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
                if (this.EndX != null)
                    hash = hash * 59 + this.EndX.GetHashCode();
                if (this.EndY != null)
                    hash = hash * 59 + this.EndY.GetHashCode();
                if (this.Layer != null)
                    hash = hash * 59 + this.Layer.GetHashCode();
                if (this.Rotation != null)
                    hash = hash * 59 + this.Rotation.GetHashCode();
                if (this.Opacity != null)
                    hash = hash * 59 + this.Opacity.GetHashCode();
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
