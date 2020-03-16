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
    /// CreateContrattoResponse
    /// </summary>
    [DataContract]
    public partial class CreateContrattoResponse :  IEquatable<CreateContrattoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContrattoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateContrattoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContrattoResponse" /> class.
        /// </summary>
        /// <param name="identificativo">identificativo (required).</param>
        public CreateContrattoResponse(string identificativo = default(string))
        {
            // to ensure "identificativo" is required (not null)
            if (identificativo == null)
            {
                throw new InvalidDataException("identificativo is a required property for CreateContrattoResponse and cannot be null");
            }
            else
            {
                this.Identificativo = identificativo;
            }
        }
        
        /// <summary>
        /// Gets or Sets Identificativo
        /// </summary>
        [DataMember(Name="identificativo", EmitDefaultValue=false)]
        public string Identificativo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContrattoResponse {\n");
            sb.Append("  Identificativo: ").Append(Identificativo).Append("\n");
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
            return this.Equals(input as CreateContrattoResponse);
        }

        /// <summary>
        /// Returns true if CreateContrattoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContrattoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContrattoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identificativo == input.Identificativo ||
                    (this.Identificativo != null &&
                    this.Identificativo.Equals(input.Identificativo))
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
