/* 
 * Contratti API V2.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ListResultCount
    /// </summary>
    [DataContract]
    public partial class ListResultCount :  IEquatable<ListResultCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListResultCount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListResultCount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListResultCount" /> class.
        /// </summary>
        /// <param name="totalRecords">totalRecords (required).</param>
        /// <param name="totalResultRecords">totalResultRecords (required).</param>
        public ListResultCount(int? totalRecords = default(int?), int? totalResultRecords = default(int?))
        {
            // to ensure "totalRecords" is required (not null)
            if (totalRecords == null)
            {
                throw new InvalidDataException("totalRecords is a required property for ListResultCount and cannot be null");
            }
            else
            {
                this.TotalRecords = totalRecords;
            }
            // to ensure "totalResultRecords" is required (not null)
            if (totalResultRecords == null)
            {
                throw new InvalidDataException("totalResultRecords is a required property for ListResultCount and cannot be null");
            }
            else
            {
                this.TotalResultRecords = totalResultRecords;
            }
        }
        
        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Gets or Sets TotalResultRecords
        /// </summary>
        [DataMember(Name="totalResultRecords", EmitDefaultValue=false)]
        public int? TotalResultRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResultCount {\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  TotalResultRecords: ").Append(TotalResultRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResultCount);
        }

        /// <summary>
        /// Returns true if ListResultCount instances are equal
        /// </summary>
        /// <param name="input">Instance of ListResultCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListResultCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalRecords == input.TotalRecords ||
                    (this.TotalRecords != null &&
                    this.TotalRecords.Equals(input.TotalRecords))
                ) && 
                (
                    this.TotalResultRecords == input.TotalResultRecords ||
                    (this.TotalResultRecords != null &&
                    this.TotalResultRecords.Equals(input.TotalResultRecords))
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
                if (this.TotalRecords != null)
                    hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.TotalResultRecords != null)
                    hashCode = hashCode * 59 + this.TotalResultRecords.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
