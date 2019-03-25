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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tsi.Web.Client;
using Tsi.Web.Api;
using Tsi.Web.Model;

namespace Tsi.Web.Test
{
    /// <summary>
    ///  Class for testing ContactsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class ContactsApiTests
    {
        private ContactsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new ContactsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactsApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContactsApi
            //Assert.IsInstanceOfType(typeof(ContactsApi), instance, "instance is a ContactsApi");
        }

        
        /// <summary>
        /// Test ContactsAdvancedSearch
        /// </summary>
        [TestMethod]
        public void ContactsAdvancedSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebAdvancedSearchRequest request = null;
            //var response = instance.ContactsAdvancedSearch(request);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsCreateContact
        /// </summary>
        [TestMethod]
        public void ContactsCreateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebCreateContactModel model = null;
            //var response = instance.ContactsCreateContact(model);
            //Assert.IsInstanceOf<TsiWebContactResponse> (response, "response is TsiWebContactResponse");
        }
        
        /// <summary>
        /// Test ContactsCreateContactJournalEntry
        /// </summary>
        [TestMethod]
        public void ContactsCreateContactJournalEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //TsiWebContactJournalEntryModel model = null;
            //var response = instance.ContactsCreateContactJournalEntry(contactNumber, model);
            //Assert.IsInstanceOf<TsiWebJournalEntryResponse> (response, "response is TsiWebJournalEntryResponse");
        }
        
        /// <summary>
        /// Test ContactsCreateEmail
        /// </summary>
        [TestMethod]
        public void ContactsCreateEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //TsiWebEmailAddress email = null;
            //var response = instance.ContactsCreateEmail(contactNumber, email);
            //Assert.IsInstanceOf<TsiWebEmailAddressResponse> (response, "response is TsiWebEmailAddressResponse");
        }
        
        /// <summary>
        /// Test ContactsCreatePhoneNumber
        /// </summary>
        [TestMethod]
        public void ContactsCreatePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //TsiWebPhoneNumber phoneNumber = null;
            //var response = instance.ContactsCreatePhoneNumber(contactNumber, phoneNumber);
            //Assert.IsInstanceOf<TsiWebPhoneNumberResponse> (response, "response is TsiWebPhoneNumberResponse");
        }
        
        /// <summary>
        /// Test ContactsDeleteContactGroup
        /// </summary>
        [TestMethod]
        public void ContactsDeleteContactGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //string id = null;
            //var response = instance.ContactsDeleteContactGroup(contactNumber, id);
            //Assert.IsInstanceOf<TsiWebResponse> (response, "response is TsiWebResponse");
        }
        
        /// <summary>
        /// Test ContactsDeleteContactProfile
        /// </summary>
        [TestMethod]
        public void ContactsDeleteContactProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //string id = null;
            //var response = instance.ContactsDeleteContactProfile(contactNumber, id);
            //Assert.IsInstanceOf<TsiWebResponse> (response, "response is TsiWebResponse");
        }
        
        /// <summary>
        /// Test ContactsDeleteEmail
        /// </summary>
        [TestMethod]
        public void ContactsDeleteEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? id = null;
            //var response = instance.ContactsDeleteEmail(contactNumber, id);
            //Assert.IsInstanceOf<TsiWebResponse> (response, "response is TsiWebResponse");
        }
        
        /// <summary>
        /// Test ContactsDeletePhoneNumber
        /// </summary>
        [TestMethod]
        public void ContactsDeletePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? id = null;
            //var response = instance.ContactsDeletePhoneNumber(contactNumber, id);
            //Assert.IsInstanceOf<TsiWebResponse> (response, "response is TsiWebResponse");
        }
        
        /// <summary>
        /// Test ContactsGetAccountContacts
        /// </summary>
        [TestMethod]
        public void ContactsGetAccountContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountNumber = null;
            //bool? activeOnly = null;
            //var response = instance.ContactsGetAccountContacts(accountNumber, activeOnly);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsGetAccountContacts_0
        /// </summary>
        [TestMethod]
        public void ContactsGetAccountContacts_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountNumber = null;
            //bool? activeOnly = null;
            //var response = instance.ContactsGetAccountContacts_0(accountNumber, activeOnly);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsGetAssignedGroups
        /// </summary>
        [TestMethod]
        public void ContactsGetAssignedGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetAssignedGroups(contactNumber);
            //Assert.IsInstanceOf<List<TsiWebAssignedMarketingGroup>> (response, "response is List<TsiWebAssignedMarketingGroup>");
        }
        
        /// <summary>
        /// Test ContactsGetAssignedProfiles
        /// </summary>
        [TestMethod]
        public void ContactsGetAssignedProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetAssignedProfiles(contactNumber);
            //Assert.IsInstanceOf<List<TsiWebAssignedMarketingProfile>> (response, "response is List<TsiWebAssignedMarketingProfile>");
        }
        
        /// <summary>
        /// Test ContactsGetContacTasks
        /// </summary>
        [TestMethod]
        public void ContactsGetContacTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsGetContacTasks(contactNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test ContactsGetContactCompletedTasks
        /// </summary>
        [TestMethod]
        public void ContactsGetContactCompletedTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsGetContactCompletedTasks(contactNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test ContactsGetContactDetail
        /// </summary>
        [TestMethod]
        public void ContactsGetContactDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetContactDetail(contactNumber);
            //Assert.IsInstanceOf<TsiWebContactDetail> (response, "response is TsiWebContactDetail");
        }
        
        /// <summary>
        /// Test ContactsGetContactDocuments
        /// </summary>
        [TestMethod]
        public void ContactsGetContactDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsGetContactDocuments(contactNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebDocumentsResponse> (response, "response is TsiWebDocumentsResponse");
        }
        
        /// <summary>
        /// Test ContactsGetContactIncompleteTasks
        /// </summary>
        [TestMethod]
        public void ContactsGetContactIncompleteTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsGetContactIncompleteTasks(contactNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test ContactsGetContactJournalEntries
        /// </summary>
        [TestMethod]
        public void ContactsGetContactJournalEntriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //bool? excludeSystemEntries = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsGetContactJournalEntries(contactNumber, excludeSystemEntries, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebJournalEntriesResponse> (response, "response is TsiWebJournalEntriesResponse");
        }
        
        /// <summary>
        /// Test ContactsGetContactJournalEntries_0
        /// </summary>
        [TestMethod]
        public void ContactsGetContactJournalEntries_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //bool? excludeSystemEntries = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsGetContactJournalEntries_0(contactNumber, excludeSystemEntries, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebJournalEntriesResponse> (response, "response is TsiWebJournalEntriesResponse");
        }
        
        /// <summary>
        /// Test ContactsGetContactSummary
        /// </summary>
        [TestMethod]
        public void ContactsGetContactSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetContactSummary(contactNumber);
            //Assert.IsInstanceOf<TsiWebContactSummary> (response, "response is TsiWebContactSummary");
        }
        
        /// <summary>
        /// Test ContactsGetCustomFields
        /// </summary>
        [TestMethod]
        public void ContactsGetCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetCustomFields(contactNumber);
            //Assert.IsInstanceOf<List<TsiWebCustomField>> (response, "response is List<TsiWebCustomField>");
        }
        
        /// <summary>
        /// Test ContactsGetEmail
        /// </summary>
        [TestMethod]
        public void ContactsGetEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? emailAddressID = null;
            //var response = instance.ContactsGetEmail(contactNumber, emailAddressID);
            //Assert.IsInstanceOf<TsiWebEmailAddress> (response, "response is TsiWebEmailAddress");
        }
        
        /// <summary>
        /// Test ContactsGetEmails
        /// </summary>
        [TestMethod]
        public void ContactsGetEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetEmails(contactNumber);
            //Assert.IsInstanceOf<List<TsiWebEmailAddress>> (response, "response is List<TsiWebEmailAddress>");
        }
        
        /// <summary>
        /// Test ContactsGetPhoneNumber
        /// </summary>
        [TestMethod]
        public void ContactsGetPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? phoneNumberID = null;
            //var response = instance.ContactsGetPhoneNumber(contactNumber, phoneNumberID);
            //Assert.IsInstanceOf<TsiWebPhoneNumber> (response, "response is TsiWebPhoneNumber");
        }
        
        /// <summary>
        /// Test ContactsGetPhoneNumbers
        /// </summary>
        [TestMethod]
        public void ContactsGetPhoneNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.ContactsGetPhoneNumbers(contactNumber);
            //Assert.IsInstanceOf<List<TsiWebPhoneNumber>> (response, "response is List<TsiWebPhoneNumber>");
        }
        
        /// <summary>
        /// Test ContactsLinkContact
        /// </summary>
        [TestMethod]
        public void ContactsLinkContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? accountNumber = null;
            //var response = instance.ContactsLinkContact(contactNumber, accountNumber);
            //Assert.IsInstanceOf<TsiWebContactResponse> (response, "response is TsiWebContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByCustomField
        /// </summary>
        [TestMethod]
        public void ContactsSearchByCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebCustomFieldSearchModel searchModel = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByCustomField(searchModel, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByEmail
        /// </summary>
        [TestMethod]
        public void ContactsSearchByEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByEmail(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByFirstName
        /// </summary>
        [TestMethod]
        public void ContactsSearchByFirstNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByFirstName(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByFirstNameSoundsLike
        /// </summary>
        [TestMethod]
        public void ContactsSearchByFirstNameSoundsLikeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByFirstNameSoundsLike(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByLastName
        /// </summary>
        [TestMethod]
        public void ContactsSearchByLastNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByLastName(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByLastNameSoundsLike
        /// </summary>
        [TestMethod]
        public void ContactsSearchByLastNameSoundsLikeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByLastNameSoundsLike(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSearchByPhoneNumber
        /// </summary>
        [TestMethod]
        public void ContactsSearchByPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.ContactsSearchByPhoneNumber(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSetAccountPrimaryContact
        /// </summary>
        [TestMethod]
        public void ContactsSetAccountPrimaryContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? accountNumber = null;
            //var response = instance.ContactsSetAccountPrimaryContact(contactNumber, accountNumber);
            //Assert.IsInstanceOf<TsiWebContactResponse> (response, "response is TsiWebContactResponse");
        }
        
        /// <summary>
        /// Test ContactsSetContactGroup
        /// </summary>
        [TestMethod]
        public void ContactsSetContactGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //string group = null;
            //var response = instance.ContactsSetContactGroup(contactNumber, group);
            //Assert.IsInstanceOf<TsiWebAssignedMarketingGroupsResponse> (response, "response is TsiWebAssignedMarketingGroupsResponse");
        }
        
        /// <summary>
        /// Test ContactsSetContactProfile
        /// </summary>
        [TestMethod]
        public void ContactsSetContactProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //string profile = null;
            //var response = instance.ContactsSetContactProfile(contactNumber, profile);
            //Assert.IsInstanceOf<TsiWebAssignedMarketingProfilesResponse> (response, "response is TsiWebAssignedMarketingProfilesResponse");
        }
        
        /// <summary>
        /// Test ContactsSetPrimaryEmail
        /// </summary>
        [TestMethod]
        public void ContactsSetPrimaryEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? emailAddressID = null;
            //var response = instance.ContactsSetPrimaryEmail(contactNumber, emailAddressID);
            //Assert.IsInstanceOf<TsiWebEmailAddressResponse> (response, "response is TsiWebEmailAddressResponse");
        }
        
        /// <summary>
        /// Test ContactsSetPrimaryFaxNumber
        /// </summary>
        [TestMethod]
        public void ContactsSetPrimaryFaxNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? phoneNumberID = null;
            //var response = instance.ContactsSetPrimaryFaxNumber(contactNumber, phoneNumberID);
            //Assert.IsInstanceOf<TsiWebPhoneNumberResponse> (response, "response is TsiWebPhoneNumberResponse");
        }
        
        /// <summary>
        /// Test ContactsSetPrimaryPhoneNumber
        /// </summary>
        [TestMethod]
        public void ContactsSetPrimaryPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? phoneNumberID = null;
            //var response = instance.ContactsSetPrimaryPhoneNumber(contactNumber, phoneNumberID);
            //Assert.IsInstanceOf<TsiWebPhoneNumberResponse> (response, "response is TsiWebPhoneNumberResponse");
        }
        
        /// <summary>
        /// Test ContactsUpdateContact
        /// </summary>
        [TestMethod]
        public void ContactsUpdateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //TsiWebContact contact = null;
            //var response = instance.ContactsUpdateContact(contactNumber, contact);
            //Assert.IsInstanceOf<TsiWebContactResponse> (response, "response is TsiWebContactResponse");
        }
        
        /// <summary>
        /// Test ContactsUpdateCustomFields
        /// </summary>
        [TestMethod]
        public void ContactsUpdateCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //List<TsiWebCustomField> customFields = null;
            //var response = instance.ContactsUpdateCustomFields(contactNumber, customFields);
            //Assert.IsInstanceOf<TsiWebCustomFieldsResponse> (response, "response is TsiWebCustomFieldsResponse");
        }
        
        /// <summary>
        /// Test ContactsUpdateEmail
        /// </summary>
        [TestMethod]
        public void ContactsUpdateEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? emailAddressID = null;
            //TsiWebEmailAddress email = null;
            //var response = instance.ContactsUpdateEmail(contactNumber, emailAddressID, email);
            //Assert.IsInstanceOf<TsiWebEmailAddressResponse> (response, "response is TsiWebEmailAddressResponse");
        }
        
        /// <summary>
        /// Test ContactsUpdatePhoneNumber
        /// </summary>
        [TestMethod]
        public void ContactsUpdatePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //int? phoneNumberID = null;
            //TsiWebPhoneNumber phoneNumber = null;
            //var response = instance.ContactsUpdatePhoneNumber(contactNumber, phoneNumberID, phoneNumber);
            //Assert.IsInstanceOf<TsiWebPhoneNumberResponse> (response, "response is TsiWebPhoneNumberResponse");
        }
        
    }

}