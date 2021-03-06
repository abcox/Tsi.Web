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
    /// TsiWebOpportunityName
    /// </summary>
    [DataContract]
    public partial class TsiWebOpportunityName :  IEquatable<TsiWebOpportunityName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebOpportunityName" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="expectedAmount">expectedAmount.</param>
        public TsiWebOpportunityName(string name = default(string), double? expectedAmount = default(double?))
        {
            this.Name = name;
            this.ExpectedAmount = expectedAmount;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedAmount
        /// </summary>
        [DataMember(Name="ExpectedAmount", EmitDefaultValue=false)]
        public double? ExpectedAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebOpportunityName {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExpectedAmount: ").Append(ExpectedAmount).Append("\n");
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
            return this.Equals(input as TsiWebOpportunityName);
        }

        /// <summary>
        /// Returns true if TsiWebOpportunityName instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebOpportunityName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebOpportunityName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExpectedAmount == input.ExpectedAmount ||
                    (this.ExpectedAmount != null &&
                    this.ExpectedAmount.Equals(input.ExpectedAmount))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExpectedAmount != null)
                    hashCode = hashCode * 59 + this.ExpectedAmount.GetHashCode();
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
