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
    /// TsiWebCustomFieldCategory
    /// </summary>
    [DataContract]
    public partial class TsiWebCustomFieldCategory :  IEquatable<TsiWebCustomFieldCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCustomFieldCategory" /> class.
        /// </summary>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="availableInGui">availableInGui.</param>
        /// <param name="systemEntry">systemEntry.</param>
        /// <param name="fields">fields.</param>
        public TsiWebCustomFieldCategory(string categoryName = default(string), bool? availableInGui = default(bool?), bool? systemEntry = default(bool?), List<TsiWebCustomFieldDefinition> fields = default(List<TsiWebCustomFieldDefinition>))
        {
            this.CategoryName = categoryName;
            this.AvailableInGui = availableInGui;
            this.SystemEntry = systemEntry;
            this.Fields = fields;
        }
        
        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="CategoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets AvailableInGui
        /// </summary>
        [DataMember(Name="AvailableInGui", EmitDefaultValue=false)]
        public bool? AvailableInGui { get; set; }

        /// <summary>
        /// Gets or Sets SystemEntry
        /// </summary>
        [DataMember(Name="SystemEntry", EmitDefaultValue=false)]
        public bool? SystemEntry { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="Fields", EmitDefaultValue=false)]
        public List<TsiWebCustomFieldDefinition> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCustomFieldCategory {\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  AvailableInGui: ").Append(AvailableInGui).Append("\n");
            sb.Append("  SystemEntry: ").Append(SystemEntry).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as TsiWebCustomFieldCategory);
        }

        /// <summary>
        /// Returns true if TsiWebCustomFieldCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCustomFieldCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCustomFieldCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.AvailableInGui == input.AvailableInGui ||
                    (this.AvailableInGui != null &&
                    this.AvailableInGui.Equals(input.AvailableInGui))
                ) && 
                (
                    this.SystemEntry == input.SystemEntry ||
                    (this.SystemEntry != null &&
                    this.SystemEntry.Equals(input.SystemEntry))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.AvailableInGui != null)
                    hashCode = hashCode * 59 + this.AvailableInGui.GetHashCode();
                if (this.SystemEntry != null)
                    hashCode = hashCode * 59 + this.SystemEntry.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
