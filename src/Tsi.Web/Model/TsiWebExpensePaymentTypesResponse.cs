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
    /// TsiWebExpensePaymentTypesResponse
    /// </summary>
    [DataContract]
    public partial class TsiWebExpensePaymentTypesResponse :  IEquatable<TsiWebExpensePaymentTypesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebExpensePaymentTypesResponse" /> class.
        /// </summary>
        /// <param name="expensePaymentTypes">expensePaymentTypes.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        public TsiWebExpensePaymentTypesResponse(List<TsiWebExpensePaymentType> expensePaymentTypes = default(List<TsiWebExpensePaymentType>), bool? success = default(bool?), string message = default(string))
        {
            this.ExpensePaymentTypes = expensePaymentTypes;
            this.Success = success;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets ExpensePaymentTypes
        /// </summary>
        [DataMember(Name="ExpensePaymentTypes", EmitDefaultValue=false)]
        public List<TsiWebExpensePaymentType> ExpensePaymentTypes { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebExpensePaymentTypesResponse {\n");
            sb.Append("  ExpensePaymentTypes: ").Append(ExpensePaymentTypes).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as TsiWebExpensePaymentTypesResponse);
        }

        /// <summary>
        /// Returns true if TsiWebExpensePaymentTypesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebExpensePaymentTypesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebExpensePaymentTypesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpensePaymentTypes == input.ExpensePaymentTypes ||
                    this.ExpensePaymentTypes != null &&
                    this.ExpensePaymentTypes.SequenceEqual(input.ExpensePaymentTypes)
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.ExpensePaymentTypes != null)
                    hashCode = hashCode * 59 + this.ExpensePaymentTypes.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
