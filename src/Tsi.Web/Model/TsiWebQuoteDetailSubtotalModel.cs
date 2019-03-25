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
    /// TsiWebQuoteDetailSubtotalModel
    /// </summary>
    [DataContract]
    public partial class TsiWebQuoteDetailSubtotalModel :  IEquatable<TsiWebQuoteDetailSubtotalModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebQuoteDetailSubtotalModel" /> class.
        /// </summary>
        /// <param name="printSubtotalInHeader">printSubtotalInHeader.</param>
        /// <param name="comment">comment.</param>
        /// <param name="printOnQuote">printOnQuote.</param>
        public TsiWebQuoteDetailSubtotalModel(bool? printSubtotalInHeader = default(bool?), string comment = default(string), bool? printOnQuote = default(bool?))
        {
            this.PrintSubtotalInHeader = printSubtotalInHeader;
            this.Comment = comment;
            this.PrintOnQuote = printOnQuote;
        }
        
        /// <summary>
        /// Gets or Sets PrintSubtotalInHeader
        /// </summary>
        [DataMember(Name="PrintSubtotalInHeader", EmitDefaultValue=false)]
        public bool? PrintSubtotalInHeader { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets PrintOnQuote
        /// </summary>
        [DataMember(Name="PrintOnQuote", EmitDefaultValue=false)]
        public bool? PrintOnQuote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebQuoteDetailSubtotalModel {\n");
            sb.Append("  PrintSubtotalInHeader: ").Append(PrintSubtotalInHeader).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  PrintOnQuote: ").Append(PrintOnQuote).Append("\n");
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
            return this.Equals(input as TsiWebQuoteDetailSubtotalModel);
        }

        /// <summary>
        /// Returns true if TsiWebQuoteDetailSubtotalModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebQuoteDetailSubtotalModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebQuoteDetailSubtotalModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrintSubtotalInHeader == input.PrintSubtotalInHeader ||
                    (this.PrintSubtotalInHeader != null &&
                    this.PrintSubtotalInHeader.Equals(input.PrintSubtotalInHeader))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.PrintOnQuote == input.PrintOnQuote ||
                    (this.PrintOnQuote != null &&
                    this.PrintOnQuote.Equals(input.PrintOnQuote))
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
                if (this.PrintSubtotalInHeader != null)
                    hashCode = hashCode * 59 + this.PrintSubtotalInHeader.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.PrintOnQuote != null)
                    hashCode = hashCode * 59 + this.PrintOnQuote.GetHashCode();
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