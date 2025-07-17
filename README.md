# DocSpace.Sdk - the C# library for the API

The ONLYOFFICE DocSpace SDK for C# is a library that provides tools for integrating and managing DocSpace features within your applications. It simplifies interaction with the DocSpace API by offering ready-to-use methods and models.

- API version: 3.2.0
- SDK version: 1.0.0

For more information, please visit [https://helpdesk.onlyoffice.com/hc/en-us](https://helpdesk.onlyoffice.com/hc/en-us)

<a id="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```powershell
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```
<a id="installation"></a>
## Installation
Run the following command to generate the DLL:
- [macOS/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the NuGet quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```powershell
nuget pack -Build -OutputDirectory out DocSpace.Sdk.csproj
```

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, set up a `System.Net.WebProxy` as follows:
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each API class (specifically the API client within it) will create an instance of HttpClient. This instance is used throughout the class lifecycle and is disposed of when the Dispose method is called.

To better manage connections, it is common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance, just pass it to the API class constructor:

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient but do not have access to its handler (for example, when using IHttpClientFactory in the ASP.NET Core DI context), you can create and configure your HttpClient instance separately and then pass it to the API class constructor:

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
If you want to use an HttpClient but do not have access to its handler (for example, when using IHttpClientFactory in the ASP.NET Core DI context), you can create and configure your HttpClient instance separately and then pass it to the API class constructor:

Here is an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="asc_auth_key"></a>
### asc_auth_key

- **Type**: API key
- **API key parameter name**: asc_auth_key
- **Location**: Cookie

<a id="Basic"></a>
### Basic

- **Type**: HTTP basic authentication

<a id="Bearer"></a>
### Bearer

- **Type**: Bearer Authentication

<a id="ApiKeyBearer"></a>
### ApiKeyBearer

- **Type**: API key
- **API key parameter name**: ApiKeyBearer
- **Location**: HTTP header

<a id="OAuth2"></a>
### OAuth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: {{authBaseUrl}}/oauth2/authorize
- **Token Url**: {{authBaseUrl}}/oauth2/token
- **Scopes**: 
  - read: Read access to protected resources
  - write: Write access to protected resources

<a id="OpenId"></a>
### OpenId

- **Type**: OpenId Connect
- **OpenId Connect URL**: {{authBaseUrl}}/.well-known/openid-configuration

<a id="x-signature"></a>
### x-signature

- **Type**: API key
- **API key parameter name**: x-signature
- **Location**: Cookie


<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyBearer
            config.ApiKey.Add("ApiKeyBearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("ApiKeyBearer", "Bearer");
            // Configure API key authorization: asc_auth_key
            config.ApiKey.Add("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ApiKeysApi(httpClient, config, httpClientHandler);
            var createApiKeyRequestDto = new CreateApiKeyRequestDto?(); // CreateApiKeyRequestDto? | The request parameters for creating a new API key. (optional) 

            try
            {
                // Create a user API key
                ApiKeyResponseWrapper result = apiInstance.CreateApiKey(createApiKeyRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApiKeysApi.CreateApiKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:8092*

<details><summary>API Endoints table</summary>
Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiKeysApi* | [**CreateApiKey**](docs/ApiKeysApi.md#createapikey) | **POST** /api/2.0/keys | Create a user API key
*ApiKeysApi* | [**DeleteApiKey**](docs/ApiKeysApi.md#deleteapikey) | **DELETE** /api/2.0/keys/{keyId} | Delete a user API key
*ApiKeysApi* | [**GetAllPermissions**](docs/ApiKeysApi.md#getallpermissions) | **GET** /api/2.0/keys/permissions | Get API key permissions
*ApiKeysApi* | [**GetApiKey**](docs/ApiKeysApi.md#getapikey) | **GET** /api/2.0/keys/@self | Get user API key info
*ApiKeysApi* | [**GetApiKeys**](docs/ApiKeysApi.md#getapikeys) | **GET** /api/2.0/keys | Get user API keys
*ApiKeysApi* | [**UpdateApiKey**](docs/ApiKeysApi.md#updateapikey) | **PUT** /api/2.0/keys/{keyId} | Update an API key
*AuthenticationApi* | [**AuthenticateMe**](docs/AuthenticationApi.md#authenticateme) | **POST** /api/2.0/authentication | Authenticate a user
*AuthenticationApi* | [**AuthenticateMeFromBodyWithCode**](docs/AuthenticationApi.md#authenticatemefrombodywithcode) | **POST** /api/2.0/authentication/{code} | Authenticate a user by code
*AuthenticationApi* | [**CheckConfirm**](docs/AuthenticationApi.md#checkconfirm) | **POST** /api/2.0/authentication/confirm | Open confirmation email URL
*AuthenticationApi* | [**GetIsAuthentificated**](docs/AuthenticationApi.md#getisauthentificated) | **GET** /api/2.0/authentication | Check authentication
*AuthenticationApi* | [**Logout**](docs/AuthenticationApi.md#logout) | **POST** /api/2.0/authentication/logout | Log out
*AuthenticationApi* | [**SaveMobilePhone**](docs/AuthenticationApi.md#savemobilephone) | **POST** /api/2.0/authentication/setphone | Set a mobile phone
*AuthenticationApi* | [**SendSmsCode**](docs/AuthenticationApi.md#sendsmscode) | **POST** /api/2.0/authentication/sendsms | Send SMS code
*BackupApi* | [**CreateBackupSchedule**](docs/BackupApi.md#createbackupschedule) | **POST** /api/2.0/backup/createbackupschedule | Create the backup schedule
*BackupApi* | [**DeleteBackup**](docs/BackupApi.md#deletebackup) | **DELETE** /api/2.0/backup/deletebackup/{id} | Delete the backup
*BackupApi* | [**DeleteBackupHistory**](docs/BackupApi.md#deletebackuphistory) | **DELETE** /api/2.0/backup/deletebackuphistory | Delete the backup history
*BackupApi* | [**DeleteBackupSchedule**](docs/BackupApi.md#deletebackupschedule) | **DELETE** /api/2.0/backup/deletebackupschedule | Delete the backup schedule
*BackupApi* | [**GetBackupHistory**](docs/BackupApi.md#getbackuphistory) | **GET** /api/2.0/backup/getbackuphistory | Get the backup history
*BackupApi* | [**GetBackupProgress**](docs/BackupApi.md#getbackupprogress) | **GET** /api/2.0/backup/getbackupprogress | Get the backup progress
*BackupApi* | [**GetBackupSchedule**](docs/BackupApi.md#getbackupschedule) | **GET** /api/2.0/backup/getbackupschedule | Get the backup schedule
*BackupApi* | [**GetRestoreProgress**](docs/BackupApi.md#getrestoreprogress) | **GET** /api/2.0/backup/getrestoreprogress | Get the restoring progress
*BackupApi* | [**StartBackup**](docs/BackupApi.md#startbackup) | **POST** /api/2.0/backup/startbackup | Start the backup
*BackupApi* | [**StartBackupRestore**](docs/BackupApi.md#startbackuprestore) | **POST** /api/2.0/backup/startrestore | Start the restoring process
*CapabilitiesApi* | [**GetPortalCapabilities**](docs/CapabilitiesApi.md#getportalcapabilities) | **GET** /api/2.0/capabilities | Get portal capabilities
*FilesFilesApi* | [**AddTemplates**](docs/FilesFilesApi.md#addtemplates) | **POST** /api/2.0/files/templates | Add template files
*FilesFilesApi* | [**ChangeVersionHistory**](docs/FilesFilesApi.md#changeversionhistory) | **PUT** /api/2.0/files/file/{fileId}/history | Change version history
*FilesFilesApi* | [**CheckFillFormDraft**](docs/FilesFilesApi.md#checkfillformdraft) | **POST** /api/2.0/files/masterform/{fileId}/checkfillformdraft | Check the form draft filling
*FilesFilesApi* | [**CopyFileAs**](docs/FilesFilesApi.md#copyfileas) | **POST** /api/2.0/files/file/{fileId}/copyas | Copy a file
*FilesFilesApi* | [**CreateEditSession**](docs/FilesFilesApi.md#createeditsession) | **POST** /api/2.0/files/file/{fileId}/edit_session | Create the editing session
*FilesFilesApi* | [**CreateFile**](docs/FilesFilesApi.md#createfile) | **POST** /api/2.0/files/{folderId}/file | Create a file
*FilesFilesApi* | [**CreateFileInMyDocuments**](docs/FilesFilesApi.md#createfileinmydocuments) | **POST** /api/2.0/files/@my/file | Create a file in the \"My documents\" section
*FilesFilesApi* | [**CreateHtmlFile**](docs/FilesFilesApi.md#createhtmlfile) | **POST** /api/2.0/files/{folderId}/html | Create an HTML file
*FilesFilesApi* | [**CreateHtmlFileInMyDocuments**](docs/FilesFilesApi.md#createhtmlfileinmydocuments) | **POST** /api/2.0/files/@my/html | Create an HTML file in the \"My documents\" section
*FilesFilesApi* | [**CreatePrimaryExternalLink**](docs/FilesFilesApi.md#createprimaryexternallink) | **POST** /api/2.0/files/file/{id}/link | Create primary external link
*FilesFilesApi* | [**CreateTextFile**](docs/FilesFilesApi.md#createtextfile) | **POST** /api/2.0/files/{folderId}/text | Create a text file
*FilesFilesApi* | [**CreateTextFileInMyDocuments**](docs/FilesFilesApi.md#createtextfileinmydocuments) | **POST** /api/2.0/files/@my/text | Create a text file in the \"My documents\" section
*FilesFilesApi* | [**CreateThumbnails**](docs/FilesFilesApi.md#createthumbnails) | **POST** /api/2.0/files/thumbnails | Create file thumbnails
*FilesFilesApi* | [**DeleteFile**](docs/FilesFilesApi.md#deletefile) | **DELETE** /api/2.0/files/file/{fileId} | Delete a file
*FilesFilesApi* | [**DeleteRecent**](docs/FilesFilesApi.md#deleterecent) | **DELETE** /api/2.0/files/recent | Delete recent files
*FilesFilesApi* | [**DeleteTemplates**](docs/FilesFilesApi.md#deletetemplates) | **DELETE** /api/2.0/files/templates | Delete template files
*FilesFilesApi* | [**GetAllFormRoles**](docs/FilesFilesApi.md#getallformroles) | **GET** /api/2.0/files/file/{fileId}/formroles | Get form roles
*FilesFilesApi* | [**GetEditDiffUrl**](docs/FilesFilesApi.md#geteditdiffurl) | **GET** /api/2.0/files/file/{fileId}/edit/diff | Get changes URL
*FilesFilesApi* | [**GetEditHistory**](docs/FilesFilesApi.md#getedithistory) | **GET** /api/2.0/files/file/{fileId}/edit/history | Get version history
*FilesFilesApi* | [**GetFileHistory**](docs/FilesFilesApi.md#getfilehistory) | **GET** /api/2.0/files/file/{fileId}/log | Get file history
*FilesFilesApi* | [**GetFileInfo**](docs/FilesFilesApi.md#getfileinfo) | **GET** /api/2.0/files/file/{fileId} | Get file information
*FilesFilesApi* | [**GetFileLinks**](docs/FilesFilesApi.md#getfilelinks) | **GET** /api/2.0/files/file/{id}/links | Get file external links
*FilesFilesApi* | [**GetFilePrimaryExternalLink**](docs/FilesFilesApi.md#getfileprimaryexternallink) | **GET** /api/2.0/files/file/{id}/link | Get primary external link
*FilesFilesApi* | [**GetFileVersionInfo**](docs/FilesFilesApi.md#getfileversioninfo) | **GET** /api/2.0/files/file/{fileId}/history | Get file versions
*FilesFilesApi* | [**GetFillResult**](docs/FilesFilesApi.md#getfillresult) | **GET** /api/2.0/files/file/fillresult | Get form-filling result
*FilesFilesApi* | [**GetPresignedFileUri**](docs/FilesFilesApi.md#getpresignedfileuri) | **GET** /api/2.0/files/file/{fileId}/presigned | Get file download link asynchronously
*FilesFilesApi* | [**GetPresignedUri**](docs/FilesFilesApi.md#getpresigneduri) | **GET** /api/2.0/files/file/{fileId}/presigneduri | Get file download link
*FilesFilesApi* | [**GetProtectedFileUsers**](docs/FilesFilesApi.md#getprotectedfileusers) | **GET** /api/2.0/files/file/{fileId}/protectusers | Get users access rights to the protected file
*FilesFilesApi* | [**GetReferenceData**](docs/FilesFilesApi.md#getreferencedata) | **POST** /api/2.0/files/file/referencedata | Get reference data
*FilesFilesApi* | [**IsFormPDF**](docs/FilesFilesApi.md#isformpdf) | **GET** /api/2.0/files/file/{fileId}/isformpdf | Check the PDF file
*FilesFilesApi* | [**LockFile**](docs/FilesFilesApi.md#lockfile) | **PUT** /api/2.0/files/file/{fileId}/lock | Lock a file
*FilesFilesApi* | [**ManageFormFilling**](docs/FilesFilesApi.md#manageformfilling) | **PUT** /api/2.0/files/file/{fileId}/manageformfilling | Perform form filling action
*FilesFilesApi* | [**OpenEditFile**](docs/FilesFilesApi.md#openeditfile) | **GET** /api/2.0/files/file/{fileId}/openedit | Open a file configuration
*FilesFilesApi* | [**RestoreFileVersion**](docs/FilesFilesApi.md#restorefileversion) | **GET** /api/2.0/files/file/{fileId}/restoreversion | Restore a file version
*FilesFilesApi* | [**SaveEditingFileFromForm**](docs/FilesFilesApi.md#saveeditingfilefromform) | **PUT** /api/2.0/files/file/{fileId}/saveediting | Save file edits
*FilesFilesApi* | [**SaveFileAsPdf**](docs/FilesFilesApi.md#savefileaspdf) | **POST** /api/2.0/files/file/{id}/saveaspdf | Save a file as PDF
*FilesFilesApi* | [**SaveFormRoleMapping**](docs/FilesFilesApi.md#saveformrolemapping) | **POST** /api/2.0/files/file/{fileId}/formrolemapping | Save form role mapping
*FilesFilesApi* | [**SetCustomFilterTag**](docs/FilesFilesApi.md#setcustomfiltertag) | **PUT** /api/2.0/files/file/{fileId}/customfilter | Set the Custom Filter editing mode
*FilesFilesApi* | [**SetExternalLink**](docs/FilesFilesApi.md#setexternallink) | **PUT** /api/2.0/files/file/{id}/links | Set an external link
*FilesFilesApi* | [**SetFileOrder**](docs/FilesFilesApi.md#setfileorder) | **PUT** /api/2.0/files/{fileId}/order | Set file order
*FilesFilesApi* | [**SetFilesOrder**](docs/FilesFilesApi.md#setfilesorder) | **PUT** /api/2.0/files/order | Set order of files
*FilesFilesApi* | [**StartEditFile**](docs/FilesFilesApi.md#starteditfile) | **POST** /api/2.0/files/file/{fileId}/startedit | Start file editing
*FilesFilesApi* | [**StartFillingFile**](docs/FilesFilesApi.md#startfillingfile) | **PUT** /api/2.0/files/file/{fileId}/startfilling | Start file filling
*FilesFilesApi* | [**TrackEditFile**](docs/FilesFilesApi.md#trackeditfile) | **GET** /api/2.0/files/file/{fileId}/trackeditfile | Track file editing
*FilesFilesApi* | [**UpdateFile**](docs/FilesFilesApi.md#updatefile) | **PUT** /api/2.0/files/file/{fileId} | Update a file
*FilesFoldersApi* | [**CheckUpload**](docs/FilesFoldersApi.md#checkupload) | **POST** /api/2.0/files/{folderId}/upload/check | Check file uploads
*FilesFoldersApi* | [**CreateFolder**](docs/FilesFoldersApi.md#createfolder) | **POST** /api/2.0/files/folder/{folderId} | Create a folder
*FilesFoldersApi* | [**DeleteFolder**](docs/FilesFoldersApi.md#deletefolder) | **DELETE** /api/2.0/files/folder/{folderId} | Delete a folder
*FilesFoldersApi* | [**GetFilesUsedSpace**](docs/FilesFoldersApi.md#getfilesusedspace) | **GET** /api/2.0/files/filesusedspace | Get used space of files
*FilesFoldersApi* | [**GetFolder**](docs/FilesFoldersApi.md#getfolder) | **GET** /api/2.0/files/{folderId}/formfilter | Get folder form filter
*FilesFoldersApi* | [**GetFolderByFolderId**](docs/FilesFoldersApi.md#getfolderbyfolderid) | **GET** /api/2.0/files/{folderId} | Get a folder by ID
*FilesFoldersApi* | [**GetFolderHistory**](docs/FilesFoldersApi.md#getfolderhistory) | **GET** /api/2.0/files/folder/{folderId}/log | Get folder history
*FilesFoldersApi* | [**GetFolderInfo**](docs/FilesFoldersApi.md#getfolderinfo) | **GET** /api/2.0/files/folder/{folderId} | Get folder information
*FilesFoldersApi* | [**GetFolderPath**](docs/FilesFoldersApi.md#getfolderpath) | **GET** /api/2.0/files/folder/{folderId}/path | Get the folder path
*FilesFoldersApi* | [**GetFolderPrimaryExternalLink**](docs/FilesFoldersApi.md#getfolderprimaryexternallink) | **GET** /api/2.0/files/folder/{id}/link | Get primary external link
*FilesFoldersApi* | [**GetFolders**](docs/FilesFoldersApi.md#getfolders) | **GET** /api/2.0/files/{folderId}/subfolders | Get subfolders
*FilesFoldersApi* | [**GetMyFolder**](docs/FilesFoldersApi.md#getmyfolder) | **GET** /api/2.0/files/@my | Get the \"My documents\" section
*FilesFoldersApi* | [**GetNewFolderItems**](docs/FilesFoldersApi.md#getnewfolderitems) | **GET** /api/2.0/files/{folderId}/news | Get new folder items
*FilesFoldersApi* | [**GetPrivacyFolder**](docs/FilesFoldersApi.md#getprivacyfolder) | **GET** /api/2.0/files/@privacy | Get the \"Private Room\" section
*FilesFoldersApi* | [**GetRootFolders**](docs/FilesFoldersApi.md#getrootfolders) | **GET** /api/2.0/files/@root | Get filtered sections
*FilesFoldersApi* | [**GetTrashFolder**](docs/FilesFoldersApi.md#gettrashfolder) | **GET** /api/2.0/files/@trash | Get the \"Trash\" section
*FilesFoldersApi* | [**InsertFile**](docs/FilesFoldersApi.md#insertfile) | **POST** /api/2.0/files/{folderId}/insert | Insert a file
*FilesFoldersApi* | [**InsertFileToMyFromBody**](docs/FilesFoldersApi.md#insertfiletomyfrombody) | **POST** /api/2.0/files/@my/insert | Insert a file to the \"My documents\" section
*FilesFoldersApi* | [**RenameFolder**](docs/FilesFoldersApi.md#renamefolder) | **PUT** /api/2.0/files/folder/{folderId} | Rename a folder
*FilesFoldersApi* | [**SetFolderOrder**](docs/FilesFoldersApi.md#setfolderorder) | **PUT** /api/2.0/files/folder/{folderId}/order | Set folder order
*FilesFoldersApi* | [**UploadFile**](docs/FilesFoldersApi.md#uploadfile) | **POST** /api/2.0/files/{folderId}/upload | Upload a file
*FilesFoldersApi* | [**UploadFileToMy**](docs/FilesFoldersApi.md#uploadfiletomy) | **POST** /api/2.0/files/@my/upload | Upload a file to the \"My documents\" section
*FilesOperationsApi* | [**BulkDownload**](docs/FilesOperationsApi.md#bulkdownload) | **PUT** /api/2.0/files/fileops/bulkdownload | Bulk download
*FilesOperationsApi* | [**CheckConversionStatus**](docs/FilesOperationsApi.md#checkconversionstatus) | **GET** /api/2.0/files/file/{fileId}/checkconversion | Get conversion status
*FilesOperationsApi* | [**CheckMoveOrCopyBatchItems**](docs/FilesOperationsApi.md#checkmoveorcopybatchitems) | **GET** /api/2.0/files/fileops/move | Check and move or copy to a folder
*FilesOperationsApi* | [**CheckMoveOrCopyDestFolder**](docs/FilesOperationsApi.md#checkmoveorcopydestfolder) | **GET** /api/2.0/files/fileops/checkdestfolder | Check for moving or copying to a folder
*FilesOperationsApi* | [**CopyBatchItems**](docs/FilesOperationsApi.md#copybatchitems) | **PUT** /api/2.0/files/fileops/copy | Copy to the folder
*FilesOperationsApi* | [**CreateUploadSession**](docs/FilesOperationsApi.md#createuploadsession) | **POST** /api/2.0/files/{folderId}/upload/create_session | Chunked upload
*FilesOperationsApi* | [**DeleteBatchItems**](docs/FilesOperationsApi.md#deletebatchitems) | **PUT** /api/2.0/files/fileops/delete | Delete files and folders
*FilesOperationsApi* | [**DeleteFileVersions**](docs/FilesOperationsApi.md#deletefileversions) | **PUT** /api/2.0/files/fileops/deleteversion | Delete file versions
*FilesOperationsApi* | [**DuplicateBatchItems**](docs/FilesOperationsApi.md#duplicatebatchitems) | **PUT** /api/2.0/files/fileops/duplicate | Duplicate files and folders
*FilesOperationsApi* | [**EmptyTrash**](docs/FilesOperationsApi.md#emptytrash) | **PUT** /api/2.0/files/fileops/emptytrash | Empty the \"Trash\" folder
*FilesOperationsApi* | [**GetOperationStatuses**](docs/FilesOperationsApi.md#getoperationstatuses) | **GET** /api/2.0/files/fileops | Get active file operations
*FilesOperationsApi* | [**GetOperationStatusesByType**](docs/FilesOperationsApi.md#getoperationstatusesbytype) | **GET** /api/2.0/files/fileops/{operationType} | Get file operation statuses
*FilesOperationsApi* | [**MarkAsRead**](docs/FilesOperationsApi.md#markasread) | **PUT** /api/2.0/files/fileops/markasread | Mark as read
*FilesOperationsApi* | [**MoveBatchItems**](docs/FilesOperationsApi.md#movebatchitems) | **PUT** /api/2.0/files/fileops/move | Move or copy to a folder
*FilesOperationsApi* | [**StartFileConversion**](docs/FilesOperationsApi.md#startfileconversion) | **PUT** /api/2.0/files/file/{fileId}/checkconversion | Start file conversion
*FilesOperationsApi* | [**TerminateTasks**](docs/FilesOperationsApi.md#terminatetasks) | **PUT** /api/2.0/files/fileops/terminate/{id} | Finish active operations
*FilesOperationsApi* | [**UpdateFileComment**](docs/FilesOperationsApi.md#updatefilecomment) | **PUT** /api/2.0/files/file/{fileId}/comment | Update a comment
*FilesQuotaApi* | [**ResetRoomQuota**](docs/FilesQuotaApi.md#resetroomquota) | **PUT** /api/2.0/files/rooms/resetquota | Reset the room quota limit
*FilesQuotaApi* | [**UpdateRoomsQuota**](docs/FilesQuotaApi.md#updateroomsquota) | **PUT** /api/2.0/files/rooms/roomquota | Change the room quota limit
*FilesSettingsApi* | [**ChangeAccessToThirdparty**](docs/FilesSettingsApi.md#changeaccesstothirdparty) | **PUT** /api/2.0/files/thirdparty | Change the third-party settings access
*FilesSettingsApi* | [**ChangeAutomaticallyCleanUp**](docs/FilesSettingsApi.md#changeautomaticallycleanup) | **PUT** /api/2.0/files/settings/autocleanup | Update the trash bin auto-clearing setting
*FilesSettingsApi* | [**ChangeDefaultAccessRights**](docs/FilesSettingsApi.md#changedefaultaccessrights) | **PUT** /api/2.0/files/settings/dafaultaccessrights | Change the default access rights
*FilesSettingsApi* | [**ChangeDeleteConfirm**](docs/FilesSettingsApi.md#changedeleteconfirm) | **PUT** /api/2.0/files/changedeleteconfrim | Confirm the file deletion
*FilesSettingsApi* | [**ChangeDownloadZipFromBody**](docs/FilesSettingsApi.md#changedownloadzipfrombody) | **PUT** /api/2.0/files/settings/downloadtargz | Change the archive format (using body parameters)
*FilesSettingsApi* | [**CheckDocServiceUrl**](docs/FilesSettingsApi.md#checkdocserviceurl) | **PUT** /api/2.0/files/docservice | Check the document service URL
*FilesSettingsApi* | [**DisplayFileExtension**](docs/FilesSettingsApi.md#displayfileextension) | **PUT** /api/2.0/files/displayfileextension | Display a file extension
*FilesSettingsApi* | [**ExternalShare**](docs/FilesSettingsApi.md#externalshare) | **PUT** /api/2.0/files/settings/external | Change the external sharing ability
*FilesSettingsApi* | [**ExternalShareSocialMedia**](docs/FilesSettingsApi.md#externalsharesocialmedia) | **PUT** /api/2.0/files/settings/externalsocialmedia | Change the external sharing ability on social networks
*FilesSettingsApi* | [**Forcesave**](docs/FilesSettingsApi.md#forcesave) | **PUT** /api/2.0/files/forcesave | Change the forcesaving ability
*FilesSettingsApi* | [**GetAutomaticallyCleanUp**](docs/FilesSettingsApi.md#getautomaticallycleanup) | **GET** /api/2.0/files/settings/autocleanup | Get the trash bin auto-clearing setting
*FilesSettingsApi* | [**GetDocServiceUrl**](docs/FilesSettingsApi.md#getdocserviceurl) | **GET** /api/2.0/files/docservice | Get the document service URL
*FilesSettingsApi* | [**GetFilesModule**](docs/FilesSettingsApi.md#getfilesmodule) | **GET** /api/2.0/files/info | Get the \"Documents\" information
*FilesSettingsApi* | [**GetFilesSettings**](docs/FilesSettingsApi.md#getfilessettings) | **GET** /api/2.0/files/settings | Get file settings
*FilesSettingsApi* | [**HideConfirmCancelOperation**](docs/FilesSettingsApi.md#hideconfirmcanceloperation) | **PUT** /api/2.0/files/hideconfirmcanceloperation | Hide confirmation dialog when canceling operations
*FilesSettingsApi* | [**HideConfirmConvert**](docs/FilesSettingsApi.md#hideconfirmconvert) | **PUT** /api/2.0/files/hideconfirmconvert | Hide the confirmation dialog when converting
*FilesSettingsApi* | [**HideConfirmRoomLifetime**](docs/FilesSettingsApi.md#hideconfirmroomlifetime) | **PUT** /api/2.0/files/hideconfirmroomlifetime | Hide confirmation dialog when changing room lifetime settings
*FilesSettingsApi* | [**IsAvailablePrivacyRoomSettings**](docs/FilesSettingsApi.md#isavailableprivacyroomsettings) | **GET** /api/2.0/files/@privacy/available | Check the \"Private Room\" availability
*FilesSettingsApi* | [**KeepNewFileName**](docs/FilesSettingsApi.md#keepnewfilename) | **PUT** /api/2.0/files/keepnewfilename | Ask a new file name
*FilesSettingsApi* | [**SetOpenEditorInSameTab**](docs/FilesSettingsApi.md#setopeneditorinsametab) | **PUT** /api/2.0/files/settings/openeditorinsametab | Open document in the same browser tab
*FilesSettingsApi* | [**StoreForcesave**](docs/FilesSettingsApi.md#storeforcesave) | **PUT** /api/2.0/files/storeforcesave | Change the ability to store the forcesaved files
*FilesSettingsApi* | [**StoreOriginal**](docs/FilesSettingsApi.md#storeoriginal) | **PUT** /api/2.0/files/storeoriginal | Change the ability to upload original formats
*FilesSettingsApi* | [**UpdateFileIfExist**](docs/FilesSettingsApi.md#updatefileifexist) | **PUT** /api/2.0/files/updateifexist | Update a file version if it exists
*FilesSharingApi* | [**ApplyExternalSharePassword**](docs/FilesSharingApi.md#applyexternalsharepassword) | **POST** /api/2.0/files/share/{key}/password | Apply external data password
*FilesSharingApi* | [**ChangeFileOwner**](docs/FilesSharingApi.md#changefileowner) | **POST** /api/2.0/files/owner | Change the file owner
*FilesSharingApi* | [**GetExternalShareData**](docs/FilesSharingApi.md#getexternalsharedata) | **GET** /api/2.0/files/share/{key} | Get the external data
*FilesSharingApi* | [**GetSharedUsers**](docs/FilesSharingApi.md#getsharedusers) | **GET** /api/2.0/files/file/{fileId}/sharedusers | Get user access rights by file ID
*FilesSharingApi* | [**SendEditorNotify**](docs/FilesSharingApi.md#sendeditornotify) | **POST** /api/2.0/files/file/{fileId}/sendeditornotify | Send the mention message
*FilesThirdPartyIntegrationApi* | [**DeleteThirdParty**](docs/FilesThirdPartyIntegrationApi.md#deletethirdparty) | **DELETE** /api/2.0/files/thirdparty/{providerId} | Remove a third-party account
*FilesThirdPartyIntegrationApi* | [**GetAllProviders**](docs/FilesThirdPartyIntegrationApi.md#getallproviders) | **GET** /api/2.0/files/thirdparty/providers | Get all providers
*FilesThirdPartyIntegrationApi* | [**GetBackupThirdPartyAccount**](docs/FilesThirdPartyIntegrationApi.md#getbackupthirdpartyaccount) | **GET** /api/2.0/files/thirdparty/backup | Get a third-party account backup
*FilesThirdPartyIntegrationApi* | [**GetCapabilities**](docs/FilesThirdPartyIntegrationApi.md#getcapabilities) | **GET** /api/2.0/files/thirdparty/capabilities | Get providers
*FilesThirdPartyIntegrationApi* | [**GetCommonThirdPartyFolders**](docs/FilesThirdPartyIntegrationApi.md#getcommonthirdpartyfolders) | **GET** /api/2.0/files/thirdparty/common | Get the common third-party services
*FilesThirdPartyIntegrationApi* | [**GetThirdPartyAccounts**](docs/FilesThirdPartyIntegrationApi.md#getthirdpartyaccounts) | **GET** /api/2.0/files/thirdparty | Get the third-party accounts
*FilesThirdPartyIntegrationApi* | [**SaveThirdParty**](docs/FilesThirdPartyIntegrationApi.md#savethirdparty) | **POST** /api/2.0/files/thirdparty | Save a third-party account
*FilesThirdPartyIntegrationApi* | [**SaveThirdPartyBackup**](docs/FilesThirdPartyIntegrationApi.md#savethirdpartybackup) | **POST** /api/2.0/files/thirdparty/backup | Save a third-party account backup
*GroupApi* | [**AddGroup**](docs/GroupApi.md#addgroup) | **POST** /api/2.0/group | Add a new group
*GroupApi* | [**AddMembersTo**](docs/GroupApi.md#addmembersto) | **PUT** /api/2.0/group/{id}/members | Add group members
*GroupApi* | [**DeleteGroup**](docs/GroupApi.md#deletegroup) | **DELETE** /api/2.0/group/{id} | Delete a group
*GroupApi* | [**GetGroup**](docs/GroupApi.md#getgroup) | **GET** /api/2.0/group/{id} | Get a group
*GroupApi* | [**GetGroupByUserId**](docs/GroupApi.md#getgroupbyuserid) | **GET** /api/2.0/group/user/{userid} | Get user groups
*GroupApi* | [**GetGroups**](docs/GroupApi.md#getgroups) | **GET** /api/2.0/group | Get groups
*GroupApi* | [**MoveMembersTo**](docs/GroupApi.md#movemembersto) | **PUT** /api/2.0/group/{fromId}/members/{toId} | Move group members
*GroupApi* | [**RemoveMembersFrom**](docs/GroupApi.md#removemembersfrom) | **DELETE** /api/2.0/group/{id}/members | Remove group members
*GroupApi* | [**SetGroupManager**](docs/GroupApi.md#setgroupmanager) | **PUT** /api/2.0/group/{id}/manager | Set a group manager
*GroupApi* | [**SetMembersTo**](docs/GroupApi.md#setmembersto) | **POST** /api/2.0/group/{id}/members | Replace group members
*GroupApi* | [**UpdateGroup**](docs/GroupApi.md#updategroup) | **PUT** /api/2.0/group/{id} | Update a group
*GroupRoomsApi* | [**GetGroupsWithShared**](docs/GroupRoomsApi.md#getgroupswithshared) | **GET** /api/2.0/group/room/{id} | Get groups with sharing settings
*MigrationApi* | [**CancelMigration**](docs/MigrationApi.md#cancelmigration) | **POST** /api/2.0/migration/cancel | Cancel migration
*MigrationApi* | [**ClearMigration**](docs/MigrationApi.md#clearmigration) | **POST** /api/2.0/migration/clear | Clear migration
*MigrationApi* | [**FinishMigration**](docs/MigrationApi.md#finishmigration) | **POST** /api/2.0/migration/finish | Finish migration
*MigrationApi* | [**GetMigrationLogs**](docs/MigrationApi.md#getmigrationlogs) | **GET** /api/2.0/migration/logs | Get migration logs
*MigrationApi* | [**GetMigrationStatus**](docs/MigrationApi.md#getmigrationstatus) | **GET** /api/2.0/migration/status | Get migration status
*MigrationApi* | [**ListMigrations**](docs/MigrationApi.md#listmigrations) | **GET** /api/2.0/migration/list | Get migrations
*MigrationApi* | [**StartMigration**](docs/MigrationApi.md#startmigration) | **POST** /api/2.0/migration/migrate | Start migration
*MigrationApi* | [**UploadAndInitializeMigration**](docs/MigrationApi.md#uploadandinitializemigration) | **POST** /api/2.0/migration/init/{migratorName} | Upload and initialize migration
*OAuth20AuthorizationApi* | [**AuthorizeOAuth**](docs/OAuth20AuthorizationApi.md#authorizeoauth) | **GET** /oauth2/authorize | OAuth2 authorization endpoint
*OAuth20AuthorizationApi* | [**ExchangeToken**](docs/OAuth20AuthorizationApi.md#exchangetoken) | **POST** /oauth2/token | OAuth2 token endpoint
*OAuth20AuthorizationApi* | [**SubmitConsent**](docs/OAuth20AuthorizationApi.md#submitconsent) | **POST** /oauth2/authorize | OAuth2 consent endpoint
*OAuth20ClientManagementApi* | [**ChangeActivation**](docs/OAuth20ClientManagementApi.md#changeactivation) | **PATCH** /api/2.0/clients/{clientId}/activation | Change the client activation status
*OAuth20ClientManagementApi* | [**CreateClient**](docs/OAuth20ClientManagementApi.md#createclient) | **POST** /api/2.0/clients | Create a new OAuth2 client
*OAuth20ClientManagementApi* | [**DeleteClient**](docs/OAuth20ClientManagementApi.md#deleteclient) | **DELETE** /api/2.0/clients/{clientId} | Delete an OAuth2 client
*OAuth20ClientManagementApi* | [**RegenerateSecret**](docs/OAuth20ClientManagementApi.md#regeneratesecret) | **PATCH** /api/2.0/clients/{clientId}/regenerate | Regenerate the client secret
*OAuth20ClientManagementApi* | [**RevokeUserClient**](docs/OAuth20ClientManagementApi.md#revokeuserclient) | **DELETE** /api/2.0/clients/{clientId}/revoke | Revoke client consent
*OAuth20ClientManagementApi* | [**UpdateClient**](docs/OAuth20ClientManagementApi.md#updateclient) | **PUT** /api/2.0/clients/{clientId} | Update an existing OAuth2 client
*OAuth20ClientQueryingApi* | [**GetClient**](docs/OAuth20ClientQueryingApi.md#getclient) | **GET** /api/2.0/clients/{clientId} | Get client details
*OAuth20ClientQueryingApi* | [**GetClientInfo**](docs/OAuth20ClientQueryingApi.md#getclientinfo) | **GET** /api/2.0/clients/{clientId}/info | Get detailed client information
*OAuth20ClientQueryingApi* | [**GetClients**](docs/OAuth20ClientQueryingApi.md#getclients) | **GET** /api/2.0/clients | Get clients
*OAuth20ClientQueryingApi* | [**GetClientsInfo**](docs/OAuth20ClientQueryingApi.md#getclientsinfo) | **GET** /api/2.0/clients/info | Get detailed information of clients
*OAuth20ClientQueryingApi* | [**GetConsents**](docs/OAuth20ClientQueryingApi.md#getconsents) | **GET** /api/2.0/clients/consents | Get user consents
*OAuth20ClientQueryingApi* | [**GetPublicClientInfo**](docs/OAuth20ClientQueryingApi.md#getpublicclientinfo) | **GET** /api/2.0/clients/{clientId}/public/info | Get public client information
*OAuth20ScopeManagementApi* | [**GetScopes**](docs/OAuth20ScopeManagementApi.md#getscopes) | **GET** /api/2.0/scopes | Get available OAuth2 scopes
*PeopleGuestsApi* | [**ApproveGuestShareLink**](docs/PeopleGuestsApi.md#approveguestsharelink) | **POST** /api/2.0/people/guests/share/approve | Approve a guest sharing link
*PeopleGuestsApi* | [**DeleteGuests**](docs/PeopleGuestsApi.md#deleteguests) | **DELETE** /api/2.0/people/guests | Delete guests
*PeoplePasswordApi* | [**ChangeUserPassword**](docs/PeoplePasswordApi.md#changeuserpassword) | **PUT** /api/2.0/people/{userid}/password | Change a user password
*PeoplePasswordApi* | [**SendUserPassword**](docs/PeoplePasswordApi.md#senduserpassword) | **POST** /api/2.0/people/password | Remind a user password
*PeoplePhotosApi* | [**CreateMemberPhotoThumbnails**](docs/PeoplePhotosApi.md#creatememberphotothumbnails) | **POST** /api/2.0/people/{userid}/photo/thumbnails | Create photo thumbnails
*PeoplePhotosApi* | [**DeleteMemberPhoto**](docs/PeoplePhotosApi.md#deletememberphoto) | **DELETE** /api/2.0/people/{userid}/photo | Delete a user photo
*PeoplePhotosApi* | [**GetMemberPhoto**](docs/PeoplePhotosApi.md#getmemberphoto) | **GET** /api/2.0/people/{userid}/photo | Get a user photo
*PeoplePhotosApi* | [**UpdateMemberPhoto**](docs/PeoplePhotosApi.md#updatememberphoto) | **PUT** /api/2.0/people/{userid}/photo | Update a user photo
*PeoplePhotosApi* | [**UploadMemberPhoto**](docs/PeoplePhotosApi.md#uploadmemberphoto) | **POST** /api/2.0/people/{userid}/photo | Upload a user photo
*PeopleProfilesApi* | [**AddMember**](docs/PeopleProfilesApi.md#addmember) | **POST** /api/2.0/people | Add a user
*PeopleProfilesApi* | [**DeleteMember**](docs/PeopleProfilesApi.md#deletemember) | **DELETE** /api/2.0/people/{userid} | Delete a user
*PeopleProfilesApi* | [**DeleteProfile**](docs/PeopleProfilesApi.md#deleteprofile) | **DELETE** /api/2.0/people/@self | Delete my profile
*PeopleProfilesApi* | [**GetAllProfiles**](docs/PeopleProfilesApi.md#getallprofiles) | **GET** /api/2.0/people | Get profiles
*PeopleProfilesApi* | [**GetClaims**](docs/PeopleProfilesApi.md#getclaims) | **GET** /api/2.0/people/tokendiagnostics | Returns the user claims.
*PeopleProfilesApi* | [**GetProfileByEmail**](docs/PeopleProfilesApi.md#getprofilebyemail) | **GET** /api/2.0/people/email | Get a profile by user email
*PeopleProfilesApi* | [**GetProfileByUserId**](docs/PeopleProfilesApi.md#getprofilebyuserid) | **GET** /api/2.0/people/{userid} | Get a profile by user name
*PeopleProfilesApi* | [**GetSelfProfile**](docs/PeopleProfilesApi.md#getselfprofile) | **GET** /api/2.0/people/@self | Get my profile
*PeopleProfilesApi* | [**InviteUsers**](docs/PeopleProfilesApi.md#inviteusers) | **POST** /api/2.0/people/invite | Invite users
*PeopleProfilesApi* | [**RemoveUsers**](docs/PeopleProfilesApi.md#removeusers) | **PUT** /api/2.0/people/delete | Delete users
*PeopleProfilesApi* | [**ResendUserInvites**](docs/PeopleProfilesApi.md#resenduserinvites) | **PUT** /api/2.0/people/invite | Resend activation emails
*PeopleProfilesApi* | [**SendEmailChangeInstructions**](docs/PeopleProfilesApi.md#sendemailchangeinstructions) | **POST** /api/2.0/people/email | Send instructions to change email
*PeopleProfilesApi* | [**UpdateMember**](docs/PeopleProfilesApi.md#updatemember) | **PUT** /api/2.0/people/{userid} | Update a user
*PeopleProfilesApi* | [**UpdateMemberCulture**](docs/PeopleProfilesApi.md#updatememberculture) | **PUT** /api/2.0/people/{userid}/culture | Update a user culture code
*PeopleQuotaApi* | [**ResetUsersQuota**](docs/PeopleQuotaApi.md#resetusersquota) | **PUT** /api/2.0/people/resetquota | Reset a user quota limit
*PeopleQuotaApi* | [**UpdateUserQuota**](docs/PeopleQuotaApi.md#updateuserquota) | **PUT** /api/2.0/people/userquota | Change a user quota limit
*PeopleSearchApi* | [**GetAccountsEntriesWithShared**](docs/PeopleSearchApi.md#getaccountsentrieswithshared) | **GET** /api/2.0/accounts/room/{id}/search | Get account entries
*PeopleSearchApi* | [**GetSearch**](docs/PeopleSearchApi.md#getsearch) | **GET** /api/2.0/people/@search/{query} | Search users
*PeopleSearchApi* | [**GetSimpleByFilter**](docs/PeopleSearchApi.md#getsimplebyfilter) | **GET** /api/2.0/people/simple/filter | Search users by extended filter
*PeopleSearchApi* | [**GetUsersWithRoomShared**](docs/PeopleSearchApi.md#getuserswithroomshared) | **GET** /api/2.0/people/room/{id} | Get users with room sharing settings
*PeopleSearchApi* | [**SearchUsersByExtendedFilter**](docs/PeopleSearchApi.md#searchusersbyextendedfilter) | **GET** /api/2.0/people/filter | Search users with detaailed information by extended filter
*PeopleSearchApi* | [**SearchUsersByQuery**](docs/PeopleSearchApi.md#searchusersbyquery) | **GET** /api/2.0/people/search | Search users (using query parameters)
*PeopleSearchApi* | [**SearchUsersByStatus**](docs/PeopleSearchApi.md#searchusersbystatus) | **GET** /api/2.0/people/status/{status}/search | Search users by status filter
*PeopleThemeApi* | [**ChangePortalTheme**](docs/PeopleThemeApi.md#changeportaltheme) | **PUT** /api/2.0/people/theme | Change the portal theme
*PeopleThemeApi* | [**GetPortalTheme**](docs/PeopleThemeApi.md#getportaltheme) | **GET** /api/2.0/people/theme | Get the portal theme
*PeopleThirdPartyAccountsApi* | [**GetThirdPartyAuthProviders**](docs/PeopleThirdPartyAccountsApi.md#getthirdpartyauthproviders) | **GET** /api/2.0/people/thirdparty/providers | Get third-party accounts
*PeopleThirdPartyAccountsApi* | [**LinkThirdPartyAccount**](docs/PeopleThirdPartyAccountsApi.md#linkthirdpartyaccount) | **PUT** /api/2.0/people/thirdparty/linkaccount | Link a third-pary account
*PeopleThirdPartyAccountsApi* | [**SignupThirdPartyAccount**](docs/PeopleThirdPartyAccountsApi.md#signupthirdpartyaccount) | **POST** /api/2.0/people/thirdparty/signup | Create a third-pary account
*PeopleThirdPartyAccountsApi* | [**UnlinkThirdPartyAccount**](docs/PeopleThirdPartyAccountsApi.md#unlinkthirdpartyaccount) | **DELETE** /api/2.0/people/thirdparty/unlinkaccount | Unlink a third-pary account
*PeopleUserDataApi* | [**GetDeletePersonalFolderProgress**](docs/PeopleUserDataApi.md#getdeletepersonalfolderprogress) | **GET** /api/2.0/people/delete/personal/progress | Get the progress of deleting the personal folder
*PeopleUserDataApi* | [**GetReassignProgress**](docs/PeopleUserDataApi.md#getreassignprogress) | **GET** /api/2.0/people/reassign/progress/{userid} | Get the reassignment progress
*PeopleUserDataApi* | [**GetRemoveProgress**](docs/PeopleUserDataApi.md#getremoveprogress) | **GET** /api/2.0/people/remove/progress/{userid} | Get the deletion progress
*PeopleUserDataApi* | [**NecessaryReassign**](docs/PeopleUserDataApi.md#necessaryreassign) | **GET** /api/2.0/people/reassign/necessary | Check the data reassignment need
*PeopleUserDataApi* | [**SendInstructionsToDelete**](docs/PeopleUserDataApi.md#sendinstructionstodelete) | **PUT** /api/2.0/people/self/delete | Send the deletion instructions
*PeopleUserDataApi* | [**StartDeletePersonalFolder**](docs/PeopleUserDataApi.md#startdeletepersonalfolder) | **POST** /api/2.0/people/delete/personal/start | Delete the personal folder
*PeopleUserDataApi* | [**StartReassign**](docs/PeopleUserDataApi.md#startreassign) | **POST** /api/2.0/people/reassign/start | Start the data reassignment
*PeopleUserDataApi* | [**StartRemove**](docs/PeopleUserDataApi.md#startremove) | **POST** /api/2.0/people/remove/start | Start the data deletion
*PeopleUserDataApi* | [**TerminateReassign**](docs/PeopleUserDataApi.md#terminatereassign) | **PUT** /api/2.0/people/reassign/terminate | Terminate the data reassignment
*PeopleUserDataApi* | [**TerminateRemove**](docs/PeopleUserDataApi.md#terminateremove) | **PUT** /api/2.0/people/remove/terminate | Terminate the data deletion
*PeopleUserStatusApi* | [**GetByStatus**](docs/PeopleUserStatusApi.md#getbystatus) | **GET** /api/2.0/people/status/{status} | Get profiles by status
*PeopleUserStatusApi* | [**UpdateUserActivationStatus**](docs/PeopleUserStatusApi.md#updateuseractivationstatus) | **PUT** /api/2.0/people/activationstatus/{activationstatus} | Set an activation status to the users
*PeopleUserStatusApi* | [**UpdateUserStatus**](docs/PeopleUserStatusApi.md#updateuserstatus) | **PUT** /api/2.0/people/status/{status} | Change a user status
*PeopleUserTypeApi* | [**GetUserTypeUpdateProgress**](docs/PeopleUserTypeApi.md#getusertypeupdateprogress) | **GET** /api/2.0/people/type/progress/{userid} | Get the progress of updating user type
*PeopleUserTypeApi* | [**StarUserTypetUpdate**](docs/PeopleUserTypeApi.md#starusertypetupdate) | **POST** /api/2.0/people/type | Update user type
*PeopleUserTypeApi* | [**TerminateUserTypeUpdate**](docs/PeopleUserTypeApi.md#terminateusertypeupdate) | **PUT** /api/2.0/people/type/terminate | Terminate update user type
*PeopleUserTypeApi* | [**UpdateUserType**](docs/PeopleUserTypeApi.md#updateusertype) | **PUT** /api/2.0/people/type/{type} | Change a user type
*PortalGuestsApi* | [**GetGuestSharingLink**](docs/PortalGuestsApi.md#getguestsharinglink) | **GET** /api/2.0/people/guests/{userid}/share | Get a guest sharing link
*PortalPaymentApi* | [**CalculateWalletPayment**](docs/PortalPaymentApi.md#calculatewalletpayment) | **PUT** /api/2.0/portal/payment/calculatewallet | Calculate amount of the wallet payment
*PortalPaymentApi* | [**CreateCustomerOperationsReport**](docs/PortalPaymentApi.md#createcustomeroperationsreport) | **POST** /api/2.0/portal/payment/customer/operationsreport | Generate the customer operations report
*PortalPaymentApi* | [**GetCheckoutSetupUrl**](docs/PortalPaymentApi.md#getcheckoutsetupurl) | **GET** /api/2.0/portal/payment/chechoutsetupurl | Get the checkout setup page URL
*PortalPaymentApi* | [**GetCustomerBalance**](docs/PortalPaymentApi.md#getcustomerbalance) | **GET** /api/2.0/portal/payment/customer/balance | Get the customer balance
*PortalPaymentApi* | [**GetCustomerInfo**](docs/PortalPaymentApi.md#getcustomerinfo) | **GET** /api/2.0/portal/payment/customerinfo | Get the customer info
*PortalPaymentApi* | [**GetCustomerOperations**](docs/PortalPaymentApi.md#getcustomeroperations) | **GET** /api/2.0/portal/payment/customer/operations | Get the customer operations
*PortalPaymentApi* | [**GetPaymentAccount**](docs/PortalPaymentApi.md#getpaymentaccount) | **GET** /api/2.0/portal/payment/account | Get the payment account
*PortalPaymentApi* | [**GetPaymentCurrencies**](docs/PortalPaymentApi.md#getpaymentcurrencies) | **GET** /api/2.0/portal/payment/currencies | Get currencies
*PortalPaymentApi* | [**GetPaymentQuotas**](docs/PortalPaymentApi.md#getpaymentquotas) | **GET** /api/2.0/portal/payment/quotas | Get quotas
*PortalPaymentApi* | [**GetPaymentUrl**](docs/PortalPaymentApi.md#getpaymenturl) | **PUT** /api/2.0/portal/payment/url | Get the payment page URL
*PortalPaymentApi* | [**GetPortalPrices**](docs/PortalPaymentApi.md#getportalprices) | **GET** /api/2.0/portal/payment/prices | Get prices
*PortalPaymentApi* | [**GetQuotaPaymentInformation**](docs/PortalPaymentApi.md#getquotapaymentinformation) | **GET** /api/2.0/portal/payment/quota | Get quota payment information
*PortalPaymentApi* | [**GetTenantWalletSettings**](docs/PortalPaymentApi.md#gettenantwalletsettings) | **GET** /api/2.0/portal/payment/topupsettings | Get wallet auto top up settings
*PortalPaymentApi* | [**SendPaymentRequest**](docs/PortalPaymentApi.md#sendpaymentrequest) | **POST** /api/2.0/portal/payment/request | Send a payment request
*PortalPaymentApi* | [**SetTenantWalletSettings**](docs/PortalPaymentApi.md#settenantwalletsettings) | **POST** /api/2.0/portal/payment/topupsettings | Set wallet auto top up settings
*PortalPaymentApi* | [**TopUpDeposit**](docs/PortalPaymentApi.md#topupdeposit) | **POST** /api/2.0/portal/payment/deposit | Put money on deposit
*PortalPaymentApi* | [**UpdatePayment**](docs/PortalPaymentApi.md#updatepayment) | **PUT** /api/2.0/portal/payment/update | Update the payment quantity
*PortalPaymentApi* | [**UpdateWalletPayment**](docs/PortalPaymentApi.md#updatewalletpayment) | **PUT** /api/2.0/portal/payment/updatewallet | Update the wallet payment quantity
*PortalQuotaApi* | [**GetPortalQuota**](docs/PortalQuotaApi.md#getportalquota) | **GET** /api/2.0/portal/quota | Get a portal quota
*PortalQuotaApi* | [**GetPortalTariff**](docs/PortalQuotaApi.md#getportaltariff) | **GET** /api/2.0/portal/tariff | Get a portal tariff
*PortalQuotaApi* | [**GetPortalUsedSpace**](docs/PortalQuotaApi.md#getportalusedspace) | **GET** /api/2.0/portal/usedspace | Get the portal used space
*PortalQuotaApi* | [**GetRightQuota**](docs/PortalQuotaApi.md#getrightquota) | **GET** /api/2.0/portal/quota/right | Get the recommended quota
*PortalSettingsApi* | [**ContinuePortal**](docs/PortalSettingsApi.md#continueportal) | **PUT** /api/2.0/portal/continue | Restore a portal
*PortalSettingsApi* | [**DeletePortal**](docs/PortalSettingsApi.md#deleteportal) | **DELETE** /api/2.0/portal/delete | Delete a portal
*PortalSettingsApi* | [**GetPortalInformation**](docs/PortalSettingsApi.md#getportalinformation) | **GET** /api/2.0/portal | Get a portal
*PortalSettingsApi* | [**GetPortalPath**](docs/PortalSettingsApi.md#getportalpath) | **GET** /api/2.0/portal/path | Get a path to the portal
*PortalSettingsApi* | [**SendDeleteInstructions**](docs/PortalSettingsApi.md#senddeleteinstructions) | **POST** /api/2.0/portal/delete | Send removal instructions
*PortalSettingsApi* | [**SendSuspendInstructions**](docs/PortalSettingsApi.md#sendsuspendinstructions) | **POST** /api/2.0/portal/suspend | Send suspension instructions
*PortalSettingsApi* | [**SuspendPortal**](docs/PortalSettingsApi.md#suspendportal) | **PUT** /api/2.0/portal/suspend | Deactivate a portal
*PortalUsersApi* | [**GetInvitationLink**](docs/PortalUsersApi.md#getinvitationlink) | **GET** /api/2.0/portal/users/invite/{employeeType} | Get an invitation link
*PortalUsersApi* | [**GetPortalUsersCount**](docs/PortalUsersApi.md#getportaluserscount) | **GET** /api/2.0/portal/userscount | Get a number of portal users
*PortalUsersApi* | [**GetUserById**](docs/PortalUsersApi.md#getuserbyid) | **GET** /api/2.0/portal/users/{userID} | Get a user by ID
*PortalUsersApi* | [**MarkGiftMessageAsRead**](docs/PortalUsersApi.md#markgiftmessageasread) | **POST** /api/2.0/portal/present/mark | Mark a gift message as read
*PortalUsersApi* | [**SendCongratulations**](docs/PortalUsersApi.md#sendcongratulations) | **POST** /api/2.0/portal/sendcongratulations | Send congratulations
*RoomsApi* | [**AddRoomTags**](docs/RoomsApi.md#addroomtags) | **PUT** /api/2.0/files/rooms/{id}/tags | Add the room tags
*RoomsApi* | [**ArchiveRoom**](docs/RoomsApi.md#archiveroom) | **PUT** /api/2.0/files/rooms/{id}/archive | Archive a room
*RoomsApi* | [**ChangeRoomCover**](docs/RoomsApi.md#changeroomcover) | **POST** /api/2.0/files/rooms/{id}/cover | Change the room cover
*RoomsApi* | [**CreateRoom**](docs/RoomsApi.md#createroom) | **POST** /api/2.0/files/rooms | Create a room
*RoomsApi* | [**CreateRoomFromTemplate**](docs/RoomsApi.md#createroomfromtemplate) | **POST** /api/2.0/files/rooms/fromtemplate | Create a room from the template
*RoomsApi* | [**CreateRoomLogo**](docs/RoomsApi.md#createroomlogo) | **POST** /api/2.0/files/rooms/{id}/logo | Create a room logo
*RoomsApi* | [**CreateRoomTag**](docs/RoomsApi.md#createroomtag) | **POST** /api/2.0/files/tags | Create a tag
*RoomsApi* | [**CreateRoomTemplate**](docs/RoomsApi.md#createroomtemplate) | **POST** /api/2.0/files/roomtemplate | Start creating room template
*RoomsApi* | [**CreateRoomThirdParty**](docs/RoomsApi.md#createroomthirdparty) | **POST** /api/2.0/files/rooms/thirdparty/{id} | Create a third-party room
*RoomsApi* | [**DeleteCustomTags**](docs/RoomsApi.md#deletecustomtags) | **DELETE** /api/2.0/files/tags | Delete tags
*RoomsApi* | [**DeleteRoom**](docs/RoomsApi.md#deleteroom) | **DELETE** /api/2.0/files/rooms/{id} | Remove a room
*RoomsApi* | [**DeleteRoomLogo**](docs/RoomsApi.md#deleteroomlogo) | **DELETE** /api/2.0/files/rooms/{id}/logo | Remove a room logo
*RoomsApi* | [**DeleteRoomTags**](docs/RoomsApi.md#deleteroomtags) | **DELETE** /api/2.0/files/rooms/{id}/tags | Remove the room tags
*RoomsApi* | [**GetNewRoomItems**](docs/RoomsApi.md#getnewroomitems) | **GET** /api/2.0/files/rooms/{id}/news | Get the new room items
*RoomsApi* | [**GetPublicSettings**](docs/RoomsApi.md#getpublicsettings) | **GET** /api/2.0/files/roomtemplate/{id}/public | Get public settings
*RoomsApi* | [**GetRoomCovers**](docs/RoomsApi.md#getroomcovers) | **GET** /api/2.0/files/rooms/covers | Get covers
*RoomsApi* | [**GetRoomCreatingStatus**](docs/RoomsApi.md#getroomcreatingstatus) | **GET** /api/2.0/files/rooms/fromtemplate/status | Get the room creation progress
*RoomsApi* | [**GetRoomIndexExport**](docs/RoomsApi.md#getroomindexexport) | **GET** /api/2.0/files/rooms/indexexport | Get the room index export
*RoomsApi* | [**GetRoomInfo**](docs/RoomsApi.md#getroominfo) | **GET** /api/2.0/files/rooms/{id} | Get room information
*RoomsApi* | [**GetRoomLinks**](docs/RoomsApi.md#getroomlinks) | **GET** /api/2.0/files/rooms/{id}/links | Get the room links
*RoomsApi* | [**GetRoomSecurityInfo**](docs/RoomsApi.md#getroomsecurityinfo) | **GET** /api/2.0/files/rooms/{id}/share | Get the room access rights
*RoomsApi* | [**GetRoomTagsInfo**](docs/RoomsApi.md#getroomtagsinfo) | **GET** /api/2.0/files/tags | Get tags
*RoomsApi* | [**GetRoomTemplateCreatingStatus**](docs/RoomsApi.md#getroomtemplatecreatingstatus) | **GET** /api/2.0/files/roomtemplate/status | Get status of room template creation
*RoomsApi* | [**GetRoomsFolder**](docs/RoomsApi.md#getroomsfolder) | **GET** /api/2.0/files/rooms | Get rooms
*RoomsApi* | [**GetRoomsNewItems**](docs/RoomsApi.md#getroomsnewitems) | **GET** /api/2.0/files/rooms/news | Get the room new items
*RoomsApi* | [**GetRoomsPrimaryExternalLink**](docs/RoomsApi.md#getroomsprimaryexternallink) | **GET** /api/2.0/files/rooms/{id}/link | Get the room primary external link
*RoomsApi* | [**PinRoom**](docs/RoomsApi.md#pinroom) | **PUT** /api/2.0/files/rooms/{id}/pin | Pin a room
*RoomsApi* | [**ReorderRoom**](docs/RoomsApi.md#reorderroom) | **PUT** /api/2.0/files/rooms/{id}/reorder | Reorder the room
*RoomsApi* | [**ResendEmailInvitations**](docs/RoomsApi.md#resendemailinvitations) | **POST** /api/2.0/files/rooms/{id}/resend | Resend the room invitations
*RoomsApi* | [**SetPublicSettings**](docs/RoomsApi.md#setpublicsettings) | **PUT** /api/2.0/files/roomtemplate/public | Set public settings
*RoomsApi* | [**SetRoomLink**](docs/RoomsApi.md#setroomlink) | **PUT** /api/2.0/files/rooms/{id}/links | Set the room external or invitation link
*RoomsApi* | [**SetRoomSecurity**](docs/RoomsApi.md#setroomsecurity) | **PUT** /api/2.0/files/rooms/{id}/share | Set the room access rights
*RoomsApi* | [**StartRoomIndexExport**](docs/RoomsApi.md#startroomindexexport) | **POST** /api/2.0/files/rooms/{id}/indexexport | Start the room index export
*RoomsApi* | [**TerminateRoomIndexExport**](docs/RoomsApi.md#terminateroomindexexport) | **DELETE** /api/2.0/files/rooms/indexexport | Terminate the room index export
*RoomsApi* | [**UnarchiveRoom**](docs/RoomsApi.md#unarchiveroom) | **PUT** /api/2.0/files/rooms/{id}/unarchive | Unarchive a room
*RoomsApi* | [**UnpinRoom**](docs/RoomsApi.md#unpinroom) | **PUT** /api/2.0/files/rooms/{id}/unpin | Unpin a room
*RoomsApi* | [**UpdateRoom**](docs/RoomsApi.md#updateroom) | **PUT** /api/2.0/files/rooms/{id} | Update a room
*RoomsApi* | [**UploadRoomLogo**](docs/RoomsApi.md#uploadroomlogo) | **POST** /api/2.0/files/logos | Upload a room logo image
*SecurityAccessToDevToolsApi* | [**SetTenantDevToolsAccessSettings**](docs/SecurityAccessToDevToolsApi.md#settenantdevtoolsaccesssettings) | **POST** /api/2.0/settings/devtoolsaccess | Set the Developer Tools access settings
*SecurityActiveConnectionsApi* | [**GetAllActiveConnections**](docs/SecurityActiveConnectionsApi.md#getallactiveconnections) | **GET** /api/2.0/security/activeconnections | Get active connections
*SecurityActiveConnectionsApi* | [**LogOutActiveConnection**](docs/SecurityActiveConnectionsApi.md#logoutactiveconnection) | **PUT** /api/2.0/security/activeconnections/logout/{loginEventId} | Log out from the connection
*SecurityActiveConnectionsApi* | [**LogOutAllActiveConnectionsChangePassword**](docs/SecurityActiveConnectionsApi.md#logoutallactiveconnectionschangepassword) | **PUT** /api/2.0/security/activeconnections/logoutallchangepassword | Log out and change password
*SecurityActiveConnectionsApi* | [**LogOutAllActiveConnectionsForUser**](docs/SecurityActiveConnectionsApi.md#logoutallactiveconnectionsforuser) | **PUT** /api/2.0/security/activeconnections/logoutall/{userId} | Log out for the user by ID
*SecurityActiveConnectionsApi* | [**LogOutAllExceptThisConnection**](docs/SecurityActiveConnectionsApi.md#logoutallexceptthisconnection) | **PUT** /api/2.0/security/activeconnections/logoutallexceptthis | Log out from all connections except the current one
*SecurityAuditTrailDataApi* | [**CreateAuditTrailReport**](docs/SecurityAuditTrailDataApi.md#createaudittrailreport) | **POST** /api/2.0/security/audit/events/report | Generate the audit trail report
*SecurityAuditTrailDataApi* | [**GetAuditEventsByFilter**](docs/SecurityAuditTrailDataApi.md#getauditeventsbyfilter) | **GET** /api/2.0/security/audit/events/filter | Get filtered audit trail data
*SecurityAuditTrailDataApi* | [**GetAuditSettings**](docs/SecurityAuditTrailDataApi.md#getauditsettings) | **GET** /api/2.0/security/audit/settings/lifetime | Get the audit trail settings
*SecurityAuditTrailDataApi* | [**GetAuditTrailMappers**](docs/SecurityAuditTrailDataApi.md#getaudittrailmappers) | **GET** /api/2.0/security/audit/mappers | Get audit trail mappers
*SecurityAuditTrailDataApi* | [**GetAuditTrailTypes**](docs/SecurityAuditTrailDataApi.md#getaudittrailtypes) | **GET** /api/2.0/security/audit/types | Get audit trail types
*SecurityAuditTrailDataApi* | [**GetLastAuditEvents**](docs/SecurityAuditTrailDataApi.md#getlastauditevents) | **GET** /api/2.0/security/audit/events/last | Get audit trail data
*SecurityAuditTrailDataApi* | [**SetAuditSettings**](docs/SecurityAuditTrailDataApi.md#setauditsettings) | **POST** /api/2.0/security/audit/settings/lifetime | Set the audit trail settings
*SecurityBannersVisibilityApi* | [**SetTenantBannerSettings**](docs/SecurityBannersVisibilityApi.md#settenantbannersettings) | **POST** /api/2.0/settings/banner | Set the promotional banners visibility settings
*SecurityCSPApi* | [**ConfigureCsp**](docs/SecurityCSPApi.md#configurecsp) | **POST** /api/2.0/security/csp | Configure CSP settings
*SecurityCSPApi* | [**GetCspSettings**](docs/SecurityCSPApi.md#getcspsettings) | **GET** /api/2.0/security/csp | Get CSP settings
*SecurityFirebaseApi* | [**DocRegisterPusnNotificationDevice**](docs/SecurityFirebaseApi.md#docregisterpusnnotificationdevice) | **POST** /api/2.0/settings/push/docregisterdevice | Save the Documents Firebase device token
*SecurityFirebaseApi* | [**SubscribeDocumentsPushNotification**](docs/SecurityFirebaseApi.md#subscribedocumentspushnotification) | **PUT** /api/2.0/settings/push/docsubscribe | Subscribe to Documents push notification
*SecurityLoginHistoryApi* | [**CreateLoginHistoryReport**](docs/SecurityLoginHistoryApi.md#createloginhistoryreport) | **POST** /api/2.0/security/audit/login/report | Generate the login history report
*SecurityLoginHistoryApi* | [**GetLastLoginEvents**](docs/SecurityLoginHistoryApi.md#getlastloginevents) | **GET** /api/2.0/security/audit/login/last | Get login history
*SecurityLoginHistoryApi* | [**GetLoginEventsByFilter**](docs/SecurityLoginHistoryApi.md#getlogineventsbyfilter) | **GET** /api/2.0/security/audit/login/filter | Get filtered login events
*SecurityOAuth2Api* | [**GenerateJwtToken**](docs/SecurityOAuth2Api.md#generatejwttoken) | **GET** /api/2.0/security/oauth2/token | Generate JWT token
*SecuritySMTPSettingsApi* | [**GetSmtpOperationStatus**](docs/SecuritySMTPSettingsApi.md#getsmtpoperationstatus) | **GET** /api/2.0/smtpsettings/smtp/test/status | Get the SMTP testing process status
*SecuritySMTPSettingsApi* | [**GetSmtpSettings**](docs/SecuritySMTPSettingsApi.md#getsmtpsettings) | **GET** /api/2.0/smtpsettings/smtp | Get the SMTP settings
*SecuritySMTPSettingsApi* | [**ResetSmtpSettings**](docs/SecuritySMTPSettingsApi.md#resetsmtpsettings) | **DELETE** /api/2.0/smtpsettings/smtp | Reset the SMTP settings
*SecuritySMTPSettingsApi* | [**SaveSmtpSettings**](docs/SecuritySMTPSettingsApi.md#savesmtpsettings) | **POST** /api/2.0/smtpsettings/smtp | Save the SMTP settings
*SecuritySMTPSettingsApi* | [**TestSmtpSettings**](docs/SecuritySMTPSettingsApi.md#testsmtpsettings) | **GET** /api/2.0/smtpsettings/smtp/test | Test the SMTP settings
*SettingsAccessToDevToolsApi* | [**GetTenantAccessDevToolsSettings**](docs/SettingsAccessToDevToolsApi.md#gettenantaccessdevtoolssettings) | **GET** /api/2.0/settings/devtoolsaccess | Get the Developer Tools access settings
*SettingsAuthorizationApi* | [**GetAuthServices**](docs/SettingsAuthorizationApi.md#getauthservices) | **GET** /api/2.0/settings/authservice | Get the authorization services
*SettingsAuthorizationApi* | [**SaveAuthKeys**](docs/SettingsAuthorizationApi.md#saveauthkeys) | **POST** /api/2.0/settings/authservice | Save the authorization keys
*SettingsBannersVisibilityApi* | [**GetTenantBannerSettings**](docs/SettingsBannersVisibilityApi.md#gettenantbannersettings) | **GET** /api/2.0/settings/banner | Get the promotional banners visibility settings
*SettingsCommonSettingsApi* | [**CloseAdminHelper**](docs/SettingsCommonSettingsApi.md#closeadminhelper) | **PUT** /api/2.0/settings/closeadminhelper | Close the admin helper
*SettingsCommonSettingsApi* | [**CompleteWizard**](docs/SettingsCommonSettingsApi.md#completewizard) | **PUT** /api/2.0/settings/wizard/complete | Complete the Wizard settings
*SettingsCommonSettingsApi* | [**ConfigureDeepLink**](docs/SettingsCommonSettingsApi.md#configuredeeplink) | **POST** /api/2.0/settings/deeplink | Configure the deep link settings
*SettingsCommonSettingsApi* | [**DeletePortalColorTheme**](docs/SettingsCommonSettingsApi.md#deleteportalcolortheme) | **DELETE** /api/2.0/settings/colortheme | Delete a color theme
*SettingsCommonSettingsApi* | [**GetDeepLinkSettings**](docs/SettingsCommonSettingsApi.md#getdeeplinksettings) | **GET** /api/2.0/settings/deeplink | Get the deep link settings
*SettingsCommonSettingsApi* | [**GetPaymentSettings**](docs/SettingsCommonSettingsApi.md#getpaymentsettings) | **GET** /api/2.0/settings/payment | Get the payment settings
*SettingsCommonSettingsApi* | [**GetPortalColorTheme**](docs/SettingsCommonSettingsApi.md#getportalcolortheme) | **GET** /api/2.0/settings/colortheme | Get a color theme
*SettingsCommonSettingsApi* | [**GetPortalHostname**](docs/SettingsCommonSettingsApi.md#getportalhostname) | **GET** /api/2.0/settings/machine | Get hostname
*SettingsCommonSettingsApi* | [**GetPortalLogo**](docs/SettingsCommonSettingsApi.md#getportallogo) | **GET** /api/2.0/settings/logo | Get a portal logo
*SettingsCommonSettingsApi* | [**GetPortalSettings**](docs/SettingsCommonSettingsApi.md#getportalsettings) | **GET** /api/2.0/settings | Get the portal settings
*SettingsCommonSettingsApi* | [**GetSocketSettings**](docs/SettingsCommonSettingsApi.md#getsocketsettings) | **GET** /api/2.0/settings/socket | Get the socket settings
*SettingsCommonSettingsApi* | [**GetSupportedCultures**](docs/SettingsCommonSettingsApi.md#getsupportedcultures) | **GET** /api/2.0/settings/cultures | Get supported languages
*SettingsCommonSettingsApi* | [**GetTenantUserInvitationSettings**](docs/SettingsCommonSettingsApi.md#gettenantuserinvitationsettings) | **GET** /api/2.0/settings/invitationsettings | Get the user invitation settings
*SettingsCommonSettingsApi* | [**GetTimeZones**](docs/SettingsCommonSettingsApi.md#gettimezones) | **GET** /api/2.0/settings/timezones | Get time zones
*SettingsCommonSettingsApi* | [**SaveDnsSettings**](docs/SettingsCommonSettingsApi.md#savednssettings) | **PUT** /api/2.0/settings/dns | Save the DNS settings
*SettingsCommonSettingsApi* | [**SaveMailDomainSettings**](docs/SettingsCommonSettingsApi.md#savemaildomainsettings) | **POST** /api/2.0/settings/maildomainsettings | Save the mail domain settings
*SettingsCommonSettingsApi* | [**SavePortalColorTheme**](docs/SettingsCommonSettingsApi.md#saveportalcolortheme) | **PUT** /api/2.0/settings/colortheme | Save a color theme
*SettingsCommonSettingsApi* | [**UpdateEmailActivationSettings**](docs/SettingsCommonSettingsApi.md#updateemailactivationsettings) | **PUT** /api/2.0/settings/emailactivation | Update the email activation settings
*SettingsCommonSettingsApi* | [**UpdateInvitationSettings**](docs/SettingsCommonSettingsApi.md#updateinvitationsettings) | **PUT** /api/2.0/settings/invitationsettings | Update user invitation settings
*SettingsCookiesApi* | [**GetCookieSettings**](docs/SettingsCookiesApi.md#getcookiesettings) | **GET** /api/2.0/settings/cookiesettings | Get cookies lifetime
*SettingsCookiesApi* | [**UpdateCookieSettings**](docs/SettingsCookiesApi.md#updatecookiesettings) | **PUT** /api/2.0/settings/cookiesettings | Update cookies lifetime
*SettingsCustomNavigationApi* | [**CreateCustomNavigationItem**](docs/SettingsCustomNavigationApi.md#createcustomnavigationitem) | **POST** /api/2.0/settings/customnavigation/create | Add a custom navigation item
*SettingsCustomNavigationApi* | [**DeleteCustomNavigationItem**](docs/SettingsCustomNavigationApi.md#deletecustomnavigationitem) | **DELETE** /api/2.0/settings/customnavigation/delete/{id} | Delete a custom navigation item
*SettingsCustomNavigationApi* | [**GetCustomNavigationItem**](docs/SettingsCustomNavigationApi.md#getcustomnavigationitem) | **GET** /api/2.0/settings/customnavigation/get/{id} | Get a custom navigation item by ID
*SettingsCustomNavigationApi* | [**GetCustomNavigationItemSample**](docs/SettingsCustomNavigationApi.md#getcustomnavigationitemsample) | **GET** /api/2.0/settings/customnavigation/getsample | Get a custom navigation item sample
*SettingsCustomNavigationApi* | [**GetCustomNavigationItems**](docs/SettingsCustomNavigationApi.md#getcustomnavigationitems) | **GET** /api/2.0/settings/customnavigation/getall | Get the custom navigation items
*SettingsEncryptionApi* | [**GetStorageEncryptionProgress**](docs/SettingsEncryptionApi.md#getstorageencryptionprogress) | **GET** /api/2.0/settings/encryption/progress | Get the storage encryption progress
*SettingsEncryptionApi* | [**GetStorageEncryptionSettings**](docs/SettingsEncryptionApi.md#getstorageencryptionsettings) | **GET** /api/2.0/settings/encryption/settings | Get the storage encryption settings
*SettingsEncryptionApi* | [**StartStorageEncryption**](docs/SettingsEncryptionApi.md#startstorageencryption) | **POST** /api/2.0/settings/encryption/start | Start the storage encryption process
*SettingsGreetingSettingsApi* | [**GetGreetingSettings**](docs/SettingsGreetingSettingsApi.md#getgreetingsettings) | **GET** /api/2.0/settings/greetingsettings | Get greeting settings
*SettingsGreetingSettingsApi* | [**GetIsDefaultGreetingSettings**](docs/SettingsGreetingSettingsApi.md#getisdefaultgreetingsettings) | **GET** /api/2.0/settings/greetingsettings/isdefault | Check the default greeting settings
*SettingsGreetingSettingsApi* | [**RestoreGreetingSettings**](docs/SettingsGreetingSettingsApi.md#restoregreetingsettings) | **POST** /api/2.0/settings/greetingsettings/restore | Restore the greeting settings
*SettingsGreetingSettingsApi* | [**SaveGreetingSettings**](docs/SettingsGreetingSettingsApi.md#savegreetingsettings) | **POST** /api/2.0/settings/greetingsettings | Save the greeting settings
*SettingsIPRestrictionsApi* | [**GetIpRestrictions**](docs/SettingsIPRestrictionsApi.md#getiprestrictions) | **GET** /api/2.0/settings/iprestrictions | Get the IP portal restrictions
*SettingsIPRestrictionsApi* | [**ReadIpRestrictionsSettings**](docs/SettingsIPRestrictionsApi.md#readiprestrictionssettings) | **GET** /api/2.0/settings/iprestrictions/settings | Get the IP restriction settings
*SettingsIPRestrictionsApi* | [**SaveIpRestrictions**](docs/SettingsIPRestrictionsApi.md#saveiprestrictions) | **PUT** /api/2.0/settings/iprestrictions | Update the IP restrictions
*SettingsIPRestrictionsApi* | [**UpdateIpRestrictionsSettings**](docs/SettingsIPRestrictionsApi.md#updateiprestrictionssettings) | **PUT** /api/2.0/settings/iprestrictions/settings | Update the IP restriction settings
*SettingsLicenseApi* | [**AcceptLicense**](docs/SettingsLicenseApi.md#acceptlicense) | **POST** /api/2.0/settings/license/accept | Activate a license
*SettingsLicenseApi* | [**GetIsLicenseRequired**](docs/SettingsLicenseApi.md#getislicenserequired) | **GET** /api/2.0/settings/license/required | Request a license
*SettingsLicenseApi* | [**RefreshLicense**](docs/SettingsLicenseApi.md#refreshlicense) | **GET** /api/2.0/settings/license/refresh | Refresh the license
*SettingsLicenseApi* | [**UploadLicense**](docs/SettingsLicenseApi.md#uploadlicense) | **POST** /api/2.0/settings/license | Upload a license
*SettingsLoginSettingsApi* | [**GetLoginSettings**](docs/SettingsLoginSettingsApi.md#getloginsettings) | **GET** /api/2.0/settings/security/loginsettings | Get the login settings
*SettingsLoginSettingsApi* | [**SetDefaultLoginSettings**](docs/SettingsLoginSettingsApi.md#setdefaultloginsettings) | **DELETE** /api/2.0/settings/security/loginsettings | Reset the login settings
*SettingsLoginSettingsApi* | [**UpdateLoginSettings**](docs/SettingsLoginSettingsApi.md#updateloginsettings) | **PUT** /api/2.0/settings/security/loginsettings | Update the login settings
*SettingsMessagesApi* | [**EnableAdminMessageSettings**](docs/SettingsMessagesApi.md#enableadminmessagesettings) | **POST** /api/2.0/settings/messagesettings | Enable the administrator message settings
*SettingsMessagesApi* | [**SendAdminMail**](docs/SettingsMessagesApi.md#sendadminmail) | **POST** /api/2.0/settings/sendadmmail | Send a message to the administrator
*SettingsMessagesApi* | [**SendJoinInviteMail**](docs/SettingsMessagesApi.md#sendjoininvitemail) | **POST** /api/2.0/settings/sendjoininvite | Sends an invitation email
*SettingsNotificationsApi* | [**GetNotificationSettings**](docs/SettingsNotificationsApi.md#getnotificationsettings) | **GET** /api/2.0/settings/notification/{type} | Check notification availability
*SettingsNotificationsApi* | [**GetRoomsNotificationSettings**](docs/SettingsNotificationsApi.md#getroomsnotificationsettings) | **GET** /api/2.0/settings/notification/rooms | Get room notification settings
*SettingsNotificationsApi* | [**SetNotificationSettings**](docs/SettingsNotificationsApi.md#setnotificationsettings) | **POST** /api/2.0/settings/notification | Enable notifications
*SettingsNotificationsApi* | [**SetRoomsNotificationStatus**](docs/SettingsNotificationsApi.md#setroomsnotificationstatus) | **POST** /api/2.0/settings/notification/rooms | Set room notification status
*SettingsOwnerApi* | [**SendOwnerChangeInstructions**](docs/SettingsOwnerApi.md#sendownerchangeinstructions) | **POST** /api/2.0/settings/owner | Send the owner change instructions
*SettingsOwnerApi* | [**UpdatePortalOwner**](docs/SettingsOwnerApi.md#updateportalowner) | **PUT** /api/2.0/settings/owner | Update the portal owner
*SettingsQuotaApi* | [**GetUserQuotaSettings**](docs/SettingsQuotaApi.md#getuserquotasettings) | **GET** /api/2.0/settings/userquotasettings | Get the user quota settings
*SettingsQuotaApi* | [**SaveRoomQuotaSettings**](docs/SettingsQuotaApi.md#saveroomquotasettings) | **POST** /api/2.0/settings/roomquotasettings | Save the room quota settings
*SettingsQuotaApi* | [**SetTenantQuotaSettings**](docs/SettingsQuotaApi.md#settenantquotasettings) | **PUT** /api/2.0/settings/tenantquotasettings | Save the tenant quota settings
*SettingsRebrandingApi* | [**DeleteAdditionalWhiteLabelSettings**](docs/SettingsRebrandingApi.md#deleteadditionalwhitelabelsettings) | **DELETE** /api/2.0/settings/rebranding/additional | Delete the additional white label settings
*SettingsRebrandingApi* | [**DeleteCompanyWhiteLabelSettings**](docs/SettingsRebrandingApi.md#deletecompanywhitelabelsettings) | **DELETE** /api/2.0/settings/rebranding/company | Delete the company white label settings
*SettingsRebrandingApi* | [**GetAdditionalWhiteLabelSettings**](docs/SettingsRebrandingApi.md#getadditionalwhitelabelsettings) | **GET** /api/2.0/settings/rebranding/additional | Get the additional white label settings
*SettingsRebrandingApi* | [**GetCompanyWhiteLabelSettings**](docs/SettingsRebrandingApi.md#getcompanywhitelabelsettings) | **GET** /api/2.0/settings/rebranding/company | Get the company white label settings
*SettingsRebrandingApi* | [**GetEnableWhitelabel**](docs/SettingsRebrandingApi.md#getenablewhitelabel) | **GET** /api/2.0/settings/enablewhitelabel | Check the white label availability
*SettingsRebrandingApi* | [**GetIsDefaultWhiteLabelLogoText**](docs/SettingsRebrandingApi.md#getisdefaultwhitelabellogotext) | **GET** /api/2.0/settings/whitelabel/logotext/isdefault | Check the default white label logo text
*SettingsRebrandingApi* | [**GetIsDefaultWhiteLabelLogos**](docs/SettingsRebrandingApi.md#getisdefaultwhitelabellogos) | **GET** /api/2.0/settings/whitelabel/logos/isdefault | Check the default white label logos
*SettingsRebrandingApi* | [**GetLicensorData**](docs/SettingsRebrandingApi.md#getlicensordata) | **GET** /api/2.0/settings/companywhitelabel | Get the licensor data
*SettingsRebrandingApi* | [**GetWhiteLabelLogoText**](docs/SettingsRebrandingApi.md#getwhitelabellogotext) | **GET** /api/2.0/settings/whitelabel/logotext | Get the white label logo text
*SettingsRebrandingApi* | [**GetWhiteLabelLogos**](docs/SettingsRebrandingApi.md#getwhitelabellogos) | **GET** /api/2.0/settings/whitelabel/logos | Get the white label logos
*SettingsRebrandingApi* | [**RestoreWhiteLabelLogoText**](docs/SettingsRebrandingApi.md#restorewhitelabellogotext) | **PUT** /api/2.0/settings/whitelabel/logotext/restore | Restore the white label logo text
*SettingsRebrandingApi* | [**RestoreWhiteLabelLogos**](docs/SettingsRebrandingApi.md#restorewhitelabellogos) | **PUT** /api/2.0/settings/whitelabel/logos/restore | Restore the white label logos
*SettingsRebrandingApi* | [**SaveAdditionalWhiteLabelSettings**](docs/SettingsRebrandingApi.md#saveadditionalwhitelabelsettings) | **POST** /api/2.0/settings/rebranding/additional | Save the additional white label settings
*SettingsRebrandingApi* | [**SaveCompanyWhiteLabelSettings**](docs/SettingsRebrandingApi.md#savecompanywhitelabelsettings) | **POST** /api/2.0/settings/rebranding/company | Save the company white label settings
*SettingsRebrandingApi* | [**SaveWhiteLabelLogoText**](docs/SettingsRebrandingApi.md#savewhitelabellogotext) | **POST** /api/2.0/settings/whitelabel/logotext/save | Save the white label logo text settings
*SettingsRebrandingApi* | [**SaveWhiteLabelSettings**](docs/SettingsRebrandingApi.md#savewhitelabelsettings) | **POST** /api/2.0/settings/whitelabel/logos/save | Save the white label logos
*SettingsRebrandingApi* | [**SaveWhiteLabelSettingsFromFiles**](docs/SettingsRebrandingApi.md#savewhitelabelsettingsfromfiles) | **POST** /api/2.0/settings/whitelabel/logos/savefromfiles | Save the white label logos from files
*SettingsSSOApi* | [**GetDefaultSsoSettingsV2**](docs/SettingsSSOApi.md#getdefaultssosettingsv2) | **GET** /api/2.0/settings/ssov2/default | Get the default SSO settings
*SettingsSSOApi* | [**GetSsoSettingsV2**](docs/SettingsSSOApi.md#getssosettingsv2) | **GET** /api/2.0/settings/ssov2 | Get the SSO settings
*SettingsSSOApi* | [**GetSsoSettingsV2Constants**](docs/SettingsSSOApi.md#getssosettingsv2constants) | **GET** /api/2.0/settings/ssov2/constants | Get the SSO settings constants
*SettingsSSOApi* | [**ResetSsoSettingsV2**](docs/SettingsSSOApi.md#resetssosettingsv2) | **DELETE** /api/2.0/settings/ssov2 | Reset the SSO settings
*SettingsSSOApi* | [**SaveSsoSettingsV2**](docs/SettingsSSOApi.md#savessosettingsv2) | **POST** /api/2.0/settings/ssov2 | Save the SSO settings
*SettingsSecurityApi* | [**GetEnabledModules**](docs/SettingsSecurityApi.md#getenabledmodules) | **GET** /api/2.0/settings/security/modules | Get the enabled modules
*SettingsSecurityApi* | [**GetIsProductAdministrator**](docs/SettingsSecurityApi.md#getisproductadministrator) | **GET** /api/2.0/settings/security/administrator | Check a product administrator
*SettingsSecurityApi* | [**GetPasswordSettings**](docs/SettingsSecurityApi.md#getpasswordsettings) | **GET** /api/2.0/settings/security/password | Get the password settings
*SettingsSecurityApi* | [**GetProductAdministrators**](docs/SettingsSecurityApi.md#getproductadministrators) | **GET** /api/2.0/settings/security/administrator/{productid} | Get the product administrators
*SettingsSecurityApi* | [**GetWebItemSecurityInfo**](docs/SettingsSecurityApi.md#getwebitemsecurityinfo) | **GET** /api/2.0/settings/security/{id} | Get the module availability
*SettingsSecurityApi* | [**GetWebItemSettingsSecurityInfo**](docs/SettingsSecurityApi.md#getwebitemsettingssecurityinfo) | **GET** /api/2.0/settings/security | Get the security settings
*SettingsSecurityApi* | [**SetAccessToWebItems**](docs/SettingsSecurityApi.md#setaccesstowebitems) | **PUT** /api/2.0/settings/security/access | Set the security settings to modules
*SettingsSecurityApi* | [**SetProductAdministrator**](docs/SettingsSecurityApi.md#setproductadministrator) | **PUT** /api/2.0/settings/security/administrator | Set a product administrator
*SettingsSecurityApi* | [**SetWebItemSecurity**](docs/SettingsSecurityApi.md#setwebitemsecurity) | **PUT** /api/2.0/settings/security | Set the module security settings
*SettingsSecurityApi* | [**UpdatePasswordSettings**](docs/SettingsSecurityApi.md#updatepasswordsettings) | **PUT** /api/2.0/settings/security/password | Set the password settings
*SettingsStatisticsApi* | [**GetSpaceUsageStatistics**](docs/SettingsStatisticsApi.md#getspaceusagestatistics) | **GET** /api/2.0/settings/statistics/spaceusage/{id} | Get the space usage statistics
*SettingsStorageApi* | [**GetAllBackupStorages**](docs/SettingsStorageApi.md#getallbackupstorages) | **GET** /api/2.0/settings/storage/backup | Get the backup storages
*SettingsStorageApi* | [**GetAllCdnStorages**](docs/SettingsStorageApi.md#getallcdnstorages) | **GET** /api/2.0/settings/storage/cdn | Get the CDN storages
*SettingsStorageApi* | [**GetAllStorages**](docs/SettingsStorageApi.md#getallstorages) | **GET** /api/2.0/settings/storage | Get storages
*SettingsStorageApi* | [**GetAmazonS3Regions**](docs/SettingsStorageApi.md#getamazons3regions) | **GET** /api/2.0/settings/storage/s3/regions | Get Amazon regions
*SettingsStorageApi* | [**GetStorageProgress**](docs/SettingsStorageApi.md#getstorageprogress) | **GET** /api/2.0/settings/storage/progress | Get the storage progress
*SettingsStorageApi* | [**ResetCdnToDefault**](docs/SettingsStorageApi.md#resetcdntodefault) | **DELETE** /api/2.0/settings/storage/cdn | Reset the CDN storage settings
*SettingsStorageApi* | [**ResetStorageToDefault**](docs/SettingsStorageApi.md#resetstoragetodefault) | **DELETE** /api/2.0/settings/storage | Reset the storage settings
*SettingsStorageApi* | [**UpdateCdnStorage**](docs/SettingsStorageApi.md#updatecdnstorage) | **PUT** /api/2.0/settings/storage/cdn | Update the CDN storage
*SettingsStorageApi* | [**UpdateStorage**](docs/SettingsStorageApi.md#updatestorage) | **PUT** /api/2.0/settings/storage | Update a storage
*SettingsTFASettingsApi* | [**GetTfaAppCodes**](docs/SettingsTFASettingsApi.md#gettfaappcodes) | **GET** /api/2.0/settings/tfaappcodes | Get the TFA codes
*SettingsTFASettingsApi* | [**GetTfaConfirmUrl**](docs/SettingsTFASettingsApi.md#gettfaconfirmurl) | **GET** /api/2.0/settings/tfaapp/confirm | Get confirmation email
*SettingsTFASettingsApi* | [**GetTfaSettings**](docs/SettingsTFASettingsApi.md#gettfasettings) | **GET** /api/2.0/settings/tfaapp | Get the TFA settings
*SettingsTFASettingsApi* | [**TfaAppGenerateSetupCode**](docs/SettingsTFASettingsApi.md#tfaappgeneratesetupcode) | **GET** /api/2.0/settings/tfaapp/setup | Generate setup code
*SettingsTFASettingsApi* | [**TfaValidateAuthCode**](docs/SettingsTFASettingsApi.md#tfavalidateauthcode) | **POST** /api/2.0/settings/tfaapp/validate | Validate the TFA code
*SettingsTFASettingsApi* | [**UnlinkTfaApp**](docs/SettingsTFASettingsApi.md#unlinktfaapp) | **PUT** /api/2.0/settings/tfaappnewapp | Unlink the TFA application
*SettingsTFASettingsApi* | [**UpdateTfaAppCodes**](docs/SettingsTFASettingsApi.md#updatetfaappcodes) | **PUT** /api/2.0/settings/tfaappnewcodes | Update the TFA codes
*SettingsTFASettingsApi* | [**UpdateTfaSettings**](docs/SettingsTFASettingsApi.md#updatetfasettings) | **PUT** /api/2.0/settings/tfaapp | Update the TFA settings
*SettingsTFASettingsApi* | [**UpdateTfaSettingsLink**](docs/SettingsTFASettingsApi.md#updatetfasettingslink) | **PUT** /api/2.0/settings/tfaappwithlink | Get a confirmation email for updating TFA settings
*SettingsWebhooksApi* | [**CreateWebhook**](docs/SettingsWebhooksApi.md#createwebhook) | **POST** /api/2.0/settings/webhook | Create a webhook
*SettingsWebhooksApi* | [**EnableWebhook**](docs/SettingsWebhooksApi.md#enablewebhook) | **PUT** /api/2.0/settings/webhook/enable | Enable a webhook
*SettingsWebhooksApi* | [**GetTenantWebhooks**](docs/SettingsWebhooksApi.md#gettenantwebhooks) | **GET** /api/2.0/settings/webhook | Get webhooks
*SettingsWebhooksApi* | [**GetWebhookTriggers**](docs/SettingsWebhooksApi.md#getwebhooktriggers) | **GET** /api/2.0/settings/webhook/triggers | Get webhook triggers
*SettingsWebhooksApi* | [**GetWebhooksLogs**](docs/SettingsWebhooksApi.md#getwebhookslogs) | **GET** /api/2.0/settings/webhooks/log | Get webhook logs
*SettingsWebhooksApi* | [**RemoveWebhook**](docs/SettingsWebhooksApi.md#removewebhook) | **DELETE** /api/2.0/settings/webhook/{id} | Remove a webhook
*SettingsWebhooksApi* | [**RetryWebhook**](docs/SettingsWebhooksApi.md#retrywebhook) | **PUT** /api/2.0/settings/webhook/{id}/retry | Retry a webhook
*SettingsWebhooksApi* | [**RetryWebhooks**](docs/SettingsWebhooksApi.md#retrywebhooks) | **PUT** /api/2.0/settings/webhook/retry | Retry webhooks
*SettingsWebhooksApi* | [**UpdateWebhook**](docs/SettingsWebhooksApi.md#updatewebhook) | **PUT** /api/2.0/settings/webhook | Update a webhook
*SettingsWebpluginsApi* | [**AddWebPluginFromFile**](docs/SettingsWebpluginsApi.md#addwebpluginfromfile) | **POST** /api/2.0/settings/webplugins | Add a web plugin
*SettingsWebpluginsApi* | [**DeleteWebPlugin**](docs/SettingsWebpluginsApi.md#deletewebplugin) | **DELETE** /api/2.0/settings/webplugins/{name} | Delete a web plugin
*SettingsWebpluginsApi* | [**GetWebPlugin**](docs/SettingsWebpluginsApi.md#getwebplugin) | **GET** /api/2.0/settings/webplugins/{name} | Get a web plugin by name
*SettingsWebpluginsApi* | [**GetWebPlugins**](docs/SettingsWebpluginsApi.md#getwebplugins) | **GET** /api/2.0/settings/webplugins | Get web plugins
*SettingsWebpluginsApi* | [**UpdateWebPlugin**](docs/SettingsWebpluginsApi.md#updatewebplugin) | **PUT** /api/2.0/settings/webplugins/{name} | Update a web plugin
*ThirdPartyApi* | [**GetThirdPartyCode**](docs/ThirdPartyApi.md#getthirdpartycode) | **GET** /api/2.0/thirdparty/{provider} | Get the code request

</details>

<a id="documentation-for-models"></a>
## Documentation for Models

<details><summary>Models list</summary>
 - [Model.AccountInfoArrayWrapper](docs/AccountInfoArrayWrapper.md)
 - [Model.AccountInfoDto](docs/AccountInfoDto.md)
 - [Model.AccountLoginType](docs/AccountLoginType.md)
 - [Model.AceShortWrapper](docs/AceShortWrapper.md)
 - [Model.AceShortWrapperArrayWrapper](docs/AceShortWrapperArrayWrapper.md)
 - [Model.ActionConfig](docs/ActionConfig.md)
 - [Model.ActionLinkConfig](docs/ActionLinkConfig.md)
 - [Model.ActionType](docs/ActionType.md)
 - [Model.ActiveConnectionsDto](docs/ActiveConnectionsDto.md)
 - [Model.ActiveConnectionsItemDto](docs/ActiveConnectionsItemDto.md)
 - [Model.ActiveConnectionsWrapper](docs/ActiveConnectionsWrapper.md)
 - [Model.ActiveConnectionsWrapperLinksInner](docs/ActiveConnectionsWrapperLinksInner.md)
 - [Model.AdditionalWhiteLabelSettings](docs/AdditionalWhiteLabelSettings.md)
 - [Model.AdditionalWhiteLabelSettingsDto](docs/AdditionalWhiteLabelSettingsDto.md)
 - [Model.AdditionalWhiteLabelSettingsWrapper](docs/AdditionalWhiteLabelSettingsWrapper.md)
 - [Model.AdminMessageBaseSettingsRequestsDto](docs/AdminMessageBaseSettingsRequestsDto.md)
 - [Model.AdminMessageSettingsRequestsDto](docs/AdminMessageSettingsRequestsDto.md)
 - [Model.AnonymousConfigDto](docs/AnonymousConfigDto.md)
 - [Model.ApiDateTime](docs/ApiDateTime.md)
 - [Model.ApiKeyResponseArrayWrapper](docs/ApiKeyResponseArrayWrapper.md)
 - [Model.ApiKeyResponseDto](docs/ApiKeyResponseDto.md)
 - [Model.ApiKeyResponseWrapper](docs/ApiKeyResponseWrapper.md)
 - [Model.ApplyFilterOption](docs/ApplyFilterOption.md)
 - [Model.ArchiveRoomRequest](docs/ArchiveRoomRequest.md)
 - [Model.Area](docs/Area.md)
 - [Model.ArrayArrayWrapper](docs/ArrayArrayWrapper.md)
 - [Model.AuditEventArrayWrapper](docs/AuditEventArrayWrapper.md)
 - [Model.AuditEventDto](docs/AuditEventDto.md)
 - [Model.AuthData](docs/AuthData.md)
 - [Model.AuthKey](docs/AuthKey.md)
 - [Model.AuthRequestsDto](docs/AuthRequestsDto.md)
 - [Model.AuthServiceRequestsArrayWrapper](docs/AuthServiceRequestsArrayWrapper.md)
 - [Model.AuthServiceRequestsDto](docs/AuthServiceRequestsDto.md)
 - [Model.AuthenticationTokenDto](docs/AuthenticationTokenDto.md)
 - [Model.AuthenticationTokenWrapper](docs/AuthenticationTokenWrapper.md)
 - [Model.AutoCleanUpData](docs/AutoCleanUpData.md)
 - [Model.AutoCleanUpDataWrapper](docs/AutoCleanUpDataWrapper.md)
 - [Model.AutoCleanupRequestDto](docs/AutoCleanupRequestDto.md)
 - [Model.BackupDto](docs/BackupDto.md)
 - [Model.BackupHistoryRecord](docs/BackupHistoryRecord.md)
 - [Model.BackupHistoryRecordArrayWrapper](docs/BackupHistoryRecordArrayWrapper.md)
 - [Model.BackupPeriod](docs/BackupPeriod.md)
 - [Model.BackupProgress](docs/BackupProgress.md)
 - [Model.BackupProgressEnum](docs/BackupProgressEnum.md)
 - [Model.BackupProgressWrapper](docs/BackupProgressWrapper.md)
 - [Model.BackupRestoreDto](docs/BackupRestoreDto.md)
 - [Model.BackupScheduleDto](docs/BackupScheduleDto.md)
 - [Model.BackupStorageType](docs/BackupStorageType.md)
 - [Model.Balance](docs/Balance.md)
 - [Model.BalanceWrapper](docs/BalanceWrapper.md)
 - [Model.BaseBatchRequestDto](docs/BaseBatchRequestDto.md)
 - [Model.BaseBatchRequestDtoFolderIdsInner](docs/BaseBatchRequestDtoFolderIdsInner.md)
 - [Model.BatchRequestDto](docs/BatchRequestDto.md)
 - [Model.BatchRequestDtoDestFolderId](docs/BatchRequestDtoDestFolderId.md)
 - [Model.BatchTagsRequestDto](docs/BatchTagsRequestDto.md)
 - [Model.BooleanWrapper](docs/BooleanWrapper.md)
 - [Model.CapabilitiesDto](docs/CapabilitiesDto.md)
 - [Model.CapabilitiesWrapper](docs/CapabilitiesWrapper.md)
 - [Model.CdnStorageSettings](docs/CdnStorageSettings.md)
 - [Model.CdnStorageSettingsWrapper](docs/CdnStorageSettingsWrapper.md)
 - [Model.ChangeClientActivationRequest](docs/ChangeClientActivationRequest.md)
 - [Model.ChangeHistory](docs/ChangeHistory.md)
 - [Model.ChangeOwnerRequestDto](docs/ChangeOwnerRequestDto.md)
 - [Model.CheckConversionRequestDtoInteger](docs/CheckConversionRequestDtoInteger.md)
 - [Model.CheckDestFolderDto](docs/CheckDestFolderDto.md)
 - [Model.CheckDestFolderResult](docs/CheckDestFolderResult.md)
 - [Model.CheckDestFolderWrapper](docs/CheckDestFolderWrapper.md)
 - [Model.CheckDocServiceUrlRequestDto](docs/CheckDocServiceUrlRequestDto.md)
 - [Model.CheckFillFormDraft](docs/CheckFillFormDraft.md)
 - [Model.CheckUploadRequest](docs/CheckUploadRequest.md)
 - [Model.ClientInfoResponse](docs/ClientInfoResponse.md)
 - [Model.ClientResponse](docs/ClientResponse.md)
 - [Model.ClientSecretResponse](docs/ClientSecretResponse.md)
 - [Model.CoEditingConfig](docs/CoEditingConfig.md)
 - [Model.CoEditingConfigMode](docs/CoEditingConfigMode.md)
 - [Model.CompanyWhiteLabelSettings](docs/CompanyWhiteLabelSettings.md)
 - [Model.CompanyWhiteLabelSettingsArrayWrapper](docs/CompanyWhiteLabelSettingsArrayWrapper.md)
 - [Model.CompanyWhiteLabelSettingsDto](docs/CompanyWhiteLabelSettingsDto.md)
 - [Model.CompanyWhiteLabelSettingsWrapper](docs/CompanyWhiteLabelSettingsWrapper.md)
 - [Model.ConfigurationDtoInteger](docs/ConfigurationDtoInteger.md)
 - [Model.ConfigurationIntegerWrapper](docs/ConfigurationIntegerWrapper.md)
 - [Model.ConfirmData](docs/ConfirmData.md)
 - [Model.ConfirmDto](docs/ConfirmDto.md)
 - [Model.ConfirmType](docs/ConfirmType.md)
 - [Model.ConfirmWrapper](docs/ConfirmWrapper.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContentDisposition](docs/ContentDisposition.md)
 - [Model.ContentType](docs/ContentType.md)
 - [Model.ConversationResultArrayWrapper](docs/ConversationResultArrayWrapper.md)
 - [Model.ConversationResultDto](docs/ConversationResultDto.md)
 - [Model.CookieSettingsDto](docs/CookieSettingsDto.md)
 - [Model.CookieSettingsRequestsDto](docs/CookieSettingsRequestsDto.md)
 - [Model.CookieSettingsWrapper](docs/CookieSettingsWrapper.md)
 - [Model.CopyAsJsonElement](docs/CopyAsJsonElement.md)
 - [Model.CopyAsJsonElementDestFolderId](docs/CopyAsJsonElementDestFolderId.md)
 - [Model.CoverRequestDto](docs/CoverRequestDto.md)
 - [Model.CoversResultArrayWrapper](docs/CoversResultArrayWrapper.md)
 - [Model.CoversResultDto](docs/CoversResultDto.md)
 - [Model.CreateApiKeyRequestDto](docs/CreateApiKeyRequestDto.md)
 - [Model.CreateClientRequest](docs/CreateClientRequest.md)
 - [Model.CreateFileJsonElement](docs/CreateFileJsonElement.md)
 - [Model.CreateFileJsonElementTemplateId](docs/CreateFileJsonElementTemplateId.md)
 - [Model.CreateFolder](docs/CreateFolder.md)
 - [Model.CreateRoomFromTemplateDto](docs/CreateRoomFromTemplateDto.md)
 - [Model.CreateRoomRequestDto](docs/CreateRoomRequestDto.md)
 - [Model.CreateTagRequestDto](docs/CreateTagRequestDto.md)
 - [Model.CreateTextOrHtmlFile](docs/CreateTextOrHtmlFile.md)
 - [Model.CreateThirdPartyRoom](docs/CreateThirdPartyRoom.md)
 - [Model.CreateWebhooksConfigRequestsDto](docs/CreateWebhooksConfigRequestsDto.md)
 - [Model.Cron](docs/Cron.md)
 - [Model.CronParams](docs/CronParams.md)
 - [Model.CspDto](docs/CspDto.md)
 - [Model.CspRequestsDto](docs/CspRequestsDto.md)
 - [Model.CspWrapper](docs/CspWrapper.md)
 - [Model.Culture](docs/Culture.md)
 - [Model.CultureSpecificExternalResource](docs/CultureSpecificExternalResource.md)
 - [Model.CultureSpecificExternalResources](docs/CultureSpecificExternalResources.md)
 - [Model.CurrenciesArrayWrapper](docs/CurrenciesArrayWrapper.md)
 - [Model.CurrenciesDto](docs/CurrenciesDto.md)
 - [Model.CurrentLicenseInfo](docs/CurrentLicenseInfo.md)
 - [Model.CustomColorThemesSettingsColorItem](docs/CustomColorThemesSettingsColorItem.md)
 - [Model.CustomColorThemesSettingsDto](docs/CustomColorThemesSettingsDto.md)
 - [Model.CustomColorThemesSettingsItem](docs/CustomColorThemesSettingsItem.md)
 - [Model.CustomColorThemesSettingsRequestsDto](docs/CustomColorThemesSettingsRequestsDto.md)
 - [Model.CustomColorThemesSettingsWrapper](docs/CustomColorThemesSettingsWrapper.md)
 - [Model.CustomFilterParameters](docs/CustomFilterParameters.md)
 - [Model.CustomNavigationItem](docs/CustomNavigationItem.md)
 - [Model.CustomNavigationItemArrayWrapper](docs/CustomNavigationItemArrayWrapper.md)
 - [Model.CustomNavigationItemWrapper](docs/CustomNavigationItemWrapper.md)
 - [Model.CustomerConfigDto](docs/CustomerConfigDto.md)
 - [Model.CustomerInfoDto](docs/CustomerInfoDto.md)
 - [Model.CustomerInfoWrapper](docs/CustomerInfoWrapper.md)
 - [Model.CustomerOperationsReportRequestDto](docs/CustomerOperationsReportRequestDto.md)
 - [Model.CustomizationConfigDto](docs/CustomizationConfigDto.md)
 - [Model.DarkThemeSettings](docs/DarkThemeSettings.md)
 - [Model.DarkThemeSettingsRequestDto](docs/DarkThemeSettingsRequestDto.md)
 - [Model.DarkThemeSettingsType](docs/DarkThemeSettingsType.md)
 - [Model.DarkThemeSettingsWrapper](docs/DarkThemeSettingsWrapper.md)
 - [Model.DateToAutoCleanUp](docs/DateToAutoCleanUp.md)
 - [Model.DbTenant](docs/DbTenant.md)
 - [Model.DbTenantPartner](docs/DbTenantPartner.md)
 - [Model.DeepLinkConfigurationRequestsDto](docs/DeepLinkConfigurationRequestsDto.md)
 - [Model.DeepLinkDto](docs/DeepLinkDto.md)
 - [Model.DeepLinkHandlingMode](docs/DeepLinkHandlingMode.md)
 - [Model.Delete](docs/Delete.md)
 - [Model.DeleteBatchRequestDto](docs/DeleteBatchRequestDto.md)
 - [Model.DeleteFolder](docs/DeleteFolder.md)
 - [Model.DeleteRoomRequest](docs/DeleteRoomRequest.md)
 - [Model.DeleteVersionBatchRequestDto](docs/DeleteVersionBatchRequestDto.md)
 - [Model.DisplayRequestDto](docs/DisplayRequestDto.md)
 - [Model.DistributedTaskStatus](docs/DistributedTaskStatus.md)
 - [Model.DnsSettingsRequestsDto](docs/DnsSettingsRequestsDto.md)
 - [Model.DocServiceUrlDto](docs/DocServiceUrlDto.md)
 - [Model.DocServiceUrlWrapper](docs/DocServiceUrlWrapper.md)
 - [Model.DocumentBuilderTaskDto](docs/DocumentBuilderTaskDto.md)
 - [Model.DocumentBuilderTaskWrapper](docs/DocumentBuilderTaskWrapper.md)
 - [Model.DocumentConfigDto](docs/DocumentConfigDto.md)
 - [Model.DoubleWrapper](docs/DoubleWrapper.md)
 - [Model.DownloadRequestDto](docs/DownloadRequestDto.md)
 - [Model.DownloadRequestItemDto](docs/DownloadRequestItemDto.md)
 - [Model.DownloadRequestItemDtoKey](docs/DownloadRequestItemDtoKey.md)
 - [Model.DraftLocationInteger](docs/DraftLocationInteger.md)
 - [Model.DuplicateRequestDto](docs/DuplicateRequestDto.md)
 - [Model.EditHistoryArrayWrapper](docs/EditHistoryArrayWrapper.md)
 - [Model.EditHistoryAuthor](docs/EditHistoryAuthor.md)
 - [Model.EditHistoryChangesWrapper](docs/EditHistoryChangesWrapper.md)
 - [Model.EditHistoryDataDto](docs/EditHistoryDataDto.md)
 - [Model.EditHistoryDataWrapper](docs/EditHistoryDataWrapper.md)
 - [Model.EditHistoryDto](docs/EditHistoryDto.md)
 - [Model.EditHistoryUrl](docs/EditHistoryUrl.md)
 - [Model.EditorConfigurationDto](docs/EditorConfigurationDto.md)
 - [Model.EditorType](docs/EditorType.md)
 - [Model.EmailActivationSettings](docs/EmailActivationSettings.md)
 - [Model.EmailActivationSettingsWrapper](docs/EmailActivationSettingsWrapper.md)
 - [Model.EmailMemberRequestDto](docs/EmailMemberRequestDto.md)
 - [Model.EmailValidationKeyModel](docs/EmailValidationKeyModel.md)
 - [Model.EmbeddedConfig](docs/EmbeddedConfig.md)
 - [Model.EmployeeActivationStatus](docs/EmployeeActivationStatus.md)
 - [Model.EmployeeArrayWrapper](docs/EmployeeArrayWrapper.md)
 - [Model.EmployeeDto](docs/EmployeeDto.md)
 - [Model.EmployeeFullArrayWrapper](docs/EmployeeFullArrayWrapper.md)
 - [Model.EmployeeFullDto](docs/EmployeeFullDto.md)
 - [Model.EmployeeFullWrapper](docs/EmployeeFullWrapper.md)
 - [Model.EmployeeStatus](docs/EmployeeStatus.md)
 - [Model.EmployeeType](docs/EmployeeType.md)
 - [Model.EncryprtionStatus](docs/EncryprtionStatus.md)
 - [Model.EncryptionKeysConfig](docs/EncryptionKeysConfig.md)
 - [Model.EncryptionSettings](docs/EncryptionSettings.md)
 - [Model.EncryptionSettingsWrapper](docs/EncryptionSettingsWrapper.md)
 - [Model.EntryType](docs/EntryType.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ExchangeToken200Response](docs/ExchangeToken200Response.md)
 - [Model.ExternalShareDto](docs/ExternalShareDto.md)
 - [Model.ExternalShareRequestParam](docs/ExternalShareRequestParam.md)
 - [Model.ExternalShareWrapper](docs/ExternalShareWrapper.md)
 - [Model.FeatureUsedDto](docs/FeatureUsedDto.md)
 - [Model.FeedbackConfig](docs/FeedbackConfig.md)
 - [Model.FileConflictResolveType](docs/FileConflictResolveType.md)
 - [Model.FileDtoInteger](docs/FileDtoInteger.md)
 - [Model.FileDtoIntegerSecurity](docs/FileDtoIntegerSecurity.md)
 - [Model.FileDtoIntegerViewAccessibility](docs/FileDtoIntegerViewAccessibility.md)
 - [Model.FileEntryArrayWrapper](docs/FileEntryArrayWrapper.md)
 - [Model.FileEntryDto](docs/FileEntryDto.md)
 - [Model.FileEntryType](docs/FileEntryType.md)
 - [Model.FileEntryWrapper](docs/FileEntryWrapper.md)
 - [Model.FileIntegerArrayWrapper](docs/FileIntegerArrayWrapper.md)
 - [Model.FileIntegerWrapper](docs/FileIntegerWrapper.md)
 - [Model.FileLink](docs/FileLink.md)
 - [Model.FileLinkRequest](docs/FileLinkRequest.md)
 - [Model.FileLinkWrapper](docs/FileLinkWrapper.md)
 - [Model.FileOperationArrayWrapper](docs/FileOperationArrayWrapper.md)
 - [Model.FileOperationDto](docs/FileOperationDto.md)
 - [Model.FileOperationType](docs/FileOperationType.md)
 - [Model.FileOperationWrapper](docs/FileOperationWrapper.md)
 - [Model.FileReference](docs/FileReference.md)
 - [Model.FileReferenceData](docs/FileReferenceData.md)
 - [Model.FileReferenceWrapper](docs/FileReferenceWrapper.md)
 - [Model.FileShare](docs/FileShare.md)
 - [Model.FileShareArrayWrapper](docs/FileShareArrayWrapper.md)
 - [Model.FileShareDto](docs/FileShareDto.md)
 - [Model.FileShareParams](docs/FileShareParams.md)
 - [Model.FileShareWrapper](docs/FileShareWrapper.md)
 - [Model.FileStatus](docs/FileStatus.md)
 - [Model.FileType](docs/FileType.md)
 - [Model.FileUploadResultDto](docs/FileUploadResultDto.md)
 - [Model.FileUploadResultWrapper](docs/FileUploadResultWrapper.md)
 - [Model.FilesSettingsDto](docs/FilesSettingsDto.md)
 - [Model.FilesSettingsDtoInternalFormats](docs/FilesSettingsDtoInternalFormats.md)
 - [Model.FilesSettingsWrapper](docs/FilesSettingsWrapper.md)
 - [Model.FilesStatisticsFolder](docs/FilesStatisticsFolder.md)
 - [Model.FilesStatisticsResultDto](docs/FilesStatisticsResultDto.md)
 - [Model.FilesStatisticsResultWrapper](docs/FilesStatisticsResultWrapper.md)
 - [Model.FillingFormResultDtoInteger](docs/FillingFormResultDtoInteger.md)
 - [Model.FillingFormResultIntegerWrapper](docs/FillingFormResultIntegerWrapper.md)
 - [Model.FilterType](docs/FilterType.md)
 - [Model.FinishDto](docs/FinishDto.md)
 - [Model.FireBaseUser](docs/FireBaseUser.md)
 - [Model.FireBaseUserWrapper](docs/FireBaseUserWrapper.md)
 - [Model.FirebaseDto](docs/FirebaseDto.md)
 - [Model.FirebaseRequestsDto](docs/FirebaseRequestsDto.md)
 - [Model.FolderContentDtoInteger](docs/FolderContentDtoInteger.md)
 - [Model.FolderContentIntegerArrayWrapper](docs/FolderContentIntegerArrayWrapper.md)
 - [Model.FolderContentIntegerWrapper](docs/FolderContentIntegerWrapper.md)
 - [Model.FolderDtoInteger](docs/FolderDtoInteger.md)
 - [Model.FolderDtoString](docs/FolderDtoString.md)
 - [Model.FolderIntegerArrayWrapper](docs/FolderIntegerArrayWrapper.md)
 - [Model.FolderIntegerWrapper](docs/FolderIntegerWrapper.md)
 - [Model.FolderStringArrayWrapper](docs/FolderStringArrayWrapper.md)
 - [Model.FolderStringWrapper](docs/FolderStringWrapper.md)
 - [Model.FolderType](docs/FolderType.md)
 - [Model.FormFillingManageAction](docs/FormFillingManageAction.md)
 - [Model.FormFillingStatus](docs/FormFillingStatus.md)
 - [Model.FormGalleryDto](docs/FormGalleryDto.md)
 - [Model.FormRole](docs/FormRole.md)
 - [Model.FormRoleArrayWrapper](docs/FormRoleArrayWrapper.md)
 - [Model.FormRoleWrapper](docs/FormRoleWrapper.md)
 - [Model.FormsItemArrayWrapper](docs/FormsItemArrayWrapper.md)
 - [Model.FormsItemDto](docs/FormsItemDto.md)
 - [Model.GetReferenceDataDtoInteger](docs/GetReferenceDataDtoInteger.md)
 - [Model.GobackConfig](docs/GobackConfig.md)
 - [Model.GreetingSettingsRequestsDto](docs/GreetingSettingsRequestsDto.md)
 - [Model.GroupArrayWrapper](docs/GroupArrayWrapper.md)
 - [Model.GroupDto](docs/GroupDto.md)
 - [Model.GroupRequestDto](docs/GroupRequestDto.md)
 - [Model.GroupSummaryArrayWrapper](docs/GroupSummaryArrayWrapper.md)
 - [Model.GroupSummaryDto](docs/GroupSummaryDto.md)
 - [Model.GroupWrapper](docs/GroupWrapper.md)
 - [Model.HideConfirmConvertRequestDto](docs/HideConfirmConvertRequestDto.md)
 - [Model.HistoryAction](docs/HistoryAction.md)
 - [Model.HistoryArrayWrapper](docs/HistoryArrayWrapper.md)
 - [Model.HistoryData](docs/HistoryData.md)
 - [Model.HistoryDto](docs/HistoryDto.md)
 - [Model.ICompressWrapper](docs/ICompressWrapper.md)
 - [Model.IMagickGeometry](docs/IMagickGeometry.md)
 - [Model.IPRestriction](docs/IPRestriction.md)
 - [Model.IPRestrictionArrayWrapper](docs/IPRestrictionArrayWrapper.md)
 - [Model.IPRestrictionsSettings](docs/IPRestrictionsSettings.md)
 - [Model.IPRestrictionsSettingsWrapper](docs/IPRestrictionsSettingsWrapper.md)
 - [Model.InfoConfigDto](docs/InfoConfigDto.md)
 - [Model.Int64Wrapper](docs/Int64Wrapper.md)
 - [Model.InviteUsersRequestDto](docs/InviteUsersRequestDto.md)
 - [Model.IpRestrictionBase](docs/IpRestrictionBase.md)
 - [Model.IpRestrictionsDto](docs/IpRestrictionsDto.md)
 - [Model.IpRestrictionsWrapper](docs/IpRestrictionsWrapper.md)
 - [Model.IsDefaultWhiteLabelLogosArrayWrapper](docs/IsDefaultWhiteLabelLogosArrayWrapper.md)
 - [Model.IsDefaultWhiteLabelLogosDto](docs/IsDefaultWhiteLabelLogosDto.md)
 - [Model.IsDefaultWhiteLabelLogosWrapper](docs/IsDefaultWhiteLabelLogosWrapper.md)
 - [Model.ItemKeyValuePairObjectObject](docs/ItemKeyValuePairObjectObject.md)
 - [Model.ItemKeyValuePairStringBoolean](docs/ItemKeyValuePairStringBoolean.md)
 - [Model.ItemKeyValuePairStringLogoRequestsDto](docs/ItemKeyValuePairStringLogoRequestsDto.md)
 - [Model.ItemKeyValuePairStringString](docs/ItemKeyValuePairStringString.md)
 - [Model.KeyValuePairBooleanString](docs/KeyValuePairBooleanString.md)
 - [Model.KeyValuePairBooleanStringWrapper](docs/KeyValuePairBooleanStringWrapper.md)
 - [Model.KeyValuePairStringStringValues](docs/KeyValuePairStringStringValues.md)
 - [Model.LinkAccountRequestDto](docs/LinkAccountRequestDto.md)
 - [Model.LinkType](docs/LinkType.md)
 - [Model.LockFileParameters](docs/LockFileParameters.md)
 - [Model.LoginEventArrayWrapper](docs/LoginEventArrayWrapper.md)
 - [Model.LoginEventDto](docs/LoginEventDto.md)
 - [Model.LoginProvider](docs/LoginProvider.md)
 - [Model.LoginSettingsDto](docs/LoginSettingsDto.md)
 - [Model.LoginSettingsRequestDto](docs/LoginSettingsRequestDto.md)
 - [Model.LoginSettingsWrapper](docs/LoginSettingsWrapper.md)
 - [Model.Logo](docs/Logo.md)
 - [Model.LogoConfigDto](docs/LogoConfigDto.md)
 - [Model.LogoCover](docs/LogoCover.md)
 - [Model.LogoRequest](docs/LogoRequest.md)
 - [Model.LogoRequestsDto](docs/LogoRequestsDto.md)
 - [Model.MailDomainSettingsRequestsDto](docs/MailDomainSettingsRequestsDto.md)
 - [Model.ManageFormFillingDtoInteger](docs/ManageFormFillingDtoInteger.md)
 - [Model.MemberBaseRequestDto](docs/MemberBaseRequestDto.md)
 - [Model.MemberRequestDto](docs/MemberRequestDto.md)
 - [Model.MembersRequest](docs/MembersRequest.md)
 - [Model.MentionMessageWrapper](docs/MentionMessageWrapper.md)
 - [Model.MentionWrapper](docs/MentionWrapper.md)
 - [Model.MentionWrapperArrayWrapper](docs/MentionWrapperArrayWrapper.md)
 - [Model.MessageAction](docs/MessageAction.md)
 - [Model.MigratingApiFiles](docs/MigratingApiFiles.md)
 - [Model.MigratingApiGroup](docs/MigratingApiGroup.md)
 - [Model.MigratingApiUser](docs/MigratingApiUser.md)
 - [Model.MigrationApiInfo](docs/MigrationApiInfo.md)
 - [Model.MigrationStatusDto](docs/MigrationStatusDto.md)
 - [Model.MigrationStatusWrapper](docs/MigrationStatusWrapper.md)
 - [Model.MobilePhoneActivationStatus](docs/MobilePhoneActivationStatus.md)
 - [Model.MobileRequestsDto](docs/MobileRequestsDto.md)
 - [Model.Module](docs/Module.md)
 - [Model.ModuleType](docs/ModuleType.md)
 - [Model.ModuleWrapper](docs/ModuleWrapper.md)
 - [Model.NewItemsDtoFileEntryDto](docs/NewItemsDtoFileEntryDto.md)
 - [Model.NewItemsDtoRoomNewItemsDto](docs/NewItemsDtoRoomNewItemsDto.md)
 - [Model.NewItemsFileEntryArrayWrapper](docs/NewItemsFileEntryArrayWrapper.md)
 - [Model.NewItemsRoomNewItemsArrayWrapper](docs/NewItemsRoomNewItemsArrayWrapper.md)
 - [Model.NoContentResult](docs/NoContentResult.md)
 - [Model.NoContentResultWrapper](docs/NoContentResultWrapper.md)
 - [Model.NotificationSettingsDto](docs/NotificationSettingsDto.md)
 - [Model.NotificationSettingsRequestsDto](docs/NotificationSettingsRequestsDto.md)
 - [Model.NotificationSettingsWrapper](docs/NotificationSettingsWrapper.md)
 - [Model.NotificationType](docs/NotificationType.md)
 - [Model.OAuth20Token](docs/OAuth20Token.md)
 - [Model.ObjectArrayWrapper](docs/ObjectArrayWrapper.md)
 - [Model.ObjectWrapper](docs/ObjectWrapper.md)
 - [Model.OperationDto](docs/OperationDto.md)
 - [Model.Options](docs/Options.md)
 - [Model.OrderBy](docs/OrderBy.md)
 - [Model.OrderRequestDto](docs/OrderRequestDto.md)
 - [Model.OrdersItemRequestDtoInteger](docs/OrdersItemRequestDtoInteger.md)
 - [Model.OrdersRequestDtoInteger](docs/OrdersRequestDtoInteger.md)
 - [Model.OwnerChangeInstructionsDto](docs/OwnerChangeInstructionsDto.md)
 - [Model.OwnerChangeInstructionsWrapper](docs/OwnerChangeInstructionsWrapper.md)
 - [Model.OwnerIdSettingsRequestDto](docs/OwnerIdSettingsRequestDto.md)
 - [Model.PageableModificationResponse](docs/PageableModificationResponse.md)
 - [Model.PageableResponse](docs/PageableResponse.md)
 - [Model.PageableResponseClientInfoResponse](docs/PageableResponseClientInfoResponse.md)
 - [Model.Paragraph](docs/Paragraph.md)
 - [Model.PasswordHasher](docs/PasswordHasher.md)
 - [Model.PasswordSettingsDto](docs/PasswordSettingsDto.md)
 - [Model.PasswordSettingsRequestsDto](docs/PasswordSettingsRequestsDto.md)
 - [Model.PasswordSettingsWrapper](docs/PasswordSettingsWrapper.md)
 - [Model.PaymentCalculation](docs/PaymentCalculation.md)
 - [Model.PaymentCalculationWrapper](docs/PaymentCalculationWrapper.md)
 - [Model.PaymentMethodStatus](docs/PaymentMethodStatus.md)
 - [Model.PaymentSettingsDto](docs/PaymentSettingsDto.md)
 - [Model.PaymentSettingsWrapper](docs/PaymentSettingsWrapper.md)
 - [Model.PaymentUrlRequestsDto](docs/PaymentUrlRequestsDto.md)
 - [Model.Payments](docs/Payments.md)
 - [Model.PermissionsConfig](docs/PermissionsConfig.md)
 - [Model.PluginsConfig](docs/PluginsConfig.md)
 - [Model.PluginsDto](docs/PluginsDto.md)
 - [Model.PriceDto](docs/PriceDto.md)
 - [Model.ProductAdministratorDto](docs/ProductAdministratorDto.md)
 - [Model.ProductAdministratorWrapper](docs/ProductAdministratorWrapper.md)
 - [Model.ProductQuantityType](docs/ProductQuantityType.md)
 - [Model.ProductType](docs/ProductType.md)
 - [Model.ProviderArrayWrapper](docs/ProviderArrayWrapper.md)
 - [Model.ProviderDto](docs/ProviderDto.md)
 - [Model.ProviderFilter](docs/ProviderFilter.md)
 - [Model.QuantityRequestDto](docs/QuantityRequestDto.md)
 - [Model.Quota](docs/Quota.md)
 - [Model.QuotaArrayWrapper](docs/QuotaArrayWrapper.md)
 - [Model.QuotaDto](docs/QuotaDto.md)
 - [Model.QuotaFilter](docs/QuotaFilter.md)
 - [Model.QuotaSettingsRequestsDto](docs/QuotaSettingsRequestsDto.md)
 - [Model.QuotaSettingsRequestsDtoDefaultQuota](docs/QuotaSettingsRequestsDtoDefaultQuota.md)
 - [Model.QuotaState](docs/QuotaState.md)
 - [Model.QuotaWrapper](docs/QuotaWrapper.md)
 - [Model.RecaptchaType](docs/RecaptchaType.md)
 - [Model.RecentConfig](docs/RecentConfig.md)
 - [Model.ReportDto](docs/ReportDto.md)
 - [Model.ReportWrapper](docs/ReportWrapper.md)
 - [Model.ReviewConfig](docs/ReviewConfig.md)
 - [Model.RoomDataLifetimeDto](docs/RoomDataLifetimeDto.md)
 - [Model.RoomDataLifetimePeriod](docs/RoomDataLifetimePeriod.md)
 - [Model.RoomFromTemplateStatusDto](docs/RoomFromTemplateStatusDto.md)
 - [Model.RoomFromTemplateStatusWrapper](docs/RoomFromTemplateStatusWrapper.md)
 - [Model.RoomInvitation](docs/RoomInvitation.md)
 - [Model.RoomInvitationRequest](docs/RoomInvitationRequest.md)
 - [Model.RoomLinkRequest](docs/RoomLinkRequest.md)
 - [Model.RoomNewItemsDto](docs/RoomNewItemsDto.md)
 - [Model.RoomSecurityDto](docs/RoomSecurityDto.md)
 - [Model.RoomSecurityError](docs/RoomSecurityError.md)
 - [Model.RoomSecurityWrapper](docs/RoomSecurityWrapper.md)
 - [Model.RoomTemplateDto](docs/RoomTemplateDto.md)
 - [Model.RoomTemplateStatusDto](docs/RoomTemplateStatusDto.md)
 - [Model.RoomTemplateStatusWrapper](docs/RoomTemplateStatusWrapper.md)
 - [Model.RoomType](docs/RoomType.md)
 - [Model.RoomsNotificationSettingsDto](docs/RoomsNotificationSettingsDto.md)
 - [Model.RoomsNotificationSettingsWrapper](docs/RoomsNotificationSettingsWrapper.md)
 - [Model.RoomsNotificationsSettingsRequestDto](docs/RoomsNotificationsSettingsRequestDto.md)
 - [Model.Run](docs/Run.md)
 - [Model.STRINGArrayWrapper](docs/STRINGArrayWrapper.md)
 - [Model.SalesRequestsDto](docs/SalesRequestsDto.md)
 - [Model.SaveAsPdfInteger](docs/SaveAsPdfInteger.md)
 - [Model.SaveFormRoleMappingDtoInteger](docs/SaveFormRoleMappingDtoInteger.md)
 - [Model.Schedule](docs/Schedule.md)
 - [Model.ScheduleWrapper](docs/ScheduleWrapper.md)
 - [Model.ScopeResponse](docs/ScopeResponse.md)
 - [Model.SearchArea](docs/SearchArea.md)
 - [Model.SecurityArrayWrapper](docs/SecurityArrayWrapper.md)
 - [Model.SecurityDto](docs/SecurityDto.md)
 - [Model.SecurityRequestsDto](docs/SecurityRequestsDto.md)
 - [Model.SessionRequest](docs/SessionRequest.md)
 - [Model.SetManagerRequest](docs/SetManagerRequest.md)
 - [Model.SetPublicDto](docs/SetPublicDto.md)
 - [Model.SettingsDto](docs/SettingsDto.md)
 - [Model.SettingsRequestDto](docs/SettingsRequestDto.md)
 - [Model.SettingsWrapper](docs/SettingsWrapper.md)
 - [Model.SetupCode](docs/SetupCode.md)
 - [Model.SetupCodeWrapper](docs/SetupCodeWrapper.md)
 - [Model.SexEnum](docs/SexEnum.md)
 - [Model.ShareFilterType](docs/ShareFilterType.md)
 - [Model.SignupAccountRequestDto](docs/SignupAccountRequestDto.md)
 - [Model.SmtpOperationStatusRequestsDto](docs/SmtpOperationStatusRequestsDto.md)
 - [Model.SmtpOperationStatusRequestsWrapper](docs/SmtpOperationStatusRequestsWrapper.md)
 - [Model.SmtpSettingsDto](docs/SmtpSettingsDto.md)
 - [Model.SmtpSettingsWrapper](docs/SmtpSettingsWrapper.md)
 - [Model.SortOrder](docs/SortOrder.md)
 - [Model.SortedByType](docs/SortedByType.md)
 - [Model.SsoCertificate](docs/SsoCertificate.md)
 - [Model.SsoFieldMapping](docs/SsoFieldMapping.md)
 - [Model.SsoIdpCertificateAdvanced](docs/SsoIdpCertificateAdvanced.md)
 - [Model.SsoIdpSettings](docs/SsoIdpSettings.md)
 - [Model.SsoSettingsRequestsDto](docs/SsoSettingsRequestsDto.md)
 - [Model.SsoSettingsV2](docs/SsoSettingsV2.md)
 - [Model.SsoSettingsV2Wrapper](docs/SsoSettingsV2Wrapper.md)
 - [Model.SsoSpCertificateAdvanced](docs/SsoSpCertificateAdvanced.md)
 - [Model.StartEdit](docs/StartEdit.md)
 - [Model.StartFillingForm](docs/StartFillingForm.md)
 - [Model.StartFillingMode](docs/StartFillingMode.md)
 - [Model.StartReassignRequestDto](docs/StartReassignRequestDto.md)
 - [Model.StartUpdateUserTypeDto](docs/StartUpdateUserTypeDto.md)
 - [Model.Status](docs/Status.md)
 - [Model.StorageArrayWrapper](docs/StorageArrayWrapper.md)
 - [Model.StorageDto](docs/StorageDto.md)
 - [Model.StorageEncryptionRequestsDto](docs/StorageEncryptionRequestsDto.md)
 - [Model.StorageFilter](docs/StorageFilter.md)
 - [Model.StorageRequestsDto](docs/StorageRequestsDto.md)
 - [Model.StorageSettings](docs/StorageSettings.md)
 - [Model.StorageSettingsWrapper](docs/StorageSettingsWrapper.md)
 - [Model.StringWrapper](docs/StringWrapper.md)
 - [Model.SubAccount](docs/SubAccount.md)
 - [Model.SubjectFilter](docs/SubjectFilter.md)
 - [Model.SubjectType](docs/SubjectType.md)
 - [Model.SubmitForm](docs/SubmitForm.md)
 - [Model.Tariff](docs/Tariff.md)
 - [Model.TariffState](docs/TariffState.md)
 - [Model.TariffWrapper](docs/TariffWrapper.md)
 - [Model.TaskProgressResponseDto](docs/TaskProgressResponseDto.md)
 - [Model.TaskProgressResponseWrapper](docs/TaskProgressResponseWrapper.md)
 - [Model.TemplatesConfig](docs/TemplatesConfig.md)
 - [Model.TemplatesRequestDto](docs/TemplatesRequestDto.md)
 - [Model.TenantAuditSettings](docs/TenantAuditSettings.md)
 - [Model.TenantAuditSettingsWrapper](docs/TenantAuditSettingsWrapper.md)
 - [Model.TenantBannerSettings](docs/TenantBannerSettings.md)
 - [Model.TenantBannerSettingsDto](docs/TenantBannerSettingsDto.md)
 - [Model.TenantBannerSettingsWrapper](docs/TenantBannerSettingsWrapper.md)
 - [Model.TenantDeepLinkSettings](docs/TenantDeepLinkSettings.md)
 - [Model.TenantDeepLinkSettingsWrapper](docs/TenantDeepLinkSettingsWrapper.md)
 - [Model.TenantDevToolsAccessSettings](docs/TenantDevToolsAccessSettings.md)
 - [Model.TenantDevToolsAccessSettingsDto](docs/TenantDevToolsAccessSettingsDto.md)
 - [Model.TenantDevToolsAccessSettingsWrapper](docs/TenantDevToolsAccessSettingsWrapper.md)
 - [Model.TenantDomainValidator](docs/TenantDomainValidator.md)
 - [Model.TenantDto](docs/TenantDto.md)
 - [Model.TenantEntityQuotaSettings](docs/TenantEntityQuotaSettings.md)
 - [Model.TenantIndustry](docs/TenantIndustry.md)
 - [Model.TenantQuota](docs/TenantQuota.md)
 - [Model.TenantQuotaFeatureDto](docs/TenantQuotaFeatureDto.md)
 - [Model.TenantQuotaSettings](docs/TenantQuotaSettings.md)
 - [Model.TenantQuotaSettingsRequestsDto](docs/TenantQuotaSettingsRequestsDto.md)
 - [Model.TenantQuotaSettingsWrapper](docs/TenantQuotaSettingsWrapper.md)
 - [Model.TenantQuotaWrapper](docs/TenantQuotaWrapper.md)
 - [Model.TenantRoomQuotaSettings](docs/TenantRoomQuotaSettings.md)
 - [Model.TenantRoomQuotaSettingsWrapper](docs/TenantRoomQuotaSettingsWrapper.md)
 - [Model.TenantStatus](docs/TenantStatus.md)
 - [Model.TenantTrustedDomainsType](docs/TenantTrustedDomainsType.md)
 - [Model.TenantUserInvitationSettingsDto](docs/TenantUserInvitationSettingsDto.md)
 - [Model.TenantUserInvitationSettingsRequestDto](docs/TenantUserInvitationSettingsRequestDto.md)
 - [Model.TenantUserInvitationSettingsWrapper](docs/TenantUserInvitationSettingsWrapper.md)
 - [Model.TenantUserQuotaSettings](docs/TenantUserQuotaSettings.md)
 - [Model.TenantUserQuotaSettingsWrapper](docs/TenantUserQuotaSettingsWrapper.md)
 - [Model.TenantWalletSettings](docs/TenantWalletSettings.md)
 - [Model.TenantWalletSettingsWrapper](docs/TenantWalletSettingsWrapper.md)
 - [Model.TenantWrapper](docs/TenantWrapper.md)
 - [Model.TerminateRequestDto](docs/TerminateRequestDto.md)
 - [Model.TfaRequestsDto](docs/TfaRequestsDto.md)
 - [Model.TfaRequestsDtoType](docs/TfaRequestsDtoType.md)
 - [Model.TfaSettingsArrayWrapper](docs/TfaSettingsArrayWrapper.md)
 - [Model.TfaSettingsDto](docs/TfaSettingsDto.md)
 - [Model.TfaValidateRequestsDto](docs/TfaValidateRequestsDto.md)
 - [Model.ThirdPartyBackupRequestDto](docs/ThirdPartyBackupRequestDto.md)
 - [Model.ThirdPartyParams](docs/ThirdPartyParams.md)
 - [Model.ThirdPartyParamsArrayWrapper](docs/ThirdPartyParamsArrayWrapper.md)
 - [Model.ThirdPartyRequestDto](docs/ThirdPartyRequestDto.md)
 - [Model.Thumbnail](docs/Thumbnail.md)
 - [Model.ThumbnailsDataDto](docs/ThumbnailsDataDto.md)
 - [Model.ThumbnailsDataWrapper](docs/ThumbnailsDataWrapper.md)
 - [Model.ThumbnailsRequest](docs/ThumbnailsRequest.md)
 - [Model.TimezonesRequestsArrayWrapper](docs/TimezonesRequestsArrayWrapper.md)
 - [Model.TimezonesRequestsDto](docs/TimezonesRequestsDto.md)
 - [Model.TopUpDepositRequestDto](docs/TopUpDepositRequestDto.md)
 - [Model.TurnOnAdminMessageSettingsRequestDto](docs/TurnOnAdminMessageSettingsRequestDto.md)
 - [Model.UnknownWrapper](docs/UnknownWrapper.md)
 - [Model.UpdateApiKeyRequest](docs/UpdateApiKeyRequest.md)
 - [Model.UpdateClientRequest](docs/UpdateClientRequest.md)
 - [Model.UpdateComment](docs/UpdateComment.md)
 - [Model.UpdateFile](docs/UpdateFile.md)
 - [Model.UpdateGroupRequest](docs/UpdateGroupRequest.md)
 - [Model.UpdateMemberRequestDto](docs/UpdateMemberRequestDto.md)
 - [Model.UpdateMembersQuotaRequestDto](docs/UpdateMembersQuotaRequestDto.md)
 - [Model.UpdateMembersQuotaRequestDtoQuota](docs/UpdateMembersQuotaRequestDtoQuota.md)
 - [Model.UpdateMembersRequestDto](docs/UpdateMembersRequestDto.md)
 - [Model.UpdatePhotoMemberRequest](docs/UpdatePhotoMemberRequest.md)
 - [Model.UpdateRoomRequest](docs/UpdateRoomRequest.md)
 - [Model.UpdateRoomsQuotaRequestDtoInteger](docs/UpdateRoomsQuotaRequestDtoInteger.md)
 - [Model.UpdateRoomsRoomIdsRequestDtoInteger](docs/UpdateRoomsRoomIdsRequestDtoInteger.md)
 - [Model.UpdateWebhooksConfigRequestsDto](docs/UpdateWebhooksConfigRequestsDto.md)
 - [Model.UploadRequestDto](docs/UploadRequestDto.md)
 - [Model.UploadResultDto](docs/UploadResultDto.md)
 - [Model.UploadResultWrapper](docs/UploadResultWrapper.md)
 - [Model.UsageSpaceStatItemArrayWrapper](docs/UsageSpaceStatItemArrayWrapper.md)
 - [Model.UsageSpaceStatItemDto](docs/UsageSpaceStatItemDto.md)
 - [Model.UserConfig](docs/UserConfig.md)
 - [Model.UserInfo](docs/UserInfo.md)
 - [Model.UserInfoWrapper](docs/UserInfoWrapper.md)
 - [Model.UserInvitation](docs/UserInvitation.md)
 - [Model.UserInvitationRequestDto](docs/UserInvitationRequestDto.md)
 - [Model.ValidationResult](docs/ValidationResult.md)
 - [Model.WalletQuantityRequestDto](docs/WalletQuantityRequestDto.md)
 - [Model.WatermarkAdditions](docs/WatermarkAdditions.md)
 - [Model.WatermarkDto](docs/WatermarkDto.md)
 - [Model.WatermarkOnDraw](docs/WatermarkOnDraw.md)
 - [Model.WatermarkRequestDto](docs/WatermarkRequestDto.md)
 - [Model.WebItemSecurityRequestsDto](docs/WebItemSecurityRequestsDto.md)
 - [Model.WebItemsSecurityRequestsDto](docs/WebItemsSecurityRequestsDto.md)
 - [Model.WebPluginArrayWrapper](docs/WebPluginArrayWrapper.md)
 - [Model.WebPluginDto](docs/WebPluginDto.md)
 - [Model.WebPluginRequests](docs/WebPluginRequests.md)
 - [Model.WebPluginWrapper](docs/WebPluginWrapper.md)
 - [Model.WebhookGroupStatus](docs/WebhookGroupStatus.md)
 - [Model.WebhookRetryRequestsDto](docs/WebhookRetryRequestsDto.md)
 - [Model.WebhookTrigger](docs/WebhookTrigger.md)
 - [Model.WebhooksConfigDto](docs/WebhooksConfigDto.md)
 - [Model.WebhooksConfigWithStatusArrayWrapper](docs/WebhooksConfigWithStatusArrayWrapper.md)
 - [Model.WebhooksConfigWithStatusDto](docs/WebhooksConfigWithStatusDto.md)
 - [Model.WebhooksConfigWrapper](docs/WebhooksConfigWrapper.md)
 - [Model.WebhooksLogArrayWrapper](docs/WebhooksLogArrayWrapper.md)
 - [Model.WebhooksLogDto](docs/WebhooksLogDto.md)
 - [Model.WebhooksLogWrapper](docs/WebhooksLogWrapper.md)
 - [Model.WhiteLabelItemArrayWrapper](docs/WhiteLabelItemArrayWrapper.md)
 - [Model.WhiteLabelItemDto](docs/WhiteLabelItemDto.md)
 - [Model.WhiteLabelItemPathDto](docs/WhiteLabelItemPathDto.md)
 - [Model.WhiteLabelRequestsDto](docs/WhiteLabelRequestsDto.md)
 - [Model.WizardRequestsDto](docs/WizardRequestsDto.md)
 - [Model.WizardSettings](docs/WizardSettings.md)
 - [Model.WizardSettingsWrapper](docs/WizardSettingsWrapper.md)

</details>
