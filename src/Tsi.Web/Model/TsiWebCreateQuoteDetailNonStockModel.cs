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
    /// TsiWebCreateQuoteDetailNonStockModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateQuoteDetailNonStockModel :  IEquatable<TsiWebCreateQuoteDetailNonStockModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateQuoteDetailNonStockModel" /> class.
        /// </summary>
        /// <param name="lineNumber">lineNumber.</param>
        /// <param name="projectPhaseNumber">projectPhaseNumber.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="unitOfMeasure">unitOfMeasure.</param>
        /// <param name="type">type.</param>
        /// <param name="subjectToSingleItemTax">subjectToSingleItemTax.</param>
        /// <param name="sellingPrice">sellingPrice.</param>
        /// <param name="manufacturerListPrice">manufacturerListPrice.</param>
        /// <param name="cost">cost.</param>
        /// <param name="installLocation">installLocation.</param>
        /// <param name="orderByDate">orderByDate.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="subjectToProviderTax">subjectToProviderTax.</param>
        /// <param name="printOnInvoice">printOnInvoice.</param>
        /// <param name="printOnQuote">printOnQuote.</param>
        /// <param name="itemCanBeDiscounted">itemCanBeDiscounted.</param>
        /// <param name="useThisCostWhenOrdering">useThisCostWhenOrdering.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="isSerialized">isSerialized.</param>
        public TsiWebCreateQuoteDetailNonStockModel(int? lineNumber = default(int?), int? projectPhaseNumber = default(int?), string itemId = default(string), string itemDescription = default(string), string unitOfMeasure = default(string), string type = default(string), bool? subjectToSingleItemTax = default(bool?), double? sellingPrice = default(double?), double? manufacturerListPrice = default(double?), double? cost = default(double?), string installLocation = default(string), DateTime? orderByDate = default(DateTime?), bool? taxable = default(bool?), bool? subjectToProviderTax = default(bool?), bool? printOnInvoice = default(bool?), bool? printOnQuote = default(bool?), bool? itemCanBeDiscounted = default(bool?), bool? useThisCostWhenOrdering = default(bool?), double? quantity = default(double?), bool? isSerialized = default(bool?))
        {
            this.LineNumber = lineNumber;
            this.ProjectPhaseNumber = projectPhaseNumber;
            this.ItemId = itemId;
            this.ItemDescription = itemDescription;
            this.UnitOfMeasure = unitOfMeasure;
            this.Type = type;
            this.SubjectToSingleItemTax = subjectToSingleItemTax;
            this.SellingPrice = sellingPrice;
            this.ManufacturerListPrice = manufacturerListPrice;
            this.Cost = cost;
            this.InstallLocation = installLocation;
            this.OrderByDate = orderByDate;
            this.Taxable = taxable;
            this.SubjectToProviderTax = subjectToProviderTax;
            this.PrintOnInvoice = printOnInvoice;
            this.PrintOnQuote = printOnQuote;
            this.ItemCanBeDiscounted = itemCanBeDiscounted;
            this.UseThisCostWhenOrdering = useThisCostWhenOrdering;
            this.Quantity = quantity;
            this.IsSerialized = isSerialized;
        }
        
        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="LineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectPhaseNumber
        /// </summary>
        [DataMember(Name="ProjectPhaseNumber", EmitDefaultValue=false)]
        public int? ProjectPhaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="ItemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name="UnitOfMeasure", EmitDefaultValue=false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SubjectToSingleItemTax
        /// </summary>
        [DataMember(Name="SubjectToSingleItemTax", EmitDefaultValue=false)]
        public bool? SubjectToSingleItemTax { get; set; }

        /// <summary>
        /// Gets or Sets SellingPrice
        /// </summary>
        [DataMember(Name="SellingPrice", EmitDefaultValue=false)]
        public double? SellingPrice { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerListPrice
        /// </summary>
        [DataMember(Name="ManufacturerListPrice", EmitDefaultValue=false)]
        public double? ManufacturerListPrice { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="Cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or Sets InstallLocation
        /// </summary>
        [DataMember(Name="InstallLocation", EmitDefaultValue=false)]
        public string InstallLocation { get; set; }

        /// <summary>
        /// Gets or Sets OrderByDate
        /// </summary>
        [DataMember(Name="OrderByDate", EmitDefaultValue=false)]
        public DateTime? OrderByDate { get; set; }

        /// <summary>
        /// Gets or Sets Taxable
        /// </summary>
        [DataMember(Name="Taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Gets or Sets SubjectToProviderTax
        /// </summary>
        [DataMember(Name="SubjectToProviderTax", EmitDefaultValue=false)]
        public bool? SubjectToProviderTax { get; set; }

        /// <summary>
        /// Gets or Sets PrintOnInvoice
        /// </summary>
        [DataMember(Name="PrintOnInvoice", EmitDefaultValue=false)]
        public bool? PrintOnInvoice { get; set; }

        /// <summary>
        /// Gets or Sets PrintOnQuote
        /// </summary>
        [DataMember(Name="PrintOnQuote", EmitDefaultValue=false)]
        public bool? PrintOnQuote { get; set; }

        /// <summary>
        /// Gets or Sets ItemCanBeDiscounted
        /// </summary>
        [DataMember(Name="ItemCanBeDiscounted", EmitDefaultValue=false)]
        public bool? ItemCanBeDiscounted { get; set; }

        /// <summary>
        /// Gets or Sets UseThisCostWhenOrdering
        /// </summary>
        [DataMember(Name="UseThisCostWhenOrdering", EmitDefaultValue=false)]
        public bool? UseThisCostWhenOrdering { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets IsSerialized
        /// </summary>
        [DataMember(Name="IsSerialized", EmitDefaultValue=false)]
        public bool? IsSerialized { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateQuoteDetailNonStockModel {\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  ProjectPhaseNumber: ").Append(ProjectPhaseNumber).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubjectToSingleItemTax: ").Append(SubjectToSingleItemTax).Append("\n");
            sb.Append("  SellingPrice: ").Append(SellingPrice).Append("\n");
            sb.Append("  ManufacturerListPrice: ").Append(ManufacturerListPrice).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  InstallLocation: ").Append(InstallLocation).Append("\n");
            sb.Append("  OrderByDate: ").Append(OrderByDate).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  SubjectToProviderTax: ").Append(SubjectToProviderTax).Append("\n");
            sb.Append("  PrintOnInvoice: ").Append(PrintOnInvoice).Append("\n");
            sb.Append("  PrintOnQuote: ").Append(PrintOnQuote).Append("\n");
            sb.Append("  ItemCanBeDiscounted: ").Append(ItemCanBeDiscounted).Append("\n");
            sb.Append("  UseThisCostWhenOrdering: ").Append(UseThisCostWhenOrdering).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  IsSerialized: ").Append(IsSerialized).Append("\n");
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
            return this.Equals(input as TsiWebCreateQuoteDetailNonStockModel);
        }

        /// <summary>
        /// Returns true if TsiWebCreateQuoteDetailNonStockModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateQuoteDetailNonStockModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateQuoteDetailNonStockModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.ProjectPhaseNumber == input.ProjectPhaseNumber ||
                    (this.ProjectPhaseNumber != null &&
                    this.ProjectPhaseNumber.Equals(input.ProjectPhaseNumber))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemDescription == input.ItemDescription ||
                    (this.ItemDescription != null &&
                    this.ItemDescription.Equals(input.ItemDescription))
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SubjectToSingleItemTax == input.SubjectToSingleItemTax ||
                    (this.SubjectToSingleItemTax != null &&
                    this.SubjectToSingleItemTax.Equals(input.SubjectToSingleItemTax))
                ) && 
                (
                    this.SellingPrice == input.SellingPrice ||
                    (this.SellingPrice != null &&
                    this.SellingPrice.Equals(input.SellingPrice))
                ) && 
                (
                    this.ManufacturerListPrice == input.ManufacturerListPrice ||
                    (this.ManufacturerListPrice != null &&
                    this.ManufacturerListPrice.Equals(input.ManufacturerListPrice))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.InstallLocation == input.InstallLocation ||
                    (this.InstallLocation != null &&
                    this.InstallLocation.Equals(input.InstallLocation))
                ) && 
                (
                    this.OrderByDate == input.OrderByDate ||
                    (this.OrderByDate != null &&
                    this.OrderByDate.Equals(input.OrderByDate))
                ) && 
                (
                    this.Taxable == input.Taxable ||
                    (this.Taxable != null &&
                    this.Taxable.Equals(input.Taxable))
                ) && 
                (
                    this.SubjectToProviderTax == input.SubjectToProviderTax ||
                    (this.SubjectToProviderTax != null &&
                    this.SubjectToProviderTax.Equals(input.SubjectToProviderTax))
                ) && 
                (
                    this.PrintOnInvoice == input.PrintOnInvoice ||
                    (this.PrintOnInvoice != null &&
                    this.PrintOnInvoice.Equals(input.PrintOnInvoice))
                ) && 
                (
                    this.PrintOnQuote == input.PrintOnQuote ||
                    (this.PrintOnQuote != null &&
                    this.PrintOnQuote.Equals(input.PrintOnQuote))
                ) && 
                (
                    this.ItemCanBeDiscounted == input.ItemCanBeDiscounted ||
                    (this.ItemCanBeDiscounted != null &&
                    this.ItemCanBeDiscounted.Equals(input.ItemCanBeDiscounted))
                ) && 
                (
                    this.UseThisCostWhenOrdering == input.UseThisCostWhenOrdering ||
                    (this.UseThisCostWhenOrdering != null &&
                    this.UseThisCostWhenOrdering.Equals(input.UseThisCostWhenOrdering))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.IsSerialized == input.IsSerialized ||
                    (this.IsSerialized != null &&
                    this.IsSerialized.Equals(input.IsSerialized))
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
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.ProjectPhaseNumber != null)
                    hashCode = hashCode * 59 + this.ProjectPhaseNumber.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SubjectToSingleItemTax != null)
                    hashCode = hashCode * 59 + this.SubjectToSingleItemTax.GetHashCode();
                if (this.SellingPrice != null)
                    hashCode = hashCode * 59 + this.SellingPrice.GetHashCode();
                if (this.ManufacturerListPrice != null)
                    hashCode = hashCode * 59 + this.ManufacturerListPrice.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.InstallLocation != null)
                    hashCode = hashCode * 59 + this.InstallLocation.GetHashCode();
                if (this.OrderByDate != null)
                    hashCode = hashCode * 59 + this.OrderByDate.GetHashCode();
                if (this.Taxable != null)
                    hashCode = hashCode * 59 + this.Taxable.GetHashCode();
                if (this.SubjectToProviderTax != null)
                    hashCode = hashCode * 59 + this.SubjectToProviderTax.GetHashCode();
                if (this.PrintOnInvoice != null)
                    hashCode = hashCode * 59 + this.PrintOnInvoice.GetHashCode();
                if (this.PrintOnQuote != null)
                    hashCode = hashCode * 59 + this.PrintOnQuote.GetHashCode();
                if (this.ItemCanBeDiscounted != null)
                    hashCode = hashCode * 59 + this.ItemCanBeDiscounted.GetHashCode();
                if (this.UseThisCostWhenOrdering != null)
                    hashCode = hashCode * 59 + this.UseThisCostWhenOrdering.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.IsSerialized != null)
                    hashCode = hashCode * 59 + this.IsSerialized.GetHashCode();
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
