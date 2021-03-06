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
    /// AooModuloIxRequest
    /// </summary>
    [DataContract]
    public partial class AooModuloIxRequest :  IEquatable<AooModuloIxRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines TipoFirma
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoFirmaEnum
        {
            
            /// <summary>
            /// Enum NESSUNA for value: NESSUNA
            /// </summary>
            [EnumMember(Value = "NESSUNA")]
            NESSUNA = 1,
            
            /// <summary>
            /// Enum AUTOMATICAINTERMEDIARIO for value: AUTOMATICA_INTERMEDIARIO
            /// </summary>
            [EnumMember(Value = "AUTOMATICA_INTERMEDIARIO")]
            AUTOMATICAINTERMEDIARIO = 2,
            
            /// <summary>
            /// Enum AUTOMATICAMITTENTE for value: AUTOMATICA_MITTENTE
            /// </summary>
            [EnumMember(Value = "AUTOMATICA_MITTENTE")]
            AUTOMATICAMITTENTE = 3,
            
            /// <summary>
            /// Enum MANUALEMITTENTE for value: MANUALE_MITTENTE
            /// </summary>
            [EnumMember(Value = "MANUALE_MITTENTE")]
            MANUALEMITTENTE = 4
        }

        /// <summary>
        /// Gets or Sets TipoFirma
        /// </summary>
        [DataMember(Name="tipoFirma", EmitDefaultValue=false)]
        public TipoFirmaEnum TipoFirma { get; set; }
        /// <summary>
        /// Defines TipoFattura
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoFatturaEnum
        {
            
            /// <summary>
            /// Enum XMLNONFIRMATO for value: XML_NON_FIRMATO
            /// </summary>
            [EnumMember(Value = "XML_NON_FIRMATO")]
            XMLNONFIRMATO = 1,
            
            /// <summary>
            /// Enum XMLFIRMATO for value: XML_FIRMATO
            /// </summary>
            [EnumMember(Value = "XML_FIRMATO")]
            XMLFIRMATO = 2,
            
            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 3
        }

        /// <summary>
        /// Gets or Sets TipoFattura
        /// </summary>
        [DataMember(Name="tipoFattura", EmitDefaultValue=false)]
        public TipoFatturaEnum TipoFattura { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AooModuloIxRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AooModuloIxRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AooModuloIxRequest" /> class.
        /// </summary>
        /// <param name="fascia">fascia.</param>
        /// <param name="fasciaAnniSuccessiva">fasciaAnniSuccessiva.</param>
        /// <param name="tipoFirma">tipoFirma (required).</param>
        /// <param name="tipoFattura">tipoFattura (required).</param>
        public AooModuloIxRequest(int? fascia = default(int?), int? fasciaAnniSuccessiva = default(int?), TipoFirmaEnum tipoFirma = default(TipoFirmaEnum), TipoFatturaEnum tipoFattura = default(TipoFatturaEnum))
        {
            // to ensure "tipoFirma" is required (not null)
            if (tipoFirma == null)
            {
                throw new InvalidDataException("tipoFirma is a required property for AooModuloIxRequest and cannot be null");
            }
            else
            {
                this.TipoFirma = tipoFirma;
            }
            // to ensure "tipoFattura" is required (not null)
            if (tipoFattura == null)
            {
                throw new InvalidDataException("tipoFattura is a required property for AooModuloIxRequest and cannot be null");
            }
            else
            {
                this.TipoFattura = tipoFattura;
            }
            this.Fascia = fascia;
            this.FasciaAnniSuccessiva = fasciaAnniSuccessiva;
        }
        
        /// <summary>
        /// Gets or Sets Fascia
        /// </summary>
        [DataMember(Name="fascia", EmitDefaultValue=false)]
        public int? Fascia { get; set; }

        /// <summary>
        /// Gets or Sets FasciaAnniSuccessiva
        /// </summary>
        [DataMember(Name="fasciaAnniSuccessiva", EmitDefaultValue=false)]
        public int? FasciaAnniSuccessiva { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AooModuloIxRequest {\n");
            sb.Append("  Fascia: ").Append(Fascia).Append("\n");
            sb.Append("  FasciaAnniSuccessiva: ").Append(FasciaAnniSuccessiva).Append("\n");
            sb.Append("  TipoFirma: ").Append(TipoFirma).Append("\n");
            sb.Append("  TipoFattura: ").Append(TipoFattura).Append("\n");
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
            return this.Equals(input as AooModuloIxRequest);
        }

        /// <summary>
        /// Returns true if AooModuloIxRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AooModuloIxRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AooModuloIxRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fascia == input.Fascia ||
                    (this.Fascia != null &&
                    this.Fascia.Equals(input.Fascia))
                ) && 
                (
                    this.FasciaAnniSuccessiva == input.FasciaAnniSuccessiva ||
                    (this.FasciaAnniSuccessiva != null &&
                    this.FasciaAnniSuccessiva.Equals(input.FasciaAnniSuccessiva))
                ) && 
                (
                    this.TipoFirma == input.TipoFirma ||
                    (this.TipoFirma != null &&
                    this.TipoFirma.Equals(input.TipoFirma))
                ) && 
                (
                    this.TipoFattura == input.TipoFattura ||
                    (this.TipoFattura != null &&
                    this.TipoFattura.Equals(input.TipoFattura))
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
                if (this.Fascia != null)
                    hashCode = hashCode * 59 + this.Fascia.GetHashCode();
                if (this.FasciaAnniSuccessiva != null)
                    hashCode = hashCode * 59 + this.FasciaAnniSuccessiva.GetHashCode();
                if (this.TipoFirma != null)
                    hashCode = hashCode * 59 + this.TipoFirma.GetHashCode();
                if (this.TipoFattura != null)
                    hashCode = hashCode * 59 + this.TipoFattura.GetHashCode();
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
