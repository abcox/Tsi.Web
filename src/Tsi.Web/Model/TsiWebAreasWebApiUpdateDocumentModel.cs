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
    /// TsiWebAreasWebApiUpdateDocumentModel
    /// </summary>
    [DataContract]
    public partial class TsiWebAreasWebApiUpdateDocumentModel :  IEquatable<TsiWebAreasWebApiUpdateDocumentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAreasWebApiUpdateDocumentModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebAreasWebApiUpdateDocumentModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAreasWebApiUpdateDocumentModel" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="topic">topic (required).</param>
        /// <param name="description">description.</param>
        /// <param name="displayInPortal">displayInPortal.</param>
        /// <param name="contactNumber">contactNumber.</param>
        public TsiWebAreasWebApiUpdateDocumentModel(string title = default(string), string topic = default(string), string description = default(string), bool? displayInPortal = default(bool?), int? contactNumber = default(int?))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TsiWebAreasWebApiUpdateDocumentModel and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "topic" is required (not null)
            if (topic == null)
            {
                throw new InvalidDataException("topic is a required property for TsiWebAreasWebApiUpdateDocumentModel and cannot be null");
            }
            else
            {
                this.Topic = topic;
            }
            this.Description = description;
            this.DisplayInPortal = displayInPortal;
            this.ContactNumber = contactNumber;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="Topic", EmitDefaultValue=false)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayInPortal
        /// </summary>
        [DataMember(Name="DisplayInPortal", EmitDefaultValue=false)]
        public bool? DisplayInPortal { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public int? ContactNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAreasWebApiUpdateDocumentModel {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayInPortal: ").Append(DisplayInPortal).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
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
            return this.Equals(input as TsiWebAreasWebApiUpdateDocumentModel);
        }

        /// <summary>
        /// Returns true if TsiWebAreasWebApiUpdateDocumentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAreasWebApiUpdateDocumentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAreasWebApiUpdateDocumentModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayInPortal == input.DisplayInPortal ||
                    (this.DisplayInPortal != null &&
                    this.DisplayInPortal.Equals(input.DisplayInPortal))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayInPortal != null)
                    hashCode = hashCode * 59 + this.DisplayInPortal.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
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
