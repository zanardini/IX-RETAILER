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
    /// RuoloConservazioneResponse
    /// </summary>
    [DataContract]
    public partial class RuoloConservazioneResponse :  IEquatable<RuoloConservazioneResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Ruolo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RuoloEnum
        {
            
            /// <summary>
            /// Enum Produttore for value: Produttore
            /// </summary>
            [EnumMember(Value = "Produttore")]
            Produttore = 1,
            
            /// <summary>
            /// Enum Utente for value: Utente
            /// </summary>
            [EnumMember(Value = "Utente")]
            Utente = 2
        }

        /// <summary>
        /// Gets or Sets Ruolo
        /// </summary>
        [DataMember(Name="ruolo", EmitDefaultValue=false)]
        public RuoloEnum Ruolo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuoloConservazioneResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuoloConservazioneResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuoloConservazioneResponse" /> class.
        /// </summary>
        /// <param name="ruolo">ruolo (required).</param>
        /// <param name="descrizione">descrizione (required).</param>
        public RuoloConservazioneResponse(RuoloEnum ruolo = default(RuoloEnum), string descrizione = default(string))
        {
            // to ensure "ruolo" is required (not null)
            if (ruolo == null)
            {
                throw new InvalidDataException("ruolo is a required property for RuoloConservazioneResponse and cannot be null");
            }
            else
            {
                this.Ruolo = ruolo;
            }
            // to ensure "descrizione" is required (not null)
            if (descrizione == null)
            {
                throw new InvalidDataException("descrizione is a required property for RuoloConservazioneResponse and cannot be null");
            }
            else
            {
                this.Descrizione = descrizione;
            }
        }
        

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
            sb.Append("class RuoloConservazioneResponse {\n");
            sb.Append("  Ruolo: ").Append(Ruolo).Append("\n");
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
            return this.Equals(input as RuoloConservazioneResponse);
        }

        /// <summary>
        /// Returns true if RuoloConservazioneResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RuoloConservazioneResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuoloConservazioneResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ruolo == input.Ruolo ||
                    (this.Ruolo != null &&
                    this.Ruolo.Equals(input.Ruolo))
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
                if (this.Ruolo != null)
                    hashCode = hashCode * 59 + this.Ruolo.GetHashCode();
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
