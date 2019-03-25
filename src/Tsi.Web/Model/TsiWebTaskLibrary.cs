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
    /// TsiWebTaskLibrary
    /// </summary>
    [DataContract]
    public partial class TsiWebTaskLibrary :  IEquatable<TsiWebTaskLibrary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebTaskLibrary" /> class.
        /// </summary>
        /// <param name="taskLibraryKeyNumber">taskLibraryKeyNumber.</param>
        /// <param name="subject">subject.</param>
        /// <param name="location">location.</param>
        /// <param name="taskType">taskType.</param>
        /// <param name="taskAction">taskAction.</param>
        /// <param name="priorityNumber">priorityNumber.</param>
        /// <param name="priorityText">priorityText.</param>
        /// <param name="taskComment">taskComment.</param>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationInterval">durationInterval.</param>
        public TsiWebTaskLibrary(int? taskLibraryKeyNumber = default(int?), string subject = default(string), string location = default(string), string taskType = default(string), string taskAction = default(string), int? priorityNumber = default(int?), string priorityText = default(string), string taskComment = default(string), string resourceName = default(string), int? duration = default(int?), string durationInterval = default(string))
        {
            this.TaskLibraryKeyNumber = taskLibraryKeyNumber;
            this.Subject = subject;
            this.Location = location;
            this.TaskType = taskType;
            this.TaskAction = taskAction;
            this.PriorityNumber = priorityNumber;
            this.PriorityText = priorityText;
            this.TaskComment = taskComment;
            this.ResourceName = resourceName;
            this.Duration = duration;
            this.DurationInterval = durationInterval;
        }
        
        /// <summary>
        /// Gets or Sets TaskLibraryKeyNumber
        /// </summary>
        [DataMember(Name="TaskLibraryKeyNumber", EmitDefaultValue=false)]
        public int? TaskLibraryKeyNumber { get; set; }

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
        /// Gets or Sets PriorityNumber
        /// </summary>
        [DataMember(Name="PriorityNumber", EmitDefaultValue=false)]
        public int? PriorityNumber { get; set; }

        /// <summary>
        /// Gets or Sets PriorityText
        /// </summary>
        [DataMember(Name="PriorityText", EmitDefaultValue=false)]
        public string PriorityText { get; set; }

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
        /// Gets or Sets DurationInterval
        /// </summary>
        [DataMember(Name="DurationInterval", EmitDefaultValue=false)]
        public string DurationInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebTaskLibrary {\n");
            sb.Append("  TaskLibraryKeyNumber: ").Append(TaskLibraryKeyNumber).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  TaskAction: ").Append(TaskAction).Append("\n");
            sb.Append("  PriorityNumber: ").Append(PriorityNumber).Append("\n");
            sb.Append("  PriorityText: ").Append(PriorityText).Append("\n");
            sb.Append("  TaskComment: ").Append(TaskComment).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationInterval: ").Append(DurationInterval).Append("\n");
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
            return this.Equals(input as TsiWebTaskLibrary);
        }

        /// <summary>
        /// Returns true if TsiWebTaskLibrary instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebTaskLibrary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebTaskLibrary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskLibraryKeyNumber == input.TaskLibraryKeyNumber ||
                    (this.TaskLibraryKeyNumber != null &&
                    this.TaskLibraryKeyNumber.Equals(input.TaskLibraryKeyNumber))
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
                    this.PriorityNumber == input.PriorityNumber ||
                    (this.PriorityNumber != null &&
                    this.PriorityNumber.Equals(input.PriorityNumber))
                ) && 
                (
                    this.PriorityText == input.PriorityText ||
                    (this.PriorityText != null &&
                    this.PriorityText.Equals(input.PriorityText))
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
                    this.DurationInterval == input.DurationInterval ||
                    (this.DurationInterval != null &&
                    this.DurationInterval.Equals(input.DurationInterval))
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
                if (this.TaskLibraryKeyNumber != null)
                    hashCode = hashCode * 59 + this.TaskLibraryKeyNumber.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TaskAction != null)
                    hashCode = hashCode * 59 + this.TaskAction.GetHashCode();
                if (this.PriorityNumber != null)
                    hashCode = hashCode * 59 + this.PriorityNumber.GetHashCode();
                if (this.PriorityText != null)
                    hashCode = hashCode * 59 + this.PriorityText.GetHashCode();
                if (this.TaskComment != null)
                    hashCode = hashCode * 59 + this.TaskComment.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationInterval != null)
                    hashCode = hashCode * 59 + this.DurationInterval.GetHashCode();
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
