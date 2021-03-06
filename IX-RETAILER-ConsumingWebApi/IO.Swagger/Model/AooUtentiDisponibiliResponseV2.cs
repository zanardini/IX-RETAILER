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
    /// AooUtentiDisponibiliResponseV2
    /// </summary>
    [DataContract]
    public partial class AooUtentiDisponibiliResponseV2 :  IEquatable<AooUtentiDisponibiliResponseV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AooUtentiDisponibiliResponseV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AooUtentiDisponibiliResponseV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AooUtentiDisponibiliResponseV2" /> class.
        /// </summary>
        /// <param name="utenti">utenti (required).</param>
        public AooUtentiDisponibiliResponseV2(List<AooUtenteDisponibileResponseV2> utenti = default(List<AooUtenteDisponibileResponseV2>))
        {
            // to ensure "utenti" is required (not null)
            if (utenti == null)
            {
                throw new InvalidDataException("utenti is a required property for AooUtentiDisponibiliResponseV2 and cannot be null");
            }
            else
            {
                this.Utenti = utenti;
            }
        }
        
        /// <summary>
        /// Gets or Sets Utenti
        /// </summary>
        [DataMember(Name="utenti", EmitDefaultValue=false)]
        public List<AooUtenteDisponibileResponseV2> Utenti { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AooUtentiDisponibiliResponseV2 {\n");
            sb.Append("  Utenti: ").Append(Utenti).Append("\n");
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
            return this.Equals(input as AooUtentiDisponibiliResponseV2);
        }

        /// <summary>
        /// Returns true if AooUtentiDisponibiliResponseV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of AooUtentiDisponibiliResponseV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AooUtentiDisponibiliResponseV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Utenti == input.Utenti ||
                    this.Utenti != null &&
                    this.Utenti.SequenceEqual(input.Utenti)
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
                if (this.Utenti != null)
                    hashCode = hashCode * 59 + this.Utenti.GetHashCode();
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
