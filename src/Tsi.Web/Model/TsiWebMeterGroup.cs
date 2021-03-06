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
    /// TsiWebMeterGroup
    /// </summary>
    [DataContract]
    public partial class TsiWebMeterGroup :  IEquatable<TsiWebMeterGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebMeterGroup" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="value">value.</param>
        /// <param name="isSystemEntry">isSystemEntry.</param>
        /// <param name="isSystemDefault">isSystemDefault.</param>
        public TsiWebMeterGroup(int? id = default(int?), string value = default(string), bool? isSystemEntry = default(bool?), bool? isSystemDefault = default(bool?))
        {
            this.Id = id;
            this.Value = value;
            this.IsSystemEntry = isSystemEntry;
            this.IsSystemDefault = isSystemDefault;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemEntry
        /// </summary>
        [DataMember(Name="IsSystemEntry", EmitDefaultValue=false)]
        public bool? IsSystemEntry { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemDefault
        /// </summary>
        [DataMember(Name="IsSystemDefault", EmitDefaultValue=false)]
        public bool? IsSystemDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebMeterGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IsSystemEntry: ").Append(IsSystemEntry).Append("\n");
            sb.Append("  IsSystemDefault: ").Append(IsSystemDefault).Append("\n");
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
            return this.Equals(input as TsiWebMeterGroup);
        }

        /// <summary>
        /// Returns true if TsiWebMeterGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebMeterGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebMeterGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IsSystemEntry == input.IsSystemEntry ||
                    (this.IsSystemEntry != null &&
                    this.IsSystemEntry.Equals(input.IsSystemEntry))
                ) && 
                (
                    this.IsSystemDefault == input.IsSystemDefault ||
                    (this.IsSystemDefault != null &&
                    this.IsSystemDefault.Equals(input.IsSystemDefault))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.IsSystemEntry != null)
                    hashCode = hashCode * 59 + this.IsSystemEntry.GetHashCode();
                if (this.IsSystemDefault != null)
                    hashCode = hashCode * 59 + this.IsSystemDefault.GetHashCode();
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
