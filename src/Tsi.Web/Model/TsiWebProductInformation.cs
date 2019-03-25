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
    /// TsiWebProductInformation
    /// </summary>
    [DataContract]
    public partial class TsiWebProductInformation :  IEquatable<TsiWebProductInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebProductInformation" /> class.
        /// </summary>
        /// <param name="hasValidLicense">hasValidLicense.</param>
        /// <param name="isUsingNamedUserLicense">isUsingNamedUserLicense.</param>
        /// <param name="isTigerpawOne">isTigerpawOne.</param>
        /// <param name="isArchivedDatabase">isArchivedDatabase.</param>
        /// <param name="databaseVersion">databaseVersion.</param>
        public TsiWebProductInformation(bool? hasValidLicense = default(bool?), bool? isUsingNamedUserLicense = default(bool?), bool? isTigerpawOne = default(bool?), bool? isArchivedDatabase = default(bool?), string databaseVersion = default(string))
        {
            this.HasValidLicense = hasValidLicense;
            this.IsUsingNamedUserLicense = isUsingNamedUserLicense;
            this.IsTigerpawOne = isTigerpawOne;
            this.IsArchivedDatabase = isArchivedDatabase;
            this.DatabaseVersion = databaseVersion;
        }
        
        /// <summary>
        /// Gets or Sets HasValidLicense
        /// </summary>
        [DataMember(Name="HasValidLicense", EmitDefaultValue=false)]
        public bool? HasValidLicense { get; set; }

        /// <summary>
        /// Gets or Sets IsUsingNamedUserLicense
        /// </summary>
        [DataMember(Name="IsUsingNamedUserLicense", EmitDefaultValue=false)]
        public bool? IsUsingNamedUserLicense { get; set; }

        /// <summary>
        /// Gets or Sets IsTigerpawOne
        /// </summary>
        [DataMember(Name="IsTigerpawOne", EmitDefaultValue=false)]
        public bool? IsTigerpawOne { get; set; }

        /// <summary>
        /// Gets or Sets IsArchivedDatabase
        /// </summary>
        [DataMember(Name="IsArchivedDatabase", EmitDefaultValue=false)]
        public bool? IsArchivedDatabase { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseVersion
        /// </summary>
        [DataMember(Name="DatabaseVersion", EmitDefaultValue=false)]
        public string DatabaseVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebProductInformation {\n");
            sb.Append("  HasValidLicense: ").Append(HasValidLicense).Append("\n");
            sb.Append("  IsUsingNamedUserLicense: ").Append(IsUsingNamedUserLicense).Append("\n");
            sb.Append("  IsTigerpawOne: ").Append(IsTigerpawOne).Append("\n");
            sb.Append("  IsArchivedDatabase: ").Append(IsArchivedDatabase).Append("\n");
            sb.Append("  DatabaseVersion: ").Append(DatabaseVersion).Append("\n");
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
            return this.Equals(input as TsiWebProductInformation);
        }

        /// <summary>
        /// Returns true if TsiWebProductInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebProductInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebProductInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasValidLicense == input.HasValidLicense ||
                    (this.HasValidLicense != null &&
                    this.HasValidLicense.Equals(input.HasValidLicense))
                ) && 
                (
                    this.IsUsingNamedUserLicense == input.IsUsingNamedUserLicense ||
                    (this.IsUsingNamedUserLicense != null &&
                    this.IsUsingNamedUserLicense.Equals(input.IsUsingNamedUserLicense))
                ) && 
                (
                    this.IsTigerpawOne == input.IsTigerpawOne ||
                    (this.IsTigerpawOne != null &&
                    this.IsTigerpawOne.Equals(input.IsTigerpawOne))
                ) && 
                (
                    this.IsArchivedDatabase == input.IsArchivedDatabase ||
                    (this.IsArchivedDatabase != null &&
                    this.IsArchivedDatabase.Equals(input.IsArchivedDatabase))
                ) && 
                (
                    this.DatabaseVersion == input.DatabaseVersion ||
                    (this.DatabaseVersion != null &&
                    this.DatabaseVersion.Equals(input.DatabaseVersion))
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
                if (this.HasValidLicense != null)
                    hashCode = hashCode * 59 + this.HasValidLicense.GetHashCode();
                if (this.IsUsingNamedUserLicense != null)
                    hashCode = hashCode * 59 + this.IsUsingNamedUserLicense.GetHashCode();
                if (this.IsTigerpawOne != null)
                    hashCode = hashCode * 59 + this.IsTigerpawOne.GetHashCode();
                if (this.IsArchivedDatabase != null)
                    hashCode = hashCode * 59 + this.IsArchivedDatabase.GetHashCode();
                if (this.DatabaseVersion != null)
                    hashCode = hashCode * 59 + this.DatabaseVersion.GetHashCode();
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
