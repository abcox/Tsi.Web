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
    /// TsiWebPurchaseOrder
    /// </summary>
    [DataContract]
    public partial class TsiWebPurchaseOrder :  IEquatable<TsiWebPurchaseOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebPurchaseOrder" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="reference">reference.</param>
        /// <param name="purchaseOrderDate">purchaseOrderDate.</param>
        /// <param name="confirmedBy">confirmedBy.</param>
        /// <param name="confirmedDate">confirmedDate.</param>
        /// <param name="hasBeenPrinted">hasBeenPrinted.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDate">statusDate.</param>
        /// <param name="buyingRepNumber">buyingRepNumber.</param>
        /// <param name="buyingRepName">buyingRepName.</param>
        /// <param name="comments">comments.</param>
        /// <param name="orderTerms">orderTerms.</param>
        /// <param name="freightTerms">freightTerms.</param>
        /// <param name="shippingMethod">shippingMethod.</param>
        /// <param name="updateLatestCost">updateLatestCost.</param>
        /// <param name="allowBackOrders">allowBackOrders.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="projectedTotalInventory">projectedTotalInventory.</param>
        /// <param name="projectedCost">projectedCost.</param>
        /// <param name="expectedDate">expectedDate.</param>
        /// <param name="defaultReceivingLocation">defaultReceivingLocation.</param>
        /// <param name="defaultCostLevel">defaultCostLevel.</param>
        /// <param name="orderIdentificationNumber">orderIdentificationNumber.</param>
        /// <param name="invoiceTerms">invoiceTerms.</param>
        /// <param name="freight">freight.</param>
        /// <param name="blindShip">blindShip.</param>
        /// <param name="trackingNumber">trackingNumber.</param>
        /// <param name="requestedRepNumber">requestedRepNumber.</param>
        /// <param name="requestedRepName">requestedRepName.</param>
        /// <param name="linkedAccountNumber">linkedAccountNumber.</param>
        /// <param name="linkedQuoteNumber">linkedQuoteNumber.</param>
        /// <param name="linkedServiceOrderNumber">linkedServiceOrderNumber.</param>
        /// <param name="paidInFull">paidInFull.</param>
        /// <param name="internalComments">internalComments.</param>
        /// <param name="vendorAccountNumber">vendorAccountNumber.</param>
        /// <param name="purchaseOrderWasAddedToBatch">purchaseOrderWasAddedToBatch.</param>
        /// <param name="projectNumber">projectNumber.</param>
        /// <param name="shipper">shipper.</param>
        /// <param name="defaultReceivingBin">defaultReceivingBin.</param>
        /// <param name="shipTo">shipTo.</param>
        /// <param name="billTo">billTo.</param>
        public TsiWebPurchaseOrder(string description = default(string), string reference = default(string), DateTime? purchaseOrderDate = default(DateTime?), string confirmedBy = default(string), DateTime? confirmedDate = default(DateTime?), bool? hasBeenPrinted = default(bool?), string status = default(string), DateTime? statusDate = default(DateTime?), int? buyingRepNumber = default(int?), string buyingRepName = default(string), string comments = default(string), string orderTerms = default(string), string freightTerms = default(string), string shippingMethod = default(string), bool? updateLatestCost = default(bool?), bool? allowBackOrders = default(bool?), int? lineItems = default(int?), double? projectedTotalInventory = default(double?), double? projectedCost = default(double?), DateTime? expectedDate = default(DateTime?), string defaultReceivingLocation = default(string), string defaultCostLevel = default(string), string orderIdentificationNumber = default(string), string invoiceTerms = default(string), double? freight = default(double?), bool? blindShip = default(bool?), string trackingNumber = default(string), int? requestedRepNumber = default(int?), string requestedRepName = default(string), int? linkedAccountNumber = default(int?), int? linkedQuoteNumber = default(int?), int? linkedServiceOrderNumber = default(int?), bool? paidInFull = default(bool?), string internalComments = default(string), int? vendorAccountNumber = default(int?), bool? purchaseOrderWasAddedToBatch = default(bool?), int? projectNumber = default(int?), string shipper = default(string), string defaultReceivingBin = default(string), TsiWebAlternateAddress shipTo = default(TsiWebAlternateAddress), TsiWebAlternateAddress billTo = default(TsiWebAlternateAddress))
        {
            this.Description = description;
            this.Reference = reference;
            this.PurchaseOrderDate = purchaseOrderDate;
            this.ConfirmedBy = confirmedBy;
            this.ConfirmedDate = confirmedDate;
            this.HasBeenPrinted = hasBeenPrinted;
            this.Status = status;
            this.StatusDate = statusDate;
            this.BuyingRepNumber = buyingRepNumber;
            this.BuyingRepName = buyingRepName;
            this.Comments = comments;
            this.OrderTerms = orderTerms;
            this.FreightTerms = freightTerms;
            this.ShippingMethod = shippingMethod;
            this.UpdateLatestCost = updateLatestCost;
            this.AllowBackOrders = allowBackOrders;
            this.LineItems = lineItems;
            this.ProjectedTotalInventory = projectedTotalInventory;
            this.ProjectedCost = projectedCost;
            this.ExpectedDate = expectedDate;
            this.DefaultReceivingLocation = defaultReceivingLocation;
            this.DefaultCostLevel = defaultCostLevel;
            this.OrderIdentificationNumber = orderIdentificationNumber;
            this.InvoiceTerms = invoiceTerms;
            this.Freight = freight;
            this.BlindShip = blindShip;
            this.TrackingNumber = trackingNumber;
            this.RequestedRepNumber = requestedRepNumber;
            this.RequestedRepName = requestedRepName;
            this.LinkedAccountNumber = linkedAccountNumber;
            this.LinkedQuoteNumber = linkedQuoteNumber;
            this.LinkedServiceOrderNumber = linkedServiceOrderNumber;
            this.PaidInFull = paidInFull;
            this.InternalComments = internalComments;
            this.VendorAccountNumber = vendorAccountNumber;
            this.PurchaseOrderWasAddedToBatch = purchaseOrderWasAddedToBatch;
            this.ProjectNumber = projectNumber;
            this.Shipper = shipper;
            this.DefaultReceivingBin = defaultReceivingBin;
            this.ShipTo = shipTo;
            this.BillTo = billTo;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderDate
        /// </summary>
        [DataMember(Name="PurchaseOrderDate", EmitDefaultValue=false)]
        public DateTime? PurchaseOrderDate { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedBy
        /// </summary>
        [DataMember(Name="ConfirmedBy", EmitDefaultValue=false)]
        public string ConfirmedBy { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedDate
        /// </summary>
        [DataMember(Name="ConfirmedDate", EmitDefaultValue=false)]
        public DateTime? ConfirmedDate { get; set; }

        /// <summary>
        /// Gets or Sets HasBeenPrinted
        /// </summary>
        [DataMember(Name="HasBeenPrinted", EmitDefaultValue=false)]
        public bool? HasBeenPrinted { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name="StatusDate", EmitDefaultValue=false)]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets BuyingRepNumber
        /// </summary>
        [DataMember(Name="BuyingRepNumber", EmitDefaultValue=false)]
        public int? BuyingRepNumber { get; set; }

        /// <summary>
        /// Gets or Sets BuyingRepName
        /// </summary>
        [DataMember(Name="BuyingRepName", EmitDefaultValue=false)]
        public string BuyingRepName { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets OrderTerms
        /// </summary>
        [DataMember(Name="OrderTerms", EmitDefaultValue=false)]
        public string OrderTerms { get; set; }

        /// <summary>
        /// Gets or Sets FreightTerms
        /// </summary>
        [DataMember(Name="FreightTerms", EmitDefaultValue=false)]
        public string FreightTerms { get; set; }

        /// <summary>
        /// Gets or Sets ShippingMethod
        /// </summary>
        [DataMember(Name="ShippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Gets or Sets UpdateLatestCost
        /// </summary>
        [DataMember(Name="UpdateLatestCost", EmitDefaultValue=false)]
        public bool? UpdateLatestCost { get; set; }

        /// <summary>
        /// Gets or Sets AllowBackOrders
        /// </summary>
        [DataMember(Name="AllowBackOrders", EmitDefaultValue=false)]
        public bool? AllowBackOrders { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public int? LineItems { get; set; }

        /// <summary>
        /// Gets or Sets ProjectedTotalInventory
        /// </summary>
        [DataMember(Name="ProjectedTotalInventory", EmitDefaultValue=false)]
        public double? ProjectedTotalInventory { get; set; }

        /// <summary>
        /// Gets or Sets ProjectedCost
        /// </summary>
        [DataMember(Name="ProjectedCost", EmitDefaultValue=false)]
        public double? ProjectedCost { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedDate
        /// </summary>
        [DataMember(Name="ExpectedDate", EmitDefaultValue=false)]
        public DateTime? ExpectedDate { get; set; }

        /// <summary>
        /// Gets or Sets DefaultReceivingLocation
        /// </summary>
        [DataMember(Name="DefaultReceivingLocation", EmitDefaultValue=false)]
        public string DefaultReceivingLocation { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCostLevel
        /// </summary>
        [DataMember(Name="DefaultCostLevel", EmitDefaultValue=false)]
        public string DefaultCostLevel { get; set; }

        /// <summary>
        /// Gets or Sets OrderIdentificationNumber
        /// </summary>
        [DataMember(Name="OrderIdentificationNumber", EmitDefaultValue=false)]
        public string OrderIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceTerms
        /// </summary>
        [DataMember(Name="InvoiceTerms", EmitDefaultValue=false)]
        public string InvoiceTerms { get; set; }

        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="Freight", EmitDefaultValue=false)]
        public double? Freight { get; set; }

        /// <summary>
        /// Gets or Sets BlindShip
        /// </summary>
        [DataMember(Name="BlindShip", EmitDefaultValue=false)]
        public bool? BlindShip { get; set; }

        /// <summary>
        /// Gets or Sets TrackingNumber
        /// </summary>
        [DataMember(Name="TrackingNumber", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Gets or Sets RequestedRepNumber
        /// </summary>
        [DataMember(Name="RequestedRepNumber", EmitDefaultValue=false)]
        public int? RequestedRepNumber { get; set; }

        /// <summary>
        /// Gets or Sets RequestedRepName
        /// </summary>
        [DataMember(Name="RequestedRepName", EmitDefaultValue=false)]
        public string RequestedRepName { get; set; }

        /// <summary>
        /// Gets or Sets LinkedAccountNumber
        /// </summary>
        [DataMember(Name="LinkedAccountNumber", EmitDefaultValue=false)]
        public int? LinkedAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets LinkedQuoteNumber
        /// </summary>
        [DataMember(Name="LinkedQuoteNumber", EmitDefaultValue=false)]
        public int? LinkedQuoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets LinkedServiceOrderNumber
        /// </summary>
        [DataMember(Name="LinkedServiceOrderNumber", EmitDefaultValue=false)]
        public int? LinkedServiceOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaidInFull
        /// </summary>
        [DataMember(Name="PaidInFull", EmitDefaultValue=false)]
        public bool? PaidInFull { get; set; }

        /// <summary>
        /// Gets or Sets InternalComments
        /// </summary>
        [DataMember(Name="InternalComments", EmitDefaultValue=false)]
        public string InternalComments { get; set; }

        /// <summary>
        /// Gets or Sets VendorAccountNumber
        /// </summary>
        [DataMember(Name="VendorAccountNumber", EmitDefaultValue=false)]
        public int? VendorAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderWasAddedToBatch
        /// </summary>
        [DataMember(Name="PurchaseOrderWasAddedToBatch", EmitDefaultValue=false)]
        public bool? PurchaseOrderWasAddedToBatch { get; set; }

        /// <summary>
        /// Gets or Sets ProjectNumber
        /// </summary>
        [DataMember(Name="ProjectNumber", EmitDefaultValue=false)]
        public int? ProjectNumber { get; set; }

        /// <summary>
        /// Gets or Sets Shipper
        /// </summary>
        [DataMember(Name="Shipper", EmitDefaultValue=false)]
        public string Shipper { get; set; }

        /// <summary>
        /// Gets or Sets DefaultReceivingBin
        /// </summary>
        [DataMember(Name="DefaultReceivingBin", EmitDefaultValue=false)]
        public string DefaultReceivingBin { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="ShipTo", EmitDefaultValue=false)]
        public TsiWebAlternateAddress ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="BillTo", EmitDefaultValue=false)]
        public TsiWebAlternateAddress BillTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebPurchaseOrder {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  PurchaseOrderDate: ").Append(PurchaseOrderDate).Append("\n");
            sb.Append("  ConfirmedBy: ").Append(ConfirmedBy).Append("\n");
            sb.Append("  ConfirmedDate: ").Append(ConfirmedDate).Append("\n");
            sb.Append("  HasBeenPrinted: ").Append(HasBeenPrinted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  BuyingRepNumber: ").Append(BuyingRepNumber).Append("\n");
            sb.Append("  BuyingRepName: ").Append(BuyingRepName).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  OrderTerms: ").Append(OrderTerms).Append("\n");
            sb.Append("  FreightTerms: ").Append(FreightTerms).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  UpdateLatestCost: ").Append(UpdateLatestCost).Append("\n");
            sb.Append("  AllowBackOrders: ").Append(AllowBackOrders).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ProjectedTotalInventory: ").Append(ProjectedTotalInventory).Append("\n");
            sb.Append("  ProjectedCost: ").Append(ProjectedCost).Append("\n");
            sb.Append("  ExpectedDate: ").Append(ExpectedDate).Append("\n");
            sb.Append("  DefaultReceivingLocation: ").Append(DefaultReceivingLocation).Append("\n");
            sb.Append("  DefaultCostLevel: ").Append(DefaultCostLevel).Append("\n");
            sb.Append("  OrderIdentificationNumber: ").Append(OrderIdentificationNumber).Append("\n");
            sb.Append("  InvoiceTerms: ").Append(InvoiceTerms).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("  BlindShip: ").Append(BlindShip).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  RequestedRepNumber: ").Append(RequestedRepNumber).Append("\n");
            sb.Append("  RequestedRepName: ").Append(RequestedRepName).Append("\n");
            sb.Append("  LinkedAccountNumber: ").Append(LinkedAccountNumber).Append("\n");
            sb.Append("  LinkedQuoteNumber: ").Append(LinkedQuoteNumber).Append("\n");
            sb.Append("  LinkedServiceOrderNumber: ").Append(LinkedServiceOrderNumber).Append("\n");
            sb.Append("  PaidInFull: ").Append(PaidInFull).Append("\n");
            sb.Append("  InternalComments: ").Append(InternalComments).Append("\n");
            sb.Append("  VendorAccountNumber: ").Append(VendorAccountNumber).Append("\n");
            sb.Append("  PurchaseOrderWasAddedToBatch: ").Append(PurchaseOrderWasAddedToBatch).Append("\n");
            sb.Append("  ProjectNumber: ").Append(ProjectNumber).Append("\n");
            sb.Append("  Shipper: ").Append(Shipper).Append("\n");
            sb.Append("  DefaultReceivingBin: ").Append(DefaultReceivingBin).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
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
            return this.Equals(input as TsiWebPurchaseOrder);
        }

        /// <summary>
        /// Returns true if TsiWebPurchaseOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebPurchaseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebPurchaseOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.PurchaseOrderDate == input.PurchaseOrderDate ||
                    (this.PurchaseOrderDate != null &&
                    this.PurchaseOrderDate.Equals(input.PurchaseOrderDate))
                ) && 
                (
                    this.ConfirmedBy == input.ConfirmedBy ||
                    (this.ConfirmedBy != null &&
                    this.ConfirmedBy.Equals(input.ConfirmedBy))
                ) && 
                (
                    this.ConfirmedDate == input.ConfirmedDate ||
                    (this.ConfirmedDate != null &&
                    this.ConfirmedDate.Equals(input.ConfirmedDate))
                ) && 
                (
                    this.HasBeenPrinted == input.HasBeenPrinted ||
                    (this.HasBeenPrinted != null &&
                    this.HasBeenPrinted.Equals(input.HasBeenPrinted))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.BuyingRepNumber == input.BuyingRepNumber ||
                    (this.BuyingRepNumber != null &&
                    this.BuyingRepNumber.Equals(input.BuyingRepNumber))
                ) && 
                (
                    this.BuyingRepName == input.BuyingRepName ||
                    (this.BuyingRepName != null &&
                    this.BuyingRepName.Equals(input.BuyingRepName))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.OrderTerms == input.OrderTerms ||
                    (this.OrderTerms != null &&
                    this.OrderTerms.Equals(input.OrderTerms))
                ) && 
                (
                    this.FreightTerms == input.FreightTerms ||
                    (this.FreightTerms != null &&
                    this.FreightTerms.Equals(input.FreightTerms))
                ) && 
                (
                    this.ShippingMethod == input.ShippingMethod ||
                    (this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(input.ShippingMethod))
                ) && 
                (
                    this.UpdateLatestCost == input.UpdateLatestCost ||
                    (this.UpdateLatestCost != null &&
                    this.UpdateLatestCost.Equals(input.UpdateLatestCost))
                ) && 
                (
                    this.AllowBackOrders == input.AllowBackOrders ||
                    (this.AllowBackOrders != null &&
                    this.AllowBackOrders.Equals(input.AllowBackOrders))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    (this.LineItems != null &&
                    this.LineItems.Equals(input.LineItems))
                ) && 
                (
                    this.ProjectedTotalInventory == input.ProjectedTotalInventory ||
                    (this.ProjectedTotalInventory != null &&
                    this.ProjectedTotalInventory.Equals(input.ProjectedTotalInventory))
                ) && 
                (
                    this.ProjectedCost == input.ProjectedCost ||
                    (this.ProjectedCost != null &&
                    this.ProjectedCost.Equals(input.ProjectedCost))
                ) && 
                (
                    this.ExpectedDate == input.ExpectedDate ||
                    (this.ExpectedDate != null &&
                    this.ExpectedDate.Equals(input.ExpectedDate))
                ) && 
                (
                    this.DefaultReceivingLocation == input.DefaultReceivingLocation ||
                    (this.DefaultReceivingLocation != null &&
                    this.DefaultReceivingLocation.Equals(input.DefaultReceivingLocation))
                ) && 
                (
                    this.DefaultCostLevel == input.DefaultCostLevel ||
                    (this.DefaultCostLevel != null &&
                    this.DefaultCostLevel.Equals(input.DefaultCostLevel))
                ) && 
                (
                    this.OrderIdentificationNumber == input.OrderIdentificationNumber ||
                    (this.OrderIdentificationNumber != null &&
                    this.OrderIdentificationNumber.Equals(input.OrderIdentificationNumber))
                ) && 
                (
                    this.InvoiceTerms == input.InvoiceTerms ||
                    (this.InvoiceTerms != null &&
                    this.InvoiceTerms.Equals(input.InvoiceTerms))
                ) && 
                (
                    this.Freight == input.Freight ||
                    (this.Freight != null &&
                    this.Freight.Equals(input.Freight))
                ) && 
                (
                    this.BlindShip == input.BlindShip ||
                    (this.BlindShip != null &&
                    this.BlindShip.Equals(input.BlindShip))
                ) && 
                (
                    this.TrackingNumber == input.TrackingNumber ||
                    (this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(input.TrackingNumber))
                ) && 
                (
                    this.RequestedRepNumber == input.RequestedRepNumber ||
                    (this.RequestedRepNumber != null &&
                    this.RequestedRepNumber.Equals(input.RequestedRepNumber))
                ) && 
                (
                    this.RequestedRepName == input.RequestedRepName ||
                    (this.RequestedRepName != null &&
                    this.RequestedRepName.Equals(input.RequestedRepName))
                ) && 
                (
                    this.LinkedAccountNumber == input.LinkedAccountNumber ||
                    (this.LinkedAccountNumber != null &&
                    this.LinkedAccountNumber.Equals(input.LinkedAccountNumber))
                ) && 
                (
                    this.LinkedQuoteNumber == input.LinkedQuoteNumber ||
                    (this.LinkedQuoteNumber != null &&
                    this.LinkedQuoteNumber.Equals(input.LinkedQuoteNumber))
                ) && 
                (
                    this.LinkedServiceOrderNumber == input.LinkedServiceOrderNumber ||
                    (this.LinkedServiceOrderNumber != null &&
                    this.LinkedServiceOrderNumber.Equals(input.LinkedServiceOrderNumber))
                ) && 
                (
                    this.PaidInFull == input.PaidInFull ||
                    (this.PaidInFull != null &&
                    this.PaidInFull.Equals(input.PaidInFull))
                ) && 
                (
                    this.InternalComments == input.InternalComments ||
                    (this.InternalComments != null &&
                    this.InternalComments.Equals(input.InternalComments))
                ) && 
                (
                    this.VendorAccountNumber == input.VendorAccountNumber ||
                    (this.VendorAccountNumber != null &&
                    this.VendorAccountNumber.Equals(input.VendorAccountNumber))
                ) && 
                (
                    this.PurchaseOrderWasAddedToBatch == input.PurchaseOrderWasAddedToBatch ||
                    (this.PurchaseOrderWasAddedToBatch != null &&
                    this.PurchaseOrderWasAddedToBatch.Equals(input.PurchaseOrderWasAddedToBatch))
                ) && 
                (
                    this.ProjectNumber == input.ProjectNumber ||
                    (this.ProjectNumber != null &&
                    this.ProjectNumber.Equals(input.ProjectNumber))
                ) && 
                (
                    this.Shipper == input.Shipper ||
                    (this.Shipper != null &&
                    this.Shipper.Equals(input.Shipper))
                ) && 
                (
                    this.DefaultReceivingBin == input.DefaultReceivingBin ||
                    (this.DefaultReceivingBin != null &&
                    this.DefaultReceivingBin.Equals(input.DefaultReceivingBin))
                ) && 
                (
                    this.ShipTo == input.ShipTo ||
                    (this.ShipTo != null &&
                    this.ShipTo.Equals(input.ShipTo))
                ) && 
                (
                    this.BillTo == input.BillTo ||
                    (this.BillTo != null &&
                    this.BillTo.Equals(input.BillTo))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.PurchaseOrderDate != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderDate.GetHashCode();
                if (this.ConfirmedBy != null)
                    hashCode = hashCode * 59 + this.ConfirmedBy.GetHashCode();
                if (this.ConfirmedDate != null)
                    hashCode = hashCode * 59 + this.ConfirmedDate.GetHashCode();
                if (this.HasBeenPrinted != null)
                    hashCode = hashCode * 59 + this.HasBeenPrinted.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDate != null)
                    hashCode = hashCode * 59 + this.StatusDate.GetHashCode();
                if (this.BuyingRepNumber != null)
                    hashCode = hashCode * 59 + this.BuyingRepNumber.GetHashCode();
                if (this.BuyingRepName != null)
                    hashCode = hashCode * 59 + this.BuyingRepName.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.OrderTerms != null)
                    hashCode = hashCode * 59 + this.OrderTerms.GetHashCode();
                if (this.FreightTerms != null)
                    hashCode = hashCode * 59 + this.FreightTerms.GetHashCode();
                if (this.ShippingMethod != null)
                    hashCode = hashCode * 59 + this.ShippingMethod.GetHashCode();
                if (this.UpdateLatestCost != null)
                    hashCode = hashCode * 59 + this.UpdateLatestCost.GetHashCode();
                if (this.AllowBackOrders != null)
                    hashCode = hashCode * 59 + this.AllowBackOrders.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.ProjectedTotalInventory != null)
                    hashCode = hashCode * 59 + this.ProjectedTotalInventory.GetHashCode();
                if (this.ProjectedCost != null)
                    hashCode = hashCode * 59 + this.ProjectedCost.GetHashCode();
                if (this.ExpectedDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDate.GetHashCode();
                if (this.DefaultReceivingLocation != null)
                    hashCode = hashCode * 59 + this.DefaultReceivingLocation.GetHashCode();
                if (this.DefaultCostLevel != null)
                    hashCode = hashCode * 59 + this.DefaultCostLevel.GetHashCode();
                if (this.OrderIdentificationNumber != null)
                    hashCode = hashCode * 59 + this.OrderIdentificationNumber.GetHashCode();
                if (this.InvoiceTerms != null)
                    hashCode = hashCode * 59 + this.InvoiceTerms.GetHashCode();
                if (this.Freight != null)
                    hashCode = hashCode * 59 + this.Freight.GetHashCode();
                if (this.BlindShip != null)
                    hashCode = hashCode * 59 + this.BlindShip.GetHashCode();
                if (this.TrackingNumber != null)
                    hashCode = hashCode * 59 + this.TrackingNumber.GetHashCode();
                if (this.RequestedRepNumber != null)
                    hashCode = hashCode * 59 + this.RequestedRepNumber.GetHashCode();
                if (this.RequestedRepName != null)
                    hashCode = hashCode * 59 + this.RequestedRepName.GetHashCode();
                if (this.LinkedAccountNumber != null)
                    hashCode = hashCode * 59 + this.LinkedAccountNumber.GetHashCode();
                if (this.LinkedQuoteNumber != null)
                    hashCode = hashCode * 59 + this.LinkedQuoteNumber.GetHashCode();
                if (this.LinkedServiceOrderNumber != null)
                    hashCode = hashCode * 59 + this.LinkedServiceOrderNumber.GetHashCode();
                if (this.PaidInFull != null)
                    hashCode = hashCode * 59 + this.PaidInFull.GetHashCode();
                if (this.InternalComments != null)
                    hashCode = hashCode * 59 + this.InternalComments.GetHashCode();
                if (this.VendorAccountNumber != null)
                    hashCode = hashCode * 59 + this.VendorAccountNumber.GetHashCode();
                if (this.PurchaseOrderWasAddedToBatch != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderWasAddedToBatch.GetHashCode();
                if (this.ProjectNumber != null)
                    hashCode = hashCode * 59 + this.ProjectNumber.GetHashCode();
                if (this.Shipper != null)
                    hashCode = hashCode * 59 + this.Shipper.GetHashCode();
                if (this.DefaultReceivingBin != null)
                    hashCode = hashCode * 59 + this.DefaultReceivingBin.GetHashCode();
                if (this.ShipTo != null)
                    hashCode = hashCode * 59 + this.ShipTo.GetHashCode();
                if (this.BillTo != null)
                    hashCode = hashCode * 59 + this.BillTo.GetHashCode();
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