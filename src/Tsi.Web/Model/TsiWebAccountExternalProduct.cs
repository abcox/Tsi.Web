/* 
 * Tigerpaw API Method Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 18.2.1
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
using SwaggerDateConverter = Tsi.Web.Client.SwaggerDateConverter;

namespace Tsi.Web.Model
{
    /// <summary>
    /// TsiWebAccountExternalProduct
    /// </summary>
    [DataContract]
    public partial class TsiWebAccountExternalProduct :  IEquatable<TsiWebAccountExternalProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAccountExternalProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebAccountExternalProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAccountExternalProduct" /> class.
        /// </summary>
        /// <param name="accountExternalProductId">accountExternalProductId.</param>
        /// <param name="externalProductId">externalProductId.</param>
        /// <param name="externalProduct">externalProduct.</param>
        /// <param name="externalId">externalId (required).</param>
        /// <param name="externalSystemId">externalSystemId.</param>
        /// <param name="comment">comment.</param>
        public TsiWebAccountExternalProduct(int? accountExternalProductId = default(int?), int? externalProductId = default(int?), string externalProduct = default(string), string externalId = default(string), string externalSystemId = default(string), string comment = default(string))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for TsiWebAccountExternalProduct and cannot be null");
            }
            else
            {
                this.ExternalId = externalId;
            }
            this.AccountExternalProductId = accountExternalProductId;
            this.ExternalProductId = externalProductId;
            this.ExternalProduct = externalProduct;
            this.ExternalSystemId = externalSystemId;
            this.Comment = comment;
        }
        
        /// <summary>
        /// Gets or Sets AccountExternalProductId
        /// </summary>
        [DataMember(Name="AccountExternalProductId", EmitDefaultValue=false)]
        public int? AccountExternalProductId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalProductId
        /// </summary>
        [DataMember(Name="ExternalProductId", EmitDefaultValue=false)]
        public int? ExternalProductId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalProduct
        /// </summary>
        [DataMember(Name="ExternalProduct", EmitDefaultValue=false)]
        public string ExternalProduct { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="ExternalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalSystemId
        /// </summary>
        [DataMember(Name="ExternalSystemId", EmitDefaultValue=false)]
        public string ExternalSystemId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAccountExternalProduct {\n");
            sb.Append("  AccountExternalProductId: ").Append(AccountExternalProductId).Append("\n");
            sb.Append("  ExternalProductId: ").Append(ExternalProductId).Append("\n");
            sb.Append("  ExternalProduct: ").Append(ExternalProduct).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalSystemId: ").Append(ExternalSystemId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as TsiWebAccountExternalProduct);
        }

        /// <summary>
        /// Returns true if TsiWebAccountExternalProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAccountExternalProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAccountExternalProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountExternalProductId == input.AccountExternalProductId ||
                    (this.AccountExternalProductId != null &&
                    this.AccountExternalProductId.Equals(input.AccountExternalProductId))
                ) && 
                (
                    this.ExternalProductId == input.ExternalProductId ||
                    (this.ExternalProductId != null &&
                    this.ExternalProductId.Equals(input.ExternalProductId))
                ) && 
                (
                    this.ExternalProduct == input.ExternalProduct ||
                    (this.ExternalProduct != null &&
                    this.ExternalProduct.Equals(input.ExternalProduct))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.ExternalSystemId == input.ExternalSystemId ||
                    (this.ExternalSystemId != null &&
                    this.ExternalSystemId.Equals(input.ExternalSystemId))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.AccountExternalProductId != null)
                    hashCode = hashCode * 59 + this.AccountExternalProductId.GetHashCode();
                if (this.ExternalProductId != null)
                    hashCode = hashCode * 59 + this.ExternalProductId.GetHashCode();
                if (this.ExternalProduct != null)
                    hashCode = hashCode * 59 + this.ExternalProduct.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.ExternalSystemId != null)
                    hashCode = hashCode * 59 + this.ExternalSystemId.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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