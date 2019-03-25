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
    /// TsiWebOpportunityStage
    /// </summary>
    [DataContract]
    public partial class TsiWebOpportunityStage :  IEquatable<TsiWebOpportunityStage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebOpportunityStage" /> class.
        /// </summary>
        /// <param name="opportunityStageId">opportunityStageId.</param>
        /// <param name="forwardActivityName">forwardActivityName.</param>
        /// <param name="backwardActivityName">backwardActivityName.</param>
        /// <param name="stageDescription">stageDescription.</param>
        /// <param name="description">description.</param>
        /// <param name="probabilityOfSale">probabilityOfSale.</param>
        /// <param name="daysToClose">daysToClose.</param>
        /// <param name="ageThresholdForWorkflow">ageThresholdForWorkflow.</param>
        public TsiWebOpportunityStage(int? opportunityStageId = default(int?), string forwardActivityName = default(string), string backwardActivityName = default(string), string stageDescription = default(string), string description = default(string), double? probabilityOfSale = default(double?), int? daysToClose = default(int?), int? ageThresholdForWorkflow = default(int?))
        {
            this.OpportunityStageId = opportunityStageId;
            this.ForwardActivityName = forwardActivityName;
            this.BackwardActivityName = backwardActivityName;
            this.StageDescription = stageDescription;
            this.Description = description;
            this.ProbabilityOfSale = probabilityOfSale;
            this.DaysToClose = daysToClose;
            this.AgeThresholdForWorkflow = ageThresholdForWorkflow;
        }
        
        /// <summary>
        /// Gets or Sets OpportunityStageId
        /// </summary>
        [DataMember(Name="OpportunityStageId", EmitDefaultValue=false)]
        public int? OpportunityStageId { get; set; }

        /// <summary>
        /// Gets or Sets ForwardActivityName
        /// </summary>
        [DataMember(Name="ForwardActivityName", EmitDefaultValue=false)]
        public string ForwardActivityName { get; set; }

        /// <summary>
        /// Gets or Sets BackwardActivityName
        /// </summary>
        [DataMember(Name="BackwardActivityName", EmitDefaultValue=false)]
        public string BackwardActivityName { get; set; }

        /// <summary>
        /// Gets or Sets StageDescription
        /// </summary>
        [DataMember(Name="StageDescription", EmitDefaultValue=false)]
        public string StageDescription { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ProbabilityOfSale
        /// </summary>
        [DataMember(Name="ProbabilityOfSale", EmitDefaultValue=false)]
        public double? ProbabilityOfSale { get; set; }

        /// <summary>
        /// Gets or Sets DaysToClose
        /// </summary>
        [DataMember(Name="DaysToClose", EmitDefaultValue=false)]
        public int? DaysToClose { get; set; }

        /// <summary>
        /// Gets or Sets AgeThresholdForWorkflow
        /// </summary>
        [DataMember(Name="AgeThresholdForWorkflow", EmitDefaultValue=false)]
        public int? AgeThresholdForWorkflow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebOpportunityStage {\n");
            sb.Append("  OpportunityStageId: ").Append(OpportunityStageId).Append("\n");
            sb.Append("  ForwardActivityName: ").Append(ForwardActivityName).Append("\n");
            sb.Append("  BackwardActivityName: ").Append(BackwardActivityName).Append("\n");
            sb.Append("  StageDescription: ").Append(StageDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProbabilityOfSale: ").Append(ProbabilityOfSale).Append("\n");
            sb.Append("  DaysToClose: ").Append(DaysToClose).Append("\n");
            sb.Append("  AgeThresholdForWorkflow: ").Append(AgeThresholdForWorkflow).Append("\n");
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
            return this.Equals(input as TsiWebOpportunityStage);
        }

        /// <summary>
        /// Returns true if TsiWebOpportunityStage instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebOpportunityStage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebOpportunityStage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpportunityStageId == input.OpportunityStageId ||
                    (this.OpportunityStageId != null &&
                    this.OpportunityStageId.Equals(input.OpportunityStageId))
                ) && 
                (
                    this.ForwardActivityName == input.ForwardActivityName ||
                    (this.ForwardActivityName != null &&
                    this.ForwardActivityName.Equals(input.ForwardActivityName))
                ) && 
                (
                    this.BackwardActivityName == input.BackwardActivityName ||
                    (this.BackwardActivityName != null &&
                    this.BackwardActivityName.Equals(input.BackwardActivityName))
                ) && 
                (
                    this.StageDescription == input.StageDescription ||
                    (this.StageDescription != null &&
                    this.StageDescription.Equals(input.StageDescription))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProbabilityOfSale == input.ProbabilityOfSale ||
                    (this.ProbabilityOfSale != null &&
                    this.ProbabilityOfSale.Equals(input.ProbabilityOfSale))
                ) && 
                (
                    this.DaysToClose == input.DaysToClose ||
                    (this.DaysToClose != null &&
                    this.DaysToClose.Equals(input.DaysToClose))
                ) && 
                (
                    this.AgeThresholdForWorkflow == input.AgeThresholdForWorkflow ||
                    (this.AgeThresholdForWorkflow != null &&
                    this.AgeThresholdForWorkflow.Equals(input.AgeThresholdForWorkflow))
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
                if (this.OpportunityStageId != null)
                    hashCode = hashCode * 59 + this.OpportunityStageId.GetHashCode();
                if (this.ForwardActivityName != null)
                    hashCode = hashCode * 59 + this.ForwardActivityName.GetHashCode();
                if (this.BackwardActivityName != null)
                    hashCode = hashCode * 59 + this.BackwardActivityName.GetHashCode();
                if (this.StageDescription != null)
                    hashCode = hashCode * 59 + this.StageDescription.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProbabilityOfSale != null)
                    hashCode = hashCode * 59 + this.ProbabilityOfSale.GetHashCode();
                if (this.DaysToClose != null)
                    hashCode = hashCode * 59 + this.DaysToClose.GetHashCode();
                if (this.AgeThresholdForWorkflow != null)
                    hashCode = hashCode * 59 + this.AgeThresholdForWorkflow.GetHashCode();
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