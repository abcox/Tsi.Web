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
    /// TsiWebPuchaseOrderVendorItem
    /// </summary>
    [DataContract]
    public partial class TsiWebPuchaseOrderVendorItem :  IEquatable<TsiWebPuchaseOrderVendorItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebPuchaseOrderVendorItem" /> class.
        /// </summary>
        /// <param name="vendorAccountNumber">vendorAccountNumber.</param>
        /// <param name="items">items.</param>
        public TsiWebPuchaseOrderVendorItem(int? vendorAccountNumber = default(int?), List<TsiWebVendorItem> items = default(List<TsiWebVendorItem>))
        {
            this.VendorAccountNumber = vendorAccountNumber;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets VendorAccountNumber
        /// </summary>
        [DataMember(Name="VendorAccountNumber", EmitDefaultValue=false)]
        public int? VendorAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<TsiWebVendorItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebPuchaseOrderVendorItem {\n");
            sb.Append("  VendorAccountNumber: ").Append(VendorAccountNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as TsiWebPuchaseOrderVendorItem);
        }

        /// <summary>
        /// Returns true if TsiWebPuchaseOrderVendorItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebPuchaseOrderVendorItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebPuchaseOrderVendorItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorAccountNumber == input.VendorAccountNumber ||
                    (this.VendorAccountNumber != null &&
                    this.VendorAccountNumber.Equals(input.VendorAccountNumber))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.VendorAccountNumber != null)
                    hashCode = hashCode * 59 + this.VendorAccountNumber.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
