# DocSpace.API.SDK.Api.AssignmentsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewAiAssignmentsAssign**](#newaiassignmentsassign) | **PUT** /api/2.0/ai/assignments/assign | Assign |
| [**NewAiAssignmentsBulkAssign**](#newaiassignmentsbulkassign) | **PUT** /api/2.0/ai/assignments/bulk-assign | Bulk assign |
| [**NewAiAssignmentsCascadeProfileDelete**](#newaiassignmentscascadeprofiledelete) | **DELETE** /api/2.0/ai/assignments/cascade-profile-delete | Cascade profile delete |
| [**NewAiAssignmentsGetAllAssignments**](#newaiassignmentsgetallassignments) | **GET** /api/2.0/ai/assignments/get-all-assignments | Get all assignments |
| [**NewAiAssignmentsGetAssignment**](#newaiassignmentsgetassignment) | **GET** /api/2.0/ai/assignments/get-assignment | Get assignment |
| [**NewAiAssignmentsResolveForAction**](#newaiassignmentsresolveforaction) | **GET** /api/2.0/ai/assignments/resolve-for-action | Resolve for action |
| [**NewAiAssignmentsTryResolveForAction**](#newaiassignmentstryresolveforaction) | **GET** /api/2.0/ai/assignments/try-resolve-for-action | Try resolve for action |
| [**NewAiAssignmentsUnassign**](#newaiassignmentsunassign) | **DELETE** /api/2.0/ai/assignments/unassign | Unassign |

<a id="newaiassignmentsassign"></a>
# **NewAiAssignmentsAssign**
> NewAiAssignmentMutationResult NewAiAssignmentsAssign (NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAssignmentsAssignRequest** | [**NewAiAssignmentsAssignRequest**](NewAiAssignmentsAssignRequest.md) |  |  |

### Return type

[**NewAiAssignmentMutationResult**](NewAiAssignmentMutationResult.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsAssignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var newAiAssignmentsAssignRequest = new NewAiAssignmentsAssignRequest(); // NewAiAssignmentsAssignRequest | 

            try
            {
                // Assign
                NewAiAssignmentMutationResult result = apiInstance.NewAiAssignmentsAssign(newAiAssignmentsAssignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign
    ApiResponse<NewAiAssignmentMutationResult> response = apiInstance.NewAiAssignmentsAssignWithHttpInfo(newAiAssignmentsAssignRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentsbulkassign"></a>
# **NewAiAssignmentsBulkAssign**
> NewAiBulkAssignmentResult NewAiAssignmentsBulkAssign (Dictionary<string, string> requestBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md) |  |  |

### Return type

[**NewAiBulkAssignmentResult**](NewAiBulkAssignmentResult.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsBulkAssignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | 

            try
            {
                // Bulk assign
                NewAiBulkAssignmentResult result = apiInstance.NewAiAssignmentsBulkAssign(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsBulkAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsBulkAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk assign
    ApiResponse<NewAiBulkAssignmentResult> response = apiInstance.NewAiAssignmentsBulkAssignWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsBulkAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentscascadeprofiledelete"></a>
# **NewAiAssignmentsCascadeProfileDelete**
> NewAiSuccessResponse NewAiAssignmentsCascadeProfileDelete (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

### Return type

[**NewAiSuccessResponse**](NewAiSuccessResponse.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsCascadeProfileDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | 

            try
            {
                // Cascade profile delete
                NewAiSuccessResponse result = apiInstance.NewAiAssignmentsCascadeProfileDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsCascadeProfileDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsCascadeProfileDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cascade profile delete
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiAssignmentsCascadeProfileDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsCascadeProfileDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentsgetallassignments"></a>
# **NewAiAssignmentsGetAllAssignments**
> Dictionary&lt;string, string&gt; NewAiAssignmentsGetAllAssignments (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsGetAllAssignmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // Get all assignments
                Dictionary<string, string> result = apiInstance.NewAiAssignmentsGetAllAssignments(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsGetAllAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsGetAllAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all assignments
    ApiResponse<Dictionary<string, string>> response = apiInstance.NewAiAssignmentsGetAllAssignmentsWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsGetAllAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentsgetassignment"></a>
# **NewAiAssignmentsGetAssignment**
> string NewAiAssignmentsGetAssignment (string actionType)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actionType** | **string** |  |  |

### Return type

**string**

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsGetAssignmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var actionType = "actionType_example";  // string | 

            try
            {
                // Get assignment
                string result = apiInstance.NewAiAssignmentsGetAssignment(actionType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsGetAssignment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsGetAssignmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get assignment
    ApiResponse<string> response = apiInstance.NewAiAssignmentsGetAssignmentWithHttpInfo(actionType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsGetAssignmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentsresolveforaction"></a>
# **NewAiAssignmentsResolveForAction**
> NewAiResolvedAssignment NewAiAssignmentsResolveForAction (string actionType, string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actionType** | **string** |  |  |
| **entityId** | **string** |  |  |

### Return type

[**NewAiResolvedAssignment**](NewAiResolvedAssignment.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsResolveForActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var actionType = "actionType_example";  // string | 
            var entityId = "entityId_example";  // string | 

            try
            {
                // Resolve for action
                NewAiResolvedAssignment result = apiInstance.NewAiAssignmentsResolveForAction(actionType, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsResolveForAction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsResolveForActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resolve for action
    ApiResponse<NewAiResolvedAssignment> response = apiInstance.NewAiAssignmentsResolveForActionWithHttpInfo(actionType, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsResolveForActionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentstryresolveforaction"></a>
# **NewAiAssignmentsTryResolveForAction**
> NewAiResolvedAssignment NewAiAssignmentsTryResolveForAction (string actionType, string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actionType** | **string** |  |  |
| **entityId** | **string** |  |  |

### Return type

[**NewAiResolvedAssignment**](NewAiResolvedAssignment.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsTryResolveForActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var actionType = "actionType_example";  // string | 
            var entityId = "entityId_example";  // string | 

            try
            {
                // Try resolve for action
                NewAiResolvedAssignment result = apiInstance.NewAiAssignmentsTryResolveForAction(actionType, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsTryResolveForAction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsTryResolveForActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Try resolve for action
    ApiResponse<NewAiResolvedAssignment> response = apiInstance.NewAiAssignmentsTryResolveForActionWithHttpInfo(actionType, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsTryResolveForActionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiassignmentsunassign"></a>
# **NewAiAssignmentsUnassign**
> NewAiSuccessResponse NewAiAssignmentsUnassign (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

### Return type

[**NewAiSuccessResponse**](NewAiSuccessResponse.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class NewAiAssignmentsUnassignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssignmentsApi(httpClient, config, httpClientHandler);
            var body = null;  // string | 

            try
            {
                // Unassign
                NewAiSuccessResponse result = apiInstance.NewAiAssignmentsUnassign(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsUnassign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAssignmentsUnassignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unassign
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiAssignmentsUnassignWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.NewAiAssignmentsUnassignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

