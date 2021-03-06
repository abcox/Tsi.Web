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
    /// TsiWebAgreementCoveredAssetType
    /// </summary>
    [DataContract]
    public partial class TsiWebAgreementCoveredAssetType :  IEquatable<TsiWebAgreementCoveredAssetType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAgreementCoveredAssetType" /> class.
        /// </summary>
        /// <param name="coveredAssetNumber">Gets or sets AssetTypeId.</param>
        /// <param name="assetType">Gets or sets AssetType.</param>
        /// <param name="specialItemId">Gets or sets SpecialItemId.</param>
        /// <param name="itemDescription">Gets or sets the ItemDescription.</param>
        /// <param name="price">Gets or sets the Price.</param>
        /// <param name="priceLevel">Gets or sets the PriceLevel.</param>
        /// <param name="priceLevelDescription">Gets or sets the PriceLevelDescription.</param>
        /// <param name="dateAdded">Gets or sets the DateAdded.</param>
        /// <param name="useFlatPrice">Gets or sets the UseFlatPrice.</param>
        public TsiWebAgreementCoveredAssetType(int? coveredAssetNumber = default(int?), string assetType = default(string), string specialItemId = default(string), string itemDescription = default(string), double? price = default(double?), int? priceLevel = default(int?), string priceLevelDescription = default(string), DateTime? dateAdded = default(DateTime?), bool? useFlatPrice = default(bool?))
        {
            this.CoveredAssetNumber = coveredAssetNumber;
            this.AssetType = assetType;
            this.SpecialItemId = specialItemId;
            this.ItemDescription = itemDescription;
            this.Price = price;
            this.PriceLevel = priceLevel;
            this.PriceLevelDescription = priceLevelDescription;
            this.DateAdded = dateAdded;
            this.UseFlatPrice = useFlatPrice;
        }
        
        /// <summary>
        /// Gets or sets AssetTypeId
        /// </summary>
        /// <value>Gets or sets AssetTypeId</value>
        [DataMember(Name="CoveredAssetNumber", EmitDefaultValue=false)]
        public int? CoveredAssetNumber { get; set; }

        /// <summary>
        /// Gets or sets AssetType
        /// </summary>
        /// <value>Gets or sets AssetType</value>
        [DataMember(Name="AssetType", EmitDefaultValue=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or sets SpecialItemId
        /// </summary>
        /// <value>Gets or sets SpecialItemId</value>
        [DataMember(Name="SpecialItemId", EmitDefaultValue=false)]
        public string SpecialItemId { get; set; }

        /// <summary>
        /// Gets or sets the ItemDescription
        /// </summary>
        /// <value>Gets or sets the ItemDescription</value>
        [DataMember(Name="ItemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        /// <value>Gets or sets the Price</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or sets the PriceLevel
        /// </summary>
        /// <value>Gets or sets the PriceLevel</value>
        [DataMember(Name="PriceLevel", EmitDefaultValue=false)]
        public int? PriceLevel { get; set; }

        /// <summary>
        /// Gets or sets the PriceLevelDescription
        /// </summary>
        /// <value>Gets or sets the PriceLevelDescription</value>
        [DataMember(Name="PriceLevelDescription", EmitDefaultValue=false)]
        public string PriceLevelDescription { get; set; }

        /// <summary>
        /// Gets or sets the DateAdded
        /// </summary>
        /// <value>Gets or sets the DateAdded</value>
        [DataMember(Name="DateAdded", EmitDefaultValue=false)]
        public DateTime? DateAdded { get; set; }

        /// <summary>
        /// Gets or sets the UseFlatPrice
        /// </summary>
        /// <value>Gets or sets the UseFlatPrice</value>
        [DataMember(Name="UseFlatPrice", EmitDefaultValue=false)]
        public bool? UseFlatPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAgreementCoveredAssetType {\n");
            sb.Append("  CoveredAssetNumber: ").Append(CoveredAssetNumber).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  SpecialItemId: ").Append(SpecialItemId).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  PriceLevelDescription: ").Append(PriceLevelDescription).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  UseFlatPrice: ").Append(UseFlatPrice).Append("\n");
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
            return this.Equals(input as TsiWebAgreementCoveredAssetType);
        }

        /// <summary>
        /// Returns true if TsiWebAgreementCoveredAssetType instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAgreementCoveredAssetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAgreementCoveredAssetType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoveredAssetNumber == input.CoveredAssetNumber ||
                    (this.CoveredAssetNumber != null &&
                    this.CoveredAssetNumber.Equals(input.CoveredAssetNumber))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.SpecialItemId == input.SpecialItemId ||
                    (this.SpecialItemId != null &&
                    this.SpecialItemId.Equals(input.SpecialItemId))
                ) && 
                (
                    this.ItemDescription == input.ItemDescription ||
                    (this.ItemDescription != null &&
                    this.ItemDescription.Equals(input.ItemDescription))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PriceLevel == input.PriceLevel ||
                    (this.PriceLevel != null &&
                    this.PriceLevel.Equals(input.PriceLevel))
                ) && 
                (
                    this.PriceLevelDescription == input.PriceLevelDescription ||
                    (this.PriceLevelDescription != null &&
                    this.PriceLevelDescription.Equals(input.PriceLevelDescription))
                ) && 
                (
                    this.DateAdded == input.DateAdded ||
                    (this.DateAdded != null &&
                    this.DateAdded.Equals(input.DateAdded))
                ) && 
                (
                    this.UseFlatPrice == input.UseFlatPrice ||
                    (this.UseFlatPrice != null &&
                    this.UseFlatPrice.Equals(input.UseFlatPrice))
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
                if (this.CoveredAssetNumber != null)
                    hashCode = hashCode * 59 + this.CoveredAssetNumber.GetHashCode();
                if (this.AssetType != null)
                    hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.SpecialItemId != null)
                    hashCode = hashCode * 59 + this.SpecialItemId.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceLevel != null)
                    hashCode = hashCode * 59 + this.PriceLevel.GetHashCode();
                if (this.PriceLevelDescription != null)
                    hashCode = hashCode * 59 + this.PriceLevelDescription.GetHashCode();
                if (this.DateAdded != null)
                    hashCode = hashCode * 59 + this.DateAdded.GetHashCode();
                if (this.UseFlatPrice != null)
                    hashCode = hashCode * 59 + this.UseFlatPrice.GetHashCode();
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
