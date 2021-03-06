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
    /// TsiWebAccountDetail
    /// </summary>
    [DataContract]
    public partial class TsiWebAccountDetail :  IEquatable<TsiWebAccountDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebAccountDetail" /> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="account">account.</param>
        /// <param name="accounting">accounting.</param>
        /// <param name="marketing">marketing.</param>
        /// <param name="service">service.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="primaryRep">primaryRep.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="shipTos">shipTos.</param>
        /// <param name="billTos">billTos.</param>
        /// <param name="payMethods">payMethods.</param>
        /// <param name="externalProducts">externalProducts.</param>
        /// <param name="systems">systems.</param>
        /// <param name="coManagedTechnicians">coManagedTechnicians.</param>
        /// <param name="groups">groups.</param>
        /// <param name="profiles">profiles.</param>
        /// <param name="sICCodes">sICCodes.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="relatedAccounts">relatedAccounts.</param>
        /// <param name="parentAccountNumber">parentAccountNumber.</param>
        /// <param name="journalEntries">journalEntries.</param>
        /// <param name="openInvoices">openInvoices.</param>
        /// <param name="openQuotes">openQuotes.</param>
        /// <param name="openOpportunities">openOpportunities.</param>
        /// <param name="openProjectCount">openProjectCount.</param>
        /// <param name="openServiceOrders">openServiceOrders.</param>
        /// <param name="pastDueTasks">pastDueTasks.</param>
        /// <param name="openRMAs">openRMAs.</param>
        /// <param name="numberOfContacts">numberOfContacts.</param>
        public TsiWebAccountDetail(int? accountNumber = default(int?), TsiWebAccount account = default(TsiWebAccount), TsiWebAccountingDetail accounting = default(TsiWebAccountingDetail), TsiWebAccountMarketingDetail marketing = default(TsiWebAccountMarketingDetail), TsiWebAccountServiceDetail service = default(TsiWebAccountServiceDetail), TsiWebPerson primaryContact = default(TsiWebPerson), TsiWebPerson primaryRep = default(TsiWebPerson), List<TsiWebPhoneNumber> phoneNumbers = default(List<TsiWebPhoneNumber>), List<TsiWebShipTo> shipTos = default(List<TsiWebShipTo>), List<TsiWebBillTo> billTos = default(List<TsiWebBillTo>), List<TsiWebPayMethod> payMethods = default(List<TsiWebPayMethod>), List<TsiWebAccountExternalProduct> externalProducts = default(List<TsiWebAccountExternalProduct>), List<TsiWebAccountSystem> systems = default(List<TsiWebAccountSystem>), List<TsiWebCoManagedTechnician> coManagedTechnicians = default(List<TsiWebCoManagedTechnician>), List<TsiWebAssignedMarketingGroup> groups = default(List<TsiWebAssignedMarketingGroup>), List<TsiWebAssignedMarketingProfile> profiles = default(List<TsiWebAssignedMarketingProfile>), List<TsiWebAssignedSICCode> sICCodes = default(List<TsiWebAssignedSICCode>), List<TsiWebCustomField> customFields = default(List<TsiWebCustomField>), int? relatedAccounts = default(int?), int? parentAccountNumber = default(int?), int? journalEntries = default(int?), int? openInvoices = default(int?), int? openQuotes = default(int?), int? openOpportunities = default(int?), int? openProjectCount = default(int?), int? openServiceOrders = default(int?), int? pastDueTasks = default(int?), int? openRMAs = default(int?), int? numberOfContacts = default(int?))
        {
            this.AccountNumber = accountNumber;
            this.Account = account;
            this.Accounting = accounting;
            this.Marketing = marketing;
            this.Service = service;
            this.PrimaryContact = primaryContact;
            this.PrimaryRep = primaryRep;
            this.PhoneNumbers = phoneNumbers;
            this.ShipTos = shipTos;
            this.BillTos = billTos;
            this.PayMethods = payMethods;
            this.ExternalProducts = externalProducts;
            this.Systems = systems;
            this.CoManagedTechnicians = coManagedTechnicians;
            this.Groups = groups;
            this.Profiles = profiles;
            this.SICCodes = sICCodes;
            this.CustomFields = customFields;
            this.RelatedAccounts = relatedAccounts;
            this.ParentAccountNumber = parentAccountNumber;
            this.JournalEntries = journalEntries;
            this.OpenInvoices = openInvoices;
            this.OpenQuotes = openQuotes;
            this.OpenOpportunities = openOpportunities;
            this.OpenProjectCount = openProjectCount;
            this.OpenServiceOrders = openServiceOrders;
            this.PastDueTasks = pastDueTasks;
            this.OpenRMAs = openRMAs;
            this.NumberOfContacts = numberOfContacts;
        }
        
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public TsiWebAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets Accounting
        /// </summary>
        [DataMember(Name="Accounting", EmitDefaultValue=false)]
        public TsiWebAccountingDetail Accounting { get; set; }

        /// <summary>
        /// Gets or Sets Marketing
        /// </summary>
        [DataMember(Name="Marketing", EmitDefaultValue=false)]
        public TsiWebAccountMarketingDetail Marketing { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="Service", EmitDefaultValue=false)]
        public TsiWebAccountServiceDetail Service { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
        public TsiWebPerson PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryRep
        /// </summary>
        [DataMember(Name="PrimaryRep", EmitDefaultValue=false)]
        public TsiWebPerson PrimaryRep { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="PhoneNumbers", EmitDefaultValue=false)]
        public List<TsiWebPhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets ShipTos
        /// </summary>
        [DataMember(Name="ShipTos", EmitDefaultValue=false)]
        public List<TsiWebShipTo> ShipTos { get; set; }

        /// <summary>
        /// Gets or Sets BillTos
        /// </summary>
        [DataMember(Name="BillTos", EmitDefaultValue=false)]
        public List<TsiWebBillTo> BillTos { get; set; }

        /// <summary>
        /// Gets or Sets PayMethods
        /// </summary>
        [DataMember(Name="PayMethods", EmitDefaultValue=false)]
        public List<TsiWebPayMethod> PayMethods { get; set; }

        /// <summary>
        /// Gets or Sets ExternalProducts
        /// </summary>
        [DataMember(Name="ExternalProducts", EmitDefaultValue=false)]
        public List<TsiWebAccountExternalProduct> ExternalProducts { get; set; }

        /// <summary>
        /// Gets or Sets Systems
        /// </summary>
        [DataMember(Name="Systems", EmitDefaultValue=false)]
        public List<TsiWebAccountSystem> Systems { get; set; }

        /// <summary>
        /// Gets or Sets CoManagedTechnicians
        /// </summary>
        [DataMember(Name="CoManagedTechnicians", EmitDefaultValue=false)]
        public List<TsiWebCoManagedTechnician> CoManagedTechnicians { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="Groups", EmitDefaultValue=false)]
        public List<TsiWebAssignedMarketingGroup> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="Profiles", EmitDefaultValue=false)]
        public List<TsiWebAssignedMarketingProfile> Profiles { get; set; }

        /// <summary>
        /// Gets or Sets SICCodes
        /// </summary>
        [DataMember(Name="SICCodes", EmitDefaultValue=false)]
        public List<TsiWebAssignedSICCode> SICCodes { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="CustomFields", EmitDefaultValue=false)]
        public List<TsiWebCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets RelatedAccounts
        /// </summary>
        [DataMember(Name="RelatedAccounts", EmitDefaultValue=false)]
        public int? RelatedAccounts { get; set; }

        /// <summary>
        /// Gets or Sets ParentAccountNumber
        /// </summary>
        [DataMember(Name="ParentAccountNumber", EmitDefaultValue=false)]
        public int? ParentAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets JournalEntries
        /// </summary>
        [DataMember(Name="JournalEntries", EmitDefaultValue=false)]
        public int? JournalEntries { get; set; }

        /// <summary>
        /// Gets or Sets OpenInvoices
        /// </summary>
        [DataMember(Name="OpenInvoices", EmitDefaultValue=false)]
        public int? OpenInvoices { get; set; }

        /// <summary>
        /// Gets or Sets OpenQuotes
        /// </summary>
        [DataMember(Name="OpenQuotes", EmitDefaultValue=false)]
        public int? OpenQuotes { get; set; }

        /// <summary>
        /// Gets or Sets OpenOpportunities
        /// </summary>
        [DataMember(Name="OpenOpportunities", EmitDefaultValue=false)]
        public int? OpenOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets OpenProjectCount
        /// </summary>
        [DataMember(Name="OpenProjectCount", EmitDefaultValue=false)]
        public int? OpenProjectCount { get; set; }

        /// <summary>
        /// Gets or Sets OpenServiceOrders
        /// </summary>
        [DataMember(Name="OpenServiceOrders", EmitDefaultValue=false)]
        public int? OpenServiceOrders { get; set; }

        /// <summary>
        /// Gets or Sets PastDueTasks
        /// </summary>
        [DataMember(Name="PastDueTasks", EmitDefaultValue=false)]
        public int? PastDueTasks { get; set; }

        /// <summary>
        /// Gets or Sets OpenRMAs
        /// </summary>
        [DataMember(Name="OpenRMAs", EmitDefaultValue=false)]
        public int? OpenRMAs { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfContacts
        /// </summary>
        [DataMember(Name="NumberOfContacts", EmitDefaultValue=false)]
        public int? NumberOfContacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebAccountDetail {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Accounting: ").Append(Accounting).Append("\n");
            sb.Append("  Marketing: ").Append(Marketing).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  PrimaryRep: ").Append(PrimaryRep).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  ShipTos: ").Append(ShipTos).Append("\n");
            sb.Append("  BillTos: ").Append(BillTos).Append("\n");
            sb.Append("  PayMethods: ").Append(PayMethods).Append("\n");
            sb.Append("  ExternalProducts: ").Append(ExternalProducts).Append("\n");
            sb.Append("  Systems: ").Append(Systems).Append("\n");
            sb.Append("  CoManagedTechnicians: ").Append(CoManagedTechnicians).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  SICCodes: ").Append(SICCodes).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  RelatedAccounts: ").Append(RelatedAccounts).Append("\n");
            sb.Append("  ParentAccountNumber: ").Append(ParentAccountNumber).Append("\n");
            sb.Append("  JournalEntries: ").Append(JournalEntries).Append("\n");
            sb.Append("  OpenInvoices: ").Append(OpenInvoices).Append("\n");
            sb.Append("  OpenQuotes: ").Append(OpenQuotes).Append("\n");
            sb.Append("  OpenOpportunities: ").Append(OpenOpportunities).Append("\n");
            sb.Append("  OpenProjectCount: ").Append(OpenProjectCount).Append("\n");
            sb.Append("  OpenServiceOrders: ").Append(OpenServiceOrders).Append("\n");
            sb.Append("  PastDueTasks: ").Append(PastDueTasks).Append("\n");
            sb.Append("  OpenRMAs: ").Append(OpenRMAs).Append("\n");
            sb.Append("  NumberOfContacts: ").Append(NumberOfContacts).Append("\n");
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
            return this.Equals(input as TsiWebAccountDetail);
        }

        /// <summary>
        /// Returns true if TsiWebAccountDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebAccountDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebAccountDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Accounting == input.Accounting ||
                    (this.Accounting != null &&
                    this.Accounting.Equals(input.Accounting))
                ) && 
                (
                    this.Marketing == input.Marketing ||
                    (this.Marketing != null &&
                    this.Marketing.Equals(input.Marketing))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.PrimaryRep == input.PrimaryRep ||
                    (this.PrimaryRep != null &&
                    this.PrimaryRep.Equals(input.PrimaryRep))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.ShipTos == input.ShipTos ||
                    this.ShipTos != null &&
                    this.ShipTos.SequenceEqual(input.ShipTos)
                ) && 
                (
                    this.BillTos == input.BillTos ||
                    this.BillTos != null &&
                    this.BillTos.SequenceEqual(input.BillTos)
                ) && 
                (
                    this.PayMethods == input.PayMethods ||
                    this.PayMethods != null &&
                    this.PayMethods.SequenceEqual(input.PayMethods)
                ) && 
                (
                    this.ExternalProducts == input.ExternalProducts ||
                    this.ExternalProducts != null &&
                    this.ExternalProducts.SequenceEqual(input.ExternalProducts)
                ) && 
                (
                    this.Systems == input.Systems ||
                    this.Systems != null &&
                    this.Systems.SequenceEqual(input.Systems)
                ) && 
                (
                    this.CoManagedTechnicians == input.CoManagedTechnicians ||
                    this.CoManagedTechnicians != null &&
                    this.CoManagedTechnicians.SequenceEqual(input.CoManagedTechnicians)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
                ) && 
                (
                    this.SICCodes == input.SICCodes ||
                    this.SICCodes != null &&
                    this.SICCodes.SequenceEqual(input.SICCodes)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.RelatedAccounts == input.RelatedAccounts ||
                    (this.RelatedAccounts != null &&
                    this.RelatedAccounts.Equals(input.RelatedAccounts))
                ) && 
                (
                    this.ParentAccountNumber == input.ParentAccountNumber ||
                    (this.ParentAccountNumber != null &&
                    this.ParentAccountNumber.Equals(input.ParentAccountNumber))
                ) && 
                (
                    this.JournalEntries == input.JournalEntries ||
                    (this.JournalEntries != null &&
                    this.JournalEntries.Equals(input.JournalEntries))
                ) && 
                (
                    this.OpenInvoices == input.OpenInvoices ||
                    (this.OpenInvoices != null &&
                    this.OpenInvoices.Equals(input.OpenInvoices))
                ) && 
                (
                    this.OpenQuotes == input.OpenQuotes ||
                    (this.OpenQuotes != null &&
                    this.OpenQuotes.Equals(input.OpenQuotes))
                ) && 
                (
                    this.OpenOpportunities == input.OpenOpportunities ||
                    (this.OpenOpportunities != null &&
                    this.OpenOpportunities.Equals(input.OpenOpportunities))
                ) && 
                (
                    this.OpenProjectCount == input.OpenProjectCount ||
                    (this.OpenProjectCount != null &&
                    this.OpenProjectCount.Equals(input.OpenProjectCount))
                ) && 
                (
                    this.OpenServiceOrders == input.OpenServiceOrders ||
                    (this.OpenServiceOrders != null &&
                    this.OpenServiceOrders.Equals(input.OpenServiceOrders))
                ) && 
                (
                    this.PastDueTasks == input.PastDueTasks ||
                    (this.PastDueTasks != null &&
                    this.PastDueTasks.Equals(input.PastDueTasks))
                ) && 
                (
                    this.OpenRMAs == input.OpenRMAs ||
                    (this.OpenRMAs != null &&
                    this.OpenRMAs.Equals(input.OpenRMAs))
                ) && 
                (
                    this.NumberOfContacts == input.NumberOfContacts ||
                    (this.NumberOfContacts != null &&
                    this.NumberOfContacts.Equals(input.NumberOfContacts))
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
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Accounting != null)
                    hashCode = hashCode * 59 + this.Accounting.GetHashCode();
                if (this.Marketing != null)
                    hashCode = hashCode * 59 + this.Marketing.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.PrimaryRep != null)
                    hashCode = hashCode * 59 + this.PrimaryRep.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.ShipTos != null)
                    hashCode = hashCode * 59 + this.ShipTos.GetHashCode();
                if (this.BillTos != null)
                    hashCode = hashCode * 59 + this.BillTos.GetHashCode();
                if (this.PayMethods != null)
                    hashCode = hashCode * 59 + this.PayMethods.GetHashCode();
                if (this.ExternalProducts != null)
                    hashCode = hashCode * 59 + this.ExternalProducts.GetHashCode();
                if (this.Systems != null)
                    hashCode = hashCode * 59 + this.Systems.GetHashCode();
                if (this.CoManagedTechnicians != null)
                    hashCode = hashCode * 59 + this.CoManagedTechnicians.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.SICCodes != null)
                    hashCode = hashCode * 59 + this.SICCodes.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.RelatedAccounts != null)
                    hashCode = hashCode * 59 + this.RelatedAccounts.GetHashCode();
                if (this.ParentAccountNumber != null)
                    hashCode = hashCode * 59 + this.ParentAccountNumber.GetHashCode();
                if (this.JournalEntries != null)
                    hashCode = hashCode * 59 + this.JournalEntries.GetHashCode();
                if (this.OpenInvoices != null)
                    hashCode = hashCode * 59 + this.OpenInvoices.GetHashCode();
                if (this.OpenQuotes != null)
                    hashCode = hashCode * 59 + this.OpenQuotes.GetHashCode();
                if (this.OpenOpportunities != null)
                    hashCode = hashCode * 59 + this.OpenOpportunities.GetHashCode();
                if (this.OpenProjectCount != null)
                    hashCode = hashCode * 59 + this.OpenProjectCount.GetHashCode();
                if (this.OpenServiceOrders != null)
                    hashCode = hashCode * 59 + this.OpenServiceOrders.GetHashCode();
                if (this.PastDueTasks != null)
                    hashCode = hashCode * 59 + this.PastDueTasks.GetHashCode();
                if (this.OpenRMAs != null)
                    hashCode = hashCode * 59 + this.OpenRMAs.GetHashCode();
                if (this.NumberOfContacts != null)
                    hashCode = hashCode * 59 + this.NumberOfContacts.GetHashCode();
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
