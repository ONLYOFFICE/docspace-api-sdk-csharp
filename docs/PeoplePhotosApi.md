# Docspace.Api.PeoplePhotosApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMemberPhotoThumbnails**](PeoplePhotosApi.md#creatememberphotothumbnails) | **POST** /api/2.0/people/{userid}/photo/thumbnails | Create photo thumbnails |
| [**DeleteMemberPhoto**](PeoplePhotosApi.md#deletememberphoto) | **DELETE** /api/2.0/people/{userid}/photo | Delete a user photo |
| [**GetMemberPhoto**](PeoplePhotosApi.md#getmemberphoto) | **GET** /api/2.0/people/{userid}/photo | Get a user photo |
| [**UpdateMemberPhoto**](PeoplePhotosApi.md#updatememberphoto) | **PUT** /api/2.0/people/{userid}/photo | Update a user photo |
| [**UploadMemberPhoto**](PeoplePhotosApi.md#uploadmemberphoto) | **POST** /api/2.0/people/{userid}/photo | Upload a user photo |

<a id="creatememberphotothumbnails"></a>
# **CreateMemberPhotoThumbnails**
> ThumbnailsDataWrapper CreateMemberPhotoThumbnails (string userid, ThumbnailsRequest? thumbnailsRequest = null)

Create photo thumbnails

Creates photo thumbnails by coordinates of the original image specified in the request.

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
    public class CreateMemberPhotoThumbnailsExample
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
            var apiInstance = new PeoplePhotosApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID
            var thumbnailsRequest = new ThumbnailsRequest?(); // ThumbnailsRequest? | Thumbnails (optional) 

            try
            {
                // Create photo thumbnails
                ThumbnailsDataWrapper result = apiInstance.CreateMemberPhotoThumbnails(userid, thumbnailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePhotosApi.CreateMemberPhotoThumbnails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMemberPhotoThumbnailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create photo thumbnails
    ApiResponse<ThumbnailsDataWrapper> response = apiInstance.CreateMemberPhotoThumbnailsWithHttpInfo(userid, thumbnailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeoplePhotosApi.CreateMemberPhotoThumbnailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |
| **thumbnailsRequest** | [**ThumbnailsRequest?**](ThumbnailsRequest?.md) | Thumbnails | [optional]  |

### Return type

[**ThumbnailsDataWrapper**](ThumbnailsDataWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Thumbnail parameters |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletememberphoto"></a>
# **DeleteMemberPhoto**
> ThumbnailsDataWrapper DeleteMemberPhoto (string userid)

Delete a user photo

Deletes a photo of the user with the ID specified in the request.

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
    public class DeleteMemberPhotoExample
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
            var apiInstance = new PeoplePhotosApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID

            try
            {
                // Delete a user photo
                ThumbnailsDataWrapper result = apiInstance.DeleteMemberPhoto(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePhotosApi.DeleteMemberPhoto: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMemberPhotoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a user photo
    ApiResponse<ThumbnailsDataWrapper> response = apiInstance.DeleteMemberPhotoWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeoplePhotosApi.DeleteMemberPhotoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |

### Return type

[**ThumbnailsDataWrapper**](ThumbnailsDataWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Thumbnail parameters: original photo, retina, maximum size photo, big, medium, small |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmemberphoto"></a>
# **GetMemberPhoto**
> ThumbnailsDataWrapper GetMemberPhoto (string userid)

Get a user photo

Returns a photo of the user with the ID specified in the request.

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
    public class GetMemberPhotoExample
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
            var apiInstance = new PeoplePhotosApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID

            try
            {
                // Get a user photo
                ThumbnailsDataWrapper result = apiInstance.GetMemberPhoto(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePhotosApi.GetMemberPhoto: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberPhotoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user photo
    ApiResponse<ThumbnailsDataWrapper> response = apiInstance.GetMemberPhotoWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeoplePhotosApi.GetMemberPhotoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |

### Return type

[**ThumbnailsDataWrapper**](ThumbnailsDataWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Thumbnail parameters: original photo, retina, maximum size photo, big, medium, small |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatememberphoto"></a>
# **UpdateMemberPhoto**
> ThumbnailsDataWrapper UpdateMemberPhoto (string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = null)

Update a user photo

Updates a photo of the user with the ID specified in the request.

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
    public class UpdateMemberPhotoExample
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
            var apiInstance = new PeoplePhotosApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID
            var updatePhotoMemberRequest = new UpdatePhotoMemberRequest?(); // UpdatePhotoMemberRequest? | Update photo (optional) 

            try
            {
                // Update a user photo
                ThumbnailsDataWrapper result = apiInstance.UpdateMemberPhoto(userid, updatePhotoMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePhotosApi.UpdateMemberPhoto: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMemberPhotoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a user photo
    ApiResponse<ThumbnailsDataWrapper> response = apiInstance.UpdateMemberPhotoWithHttpInfo(userid, updatePhotoMemberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeoplePhotosApi.UpdateMemberPhotoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |
| **updatePhotoMemberRequest** | [**UpdatePhotoMemberRequest?**](UpdatePhotoMemberRequest?.md) | Update photo | [optional]  |

### Return type

[**ThumbnailsDataWrapper**](ThumbnailsDataWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated thumbnail parameters: original photo, retina, maximum size photo, big, medium, small |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadmemberphoto"></a>
# **UploadMemberPhoto**
> FileUploadResultWrapper UploadMemberPhoto (string userid, List<KeyValuePairStringStringValues>? formCollection = null)

Upload a user photo

Uploads a photo of the user with the ID specified in the request.

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
    public class UploadMemberPhotoExample
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
            var apiInstance = new PeoplePhotosApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID
            var formCollection = new List<KeyValuePairStringStringValues>?(); // List<KeyValuePairStringStringValues>? | Image data (optional) 

            try
            {
                // Upload a user photo
                FileUploadResultWrapper result = apiInstance.UploadMemberPhoto(userid, formCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePhotosApi.UploadMemberPhoto: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadMemberPhotoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a user photo
    ApiResponse<FileUploadResultWrapper> response = apiInstance.UploadMemberPhotoWithHttpInfo(userid, formCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeoplePhotosApi.UploadMemberPhotoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |
| **formCollection** | [**List&lt;KeyValuePairStringStringValues&gt;?**](KeyValuePairStringStringValues.md) | Image data | [optional]  |

### Return type

[**FileUploadResultWrapper**](FileUploadResultWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Result of file uploading |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

