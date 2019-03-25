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
    /// TsiWebContractSummary
    /// </summary>
    [DataContract]
    public partial class TsiWebContractSummary :  IEquatable<TsiWebContractSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebContractSummary" /> class.
        /// </summary>
        /// <param name="contractNumber">Gets or sets the ContractNumber.</param>
        /// <param name="contract">Gets or sets the Contract.</param>
        /// <param name="createdByRepName">Gets or sets the created by rep name.</param>
        /// <param name="createdByRepEmailAddress">Gets or sets the created by rep email address.</param>
        /// <param name="createdByRepPhoneNumber">Gets or sets the created by rep phone number.</param>
        /// <param name="assignedTechRepName">Gets or sets the assigned tech rep name.</param>
        /// <param name="assignedTechRepEmailAddress">Gets or sets the assigned tech rep email adress.</param>
        /// <param name="assignedTechRepPhoneNumber">Gets or sets the assigned tech rep phone number.</param>
        /// <param name="repToCreditName">Gets or sets the rep to credit rep name.</param>
        /// <param name="repToCreditEmailAddress">Gets or sets the rep to credit rep email address.</param>
        /// <param name="repToCreditPhoneNumber">Gets or sets the rep to credit rep phone number.</param>
        /// <param name="contractAccount">Gets or sets the ContractAccount.</param>
        /// <param name="itemsCovered">Gets or sets the ItemsCovered.</param>
        public TsiWebContractSummary(int? contractNumber = default(int?), TsiWebContract contract = default(TsiWebContract), string createdByRepName = default(string), string createdByRepEmailAddress = default(string), string createdByRepPhoneNumber = default(string), string assignedTechRepName = default(string), string assignedTechRepEmailAddress = default(string), string assignedTechRepPhoneNumber = default(string), string repToCreditName = default(string), string repToCreditEmailAddress = default(string), string repToCreditPhoneNumber = default(string), List<TsiWebContractAccount> contractAccount = default(List<TsiWebContractAccount>), int? itemsCovered = default(int?))
        {
            this.ContractNumber = contractNumber;
            this.Contract = contract;
            this.CreatedByRepName = createdByRepName;
            this.CreatedByRepEmailAddress = createdByRepEmailAddress;
            this.CreatedByRepPhoneNumber = createdByRepPhoneNumber;
            this.AssignedTechRepName = assignedTechRepName;
            this.AssignedTechRepEmailAddress = assignedTechRepEmailAddress;
            this.AssignedTechRepPhoneNumber = assignedTechRepPhoneNumber;
            this.RepToCreditName = repToCreditName;
            this.RepToCreditEmailAddress = repToCreditEmailAddress;
            this.RepToCreditPhoneNumber = repToCreditPhoneNumber;
            this.ContractAccount = contractAccount;
            this.ItemsCovered = itemsCovered;
        }
        
        /// <summary>
        /// Gets or sets the ContractNumber
        /// </summary>
        /// <value>Gets or sets the ContractNumber</value>
        [DataMember(Name="ContractNumber", EmitDefaultValue=false)]
        public int? ContractNumber { get; set; }

        /// <summary>
        /// Gets or sets the Contract
        /// </summary>
        /// <value>Gets or sets the Contract</value>
        [DataMember(Name="Contract", EmitDefaultValue=false)]
        public TsiWebContract Contract { get; set; }

        /// <summary>
        /// Gets or sets the created by rep name
        /// </summary>
        /// <value>Gets or sets the created by rep name</value>
        [DataMember(Name="CreatedByRepName", EmitDefaultValue=false)]
        public string CreatedByRepName { get; set; }

        /// <summary>
        /// Gets or sets the created by rep email address
        /// </summary>
        /// <value>Gets or sets the created by rep email address</value>
        [DataMember(Name="CreatedByRepEmailAddress", EmitDefaultValue=false)]
        public string CreatedByRepEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the created by rep phone number
        /// </summary>
        /// <value>Gets or sets the created by rep phone number</value>
        [DataMember(Name="CreatedByRepPhoneNumber", EmitDefaultValue=false)]
        public string CreatedByRepPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the assigned tech rep name
        /// </summary>
        /// <value>Gets or sets the assigned tech rep name</value>
        [DataMember(Name="AssignedTechRepName", EmitDefaultValue=false)]
        public string AssignedTechRepName { get; set; }

        /// <summary>
        /// Gets or sets the assigned tech rep email adress
        /// </summary>
        /// <value>Gets or sets the assigned tech rep email adress</value>
        [DataMember(Name="AssignedTechRepEmailAddress", EmitDefaultValue=false)]
        public string AssignedTechRepEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the assigned tech rep phone number
        /// </summary>
        /// <value>Gets or sets the assigned tech rep phone number</value>
        [DataMember(Name="AssignedTechRepPhoneNumber", EmitDefaultValue=false)]
        public string AssignedTechRepPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the rep to credit rep name
        /// </summary>
        /// <value>Gets or sets the rep to credit rep name</value>
        [DataMember(Name="RepToCreditName", EmitDefaultValue=false)]
        public string RepToCreditName { get; set; }

        /// <summary>
        /// Gets or sets the rep to credit rep email address
        /// </summary>
        /// <value>Gets or sets the rep to credit rep email address</value>
        [DataMember(Name="RepToCreditEmailAddress", EmitDefaultValue=false)]
        public string RepToCreditEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the rep to credit rep phone number
        /// </summary>
        /// <value>Gets or sets the rep to credit rep phone number</value>
        [DataMember(Name="RepToCreditPhoneNumber", EmitDefaultValue=false)]
        public string RepToCreditPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the ContractAccount
        /// </summary>
        /// <value>Gets or sets the ContractAccount</value>
        [DataMember(Name="ContractAccount", EmitDefaultValue=false)]
        public List<TsiWebContractAccount> ContractAccount { get; set; }

        /// <summary>
        /// Gets or sets the ItemsCovered
        /// </summary>
        /// <value>Gets or sets the ItemsCovered</value>
        [DataMember(Name="ItemsCovered", EmitDefaultValue=false)]
        public int? ItemsCovered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebContractSummary {\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  CreatedByRepName: ").Append(CreatedByRepName).Append("\n");
            sb.Append("  CreatedByRepEmailAddress: ").Append(CreatedByRepEmailAddress).Append("\n");
            sb.Append("  CreatedByRepPhoneNumber: ").Append(CreatedByRepPhoneNumber).Append("\n");
            sb.Append("  AssignedTechRepName: ").Append(AssignedTechRepName).Append("\n");
            sb.Append("  AssignedTechRepEmailAddress: ").Append(AssignedTechRepEmailAddress).Append("\n");
            sb.Append("  AssignedTechRepPhoneNumber: ").Append(AssignedTechRepPhoneNumber).Append("\n");
            sb.Append("  RepToCreditName: ").Append(RepToCreditName).Append("\n");
            sb.Append("  RepToCreditEmailAddress: ").Append(RepToCreditEmailAddress).Append("\n");
            sb.Append("  RepToCreditPhoneNumber: ").Append(RepToCreditPhoneNumber).Append("\n");
            sb.Append("  ContractAccount: ").Append(ContractAccount).Append("\n");
            sb.Append("  ItemsCovered: ").Append(ItemsCovered).Append("\n");
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
            return this.Equals(input as TsiWebContractSummary);
        }

        /// <summary>
        /// Returns true if TsiWebContractSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebContractSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebContractSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.CreatedByRepName == input.CreatedByRepName ||
                    (this.CreatedByRepName != null &&
                    this.CreatedByRepName.Equals(input.CreatedByRepName))
                ) && 
                (
                    this.CreatedByRepEmailAddress == input.CreatedByRepEmailAddress ||
                    (this.CreatedByRepEmailAddress != null &&
                    this.CreatedByRepEmailAddress.Equals(input.CreatedByRepEmailAddress))
                ) && 
                (
                    this.CreatedByRepPhoneNumber == input.CreatedByRepPhoneNumber ||
                    (this.CreatedByRepPhoneNumber != null &&
                    this.CreatedByRepPhoneNumber.Equals(input.CreatedByRepPhoneNumber))
                ) && 
                (
                    this.AssignedTechRepName == input.AssignedTechRepName ||
                    (this.AssignedTechRepName != null &&
                    this.AssignedTechRepName.Equals(input.AssignedTechRepName))
                ) && 
                (
                    this.AssignedTechRepEmailAddress == input.AssignedTechRepEmailAddress ||
                    (this.AssignedTechRepEmailAddress != null &&
                    this.AssignedTechRepEmailAddress.Equals(input.AssignedTechRepEmailAddress))
                ) && 
                (
                    this.AssignedTechRepPhoneNumber == input.AssignedTechRepPhoneNumber ||
                    (this.AssignedTechRepPhoneNumber != null &&
                    this.AssignedTechRepPhoneNumber.Equals(input.AssignedTechRepPhoneNumber))
                ) && 
                (
                    this.RepToCreditName == input.RepToCreditName ||
                    (this.RepToCreditName != null &&
                    this.RepToCreditName.Equals(input.RepToCreditName))
                ) && 
                (
                    this.RepToCreditEmailAddress == input.RepToCreditEmailAddress ||
                    (this.RepToCreditEmailAddress != null &&
                    this.RepToCreditEmailAddress.Equals(input.RepToCreditEmailAddress))
                ) && 
                (
                    this.RepToCreditPhoneNumber == input.RepToCreditPhoneNumber ||
                    (this.RepToCreditPhoneNumber != null &&
                    this.RepToCreditPhoneNumber.Equals(input.RepToCreditPhoneNumber))
                ) && 
                (
                    this.ContractAccount == input.ContractAccount ||
                    this.ContractAccount != null &&
                    this.ContractAccount.SequenceEqual(input.ContractAccount)
                ) && 
                (
                    this.ItemsCovered == input.ItemsCovered ||
                    (this.ItemsCovered != null &&
                    this.ItemsCovered.Equals(input.ItemsCovered))
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
                if (this.ContractNumber != null)
                    hashCode = hashCode * 59 + this.ContractNumber.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.CreatedByRepName != null)
                    hashCode = hashCode * 59 + this.CreatedByRepName.GetHashCode();
                if (this.CreatedByRepEmailAddress != null)
                    hashCode = hashCode * 59 + this.CreatedByRepEmailAddress.GetHashCode();
                if (this.CreatedByRepPhoneNumber != null)
                    hashCode = hashCode * 59 + this.CreatedByRepPhoneNumber.GetHashCode();
                if (this.AssignedTechRepName != null)
                    hashCode = hashCode * 59 + this.AssignedTechRepName.GetHashCode();
                if (this.AssignedTechRepEmailAddress != null)
                    hashCode = hashCode * 59 + this.AssignedTechRepEmailAddress.GetHashCode();
                if (this.AssignedTechRepPhoneNumber != null)
                    hashCode = hashCode * 59 + this.AssignedTechRepPhoneNumber.GetHashCode();
                if (this.RepToCreditName != null)
                    hashCode = hashCode * 59 + this.RepToCreditName.GetHashCode();
                if (this.RepToCreditEmailAddress != null)
                    hashCode = hashCode * 59 + this.RepToCreditEmailAddress.GetHashCode();
                if (this.RepToCreditPhoneNumber != null)
                    hashCode = hashCode * 59 + this.RepToCreditPhoneNumber.GetHashCode();
                if (this.ContractAccount != null)
                    hashCode = hashCode * 59 + this.ContractAccount.GetHashCode();
                if (this.ItemsCovered != null)
                    hashCode = hashCode * 59 + this.ItemsCovered.GetHashCode();
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