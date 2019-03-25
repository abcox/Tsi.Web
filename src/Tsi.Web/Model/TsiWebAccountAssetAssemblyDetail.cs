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
    /// TsiWebAccountAssetAssemblyDetail
    /// </summary>
    [DataContract]
    public partial class TsiWebAccountAssetAssemblyDetail :  IEquatable<TsiWebAccountAssetAssemblyDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAccountAssetAssemblyDetail" /> class.
        /// </summary>
        /// <param name="accountAssetAssemblyDetailNumber">accountAssetAssemblyDetailNumber.</param>
        /// <param name="itemID">itemID.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="purchasedFromUs">purchasedFromUs.</param>
        /// <param name="datePurchased">datePurchased.</param>
        /// <param name="purchasePrice">purchasePrice.</param>
        /// <param name="warrantyExpiration">warrantyExpiration.</param>
        /// <param name="manufacturerWarrantyExpiration">manufacturerWarrantyExpiration.</param>
        /// <param name="vendorInvoiceNumber">vendorInvoiceNumber.</param>
        /// <param name="status">status.</param>
        /// <param name="statusComment">statusComment.</param>
        /// <param name="statusDate">statusDate.</param>
        /// <param name="transferTo">transferTo.</param>
        /// <param name="transferDate">transferDate.</param>
        /// <param name="creditMemoQuantity">creditMemoQuantity.</param>
        /// <param name="allowExchange">allowExchange.</param>
        /// <param name="itemExchangedFor">itemExchangedFor.</param>
        /// <param name="exchangeNumber">exchangeNumber.</param>
        /// <param name="invoiceNumber">invoiceNumber.</param>
        /// <param name="invoiceDetailNumber">invoiceDetailNumber.</param>
        /// <param name="invoiceAssemblyDetailNumber">invoiceAssemblyDetailNumber.</param>
        /// <param name="creditMemoNumber">creditMemoNumber.</param>
        /// <param name="creditMemoDetailNumber">creditMemoDetailNumber.</param>
        /// <param name="creditMemoAssemblyDetailNumber">creditMemoAssemblyDetailNumber.</param>
        /// <param name="manufacturerPartNumber">manufacturerPartNumber.</param>
        /// <param name="vendorAccountNumber">vendorAccountNumber.</param>
        /// <param name="purchasedFromVendorDate">purchasedFromVendorDate.</param>
        /// <param name="nextActionDate">nextActionDate.</param>
        /// <param name="nextActionType">nextActionType.</param>
        /// <param name="nextActionTriggersWorkflow">nextActionTriggersWorkflow.</param>
        /// <param name="replacedByItemId">replacedByItemId.</param>
        /// <param name="warrantyExpirationTriggersWorkflow">warrantyExpirationTriggersWorkflow.</param>
        /// <param name="printOnCustomerFacingReports">printOnCustomerFacingReports.</param>
        public TsiWebAccountAssetAssemblyDetail(int? accountAssetAssemblyDetailNumber = default(int?), string itemID = default(string), string itemDescription = default(string), string serialNumber = default(string), double? quantity = default(double?), bool? purchasedFromUs = default(bool?), DateTime? datePurchased = default(DateTime?), double? purchasePrice = default(double?), DateTime? warrantyExpiration = default(DateTime?), DateTime? manufacturerWarrantyExpiration = default(DateTime?), string vendorInvoiceNumber = default(string), string status = default(string), string statusComment = default(string), DateTime? statusDate = default(DateTime?), int? transferTo = default(int?), DateTime? transferDate = default(DateTime?), double? creditMemoQuantity = default(double?), bool? allowExchange = default(bool?), int? itemExchangedFor = default(int?), int? exchangeNumber = default(int?), int? invoiceNumber = default(int?), int? invoiceDetailNumber = default(int?), int? invoiceAssemblyDetailNumber = default(int?), int? creditMemoNumber = default(int?), int? creditMemoDetailNumber = default(int?), int? creditMemoAssemblyDetailNumber = default(int?), string manufacturerPartNumber = default(string), int? vendorAccountNumber = default(int?), DateTime? purchasedFromVendorDate = default(DateTime?), DateTime? nextActionDate = default(DateTime?), string nextActionType = default(string), bool? nextActionTriggersWorkflow = default(bool?), string replacedByItemId = default(string), bool? warrantyExpirationTriggersWorkflow = default(bool?), bool? printOnCustomerFacingReports = default(bool?))
        {
            this.AccountAssetAssemblyDetailNumber = accountAssetAssemblyDetailNumber;
            this.ItemID = itemID;
            this.ItemDescription = itemDescription;
            this.SerialNumber = serialNumber;
            this.Quantity = quantity;
            this.PurchasedFromUs = purchasedFromUs;
            this.DatePurchased = datePurchased;
            this.PurchasePrice = purchasePrice;
            this.WarrantyExpiration = warrantyExpiration;
            this.ManufacturerWarrantyExpiration = manufacturerWarrantyExpiration;
            this.VendorInvoiceNumber = vendorInvoiceNumber;
            this.Status = status;
            this.StatusComment = statusComment;
            this.StatusDate = statusDate;
            this.TransferTo = transferTo;
            this.TransferDate = transferDate;
            this.CreditMemoQuantity = creditMemoQuantity;
            this.AllowExchange = allowExchange;
            this.ItemExchangedFor = itemExchangedFor;
            this.ExchangeNumber = exchangeNumber;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceDetailNumber = invoiceDetailNumber;
            this.InvoiceAssemblyDetailNumber = invoiceAssemblyDetailNumber;
            this.CreditMemoNumber = creditMemoNumber;
            this.CreditMemoDetailNumber = creditMemoDetailNumber;
            this.CreditMemoAssemblyDetailNumber = creditMemoAssemblyDetailNumber;
            this.ManufacturerPartNumber = manufacturerPartNumber;
            this.VendorAccountNumber = vendorAccountNumber;
            this.PurchasedFromVendorDate = purchasedFromVendorDate;
            this.NextActionDate = nextActionDate;
            this.NextActionType = nextActionType;
            this.NextActionTriggersWorkflow = nextActionTriggersWorkflow;
            this.ReplacedByItemId = replacedByItemId;
            this.WarrantyExpirationTriggersWorkflow = warrantyExpirationTriggersWorkflow;
            this.PrintOnCustomerFacingReports = printOnCustomerFacingReports;
        }
        
        /// <summary>
        /// Gets or Sets AccountAssetAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="AccountAssetAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? AccountAssetAssemblyDetailNumber { get; set; }

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
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets PurchasedFromUs
        /// </summary>
        [DataMember(Name="PurchasedFromUs", EmitDefaultValue=false)]
        public bool? PurchasedFromUs { get; set; }

        /// <summary>
        /// Gets or Sets DatePurchased
        /// </summary>
        [DataMember(Name="DatePurchased", EmitDefaultValue=false)]
        public DateTime? DatePurchased { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="PurchasePrice", EmitDefaultValue=false)]
        public double? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets WarrantyExpiration
        /// </summary>
        [DataMember(Name="WarrantyExpiration", EmitDefaultValue=false)]
        public DateTime? WarrantyExpiration { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerWarrantyExpiration
        /// </summary>
        [DataMember(Name="ManufacturerWarrantyExpiration", EmitDefaultValue=false)]
        public DateTime? ManufacturerWarrantyExpiration { get; set; }

        /// <summary>
        /// Gets or Sets VendorInvoiceNumber
        /// </summary>
        [DataMember(Name="VendorInvoiceNumber", EmitDefaultValue=false)]
        public string VendorInvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusComment
        /// </summary>
        [DataMember(Name="StatusComment", EmitDefaultValue=false)]
        public string StatusComment { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name="StatusDate", EmitDefaultValue=false)]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets TransferTo
        /// </summary>
        [DataMember(Name="TransferTo", EmitDefaultValue=false)]
        public int? TransferTo { get; set; }

        /// <summary>
        /// Gets or Sets TransferDate
        /// </summary>
        [DataMember(Name="TransferDate", EmitDefaultValue=false)]
        public DateTime? TransferDate { get; set; }

        /// <summary>
        /// Gets or Sets CreditMemoQuantity
        /// </summary>
        [DataMember(Name="CreditMemoQuantity", EmitDefaultValue=false)]
        public double? CreditMemoQuantity { get; set; }

        /// <summary>
        /// Gets or Sets AllowExchange
        /// </summary>
        [DataMember(Name="AllowExchange", EmitDefaultValue=false)]
        public bool? AllowExchange { get; set; }

        /// <summary>
        /// Gets or Sets ItemExchangedFor
        /// </summary>
        [DataMember(Name="ItemExchangedFor", EmitDefaultValue=false)]
        public int? ItemExchangedFor { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeNumber
        /// </summary>
        [DataMember(Name="ExchangeNumber", EmitDefaultValue=false)]
        public int? ExchangeNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
        public int? InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDetailNumber
        /// </summary>
        [DataMember(Name="InvoiceDetailNumber", EmitDefaultValue=false)]
        public int? InvoiceDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="InvoiceAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? InvoiceAssemblyDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreditMemoNumber
        /// </summary>
        [DataMember(Name="CreditMemoNumber", EmitDefaultValue=false)]
        public int? CreditMemoNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreditMemoDetailNumber
        /// </summary>
        [DataMember(Name="CreditMemoDetailNumber", EmitDefaultValue=false)]
        public int? CreditMemoDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreditMemoAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="CreditMemoAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? CreditMemoAssemblyDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerPartNumber
        /// </summary>
        [DataMember(Name="ManufacturerPartNumber", EmitDefaultValue=false)]
        public string ManufacturerPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets VendorAccountNumber
        /// </summary>
        [DataMember(Name="VendorAccountNumber", EmitDefaultValue=false)]
        public int? VendorAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets PurchasedFromVendorDate
        /// </summary>
        [DataMember(Name="PurchasedFromVendorDate", EmitDefaultValue=false)]
        public DateTime? PurchasedFromVendorDate { get; set; }

        /// <summary>
        /// Gets or Sets NextActionDate
        /// </summary>
        [DataMember(Name="NextActionDate", EmitDefaultValue=false)]
        public DateTime? NextActionDate { get; set; }

        /// <summary>
        /// Gets or Sets NextActionType
        /// </summary>
        [DataMember(Name="NextActionType", EmitDefaultValue=false)]
        public string NextActionType { get; set; }

        /// <summary>
        /// Gets or Sets NextActionTriggersWorkflow
        /// </summary>
        [DataMember(Name="NextActionTriggersWorkflow", EmitDefaultValue=false)]
        public bool? NextActionTriggersWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets ReplacedByItemId
        /// </summary>
        [DataMember(Name="ReplacedByItemId", EmitDefaultValue=false)]
        public string ReplacedByItemId { get; set; }

        /// <summary>
        /// Gets or Sets WarrantyExpirationTriggersWorkflow
        /// </summary>
        [DataMember(Name="WarrantyExpirationTriggersWorkflow", EmitDefaultValue=false)]
        public bool? WarrantyExpirationTriggersWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets PrintOnCustomerFacingReports
        /// </summary>
        [DataMember(Name="PrintOnCustomerFacingReports", EmitDefaultValue=false)]
        public bool? PrintOnCustomerFacingReports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAccountAssetAssemblyDetail {\n");
            sb.Append("  AccountAssetAssemblyDetailNumber: ").Append(AccountAssetAssemblyDetailNumber).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PurchasedFromUs: ").Append(PurchasedFromUs).Append("\n");
            sb.Append("  DatePurchased: ").Append(DatePurchased).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  WarrantyExpiration: ").Append(WarrantyExpiration).Append("\n");
            sb.Append("  ManufacturerWarrantyExpiration: ").Append(ManufacturerWarrantyExpiration).Append("\n");
            sb.Append("  VendorInvoiceNumber: ").Append(VendorInvoiceNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusComment: ").Append(StatusComment).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  TransferTo: ").Append(TransferTo).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  CreditMemoQuantity: ").Append(CreditMemoQuantity).Append("\n");
            sb.Append("  AllowExchange: ").Append(AllowExchange).Append("\n");
            sb.Append("  ItemExchangedFor: ").Append(ItemExchangedFor).Append("\n");
            sb.Append("  ExchangeNumber: ").Append(ExchangeNumber).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceDetailNumber: ").Append(InvoiceDetailNumber).Append("\n");
            sb.Append("  InvoiceAssemblyDetailNumber: ").Append(InvoiceAssemblyDetailNumber).Append("\n");
            sb.Append("  CreditMemoNumber: ").Append(CreditMemoNumber).Append("\n");
            sb.Append("  CreditMemoDetailNumber: ").Append(CreditMemoDetailNumber).Append("\n");
            sb.Append("  CreditMemoAssemblyDetailNumber: ").Append(CreditMemoAssemblyDetailNumber).Append("\n");
            sb.Append("  ManufacturerPartNumber: ").Append(ManufacturerPartNumber).Append("\n");
            sb.Append("  VendorAccountNumber: ").Append(VendorAccountNumber).Append("\n");
            sb.Append("  PurchasedFromVendorDate: ").Append(PurchasedFromVendorDate).Append("\n");
            sb.Append("  NextActionDate: ").Append(NextActionDate).Append("\n");
            sb.Append("  NextActionType: ").Append(NextActionType).Append("\n");
            sb.Append("  NextActionTriggersWorkflow: ").Append(NextActionTriggersWorkflow).Append("\n");
            sb.Append("  ReplacedByItemId: ").Append(ReplacedByItemId).Append("\n");
            sb.Append("  WarrantyExpirationTriggersWorkflow: ").Append(WarrantyExpirationTriggersWorkflow).Append("\n");
            sb.Append("  PrintOnCustomerFacingReports: ").Append(PrintOnCustomerFacingReports).Append("\n");
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
            return this.Equals(input as TsiWebAccountAssetAssemblyDetail);
        }

        /// <summary>
        /// Returns true if TsiWebAccountAssetAssemblyDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAccountAssetAssemblyDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAccountAssetAssemblyDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountAssetAssemblyDetailNumber == input.AccountAssetAssemblyDetailNumber ||
                    (this.AccountAssetAssemblyDetailNumber != null &&
                    this.AccountAssetAssemblyDetailNumber.Equals(input.AccountAssetAssemblyDetailNumber))
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
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.PurchasedFromUs == input.PurchasedFromUs ||
                    (this.PurchasedFromUs != null &&
                    this.PurchasedFromUs.Equals(input.PurchasedFromUs))
                ) && 
                (
                    this.DatePurchased == input.DatePurchased ||
                    (this.DatePurchased != null &&
                    this.DatePurchased.Equals(input.DatePurchased))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.WarrantyExpiration == input.WarrantyExpiration ||
                    (this.WarrantyExpiration != null &&
                    this.WarrantyExpiration.Equals(input.WarrantyExpiration))
                ) && 
                (
                    this.ManufacturerWarrantyExpiration == input.ManufacturerWarrantyExpiration ||
                    (this.ManufacturerWarrantyExpiration != null &&
                    this.ManufacturerWarrantyExpiration.Equals(input.ManufacturerWarrantyExpiration))
                ) && 
                (
                    this.VendorInvoiceNumber == input.VendorInvoiceNumber ||
                    (this.VendorInvoiceNumber != null &&
                    this.VendorInvoiceNumber.Equals(input.VendorInvoiceNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusComment == input.StatusComment ||
                    (this.StatusComment != null &&
                    this.StatusComment.Equals(input.StatusComment))
                ) && 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.TransferTo == input.TransferTo ||
                    (this.TransferTo != null &&
                    this.TransferTo.Equals(input.TransferTo))
                ) && 
                (
                    this.TransferDate == input.TransferDate ||
                    (this.TransferDate != null &&
                    this.TransferDate.Equals(input.TransferDate))
                ) && 
                (
                    this.CreditMemoQuantity == input.CreditMemoQuantity ||
                    (this.CreditMemoQuantity != null &&
                    this.CreditMemoQuantity.Equals(input.CreditMemoQuantity))
                ) && 
                (
                    this.AllowExchange == input.AllowExchange ||
                    (this.AllowExchange != null &&
                    this.AllowExchange.Equals(input.AllowExchange))
                ) && 
                (
                    this.ItemExchangedFor == input.ItemExchangedFor ||
                    (this.ItemExchangedFor != null &&
                    this.ItemExchangedFor.Equals(input.ItemExchangedFor))
                ) && 
                (
                    this.ExchangeNumber == input.ExchangeNumber ||
                    (this.ExchangeNumber != null &&
                    this.ExchangeNumber.Equals(input.ExchangeNumber))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.InvoiceDetailNumber == input.InvoiceDetailNumber ||
                    (this.InvoiceDetailNumber != null &&
                    this.InvoiceDetailNumber.Equals(input.InvoiceDetailNumber))
                ) && 
                (
                    this.InvoiceAssemblyDetailNumber == input.InvoiceAssemblyDetailNumber ||
                    (this.InvoiceAssemblyDetailNumber != null &&
                    this.InvoiceAssemblyDetailNumber.Equals(input.InvoiceAssemblyDetailNumber))
                ) && 
                (
                    this.CreditMemoNumber == input.CreditMemoNumber ||
                    (this.CreditMemoNumber != null &&
                    this.CreditMemoNumber.Equals(input.CreditMemoNumber))
                ) && 
                (
                    this.CreditMemoDetailNumber == input.CreditMemoDetailNumber ||
                    (this.CreditMemoDetailNumber != null &&
                    this.CreditMemoDetailNumber.Equals(input.CreditMemoDetailNumber))
                ) && 
                (
                    this.CreditMemoAssemblyDetailNumber == input.CreditMemoAssemblyDetailNumber ||
                    (this.CreditMemoAssemblyDetailNumber != null &&
                    this.CreditMemoAssemblyDetailNumber.Equals(input.CreditMemoAssemblyDetailNumber))
                ) && 
                (
                    this.ManufacturerPartNumber == input.ManufacturerPartNumber ||
                    (this.ManufacturerPartNumber != null &&
                    this.ManufacturerPartNumber.Equals(input.ManufacturerPartNumber))
                ) && 
                (
                    this.VendorAccountNumber == input.VendorAccountNumber ||
                    (this.VendorAccountNumber != null &&
                    this.VendorAccountNumber.Equals(input.VendorAccountNumber))
                ) && 
                (
                    this.PurchasedFromVendorDate == input.PurchasedFromVendorDate ||
                    (this.PurchasedFromVendorDate != null &&
                    this.PurchasedFromVendorDate.Equals(input.PurchasedFromVendorDate))
                ) && 
                (
                    this.NextActionDate == input.NextActionDate ||
                    (this.NextActionDate != null &&
                    this.NextActionDate.Equals(input.NextActionDate))
                ) && 
                (
                    this.NextActionType == input.NextActionType ||
                    (this.NextActionType != null &&
                    this.NextActionType.Equals(input.NextActionType))
                ) && 
                (
                    this.NextActionTriggersWorkflow == input.NextActionTriggersWorkflow ||
                    (this.NextActionTriggersWorkflow != null &&
                    this.NextActionTriggersWorkflow.Equals(input.NextActionTriggersWorkflow))
                ) && 
                (
                    this.ReplacedByItemId == input.ReplacedByItemId ||
                    (this.ReplacedByItemId != null &&
                    this.ReplacedByItemId.Equals(input.ReplacedByItemId))
                ) && 
                (
                    this.WarrantyExpirationTriggersWorkflow == input.WarrantyExpirationTriggersWorkflow ||
                    (this.WarrantyExpirationTriggersWorkflow != null &&
                    this.WarrantyExpirationTriggersWorkflow.Equals(input.WarrantyExpirationTriggersWorkflow))
                ) && 
                (
                    this.PrintOnCustomerFacingReports == input.PrintOnCustomerFacingReports ||
                    (this.PrintOnCustomerFacingReports != null &&
                    this.PrintOnCustomerFacingReports.Equals(input.PrintOnCustomerFacingReports))
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
                if (this.AccountAssetAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.AccountAssetAssemblyDetailNumber.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.PurchasedFromUs != null)
                    hashCode = hashCode * 59 + this.PurchasedFromUs.GetHashCode();
                if (this.DatePurchased != null)
                    hashCode = hashCode * 59 + this.DatePurchased.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.WarrantyExpiration != null)
                    hashCode = hashCode * 59 + this.WarrantyExpiration.GetHashCode();
                if (this.ManufacturerWarrantyExpiration != null)
                    hashCode = hashCode * 59 + this.ManufacturerWarrantyExpiration.GetHashCode();
                if (this.VendorInvoiceNumber != null)
                    hashCode = hashCode * 59 + this.VendorInvoiceNumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusComment != null)
                    hashCode = hashCode * 59 + this.StatusComment.GetHashCode();
                if (this.StatusDate != null)
                    hashCode = hashCode * 59 + this.StatusDate.GetHashCode();
                if (this.TransferTo != null)
                    hashCode = hashCode * 59 + this.TransferTo.GetHashCode();
                if (this.TransferDate != null)
                    hashCode = hashCode * 59 + this.TransferDate.GetHashCode();
                if (this.CreditMemoQuantity != null)
                    hashCode = hashCode * 59 + this.CreditMemoQuantity.GetHashCode();
                if (this.AllowExchange != null)
                    hashCode = hashCode * 59 + this.AllowExchange.GetHashCode();
                if (this.ItemExchangedFor != null)
                    hashCode = hashCode * 59 + this.ItemExchangedFor.GetHashCode();
                if (this.ExchangeNumber != null)
                    hashCode = hashCode * 59 + this.ExchangeNumber.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.InvoiceDetailNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceDetailNumber.GetHashCode();
                if (this.InvoiceAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceAssemblyDetailNumber.GetHashCode();
                if (this.CreditMemoNumber != null)
                    hashCode = hashCode * 59 + this.CreditMemoNumber.GetHashCode();
                if (this.CreditMemoDetailNumber != null)
                    hashCode = hashCode * 59 + this.CreditMemoDetailNumber.GetHashCode();
                if (this.CreditMemoAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.CreditMemoAssemblyDetailNumber.GetHashCode();
                if (this.ManufacturerPartNumber != null)
                    hashCode = hashCode * 59 + this.ManufacturerPartNumber.GetHashCode();
                if (this.VendorAccountNumber != null)
                    hashCode = hashCode * 59 + this.VendorAccountNumber.GetHashCode();
                if (this.PurchasedFromVendorDate != null)
                    hashCode = hashCode * 59 + this.PurchasedFromVendorDate.GetHashCode();
                if (this.NextActionDate != null)
                    hashCode = hashCode * 59 + this.NextActionDate.GetHashCode();
                if (this.NextActionType != null)
                    hashCode = hashCode * 59 + this.NextActionType.GetHashCode();
                if (this.NextActionTriggersWorkflow != null)
                    hashCode = hashCode * 59 + this.NextActionTriggersWorkflow.GetHashCode();
                if (this.ReplacedByItemId != null)
                    hashCode = hashCode * 59 + this.ReplacedByItemId.GetHashCode();
                if (this.WarrantyExpirationTriggersWorkflow != null)
                    hashCode = hashCode * 59 + this.WarrantyExpirationTriggersWorkflow.GetHashCode();
                if (this.PrintOnCustomerFacingReports != null)
                    hashCode = hashCode * 59 + this.PrintOnCustomerFacingReports.GetHashCode();
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
