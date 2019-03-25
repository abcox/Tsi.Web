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
    /// TsiWebSearchQuotesResponse
    /// </summary>
    [DataContract]
    public partial class TsiWebSearchQuotesResponse :  IEquatable<TsiWebSearchQuotesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebSearchQuotesResponse" /> class.
        /// </summary>
        /// <param name="quotes">quotes.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="nextRow">nextRow.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        public TsiWebSearchQuotesResponse(List<TsiWebQuoteSummary> quotes = default(List<TsiWebQuoteSummary>), int? pageSize = default(int?), int? nextRow = default(int?), int? totalCount = default(int?), bool? success = default(bool?), string message = default(string))
        {
            this.Quotes = quotes;
            this.PageSize = pageSize;
            this.NextRow = nextRow;
            this.TotalCount = totalCount;
            this.Success = success;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets Quotes
        /// </summary>
        [DataMember(Name="Quotes", EmitDefaultValue=false)]
        public List<TsiWebQuoteSummary> Quotes { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="PageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or Sets NextRow
        /// </summary>
        [DataMember(Name="NextRow", EmitDefaultValue=false)]
        public int? NextRow { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="TotalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebSearchQuotesResponse {\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  NextRow: ").Append(NextRow).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as TsiWebSearchQuotesResponse);
        }

        /// <summary>
        /// Returns true if TsiWebSearchQuotesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebSearchQuotesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebSearchQuotesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.NextRow == input.NextRow ||
                    (this.NextRow != null &&
                    this.NextRow.Equals(input.NextRow))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Quotes != null)
                    hashCode = hashCode * 59 + this.Quotes.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.NextRow != null)
                    hashCode = hashCode * 59 + this.NextRow.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
