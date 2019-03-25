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
    /// TsiWebSalesTaxCode
    /// </summary>
    [DataContract]
    public partial class TsiWebSalesTaxCode :  IEquatable<TsiWebSalesTaxCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebSalesTaxCode" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="description">description.</param>
        /// <param name="customerTaxCode">customerTaxCode.</param>
        /// <param name="itemFullyTaxableCode">itemFullyTaxableCode.</param>
        /// <param name="itemProvincialOnlyCode">itemProvincialOnlyCode.</param>
        /// <param name="itemGSTOnlyCode">itemGSTOnlyCode.</param>
        /// <param name="itemExemptCode">itemExemptCode.</param>
        /// <param name="hasTieredDistrict">hasTieredDistrict.</param>
        /// <param name="taxGST">taxGST.</param>
        /// <param name="isHarmonizedTaxCode">isHarmonizedTaxCode.</param>
        /// <param name="systemDefault">systemDefault.</param>
        /// <param name="totalRate">totalRate.</param>
        public TsiWebSalesTaxCode(string code = default(string), string description = default(string), string customerTaxCode = default(string), string itemFullyTaxableCode = default(string), string itemProvincialOnlyCode = default(string), string itemGSTOnlyCode = default(string), string itemExemptCode = default(string), bool? hasTieredDistrict = default(bool?), bool? taxGST = default(bool?), bool? isHarmonizedTaxCode = default(bool?), bool? systemDefault = default(bool?), double? totalRate = default(double?))
        {
            this.Code = code;
            this.Description = description;
            this.CustomerTaxCode = customerTaxCode;
            this.ItemFullyTaxableCode = itemFullyTaxableCode;
            this.ItemProvincialOnlyCode = itemProvincialOnlyCode;
            this.ItemGSTOnlyCode = itemGSTOnlyCode;
            this.ItemExemptCode = itemExemptCode;
            this.HasTieredDistrict = hasTieredDistrict;
            this.TaxGST = taxGST;
            this.IsHarmonizedTaxCode = isHarmonizedTaxCode;
            this.SystemDefault = systemDefault;
            this.TotalRate = totalRate;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CustomerTaxCode
        /// </summary>
        [DataMember(Name="CustomerTaxCode", EmitDefaultValue=false)]
        public string CustomerTaxCode { get; set; }

        /// <summary>
        /// Gets or Sets ItemFullyTaxableCode
        /// </summary>
        [DataMember(Name="ItemFullyTaxableCode", EmitDefaultValue=false)]
        public string ItemFullyTaxableCode { get; set; }

        /// <summary>
        /// Gets or Sets ItemProvincialOnlyCode
        /// </summary>
        [DataMember(Name="ItemProvincialOnlyCode", EmitDefaultValue=false)]
        public string ItemProvincialOnlyCode { get; set; }

        /// <summary>
        /// Gets or Sets ItemGSTOnlyCode
        /// </summary>
        [DataMember(Name="ItemGSTOnlyCode", EmitDefaultValue=false)]
        public string ItemGSTOnlyCode { get; set; }

        /// <summary>
        /// Gets or Sets ItemExemptCode
        /// </summary>
        [DataMember(Name="ItemExemptCode", EmitDefaultValue=false)]
        public string ItemExemptCode { get; set; }

        /// <summary>
        /// Gets or Sets HasTieredDistrict
        /// </summary>
        [DataMember(Name="HasTieredDistrict", EmitDefaultValue=false)]
        public bool? HasTieredDistrict { get; set; }

        /// <summary>
        /// Gets or Sets TaxGST
        /// </summary>
        [DataMember(Name="TaxGST", EmitDefaultValue=false)]
        public bool? TaxGST { get; set; }

        /// <summary>
        /// Gets or Sets IsHarmonizedTaxCode
        /// </summary>
        [DataMember(Name="IsHarmonizedTaxCode", EmitDefaultValue=false)]
        public bool? IsHarmonizedTaxCode { get; set; }

        /// <summary>
        /// Gets or Sets SystemDefault
        /// </summary>
        [DataMember(Name="SystemDefault", EmitDefaultValue=false)]
        public bool? SystemDefault { get; set; }

        /// <summary>
        /// Gets or Sets TotalRate
        /// </summary>
        [DataMember(Name="TotalRate", EmitDefaultValue=false)]
        public double? TotalRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebSalesTaxCode {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CustomerTaxCode: ").Append(CustomerTaxCode).Append("\n");
            sb.Append("  ItemFullyTaxableCode: ").Append(ItemFullyTaxableCode).Append("\n");
            sb.Append("  ItemProvincialOnlyCode: ").Append(ItemProvincialOnlyCode).Append("\n");
            sb.Append("  ItemGSTOnlyCode: ").Append(ItemGSTOnlyCode).Append("\n");
            sb.Append("  ItemExemptCode: ").Append(ItemExemptCode).Append("\n");
            sb.Append("  HasTieredDistrict: ").Append(HasTieredDistrict).Append("\n");
            sb.Append("  TaxGST: ").Append(TaxGST).Append("\n");
            sb.Append("  IsHarmonizedTaxCode: ").Append(IsHarmonizedTaxCode).Append("\n");
            sb.Append("  SystemDefault: ").Append(SystemDefault).Append("\n");
            sb.Append("  TotalRate: ").Append(TotalRate).Append("\n");
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
            return this.Equals(input as TsiWebSalesTaxCode);
        }

        /// <summary>
        /// Returns true if TsiWebSalesTaxCode instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebSalesTaxCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebSalesTaxCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CustomerTaxCode == input.CustomerTaxCode ||
                    (this.CustomerTaxCode != null &&
                    this.CustomerTaxCode.Equals(input.CustomerTaxCode))
                ) && 
                (
                    this.ItemFullyTaxableCode == input.ItemFullyTaxableCode ||
                    (this.ItemFullyTaxableCode != null &&
                    this.ItemFullyTaxableCode.Equals(input.ItemFullyTaxableCode))
                ) && 
                (
                    this.ItemProvincialOnlyCode == input.ItemProvincialOnlyCode ||
                    (this.ItemProvincialOnlyCode != null &&
                    this.ItemProvincialOnlyCode.Equals(input.ItemProvincialOnlyCode))
                ) && 
                (
                    this.ItemGSTOnlyCode == input.ItemGSTOnlyCode ||
                    (this.ItemGSTOnlyCode != null &&
                    this.ItemGSTOnlyCode.Equals(input.ItemGSTOnlyCode))
                ) && 
                (
                    this.ItemExemptCode == input.ItemExemptCode ||
                    (this.ItemExemptCode != null &&
                    this.ItemExemptCode.Equals(input.ItemExemptCode))
                ) && 
                (
                    this.HasTieredDistrict == input.HasTieredDistrict ||
                    (this.HasTieredDistrict != null &&
                    this.HasTieredDistrict.Equals(input.HasTieredDistrict))
                ) && 
                (
                    this.TaxGST == input.TaxGST ||
                    (this.TaxGST != null &&
                    this.TaxGST.Equals(input.TaxGST))
                ) && 
                (
                    this.IsHarmonizedTaxCode == input.IsHarmonizedTaxCode ||
                    (this.IsHarmonizedTaxCode != null &&
                    this.IsHarmonizedTaxCode.Equals(input.IsHarmonizedTaxCode))
                ) && 
                (
                    this.SystemDefault == input.SystemDefault ||
                    (this.SystemDefault != null &&
                    this.SystemDefault.Equals(input.SystemDefault))
                ) && 
                (
                    this.TotalRate == input.TotalRate ||
                    (this.TotalRate != null &&
                    this.TotalRate.Equals(input.TotalRate))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomerTaxCode != null)
                    hashCode = hashCode * 59 + this.CustomerTaxCode.GetHashCode();
                if (this.ItemFullyTaxableCode != null)
                    hashCode = hashCode * 59 + this.ItemFullyTaxableCode.GetHashCode();
                if (this.ItemProvincialOnlyCode != null)
                    hashCode = hashCode * 59 + this.ItemProvincialOnlyCode.GetHashCode();
                if (this.ItemGSTOnlyCode != null)
                    hashCode = hashCode * 59 + this.ItemGSTOnlyCode.GetHashCode();
                if (this.ItemExemptCode != null)
                    hashCode = hashCode * 59 + this.ItemExemptCode.GetHashCode();
                if (this.HasTieredDistrict != null)
                    hashCode = hashCode * 59 + this.HasTieredDistrict.GetHashCode();
                if (this.TaxGST != null)
                    hashCode = hashCode * 59 + this.TaxGST.GetHashCode();
                if (this.IsHarmonizedTaxCode != null)
                    hashCode = hashCode * 59 + this.IsHarmonizedTaxCode.GetHashCode();
                if (this.SystemDefault != null)
                    hashCode = hashCode * 59 + this.SystemDefault.GetHashCode();
                if (this.TotalRate != null)
                    hashCode = hashCode * 59 + this.TotalRate.GetHashCode();
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