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
    /// TsiWebVendorItem
    /// </summary>
    [DataContract]
    public partial class TsiWebVendorItem :  IEquatable<TsiWebVendorItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebVendorItem" /> class.
        /// </summary>
        /// <param name="cost">cost.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="isStockItem">isStockItem.</param>
        /// <param name="isRepair">isRepair.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="priceBookItemType">priceBookItemType.</param>
        /// <param name="relatedOrderType">relatedOrderType.</param>
        /// <param name="relatedOrderNumber">relatedOrderNumber.</param>
        /// <param name="relatedOrderDetailNumber">relatedOrderDetailNumber.</param>
        /// <param name="relatedOrderAssemblyDetailNumber">relatedOrderAssemblyDetailNumber.</param>
        /// <param name="expectedDate">expectedDate.</param>
        public TsiWebVendorItem(double? cost = default(double?), double? quantity = default(double?), bool? isStockItem = default(bool?), bool? isRepair = default(bool?), string itemId = default(string), string itemDescription = default(string), string priceBookItemType = default(string), string relatedOrderType = default(string), int? relatedOrderNumber = default(int?), int? relatedOrderDetailNumber = default(int?), int? relatedOrderAssemblyDetailNumber = default(int?), DateTime? expectedDate = default(DateTime?))
        {
            this.Cost = cost;
            this.Quantity = quantity;
            this.IsStockItem = isStockItem;
            this.IsRepair = isRepair;
            this.ItemId = itemId;
            this.ItemDescription = itemDescription;
            this.PriceBookItemType = priceBookItemType;
            this.RelatedOrderType = relatedOrderType;
            this.RelatedOrderNumber = relatedOrderNumber;
            this.RelatedOrderDetailNumber = relatedOrderDetailNumber;
            this.RelatedOrderAssemblyDetailNumber = relatedOrderAssemblyDetailNumber;
            this.ExpectedDate = expectedDate;
        }
        
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="Cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets IsStockItem
        /// </summary>
        [DataMember(Name="IsStockItem", EmitDefaultValue=false)]
        public bool? IsStockItem { get; set; }

        /// <summary>
        /// Gets or Sets IsRepair
        /// </summary>
        [DataMember(Name="IsRepair", EmitDefaultValue=false)]
        public bool? IsRepair { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="ItemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets PriceBookItemType
        /// </summary>
        [DataMember(Name="PriceBookItemType", EmitDefaultValue=false)]
        public string PriceBookItemType { get; set; }

        /// <summary>
        /// Gets or Sets RelatedOrderType
        /// </summary>
        [DataMember(Name="RelatedOrderType", EmitDefaultValue=false)]
        public string RelatedOrderType { get; set; }

        /// <summary>
        /// Gets or Sets RelatedOrderNumber
        /// </summary>
        [DataMember(Name="RelatedOrderNumber", EmitDefaultValue=false)]
        public int? RelatedOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets RelatedOrderDetailNumber
        /// </summary>
        [DataMember(Name="RelatedOrderDetailNumber", EmitDefaultValue=false)]
        public int? RelatedOrderDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets RelatedOrderAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="RelatedOrderAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? RelatedOrderAssemblyDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedDate
        /// </summary>
        [DataMember(Name="ExpectedDate", EmitDefaultValue=false)]
        public DateTime? ExpectedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebVendorItem {\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  IsStockItem: ").Append(IsStockItem).Append("\n");
            sb.Append("  IsRepair: ").Append(IsRepair).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  PriceBookItemType: ").Append(PriceBookItemType).Append("\n");
            sb.Append("  RelatedOrderType: ").Append(RelatedOrderType).Append("\n");
            sb.Append("  RelatedOrderNumber: ").Append(RelatedOrderNumber).Append("\n");
            sb.Append("  RelatedOrderDetailNumber: ").Append(RelatedOrderDetailNumber).Append("\n");
            sb.Append("  RelatedOrderAssemblyDetailNumber: ").Append(RelatedOrderAssemblyDetailNumber).Append("\n");
            sb.Append("  ExpectedDate: ").Append(ExpectedDate).Append("\n");
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
            return this.Equals(input as TsiWebVendorItem);
        }

        /// <summary>
        /// Returns true if TsiWebVendorItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebVendorItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebVendorItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.IsStockItem == input.IsStockItem ||
                    (this.IsStockItem != null &&
                    this.IsStockItem.Equals(input.IsStockItem))
                ) && 
                (
                    this.IsRepair == input.IsRepair ||
                    (this.IsRepair != null &&
                    this.IsRepair.Equals(input.IsRepair))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemDescription == input.ItemDescription ||
                    (this.ItemDescription != null &&
                    this.ItemDescription.Equals(input.ItemDescription))
                ) && 
                (
                    this.PriceBookItemType == input.PriceBookItemType ||
                    (this.PriceBookItemType != null &&
                    this.PriceBookItemType.Equals(input.PriceBookItemType))
                ) && 
                (
                    this.RelatedOrderType == input.RelatedOrderType ||
                    (this.RelatedOrderType != null &&
                    this.RelatedOrderType.Equals(input.RelatedOrderType))
                ) && 
                (
                    this.RelatedOrderNumber == input.RelatedOrderNumber ||
                    (this.RelatedOrderNumber != null &&
                    this.RelatedOrderNumber.Equals(input.RelatedOrderNumber))
                ) && 
                (
                    this.RelatedOrderDetailNumber == input.RelatedOrderDetailNumber ||
                    (this.RelatedOrderDetailNumber != null &&
                    this.RelatedOrderDetailNumber.Equals(input.RelatedOrderDetailNumber))
                ) && 
                (
                    this.RelatedOrderAssemblyDetailNumber == input.RelatedOrderAssemblyDetailNumber ||
                    (this.RelatedOrderAssemblyDetailNumber != null &&
                    this.RelatedOrderAssemblyDetailNumber.Equals(input.RelatedOrderAssemblyDetailNumber))
                ) && 
                (
                    this.ExpectedDate == input.ExpectedDate ||
                    (this.ExpectedDate != null &&
                    this.ExpectedDate.Equals(input.ExpectedDate))
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
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.IsStockItem != null)
                    hashCode = hashCode * 59 + this.IsStockItem.GetHashCode();
                if (this.IsRepair != null)
                    hashCode = hashCode * 59 + this.IsRepair.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.PriceBookItemType != null)
                    hashCode = hashCode * 59 + this.PriceBookItemType.GetHashCode();
                if (this.RelatedOrderType != null)
                    hashCode = hashCode * 59 + this.RelatedOrderType.GetHashCode();
                if (this.RelatedOrderNumber != null)
                    hashCode = hashCode * 59 + this.RelatedOrderNumber.GetHashCode();
                if (this.RelatedOrderDetailNumber != null)
                    hashCode = hashCode * 59 + this.RelatedOrderDetailNumber.GetHashCode();
                if (this.RelatedOrderAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.RelatedOrderAssemblyDetailNumber.GetHashCode();
                if (this.ExpectedDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDate.GetHashCode();
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
