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
    /// SharePoint file information for operation
    /// </summary>
    [DataContract(Name = "sharepoint_file")]
    public partial class SharepointFile : IEquatable<SharepointFile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointFile" /> class.
        /// </summary>
        /// <param name="siteUrl">SharePoint site url (example: http://contoso.sharepoint.com/sites/mysite).</param>
        /// <param name="sourceFileUrl">Path to the source file.</param>
        /// <param name="destinationFileUrl">Path to the destination file.</param>
        /// <param name="username">User name to log in to the SharePoint site.</param>
        /// <param name="password">Password to log in to the SharePoint site’.</param>
        public SharepointFile(string siteUrl = default(string), string sourceFileUrl = default(string), string destinationFileUrl = default(string), string username = default(string), string password = default(string))
        {
            this.SiteUrl = siteUrl;
            this.SourceFileUrl = sourceFileUrl;
            this.DestinationFileUrl = destinationFileUrl;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// SharePoint site url (example: http://contoso.sharepoint.com/sites/mysite)
        /// </summary>
        /// <value>SharePoint site url (example: http://contoso.sharepoint.com/sites/mysite)</value>
        [DataMember(Name = "site_url", EmitDefaultValue = false)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Path to the source file
        /// </summary>
        /// <value>Path to the source file</value>
        [DataMember(Name = "source_file_url", EmitDefaultValue = false)]
        public string SourceFileUrl { get; set; }

        /// <summary>
        /// Path to the destination file
        /// </summary>
        /// <value>Path to the destination file</value>
        [DataMember(Name = "destination_file_url", EmitDefaultValue = false)]
        public string DestinationFileUrl { get; set; }

        /// <summary>
        /// User name to log in to the SharePoint site
        /// </summary>
        /// <value>User name to log in to the SharePoint site</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Password to log in to the SharePoint site’
        /// </summary>
        /// <value>Password to log in to the SharePoint site’</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharepointFile {\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  SourceFileUrl: ").Append(SourceFileUrl).Append("\n");
            sb.Append("  DestinationFileUrl: ").Append(DestinationFileUrl).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as SharepointFile);
        }

        /// <summary>
        /// Returns true if SharepointFile instances are equal
        /// </summary>
        /// <param name="input">Instance of SharepointFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharepointFile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.SourceFileUrl == input.SourceFileUrl ||
                    (this.SourceFileUrl != null &&
                    this.SourceFileUrl.Equals(input.SourceFileUrl))
                ) && 
                (
                    this.DestinationFileUrl == input.DestinationFileUrl ||
                    (this.DestinationFileUrl != null &&
                    this.DestinationFileUrl.Equals(input.DestinationFileUrl))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.SiteUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SiteUrl.GetHashCode();
                }
                if (this.SourceFileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileUrl.GetHashCode();
                }
                if (this.DestinationFileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationFileUrl.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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