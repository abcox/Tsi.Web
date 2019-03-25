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
    /// TsiWebShipper
    /// </summary>
    [DataContract]
    public partial class TsiWebShipper :  IEquatable<TsiWebShipper>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebShipper" /> class.
        /// </summary>
        /// <param name="shipperName">shipperName.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        public TsiWebShipper(string shipperName = default(string), string phoneNumber = default(string))
        {
            this.ShipperName = shipperName;
            this.PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// Gets or Sets ShipperName
        /// </summary>
        [DataMember(Name="ShipperName", EmitDefaultValue=false)]
        public string ShipperName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebShipper {\n");
            sb.Append("  ShipperName: ").Append(ShipperName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as TsiWebShipper);
        }

        /// <summary>
        /// Returns true if TsiWebShipper instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebShipper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebShipper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShipperName == input.ShipperName ||
                    (this.ShipperName != null &&
                    this.ShipperName.Equals(input.ShipperName))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.ShipperName != null)
                    hashCode = hashCode * 59 + this.ShipperName.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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