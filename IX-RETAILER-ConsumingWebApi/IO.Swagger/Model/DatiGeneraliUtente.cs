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
    /// DatiGeneraliUtente
    /// </summary>
    [DataContract]
    public partial class DatiGeneraliUtente :  IEquatable<DatiGeneraliUtente>, IValidatableObject
    {
        /// <summary>
        /// Defines Sesso
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessoEnum
        {
            
            /// <summary>
            /// Enum M for value: M
            /// </summary>
            [EnumMember(Value = "M")]
            M = 1,
            
            /// <summary>
            /// Enum F for value: F
            /// </summary>
            [EnumMember(Value = "F")]
            F = 2
        }

        /// <summary>
        /// Gets or Sets Sesso
        /// </summary>
        [DataMember(Name="sesso", EmitDefaultValue=false)]
        public SessoEnum Sesso { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiGeneraliUtente" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatiGeneraliUtente() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatiGeneraliUtente" /> class.
        /// </summary>
        /// <param name="nome">nome (required).</param>
        /// <param name="cognome">cognome (required).</param>
        /// <param name="sesso">sesso (required).</param>
        /// <param name="cittadinanza">cittadinanza (required).</param>
        /// <param name="comuneNascita">comuneNascita.</param>
        /// <param name="natoEstero">natoEstero (required).</param>
        /// <param name="paeseNascitaEstero">paeseNascitaEstero.</param>
        /// <param name="comuneNascitaEstero">comuneNascitaEstero.</param>
        /// <param name="dataNascita">dataNascita (required).</param>
        public DatiGeneraliUtente(string nome = default(string), string cognome = default(string), SessoEnum sesso = default(SessoEnum), string cittadinanza = default(string), string comuneNascita = default(string), bool? natoEstero = default(bool?), string paeseNascitaEstero = default(string), string comuneNascitaEstero = default(string), DateTime? dataNascita = default(DateTime?))
        {
            // to ensure "nome" is required (not null)
            if (nome == null)
            {
                throw new InvalidDataException("nome is a required property for DatiGeneraliUtente and cannot be null");
            }
            else
            {
                this.Nome = nome;
            }
            // to ensure "cognome" is required (not null)
            if (cognome == null)
            {
                throw new InvalidDataException("cognome is a required property for DatiGeneraliUtente and cannot be null");
            }
            else
            {
                this.Cognome = cognome;
            }
            // to ensure "sesso" is required (not null)
            if (sesso == null)
            {
                throw new InvalidDataException("sesso is a required property for DatiGeneraliUtente and cannot be null");
            }
            else
            {
                this.Sesso = sesso;
            }
            // to ensure "cittadinanza" is required (not null)
            if (cittadinanza == null)
            {
                throw new InvalidDataException("cittadinanza is a required property for DatiGeneraliUtente and cannot be null");
            }
            else
            {
                this.Cittadinanza = cittadinanza;
            }
            // to ensure "natoEstero" is required (not null)
            if (natoEstero == null)
            {
                throw new InvalidDataException("natoEstero is a required property for DatiGeneraliUtente and cannot be null");
            }
            else
            {
                this.NatoEstero = natoEstero;
            }
            // to ensure "dataNascita" is required (not null)
            if (dataNascita == null)
            {
                throw new InvalidDataException("dataNascita is a required property for DatiGeneraliUtente and cannot be null");
            }
            else
            {
                this.DataNascita = dataNascita;
            }
            this.ComuneNascita = comuneNascita;
            this.PaeseNascitaEstero = paeseNascitaEstero;
            this.ComuneNascitaEstero = comuneNascitaEstero;
        }
        
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or Sets Cognome
        /// </summary>
        [DataMember(Name="cognome", EmitDefaultValue=false)]
        public string Cognome { get; set; }


        /// <summary>
        /// Gets or Sets Cittadinanza
        /// </summary>
        [DataMember(Name="cittadinanza", EmitDefaultValue=false)]
        public string Cittadinanza { get; set; }

        /// <summary>
        /// Gets or Sets ComuneNascita
        /// </summary>
        [DataMember(Name="comuneNascita", EmitDefaultValue=false)]
        public string ComuneNascita { get; set; }

        /// <summary>
        /// Gets or Sets NatoEstero
        /// </summary>
        [DataMember(Name="natoEstero", EmitDefaultValue=false)]
        public bool? NatoEstero { get; set; }

        /// <summary>
        /// Gets or Sets PaeseNascitaEstero
        /// </summary>
        [DataMember(Name="paeseNascitaEstero", EmitDefaultValue=false)]
        public string PaeseNascitaEstero { get; set; }

        /// <summary>
        /// Gets or Sets ComuneNascitaEstero
        /// </summary>
        [DataMember(Name="comuneNascitaEstero", EmitDefaultValue=false)]
        public string ComuneNascitaEstero { get; set; }

        /// <summary>
        /// Gets or Sets DataNascita
        /// </summary>
        [DataMember(Name="dataNascita", EmitDefaultValue=false)]
        public DateTime? DataNascita { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatiGeneraliUtente {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Cognome: ").Append(Cognome).Append("\n");
            sb.Append("  Sesso: ").Append(Sesso).Append("\n");
            sb.Append("  Cittadinanza: ").Append(Cittadinanza).Append("\n");
            sb.Append("  ComuneNascita: ").Append(ComuneNascita).Append("\n");
            sb.Append("  NatoEstero: ").Append(NatoEstero).Append("\n");
            sb.Append("  PaeseNascitaEstero: ").Append(PaeseNascitaEstero).Append("\n");
            sb.Append("  ComuneNascitaEstero: ").Append(ComuneNascitaEstero).Append("\n");
            sb.Append("  DataNascita: ").Append(DataNascita).Append("\n");
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
            return this.Equals(input as DatiGeneraliUtente);
        }

        /// <summary>
        /// Returns true if DatiGeneraliUtente instances are equal
        /// </summary>
        /// <param name="input">Instance of DatiGeneraliUtente to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatiGeneraliUtente input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
                ) && 
                (
                    this.Cognome == input.Cognome ||
                    (this.Cognome != null &&
                    this.Cognome.Equals(input.Cognome))
                ) && 
                (
                    this.Sesso == input.Sesso ||
                    (this.Sesso != null &&
                    this.Sesso.Equals(input.Sesso))
                ) && 
                (
                    this.Cittadinanza == input.Cittadinanza ||
                    (this.Cittadinanza != null &&
                    this.Cittadinanza.Equals(input.Cittadinanza))
                ) && 
                (
                    this.ComuneNascita == input.ComuneNascita ||
                    (this.ComuneNascita != null &&
                    this.ComuneNascita.Equals(input.ComuneNascita))
                ) && 
                (
                    this.NatoEstero == input.NatoEstero ||
                    (this.NatoEstero != null &&
                    this.NatoEstero.Equals(input.NatoEstero))
                ) && 
                (
                    this.PaeseNascitaEstero == input.PaeseNascitaEstero ||
                    (this.PaeseNascitaEstero != null &&
                    this.PaeseNascitaEstero.Equals(input.PaeseNascitaEstero))
                ) && 
                (
                    this.ComuneNascitaEstero == input.ComuneNascitaEstero ||
                    (this.ComuneNascitaEstero != null &&
                    this.ComuneNascitaEstero.Equals(input.ComuneNascitaEstero))
                ) && 
                (
                    this.DataNascita == input.DataNascita ||
                    (this.DataNascita != null &&
                    this.DataNascita.Equals(input.DataNascita))
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
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
                if (this.Cognome != null)
                    hashCode = hashCode * 59 + this.Cognome.GetHashCode();
                if (this.Sesso != null)
                    hashCode = hashCode * 59 + this.Sesso.GetHashCode();
                if (this.Cittadinanza != null)
                    hashCode = hashCode * 59 + this.Cittadinanza.GetHashCode();
                if (this.ComuneNascita != null)
                    hashCode = hashCode * 59 + this.ComuneNascita.GetHashCode();
                if (this.NatoEstero != null)
                    hashCode = hashCode * 59 + this.NatoEstero.GetHashCode();
                if (this.PaeseNascitaEstero != null)
                    hashCode = hashCode * 59 + this.PaeseNascitaEstero.GetHashCode();
                if (this.ComuneNascitaEstero != null)
                    hashCode = hashCode * 59 + this.ComuneNascitaEstero.GetHashCode();
                if (this.DataNascita != null)
                    hashCode = hashCode * 59 + this.DataNascita.GetHashCode();
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
            // Nome (string) maxLength
            if(this.Nome != null && this.Nome.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nome, length must be less than 255.", new [] { "Nome" });
            }

            // Nome (string) minLength
            if(this.Nome != null && this.Nome.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nome, length must be greater than 0.", new [] { "Nome" });
            }

            // Cognome (string) maxLength
            if(this.Cognome != null && this.Cognome.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cognome, length must be less than 255.", new [] { "Cognome" });
            }

            // Cognome (string) minLength
            if(this.Cognome != null && this.Cognome.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cognome, length must be greater than 0.", new [] { "Cognome" });
            }

            // Cittadinanza (string) maxLength
            if(this.Cittadinanza != null && this.Cittadinanza.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cittadinanza, length must be less than 255.", new [] { "Cittadinanza" });
            }

            // Cittadinanza (string) minLength
            if(this.Cittadinanza != null && this.Cittadinanza.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cittadinanza, length must be greater than 0.", new [] { "Cittadinanza" });
            }

            yield break;
        }
    }

}
