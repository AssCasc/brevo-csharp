# brevo_csharp.Api.ProcessApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProcess**](ProcessApi.md#getprocess) | **GET** /processes/{processId} | Return the informations for a process
[**GetProcesses**](ProcessApi.md#getprocesses) | **GET** /processes | Return all the processes for your account


<a name="getprocess"></a>
# **GetProcess**
> GetProcess GetProcess (long? processId)

Return the informations for a process

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetProcessExample
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

            var apiInstance = new ProcessApi();
            var processId = 789;  // long? | Id of the process

            try
            {
                // Return the informations for a process
                GetProcess result = apiInstance.GetProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessApi.GetProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **long?**| Id of the process | 

### Return type

[**GetProcess**](GetProcess.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocesses"></a>
# **GetProcesses**
> GetProcesses GetProcesses (long? limit = null, long? offset = null, string sort = null)

Return all the processes for your account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetProcessesExample
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

            var apiInstance = new ProcessApi();
            var limit = 789;  // long? | Number limitation for the result returned (optional)  (default to 10)
            var offset = 789;  // long? | Beginning point in the list to retrieve from. (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Return all the processes for your account
                GetProcesses result = apiInstance.GetProcesses(limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessApi.GetProcesses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number limitation for the result returned | [optional] [default to 10]
 **offset** | **long?**| Beginning point in the list to retrieve from. | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetProcesses**](GetProcesses.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

