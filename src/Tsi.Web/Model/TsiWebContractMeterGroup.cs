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
    /// TsiWebContractMeterGroup
    /// </summary>
    [DataContract]
    public partial class TsiWebContractMeterGroup :  IEquatable<TsiWebContractMeterGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebContractMeterGroup" /> class.
        /// </summary>
        /// <param name="contractMultipleMeterGroupPricingKeyNumber">Gets or sets the contract multiple meter group pricing key number.</param>
        /// <param name="contractMeterGroupKeyNumber">Gets or sets the contract meter group.</param>
        /// <param name="contractMeterGroupName">Gets or sets the contract meter group name.</param>
        /// <param name="billingStyle">Gets or sets the contract meter group billing style.</param>
        /// <param name="startDate">Gets or sets the StartDate.</param>
        /// <param name="endDate">Gets or sets the EndDate.</param>
        /// <param name="flatRate">Gets or sets the FlatRate.</param>
        /// <param name="itemID">Gets or sets the ItemID.</param>
        /// <param name="lastBilledUsage">Gets or sets the LastBilledUsage.</param>
        /// <param name="lastBilledDate">Gets or sets the LastBilledDate.</param>
        /// <param name="nextBillingDate">Gets or sets the NextBillingDate.</param>
        /// <param name="totalUsageBilled">Gets or sets the TotalUsageBilled.</param>
        /// <param name="lockPricing">lockPricing.</param>
        /// <param name="priceLockingEndDate">priceLockingEndDate.</param>
        /// <param name="usePriceEscalation">usePriceEscalation.</param>
        /// <param name="escalationPercent">escalationPercent.</param>
        /// <param name="escalationPeriod">escalationPeriod.</param>
        /// <param name="nextPriceEscalationDate">nextPriceEscalationDate.</param>
        /// <param name="basePrice">basePrice.</param>
        /// <param name="contractMeterGroupBillings">Gets or sets the ContractMeterGroupBillings.</param>
        public TsiWebContractMeterGroup(int? contractMultipleMeterGroupPricingKeyNumber = default(int?), int? contractMeterGroupKeyNumber = default(int?), string contractMeterGroupName = default(string), string billingStyle = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), double? flatRate = default(double?), string itemID = default(string), int? lastBilledUsage = default(int?), DateTime? lastBilledDate = default(DateTime?), DateTime? nextBillingDate = default(DateTime?), int? totalUsageBilled = default(int?), bool? lockPricing = default(bool?), DateTime? priceLockingEndDate = default(DateTime?), bool? usePriceEscalation = default(bool?), double? escalationPercent = default(double?), int? escalationPeriod = default(int?), DateTime? nextPriceEscalationDate = default(DateTime?), double? basePrice = default(double?), List<TsiWebContractMeterGroupBilling> contractMeterGroupBillings = default(List<TsiWebContractMeterGroupBilling>))
        {
            this.ContractMultipleMeterGroupPricingKeyNumber = contractMultipleMeterGroupPricingKeyNumber;
            this.ContractMeterGroupKeyNumber = contractMeterGroupKeyNumber;
            this.ContractMeterGroupName = contractMeterGroupName;
            this.BillingStyle = billingStyle;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FlatRate = flatRate;
            this.ItemID = itemID;
            this.LastBilledUsage = lastBilledUsage;
            this.LastBilledDate = lastBilledDate;
            this.NextBillingDate = nextBillingDate;
            this.TotalUsageBilled = totalUsageBilled;
            this.LockPricing = lockPricing;
            this.PriceLockingEndDate = priceLockingEndDate;
            this.UsePriceEscalation = usePriceEscalation;
            this.EscalationPercent = escalationPercent;
            this.EscalationPeriod = escalationPeriod;
            this.NextPriceEscalationDate = nextPriceEscalationDate;
            this.BasePrice = basePrice;
            this.ContractMeterGroupBillings = contractMeterGroupBillings;
        }
        
        /// <summary>
        /// Gets or sets the contract multiple meter group pricing key number
        /// </summary>
        /// <value>Gets or sets the contract multiple meter group pricing key number</value>
        [DataMember(Name="ContractMultipleMeterGroupPricingKeyNumber", EmitDefaultValue=false)]
        public int? ContractMultipleMeterGroupPricingKeyNumber { get; set; }

        /// <summary>
        /// Gets or sets the contract meter group
        /// </summary>
        /// <value>Gets or sets the contract meter group</value>
        [DataMember(Name="ContractMeterGroupKeyNumber", EmitDefaultValue=false)]
        public int? ContractMeterGroupKeyNumber { get; set; }

        /// <summary>
        /// Gets or sets the contract meter group name
        /// </summary>
        /// <value>Gets or sets the contract meter group name</value>
        [DataMember(Name="ContractMeterGroupName", EmitDefaultValue=false)]
        public string ContractMeterGroupName { get; set; }

        /// <summary>
        /// Gets or sets the contract meter group billing style
        /// </summary>
        /// <value>Gets or sets the contract meter group billing style</value>
        [DataMember(Name="BillingStyle", EmitDefaultValue=false)]
        public string BillingStyle { get; set; }

        /// <summary>
        /// Gets or sets the StartDate
        /// </summary>
        /// <value>Gets or sets the StartDate</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the EndDate
        /// </summary>
        /// <value>Gets or sets the EndDate</value>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the FlatRate
        /// </summary>
        /// <value>Gets or sets the FlatRate</value>
        [DataMember(Name="FlatRate", EmitDefaultValue=false)]
        public double? FlatRate { get; set; }

        /// <summary>
        /// Gets or sets the ItemID
        /// </summary>
        /// <value>Gets or sets the ItemID</value>
        [DataMember(Name="ItemID", EmitDefaultValue=false)]
        public string ItemID { get; set; }

        /// <summary>
        /// Gets or sets the LastBilledUsage
        /// </summary>
        /// <value>Gets or sets the LastBilledUsage</value>
        [DataMember(Name="LastBilledUsage", EmitDefaultValue=false)]
        public int? LastBilledUsage { get; set; }

        /// <summary>
        /// Gets or sets the LastBilledDate
        /// </summary>
        /// <value>Gets or sets the LastBilledDate</value>
        [DataMember(Name="LastBilledDate", EmitDefaultValue=false)]
        public DateTime? LastBilledDate { get; set; }

        /// <summary>
        /// Gets or sets the NextBillingDate
        /// </summary>
        /// <value>Gets or sets the NextBillingDate</value>
        [DataMember(Name="NextBillingDate", EmitDefaultValue=false)]
        public DateTime? NextBillingDate { get; set; }

        /// <summary>
        /// Gets or sets the TotalUsageBilled
        /// </summary>
        /// <value>Gets or sets the TotalUsageBilled</value>
        [DataMember(Name="TotalUsageBilled", EmitDefaultValue=false)]
        public int? TotalUsageBilled { get; set; }

        /// <summary>
        /// Gets or Sets LockPricing
        /// </summary>
        [DataMember(Name="LockPricing", EmitDefaultValue=false)]
        public bool? LockPricing { get; set; }

        /// <summary>
        /// Gets or Sets PriceLockingEndDate
        /// </summary>
        [DataMember(Name="PriceLockingEndDate", EmitDefaultValue=false)]
        public DateTime? PriceLockingEndDate { get; set; }

        /// <summary>
        /// Gets or Sets UsePriceEscalation
        /// </summary>
        [DataMember(Name="UsePriceEscalation", EmitDefaultValue=false)]
        public bool? UsePriceEscalation { get; set; }

        /// <summary>
        /// Gets or Sets EscalationPercent
        /// </summary>
        [DataMember(Name="EscalationPercent", EmitDefaultValue=false)]
        public double? EscalationPercent { get; set; }

        /// <summary>
        /// Gets or Sets EscalationPeriod
        /// </summary>
        [DataMember(Name="EscalationPeriod", EmitDefaultValue=false)]
        public int? EscalationPeriod { get; set; }

        /// <summary>
        /// Gets or Sets NextPriceEscalationDate
        /// </summary>
        [DataMember(Name="NextPriceEscalationDate", EmitDefaultValue=false)]
        public DateTime? NextPriceEscalationDate { get; set; }

        /// <summary>
        /// Gets or Sets BasePrice
        /// </summary>
        [DataMember(Name="BasePrice", EmitDefaultValue=false)]
        public double? BasePrice { get; set; }

        /// <summary>
        /// Gets or sets the ContractMeterGroupBillings
        /// </summary>
        /// <value>Gets or sets the ContractMeterGroupBillings</value>
        [DataMember(Name="ContractMeterGroupBillings", EmitDefaultValue=false)]
        public List<TsiWebContractMeterGroupBilling> ContractMeterGroupBillings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebContractMeterGroup {\n");
            sb.Append("  ContractMultipleMeterGroupPricingKeyNumber: ").Append(ContractMultipleMeterGroupPricingKeyNumber).Append("\n");
            sb.Append("  ContractMeterGroupKeyNumber: ").Append(ContractMeterGroupKeyNumber).Append("\n");
            sb.Append("  ContractMeterGroupName: ").Append(ContractMeterGroupName).Append("\n");
            sb.Append("  BillingStyle: ").Append(BillingStyle).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FlatRate: ").Append(FlatRate).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  LastBilledUsage: ").Append(LastBilledUsage).Append("\n");
            sb.Append("  LastBilledDate: ").Append(LastBilledDate).Append("\n");
            sb.Append("  NextBillingDate: ").Append(NextBillingDate).Append("\n");
            sb.Append("  TotalUsageBilled: ").Append(TotalUsageBilled).Append("\n");
            sb.Append("  LockPricing: ").Append(LockPricing).Append("\n");
            sb.Append("  PriceLockingEndDate: ").Append(PriceLockingEndDate).Append("\n");
            sb.Append("  UsePriceEscalation: ").Append(UsePriceEscalation).Append("\n");
            sb.Append("  EscalationPercent: ").Append(EscalationPercent).Append("\n");
            sb.Append("  EscalationPeriod: ").Append(EscalationPeriod).Append("\n");
            sb.Append("  NextPriceEscalationDate: ").Append(NextPriceEscalationDate).Append("\n");
            sb.Append("  BasePrice: ").Append(BasePrice).Append("\n");
            sb.Append("  ContractMeterGroupBillings: ").Append(ContractMeterGroupBillings).Append("\n");
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
            return this.Equals(input as TsiWebContractMeterGroup);
        }

        /// <summary>
        /// Returns true if TsiWebContractMeterGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebContractMeterGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebContractMeterGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContractMultipleMeterGroupPricingKeyNumber == input.ContractMultipleMeterGroupPricingKeyNumber ||
                    (this.ContractMultipleMeterGroupPricingKeyNumber != null &&
                    this.ContractMultipleMeterGroupPricingKeyNumber.Equals(input.ContractMultipleMeterGroupPricingKeyNumber))
                ) && 
                (
                    this.ContractMeterGroupKeyNumber == input.ContractMeterGroupKeyNumber ||
                    (this.ContractMeterGroupKeyNumber != null &&
                    this.ContractMeterGroupKeyNumber.Equals(input.ContractMeterGroupKeyNumber))
                ) && 
                (
                    this.ContractMeterGroupName == input.ContractMeterGroupName ||
                    (this.ContractMeterGroupName != null &&
                    this.ContractMeterGroupName.Equals(input.ContractMeterGroupName))
                ) && 
                (
                    this.BillingStyle == input.BillingStyle ||
                    (this.BillingStyle != null &&
                    this.BillingStyle.Equals(input.BillingStyle))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FlatRate == input.FlatRate ||
                    (this.FlatRate != null &&
                    this.FlatRate.Equals(input.FlatRate))
                ) && 
                (
                    this.ItemID == input.ItemID ||
                    (this.ItemID != null &&
                    this.ItemID.Equals(input.ItemID))
                ) && 
                (
                    this.LastBilledUsage == input.LastBilledUsage ||
                    (this.LastBilledUsage != null &&
                    this.LastBilledUsage.Equals(input.LastBilledUsage))
                ) && 
                (
                    this.LastBilledDate == input.LastBilledDate ||
                    (this.LastBilledDate != null &&
                    this.LastBilledDate.Equals(input.LastBilledDate))
                ) && 
                (
                    this.NextBillingDate == input.NextBillingDate ||
                    (this.NextBillingDate != null &&
                    this.NextBillingDate.Equals(input.NextBillingDate))
                ) && 
                (
                    this.TotalUsageBilled == input.TotalUsageBilled ||
                    (this.TotalUsageBilled != null &&
                    this.TotalUsageBilled.Equals(input.TotalUsageBilled))
                ) && 
                (
                    this.LockPricing == input.LockPricing ||
                    (this.LockPricing != null &&
                    this.LockPricing.Equals(input.LockPricing))
                ) && 
                (
                    this.PriceLockingEndDate == input.PriceLockingEndDate ||
                    (this.PriceLockingEndDate != null &&
                    this.PriceLockingEndDate.Equals(input.PriceLockingEndDate))
                ) && 
                (
                    this.UsePriceEscalation == input.UsePriceEscalation ||
                    (this.UsePriceEscalation != null &&
                    this.UsePriceEscalation.Equals(input.UsePriceEscalation))
                ) && 
                (
                    this.EscalationPercent == input.EscalationPercent ||
                    (this.EscalationPercent != null &&
                    this.EscalationPercent.Equals(input.EscalationPercent))
                ) && 
                (
                    this.EscalationPeriod == input.EscalationPeriod ||
                    (this.EscalationPeriod != null &&
                    this.EscalationPeriod.Equals(input.EscalationPeriod))
                ) && 
                (
                    this.NextPriceEscalationDate == input.NextPriceEscalationDate ||
                    (this.NextPriceEscalationDate != null &&
                    this.NextPriceEscalationDate.Equals(input.NextPriceEscalationDate))
                ) && 
                (
                    this.BasePrice == input.BasePrice ||
                    (this.BasePrice != null &&
                    this.BasePrice.Equals(input.BasePrice))
                ) && 
                (
                    this.ContractMeterGroupBillings == input.ContractMeterGroupBillings ||
                    this.ContractMeterGroupBillings != null &&
                    this.ContractMeterGroupBillings.SequenceEqual(input.ContractMeterGroupBillings)
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
                if (this.ContractMultipleMeterGroupPricingKeyNumber != null)
                    hashCode = hashCode * 59 + this.ContractMultipleMeterGroupPricingKeyNumber.GetHashCode();
                if (this.ContractMeterGroupKeyNumber != null)
                    hashCode = hashCode * 59 + this.ContractMeterGroupKeyNumber.GetHashCode();
                if (this.ContractMeterGroupName != null)
                    hashCode = hashCode * 59 + this.ContractMeterGroupName.GetHashCode();
                if (this.BillingStyle != null)
                    hashCode = hashCode * 59 + this.BillingStyle.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FlatRate != null)
                    hashCode = hashCode * 59 + this.FlatRate.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.LastBilledUsage != null)
                    hashCode = hashCode * 59 + this.LastBilledUsage.GetHashCode();
                if (this.LastBilledDate != null)
                    hashCode = hashCode * 59 + this.LastBilledDate.GetHashCode();
                if (this.NextBillingDate != null)
                    hashCode = hashCode * 59 + this.NextBillingDate.GetHashCode();
                if (this.TotalUsageBilled != null)
                    hashCode = hashCode * 59 + this.TotalUsageBilled.GetHashCode();
                if (this.LockPricing != null)
                    hashCode = hashCode * 59 + this.LockPricing.GetHashCode();
                if (this.PriceLockingEndDate != null)
                    hashCode = hashCode * 59 + this.PriceLockingEndDate.GetHashCode();
                if (this.UsePriceEscalation != null)
                    hashCode = hashCode * 59 + this.UsePriceEscalation.GetHashCode();
                if (this.EscalationPercent != null)
                    hashCode = hashCode * 59 + this.EscalationPercent.GetHashCode();
                if (this.EscalationPeriod != null)
                    hashCode = hashCode * 59 + this.EscalationPeriod.GetHashCode();
                if (this.NextPriceEscalationDate != null)
                    hashCode = hashCode * 59 + this.NextPriceEscalationDate.GetHashCode();
                if (this.BasePrice != null)
                    hashCode = hashCode * 59 + this.BasePrice.GetHashCode();
                if (this.ContractMeterGroupBillings != null)
                    hashCode = hashCode * 59 + this.ContractMeterGroupBillings.GetHashCode();
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