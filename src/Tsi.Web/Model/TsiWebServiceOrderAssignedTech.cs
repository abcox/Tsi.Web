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
    /// TsiWebServiceOrderAssignedTech
    /// </summary>
    [DataContract]
    public partial class TsiWebServiceOrderAssignedTech :  IEquatable<TsiWebServiceOrderAssignedTech>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebServiceOrderAssignedTech" /> class.
        /// </summary>
        /// <param name="serviceOrderAssignedTechNumber">serviceOrderAssignedTechNumber.</param>
        /// <param name="repNumber">repNumber.</param>
        /// <param name="repName">repName.</param>
        /// <param name="dateAssigned">dateAssigned.</param>
        /// <param name="primaryIndicator">primaryIndicator.</param>
        public TsiWebServiceOrderAssignedTech(int? serviceOrderAssignedTechNumber = default(int?), int? repNumber = default(int?), string repName = default(string), DateTime? dateAssigned = default(DateTime?), bool? primaryIndicator = default(bool?))
        {
            this.ServiceOrderAssignedTechNumber = serviceOrderAssignedTechNumber;
            this.RepNumber = repNumber;
            this.RepName = repName;
            this.DateAssigned = dateAssigned;
            this.PrimaryIndicator = primaryIndicator;
        }
        
        /// <summary>
        /// Gets or Sets ServiceOrderAssignedTechNumber
        /// </summary>
        [DataMember(Name="ServiceOrderAssignedTechNumber", EmitDefaultValue=false)]
        public int? ServiceOrderAssignedTechNumber { get; set; }

        /// <summary>
        /// Gets or Sets RepNumber
        /// </summary>
        [DataMember(Name="RepNumber", EmitDefaultValue=false)]
        public int? RepNumber { get; set; }

        /// <summary>
        /// Gets or Sets RepName
        /// </summary>
        [DataMember(Name="RepName", EmitDefaultValue=false)]
        public string RepName { get; set; }

        /// <summary>
        /// Gets or Sets DateAssigned
        /// </summary>
        [DataMember(Name="DateAssigned", EmitDefaultValue=false)]
        public DateTime? DateAssigned { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryIndicator
        /// </summary>
        [DataMember(Name="PrimaryIndicator", EmitDefaultValue=false)]
        public bool? PrimaryIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebServiceOrderAssignedTech {\n");
            sb.Append("  ServiceOrderAssignedTechNumber: ").Append(ServiceOrderAssignedTechNumber).Append("\n");
            sb.Append("  RepNumber: ").Append(RepNumber).Append("\n");
            sb.Append("  RepName: ").Append(RepName).Append("\n");
            sb.Append("  DateAssigned: ").Append(DateAssigned).Append("\n");
            sb.Append("  PrimaryIndicator: ").Append(PrimaryIndicator).Append("\n");
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
            return this.Equals(input as TsiWebServiceOrderAssignedTech);
        }

        /// <summary>
        /// Returns true if TsiWebServiceOrderAssignedTech instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebServiceOrderAssignedTech to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebServiceOrderAssignedTech input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceOrderAssignedTechNumber == input.ServiceOrderAssignedTechNumber ||
                    (this.ServiceOrderAssignedTechNumber != null &&
                    this.ServiceOrderAssignedTechNumber.Equals(input.ServiceOrderAssignedTechNumber))
                ) && 
                (
                    this.RepNumber == input.RepNumber ||
                    (this.RepNumber != null &&
                    this.RepNumber.Equals(input.RepNumber))
                ) && 
                (
                    this.RepName == input.RepName ||
                    (this.RepName != null &&
                    this.RepName.Equals(input.RepName))
                ) && 
                (
                    this.DateAssigned == input.DateAssigned ||
                    (this.DateAssigned != null &&
                    this.DateAssigned.Equals(input.DateAssigned))
                ) && 
                (
                    this.PrimaryIndicator == input.PrimaryIndicator ||
                    (this.PrimaryIndicator != null &&
                    this.PrimaryIndicator.Equals(input.PrimaryIndicator))
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
                if (this.ServiceOrderAssignedTechNumber != null)
                    hashCode = hashCode * 59 + this.ServiceOrderAssignedTechNumber.GetHashCode();
                if (this.RepNumber != null)
                    hashCode = hashCode * 59 + this.RepNumber.GetHashCode();
                if (this.RepName != null)
                    hashCode = hashCode * 59 + this.RepName.GetHashCode();
                if (this.DateAssigned != null)
                    hashCode = hashCode * 59 + this.DateAssigned.GetHashCode();
                if (this.PrimaryIndicator != null)
                    hashCode = hashCode * 59 + this.PrimaryIndicator.GetHashCode();
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
