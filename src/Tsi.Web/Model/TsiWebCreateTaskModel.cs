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
    /// TsiWebCreateTaskModel
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateTaskModel :  IEquatable<TsiWebCreateTaskModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateTaskModel" /> class.
        /// </summary>
        /// <param name="scheduleConflictedTask">scheduleConflictedTask.</param>
        /// <param name="scheduleThroughEndDate">scheduleThroughEndDate.</param>
        /// <param name="numberOfTasksToSchedule">numberOfTasksToSchedule.</param>
        /// <param name="taskAttendees">taskAttendees.</param>
        /// <param name="comment">comment.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="scheduledForRepNumber">scheduledForRepNumber.</param>
        /// <param name="scheduledByRepNumber">scheduledByRepNumber.</param>
        /// <param name="serviceOrderNumber">serviceOrderNumber.</param>
        /// <param name="quoteNumber">quoteNumber.</param>
        /// <param name="opportunityNumber">opportunityNumber.</param>
        /// <param name="projectNumber">projectNumber.</param>
        /// <param name="projectPhaseNumber">projectPhaseNumber.</param>
        /// <param name="projectSubPhaseAssignmentNumber">projectSubPhaseAssignmentNumber.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="action">action.</param>
        /// <param name="type">type.</param>
        /// <param name="priorityNumber">priorityNumber.</param>
        /// <param name="priority">priority.</param>
        /// <param name="hasAlarm">hasAlarm.</param>
        /// <param name="alarmDateTime">alarmDateTime.</param>
        /// <param name="alarmReminderQuantity">alarmReminderQuantity.</param>
        /// <param name="alarmReminderInterval">alarmReminderInterval.</param>
        /// <param name="isCompleted">isCompleted.</param>
        /// <param name="isPrivate">isPrivate.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="isGlobalTask">isGlobalTask.</param>
        /// <param name="isAppointment">isAppointment.</param>
        /// <param name="subject">subject.</param>
        /// <param name="location">location.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="dueTime">dueTime.</param>
        public TsiWebCreateTaskModel(bool? scheduleConflictedTask = default(bool?), bool? scheduleThroughEndDate = default(bool?), int? numberOfTasksToSchedule = default(int?), List<TsiWebTaskAttendee> taskAttendees = default(List<TsiWebTaskAttendee>), string comment = default(string), int? accountNumber = default(int?), int? contactNumber = default(int?), int? scheduledForRepNumber = default(int?), int? scheduledByRepNumber = default(int?), int? serviceOrderNumber = default(int?), int? quoteNumber = default(int?), int? opportunityNumber = default(int?), int? projectNumber = default(int?), int? projectPhaseNumber = default(int?), int? projectSubPhaseAssignmentNumber = default(int?), DateTime? startDate = default(DateTime?), DateTime? startTime = default(DateTime?), DateTime? endDate = default(DateTime?), DateTime? endTime = default(DateTime?), string action = default(string), string type = default(string), int? priorityNumber = default(int?), string priority = default(string), bool? hasAlarm = default(bool?), DateTime? alarmDateTime = default(DateTime?), int? alarmReminderQuantity = default(int?), string alarmReminderInterval = default(string), bool? isCompleted = default(bool?), bool? isPrivate = default(bool?), DateTime? lastModified = default(DateTime?), string resourceName = default(string), bool? isGlobalTask = default(bool?), bool? isAppointment = default(bool?), string subject = default(string), string location = default(string), DateTime? dueDate = default(DateTime?), DateTime? dueTime = default(DateTime?))
        {
            this.ScheduleConflictedTask = scheduleConflictedTask;
            this.ScheduleThroughEndDate = scheduleThroughEndDate;
            this.NumberOfTasksToSchedule = numberOfTasksToSchedule;
            this.TaskAttendees = taskAttendees;
            this.Comment = comment;
            this.AccountNumber = accountNumber;
            this.ContactNumber = contactNumber;
            this.ScheduledForRepNumber = scheduledForRepNumber;
            this.ScheduledByRepNumber = scheduledByRepNumber;
            this.ServiceOrderNumber = serviceOrderNumber;
            this.QuoteNumber = quoteNumber;
            this.OpportunityNumber = opportunityNumber;
            this.ProjectNumber = projectNumber;
            this.ProjectPhaseNumber = projectPhaseNumber;
            this.ProjectSubPhaseAssignmentNumber = projectSubPhaseAssignmentNumber;
            this.StartDate = startDate;
            this.StartTime = startTime;
            this.EndDate = endDate;
            this.EndTime = endTime;
            this.Action = action;
            this.Type = type;
            this.PriorityNumber = priorityNumber;
            this.Priority = priority;
            this.HasAlarm = hasAlarm;
            this.AlarmDateTime = alarmDateTime;
            this.AlarmReminderQuantity = alarmReminderQuantity;
            this.AlarmReminderInterval = alarmReminderInterval;
            this.IsCompleted = isCompleted;
            this.IsPrivate = isPrivate;
            this.LastModified = lastModified;
            this.ResourceName = resourceName;
            this.IsGlobalTask = isGlobalTask;
            this.IsAppointment = isAppointment;
            this.Subject = subject;
            this.Location = location;
            this.DueDate = dueDate;
            this.DueTime = dueTime;
        }
        
        /// <summary>
        /// Gets or Sets ScheduleConflictedTask
        /// </summary>
        [DataMember(Name="ScheduleConflictedTask", EmitDefaultValue=false)]
        public bool? ScheduleConflictedTask { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleThroughEndDate
        /// </summary>
        [DataMember(Name="ScheduleThroughEndDate", EmitDefaultValue=false)]
        public bool? ScheduleThroughEndDate { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfTasksToSchedule
        /// </summary>
        [DataMember(Name="NumberOfTasksToSchedule", EmitDefaultValue=false)]
        public int? NumberOfTasksToSchedule { get; set; }

        /// <summary>
        /// Gets or Sets TaskAttendees
        /// </summary>
        [DataMember(Name="TaskAttendees", EmitDefaultValue=false)]
        public List<TsiWebTaskAttendee> TaskAttendees { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

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
        /// Gets or Sets ScheduledForRepNumber
        /// </summary>
        [DataMember(Name="ScheduledForRepNumber", EmitDefaultValue=false)]
        public int? ScheduledForRepNumber { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledByRepNumber
        /// </summary>
        [DataMember(Name="ScheduledByRepNumber", EmitDefaultValue=false)]
        public int? ScheduledByRepNumber { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderNumber
        /// </summary>
        [DataMember(Name="ServiceOrderNumber", EmitDefaultValue=false)]
        public int? ServiceOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets QuoteNumber
        /// </summary>
        [DataMember(Name="QuoteNumber", EmitDefaultValue=false)]
        public int? QuoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityNumber
        /// </summary>
        [DataMember(Name="OpportunityNumber", EmitDefaultValue=false)]
        public int? OpportunityNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectNumber
        /// </summary>
        [DataMember(Name="ProjectNumber", EmitDefaultValue=false)]
        public int? ProjectNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectPhaseNumber
        /// </summary>
        [DataMember(Name="ProjectPhaseNumber", EmitDefaultValue=false)]
        public int? ProjectPhaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectSubPhaseAssignmentNumber
        /// </summary>
        [DataMember(Name="ProjectSubPhaseAssignmentNumber", EmitDefaultValue=false)]
        public int? ProjectSubPhaseAssignmentNumber { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PriorityNumber
        /// </summary>
        [DataMember(Name="PriorityNumber", EmitDefaultValue=false)]
        public int? PriorityNumber { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="Priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets HasAlarm
        /// </summary>
        [DataMember(Name="HasAlarm", EmitDefaultValue=false)]
        public bool? HasAlarm { get; set; }

        /// <summary>
        /// Gets or Sets AlarmDateTime
        /// </summary>
        [DataMember(Name="AlarmDateTime", EmitDefaultValue=false)]
        public DateTime? AlarmDateTime { get; set; }

        /// <summary>
        /// Gets or Sets AlarmReminderQuantity
        /// </summary>
        [DataMember(Name="AlarmReminderQuantity", EmitDefaultValue=false)]
        public int? AlarmReminderQuantity { get; set; }

        /// <summary>
        /// Gets or Sets AlarmReminderInterval
        /// </summary>
        [DataMember(Name="AlarmReminderInterval", EmitDefaultValue=false)]
        public string AlarmReminderInterval { get; set; }

        /// <summary>
        /// Gets or Sets IsCompleted
        /// </summary>
        [DataMember(Name="IsCompleted", EmitDefaultValue=false)]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name="IsPrivate", EmitDefaultValue=false)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="LastModified", EmitDefaultValue=false)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or Sets ResourceName
        /// </summary>
        [DataMember(Name="ResourceName", EmitDefaultValue=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or Sets IsGlobalTask
        /// </summary>
        [DataMember(Name="IsGlobalTask", EmitDefaultValue=false)]
        public bool? IsGlobalTask { get; set; }

        /// <summary>
        /// Gets or Sets IsAppointment
        /// </summary>
        [DataMember(Name="IsAppointment", EmitDefaultValue=false)]
        public bool? IsAppointment { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="DueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets DueTime
        /// </summary>
        [DataMember(Name="DueTime", EmitDefaultValue=false)]
        public DateTime? DueTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateTaskModel {\n");
            sb.Append("  ScheduleConflictedTask: ").Append(ScheduleConflictedTask).Append("\n");
            sb.Append("  ScheduleThroughEndDate: ").Append(ScheduleThroughEndDate).Append("\n");
            sb.Append("  NumberOfTasksToSchedule: ").Append(NumberOfTasksToSchedule).Append("\n");
            sb.Append("  TaskAttendees: ").Append(TaskAttendees).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  ScheduledForRepNumber: ").Append(ScheduledForRepNumber).Append("\n");
            sb.Append("  ScheduledByRepNumber: ").Append(ScheduledByRepNumber).Append("\n");
            sb.Append("  ServiceOrderNumber: ").Append(ServiceOrderNumber).Append("\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
            sb.Append("  OpportunityNumber: ").Append(OpportunityNumber).Append("\n");
            sb.Append("  ProjectNumber: ").Append(ProjectNumber).Append("\n");
            sb.Append("  ProjectPhaseNumber: ").Append(ProjectPhaseNumber).Append("\n");
            sb.Append("  ProjectSubPhaseAssignmentNumber: ").Append(ProjectSubPhaseAssignmentNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PriorityNumber: ").Append(PriorityNumber).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  HasAlarm: ").Append(HasAlarm).Append("\n");
            sb.Append("  AlarmDateTime: ").Append(AlarmDateTime).Append("\n");
            sb.Append("  AlarmReminderQuantity: ").Append(AlarmReminderQuantity).Append("\n");
            sb.Append("  AlarmReminderInterval: ").Append(AlarmReminderInterval).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  IsGlobalTask: ").Append(IsGlobalTask).Append("\n");
            sb.Append("  IsAppointment: ").Append(IsAppointment).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DueTime: ").Append(DueTime).Append("\n");
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
            return this.Equals(input as TsiWebCreateTaskModel);
        }

        /// <summary>
        /// Returns true if TsiWebCreateTaskModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateTaskModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateTaskModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduleConflictedTask == input.ScheduleConflictedTask ||
                    (this.ScheduleConflictedTask != null &&
                    this.ScheduleConflictedTask.Equals(input.ScheduleConflictedTask))
                ) && 
                (
                    this.ScheduleThroughEndDate == input.ScheduleThroughEndDate ||
                    (this.ScheduleThroughEndDate != null &&
                    this.ScheduleThroughEndDate.Equals(input.ScheduleThroughEndDate))
                ) && 
                (
                    this.NumberOfTasksToSchedule == input.NumberOfTasksToSchedule ||
                    (this.NumberOfTasksToSchedule != null &&
                    this.NumberOfTasksToSchedule.Equals(input.NumberOfTasksToSchedule))
                ) && 
                (
                    this.TaskAttendees == input.TaskAttendees ||
                    this.TaskAttendees != null &&
                    this.TaskAttendees.SequenceEqual(input.TaskAttendees)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                    this.ScheduledForRepNumber == input.ScheduledForRepNumber ||
                    (this.ScheduledForRepNumber != null &&
                    this.ScheduledForRepNumber.Equals(input.ScheduledForRepNumber))
                ) && 
                (
                    this.ScheduledByRepNumber == input.ScheduledByRepNumber ||
                    (this.ScheduledByRepNumber != null &&
                    this.ScheduledByRepNumber.Equals(input.ScheduledByRepNumber))
                ) && 
                (
                    this.ServiceOrderNumber == input.ServiceOrderNumber ||
                    (this.ServiceOrderNumber != null &&
                    this.ServiceOrderNumber.Equals(input.ServiceOrderNumber))
                ) && 
                (
                    this.QuoteNumber == input.QuoteNumber ||
                    (this.QuoteNumber != null &&
                    this.QuoteNumber.Equals(input.QuoteNumber))
                ) && 
                (
                    this.OpportunityNumber == input.OpportunityNumber ||
                    (this.OpportunityNumber != null &&
                    this.OpportunityNumber.Equals(input.OpportunityNumber))
                ) && 
                (
                    this.ProjectNumber == input.ProjectNumber ||
                    (this.ProjectNumber != null &&
                    this.ProjectNumber.Equals(input.ProjectNumber))
                ) && 
                (
                    this.ProjectPhaseNumber == input.ProjectPhaseNumber ||
                    (this.ProjectPhaseNumber != null &&
                    this.ProjectPhaseNumber.Equals(input.ProjectPhaseNumber))
                ) && 
                (
                    this.ProjectSubPhaseAssignmentNumber == input.ProjectSubPhaseAssignmentNumber ||
                    (this.ProjectSubPhaseAssignmentNumber != null &&
                    this.ProjectSubPhaseAssignmentNumber.Equals(input.ProjectSubPhaseAssignmentNumber))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PriorityNumber == input.PriorityNumber ||
                    (this.PriorityNumber != null &&
                    this.PriorityNumber.Equals(input.PriorityNumber))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.HasAlarm == input.HasAlarm ||
                    (this.HasAlarm != null &&
                    this.HasAlarm.Equals(input.HasAlarm))
                ) && 
                (
                    this.AlarmDateTime == input.AlarmDateTime ||
                    (this.AlarmDateTime != null &&
                    this.AlarmDateTime.Equals(input.AlarmDateTime))
                ) && 
                (
                    this.AlarmReminderQuantity == input.AlarmReminderQuantity ||
                    (this.AlarmReminderQuantity != null &&
                    this.AlarmReminderQuantity.Equals(input.AlarmReminderQuantity))
                ) && 
                (
                    this.AlarmReminderInterval == input.AlarmReminderInterval ||
                    (this.AlarmReminderInterval != null &&
                    this.AlarmReminderInterval.Equals(input.AlarmReminderInterval))
                ) && 
                (
                    this.IsCompleted == input.IsCompleted ||
                    (this.IsCompleted != null &&
                    this.IsCompleted.Equals(input.IsCompleted))
                ) && 
                (
                    this.IsPrivate == input.IsPrivate ||
                    (this.IsPrivate != null &&
                    this.IsPrivate.Equals(input.IsPrivate))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.IsGlobalTask == input.IsGlobalTask ||
                    (this.IsGlobalTask != null &&
                    this.IsGlobalTask.Equals(input.IsGlobalTask))
                ) && 
                (
                    this.IsAppointment == input.IsAppointment ||
                    (this.IsAppointment != null &&
                    this.IsAppointment.Equals(input.IsAppointment))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.DueTime == input.DueTime ||
                    (this.DueTime != null &&
                    this.DueTime.Equals(input.DueTime))
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
                if (this.ScheduleConflictedTask != null)
                    hashCode = hashCode * 59 + this.ScheduleConflictedTask.GetHashCode();
                if (this.ScheduleThroughEndDate != null)
                    hashCode = hashCode * 59 + this.ScheduleThroughEndDate.GetHashCode();
                if (this.NumberOfTasksToSchedule != null)
                    hashCode = hashCode * 59 + this.NumberOfTasksToSchedule.GetHashCode();
                if (this.TaskAttendees != null)
                    hashCode = hashCode * 59 + this.TaskAttendees.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.ScheduledForRepNumber != null)
                    hashCode = hashCode * 59 + this.ScheduledForRepNumber.GetHashCode();
                if (this.ScheduledByRepNumber != null)
                    hashCode = hashCode * 59 + this.ScheduledByRepNumber.GetHashCode();
                if (this.ServiceOrderNumber != null)
                    hashCode = hashCode * 59 + this.ServiceOrderNumber.GetHashCode();
                if (this.QuoteNumber != null)
                    hashCode = hashCode * 59 + this.QuoteNumber.GetHashCode();
                if (this.OpportunityNumber != null)
                    hashCode = hashCode * 59 + this.OpportunityNumber.GetHashCode();
                if (this.ProjectNumber != null)
                    hashCode = hashCode * 59 + this.ProjectNumber.GetHashCode();
                if (this.ProjectPhaseNumber != null)
                    hashCode = hashCode * 59 + this.ProjectPhaseNumber.GetHashCode();
                if (this.ProjectSubPhaseAssignmentNumber != null)
                    hashCode = hashCode * 59 + this.ProjectSubPhaseAssignmentNumber.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PriorityNumber != null)
                    hashCode = hashCode * 59 + this.PriorityNumber.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.HasAlarm != null)
                    hashCode = hashCode * 59 + this.HasAlarm.GetHashCode();
                if (this.AlarmDateTime != null)
                    hashCode = hashCode * 59 + this.AlarmDateTime.GetHashCode();
                if (this.AlarmReminderQuantity != null)
                    hashCode = hashCode * 59 + this.AlarmReminderQuantity.GetHashCode();
                if (this.AlarmReminderInterval != null)
                    hashCode = hashCode * 59 + this.AlarmReminderInterval.GetHashCode();
                if (this.IsCompleted != null)
                    hashCode = hashCode * 59 + this.IsCompleted.GetHashCode();
                if (this.IsPrivate != null)
                    hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.IsGlobalTask != null)
                    hashCode = hashCode * 59 + this.IsGlobalTask.GetHashCode();
                if (this.IsAppointment != null)
                    hashCode = hashCode * 59 + this.IsAppointment.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.DueTime != null)
                    hashCode = hashCode * 59 + this.DueTime.GetHashCode();
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
