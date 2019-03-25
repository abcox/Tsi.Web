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
    /// TsiWebTaskChecklistItem
    /// </summary>
    [DataContract]
    public partial class TsiWebTaskChecklistItem :  IEquatable<TsiWebTaskChecklistItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebTaskChecklistItem" /> class.
        /// </summary>
        /// <param name="taskNumber">taskNumber.</param>
        /// <param name="taskCheckListNumber">taskCheckListNumber.</param>
        /// <param name="itemText">itemText.</param>
        /// <param name="ordinalPosition">ordinalPosition.</param>
        /// <param name="completed">completed.</param>
        public TsiWebTaskChecklistItem(int? taskNumber = default(int?), int? taskCheckListNumber = default(int?), string itemText = default(string), int? ordinalPosition = default(int?), bool? completed = default(bool?))
        {
            this.TaskNumber = taskNumber;
            this.TaskCheckListNumber = taskCheckListNumber;
            this.ItemText = itemText;
            this.OrdinalPosition = ordinalPosition;
            this.Completed = completed;
        }
        
        /// <summary>
        /// Gets or Sets TaskNumber
        /// </summary>
        [DataMember(Name="TaskNumber", EmitDefaultValue=false)]
        public int? TaskNumber { get; set; }

        /// <summary>
        /// Gets or Sets TaskCheckListNumber
        /// </summary>
        [DataMember(Name="TaskCheckListNumber", EmitDefaultValue=false)]
        public int? TaskCheckListNumber { get; set; }

        /// <summary>
        /// Gets or Sets ItemText
        /// </summary>
        [DataMember(Name="ItemText", EmitDefaultValue=false)]
        public string ItemText { get; set; }

        /// <summary>
        /// Gets or Sets OrdinalPosition
        /// </summary>
        [DataMember(Name="OrdinalPosition", EmitDefaultValue=false)]
        public int? OrdinalPosition { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="Completed", EmitDefaultValue=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebTaskChecklistItem {\n");
            sb.Append("  TaskNumber: ").Append(TaskNumber).Append("\n");
            sb.Append("  TaskCheckListNumber: ").Append(TaskCheckListNumber).Append("\n");
            sb.Append("  ItemText: ").Append(ItemText).Append("\n");
            sb.Append("  OrdinalPosition: ").Append(OrdinalPosition).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
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
            return this.Equals(input as TsiWebTaskChecklistItem);
        }

        /// <summary>
        /// Returns true if TsiWebTaskChecklistItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebTaskChecklistItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebTaskChecklistItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskNumber == input.TaskNumber ||
                    (this.TaskNumber != null &&
                    this.TaskNumber.Equals(input.TaskNumber))
                ) && 
                (
                    this.TaskCheckListNumber == input.TaskCheckListNumber ||
                    (this.TaskCheckListNumber != null &&
                    this.TaskCheckListNumber.Equals(input.TaskCheckListNumber))
                ) && 
                (
                    this.ItemText == input.ItemText ||
                    (this.ItemText != null &&
                    this.ItemText.Equals(input.ItemText))
                ) && 
                (
                    this.OrdinalPosition == input.OrdinalPosition ||
                    (this.OrdinalPosition != null &&
                    this.OrdinalPosition.Equals(input.OrdinalPosition))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
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
                if (this.TaskNumber != null)
                    hashCode = hashCode * 59 + this.TaskNumber.GetHashCode();
                if (this.TaskCheckListNumber != null)
                    hashCode = hashCode * 59 + this.TaskCheckListNumber.GetHashCode();
                if (this.ItemText != null)
                    hashCode = hashCode * 59 + this.ItemText.GetHashCode();
                if (this.OrdinalPosition != null)
                    hashCode = hashCode * 59 + this.OrdinalPosition.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
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