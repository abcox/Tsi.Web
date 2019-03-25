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
    /// TsiWebCustomFieldSearchModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCustomFieldSearchModel :  IEquatable<TsiWebCustomFieldSearchModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCustomFieldSearchModel" /> class.
        /// </summary>
        /// <param name="criteria">criteria.</param>
        /// <param name="category">category.</param>
        /// <param name="field">field.</param>
        public TsiWebCustomFieldSearchModel(string criteria = default(string), string category = default(string), string field = default(string))
        {
            this.Criteria = criteria;
            this.Category = category;
            this.Field = field;
        }
        
        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name="Criteria", EmitDefaultValue=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="Field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCustomFieldSearchModel {\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as TsiWebCustomFieldSearchModel);
        }

        /// <summary>
        /// Returns true if TsiWebCustomFieldSearchModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCustomFieldSearchModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCustomFieldSearchModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Criteria == input.Criteria ||
                    (this.Criteria != null &&
                    this.Criteria.Equals(input.Criteria))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.Criteria != null)
                    hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
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