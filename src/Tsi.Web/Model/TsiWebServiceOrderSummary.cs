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
    /// TsiWebServiceOrderSummary
    /// </summary>
    [DataContract]
    public partial class TsiWebServiceOrderSummary :  IEquatable<TsiWebServiceOrderSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebServiceOrderSummary" /> class.
        /// </summary>
        /// <param name="serviceOrderNumber">serviceOrderNumber.</param>
        /// <param name="serviceOrder">serviceOrder.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="faxNumber">faxNumber.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactEmailAddress">contactEmailAddress.</param>
        /// <param name="contactPhoneNumber">contactPhoneNumber.</param>
        /// <param name="primaryTechnicianName">primaryTechnicianName.</param>
        /// <param name="primaryTechnicianEmailAddress">primaryTechnicianEmailAddress.</param>
        /// <param name="primaryTechnicianPhoneNumber">primaryTechnicianPhoneNumber.</param>
        /// <param name="takenByName">takenByName.</param>
        /// <param name="priceLevelDescription">priceLevelDescription.</param>
        /// <param name="payMethodName">payMethodName.</param>
        /// <param name="projectDescription">projectDescription.</param>
        /// <param name="projectPhase">projectPhase.</param>
        /// <param name="repToCreditName">repToCreditName.</param>
        /// <param name="voidedByName">voidedByName.</param>
        /// <param name="contractDescription">contractDescription.</param>
        /// <param name="contractExpiration">contractExpiration.</param>
        /// <param name="externalProductName">externalProductName.</param>
        /// <param name="severityDescription">severityDescription.</param>
        /// <param name="totalExpenses">totalExpenses.</param>
        /// <param name="serviceOrderProfiles">serviceOrderProfiles.</param>
        /// <param name="serviceOrderSymptoms">serviceOrderSymptoms.</param>
        /// <param name="serviceOrderResolution">serviceOrderResolution.</param>
        /// <param name="partsUsed">partsUsed.</param>
        /// <param name="itemsServiced">itemsServiced.</param>
        /// <param name="timeLogs">timeLogs.</param>
        /// <param name="openTasks">openTasks.</param>
        /// <param name="notes">notes.</param>
        /// <param name="subContractors">subContractors.</param>
        /// <param name="quotes">quotes.</param>
        /// <param name="changeOrders">changeOrders.</param>
        /// <param name="hasParentServiceOrders">hasParentServiceOrders.</param>
        /// <param name="hasChildServiceOrders">hasChildServiceOrders.</param>
        /// <param name="hasBeenSigned">hasBeenSigned.</param>
        /// <param name="hasRecurringOrder">hasRecurringOrder.</param>
        /// <param name="serviceOrderLock">serviceOrderLock.</param>
        /// <param name="hasProjectBeenInvoiced">hasProjectBeenInvoiced.</param>
        public TsiWebServiceOrderSummary(int? serviceOrderNumber = default(int?), TsiWebServiceOrder serviceOrder = default(TsiWebServiceOrder), string accountName = default(string), string phoneNumber = default(string), string faxNumber = default(string), string contactName = default(string), string contactEmailAddress = default(string), string contactPhoneNumber = default(string), string primaryTechnicianName = default(string), string primaryTechnicianEmailAddress = default(string), string primaryTechnicianPhoneNumber = default(string), string takenByName = default(string), string priceLevelDescription = default(string), string payMethodName = default(string), string projectDescription = default(string), string projectPhase = default(string), string repToCreditName = default(string), string voidedByName = default(string), string contractDescription = default(string), DateTime? contractExpiration = default(DateTime?), string externalProductName = default(string), string severityDescription = default(string), double? totalExpenses = default(double?), int? serviceOrderProfiles = default(int?), int? serviceOrderSymptoms = default(int?), int? serviceOrderResolution = default(int?), int? partsUsed = default(int?), int? itemsServiced = default(int?), int? timeLogs = default(int?), int? openTasks = default(int?), int? notes = default(int?), int? subContractors = default(int?), int? quotes = default(int?), int? changeOrders = default(int?), bool? hasParentServiceOrders = default(bool?), bool? hasChildServiceOrders = default(bool?), bool? hasBeenSigned = default(bool?), bool? hasRecurringOrder = default(bool?), TsiWebServiceOrderLock serviceOrderLock = default(TsiWebServiceOrderLock), bool? hasProjectBeenInvoiced = default(bool?))
        {
            this.ServiceOrderNumber = serviceOrderNumber;
            this.ServiceOrder = serviceOrder;
            this.AccountName = accountName;
            this.PhoneNumber = phoneNumber;
            this.FaxNumber = faxNumber;
            this.ContactName = contactName;
            this.ContactEmailAddress = contactEmailAddress;
            this.ContactPhoneNumber = contactPhoneNumber;
            this.PrimaryTechnicianName = primaryTechnicianName;
            this.PrimaryTechnicianEmailAddress = primaryTechnicianEmailAddress;
            this.PrimaryTechnicianPhoneNumber = primaryTechnicianPhoneNumber;
            this.TakenByName = takenByName;
            this.PriceLevelDescription = priceLevelDescription;
            this.PayMethodName = payMethodName;
            this.ProjectDescription = projectDescription;
            this.ProjectPhase = projectPhase;
            this.RepToCreditName = repToCreditName;
            this.VoidedByName = voidedByName;
            this.ContractDescription = contractDescription;
            this.ContractExpiration = contractExpiration;
            this.ExternalProductName = externalProductName;
            this.SeverityDescription = severityDescription;
            this.TotalExpenses = totalExpenses;
            this.ServiceOrderProfiles = serviceOrderProfiles;
            this.ServiceOrderSymptoms = serviceOrderSymptoms;
            this.ServiceOrderResolution = serviceOrderResolution;
            this.PartsUsed = partsUsed;
            this.ItemsServiced = itemsServiced;
            this.TimeLogs = timeLogs;
            this.OpenTasks = openTasks;
            this.Notes = notes;
            this.SubContractors = subContractors;
            this.Quotes = quotes;
            this.ChangeOrders = changeOrders;
            this.HasParentServiceOrders = hasParentServiceOrders;
            this.HasChildServiceOrders = hasChildServiceOrders;
            this.HasBeenSigned = hasBeenSigned;
            this.HasRecurringOrder = hasRecurringOrder;
            this.ServiceOrderLock = serviceOrderLock;
            this.HasProjectBeenInvoiced = hasProjectBeenInvoiced;
        }
        
        /// <summary>
        /// Gets or Sets ServiceOrderNumber
        /// </summary>
        [DataMember(Name="ServiceOrderNumber", EmitDefaultValue=false)]
        public int? ServiceOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrder
        /// </summary>
        [DataMember(Name="ServiceOrder", EmitDefaultValue=false)]
        public TsiWebServiceOrder ServiceOrder { get; set; }

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
        /// Gets or Sets PrimaryTechnicianName
        /// </summary>
        [DataMember(Name="PrimaryTechnicianName", EmitDefaultValue=false)]
        public string PrimaryTechnicianName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTechnicianEmailAddress
        /// </summary>
        [DataMember(Name="PrimaryTechnicianEmailAddress", EmitDefaultValue=false)]
        public string PrimaryTechnicianEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTechnicianPhoneNumber
        /// </summary>
        [DataMember(Name="PrimaryTechnicianPhoneNumber", EmitDefaultValue=false)]
        public string PrimaryTechnicianPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets TakenByName
        /// </summary>
        [DataMember(Name="TakenByName", EmitDefaultValue=false)]
        public string TakenByName { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevelDescription
        /// </summary>
        [DataMember(Name="PriceLevelDescription", EmitDefaultValue=false)]
        public string PriceLevelDescription { get; set; }

        /// <summary>
        /// Gets or Sets PayMethodName
        /// </summary>
        [DataMember(Name="PayMethodName", EmitDefaultValue=false)]
        public string PayMethodName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectDescription
        /// </summary>
        [DataMember(Name="ProjectDescription", EmitDefaultValue=false)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Gets or Sets ProjectPhase
        /// </summary>
        [DataMember(Name="ProjectPhase", EmitDefaultValue=false)]
        public string ProjectPhase { get; set; }

        /// <summary>
        /// Gets or Sets RepToCreditName
        /// </summary>
        [DataMember(Name="RepToCreditName", EmitDefaultValue=false)]
        public string RepToCreditName { get; set; }

        /// <summary>
        /// Gets or Sets VoidedByName
        /// </summary>
        [DataMember(Name="VoidedByName", EmitDefaultValue=false)]
        public string VoidedByName { get; set; }

        /// <summary>
        /// Gets or Sets ContractDescription
        /// </summary>
        [DataMember(Name="ContractDescription", EmitDefaultValue=false)]
        public string ContractDescription { get; set; }

        /// <summary>
        /// Gets or Sets ContractExpiration
        /// </summary>
        [DataMember(Name="ContractExpiration", EmitDefaultValue=false)]
        public DateTime? ContractExpiration { get; set; }

        /// <summary>
        /// Gets or Sets ExternalProductName
        /// </summary>
        [DataMember(Name="ExternalProductName", EmitDefaultValue=false)]
        public string ExternalProductName { get; set; }

        /// <summary>
        /// Gets or Sets SeverityDescription
        /// </summary>
        [DataMember(Name="SeverityDescription", EmitDefaultValue=false)]
        public string SeverityDescription { get; set; }

        /// <summary>
        /// Gets or Sets TotalExpenses
        /// </summary>
        [DataMember(Name="TotalExpenses", EmitDefaultValue=false)]
        public double? TotalExpenses { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderProfiles
        /// </summary>
        [DataMember(Name="ServiceOrderProfiles", EmitDefaultValue=false)]
        public int? ServiceOrderProfiles { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderSymptoms
        /// </summary>
        [DataMember(Name="ServiceOrderSymptoms", EmitDefaultValue=false)]
        public int? ServiceOrderSymptoms { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderResolution
        /// </summary>
        [DataMember(Name="ServiceOrderResolution", EmitDefaultValue=false)]
        public int? ServiceOrderResolution { get; set; }

        /// <summary>
        /// Gets or Sets PartsUsed
        /// </summary>
        [DataMember(Name="PartsUsed", EmitDefaultValue=false)]
        public int? PartsUsed { get; set; }

        /// <summary>
        /// Gets or Sets ItemsServiced
        /// </summary>
        [DataMember(Name="ItemsServiced", EmitDefaultValue=false)]
        public int? ItemsServiced { get; set; }

        /// <summary>
        /// Gets or Sets TimeLogs
        /// </summary>
        [DataMember(Name="TimeLogs", EmitDefaultValue=false)]
        public int? TimeLogs { get; set; }

        /// <summary>
        /// Gets or Sets OpenTasks
        /// </summary>
        [DataMember(Name="OpenTasks", EmitDefaultValue=false)]
        public int? OpenTasks { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public int? Notes { get; set; }

        /// <summary>
        /// Gets or Sets SubContractors
        /// </summary>
        [DataMember(Name="SubContractors", EmitDefaultValue=false)]
        public int? SubContractors { get; set; }

        /// <summary>
        /// Gets or Sets Quotes
        /// </summary>
        [DataMember(Name="Quotes", EmitDefaultValue=false)]
        public int? Quotes { get; set; }

        /// <summary>
        /// Gets or Sets ChangeOrders
        /// </summary>
        [DataMember(Name="ChangeOrders", EmitDefaultValue=false)]
        public int? ChangeOrders { get; set; }

        /// <summary>
        /// Gets or Sets HasParentServiceOrders
        /// </summary>
        [DataMember(Name="HasParentServiceOrders", EmitDefaultValue=false)]
        public bool? HasParentServiceOrders { get; set; }

        /// <summary>
        /// Gets or Sets HasChildServiceOrders
        /// </summary>
        [DataMember(Name="HasChildServiceOrders", EmitDefaultValue=false)]
        public bool? HasChildServiceOrders { get; set; }

        /// <summary>
        /// Gets or Sets HasBeenSigned
        /// </summary>
        [DataMember(Name="HasBeenSigned", EmitDefaultValue=false)]
        public bool? HasBeenSigned { get; set; }

        /// <summary>
        /// Gets or Sets HasRecurringOrder
        /// </summary>
        [DataMember(Name="HasRecurringOrder", EmitDefaultValue=false)]
        public bool? HasRecurringOrder { get; set; }

        /// <summary>
        /// Gets or Sets ServiceOrderLock
        /// </summary>
        [DataMember(Name="ServiceOrderLock", EmitDefaultValue=false)]
        public TsiWebServiceOrderLock ServiceOrderLock { get; set; }

        /// <summary>
        /// Gets or Sets HasProjectBeenInvoiced
        /// </summary>
        [DataMember(Name="HasProjectBeenInvoiced", EmitDefaultValue=false)]
        public bool? HasProjectBeenInvoiced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebServiceOrderSummary {\n");
            sb.Append("  ServiceOrderNumber: ").Append(ServiceOrderNumber).Append("\n");
            sb.Append("  ServiceOrder: ").Append(ServiceOrder).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
            sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
            sb.Append("  PrimaryTechnicianName: ").Append(PrimaryTechnicianName).Append("\n");
            sb.Append("  PrimaryTechnicianEmailAddress: ").Append(PrimaryTechnicianEmailAddress).Append("\n");
            sb.Append("  PrimaryTechnicianPhoneNumber: ").Append(PrimaryTechnicianPhoneNumber).Append("\n");
            sb.Append("  TakenByName: ").Append(TakenByName).Append("\n");
            sb.Append("  PriceLevelDescription: ").Append(PriceLevelDescription).Append("\n");
            sb.Append("  PayMethodName: ").Append(PayMethodName).Append("\n");
            sb.Append("  ProjectDescription: ").Append(ProjectDescription).Append("\n");
            sb.Append("  ProjectPhase: ").Append(ProjectPhase).Append("\n");
            sb.Append("  RepToCreditName: ").Append(RepToCreditName).Append("\n");
            sb.Append("  VoidedByName: ").Append(VoidedByName).Append("\n");
            sb.Append("  ContractDescription: ").Append(ContractDescription).Append("\n");
            sb.Append("  ContractExpiration: ").Append(ContractExpiration).Append("\n");
            sb.Append("  ExternalProductName: ").Append(ExternalProductName).Append("\n");
            sb.Append("  SeverityDescription: ").Append(SeverityDescription).Append("\n");
            sb.Append("  TotalExpenses: ").Append(TotalExpenses).Append("\n");
            sb.Append("  ServiceOrderProfiles: ").Append(ServiceOrderProfiles).Append("\n");
            sb.Append("  ServiceOrderSymptoms: ").Append(ServiceOrderSymptoms).Append("\n");
            sb.Append("  ServiceOrderResolution: ").Append(ServiceOrderResolution).Append("\n");
            sb.Append("  PartsUsed: ").Append(PartsUsed).Append("\n");
            sb.Append("  ItemsServiced: ").Append(ItemsServiced).Append("\n");
            sb.Append("  TimeLogs: ").Append(TimeLogs).Append("\n");
            sb.Append("  OpenTasks: ").Append(OpenTasks).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  SubContractors: ").Append(SubContractors).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  ChangeOrders: ").Append(ChangeOrders).Append("\n");
            sb.Append("  HasParentServiceOrders: ").Append(HasParentServiceOrders).Append("\n");
            sb.Append("  HasChildServiceOrders: ").Append(HasChildServiceOrders).Append("\n");
            sb.Append("  HasBeenSigned: ").Append(HasBeenSigned).Append("\n");
            sb.Append("  HasRecurringOrder: ").Append(HasRecurringOrder).Append("\n");
            sb.Append("  ServiceOrderLock: ").Append(ServiceOrderLock).Append("\n");
            sb.Append("  HasProjectBeenInvoiced: ").Append(HasProjectBeenInvoiced).Append("\n");
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
            return this.Equals(input as TsiWebServiceOrderSummary);
        }

        /// <summary>
        /// Returns true if TsiWebServiceOrderSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebServiceOrderSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebServiceOrderSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceOrderNumber == input.ServiceOrderNumber ||
                    (this.ServiceOrderNumber != null &&
                    this.ServiceOrderNumber.Equals(input.ServiceOrderNumber))
                ) && 
                (
                    this.ServiceOrder == input.ServiceOrder ||
                    (this.ServiceOrder != null &&
                    this.ServiceOrder.Equals(input.ServiceOrder))
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
                    this.PrimaryTechnicianName == input.PrimaryTechnicianName ||
                    (this.PrimaryTechnicianName != null &&
                    this.PrimaryTechnicianName.Equals(input.PrimaryTechnicianName))
                ) && 
                (
                    this.PrimaryTechnicianEmailAddress == input.PrimaryTechnicianEmailAddress ||
                    (this.PrimaryTechnicianEmailAddress != null &&
                    this.PrimaryTechnicianEmailAddress.Equals(input.PrimaryTechnicianEmailAddress))
                ) && 
                (
                    this.PrimaryTechnicianPhoneNumber == input.PrimaryTechnicianPhoneNumber ||
                    (this.PrimaryTechnicianPhoneNumber != null &&
                    this.PrimaryTechnicianPhoneNumber.Equals(input.PrimaryTechnicianPhoneNumber))
                ) && 
                (
                    this.TakenByName == input.TakenByName ||
                    (this.TakenByName != null &&
                    this.TakenByName.Equals(input.TakenByName))
                ) && 
                (
                    this.PriceLevelDescription == input.PriceLevelDescription ||
                    (this.PriceLevelDescription != null &&
                    this.PriceLevelDescription.Equals(input.PriceLevelDescription))
                ) && 
                (
                    this.PayMethodName == input.PayMethodName ||
                    (this.PayMethodName != null &&
                    this.PayMethodName.Equals(input.PayMethodName))
                ) && 
                (
                    this.ProjectDescription == input.ProjectDescription ||
                    (this.ProjectDescription != null &&
                    this.ProjectDescription.Equals(input.ProjectDescription))
                ) && 
                (
                    this.ProjectPhase == input.ProjectPhase ||
                    (this.ProjectPhase != null &&
                    this.ProjectPhase.Equals(input.ProjectPhase))
                ) && 
                (
                    this.RepToCreditName == input.RepToCreditName ||
                    (this.RepToCreditName != null &&
                    this.RepToCreditName.Equals(input.RepToCreditName))
                ) && 
                (
                    this.VoidedByName == input.VoidedByName ||
                    (this.VoidedByName != null &&
                    this.VoidedByName.Equals(input.VoidedByName))
                ) && 
                (
                    this.ContractDescription == input.ContractDescription ||
                    (this.ContractDescription != null &&
                    this.ContractDescription.Equals(input.ContractDescription))
                ) && 
                (
                    this.ContractExpiration == input.ContractExpiration ||
                    (this.ContractExpiration != null &&
                    this.ContractExpiration.Equals(input.ContractExpiration))
                ) && 
                (
                    this.ExternalProductName == input.ExternalProductName ||
                    (this.ExternalProductName != null &&
                    this.ExternalProductName.Equals(input.ExternalProductName))
                ) && 
                (
                    this.SeverityDescription == input.SeverityDescription ||
                    (this.SeverityDescription != null &&
                    this.SeverityDescription.Equals(input.SeverityDescription))
                ) && 
                (
                    this.TotalExpenses == input.TotalExpenses ||
                    (this.TotalExpenses != null &&
                    this.TotalExpenses.Equals(input.TotalExpenses))
                ) && 
                (
                    this.ServiceOrderProfiles == input.ServiceOrderProfiles ||
                    (this.ServiceOrderProfiles != null &&
                    this.ServiceOrderProfiles.Equals(input.ServiceOrderProfiles))
                ) && 
                (
                    this.ServiceOrderSymptoms == input.ServiceOrderSymptoms ||
                    (this.ServiceOrderSymptoms != null &&
                    this.ServiceOrderSymptoms.Equals(input.ServiceOrderSymptoms))
                ) && 
                (
                    this.ServiceOrderResolution == input.ServiceOrderResolution ||
                    (this.ServiceOrderResolution != null &&
                    this.ServiceOrderResolution.Equals(input.ServiceOrderResolution))
                ) && 
                (
                    this.PartsUsed == input.PartsUsed ||
                    (this.PartsUsed != null &&
                    this.PartsUsed.Equals(input.PartsUsed))
                ) && 
                (
                    this.ItemsServiced == input.ItemsServiced ||
                    (this.ItemsServiced != null &&
                    this.ItemsServiced.Equals(input.ItemsServiced))
                ) && 
                (
                    this.TimeLogs == input.TimeLogs ||
                    (this.TimeLogs != null &&
                    this.TimeLogs.Equals(input.TimeLogs))
                ) && 
                (
                    this.OpenTasks == input.OpenTasks ||
                    (this.OpenTasks != null &&
                    this.OpenTasks.Equals(input.OpenTasks))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.SubContractors == input.SubContractors ||
                    (this.SubContractors != null &&
                    this.SubContractors.Equals(input.SubContractors))
                ) && 
                (
                    this.Quotes == input.Quotes ||
                    (this.Quotes != null &&
                    this.Quotes.Equals(input.Quotes))
                ) && 
                (
                    this.ChangeOrders == input.ChangeOrders ||
                    (this.ChangeOrders != null &&
                    this.ChangeOrders.Equals(input.ChangeOrders))
                ) && 
                (
                    this.HasParentServiceOrders == input.HasParentServiceOrders ||
                    (this.HasParentServiceOrders != null &&
                    this.HasParentServiceOrders.Equals(input.HasParentServiceOrders))
                ) && 
                (
                    this.HasChildServiceOrders == input.HasChildServiceOrders ||
                    (this.HasChildServiceOrders != null &&
                    this.HasChildServiceOrders.Equals(input.HasChildServiceOrders))
                ) && 
                (
                    this.HasBeenSigned == input.HasBeenSigned ||
                    (this.HasBeenSigned != null &&
                    this.HasBeenSigned.Equals(input.HasBeenSigned))
                ) && 
                (
                    this.HasRecurringOrder == input.HasRecurringOrder ||
                    (this.HasRecurringOrder != null &&
                    this.HasRecurringOrder.Equals(input.HasRecurringOrder))
                ) && 
                (
                    this.ServiceOrderLock == input.ServiceOrderLock ||
                    (this.ServiceOrderLock != null &&
                    this.ServiceOrderLock.Equals(input.ServiceOrderLock))
                ) && 
                (
                    this.HasProjectBeenInvoiced == input.HasProjectBeenInvoiced ||
                    (this.HasProjectBeenInvoiced != null &&
                    this.HasProjectBeenInvoiced.Equals(input.HasProjectBeenInvoiced))
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
                if (this.ServiceOrderNumber != null)
                    hashCode = hashCode * 59 + this.ServiceOrderNumber.GetHashCode();
                if (this.ServiceOrder != null)
                    hashCode = hashCode * 59 + this.ServiceOrder.GetHashCode();
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
                if (this.PrimaryTechnicianName != null)
                    hashCode = hashCode * 59 + this.PrimaryTechnicianName.GetHashCode();
                if (this.PrimaryTechnicianEmailAddress != null)
                    hashCode = hashCode * 59 + this.PrimaryTechnicianEmailAddress.GetHashCode();
                if (this.PrimaryTechnicianPhoneNumber != null)
                    hashCode = hashCode * 59 + this.PrimaryTechnicianPhoneNumber.GetHashCode();
                if (this.TakenByName != null)
                    hashCode = hashCode * 59 + this.TakenByName.GetHashCode();
                if (this.PriceLevelDescription != null)
                    hashCode = hashCode * 59 + this.PriceLevelDescription.GetHashCode();
                if (this.PayMethodName != null)
                    hashCode = hashCode * 59 + this.PayMethodName.GetHashCode();
                if (this.ProjectDescription != null)
                    hashCode = hashCode * 59 + this.ProjectDescription.GetHashCode();
                if (this.ProjectPhase != null)
                    hashCode = hashCode * 59 + this.ProjectPhase.GetHashCode();
                if (this.RepToCreditName != null)
                    hashCode = hashCode * 59 + this.RepToCreditName.GetHashCode();
                if (this.VoidedByName != null)
                    hashCode = hashCode * 59 + this.VoidedByName.GetHashCode();
                if (this.ContractDescription != null)
                    hashCode = hashCode * 59 + this.ContractDescription.GetHashCode();
                if (this.ContractExpiration != null)
                    hashCode = hashCode * 59 + this.ContractExpiration.GetHashCode();
                if (this.ExternalProductName != null)
                    hashCode = hashCode * 59 + this.ExternalProductName.GetHashCode();
                if (this.SeverityDescription != null)
                    hashCode = hashCode * 59 + this.SeverityDescription.GetHashCode();
                if (this.TotalExpenses != null)
                    hashCode = hashCode * 59 + this.TotalExpenses.GetHashCode();
                if (this.ServiceOrderProfiles != null)
                    hashCode = hashCode * 59 + this.ServiceOrderProfiles.GetHashCode();
                if (this.ServiceOrderSymptoms != null)
                    hashCode = hashCode * 59 + this.ServiceOrderSymptoms.GetHashCode();
                if (this.ServiceOrderResolution != null)
                    hashCode = hashCode * 59 + this.ServiceOrderResolution.GetHashCode();
                if (this.PartsUsed != null)
                    hashCode = hashCode * 59 + this.PartsUsed.GetHashCode();
                if (this.ItemsServiced != null)
                    hashCode = hashCode * 59 + this.ItemsServiced.GetHashCode();
                if (this.TimeLogs != null)
                    hashCode = hashCode * 59 + this.TimeLogs.GetHashCode();
                if (this.OpenTasks != null)
                    hashCode = hashCode * 59 + this.OpenTasks.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.SubContractors != null)
                    hashCode = hashCode * 59 + this.SubContractors.GetHashCode();
                if (this.Quotes != null)
                    hashCode = hashCode * 59 + this.Quotes.GetHashCode();
                if (this.ChangeOrders != null)
                    hashCode = hashCode * 59 + this.ChangeOrders.GetHashCode();
                if (this.HasParentServiceOrders != null)
                    hashCode = hashCode * 59 + this.HasParentServiceOrders.GetHashCode();
                if (this.HasChildServiceOrders != null)
                    hashCode = hashCode * 59 + this.HasChildServiceOrders.GetHashCode();
                if (this.HasBeenSigned != null)
                    hashCode = hashCode * 59 + this.HasBeenSigned.GetHashCode();
                if (this.HasRecurringOrder != null)
                    hashCode = hashCode * 59 + this.HasRecurringOrder.GetHashCode();
                if (this.ServiceOrderLock != null)
                    hashCode = hashCode * 59 + this.ServiceOrderLock.GetHashCode();
                if (this.HasProjectBeenInvoiced != null)
                    hashCode = hashCode * 59 + this.HasProjectBeenInvoiced.GetHashCode();
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
