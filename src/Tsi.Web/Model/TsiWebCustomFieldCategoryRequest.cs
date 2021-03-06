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
    /// TsiWebCustomFieldCategoryRequest
    /// </summary>
    [DataContract]
    public partial class TsiWebCustomFieldCategoryRequest :  IEquatable<TsiWebCustomFieldCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCustomFieldCategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebCustomFieldCategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCustomFieldCategoryRequest" /> class.
        /// </summary>
        /// <param name="categoryName">categoryName (required).</param>
        /// <param name="availableInGui">availableInGui.</param>
        /// <param name="previousCategoryName">previousCategoryName.</param>
        public TsiWebCustomFieldCategoryRequest(string categoryName = default(string), bool? availableInGui = default(bool?), string previousCategoryName = default(string))
        {
            // to ensure "categoryName" is required (not null)
            if (categoryName == null)
            {
                throw new InvalidDataException("categoryName is a required property for TsiWebCustomFieldCategoryRequest and cannot be null");
            }
            else
            {
                this.CategoryName = categoryName;
            }
            this.AvailableInGui = availableInGui;
            this.PreviousCategoryName = previousCategoryName;
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
        /// Gets or Sets PreviousCategoryName
        /// </summary>
        [DataMember(Name="PreviousCategoryName", EmitDefaultValue=false)]
        public string PreviousCategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCustomFieldCategoryRequest {\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  AvailableInGui: ").Append(AvailableInGui).Append("\n");
            sb.Append("  PreviousCategoryName: ").Append(PreviousCategoryName).Append("\n");
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
            return this.Equals(input as TsiWebCustomFieldCategoryRequest);
        }

        /// <summary>
        /// Returns true if TsiWebCustomFieldCategoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCustomFieldCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCustomFieldCategoryRequest input)
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
                    this.PreviousCategoryName == input.PreviousCategoryName ||
                    (this.PreviousCategoryName != null &&
                    this.PreviousCategoryName.Equals(input.PreviousCategoryName))
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
                if (this.PreviousCategoryName != null)
                    hashCode = hashCode * 59 + this.PreviousCategoryName.GetHashCode();
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
