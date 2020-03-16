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
    /// TipoCausalePagamento
    /// </summary>
    [DataContract]
    public partial class TipoCausalePagamento :  IEquatable<TipoCausalePagamento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoCausalePagamento" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TipoCausalePagamento() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoCausalePagamento" /> class.
        /// </summary>
        /// <param name="codice">codice (required).</param>
        /// <param name="descrizione">descrizione (required).</param>
        public TipoCausalePagamento(string codice = default(string), string descrizione = default(string))
        {
            // to ensure "codice" is required (not null)
            if (codice == null)
            {
                throw new InvalidDataException("codice is a required property for TipoCausalePagamento and cannot be null");
            }
            else
            {
                this.Codice = codice;
            }
            // to ensure "descrizione" is required (not null)
            if (descrizione == null)
            {
                throw new InvalidDataException("descrizione is a required property for TipoCausalePagamento and cannot be null");
            }
            else
            {
                this.Descrizione = descrizione;
            }
        }
        
        /// <summary>
        /// Gets or Sets Codice
        /// </summary>
        [DataMember(Name="codice", EmitDefaultValue=false)]
        public string Codice { get; set; }

        /// <summary>
        /// Gets or Sets Descrizione
        /// </summary>
        [DataMember(Name="descrizione", EmitDefaultValue=false)]
        public string Descrizione { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoCausalePagamento {\n");
            sb.Append("  Codice: ").Append(Codice).Append("\n");
            sb.Append("  Descrizione: ").Append(Descrizione).Append("\n");
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
            return this.Equals(input as TipoCausalePagamento);
        }

        /// <summary>
        /// Returns true if TipoCausalePagamento instances are equal
        /// </summary>
        /// <param name="input">Instance of TipoCausalePagamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoCausalePagamento input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Codice == input.Codice ||
                    (this.Codice != null &&
                    this.Codice.Equals(input.Codice))
                ) && 
                (
                    this.Descrizione == input.Descrizione ||
                    (this.Descrizione != null &&
                    this.Descrizione.Equals(input.Descrizione))
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
                if (this.Codice != null)
                    hashCode = hashCode * 59 + this.Codice.GetHashCode();
                if (this.Descrizione != null)
                    hashCode = hashCode * 59 + this.Descrizione.GetHashCode();
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
