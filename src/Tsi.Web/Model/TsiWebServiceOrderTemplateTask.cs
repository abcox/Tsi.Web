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
    /// TsiWebServiceOrderTemplateTask
    /// </summary>
    [DataContract]
    public partial class TsiWebServiceOrderTemplateTask :  IEquatable<TsiWebServiceOrderTemplateTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebServiceOrderTemplateTask" /> class.
        /// </summary>
        /// <param name="serviceOrderTemplateTaskNumber">serviceOrderTemplateTaskNumber.</param>
        /// <param name="stepNumber">stepNumber.</param>
        /// <param name="subject">subject.</param>
        /// <param name="location">location.</param>
        /// <param name="taskType">taskType.</param>
        /// <param name="taskAction">taskAction.</param>
        /// <param name="priority">priority.</param>
        /// <param name="taskComment">taskComment.</param>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationIntervalType">durationIntervalType.</param>
        /// <param name="scheduleAfterTask">scheduleAfterTask.</param>
        /// <param name="previousTaskoffset">previousTaskoffset.</param>
        /// <param name="offSetIntervalType">offSetIntervalType.</param>
        /// <param name="repType">repType.</param>
        /// <param name="repTypeDescription">repTypeDescription.</param>
        /// <param name="repNumber">repNumber.</param>
        /// <param name="repName">repName.</param>
        /// <param name="repGroup">repGroup.</param>
        /// <param name="startTime">startTime.</param>
        public TsiWebServiceOrderTemplateTask(int? serviceOrderTemplateTaskNumber = default(int?), int? stepNumber = default(int?), string subject = default(string), string location = default(string), string taskType = default(string), string taskAction = default(string), string priority = default(string), string taskComment = default(string), string resourceName = default(string), int? duration = default(int?), string durationIntervalType = default(string), string scheduleAfterTask = default(string), int? previousTaskoffset = default(int?), string offSetIntervalType = default(string), int? repType = default(int?), string repTypeDescription = default(string), int? repNumber = default(int?), string repName = default(string), string repGroup = default(string), DateTime? startTime = default(DateTime?))
        {
            this.ServiceOrderTemplateTaskNumber = serviceOrderTemplateTaskNumber;
            this.StepNumber = stepNumber;
            this.Subject = subject;
            this.Location = location;
            this.TaskType = taskType;
            this.TaskAction = taskAction;
            this.Priority = priority;
            this.TaskComment = taskComment;
            this.ResourceName = resourceName;
            this.Duration = duration;
            this.DurationIntervalType = durationIntervalType;
            this.ScheduleAfterTask = scheduleAfterTask;
            this.PreviousTaskoffset = previousTaskoffset;
            this.OffSetIntervalType = offSetIntervalType;
            this.RepType = repType;
            this.RepTypeDescription = repTypeDescription;
            this.RepNumber = repNumber;
            this.RepName = repName;
            this.RepGroup = repGroup;
            this.StartTime = startTime;
        }
        
        /// <summary>
        /// Gets or Sets ServiceOrderTemplateTaskNumber
        /// </summary>
        [DataMember(Name="ServiceOrderTemplateTaskNumber", EmitDefaultValue=false)]
        public int? ServiceOrderTemplateTaskNumber { get; set; }

        /// <summary>
        /// Gets or Sets StepNumber
        /// </summary>
        [DataMember(Name="StepNumber", EmitDefaultValue=false)]
        public int? StepNumber { get; set; }

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
        /// Gets or Sets TaskType
        /// </summary>
        [DataMember(Name="TaskType", EmitDefaultValue=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// Gets or Sets TaskAction
        /// </summary>
        [DataMember(Name="TaskAction", EmitDefaultValue=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="Priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets TaskComment
        /// </summary>
        [DataMember(Name="TaskComment", EmitDefaultValue=false)]
        public string TaskComment { get; set; }

        /// <summary>
        /// Gets or Sets ResourceName
        /// </summary>
        [DataMember(Name="ResourceName", EmitDefaultValue=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="Duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets DurationIntervalType
        /// </summary>
        [DataMember(Name="DurationIntervalType", EmitDefaultValue=false)]
        public string DurationIntervalType { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleAfterTask
        /// </summary>
        [DataMember(Name="ScheduleAfterTask", EmitDefaultValue=false)]
        public string ScheduleAfterTask { get; set; }

        /// <summary>
        /// Gets or Sets PreviousTaskoffset
        /// </summary>
        [DataMember(Name="PreviousTaskoffset", EmitDefaultValue=false)]
        public int? PreviousTaskoffset { get; set; }

        /// <summary>
        /// Gets or Sets OffSetIntervalType
        /// </summary>
        [DataMember(Name="OffSetIntervalType", EmitDefaultValue=false)]
        public string OffSetIntervalType { get; set; }

        /// <summary>
        /// Gets or Sets RepType
        /// </summary>
        [DataMember(Name="RepType", EmitDefaultValue=false)]
        public int? RepType { get; set; }

        /// <summary>
        /// Gets or Sets RepTypeDescription
        /// </summary>
        [DataMember(Name="RepTypeDescription", EmitDefaultValue=false)]
        public string RepTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets RepNumber
        /// </summary>
        [DataMember(Name="RepNumber", EmitDefaultValue=false)]
        public int? RepNumber { get; set; }

        /// <summary>
        /// Gets or Sets RepName
        /// </summary>
        [DataMember(Name="RepName", EmitDefaultValue=false)]
        public string RepName { get; set; }

        /// <summary>
        /// Gets or Sets RepGroup
        /// </summary>
        [DataMember(Name="RepGroup", EmitDefaultValue=false)]
        public string RepGroup { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebServiceOrderTemplateTask {\n");
            sb.Append("  ServiceOrderTemplateTaskNumber: ").Append(ServiceOrderTemplateTaskNumber).Append("\n");
            sb.Append("  StepNumber: ").Append(StepNumber).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  TaskAction: ").Append(TaskAction).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TaskComment: ").Append(TaskComment).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationIntervalType: ").Append(DurationIntervalType).Append("\n");
            sb.Append("  ScheduleAfterTask: ").Append(ScheduleAfterTask).Append("\n");
            sb.Append("  PreviousTaskoffset: ").Append(PreviousTaskoffset).Append("\n");
            sb.Append("  OffSetIntervalType: ").Append(OffSetIntervalType).Append("\n");
            sb.Append("  RepType: ").Append(RepType).Append("\n");
            sb.Append("  RepTypeDescription: ").Append(RepTypeDescription).Append("\n");
            sb.Append("  RepNumber: ").Append(RepNumber).Append("\n");
            sb.Append("  RepName: ").Append(RepName).Append("\n");
            sb.Append("  RepGroup: ").Append(RepGroup).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as TsiWebServiceOrderTemplateTask);
        }

        /// <summary>
        /// Returns true if TsiWebServiceOrderTemplateTask instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebServiceOrderTemplateTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebServiceOrderTemplateTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceOrderTemplateTaskNumber == input.ServiceOrderTemplateTaskNumber ||
                    (this.ServiceOrderTemplateTaskNumber != null &&
                    this.ServiceOrderTemplateTaskNumber.Equals(input.ServiceOrderTemplateTaskNumber))
                ) && 
                (
                    this.StepNumber == input.StepNumber ||
                    (this.StepNumber != null &&
                    this.StepNumber.Equals(input.StepNumber))
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
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.TaskAction == input.TaskAction ||
                    (this.TaskAction != null &&
                    this.TaskAction.Equals(input.TaskAction))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.TaskComment == input.TaskComment ||
                    (this.TaskComment != null &&
                    this.TaskComment.Equals(input.TaskComment))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.DurationIntervalType == input.DurationIntervalType ||
                    (this.DurationIntervalType != null &&
                    this.DurationIntervalType.Equals(input.DurationIntervalType))
                ) && 
                (
                    this.ScheduleAfterTask == input.ScheduleAfterTask ||
                    (this.ScheduleAfterTask != null &&
                    this.ScheduleAfterTask.Equals(input.ScheduleAfterTask))
                ) && 
                (
                    this.PreviousTaskoffset == input.PreviousTaskoffset ||
                    (this.PreviousTaskoffset != null &&
                    this.PreviousTaskoffset.Equals(input.PreviousTaskoffset))
                ) && 
                (
                    this.OffSetIntervalType == input.OffSetIntervalType ||
                    (this.OffSetIntervalType != null &&
                    this.OffSetIntervalType.Equals(input.OffSetIntervalType))
                ) && 
                (
                    this.RepType == input.RepType ||
                    (this.RepType != null &&
                    this.RepType.Equals(input.RepType))
                ) && 
                (
                    this.RepTypeDescription == input.RepTypeDescription ||
                    (this.RepTypeDescription != null &&
                    this.RepTypeDescription.Equals(input.RepTypeDescription))
                ) && 
                (
                    this.RepNumber == input.RepNumber ||
                    (this.RepNumber != null &&
                    this.RepNumber.Equals(input.RepNumber))
                ) && 
                (
                    this.RepName == input.RepName ||
                    (this.RepName != null &&
                    this.RepName.Equals(input.RepName))
                ) && 
                (
                    this.RepGroup == input.RepGroup ||
                    (this.RepGroup != null &&
                    this.RepGroup.Equals(input.RepGroup))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.ServiceOrderTemplateTaskNumber != null)
                    hashCode = hashCode * 59 + this.ServiceOrderTemplateTaskNumber.GetHashCode();
                if (this.StepNumber != null)
                    hashCode = hashCode * 59 + this.StepNumber.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TaskAction != null)
                    hashCode = hashCode * 59 + this.TaskAction.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.TaskComment != null)
                    hashCode = hashCode * 59 + this.TaskComment.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationIntervalType != null)
                    hashCode = hashCode * 59 + this.DurationIntervalType.GetHashCode();
                if (this.ScheduleAfterTask != null)
                    hashCode = hashCode * 59 + this.ScheduleAfterTask.GetHashCode();
                if (this.PreviousTaskoffset != null)
                    hashCode = hashCode * 59 + this.PreviousTaskoffset.GetHashCode();
                if (this.OffSetIntervalType != null)
                    hashCode = hashCode * 59 + this.OffSetIntervalType.GetHashCode();
                if (this.RepType != null)
                    hashCode = hashCode * 59 + this.RepType.GetHashCode();
                if (this.RepTypeDescription != null)
                    hashCode = hashCode * 59 + this.RepTypeDescription.GetHashCode();
                if (this.RepNumber != null)
                    hashCode = hashCode * 59 + this.RepNumber.GetHashCode();
                if (this.RepName != null)
                    hashCode = hashCode * 59 + this.RepName.GetHashCode();
                if (this.RepGroup != null)
                    hashCode = hashCode * 59 + this.RepGroup.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
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
