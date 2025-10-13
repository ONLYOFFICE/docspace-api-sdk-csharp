# DocSpace.API.SDK.Api.SettingsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeAccessToThirdparty**](#changeaccesstothirdparty) | **PUT** /api/2.0/files/thirdparty |  |
| [**ChangeAutomaticallyCleanUp**](#changeautomaticallycleanup) | **PUT** /api/2.0/files/settings/autocleanup |  |
| [**ChangeDefaultAccessRights**](#changedefaultaccessrights) | **PUT** /api/2.0/files/settings/dafaultaccessrights |  |
| [**ChangeDeleteConfirm**](#changedeleteconfirm) | **PUT** /api/2.0/files/changedeleteconfrim |  |
| [**ChangeDownloadZipFromBody**](#changedownloadzipfrombody) | **PUT** /api/2.0/files/settings/downloadtargz |  |
| [**CheckDocServiceUrl**](#checkdocserviceurl) | **PUT** /api/2.0/files/docservice |  |
| [**DisplayFileExtension**](#displayfileextension) | **PUT** /api/2.0/files/displayfileextension |  |
| [**DisplayRecent**](#displayrecent) | **PUT** /api/2.0/files/displayrecent |  |
| [**ExternalShare**](#externalshare) | **PUT** /api/2.0/files/settings/external |  |
| [**ExternalShareSocialMedia**](#externalsharesocialmedia) | **PUT** /api/2.0/files/settings/externalsocialmedia |  |
| [**Forcesave**](#forcesave) | **PUT** /api/2.0/files/forcesave |  |
| [**GetAutomaticallyCleanUp**](#getautomaticallycleanup) | **GET** /api/2.0/files/settings/autocleanup |  |
| [**GetDocServiceUrl**](#getdocserviceurl) | **GET** /api/2.0/files/docservice |  |
| [**GetFilesModule**](#getfilesmodule) | **GET** /api/2.0/files/info |  |
| [**GetFilesSettings**](#getfilessettings) | **GET** /api/2.0/files/settings |  |
| [**HideConfirmCancelOperation**](#hideconfirmcanceloperation) | **PUT** /api/2.0/files/hideconfirmcanceloperation |  |
| [**HideConfirmConvert**](#hideconfirmconvert) | **PUT** /api/2.0/files/hideconfirmconvert |  |
| [**HideConfirmRoomLifetime**](#hideconfirmroomlifetime) | **PUT** /api/2.0/files/hideconfirmroomlifetime |  |
| [**IsAvailablePrivacyRoomSettings**](#isavailableprivacyroomsettings) | **GET** /api/2.0/files/@privacy/available |  |
| [**KeepNewFileName**](#keepnewfilename) | **PUT** /api/2.0/files/keepnewfilename |  |
| [**SetOpenEditorInSameTab**](#setopeneditorinsametab) | **PUT** /api/2.0/files/settings/openeditorinsametab |  |
| [**StoreForcesave**](#storeforcesave) | **PUT** /api/2.0/files/storeforcesave |  |
| [**StoreOriginal**](#storeoriginal) | **PUT** /api/2.0/files/storeoriginal |  |
| [**UpdateFileIfExist**](#updatefileifexist) | **PUT** /api/2.0/files/updateifexist |  |

<a id="changeaccesstothirdparty"></a>
# **ChangeAccessToThirdparty**
> BooleanWrapper ChangeAccessToThirdparty (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class ChangeAccessToThirdpartyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.ChangeAccessToThirdparty(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ChangeAccessToThirdparty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeAccessToThirdpartyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.ChangeAccessToThirdpartyWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ChangeAccessToThirdpartyWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changeautomaticallycleanup"></a>
# **ChangeAutomaticallyCleanUp**
> AutoCleanUpDataWrapper ChangeAutomaticallyCleanUp (AutoCleanupRequestDto? autoCleanupRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoCleanupRequestDto** | [**AutoCleanupRequestDto?**](AutoCleanupRequestDto.md) | The auto-clearing request parameters. | [optional]  |

### Return type

[**AutoCleanUpDataWrapper**](AutoCleanUpDataWrapper.md)

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
    public class ChangeAutomaticallyCleanUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var autoCleanupRequestDto = new AutoCleanupRequestDto?(); // AutoCleanupRequestDto? | The auto-clearing request parameters. (optional) 

            try
            {
                AutoCleanUpDataWrapper result = apiInstance.ChangeAutomaticallyCleanUp(autoCleanupRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ChangeAutomaticallyCleanUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeAutomaticallyCleanUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AutoCleanUpDataWrapper> response = apiInstance.ChangeAutomaticallyCleanUpWithHttpInfo(autoCleanupRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ChangeAutomaticallyCleanUpWithHttpInfo: " + e.Message);
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
| **200** | The auto-clearing setting properties: auto-clearing or not, a time interval when the auto-clearing will be performed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changedefaultaccessrights"></a>
# **ChangeDefaultAccessRights**
> FileShareArrayWrapper ChangeDefaultAccessRights (List<int>? requestBody = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;int&gt;?**](int.md) | Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). | [optional]  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

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
    public class ChangeDefaultAccessRightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var requestBody = new List<int>?(); // List<int>? | Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional) 

            try
            {
                FileShareArrayWrapper result = apiInstance.ChangeDefaultAccessRights(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ChangeDefaultAccessRights: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeDefaultAccessRightsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.ChangeDefaultAccessRightsWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ChangeDefaultAccessRightsWithHttpInfo: " + e.Message);
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
| **200** | Updated sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changedeleteconfirm"></a>
# **ChangeDeleteConfirm**
> BooleanWrapper ChangeDeleteConfirm (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class ChangeDeleteConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.ChangeDeleteConfirm(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ChangeDeleteConfirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeDeleteConfirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.ChangeDeleteConfirmWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ChangeDeleteConfirmWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changedownloadzipfrombody"></a>
# **ChangeDownloadZipFromBody**
> ICompressWrapper ChangeDownloadZipFromBody (DisplayRequestDto? displayRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayRequestDto** | [**DisplayRequestDto?**](DisplayRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**ICompressWrapper**](ICompressWrapper.md)

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
    public class ChangeDownloadZipFromBodyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var displayRequestDto = new DisplayRequestDto?(); // DisplayRequestDto? | The settings request parameters. (optional) 

            try
            {
                ICompressWrapper result = apiInstance.ChangeDownloadZipFromBody(displayRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ChangeDownloadZipFromBody: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeDownloadZipFromBodyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ICompressWrapper> response = apiInstance.ChangeDownloadZipFromBodyWithHttpInfo(displayRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ChangeDownloadZipFromBodyWithHttpInfo: " + e.Message);
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
| **200** | Archive |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkdocserviceurl"></a>
# **CheckDocServiceUrl**
> DocServiceUrlWrapper CheckDocServiceUrl (CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkDocServiceUrlRequestDto** | [**CheckDocServiceUrlRequestDto?**](CheckDocServiceUrlRequestDto.md) | The request parameters for checking the document service location. | [optional]  |

### Return type

[**DocServiceUrlWrapper**](DocServiceUrlWrapper.md)

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
    public class CheckDocServiceUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var checkDocServiceUrlRequestDto = new CheckDocServiceUrlRequestDto?(); // CheckDocServiceUrlRequestDto? | The request parameters for checking the document service location. (optional) 

            try
            {
                DocServiceUrlWrapper result = apiInstance.CheckDocServiceUrl(checkDocServiceUrlRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.CheckDocServiceUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckDocServiceUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DocServiceUrlWrapper> response = apiInstance.CheckDocServiceUrlWithHttpInfo(checkDocServiceUrlRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.CheckDocServiceUrlWithHttpInfo: " + e.Message);
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
| **200** | Document service information: the Document Server address, the Document Server address in the local private network, the Community Server address |  -  |
| **400** | Invalid input urls/Mixed Active Content is not allowed. HTTPS address for Document Server is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="displayfileextension"></a>
# **DisplayFileExtension**
> BooleanWrapper DisplayFileExtension (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class DisplayFileExtensionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.DisplayFileExtension(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DisplayFileExtension: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisplayFileExtensionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.DisplayFileExtensionWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DisplayFileExtensionWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="displayrecent"></a>
# **DisplayRecent**
> BooleanWrapper DisplayRecent (DisplayRequestDto? displayRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/display-recent/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayRequestDto** | [**DisplayRequestDto?**](DisplayRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class DisplayRecentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var displayRequestDto = new DisplayRequestDto?(); // DisplayRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.DisplayRecent(displayRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DisplayRecent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisplayRecentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.DisplayRecentWithHttpInfo(displayRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DisplayRecentWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="externalshare"></a>
# **ExternalShare**
> BooleanWrapper ExternalShare (DisplayRequestDto? displayRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayRequestDto** | [**DisplayRequestDto?**](DisplayRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class ExternalShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var displayRequestDto = new DisplayRequestDto?(); // DisplayRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.ExternalShare(displayRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ExternalShare: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalShareWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.ExternalShareWithHttpInfo(displayRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ExternalShareWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="externalsharesocialmedia"></a>
# **ExternalShareSocialMedia**
> BooleanWrapper ExternalShareSocialMedia (DisplayRequestDto? displayRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayRequestDto** | [**DisplayRequestDto?**](DisplayRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class ExternalShareSocialMediaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var displayRequestDto = new DisplayRequestDto?(); // DisplayRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.ExternalShareSocialMedia(displayRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ExternalShareSocialMedia: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalShareSocialMediaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.ExternalShareSocialMediaWithHttpInfo(displayRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ExternalShareSocialMediaWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="forcesave"></a>
# **Forcesave**
> BooleanWrapper Forcesave ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class ForcesaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                BooleanWrapper result = apiInstance.Forcesave();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.Forcesave: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForcesaveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.ForcesaveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ForcesaveWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getautomaticallycleanup"></a>
# **GetAutomaticallyCleanUp**
> AutoCleanUpDataWrapper GetAutomaticallyCleanUp ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**AutoCleanUpDataWrapper**](AutoCleanUpDataWrapper.md)

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
    public class GetAutomaticallyCleanUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                AutoCleanUpDataWrapper result = apiInstance.GetAutomaticallyCleanUp();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetAutomaticallyCleanUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutomaticallyCleanUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AutoCleanUpDataWrapper> response = apiInstance.GetAutomaticallyCleanUpWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetAutomaticallyCleanUpWithHttpInfo: " + e.Message);
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
| **200** | The auto-clearing setting properties: auto-clearing or not, a time interval when the auto-clearing will be performed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdocserviceurl"></a>
# **GetDocServiceUrl**
> DocServiceUrlWrapper GetDocServiceUrl (bool? version = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **version** | **bool?** | Specifies whether to return the editor version or not. | [optional]  |

### Return type

[**DocServiceUrlWrapper**](DocServiceUrlWrapper.md)

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
    public class GetDocServiceUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var version = true;  // bool? | Specifies whether to return the editor version or not. (optional) 

            try
            {
                DocServiceUrlWrapper result = apiInstance.GetDocServiceUrl(version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetDocServiceUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocServiceUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DocServiceUrlWrapper> response = apiInstance.GetDocServiceUrlWithHttpInfo(version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetDocServiceUrlWithHttpInfo: " + e.Message);
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
| **200** | The document service URL with the editor version specified |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilesmodule"></a>
# **GetFilesModule**
> ModuleWrapper GetFilesModule ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**ModuleWrapper**](ModuleWrapper.md)

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
    public class GetFilesModuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                ModuleWrapper result = apiInstance.GetFilesModule();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetFilesModule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilesModuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ModuleWrapper> response = apiInstance.GetFilesModuleWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetFilesModuleWithHttpInfo: " + e.Message);
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
| **200** | Module information: ID, product class name, title, description, icon URL, large icon URL, start URL, primary or nor, help URL |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilessettings"></a>
# **GetFilesSettings**
> FilesSettingsWrapper GetFilesSettings ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**FilesSettingsWrapper**](FilesSettingsWrapper.md)

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
    public class GetFilesSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                FilesSettingsWrapper result = apiInstance.GetFilesSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetFilesSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilesSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FilesSettingsWrapper> response = apiInstance.GetFilesSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetFilesSettingsWithHttpInfo: " + e.Message);
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
| **200** | File settings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hideconfirmcanceloperation"></a>
# **HideConfirmCancelOperation**
> BooleanWrapper HideConfirmCancelOperation (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class HideConfirmCancelOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.HideConfirmCancelOperation(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.HideConfirmCancelOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HideConfirmCancelOperationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.HideConfirmCancelOperationWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.HideConfirmCancelOperationWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hideconfirmconvert"></a>
# **HideConfirmConvert**
> ModuleWrapper HideConfirmConvert (HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hideConfirmConvertRequestDto** | [**HideConfirmConvertRequestDto?**](HideConfirmConvertRequestDto.md) | The request parameters for hiding the confirmation dialog when converting. | [optional]  |

### Return type

[**ModuleWrapper**](ModuleWrapper.md)

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
    public class HideConfirmConvertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var hideConfirmConvertRequestDto = new HideConfirmConvertRequestDto?(); // HideConfirmConvertRequestDto? | The request parameters for hiding the confirmation dialog when converting. (optional) 

            try
            {
                ModuleWrapper result = apiInstance.HideConfirmConvert(hideConfirmConvertRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.HideConfirmConvert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HideConfirmConvertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ModuleWrapper> response = apiInstance.HideConfirmConvertWithHttpInfo(hideConfirmConvertRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.HideConfirmConvertWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hideconfirmroomlifetime"></a>
# **HideConfirmRoomLifetime**
> BooleanWrapper HideConfirmRoomLifetime (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class HideConfirmRoomLifetimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.HideConfirmRoomLifetime(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.HideConfirmRoomLifetime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HideConfirmRoomLifetimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.HideConfirmRoomLifetimeWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.HideConfirmRoomLifetimeWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="isavailableprivacyroomsettings"></a>
# **IsAvailablePrivacyRoomSettings**
> BooleanWrapper IsAvailablePrivacyRoomSettings ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class IsAvailablePrivacyRoomSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                BooleanWrapper result = apiInstance.IsAvailablePrivacyRoomSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.IsAvailablePrivacyRoomSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsAvailablePrivacyRoomSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.IsAvailablePrivacyRoomSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.IsAvailablePrivacyRoomSettingsWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the Private Room settings are available |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="keepnewfilename"></a>
# **KeepNewFileName**
> BooleanWrapper KeepNewFileName (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class KeepNewFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.KeepNewFileName(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.KeepNewFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeepNewFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.KeepNewFileNameWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.KeepNewFileNameWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setopeneditorinsametab"></a>
# **SetOpenEditorInSameTab**
> BooleanWrapper SetOpenEditorInSameTab (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class SetOpenEditorInSameTabExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.SetOpenEditorInSameTab(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.SetOpenEditorInSameTab: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetOpenEditorInSameTabWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.SetOpenEditorInSameTabWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.SetOpenEditorInSameTabWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the parameter is enabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="storeforcesave"></a>
# **StoreForcesave**
> BooleanWrapper StoreForcesave ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class StoreForcesaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                BooleanWrapper result = apiInstance.StoreForcesave();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.StoreForcesave: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StoreForcesaveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.StoreForcesaveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.StoreForcesaveWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="storeoriginal"></a>
# **StoreOriginal**
> BooleanWrapper StoreOriginal (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class StoreOriginalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.StoreOriginal(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.StoreOriginal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StoreOriginalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.StoreOriginalWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.StoreOriginalWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefileifexist"></a>
# **UpdateFileIfExist**
> BooleanWrapper UpdateFileIfExist (SettingsRequestDto? settingsRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsRequestDto** | [**SettingsRequestDto?**](SettingsRequestDto.md) | The settings request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class UpdateFileIfExistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var settingsRequestDto = new SettingsRequestDto?(); // SettingsRequestDto? | The settings request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.UpdateFileIfExist(settingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.UpdateFileIfExist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFileIfExistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.UpdateFileIfExistWithHttpInfo(settingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.UpdateFileIfExistWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

