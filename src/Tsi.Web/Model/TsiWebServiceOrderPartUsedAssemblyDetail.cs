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
    /// TsiWebServiceOrderPartUsedAssemblyDetail
    /// </summary>
    [DataContract]
    public partial class TsiWebServiceOrderPartUsedAssemblyDetail :  IEquatable<TsiWebServiceOrderPartUsedAssemblyDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebServiceOrderPartUsedAssemblyDetail" /> class.
        /// </summary>
        /// <param name="partUsedAssemblyDetailNumber">partUsedAssemblyDetailNumber.</param>
        /// <param name="invoiceAssemblyDetailNumber">invoiceAssemblyDetailNumber.</param>
        /// <param name="eachQuantity">eachQuantity.</param>
        /// <param name="itemID">itemID.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="memo">memo.</param>
        /// <param name="costGLCode">costGLCode.</param>
        /// <param name="incomeGLCode">incomeGLCode.</param>
        /// <param name="rMANumber">rMANumber.</param>
        /// <param name="type">type.</param>
        /// <param name="exchangeFlag">exchangeFlag.</param>
        /// <param name="gSTExempt">gSTExempt.</param>
        /// <param name="printOnInvoice">printOnInvoice.</param>
        /// <param name="subjectToProviderTax">subjectToProviderTax.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="underContract">underContract.</param>
        /// <param name="useThisCostWhenOrdering">useThisCostWhenOrdering.</param>
        /// <param name="wasTaxed">wasTaxed.</param>
        /// <param name="invoiceDate">invoiceDate.</param>
        /// <param name="orderByDate">orderByDate.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="quantityFilled">quantityFilled.</param>
        /// <param name="quantityInvoiced">quantityInvoiced.</param>
        /// <param name="quantityOrdered">quantityOrdered.</param>
        /// <param name="quantityPosted">quantityPosted.</param>
        /// <param name="quantityReceived">quantityReceived.</param>
        /// <param name="contractNumber">contractNumber.</param>
        /// <param name="exchangeNumber">exchangeNumber.</param>
        /// <param name="itemServicedNumber">itemServicedNumber.</param>
        /// <param name="invoiceNumber">invoiceNumber.</param>
        /// <param name="lineNumber">lineNumber.</param>
        /// <param name="priceLevel">priceLevel.</param>
        /// <param name="actualUnitCost">actualUnitCost.</param>
        /// <param name="cost">cost.</param>
        /// <param name="gSTaxableAmount">gSTaxableAmount.</param>
        /// <param name="manufacturerListPrice">manufacturerListPrice.</param>
        /// <param name="providerTaxableAmount">providerTaxableAmount.</param>
        /// <param name="sellingPrice">sellingPrice.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="totalCost">totalCost.</param>
        /// <param name="totalPostedCost">totalPostedCost.</param>
        /// <param name="totalSellingPrice">totalSellingPrice.</param>
        public TsiWebServiceOrderPartUsedAssemblyDetail(int? partUsedAssemblyDetailNumber = default(int?), int? invoiceAssemblyDetailNumber = default(int?), double? eachQuantity = default(double?), string itemID = default(string), string itemDescription = default(string), string memo = default(string), string costGLCode = default(string), string incomeGLCode = default(string), string rMANumber = default(string), string type = default(string), bool? exchangeFlag = default(bool?), bool? gSTExempt = default(bool?), bool? printOnInvoice = default(bool?), bool? subjectToProviderTax = default(bool?), bool? taxable = default(bool?), bool? underContract = default(bool?), bool? useThisCostWhenOrdering = default(bool?), bool? wasTaxed = default(bool?), DateTime? invoiceDate = default(DateTime?), DateTime? orderByDate = default(DateTime?), double? quantity = default(double?), double? quantityFilled = default(double?), double? quantityInvoiced = default(double?), double? quantityOrdered = default(double?), double? quantityPosted = default(double?), double? quantityReceived = default(double?), int? contractNumber = default(int?), int? exchangeNumber = default(int?), int? itemServicedNumber = default(int?), int? invoiceNumber = default(int?), int? lineNumber = default(int?), int? priceLevel = default(int?), double? actualUnitCost = default(double?), double? cost = default(double?), double? gSTaxableAmount = default(double?), double? manufacturerListPrice = default(double?), double? providerTaxableAmount = default(double?), double? sellingPrice = default(double?), double? taxableAmount = default(double?), double? totalCost = default(double?), double? totalPostedCost = default(double?), double? totalSellingPrice = default(double?))
        {
            this.PartUsedAssemblyDetailNumber = partUsedAssemblyDetailNumber;
            this.InvoiceAssemblyDetailNumber = invoiceAssemblyDetailNumber;
            this.EachQuantity = eachQuantity;
            this.ItemID = itemID;
            this.ItemDescription = itemDescription;
            this.Memo = memo;
            this.CostGLCode = costGLCode;
            this.IncomeGLCode = incomeGLCode;
            this.RMANumber = rMANumber;
            this.Type = type;
            this.ExchangeFlag = exchangeFlag;
            this.GSTExempt = gSTExempt;
            this.PrintOnInvoice = printOnInvoice;
            this.SubjectToProviderTax = subjectToProviderTax;
            this.Taxable = taxable;
            this.UnderContract = underContract;
            this.UseThisCostWhenOrdering = useThisCostWhenOrdering;
            this.WasTaxed = wasTaxed;
            this.InvoiceDate = invoiceDate;
            this.OrderByDate = orderByDate;
            this.Quantity = quantity;
            this.QuantityFilled = quantityFilled;
            this.QuantityInvoiced = quantityInvoiced;
            this.QuantityOrdered = quantityOrdered;
            this.QuantityPosted = quantityPosted;
            this.QuantityReceived = quantityReceived;
            this.ContractNumber = contractNumber;
            this.ExchangeNumber = exchangeNumber;
            this.ItemServicedNumber = itemServicedNumber;
            this.InvoiceNumber = invoiceNumber;
            this.LineNumber = lineNumber;
            this.PriceLevel = priceLevel;
            this.ActualUnitCost = actualUnitCost;
            this.Cost = cost;
            this.GSTaxableAmount = gSTaxableAmount;
            this.ManufacturerListPrice = manufacturerListPrice;
            this.ProviderTaxableAmount = providerTaxableAmount;
            this.SellingPrice = sellingPrice;
            this.TaxableAmount = taxableAmount;
            this.TotalCost = totalCost;
            this.TotalPostedCost = totalPostedCost;
            this.TotalSellingPrice = totalSellingPrice;
        }
        
        /// <summary>
        /// Gets or Sets PartUsedAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="PartUsedAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? PartUsedAssemblyDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceAssemblyDetailNumber
        /// </summary>
        [DataMember(Name="InvoiceAssemblyDetailNumber", EmitDefaultValue=false)]
        public int? InvoiceAssemblyDetailNumber { get; set; }

        /// <summary>
        /// Gets or Sets EachQuantity
        /// </summary>
        [DataMember(Name="EachQuantity", EmitDefaultValue=false)]
        public double? EachQuantity { get; set; }

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
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name="Memo", EmitDefaultValue=false)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets CostGLCode
        /// </summary>
        [DataMember(Name="CostGLCode", EmitDefaultValue=false)]
        public string CostGLCode { get; set; }

        /// <summary>
        /// Gets or Sets IncomeGLCode
        /// </summary>
        [DataMember(Name="IncomeGLCode", EmitDefaultValue=false)]
        public string IncomeGLCode { get; set; }

        /// <summary>
        /// Gets or Sets RMANumber
        /// </summary>
        [DataMember(Name="RMANumber", EmitDefaultValue=false)]
        public string RMANumber { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeFlag
        /// </summary>
        [DataMember(Name="ExchangeFlag", EmitDefaultValue=false)]
        public bool? ExchangeFlag { get; set; }

        /// <summary>
        /// Gets or Sets GSTExempt
        /// </summary>
        [DataMember(Name="GSTExempt", EmitDefaultValue=false)]
        public bool? GSTExempt { get; set; }

        /// <summary>
        /// Gets or Sets PrintOnInvoice
        /// </summary>
        [DataMember(Name="PrintOnInvoice", EmitDefaultValue=false)]
        public bool? PrintOnInvoice { get; set; }

        /// <summary>
        /// Gets or Sets SubjectToProviderTax
        /// </summary>
        [DataMember(Name="SubjectToProviderTax", EmitDefaultValue=false)]
        public bool? SubjectToProviderTax { get; set; }

        /// <summary>
        /// Gets or Sets Taxable
        /// </summary>
        [DataMember(Name="Taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Gets or Sets UnderContract
        /// </summary>
        [DataMember(Name="UnderContract", EmitDefaultValue=false)]
        public bool? UnderContract { get; set; }

        /// <summary>
        /// Gets or Sets UseThisCostWhenOrdering
        /// </summary>
        [DataMember(Name="UseThisCostWhenOrdering", EmitDefaultValue=false)]
        public bool? UseThisCostWhenOrdering { get; set; }

        /// <summary>
        /// Gets or Sets WasTaxed
        /// </summary>
        [DataMember(Name="WasTaxed", EmitDefaultValue=false)]
        public bool? WasTaxed { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderByDate
        /// </summary>
        [DataMember(Name="OrderByDate", EmitDefaultValue=false)]
        public DateTime? OrderByDate { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets QuantityFilled
        /// </summary>
        [DataMember(Name="QuantityFilled", EmitDefaultValue=false)]
        public double? QuantityFilled { get; set; }

        /// <summary>
        /// Gets or Sets QuantityInvoiced
        /// </summary>
        [DataMember(Name="QuantityInvoiced", EmitDefaultValue=false)]
        public double? QuantityInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets QuantityOrdered
        /// </summary>
        [DataMember(Name="QuantityOrdered", EmitDefaultValue=false)]
        public double? QuantityOrdered { get; set; }

        /// <summary>
        /// Gets or Sets QuantityPosted
        /// </summary>
        [DataMember(Name="QuantityPosted", EmitDefaultValue=false)]
        public double? QuantityPosted { get; set; }

        /// <summary>
        /// Gets or Sets QuantityReceived
        /// </summary>
        [DataMember(Name="QuantityReceived", EmitDefaultValue=false)]
        public double? QuantityReceived { get; set; }

        /// <summary>
        /// Gets or Sets ContractNumber
        /// </summary>
        [DataMember(Name="ContractNumber", EmitDefaultValue=false)]
        public int? ContractNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeNumber
        /// </summary>
        [DataMember(Name="ExchangeNumber", EmitDefaultValue=false)]
        public int? ExchangeNumber { get; set; }

        /// <summary>
        /// Gets or Sets ItemServicedNumber
        /// </summary>
        [DataMember(Name="ItemServicedNumber", EmitDefaultValue=false)]
        public int? ItemServicedNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
        public int? InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="LineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevel
        /// </summary>
        [DataMember(Name="PriceLevel", EmitDefaultValue=false)]
        public int? PriceLevel { get; set; }

        /// <summary>
        /// Gets or Sets ActualUnitCost
        /// </summary>
        [DataMember(Name="ActualUnitCost", EmitDefaultValue=false)]
        public double? ActualUnitCost { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="Cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or Sets GSTaxableAmount
        /// </summary>
        [DataMember(Name="GSTaxableAmount", EmitDefaultValue=false)]
        public double? GSTaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerListPrice
        /// </summary>
        [DataMember(Name="ManufacturerListPrice", EmitDefaultValue=false)]
        public double? ManufacturerListPrice { get; set; }

        /// <summary>
        /// Gets or Sets ProviderTaxableAmount
        /// </summary>
        [DataMember(Name="ProviderTaxableAmount", EmitDefaultValue=false)]
        public double? ProviderTaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets SellingPrice
        /// </summary>
        [DataMember(Name="SellingPrice", EmitDefaultValue=false)]
        public double? SellingPrice { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
        public double? TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalCost
        /// </summary>
        [DataMember(Name="TotalCost", EmitDefaultValue=false)]
        public double? TotalCost { get; set; }

        /// <summary>
        /// Gets or Sets TotalPostedCost
        /// </summary>
        [DataMember(Name="TotalPostedCost", EmitDefaultValue=false)]
        public double? TotalPostedCost { get; set; }

        /// <summary>
        /// Gets or Sets TotalSellingPrice
        /// </summary>
        [DataMember(Name="TotalSellingPrice", EmitDefaultValue=false)]
        public double? TotalSellingPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebServiceOrderPartUsedAssemblyDetail {\n");
            sb.Append("  PartUsedAssemblyDetailNumber: ").Append(PartUsedAssemblyDetailNumber).Append("\n");
            sb.Append("  InvoiceAssemblyDetailNumber: ").Append(InvoiceAssemblyDetailNumber).Append("\n");
            sb.Append("  EachQuantity: ").Append(EachQuantity).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  CostGLCode: ").Append(CostGLCode).Append("\n");
            sb.Append("  IncomeGLCode: ").Append(IncomeGLCode).Append("\n");
            sb.Append("  RMANumber: ").Append(RMANumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExchangeFlag: ").Append(ExchangeFlag).Append("\n");
            sb.Append("  GSTExempt: ").Append(GSTExempt).Append("\n");
            sb.Append("  PrintOnInvoice: ").Append(PrintOnInvoice).Append("\n");
            sb.Append("  SubjectToProviderTax: ").Append(SubjectToProviderTax).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  UnderContract: ").Append(UnderContract).Append("\n");
            sb.Append("  UseThisCostWhenOrdering: ").Append(UseThisCostWhenOrdering).Append("\n");
            sb.Append("  WasTaxed: ").Append(WasTaxed).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  OrderByDate: ").Append(OrderByDate).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityFilled: ").Append(QuantityFilled).Append("\n");
            sb.Append("  QuantityInvoiced: ").Append(QuantityInvoiced).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  QuantityPosted: ").Append(QuantityPosted).Append("\n");
            sb.Append("  QuantityReceived: ").Append(QuantityReceived).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  ExchangeNumber: ").Append(ExchangeNumber).Append("\n");
            sb.Append("  ItemServicedNumber: ").Append(ItemServicedNumber).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  ActualUnitCost: ").Append(ActualUnitCost).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  GSTaxableAmount: ").Append(GSTaxableAmount).Append("\n");
            sb.Append("  ManufacturerListPrice: ").Append(ManufacturerListPrice).Append("\n");
            sb.Append("  ProviderTaxableAmount: ").Append(ProviderTaxableAmount).Append("\n");
            sb.Append("  SellingPrice: ").Append(SellingPrice).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
            sb.Append("  TotalPostedCost: ").Append(TotalPostedCost).Append("\n");
            sb.Append("  TotalSellingPrice: ").Append(TotalSellingPrice).Append("\n");
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
            return this.Equals(input as TsiWebServiceOrderPartUsedAssemblyDetail);
        }

        /// <summary>
        /// Returns true if TsiWebServiceOrderPartUsedAssemblyDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebServiceOrderPartUsedAssemblyDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebServiceOrderPartUsedAssemblyDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartUsedAssemblyDetailNumber == input.PartUsedAssemblyDetailNumber ||
                    (this.PartUsedAssemblyDetailNumber != null &&
                    this.PartUsedAssemblyDetailNumber.Equals(input.PartUsedAssemblyDetailNumber))
                ) && 
                (
                    this.InvoiceAssemblyDetailNumber == input.InvoiceAssemblyDetailNumber ||
                    (this.InvoiceAssemblyDetailNumber != null &&
                    this.InvoiceAssemblyDetailNumber.Equals(input.InvoiceAssemblyDetailNumber))
                ) && 
                (
                    this.EachQuantity == input.EachQuantity ||
                    (this.EachQuantity != null &&
                    this.EachQuantity.Equals(input.EachQuantity))
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
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.CostGLCode == input.CostGLCode ||
                    (this.CostGLCode != null &&
                    this.CostGLCode.Equals(input.CostGLCode))
                ) && 
                (
                    this.IncomeGLCode == input.IncomeGLCode ||
                    (this.IncomeGLCode != null &&
                    this.IncomeGLCode.Equals(input.IncomeGLCode))
                ) && 
                (
                    this.RMANumber == input.RMANumber ||
                    (this.RMANumber != null &&
                    this.RMANumber.Equals(input.RMANumber))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ExchangeFlag == input.ExchangeFlag ||
                    (this.ExchangeFlag != null &&
                    this.ExchangeFlag.Equals(input.ExchangeFlag))
                ) && 
                (
                    this.GSTExempt == input.GSTExempt ||
                    (this.GSTExempt != null &&
                    this.GSTExempt.Equals(input.GSTExempt))
                ) && 
                (
                    this.PrintOnInvoice == input.PrintOnInvoice ||
                    (this.PrintOnInvoice != null &&
                    this.PrintOnInvoice.Equals(input.PrintOnInvoice))
                ) && 
                (
                    this.SubjectToProviderTax == input.SubjectToProviderTax ||
                    (this.SubjectToProviderTax != null &&
                    this.SubjectToProviderTax.Equals(input.SubjectToProviderTax))
                ) && 
                (
                    this.Taxable == input.Taxable ||
                    (this.Taxable != null &&
                    this.Taxable.Equals(input.Taxable))
                ) && 
                (
                    this.UnderContract == input.UnderContract ||
                    (this.UnderContract != null &&
                    this.UnderContract.Equals(input.UnderContract))
                ) && 
                (
                    this.UseThisCostWhenOrdering == input.UseThisCostWhenOrdering ||
                    (this.UseThisCostWhenOrdering != null &&
                    this.UseThisCostWhenOrdering.Equals(input.UseThisCostWhenOrdering))
                ) && 
                (
                    this.WasTaxed == input.WasTaxed ||
                    (this.WasTaxed != null &&
                    this.WasTaxed.Equals(input.WasTaxed))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.OrderByDate == input.OrderByDate ||
                    (this.OrderByDate != null &&
                    this.OrderByDate.Equals(input.OrderByDate))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.QuantityFilled == input.QuantityFilled ||
                    (this.QuantityFilled != null &&
                    this.QuantityFilled.Equals(input.QuantityFilled))
                ) && 
                (
                    this.QuantityInvoiced == input.QuantityInvoiced ||
                    (this.QuantityInvoiced != null &&
                    this.QuantityInvoiced.Equals(input.QuantityInvoiced))
                ) && 
                (
                    this.QuantityOrdered == input.QuantityOrdered ||
                    (this.QuantityOrdered != null &&
                    this.QuantityOrdered.Equals(input.QuantityOrdered))
                ) && 
                (
                    this.QuantityPosted == input.QuantityPosted ||
                    (this.QuantityPosted != null &&
                    this.QuantityPosted.Equals(input.QuantityPosted))
                ) && 
                (
                    this.QuantityReceived == input.QuantityReceived ||
                    (this.QuantityReceived != null &&
                    this.QuantityReceived.Equals(input.QuantityReceived))
                ) && 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
                ) && 
                (
                    this.ExchangeNumber == input.ExchangeNumber ||
                    (this.ExchangeNumber != null &&
                    this.ExchangeNumber.Equals(input.ExchangeNumber))
                ) && 
                (
                    this.ItemServicedNumber == input.ItemServicedNumber ||
                    (this.ItemServicedNumber != null &&
                    this.ItemServicedNumber.Equals(input.ItemServicedNumber))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.PriceLevel == input.PriceLevel ||
                    (this.PriceLevel != null &&
                    this.PriceLevel.Equals(input.PriceLevel))
                ) && 
                (
                    this.ActualUnitCost == input.ActualUnitCost ||
                    (this.ActualUnitCost != null &&
                    this.ActualUnitCost.Equals(input.ActualUnitCost))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.GSTaxableAmount == input.GSTaxableAmount ||
                    (this.GSTaxableAmount != null &&
                    this.GSTaxableAmount.Equals(input.GSTaxableAmount))
                ) && 
                (
                    this.ManufacturerListPrice == input.ManufacturerListPrice ||
                    (this.ManufacturerListPrice != null &&
                    this.ManufacturerListPrice.Equals(input.ManufacturerListPrice))
                ) && 
                (
                    this.ProviderTaxableAmount == input.ProviderTaxableAmount ||
                    (this.ProviderTaxableAmount != null &&
                    this.ProviderTaxableAmount.Equals(input.ProviderTaxableAmount))
                ) && 
                (
                    this.SellingPrice == input.SellingPrice ||
                    (this.SellingPrice != null &&
                    this.SellingPrice.Equals(input.SellingPrice))
                ) && 
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
                ) && 
                (
                    this.TotalCost == input.TotalCost ||
                    (this.TotalCost != null &&
                    this.TotalCost.Equals(input.TotalCost))
                ) && 
                (
                    this.TotalPostedCost == input.TotalPostedCost ||
                    (this.TotalPostedCost != null &&
                    this.TotalPostedCost.Equals(input.TotalPostedCost))
                ) && 
                (
                    this.TotalSellingPrice == input.TotalSellingPrice ||
                    (this.TotalSellingPrice != null &&
                    this.TotalSellingPrice.Equals(input.TotalSellingPrice))
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
                if (this.PartUsedAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.PartUsedAssemblyDetailNumber.GetHashCode();
                if (this.InvoiceAssemblyDetailNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceAssemblyDetailNumber.GetHashCode();
                if (this.EachQuantity != null)
                    hashCode = hashCode * 59 + this.EachQuantity.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.CostGLCode != null)
                    hashCode = hashCode * 59 + this.CostGLCode.GetHashCode();
                if (this.IncomeGLCode != null)
                    hashCode = hashCode * 59 + this.IncomeGLCode.GetHashCode();
                if (this.RMANumber != null)
                    hashCode = hashCode * 59 + this.RMANumber.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExchangeFlag != null)
                    hashCode = hashCode * 59 + this.ExchangeFlag.GetHashCode();
                if (this.GSTExempt != null)
                    hashCode = hashCode * 59 + this.GSTExempt.GetHashCode();
                if (this.PrintOnInvoice != null)
                    hashCode = hashCode * 59 + this.PrintOnInvoice.GetHashCode();
                if (this.SubjectToProviderTax != null)
                    hashCode = hashCode * 59 + this.SubjectToProviderTax.GetHashCode();
                if (this.Taxable != null)
                    hashCode = hashCode * 59 + this.Taxable.GetHashCode();
                if (this.UnderContract != null)
                    hashCode = hashCode * 59 + this.UnderContract.GetHashCode();
                if (this.UseThisCostWhenOrdering != null)
                    hashCode = hashCode * 59 + this.UseThisCostWhenOrdering.GetHashCode();
                if (this.WasTaxed != null)
                    hashCode = hashCode * 59 + this.WasTaxed.GetHashCode();
                if (this.InvoiceDate != null)
                    hashCode = hashCode * 59 + this.InvoiceDate.GetHashCode();
                if (this.OrderByDate != null)
                    hashCode = hashCode * 59 + this.OrderByDate.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.QuantityFilled != null)
                    hashCode = hashCode * 59 + this.QuantityFilled.GetHashCode();
                if (this.QuantityInvoiced != null)
                    hashCode = hashCode * 59 + this.QuantityInvoiced.GetHashCode();
                if (this.QuantityOrdered != null)
                    hashCode = hashCode * 59 + this.QuantityOrdered.GetHashCode();
                if (this.QuantityPosted != null)
                    hashCode = hashCode * 59 + this.QuantityPosted.GetHashCode();
                if (this.QuantityReceived != null)
                    hashCode = hashCode * 59 + this.QuantityReceived.GetHashCode();
                if (this.ContractNumber != null)
                    hashCode = hashCode * 59 + this.ContractNumber.GetHashCode();
                if (this.ExchangeNumber != null)
                    hashCode = hashCode * 59 + this.ExchangeNumber.GetHashCode();
                if (this.ItemServicedNumber != null)
                    hashCode = hashCode * 59 + this.ItemServicedNumber.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.PriceLevel != null)
                    hashCode = hashCode * 59 + this.PriceLevel.GetHashCode();
                if (this.ActualUnitCost != null)
                    hashCode = hashCode * 59 + this.ActualUnitCost.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.GSTaxableAmount != null)
                    hashCode = hashCode * 59 + this.GSTaxableAmount.GetHashCode();
                if (this.ManufacturerListPrice != null)
                    hashCode = hashCode * 59 + this.ManufacturerListPrice.GetHashCode();
                if (this.ProviderTaxableAmount != null)
                    hashCode = hashCode * 59 + this.ProviderTaxableAmount.GetHashCode();
                if (this.SellingPrice != null)
                    hashCode = hashCode * 59 + this.SellingPrice.GetHashCode();
                if (this.TaxableAmount != null)
                    hashCode = hashCode * 59 + this.TaxableAmount.GetHashCode();
                if (this.TotalCost != null)
                    hashCode = hashCode * 59 + this.TotalCost.GetHashCode();
                if (this.TotalPostedCost != null)
                    hashCode = hashCode * 59 + this.TotalPostedCost.GetHashCode();
                if (this.TotalSellingPrice != null)
                    hashCode = hashCode * 59 + this.TotalSellingPrice.GetHashCode();
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
