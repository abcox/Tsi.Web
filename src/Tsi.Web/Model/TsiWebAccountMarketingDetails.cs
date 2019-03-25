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
    /// TsiWebAccountMarketingDetails
    /// </summary>
    [DataContract]
    public partial class TsiWebAccountMarketingDetails :  IEquatable<TsiWebAccountMarketingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAccountMarketingDetails" /> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="detail">detail.</param>
        /// <param name="groups">groups.</param>
        /// <param name="profiles">profiles.</param>
        /// <param name="sICCodes">sICCodes.</param>
        public TsiWebAccountMarketingDetails(int? accountNumber = default(int?), TsiWebAccountMarketingDetail detail = default(TsiWebAccountMarketingDetail), List<TsiWebAssignedMarketingGroup> groups = default(List<TsiWebAssignedMarketingGroup>), List<TsiWebAssignedMarketingProfile> profiles = default(List<TsiWebAssignedMarketingProfile>), List<TsiWebAssignedSICCode> sICCodes = default(List<TsiWebAssignedSICCode>))
        {
            this.AccountNumber = accountNumber;
            this.Detail = detail;
            this.Groups = groups;
            this.Profiles = profiles;
            this.SICCodes = sICCodes;
        }
        
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="Detail", EmitDefaultValue=false)]
        public TsiWebAccountMarketingDetail Detail { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="Groups", EmitDefaultValue=false)]
        public List<TsiWebAssignedMarketingGroup> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="Profiles", EmitDefaultValue=false)]
        public List<TsiWebAssignedMarketingProfile> Profiles { get; set; }

        /// <summary>
        /// Gets or Sets SICCodes
        /// </summary>
        [DataMember(Name="SICCodes", EmitDefaultValue=false)]
        public List<TsiWebAssignedSICCode> SICCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAccountMarketingDetails {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  SICCodes: ").Append(SICCodes).Append("\n");
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
            return this.Equals(input as TsiWebAccountMarketingDetails);
        }

        /// <summary>
        /// Returns true if TsiWebAccountMarketingDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAccountMarketingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAccountMarketingDetails input)
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
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
                ) && 
                (
                    this.SICCodes == input.SICCodes ||
                    this.SICCodes != null &&
                    this.SICCodes.SequenceEqual(input.SICCodes)
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.SICCodes != null)
                    hashCode = hashCode * 59 + this.SICCodes.GetHashCode();
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