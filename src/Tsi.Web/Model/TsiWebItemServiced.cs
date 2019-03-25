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
    /// TsiWebItemServiced
    /// </summary>
    [DataContract]
    public partial class TsiWebItemServiced :  IEquatable<TsiWebItemServiced>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebItemServiced" /> class.
        /// </summary>
        /// <param name="itemsServicedNumber">itemsServicedNumber.</param>
        /// <param name="serviceOrderNumber">serviceOrderNumber.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="customerInventoryNumber">customerInventoryNumber.</param>
        /// <param name="customerInventoryAssemblyDetailNumber">customerInventoryAssemblyDetailNumber.</param>
        /// <param name="contractNumber">contractNumber.</param>
        /// <param name="contractDetailNumber">contractDetailNumber.</param>
        /// <param name="rMA">rMA.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="meterReading">meterReading.</param>
        /// <param name="meterUsed">meterUsed.</param>
        /// <param name="rMADetail">rMADetail.</param>
        /// <param name="productType">productType.</param>
        /// <param name="mSPAccountAssets">mSPAccountAssets.</param>
        /// <param name="itemID">itemID.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="repairCode">repairCode.</param>
        /// <param name="location">location.</param>
        /// <param name="problem">problem.</param>
        /// <param name="repair">repair.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="rMANumber">rMANumber.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="providersAssetId">providersAssetId.</param>
        /// <param name="warrantyCovered">warrantyCovered.</param>
        /// <param name="updateContract">updateContract.</param>
        /// <param name="completeDate">completeDate.</param>
        /// <param name="symptom1">symptom1.</param>
        /// <param name="symptom2">symptom2.</param>
        /// <param name="symptom3">symptom3.</param>
        /// <param name="symptom4">symptom4.</param>
        /// <param name="symptom5">symptom5.</param>
        /// <param name="resolution1">resolution1.</param>
        /// <param name="resolution2">resolution2.</param>
        /// <param name="resolution3">resolution3.</param>
        /// <param name="resolution4">resolution4.</param>
        /// <param name="resolution5">resolution5.</param>
        public TsiWebItemServiced(int? itemsServicedNumber = default(int?), int? serviceOrderNumber = default(int?), int? accountNumber = default(int?), int? customerInventoryNumber = default(int?), int? customerInventoryAssemblyDetailNumber = default(int?), int? contractNumber = default(int?), int? contractDetailNumber = default(int?), int? rMA = default(int?), int? quantity = default(int?), int? meterReading = default(int?), int? meterUsed = default(int?), int? rMADetail = default(int?), int? productType = default(int?), int? mSPAccountAssets = default(int?), string itemID = default(string), string itemDescription = default(string), string repairCode = default(string), string location = default(string), string problem = default(string), string repair = default(string), string serialNumber = default(string), string rMANumber = default(string), string manufacturer = default(string), string providersAssetId = default(string), bool? warrantyCovered = default(bool?), bool? updateContract = default(bool?), DateTime? completeDate = default(DateTime?), string symptom1 = default(string), string symptom2 = default(string), string symptom3 = default(string), string symptom4 = default(string), string symptom5 = default(string), string resolution1 = default(string), string resolution2 = default(string), string resolution3 = default(string), string resolution4 = default(string), string resolution5 = default(string))
        {
            this.ItemsServicedNumber = itemsServicedNumber;
            this.ServiceOrderNumber = serviceOrderNumber;
            this.AccountNumber = accountNumber;
            this.CustomerInventoryNumber = customerInventoryNumber;
            this.CustomerInventoryAssemblyDetailNumber = customerInventoryAssemblyDetailNumber;
            this.ContractNumber = contractNumber;
            this.ContractDetailNumber = contractDetailNumber;
            this.RMA = rMA;
            this.Quantity = quantity;
            this.MeterReading = meterReading;
            this.MeterUsed = meterUsed;
            this.RMADetail = rMADetail;
            this.ProductType = productType;
            this.MSPAccountAssets = mSPAccountAssets;
            this.ItemID = itemID;
            this.ItemDescription = itemDescription;
            this.RepairCode = repairCode;
            this.Location = location;
            this.Problem = problem;
            this.Repair = repair;
            this.SerialNumber = serialNumber;
            this.RMANumber = rMANumber;
            this.Manufacturer = manufacturer;
            this.ProvidersAssetId = providersAssetId;
            this.WarrantyCovered = warrantyCovered;
            this.UpdateContract = updateContract;
            this.CompleteDate = completeDate;
            this.Symptom1 = symptom1;
            this.Symptom2 = symptom2;
            this.Symptom3 = symptom3;
            this.Symptom4 = symptom4;
            this.Symptom5 = symptom5;
            this.Resolution1 = resolution1;
            this.Resolution2 = resolution2;
            this.Resolution3 = resolution3;
            this.Resolution4 = resolution4;
            this.Resolution5 = resolution5;
        }
        
        /// <summary>
        /// Gets or Sets ItemsServicedNumber
        /// </summary>
        [DataMember(Name="ItemsServicedNumber", EmitDefaultValue=false)]
        public int? ItemsServicedNumber { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderNumber
        /// </summary>
        [DataMember(Name="ServiceOrderNumber", EmitDefaultValue=false)]
        public int? ServiceOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInventoryNumber
        /// </summary>
        [DataMember(Name="CustomerInventoryNumber", EmitDefaultValue=false)]
        public int? CustomerInventoryNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInventoryAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="CustomerInventoryAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? CustomerInventoryAssemblyDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContractNumber
        /// </summary>
        [DataMember(Name="ContractNumber", EmitDefaultValue=false)]
        public int? ContractNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContractDetailNumber
        /// </summary>
        [DataMember(Name="ContractDetailNumber", EmitDefaultValue=false)]
        public int? ContractDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets RMA
        /// </summary>
        [DataMember(Name="RMA", EmitDefaultValue=false)]
        public int? RMA { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets MeterReading
        /// </summary>
        [DataMember(Name="MeterReading", EmitDefaultValue=false)]
        public int? MeterReading { get; set; }

        /// <summary>
        /// Gets or Sets MeterUsed
        /// </summary>
        [DataMember(Name="MeterUsed", EmitDefaultValue=false)]
        public int? MeterUsed { get; set; }

        /// <summary>
        /// Gets or Sets RMADetail
        /// </summary>
        [DataMember(Name="RMADetail", EmitDefaultValue=false)]
        public int? RMADetail { get; set; }

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="ProductType", EmitDefaultValue=false)]
        public int? ProductType { get; set; }

        /// <summary>
        /// Gets or Sets MSPAccountAssets
        /// </summary>
        [DataMember(Name="MSPAccountAssets", EmitDefaultValue=false)]
        public int? MSPAccountAssets { get; set; }

        /// <summary>
        /// Gets or Sets ItemID
        /// </summary>
        [DataMember(Name="ItemID", EmitDefaultValue=false)]
        public string ItemID { get; set; }

        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="ItemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets RepairCode
        /// </summary>
        [DataMember(Name="RepairCode", EmitDefaultValue=false)]
        public string RepairCode { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Problem
        /// </summary>
        [DataMember(Name="Problem", EmitDefaultValue=false)]
        public string Problem { get; set; }

        /// <summary>
        /// Gets or Sets Repair
        /// </summary>
        [DataMember(Name="Repair", EmitDefaultValue=false)]
        public string Repair { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets RMANumber
        /// </summary>
        [DataMember(Name="RMANumber", EmitDefaultValue=false)]
        public string RMANumber { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="Manufacturer", EmitDefaultValue=false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets ProvidersAssetId
        /// </summary>
        [DataMember(Name="ProvidersAssetId", EmitDefaultValue=false)]
        public string ProvidersAssetId { get; set; }

        /// <summary>
        /// Gets or Sets WarrantyCovered
        /// </summary>
        [DataMember(Name="WarrantyCovered", EmitDefaultValue=false)]
        public bool? WarrantyCovered { get; set; }

        /// <summary>
        /// Gets or Sets UpdateContract
        /// </summary>
        [DataMember(Name="UpdateContract", EmitDefaultValue=false)]
        public bool? UpdateContract { get; set; }

        /// <summary>
        /// Gets or Sets CompleteDate
        /// </summary>
        [DataMember(Name="CompleteDate", EmitDefaultValue=false)]
        public DateTime? CompleteDate { get; set; }

        /// <summary>
        /// Gets or Sets Symptom1
        /// </summary>
        [DataMember(Name="Symptom1", EmitDefaultValue=false)]
        public string Symptom1 { get; set; }

        /// <summary>
        /// Gets or Sets Symptom2
        /// </summary>
        [DataMember(Name="Symptom2", EmitDefaultValue=false)]
        public string Symptom2 { get; set; }

        /// <summary>
        /// Gets or Sets Symptom3
        /// </summary>
        [DataMember(Name="Symptom3", EmitDefaultValue=false)]
        public string Symptom3 { get; set; }

        /// <summary>
        /// Gets or Sets Symptom4
        /// </summary>
        [DataMember(Name="Symptom4", EmitDefaultValue=false)]
        public string Symptom4 { get; set; }

        /// <summary>
        /// Gets or Sets Symptom5
        /// </summary>
        [DataMember(Name="Symptom5", EmitDefaultValue=false)]
        public string Symptom5 { get; set; }

        /// <summary>
        /// Gets or Sets Resolution1
        /// </summary>
        [DataMember(Name="Resolution1", EmitDefaultValue=false)]
        public string Resolution1 { get; set; }

        /// <summary>
        /// Gets or Sets Resolution2
        /// </summary>
        [DataMember(Name="Resolution2", EmitDefaultValue=false)]
        public string Resolution2 { get; set; }

        /// <summary>
        /// Gets or Sets Resolution3
        /// </summary>
        [DataMember(Name="Resolution3", EmitDefaultValue=false)]
        public string Resolution3 { get; set; }

        /// <summary>
        /// Gets or Sets Resolution4
        /// </summary>
        [DataMember(Name="Resolution4", EmitDefaultValue=false)]
        public string Resolution4 { get; set; }

        /// <summary>
        /// Gets or Sets Resolution5
        /// </summary>
        [DataMember(Name="Resolution5", EmitDefaultValue=false)]
        public string Resolution5 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebItemServiced {\n");
            sb.Append("  ItemsServicedNumber: ").Append(ItemsServicedNumber).Append("\n");
            sb.Append("  ServiceOrderNumber: ").Append(ServiceOrderNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  CustomerInventoryNumber: ").Append(CustomerInventoryNumber).Append("\n");
            sb.Append("  CustomerInventoryAssemblyDetailNumber: ").Append(CustomerInventoryAssemblyDetailNumber).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  ContractDetailNumber: ").Append(ContractDetailNumber).Append("\n");
            sb.Append("  RMA: ").Append(RMA).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  MeterReading: ").Append(MeterReading).Append("\n");
            sb.Append("  MeterUsed: ").Append(MeterUsed).Append("\n");
            sb.Append("  RMADetail: ").Append(RMADetail).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  MSPAccountAssets: ").Append(MSPAccountAssets).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  RepairCode: ").Append(RepairCode).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Problem: ").Append(Problem).Append("\n");
            sb.Append("  Repair: ").Append(Repair).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  RMANumber: ").Append(RMANumber).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  ProvidersAssetId: ").Append(ProvidersAssetId).Append("\n");
            sb.Append("  WarrantyCovered: ").Append(WarrantyCovered).Append("\n");
            sb.Append("  UpdateContract: ").Append(UpdateContract).Append("\n");
            sb.Append("  CompleteDate: ").Append(CompleteDate).Append("\n");
            sb.Append("  Symptom1: ").Append(Symptom1).Append("\n");
            sb.Append("  Symptom2: ").Append(Symptom2).Append("\n");
            sb.Append("  Symptom3: ").Append(Symptom3).Append("\n");
            sb.Append("  Symptom4: ").Append(Symptom4).Append("\n");
            sb.Append("  Symptom5: ").Append(Symptom5).Append("\n");
            sb.Append("  Resolution1: ").Append(Resolution1).Append("\n");
            sb.Append("  Resolution2: ").Append(Resolution2).Append("\n");
            sb.Append("  Resolution3: ").Append(Resolution3).Append("\n");
            sb.Append("  Resolution4: ").Append(Resolution4).Append("\n");
            sb.Append("  Resolution5: ").Append(Resolution5).Append("\n");
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
            return this.Equals(input as TsiWebItemServiced);
        }

        /// <summary>
        /// Returns true if TsiWebItemServiced instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebItemServiced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebItemServiced input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemsServicedNumber == input.ItemsServicedNumber ||
                    (this.ItemsServicedNumber != null &&
                    this.ItemsServicedNumber.Equals(input.ItemsServicedNumber))
                ) && 
                (
                    this.ServiceOrderNumber == input.ServiceOrderNumber ||
                    (this.ServiceOrderNumber != null &&
                    this.ServiceOrderNumber.Equals(input.ServiceOrderNumber))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.CustomerInventoryNumber == input.CustomerInventoryNumber ||
                    (this.CustomerInventoryNumber != null &&
                    this.CustomerInventoryNumber.Equals(input.CustomerInventoryNumber))
                ) && 
                (
                    this.CustomerInventoryAssemblyDetailNumber == input.CustomerInventoryAssemblyDetailNumber ||
                    (this.CustomerInventoryAssemblyDetailNumber != null &&
                    this.CustomerInventoryAssemblyDetailNumber.Equals(input.CustomerInventoryAssemblyDetailNumber))
                ) && 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
                ) && 
                (
                    this.ContractDetailNumber == input.ContractDetailNumber ||
                    (this.ContractDetailNumber != null &&
                    this.ContractDetailNumber.Equals(input.ContractDetailNumber))
                ) && 
                (
                    this.RMA == input.RMA ||
                    (this.RMA != null &&
                    this.RMA.Equals(input.RMA))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.MeterReading == input.MeterReading ||
                    (this.MeterReading != null &&
                    this.MeterReading.Equals(input.MeterReading))
                ) && 
                (
                    this.MeterUsed == input.MeterUsed ||
                    (this.MeterUsed != null &&
                    this.MeterUsed.Equals(input.MeterUsed))
                ) && 
                (
                    this.RMADetail == input.RMADetail ||
                    (this.RMADetail != null &&
                    this.RMADetail.Equals(input.RMADetail))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.MSPAccountAssets == input.MSPAccountAssets ||
                    (this.MSPAccountAssets != null &&
                    this.MSPAccountAssets.Equals(input.MSPAccountAssets))
                ) && 
                (
                    this.ItemID == input.ItemID ||
                    (this.ItemID != null &&
                    this.ItemID.Equals(input.ItemID))
                ) && 
                (
                    this.ItemDescription == input.ItemDescription ||
                    (this.ItemDescription != null &&
                    this.ItemDescription.Equals(input.ItemDescription))
                ) && 
                (
                    this.RepairCode == input.RepairCode ||
                    (this.RepairCode != null &&
                    this.RepairCode.Equals(input.RepairCode))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Problem == input.Problem ||
                    (this.Problem != null &&
                    this.Problem.Equals(input.Problem))
                ) && 
                (
                    this.Repair == input.Repair ||
                    (this.Repair != null &&
                    this.Repair.Equals(input.Repair))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.RMANumber == input.RMANumber ||
                    (this.RMANumber != null &&
                    this.RMANumber.Equals(input.RMANumber))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.ProvidersAssetId == input.ProvidersAssetId ||
                    (this.ProvidersAssetId != null &&
                    this.ProvidersAssetId.Equals(input.ProvidersAssetId))
                ) && 
                (
                    this.WarrantyCovered == input.WarrantyCovered ||
                    (this.WarrantyCovered != null &&
                    this.WarrantyCovered.Equals(input.WarrantyCovered))
                ) && 
                (
                    this.UpdateContract == input.UpdateContract ||
                    (this.UpdateContract != null &&
                    this.UpdateContract.Equals(input.UpdateContract))
                ) && 
                (
                    this.CompleteDate == input.CompleteDate ||
                    (this.CompleteDate != null &&
                    this.CompleteDate.Equals(input.CompleteDate))
                ) && 
                (
                    this.Symptom1 == input.Symptom1 ||
                    (this.Symptom1 != null &&
                    this.Symptom1.Equals(input.Symptom1))
                ) && 
                (
                    this.Symptom2 == input.Symptom2 ||
                    (this.Symptom2 != null &&
                    this.Symptom2.Equals(input.Symptom2))
                ) && 
                (
                    this.Symptom3 == input.Symptom3 ||
                    (this.Symptom3 != null &&
                    this.Symptom3.Equals(input.Symptom3))
                ) && 
                (
                    this.Symptom4 == input.Symptom4 ||
                    (this.Symptom4 != null &&
                    this.Symptom4.Equals(input.Symptom4))
                ) && 
                (
                    this.Symptom5 == input.Symptom5 ||
                    (this.Symptom5 != null &&
                    this.Symptom5.Equals(input.Symptom5))
                ) && 
                (
                    this.Resolution1 == input.Resolution1 ||
                    (this.Resolution1 != null &&
                    this.Resolution1.Equals(input.Resolution1))
                ) && 
                (
                    this.Resolution2 == input.Resolution2 ||
                    (this.Resolution2 != null &&
                    this.Resolution2.Equals(input.Resolution2))
                ) && 
                (
                    this.Resolution3 == input.Resolution3 ||
                    (this.Resolution3 != null &&
                    this.Resolution3.Equals(input.Resolution3))
                ) && 
                (
                    this.Resolution4 == input.Resolution4 ||
                    (this.Resolution4 != null &&
                    this.Resolution4.Equals(input.Resolution4))
                ) && 
                (
                    this.Resolution5 == input.Resolution5 ||
                    (this.Resolution5 != null &&
                    this.Resolution5.Equals(input.Resolution5))
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
                if (this.ItemsServicedNumber != null)
                    hashCode = hashCode * 59 + this.ItemsServicedNumber.GetHashCode();
                if (this.ServiceOrderNumber != null)
                    hashCode = hashCode * 59 + this.ServiceOrderNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.CustomerInventoryNumber != null)
                    hashCode = hashCode * 59 + this.CustomerInventoryNumber.GetHashCode();
                if (this.CustomerInventoryAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.CustomerInventoryAssemblyDetailNumber.GetHashCode();
                if (this.ContractNumber != null)
                    hashCode = hashCode * 59 + this.ContractNumber.GetHashCode();
                if (this.ContractDetailNumber != null)
                    hashCode = hashCode * 59 + this.ContractDetailNumber.GetHashCode();
                if (this.RMA != null)
                    hashCode = hashCode * 59 + this.RMA.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.MeterReading != null)
                    hashCode = hashCode * 59 + this.MeterReading.GetHashCode();
                if (this.MeterUsed != null)
                    hashCode = hashCode * 59 + this.MeterUsed.GetHashCode();
                if (this.RMADetail != null)
                    hashCode = hashCode * 59 + this.RMADetail.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.MSPAccountAssets != null)
                    hashCode = hashCode * 59 + this.MSPAccountAssets.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.RepairCode != null)
                    hashCode = hashCode * 59 + this.RepairCode.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Problem != null)
                    hashCode = hashCode * 59 + this.Problem.GetHashCode();
                if (this.Repair != null)
                    hashCode = hashCode * 59 + this.Repair.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.RMANumber != null)
                    hashCode = hashCode * 59 + this.RMANumber.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.ProvidersAssetId != null)
                    hashCode = hashCode * 59 + this.ProvidersAssetId.GetHashCode();
                if (this.WarrantyCovered != null)
                    hashCode = hashCode * 59 + this.WarrantyCovered.GetHashCode();
                if (this.UpdateContract != null)
                    hashCode = hashCode * 59 + this.UpdateContract.GetHashCode();
                if (this.CompleteDate != null)
                    hashCode = hashCode * 59 + this.CompleteDate.GetHashCode();
                if (this.Symptom1 != null)
                    hashCode = hashCode * 59 + this.Symptom1.GetHashCode();
                if (this.Symptom2 != null)
                    hashCode = hashCode * 59 + this.Symptom2.GetHashCode();
                if (this.Symptom3 != null)
                    hashCode = hashCode * 59 + this.Symptom3.GetHashCode();
                if (this.Symptom4 != null)
                    hashCode = hashCode * 59 + this.Symptom4.GetHashCode();
                if (this.Symptom5 != null)
                    hashCode = hashCode * 59 + this.Symptom5.GetHashCode();
                if (this.Resolution1 != null)
                    hashCode = hashCode * 59 + this.Resolution1.GetHashCode();
                if (this.Resolution2 != null)
                    hashCode = hashCode * 59 + this.Resolution2.GetHashCode();
                if (this.Resolution3 != null)
                    hashCode = hashCode * 59 + this.Resolution3.GetHashCode();
                if (this.Resolution4 != null)
                    hashCode = hashCode * 59 + this.Resolution4.GetHashCode();
                if (this.Resolution5 != null)
                    hashCode = hashCode * 59 + this.Resolution5.GetHashCode();
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
