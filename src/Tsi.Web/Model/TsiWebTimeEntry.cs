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
    /// TsiWebTimeEntry
    /// </summary>
    [DataContract]
    public partial class TsiWebTimeEntry :  IEquatable<TsiWebTimeEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebTimeEntry" /> class.
        /// </summary>
        /// <param name="entryType">entryType.</param>
        /// <param name="timeEntryKeyNumber">timeEntryKeyNumber.</param>
        /// <param name="serviceOrderNumber">serviceOrderNumber.</param>
        /// <param name="sOBriefDescription">sOBriefDescription.</param>
        /// <param name="sOWorkPerformed">sOWorkPerformed.</param>
        /// <param name="logReason">logReason.</param>
        /// <param name="techAssigned">techAssigned.</param>
        /// <param name="techAssignedName">techAssignedName.</param>
        /// <param name="startDateTime">startDateTime.</param>
        /// <param name="endDateTime">endDateTime.</param>
        /// <param name="logHours">logHours.</param>
        /// <param name="logMinutes">logMinutes.</param>
        /// <param name="elapsedHours">elapsedHours.</param>
        /// <param name="elapsedMinutes">elapsedMinutes.</param>
        /// <param name="utilizationHours">utilizationHours.</param>
        /// <param name="utilizationMinutes">utilizationMinutes.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="acceptanceStatus">acceptanceStatus.</param>
        /// <param name="internalComments">internalComments.</param>
        /// <param name="logComment">logComment.</param>
        /// <param name="billable">billable.</param>
        /// <param name="chargable">chargable.</param>
        /// <param name="billingOption">billingOption.</param>
        /// <param name="unitFactor">unitFactor.</param>
        /// <param name="totalUnits">totalUnits.</param>
        /// <param name="contractNumber">contractNumber.</param>
        public TsiWebTimeEntry(string entryType = default(string), int? timeEntryKeyNumber = default(int?), int? serviceOrderNumber = default(int?), string sOBriefDescription = default(string), string sOWorkPerformed = default(string), string logReason = default(string), int? techAssigned = default(int?), string techAssignedName = default(string), DateTime? startDateTime = default(DateTime?), DateTime? endDateTime = default(DateTime?), int? logHours = default(int?), int? logMinutes = default(int?), int? elapsedHours = default(int?), int? elapsedMinutes = default(int?), int? utilizationHours = default(int?), int? utilizationMinutes = default(int?), int? accountNumber = default(int?), string accountName = default(string), int? acceptanceStatus = default(int?), string internalComments = default(string), string logComment = default(string), bool? billable = default(bool?), bool? chargable = default(bool?), string billingOption = default(string), double? unitFactor = default(double?), double? totalUnits = default(double?), int? contractNumber = default(int?))
        {
            this.EntryType = entryType;
            this.TimeEntryKeyNumber = timeEntryKeyNumber;
            this.ServiceOrderNumber = serviceOrderNumber;
            this.SOBriefDescription = sOBriefDescription;
            this.SOWorkPerformed = sOWorkPerformed;
            this.LogReason = logReason;
            this.TechAssigned = techAssigned;
            this.TechAssignedName = techAssignedName;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.LogHours = logHours;
            this.LogMinutes = logMinutes;
            this.ElapsedHours = elapsedHours;
            this.ElapsedMinutes = elapsedMinutes;
            this.UtilizationHours = utilizationHours;
            this.UtilizationMinutes = utilizationMinutes;
            this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.AcceptanceStatus = acceptanceStatus;
            this.InternalComments = internalComments;
            this.LogComment = logComment;
            this.Billable = billable;
            this.Chargable = chargable;
            this.BillingOption = billingOption;
            this.UnitFactor = unitFactor;
            this.TotalUnits = totalUnits;
            this.ContractNumber = contractNumber;
        }
        
        /// <summary>
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name="EntryType", EmitDefaultValue=false)]
        public string EntryType { get; set; }

        /// <summary>
        /// Gets or Sets TimeEntryKeyNumber
        /// </summary>
        [DataMember(Name="TimeEntryKeyNumber", EmitDefaultValue=false)]
        public int? TimeEntryKeyNumber { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderNumber
        /// </summary>
        [DataMember(Name="ServiceOrderNumber", EmitDefaultValue=false)]
        public int? ServiceOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets SOBriefDescription
        /// </summary>
        [DataMember(Name="SOBriefDescription", EmitDefaultValue=false)]
        public string SOBriefDescription { get; set; }

        /// <summary>
        /// Gets or Sets SOWorkPerformed
        /// </summary>
        [DataMember(Name="SOWorkPerformed", EmitDefaultValue=false)]
        public string SOWorkPerformed { get; set; }

        /// <summary>
        /// Gets or Sets LogReason
        /// </summary>
        [DataMember(Name="LogReason", EmitDefaultValue=false)]
        public string LogReason { get; set; }

        /// <summary>
        /// Gets or Sets TechAssigned
        /// </summary>
        [DataMember(Name="TechAssigned", EmitDefaultValue=false)]
        public int? TechAssigned { get; set; }

        /// <summary>
        /// Gets or Sets TechAssignedName
        /// </summary>
        [DataMember(Name="TechAssignedName", EmitDefaultValue=false)]
        public string TechAssignedName { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name="StartDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name="EndDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LogHours
        /// </summary>
        [DataMember(Name="LogHours", EmitDefaultValue=false)]
        public int? LogHours { get; set; }

        /// <summary>
        /// Gets or Sets LogMinutes
        /// </summary>
        [DataMember(Name="LogMinutes", EmitDefaultValue=false)]
        public int? LogMinutes { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedHours
        /// </summary>
        [DataMember(Name="ElapsedHours", EmitDefaultValue=false)]
        public int? ElapsedHours { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedMinutes
        /// </summary>
        [DataMember(Name="ElapsedMinutes", EmitDefaultValue=false)]
        public int? ElapsedMinutes { get; set; }

        /// <summary>
        /// Gets or Sets UtilizationHours
        /// </summary>
        [DataMember(Name="UtilizationHours", EmitDefaultValue=false)]
        public int? UtilizationHours { get; set; }

        /// <summary>
        /// Gets or Sets UtilizationMinutes
        /// </summary>
        [DataMember(Name="UtilizationMinutes", EmitDefaultValue=false)]
        public int? UtilizationMinutes { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets AcceptanceStatus
        /// </summary>
        [DataMember(Name="AcceptanceStatus", EmitDefaultValue=false)]
        public int? AcceptanceStatus { get; set; }

        /// <summary>
        /// Gets or Sets InternalComments
        /// </summary>
        [DataMember(Name="InternalComments", EmitDefaultValue=false)]
        public string InternalComments { get; set; }

        /// <summary>
        /// Gets or Sets LogComment
        /// </summary>
        [DataMember(Name="LogComment", EmitDefaultValue=false)]
        public string LogComment { get; set; }

        /// <summary>
        /// Gets or Sets Billable
        /// </summary>
        [DataMember(Name="Billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// Gets or Sets Chargable
        /// </summary>
        [DataMember(Name="Chargable", EmitDefaultValue=false)]
        public bool? Chargable { get; set; }

        /// <summary>
        /// Gets or Sets BillingOption
        /// </summary>
        [DataMember(Name="BillingOption", EmitDefaultValue=false)]
        public string BillingOption { get; set; }

        /// <summary>
        /// Gets or Sets UnitFactor
        /// </summary>
        [DataMember(Name="UnitFactor", EmitDefaultValue=false)]
        public double? UnitFactor { get; set; }

        /// <summary>
        /// Gets or Sets TotalUnits
        /// </summary>
        [DataMember(Name="TotalUnits", EmitDefaultValue=false)]
        public double? TotalUnits { get; set; }

        /// <summary>
        /// Gets or Sets ContractNumber
        /// </summary>
        [DataMember(Name="ContractNumber", EmitDefaultValue=false)]
        public int? ContractNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebTimeEntry {\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  TimeEntryKeyNumber: ").Append(TimeEntryKeyNumber).Append("\n");
            sb.Append("  ServiceOrderNumber: ").Append(ServiceOrderNumber).Append("\n");
            sb.Append("  SOBriefDescription: ").Append(SOBriefDescription).Append("\n");
            sb.Append("  SOWorkPerformed: ").Append(SOWorkPerformed).Append("\n");
            sb.Append("  LogReason: ").Append(LogReason).Append("\n");
            sb.Append("  TechAssigned: ").Append(TechAssigned).Append("\n");
            sb.Append("  TechAssignedName: ").Append(TechAssignedName).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  LogHours: ").Append(LogHours).Append("\n");
            sb.Append("  LogMinutes: ").Append(LogMinutes).Append("\n");
            sb.Append("  ElapsedHours: ").Append(ElapsedHours).Append("\n");
            sb.Append("  ElapsedMinutes: ").Append(ElapsedMinutes).Append("\n");
            sb.Append("  UtilizationHours: ").Append(UtilizationHours).Append("\n");
            sb.Append("  UtilizationMinutes: ").Append(UtilizationMinutes).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AcceptanceStatus: ").Append(AcceptanceStatus).Append("\n");
            sb.Append("  InternalComments: ").Append(InternalComments).Append("\n");
            sb.Append("  LogComment: ").Append(LogComment).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  Chargable: ").Append(Chargable).Append("\n");
            sb.Append("  BillingOption: ").Append(BillingOption).Append("\n");
            sb.Append("  UnitFactor: ").Append(UnitFactor).Append("\n");
            sb.Append("  TotalUnits: ").Append(TotalUnits).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
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
            return this.Equals(input as TsiWebTimeEntry);
        }

        /// <summary>
        /// Returns true if TsiWebTimeEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebTimeEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebTimeEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntryType == input.EntryType ||
                    (this.EntryType != null &&
                    this.EntryType.Equals(input.EntryType))
                ) && 
                (
                    this.TimeEntryKeyNumber == input.TimeEntryKeyNumber ||
                    (this.TimeEntryKeyNumber != null &&
                    this.TimeEntryKeyNumber.Equals(input.TimeEntryKeyNumber))
                ) && 
                (
                    this.ServiceOrderNumber == input.ServiceOrderNumber ||
                    (this.ServiceOrderNumber != null &&
                    this.ServiceOrderNumber.Equals(input.ServiceOrderNumber))
                ) && 
                (
                    this.SOBriefDescription == input.SOBriefDescription ||
                    (this.SOBriefDescription != null &&
                    this.SOBriefDescription.Equals(input.SOBriefDescription))
                ) && 
                (
                    this.SOWorkPerformed == input.SOWorkPerformed ||
                    (this.SOWorkPerformed != null &&
                    this.SOWorkPerformed.Equals(input.SOWorkPerformed))
                ) && 
                (
                    this.LogReason == input.LogReason ||
                    (this.LogReason != null &&
                    this.LogReason.Equals(input.LogReason))
                ) && 
                (
                    this.TechAssigned == input.TechAssigned ||
                    (this.TechAssigned != null &&
                    this.TechAssigned.Equals(input.TechAssigned))
                ) && 
                (
                    this.TechAssignedName == input.TechAssignedName ||
                    (this.TechAssignedName != null &&
                    this.TechAssignedName.Equals(input.TechAssignedName))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.LogHours == input.LogHours ||
                    (this.LogHours != null &&
                    this.LogHours.Equals(input.LogHours))
                ) && 
                (
                    this.LogMinutes == input.LogMinutes ||
                    (this.LogMinutes != null &&
                    this.LogMinutes.Equals(input.LogMinutes))
                ) && 
                (
                    this.ElapsedHours == input.ElapsedHours ||
                    (this.ElapsedHours != null &&
                    this.ElapsedHours.Equals(input.ElapsedHours))
                ) && 
                (
                    this.ElapsedMinutes == input.ElapsedMinutes ||
                    (this.ElapsedMinutes != null &&
                    this.ElapsedMinutes.Equals(input.ElapsedMinutes))
                ) && 
                (
                    this.UtilizationHours == input.UtilizationHours ||
                    (this.UtilizationHours != null &&
                    this.UtilizationHours.Equals(input.UtilizationHours))
                ) && 
                (
                    this.UtilizationMinutes == input.UtilizationMinutes ||
                    (this.UtilizationMinutes != null &&
                    this.UtilizationMinutes.Equals(input.UtilizationMinutes))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AcceptanceStatus == input.AcceptanceStatus ||
                    (this.AcceptanceStatus != null &&
                    this.AcceptanceStatus.Equals(input.AcceptanceStatus))
                ) && 
                (
                    this.InternalComments == input.InternalComments ||
                    (this.InternalComments != null &&
                    this.InternalComments.Equals(input.InternalComments))
                ) && 
                (
                    this.LogComment == input.LogComment ||
                    (this.LogComment != null &&
                    this.LogComment.Equals(input.LogComment))
                ) && 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && 
                (
                    this.Chargable == input.Chargable ||
                    (this.Chargable != null &&
                    this.Chargable.Equals(input.Chargable))
                ) && 
                (
                    this.BillingOption == input.BillingOption ||
                    (this.BillingOption != null &&
                    this.BillingOption.Equals(input.BillingOption))
                ) && 
                (
                    this.UnitFactor == input.UnitFactor ||
                    (this.UnitFactor != null &&
                    this.UnitFactor.Equals(input.UnitFactor))
                ) && 
                (
                    this.TotalUnits == input.TotalUnits ||
                    (this.TotalUnits != null &&
                    this.TotalUnits.Equals(input.TotalUnits))
                ) && 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
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
                if (this.EntryType != null)
                    hashCode = hashCode * 59 + this.EntryType.GetHashCode();
                if (this.TimeEntryKeyNumber != null)
                    hashCode = hashCode * 59 + this.TimeEntryKeyNumber.GetHashCode();
                if (this.ServiceOrderNumber != null)
                    hashCode = hashCode * 59 + this.ServiceOrderNumber.GetHashCode();
                if (this.SOBriefDescription != null)
                    hashCode = hashCode * 59 + this.SOBriefDescription.GetHashCode();
                if (this.SOWorkPerformed != null)
                    hashCode = hashCode * 59 + this.SOWorkPerformed.GetHashCode();
                if (this.LogReason != null)
                    hashCode = hashCode * 59 + this.LogReason.GetHashCode();
                if (this.TechAssigned != null)
                    hashCode = hashCode * 59 + this.TechAssigned.GetHashCode();
                if (this.TechAssignedName != null)
                    hashCode = hashCode * 59 + this.TechAssignedName.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
                if (this.LogHours != null)
                    hashCode = hashCode * 59 + this.LogHours.GetHashCode();
                if (this.LogMinutes != null)
                    hashCode = hashCode * 59 + this.LogMinutes.GetHashCode();
                if (this.ElapsedHours != null)
                    hashCode = hashCode * 59 + this.ElapsedHours.GetHashCode();
                if (this.ElapsedMinutes != null)
                    hashCode = hashCode * 59 + this.ElapsedMinutes.GetHashCode();
                if (this.UtilizationHours != null)
                    hashCode = hashCode * 59 + this.UtilizationHours.GetHashCode();
                if (this.UtilizationMinutes != null)
                    hashCode = hashCode * 59 + this.UtilizationMinutes.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AcceptanceStatus != null)
                    hashCode = hashCode * 59 + this.AcceptanceStatus.GetHashCode();
                if (this.InternalComments != null)
                    hashCode = hashCode * 59 + this.InternalComments.GetHashCode();
                if (this.LogComment != null)
                    hashCode = hashCode * 59 + this.LogComment.GetHashCode();
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.Chargable != null)
                    hashCode = hashCode * 59 + this.Chargable.GetHashCode();
                if (this.BillingOption != null)
                    hashCode = hashCode * 59 + this.BillingOption.GetHashCode();
                if (this.UnitFactor != null)
                    hashCode = hashCode * 59 + this.UnitFactor.GetHashCode();
                if (this.TotalUnits != null)
                    hashCode = hashCode * 59 + this.TotalUnits.GetHashCode();
                if (this.ContractNumber != null)
                    hashCode = hashCode * 59 + this.ContractNumber.GetHashCode();
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