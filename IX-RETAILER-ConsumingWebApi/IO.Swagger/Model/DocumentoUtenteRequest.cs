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
    /// DocumentoUtenteRequest
    /// </summary>
    [DataContract]
    public partial class DocumentoUtenteRequest :  IEquatable<DocumentoUtenteRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Tipo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEnum
        {
            
            /// <summary>
            /// Enum CARTAIDENTITA for value: CARTA_IDENTITA
            /// </summary>
            [EnumMember(Value = "CARTA_IDENTITA")]
            CARTAIDENTITA = 1,
            
            /// <summary>
            /// Enum PASSAPORTO for value: PASSAPORTO
            /// </summary>
            [EnumMember(Value = "PASSAPORTO")]
            PASSAPORTO = 2,
            
            /// <summary>
            /// Enum PATENTE for value: PATENTE
            /// </summary>
            [EnumMember(Value = "PATENTE")]
            PATENTE = 3
        }

        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public TipoEnum Tipo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoUtenteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentoUtenteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoUtenteRequest" /> class.
        /// </summary>
        /// <param name="identificativoUtente">identificativoUtente (required).</param>
        /// <param name="tipo">tipo (required).</param>
        /// <param name="numero">numero (required).</param>
        /// <param name="enteRilascio">enteRilascio (required).</param>
        /// <param name="dataRilascio">dataRilascio (required).</param>
        /// <param name="dataScadenza">dataScadenza (required).</param>
        public DocumentoUtenteRequest(string identificativoUtente = default(string), TipoEnum tipo = default(TipoEnum), string numero = default(string), string enteRilascio = default(string), DateTime? dataRilascio = default(DateTime?), DateTime? dataScadenza = default(DateTime?))
        {
            // to ensure "identificativoUtente" is required (not null)
            if (identificativoUtente == null)
            {
                throw new InvalidDataException("identificativoUtente is a required property for DocumentoUtenteRequest and cannot be null");
            }
            else
            {
                this.IdentificativoUtente = identificativoUtente;
            }
            // to ensure "tipo" is required (not null)
            if (tipo == null)
            {
                throw new InvalidDataException("tipo is a required property for DocumentoUtenteRequest and cannot be null");
            }
            else
            {
                this.Tipo = tipo;
            }
            // to ensure "numero" is required (not null)
            if (numero == null)
            {
                throw new InvalidDataException("numero is a required property for DocumentoUtenteRequest and cannot be null");
            }
            else
            {
                this.Numero = numero;
            }
            // to ensure "enteRilascio" is required (not null)
            if (enteRilascio == null)
            {
                throw new InvalidDataException("enteRilascio is a required property for DocumentoUtenteRequest and cannot be null");
            }
            else
            {
                this.EnteRilascio = enteRilascio;
            }
            // to ensure "dataRilascio" is required (not null)
            if (dataRilascio == null)
            {
                throw new InvalidDataException("dataRilascio is a required property for DocumentoUtenteRequest and cannot be null");
            }
            else
            {
                this.DataRilascio = dataRilascio;
            }
            // to ensure "dataScadenza" is required (not null)
            if (dataScadenza == null)
            {
                throw new InvalidDataException("dataScadenza is a required property for DocumentoUtenteRequest and cannot be null");
            }
            else
            {
                this.DataScadenza = dataScadenza;
            }
        }
        
        /// <summary>
        /// Gets or Sets IdentificativoUtente
        /// </summary>
        [DataMember(Name="identificativoUtente", EmitDefaultValue=false)]
        public string IdentificativoUtente { get; set; }


        /// <summary>
        /// Gets or Sets Numero
        /// </summary>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public string Numero { get; set; }

        /// <summary>
        /// Gets or Sets EnteRilascio
        /// </summary>
        [DataMember(Name="enteRilascio", EmitDefaultValue=false)]
        public string EnteRilascio { get; set; }

        /// <summary>
        /// Gets or Sets DataRilascio
        /// </summary>
        [DataMember(Name="dataRilascio", EmitDefaultValue=false)]
        public DateTime? DataRilascio { get; set; }

        /// <summary>
        /// Gets or Sets DataScadenza
        /// </summary>
        [DataMember(Name="dataScadenza", EmitDefaultValue=false)]
        public DateTime? DataScadenza { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoUtenteRequest {\n");
            sb.Append("  IdentificativoUtente: ").Append(IdentificativoUtente).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  EnteRilascio: ").Append(EnteRilascio).Append("\n");
            sb.Append("  DataRilascio: ").Append(DataRilascio).Append("\n");
            sb.Append("  DataScadenza: ").Append(DataScadenza).Append("\n");
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
            return this.Equals(input as DocumentoUtenteRequest);
        }

        /// <summary>
        /// Returns true if DocumentoUtenteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentoUtenteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoUtenteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentificativoUtente == input.IdentificativoUtente ||
                    (this.IdentificativoUtente != null &&
                    this.IdentificativoUtente.Equals(input.IdentificativoUtente))
                ) && 
                (
                    this.Tipo == input.Tipo ||
                    (this.Tipo != null &&
                    this.Tipo.Equals(input.Tipo))
                ) && 
                (
                    this.Numero == input.Numero ||
                    (this.Numero != null &&
                    this.Numero.Equals(input.Numero))
                ) && 
                (
                    this.EnteRilascio == input.EnteRilascio ||
                    (this.EnteRilascio != null &&
                    this.EnteRilascio.Equals(input.EnteRilascio))
                ) && 
                (
                    this.DataRilascio == input.DataRilascio ||
                    (this.DataRilascio != null &&
                    this.DataRilascio.Equals(input.DataRilascio))
                ) && 
                (
                    this.DataScadenza == input.DataScadenza ||
                    (this.DataScadenza != null &&
                    this.DataScadenza.Equals(input.DataScadenza))
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
                if (this.IdentificativoUtente != null)
                    hashCode = hashCode * 59 + this.IdentificativoUtente.GetHashCode();
                if (this.Tipo != null)
                    hashCode = hashCode * 59 + this.Tipo.GetHashCode();
                if (this.Numero != null)
                    hashCode = hashCode * 59 + this.Numero.GetHashCode();
                if (this.EnteRilascio != null)
                    hashCode = hashCode * 59 + this.EnteRilascio.GetHashCode();
                if (this.DataRilascio != null)
                    hashCode = hashCode * 59 + this.DataRilascio.GetHashCode();
                if (this.DataScadenza != null)
                    hashCode = hashCode * 59 + this.DataScadenza.GetHashCode();
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
