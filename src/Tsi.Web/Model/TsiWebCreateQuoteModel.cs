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
    /// TsiWebCreateQuoteModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateQuoteModel :  IEquatable<TsiWebCreateQuoteModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateQuoteModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebCreateQuoteModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateQuoteModel" /> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber (required).</param>
        /// <param name="existingQuoteNumber">existingQuoteNumber.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="opportunityNumber">opportunityNumber.</param>
        /// <param name="projectNumber">projectNumber.</param>
        /// <param name="projectPhaseNumber">projectPhaseNumber.</param>
        /// <param name="repNumber">repNumber.</param>
        /// <param name="shipToAddressAccountNumber">shipToAddressAccountNumber.</param>
        /// <param name="billToAddressAccountNumber">billToAddressAccountNumber.</param>
        /// <param name="alternateShipToAddressID">alternateShipToAddressID.</param>
        /// <param name="alternateBillToAddressID">alternateBillToAddressID.</param>
        /// <param name="shipToAddressType">shipToAddressType.</param>
        /// <param name="shipTo">shipTo.</param>
        /// <param name="billToAddressType">billToAddressType.</param>
        /// <param name="billTo">billTo.</param>
        /// <param name="description">description.</param>
        /// <param name="useAlternateShipToTaxCode">useAlternateShipToTaxCode.</param>
        /// <param name="updateDetailsToReflectCurrentPricing">updateDetailsToReflectCurrentPricing.</param>
        /// <param name="preserveLineItemPercentageDiscounts">preserveLineItemPercentageDiscounts.</param>
        /// <param name="applyQuoteProjectPhaseToDetailItems">applyQuoteProjectPhaseToDetailItems.</param>
        /// <param name="addMissingDetailProjectPhasesToProject">addMissingDetailProjectPhasesToProject.</param>
        public TsiWebCreateQuoteModel(int? accountNumber = default(int?), int? existingQuoteNumber = default(int?), int? contactNumber = default(int?), int? opportunityNumber = default(int?), int? projectNumber = default(int?), int? projectPhaseNumber = default(int?), int? repNumber = default(int?), int? shipToAddressAccountNumber = default(int?), int? billToAddressAccountNumber = default(int?), int? alternateShipToAddressID = default(int?), int? alternateBillToAddressID = default(int?), string shipToAddressType = default(string), TsiWebAlternateAddress shipTo = default(TsiWebAlternateAddress), string billToAddressType = default(string), TsiWebAlternateAddress billTo = default(TsiWebAlternateAddress), string description = default(string), bool? useAlternateShipToTaxCode = default(bool?), bool? updateDetailsToReflectCurrentPricing = default(bool?), bool? preserveLineItemPercentageDiscounts = default(bool?), bool? applyQuoteProjectPhaseToDetailItems = default(bool?), bool? addMissingDetailProjectPhasesToProject = default(bool?))
        {
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new InvalidDataException("accountNumber is a required property for TsiWebCreateQuoteModel and cannot be null");
            }
            else
            {
                this.AccountNumber = accountNumber;
            }
            this.ExistingQuoteNumber = existingQuoteNumber;
            this.ContactNumber = contactNumber;
            this.OpportunityNumber = opportunityNumber;
            this.ProjectNumber = projectNumber;
            this.ProjectPhaseNumber = projectPhaseNumber;
            this.RepNumber = repNumber;
            this.ShipToAddressAccountNumber = shipToAddressAccountNumber;
            this.BillToAddressAccountNumber = billToAddressAccountNumber;
            this.AlternateShipToAddressID = alternateShipToAddressID;
            this.AlternateBillToAddressID = alternateBillToAddressID;
            this.ShipToAddressType = shipToAddressType;
            this.ShipTo = shipTo;
            this.BillToAddressType = billToAddressType;
            this.BillTo = billTo;
            this.Description = description;
            this.UseAlternateShipToTaxCode = useAlternateShipToTaxCode;
            this.UpdateDetailsToReflectCurrentPricing = updateDetailsToReflectCurrentPricing;
            this.PreserveLineItemPercentageDiscounts = preserveLineItemPercentageDiscounts;
            this.ApplyQuoteProjectPhaseToDetailItems = applyQuoteProjectPhaseToDetailItems;
            this.AddMissingDetailProjectPhasesToProject = addMissingDetailProjectPhasesToProject;
        }
        
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExistingQuoteNumber
        /// </summary>
        [DataMember(Name="ExistingQuoteNumber", EmitDefaultValue=false)]
        public int? ExistingQuoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public int? ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityNumber
        /// </summary>
        [DataMember(Name="OpportunityNumber", EmitDefaultValue=false)]
        public int? OpportunityNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectNumber
        /// </summary>
        [DataMember(Name="ProjectNumber", EmitDefaultValue=false)]
        public int? ProjectNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectPhaseNumber
        /// </summary>
        [DataMember(Name="ProjectPhaseNumber", EmitDefaultValue=false)]
        public int? ProjectPhaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets RepNumber
        /// </summary>
        [DataMember(Name="RepNumber", EmitDefaultValue=false)]
        public int? RepNumber { get; set; }

        /// <summary>
        /// Gets or Sets ShipToAddressAccountNumber
        /// </summary>
        [DataMember(Name="ShipToAddressAccountNumber", EmitDefaultValue=false)]
        public int? ShipToAddressAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets BillToAddressAccountNumber
        /// </summary>
        [DataMember(Name="BillToAddressAccountNumber", EmitDefaultValue=false)]
        public int? BillToAddressAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets AlternateShipToAddressID
        /// </summary>
        [DataMember(Name="AlternateShipToAddressID", EmitDefaultValue=false)]
        public int? AlternateShipToAddressID { get; set; }

        /// <summary>
        /// Gets or Sets AlternateBillToAddressID
        /// </summary>
        [DataMember(Name="AlternateBillToAddressID", EmitDefaultValue=false)]
        public int? AlternateBillToAddressID { get; set; }

        /// <summary>
        /// Gets or Sets ShipToAddressType
        /// </summary>
        [DataMember(Name="ShipToAddressType", EmitDefaultValue=false)]
        public string ShipToAddressType { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="ShipTo", EmitDefaultValue=false)]
        public TsiWebAlternateAddress ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets BillToAddressType
        /// </summary>
        [DataMember(Name="BillToAddressType", EmitDefaultValue=false)]
        public string BillToAddressType { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="BillTo", EmitDefaultValue=false)]
        public TsiWebAlternateAddress BillTo { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UseAlternateShipToTaxCode
        /// </summary>
        [DataMember(Name="UseAlternateShipToTaxCode", EmitDefaultValue=false)]
        public bool? UseAlternateShipToTaxCode { get; set; }

        /// <summary>
        /// Gets or Sets UpdateDetailsToReflectCurrentPricing
        /// </summary>
        [DataMember(Name="UpdateDetailsToReflectCurrentPricing", EmitDefaultValue=false)]
        public bool? UpdateDetailsToReflectCurrentPricing { get; set; }

        /// <summary>
        /// Gets or Sets PreserveLineItemPercentageDiscounts
        /// </summary>
        [DataMember(Name="PreserveLineItemPercentageDiscounts", EmitDefaultValue=false)]
        public bool? PreserveLineItemPercentageDiscounts { get; set; }

        /// <summary>
        /// Gets or Sets ApplyQuoteProjectPhaseToDetailItems
        /// </summary>
        [DataMember(Name="ApplyQuoteProjectPhaseToDetailItems", EmitDefaultValue=false)]
        public bool? ApplyQuoteProjectPhaseToDetailItems { get; set; }

        /// <summary>
        /// Gets or Sets AddMissingDetailProjectPhasesToProject
        /// </summary>
        [DataMember(Name="AddMissingDetailProjectPhasesToProject", EmitDefaultValue=false)]
        public bool? AddMissingDetailProjectPhasesToProject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateQuoteModel {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ExistingQuoteNumber: ").Append(ExistingQuoteNumber).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  OpportunityNumber: ").Append(OpportunityNumber).Append("\n");
            sb.Append("  ProjectNumber: ").Append(ProjectNumber).Append("\n");
            sb.Append("  ProjectPhaseNumber: ").Append(ProjectPhaseNumber).Append("\n");
            sb.Append("  RepNumber: ").Append(RepNumber).Append("\n");
            sb.Append("  ShipToAddressAccountNumber: ").Append(ShipToAddressAccountNumber).Append("\n");
            sb.Append("  BillToAddressAccountNumber: ").Append(BillToAddressAccountNumber).Append("\n");
            sb.Append("  AlternateShipToAddressID: ").Append(AlternateShipToAddressID).Append("\n");
            sb.Append("  AlternateBillToAddressID: ").Append(AlternateBillToAddressID).Append("\n");
            sb.Append("  ShipToAddressType: ").Append(ShipToAddressType).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  BillToAddressType: ").Append(BillToAddressType).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UseAlternateShipToTaxCode: ").Append(UseAlternateShipToTaxCode).Append("\n");
            sb.Append("  UpdateDetailsToReflectCurrentPricing: ").Append(UpdateDetailsToReflectCurrentPricing).Append("\n");
            sb.Append("  PreserveLineItemPercentageDiscounts: ").Append(PreserveLineItemPercentageDiscounts).Append("\n");
            sb.Append("  ApplyQuoteProjectPhaseToDetailItems: ").Append(ApplyQuoteProjectPhaseToDetailItems).Append("\n");
            sb.Append("  AddMissingDetailProjectPhasesToProject: ").Append(AddMissingDetailProjectPhasesToProject).Append("\n");
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
            return this.Equals(input as TsiWebCreateQuoteModel);
        }

        /// <summary>
        /// Returns true if TsiWebCreateQuoteModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateQuoteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateQuoteModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.ExistingQuoteNumber == input.ExistingQuoteNumber ||
                    (this.ExistingQuoteNumber != null &&
                    this.ExistingQuoteNumber.Equals(input.ExistingQuoteNumber))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.OpportunityNumber == input.OpportunityNumber ||
                    (this.OpportunityNumber != null &&
                    this.OpportunityNumber.Equals(input.OpportunityNumber))
                ) && 
                (
                    this.ProjectNumber == input.ProjectNumber ||
                    (this.ProjectNumber != null &&
                    this.ProjectNumber.Equals(input.ProjectNumber))
                ) && 
                (
                    this.ProjectPhaseNumber == input.ProjectPhaseNumber ||
                    (this.ProjectPhaseNumber != null &&
                    this.ProjectPhaseNumber.Equals(input.ProjectPhaseNumber))
                ) && 
                (
                    this.RepNumber == input.RepNumber ||
                    (this.RepNumber != null &&
                    this.RepNumber.Equals(input.RepNumber))
                ) && 
                (
                    this.ShipToAddressAccountNumber == input.ShipToAddressAccountNumber ||
                    (this.ShipToAddressAccountNumber != null &&
                    this.ShipToAddressAccountNumber.Equals(input.ShipToAddressAccountNumber))
                ) && 
                (
                    this.BillToAddressAccountNumber == input.BillToAddressAccountNumber ||
                    (this.BillToAddressAccountNumber != null &&
                    this.BillToAddressAccountNumber.Equals(input.BillToAddressAccountNumber))
                ) && 
                (
                    this.AlternateShipToAddressID == input.AlternateShipToAddressID ||
                    (this.AlternateShipToAddressID != null &&
                    this.AlternateShipToAddressID.Equals(input.AlternateShipToAddressID))
                ) && 
                (
                    this.AlternateBillToAddressID == input.AlternateBillToAddressID ||
                    (this.AlternateBillToAddressID != null &&
                    this.AlternateBillToAddressID.Equals(input.AlternateBillToAddressID))
                ) && 
                (
                    this.ShipToAddressType == input.ShipToAddressType ||
                    (this.ShipToAddressType != null &&
                    this.ShipToAddressType.Equals(input.ShipToAddressType))
                ) && 
                (
                    this.ShipTo == input.ShipTo ||
                    (this.ShipTo != null &&
                    this.ShipTo.Equals(input.ShipTo))
                ) && 
                (
                    this.BillToAddressType == input.BillToAddressType ||
                    (this.BillToAddressType != null &&
                    this.BillToAddressType.Equals(input.BillToAddressType))
                ) && 
                (
                    this.BillTo == input.BillTo ||
                    (this.BillTo != null &&
                    this.BillTo.Equals(input.BillTo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UseAlternateShipToTaxCode == input.UseAlternateShipToTaxCode ||
                    (this.UseAlternateShipToTaxCode != null &&
                    this.UseAlternateShipToTaxCode.Equals(input.UseAlternateShipToTaxCode))
                ) && 
                (
                    this.UpdateDetailsToReflectCurrentPricing == input.UpdateDetailsToReflectCurrentPricing ||
                    (this.UpdateDetailsToReflectCurrentPricing != null &&
                    this.UpdateDetailsToReflectCurrentPricing.Equals(input.UpdateDetailsToReflectCurrentPricing))
                ) && 
                (
                    this.PreserveLineItemPercentageDiscounts == input.PreserveLineItemPercentageDiscounts ||
                    (this.PreserveLineItemPercentageDiscounts != null &&
                    this.PreserveLineItemPercentageDiscounts.Equals(input.PreserveLineItemPercentageDiscounts))
                ) && 
                (
                    this.ApplyQuoteProjectPhaseToDetailItems == input.ApplyQuoteProjectPhaseToDetailItems ||
                    (this.ApplyQuoteProjectPhaseToDetailItems != null &&
                    this.ApplyQuoteProjectPhaseToDetailItems.Equals(input.ApplyQuoteProjectPhaseToDetailItems))
                ) && 
                (
                    this.AddMissingDetailProjectPhasesToProject == input.AddMissingDetailProjectPhasesToProject ||
                    (this.AddMissingDetailProjectPhasesToProject != null &&
                    this.AddMissingDetailProjectPhasesToProject.Equals(input.AddMissingDetailProjectPhasesToProject))
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
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.ExistingQuoteNumber != null)
                    hashCode = hashCode * 59 + this.ExistingQuoteNumber.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.OpportunityNumber != null)
                    hashCode = hashCode * 59 + this.OpportunityNumber.GetHashCode();
                if (this.ProjectNumber != null)
                    hashCode = hashCode * 59 + this.ProjectNumber.GetHashCode();
                if (this.ProjectPhaseNumber != null)
                    hashCode = hashCode * 59 + this.ProjectPhaseNumber.GetHashCode();
                if (this.RepNumber != null)
                    hashCode = hashCode * 59 + this.RepNumber.GetHashCode();
                if (this.ShipToAddressAccountNumber != null)
                    hashCode = hashCode * 59 + this.ShipToAddressAccountNumber.GetHashCode();
                if (this.BillToAddressAccountNumber != null)
                    hashCode = hashCode * 59 + this.BillToAddressAccountNumber.GetHashCode();
                if (this.AlternateShipToAddressID != null)
                    hashCode = hashCode * 59 + this.AlternateShipToAddressID.GetHashCode();
                if (this.AlternateBillToAddressID != null)
                    hashCode = hashCode * 59 + this.AlternateBillToAddressID.GetHashCode();
                if (this.ShipToAddressType != null)
                    hashCode = hashCode * 59 + this.ShipToAddressType.GetHashCode();
                if (this.ShipTo != null)
                    hashCode = hashCode * 59 + this.ShipTo.GetHashCode();
                if (this.BillToAddressType != null)
                    hashCode = hashCode * 59 + this.BillToAddressType.GetHashCode();
                if (this.BillTo != null)
                    hashCode = hashCode * 59 + this.BillTo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UseAlternateShipToTaxCode != null)
                    hashCode = hashCode * 59 + this.UseAlternateShipToTaxCode.GetHashCode();
                if (this.UpdateDetailsToReflectCurrentPricing != null)
                    hashCode = hashCode * 59 + this.UpdateDetailsToReflectCurrentPricing.GetHashCode();
                if (this.PreserveLineItemPercentageDiscounts != null)
                    hashCode = hashCode * 59 + this.PreserveLineItemPercentageDiscounts.GetHashCode();
                if (this.ApplyQuoteProjectPhaseToDetailItems != null)
                    hashCode = hashCode * 59 + this.ApplyQuoteProjectPhaseToDetailItems.GetHashCode();
                if (this.AddMissingDetailProjectPhasesToProject != null)
                    hashCode = hashCode * 59 + this.AddMissingDetailProjectPhasesToProject.GetHashCode();
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