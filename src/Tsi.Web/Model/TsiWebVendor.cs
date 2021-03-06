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
    /// TsiWebVendor
    /// </summary>
    [DataContract]
    public partial class TsiWebVendor :  IEquatable<TsiWebVendor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebVendor" /> class.
        /// </summary>
        /// <param name="vendorAccountNumber">vendorAccountNumber.</param>
        /// <param name="vendorAccountName">vendorAccountName.</param>
        /// <param name="ourCustomerNumber">ourCustomerNumber.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="internetID">internetID.</param>
        /// <param name="minimumOrderQuantity">minimumOrderQuantity.</param>
        /// <param name="minimumOrderAmount">minimumOrderAmount.</param>
        /// <param name="creditLimit">creditLimit.</param>
        /// <param name="discountPercent">discountPercent.</param>
        /// <param name="discountDays">discountDays.</param>
        /// <param name="netDays">netDays.</param>
        /// <param name="freightTerms">freightTerms.</param>
        /// <param name="shippingMethods">shippingMethods.</param>
        /// <param name="standingRMANumber">standingRMANumber.</param>
        /// <param name="rMAShipToAddressNumber">rMAShipToAddressNumber.</param>
        /// <param name="purchaseOrderLeadTime">purchaseOrderLeadTime.</param>
        /// <param name="aPVendorID">aPVendorID.</param>
        /// <param name="address">address.</param>
        /// <param name="uRL1">uRL1.</param>
        /// <param name="uRL1Description">uRL1Description.</param>
        /// <param name="uRL2">uRL2.</param>
        /// <param name="uRL2Description">uRL2Description.</param>
        /// <param name="primaryContact">primaryContact.</param>
        public TsiWebVendor(int? vendorAccountNumber = default(int?), string vendorAccountName = default(string), string ourCustomerNumber = default(string), string phoneNumber = default(string), string internetID = default(string), double? minimumOrderQuantity = default(double?), double? minimumOrderAmount = default(double?), double? creditLimit = default(double?), double? discountPercent = default(double?), int? discountDays = default(int?), int? netDays = default(int?), string freightTerms = default(string), string shippingMethods = default(string), string standingRMANumber = default(string), int? rMAShipToAddressNumber = default(int?), string purchaseOrderLeadTime = default(string), string aPVendorID = default(string), TsiWebAlternateAddress address = default(TsiWebAlternateAddress), string uRL1 = default(string), string uRL1Description = default(string), string uRL2 = default(string), string uRL2Description = default(string), TsiWebPerson primaryContact = default(TsiWebPerson))
        {
            this.VendorAccountNumber = vendorAccountNumber;
            this.VendorAccountName = vendorAccountName;
            this.OurCustomerNumber = ourCustomerNumber;
            this.PhoneNumber = phoneNumber;
            this.InternetID = internetID;
            this.MinimumOrderQuantity = minimumOrderQuantity;
            this.MinimumOrderAmount = minimumOrderAmount;
            this.CreditLimit = creditLimit;
            this.DiscountPercent = discountPercent;
            this.DiscountDays = discountDays;
            this.NetDays = netDays;
            this.FreightTerms = freightTerms;
            this.ShippingMethods = shippingMethods;
            this.StandingRMANumber = standingRMANumber;
            this.RMAShipToAddressNumber = rMAShipToAddressNumber;
            this.PurchaseOrderLeadTime = purchaseOrderLeadTime;
            this.APVendorID = aPVendorID;
            this.Address = address;
            this.URL1 = uRL1;
            this.URL1Description = uRL1Description;
            this.URL2 = uRL2;
            this.URL2Description = uRL2Description;
            this.PrimaryContact = primaryContact;
        }
        
        /// <summary>
        /// Gets or Sets VendorAccountNumber
        /// </summary>
        [DataMember(Name="VendorAccountNumber", EmitDefaultValue=false)]
        public int? VendorAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets VendorAccountName
        /// </summary>
        [DataMember(Name="VendorAccountName", EmitDefaultValue=false)]
        public string VendorAccountName { get; set; }

        /// <summary>
        /// Gets or Sets OurCustomerNumber
        /// </summary>
        [DataMember(Name="OurCustomerNumber", EmitDefaultValue=false)]
        public string OurCustomerNumber { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets InternetID
        /// </summary>
        [DataMember(Name="InternetID", EmitDefaultValue=false)]
        public string InternetID { get; set; }

        /// <summary>
        /// Gets or Sets MinimumOrderQuantity
        /// </summary>
        [DataMember(Name="MinimumOrderQuantity", EmitDefaultValue=false)]
        public double? MinimumOrderQuantity { get; set; }

        /// <summary>
        /// Gets or Sets MinimumOrderAmount
        /// </summary>
        [DataMember(Name="MinimumOrderAmount", EmitDefaultValue=false)]
        public double? MinimumOrderAmount { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [DataMember(Name="CreditLimit", EmitDefaultValue=false)]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// Gets or Sets DiscountPercent
        /// </summary>
        [DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
        public double? DiscountPercent { get; set; }

        /// <summary>
        /// Gets or Sets DiscountDays
        /// </summary>
        [DataMember(Name="DiscountDays", EmitDefaultValue=false)]
        public int? DiscountDays { get; set; }

        /// <summary>
        /// Gets or Sets NetDays
        /// </summary>
        [DataMember(Name="NetDays", EmitDefaultValue=false)]
        public int? NetDays { get; set; }

        /// <summary>
        /// Gets or Sets FreightTerms
        /// </summary>
        [DataMember(Name="FreightTerms", EmitDefaultValue=false)]
        public string FreightTerms { get; set; }

        /// <summary>
        /// Gets or Sets ShippingMethods
        /// </summary>
        [DataMember(Name="ShippingMethods", EmitDefaultValue=false)]
        public string ShippingMethods { get; set; }

        /// <summary>
        /// Gets or Sets StandingRMANumber
        /// </summary>
        [DataMember(Name="StandingRMANumber", EmitDefaultValue=false)]
        public string StandingRMANumber { get; set; }

        /// <summary>
        /// Gets or Sets RMAShipToAddressNumber
        /// </summary>
        [DataMember(Name="RMAShipToAddressNumber", EmitDefaultValue=false)]
        public int? RMAShipToAddressNumber { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderLeadTime
        /// </summary>
        [DataMember(Name="PurchaseOrderLeadTime", EmitDefaultValue=false)]
        public string PurchaseOrderLeadTime { get; set; }

        /// <summary>
        /// Gets or Sets APVendorID
        /// </summary>
        [DataMember(Name="APVendorID", EmitDefaultValue=false)]
        public string APVendorID { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public TsiWebAlternateAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets URL1
        /// </summary>
        [DataMember(Name="URL1", EmitDefaultValue=false)]
        public string URL1 { get; set; }

        /// <summary>
        /// Gets or Sets URL1Description
        /// </summary>
        [DataMember(Name="URL1Description", EmitDefaultValue=false)]
        public string URL1Description { get; set; }

        /// <summary>
        /// Gets or Sets URL2
        /// </summary>
        [DataMember(Name="URL2", EmitDefaultValue=false)]
        public string URL2 { get; set; }

        /// <summary>
        /// Gets or Sets URL2Description
        /// </summary>
        [DataMember(Name="URL2Description", EmitDefaultValue=false)]
        public string URL2Description { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
        public TsiWebPerson PrimaryContact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebVendor {\n");
            sb.Append("  VendorAccountNumber: ").Append(VendorAccountNumber).Append("\n");
            sb.Append("  VendorAccountName: ").Append(VendorAccountName).Append("\n");
            sb.Append("  OurCustomerNumber: ").Append(OurCustomerNumber).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  InternetID: ").Append(InternetID).Append("\n");
            sb.Append("  MinimumOrderQuantity: ").Append(MinimumOrderQuantity).Append("\n");
            sb.Append("  MinimumOrderAmount: ").Append(MinimumOrderAmount).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  DiscountDays: ").Append(DiscountDays).Append("\n");
            sb.Append("  NetDays: ").Append(NetDays).Append("\n");
            sb.Append("  FreightTerms: ").Append(FreightTerms).Append("\n");
            sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
            sb.Append("  StandingRMANumber: ").Append(StandingRMANumber).Append("\n");
            sb.Append("  RMAShipToAddressNumber: ").Append(RMAShipToAddressNumber).Append("\n");
            sb.Append("  PurchaseOrderLeadTime: ").Append(PurchaseOrderLeadTime).Append("\n");
            sb.Append("  APVendorID: ").Append(APVendorID).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  URL1: ").Append(URL1).Append("\n");
            sb.Append("  URL1Description: ").Append(URL1Description).Append("\n");
            sb.Append("  URL2: ").Append(URL2).Append("\n");
            sb.Append("  URL2Description: ").Append(URL2Description).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
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
            return this.Equals(input as TsiWebVendor);
        }

        /// <summary>
        /// Returns true if TsiWebVendor instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebVendor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebVendor input)
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
                    this.VendorAccountName == input.VendorAccountName ||
                    (this.VendorAccountName != null &&
                    this.VendorAccountName.Equals(input.VendorAccountName))
                ) && 
                (
                    this.OurCustomerNumber == input.OurCustomerNumber ||
                    (this.OurCustomerNumber != null &&
                    this.OurCustomerNumber.Equals(input.OurCustomerNumber))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.InternetID == input.InternetID ||
                    (this.InternetID != null &&
                    this.InternetID.Equals(input.InternetID))
                ) && 
                (
                    this.MinimumOrderQuantity == input.MinimumOrderQuantity ||
                    (this.MinimumOrderQuantity != null &&
                    this.MinimumOrderQuantity.Equals(input.MinimumOrderQuantity))
                ) && 
                (
                    this.MinimumOrderAmount == input.MinimumOrderAmount ||
                    (this.MinimumOrderAmount != null &&
                    this.MinimumOrderAmount.Equals(input.MinimumOrderAmount))
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    (this.CreditLimit != null &&
                    this.CreditLimit.Equals(input.CreditLimit))
                ) && 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && 
                (
                    this.DiscountDays == input.DiscountDays ||
                    (this.DiscountDays != null &&
                    this.DiscountDays.Equals(input.DiscountDays))
                ) && 
                (
                    this.NetDays == input.NetDays ||
                    (this.NetDays != null &&
                    this.NetDays.Equals(input.NetDays))
                ) && 
                (
                    this.FreightTerms == input.FreightTerms ||
                    (this.FreightTerms != null &&
                    this.FreightTerms.Equals(input.FreightTerms))
                ) && 
                (
                    this.ShippingMethods == input.ShippingMethods ||
                    (this.ShippingMethods != null &&
                    this.ShippingMethods.Equals(input.ShippingMethods))
                ) && 
                (
                    this.StandingRMANumber == input.StandingRMANumber ||
                    (this.StandingRMANumber != null &&
                    this.StandingRMANumber.Equals(input.StandingRMANumber))
                ) && 
                (
                    this.RMAShipToAddressNumber == input.RMAShipToAddressNumber ||
                    (this.RMAShipToAddressNumber != null &&
                    this.RMAShipToAddressNumber.Equals(input.RMAShipToAddressNumber))
                ) && 
                (
                    this.PurchaseOrderLeadTime == input.PurchaseOrderLeadTime ||
                    (this.PurchaseOrderLeadTime != null &&
                    this.PurchaseOrderLeadTime.Equals(input.PurchaseOrderLeadTime))
                ) && 
                (
                    this.APVendorID == input.APVendorID ||
                    (this.APVendorID != null &&
                    this.APVendorID.Equals(input.APVendorID))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.URL1 == input.URL1 ||
                    (this.URL1 != null &&
                    this.URL1.Equals(input.URL1))
                ) && 
                (
                    this.URL1Description == input.URL1Description ||
                    (this.URL1Description != null &&
                    this.URL1Description.Equals(input.URL1Description))
                ) && 
                (
                    this.URL2 == input.URL2 ||
                    (this.URL2 != null &&
                    this.URL2.Equals(input.URL2))
                ) && 
                (
                    this.URL2Description == input.URL2Description ||
                    (this.URL2Description != null &&
                    this.URL2Description.Equals(input.URL2Description))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
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
                if (this.VendorAccountName != null)
                    hashCode = hashCode * 59 + this.VendorAccountName.GetHashCode();
                if (this.OurCustomerNumber != null)
                    hashCode = hashCode * 59 + this.OurCustomerNumber.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.InternetID != null)
                    hashCode = hashCode * 59 + this.InternetID.GetHashCode();
                if (this.MinimumOrderQuantity != null)
                    hashCode = hashCode * 59 + this.MinimumOrderQuantity.GetHashCode();
                if (this.MinimumOrderAmount != null)
                    hashCode = hashCode * 59 + this.MinimumOrderAmount.GetHashCode();
                if (this.CreditLimit != null)
                    hashCode = hashCode * 59 + this.CreditLimit.GetHashCode();
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.DiscountDays != null)
                    hashCode = hashCode * 59 + this.DiscountDays.GetHashCode();
                if (this.NetDays != null)
                    hashCode = hashCode * 59 + this.NetDays.GetHashCode();
                if (this.FreightTerms != null)
                    hashCode = hashCode * 59 + this.FreightTerms.GetHashCode();
                if (this.ShippingMethods != null)
                    hashCode = hashCode * 59 + this.ShippingMethods.GetHashCode();
                if (this.StandingRMANumber != null)
                    hashCode = hashCode * 59 + this.StandingRMANumber.GetHashCode();
                if (this.RMAShipToAddressNumber != null)
                    hashCode = hashCode * 59 + this.RMAShipToAddressNumber.GetHashCode();
                if (this.PurchaseOrderLeadTime != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderLeadTime.GetHashCode();
                if (this.APVendorID != null)
                    hashCode = hashCode * 59 + this.APVendorID.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.URL1 != null)
                    hashCode = hashCode * 59 + this.URL1.GetHashCode();
                if (this.URL1Description != null)
                    hashCode = hashCode * 59 + this.URL1Description.GetHashCode();
                if (this.URL2 != null)
                    hashCode = hashCode * 59 + this.URL2.GetHashCode();
                if (this.URL2Description != null)
                    hashCode = hashCode * 59 + this.URL2Description.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
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
