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
    /// ContrattoUtenteRequestV2
    /// </summary>
    [DataContract]
    public partial class ContrattoUtenteRequestV2 :  IEquatable<ContrattoUtenteRequestV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContrattoUtenteRequestV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContrattoUtenteRequestV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContrattoUtenteRequestV2" /> class.
        /// </summary>
        /// <param name="username">username (required).</param>
        /// <param name="password">password (required).</param>
        /// <param name="datiGenerali">datiGenerali (required).</param>
        /// <param name="datiResidenza">datiResidenza (required).</param>
        /// <param name="datiFiscali">datiFiscali (required).</param>
        public ContrattoUtenteRequestV2(string username = default(string), string password = default(string), DatiGeneraliUtente datiGenerali = default(DatiGeneraliUtente), DatiResidenzaUtente datiResidenza = default(DatiResidenzaUtente), DatiFiscaliUtente datiFiscali = default(DatiFiscaliUtente))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for ContrattoUtenteRequestV2 and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for ContrattoUtenteRequestV2 and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "datiGenerali" is required (not null)
            if (datiGenerali == null)
            {
                throw new InvalidDataException("datiGenerali is a required property for ContrattoUtenteRequestV2 and cannot be null");
            }
            else
            {
                this.DatiGenerali = datiGenerali;
            }
            // to ensure "datiResidenza" is required (not null)
            if (datiResidenza == null)
            {
                throw new InvalidDataException("datiResidenza is a required property for ContrattoUtenteRequestV2 and cannot be null");
            }
            else
            {
                this.DatiResidenza = datiResidenza;
            }
            // to ensure "datiFiscali" is required (not null)
            if (datiFiscali == null)
            {
                throw new InvalidDataException("datiFiscali is a required property for ContrattoUtenteRequestV2 and cannot be null");
            }
            else
            {
                this.DatiFiscali = datiFiscali;
            }
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets DatiGenerali
        /// </summary>
        [DataMember(Name="datiGenerali", EmitDefaultValue=false)]
        public DatiGeneraliUtente DatiGenerali { get; set; }

        /// <summary>
        /// Gets or Sets DatiResidenza
        /// </summary>
        [DataMember(Name="datiResidenza", EmitDefaultValue=false)]
        public DatiResidenzaUtente DatiResidenza { get; set; }

        /// <summary>
        /// Gets or Sets DatiFiscali
        /// </summary>
        [DataMember(Name="datiFiscali", EmitDefaultValue=false)]
        public DatiFiscaliUtente DatiFiscali { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContrattoUtenteRequestV2 {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DatiGenerali: ").Append(DatiGenerali).Append("\n");
            sb.Append("  DatiResidenza: ").Append(DatiResidenza).Append("\n");
            sb.Append("  DatiFiscali: ").Append(DatiFiscali).Append("\n");
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
            return this.Equals(input as ContrattoUtenteRequestV2);
        }

        /// <summary>
        /// Returns true if ContrattoUtenteRequestV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ContrattoUtenteRequestV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContrattoUtenteRequestV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.DatiGenerali == input.DatiGenerali ||
                    (this.DatiGenerali != null &&
                    this.DatiGenerali.Equals(input.DatiGenerali))
                ) && 
                (
                    this.DatiResidenza == input.DatiResidenza ||
                    (this.DatiResidenza != null &&
                    this.DatiResidenza.Equals(input.DatiResidenza))
                ) && 
                (
                    this.DatiFiscali == input.DatiFiscali ||
                    (this.DatiFiscali != null &&
                    this.DatiFiscali.Equals(input.DatiFiscali))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.DatiGenerali != null)
                    hashCode = hashCode * 59 + this.DatiGenerali.GetHashCode();
                if (this.DatiResidenza != null)
                    hashCode = hashCode * 59 + this.DatiResidenza.GetHashCode();
                if (this.DatiFiscali != null)
                    hashCode = hashCode * 59 + this.DatiFiscali.GetHashCode();
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
            // Username (string) maxLength
            if(this.Username != null && this.Username.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 255.", new [] { "Username" });
            }

            // Username (string) minLength
            if(this.Username != null && this.Username.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be greater than 0.", new [] { "Username" });
            }

            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 255.", new [] { "Password" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 0.", new [] { "Password" });
            }

            yield break;
        }
    }

}
