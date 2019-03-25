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
    /// TsiWebQuoteNoteSummary
    /// </summary>
    [DataContract]
    public partial class TsiWebQuoteNoteSummary :  IEquatable<TsiWebQuoteNoteSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsiWebQuoteNoteSummary" /> class.
        /// </summary>
        /// <param name="contact">contact.</param>
        /// <param name="rep">rep.</param>
        /// <param name="quoteNoteNumber">quoteNoteNumber.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="repNumber">repNumber.</param>
        /// <param name="topic">topic.</param>
        /// <param name="note">note.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="noteDate">noteDate.</param>
        public TsiWebQuoteNoteSummary(TsiWebPerson contact = default(TsiWebPerson), TsiWebPerson rep = default(TsiWebPerson), int? quoteNoteNumber = default(int?), int? contactNumber = default(int?), int? repNumber = default(int?), string topic = default(string), string note = default(string), DateTime? dateCreated = default(DateTime?), DateTime? noteDate = default(DateTime?))
        {
            this.Contact = contact;
            this.Rep = rep;
            this.QuoteNoteNumber = quoteNoteNumber;
            this.ContactNumber = contactNumber;
            this.RepNumber = repNumber;
            this.Topic = topic;
            this.Note = note;
            this.DateCreated = dateCreated;
            this.NoteDate = noteDate;
        }
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public TsiWebPerson Contact { get; set; }

        /// <summary>
        /// Gets or Sets Rep
        /// </summary>
        [DataMember(Name="Rep", EmitDefaultValue=false)]
        public TsiWebPerson Rep { get; set; }

        /// <summary>
        /// Gets or Sets QuoteNoteNumber
        /// </summary>
        [DataMember(Name="QuoteNoteNumber", EmitDefaultValue=false)]
        public int? QuoteNoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public int? ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets RepNumber
        /// </summary>
        [DataMember(Name="RepNumber", EmitDefaultValue=false)]
        public int? RepNumber { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="Topic", EmitDefaultValue=false)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="Note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="DateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets NoteDate
        /// </summary>
        [DataMember(Name="NoteDate", EmitDefaultValue=false)]
        public DateTime? NoteDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiWebQuoteNoteSummary {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Rep: ").Append(Rep).Append("\n");
            sb.Append("  QuoteNoteNumber: ").Append(QuoteNoteNumber).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  RepNumber: ").Append(RepNumber).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  NoteDate: ").Append(NoteDate).Append("\n");
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
            return this.Equals(input as TsiWebQuoteNoteSummary);
        }

        /// <summary>
        /// Returns true if TsiWebQuoteNoteSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TsiWebQuoteNoteSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiWebQuoteNoteSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Rep == input.Rep ||
                    (this.Rep != null &&
                    this.Rep.Equals(input.Rep))
                ) && 
                (
                    this.QuoteNoteNumber == input.QuoteNoteNumber ||
                    (this.QuoteNoteNumber != null &&
                    this.QuoteNoteNumber.Equals(input.QuoteNoteNumber))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.RepNumber == input.RepNumber ||
                    (this.RepNumber != null &&
                    this.RepNumber.Equals(input.RepNumber))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.NoteDate == input.NoteDate ||
                    (this.NoteDate != null &&
                    this.NoteDate.Equals(input.NoteDate))
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Rep != null)
                    hashCode = hashCode * 59 + this.Rep.GetHashCode();
                if (this.QuoteNoteNumber != null)
                    hashCode = hashCode * 59 + this.QuoteNoteNumber.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.RepNumber != null)
                    hashCode = hashCode * 59 + this.RepNumber.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.NoteDate != null)
                    hashCode = hashCode * 59 + this.NoteDate.GetHashCode();
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
