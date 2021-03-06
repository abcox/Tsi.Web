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
    /// TsiWebCreateAccountModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateAccountModel :  IEquatable<TsiWebCreateAccountModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateAccountModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebCreateAccountModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateAccountModel" /> class.
        /// </summary>
        /// <param name="account">account (required).</param>
        /// <param name="primaryPhoneNumber">primaryPhoneNumber.</param>
        /// <param name="accountSource">accountSource.</param>
        public TsiWebCreateAccountModel(TsiWebAccount account = default(TsiWebAccount), TsiWebPhoneNumber primaryPhoneNumber = default(TsiWebPhoneNumber), string accountSource = default(string))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for TsiWebCreateAccountModel and cannot be null");
            }
            else
            {
                this.Account = account;
            }
            this.PrimaryPhoneNumber = primaryPhoneNumber;
            this.AccountSource = accountSource;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public TsiWebAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryPhoneNumber
        /// </summary>
        [DataMember(Name="PrimaryPhoneNumber", EmitDefaultValue=false)]
        public TsiWebPhoneNumber PrimaryPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountSource
        /// </summary>
        [DataMember(Name="AccountSource", EmitDefaultValue=false)]
        public string AccountSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateAccountModel {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  PrimaryPhoneNumber: ").Append(PrimaryPhoneNumber).Append("\n");
            sb.Append("  AccountSource: ").Append(AccountSource).Append("\n");
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
            return this.Equals(input as TsiWebCreateAccountModel);
        }

        /// <summary>
        /// Returns true if TsiWebCreateAccountModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateAccountModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateAccountModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.PrimaryPhoneNumber == input.PrimaryPhoneNumber ||
                    (this.PrimaryPhoneNumber != null &&
                    this.PrimaryPhoneNumber.Equals(input.PrimaryPhoneNumber))
                ) && 
                (
                    this.AccountSource == input.AccountSource ||
                    (this.AccountSource != null &&
                    this.AccountSource.Equals(input.AccountSource))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.PrimaryPhoneNumber != null)
                    hashCode = hashCode * 59 + this.PrimaryPhoneNumber.GetHashCode();
                if (this.AccountSource != null)
                    hashCode = hashCode * 59 + this.AccountSource.GetHashCode();
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
