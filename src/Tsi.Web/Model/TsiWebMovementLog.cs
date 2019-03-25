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
    /// TsiWebMovementLog
    /// </summary>
    [DataContract]
    public partial class TsiWebMovementLog :  IEquatable<TsiWebMovementLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebMovementLog" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="documentNumber">documentNumber.</param>
        /// <param name="newQuantityOnHand">newQuantityOnHand.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="newQuantityInLocation">newQuantityInLocation.</param>
        /// <param name="transactionDate">transactionDate.</param>
        /// <param name="transactionCost">transactionCost.</param>
        /// <param name="newAverageCost">newAverageCost.</param>
        /// <param name="enteredBy">enteredBy.</param>
        public TsiWebMovementLog(string location = default(string), string documentType = default(string), string documentNumber = default(string), int? newQuantityOnHand = default(int?), int? quantity = default(int?), int? newQuantityInLocation = default(int?), DateTime? transactionDate = default(DateTime?), double? transactionCost = default(double?), double? newAverageCost = default(double?), string enteredBy = default(string))
        {
            this.Location = location;
            this.DocumentType = documentType;
            this.DocumentNumber = documentNumber;
            this.NewQuantityOnHand = newQuantityOnHand;
            this.Quantity = quantity;
            this.NewQuantityInLocation = newQuantityInLocation;
            this.TransactionDate = transactionDate;
            this.TransactionCost = transactionCost;
            this.NewAverageCost = newAverageCost;
            this.EnteredBy = enteredBy;
        }
        
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name="DocumentType", EmitDefaultValue=false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [DataMember(Name="DocumentNumber", EmitDefaultValue=false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets NewQuantityOnHand
        /// </summary>
        [DataMember(Name="NewQuantityOnHand", EmitDefaultValue=false)]
        public int? NewQuantityOnHand { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets NewQuantityInLocation
        /// </summary>
        [DataMember(Name="NewQuantityInLocation", EmitDefaultValue=false)]
        public int? NewQuantityInLocation { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDate
        /// </summary>
        [DataMember(Name="TransactionDate", EmitDefaultValue=false)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Gets or Sets TransactionCost
        /// </summary>
        [DataMember(Name="TransactionCost", EmitDefaultValue=false)]
        public double? TransactionCost { get; set; }

        /// <summary>
        /// Gets or Sets NewAverageCost
        /// </summary>
        [DataMember(Name="NewAverageCost", EmitDefaultValue=false)]
        public double? NewAverageCost { get; set; }

        /// <summary>
        /// Gets or Sets EnteredBy
        /// </summary>
        [DataMember(Name="EnteredBy", EmitDefaultValue=false)]
        public string EnteredBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebMovementLog {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  NewQuantityOnHand: ").Append(NewQuantityOnHand).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  NewQuantityInLocation: ").Append(NewQuantityInLocation).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  TransactionCost: ").Append(TransactionCost).Append("\n");
            sb.Append("  NewAverageCost: ").Append(NewAverageCost).Append("\n");
            sb.Append("  EnteredBy: ").Append(EnteredBy).Append("\n");
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
            return this.Equals(input as TsiWebMovementLog);
        }

        /// <summary>
        /// Returns true if TsiWebMovementLog instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebMovementLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebMovementLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.NewQuantityOnHand == input.NewQuantityOnHand ||
                    (this.NewQuantityOnHand != null &&
                    this.NewQuantityOnHand.Equals(input.NewQuantityOnHand))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.NewQuantityInLocation == input.NewQuantityInLocation ||
                    (this.NewQuantityInLocation != null &&
                    this.NewQuantityInLocation.Equals(input.NewQuantityInLocation))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.TransactionCost == input.TransactionCost ||
                    (this.TransactionCost != null &&
                    this.TransactionCost.Equals(input.TransactionCost))
                ) && 
                (
                    this.NewAverageCost == input.NewAverageCost ||
                    (this.NewAverageCost != null &&
                    this.NewAverageCost.Equals(input.NewAverageCost))
                ) && 
                (
                    this.EnteredBy == input.EnteredBy ||
                    (this.EnteredBy != null &&
                    this.EnteredBy.Equals(input.EnteredBy))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.NewQuantityOnHand != null)
                    hashCode = hashCode * 59 + this.NewQuantityOnHand.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.NewQuantityInLocation != null)
                    hashCode = hashCode * 59 + this.NewQuantityInLocation.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.TransactionCost != null)
                    hashCode = hashCode * 59 + this.TransactionCost.GetHashCode();
                if (this.NewAverageCost != null)
                    hashCode = hashCode * 59 + this.NewAverageCost.GetHashCode();
                if (this.EnteredBy != null)
                    hashCode = hashCode * 59 + this.EnteredBy.GetHashCode();
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