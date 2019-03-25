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
    /// TsiWebAgreementCustomerAsset
    /// </summary>
    [DataContract]
    public partial class TsiWebAgreementCustomerAsset :  IEquatable<TsiWebAgreementCustomerAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAgreementCustomerAsset" /> class.
        /// </summary>
        /// <param name="customerAssetNumber">Gets or sets AssetId.</param>
        /// <param name="provider">Gets or sets Provider.</param>
        /// <param name="assetType">Gets or sets AssetType.</param>
        /// <param name="providerAssetName">Gets or sets ProviderAssetName.</param>
        /// <param name="providerAssetId">Gets or sets ProviderAssetId.</param>
        /// <param name="price">Gets or sets the Price.</param>
        /// <param name="priceLevel">Gets or sets the PriceLevel.</param>
        /// <param name="priceLevelDescription">Gets or sets the PriceLevelDescription.</param>
        /// <param name="externalId">Gets or sets the ExternalId.</param>
        /// <param name="dateAdded">Gets or sets the DateAdded.</param>
        /// <param name="deviceURL">Gets or sets the DeviceURL.</param>
        /// <param name="lastPolledDate">Gets or sets the LastPolledDate.</param>
        /// <param name="dateRemoved">Gets or sets the DateRemoved.</param>
        /// <param name="iPAddress">Gets or sets the IPAdress.</param>
        /// <param name="macAddress">Gets or sets the MacAddress.</param>
        /// <param name="oS">Gets or sets the OS.</param>
        /// <param name="serialNumber">Gets or sets the SerialNumber.</param>
        /// <param name="description">Gets or sets the Description.</param>
        public TsiWebAgreementCustomerAsset(int? customerAssetNumber = default(int?), string provider = default(string), string assetType = default(string), string providerAssetName = default(string), int? providerAssetId = default(int?), double? price = default(double?), int? priceLevel = default(int?), string priceLevelDescription = default(string), string externalId = default(string), DateTime? dateAdded = default(DateTime?), string deviceURL = default(string), DateTime? lastPolledDate = default(DateTime?), DateTime? dateRemoved = default(DateTime?), string iPAddress = default(string), string macAddress = default(string), string oS = default(string), string serialNumber = default(string), string description = default(string))
        {
            this.CustomerAssetNumber = customerAssetNumber;
            this.Provider = provider;
            this.AssetType = assetType;
            this.ProviderAssetName = providerAssetName;
            this.ProviderAssetId = providerAssetId;
            this.Price = price;
            this.PriceLevel = priceLevel;
            this.PriceLevelDescription = priceLevelDescription;
            this.ExternalId = externalId;
            this.DateAdded = dateAdded;
            this.DeviceURL = deviceURL;
            this.LastPolledDate = lastPolledDate;
            this.DateRemoved = dateRemoved;
            this.IPAddress = iPAddress;
            this.MacAddress = macAddress;
            this.OS = oS;
            this.SerialNumber = serialNumber;
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or sets AssetId
        /// </summary>
        /// <value>Gets or sets AssetId</value>
        [DataMember(Name="CustomerAssetNumber", EmitDefaultValue=false)]
        public int? CustomerAssetNumber { get; set; }

        /// <summary>
        /// Gets or sets Provider
        /// </summary>
        /// <value>Gets or sets Provider</value>
        [DataMember(Name="Provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets AssetType
        /// </summary>
        /// <value>Gets or sets AssetType</value>
        [DataMember(Name="AssetType", EmitDefaultValue=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or sets ProviderAssetName
        /// </summary>
        /// <value>Gets or sets ProviderAssetName</value>
        [DataMember(Name="ProviderAssetName", EmitDefaultValue=false)]
        public string ProviderAssetName { get; set; }

        /// <summary>
        /// Gets or sets ProviderAssetId
        /// </summary>
        /// <value>Gets or sets ProviderAssetId</value>
        [DataMember(Name="ProviderAssetId", EmitDefaultValue=false)]
        public int? ProviderAssetId { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        /// <value>Gets or sets the Price</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or sets the PriceLevel
        /// </summary>
        /// <value>Gets or sets the PriceLevel</value>
        [DataMember(Name="PriceLevel", EmitDefaultValue=false)]
        public int? PriceLevel { get; set; }

        /// <summary>
        /// Gets or sets the PriceLevelDescription
        /// </summary>
        /// <value>Gets or sets the PriceLevelDescription</value>
        [DataMember(Name="PriceLevelDescription", EmitDefaultValue=false)]
        public string PriceLevelDescription { get; set; }

        /// <summary>
        /// Gets or sets the ExternalId
        /// </summary>
        /// <value>Gets or sets the ExternalId</value>
        [DataMember(Name="ExternalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the DateAdded
        /// </summary>
        /// <value>Gets or sets the DateAdded</value>
        [DataMember(Name="DateAdded", EmitDefaultValue=false)]
        public DateTime? DateAdded { get; set; }

        /// <summary>
        /// Gets or sets the DeviceURL
        /// </summary>
        /// <value>Gets or sets the DeviceURL</value>
        [DataMember(Name="DeviceURL", EmitDefaultValue=false)]
        public string DeviceURL { get; set; }

        /// <summary>
        /// Gets or sets the LastPolledDate
        /// </summary>
        /// <value>Gets or sets the LastPolledDate</value>
        [DataMember(Name="LastPolledDate", EmitDefaultValue=false)]
        public DateTime? LastPolledDate { get; set; }

        /// <summary>
        /// Gets or sets the DateRemoved
        /// </summary>
        /// <value>Gets or sets the DateRemoved</value>
        [DataMember(Name="DateRemoved", EmitDefaultValue=false)]
        public DateTime? DateRemoved { get; set; }

        /// <summary>
        /// Gets or sets the IPAdress
        /// </summary>
        /// <value>Gets or sets the IPAdress</value>
        [DataMember(Name="IPAddress", EmitDefaultValue=false)]
        public string IPAddress { get; set; }

        /// <summary>
        /// Gets or sets the MacAddress
        /// </summary>
        /// <value>Gets or sets the MacAddress</value>
        [DataMember(Name="MacAddress", EmitDefaultValue=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Gets or sets the OS
        /// </summary>
        /// <value>Gets or sets the OS</value>
        [DataMember(Name="OS", EmitDefaultValue=false)]
        public string OS { get; set; }

        /// <summary>
        /// Gets or sets the SerialNumber
        /// </summary>
        /// <value>Gets or sets the SerialNumber</value>
        [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        /// <value>Gets or sets the Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAgreementCustomerAsset {\n");
            sb.Append("  CustomerAssetNumber: ").Append(CustomerAssetNumber).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  ProviderAssetName: ").Append(ProviderAssetName).Append("\n");
            sb.Append("  ProviderAssetId: ").Append(ProviderAssetId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  PriceLevelDescription: ").Append(PriceLevelDescription).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  DeviceURL: ").Append(DeviceURL).Append("\n");
            sb.Append("  LastPolledDate: ").Append(LastPolledDate).Append("\n");
            sb.Append("  DateRemoved: ").Append(DateRemoved).Append("\n");
            sb.Append("  IPAddress: ").Append(IPAddress).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  OS: ").Append(OS).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as TsiWebAgreementCustomerAsset);
        }

        /// <summary>
        /// Returns true if TsiWebAgreementCustomerAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAgreementCustomerAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAgreementCustomerAsset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerAssetNumber == input.CustomerAssetNumber ||
                    (this.CustomerAssetNumber != null &&
                    this.CustomerAssetNumber.Equals(input.CustomerAssetNumber))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.ProviderAssetName == input.ProviderAssetName ||
                    (this.ProviderAssetName != null &&
                    this.ProviderAssetName.Equals(input.ProviderAssetName))
                ) && 
                (
                    this.ProviderAssetId == input.ProviderAssetId ||
                    (this.ProviderAssetId != null &&
                    this.ProviderAssetId.Equals(input.ProviderAssetId))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PriceLevel == input.PriceLevel ||
                    (this.PriceLevel != null &&
                    this.PriceLevel.Equals(input.PriceLevel))
                ) && 
                (
                    this.PriceLevelDescription == input.PriceLevelDescription ||
                    (this.PriceLevelDescription != null &&
                    this.PriceLevelDescription.Equals(input.PriceLevelDescription))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.DateAdded == input.DateAdded ||
                    (this.DateAdded != null &&
                    this.DateAdded.Equals(input.DateAdded))
                ) && 
                (
                    this.DeviceURL == input.DeviceURL ||
                    (this.DeviceURL != null &&
                    this.DeviceURL.Equals(input.DeviceURL))
                ) && 
                (
                    this.LastPolledDate == input.LastPolledDate ||
                    (this.LastPolledDate != null &&
                    this.LastPolledDate.Equals(input.LastPolledDate))
                ) && 
                (
                    this.DateRemoved == input.DateRemoved ||
                    (this.DateRemoved != null &&
                    this.DateRemoved.Equals(input.DateRemoved))
                ) && 
                (
                    this.IPAddress == input.IPAddress ||
                    (this.IPAddress != null &&
                    this.IPAddress.Equals(input.IPAddress))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.OS == input.OS ||
                    (this.OS != null &&
                    this.OS.Equals(input.OS))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.CustomerAssetNumber != null)
                    hashCode = hashCode * 59 + this.CustomerAssetNumber.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.AssetType != null)
                    hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.ProviderAssetName != null)
                    hashCode = hashCode * 59 + this.ProviderAssetName.GetHashCode();
                if (this.ProviderAssetId != null)
                    hashCode = hashCode * 59 + this.ProviderAssetId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceLevel != null)
                    hashCode = hashCode * 59 + this.PriceLevel.GetHashCode();
                if (this.PriceLevelDescription != null)
                    hashCode = hashCode * 59 + this.PriceLevelDescription.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.DateAdded != null)
                    hashCode = hashCode * 59 + this.DateAdded.GetHashCode();
                if (this.DeviceURL != null)
                    hashCode = hashCode * 59 + this.DeviceURL.GetHashCode();
                if (this.LastPolledDate != null)
                    hashCode = hashCode * 59 + this.LastPolledDate.GetHashCode();
                if (this.DateRemoved != null)
                    hashCode = hashCode * 59 + this.DateRemoved.GetHashCode();
                if (this.IPAddress != null)
                    hashCode = hashCode * 59 + this.IPAddress.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.OS != null)
                    hashCode = hashCode * 59 + this.OS.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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