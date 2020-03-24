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
    /// DistributoreResponse
    /// </summary>
    [DataContract]
    public partial class DistributoreResponse :  IEquatable<DistributoreResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributoreResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistributoreResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributoreResponse" /> class.
        /// </summary>
        /// <param name="identificativo">identificativo (required).</param>
        /// <param name="nome">nome (required).</param>
        public DistributoreResponse(string identificativo = default(string), string nome = default(string))
        {
            // to ensure "identificativo" is required (not null)
            if (identificativo == null)
            {
                throw new InvalidDataException("identificativo is a required property for DistributoreResponse and cannot be null");
            }
            else
            {
                this.Identificativo = identificativo;
            }
            // to ensure "nome" is required (not null)
            if (nome == null)
            {
                throw new InvalidDataException("nome is a required property for DistributoreResponse and cannot be null");
            }
            else
            {
                this.Nome = nome;
            }
        }
        
        /// <summary>
        /// Gets or Sets Identificativo
        /// </summary>
        [DataMember(Name="identificativo", EmitDefaultValue=false)]
        public string Identificativo { get; set; }

        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributoreResponse {\n");
            sb.Append("  Identificativo: ").Append(Identificativo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
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
            return this.Equals(input as DistributoreResponse);
        }

        /// <summary>
        /// Returns true if DistributoreResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributoreResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributoreResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identificativo == input.Identificativo ||
                    (this.Identificativo != null &&
                    this.Identificativo.Equals(input.Identificativo))
                ) && 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
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
                if (this.Identificativo != null)
                    hashCode = hashCode * 59 + this.Identificativo.GetHashCode();
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
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
