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
    /// TsiWebTaskSummary
    /// </summary>
    [DataContract]
    public partial class TsiWebTaskSummary :  IEquatable<TsiWebTaskSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebTaskSummary" /> class.
        /// </summary>
        /// <param name="taskNumber">taskNumber.</param>
        /// <param name="task">task.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="faxNumber">faxNumber.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactEmailAddress">contactEmailAddress.</param>
        /// <param name="contactPhoneNumber">contactPhoneNumber.</param>
        /// <param name="scheduledForRepName">scheduledForRepName.</param>
        /// <param name="scheduledByRepName">scheduledByRepName.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="projectPhase">projectPhase.</param>
        /// <param name="projectSubPhase">projectSubPhase.</param>
        /// <param name="serviceOrderDescription">serviceOrderDescription.</param>
        /// <param name="quoteDescription">quoteDescription.</param>
        /// <param name="opportunityName">opportunityName.</param>
        public TsiWebTaskSummary(int? taskNumber = default(int?), TsiWebTask task = default(TsiWebTask), string accountName = default(string), string phoneNumber = default(string), string faxNumber = default(string), string contactName = default(string), string contactEmailAddress = default(string), string contactPhoneNumber = default(string), string scheduledForRepName = default(string), string scheduledByRepName = default(string), string projectName = default(string), string projectPhase = default(string), string projectSubPhase = default(string), string serviceOrderDescription = default(string), string quoteDescription = default(string), string opportunityName = default(string))
        {
            this.TaskNumber = taskNumber;
            this.Task = task;
            this.AccountName = accountName;
            this.PhoneNumber = phoneNumber;
            this.FaxNumber = faxNumber;
            this.ContactName = contactName;
            this.ContactEmailAddress = contactEmailAddress;
            this.ContactPhoneNumber = contactPhoneNumber;
            this.ScheduledForRepName = scheduledForRepName;
            this.ScheduledByRepName = scheduledByRepName;
            this.ProjectName = projectName;
            this.ProjectPhase = projectPhase;
            this.ProjectSubPhase = projectSubPhase;
            this.ServiceOrderDescription = serviceOrderDescription;
            this.QuoteDescription = quoteDescription;
            this.OpportunityName = opportunityName;
        }
        
        /// <summary>
        /// Gets or Sets TaskNumber
        /// </summary>
        [DataMember(Name="TaskNumber", EmitDefaultValue=false)]
        public int? TaskNumber { get; set; }

        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="Task", EmitDefaultValue=false)]
        public TsiWebTask Task { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets FaxNumber
        /// </summary>
        [DataMember(Name="FaxNumber", EmitDefaultValue=false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="ContactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmailAddress
        /// </summary>
        [DataMember(Name="ContactEmailAddress", EmitDefaultValue=false)]
        public string ContactEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhoneNumber
        /// </summary>
        [DataMember(Name="ContactPhoneNumber", EmitDefaultValue=false)]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledForRepName
        /// </summary>
        [DataMember(Name="ScheduledForRepName", EmitDefaultValue=false)]
        public string ScheduledForRepName { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledByRepName
        /// </summary>
        [DataMember(Name="ScheduledByRepName", EmitDefaultValue=false)]
        public string ScheduledByRepName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="ProjectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectPhase
        /// </summary>
        [DataMember(Name="ProjectPhase", EmitDefaultValue=false)]
        public string ProjectPhase { get; set; }

        /// <summary>
        /// Gets or Sets ProjectSubPhase
        /// </summary>
        [DataMember(Name="ProjectSubPhase", EmitDefaultValue=false)]
        public string ProjectSubPhase { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderDescription
        /// </summary>
        [DataMember(Name="ServiceOrderDescription", EmitDefaultValue=false)]
        public string ServiceOrderDescription { get; set; }

        /// <summary>
        /// Gets or Sets QuoteDescription
        /// </summary>
        [DataMember(Name="QuoteDescription", EmitDefaultValue=false)]
        public string QuoteDescription { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityName
        /// </summary>
        [DataMember(Name="OpportunityName", EmitDefaultValue=false)]
        public string OpportunityName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebTaskSummary {\n");
            sb.Append("  TaskNumber: ").Append(TaskNumber).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
            sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
            sb.Append("  ScheduledForRepName: ").Append(ScheduledForRepName).Append("\n");
            sb.Append("  ScheduledByRepName: ").Append(ScheduledByRepName).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  ProjectPhase: ").Append(ProjectPhase).Append("\n");
            sb.Append("  ProjectSubPhase: ").Append(ProjectSubPhase).Append("\n");
            sb.Append("  ServiceOrderDescription: ").Append(ServiceOrderDescription).Append("\n");
            sb.Append("  QuoteDescription: ").Append(QuoteDescription).Append("\n");
            sb.Append("  OpportunityName: ").Append(OpportunityName).Append("\n");
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
            return this.Equals(input as TsiWebTaskSummary);
        }

        /// <summary>
        /// Returns true if TsiWebTaskSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebTaskSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebTaskSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskNumber == input.TaskNumber ||
                    (this.TaskNumber != null &&
                    this.TaskNumber.Equals(input.TaskNumber))
                ) && 
                (
                    this.Task == input.Task ||
                    (this.Task != null &&
                    this.Task.Equals(input.Task))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.FaxNumber == input.FaxNumber ||
                    (this.FaxNumber != null &&
                    this.FaxNumber.Equals(input.FaxNumber))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactEmailAddress == input.ContactEmailAddress ||
                    (this.ContactEmailAddress != null &&
                    this.ContactEmailAddress.Equals(input.ContactEmailAddress))
                ) && 
                (
                    this.ContactPhoneNumber == input.ContactPhoneNumber ||
                    (this.ContactPhoneNumber != null &&
                    this.ContactPhoneNumber.Equals(input.ContactPhoneNumber))
                ) && 
                (
                    this.ScheduledForRepName == input.ScheduledForRepName ||
                    (this.ScheduledForRepName != null &&
                    this.ScheduledForRepName.Equals(input.ScheduledForRepName))
                ) && 
                (
                    this.ScheduledByRepName == input.ScheduledByRepName ||
                    (this.ScheduledByRepName != null &&
                    this.ScheduledByRepName.Equals(input.ScheduledByRepName))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.ProjectPhase == input.ProjectPhase ||
                    (this.ProjectPhase != null &&
                    this.ProjectPhase.Equals(input.ProjectPhase))
                ) && 
                (
                    this.ProjectSubPhase == input.ProjectSubPhase ||
                    (this.ProjectSubPhase != null &&
                    this.ProjectSubPhase.Equals(input.ProjectSubPhase))
                ) && 
                (
                    this.ServiceOrderDescription == input.ServiceOrderDescription ||
                    (this.ServiceOrderDescription != null &&
                    this.ServiceOrderDescription.Equals(input.ServiceOrderDescription))
                ) && 
                (
                    this.QuoteDescription == input.QuoteDescription ||
                    (this.QuoteDescription != null &&
                    this.QuoteDescription.Equals(input.QuoteDescription))
                ) && 
                (
                    this.OpportunityName == input.OpportunityName ||
                    (this.OpportunityName != null &&
                    this.OpportunityName.Equals(input.OpportunityName))
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
                if (this.TaskNumber != null)
                    hashCode = hashCode * 59 + this.TaskNumber.GetHashCode();
                if (this.Task != null)
                    hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.FaxNumber != null)
                    hashCode = hashCode * 59 + this.FaxNumber.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.ContactEmailAddress != null)
                    hashCode = hashCode * 59 + this.ContactEmailAddress.GetHashCode();
                if (this.ContactPhoneNumber != null)
                    hashCode = hashCode * 59 + this.ContactPhoneNumber.GetHashCode();
                if (this.ScheduledForRepName != null)
                    hashCode = hashCode * 59 + this.ScheduledForRepName.GetHashCode();
                if (this.ScheduledByRepName != null)
                    hashCode = hashCode * 59 + this.ScheduledByRepName.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ProjectPhase != null)
                    hashCode = hashCode * 59 + this.ProjectPhase.GetHashCode();
                if (this.ProjectSubPhase != null)
                    hashCode = hashCode * 59 + this.ProjectSubPhase.GetHashCode();
                if (this.ServiceOrderDescription != null)
                    hashCode = hashCode * 59 + this.ServiceOrderDescription.GetHashCode();
                if (this.QuoteDescription != null)
                    hashCode = hashCode * 59 + this.QuoteDescription.GetHashCode();
                if (this.OpportunityName != null)
                    hashCode = hashCode * 59 + this.OpportunityName.GetHashCode();
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
