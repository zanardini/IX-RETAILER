/* 
 * REGISTRY API V1
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
    /// AooInfo
    /// </summary>
    [DataContract]
    public partial class AooInfo :  IEquatable<AooInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AooInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AooInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AooInfo" /> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="identifiers">identifiers.</param>
        /// <param name="modules">modules.</param>
        /// <param name="ixModuleExtensions">ixModuleExtensions.</param>
        public AooInfo(Guid? identifier = default(Guid?), string name = default(string), string description = default(string), AooInfoIdentifiers identifiers = default(AooInfoIdentifiers), List<string> modules = default(List<string>), List<string> ixModuleExtensions = default(List<string>))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for AooInfo and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AooInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
            this.Identifiers = identifiers;
            this.Modules = modules;
            this.IxModuleExtensions = ixModuleExtensions;
        }
        
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public Guid? Identifier { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Identifiers
        /// </summary>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public AooInfoIdentifiers Identifiers { get; set; }

        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name="modules", EmitDefaultValue=false)]
        public List<string> Modules { get; set; }

        /// <summary>
        /// Gets or Sets IxModuleExtensions
        /// </summary>
        [DataMember(Name="ixModuleExtensions", EmitDefaultValue=false)]
        public List<string> IxModuleExtensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AooInfo {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  IxModuleExtensions: ").Append(IxModuleExtensions).Append("\n");
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
            return this.Equals(input as AooInfo);
        }

        /// <summary>
        /// Returns true if AooInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AooInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AooInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    (this.Identifiers != null &&
                    this.Identifiers.Equals(input.Identifiers))
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
                ) && 
                (
                    this.IxModuleExtensions == input.IxModuleExtensions ||
                    this.IxModuleExtensions != null &&
                    this.IxModuleExtensions.SequenceEqual(input.IxModuleExtensions)
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Modules != null)
                    hashCode = hashCode * 59 + this.Modules.GetHashCode();
                if (this.IxModuleExtensions != null)
                    hashCode = hashCode * 59 + this.IxModuleExtensions.GetHashCode();
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
