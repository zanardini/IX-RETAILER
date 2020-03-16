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
    /// UpdateAooRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAooRequest :  IEquatable<UpdateAooRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAooRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAooRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAooRequest" /> class.
        /// </summary>
        /// <param name="aoo">aoo (required).</param>
        public UpdateAooRequest(AooRequest aoo = default(AooRequest))
        {
            // to ensure "aoo" is required (not null)
            if (aoo == null)
            {
                throw new InvalidDataException("aoo is a required property for UpdateAooRequest and cannot be null");
            }
            else
            {
                this.Aoo = aoo;
            }
        }
        
        /// <summary>
        /// Gets or Sets Aoo
        /// </summary>
        [DataMember(Name="aoo", EmitDefaultValue=false)]
        public AooRequest Aoo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAooRequest {\n");
            sb.Append("  Aoo: ").Append(Aoo).Append("\n");
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
            return this.Equals(input as UpdateAooRequest);
        }

        /// <summary>
        /// Returns true if UpdateAooRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAooRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAooRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aoo == input.Aoo ||
                    (this.Aoo != null &&
                    this.Aoo.Equals(input.Aoo))
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
                if (this.Aoo != null)
                    hashCode = hashCode * 59 + this.Aoo.GetHashCode();
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
