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
    /// TsiWebAssetType
    /// </summary>
    [DataContract]
    public partial class TsiWebAssetType :  IEquatable<TsiWebAssetType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAssetType" /> class.
        /// </summary>
        /// <param name="assetTypeKeyNumber">assetTypeKeyNumber.</param>
        /// <param name="mSPAssetType">mSPAssetType.</param>
        /// <param name="specialItemID">specialItemID.</param>
        /// <param name="defaultPriceLevel">defaultPriceLevel.</param>
        /// <param name="priceLevelDescription">priceLevelDescription.</param>
        /// <param name="defaultFlatPrice">defaultFlatPrice.</param>
        /// <param name="useFlatPriceDefault">useFlatPriceDefault.</param>
        public TsiWebAssetType(int? assetTypeKeyNumber = default(int?), string mSPAssetType = default(string), string specialItemID = default(string), int? defaultPriceLevel = default(int?), string priceLevelDescription = default(string), double? defaultFlatPrice = default(double?), bool? useFlatPriceDefault = default(bool?))
        {
            this.AssetTypeKeyNumber = assetTypeKeyNumber;
            this.MSPAssetType = mSPAssetType;
            this.SpecialItemID = specialItemID;
            this.DefaultPriceLevel = defaultPriceLevel;
            this.PriceLevelDescription = priceLevelDescription;
            this.DefaultFlatPrice = defaultFlatPrice;
            this.UseFlatPriceDefault = useFlatPriceDefault;
        }
        
        /// <summary>
        /// Gets or Sets AssetTypeKeyNumber
        /// </summary>
        [DataMember(Name="AssetTypeKeyNumber", EmitDefaultValue=false)]
        public int? AssetTypeKeyNumber { get; set; }

        /// <summary>
        /// Gets or Sets MSPAssetType
        /// </summary>
        [DataMember(Name="MSPAssetType", EmitDefaultValue=false)]
        public string MSPAssetType { get; set; }

        /// <summary>
        /// Gets or Sets SpecialItemID
        /// </summary>
        [DataMember(Name="SpecialItemID", EmitDefaultValue=false)]
        public string SpecialItemID { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPriceLevel
        /// </summary>
        [DataMember(Name="DefaultPriceLevel", EmitDefaultValue=false)]
        public int? DefaultPriceLevel { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevelDescription
        /// </summary>
        [DataMember(Name="PriceLevelDescription", EmitDefaultValue=false)]
        public string PriceLevelDescription { get; set; }

        /// <summary>
        /// Gets or Sets DefaultFlatPrice
        /// </summary>
        [DataMember(Name="DefaultFlatPrice", EmitDefaultValue=false)]
        public double? DefaultFlatPrice { get; set; }

        /// <summary>
        /// Gets or Sets UseFlatPriceDefault
        /// </summary>
        [DataMember(Name="UseFlatPriceDefault", EmitDefaultValue=false)]
        public bool? UseFlatPriceDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAssetType {\n");
            sb.Append("  AssetTypeKeyNumber: ").Append(AssetTypeKeyNumber).Append("\n");
            sb.Append("  MSPAssetType: ").Append(MSPAssetType).Append("\n");
            sb.Append("  SpecialItemID: ").Append(SpecialItemID).Append("\n");
            sb.Append("  DefaultPriceLevel: ").Append(DefaultPriceLevel).Append("\n");
            sb.Append("  PriceLevelDescription: ").Append(PriceLevelDescription).Append("\n");
            sb.Append("  DefaultFlatPrice: ").Append(DefaultFlatPrice).Append("\n");
            sb.Append("  UseFlatPriceDefault: ").Append(UseFlatPriceDefault).Append("\n");
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
            return this.Equals(input as TsiWebAssetType);
        }

        /// <summary>
        /// Returns true if TsiWebAssetType instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAssetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAssetType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetTypeKeyNumber == input.AssetTypeKeyNumber ||
                    (this.AssetTypeKeyNumber != null &&
                    this.AssetTypeKeyNumber.Equals(input.AssetTypeKeyNumber))
                ) && 
                (
                    this.MSPAssetType == input.MSPAssetType ||
                    (this.MSPAssetType != null &&
                    this.MSPAssetType.Equals(input.MSPAssetType))
                ) && 
                (
                    this.SpecialItemID == input.SpecialItemID ||
                    (this.SpecialItemID != null &&
                    this.SpecialItemID.Equals(input.SpecialItemID))
                ) && 
                (
                    this.DefaultPriceLevel == input.DefaultPriceLevel ||
                    (this.DefaultPriceLevel != null &&
                    this.DefaultPriceLevel.Equals(input.DefaultPriceLevel))
                ) && 
                (
                    this.PriceLevelDescription == input.PriceLevelDescription ||
                    (this.PriceLevelDescription != null &&
                    this.PriceLevelDescription.Equals(input.PriceLevelDescription))
                ) && 
                (
                    this.DefaultFlatPrice == input.DefaultFlatPrice ||
                    (this.DefaultFlatPrice != null &&
                    this.DefaultFlatPrice.Equals(input.DefaultFlatPrice))
                ) && 
                (
                    this.UseFlatPriceDefault == input.UseFlatPriceDefault ||
                    (this.UseFlatPriceDefault != null &&
                    this.UseFlatPriceDefault.Equals(input.UseFlatPriceDefault))
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
                if (this.AssetTypeKeyNumber != null)
                    hashCode = hashCode * 59 + this.AssetTypeKeyNumber.GetHashCode();
                if (this.MSPAssetType != null)
                    hashCode = hashCode * 59 + this.MSPAssetType.GetHashCode();
                if (this.SpecialItemID != null)
                    hashCode = hashCode * 59 + this.SpecialItemID.GetHashCode();
                if (this.DefaultPriceLevel != null)
                    hashCode = hashCode * 59 + this.DefaultPriceLevel.GetHashCode();
                if (this.PriceLevelDescription != null)
                    hashCode = hashCode * 59 + this.PriceLevelDescription.GetHashCode();
                if (this.DefaultFlatPrice != null)
                    hashCode = hashCode * 59 + this.DefaultFlatPrice.GetHashCode();
                if (this.UseFlatPriceDefault != null)
                    hashCode = hashCode * 59 + this.UseFlatPriceDefault.GetHashCode();
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
