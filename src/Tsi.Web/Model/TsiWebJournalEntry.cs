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
    /// TsiWebJournalEntry
    /// </summary>
    [DataContract]
    public partial class TsiWebJournalEntry :  IEquatable<TsiWebJournalEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebJournalEntry" /> class.
        /// </summary>
        /// <param name="journalEntryId">journalEntryId.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="repNumber">repNumber.</param>
        /// <param name="topic">topic.</param>
        /// <param name="action">action.</param>
        /// <param name="note">note.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="isSystemEntry">isSystemEntry.</param>
        public TsiWebJournalEntry(int? journalEntryId = default(int?), int? accountNumber = default(int?), int? contactNumber = default(int?), int? repNumber = default(int?), string topic = default(string), string action = default(string), string note = default(string), DateTime? dateCreated = default(DateTime?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), bool? isSystemEntry = default(bool?))
        {
            this.JournalEntryId = journalEntryId;
            this.AccountNumber = accountNumber;
            this.ContactNumber = contactNumber;
            this.RepNumber = repNumber;
            this.Topic = topic;
            this.Action = action;
            this.Note = note;
            this.DateCreated = dateCreated;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IsSystemEntry = isSystemEntry;
        }
        
        /// <summary>
        /// Gets or Sets JournalEntryId
        /// </summary>
        [DataMember(Name="JournalEntryId", EmitDefaultValue=false)]
        public int? JournalEntryId { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public int? ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets RepNumber
        /// </summary>
        [DataMember(Name="RepNumber", EmitDefaultValue=false)]
        public int? RepNumber { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="Topic", EmitDefaultValue=false)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="Note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="DateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemEntry
        /// </summary>
        [DataMember(Name="IsSystemEntry", EmitDefaultValue=false)]
        public bool? IsSystemEntry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebJournalEntry {\n");
            sb.Append("  JournalEntryId: ").Append(JournalEntryId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  RepNumber: ").Append(RepNumber).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  IsSystemEntry: ").Append(IsSystemEntry).Append("\n");
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
            return this.Equals(input as TsiWebJournalEntry);
        }

        /// <summary>
        /// Returns true if TsiWebJournalEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebJournalEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebJournalEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JournalEntryId == input.JournalEntryId ||
                    (this.JournalEntryId != null &&
                    this.JournalEntryId.Equals(input.JournalEntryId))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.RepNumber == input.RepNumber ||
                    (this.RepNumber != null &&
                    this.RepNumber.Equals(input.RepNumber))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.IsSystemEntry == input.IsSystemEntry ||
                    (this.IsSystemEntry != null &&
                    this.IsSystemEntry.Equals(input.IsSystemEntry))
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
                if (this.JournalEntryId != null)
                    hashCode = hashCode * 59 + this.JournalEntryId.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.RepNumber != null)
                    hashCode = hashCode * 59 + this.RepNumber.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsSystemEntry != null)
                    hashCode = hashCode * 59 + this.IsSystemEntry.GetHashCode();
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