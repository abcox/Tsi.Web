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
    /// TsiWebLocationDetail
    /// </summary>
    [DataContract]
    public partial class TsiWebLocationDetail :  IEquatable<TsiWebLocationDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebLocationDetail" /> class.
        /// </summary>
        /// <param name="itemId">itemId.</param>
        /// <param name="location">location.</param>
        /// <param name="bin">bin.</param>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="reserved">reserved.</param>
        /// <param name="dateIn">dateIn.</param>
        /// <param name="dateOut">dateOut.</param>
        public TsiWebLocationDetail(string itemId = default(string), string location = default(string), string bin = default(string), int? min = default(int?), int? max = default(int?), int? quantity = default(int?), int? reserved = default(int?), DateTime? dateIn = default(DateTime?), DateTime? dateOut = default(DateTime?))
        {
            this.ItemId = itemId;
            this.Location = location;
            this.Bin = bin;
            this.Min = min;
            this.Max = max;
            this.Quantity = quantity;
            this.Reserved = reserved;
            this.DateIn = dateIn;
            this.DateOut = dateOut;
        }
        
        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Bin
        /// </summary>
        [DataMember(Name="Bin", EmitDefaultValue=false)]
        public string Bin { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="Min", EmitDefaultValue=false)]
        public int? Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="Max", EmitDefaultValue=false)]
        public int? Max { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Reserved
        /// </summary>
        [DataMember(Name="Reserved", EmitDefaultValue=false)]
        public int? Reserved { get; set; }

        /// <summary>
        /// Gets or Sets DateIn
        /// </summary>
        [DataMember(Name="DateIn", EmitDefaultValue=false)]
        public DateTime? DateIn { get; set; }

        /// <summary>
        /// Gets or Sets DateOut
        /// </summary>
        [DataMember(Name="DateOut", EmitDefaultValue=false)]
        public DateTime? DateOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebLocationDetail {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Reserved: ").Append(Reserved).Append("\n");
            sb.Append("  DateIn: ").Append(DateIn).Append("\n");
            sb.Append("  DateOut: ").Append(DateOut).Append("\n");
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
            return this.Equals(input as TsiWebLocationDetail);
        }

        /// <summary>
        /// Returns true if TsiWebLocationDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebLocationDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebLocationDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Bin == input.Bin ||
                    (this.Bin != null &&
                    this.Bin.Equals(input.Bin))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Reserved == input.Reserved ||
                    (this.Reserved != null &&
                    this.Reserved.Equals(input.Reserved))
                ) && 
                (
                    this.DateIn == input.DateIn ||
                    (this.DateIn != null &&
                    this.DateIn.Equals(input.DateIn))
                ) && 
                (
                    this.DateOut == input.DateOut ||
                    (this.DateOut != null &&
                    this.DateOut.Equals(input.DateOut))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Bin != null)
                    hashCode = hashCode * 59 + this.Bin.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Reserved != null)
                    hashCode = hashCode * 59 + this.Reserved.GetHashCode();
                if (this.DateIn != null)
                    hashCode = hashCode * 59 + this.DateIn.GetHashCode();
                if (this.DateOut != null)
                    hashCode = hashCode * 59 + this.DateOut.GetHashCode();
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
