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
    /// TsiWebTaskCheckListTemplateItem
    /// </summary>
    [DataContract]
    public partial class TsiWebTaskCheckListTemplateItem :  IEquatable<TsiWebTaskCheckListTemplateItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebTaskCheckListTemplateItem" /> class.
        /// </summary>
        /// <param name="itemText">itemText.</param>
        /// <param name="ordinalPosition">ordinalPosition.</param>
        public TsiWebTaskCheckListTemplateItem(string itemText = default(string), int? ordinalPosition = default(int?))
        {
            this.ItemText = itemText;
            this.OrdinalPosition = ordinalPosition;
        }
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebTaskCheckListTemplateItem {\n");
            sb.Append("  ItemText: ").Append(ItemText).Append("\n");
            sb.Append("  OrdinalPosition: ").Append(OrdinalPosition).Append("\n");
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
            return this.Equals(input as TsiWebTaskCheckListTemplateItem);
        }

        /// <summary>
        /// Returns true if TsiWebTaskCheckListTemplateItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebTaskCheckListTemplateItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebTaskCheckListTemplateItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemText == input.ItemText ||
                    (this.ItemText != null &&
                    this.ItemText.Equals(input.ItemText))
                ) && 
                (
                    this.OrdinalPosition == input.OrdinalPosition ||
                    (this.OrdinalPosition != null &&
                    this.OrdinalPosition.Equals(input.OrdinalPosition))
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
                if (this.ItemText != null)
                    hashCode = hashCode * 59 + this.ItemText.GetHashCode();
                if (this.OrdinalPosition != null)
                    hashCode = hashCode * 59 + this.OrdinalPosition.GetHashCode();
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
