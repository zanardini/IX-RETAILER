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
    /// InfoPasswordRequest
    /// </summary>
    [DataContract]
    public partial class InfoPasswordRequest :  IEquatable<InfoPasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPasswordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPasswordRequest" /> class.
        /// </summary>
        /// <param name="oldpassword">oldpassword (required).</param>
        /// <param name="newpassword">newpassword (required).</param>
        public InfoPasswordRequest(string oldpassword = default(string), string newpassword = default(string))
        {
            // to ensure "oldpassword" is required (not null)
            if (oldpassword == null)
            {
                throw new InvalidDataException("oldpassword is a required property for InfoPasswordRequest and cannot be null");
            }
            else
            {
                this.Oldpassword = oldpassword;
            }
            // to ensure "newpassword" is required (not null)
            if (newpassword == null)
            {
                throw new InvalidDataException("newpassword is a required property for InfoPasswordRequest and cannot be null");
            }
            else
            {
                this.Newpassword = newpassword;
            }
        }
        
        /// <summary>
        /// Gets or Sets Oldpassword
        /// </summary>
        [DataMember(Name="oldpassword", EmitDefaultValue=false)]
        public string Oldpassword { get; set; }

        /// <summary>
        /// Gets or Sets Newpassword
        /// </summary>
        [DataMember(Name="newpassword", EmitDefaultValue=false)]
        public string Newpassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoPasswordRequest {\n");
            sb.Append("  Oldpassword: ").Append(Oldpassword).Append("\n");
            sb.Append("  Newpassword: ").Append(Newpassword).Append("\n");
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
            return this.Equals(input as InfoPasswordRequest);
        }

        /// <summary>
        /// Returns true if InfoPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Oldpassword == input.Oldpassword ||
                    (this.Oldpassword != null &&
                    this.Oldpassword.Equals(input.Oldpassword))
                ) && 
                (
                    this.Newpassword == input.Newpassword ||
                    (this.Newpassword != null &&
                    this.Newpassword.Equals(input.Newpassword))
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
                if (this.Oldpassword != null)
                    hashCode = hashCode * 59 + this.Oldpassword.GetHashCode();
                if (this.Newpassword != null)
                    hashCode = hashCode * 59 + this.Newpassword.GetHashCode();
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
            // Oldpassword (string) maxLength
            if(this.Oldpassword != null && this.Oldpassword.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Oldpassword, length must be less than 255.", new [] { "Oldpassword" });
            }

            // Oldpassword (string) minLength
            if(this.Oldpassword != null && this.Oldpassword.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Oldpassword, length must be greater than 0.", new [] { "Oldpassword" });
            }

            // Newpassword (string) maxLength
            if(this.Newpassword != null && this.Newpassword.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Newpassword, length must be less than 255.", new [] { "Newpassword" });
            }

            // Newpassword (string) minLength
            if(this.Newpassword != null && this.Newpassword.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Newpassword, length must be greater than 0.", new [] { "Newpassword" });
            }

            yield break;
        }
    }

}
