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
    /// TsiWebContactDetail
    /// </summary>
    [DataContract]
    public partial class TsiWebContactDetail :  IEquatable<TsiWebContactDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebContactDetail" /> class.
        /// </summary>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="contact">contact.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        /// <param name="groups">groups.</param>
        /// <param name="profiles">profiles.</param>
        /// <param name="account">account.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="isPrimaryContact">isPrimaryContact.</param>
        /// <param name="journalEntries">journalEntries.</param>
        /// <param name="openOpportunities">openOpportunities.</param>
        /// <param name="openServiceOrders">openServiceOrders.</param>
        /// <param name="pastDueTasks">pastDueTasks.</param>
        public TsiWebContactDetail(int? contactNumber = default(int?), TsiWebContact contact = default(TsiWebContact), List<TsiWebPhoneNumber> phoneNumbers = default(List<TsiWebPhoneNumber>), List<TsiWebEmailAddress> emailAddresses = default(List<TsiWebEmailAddress>), List<TsiWebAssignedMarketingGroup> groups = default(List<TsiWebAssignedMarketingGroup>), List<TsiWebAssignedMarketingProfile> profiles = default(List<TsiWebAssignedMarketingProfile>), TsiWebAccount account = default(TsiWebAccount), List<TsiWebCustomField> customFields = default(List<TsiWebCustomField>), bool? isPrimaryContact = default(bool?), int? journalEntries = default(int?), int? openOpportunities = default(int?), int? openServiceOrders = default(int?), int? pastDueTasks = default(int?))
        {
            this.ContactNumber = contactNumber;
            this.Contact = contact;
            this.PhoneNumbers = phoneNumbers;
            this.EmailAddresses = emailAddresses;
            this.Groups = groups;
            this.Profiles = profiles;
            this.Account = account;
            this.CustomFields = customFields;
            this.IsPrimaryContact = isPrimaryContact;
            this.JournalEntries = journalEntries;
            this.OpenOpportunities = openOpportunities;
            this.OpenServiceOrders = openServiceOrders;
            this.PastDueTasks = pastDueTasks;
        }
        
        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public int? ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public TsiWebContact Contact { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="PhoneNumbers", EmitDefaultValue=false)]
        public List<TsiWebPhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name="EmailAddresses", EmitDefaultValue=false)]
        public List<TsiWebEmailAddress> EmailAddresses { get; set; }

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
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public TsiWebAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="CustomFields", EmitDefaultValue=false)]
        public List<TsiWebCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets IsPrimaryContact
        /// </summary>
        [DataMember(Name="IsPrimaryContact", EmitDefaultValue=false)]
        public bool? IsPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets JournalEntries
        /// </summary>
        [DataMember(Name="JournalEntries", EmitDefaultValue=false)]
        public int? JournalEntries { get; set; }

        /// <summary>
        /// Gets or Sets OpenOpportunities
        /// </summary>
        [DataMember(Name="OpenOpportunities", EmitDefaultValue=false)]
        public int? OpenOpportunities { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebContactDetail {\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  IsPrimaryContact: ").Append(IsPrimaryContact).Append("\n");
            sb.Append("  JournalEntries: ").Append(JournalEntries).Append("\n");
            sb.Append("  OpenOpportunities: ").Append(OpenOpportunities).Append("\n");
            sb.Append("  OpenServiceOrders: ").Append(OpenServiceOrders).Append("\n");
            sb.Append("  PastDueTasks: ").Append(PastDueTasks).Append("\n");
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
            return this.Equals(input as TsiWebContactDetail);
        }

        /// <summary>
        /// Returns true if TsiWebContactDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebContactDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebContactDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
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
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.IsPrimaryContact == input.IsPrimaryContact ||
                    (this.IsPrimaryContact != null &&
                    this.IsPrimaryContact.Equals(input.IsPrimaryContact))
                ) && 
                (
                    this.JournalEntries == input.JournalEntries ||
                    (this.JournalEntries != null &&
                    this.JournalEntries.Equals(input.JournalEntries))
                ) && 
                (
                    this.OpenOpportunities == input.OpenOpportunities ||
                    (this.OpenOpportunities != null &&
                    this.OpenOpportunities.Equals(input.OpenOpportunities))
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
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.EmailAddresses != null)
                    hashCode = hashCode * 59 + this.EmailAddresses.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.IsPrimaryContact != null)
                    hashCode = hashCode * 59 + this.IsPrimaryContact.GetHashCode();
                if (this.JournalEntries != null)
                    hashCode = hashCode * 59 + this.JournalEntries.GetHashCode();
                if (this.OpenOpportunities != null)
                    hashCode = hashCode * 59 + this.OpenOpportunities.GetHashCode();
                if (this.OpenServiceOrders != null)
                    hashCode = hashCode * 59 + this.OpenServiceOrders.GetHashCode();
                if (this.PastDueTasks != null)
                    hashCode = hashCode * 59 + this.PastDueTasks.GetHashCode();
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
