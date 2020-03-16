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
    /// PeriodoImpostaInfo
    /// </summary>
    [DataContract]
    public partial class PeriodoImpostaInfo :  IEquatable<PeriodoImpostaInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodoImpostaInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeriodoImpostaInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodoImpostaInfo" /> class.
        /// </summary>
        /// <param name="dataInizio">dataInizio (required).</param>
        /// <param name="dataFine">dataFine (required).</param>
        /// <param name="dataDichiarazioneRedditi">dataDichiarazioneRedditi (required).</param>
        public PeriodoImpostaInfo(DateTime? dataInizio = default(DateTime?), DateTime? dataFine = default(DateTime?), DateTime? dataDichiarazioneRedditi = default(DateTime?))
        {
            // to ensure "dataInizio" is required (not null)
            if (dataInizio == null)
            {
                throw new InvalidDataException("dataInizio is a required property for PeriodoImpostaInfo and cannot be null");
            }
            else
            {
                this.DataInizio = dataInizio;
            }
            // to ensure "dataFine" is required (not null)
            if (dataFine == null)
            {
                throw new InvalidDataException("dataFine is a required property for PeriodoImpostaInfo and cannot be null");
            }
            else
            {
                this.DataFine = dataFine;
            }
            // to ensure "dataDichiarazioneRedditi" is required (not null)
            if (dataDichiarazioneRedditi == null)
            {
                throw new InvalidDataException("dataDichiarazioneRedditi is a required property for PeriodoImpostaInfo and cannot be null");
            }
            else
            {
                this.DataDichiarazioneRedditi = dataDichiarazioneRedditi;
            }
        }
        
        /// <summary>
        /// Gets or Sets DataInizio
        /// </summary>
        [DataMember(Name="dataInizio", EmitDefaultValue=false)]
        public DateTime? DataInizio { get; set; }

        /// <summary>
        /// Gets or Sets DataFine
        /// </summary>
        [DataMember(Name="dataFine", EmitDefaultValue=false)]
        public DateTime? DataFine { get; set; }

        /// <summary>
        /// Gets or Sets DataDichiarazioneRedditi
        /// </summary>
        [DataMember(Name="dataDichiarazioneRedditi", EmitDefaultValue=false)]
        public DateTime? DataDichiarazioneRedditi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeriodoImpostaInfo {\n");
            sb.Append("  DataInizio: ").Append(DataInizio).Append("\n");
            sb.Append("  DataFine: ").Append(DataFine).Append("\n");
            sb.Append("  DataDichiarazioneRedditi: ").Append(DataDichiarazioneRedditi).Append("\n");
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
            return this.Equals(input as PeriodoImpostaInfo);
        }

        /// <summary>
        /// Returns true if PeriodoImpostaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PeriodoImpostaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeriodoImpostaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataInizio == input.DataInizio ||
                    (this.DataInizio != null &&
                    this.DataInizio.Equals(input.DataInizio))
                ) && 
                (
                    this.DataFine == input.DataFine ||
                    (this.DataFine != null &&
                    this.DataFine.Equals(input.DataFine))
                ) && 
                (
                    this.DataDichiarazioneRedditi == input.DataDichiarazioneRedditi ||
                    (this.DataDichiarazioneRedditi != null &&
                    this.DataDichiarazioneRedditi.Equals(input.DataDichiarazioneRedditi))
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
                if (this.DataInizio != null)
                    hashCode = hashCode * 59 + this.DataInizio.GetHashCode();
                if (this.DataFine != null)
                    hashCode = hashCode * 59 + this.DataFine.GetHashCode();
                if (this.DataDichiarazioneRedditi != null)
                    hashCode = hashCode * 59 + this.DataDichiarazioneRedditi.GetHashCode();
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
