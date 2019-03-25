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
    /// TsiWebConvertTimeLogsToLaborItemModel
    /// </summary>
    [DataContract]
    public partial class TsiWebConvertTimeLogsToLaborItemModel :  IEquatable<TsiWebConvertTimeLogsToLaborItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebConvertTimeLogsToLaborItemModel" /> class.
        /// </summary>
        /// <param name="timeLogs">timeLogs.</param>
        /// <param name="laborItemType">laborItemType.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="priceBookItemNumber">priceBookItemNumber.</param>
        /// <param name="canConvertNonBillableTimeLogs">canConvertNonBillableTimeLogs.</param>
        /// <param name="canCombineLogsWithDifferentLaborRatesOrRateBasis">canCombineLogsWithDifferentLaborRatesOrRateBasis.</param>
        public TsiWebConvertTimeLogsToLaborItemModel(List<int?> timeLogs = default(List<int?>), string laborItemType = default(string), string itemId = default(string), int? priceBookItemNumber = default(int?), bool? canConvertNonBillableTimeLogs = default(bool?), bool? canCombineLogsWithDifferentLaborRatesOrRateBasis = default(bool?))
        {
            this.TimeLogs = timeLogs;
            this.LaborItemType = laborItemType;
            this.ItemId = itemId;
            this.PriceBookItemNumber = priceBookItemNumber;
            this.CanConvertNonBillableTimeLogs = canConvertNonBillableTimeLogs;
            this.CanCombineLogsWithDifferentLaborRatesOrRateBasis = canCombineLogsWithDifferentLaborRatesOrRateBasis;
        }
        
        /// <summary>
        /// Gets or Sets TimeLogs
        /// </summary>
        [DataMember(Name="TimeLogs", EmitDefaultValue=false)]
        public List<int?> TimeLogs { get; set; }

        /// <summary>
        /// Gets or Sets LaborItemType
        /// </summary>
        [DataMember(Name="LaborItemType", EmitDefaultValue=false)]
        public string LaborItemType { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets PriceBookItemNumber
        /// </summary>
        [DataMember(Name="PriceBookItemNumber", EmitDefaultValue=false)]
        public int? PriceBookItemNumber { get; set; }

        /// <summary>
        /// Gets or Sets CanConvertNonBillableTimeLogs
        /// </summary>
        [DataMember(Name="CanConvertNonBillableTimeLogs", EmitDefaultValue=false)]
        public bool? CanConvertNonBillableTimeLogs { get; set; }

        /// <summary>
        /// Gets or Sets CanCombineLogsWithDifferentLaborRatesOrRateBasis
        /// </summary>
        [DataMember(Name="CanCombineLogsWithDifferentLaborRatesOrRateBasis", EmitDefaultValue=false)]
        public bool? CanCombineLogsWithDifferentLaborRatesOrRateBasis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebConvertTimeLogsToLaborItemModel {\n");
            sb.Append("  TimeLogs: ").Append(TimeLogs).Append("\n");
            sb.Append("  LaborItemType: ").Append(LaborItemType).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PriceBookItemNumber: ").Append(PriceBookItemNumber).Append("\n");
            sb.Append("  CanConvertNonBillableTimeLogs: ").Append(CanConvertNonBillableTimeLogs).Append("\n");
            sb.Append("  CanCombineLogsWithDifferentLaborRatesOrRateBasis: ").Append(CanCombineLogsWithDifferentLaborRatesOrRateBasis).Append("\n");
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
            return this.Equals(input as TsiWebConvertTimeLogsToLaborItemModel);
        }

        /// <summary>
        /// Returns true if TsiWebConvertTimeLogsToLaborItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebConvertTimeLogsToLaborItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebConvertTimeLogsToLaborItemModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeLogs == input.TimeLogs ||
                    this.TimeLogs != null &&
                    this.TimeLogs.SequenceEqual(input.TimeLogs)
                ) && 
                (
                    this.LaborItemType == input.LaborItemType ||
                    (this.LaborItemType != null &&
                    this.LaborItemType.Equals(input.LaborItemType))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.PriceBookItemNumber == input.PriceBookItemNumber ||
                    (this.PriceBookItemNumber != null &&
                    this.PriceBookItemNumber.Equals(input.PriceBookItemNumber))
                ) && 
                (
                    this.CanConvertNonBillableTimeLogs == input.CanConvertNonBillableTimeLogs ||
                    (this.CanConvertNonBillableTimeLogs != null &&
                    this.CanConvertNonBillableTimeLogs.Equals(input.CanConvertNonBillableTimeLogs))
                ) && 
                (
                    this.CanCombineLogsWithDifferentLaborRatesOrRateBasis == input.CanCombineLogsWithDifferentLaborRatesOrRateBasis ||
                    (this.CanCombineLogsWithDifferentLaborRatesOrRateBasis != null &&
                    this.CanCombineLogsWithDifferentLaborRatesOrRateBasis.Equals(input.CanCombineLogsWithDifferentLaborRatesOrRateBasis))
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
                if (this.TimeLogs != null)
                    hashCode = hashCode * 59 + this.TimeLogs.GetHashCode();
                if (this.LaborItemType != null)
                    hashCode = hashCode * 59 + this.LaborItemType.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.PriceBookItemNumber != null)
                    hashCode = hashCode * 59 + this.PriceBookItemNumber.GetHashCode();
                if (this.CanConvertNonBillableTimeLogs != null)
                    hashCode = hashCode * 59 + this.CanConvertNonBillableTimeLogs.GetHashCode();
                if (this.CanCombineLogsWithDifferentLaborRatesOrRateBasis != null)
                    hashCode = hashCode * 59 + this.CanCombineLogsWithDifferentLaborRatesOrRateBasis.GetHashCode();
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
