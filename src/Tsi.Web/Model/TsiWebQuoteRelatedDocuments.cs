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
    /// TsiWebQuoteRelatedDocuments
    /// </summary>
    [DataContract]
    public partial class TsiWebQuoteRelatedDocuments :  IEquatable<TsiWebQuoteRelatedDocuments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebQuoteRelatedDocuments" /> class.
        /// </summary>
        /// <param name="serviceOrders">serviceOrders.</param>
        /// <param name="purchaseOrders">purchaseOrders.</param>
        public TsiWebQuoteRelatedDocuments(List<TsiWebQuoteServiceOrder> serviceOrders = default(List<TsiWebQuoteServiceOrder>), List<TsiWebQuotePurchaseOrder> purchaseOrders = default(List<TsiWebQuotePurchaseOrder>))
        {
            this.ServiceOrders = serviceOrders;
            this.PurchaseOrders = purchaseOrders;
        }
        
        /// <summary>
        /// Gets or Sets ServiceOrders
        /// </summary>
        [DataMember(Name="ServiceOrders", EmitDefaultValue=false)]
        public List<TsiWebQuoteServiceOrder> ServiceOrders { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrders
        /// </summary>
        [DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
        public List<TsiWebQuotePurchaseOrder> PurchaseOrders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebQuoteRelatedDocuments {\n");
            sb.Append("  ServiceOrders: ").Append(ServiceOrders).Append("\n");
            sb.Append("  PurchaseOrders: ").Append(PurchaseOrders).Append("\n");
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
            return this.Equals(input as TsiWebQuoteRelatedDocuments);
        }

        /// <summary>
        /// Returns true if TsiWebQuoteRelatedDocuments instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebQuoteRelatedDocuments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebQuoteRelatedDocuments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceOrders == input.ServiceOrders ||
                    this.ServiceOrders != null &&
                    this.ServiceOrders.SequenceEqual(input.ServiceOrders)
                ) && 
                (
                    this.PurchaseOrders == input.PurchaseOrders ||
                    this.PurchaseOrders != null &&
                    this.PurchaseOrders.SequenceEqual(input.PurchaseOrders)
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
                if (this.ServiceOrders != null)
                    hashCode = hashCode * 59 + this.ServiceOrders.GetHashCode();
                if (this.PurchaseOrders != null)
                    hashCode = hashCode * 59 + this.PurchaseOrders.GetHashCode();
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
