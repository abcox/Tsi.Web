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
    /// TsiWebShipTo
    /// </summary>
    [DataContract]
    public partial class TsiWebShipTo :  IEquatable<TsiWebShipTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebShipTo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebShipTo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebShipTo" /> class.
        /// </summary>
        /// <param name="shipToId">shipToId.</param>
        /// <param name="directionsToLocation">directionsToLocation.</param>
        /// <param name="salesTaxCode">salesTaxCode (required).</param>
        /// <param name="isPrimary">isPrimary.</param>
        /// <param name="name">name.</param>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="country">country.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactPhone">contactPhone.</param>
        public TsiWebShipTo(int? shipToId = default(int?), string directionsToLocation = default(string), string salesTaxCode = default(string), bool? isPrimary = default(bool?), string name = default(string), string address1 = default(string), string address2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string country = default(string), string contactName = default(string), string contactPhone = default(string))
        {
            // to ensure "salesTaxCode" is required (not null)
            if (salesTaxCode == null)
            {
                throw new InvalidDataException("salesTaxCode is a required property for TsiWebShipTo and cannot be null");
            }
            else
            {
                this.SalesTaxCode = salesTaxCode;
            }
            this.ShipToId = shipToId;
            this.DirectionsToLocation = directionsToLocation;
            this.IsPrimary = isPrimary;
            this.Name = name;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
        }
        
        /// <summary>
        /// Gets or Sets ShipToId
        /// </summary>
        [DataMember(Name="ShipToId", EmitDefaultValue=false)]
        public int? ShipToId { get; set; }

        /// <summary>
        /// Gets or Sets DirectionsToLocation
        /// </summary>
        [DataMember(Name="DirectionsToLocation", EmitDefaultValue=false)]
        public string DirectionsToLocation { get; set; }

        /// <summary>
        /// Gets or Sets SalesTaxCode
        /// </summary>
        [DataMember(Name="SalesTaxCode", EmitDefaultValue=false)]
        public string SalesTaxCode { get; set; }

        /// <summary>
        /// Gets or Sets IsPrimary
        /// </summary>
        [DataMember(Name="IsPrimary", EmitDefaultValue=false)]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="Address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="Address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="ContactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name="ContactPhone", EmitDefaultValue=false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebShipTo {\n");
            sb.Append("  ShipToId: ").Append(ShipToId).Append("\n");
            sb.Append("  DirectionsToLocation: ").Append(DirectionsToLocation).Append("\n");
            sb.Append("  SalesTaxCode: ").Append(SalesTaxCode).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
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
            return this.Equals(input as TsiWebShipTo);
        }

        /// <summary>
        /// Returns true if TsiWebShipTo instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebShipTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebShipTo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShipToId == input.ShipToId ||
                    (this.ShipToId != null &&
                    this.ShipToId.Equals(input.ShipToId))
                ) && 
                (
                    this.DirectionsToLocation == input.DirectionsToLocation ||
                    (this.DirectionsToLocation != null &&
                    this.DirectionsToLocation.Equals(input.DirectionsToLocation))
                ) && 
                (
                    this.SalesTaxCode == input.SalesTaxCode ||
                    (this.SalesTaxCode != null &&
                    this.SalesTaxCode.Equals(input.SalesTaxCode))
                ) && 
                (
                    this.IsPrimary == input.IsPrimary ||
                    (this.IsPrimary != null &&
                    this.IsPrimary.Equals(input.IsPrimary))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactPhone == input.ContactPhone ||
                    (this.ContactPhone != null &&
                    this.ContactPhone.Equals(input.ContactPhone))
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
                if (this.ShipToId != null)
                    hashCode = hashCode * 59 + this.ShipToId.GetHashCode();
                if (this.DirectionsToLocation != null)
                    hashCode = hashCode * 59 + this.DirectionsToLocation.GetHashCode();
                if (this.SalesTaxCode != null)
                    hashCode = hashCode * 59 + this.SalesTaxCode.GetHashCode();
                if (this.IsPrimary != null)
                    hashCode = hashCode * 59 + this.IsPrimary.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.ContactPhone != null)
                    hashCode = hashCode * 59 + this.ContactPhone.GetHashCode();
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
