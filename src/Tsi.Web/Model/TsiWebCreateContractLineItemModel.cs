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
    /// TsiWebCreateContractLineItemModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateContractLineItemModel :  IEquatable<TsiWebCreateContractLineItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateContractLineItemModel" /> class.
        /// </summary>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="itemID">itemID.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="priceBookNumber">priceBookNumber.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="contractItemType">contractItemType.</param>
        /// <param name="reference">reference.</param>
        /// <param name="warrantyExpiration">warrantyExpiration.</param>
        /// <param name="cancelDate">cancelDate.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactPhoneNumber">contactPhoneNumber.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="yearlyPrice">yearlyPrice.</param>
        /// <param name="renewalListPercentage">renewalListPercentage.</param>
        /// <param name="renewalListPrice">renewalListPrice.</param>
        /// <param name="customerInventoryNumber">customerInventoryNumber.</param>
        /// <param name="contractPrice">contractPrice.</param>
        /// <param name="serviceOrderPriority">serviceOrderPriority.</param>
        public TsiWebCreateContractLineItemModel(string serialNumber = default(string), string itemID = default(string), string itemDescription = default(string), int? priceBookNumber = default(int?), double? quantity = default(double?), string contractItemType = default(string), string reference = default(string), DateTime? warrantyExpiration = default(DateTime?), DateTime? cancelDate = default(DateTime?), string contactName = default(string), string contactPhoneNumber = default(string), DateTime? startDate = default(DateTime?), double? yearlyPrice = default(double?), double? renewalListPercentage = default(double?), double? renewalListPrice = default(double?), int? customerInventoryNumber = default(int?), double? contractPrice = default(double?), string serviceOrderPriority = default(string))
        {
            this.SerialNumber = serialNumber;
            this.ItemID = itemID;
            this.ItemDescription = itemDescription;
            this.PriceBookNumber = priceBookNumber;
            this.Quantity = quantity;
            this.ContractItemType = contractItemType;
            this.Reference = reference;
            this.WarrantyExpiration = warrantyExpiration;
            this.CancelDate = cancelDate;
            this.ContactName = contactName;
            this.ContactPhoneNumber = contactPhoneNumber;
            this.StartDate = startDate;
            this.YearlyPrice = yearlyPrice;
            this.RenewalListPercentage = renewalListPercentage;
            this.RenewalListPrice = renewalListPrice;
            this.CustomerInventoryNumber = customerInventoryNumber;
            this.ContractPrice = contractPrice;
            this.ServiceOrderPriority = serviceOrderPriority;
        }
        
        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets ItemID
        /// </summary>
        [DataMember(Name="ItemID", EmitDefaultValue=false)]
        public string ItemID { get; set; }

        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="ItemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets PriceBookNumber
        /// </summary>
        [DataMember(Name="PriceBookNumber", EmitDefaultValue=false)]
        public int? PriceBookNumber { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ContractItemType
        /// </summary>
        [DataMember(Name="ContractItemType", EmitDefaultValue=false)]
        public string ContractItemType { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets WarrantyExpiration
        /// </summary>
        [DataMember(Name="WarrantyExpiration", EmitDefaultValue=false)]
        public DateTime? WarrantyExpiration { get; set; }

        /// <summary>
        /// Gets or Sets CancelDate
        /// </summary>
        [DataMember(Name="CancelDate", EmitDefaultValue=false)]
        public DateTime? CancelDate { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="ContactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhoneNumber
        /// </summary>
        [DataMember(Name="ContactPhoneNumber", EmitDefaultValue=false)]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets YearlyPrice
        /// </summary>
        [DataMember(Name="YearlyPrice", EmitDefaultValue=false)]
        public double? YearlyPrice { get; set; }

        /// <summary>
        /// Gets or Sets RenewalListPercentage
        /// </summary>
        [DataMember(Name="RenewalListPercentage", EmitDefaultValue=false)]
        public double? RenewalListPercentage { get; set; }

        /// <summary>
        /// Gets or Sets RenewalListPrice
        /// </summary>
        [DataMember(Name="RenewalListPrice", EmitDefaultValue=false)]
        public double? RenewalListPrice { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInventoryNumber
        /// </summary>
        [DataMember(Name="CustomerInventoryNumber", EmitDefaultValue=false)]
        public int? CustomerInventoryNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContractPrice
        /// </summary>
        [DataMember(Name="ContractPrice", EmitDefaultValue=false)]
        public double? ContractPrice { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderPriority
        /// </summary>
        [DataMember(Name="ServiceOrderPriority", EmitDefaultValue=false)]
        public string ServiceOrderPriority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateContractLineItemModel {\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  PriceBookNumber: ").Append(PriceBookNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ContractItemType: ").Append(ContractItemType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  WarrantyExpiration: ").Append(WarrantyExpiration).Append("\n");
            sb.Append("  CancelDate: ").Append(CancelDate).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  YearlyPrice: ").Append(YearlyPrice).Append("\n");
            sb.Append("  RenewalListPercentage: ").Append(RenewalListPercentage).Append("\n");
            sb.Append("  RenewalListPrice: ").Append(RenewalListPrice).Append("\n");
            sb.Append("  CustomerInventoryNumber: ").Append(CustomerInventoryNumber).Append("\n");
            sb.Append("  ContractPrice: ").Append(ContractPrice).Append("\n");
            sb.Append("  ServiceOrderPriority: ").Append(ServiceOrderPriority).Append("\n");
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
            return this.Equals(input as TsiWebCreateContractLineItemModel);
        }

        /// <summary>
        /// Returns true if TsiWebCreateContractLineItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateContractLineItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateContractLineItemModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.ItemID == input.ItemID ||
                    (this.ItemID != null &&
                    this.ItemID.Equals(input.ItemID))
                ) && 
                (
                    this.ItemDescription == input.ItemDescription ||
                    (this.ItemDescription != null &&
                    this.ItemDescription.Equals(input.ItemDescription))
                ) && 
                (
                    this.PriceBookNumber == input.PriceBookNumber ||
                    (this.PriceBookNumber != null &&
                    this.PriceBookNumber.Equals(input.PriceBookNumber))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ContractItemType == input.ContractItemType ||
                    (this.ContractItemType != null &&
                    this.ContractItemType.Equals(input.ContractItemType))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.WarrantyExpiration == input.WarrantyExpiration ||
                    (this.WarrantyExpiration != null &&
                    this.WarrantyExpiration.Equals(input.WarrantyExpiration))
                ) && 
                (
                    this.CancelDate == input.CancelDate ||
                    (this.CancelDate != null &&
                    this.CancelDate.Equals(input.CancelDate))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactPhoneNumber == input.ContactPhoneNumber ||
                    (this.ContactPhoneNumber != null &&
                    this.ContactPhoneNumber.Equals(input.ContactPhoneNumber))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.YearlyPrice == input.YearlyPrice ||
                    (this.YearlyPrice != null &&
                    this.YearlyPrice.Equals(input.YearlyPrice))
                ) && 
                (
                    this.RenewalListPercentage == input.RenewalListPercentage ||
                    (this.RenewalListPercentage != null &&
                    this.RenewalListPercentage.Equals(input.RenewalListPercentage))
                ) && 
                (
                    this.RenewalListPrice == input.RenewalListPrice ||
                    (this.RenewalListPrice != null &&
                    this.RenewalListPrice.Equals(input.RenewalListPrice))
                ) && 
                (
                    this.CustomerInventoryNumber == input.CustomerInventoryNumber ||
                    (this.CustomerInventoryNumber != null &&
                    this.CustomerInventoryNumber.Equals(input.CustomerInventoryNumber))
                ) && 
                (
                    this.ContractPrice == input.ContractPrice ||
                    (this.ContractPrice != null &&
                    this.ContractPrice.Equals(input.ContractPrice))
                ) && 
                (
                    this.ServiceOrderPriority == input.ServiceOrderPriority ||
                    (this.ServiceOrderPriority != null &&
                    this.ServiceOrderPriority.Equals(input.ServiceOrderPriority))
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
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.PriceBookNumber != null)
                    hashCode = hashCode * 59 + this.PriceBookNumber.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ContractItemType != null)
                    hashCode = hashCode * 59 + this.ContractItemType.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.WarrantyExpiration != null)
                    hashCode = hashCode * 59 + this.WarrantyExpiration.GetHashCode();
                if (this.CancelDate != null)
                    hashCode = hashCode * 59 + this.CancelDate.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.ContactPhoneNumber != null)
                    hashCode = hashCode * 59 + this.ContactPhoneNumber.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.YearlyPrice != null)
                    hashCode = hashCode * 59 + this.YearlyPrice.GetHashCode();
                if (this.RenewalListPercentage != null)
                    hashCode = hashCode * 59 + this.RenewalListPercentage.GetHashCode();
                if (this.RenewalListPrice != null)
                    hashCode = hashCode * 59 + this.RenewalListPrice.GetHashCode();
                if (this.CustomerInventoryNumber != null)
                    hashCode = hashCode * 59 + this.CustomerInventoryNumber.GetHashCode();
                if (this.ContractPrice != null)
                    hashCode = hashCode * 59 + this.ContractPrice.GetHashCode();
                if (this.ServiceOrderPriority != null)
                    hashCode = hashCode * 59 + this.ServiceOrderPriority.GetHashCode();
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
