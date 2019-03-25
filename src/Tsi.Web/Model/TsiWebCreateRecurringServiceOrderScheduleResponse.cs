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
    /// TsiWebCreateRecurringServiceOrderScheduleResponse
    /// </summary>
    [DataContract]
    public partial class TsiWebCreateRecurringServiceOrderScheduleResponse :  IEquatable<TsiWebCreateRecurringServiceOrderScheduleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebCreateRecurringServiceOrderScheduleResponse" /> class.
        /// </summary>
        /// <param name="numberOfRecurringOrderSchedulesCreated">numberOfRecurringOrderSchedulesCreated.</param>
        /// <param name="recurringScheduleName">recurringScheduleName.</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="templateName">templateName.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="takenByRepNumber">takenByRepNumber.</param>
        /// <param name="createAheadDays">createAheadDays.</param>
        /// <param name="serviceOrderReceivedTime">serviceOrderReceivedTime.</param>
        /// <param name="endByDate">endByDate.</param>
        /// <param name="numberOfOccurences">numberOfOccurences.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="dailyInterval">dailyInterval.</param>
        /// <param name="scheduleEveryWeekday">scheduleEveryWeekday.</param>
        /// <param name="weeklyInterval">weeklyInterval.</param>
        /// <param name="weeklyOnSunday">weeklyOnSunday.</param>
        /// <param name="weeklyOnMonday">weeklyOnMonday.</param>
        /// <param name="weeklyOnTuesday">weeklyOnTuesday.</param>
        /// <param name="weeklyOnWednesday">weeklyOnWednesday.</param>
        /// <param name="weeklyOnThursday">weeklyOnThursday.</param>
        /// <param name="weeklyOnFriday">weeklyOnFriday.</param>
        /// <param name="weeklyOnSaturday">weeklyOnSaturday.</param>
        /// <param name="monthlyInterval">monthlyInterval.</param>
        /// <param name="dayOfMonth">dayOfMonth.</param>
        /// <param name="weekOfMonth">weekOfMonth.</param>
        /// <param name="dayOfWeek">dayOfWeek.</param>
        /// <param name="yearlyInterval">yearlyInterval.</param>
        /// <param name="monthOfYear">monthOfYear.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        public TsiWebCreateRecurringServiceOrderScheduleResponse(int? numberOfRecurringOrderSchedulesCreated = default(int?), string recurringScheduleName = default(string), int? templateId = default(int?), string templateName = default(string), DateTime? startDate = default(DateTime?), int? takenByRepNumber = default(int?), int? createAheadDays = default(int?), DateTime? serviceOrderReceivedTime = default(DateTime?), DateTime? endByDate = default(DateTime?), int? numberOfOccurences = default(int?), string frequency = default(string), int? dailyInterval = default(int?), bool? scheduleEveryWeekday = default(bool?), int? weeklyInterval = default(int?), bool? weeklyOnSunday = default(bool?), bool? weeklyOnMonday = default(bool?), bool? weeklyOnTuesday = default(bool?), bool? weeklyOnWednesday = default(bool?), bool? weeklyOnThursday = default(bool?), bool? weeklyOnFriday = default(bool?), bool? weeklyOnSaturday = default(bool?), int? monthlyInterval = default(int?), int? dayOfMonth = default(int?), string weekOfMonth = default(string), string dayOfWeek = default(string), int? yearlyInterval = default(int?), int? monthOfYear = default(int?), bool? success = default(bool?), string message = default(string))
        {
            this.NumberOfRecurringOrderSchedulesCreated = numberOfRecurringOrderSchedulesCreated;
            this.RecurringScheduleName = recurringScheduleName;
            this.TemplateId = templateId;
            this.TemplateName = templateName;
            this.StartDate = startDate;
            this.TakenByRepNumber = takenByRepNumber;
            this.CreateAheadDays = createAheadDays;
            this.ServiceOrderReceivedTime = serviceOrderReceivedTime;
            this.EndByDate = endByDate;
            this.NumberOfOccurences = numberOfOccurences;
            this.Frequency = frequency;
            this.DailyInterval = dailyInterval;
            this.ScheduleEveryWeekday = scheduleEveryWeekday;
            this.WeeklyInterval = weeklyInterval;
            this.WeeklyOnSunday = weeklyOnSunday;
            this.WeeklyOnMonday = weeklyOnMonday;
            this.WeeklyOnTuesday = weeklyOnTuesday;
            this.WeeklyOnWednesday = weeklyOnWednesday;
            this.WeeklyOnThursday = weeklyOnThursday;
            this.WeeklyOnFriday = weeklyOnFriday;
            this.WeeklyOnSaturday = weeklyOnSaturday;
            this.MonthlyInterval = monthlyInterval;
            this.DayOfMonth = dayOfMonth;
            this.WeekOfMonth = weekOfMonth;
            this.DayOfWeek = dayOfWeek;
            this.YearlyInterval = yearlyInterval;
            this.MonthOfYear = monthOfYear;
            this.Success = success;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets NumberOfRecurringOrderSchedulesCreated
        /// </summary>
        [DataMember(Name="NumberOfRecurringOrderSchedulesCreated", EmitDefaultValue=false)]
        public int? NumberOfRecurringOrderSchedulesCreated { get; set; }

        /// <summary>
        /// Gets or Sets RecurringScheduleName
        /// </summary>
        [DataMember(Name="RecurringScheduleName", EmitDefaultValue=false)]
        public string RecurringScheduleName { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="TemplateId", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateName
        /// </summary>
        [DataMember(Name="TemplateName", EmitDefaultValue=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TakenByRepNumber
        /// </summary>
        [DataMember(Name="TakenByRepNumber", EmitDefaultValue=false)]
        public int? TakenByRepNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreateAheadDays
        /// </summary>
        [DataMember(Name="CreateAheadDays", EmitDefaultValue=false)]
        public int? CreateAheadDays { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderReceivedTime
        /// </summary>
        [DataMember(Name="ServiceOrderReceivedTime", EmitDefaultValue=false)]
        public DateTime? ServiceOrderReceivedTime { get; set; }

        /// <summary>
        /// Gets or Sets EndByDate
        /// </summary>
        [DataMember(Name="EndByDate", EmitDefaultValue=false)]
        public DateTime? EndByDate { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfOccurences
        /// </summary>
        [DataMember(Name="NumberOfOccurences", EmitDefaultValue=false)]
        public int? NumberOfOccurences { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="Frequency", EmitDefaultValue=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or Sets DailyInterval
        /// </summary>
        [DataMember(Name="DailyInterval", EmitDefaultValue=false)]
        public int? DailyInterval { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleEveryWeekday
        /// </summary>
        [DataMember(Name="ScheduleEveryWeekday", EmitDefaultValue=false)]
        public bool? ScheduleEveryWeekday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyInterval
        /// </summary>
        [DataMember(Name="WeeklyInterval", EmitDefaultValue=false)]
        public int? WeeklyInterval { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnSunday
        /// </summary>
        [DataMember(Name="WeeklyOnSunday", EmitDefaultValue=false)]
        public bool? WeeklyOnSunday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnMonday
        /// </summary>
        [DataMember(Name="WeeklyOnMonday", EmitDefaultValue=false)]
        public bool? WeeklyOnMonday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnTuesday
        /// </summary>
        [DataMember(Name="WeeklyOnTuesday", EmitDefaultValue=false)]
        public bool? WeeklyOnTuesday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnWednesday
        /// </summary>
        [DataMember(Name="WeeklyOnWednesday", EmitDefaultValue=false)]
        public bool? WeeklyOnWednesday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnThursday
        /// </summary>
        [DataMember(Name="WeeklyOnThursday", EmitDefaultValue=false)]
        public bool? WeeklyOnThursday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnFriday
        /// </summary>
        [DataMember(Name="WeeklyOnFriday", EmitDefaultValue=false)]
        public bool? WeeklyOnFriday { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyOnSaturday
        /// </summary>
        [DataMember(Name="WeeklyOnSaturday", EmitDefaultValue=false)]
        public bool? WeeklyOnSaturday { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInterval
        /// </summary>
        [DataMember(Name="MonthlyInterval", EmitDefaultValue=false)]
        public int? MonthlyInterval { get; set; }

        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name="DayOfMonth", EmitDefaultValue=false)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets WeekOfMonth
        /// </summary>
        [DataMember(Name="WeekOfMonth", EmitDefaultValue=false)]
        public string WeekOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Gets or Sets YearlyInterval
        /// </summary>
        [DataMember(Name="YearlyInterval", EmitDefaultValue=false)]
        public int? YearlyInterval { get; set; }

        /// <summary>
        /// Gets or Sets MonthOfYear
        /// </summary>
        [DataMember(Name="MonthOfYear", EmitDefaultValue=false)]
        public int? MonthOfYear { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebCreateRecurringServiceOrderScheduleResponse {\n");
            sb.Append("  NumberOfRecurringOrderSchedulesCreated: ").Append(NumberOfRecurringOrderSchedulesCreated).Append("\n");
            sb.Append("  RecurringScheduleName: ").Append(RecurringScheduleName).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TakenByRepNumber: ").Append(TakenByRepNumber).Append("\n");
            sb.Append("  CreateAheadDays: ").Append(CreateAheadDays).Append("\n");
            sb.Append("  ServiceOrderReceivedTime: ").Append(ServiceOrderReceivedTime).Append("\n");
            sb.Append("  EndByDate: ").Append(EndByDate).Append("\n");
            sb.Append("  NumberOfOccurences: ").Append(NumberOfOccurences).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  DailyInterval: ").Append(DailyInterval).Append("\n");
            sb.Append("  ScheduleEveryWeekday: ").Append(ScheduleEveryWeekday).Append("\n");
            sb.Append("  WeeklyInterval: ").Append(WeeklyInterval).Append("\n");
            sb.Append("  WeeklyOnSunday: ").Append(WeeklyOnSunday).Append("\n");
            sb.Append("  WeeklyOnMonday: ").Append(WeeklyOnMonday).Append("\n");
            sb.Append("  WeeklyOnTuesday: ").Append(WeeklyOnTuesday).Append("\n");
            sb.Append("  WeeklyOnWednesday: ").Append(WeeklyOnWednesday).Append("\n");
            sb.Append("  WeeklyOnThursday: ").Append(WeeklyOnThursday).Append("\n");
            sb.Append("  WeeklyOnFriday: ").Append(WeeklyOnFriday).Append("\n");
            sb.Append("  WeeklyOnSaturday: ").Append(WeeklyOnSaturday).Append("\n");
            sb.Append("  MonthlyInterval: ").Append(MonthlyInterval).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  WeekOfMonth: ").Append(WeekOfMonth).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  YearlyInterval: ").Append(YearlyInterval).Append("\n");
            sb.Append("  MonthOfYear: ").Append(MonthOfYear).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as TsiWebCreateRecurringServiceOrderScheduleResponse);
        }

        /// <summary>
        /// Returns true if TsiWebCreateRecurringServiceOrderScheduleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebCreateRecurringServiceOrderScheduleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebCreateRecurringServiceOrderScheduleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfRecurringOrderSchedulesCreated == input.NumberOfRecurringOrderSchedulesCreated ||
                    (this.NumberOfRecurringOrderSchedulesCreated != null &&
                    this.NumberOfRecurringOrderSchedulesCreated.Equals(input.NumberOfRecurringOrderSchedulesCreated))
                ) && 
                (
                    this.RecurringScheduleName == input.RecurringScheduleName ||
                    (this.RecurringScheduleName != null &&
                    this.RecurringScheduleName.Equals(input.RecurringScheduleName))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TakenByRepNumber == input.TakenByRepNumber ||
                    (this.TakenByRepNumber != null &&
                    this.TakenByRepNumber.Equals(input.TakenByRepNumber))
                ) && 
                (
                    this.CreateAheadDays == input.CreateAheadDays ||
                    (this.CreateAheadDays != null &&
                    this.CreateAheadDays.Equals(input.CreateAheadDays))
                ) && 
                (
                    this.ServiceOrderReceivedTime == input.ServiceOrderReceivedTime ||
                    (this.ServiceOrderReceivedTime != null &&
                    this.ServiceOrderReceivedTime.Equals(input.ServiceOrderReceivedTime))
                ) && 
                (
                    this.EndByDate == input.EndByDate ||
                    (this.EndByDate != null &&
                    this.EndByDate.Equals(input.EndByDate))
                ) && 
                (
                    this.NumberOfOccurences == input.NumberOfOccurences ||
                    (this.NumberOfOccurences != null &&
                    this.NumberOfOccurences.Equals(input.NumberOfOccurences))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.DailyInterval == input.DailyInterval ||
                    (this.DailyInterval != null &&
                    this.DailyInterval.Equals(input.DailyInterval))
                ) && 
                (
                    this.ScheduleEveryWeekday == input.ScheduleEveryWeekday ||
                    (this.ScheduleEveryWeekday != null &&
                    this.ScheduleEveryWeekday.Equals(input.ScheduleEveryWeekday))
                ) && 
                (
                    this.WeeklyInterval == input.WeeklyInterval ||
                    (this.WeeklyInterval != null &&
                    this.WeeklyInterval.Equals(input.WeeklyInterval))
                ) && 
                (
                    this.WeeklyOnSunday == input.WeeklyOnSunday ||
                    (this.WeeklyOnSunday != null &&
                    this.WeeklyOnSunday.Equals(input.WeeklyOnSunday))
                ) && 
                (
                    this.WeeklyOnMonday == input.WeeklyOnMonday ||
                    (this.WeeklyOnMonday != null &&
                    this.WeeklyOnMonday.Equals(input.WeeklyOnMonday))
                ) && 
                (
                    this.WeeklyOnTuesday == input.WeeklyOnTuesday ||
                    (this.WeeklyOnTuesday != null &&
                    this.WeeklyOnTuesday.Equals(input.WeeklyOnTuesday))
                ) && 
                (
                    this.WeeklyOnWednesday == input.WeeklyOnWednesday ||
                    (this.WeeklyOnWednesday != null &&
                    this.WeeklyOnWednesday.Equals(input.WeeklyOnWednesday))
                ) && 
                (
                    this.WeeklyOnThursday == input.WeeklyOnThursday ||
                    (this.WeeklyOnThursday != null &&
                    this.WeeklyOnThursday.Equals(input.WeeklyOnThursday))
                ) && 
                (
                    this.WeeklyOnFriday == input.WeeklyOnFriday ||
                    (this.WeeklyOnFriday != null &&
                    this.WeeklyOnFriday.Equals(input.WeeklyOnFriday))
                ) && 
                (
                    this.WeeklyOnSaturday == input.WeeklyOnSaturday ||
                    (this.WeeklyOnSaturday != null &&
                    this.WeeklyOnSaturday.Equals(input.WeeklyOnSaturday))
                ) && 
                (
                    this.MonthlyInterval == input.MonthlyInterval ||
                    (this.MonthlyInterval != null &&
                    this.MonthlyInterval.Equals(input.MonthlyInterval))
                ) && 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    (this.DayOfMonth != null &&
                    this.DayOfMonth.Equals(input.DayOfMonth))
                ) && 
                (
                    this.WeekOfMonth == input.WeekOfMonth ||
                    (this.WeekOfMonth != null &&
                    this.WeekOfMonth.Equals(input.WeekOfMonth))
                ) && 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) && 
                (
                    this.YearlyInterval == input.YearlyInterval ||
                    (this.YearlyInterval != null &&
                    this.YearlyInterval.Equals(input.YearlyInterval))
                ) && 
                (
                    this.MonthOfYear == input.MonthOfYear ||
                    (this.MonthOfYear != null &&
                    this.MonthOfYear.Equals(input.MonthOfYear))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.NumberOfRecurringOrderSchedulesCreated != null)
                    hashCode = hashCode * 59 + this.NumberOfRecurringOrderSchedulesCreated.GetHashCode();
                if (this.RecurringScheduleName != null)
                    hashCode = hashCode * 59 + this.RecurringScheduleName.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TakenByRepNumber != null)
                    hashCode = hashCode * 59 + this.TakenByRepNumber.GetHashCode();
                if (this.CreateAheadDays != null)
                    hashCode = hashCode * 59 + this.CreateAheadDays.GetHashCode();
                if (this.ServiceOrderReceivedTime != null)
                    hashCode = hashCode * 59 + this.ServiceOrderReceivedTime.GetHashCode();
                if (this.EndByDate != null)
                    hashCode = hashCode * 59 + this.EndByDate.GetHashCode();
                if (this.NumberOfOccurences != null)
                    hashCode = hashCode * 59 + this.NumberOfOccurences.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.DailyInterval != null)
                    hashCode = hashCode * 59 + this.DailyInterval.GetHashCode();
                if (this.ScheduleEveryWeekday != null)
                    hashCode = hashCode * 59 + this.ScheduleEveryWeekday.GetHashCode();
                if (this.WeeklyInterval != null)
                    hashCode = hashCode * 59 + this.WeeklyInterval.GetHashCode();
                if (this.WeeklyOnSunday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnSunday.GetHashCode();
                if (this.WeeklyOnMonday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnMonday.GetHashCode();
                if (this.WeeklyOnTuesday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnTuesday.GetHashCode();
                if (this.WeeklyOnWednesday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnWednesday.GetHashCode();
                if (this.WeeklyOnThursday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnThursday.GetHashCode();
                if (this.WeeklyOnFriday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnFriday.GetHashCode();
                if (this.WeeklyOnSaturday != null)
                    hashCode = hashCode * 59 + this.WeeklyOnSaturday.GetHashCode();
                if (this.MonthlyInterval != null)
                    hashCode = hashCode * 59 + this.MonthlyInterval.GetHashCode();
                if (this.DayOfMonth != null)
                    hashCode = hashCode * 59 + this.DayOfMonth.GetHashCode();
                if (this.WeekOfMonth != null)
                    hashCode = hashCode * 59 + this.WeekOfMonth.GetHashCode();
                if (this.DayOfWeek != null)
                    hashCode = hashCode * 59 + this.DayOfWeek.GetHashCode();
                if (this.YearlyInterval != null)
                    hashCode = hashCode * 59 + this.YearlyInterval.GetHashCode();
                if (this.MonthOfYear != null)
                    hashCode = hashCode * 59 + this.MonthOfYear.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
