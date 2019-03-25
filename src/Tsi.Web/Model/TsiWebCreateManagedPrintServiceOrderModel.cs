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
    /// TsiWebCreateManagedPrintServiceOrderModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateManagedPrintServiceOrderModel :  IEquatable<TsiWebCreateManagedPrintServiceOrderModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateManagedPrintServiceOrderModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TsiWebCreateManagedPrintServiceOrderModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateManagedPrintServiceOrderModel" /> class.
        /// </summary>
        /// <param name="deviceId">deviceId (required).</param>
        /// <param name="allowInactiveContract">allowInactiveContract.</param>
        /// <param name="allowFutureContract">allowFutureContract.</param>
        /// <param name="allowContractNoRemaining">allowContractNoRemaining.</param>
        /// <param name="externalTicketId">externalTicketId (required).</param>
        /// <param name="briefDescription">briefDescription.</param>
        /// <param name="status">status.</param>
        /// <param name="serviceOrderType">serviceOrderType.</param>
        /// <param name="priority">priority.</param>
        /// <param name="workRequested">workRequested.</param>
        /// <param name="workPerformed">workPerformed.</param>
        /// <param name="internalComments">internalComments.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="dispatchBoardNumber">dispatchBoardNumber.</param>
        /// <param name="takenBy">takenBy.</param>
        /// <param name="technicianAssigned">technicianAssigned.</param>
        /// <param name="note">note.</param>
        /// <param name="alertUrl">alertUrl.</param>
        /// <param name="webLinks">webLinks.</param>
        public TsiWebCreateManagedPrintServiceOrderModel(string deviceId = default(string), bool? allowInactiveContract = default(bool?), bool? allowFutureContract = default(bool?), bool? allowContractNoRemaining = default(bool?), string externalTicketId = default(string), string briefDescription = default(string), string status = default(string), string serviceOrderType = default(string), string priority = default(string), string workRequested = default(string), string workPerformed = default(string), string internalComments = default(string), int? contactNumber = default(int?), int? dispatchBoardNumber = default(int?), int? takenBy = default(int?), int? technicianAssigned = default(int?), string note = default(string), string alertUrl = default(string), List<TsiWebServiceOrderWebLink> webLinks = default(List<TsiWebServiceOrderWebLink>))
        {
            // to ensure "deviceId" is required (not null)
            if (deviceId == null)
            {
                throw new InvalidDataException("deviceId is a required property for TsiWebCreateManagedPrintServiceOrderModel and cannot be null");
            }
            else
            {
                this.DeviceId = deviceId;
            }
            // to ensure "externalTicketId" is required (not null)
            if (externalTicketId == null)
            {
                throw new InvalidDataException("externalTicketId is a required property for TsiWebCreateManagedPrintServiceOrderModel and cannot be null");
            }
            else
            {
                this.ExternalTicketId = externalTicketId;
            }
            this.AllowInactiveContract = allowInactiveContract;
            this.AllowFutureContract = allowFutureContract;
            this.AllowContractNoRemaining = allowContractNoRemaining;
            this.BriefDescription = briefDescription;
            this.Status = status;
            this.ServiceOrderType = serviceOrderType;
            this.Priority = priority;
            this.WorkRequested = workRequested;
            this.WorkPerformed = workPerformed;
            this.InternalComments = internalComments;
            this.ContactNumber = contactNumber;
            this.DispatchBoardNumber = dispatchBoardNumber;
            this.TakenBy = takenBy;
            this.TechnicianAssigned = technicianAssigned;
            this.Note = note;
            this.AlertUrl = alertUrl;
            this.WebLinks = webLinks;
        }
        
        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="DeviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets AllowInactiveContract
        /// </summary>
        [DataMember(Name="AllowInactiveContract", EmitDefaultValue=false)]
        public bool? AllowInactiveContract { get; set; }

        /// <summary>
        /// Gets or Sets AllowFutureContract
        /// </summary>
        [DataMember(Name="AllowFutureContract", EmitDefaultValue=false)]
        public bool? AllowFutureContract { get; set; }

        /// <summary>
        /// Gets or Sets AllowContractNoRemaining
        /// </summary>
        [DataMember(Name="AllowContractNoRemaining", EmitDefaultValue=false)]
        public bool? AllowContractNoRemaining { get; set; }

        /// <summary>
        /// Gets or Sets ExternalTicketId
        /// </summary>
        [DataMember(Name="ExternalTicketId", EmitDefaultValue=false)]
        public string ExternalTicketId { get; set; }

        /// <summary>
        /// Gets or Sets BriefDescription
        /// </summary>
        [DataMember(Name="BriefDescription", EmitDefaultValue=false)]
        public string BriefDescription { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderType
        /// </summary>
        [DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
        public string ServiceOrderType { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="Priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets WorkRequested
        /// </summary>
        [DataMember(Name="WorkRequested", EmitDefaultValue=false)]
        public string WorkRequested { get; set; }

        /// <summary>
        /// Gets or Sets WorkPerformed
        /// </summary>
        [DataMember(Name="WorkPerformed", EmitDefaultValue=false)]
        public string WorkPerformed { get; set; }

        /// <summary>
        /// Gets or Sets InternalComments
        /// </summary>
        [DataMember(Name="InternalComments", EmitDefaultValue=false)]
        public string InternalComments { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public int? ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets DispatchBoardNumber
        /// </summary>
        [DataMember(Name="DispatchBoardNumber", EmitDefaultValue=false)]
        public int? DispatchBoardNumber { get; set; }

        /// <summary>
        /// Gets or Sets TakenBy
        /// </summary>
        [DataMember(Name="TakenBy", EmitDefaultValue=false)]
        public int? TakenBy { get; set; }

        /// <summary>
        /// Gets or Sets TechnicianAssigned
        /// </summary>
        [DataMember(Name="TechnicianAssigned", EmitDefaultValue=false)]
        public int? TechnicianAssigned { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="Note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets AlertUrl
        /// </summary>
        [DataMember(Name="AlertUrl", EmitDefaultValue=false)]
        public string AlertUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebLinks
        /// </summary>
        [DataMember(Name="WebLinks", EmitDefaultValue=false)]
        public List<TsiWebServiceOrderWebLink> WebLinks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateManagedPrintServiceOrderModel {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  AllowInactiveContract: ").Append(AllowInactiveContract).Append("\n");
            sb.Append("  AllowFutureContract: ").Append(AllowFutureContract).Append("\n");
            sb.Append("  AllowContractNoRemaining: ").Append(AllowContractNoRemaining).Append("\n");
            sb.Append("  ExternalTicketId: ").Append(ExternalTicketId).Append("\n");
            sb.Append("  BriefDescription: ").Append(BriefDescription).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ServiceOrderType: ").Append(ServiceOrderType).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  WorkRequested: ").Append(WorkRequested).Append("\n");
            sb.Append("  WorkPerformed: ").Append(WorkPerformed).Append("\n");
            sb.Append("  InternalComments: ").Append(InternalComments).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  DispatchBoardNumber: ").Append(DispatchBoardNumber).Append("\n");
            sb.Append("  TakenBy: ").Append(TakenBy).Append("\n");
            sb.Append("  TechnicianAssigned: ").Append(TechnicianAssigned).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  AlertUrl: ").Append(AlertUrl).Append("\n");
            sb.Append("  WebLinks: ").Append(WebLinks).Append("\n");
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
            return this.Equals(input as TsiWebCreateManagedPrintServiceOrderModel);
        }

        /// <summary>
        /// Returns true if TsiWebCreateManagedPrintServiceOrderModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateManagedPrintServiceOrderModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateManagedPrintServiceOrderModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.AllowInactiveContract == input.AllowInactiveContract ||
                    (this.AllowInactiveContract != null &&
                    this.AllowInactiveContract.Equals(input.AllowInactiveContract))
                ) && 
                (
                    this.AllowFutureContract == input.AllowFutureContract ||
                    (this.AllowFutureContract != null &&
                    this.AllowFutureContract.Equals(input.AllowFutureContract))
                ) && 
                (
                    this.AllowContractNoRemaining == input.AllowContractNoRemaining ||
                    (this.AllowContractNoRemaining != null &&
                    this.AllowContractNoRemaining.Equals(input.AllowContractNoRemaining))
                ) && 
                (
                    this.ExternalTicketId == input.ExternalTicketId ||
                    (this.ExternalTicketId != null &&
                    this.ExternalTicketId.Equals(input.ExternalTicketId))
                ) && 
                (
                    this.BriefDescription == input.BriefDescription ||
                    (this.BriefDescription != null &&
                    this.BriefDescription.Equals(input.BriefDescription))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ServiceOrderType == input.ServiceOrderType ||
                    (this.ServiceOrderType != null &&
                    this.ServiceOrderType.Equals(input.ServiceOrderType))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.WorkRequested == input.WorkRequested ||
                    (this.WorkRequested != null &&
                    this.WorkRequested.Equals(input.WorkRequested))
                ) && 
                (
                    this.WorkPerformed == input.WorkPerformed ||
                    (this.WorkPerformed != null &&
                    this.WorkPerformed.Equals(input.WorkPerformed))
                ) && 
                (
                    this.InternalComments == input.InternalComments ||
                    (this.InternalComments != null &&
                    this.InternalComments.Equals(input.InternalComments))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.DispatchBoardNumber == input.DispatchBoardNumber ||
                    (this.DispatchBoardNumber != null &&
                    this.DispatchBoardNumber.Equals(input.DispatchBoardNumber))
                ) && 
                (
                    this.TakenBy == input.TakenBy ||
                    (this.TakenBy != null &&
                    this.TakenBy.Equals(input.TakenBy))
                ) && 
                (
                    this.TechnicianAssigned == input.TechnicianAssigned ||
                    (this.TechnicianAssigned != null &&
                    this.TechnicianAssigned.Equals(input.TechnicianAssigned))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.AlertUrl == input.AlertUrl ||
                    (this.AlertUrl != null &&
                    this.AlertUrl.Equals(input.AlertUrl))
                ) && 
                (
                    this.WebLinks == input.WebLinks ||
                    this.WebLinks != null &&
                    this.WebLinks.SequenceEqual(input.WebLinks)
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
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.AllowInactiveContract != null)
                    hashCode = hashCode * 59 + this.AllowInactiveContract.GetHashCode();
                if (this.AllowFutureContract != null)
                    hashCode = hashCode * 59 + this.AllowFutureContract.GetHashCode();
                if (this.AllowContractNoRemaining != null)
                    hashCode = hashCode * 59 + this.AllowContractNoRemaining.GetHashCode();
                if (this.ExternalTicketId != null)
                    hashCode = hashCode * 59 + this.ExternalTicketId.GetHashCode();
                if (this.BriefDescription != null)
                    hashCode = hashCode * 59 + this.BriefDescription.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ServiceOrderType != null)
                    hashCode = hashCode * 59 + this.ServiceOrderType.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.WorkRequested != null)
                    hashCode = hashCode * 59 + this.WorkRequested.GetHashCode();
                if (this.WorkPerformed != null)
                    hashCode = hashCode * 59 + this.WorkPerformed.GetHashCode();
                if (this.InternalComments != null)
                    hashCode = hashCode * 59 + this.InternalComments.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.DispatchBoardNumber != null)
                    hashCode = hashCode * 59 + this.DispatchBoardNumber.GetHashCode();
                if (this.TakenBy != null)
                    hashCode = hashCode * 59 + this.TakenBy.GetHashCode();
                if (this.TechnicianAssigned != null)
                    hashCode = hashCode * 59 + this.TechnicianAssigned.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.AlertUrl != null)
                    hashCode = hashCode * 59 + this.AlertUrl.GetHashCode();
                if (this.WebLinks != null)
                    hashCode = hashCode * 59 + this.WebLinks.GetHashCode();
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