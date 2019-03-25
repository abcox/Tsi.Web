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
    /// TsiWebRepModel
    /// </summary>
    [DataContract]
    public partial class TsiWebRepModel :  IEquatable<TsiWebRepModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebRepModel" /> class.
        /// </summary>
        /// <param name="scheduledFor">scheduledFor.</param>
        /// <param name="scheduledBy">scheduledBy.</param>
        public TsiWebRepModel(bool? scheduledFor = default(bool?), bool? scheduledBy = default(bool?))
        {
            this.ScheduledFor = scheduledFor;
            this.ScheduledBy = scheduledBy;
        }
        
        /// <summary>
        /// Gets or Sets ScheduledFor
        /// </summary>
        [DataMember(Name="ScheduledFor", EmitDefaultValue=false)]
        public bool? ScheduledFor { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledBy
        /// </summary>
        [DataMember(Name="ScheduledBy", EmitDefaultValue=false)]
        public bool? ScheduledBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebRepModel {\n");
            sb.Append("  ScheduledFor: ").Append(ScheduledFor).Append("\n");
            sb.Append("  ScheduledBy: ").Append(ScheduledBy).Append("\n");
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
            return this.Equals(input as TsiWebRepModel);
        }

        /// <summary>
        /// Returns true if TsiWebRepModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebRepModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebRepModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduledFor == input.ScheduledFor ||
                    (this.ScheduledFor != null &&
                    this.ScheduledFor.Equals(input.ScheduledFor))
                ) && 
                (
                    this.ScheduledBy == input.ScheduledBy ||
                    (this.ScheduledBy != null &&
                    this.ScheduledBy.Equals(input.ScheduledBy))
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
                if (this.ScheduledFor != null)
                    hashCode = hashCode * 59 + this.ScheduledFor.GetHashCode();
                if (this.ScheduledBy != null)
                    hashCode = hashCode * 59 + this.ScheduledBy.GetHashCode();
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
