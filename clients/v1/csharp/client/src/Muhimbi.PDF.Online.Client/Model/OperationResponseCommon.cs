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
    /// Response data for all operations
    /// </summary>
    [DataContract]
    public partial class OperationResponseCommon :  IEquatable<OperationResponseCommon>, IValidatableObject
    {
        /// <summary>
        /// Operation result code.
        /// </summary>
        /// <value>Operation result code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum ProcessingError for "ProcessingError"
            /// </summary>
            [EnumMember(Value = "ProcessingError")]
            ProcessingError,
            
            /// <summary>
            /// Enum SubscriptionNotFound for "SubscriptionNotFound"
            /// </summary>
            [EnumMember(Value = "SubscriptionNotFound")]
            SubscriptionNotFound,
            
            /// <summary>
            /// Enum SubscriptionExpired for "SubscriptionExpired"
            /// </summary>
            [EnumMember(Value = "SubscriptionExpired")]
            SubscriptionExpired,
            
            /// <summary>
            /// Enum ActivationPending for "ActivationPending"
            /// </summary>
            [EnumMember(Value = "ActivationPending")]
            ActivationPending,
            
            /// <summary>
            /// Enum TrialExpired for "TrialExpired"
            /// </summary>
            [EnumMember(Value = "TrialExpired")]
            TrialExpired,
            
            /// <summary>
            /// Enum OperationSizeExceeded for "OperationSizeExceeded"
            /// </summary>
            [EnumMember(Value = "OperationSizeExceeded")]
            OperationSizeExceeded,
            
            /// <summary>
            /// Enum OperationsExceeded for "OperationsExceeded"
            /// </summary>
            [EnumMember(Value = "OperationsExceeded")]
            OperationsExceeded,
            
            /// <summary>
            /// Enum InputFileTypeNotSupported for "InputFileTypeNotSupported"
            /// </summary>
            [EnumMember(Value = "InputFileTypeNotSupported")]
            InputFileTypeNotSupported,
            
            /// <summary>
            /// Enum OutputFileTypeNotSupported for "OutputFileTypeNotSupported"
            /// </summary>
            [EnumMember(Value = "OutputFileTypeNotSupported")]
            OutputFileTypeNotSupported,
            
            /// <summary>
            /// Enum OperationNotSupported for "OperationNotSupported"
            /// </summary>
            [EnumMember(Value = "OperationNotSupported")]
            OperationNotSupported,
            
            /// <summary>
            /// Enum Accepted for "Accepted"
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted,
            
            /// <summary>
            /// Enum AccessDenied for "AccessDenied"
            /// </summary>
            [EnumMember(Value = "AccessDenied")]
            AccessDenied,
            
            /// <summary>
            /// Enum InvalidExtension for "InvalidExtension"
            /// </summary>
            [EnumMember(Value = "InvalidExtension")]
            InvalidExtension
        }

        /// <summary>
        /// Operation result code.
        /// </summary>
        /// <value>Operation result code.</value>
        [DataMember(Name="result_code", EmitDefaultValue=false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResponseCommon" /> class.
        /// </summary>
        /// <param name="BaseFileName">Name of the input file without the extension..</param>
        /// <param name="ResultCode">Operation result code..</param>
        /// <param name="ResultDetails">Operation result details..</param>
        public OperationResponseCommon(string BaseFileName = default(string), ResultCodeEnum? ResultCode = default(ResultCodeEnum?), string ResultDetails = default(string))
        {
            this.BaseFileName = BaseFileName;
            this.ResultCode = ResultCode;
            this.ResultDetails = ResultDetails;
        }
        
        /// <summary>
        /// Name of the input file without the extension.
        /// </summary>
        /// <value>Name of the input file without the extension.</value>
        [DataMember(Name="base_file_name", EmitDefaultValue=false)]
        public string BaseFileName { get; set; }
        /// <summary>
        /// Operation result details.
        /// </summary>
        /// <value>Operation result details.</value>
        [DataMember(Name="result_details", EmitDefaultValue=false)]
        public string ResultDetails { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationResponseCommon {\n");
            sb.Append("  BaseFileName: ").Append(BaseFileName).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ResultDetails: ").Append(ResultDetails).Append("\n");
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
            return this.Equals(obj as OperationResponseCommon);
        }

        /// <summary>
        /// Returns true if OperationResponseCommon instances are equal
        /// </summary>
        /// <param name="other">Instance of OperationResponseCommon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationResponseCommon other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BaseFileName == other.BaseFileName ||
                    this.BaseFileName != null &&
                    this.BaseFileName.Equals(other.BaseFileName)
                ) && 
                (
                    this.ResultCode == other.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(other.ResultCode)
                ) && 
                (
                    this.ResultDetails == other.ResultDetails ||
                    this.ResultDetails != null &&
                    this.ResultDetails.Equals(other.ResultDetails)
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
                if (this.BaseFileName != null)
                    hash = hash * 59 + this.BaseFileName.GetHashCode();
                if (this.ResultCode != null)
                    hash = hash * 59 + this.ResultCode.GetHashCode();
                if (this.ResultDetails != null)
                    hash = hash * 59 + this.ResultDetails.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
