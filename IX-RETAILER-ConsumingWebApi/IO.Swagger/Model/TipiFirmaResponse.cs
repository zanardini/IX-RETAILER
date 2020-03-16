/* 
 * Contratti API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
    /// TipiFirmaResponse
    /// </summary>
    [DataContract]
    public partial class TipiFirmaResponse :  IEquatable<TipiFirmaResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TipiFirmaResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TipiFirmaResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TipiFirmaResponse" /> class.
        /// </summary>
        /// <param name="tipiFirma">tipiFirma (required).</param>
        public TipiFirmaResponse(List<TipoFirmaResponse> tipiFirma = default(List<TipoFirmaResponse>))
        {
            // to ensure "tipiFirma" is required (not null)
            if (tipiFirma == null)
            {
                throw new InvalidDataException("tipiFirma is a required property for TipiFirmaResponse and cannot be null");
            }
            else
            {
                this.TipiFirma = tipiFirma;
            }
        }
        
        /// <summary>
        /// Gets or Sets TipiFirma
        /// </summary>
        [DataMember(Name="tipiFirma", EmitDefaultValue=false)]
        public List<TipoFirmaResponse> TipiFirma { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipiFirmaResponse {\n");
            sb.Append("  TipiFirma: ").Append(TipiFirma).Append("\n");
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
            return this.Equals(input as TipiFirmaResponse);
        }

        /// <summary>
        /// Returns true if TipiFirmaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TipiFirmaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipiFirmaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TipiFirma == input.TipiFirma ||
                    this.TipiFirma != null &&
                    this.TipiFirma.SequenceEqual(input.TipiFirma)
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
                if (this.TipiFirma != null)
                    hashCode = hashCode * 59 + this.TipiFirma.GetHashCode();
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
