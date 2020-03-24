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
    /// ContrattoModulo
    /// </summary>
    [DataContract]
    public partial class ContrattoModulo :  IEquatable<ContrattoModulo>, IValidatableObject
    {
        /// <summary>
        /// Defines Modulo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModuloEnum
        {
            
            /// <summary>
            /// Enum IX for value: IX
            /// </summary>
            [EnumMember(Value = "IX")]
            IX = 1,
            
            /// <summary>
            /// Enum IXCE for value: IXCE
            /// </summary>
            [EnumMember(Value = "IXCE")]
            IXCE = 2,
            
            /// <summary>
            /// Enum IXPEC for value: IXPEC
            /// </summary>
            [EnumMember(Value = "IXPEC")]
            IXPEC = 3
        }

        /// <summary>
        /// Gets or Sets Modulo
        /// </summary>
        [DataMember(Name="modulo", EmitDefaultValue=false)]
        public ModuloEnum Modulo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContrattoModulo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContrattoModulo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContrattoModulo" /> class.
        /// </summary>
        /// <param name="modulo">modulo (required).</param>
        /// <param name="descrizione">descrizione (required).</param>
        public ContrattoModulo(ModuloEnum modulo = default(ModuloEnum), string descrizione = default(string))
        {
            // to ensure "modulo" is required (not null)
            if (modulo == null)
            {
                throw new InvalidDataException("modulo is a required property for ContrattoModulo and cannot be null");
            }
            else
            {
                this.Modulo = modulo;
            }
            // to ensure "descrizione" is required (not null)
            if (descrizione == null)
            {
                throw new InvalidDataException("descrizione is a required property for ContrattoModulo and cannot be null");
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
            sb.Append("class ContrattoModulo {\n");
            sb.Append("  Modulo: ").Append(Modulo).Append("\n");
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
            return this.Equals(input as ContrattoModulo);
        }

        /// <summary>
        /// Returns true if ContrattoModulo instances are equal
        /// </summary>
        /// <param name="input">Instance of ContrattoModulo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContrattoModulo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Modulo == input.Modulo ||
                    (this.Modulo != null &&
                    this.Modulo.Equals(input.Modulo))
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
                if (this.Modulo != null)
                    hashCode = hashCode * 59 + this.Modulo.GetHashCode();
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
