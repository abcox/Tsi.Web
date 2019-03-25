# IO.Swagger.Api.AccountsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAdvancedSearch**](AccountsApi.md#accountsadvancedsearch) | **POST** /api/accounts/search | Advanced search for accounts.
[**AccountsCreateAccount**](AccountsApi.md#accountscreateaccount) | **POST** /api/accounts | Creates a new account.
[**AccountsCreateAccountDocument**](AccountsApi.md#accountscreateaccountdocument) | **POST** /api/accounts/{accountNumber}/documents | Creates the account document.
[**AccountsCreateAccountExternalProduct**](AccountsApi.md#accountscreateaccountexternalproduct) | **POST** /api/accounts/{accountNumber}/service/externalproducts | Creates account external product.
[**AccountsCreateAccountJournalEntry**](AccountsApi.md#accountscreateaccountjournalentry) | **POST** /api/accounts/{accountNumber}/journalentries | Creates the account journal entry.
[**AccountsCreateBillTo**](AccountsApi.md#accountscreatebillto) | **POST** /api/accounts/{accountNumber}/accounting/billtos | Creates the bill to.
[**AccountsCreatePhoneNumber**](AccountsApi.md#accountscreatephonenumber) | **POST** /api/accounts/{accountNumber}/phonenumbers | Create an account phone number.
[**AccountsCreateShipTo**](AccountsApi.md#accountscreateshipto) | **POST** /api/accounts/{accountNumber}/accounting/shiptos | Creates new alternate ship to or updates an existing ship to for the account.
[**AccountsDeleteAccountExternalProduct**](AccountsApi.md#accountsdeleteaccountexternalproduct) | **DELETE** /api/accounts/{accountNumber}/service/externalproducts | Removes the external product from the account.
[**AccountsDeleteAccountGroup**](AccountsApi.md#accountsdeleteaccountgroup) | **DELETE** /api/accounts/{accountNumber}/marketing/groups | Deletes a group from the account.
[**AccountsDeleteAccountProfile**](AccountsApi.md#accountsdeleteaccountprofile) | **DELETE** /api/accounts/{accountNumber}/marketing/profiles | Deletes a profile from the account.
[**AccountsDeleteAccountSICCodes**](AccountsApi.md#accountsdeleteaccountsiccodes) | **DELETE** /api/accounts/{accountNumber}/marketing/siccodes | Deletes a SIC code from the account.
[**AccountsDeleteAccountSystem**](AccountsApi.md#accountsdeleteaccountsystem) | **DELETE** /api/accounts/{accountNumber}/service/systems | Removes the system from the account.
[**AccountsDeleteBillTo**](AccountsApi.md#accountsdeletebillto) | **DELETE** /api/accounts/{accountNumber}/accounting/billtos | Removes the alternate bill to from the account.
[**AccountsDeletePhoneNumber**](AccountsApi.md#accountsdeletephonenumber) | **DELETE** /api/accounts/{accountNumber}/phonenumbers | Deletes the account phone number.
[**AccountsDeleteShipTo**](AccountsApi.md#accountsdeleteshipto) | **DELETE** /api/accounts/{accountNumber}/accounting/shiptos | Removes the alternate ship to from the account.
[**AccountsDeleteTechFromAccountGroup**](AccountsApi.md#accountsdeletetechfromaccountgroup) | **DELETE** /api/accounts/service/comanagedtechs/{repnumber} | Deletes the tech from the account group.
[**AccountsGetAccountCoManagedTechs**](AccountsApi.md#accountsgetaccountcomanagedtechs) | **GET** /api/accounts/{accountNumber}/service/comanagedtechs | Gets a collection of Co-Managed Direct techs assigned to the account.
[**AccountsGetAccountCompletedTasks**](AccountsApi.md#accountsgetaccountcompletedtasks) | **GET** /api/accounts/{accountNumber}/tasks/completed | Gets account completed tasks
[**AccountsGetAccountCustomerAssets**](AccountsApi.md#accountsgetaccountcustomerassets) | **GET** /api/accounts/{accountNumber}/assets/customer | Gets the account customer assets.
[**AccountsGetAccountDetails**](AccountsApi.md#accountsgetaccountdetails) | **GET** /api/accounts/{accountNumber}/details | Gets the account details by account number.
[**AccountsGetAccountDocument**](AccountsApi.md#accountsgetaccountdocument) | **GET** /api/accounts/{accountNumber}/documents/{documentID} | Gets the account document with the file bytes.
[**AccountsGetAccountDocuments**](AccountsApi.md#accountsgetaccountdocuments) | **GET** /api/accounts/{accountNumber}/documents | Gets the account documents.
[**AccountsGetAccountDocuments_0**](AccountsApi.md#accountsgetaccountdocuments_0) | **GET** /api/accounts/{accountNumber}/documents/{accountOnly} | Gets the account documents.
[**AccountsGetAccountExternalProduct**](AccountsApi.md#accountsgetaccountexternalproduct) | **GET** /api/accounts/{accountNumber}/service/externalproducts/{accountExternalProductID} | Gets account external product by ID.
[**AccountsGetAccountExternalProducts**](AccountsApi.md#accountsgetaccountexternalproducts) | **GET** /api/accounts/{accountNumber}/service/externalproducts | Gets a collection of associated external products for the account.
[**AccountsGetAccountIncompleteTasks**](AccountsApi.md#accountsgetaccountincompletetasks) | **GET** /api/accounts/{accountNumber}/tasks | Gets account incomplete tasks
[**AccountsGetAccountJournalEntries**](AccountsApi.md#accountsgetaccountjournalentries) | **GET** /api/accounts/{accountNumber}/journalentries | Gets the account journal entries.
[**AccountsGetAccountJournalEntries_0**](AccountsApi.md#accountsgetaccountjournalentries_0) | **GET** /api/accounts/{accountNumber}/journalentries/{excludeSystemEntries} | Gets the account journal entries.
[**AccountsGetAccountManagedAssets**](AccountsApi.md#accountsgetaccountmanagedassets) | **GET** /api/accounts/{accountNumber}/assets/managed | Gets the account managed assets.
[**AccountsGetAccountOnlyCompletedTasks**](AccountsApi.md#accountsgetaccountonlycompletedtasks) | **GET** /api/accounts/{accountNumber}/tasks/accountonly/completed | Gets the account only completed tasks.
[**AccountsGetAccountOnlyIncompleteTasks**](AccountsApi.md#accountsgetaccountonlyincompletetasks) | **GET** /api/accounts/{accountNumber}/tasks/accountonly | Gets the account only incomplete tasks.
[**AccountsGetAccountOnlyTasks**](AccountsApi.md#accountsgetaccountonlytasks) | **GET** /api/accounts/{accountNumber}/tasks/accountonly/all | Gets the account only tasks. Includes both completed and imcomplete tasks.
[**AccountsGetAccountSummary**](AccountsApi.md#accountsgetaccountsummary) | **GET** /api/accounts/{accountNumber} | Gets the account summary by account number.
[**AccountsGetAccountSystems**](AccountsApi.md#accountsgetaccountsystems) | **GET** /api/accounts/{accountNumber}/service/systems | Gets a collection of systems assigned to the account.
[**AccountsGetAccountTasks**](AccountsApi.md#accountsgetaccounttasks) | **GET** /api/accounts/{accountNumber}/tasks/all | Gets account tasks. includes both completed and incomplete tasks
[**AccountsGetAccountingDetails**](AccountsApi.md#accountsgetaccountingdetails) | **GET** /api/accounts/{accountNumber}/accounting | Gets the accounting details for the account.
[**AccountsGetAssignedGroups**](AccountsApi.md#accountsgetassignedgroups) | **GET** /api/accounts/{accountNumber}/marketing/groups | Gets a collection of groups assigned to the account.
[**AccountsGetAssignedProfiles**](AccountsApi.md#accountsgetassignedprofiles) | **GET** /api/accounts/{accountNumber}/marketing/profiles | Gets a collection of profiles assigned to the account.
[**AccountsGetAssignedSICCodes**](AccountsApi.md#accountsgetassignedsiccodes) | **GET** /api/accounts/{accountNumber}/marketing/siccodes | Gets a collection of SIC codes assigned to the account.
[**AccountsGetBillTo**](AccountsApi.md#accountsgetbillto) | **GET** /api/accounts/{accountNumber}/accounting/billtos/{billToID} | Gets the alternate bill to for the account by ID.
[**AccountsGetBillTos**](AccountsApi.md#accountsgetbilltos) | **GET** /api/accounts/{accountNumber}/accounting/billtos | Gets a collection of alternate bill tos for the account.
[**AccountsGetCustomFields**](AccountsApi.md#accountsgetcustomfields) | **GET** /api/accounts/{accountNumber}/customfields | Gets the custom fields for the account.
[**AccountsGetFile**](AccountsApi.md#accountsgetfile) | **GET** /api/accounts/{accountNumber}/documents/{documentID}/file | Gets the account document file.
[**AccountsGetMarketingDetails**](AccountsApi.md#accountsgetmarketingdetails) | **GET** /api/accounts/{accountNumber}/marketing | Gets the account marketing details.
[**AccountsGetPayMethod**](AccountsApi.md#accountsgetpaymethod) | **GET** /api/accounts/{accountNumber}/accounting/paymethods/{payMethodID} | Gets the pay method for the account by ID.
[**AccountsGetPayMethods**](AccountsApi.md#accountsgetpaymethods) | **GET** /api/accounts/{accountNumber}/accounting/paymethods | Gets a collection of pay methods for the account.
[**AccountsGetPhoneNumber**](AccountsApi.md#accountsgetphonenumber) | **GET** /api/accounts/{accountNumber}/phonenumbers/{phoneNumberID} | Gets the account phone number.
[**AccountsGetPhoneNumbers**](AccountsApi.md#accountsgetphonenumbers) | **GET** /api/accounts/{accountNumber}/phonenumbers | Gets the account phone numbers.
[**AccountsGetServiceDetails**](AccountsApi.md#accountsgetservicedetails) | **GET** /api/accounts/{accountNumber}/service | Gets the service details for an account.
[**AccountsGetShipTo**](AccountsApi.md#accountsgetshipto) | **GET** /api/accounts/{accountNumber}/accounting/shiptos/{shipToID} | Gets the alternate ship to for the account by ID.
[**AccountsGetShipTos**](AccountsApi.md#accountsgetshiptos) | **GET** /api/accounts/{accountNumber}/accounting/shiptos | Gets a collection of alternate ship tos for the account.
[**AccountsSaveAccountingDetails**](AccountsApi.md#accountssaveaccountingdetails) | **PUT** /api/accounts/{accountNumber}/accounting | Creates or updates accounting details for the account.
[**AccountsSaveMarketingDetails**](AccountsApi.md#accountssavemarketingdetails) | **PUT** /api/accounts/{accountNumber}/marketing | Update the account marketing details.
[**AccountsSaveServiceDetails**](AccountsApi.md#accountssaveservicedetails) | **PUT** /api/accounts/{accountNumber}/service | Updates the account service details.
[**AccountsSearchAccountsContactName**](AccountsApi.md#accountssearchaccountscontactname) | **POST** /api/accounts/search/contact/name | Search Accounts using contact name.
[**AccountsSearchAccountsCustomField**](AccountsApi.md#accountssearchaccountscustomfield) | **POST** /api/accounts/search/customfield | Search Accounts using a custom category and field label.
[**AccountsSearchAccountsSoundsLikeName**](AccountsApi.md#accountssearchaccountssoundslikename) | **POST** /api/accounts/search/name/soundslike | Searches the name of the accounts that sound like the criteria provided.
[**AccountsSearchByAccountId**](AccountsApi.md#accountssearchbyaccountid) | **POST** /api/accounts/search/accountid | Search accounts by the user specified identifier.
[**AccountsSearchByAccountNumber**](AccountsApi.md#accountssearchbyaccountnumber) | **POST** /api/accounts/search/accountnumber | Search accounts by number.
[**AccountsSearchByAccountStatus**](AccountsApi.md#accountssearchbyaccountstatus) | **POST** /api/accounts/search/accountstatus | Search accounts by Account Status.
[**AccountsSearchByAccountType**](AccountsApi.md#accountssearchbyaccounttype) | **POST** /api/accounts/search/accounttype | Search accounts by Account Type.
[**AccountsSearchByAddress**](AccountsApi.md#accountssearchbyaddress) | **POST** /api/accounts/search/address | Search accounts by address.
[**AccountsSearchByAgreement**](AccountsApi.md#accountssearchbyagreement) | **POST** /api/accounts/search/agreement | Search accounts by MSP Agreement .
[**AccountsSearchByEmail**](AccountsApi.md#accountssearchbyemail) | **POST** /api/accounts/search/email | Search accounts using all email addresses associated to the account and its contacts.
[**AccountsSearchByExternalId**](AccountsApi.md#accountssearchbyexternalid) | **POST** /api/accounts/search/externalid | Search accounts using the External ID related to .
[**AccountsSearchByName**](AccountsApi.md#accountssearchbyname) | **POST** /api/accounts/search/name | Search accounts by name.
[**AccountsSearchByPhone**](AccountsApi.md#accountssearchbyphone) | **POST** /api/accounts/search/phone | Search accounts using all phone numbers associated to the account and its contacts.
[**AccountsSearchByPostalCode**](AccountsApi.md#accountssearchbypostalcode) | **POST** /api/accounts/search/postalcode | Search accounts by postal code.
[**AccountsSetAccountDocumentFile**](AccountsApi.md#accountssetaccountdocumentfile) | **PUT** /api/accounts/{accountNumber}/documents/{documentID}/overwrite | Overwrites the account document physical file, does not rename the file.
[**AccountsSetAccountDocumentFileName**](AccountsApi.md#accountssetaccountdocumentfilename) | **PUT** /api/accounts/{accountNumber}/documents/{documentID}/rename | Sets the documents file name and renames the associated file.
[**AccountsSetAccountGroup**](AccountsApi.md#accountssetaccountgroup) | **POST** /api/accounts/{accountNumber}/marketing/groups | Assigns a group to an account.
[**AccountsSetAccountProfile**](AccountsApi.md#accountssetaccountprofile) | **POST** /api/accounts/{accountNumber}/marketing/profiles | Assigns a profile to an account.
[**AccountsSetAccountSICCode**](AccountsApi.md#accountssetaccountsiccode) | **POST** /api/accounts/{accountNumber}/marketing/siccodes | Assigns a SIC code to an account.
[**AccountsSetAccountSystem**](AccountsApi.md#accountssetaccountsystem) | **POST** /api/accounts/{accountNumber}/service/systems | Assigns a system to the account.
[**AccountsSetDefaultSystem**](AccountsApi.md#accountssetdefaultsystem) | **PUT** /api/accounts/{accountNumber}/service/systems/default | Sets the default system for the account.
[**AccountsSetPrimaryBillTo**](AccountsApi.md#accountssetprimarybillto) | **PUT** /api/accounts/{accountNumber}/accounting/billtos/{billToID}/primary | Sets the primary alternate bill to for the account.
[**AccountsSetPrimaryFaxNumber**](AccountsApi.md#accountssetprimaryfaxnumber) | **PUT** /api/accounts/{accountNumber}/phonenumbers/{phoneNumberID}/primaryfax | Sets the primary account fax number.
[**AccountsSetPrimaryPhoneNumber**](AccountsApi.md#accountssetprimaryphonenumber) | **PUT** /api/accounts/{accountNumber}/phonenumbers/{phoneNumberID}/primaryphone | Sets the primary account phone number.
[**AccountsSetPrimaryShipTo**](AccountsApi.md#accountssetprimaryshipto) | **PUT** /api/accounts/{accountNumber}/accounting/shiptos/{shipToID}/primary | Sets the primary alternate ship to for the account.
[**AccountsSetTechAccountGroup**](AccountsApi.md#accountssettechaccountgroup) | **POST** /api/accounts/service/comanagedtechs/{repnumber} | Adds the co-manage direct tech to an account group.
[**AccountsUpdateAccount**](AccountsApi.md#accountsupdateaccount) | **PUT** /api/accounts/{accountNumber} | Updates an existing account.
[**AccountsUpdateAccountDocumentProperties**](AccountsApi.md#accountsupdateaccountdocumentproperties) | **PUT** /api/accounts/{accountNumber}/documents/{documentID} | Updates the account document information. Does not allow the file name property to be changed.
[**AccountsUpdateAccountExternalProduct**](AccountsApi.md#accountsupdateaccountexternalproduct) | **PUT** /api/accounts/{accountNumber}/service/externalproducts/{externalproductid} | Updates the account external product.
[**AccountsUpdateBillTo**](AccountsApi.md#accountsupdatebillto) | **PUT** /api/accounts/{accountNumber}/accounting/billtos/{billToID} | Updates the bill to.
[**AccountsUpdateCustomFields**](AccountsApi.md#accountsupdatecustomfields) | **PUT** /api/accounts/{accountNumber}/customfields | Updates account custom fields.
[**AccountsUpdatePhoneNumber**](AccountsApi.md#accountsupdatephonenumber) | **PUT** /api/accounts/{accountNumber}/phonenumbers/{phoneNumberID} | Change an account phone number.
[**AccountsUpdateShipTo**](AccountsApi.md#accountsupdateshipto) | **PUT** /api/accounts/{accountNumber}/accounting/shiptos/{shipToID} | 


<a name="accountsadvancedsearch"></a>
# **AccountsAdvancedSearch**
> TsiWebSearchAccountResponse AccountsAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for accounts.

Valid SearchType = AccountName, Address, PostalCode, Email, PhoneNumber, AccountNumber, AccountId, AccountNameSoundsLike, ExternalId, Agreement, CustomField (requires CategoryName and CustomFieldName), ContactName, ExternalProduct, AccountType, AccountStatus  <p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for accounts.
                TsiWebSearchAccountResponse result = apiInstance.AccountsAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsAdvancedSearch: " + e.Message );
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

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreateaccount"></a>
# **AccountsCreateAccount**
> TsiWebAccountResponse AccountsCreateAccount (TsiWebCreateAccountModel model)

Creates a new account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsCreateAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var model = new TsiWebCreateAccountModel(); // TsiWebCreateAccountModel | The model.

            try
            {
                // Creates a new account.
                TsiWebAccountResponse result = apiInstance.AccountsCreateAccount(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateAccountModel**](TsiWebCreateAccountModel.md)| The model. | 

### Return type

[**TsiWebAccountResponse**](TsiWebAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreateaccountdocument"></a>
# **AccountsCreateAccountDocument**
> TsiWebDocumentResponse AccountsCreateAccountDocument (int? accountNumber)

Creates the account document.

Requires a multipart/form request containing the physical file and the xml / json Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsCreateAccountDocumentExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Creates the account document.
                TsiWebDocumentResponse result = apiInstance.AccountsCreateAccountDocument(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreateAccountDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreateaccountexternalproduct"></a>
# **AccountsCreateAccountExternalProduct**
> TsiWebAccountExternalProductResponse AccountsCreateAccountExternalProduct (int? accountNumber, TsiWebAccountExternalProduct request)

Creates account external product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsCreateAccountExternalProductExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var request = new TsiWebAccountExternalProduct(); // TsiWebAccountExternalProduct | The request.

            try
            {
                // Creates account external product.
                TsiWebAccountExternalProductResponse result = apiInstance.AccountsCreateAccountExternalProduct(accountNumber, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreateAccountExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **request** | [**TsiWebAccountExternalProduct**](TsiWebAccountExternalProduct.md)| The request. | 

### Return type

[**TsiWebAccountExternalProductResponse**](TsiWebAccountExternalProductResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreateaccountjournalentry"></a>
# **AccountsCreateAccountJournalEntry**
> TsiWebJournalEntryResponse AccountsCreateAccountJournalEntry (int? accountNumber, TsiWebAccountJournalEntryModel model)

Creates the account journal entry.

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
    public class AccountsCreateAccountJournalEntryExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var model = new TsiWebAccountJournalEntryModel(); // TsiWebAccountJournalEntryModel | The journal entry.

            try
            {
                // Creates the account journal entry.
                TsiWebJournalEntryResponse result = apiInstance.AccountsCreateAccountJournalEntry(accountNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreateAccountJournalEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **model** | [**TsiWebAccountJournalEntryModel**](TsiWebAccountJournalEntryModel.md)| The journal entry. | 

### Return type

[**TsiWebJournalEntryResponse**](TsiWebJournalEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreatebillto"></a>
# **AccountsCreateBillTo**
> TsiWebBillToResponse AccountsCreateBillTo (int? accountNumber, TsiWebBillTo billTo)

Creates the bill to.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsCreateBillToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var billTo = new TsiWebBillTo(); // TsiWebBillTo | The bill to.

            try
            {
                // Creates the bill to.
                TsiWebBillToResponse result = apiInstance.AccountsCreateBillTo(accountNumber, billTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreateBillTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **billTo** | [**TsiWebBillTo**](TsiWebBillTo.md)| The bill to. | 

### Return type

[**TsiWebBillToResponse**](TsiWebBillToResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreatephonenumber"></a>
# **AccountsCreatePhoneNumber**
> TsiWebPhoneNumberResponse AccountsCreatePhoneNumber (int? accountNumber, TsiWebPhoneNumber phoneNumber)

Create an account phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsCreatePhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var phoneNumber = new TsiWebPhoneNumber(); // TsiWebPhoneNumber | The phone number.

            try
            {
                // Create an account phone number.
                TsiWebPhoneNumberResponse result = apiInstance.AccountsCreatePhoneNumber(accountNumber, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreatePhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **phoneNumber** | [**TsiWebPhoneNumber**](TsiWebPhoneNumber.md)| The phone number. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountscreateshipto"></a>
# **AccountsCreateShipTo**
> TsiWebShipToResponse AccountsCreateShipTo (int? accountNumber, TsiWebShipTo shipTo)

Creates new alternate ship to or updates an existing ship to for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsCreateShipToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var shipTo = new TsiWebShipTo(); // TsiWebShipTo | The ship to.

            try
            {
                // Creates new alternate ship to or updates an existing ship to for the account.
                TsiWebShipToResponse result = apiInstance.AccountsCreateShipTo(accountNumber, shipTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsCreateShipTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **shipTo** | [**TsiWebShipTo**](TsiWebShipTo.md)| The ship to. | 

### Return type

[**TsiWebShipToResponse**](TsiWebShipToResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteaccountexternalproduct"></a>
# **AccountsDeleteAccountExternalProduct**
> TsiWebResponse AccountsDeleteAccountExternalProduct (int? accountNumber, int? id)

Removes the external product from the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteAccountExternalProductExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = 56;  // int? | The account external product identifier.

            try
            {
                // Removes the external product from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteAccountExternalProduct(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteAccountExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **int?**| The account external product identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteaccountgroup"></a>
# **AccountsDeleteAccountGroup**
> TsiWebResponse AccountsDeleteAccountGroup (int? accountNumber, string id)

Deletes a group from the account.

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
    public class AccountsDeleteAccountGroupExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = id_example;  // string | The group name to remove.

            try
            {
                // Deletes a group from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteAccountGroup(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteAccountGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **string**| The group name to remove. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteaccountprofile"></a>
# **AccountsDeleteAccountProfile**
> TsiWebResponse AccountsDeleteAccountProfile (int? accountNumber, string id)

Deletes a profile from the account.

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
    public class AccountsDeleteAccountProfileExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = id_example;  // string | The profile name to remove.

            try
            {
                // Deletes a profile from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteAccountProfile(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteAccountProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **string**| The profile name to remove. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteaccountsiccodes"></a>
# **AccountsDeleteAccountSICCodes**
> TsiWebResponse AccountsDeleteAccountSICCodes (int? accountNumber, string id)

Deletes a SIC code from the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteAccountSICCodesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = id_example;  // string | The SIC code.

            try
            {
                // Deletes a SIC code from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteAccountSICCodes(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteAccountSICCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **string**| The SIC code. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteaccountsystem"></a>
# **AccountsDeleteAccountSystem**
> TsiWebResponse AccountsDeleteAccountSystem (int? accountNumber, string id)

Removes the system from the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteAccountSystemExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = id_example;  // string | The system to remove.

            try
            {
                // Removes the system from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteAccountSystem(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteAccountSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **string**| The system to remove. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeletebillto"></a>
# **AccountsDeleteBillTo**
> TsiWebResponse AccountsDeleteBillTo (int? accountNumber, int? id)

Removes the alternate bill to from the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteBillToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = 56;  // int? | The bill to identifier.

            try
            {
                // Removes the alternate bill to from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteBillTo(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteBillTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **int?**| The bill to identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeletephonenumber"></a>
# **AccountsDeletePhoneNumber**
> TsiWebResponse AccountsDeletePhoneNumber (int? accountNumber, int? id)

Deletes the account phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeletePhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = 56;  // int? | The phone number identifier.

            try
            {
                // Deletes the account phone number.
                TsiWebResponse result = apiInstance.AccountsDeletePhoneNumber(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeletePhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **int?**| The phone number identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteshipto"></a>
# **AccountsDeleteShipTo**
> TsiWebResponse AccountsDeleteShipTo (int? accountNumber, int? id)

Removes the alternate ship to from the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteShipToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var id = 56;  // int? | The ship to identifier.

            try
            {
                // Removes the alternate ship to from the account.
                TsiWebResponse result = apiInstance.AccountsDeleteShipTo(accountNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteShipTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **id** | **int?**| The ship to identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeletetechfromaccountgroup"></a>
# **AccountsDeleteTechFromAccountGroup**
> TsiWebResponse AccountsDeleteTechFromAccountGroup (int? repnumber, string id)

Deletes the tech from the account group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteTechFromAccountGroupExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var repnumber = 56;  // int? | The repnumber.
            var id = id_example;  // string | The group name.

            try
            {
                // Deletes the tech from the account group.
                TsiWebResponse result = apiInstance.AccountsDeleteTechFromAccountGroup(repnumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteTechFromAccountGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repnumber** | **int?**| The repnumber. | 
 **id** | **string**| The group name. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountcomanagedtechs"></a>
# **AccountsGetAccountCoManagedTechs**
> List<TsiWebCoManagedTechnician> AccountsGetAccountCoManagedTechs (int? accountNumber)

Gets a collection of Co-Managed Direct techs assigned to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountCoManagedTechsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of Co-Managed Direct techs assigned to the account.
                List&lt;TsiWebCoManagedTechnician&gt; result = apiInstance.AccountsGetAccountCoManagedTechs(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountCoManagedTechs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebCoManagedTechnician>**](TsiWebCoManagedTechnician.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountcompletedtasks"></a>
# **AccountsGetAccountCompletedTasks**
> TsiWebTasksResponse AccountsGetAccountCompletedTasks (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets account completed tasks

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
    public class AccountsGetAccountCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets account completed tasks
                TsiWebTasksResponse result = apiInstance.AccountsGetAccountCompletedTasks(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**|  | 
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

<a name="accountsgetaccountcustomerassets"></a>
# **AccountsGetAccountCustomerAssets**
> TsiWebAccountCustomerAssetResponse AccountsGetAccountCustomerAssets (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account customer assets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountCustomerAssetsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account customer assets.
                TsiWebAccountCustomerAssetResponse result = apiInstance.AccountsGetAccountCustomerAssets(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountCustomerAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebAccountCustomerAssetResponse**](TsiWebAccountCustomerAssetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountdetails"></a>
# **AccountsGetAccountDetails**
> TsiWebAccountDetail AccountsGetAccountDetails (int? accountNumber)

Gets the account details by account number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the account details by account number.
                TsiWebAccountDetail result = apiInstance.AccountsGetAccountDetails(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebAccountDetail**](TsiWebAccountDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountdocument"></a>
# **AccountsGetAccountDocument**
> TsiWebDocumentSummary AccountsGetAccountDocument (int? accountNumber, int? documentID)

Gets the account document with the file bytes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountDocumentExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the account document with the file bytes.
                TsiWebDocumentSummary result = apiInstance.AccountsGetAccountDocument(accountNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebDocumentSummary**](TsiWebDocumentSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountdocuments"></a>
# **AccountsGetAccountDocuments**
> TsiWebDocumentsResponse AccountsGetAccountDocuments (int? accountNumber, bool? accountOnly = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountDocumentsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var accountOnly = true;  // bool? | If false includes documents from all documents related to the account. For example Contacts, Opportunities and Service Orders. (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account documents.
                TsiWebDocumentsResponse result = apiInstance.AccountsGetAccountDocuments(accountNumber, accountOnly, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **accountOnly** | **bool?**| If false includes documents from all documents related to the account. For example Contacts, Opportunities and Service Orders. | [optional] 
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

<a name="accountsgetaccountdocuments_0"></a>
# **AccountsGetAccountDocuments_0**
> TsiWebDocumentsResponse AccountsGetAccountDocuments_0 (int? accountNumber, bool? accountOnly, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountDocuments_0Example
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var accountOnly = true;  // bool? | If false includes documents from all documents related to the account. For example Contacts, Opportunities and Service Orders.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account documents.
                TsiWebDocumentsResponse result = apiInstance.AccountsGetAccountDocuments_0(accountNumber, accountOnly, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountDocuments_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **accountOnly** | **bool?**| If false includes documents from all documents related to the account. For example Contacts, Opportunities and Service Orders. | 
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

<a name="accountsgetaccountexternalproduct"></a>
# **AccountsGetAccountExternalProduct**
> TsiWebAccountExternalProduct AccountsGetAccountExternalProduct (int? accountNumber, int? accountExternalProductID)

Gets account external product by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountExternalProductExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var accountExternalProductID = 56;  // int? | The account external product identifier.

            try
            {
                // Gets account external product by ID.
                TsiWebAccountExternalProduct result = apiInstance.AccountsGetAccountExternalProduct(accountNumber, accountExternalProductID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **accountExternalProductID** | **int?**| The account external product identifier. | 

### Return type

[**TsiWebAccountExternalProduct**](TsiWebAccountExternalProduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountexternalproducts"></a>
# **AccountsGetAccountExternalProducts**
> List<TsiWebAccountExternalProduct> AccountsGetAccountExternalProducts (int? accountNumber)

Gets a collection of associated external products for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountExternalProductsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of associated external products for the account.
                List&lt;TsiWebAccountExternalProduct&gt; result = apiInstance.AccountsGetAccountExternalProducts(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountExternalProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebAccountExternalProduct>**](TsiWebAccountExternalProduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountincompletetasks"></a>
# **AccountsGetAccountIncompleteTasks**
> TsiWebTasksResponse AccountsGetAccountIncompleteTasks (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets account incomplete tasks

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
    public class AccountsGetAccountIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets account incomplete tasks
                TsiWebTasksResponse result = apiInstance.AccountsGetAccountIncompleteTasks(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**|  | 
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

<a name="accountsgetaccountjournalentries"></a>
# **AccountsGetAccountJournalEntries**
> TsiWebJournalEntriesResponse AccountsGetAccountJournalEntries (int? accountNumber, bool? excludeSystemEntries = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account journal entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountJournalEntriesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var excludeSystemEntries = true;  // bool? | If false includes system entries. (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account journal entries.
                TsiWebJournalEntriesResponse result = apiInstance.AccountsGetAccountJournalEntries(accountNumber, excludeSystemEntries, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountJournalEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
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

<a name="accountsgetaccountjournalentries_0"></a>
# **AccountsGetAccountJournalEntries_0**
> TsiWebJournalEntriesResponse AccountsGetAccountJournalEntries_0 (int? accountNumber, bool? excludeSystemEntries, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account journal entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountJournalEntries_0Example
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var excludeSystemEntries = true;  // bool? | If false includes system entries.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account journal entries.
                TsiWebJournalEntriesResponse result = apiInstance.AccountsGetAccountJournalEntries_0(accountNumber, excludeSystemEntries, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountJournalEntries_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
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

<a name="accountsgetaccountmanagedassets"></a>
# **AccountsGetAccountManagedAssets**
> TsiWebAccountManagedAssetResponse AccountsGetAccountManagedAssets (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account managed assets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountManagedAssetsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account managed assets.
                TsiWebAccountManagedAssetResponse result = apiInstance.AccountsGetAccountManagedAssets(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountManagedAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebAccountManagedAssetResponse**](TsiWebAccountManagedAssetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountonlycompletedtasks"></a>
# **AccountsGetAccountOnlyCompletedTasks**
> TsiWebTasksResponse AccountsGetAccountOnlyCompletedTasks (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account only completed tasks.

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
    public class AccountsGetAccountOnlyCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account only completed tasks.
                TsiWebTasksResponse result = apiInstance.AccountsGetAccountOnlyCompletedTasks(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountOnlyCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
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

<a name="accountsgetaccountonlyincompletetasks"></a>
# **AccountsGetAccountOnlyIncompleteTasks**
> TsiWebTasksResponse AccountsGetAccountOnlyIncompleteTasks (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account only incomplete tasks.

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
    public class AccountsGetAccountOnlyIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account only incomplete tasks.
                TsiWebTasksResponse result = apiInstance.AccountsGetAccountOnlyIncompleteTasks(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountOnlyIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
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

<a name="accountsgetaccountonlytasks"></a>
# **AccountsGetAccountOnlyTasks**
> TsiWebTasksResponse AccountsGetAccountOnlyTasks (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account only tasks. Includes both completed and imcomplete tasks.

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
    public class AccountsGetAccountOnlyTasksExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account only tasks. Includes both completed and imcomplete tasks.
                TsiWebTasksResponse result = apiInstance.AccountsGetAccountOnlyTasks(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountOnlyTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
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

<a name="accountsgetaccountsummary"></a>
# **AccountsGetAccountSummary**
> TsiWebAccountSummary AccountsGetAccountSummary (int? accountNumber)

Gets the account summary by account number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountSummaryExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the account summary by account number.
                TsiWebAccountSummary result = apiInstance.AccountsGetAccountSummary(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebAccountSummary**](TsiWebAccountSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountsystems"></a>
# **AccountsGetAccountSystems**
> List<TsiWebAccountSystem> AccountsGetAccountSystems (int? accountNumber)

Gets a collection of systems assigned to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountSystemsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of systems assigned to the account.
                List&lt;TsiWebAccountSystem&gt; result = apiInstance.AccountsGetAccountSystems(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountSystems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebAccountSystem>**](TsiWebAccountSystem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccounttasks"></a>
# **AccountsGetAccountTasks**
> TsiWebTasksResponse AccountsGetAccountTasks (int? accountNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets account tasks. includes both completed and incomplete tasks

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
    public class AccountsGetAccountTasksExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets account tasks. includes both completed and incomplete tasks
                TsiWebTasksResponse result = apiInstance.AccountsGetAccountTasks(accountNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**|  | 
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

<a name="accountsgetaccountingdetails"></a>
# **AccountsGetAccountingDetails**
> TsiWebAccounting AccountsGetAccountingDetails (int? accountNumber)

Gets the accounting details for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountingDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the accounting details for the account.
                TsiWebAccounting result = apiInstance.AccountsGetAccountingDetails(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountingDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebAccounting**](TsiWebAccounting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetassignedgroups"></a>
# **AccountsGetAssignedGroups**
> List<TsiWebAssignedMarketingGroup> AccountsGetAssignedGroups (int? accountNumber)

Gets a collection of groups assigned to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAssignedGroupsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of groups assigned to the account.
                List&lt;TsiWebAssignedMarketingGroup&gt; result = apiInstance.AccountsGetAssignedGroups(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAssignedGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebAssignedMarketingGroup>**](TsiWebAssignedMarketingGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetassignedprofiles"></a>
# **AccountsGetAssignedProfiles**
> List<TsiWebAssignedMarketingProfile> AccountsGetAssignedProfiles (int? accountNumber)

Gets a collection of profiles assigned to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAssignedProfilesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of profiles assigned to the account.
                List&lt;TsiWebAssignedMarketingProfile&gt; result = apiInstance.AccountsGetAssignedProfiles(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAssignedProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebAssignedMarketingProfile>**](TsiWebAssignedMarketingProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetassignedsiccodes"></a>
# **AccountsGetAssignedSICCodes**
> List<TsiWebAssignedSICCode> AccountsGetAssignedSICCodes (int? accountNumber)

Gets a collection of SIC codes assigned to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAssignedSICCodesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of SIC codes assigned to the account.
                List&lt;TsiWebAssignedSICCode&gt; result = apiInstance.AccountsGetAssignedSICCodes(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAssignedSICCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebAssignedSICCode>**](TsiWebAssignedSICCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetbillto"></a>
# **AccountsGetBillTo**
> List<TsiWebBillTo> AccountsGetBillTo (int? accountNumber, int? billToID)

Gets the alternate bill to for the account by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetBillToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var billToID = 56;  // int? | The bill to identifier.

            try
            {
                // Gets the alternate bill to for the account by ID.
                List&lt;TsiWebBillTo&gt; result = apiInstance.AccountsGetBillTo(accountNumber, billToID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetBillTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **billToID** | **int?**| The bill to identifier. | 

### Return type

[**List<TsiWebBillTo>**](TsiWebBillTo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetbilltos"></a>
# **AccountsGetBillTos**
> List<TsiWebBillTo> AccountsGetBillTos (int? accountNumber)

Gets a collection of alternate bill tos for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetBillTosExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of alternate bill tos for the account.
                List&lt;TsiWebBillTo&gt; result = apiInstance.AccountsGetBillTos(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetBillTos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebBillTo>**](TsiWebBillTo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetcustomfields"></a>
# **AccountsGetCustomFields**
> List<TsiWebCustomField> AccountsGetCustomFields (int? accountNumber)

Gets the custom fields for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the custom fields for the account.
                List&lt;TsiWebCustomField&gt; result = apiInstance.AccountsGetCustomFields(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetfile"></a>
# **AccountsGetFile**
> Object AccountsGetFile (int? accountNumber, int? documentID)

Gets the account document file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetFileExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the account document file.
                Object result = apiInstance.AccountsGetFile(accountNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetmarketingdetails"></a>
# **AccountsGetMarketingDetails**
> TsiWebAccountMarketingDetails AccountsGetMarketingDetails (int? accountNumber)

Gets the account marketing details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetMarketingDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the account marketing details.
                TsiWebAccountMarketingDetails result = apiInstance.AccountsGetMarketingDetails(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetMarketingDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebAccountMarketingDetails**](TsiWebAccountMarketingDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetpaymethod"></a>
# **AccountsGetPayMethod**
> TsiWebPayMethod AccountsGetPayMethod (int? accountNumber, int? payMethodID)

Gets the pay method for the account by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetPayMethodExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var payMethodID = 56;  // int? | The pay method identifier.

            try
            {
                // Gets the pay method for the account by ID.
                TsiWebPayMethod result = apiInstance.AccountsGetPayMethod(accountNumber, payMethodID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetPayMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **payMethodID** | **int?**| The pay method identifier. | 

### Return type

[**TsiWebPayMethod**](TsiWebPayMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetpaymethods"></a>
# **AccountsGetPayMethods**
> List<TsiWebPayMethod> AccountsGetPayMethods (int? accountNumber)

Gets a collection of pay methods for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetPayMethodsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of pay methods for the account.
                List&lt;TsiWebPayMethod&gt; result = apiInstance.AccountsGetPayMethods(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetPayMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebPayMethod>**](TsiWebPayMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetphonenumber"></a>
# **AccountsGetPhoneNumber**
> TsiWebPhoneNumber AccountsGetPhoneNumber (int? accountNumber, int? phoneNumberID)

Gets the account phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetPhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var phoneNumberID = 56;  // int? | The phone number identifier.

            try
            {
                // Gets the account phone number.
                TsiWebPhoneNumber result = apiInstance.AccountsGetPhoneNumber(accountNumber, phoneNumberID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **phoneNumberID** | **int?**| The phone number identifier. | 

### Return type

[**TsiWebPhoneNumber**](TsiWebPhoneNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetphonenumbers"></a>
# **AccountsGetPhoneNumbers**
> List<TsiWebPhoneNumber> AccountsGetPhoneNumbers (int? accountNumber)

Gets the account phone numbers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetPhoneNumbersExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the account phone numbers.
                List&lt;TsiWebPhoneNumber&gt; result = apiInstance.AccountsGetPhoneNumbers(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetPhoneNumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebPhoneNumber>**](TsiWebPhoneNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetservicedetails"></a>
# **AccountsGetServiceDetails**
> TsiWebAccountServiceDetails AccountsGetServiceDetails (int? accountNumber)

Gets the service details for an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetServiceDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets the service details for an account.
                TsiWebAccountServiceDetails result = apiInstance.AccountsGetServiceDetails(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetServiceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebAccountServiceDetails**](TsiWebAccountServiceDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetshipto"></a>
# **AccountsGetShipTo**
> TsiWebShipTo AccountsGetShipTo (int? accountNumber, int? shipToID)

Gets the alternate ship to for the account by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetShipToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var shipToID = 56;  // int? | The ship to identifier.

            try
            {
                // Gets the alternate ship to for the account by ID.
                TsiWebShipTo result = apiInstance.AccountsGetShipTo(accountNumber, shipToID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetShipTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **shipToID** | **int?**| The ship to identifier. | 

### Return type

[**TsiWebShipTo**](TsiWebShipTo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetshiptos"></a>
# **AccountsGetShipTos**
> List<TsiWebShipTo> AccountsGetShipTos (int? accountNumber)

Gets a collection of alternate ship tos for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetShipTosExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a collection of alternate ship tos for the account.
                List&lt;TsiWebShipTo&gt; result = apiInstance.AccountsGetShipTos(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetShipTos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebShipTo>**](TsiWebShipTo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssaveaccountingdetails"></a>
# **AccountsSaveAccountingDetails**
> TsiWebAccountingDetailResponse AccountsSaveAccountingDetails (int? accountNumber, TsiWebAccountingDetail details)

Creates or updates accounting details for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSaveAccountingDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var details = new TsiWebAccountingDetail(); // TsiWebAccountingDetail | The details.

            try
            {
                // Creates or updates accounting details for the account.
                TsiWebAccountingDetailResponse result = apiInstance.AccountsSaveAccountingDetails(accountNumber, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSaveAccountingDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **details** | [**TsiWebAccountingDetail**](TsiWebAccountingDetail.md)| The details. | 

### Return type

[**TsiWebAccountingDetailResponse**](TsiWebAccountingDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssavemarketingdetails"></a>
# **AccountsSaveMarketingDetails**
> TsiWebAccountMarketingDetailsResponse AccountsSaveMarketingDetails (int? accountNumber, TsiWebAccountMarketingDetail details)

Update the account marketing details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSaveMarketingDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var details = new TsiWebAccountMarketingDetail(); // TsiWebAccountMarketingDetail | Marketing details for the account.

            try
            {
                // Update the account marketing details.
                TsiWebAccountMarketingDetailsResponse result = apiInstance.AccountsSaveMarketingDetails(accountNumber, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSaveMarketingDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **details** | [**TsiWebAccountMarketingDetail**](TsiWebAccountMarketingDetail.md)| Marketing details for the account. | 

### Return type

[**TsiWebAccountMarketingDetailsResponse**](TsiWebAccountMarketingDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssaveservicedetails"></a>
# **AccountsSaveServiceDetails**
> TsiWebAccountServiceDetailsResponse AccountsSaveServiceDetails (int? accountNumber, TsiWebAccountServiceDetail details)

Updates the account service details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSaveServiceDetailsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var details = new TsiWebAccountServiceDetail(); // TsiWebAccountServiceDetail | The details.

            try
            {
                // Updates the account service details.
                TsiWebAccountServiceDetailsResponse result = apiInstance.AccountsSaveServiceDetails(accountNumber, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSaveServiceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **details** | [**TsiWebAccountServiceDetail**](TsiWebAccountServiceDetail.md)| The details. | 

### Return type

[**TsiWebAccountServiceDetailsResponse**](TsiWebAccountServiceDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchaccountscontactname"></a>
# **AccountsSearchAccountsContactName**
> TsiWebSearchAccountResponse AccountsSearchAccountsContactName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Accounts using contact name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchAccountsContactNameExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Accounts using contact name.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchAccountsContactName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchAccountsContactName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| The criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchaccountscustomfield"></a>
# **AccountsSearchAccountsCustomField**
> TsiWebSearchAccountResponse AccountsSearchAccountsCustomField (TsiWebCustomFieldSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

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
    public class AccountsSearchAccountsCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var model = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A {Tsi.Web.CustomFieldSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Accounts using a custom category and field label.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchAccountsCustomField(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchAccountsCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldSearchModel**](TsiWebCustomFieldSearchModel.md)| A {Tsi.Web.CustomFieldSearchModel} | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchaccountssoundslikename"></a>
# **AccountsSearchAccountsSoundsLikeName**
> TsiWebSearchAccountResponse AccountsSearchAccountsSoundsLikeName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches the name of the accounts that sound like the criteria provided.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchAccountsSoundsLikeNameExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches the name of the accounts that sound like the criteria provided.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchAccountsSoundsLikeName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchAccountsSoundsLikeName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyaccountid"></a>
# **AccountsSearchByAccountId**
> TsiWebSearchAccountResponse AccountsSearchByAccountId (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by the user specified identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByAccountIdExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by the user specified identifier.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByAccountId(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByAccountId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyaccountnumber"></a>
# **AccountsSearchByAccountNumber**
> TsiWebSearchAccountResponse AccountsSearchByAccountNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByAccountNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by number.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByAccountNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByAccountNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyaccountstatus"></a>
# **AccountsSearchByAccountStatus**
> TsiWebSearchAccountResponse AccountsSearchByAccountStatus (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by Account Status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByAccountStatusExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by Account Status.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByAccountStatus(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByAccountStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyaccounttype"></a>
# **AccountsSearchByAccountType**
> TsiWebSearchAccountResponse AccountsSearchByAccountType (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by Account Type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByAccountTypeExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by Account Type.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByAccountType(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByAccountType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyaddress"></a>
# **AccountsSearchByAddress**
> TsiWebSearchAccountResponse AccountsSearchByAddress (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByAddressExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by address.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByAddress(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyagreement"></a>
# **AccountsSearchByAgreement**
> TsiWebSearchAccountResponse AccountsSearchByAgreement (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by MSP Agreement .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByAgreementExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by MSP Agreement .
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByAgreement(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyemail"></a>
# **AccountsSearchByEmail**
> TsiWebSearchAccountResponse AccountsSearchByEmail (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts using all email addresses associated to the account and its contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByEmailExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts using all email addresses associated to the account and its contacts.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByEmail(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyexternalid"></a>
# **AccountsSearchByExternalId**
> TsiWebSearchAccountResponse AccountsSearchByExternalId (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts using the External ID related to .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByExternalIdExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts using the External ID related to .
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByExternalId(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByExternalId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyname"></a>
# **AccountsSearchByName**
> TsiWebSearchAccountResponse AccountsSearchByName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByNameExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by name.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbyphone"></a>
# **AccountsSearchByPhone**
> TsiWebSearchAccountResponse AccountsSearchByPhone (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts using all phone numbers associated to the account and its contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByPhoneExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts using all phone numbers associated to the account and its contacts.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByPhone(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssearchbypostalcode"></a>
# **AccountsSearchByPostalCode**
> TsiWebSearchAccountResponse AccountsSearchByPostalCode (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search accounts by postal code.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSearchByPostalCodeExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search accounts by postal code.
                TsiWebSearchAccountResponse result = apiInstance.AccountsSearchByPostalCode(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSearchByPostalCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetaccountdocumentfile"></a>
# **AccountsSetAccountDocumentFile**
> TsiWebResponse AccountsSetAccountDocumentFile (int? accountNumber, int? documentID)

Overwrites the account document physical file, does not rename the file.

Requires a multipart/form request containing the physical file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetAccountDocumentFileExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Overwrites the account document physical file, does not rename the file.
                TsiWebResponse result = apiInstance.AccountsSetAccountDocumentFile(accountNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetAccountDocumentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetaccountdocumentfilename"></a>
# **AccountsSetAccountDocumentFileName**
> TsiWebDocumentResponse AccountsSetAccountDocumentFileName (int? accountNumber, int? documentID, string fileName)

Sets the documents file name and renames the associated file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetAccountDocumentFileNameExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | 
            var documentID = 56;  // int? | 
            var fileName = fileName_example;  // string | 

            try
            {
                // Sets the documents file name and renames the associated file.
                TsiWebDocumentResponse result = apiInstance.AccountsSetAccountDocumentFileName(accountNumber, documentID, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetAccountDocumentFileName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**|  | 
 **documentID** | **int?**|  | 
 **fileName** | **string**|  | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetaccountgroup"></a>
# **AccountsSetAccountGroup**
> TsiWebAssignedMarketingGroupsResponse AccountsSetAccountGroup (int? accountNumber, string group)

Assigns a group to an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetAccountGroupExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var group = group_example;  // string | The group to assign.

            try
            {
                // Assigns a group to an account.
                TsiWebAssignedMarketingGroupsResponse result = apiInstance.AccountsSetAccountGroup(accountNumber, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetAccountGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **group** | **string**| The group to assign. | 

### Return type

[**TsiWebAssignedMarketingGroupsResponse**](TsiWebAssignedMarketingGroupsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetaccountprofile"></a>
# **AccountsSetAccountProfile**
> TsiWebAssignedMarketingProfilesResponse AccountsSetAccountProfile (int? accountNumber, string profile)

Assigns a profile to an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetAccountProfileExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var profile = profile_example;  // string | The profile to assign.

            try
            {
                // Assigns a profile to an account.
                TsiWebAssignedMarketingProfilesResponse result = apiInstance.AccountsSetAccountProfile(accountNumber, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetAccountProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **profile** | **string**| The profile to assign. | 

### Return type

[**TsiWebAssignedMarketingProfilesResponse**](TsiWebAssignedMarketingProfilesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetaccountsiccode"></a>
# **AccountsSetAccountSICCode**
> TsiWebAssignedSICCodesResponse AccountsSetAccountSICCode (int? accountNumber, string code)

Assigns a SIC code to an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetAccountSICCodeExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var code = code_example;  // string | The SIC code.

            try
            {
                // Assigns a SIC code to an account.
                TsiWebAssignedSICCodesResponse result = apiInstance.AccountsSetAccountSICCode(accountNumber, code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetAccountSICCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **code** | **string**| The SIC code. | 

### Return type

[**TsiWebAssignedSICCodesResponse**](TsiWebAssignedSICCodesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetaccountsystem"></a>
# **AccountsSetAccountSystem**
> TsiWebAccountSystemResponse AccountsSetAccountSystem (int? accountNumber, TsiWebAssignSystemModel system)

Assigns a system to the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetAccountSystemExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var system = new TsiWebAssignSystemModel(); // TsiWebAssignSystemModel | The system.

            try
            {
                // Assigns a system to the account.
                TsiWebAccountSystemResponse result = apiInstance.AccountsSetAccountSystem(accountNumber, system);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetAccountSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **system** | [**TsiWebAssignSystemModel**](TsiWebAssignSystemModel.md)| The system. | 

### Return type

[**TsiWebAccountSystemResponse**](TsiWebAccountSystemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetdefaultsystem"></a>
# **AccountsSetDefaultSystem**
> TsiWebAccountSystemResponse AccountsSetDefaultSystem (int? accountNumber, string system)

Sets the default system for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetDefaultSystemExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var system = system_example;  // string | The system to make default.

            try
            {
                // Sets the default system for the account.
                TsiWebAccountSystemResponse result = apiInstance.AccountsSetDefaultSystem(accountNumber, system);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetDefaultSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **system** | **string**| The system to make default. | 

### Return type

[**TsiWebAccountSystemResponse**](TsiWebAccountSystemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetprimarybillto"></a>
# **AccountsSetPrimaryBillTo**
> TsiWebBillToResponse AccountsSetPrimaryBillTo (int? accountNumber, int? billToID)

Sets the primary alternate bill to for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetPrimaryBillToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var billToID = 56;  // int? | The bill to identifier.

            try
            {
                // Sets the primary alternate bill to for the account.
                TsiWebBillToResponse result = apiInstance.AccountsSetPrimaryBillTo(accountNumber, billToID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetPrimaryBillTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **billToID** | **int?**| The bill to identifier. | 

### Return type

[**TsiWebBillToResponse**](TsiWebBillToResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetprimaryfaxnumber"></a>
# **AccountsSetPrimaryFaxNumber**
> TsiWebPhoneNumberResponse AccountsSetPrimaryFaxNumber (int? accountNumber, int? phoneNumberID)

Sets the primary account fax number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetPrimaryFaxNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var phoneNumberID = 56;  // int? | The fax number identifier.

            try
            {
                // Sets the primary account fax number.
                TsiWebPhoneNumberResponse result = apiInstance.AccountsSetPrimaryFaxNumber(accountNumber, phoneNumberID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetPrimaryFaxNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **phoneNumberID** | **int?**| The fax number identifier. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetprimaryphonenumber"></a>
# **AccountsSetPrimaryPhoneNumber**
> TsiWebPhoneNumberResponse AccountsSetPrimaryPhoneNumber (int? accountNumber, int? phoneNumberID)

Sets the primary account phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetPrimaryPhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var phoneNumberID = 56;  // int? | The phone number identifier.

            try
            {
                // Sets the primary account phone number.
                TsiWebPhoneNumberResponse result = apiInstance.AccountsSetPrimaryPhoneNumber(accountNumber, phoneNumberID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetPrimaryPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **phoneNumberID** | **int?**| The phone number identifier. | 

### Return type

[**TsiWebPhoneNumberResponse**](TsiWebPhoneNumberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssetprimaryshipto"></a>
# **AccountsSetPrimaryShipTo**
> TsiWebShipToResponse AccountsSetPrimaryShipTo (int? accountNumber, int? shipToID)

Sets the primary alternate ship to for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetPrimaryShipToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var shipToID = 56;  // int? | The ship to identifier.

            try
            {
                // Sets the primary alternate ship to for the account.
                TsiWebShipToResponse result = apiInstance.AccountsSetPrimaryShipTo(accountNumber, shipToID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetPrimaryShipTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **shipToID** | **int?**| The ship to identifier. | 

### Return type

[**TsiWebShipToResponse**](TsiWebShipToResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountssettechaccountgroup"></a>
# **AccountsSetTechAccountGroup**
> TsiWebCoManagedTechnicianResponse AccountsSetTechAccountGroup (int? repnumber, string groupName)

Adds the co-manage direct tech to an account group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsSetTechAccountGroupExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var repnumber = 56;  // int? | The repnumber.
            var groupName = groupName_example;  // string | The group name.

            try
            {
                // Adds the co-manage direct tech to an account group.
                TsiWebCoManagedTechnicianResponse result = apiInstance.AccountsSetTechAccountGroup(repnumber, groupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsSetTechAccountGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repnumber** | **int?**| The repnumber. | 
 **groupName** | **string**| The group name. | 

### Return type

[**TsiWebCoManagedTechnicianResponse**](TsiWebCoManagedTechnicianResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsupdateaccount"></a>
# **AccountsUpdateAccount**
> TsiWebAccountResponse AccountsUpdateAccount (int? accountNumber, TsiWebAccount account)

Updates an existing account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdateAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var account = new TsiWebAccount(); // TsiWebAccount | The account.

            try
            {
                // Updates an existing account.
                TsiWebAccountResponse result = apiInstance.AccountsUpdateAccount(accountNumber, account);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **account** | [**TsiWebAccount**](TsiWebAccount.md)| The account. | 

### Return type

[**TsiWebAccountResponse**](TsiWebAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsupdateaccountdocumentproperties"></a>
# **AccountsUpdateAccountDocumentProperties**
> TsiWebDocumentResponse AccountsUpdateAccountDocumentProperties (int? accountNumber, int? documentID, TsiWebAreasWebApiUpdateDocumentModel request)

Updates the account document information. Does not allow the file name property to be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdateAccountDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var documentID = 56;  // int? | The document identifier.
            var request = new TsiWebAreasWebApiUpdateDocumentModel(); // TsiWebAreasWebApiUpdateDocumentModel | The update document request.

            try
            {
                // Updates the account document information. Does not allow the file name property to be changed.
                TsiWebDocumentResponse result = apiInstance.AccountsUpdateAccountDocumentProperties(accountNumber, documentID, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdateAccountDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **documentID** | **int?**| The document identifier. | 
 **request** | [**TsiWebAreasWebApiUpdateDocumentModel**](TsiWebAreasWebApiUpdateDocumentModel.md)| The update document request. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsupdateaccountexternalproduct"></a>
# **AccountsUpdateAccountExternalProduct**
> TsiWebAccountExternalProductResponse AccountsUpdateAccountExternalProduct (int? accountNumber, int? externalproductid, TsiWebAccountExternalProduct request)

Updates the account external product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdateAccountExternalProductExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var externalproductid = 56;  // int? | The externalproductid.
            var request = new TsiWebAccountExternalProduct(); // TsiWebAccountExternalProduct | The request.

            try
            {
                // Updates the account external product.
                TsiWebAccountExternalProductResponse result = apiInstance.AccountsUpdateAccountExternalProduct(accountNumber, externalproductid, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdateAccountExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **externalproductid** | **int?**| The externalproductid. | 
 **request** | [**TsiWebAccountExternalProduct**](TsiWebAccountExternalProduct.md)| The request. | 

### Return type

[**TsiWebAccountExternalProductResponse**](TsiWebAccountExternalProductResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsupdatebillto"></a>
# **AccountsUpdateBillTo**
> TsiWebBillToResponse AccountsUpdateBillTo (int? accountNumber, int? billToID, TsiWebBillTo billTo)

Updates the bill to.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdateBillToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var billToID = 56;  // int? | The bill to identifier.
            var billTo = new TsiWebBillTo(); // TsiWebBillTo | The bill to.

            try
            {
                // Updates the bill to.
                TsiWebBillToResponse result = apiInstance.AccountsUpdateBillTo(accountNumber, billToID, billTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdateBillTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **billToID** | **int?**| The bill to identifier. | 
 **billTo** | [**TsiWebBillTo**](TsiWebBillTo.md)| The bill to. | 

### Return type

[**TsiWebBillToResponse**](TsiWebBillToResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsupdatecustomfields"></a>
# **AccountsUpdateCustomFields**
> TsiWebCustomFieldsResponse AccountsUpdateCustomFields (int? accountNumber, List<TsiWebCustomField> customFields)

Updates account custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.

            try
            {
                // Updates account custom fields.
                TsiWebCustomFieldsResponse result = apiInstance.AccountsUpdateCustomFields(accountNumber, customFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsupdatephonenumber"></a>
# **AccountsUpdatePhoneNumber**
> TsiWebPhoneNumberResponse AccountsUpdatePhoneNumber (int? accountNumber, int? phoneNumberID, TsiWebPhoneNumber phoneNumber)

Change an account phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdatePhoneNumberExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | The account number.
            var phoneNumberID = 56;  // int? | The phone number identifier.
            var phoneNumber = new TsiWebPhoneNumber(); // TsiWebPhoneNumber | The phone number.

            try
            {
                // Change an account phone number.
                TsiWebPhoneNumberResponse result = apiInstance.AccountsUpdatePhoneNumber(accountNumber, phoneNumberID, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdatePhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
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

<a name="accountsupdateshipto"></a>
# **AccountsUpdateShipTo**
> TsiWebShipToResponse AccountsUpdateShipTo (int? accountNumber, int? shipToID, TsiWebShipTo shipTo)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsUpdateShipToExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountNumber = 56;  // int? | 
            var shipToID = 56;  // int? | 
            var shipTo = new TsiWebShipTo(); // TsiWebShipTo | 

            try
            {
                TsiWebShipToResponse result = apiInstance.AccountsUpdateShipTo(accountNumber, shipToID, shipTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsUpdateShipTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**|  | 
 **shipToID** | **int?**|  | 
 **shipTo** | [**TsiWebShipTo**](TsiWebShipTo.md)|  | 

### Return type

[**TsiWebShipToResponse**](TsiWebShipToResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

