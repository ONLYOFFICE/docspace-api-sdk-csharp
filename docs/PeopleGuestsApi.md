# Docspace.Api.PeopleGuestsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteGuests**](PeopleGuestsApi.md#deleteguests) | **DELETE** /api/2.0/people/guests | Removes guests from the list and from rooms |

<a id="deleteguests"></a>
# **DeleteGuests**
> void DeleteGuests (UpdateMembersRequestDto? updateMembersRequestDto = null)

Removes guests from the list and from rooms

Removes guests from the list and excludes them from rooms to which you have invited them

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class DeleteGuestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleGuestsApi(httpClient, config, httpClientHandler);
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? |  (optional) 

            try
            {
                // Removes guests from the list and from rooms
                apiInstance.DeleteGuests(updateMembersRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleGuestsApi.DeleteGuests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGuestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes guests from the list and from rooms
    apiInstance.DeleteGuestsWithHttpInfo(updateMembersRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleGuestsApi.DeleteGuestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateMembersRequestDto** | [**UpdateMembersRequestDto?**](UpdateMembersRequestDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request parameters for deleting guests |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

