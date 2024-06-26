# brevo_csharp.Api.SMSCampaignsApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSmsCampaign**](SMSCampaignsApi.md#createsmscampaign) | **POST** /smsCampaigns | Creates an SMS campaign
[**DeleteSmsCampaign**](SMSCampaignsApi.md#deletesmscampaign) | **DELETE** /smsCampaigns/{campaignId} | Delete an SMS campaign
[**GetSmsCampaign**](SMSCampaignsApi.md#getsmscampaign) | **GET** /smsCampaigns/{campaignId} | Get an SMS campaign
[**GetSmsCampaigns**](SMSCampaignsApi.md#getsmscampaigns) | **GET** /smsCampaigns | Returns the information for all your created SMS campaigns
[**RequestSmsRecipientExport**](SMSCampaignsApi.md#requestsmsrecipientexport) | **POST** /smsCampaigns/{campaignId}/exportRecipients | Export an SMS campaign&#39;s recipients
[**SendSmsCampaignNow**](SMSCampaignsApi.md#sendsmscampaignnow) | **POST** /smsCampaigns/{campaignId}/sendNow | Send your SMS campaign immediately
[**SendSmsReport**](SMSCampaignsApi.md#sendsmsreport) | **POST** /smsCampaigns/{campaignId}/sendReport | Send an SMS campaign&#39;s report
[**SendTestSms**](SMSCampaignsApi.md#sendtestsms) | **POST** /smsCampaigns/{campaignId}/sendTest | Send a test SMS campaign
[**UpdateSmsCampaign**](SMSCampaignsApi.md#updatesmscampaign) | **PUT** /smsCampaigns/{campaignId} | Update an SMS campaign
[**UpdateSmsCampaignStatus**](SMSCampaignsApi.md#updatesmscampaignstatus) | **PUT** /smsCampaigns/{campaignId}/status | Update a campaign&#39;s status


<a name="createsmscampaign"></a>
# **CreateSmsCampaign**
> CreateModel CreateSmsCampaign (CreateSmsCampaign createSmsCampaign)

Creates an SMS campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateSmsCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var createSmsCampaign = new CreateSmsCampaign(); // CreateSmsCampaign | Values to create an SMS Campaign

            try
            {
                // Creates an SMS campaign
                CreateModel result = apiInstance.CreateSmsCampaign(createSmsCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.CreateSmsCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSmsCampaign** | [**CreateSmsCampaign**](CreateSmsCampaign.md)| Values to create an SMS Campaign | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesmscampaign"></a>
# **DeleteSmsCampaign**
> void DeleteSmsCampaign (long? campaignId)

Delete an SMS campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteSmsCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the SMS campaign

            try
            {
                // Delete an SMS campaign
                apiInstance.DeleteSmsCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.DeleteSmsCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the SMS campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmscampaign"></a>
# **GetSmsCampaign**
> GetSmsCampaign GetSmsCampaign (long? campaignId)

Get an SMS campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSmsCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the SMS campaign

            try
            {
                // Get an SMS campaign
                GetSmsCampaign result = apiInstance.GetSmsCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.GetSmsCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the SMS campaign | 

### Return type

[**GetSmsCampaign**](GetSmsCampaign.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmscampaigns"></a>
# **GetSmsCampaigns**
> GetSmsCampaigns GetSmsCampaigns (string status = null, string startDate = null, string endDate = null, long? limit = null, long? offset = null, string sort = null)

Returns the information for all your created SMS campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSmsCampaignsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var status = status_example;  // string | Status of campaign. (optional) 
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var limit = 789;  // long? | Number limitation for the result returned (optional)  (default to 500)
            var offset = 789;  // long? | Beginning point in the list to retrieve from. (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Returns the information for all your created SMS campaigns
                GetSmsCampaigns result = apiInstance.GetSmsCampaigns(status, startDate, endDate, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.GetSmsCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Status of campaign. | [optional] 
 **startDate** | **string**| Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional] 
 **limit** | **long?**| Number limitation for the result returned | [optional] [default to 500]
 **offset** | **long?**| Beginning point in the list to retrieve from. | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetSmsCampaigns**](GetSmsCampaigns.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestsmsrecipientexport"></a>
# **RequestSmsRecipientExport**
> CreatedProcessId RequestSmsRecipientExport (long? campaignId, RequestSmsRecipientExport recipientExport = null)

Export an SMS campaign's recipients

It returns the background process ID which on completion calls the notify URL that you have set in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class RequestSmsRecipientExportExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the campaign
            var recipientExport = new RequestSmsRecipientExport(); // RequestSmsRecipientExport | Values to send for a recipient export request (optional) 

            try
            {
                // Export an SMS campaign's recipients
                CreatedProcessId result = apiInstance.RequestSmsRecipientExport(campaignId, recipientExport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.RequestSmsRecipientExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the campaign | 
 **recipientExport** | [**RequestSmsRecipientExport**](RequestSmsRecipientExport.md)| Values to send for a recipient export request | [optional] 

### Return type

[**CreatedProcessId**](CreatedProcessId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmscampaignnow"></a>
# **SendSmsCampaignNow**
> void SendSmsCampaignNow (long? campaignId)

Send your SMS campaign immediately

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendSmsCampaignNowExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the campaign

            try
            {
                // Send your SMS campaign immediately
                apiInstance.SendSmsCampaignNow(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.SendSmsCampaignNow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmsreport"></a>
# **SendSmsReport**
> void SendSmsReport (long? campaignId, SendReport sendReport)

Send an SMS campaign's report

Send report of Sent and Archived campaign, to the specified email addresses, with respective data and a pdf attachment in detail.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendSmsReportExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the campaign
            var sendReport = new SendReport(); // SendReport | Values for send a report

            try
            {
                // Send an SMS campaign's report
                apiInstance.SendSmsReport(campaignId, sendReport);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.SendSmsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the campaign | 
 **sendReport** | [**SendReport**](SendReport.md)| Values for send a report | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtestsms"></a>
# **SendTestSms**
> void SendTestSms (long? campaignId, SendTestSms phoneNumber)

Send a test SMS campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendTestSmsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | Id of the SMS campaign
            var phoneNumber = new SendTestSms(); // SendTestSms | Mobile number of the recipient with the country code. This number must belong to one of your contacts in Brevo account and must not be blacklisted

            try
            {
                // Send a test SMS campaign
                apiInstance.SendTestSms(campaignId, phoneNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.SendTestSms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the SMS campaign | 
 **phoneNumber** | [**SendTestSms**](SendTestSms.md)| Mobile number of the recipient with the country code. This number must belong to one of your contacts in Brevo account and must not be blacklisted | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesmscampaign"></a>
# **UpdateSmsCampaign**
> void UpdateSmsCampaign (long? campaignId, UpdateSmsCampaign updateSmsCampaign)

Update an SMS campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateSmsCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the SMS campaign
            var updateSmsCampaign = new UpdateSmsCampaign(); // UpdateSmsCampaign | Values to update an SMS Campaign

            try
            {
                // Update an SMS campaign
                apiInstance.UpdateSmsCampaign(campaignId, updateSmsCampaign);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.UpdateSmsCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the SMS campaign | 
 **updateSmsCampaign** | [**UpdateSmsCampaign**](UpdateSmsCampaign.md)| Values to update an SMS Campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesmscampaignstatus"></a>
# **UpdateSmsCampaignStatus**
> void UpdateSmsCampaignStatus (long? campaignId, UpdateCampaignStatus status)

Update a campaign's status

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateSmsCampaignStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new SMSCampaignsApi();
            var campaignId = 789;  // long? | id of the campaign
            var status = new UpdateCampaignStatus(); // UpdateCampaignStatus | Status of the campaign.

            try
            {
                // Update a campaign's status
                apiInstance.UpdateSmsCampaignStatus(campaignId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.UpdateSmsCampaignStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the campaign | 
 **status** | [**UpdateCampaignStatus**](UpdateCampaignStatus.md)| Status of the campaign. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

