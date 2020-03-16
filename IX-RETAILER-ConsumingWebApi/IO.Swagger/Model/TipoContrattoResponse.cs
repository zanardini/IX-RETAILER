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
    /// TipoContrattoResponse
    /// </summary>
    [DataContract]
    public partial class TipoContrattoResponse :  IEquatable<TipoContrattoResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Tipo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEnum
        {
            
            /// <summary>
            /// Enum ClienteFinale for value: ClienteFinale
            /// </summary>
            [EnumMember(Value = "ClienteFinale")]
            ClienteFinale = 1,
            
            /// <summary>
            /// Enum CentroServizi for value: CentroServizi
            /// </summary>
            [EnumMember(Value = "CentroServizi")]
            CentroServizi = 2,
            
            /// <summary>
            /// Enum Holding for value: Holding
            /// </summary>
            [EnumMember(Value = "Holding")]
            Holding = 3,
            
            /// <summary>
            /// Enum GruppoAcquisto for value: GruppoAcquisto
            /// </summary>
            [EnumMember(Value = "GruppoAcquisto")]
            GruppoAcquisto = 4
        }

        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public TipoEnum Tipo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoContrattoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TipoContrattoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoContrattoResponse" /> class.
        /// </summary>
        /// <param name="tipo">tipo (required).</param>
        /// <param name="descrizione">descrizione (required).</param>
        public TipoContrattoResponse(TipoEnum tipo = default(TipoEnum), string descrizione = default(string))
        {
            // to ensure "tipo" is required (not null)
            if (tipo == null)
            {
                throw new InvalidDataException("tipo is a required property for TipoContrattoResponse and cannot be null");
            }
            else
            {
                this.Tipo = tipo;
            }
            // to ensure "descrizione" is required (not null)
            if (descrizione == null)
            {
                throw new InvalidDataException("descrizione is a required property for TipoContrattoResponse and cannot be null");
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
            sb.Append("class TipoContrattoResponse {\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
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
            return this.Equals(input as TipoContrattoResponse);
        }

        /// <summary>
        /// Returns true if TipoContrattoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TipoContrattoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoContrattoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tipo == input.Tipo ||
                    (this.Tipo != null &&
                    this.Tipo.Equals(input.Tipo))
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
                if (this.Tipo != null)
                    hashCode = hashCode * 59 + this.Tipo.GetHashCode();
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
