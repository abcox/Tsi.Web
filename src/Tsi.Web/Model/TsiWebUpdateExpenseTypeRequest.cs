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
    /// TsiWebUpdateExpenseTypeRequest
    /// </summary>
    [DataContract]
    public partial class TsiWebUpdateExpenseTypeRequest :  IEquatable<TsiWebUpdateExpenseTypeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebUpdateExpenseTypeRequest" /> class.
        /// </summary>
        /// <param name="existingExpenseTypeDescription">existingExpenseTypeDescription.</param>
        /// <param name="newExpenseTypeDescription">newExpenseTypeDescription.</param>
        /// <param name="isMileageExpense">isMileageExpense.</param>
        public TsiWebUpdateExpenseTypeRequest(string existingExpenseTypeDescription = default(string), string newExpenseTypeDescription = default(string), bool? isMileageExpense = default(bool?))
        {
            this.ExistingExpenseTypeDescription = existingExpenseTypeDescription;
            this.NewExpenseTypeDescription = newExpenseTypeDescription;
            this.IsMileageExpense = isMileageExpense;
        }
        
        /// <summary>
        /// Gets or Sets ExistingExpenseTypeDescription
        /// </summary>
        [DataMember(Name="ExistingExpenseTypeDescription", EmitDefaultValue=false)]
        public string ExistingExpenseTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets NewExpenseTypeDescription
        /// </summary>
        [DataMember(Name="NewExpenseTypeDescription", EmitDefaultValue=false)]
        public string NewExpenseTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsMileageExpense
        /// </summary>
        [DataMember(Name="IsMileageExpense", EmitDefaultValue=false)]
        public bool? IsMileageExpense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebUpdateExpenseTypeRequest {\n");
            sb.Append("  ExistingExpenseTypeDescription: ").Append(ExistingExpenseTypeDescription).Append("\n");
            sb.Append("  NewExpenseTypeDescription: ").Append(NewExpenseTypeDescription).Append("\n");
            sb.Append("  IsMileageExpense: ").Append(IsMileageExpense).Append("\n");
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
            return this.Equals(input as TsiWebUpdateExpenseTypeRequest);
        }

        /// <summary>
        /// Returns true if TsiWebUpdateExpenseTypeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebUpdateExpenseTypeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebUpdateExpenseTypeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExistingExpenseTypeDescription == input.ExistingExpenseTypeDescription ||
                    (this.ExistingExpenseTypeDescription != null &&
                    this.ExistingExpenseTypeDescription.Equals(input.ExistingExpenseTypeDescription))
                ) && 
                (
                    this.NewExpenseTypeDescription == input.NewExpenseTypeDescription ||
                    (this.NewExpenseTypeDescription != null &&
                    this.NewExpenseTypeDescription.Equals(input.NewExpenseTypeDescription))
                ) && 
                (
                    this.IsMileageExpense == input.IsMileageExpense ||
                    (this.IsMileageExpense != null &&
                    this.IsMileageExpense.Equals(input.IsMileageExpense))
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
                if (this.ExistingExpenseTypeDescription != null)
                    hashCode = hashCode * 59 + this.ExistingExpenseTypeDescription.GetHashCode();
                if (this.NewExpenseTypeDescription != null)
                    hashCode = hashCode * 59 + this.NewExpenseTypeDescription.GetHashCode();
                if (this.IsMileageExpense != null)
                    hashCode = hashCode * 59 + this.IsMileageExpense.GetHashCode();
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