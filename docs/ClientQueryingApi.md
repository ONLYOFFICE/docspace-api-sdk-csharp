# Docspace.Api.ClientQueryingApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetClient**](ClientQueryingApi.md#getclient) | **GET** /api/2.0/clients/{clientId} | Get client details |
| [**GetClientInfo**](ClientQueryingApi.md#getclientinfo) | **GET** /api/2.0/clients/{clientId}/info | Retrieves detailed information for a specific client |
| [**GetClients**](ClientQueryingApi.md#getclients) | **GET** /api/2.0/clients | List clients |
| [**GetClientsInfo**](ClientQueryingApi.md#getclientsinfo) | **GET** /api/2.0/clients/info | Retrieves a pageable list of client information |
| [**GetConsents**](ClientQueryingApi.md#getconsents) | **GET** /api/2.0/clients/consents | Retrieves a pageable list of consents |
| [**GetPublicClientInfo**](ClientQueryingApi.md#getpublicclientinfo) | **GET** /api/2.0/clients/{clientId}/public/info | Handles the GET request for public client information |

<a id="getclient"></a>
# **GetClient**
> ClientResponse GetClient (string clientId)

Get client details

Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.

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
    public class GetClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientQueryingApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to retrieve

            try
            {
                // Get client details
                ClientResponse result = apiInstance.GetClient(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientQueryingApi.GetClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get client details
    ApiResponse<ClientResponse> response = apiInstance.GetClientWithHttpInfo(clientId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientQueryingApi.GetClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to retrieve |  |

### Return type

[**ClientResponse**](ClientResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client details successfully retrieved |  -  |
| **400** | Invalid client ID format |  -  |
| **403** | Insufficient permissions to view client |  -  |
| **404** | Client not found |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclientinfo"></a>
# **GetClientInfo**
> ClientInfoResponse GetClientInfo (string clientId)

Retrieves detailed information for a specific client

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
    public class GetClientInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientQueryingApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to retrieve

            try
            {
                // Retrieves detailed information for a specific client
                ClientInfoResponse result = apiInstance.GetClientInfo(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientQueryingApi.GetClientInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves detailed information for a specific client
    ApiResponse<ClientInfoResponse> response = apiInstance.GetClientInfoWithHttpInfo(clientId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientQueryingApi.GetClientInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to retrieve |  |

### Return type

[**ClientInfoResponse**](ClientInfoResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved client info |  -  |
| **400** | Bad request |  -  |
| **429** | Too many requests |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclients"></a>
# **GetClients**
> PageableResponse GetClients (int limit, string? lastClientId = null, DateTime? lastCreatedOn = null)

List clients

Retrieves a paginated list of OAuth2 clients. The results can be paginated using the limit parameter and last seen client ID/creation date.

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
    public class GetClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientQueryingApi(httpClient, config, httpClientHandler);
            var limit = 1;  // int | Pagination limit
            var lastClientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string? | ID of the last retrieved client (optional) 
            var lastCreatedOn = 2024-04-04T12:00:00Z;  // DateTime? | Date of the last retrieved client (optional) 

            try
            {
                // List clients
                PageableResponse result = apiInstance.GetClients(limit, lastClientId, lastCreatedOn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientQueryingApi.GetClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List clients
    ApiResponse<PageableResponse> response = apiInstance.GetClientsWithHttpInfo(limit, lastClientId, lastCreatedOn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientQueryingApi.GetClientsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Pagination limit |  |
| **lastClientId** | **string?** | ID of the last retrieved client | [optional]  |
| **lastCreatedOn** | **DateTime?** | Date of the last retrieved client | [optional]  |

### Return type

[**PageableResponse**](PageableResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client list successfully retrieved |  -  |
| **400** | Invalid pagination parameters |  -  |
| **403** | Insufficient permissions to list clients |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclientsinfo"></a>
# **GetClientsInfo**
> PageableResponseClientInfoResponse GetClientsInfo (int limit, string? lastClientId = null, DateTime? lastCreatedOn = null)

Retrieves a pageable list of client information

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
    public class GetClientsInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientQueryingApi(httpClient, config, httpClientHandler);
            var limit = 1;  // int | Pagination limit
            var lastClientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string? | ID of the last retrieved client (optional) 
            var lastCreatedOn = 2024-04-04T12:00:00Z;  // DateTime? | Date of the last retrieved client (optional) 

            try
            {
                // Retrieves a pageable list of client information
                PageableResponseClientInfoResponse result = apiInstance.GetClientsInfo(limit, lastClientId, lastCreatedOn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientQueryingApi.GetClientsInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientsInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a pageable list of client information
    ApiResponse<PageableResponseClientInfoResponse> response = apiInstance.GetClientsInfoWithHttpInfo(limit, lastClientId, lastCreatedOn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientQueryingApi.GetClientsInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Pagination limit |  |
| **lastClientId** | **string?** | ID of the last retrieved client | [optional]  |
| **lastCreatedOn** | **DateTime?** | Date of the last retrieved client | [optional]  |

### Return type

[**PageableResponseClientInfoResponse**](PageableResponseClientInfoResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved clients info |  -  |
| **400** | Bad request |  -  |
| **429** | Too many requests |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconsents"></a>
# **GetConsents**
> PageableModificationResponse GetConsents (int limit, DateTime? lastModifiedOn = null)

Retrieves a pageable list of consents

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
    public class GetConsentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientQueryingApi(httpClient, config, httpClientHandler);
            var limit = 1;  // int | Pagination limit
            var lastModifiedOn = 2024-04-04T12:00:00Z;  // DateTime? | Date of the last retrieved consent (optional) 

            try
            {
                // Retrieves a pageable list of consents
                PageableModificationResponse result = apiInstance.GetConsents(limit, lastModifiedOn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientQueryingApi.GetConsents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConsentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a pageable list of consents
    ApiResponse<PageableModificationResponse> response = apiInstance.GetConsentsWithHttpInfo(limit, lastModifiedOn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientQueryingApi.GetConsentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Pagination limit |  |
| **lastModifiedOn** | **DateTime?** | Date of the last retrieved consent | [optional]  |

### Return type

[**PageableModificationResponse**](PageableModificationResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved user consents |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpublicclientinfo"></a>
# **GetPublicClientInfo**
> ClientInfoResponse GetPublicClientInfo (string clientId)

Handles the GET request for public client information

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
    public class GetPublicClientInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientQueryingApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to retrieve

            try
            {
                // Handles the GET request for public client information
                ClientInfoResponse result = apiInstance.GetPublicClientInfo(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientQueryingApi.GetPublicClientInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublicClientInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles the GET request for public client information
    ApiResponse<ClientInfoResponse> response = apiInstance.GetPublicClientInfoWithHttpInfo(clientId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientQueryingApi.GetPublicClientInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to retrieve |  |

### Return type

[**ClientInfoResponse**](ClientInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved client public info |  -  |
| **400** | Bad request |  -  |
| **429** | Too many requests |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

