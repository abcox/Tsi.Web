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
    /// TsiWebUpdateExpensePaymentTypeRequest
    /// </summary>
    [DataContract]
    public partial class TsiWebUpdateExpensePaymentTypeRequest :  IEquatable<TsiWebUpdateExpensePaymentTypeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebUpdateExpensePaymentTypeRequest" /> class.
        /// </summary>
        /// <param name="existingExpensePaymentType">existingExpensePaymentType.</param>
        /// <param name="newExpensePaymentTypeDescription">newExpensePaymentTypeDescription.</param>
        public TsiWebUpdateExpensePaymentTypeRequest(string existingExpensePaymentType = default(string), string newExpensePaymentTypeDescription = default(string))
        {
            this.ExistingExpensePaymentType = existingExpensePaymentType;
            this.NewExpensePaymentTypeDescription = newExpensePaymentTypeDescription;
        }
        
        /// <summary>
        /// Gets or Sets ExistingExpensePaymentType
        /// </summary>
        [DataMember(Name="ExistingExpensePaymentType", EmitDefaultValue=false)]
        public string ExistingExpensePaymentType { get; set; }

        /// <summary>
        /// Gets or Sets NewExpensePaymentTypeDescription
        /// </summary>
        [DataMember(Name="NewExpensePaymentTypeDescription", EmitDefaultValue=false)]
        public string NewExpensePaymentTypeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebUpdateExpensePaymentTypeRequest {\n");
            sb.Append("  ExistingExpensePaymentType: ").Append(ExistingExpensePaymentType).Append("\n");
            sb.Append("  NewExpensePaymentTypeDescription: ").Append(NewExpensePaymentTypeDescription).Append("\n");
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
            return this.Equals(input as TsiWebUpdateExpensePaymentTypeRequest);
        }

        /// <summary>
        /// Returns true if TsiWebUpdateExpensePaymentTypeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebUpdateExpensePaymentTypeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebUpdateExpensePaymentTypeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExistingExpensePaymentType == input.ExistingExpensePaymentType ||
                    (this.ExistingExpensePaymentType != null &&
                    this.ExistingExpensePaymentType.Equals(input.ExistingExpensePaymentType))
                ) && 
                (
                    this.NewExpensePaymentTypeDescription == input.NewExpensePaymentTypeDescription ||
                    (this.NewExpensePaymentTypeDescription != null &&
                    this.NewExpensePaymentTypeDescription.Equals(input.NewExpensePaymentTypeDescription))
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
                if (this.ExistingExpensePaymentType != null)
                    hashCode = hashCode * 59 + this.ExistingExpensePaymentType.GetHashCode();
                if (this.NewExpensePaymentTypeDescription != null)
                    hashCode = hashCode * 59 + this.NewExpensePaymentTypeDescription.GetHashCode();
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
