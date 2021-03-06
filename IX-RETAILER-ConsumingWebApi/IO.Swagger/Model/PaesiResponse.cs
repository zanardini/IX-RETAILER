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
    /// PaesiResponse
    /// </summary>
    [DataContract]
    public partial class PaesiResponse :  IEquatable<PaesiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaesiResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaesiResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaesiResponse" /> class.
        /// </summary>
        /// <param name="paesi">paesi (required).</param>
        public PaesiResponse(List<PaeseResponse> paesi = default(List<PaeseResponse>))
        {
            // to ensure "paesi" is required (not null)
            if (paesi == null)
            {
                throw new InvalidDataException("paesi is a required property for PaesiResponse and cannot be null");
            }
            else
            {
                this.Paesi = paesi;
            }
        }
        
        /// <summary>
        /// Gets or Sets Paesi
        /// </summary>
        [DataMember(Name="paesi", EmitDefaultValue=false)]
        public List<PaeseResponse> Paesi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaesiResponse {\n");
            sb.Append("  Paesi: ").Append(Paesi).Append("\n");
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
            return this.Equals(input as PaesiResponse);
        }

        /// <summary>
        /// Returns true if PaesiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaesiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaesiResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Paesi == input.Paesi ||
                    this.Paesi != null &&
                    this.Paesi.SequenceEqual(input.Paesi)
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
                if (this.Paesi != null)
                    hashCode = hashCode * 59 + this.Paesi.GetHashCode();
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
