# brevo_csharp.Api.TransactionalSMSApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSmsEvents**](TransactionalSMSApi.md#getsmsevents) | **GET** /transactionalSMS/statistics/events | Get all your SMS activity (unaggregated events)
[**GetTransacAggregatedSmsReport**](TransactionalSMSApi.md#gettransacaggregatedsmsreport) | **GET** /transactionalSMS/statistics/aggregatedReport | Get your SMS activity aggregated over a period of time
[**GetTransacSmsReport**](TransactionalSMSApi.md#gettransacsmsreport) | **GET** /transactionalSMS/statistics/reports | Get your SMS activity aggregated per day
[**SendTransacSms**](TransactionalSMSApi.md#sendtransacsms) | **POST** /transactionalSMS/sms | Send SMS message to a mobile number


<a name="getsmsevents"></a>
# **GetSmsEvents**
> GetSmsEventReport GetSmsEvents (long? limit = null, string startDate = null, string endDate = null, long? offset = null, long? days = null, string phoneNumber = null, string _event = null, string tags = null, string sort = null)

Get all your SMS activity (unaggregated events)

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSmsEventsExample
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

            var apiInstance = new TransactionalSMSApi();
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report (optional) 
            var offset = 789;  // long? | Index of the first document of the page (optional)  (default to 0)
            var days = 789;  // long? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var phoneNumber = phoneNumber_example;  // string | Filter the report for a specific phone number (optional) 
            var _event = _event_example;  // string | Filter the report for specific events (optional) 
            var tags = tags_example;  // string | Filter the report for specific tags passed as a serialized urlencoded array (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get all your SMS activity (unaggregated events)
                GetSmsEventReport result = apiInstance.GetSmsEvents(limit, startDate, endDate, offset, days, phoneNumber, _event, tags, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.GetSmsEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report | [optional] 
 **offset** | **long?**| Index of the first document of the page | [optional] [default to 0]
 **days** | **long?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **phoneNumber** | **string**| Filter the report for a specific phone number | [optional] 
 **_event** | **string**| Filter the report for specific events | [optional] 
 **tags** | **string**| Filter the report for specific tags passed as a serialized urlencoded array | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetSmsEventReport**](GetSmsEventReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacaggregatedsmsreport"></a>
# **GetTransacAggregatedSmsReport**
> GetTransacAggregatedSmsReport GetTransacAggregatedSmsReport (string startDate = null, string endDate = null, long? days = null, string tag = null)

Get your SMS activity aggregated over a period of time

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetTransacAggregatedSmsReportExample
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

            var apiInstance = new TransactionalSMSApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report (optional) 
            var days = 789;  // long? | Number of days in the past including today (positive integer). Not compatible with startDate and endDate (optional) 
            var tag = tag_example;  // string | Filter on a tag (optional) 

            try
            {
                // Get your SMS activity aggregated over a period of time
                GetTransacAggregatedSmsReport result = apiInstance.GetTransacAggregatedSmsReport(startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.GetTransacAggregatedSmsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report | [optional] 
 **days** | **long?**| Number of days in the past including today (positive integer). Not compatible with startDate and endDate | [optional] 
 **tag** | **string**| Filter on a tag | [optional] 

### Return type

[**GetTransacAggregatedSmsReport**](GetTransacAggregatedSmsReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacsmsreport"></a>
# **GetTransacSmsReport**
> GetTransacSmsReport GetTransacSmsReport (string startDate = null, string endDate = null, long? days = null, string tag = null, string sort = null)

Get your SMS activity aggregated per day

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetTransacSmsReportExample
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

            var apiInstance = new TransactionalSMSApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report (optional) 
            var days = 789;  // long? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = tag_example;  // string | Filter on a tag (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get your SMS activity aggregated per day
                GetTransacSmsReport result = apiInstance.GetTransacSmsReport(startDate, endDate, days, tag, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.GetTransacSmsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report | [optional] 
 **days** | **long?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **tag** | **string**| Filter on a tag | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetTransacSmsReport**](GetTransacSmsReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtransacsms"></a>
# **SendTransacSms**
> SendSms SendTransacSms (SendTransacSms sendTransacSms)

Send SMS message to a mobile number

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendTransacSmsExample
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

            var apiInstance = new TransactionalSMSApi();
            var sendTransacSms = new SendTransacSms(); // SendTransacSms | Values to send a transactional SMS

            try
            {
                // Send SMS message to a mobile number
                SendSms result = apiInstance.SendTransacSms(sendTransacSms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.SendTransacSms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendTransacSms** | [**SendTransacSms**](SendTransacSms.md)| Values to send a transactional SMS | 

### Return type

[**SendSms**](SendSms.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

