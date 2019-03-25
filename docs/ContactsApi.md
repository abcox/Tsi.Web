# IO.Swagger.Api.ContactsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactsAdvancedSearch**](ContactsApi.md#contactsadvancedsearch) | **POST** /api/contacts/search | Advanced search for contacts.
[**ContactsCreateContact**](ContactsApi.md#contactscreatecontact) | **POST** /api/contacts | Creates the contact.
[**ContactsCreateContactJournalEntry**](ContactsApi.md#contactscreatecontactjournalentry) | **POST** /api/contacts/{contactNumber}/journalentries | Creates the contact journal entry.
[**ContactsCreateEmail**](ContactsApi.md#contactscreateemail) | **POST** /api/contacts/{contactNumber}/emails | Creates the email.
[**ContactsCreatePhoneNumber**](ContactsApi.md#contactscreatephonenumber) | **POST** /api/contacts/{contactNumber}/phonenumbers | Creates a contact phone number.
[**ContactsDeleteContactGroup**](ContactsApi.md#contactsdeletecontactgroup) | **DELETE** /api/contacts/{contactNumber}/marketing/groups | Deletes a group from the contact.
[**ContactsDeleteContactProfile**](ContactsApi.md#contactsdeletecontactprofile) | **DELETE** /api/contacts/{contactNumber}/marketing/profiles | Deletes a profile from the contact.
[**ContactsDeleteEmail**](ContactsApi.md#contactsdeleteemail) | **DELETE** /api/contacts/{contactNumber}/emails | Deletes the contact email.
[**ContactsDeletePhoneNumber**](ContactsApi.md#contactsdeletephonenumber) | **DELETE** /api/contacts/{contactNumber}/phonenumbers | Deletes the contact phone number.
[**ContactsGetAccountContacts**](ContactsApi.md#contactsgetaccountcontacts) | **GET** /api/contacts/account/{accountNumber} | Gets the account contacts.
[**ContactsGetAccountContacts_0**](ContactsApi.md#contactsgetaccountcontacts_0) | **GET** /api/contacts/account/{accountNumber}/{activeOnly} | Gets the account contacts.
[**ContactsGetAssignedGroups**](ContactsApi.md#contactsgetassignedgroups) | **GET** /api/contacts/{contactNumber}/marketing/groups | Gets a collection of groups assigned to the contact.
[**ContactsGetAssignedProfiles**](ContactsApi.md#contactsgetassignedprofiles) | **GET** /api/contacts/{contactNumber}/marketing/profiles | Gets a collection of profiles assigned to the contact.
[**ContactsGetContacTasks**](ContactsApi.md#contactsgetcontactasks) | **GET** /api/contacts/{ContactNumber}/tasks/all | Gets the Contact tasks.Includes both completed and incomplete tasks
[**ContactsGetContactCompletedTasks**](ContactsApi.md#contactsgetcontactcompletedtasks) | **GET** /api/contacts/{ContactNumber}/tasks/completed | Gets the Contact completed tasks.
[**ContactsGetContactDetail**](ContactsApi.md#contactsgetcontactdetail) | **GET** /api/contacts/{contactNumber}/details | Gets the contact detail.
[**ContactsGetContactDocuments**](ContactsApi.md#contactsgetcontactdocuments) | **GET** /api/contacts/{contactNumber}/documents | Gets the contact documents.
[**ContactsGetContactIncompleteTasks**](ContactsApi.md#contactsgetcontactincompletetasks) | **GET** /api/contacts/{ContactNumber}/tasks | Gets the Contact incomplete tasks.
[**ContactsGetContactJournalEntries**](ContactsApi.md#contactsgetcontactjournalentries) | **GET** /api/contacts/{contactNumber}/journalentries | Gets the contact journal entries.
[**ContactsGetContactJournalEntries_0**](ContactsApi.md#contactsgetcontactjournalentries_0) | **GET** /api/contacts/{contactNumber}/journalentries/{excludeSystemEntries} | Gets the contact journal entries.
[**ContactsGetContactSummary**](ContactsApi.md#contactsgetcontactsummary) | **GET** /api/contacts/{contactNumber} | Gets the contact summary.
[**ContactsGetCustomFields**](ContactsApi.md#contactsgetcustomfields) | **GET** /api/contacts/{contactNumber}/customfields | Gets the custom fields for the contact.
[**ContactsGetEmail**](ContactsApi.md#contactsgetemail) | **GET** /api/contacts/{contactNumber}/emails/{emailAddressID} | Gets the contact email address.
[**ContactsGetEmails**](ContactsApi.md#contactsgetemails) | **GET** /api/contacts/{contactNumber}/emails | Gets the contact email addresses.
[**ContactsGetPhoneNumber**](ContactsApi.md#contactsgetphonenumber) | **GET** /api/contacts/{contactNumber}/phonenumbers/{phoneNumberID} | Gets the contact phone number.
[**ContactsGetPhoneNumbers**](ContactsApi.md#contactsgetphonenumbers) | **GET** /api/contacts/{contactNumber}/phonenumbers | Gets the contact phone numbers.
[**ContactsLinkContact**](ContactsApi.md#contactslinkcontact) | **POST** /api/contacts/{contactNumber}/accounts/{accountNumber}/link | Links the existing contact to the account.
[**ContactsSearchByCustomField**](ContactsApi.md#contactssearchbycustomfield) | **POST** /api/contacts/search/customfield | Search Accounts using a custom category and field label.
[**ContactsSearchByEmail**](ContactsApi.md#contactssearchbyemail) | **POST** /api/contacts/search/email | Searches contacts by email.
[**ContactsSearchByFirstName**](ContactsApi.md#contactssearchbyfirstname) | **POST** /api/contacts/search/firstname | Searches contacts by first name.
[**ContactsSearchByFirstNameSoundsLike**](ContactsApi.md#contactssearchbyfirstnamesoundslike) | **POST** /api/contacts/search/firstname/soundslike | Searches contacts with the full name that sounds like.
[**ContactsSearchByLastName**](ContactsApi.md#contactssearchbylastname) | **POST** /api/contacts/search/lastname | Searches contacts by last name.
[**ContactsSearchByLastNameSoundsLike**](ContactsApi.md#contactssearchbylastnamesoundslike) | **POST** /api/contacts/search/lastname/soundslike | Searches contacts with the last name that sounds like.
[**ContactsSearchByPhoneNumber**](ContactsApi.md#contactssearchbyphonenumber) | **POST** /api/contacts/search/phone | Searches contacts by phone number.
[**ContactsSetAccountPrimaryContact**](ContactsApi.md#contactssetaccountprimarycontact) | **PUT** /api/contacts/{contactNumber}/account/{accountNumber}/primary | Sets the account primary contact.
[**ContactsSetContactGroup**](ContactsApi.md#contactssetcontactgroup) | **POST** /api/contacts/{contactNumber}/marketing/groups | Assigns a group to a contact.
[**ContactsSetContactProfile**](ContactsApi.md#contactssetcontactprofile) | **POST** /api/contacts/{contactNumber}/marketing/profiles | Assigns a profile to a contact.
[**ContactsSetPrimaryEmail**](ContactsApi.md#contactssetprimaryemail) | **PUT** /api/contacts/{contactNumber}/emails/{emailAddressID}/primary | Sets the primary contact email address.
[**ContactsSetPrimaryFaxNumber**](ContactsApi.md#contactssetprimaryfaxnumber) | **PUT** /api/contacts/{contactNumber}/phonenumbers/{phoneNumberID}/primaryfax | Sets the primary contact fax number.
[**ContactsSetPrimaryPhoneNumber**](ContactsApi.md#contactssetprimaryphonenumber) | **PUT** /api/contacts/{contactNumber}/phonenumbers/{phoneNumberID}/primaryphone | Sets the primary contact phone number.
[**ContactsUpdateContact**](ContactsApi.md#contactsupdatecontact) | **PUT** /api/contacts/{contactNumber} | Updates the contact.
[**ContactsUpdateCustomFields**](ContactsApi.md#contactsupdatecustomfields) | **PUT** /api/contacts/{contactNumber}/customfields | Updates the contacts custom fields.
[**ContactsUpdateEmail**](ContactsApi.md#contactsupdateemail) | **PUT** /api/contacts/{contactNumber}/emails/{emailAddressID} | Updates the email.
[**ContactsUpdatePhoneNumber**](ContactsApi.md#contactsupdatephonenumber) | **PUT** /api/contacts/{contactNumber}/phonenumbers/{phoneNumberID} | Changes a contact phone number.


<a name="contactsadvancedsearch"></a>
# **ContactsAdvancedSearch**
> TsiWebSearchContactResponse ContactsAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for contacts.

Valid SearchType = Firstname, LastName, Email, PhoneNumber, FirstNameSoundsLike, LastNameSoundsLike, AccountId, CustomField (requires CategoryName and CustomFieldName)  <p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for contacts.
                TsiWebSearchContactResponse result = apiInstance.ContactsAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsAdvancedSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebAdvancedSearchRequest**](TsiWebAdvancedSearchRequest.md)| An AdvancedSearchRequest | 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactscreatecontact"></a>
# **ContactsCreateContact**
> TsiWebContactResponse ContactsCreateContact (TsiWebCreateContactModel model)

Creates the contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsCreateContactExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var model = new TsiWebCreateContactModel(); // TsiWebCreateContactModel | The request.

            try
            {
                // Creates the contact.
                TsiWebContactResponse result = apiInstance.ContactsCreateContact(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsCreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateContactModel**](TsiWebCreateContactModel.md)| The request. | 

### Return type

[**TsiWebContactResponse**](TsiWebContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactscreatecontactjournalentry"></a>
# **ContactsCreateContactJournalEntry**
> TsiWebJournalEntryResponse ContactsCreateContactJournalEntry (int? contactNumber, TsiWebContactJournalEntryModel model)

Creates the contact journal entry.

Creates journal entries that will not be flagged as system genertated only.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsCreateContactJournalEntryExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var model = new TsiWebContactJournalEntryModel(); // TsiWebContactJournalEntryModel | The journal entry.

            try
            {
                // Creates the contact journal entry.
                TsiWebJournalEntryResponse result = apiInstance.ContactsCreateContactJournalEntry(contactNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsCreateContactJournalEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **model** | [**TsiWebContactJournalEntryModel**](TsiWebContactJournalEntryModel.md)| The journal entry. | 

### Return type

[**TsiWebJournalEntryResponse**](TsiWebJournalEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactscreateemail"></a>
# **ContactsCreateEmail**
> TsiWebEmailAddressResponse ContactsCreateEmail (int? contactNumber, TsiWebEmailAddress email)

Creates the email.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsCreateEmailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var email = new TsiWebEmailAddress(); // TsiWebEmailAddress | The email.

            try
            {
                // Creates the email.
                TsiWebEmailAddressResponse result = apiInstance.ContactsCreateEmail(contactNumber, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsCreateEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **email** | [**TsiWebEmailAddress**](TsiWebEmailAddress.md)| The email. | 

### Return type

[**TsiWebEmailAddressResponse**](TsiWebEmailAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactscreatephonenumber"></a>
# **ContactsCreatePhoneNumber**
> TsiWebPhoneNumberResponse ContactsCreatePhoneNumber (int? contactNumber, TsiWebPhoneNumber phoneNumber)

Creates a contact phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsCreatePhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var phoneNumber = new TsiWebPhoneNumber(); // TsiWebPhoneNumber | The phone number.

            try
            {
                // Creates a contact phone number.
                TsiWebPhoneNumberResponse result = apiInstance.ContactsCreatePhoneNumber(contactNumber, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsCreatePhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **phoneNumber** | [**TsiWebPhoneNumber**](TsiWebPhoneNumber.md)| The phone number. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsdeletecontactgroup"></a>
# **ContactsDeleteContactGroup**
> TsiWebResponse ContactsDeleteContactGroup (int? contactNumber, string id)

Deletes a group from the contact.

The group must be url encoded

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsDeleteContactGroupExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var id = id_example;  // string | The group to remove. (Must be url encoded)

            try
            {
                // Deletes a group from the contact.
                TsiWebResponse result = apiInstance.ContactsDeleteContactGroup(contactNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteContactGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **id** | **string**| The group to remove. (Must be url encoded) | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsdeletecontactprofile"></a>
# **ContactsDeleteContactProfile**
> TsiWebResponse ContactsDeleteContactProfile (int? contactNumber, string id)

Deletes a profile from the contact.

The profile must be url encoded

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsDeleteContactProfileExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var id = id_example;  // string | The profile to remove. (Must be url encoded)

            try
            {
                // Deletes a profile from the contact.
                TsiWebResponse result = apiInstance.ContactsDeleteContactProfile(contactNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteContactProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **id** | **string**| The profile to remove. (Must be url encoded) | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsdeleteemail"></a>
# **ContactsDeleteEmail**
> TsiWebResponse ContactsDeleteEmail (int? contactNumber, int? id)

Deletes the contact email.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsDeleteEmailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var id = 56;  // int? | The email address identifier.

            try
            {
                // Deletes the contact email.
                TsiWebResponse result = apiInstance.ContactsDeleteEmail(contactNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **id** | **int?**| The email address identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsdeletephonenumber"></a>
# **ContactsDeletePhoneNumber**
> TsiWebResponse ContactsDeletePhoneNumber (int? contactNumber, int? id)

Deletes the contact phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsDeletePhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Deletes the contact phone number.
                TsiWebResponse result = apiInstance.ContactsDeletePhoneNumber(contactNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeletePhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetaccountcontacts"></a>
# **ContactsGetAccountContacts**
> TsiWebSearchContactResponse ContactsGetAccountContacts (int? accountNumber, bool? activeOnly = null)

Gets the account contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetAccountContactsExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var accountNumber = 56;  // int? | The account identifier number.
            var activeOnly = true;  // bool? | If set to true returns only the active Contacts. (optional) 

            try
            {
                // Gets the account contacts.
                TsiWebSearchContactResponse result = apiInstance.ContactsGetAccountContacts(accountNumber, activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetAccountContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account identifier number. | 
 **activeOnly** | **bool?**| If set to true returns only the active Contacts. | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetaccountcontacts_0"></a>
# **ContactsGetAccountContacts_0**
> TsiWebSearchContactResponse ContactsGetAccountContacts_0 (int? accountNumber, bool? activeOnly)

Gets the account contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetAccountContacts_0Example
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var accountNumber = 56;  // int? | The account identifier number.
            var activeOnly = true;  // bool? | If set to true returns only the active Contacts.

            try
            {
                // Gets the account contacts.
                TsiWebSearchContactResponse result = apiInstance.ContactsGetAccountContacts_0(accountNumber, activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetAccountContacts_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account identifier number. | 
 **activeOnly** | **bool?**| If set to true returns only the active Contacts. | 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetassignedgroups"></a>
# **ContactsGetAssignedGroups**
> List<TsiWebAssignedMarketingGroup> ContactsGetAssignedGroups (int? contactNumber)

Gets a collection of groups assigned to the contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetAssignedGroupsExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.

            try
            {
                // Gets a collection of groups assigned to the contact.
                List&lt;TsiWebAssignedMarketingGroup&gt; result = apiInstance.ContactsGetAssignedGroups(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetAssignedGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 

### Return type

[**List<TsiWebAssignedMarketingGroup>**](TsiWebAssignedMarketingGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetassignedprofiles"></a>
# **ContactsGetAssignedProfiles**
> List<TsiWebAssignedMarketingProfile> ContactsGetAssignedProfiles (int? contactNumber)

Gets a collection of profiles assigned to the contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetAssignedProfilesExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.

            try
            {
                // Gets a collection of profiles assigned to the contact.
                List&lt;TsiWebAssignedMarketingProfile&gt; result = apiInstance.ContactsGetAssignedProfiles(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetAssignedProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 

### Return type

[**List<TsiWebAssignedMarketingProfile>**](TsiWebAssignedMarketingProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactasks"></a>
# **ContactsGetContacTasks**
> TsiWebTasksResponse ContactsGetContacTasks (int? contactNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Contact tasks.Includes both completed and incomplete tasks

If you are retrieving a private task and if you are not the owner, only the following the fields are retrieved.  <p>  AccountNumber, AccountName, ScheduledForRepNumber, ScheduledForRepName, StartDate, StartTime, WholeStartDateTime, EndDate, EndTime, WholeEnddateTime, IsPrivate  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContacTasksExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The Contact number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Contact tasks.Includes both completed and incomplete tasks
                TsiWebTasksResponse result = apiInstance.ContactsGetContacTasks(contactNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContacTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The Contact number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactcompletedtasks"></a>
# **ContactsGetContactCompletedTasks**
> TsiWebTasksResponse ContactsGetContactCompletedTasks (int? contactNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Contact completed tasks.

If you are retrieving a private task and if you are not the owner, only the following the fields are retrieved.  <p>  AccountNumber, AccountName, ScheduledForRepNumber, ScheduledForRepName, StartDate, StartTime, WholeStartDateTime, EndDate, EndTime, WholeEnddateTime, IsPrivate  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The Contact number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Contact completed tasks.
                TsiWebTasksResponse result = apiInstance.ContactsGetContactCompletedTasks(contactNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The Contact number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactdetail"></a>
# **ContactsGetContactDetail**
> TsiWebContactDetail ContactsGetContactDetail (int? contactNumber)

Gets the contact detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactDetailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact identifier number.

            try
            {
                // Gets the contact detail.
                TsiWebContactDetail result = apiInstance.ContactsGetContactDetail(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact identifier number. | 

### Return type

[**TsiWebContactDetail**](TsiWebContactDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactdocuments"></a>
# **ContactsGetContactDocuments**
> TsiWebDocumentsResponse ContactsGetContactDocuments (int? contactNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the contact documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactDocumentsExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the contact documents.
                TsiWebDocumentsResponse result = apiInstance.ContactsGetContactDocuments(contactNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebDocumentsResponse**](TsiWebDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactincompletetasks"></a>
# **ContactsGetContactIncompleteTasks**
> TsiWebTasksResponse ContactsGetContactIncompleteTasks (int? contactNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Contact incomplete tasks.

If you are retrieving a private task and if you are not the owner, only the following the fields are retrieved.  <p>  AccountNumber, AccountName, ScheduledForRepNumber, ScheduledForRepName, StartDate, StartTime, WholeStartDateTime, EndDate, EndTime, WholeEnddateTime, IsPrivate  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The Contact number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Contact incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ContactsGetContactIncompleteTasks(contactNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The Contact number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactjournalentries"></a>
# **ContactsGetContactJournalEntries**
> TsiWebJournalEntriesResponse ContactsGetContactJournalEntries (int? contactNumber, bool? excludeSystemEntries = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the contact journal entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactJournalEntriesExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var excludeSystemEntries = true;  // bool? | If false includes system entries. (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the contact journal entries.
                TsiWebJournalEntriesResponse result = apiInstance.ContactsGetContactJournalEntries(contactNumber, excludeSystemEntries, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactJournalEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **excludeSystemEntries** | **bool?**| If false includes system entries. | [optional] 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebJournalEntriesResponse**](TsiWebJournalEntriesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactjournalentries_0"></a>
# **ContactsGetContactJournalEntries_0**
> TsiWebJournalEntriesResponse ContactsGetContactJournalEntries_0 (int? contactNumber, bool? excludeSystemEntries, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the contact journal entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactJournalEntries_0Example
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var excludeSystemEntries = true;  // bool? | If false includes system entries.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the contact journal entries.
                TsiWebJournalEntriesResponse result = apiInstance.ContactsGetContactJournalEntries_0(contactNumber, excludeSystemEntries, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactJournalEntries_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **excludeSystemEntries** | **bool?**| If false includes system entries. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebJournalEntriesResponse**](TsiWebJournalEntriesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactsummary"></a>
# **ContactsGetContactSummary**
> TsiWebContactSummary ContactsGetContactSummary (int? contactNumber)

Gets the contact summary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactSummaryExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact identifier number.

            try
            {
                // Gets the contact summary.
                TsiWebContactSummary result = apiInstance.ContactsGetContactSummary(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact identifier number. | 

### Return type

[**TsiWebContactSummary**](TsiWebContactSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcustomfields"></a>
# **ContactsGetCustomFields**
> List<TsiWebCustomField> ContactsGetCustomFields (int? contactNumber)

Gets the custom fields for the contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.

            try
            {
                // Gets the custom fields for the contact.
                List&lt;TsiWebCustomField&gt; result = apiInstance.ContactsGetCustomFields(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetemail"></a>
# **ContactsGetEmail**
> TsiWebEmailAddress ContactsGetEmail (int? contactNumber, int? emailAddressID)

Gets the contact email address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetEmailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var emailAddressID = 56;  // int? | The email address identifier.

            try
            {
                // Gets the contact email address.
                TsiWebEmailAddress result = apiInstance.ContactsGetEmail(contactNumber, emailAddressID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **emailAddressID** | **int?**| The email address identifier. | 

### Return type

[**TsiWebEmailAddress**](TsiWebEmailAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetemails"></a>
# **ContactsGetEmails**
> List<TsiWebEmailAddress> ContactsGetEmails (int? contactNumber)

Gets the contact email addresses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetEmailsExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | 

            try
            {
                // Gets the contact email addresses.
                List&lt;TsiWebEmailAddress&gt; result = apiInstance.ContactsGetEmails(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**|  | 

### Return type

[**List<TsiWebEmailAddress>**](TsiWebEmailAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetphonenumber"></a>
# **ContactsGetPhoneNumber**
> TsiWebPhoneNumber ContactsGetPhoneNumber (int? contactNumber, int? phoneNumberID)

Gets the contact phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetPhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var phoneNumberID = 56;  // int? | The phone number identifier.

            try
            {
                // Gets the contact phone number.
                TsiWebPhoneNumber result = apiInstance.ContactsGetPhoneNumber(contactNumber, phoneNumberID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **phoneNumberID** | **int?**| The phone number identifier. | 

### Return type

[**TsiWebPhoneNumber**](TsiWebPhoneNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetphonenumbers"></a>
# **ContactsGetPhoneNumbers**
> List<TsiWebPhoneNumber> ContactsGetPhoneNumbers (int? contactNumber)

Gets the contact phone numbers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetPhoneNumbersExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | 

            try
            {
                // Gets the contact phone numbers.
                List&lt;TsiWebPhoneNumber&gt; result = apiInstance.ContactsGetPhoneNumbers(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetPhoneNumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**|  | 

### Return type

[**List<TsiWebPhoneNumber>**](TsiWebPhoneNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactslinkcontact"></a>
# **ContactsLinkContact**
> TsiWebContactResponse ContactsLinkContact (int? contactNumber, int? accountNumber)

Links the existing contact to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsLinkContactExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Links the existing contact to the account.
                TsiWebContactResponse result = apiInstance.ContactsLinkContact(contactNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsLinkContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebContactResponse**](TsiWebContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbycustomfield"></a>
# **ContactsSearchByCustomField**
> TsiWebSearchContactResponse ContactsSearchByCustomField (TsiWebCustomFieldSearchModel searchModel, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Accounts using a custom category and field label.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var searchModel = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Accounts using a custom category and field label.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByCustomField(searchModel, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchModel** | [**TsiWebCustomFieldSearchModel**](TsiWebCustomFieldSearchModel.md)|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbyemail"></a>
# **ContactsSearchByEmail**
> TsiWebSearchContactResponse ContactsSearchByEmail (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches contacts by email.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByEmailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var criteria = criteria_example;  // string | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches contacts by email.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByEmail(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbyfirstname"></a>
# **ContactsSearchByFirstName**
> TsiWebSearchContactResponse ContactsSearchByFirstName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches contacts by first name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByFirstNameExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var criteria = criteria_example;  // string | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches contacts by first name.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByFirstName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByFirstName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbyfirstnamesoundslike"></a>
# **ContactsSearchByFirstNameSoundsLike**
> TsiWebSearchContactResponse ContactsSearchByFirstNameSoundsLike (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches contacts with the full name that sounds like.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByFirstNameSoundsLikeExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var criteria = criteria_example;  // string | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches contacts with the full name that sounds like.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByFirstNameSoundsLike(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByFirstNameSoundsLike: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbylastname"></a>
# **ContactsSearchByLastName**
> TsiWebSearchContactResponse ContactsSearchByLastName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches contacts by last name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByLastNameExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var criteria = criteria_example;  // string | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches contacts by last name.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByLastName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByLastName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbylastnamesoundslike"></a>
# **ContactsSearchByLastNameSoundsLike**
> TsiWebSearchContactResponse ContactsSearchByLastNameSoundsLike (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches contacts with the last name that sounds like.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByLastNameSoundsLikeExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var criteria = criteria_example;  // string | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches contacts with the last name that sounds like.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByLastNameSoundsLike(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByLastNameSoundsLike: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssearchbyphonenumber"></a>
# **ContactsSearchByPhoneNumber**
> TsiWebSearchContactResponse ContactsSearchByPhoneNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches contacts by phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSearchByPhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var criteria = criteria_example;  // string | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches contacts by phone number.
                TsiWebSearchContactResponse result = apiInstance.ContactsSearchByPhoneNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSearchByPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssetaccountprimarycontact"></a>
# **ContactsSetAccountPrimaryContact**
> TsiWebContactResponse ContactsSetAccountPrimaryContact (int? contactNumber, int? accountNumber)

Sets the account primary contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSetAccountPrimaryContactExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact identifier number.
            var accountNumber = 56;  // int? | The account identifier number.

            try
            {
                // Sets the account primary contact.
                TsiWebContactResponse result = apiInstance.ContactsSetAccountPrimaryContact(contactNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetAccountPrimaryContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 

### Return type

[**TsiWebContactResponse**](TsiWebContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssetcontactgroup"></a>
# **ContactsSetContactGroup**
> TsiWebAssignedMarketingGroupsResponse ContactsSetContactGroup (int? contactNumber, string group)

Assigns a group to a contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSetContactGroupExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var group = group_example;  // string | The group to assign.

            try
            {
                // Assigns a group to a contact.
                TsiWebAssignedMarketingGroupsResponse result = apiInstance.ContactsSetContactGroup(contactNumber, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetContactGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **group** | **string**| The group to assign. | 

### Return type

[**TsiWebAssignedMarketingGroupsResponse**](TsiWebAssignedMarketingGroupsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssetcontactprofile"></a>
# **ContactsSetContactProfile**
> TsiWebAssignedMarketingProfilesResponse ContactsSetContactProfile (int? contactNumber, string profile)

Assigns a profile to a contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSetContactProfileExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var profile = profile_example;  // string | The profile to assign.

            try
            {
                // Assigns a profile to a contact.
                TsiWebAssignedMarketingProfilesResponse result = apiInstance.ContactsSetContactProfile(contactNumber, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetContactProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **profile** | **string**| The profile to assign. | 

### Return type

[**TsiWebAssignedMarketingProfilesResponse**](TsiWebAssignedMarketingProfilesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssetprimaryemail"></a>
# **ContactsSetPrimaryEmail**
> TsiWebEmailAddressResponse ContactsSetPrimaryEmail (int? contactNumber, int? emailAddressID)

Sets the primary contact email address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSetPrimaryEmailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var emailAddressID = 56;  // int? | The email address identifier.

            try
            {
                // Sets the primary contact email address.
                TsiWebEmailAddressResponse result = apiInstance.ContactsSetPrimaryEmail(contactNumber, emailAddressID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetPrimaryEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **emailAddressID** | **int?**| The email address identifier. | 

### Return type

[**TsiWebEmailAddressResponse**](TsiWebEmailAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssetprimaryfaxnumber"></a>
# **ContactsSetPrimaryFaxNumber**
> TsiWebPhoneNumberResponse ContactsSetPrimaryFaxNumber (int? contactNumber, int? phoneNumberID)

Sets the primary contact fax number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSetPrimaryFaxNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var phoneNumberID = 56;  // int? | The fax number identifier.

            try
            {
                // Sets the primary contact fax number.
                TsiWebPhoneNumberResponse result = apiInstance.ContactsSetPrimaryFaxNumber(contactNumber, phoneNumberID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetPrimaryFaxNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **phoneNumberID** | **int?**| The fax number identifier. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactssetprimaryphonenumber"></a>
# **ContactsSetPrimaryPhoneNumber**
> TsiWebPhoneNumberResponse ContactsSetPrimaryPhoneNumber (int? contactNumber, int? phoneNumberID)

Sets the primary contact phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsSetPrimaryPhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var phoneNumberID = 56;  // int? | The phone number identifier.

            try
            {
                // Sets the primary contact phone number.
                TsiWebPhoneNumberResponse result = apiInstance.ContactsSetPrimaryPhoneNumber(contactNumber, phoneNumberID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetPrimaryPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **phoneNumberID** | **int?**| The phone number identifier. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsupdatecontact"></a>
# **ContactsUpdateContact**
> TsiWebContactResponse ContactsUpdateContact (int? contactNumber, TsiWebContact contact)

Updates the contact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsUpdateContactExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var contact = new TsiWebContact(); // TsiWebContact | The contact.

            try
            {
                // Updates the contact.
                TsiWebContactResponse result = apiInstance.ContactsUpdateContact(contactNumber, contact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsUpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **contact** | [**TsiWebContact**](TsiWebContact.md)| The contact. | 

### Return type

[**TsiWebContactResponse**](TsiWebContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsupdatecustomfields"></a>
# **ContactsUpdateCustomFields**
> TsiWebCustomFieldsResponse ContactsUpdateCustomFields (int? contactNumber, List<TsiWebCustomField> customFields)

Updates the contacts custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.

            try
            {
                // Updates the contacts custom fields.
                TsiWebCustomFieldsResponse result = apiInstance.ContactsUpdateCustomFields(contactNumber, customFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsupdateemail"></a>
# **ContactsUpdateEmail**
> TsiWebEmailAddressResponse ContactsUpdateEmail (int? contactNumber, int? emailAddressID, TsiWebEmailAddress email)

Updates the email.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsUpdateEmailExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var emailAddressID = 56;  // int? | The email address identifier.
            var email = new TsiWebEmailAddress(); // TsiWebEmailAddress | The email.

            try
            {
                // Updates the email.
                TsiWebEmailAddressResponse result = apiInstance.ContactsUpdateEmail(contactNumber, emailAddressID, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsUpdateEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **emailAddressID** | **int?**| The email address identifier. | 
 **email** | [**TsiWebEmailAddress**](TsiWebEmailAddress.md)| The email. | 

### Return type

[**TsiWebEmailAddressResponse**](TsiWebEmailAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsupdatephonenumber"></a>
# **ContactsUpdatePhoneNumber**
> TsiWebPhoneNumberResponse ContactsUpdatePhoneNumber (int? contactNumber, int? phoneNumberID, TsiWebPhoneNumber phoneNumber)

Changes a contact phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsUpdatePhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new ContactsApi();
            var contactNumber = 56;  // int? | The contact number.
            var phoneNumberID = 56;  // int? | The phone number identifier.
            var phoneNumber = new TsiWebPhoneNumber(); // TsiWebPhoneNumber | The phone number.

            try
            {
                // Changes a contact phone number.
                TsiWebPhoneNumberResponse result = apiInstance.ContactsUpdatePhoneNumber(contactNumber, phoneNumberID, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsUpdatePhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 
 **phoneNumberID** | **int?**| The phone number identifier. | 
 **phoneNumber** | [**TsiWebPhoneNumber**](TsiWebPhoneNumber.md)| The phone number. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

