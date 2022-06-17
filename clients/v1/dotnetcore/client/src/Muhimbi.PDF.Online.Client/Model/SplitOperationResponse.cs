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
    /// Response data for split operation
    /// </summary>
    [DataContract(Name = "split_operation_response")]
    public partial class SplitOperationResponse : IEquatable<SplitOperationResponse>, IValidatableObject
    {
        /// <summary>
        /// Operation result code.
        /// </summary>
        /// <value>Operation result code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 1,

            /// <summary>
            /// Enum ProcessingError for value: ProcessingError
            /// </summary>
            [EnumMember(Value = "ProcessingError")]
            ProcessingError = 2,

            /// <summary>
            /// Enum SubscriptionNotFound for value: SubscriptionNotFound
            /// </summary>
            [EnumMember(Value = "SubscriptionNotFound")]
            SubscriptionNotFound = 3,

            /// <summary>
            /// Enum SubscriptionExpired for value: SubscriptionExpired
            /// </summary>
            [EnumMember(Value = "SubscriptionExpired")]
            SubscriptionExpired = 4,

            /// <summary>
            /// Enum ActivationPending for value: ActivationPending
            /// </summary>
            [EnumMember(Value = "ActivationPending")]
            ActivationPending = 5,

            /// <summary>
            /// Enum TrialExpired for value: TrialExpired
            /// </summary>
            [EnumMember(Value = "TrialExpired")]
            TrialExpired = 6,

            /// <summary>
            /// Enum OperationSizeExceeded for value: OperationSizeExceeded
            /// </summary>
            [EnumMember(Value = "OperationSizeExceeded")]
            OperationSizeExceeded = 7,

            /// <summary>
            /// Enum OperationsExceeded for value: OperationsExceeded
            /// </summary>
            [EnumMember(Value = "OperationsExceeded")]
            OperationsExceeded = 8,

            /// <summary>
            /// Enum InputFileTypeNotSupported for value: InputFileTypeNotSupported
            /// </summary>
            [EnumMember(Value = "InputFileTypeNotSupported")]
            InputFileTypeNotSupported = 9,

            /// <summary>
            /// Enum OutputFileTypeNotSupported for value: OutputFileTypeNotSupported
            /// </summary>
            [EnumMember(Value = "OutputFileTypeNotSupported")]
            OutputFileTypeNotSupported = 10,

            /// <summary>
            /// Enum OperationNotSupported for value: OperationNotSupported
            /// </summary>
            [EnumMember(Value = "OperationNotSupported")]
            OperationNotSupported = 11,

            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 12,

            /// <summary>
            /// Enum AccessDenied for value: AccessDenied
            /// </summary>
            [EnumMember(Value = "AccessDenied")]
            AccessDenied = 13,

            /// <summary>
            /// Enum InvalidExtension for value: InvalidExtension
            /// </summary>
            [EnumMember(Value = "InvalidExtension")]
            InvalidExtension = 14

        }


        /// <summary>
        /// Operation result code.
        /// </summary>
        /// <value>Operation result code.</value>
        [DataMember(Name = "result_code", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitOperationResponse" /> class.
        /// </summary>
        /// <param name="processedFiles">Files generated by the Muhimbi converter..</param>
        /// <param name="resultCode">Operation result code..</param>
        /// <param name="resultDetails">Operation result details..</param>
        public SplitOperationResponse(List<ProcessedFiles> processedFiles = default(List<ProcessedFiles>), ResultCodeEnum? resultCode = default(ResultCodeEnum?), string resultDetails = default(string))
        {
            this.ProcessedFiles = processedFiles;
            this.ResultCode = resultCode;
            this.ResultDetails = resultDetails;
        }

        /// <summary>
        /// Files generated by the Muhimbi converter.
        /// </summary>
        /// <value>Files generated by the Muhimbi converter.</value>
        [DataMember(Name = "processed_files", EmitDefaultValue = false)]
        public List<ProcessedFiles> ProcessedFiles { get; set; }

        /// <summary>
        /// Operation result details.
        /// </summary>
        /// <value>Operation result details.</value>
        [DataMember(Name = "result_details", EmitDefaultValue = false)]
        public string ResultDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitOperationResponse {\n");
            sb.Append("  ProcessedFiles: ").Append(ProcessedFiles).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ResultDetails: ").Append(ResultDetails).Append("\n");
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
            return this.Equals(input as SplitOperationResponse);
        }

        /// <summary>
        /// Returns true if SplitOperationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitOperationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitOperationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProcessedFiles == input.ProcessedFiles ||
                    this.ProcessedFiles != null &&
                    input.ProcessedFiles != null &&
                    this.ProcessedFiles.SequenceEqual(input.ProcessedFiles)
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode.Equals(input.ResultCode)
                ) && 
                (
                    this.ResultDetails == input.ResultDetails ||
                    (this.ResultDetails != null &&
                    this.ResultDetails.Equals(input.ResultDetails))
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
                if (this.ProcessedFiles != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessedFiles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                if (this.ResultDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ResultDetails.GetHashCode();
                }
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
