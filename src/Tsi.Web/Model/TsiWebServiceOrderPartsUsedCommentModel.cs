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
    /// TsiWebServiceOrderPartsUsedCommentModel
    /// </summary>
    [DataContract]
    public partial class TsiWebServiceOrderPartsUsedCommentModel :  IEquatable<TsiWebServiceOrderPartsUsedCommentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebServiceOrderPartsUsedCommentModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebServiceOrderPartsUsedCommentModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebServiceOrderPartsUsedCommentModel" /> class.
        /// </summary>
        /// <param name="comment">comment (required).</param>
        /// <param name="printOnInvoice">printOnInvoice.</param>
        /// <param name="lineNumber">lineNumber.</param>
        public TsiWebServiceOrderPartsUsedCommentModel(string comment = default(string), bool? printOnInvoice = default(bool?), int? lineNumber = default(int?))
        {
            // to ensure "comment" is required (not null)
            if (comment == null)
            {
                throw new InvalidDataException("comment is a required property for TsiWebServiceOrderPartsUsedCommentModel and cannot be null");
            }
            else
            {
                this.Comment = comment;
            }
            this.PrintOnInvoice = printOnInvoice;
            this.LineNumber = lineNumber;
        }
        
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets PrintOnInvoice
        /// </summary>
        [DataMember(Name="PrintOnInvoice", EmitDefaultValue=false)]
        public bool? PrintOnInvoice { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="LineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebServiceOrderPartsUsedCommentModel {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  PrintOnInvoice: ").Append(PrintOnInvoice).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
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
            return this.Equals(input as TsiWebServiceOrderPartsUsedCommentModel);
        }

        /// <summary>
        /// Returns true if TsiWebServiceOrderPartsUsedCommentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebServiceOrderPartsUsedCommentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebServiceOrderPartsUsedCommentModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.PrintOnInvoice == input.PrintOnInvoice ||
                    (this.PrintOnInvoice != null &&
                    this.PrintOnInvoice.Equals(input.PrintOnInvoice))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.PrintOnInvoice != null)
                    hashCode = hashCode * 59 + this.PrintOnInvoice.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
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