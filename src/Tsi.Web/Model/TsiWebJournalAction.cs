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
    /// TsiWebJournalAction
    /// </summary>
    [DataContract]
    public partial class TsiWebJournalAction :  IEquatable<TsiWebJournalAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebJournalAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebJournalAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebJournalAction" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="isSystemEntry">isSystemEntry.</param>
        /// <param name="weight">weight.</param>
        public TsiWebJournalAction(string action = default(string), bool? isSystemEntry = default(bool?), int? weight = default(int?))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for TsiWebJournalAction and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            this.IsSystemEntry = isSystemEntry;
            this.Weight = weight;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemEntry
        /// </summary>
        [DataMember(Name="IsSystemEntry", EmitDefaultValue=false)]
        public bool? IsSystemEntry { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="Weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebJournalAction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  IsSystemEntry: ").Append(IsSystemEntry).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as TsiWebJournalAction);
        }

        /// <summary>
        /// Returns true if TsiWebJournalAction instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebJournalAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebJournalAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.IsSystemEntry == input.IsSystemEntry ||
                    (this.IsSystemEntry != null &&
                    this.IsSystemEntry.Equals(input.IsSystemEntry))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.IsSystemEntry != null)
                    hashCode = hashCode * 59 + this.IsSystemEntry.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
