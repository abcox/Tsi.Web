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
    /// TsiWebPriceLevel
    /// </summary>
    [DataContract]
    public partial class TsiWebPriceLevel :  IEquatable<TsiWebPriceLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebPriceLevel" /> class.
        /// </summary>
        /// <param name="priceLevelId">priceLevelId.</param>
        /// <param name="priceLevelCategoryId">priceLevelCategoryId.</param>
        /// <param name="priceLevelCategory">priceLevelCategory.</param>
        /// <param name="description">description.</param>
        /// <param name="incomeGeneralLedgerCode">incomeGeneralLedgerCode.</param>
        /// <param name="costGeneralLedgerCode">costGeneralLedgerCode.</param>
        /// <param name="markUp">markUp.</param>
        /// <param name="markDown">markDown.</param>
        /// <param name="margin">margin.</param>
        /// <param name="isRepairLevel">isRepairLevel.</param>
        /// <param name="applyQuantityDiscounts">applyQuantityDiscounts.</param>
        /// <param name="priceBasis">priceBasis.</param>
        /// <param name="costToUse">costToUse.</param>
        public TsiWebPriceLevel(int? priceLevelId = default(int?), int? priceLevelCategoryId = default(int?), string priceLevelCategory = default(string), string description = default(string), string incomeGeneralLedgerCode = default(string), string costGeneralLedgerCode = default(string), double? markUp = default(double?), double? markDown = default(double?), double? margin = default(double?), bool? isRepairLevel = default(bool?), bool? applyQuantityDiscounts = default(bool?), int? priceBasis = default(int?), int? costToUse = default(int?))
        {
            this.PriceLevelId = priceLevelId;
            this.PriceLevelCategoryId = priceLevelCategoryId;
            this.PriceLevelCategory = priceLevelCategory;
            this.Description = description;
            this.IncomeGeneralLedgerCode = incomeGeneralLedgerCode;
            this.CostGeneralLedgerCode = costGeneralLedgerCode;
            this.MarkUp = markUp;
            this.MarkDown = markDown;
            this.Margin = margin;
            this.IsRepairLevel = isRepairLevel;
            this.ApplyQuantityDiscounts = applyQuantityDiscounts;
            this.PriceBasis = priceBasis;
            this.CostToUse = costToUse;
        }
        
        /// <summary>
        /// Gets or Sets PriceLevelId
        /// </summary>
        [DataMember(Name="PriceLevelId", EmitDefaultValue=false)]
        public int? PriceLevelId { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevelCategoryId
        /// </summary>
        [DataMember(Name="PriceLevelCategoryId", EmitDefaultValue=false)]
        public int? PriceLevelCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevelCategory
        /// </summary>
        [DataMember(Name="PriceLevelCategory", EmitDefaultValue=false)]
        public string PriceLevelCategory { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IncomeGeneralLedgerCode
        /// </summary>
        [DataMember(Name="IncomeGeneralLedgerCode", EmitDefaultValue=false)]
        public string IncomeGeneralLedgerCode { get; set; }

        /// <summary>
        /// Gets or Sets CostGeneralLedgerCode
        /// </summary>
        [DataMember(Name="CostGeneralLedgerCode", EmitDefaultValue=false)]
        public string CostGeneralLedgerCode { get; set; }

        /// <summary>
        /// Gets or Sets MarkUp
        /// </summary>
        [DataMember(Name="MarkUp", EmitDefaultValue=false)]
        public double? MarkUp { get; set; }

        /// <summary>
        /// Gets or Sets MarkDown
        /// </summary>
        [DataMember(Name="MarkDown", EmitDefaultValue=false)]
        public double? MarkDown { get; set; }

        /// <summary>
        /// Gets or Sets Margin
        /// </summary>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public double? Margin { get; set; }

        /// <summary>
        /// Gets or Sets IsRepairLevel
        /// </summary>
        [DataMember(Name="IsRepairLevel", EmitDefaultValue=false)]
        public bool? IsRepairLevel { get; set; }

        /// <summary>
        /// Gets or Sets ApplyQuantityDiscounts
        /// </summary>
        [DataMember(Name="ApplyQuantityDiscounts", EmitDefaultValue=false)]
        public bool? ApplyQuantityDiscounts { get; set; }

        /// <summary>
        /// Gets or Sets PriceBasis
        /// </summary>
        [DataMember(Name="PriceBasis", EmitDefaultValue=false)]
        public int? PriceBasis { get; set; }

        /// <summary>
        /// Gets or Sets CostToUse
        /// </summary>
        [DataMember(Name="CostToUse", EmitDefaultValue=false)]
        public int? CostToUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebPriceLevel {\n");
            sb.Append("  PriceLevelId: ").Append(PriceLevelId).Append("\n");
            sb.Append("  PriceLevelCategoryId: ").Append(PriceLevelCategoryId).Append("\n");
            sb.Append("  PriceLevelCategory: ").Append(PriceLevelCategory).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IncomeGeneralLedgerCode: ").Append(IncomeGeneralLedgerCode).Append("\n");
            sb.Append("  CostGeneralLedgerCode: ").Append(CostGeneralLedgerCode).Append("\n");
            sb.Append("  MarkUp: ").Append(MarkUp).Append("\n");
            sb.Append("  MarkDown: ").Append(MarkDown).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  IsRepairLevel: ").Append(IsRepairLevel).Append("\n");
            sb.Append("  ApplyQuantityDiscounts: ").Append(ApplyQuantityDiscounts).Append("\n");
            sb.Append("  PriceBasis: ").Append(PriceBasis).Append("\n");
            sb.Append("  CostToUse: ").Append(CostToUse).Append("\n");
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
            return this.Equals(input as TsiWebPriceLevel);
        }

        /// <summary>
        /// Returns true if TsiWebPriceLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebPriceLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebPriceLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriceLevelId == input.PriceLevelId ||
                    (this.PriceLevelId != null &&
                    this.PriceLevelId.Equals(input.PriceLevelId))
                ) && 
                (
                    this.PriceLevelCategoryId == input.PriceLevelCategoryId ||
                    (this.PriceLevelCategoryId != null &&
                    this.PriceLevelCategoryId.Equals(input.PriceLevelCategoryId))
                ) && 
                (
                    this.PriceLevelCategory == input.PriceLevelCategory ||
                    (this.PriceLevelCategory != null &&
                    this.PriceLevelCategory.Equals(input.PriceLevelCategory))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IncomeGeneralLedgerCode == input.IncomeGeneralLedgerCode ||
                    (this.IncomeGeneralLedgerCode != null &&
                    this.IncomeGeneralLedgerCode.Equals(input.IncomeGeneralLedgerCode))
                ) && 
                (
                    this.CostGeneralLedgerCode == input.CostGeneralLedgerCode ||
                    (this.CostGeneralLedgerCode != null &&
                    this.CostGeneralLedgerCode.Equals(input.CostGeneralLedgerCode))
                ) && 
                (
                    this.MarkUp == input.MarkUp ||
                    (this.MarkUp != null &&
                    this.MarkUp.Equals(input.MarkUp))
                ) && 
                (
                    this.MarkDown == input.MarkDown ||
                    (this.MarkDown != null &&
                    this.MarkDown.Equals(input.MarkDown))
                ) && 
                (
                    this.Margin == input.Margin ||
                    (this.Margin != null &&
                    this.Margin.Equals(input.Margin))
                ) && 
                (
                    this.IsRepairLevel == input.IsRepairLevel ||
                    (this.IsRepairLevel != null &&
                    this.IsRepairLevel.Equals(input.IsRepairLevel))
                ) && 
                (
                    this.ApplyQuantityDiscounts == input.ApplyQuantityDiscounts ||
                    (this.ApplyQuantityDiscounts != null &&
                    this.ApplyQuantityDiscounts.Equals(input.ApplyQuantityDiscounts))
                ) && 
                (
                    this.PriceBasis == input.PriceBasis ||
                    (this.PriceBasis != null &&
                    this.PriceBasis.Equals(input.PriceBasis))
                ) && 
                (
                    this.CostToUse == input.CostToUse ||
                    (this.CostToUse != null &&
                    this.CostToUse.Equals(input.CostToUse))
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
                if (this.PriceLevelId != null)
                    hashCode = hashCode * 59 + this.PriceLevelId.GetHashCode();
                if (this.PriceLevelCategoryId != null)
                    hashCode = hashCode * 59 + this.PriceLevelCategoryId.GetHashCode();
                if (this.PriceLevelCategory != null)
                    hashCode = hashCode * 59 + this.PriceLevelCategory.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IncomeGeneralLedgerCode != null)
                    hashCode = hashCode * 59 + this.IncomeGeneralLedgerCode.GetHashCode();
                if (this.CostGeneralLedgerCode != null)
                    hashCode = hashCode * 59 + this.CostGeneralLedgerCode.GetHashCode();
                if (this.MarkUp != null)
                    hashCode = hashCode * 59 + this.MarkUp.GetHashCode();
                if (this.MarkDown != null)
                    hashCode = hashCode * 59 + this.MarkDown.GetHashCode();
                if (this.Margin != null)
                    hashCode = hashCode * 59 + this.Margin.GetHashCode();
                if (this.IsRepairLevel != null)
                    hashCode = hashCode * 59 + this.IsRepairLevel.GetHashCode();
                if (this.ApplyQuantityDiscounts != null)
                    hashCode = hashCode * 59 + this.ApplyQuantityDiscounts.GetHashCode();
                if (this.PriceBasis != null)
                    hashCode = hashCode * 59 + this.PriceBasis.GetHashCode();
                if (this.CostToUse != null)
                    hashCode = hashCode * 59 + this.CostToUse.GetHashCode();
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
