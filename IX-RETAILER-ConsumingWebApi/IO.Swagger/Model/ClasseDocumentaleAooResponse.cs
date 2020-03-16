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
    /// ClasseDocumentaleAooResponse
    /// </summary>
    [DataContract]
    public partial class ClasseDocumentaleAooResponse :  IEquatable<ClasseDocumentaleAooResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseDocumentaleAooResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClasseDocumentaleAooResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseDocumentaleAooResponse" /> class.
        /// </summary>
        /// <param name="idNormativa">idNormativa (required).</param>
        /// <param name="descrizione">descrizione (required).</param>
        /// <param name="sezionali">sezionali.</param>
        /// <param name="esercizi">esercizi.</param>
        /// <param name="toolsFirma">toolsFirma.</param>
        public ClasseDocumentaleAooResponse(string idNormativa = default(string), string descrizione = default(string), List<string> sezionali = default(List<string>), List<string> esercizi = default(List<string>), List<ToolFirmaResponse> toolsFirma = default(List<ToolFirmaResponse>))
        {
            // to ensure "idNormativa" is required (not null)
            if (idNormativa == null)
            {
                throw new InvalidDataException("idNormativa is a required property for ClasseDocumentaleAooResponse and cannot be null");
            }
            else
            {
                this.IdNormativa = idNormativa;
            }
            // to ensure "descrizione" is required (not null)
            if (descrizione == null)
            {
                throw new InvalidDataException("descrizione is a required property for ClasseDocumentaleAooResponse and cannot be null");
            }
            else
            {
                this.Descrizione = descrizione;
            }
            this.Sezionali = sezionali;
            this.Esercizi = esercizi;
            this.ToolsFirma = toolsFirma;
        }
        
        /// <summary>
        /// Gets or Sets IdNormativa
        /// </summary>
        [DataMember(Name="idNormativa", EmitDefaultValue=false)]
        public string IdNormativa { get; set; }

        /// <summary>
        /// Gets or Sets Descrizione
        /// </summary>
        [DataMember(Name="descrizione", EmitDefaultValue=false)]
        public string Descrizione { get; set; }

        /// <summary>
        /// Gets or Sets Sezionali
        /// </summary>
        [DataMember(Name="sezionali", EmitDefaultValue=false)]
        public List<string> Sezionali { get; set; }

        /// <summary>
        /// Gets or Sets Esercizi
        /// </summary>
        [DataMember(Name="esercizi", EmitDefaultValue=false)]
        public List<string> Esercizi { get; set; }

        /// <summary>
        /// Gets or Sets ToolsFirma
        /// </summary>
        [DataMember(Name="toolsFirma", EmitDefaultValue=false)]
        public List<ToolFirmaResponse> ToolsFirma { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClasseDocumentaleAooResponse {\n");
            sb.Append("  IdNormativa: ").Append(IdNormativa).Append("\n");
            sb.Append("  Descrizione: ").Append(Descrizione).Append("\n");
            sb.Append("  Sezionali: ").Append(Sezionali).Append("\n");
            sb.Append("  Esercizi: ").Append(Esercizi).Append("\n");
            sb.Append("  ToolsFirma: ").Append(ToolsFirma).Append("\n");
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
            return this.Equals(input as ClasseDocumentaleAooResponse);
        }

        /// <summary>
        /// Returns true if ClasseDocumentaleAooResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClasseDocumentaleAooResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClasseDocumentaleAooResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdNormativa == input.IdNormativa ||
                    (this.IdNormativa != null &&
                    this.IdNormativa.Equals(input.IdNormativa))
                ) && 
                (
                    this.Descrizione == input.Descrizione ||
                    (this.Descrizione != null &&
                    this.Descrizione.Equals(input.Descrizione))
                ) && 
                (
                    this.Sezionali == input.Sezionali ||
                    this.Sezionali != null &&
                    this.Sezionali.SequenceEqual(input.Sezionali)
                ) && 
                (
                    this.Esercizi == input.Esercizi ||
                    this.Esercizi != null &&
                    this.Esercizi.SequenceEqual(input.Esercizi)
                ) && 
                (
                    this.ToolsFirma == input.ToolsFirma ||
                    this.ToolsFirma != null &&
                    this.ToolsFirma.SequenceEqual(input.ToolsFirma)
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
                if (this.IdNormativa != null)
                    hashCode = hashCode * 59 + this.IdNormativa.GetHashCode();
                if (this.Descrizione != null)
                    hashCode = hashCode * 59 + this.Descrizione.GetHashCode();
                if (this.Sezionali != null)
                    hashCode = hashCode * 59 + this.Sezionali.GetHashCode();
                if (this.Esercizi != null)
                    hashCode = hashCode * 59 + this.Esercizi.GetHashCode();
                if (this.ToolsFirma != null)
                    hashCode = hashCode * 59 + this.ToolsFirma.GetHashCode();
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
