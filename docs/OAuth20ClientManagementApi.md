# DocSpace.API.SDK.Api.ClientManagementApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeActivation**](#changeactivation) | **PATCH** /api/2.0/oauth2/clients/{clientId}/activation | Change client activation status |
| [**CreateClient**](#createclient) | **POST** /api/2.0/oauth2/clients | Create a new OAuth2 client |
| [**DeleteClient**](#deleteclient) | **DELETE** /api/2.0/oauth2/clients/{clientId} | Delete an OAuth2 client |
| [**DeleteTenantClients**](#deletetenantclients) | **DELETE** /api/2.0/oauth2/clients/tenant | Delete all tenant OAuth2 clients |
| [**DeleteUserClients**](#deleteuserclients) | **DELETE** /api/2.0/oauth2/clients | Delete all user OAuth2 clients |
| [**RegenerateSecret**](#regeneratesecret) | **PATCH** /api/2.0/oauth2/clients/{clientId}/regenerate | Regenerate client secret |
| [**RevokeUserClient**](#revokeuserclient) | **DELETE** /api/2.0/oauth2/clients/{clientId}/revoke | Revoke client consent |
| [**UpdateClient**](#updateclient) | **PUT** /api/2.0/oauth2/clients/{clientId} | Update an existing OAuth2 client |

<a id="changeactivation"></a>
# **ChangeActivation**
> void ChangeActivation (string clientId, ChangeClientActivationRequest changeClientActivationRequest)

Enables or disables an existing client and answers 200 with an empty body. A disabled client can no longer obtain new tokens, but the tokens and consents it already holds stay valid until they expire on their own: disable a client to stop new authorizations, delete it to end the existing ones. An administrator may change any client of the tenant, a plain user only the clients they created. The body carries the single activation flag, and a client the caller may not see is reported as not found rather than as forbidden.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to change activation for |  |
| **changeClientActivationRequest** | [**ChangeClientActivationRequest**](ChangeClientActivationRequest.md) | Client activation change request |  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class ChangeActivationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to change activation for
            var changeClientActivationRequest = new ChangeClientActivationRequest(); // ChangeClientActivationRequest | Client activation change request

            try
            {
                // Change client activation status
                apiInstance.ChangeActivation(clientId, changeClientActivationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.ChangeActivation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeActivationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change client activation status
    apiInstance.ChangeActivationWithHttpInfo(clientId, changeClientActivationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.ChangeActivationWithHttpInfo: " + e.Message);
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
| **200** | Client activation status successfully changed |  -  |
| **400** | The client ID is blank, or the activation status is missing |  -  |
| **403** | Insufficient permissions to change client activation |  -  |
| **404** | No client with this ID is visible to the caller, or the ID cannot be parsed as a client ID |  -  |
| **415** | The Content-Type header is not application/json |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createclient"></a>
# **CreateClient**
> ClientResponse CreateClient (CreateClientRequest createClientRequest)

Registers a new OAuth2 client in the caller's tenant and returns it. The body must carry a name, a description, a logo and at least one redirect URI, allowed origin and scope, and every scope named must already exist in the tenant's scope catalogue. Administrators and users may both register clients; the caller is recorded as the creator, which is what later restricts a plain user to the clients they created. The response is the stored client with its generated client ID and secret, and it is the first place either value can be read. Some deployments cap how many clients one tenant may hold, and reaching that cap is reported as 400 together with the validation failures.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createClientRequest** | [**CreateClientRequest**](CreateClientRequest.md) | Client creation request containing client details |  |

### Return type

[**ClientResponse**](ClientResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class CreateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);
            var createClientRequest = new CreateClientRequest(); // CreateClientRequest | Client creation request containing client details

            try
            {
                // Create a new OAuth2 client
                ClientResponse result = apiInstance.CreateClient(createClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.CreateClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new OAuth2 client
    ApiResponse<ClientResponse> response = apiInstance.CreateClientWithHttpInfo(createClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.CreateClientWithHttpInfo: " + e.Message);
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
| **201** | Client successfully created |  -  |
| **400** | Missing required fields, validation failed, an unknown scope was requested, or the client limit for this tenant has been reached |  -  |
| **403** | Insufficient permissions to create client |  -  |
| **415** | The Content-Type header is not application/json |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (string clientId)

Deletes one client from the tenant permanently and answers 200 with an empty body. An administrator may delete any client of the tenant, a plain user only the clients they created, and a client the caller may not see is reported as not found rather than as forbidden. The authorizations and consents issued for the client are removed too, but that cleanup is driven by a message and completes on the authorization service after this call has already returned. A delete that removes no row answers 400. The operation cannot be undone.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to delete |  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class DeleteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to delete

            try
            {
                // Delete an OAuth2 client
                apiInstance.DeleteClient(clientId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.DeleteClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an OAuth2 client
    apiInstance.DeleteClientWithHttpInfo(clientId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.DeleteClientWithHttpInfo: " + e.Message);
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
| **200** | Client successfully deleted |  -  |
| **400** | The client ID is blank, or the client could not be deleted |  -  |
| **403** | Insufficient permissions to delete client |  -  |
| **404** | No client with this ID is visible to the caller, or the ID cannot be parsed as a client ID |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenantclients"></a>
# **DeleteTenantClients**
> void DeleteTenantClients ()

Deletes every client registered in the current tenant and answers 200 with an empty body. Only an administrator may call it - for a plain user or a guest it is refused with 403 - and it removes the clients of all users of the tenant, not only those of the caller. The authorizations and consents of the deleted clients are cleaned up asynchronously on the authorization service, and the tenant's client cache is dropped as part of the call. Concurrent modification that survives the retries is reported as 400. The operation cannot be undone, and the response does not say how many clients were removed.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-tenant-clients/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class DeleteTenantClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);

            try
            {
                // Delete all tenant OAuth2 clients
                apiInstance.DeleteTenantClients();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.DeleteTenantClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all tenant OAuth2 clients
    apiInstance.DeleteTenantClientsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.DeleteTenantClientsWithHttpInfo: " + e.Message);
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
| **200** | Client successfully deleted |  -  |
| **400** | The clients could not be deleted because of concurrent modification |  -  |
| **403** | Insufficient permissions to delete tenant clients |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuserclients"></a>
# **DeleteUserClients**
> void DeleteUserClients ()

Deletes every client the calling user created in the current tenant and answers 200 with an empty body. The caller's own identity always selects the set, so this never reaches clients created by somebody else, not even for an administrator. The authorizations and consents of the deleted clients are cleaned up asynchronously on the authorization service, and the tenant's client cache is dropped as part of the call. Concurrent modification that survives the retries is reported as 400. The operation cannot be undone, and the response does not say how many clients were removed.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-user-clients/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class DeleteUserClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);

            try
            {
                // Delete all user OAuth2 clients
                apiInstance.DeleteUserClients();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.DeleteUserClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all user OAuth2 clients
    apiInstance.DeleteUserClientsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.DeleteUserClientsWithHttpInfo: " + e.Message);
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
| **200** | Client successfully deleted |  -  |
| **400** | The clients could not be deleted because of concurrent modification |  -  |
| **403** | Insufficient permissions to delete user clients |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="regeneratesecret"></a>
# **RegenerateSecret**
> ClientSecretResponse RegenerateSecret (string clientId)

Issues a new secret for the client and returns it. The previous secret stops working as soon as this call succeeds, there is no grace period and no way to recover it, so every deployed copy of the client has to be updated with the value returned here. An administrator may do this for any client of the tenant, a plain user only for the clients they created. Tokens already issued to the client keep working; only future client authentication is affected. The response carries the new secret and nothing else.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to regenerate secret for |  |

### Return type

[**ClientSecretResponse**](ClientSecretResponse.md)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class RegenerateSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to regenerate secret for

            try
            {
                // Regenerate client secret
                ClientSecretResponse result = apiInstance.RegenerateSecret(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.RegenerateSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegenerateSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate client secret
    ApiResponse<ClientSecretResponse> response = apiInstance.RegenerateSecretWithHttpInfo(clientId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.RegenerateSecretWithHttpInfo: " + e.Message);
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
| **200** | Client secret successfully regenerated |  -  |
| **400** | The client ID is blank or contains only whitespace |  -  |
| **403** | Insufficient permissions to regenerate client secret |  -  |
| **404** | No client with this ID is visible to the caller, or the ID cannot be parsed as a client ID |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="revokeuserclient"></a>
# **RevokeUserClient**
> void RevokeUserClient (string clientId)

Revokes the calling user's own consent for one client and answers 200 with an empty body. It touches only the caller's grant: other users keep their consents and the client itself stays registered. Guests may call it as well as users and administrators, because it can never reach anyone else's data. The revocation is carried out by the authorization service over gRPC, so a service that reports nothing was revoked produces 400 and a service that cannot be reached produces 503. Once it succeeds the user has to authorize the client again before it can act on their behalf.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to revoke consent for |  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class RevokeUserClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to revoke consent for

            try
            {
                // Revoke client consent
                apiInstance.RevokeUserClient(clientId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.RevokeUserClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokeUserClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Revoke client consent
    apiInstance.RevokeUserClientWithHttpInfo(clientId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.RevokeUserClientWithHttpInfo: " + e.Message);
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
| **200** | Client consent successfully revoked |  -  |
| **400** | The client ID is blank, or the authorization service reported that the consent was not revoked |  -  |
| **403** | Insufficient permissions to revoke consent |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **503** | Authorization service unavailable |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateclient"></a>
# **UpdateClient**
> void UpdateClient (string clientId, UpdateClientRequest updateClientRequest)

Updates the mutable settings of an existing client and answers 200 with an empty body. Only the fields carried in the request body change; the client ID, the secret, the tenant and the creator cannot be changed this way. An administrator may update any client of the tenant, a plain user only the clients they created, and a client the caller may not see is reported as not found rather than as forbidden. The write runs under optimistic locking and is retried a few times, so a request that still loses the race is rejected with 400 instead of silently overwriting a concurrent change. Nothing is returned in the body - read the client back to see the stored result.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ID of the client to update |  |
| **updateClientRequest** | [**UpdateClientRequest**](UpdateClientRequest.md) | Client update request containing modified client details |  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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
    public class UpdateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClientManagementApi(httpClient, config, httpClientHandler);
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | ID of the client to update
            var updateClientRequest = new UpdateClientRequest(); // UpdateClientRequest | Client update request containing modified client details

            try
            {
                // Update an existing OAuth2 client
                apiInstance.UpdateClient(clientId, updateClientRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientManagementApi.UpdateClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing OAuth2 client
    apiInstance.UpdateClientWithHttpInfo(clientId, updateClientRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientManagementApi.UpdateClientWithHttpInfo: " + e.Message);
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
| **200** | Client successfully updated |  -  |
| **400** | Missing required fields, validation failed, or the client could not be updated because of concurrent modification |  -  |
| **403** | Insufficient permissions to update client |  -  |
| **404** | No client with this ID is visible to the caller, or the ID cannot be parsed as a client ID |  -  |
| **415** | The Content-Type header is not application/json |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |
| **405** | The HTTP method is not allowed for this path |  -  |
| **406** | The Accept header does not allow application/json |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

