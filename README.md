# DocSpace.API.SDK

The ONLYOFFICE DocSpace SDK for C# is a library that provides tools for integrating and managing DocSpace features within your applications. It simplifies interaction with the DocSpace API by offering ready-to-use methods and models.

For more information, please visit [https://helpdesk.onlyoffice.com/hc/en-us](https://helpdesk.onlyoffice.com/hc/en-us)

<a id="installation"></a>
## Installation

To get started, install the package from NuGet

```
dotnet add package DocSpace.API.SDK
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
var api = new RoomsApi(yourHttpClient, yourHandler);
```

If you want to use an HttpClient but do not have access to its handler (for example, when using IHttpClientFactory in the ASP.NET Core DI context), you can create and configure your HttpClient instance separately and then pass it to the API class constructor:

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new RoomsApi(yourHttpClient);
```
If you want to use an HttpClient but do not have access to its handler (for example, when using IHttpClientFactory in the ASP.NET Core DI context), you can create and configure your HttpClient instance separately and then pass it to the API class constructor:

Here is an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<RoomsApi>(httpClient =>
   new RoomsApi(httpClient));
```


<a id="getting-started"></a>
## Getting Started

```csharp

Configuration config = new Configuration();
config.BasePath = "https://your-docspace.onlyoffice.com";
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


<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://your-docspace.onlyoffice.com*

### API Endoints tables:

<details>
  <summary>ApiKeys</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>ApiKeysApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/ApiKeysApi.md#createapikey"><strong>CreateApiKey</strong></a></td>
        <td><strong>POST</strong> /api/2.0/keys</td>
        <td>Create a user API key</td>
      </tr>
      <tr>
        <td><a href="docs/ApiKeysApi.md#deleteapikey"><strong>DeleteApiKey</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/keys/{keyId}</td>
        <td>Delete a user API key</td>
      </tr>
      <tr>
        <td><a href="docs/ApiKeysApi.md#getallpermissions"><strong>GetAllPermissions</strong></a></td>
        <td><strong>GET</strong> /api/2.0/keys/permissions</td>
        <td>Get API key permissions</td>
      </tr>
      <tr>
        <td><a href="docs/ApiKeysApi.md#getapikey"><strong>GetApiKey</strong></a></td>
        <td><strong>GET</strong> /api/2.0/keys/@self</td>
        <td>Get current user&#39;s API key</td>
      </tr>
      <tr>
        <td><a href="docs/ApiKeysApi.md#getapikeys"><strong>GetApiKeys</strong></a></td>
        <td><strong>GET</strong> /api/2.0/keys</td>
        <td>Get current user&#39;s API keys</td>
      </tr>
      <tr>
        <td><a href="docs/ApiKeysApi.md#updateapikey"><strong>UpdateApiKey</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/keys/{keyId}</td>
        <td>Update an API key</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Authentication</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>AuthenticationApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#authenticateme"><strong>AuthenticateMe</strong></a></td>
        <td><strong>POST</strong> /api/2.0/authentication</td>
        <td>Authenticate a user</td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#authenticatemefrombodywithcode"><strong>AuthenticateMeFromBodyWithCode</strong></a></td>
        <td><strong>POST</strong> /api/2.0/authentication/{code}</td>
        <td>Authenticate a user by code</td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#checkconfirm"><strong>CheckConfirm</strong></a></td>
        <td><strong>POST</strong> /api/2.0/authentication/confirm</td>
        <td>Open confirmation email URL</td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#getisauthentificated"><strong>GetIsAuthentificated</strong></a></td>
        <td><strong>GET</strong> /api/2.0/authentication</td>
        <td>Check authentication</td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#logout"><strong>Logout</strong></a></td>
        <td><strong>POST</strong> /api/2.0/authentication/logout</td>
        <td>Log out</td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#savemobilephone"><strong>SaveMobilePhone</strong></a></td>
        <td><strong>POST</strong> /api/2.0/authentication/setphone</td>
        <td>Set a mobile phone</td>
      </tr>
      <tr>
        <td><a href="docs/AuthenticationApi.md#sendsmscode"><strong>SendSmsCode</strong></a></td>
        <td><strong>POST</strong> /api/2.0/authentication/sendsms</td>
        <td>Send SMS code</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Backup</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>BackupApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#createbackupschedule"><strong>CreateBackupSchedule</strong></a></td>
        <td><strong>POST</strong> /api/2.0/backup/createbackupschedule</td>
        <td>Create the backup schedule</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#deletebackup"><strong>DeleteBackup</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/backup/deletebackup/{id}</td>
        <td>Delete the backup</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#deletebackuphistory"><strong>DeleteBackupHistory</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/backup/deletebackuphistory</td>
        <td>Delete the backup history</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#deletebackupschedule"><strong>DeleteBackupSchedule</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/backup/deletebackupschedule</td>
        <td>Delete the backup schedule</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#getbackuphistory"><strong>GetBackupHistory</strong></a></td>
        <td><strong>GET</strong> /api/2.0/backup/getbackuphistory</td>
        <td>Get the backup history</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#getbackupprogress"><strong>GetBackupProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/backup/getbackupprogress</td>
        <td>Get the backup progress</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#getbackupschedule"><strong>GetBackupSchedule</strong></a></td>
        <td><strong>GET</strong> /api/2.0/backup/getbackupschedule</td>
        <td>Get the backup schedule</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#getbackupscount"><strong>GetBackupsCount</strong></a></td>
        <td><strong>GET</strong> /api/2.0/backup/getbackupscount</td>
        <td>Get the number of backups</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#getbackupsservicestate"><strong>GetBackupsServiceState</strong></a></td>
        <td><strong>GET</strong> /api/2.0/backup/getservicestate</td>
        <td>Get the backup service state</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#getrestoreprogress"><strong>GetRestoreProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/backup/getrestoreprogress</td>
        <td>Get the restoring progress</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#startbackup"><strong>StartBackup</strong></a></td>
        <td><strong>POST</strong> /api/2.0/backup/startbackup</td>
        <td>Start the backup</td>
      </tr>
      <tr>
        <td><a href="docs/BackupApi.md#startbackuprestore"><strong>StartBackupRestore</strong></a></td>
        <td><strong>POST</strong> /api/2.0/backup/startrestore</td>
        <td>Start the restoring process</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Capabilities</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>CapabilitiesApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/CapabilitiesApi.md#getportalcapabilities"><strong>GetPortalCapabilities</strong></a></td>
        <td><strong>GET</strong> /api/2.0/capabilities</td>
        <td>Get portal capabilities</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Files</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>FilesApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#addfiletorecent"><strong>AddFileToRecent</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{fileId}/recent</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#addtemplates"><strong>AddTemplates</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/templates</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#changeversionhistory"><strong>ChangeVersionHistory</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/history</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#checkfillformdraft"><strong>CheckFillFormDraft</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/masterform/{fileId}/checkfillformdraft</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#copyfileas"><strong>CopyFileAs</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{fileId}/copyas</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createeditsession"><strong>CreateEditSession</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{fileId}/edit_session</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createfile"><strong>CreateFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/file</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createfileinmydocuments"><strong>CreateFileInMyDocuments</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/@my/file</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createfileprimaryexternallink"><strong>CreateFilePrimaryExternalLink</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{id}/link</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createhtmlfile"><strong>CreateHtmlFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/html</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createhtmlfileinmydocuments"><strong>CreateHtmlFileInMyDocuments</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/@my/html</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createtextfile"><strong>CreateTextFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/text</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createtextfileinmydocuments"><strong>CreateTextFileInMyDocuments</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/@my/text</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#createthumbnails"><strong>CreateThumbnails</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/thumbnails</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#deletefile"><strong>DeleteFile</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/file/{fileId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#deleterecent"><strong>DeleteRecent</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/recent</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#deletetemplates"><strong>DeleteTemplates</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/templates</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getallformroles"><strong>GetAllFormRoles</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/formroles</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#geteditdiffurl"><strong>GetEditDiffUrl</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/edit/diff</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getedithistory"><strong>GetEditHistory</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/edit/history</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getfilehistory"><strong>GetFileHistory</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/log</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getfileinfo"><strong>GetFileInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getfilelinks"><strong>GetFileLinks</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{id}/links</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getfileprimaryexternallink"><strong>GetFilePrimaryExternalLink</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{id}/link</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getfileversioninfo"><strong>GetFileVersionInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/history</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getfillresult"><strong>GetFillResult</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/fillresult</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getpresignedfileuri"><strong>GetPresignedFileUri</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/presigned</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getpresigneduri"><strong>GetPresignedUri</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/presigneduri</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getprotectedfileusers"><strong>GetProtectedFileUsers</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/protectusers</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#getreferencedata"><strong>GetReferenceData</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/referencedata</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#isformpdf"><strong>IsFormPDF</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/isformpdf</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#lockfile"><strong>LockFile</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/lock</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#manageformfilling"><strong>ManageFormFilling</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/manageformfilling</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#openeditfile"><strong>OpenEditFile</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/openedit</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#restorefileversion"><strong>RestoreFileVersion</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/restoreversion</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#saveeditingfilefromform"><strong>SaveEditingFileFromForm</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/saveediting</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#savefileaspdf"><strong>SaveFileAsPdf</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{id}/saveaspdf</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#saveformrolemapping"><strong>SaveFormRoleMapping</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{fileId}/formrolemapping</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#setcustomfiltertag"><strong>SetCustomFilterTag</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/customfilter</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#setfileexternallink"><strong>SetFileExternalLink</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{id}/links</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#setfileorder"><strong>SetFileOrder</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/{fileId}/order</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#setfilesorder"><strong>SetFilesOrder</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/order</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#starteditfile"><strong>StartEditFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{fileId}/startedit</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#startfillingfile"><strong>StartFillingFile</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/startfilling</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#togglefilefavorite"><strong>ToggleFileFavorite</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/favorites/{fileId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#trackeditfile"><strong>TrackEditFile</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/trackeditfile</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFilesApi.md#updatefile"><strong>UpdateFile</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}</td>
        <td></td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>FoldersApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#checkupload"><strong>CheckUpload</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/upload/check</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#createfolder"><strong>CreateFolder</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/folder/{folderId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#createfolderprimaryexternallink"><strong>CreateFolderPrimaryExternalLink</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/folder/{id}/link</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#createreportfolderhistory"><strong>CreateReportFolderHistory</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/folder/{folderId}/log/report</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#deletefolder"><strong>DeleteFolder</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/folder/{folderId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfavoritesfolder"><strong>GetFavoritesFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@favorites</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfilesusedspace"><strong>GetFilesUsedSpace</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/filesusedspace</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolder"><strong>GetFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/{folderId}/formfilter</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderbyfolderid"><strong>GetFolderByFolderId</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/{folderId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderhistory"><strong>GetFolderHistory</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{folderId}/log</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderinfo"><strong>GetFolderInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{folderId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderlinks"><strong>GetFolderLinks</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{id}/links</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderpath"><strong>GetFolderPath</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{folderId}/path</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderprimaryexternallink"><strong>GetFolderPrimaryExternalLink</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{id}/link</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolderrecent"><strong>GetFolderRecent</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/recent</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getfolders"><strong>GetFolders</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/{folderId}/subfolders</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getmyfolder"><strong>GetMyFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@my</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getnewfolderitems"><strong>GetNewFolderItems</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/{folderId}/news</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getprivacyfolder"><strong>GetPrivacyFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@privacy</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getrecentfolder"><strong>GetRecentFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@recent</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#getrootfolders"><strong>GetRootFolders</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@root</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#gettrashfolder"><strong>GetTrashFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@trash</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#insertfile"><strong>InsertFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/insert</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#insertfiletomyfrombody"><strong>InsertFileToMyFromBody</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/@my/insert</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#renamefolder"><strong>RenameFolder</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/folder/{folderId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#setfolderorder"><strong>SetFolderOrder</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/folder/{folderId}/order</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#setfolderprimaryexternallink"><strong>SetFolderPrimaryExternalLink</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/folder/{id}/links</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#uploadfile"><strong>UploadFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/upload</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesFoldersApi.md#uploadfiletomy"><strong>UploadFileToMy</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/@my/upload</td>
        <td></td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>OperationsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#addfavorites"><strong>AddFavorites</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/favorites</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#bulkdownload"><strong>BulkDownload</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/bulkdownload</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#checkconversionstatus"><strong>CheckConversionStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/checkconversion</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#checkmoveorcopybatchitems"><strong>CheckMoveOrCopyBatchItems</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/fileops/move</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#checkmoveorcopydestfolder"><strong>CheckMoveOrCopyDestFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/fileops/checkdestfolder</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#copybatchitems"><strong>CopyBatchItems</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/copy</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#createuploadsession"><strong>CreateUploadSession</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/{folderId}/upload/create_session</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#deletebatchitems"><strong>DeleteBatchItems</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/delete</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#deletefavoritesfrombody"><strong>DeleteFavoritesFromBody</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/favorites</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#deletefileversions"><strong>DeleteFileVersions</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/deleteversion</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#duplicatebatchitems"><strong>DuplicateBatchItems</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/duplicate</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#emptytrash"><strong>EmptyTrash</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/emptytrash</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#getoperationstatuses"><strong>GetOperationStatuses</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/fileops</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#getoperationstatusesbytype"><strong>GetOperationStatusesByType</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/fileops/{operationType}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#markasread"><strong>MarkAsRead</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/markasread</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#movebatchitems"><strong>MoveBatchItems</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/move</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#startfileconversion"><strong>StartFileConversion</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/checkconversion</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#terminatetasks"><strong>TerminateTasks</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/fileops/terminate/{id}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesOperationsApi.md#updatefilecomment"><strong>UpdateFileComment</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/comment</td>
        <td></td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>QuotaApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesQuotaApi.md#resetroomquota"><strong>ResetRoomQuota</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/resetquota</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesQuotaApi.md#updateroomsquota"><strong>UpdateRoomsQuota</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/roomquota</td>
        <td></td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#changeaccesstothirdparty"><strong>ChangeAccessToThirdparty</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/thirdparty</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#changeautomaticallycleanup"><strong>ChangeAutomaticallyCleanUp</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/settings/autocleanup</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#changedefaultaccessrights"><strong>ChangeDefaultAccessRights</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/settings/dafaultaccessrights</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#changedeleteconfirm"><strong>ChangeDeleteConfirm</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/changedeleteconfrim</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#changedownloadzipfrombody"><strong>ChangeDownloadZipFromBody</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/settings/downloadtargz</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#checkdocserviceurl"><strong>CheckDocServiceUrl</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/docservice</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#displayfileextension"><strong>DisplayFileExtension</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/displayfileextension</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#displayrecent"><strong>DisplayRecent</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/displayrecent</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#externalshare"><strong>ExternalShare</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/settings/external</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#externalsharesocialmedia"><strong>ExternalShareSocialMedia</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/settings/externalsocialmedia</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#forcesave"><strong>Forcesave</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/forcesave</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#getautomaticallycleanup"><strong>GetAutomaticallyCleanUp</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/settings/autocleanup</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#getdocserviceurl"><strong>GetDocServiceUrl</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/docservice</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#getfilesmodule"><strong>GetFilesModule</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/info</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#getfilessettings"><strong>GetFilesSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/settings</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#hideconfirmcanceloperation"><strong>HideConfirmCancelOperation</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/hideconfirmcanceloperation</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#hideconfirmconvert"><strong>HideConfirmConvert</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/hideconfirmconvert</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#hideconfirmroomlifetime"><strong>HideConfirmRoomLifetime</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/hideconfirmroomlifetime</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#isavailableprivacyroomsettings"><strong>IsAvailablePrivacyRoomSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/@privacy/available</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#keepnewfilename"><strong>KeepNewFileName</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/keepnewfilename</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#setopeneditorinsametab"><strong>SetOpenEditorInSameTab</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/settings/openeditorinsametab</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#storeforcesave"><strong>StoreForcesave</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/storeforcesave</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#storeoriginal"><strong>StoreOriginal</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/storeoriginal</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSettingsApi.md#updatefileifexist"><strong>UpdateFileIfExist</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/updateifexist</td>
        <td></td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SharingApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#applyexternalsharepassword"><strong>ApplyExternalSharePassword</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/share/{key}/password</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#changefileowner"><strong>ChangeFileOwner</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/owner</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getexternalsharedata"><strong>GetExternalShareData</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/share/{key}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getfilesecurityinfo"><strong>GetFileSecurityInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{id}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getfoldersecurityinfo"><strong>GetFolderSecurityInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{id}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getgroupsmemberswithfilesecurity"><strong>GetGroupsMembersWithFileSecurity</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/group/{groupId}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getgroupsmemberswithfoldersecurity"><strong>GetGroupsMembersWithFolderSecurity</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/folder/{folderId}/group/{groupId}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getsecurityinfo"><strong>GetSecurityInfo</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#getsharedusers"><strong>GetSharedUsers</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/file/{fileId}/sharedusers</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#removesecurityinfo"><strong>RemoveSecurityInfo</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#sendeditornotify"><strong>SendEditorNotify</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/file/{fileId}/sendeditornotify</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#setfilesecurityinfo"><strong>SetFileSecurityInfo</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/file/{fileId}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#setfoldersecurityinfo"><strong>SetFolderSecurityInfo</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/folder/{folderId}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesSharingApi.md#setsecurityinfo"><strong>SetSecurityInfo</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/share</td>
        <td></td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ThirdPartyIntegrationApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#deletethirdparty"><strong>DeleteThirdParty</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/thirdparty/{providerId}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#getallproviders"><strong>GetAllProviders</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/thirdparty/providers</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#getbackupthirdpartyaccount"><strong>GetBackupThirdPartyAccount</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/thirdparty/backup</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#getcapabilities"><strong>GetCapabilities</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/thirdparty/capabilities</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#getcommonthirdpartyfolders"><strong>GetCommonThirdPartyFolders</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/thirdparty/common</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#getthirdpartyaccounts"><strong>GetThirdPartyAccounts</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/thirdparty</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#savethirdparty"><strong>SaveThirdParty</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/thirdparty</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/FilesThirdPartyIntegrationApi.md#savethirdpartybackup"><strong>SaveThirdPartyBackup</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/thirdparty/backup</td>
        <td></td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Group</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>GroupApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#addgroup"><strong>AddGroup</strong></a></td>
        <td><strong>POST</strong> /api/2.0/group</td>
        <td>Add a new group</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#addmembersto"><strong>AddMembersTo</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/group/{id}/members</td>
        <td>Add group members</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#deletegroup"><strong>DeleteGroup</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/group/{id}</td>
        <td>Delete a group</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#getgroup"><strong>GetGroup</strong></a></td>
        <td><strong>GET</strong> /api/2.0/group/{id}</td>
        <td>Get a group</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#getgroupbyuserid"><strong>GetGroupByUserId</strong></a></td>
        <td><strong>GET</strong> /api/2.0/group/user/{userid}</td>
        <td>Get user groups</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#getgroups"><strong>GetGroups</strong></a></td>
        <td><strong>GET</strong> /api/2.0/group</td>
        <td>Get groups</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#movemembersto"><strong>MoveMembersTo</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/group/{fromId}/members/{toId}</td>
        <td>Move group members</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#removemembersfrom"><strong>RemoveMembersFrom</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/group/{id}/members</td>
        <td>Remove group members</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#setgroupmanager"><strong>SetGroupManager</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/group/{id}/manager</td>
        <td>Set a group manager</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#setmembersto"><strong>SetMembersTo</strong></a></td>
        <td><strong>POST</strong> /api/2.0/group/{id}/members</td>
        <td>Replace group members</td>
      </tr>
      <tr>
        <td><a href="docs/GroupApi.md#updategroup"><strong>UpdateGroup</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/group/{id}</td>
        <td>Update a group</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SearchApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/GroupSearchApi.md#getgroupswithfilesshared"><strong>GetGroupsWithFilesShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/group/file/{id}</td>
        <td>Get groups with file sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/GroupSearchApi.md#getgroupswithfoldersshared"><strong>GetGroupsWithFoldersShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/group/folder/{id}</td>
        <td>Get groups with folder sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/GroupSearchApi.md#getgroupswithroomsshared"><strong>GetGroupsWithRoomsShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/group/room/{id}</td>
        <td>Get groups with room sharing settings</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Migration</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>MigrationApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#cancelmigration"><strong>CancelMigration</strong></a></td>
        <td><strong>POST</strong> /api/2.0/migration/cancel</td>
        <td>Cancel migration</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#clearmigration"><strong>ClearMigration</strong></a></td>
        <td><strong>POST</strong> /api/2.0/migration/clear</td>
        <td>Clear migration</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#finishmigration"><strong>FinishMigration</strong></a></td>
        <td><strong>POST</strong> /api/2.0/migration/finish</td>
        <td>Finish migration</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#getmigrationlogs"><strong>GetMigrationLogs</strong></a></td>
        <td><strong>GET</strong> /api/2.0/migration/logs</td>
        <td>Get migration logs</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#getmigrationstatus"><strong>GetMigrationStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/migration/status</td>
        <td>Get migration status</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#listmigrations"><strong>ListMigrations</strong></a></td>
        <td><strong>GET</strong> /api/2.0/migration/list</td>
        <td>Get migrations</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#startmigration"><strong>StartMigration</strong></a></td>
        <td><strong>POST</strong> /api/2.0/migration/migrate</td>
        <td>Start migration</td>
      </tr>
      <tr>
        <td><a href="docs/MigrationApi.md#uploadandinitializemigration"><strong>UploadAndInitializeMigration</strong></a></td>
        <td><strong>POST</strong> /api/2.0/migration/init/{migratorName}</td>
        <td>Upload and initialize migration</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>OAuth20</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>AuthorizationApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20AuthorizationApi.md#authorizeoauth"><strong>AuthorizeOAuth</strong></a></td>
        <td><strong>GET</strong> /oauth2/authorize</td>
        <td>OAuth2 authorization endpoint</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20AuthorizationApi.md#exchangetoken"><strong>ExchangeToken</strong></a></td>
        <td><strong>POST</strong> /oauth2/token</td>
        <td>OAuth2 token endpoint</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20AuthorizationApi.md#submitconsent"><strong>SubmitConsent</strong></a></td>
        <td><strong>POST</strong> /oauth2/authorize</td>
        <td>OAuth2 consent endpoint</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ClientManagementApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientManagementApi.md#changeactivation"><strong>ChangeActivation</strong></a></td>
        <td><strong>PATCH</strong> /api/2.0/clients/{clientId}/activation</td>
        <td>Change the client activation status</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientManagementApi.md#createclient"><strong>CreateClient</strong></a></td>
        <td><strong>POST</strong> /api/2.0/clients</td>
        <td>Create a new OAuth2 client</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientManagementApi.md#deleteclient"><strong>DeleteClient</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/clients/{clientId}</td>
        <td>Delete an OAuth2 client</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientManagementApi.md#regeneratesecret"><strong>RegenerateSecret</strong></a></td>
        <td><strong>PATCH</strong> /api/2.0/clients/{clientId}/regenerate</td>
        <td>Regenerate the client secret</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientManagementApi.md#revokeuserclient"><strong>RevokeUserClient</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/clients/{clientId}/revoke</td>
        <td>Revoke client consent</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientManagementApi.md#updateclient"><strong>UpdateClient</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/clients/{clientId}</td>
        <td>Update an existing OAuth2 client</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ClientQueryingApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientQueryingApi.md#getclient"><strong>GetClient</strong></a></td>
        <td><strong>GET</strong> /api/2.0/clients/{clientId}</td>
        <td>Get client details</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientQueryingApi.md#getclientinfo"><strong>GetClientInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/clients/{clientId}/info</td>
        <td>Get detailed client information</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientQueryingApi.md#getclients"><strong>GetClients</strong></a></td>
        <td><strong>GET</strong> /api/2.0/clients</td>
        <td>Get clients</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientQueryingApi.md#getclientsinfo"><strong>GetClientsInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/clients/info</td>
        <td>Get detailed information of clients</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientQueryingApi.md#getconsents"><strong>GetConsents</strong></a></td>
        <td><strong>GET</strong> /api/2.0/clients/consents</td>
        <td>Get user consents</td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ClientQueryingApi.md#getpublicclientinfo"><strong>GetPublicClientInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/clients/{clientId}/public/info</td>
        <td>Get public client information</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ScopeManagementApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/OAuth20ScopeManagementApi.md#getscopes"><strong>GetScopes</strong></a></td>
        <td><strong>GET</strong> /api/2.0/scopes</td>
        <td>Get available OAuth2 scopes</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>People</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>GuestsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleGuestsApi.md#approveguestsharelink"><strong>ApproveGuestShareLink</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/guests/share/approve</td>
        <td>Approve a guest sharing link</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleGuestsApi.md#deleteguests"><strong>DeleteGuests</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/people/guests</td>
        <td>Delete guests</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>PasswordApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePasswordApi.md#changeuserpassword"><strong>ChangeUserPassword</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/{userid}/password</td>
        <td>Change a user password</td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePasswordApi.md#senduserpassword"><strong>SendUserPassword</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/password</td>
        <td>Remind a user password</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>PhotosApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePhotosApi.md#creatememberphotothumbnails"><strong>CreateMemberPhotoThumbnails</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/{userid}/photo/thumbnails</td>
        <td>Create photo thumbnails</td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePhotosApi.md#deletememberphoto"><strong>DeleteMemberPhoto</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/people/{userid}/photo</td>
        <td>Delete a user photo</td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePhotosApi.md#getmemberphoto"><strong>GetMemberPhoto</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/{userid}/photo</td>
        <td>Get a user photo</td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePhotosApi.md#updatememberphoto"><strong>UpdateMemberPhoto</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/{userid}/photo</td>
        <td>Update a user photo</td>
      </tr>
      <tr>
        <td><a href="docs/PeoplePhotosApi.md#uploadmemberphoto"><strong>UploadMemberPhoto</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/{userid}/photo</td>
        <td>Upload a user photo</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ProfilesApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#addmember"><strong>AddMember</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people</td>
        <td>Add a user</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#deletemember"><strong>DeleteMember</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/people/{userid}</td>
        <td>Delete a user</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#deleteprofile"><strong>DeleteProfile</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/people/@self</td>
        <td>Delete my profile</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#getallprofiles"><strong>GetAllProfiles</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people</td>
        <td>Get profiles</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#getclaims"><strong>GetClaims</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/tokendiagnostics</td>
        <td>Get user claims</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#getprofilebyemail"><strong>GetProfileByEmail</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/email</td>
        <td>Get a profile by user email</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#getprofilebyuserid"><strong>GetProfileByUserId</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/{userid}</td>
        <td>Get a profile by user ID</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#getselfprofile"><strong>GetSelfProfile</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/@self</td>
        <td>Get my profile</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#inviteusers"><strong>InviteUsers</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/invite</td>
        <td>Invite users</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#removeusers"><strong>RemoveUsers</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/delete</td>
        <td>Delete users</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#resenduserinvites"><strong>ResendUserInvites</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/invite</td>
        <td>Resend activation emails</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#sendemailchangeinstructions"><strong>SendEmailChangeInstructions</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/email</td>
        <td>Send instructions to change email</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#updatemember"><strong>UpdateMember</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/{userid}</td>
        <td>Update a user</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleProfilesApi.md#updatememberculture"><strong>UpdateMemberCulture</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/{userid}/culture</td>
        <td>Update a user culture code</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>QuotaApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleQuotaApi.md#resetusersquota"><strong>ResetUsersQuota</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/resetquota</td>
        <td>Reset a user quota limit</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleQuotaApi.md#updateuserquota"><strong>UpdateUserQuota</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/userquota</td>
        <td>Change a user quota limit</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SearchApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getaccountsentrieswithfilesshared"><strong>GetAccountsEntriesWithFilesShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/accounts/file/{id}/search</td>
        <td>Get account entries with file sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getaccountsentrieswithfoldersshared"><strong>GetAccountsEntriesWithFoldersShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/accounts/folder/{id}/search</td>
        <td>Get account entries with folder sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getaccountsentrieswithroomsshared"><strong>GetAccountsEntriesWithRoomsShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/accounts/room/{id}/search</td>
        <td>Get account entries</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getsearch"><strong>GetSearch</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/@search/{query}</td>
        <td>Search users</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getsimplebyfilter"><strong>GetSimpleByFilter</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/simple/filter</td>
        <td>Search users by extended filter</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getuserswithfilesshared"><strong>GetUsersWithFilesShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/file/{id}</td>
        <td>Get users with file sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getuserswithfoldersshared"><strong>GetUsersWithFoldersShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/folder/{id}</td>
        <td>Get users with folder sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#getuserswithroomshared"><strong>GetUsersWithRoomShared</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/room/{id}</td>
        <td>Get users with room sharing settings</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#searchusersbyextendedfilter"><strong>SearchUsersByExtendedFilter</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/filter</td>
        <td>Search users with detailed information by extended filter</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#searchusersbyquery"><strong>SearchUsersByQuery</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/search</td>
        <td>Search users (using query parameters)</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleSearchApi.md#searchusersbystatus"><strong>SearchUsersByStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/status/{status}/search</td>
        <td>Search users by status filter</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ThemeApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleThemeApi.md#changeportaltheme"><strong>ChangePortalTheme</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/theme</td>
        <td>Change the portal theme</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleThemeApi.md#getportaltheme"><strong>GetPortalTheme</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/theme</td>
        <td>Get the portal theme</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ThirdPartyAccountsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleThirdPartyAccountsApi.md#getthirdpartyauthproviders"><strong>GetThirdPartyAuthProviders</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/thirdparty/providers</td>
        <td>Get third-party accounts</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleThirdPartyAccountsApi.md#linkthirdpartyaccount"><strong>LinkThirdPartyAccount</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/thirdparty/linkaccount</td>
        <td>Link a third-pary account</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleThirdPartyAccountsApi.md#signupthirdpartyaccount"><strong>SignupThirdPartyAccount</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/thirdparty/signup</td>
        <td>Create a third-pary account</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleThirdPartyAccountsApi.md#unlinkthirdpartyaccount"><strong>UnlinkThirdPartyAccount</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/people/thirdparty/unlinkaccount</td>
        <td>Unlink a third-pary account</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>UserDataApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#getdeletepersonalfolderprogress"><strong>GetDeletePersonalFolderProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/delete/personal/progress</td>
        <td>Get the progress of deleting the personal folder</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#getreassignprogress"><strong>GetReassignProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/reassign/progress/{userid}</td>
        <td>Get the reassignment progress</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#getremoveprogress"><strong>GetRemoveProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/remove/progress/{userid}</td>
        <td>Get the deletion progress</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#necessaryreassign"><strong>NecessaryReassign</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/reassign/necessary</td>
        <td>Check data for reassignment need</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#sendinstructionstodelete"><strong>SendInstructionsToDelete</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/self/delete</td>
        <td>Send the deletion instructions</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#startdeletepersonalfolder"><strong>StartDeletePersonalFolder</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/delete/personal/start</td>
        <td>Delete the personal folder</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#startreassign"><strong>StartReassign</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/reassign/start</td>
        <td>Start the data reassignment</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#startremove"><strong>StartRemove</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/remove/start</td>
        <td>Start the data deletion</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#terminatereassign"><strong>TerminateReassign</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/reassign/terminate</td>
        <td>Terminate the data reassignment</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserDataApi.md#terminateremove"><strong>TerminateRemove</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/remove/terminate</td>
        <td>Terminate the data deletion</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>UserStatusApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserStatusApi.md#getbystatus"><strong>GetByStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/status/{status}</td>
        <td>Get profiles by status</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserStatusApi.md#updateuseractivationstatus"><strong>UpdateUserActivationStatus</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/activationstatus/{activationstatus}</td>
        <td>Set an activation status to the users</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserStatusApi.md#updateuserstatus"><strong>UpdateUserStatus</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/status/{status}</td>
        <td>Change a user status</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>UserTypeApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserTypeApi.md#getusertypeupdateprogress"><strong>GetUserTypeUpdateProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/type/progress/{userid}</td>
        <td>Get the progress of updating user type</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserTypeApi.md#starusertypetupdate"><strong>StarUserTypetUpdate</strong></a></td>
        <td><strong>POST</strong> /api/2.0/people/type</td>
        <td>Start updating user type</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserTypeApi.md#terminateusertypeupdate"><strong>TerminateUserTypeUpdate</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/type/terminate</td>
        <td>Terminate updating user type</td>
      </tr>
      <tr>
        <td><a href="docs/PeopleUserTypeApi.md#updateusertype"><strong>UpdateUserType</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/people/type/{type}</td>
        <td>Change a user type</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Portal</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>GuestsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PortalGuestsApi.md#getguestsharinglink"><strong>GetGuestSharingLink</strong></a></td>
        <td><strong>GET</strong> /api/2.0/people/guests/{userid}/share</td>
        <td>Get a guest sharing link</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>PaymentApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#calculatewalletpayment"><strong>CalculateWalletPayment</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/portal/payment/calculatewallet</td>
        <td>Calculate the wallet payment amount</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#changetenantwalletservicestate"><strong>ChangeTenantWalletServiceState</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/payment/servicestate</td>
        <td>Change wallet service state</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#createcustomeroperationsreport"><strong>CreateCustomerOperationsReport</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/payment/customer/operationsreport</td>
        <td>Start the customer operations report generation</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getcheckoutsetupurl"><strong>GetCheckoutSetupUrl</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/chechoutsetupurl</td>
        <td>Get the checkout setup page URL</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getcustomerbalance"><strong>GetCustomerBalance</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/customer/balance</td>
        <td>Get the customer balance</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getcustomerinfo"><strong>GetCustomerInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/customerinfo</td>
        <td>Get the customer information</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getcustomeroperations"><strong>GetCustomerOperations</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/customer/operations</td>
        <td>Get the customer operations</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getcustomeroperationsreport"><strong>GetCustomerOperationsReport</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/customer/operationsreport</td>
        <td>Get the status of the customer operations report generation</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getpaymentaccount"><strong>GetPaymentAccount</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/account</td>
        <td>Get the payment account</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getpaymentcurrencies"><strong>GetPaymentCurrencies</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/currencies</td>
        <td>Get currencies</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getpaymentquotas"><strong>GetPaymentQuotas</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/quotas</td>
        <td>Get quotas</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getpaymenturl"><strong>GetPaymentUrl</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/portal/payment/url</td>
        <td>Get the payment page URL</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getportalprices"><strong>GetPortalPrices</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/prices</td>
        <td>Get prices</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getquotapaymentinformation"><strong>GetQuotaPaymentInformation</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/quota</td>
        <td>Get quota payment information</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#gettenantwalletservicesettings"><strong>GetTenantWalletServiceSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/servicessettings</td>
        <td>Get wallet services settings</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#gettenantwalletsettings"><strong>GetTenantWalletSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/topupsettings</td>
        <td>Get wallet auto top-up settings</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getwalletservice"><strong>GetWalletService</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/walletservice</td>
        <td>Get wallet service</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#getwalletservices"><strong>GetWalletServices</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/payment/walletservices</td>
        <td>Get wallet services</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#sendpaymentrequest"><strong>SendPaymentRequest</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/payment/request</td>
        <td>Send a payment request</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#settenantwalletsettings"><strong>SetTenantWalletSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/payment/topupsettings</td>
        <td>Set wallet auto top-up settings</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#terminatecustomeroperationsreport"><strong>TerminateCustomerOperationsReport</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/portal/payment/customer/operationsreport</td>
        <td>Terminate the customer operations report generation</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#topupdeposit"><strong>TopUpDeposit</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/payment/deposit</td>
        <td>Put money on deposit</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#updatepayment"><strong>UpdatePayment</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/portal/payment/update</td>
        <td>Update the payment quantity</td>
      </tr>
      <tr>
        <td><a href="docs/PortalPaymentApi.md#updatewalletpayment"><strong>UpdateWalletPayment</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/portal/payment/updatewallet</td>
        <td>Update the wallet payment quantity</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>QuotaApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PortalQuotaApi.md#getportalquota"><strong>GetPortalQuota</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/quota</td>
        <td>Get a portal quota</td>
      </tr>
      <tr>
        <td><a href="docs/PortalQuotaApi.md#getportaltariff"><strong>GetPortalTariff</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/tariff</td>
        <td>Get a portal tariff</td>
      </tr>
      <tr>
        <td><a href="docs/PortalQuotaApi.md#getportalusedspace"><strong>GetPortalUsedSpace</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/usedspace</td>
        <td>Get the portal used space</td>
      </tr>
      <tr>
        <td><a href="docs/PortalQuotaApi.md#getrightquota"><strong>GetRightQuota</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/quota/right</td>
        <td>Get the recommended quota</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#continueportal"><strong>ContinuePortal</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/portal/continue</td>
        <td>Restore a portal</td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#deleteportal"><strong>DeletePortal</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/portal/delete</td>
        <td>Delete a portal</td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#getportalinformation"><strong>GetPortalInformation</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal</td>
        <td>Get a portal</td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#getportalpath"><strong>GetPortalPath</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/path</td>
        <td>Get a path to the portal</td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#senddeleteinstructions"><strong>SendDeleteInstructions</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/delete</td>
        <td>Send removal instructions</td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#sendsuspendinstructions"><strong>SendSuspendInstructions</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/suspend</td>
        <td>Send suspension instructions</td>
      </tr>
      <tr>
        <td><a href="docs/PortalSettingsApi.md#suspendportal"><strong>SuspendPortal</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/portal/suspend</td>
        <td>Deactivate a portal</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>UsersApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/PortalUsersApi.md#getinvitationlink"><strong>GetInvitationLink</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/users/invite/{employeeType}</td>
        <td>Get an invitation link</td>
      </tr>
      <tr>
        <td><a href="docs/PortalUsersApi.md#getportaluserscount"><strong>GetPortalUsersCount</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/userscount</td>
        <td>Get a number of portal users</td>
      </tr>
      <tr>
        <td><a href="docs/PortalUsersApi.md#getuserbyid"><strong>GetUserById</strong></a></td>
        <td><strong>GET</strong> /api/2.0/portal/users/{userID}</td>
        <td>Get a user by ID</td>
      </tr>
      <tr>
        <td><a href="docs/PortalUsersApi.md#markgiftmessageasread"><strong>MarkGiftMessageAsRead</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/present/mark</td>
        <td>Mark a gift message as read</td>
      </tr>
      <tr>
        <td><a href="docs/PortalUsersApi.md#sendcongratulations"><strong>SendCongratulations</strong></a></td>
        <td><strong>POST</strong> /api/2.0/portal/sendcongratulations</td>
        <td>Send congratulations</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Rooms</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>RoomsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#addroomtags"><strong>AddRoomTags</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/tags</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#archiveroom"><strong>ArchiveRoom</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/archive</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#changeroomcover"><strong>ChangeRoomCover</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms/{id}/cover</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#createroom"><strong>CreateRoom</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#createroomfromtemplate"><strong>CreateRoomFromTemplate</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms/fromtemplate</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#createroomlogo"><strong>CreateRoomLogo</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms/{id}/logo</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#createroomtag"><strong>CreateRoomTag</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/tags</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#createroomtemplate"><strong>CreateRoomTemplate</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/roomtemplate</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#createroomthirdparty"><strong>CreateRoomThirdParty</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms/thirdparty/{id}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#deletecustomtags"><strong>DeleteCustomTags</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/tags</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#deleteroom"><strong>DeleteRoom</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/rooms/{id}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#deleteroomlogo"><strong>DeleteRoomLogo</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/rooms/{id}/logo</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#deleteroomtags"><strong>DeleteRoomTags</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/rooms/{id}/tags</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getnewroomitems"><strong>GetNewRoomItems</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/{id}/news</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getpublicsettings"><strong>GetPublicSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/roomtemplate/{id}/public</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomcovers"><strong>GetRoomCovers</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/covers</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomcreatingstatus"><strong>GetRoomCreatingStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/fromtemplate/status</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomindexexport"><strong>GetRoomIndexExport</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/indexexport</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroominfo"><strong>GetRoomInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/{id}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomlinks"><strong>GetRoomLinks</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/{id}/links</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomsecurityinfo"><strong>GetRoomSecurityInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/{id}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomtagsinfo"><strong>GetRoomTagsInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/tags</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomtemplatecreatingstatus"><strong>GetRoomTemplateCreatingStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/roomtemplate/status</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomsfolder"><strong>GetRoomsFolder</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomsnewitems"><strong>GetRoomsNewItems</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/news</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#getroomsprimaryexternallink"><strong>GetRoomsPrimaryExternalLink</strong></a></td>
        <td><strong>GET</strong> /api/2.0/files/rooms/{id}/link</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#pinroom"><strong>PinRoom</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/pin</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#reorderroom"><strong>ReorderRoom</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/reorder</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#resendemailinvitations"><strong>ResendEmailInvitations</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms/{id}/resend</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#setpublicsettings"><strong>SetPublicSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/roomtemplate/public</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#setroomlink"><strong>SetRoomLink</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/links</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#setroomsecurity"><strong>SetRoomSecurity</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/share</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#startroomindexexport"><strong>StartRoomIndexExport</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/rooms/{id}/indexexport</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#terminateroomindexexport"><strong>TerminateRoomIndexExport</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/files/rooms/indexexport</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#unarchiveroom"><strong>UnarchiveRoom</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/unarchive</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#unpinroom"><strong>UnpinRoom</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}/unpin</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#updateroom"><strong>UpdateRoom</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/files/rooms/{id}</td>
        <td></td>
      </tr>
      <tr>
        <td><a href="docs/RoomsApi.md#uploadroomlogo"><strong>UploadRoomLogo</strong></a></td>
        <td><strong>POST</strong> /api/2.0/files/logos</td>
        <td></td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Security</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>AccessToDevToolsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAccessToDevToolsApi.md#settenantdevtoolsaccesssettings"><strong>SetTenantDevToolsAccessSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/devtoolsaccess</td>
        <td>Set the Developer Tools access settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>ActiveConnectionsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityActiveConnectionsApi.md#getallactiveconnections"><strong>GetAllActiveConnections</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/activeconnections</td>
        <td>Get active connections</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityActiveConnectionsApi.md#logoutactiveconnection"><strong>LogOutActiveConnection</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/security/activeconnections/logout/{loginEventId}</td>
        <td>Log out from the connection</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityActiveConnectionsApi.md#logoutallactiveconnectionschangepassword"><strong>LogOutAllActiveConnectionsChangePassword</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/security/activeconnections/logoutallchangepassword</td>
        <td>Log out and change password</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityActiveConnectionsApi.md#logoutallactiveconnectionsforuser"><strong>LogOutAllActiveConnectionsForUser</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/security/activeconnections/logoutall/{userId}</td>
        <td>Log out for the user by ID</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityActiveConnectionsApi.md#logoutallexceptthisconnection"><strong>LogOutAllExceptThisConnection</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/security/activeconnections/logoutallexceptthis</td>
        <td>Log out from all connections except the current one</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>AuditTrailDataApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#createaudittrailreport"><strong>CreateAuditTrailReport</strong></a></td>
        <td><strong>POST</strong> /api/2.0/security/audit/events/report</td>
        <td>Generate the audit trail report</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#getauditeventsbyfilter"><strong>GetAuditEventsByFilter</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/events/filter</td>
        <td>Get filtered audit trail data</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#getauditsettings"><strong>GetAuditSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/settings/lifetime</td>
        <td>Get the audit trail settings</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#getaudittrailmappers"><strong>GetAuditTrailMappers</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/mappers</td>
        <td>Get audit trail mappers</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#getaudittrailtypes"><strong>GetAuditTrailTypes</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/types</td>
        <td>Get audit trail types</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#getlastauditevents"><strong>GetLastAuditEvents</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/events/last</td>
        <td>Get audit trail data</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityAuditTrailDataApi.md#setauditsettings"><strong>SetAuditSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/security/audit/settings/lifetime</td>
        <td>Set the audit trail settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>BannersVisibilityApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityBannersVisibilityApi.md#settenantbannersettings"><strong>SetTenantBannerSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/banner</td>
        <td>Set the banners visibility</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>CSPApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityCSPApi.md#configurecsp"><strong>ConfigureCsp</strong></a></td>
        <td><strong>POST</strong> /api/2.0/security/csp</td>
        <td>Configure CSP settings</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityCSPApi.md#getcspsettings"><strong>GetCspSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/csp</td>
        <td>Get CSP settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>FirebaseApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityFirebaseApi.md#docregisterpusnnotificationdevice"><strong>DocRegisterPusnNotificationDevice</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/push/docregisterdevice</td>
        <td>Save the Documents Firebase device token</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityFirebaseApi.md#subscribedocumentspushnotification"><strong>SubscribeDocumentsPushNotification</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/push/docsubscribe</td>
        <td>Subscribe to Documents push notification</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>LoginHistoryApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityLoginHistoryApi.md#createloginhistoryreport"><strong>CreateLoginHistoryReport</strong></a></td>
        <td><strong>POST</strong> /api/2.0/security/audit/login/report</td>
        <td>Generate the login history report</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityLoginHistoryApi.md#getlastloginevents"><strong>GetLastLoginEvents</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/login/last</td>
        <td>Get login history</td>
      </tr>
      <tr>
        <td><a href="docs/SecurityLoginHistoryApi.md#getlogineventsbyfilter"><strong>GetLoginEventsByFilter</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/audit/login/filter</td>
        <td>Get filtered login events</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>OAuth2Api</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecurityOAuth2Api.md#generatejwttoken"><strong>GenerateJwtToken</strong></a></td>
        <td><strong>GET</strong> /api/2.0/security/oauth2/token</td>
        <td>Generate JWT token</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SMTPSettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SecuritySMTPSettingsApi.md#getsmtpoperationstatus"><strong>GetSmtpOperationStatus</strong></a></td>
        <td><strong>GET</strong> /api/2.0/smtpsettings/smtp/test/status</td>
        <td>Get the SMTP testing process status</td>
      </tr>
      <tr>
        <td><a href="docs/SecuritySMTPSettingsApi.md#getsmtpsettings"><strong>GetSmtpSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/smtpsettings/smtp</td>
        <td>Get the SMTP settings</td>
      </tr>
      <tr>
        <td><a href="docs/SecuritySMTPSettingsApi.md#resetsmtpsettings"><strong>ResetSmtpSettings</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/smtpsettings/smtp</td>
        <td>Reset the SMTP settings</td>
      </tr>
      <tr>
        <td><a href="docs/SecuritySMTPSettingsApi.md#savesmtpsettings"><strong>SaveSmtpSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/smtpsettings/smtp</td>
        <td>Save the SMTP settings</td>
      </tr>
      <tr>
        <td><a href="docs/SecuritySMTPSettingsApi.md#testsmtpsettings"><strong>TestSmtpSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/smtpsettings/smtp/test</td>
        <td>Test the SMTP settings</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>Settings</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>AccessToDevToolsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsAccessToDevToolsApi.md#gettenantaccessdevtoolssettings"><strong>GetTenantAccessDevToolsSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/devtoolsaccess</td>
        <td>Get the Developer Tools access settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>AuthorizationApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsAuthorizationApi.md#getauthservices"><strong>GetAuthServices</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/authservice</td>
        <td>Get the authorization services</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsAuthorizationApi.md#saveauthkeys"><strong>SaveAuthKeys</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/authservice</td>
        <td>Save the authorization keys</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>BannersVisibilityApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsBannersVisibilityApi.md#gettenantbannersettings"><strong>GetTenantBannerSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/banner</td>
        <td>Get the banners visibility</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>CommonSettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#closeadminhelper"><strong>CloseAdminHelper</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/closeadminhelper</td>
        <td>Close the admin helper</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#completewizard"><strong>CompleteWizard</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/wizard/complete</td>
        <td>Complete the Wizard settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#configuredeeplink"><strong>ConfigureDeepLink</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/deeplink</td>
        <td>Configure the deep link settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#deleteportalcolortheme"><strong>DeletePortalColorTheme</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/colortheme</td>
        <td>Delete a color theme</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getdeeplinksettings"><strong>GetDeepLinkSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/deeplink</td>
        <td>Get the deep link settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getpaymentsettings"><strong>GetPaymentSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/payment</td>
        <td>Get the payment settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getportalcolortheme"><strong>GetPortalColorTheme</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/colortheme</td>
        <td>Get a color theme</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getportalhostname"><strong>GetPortalHostname</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/machine</td>
        <td>Get hostname</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getportallogo"><strong>GetPortalLogo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/logo</td>
        <td>Get a portal logo</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getportalsettings"><strong>GetPortalSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings</td>
        <td>Get the portal settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getsocketsettings"><strong>GetSocketSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/socket</td>
        <td>Get the socket settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#getsupportedcultures"><strong>GetSupportedCultures</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/cultures</td>
        <td>Get supported languages</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#gettenantuserinvitationsettings"><strong>GetTenantUserInvitationSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/invitationsettings</td>
        <td>Get the user invitation settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#gettimezones"><strong>GetTimeZones</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/timezones</td>
        <td>Get time zones</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#savednssettings"><strong>SaveDnsSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/dns</td>
        <td>Save the DNS settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#savemaildomainsettings"><strong>SaveMailDomainSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/maildomainsettings</td>
        <td>Save the mail domain settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#saveportalcolortheme"><strong>SavePortalColorTheme</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/colortheme</td>
        <td>Save a color theme</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#updateemailactivationsettings"><strong>UpdateEmailActivationSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/emailactivation</td>
        <td>Update the email activation settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCommonSettingsApi.md#updateinvitationsettings"><strong>UpdateInvitationSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/invitationsettings</td>
        <td>Update user invitation settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>CookiesApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCookiesApi.md#getcookiesettings"><strong>GetCookieSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/cookiesettings</td>
        <td>Get cookies lifetime</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsCookiesApi.md#updatecookiesettings"><strong>UpdateCookieSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/cookiesettings</td>
        <td>Update cookies lifetime</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>EncryptionApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsEncryptionApi.md#getstorageencryptionprogress"><strong>GetStorageEncryptionProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/encryption/progress</td>
        <td>Get the storage encryption progress</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsEncryptionApi.md#getstorageencryptionsettings"><strong>GetStorageEncryptionSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/encryption/settings</td>
        <td>Get the storage encryption settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsEncryptionApi.md#startstorageencryption"><strong>StartStorageEncryption</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/encryption/start</td>
        <td>Start the storage encryption process</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>GreetingSettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsGreetingSettingsApi.md#getgreetingsettings"><strong>GetGreetingSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/greetingsettings</td>
        <td>Get greeting settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsGreetingSettingsApi.md#getisdefaultgreetingsettings"><strong>GetIsDefaultGreetingSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/greetingsettings/isdefault</td>
        <td>Check the default greeting settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsGreetingSettingsApi.md#restoregreetingsettings"><strong>RestoreGreetingSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/greetingsettings/restore</td>
        <td>Restore the greeting settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsGreetingSettingsApi.md#savegreetingsettings"><strong>SaveGreetingSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/greetingsettings</td>
        <td>Save the greeting settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>IPRestrictionsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsIPRestrictionsApi.md#getiprestrictions"><strong>GetIpRestrictions</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/iprestrictions</td>
        <td>Get the IP portal restrictions</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsIPRestrictionsApi.md#readiprestrictionssettings"><strong>ReadIpRestrictionsSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/iprestrictions/settings</td>
        <td>Get the IP restriction settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsIPRestrictionsApi.md#saveiprestrictions"><strong>SaveIpRestrictions</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/iprestrictions</td>
        <td>Update the IP restrictions</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsIPRestrictionsApi.md#updateiprestrictionssettings"><strong>UpdateIpRestrictionsSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/iprestrictions/settings</td>
        <td>Update the IP restriction settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>LicenseApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLicenseApi.md#acceptlicense"><strong>AcceptLicense</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/license/accept</td>
        <td>Activate a license</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLicenseApi.md#getislicenserequired"><strong>GetIsLicenseRequired</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/license/required</td>
        <td>Request a license</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLicenseApi.md#refreshlicense"><strong>RefreshLicense</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/license/refresh</td>
        <td>Refresh the license</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLicenseApi.md#uploadlicense"><strong>UploadLicense</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/license</td>
        <td>Upload a license</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>LoginSettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLoginSettingsApi.md#getloginsettings"><strong>GetLoginSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security/loginsettings</td>
        <td>Get the login settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLoginSettingsApi.md#setdefaultloginsettings"><strong>SetDefaultLoginSettings</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/security/loginsettings</td>
        <td>Reset the login settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsLoginSettingsApi.md#updateloginsettings"><strong>UpdateLoginSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/security/loginsettings</td>
        <td>Update the login settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>MessagesApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsMessagesApi.md#enableadminmessagesettings"><strong>EnableAdminMessageSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/messagesettings</td>
        <td>Enable the administrator message settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsMessagesApi.md#sendadminmail"><strong>SendAdminMail</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/sendadmmail</td>
        <td>Send a message to the administrator</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsMessagesApi.md#sendjoininvitemail"><strong>SendJoinInviteMail</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/sendjoininvite</td>
        <td>Sends an invitation email</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>NotificationsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsNotificationsApi.md#getnotificationchannels"><strong>GetNotificationChannels</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/notification/channels</td>
        <td>Get notification channels</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsNotificationsApi.md#getnotificationsettings"><strong>GetNotificationSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/notification/{type}</td>
        <td>Check notification availability</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsNotificationsApi.md#getroomsnotificationsettings"><strong>GetRoomsNotificationSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/notification/rooms</td>
        <td>Get room notification settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsNotificationsApi.md#setnotificationsettings"><strong>SetNotificationSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/notification</td>
        <td>Enable notifications</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsNotificationsApi.md#setroomsnotificationstatus"><strong>SetRoomsNotificationStatus</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/notification/rooms</td>
        <td>Set room notification status</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>OwnerApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsOwnerApi.md#sendownerchangeinstructions"><strong>SendOwnerChangeInstructions</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/owner</td>
        <td>Send the owner change instructions</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsOwnerApi.md#updateportalowner"><strong>UpdatePortalOwner</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/owner</td>
        <td>Update the portal owner</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>QuotaApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsQuotaApi.md#getuserquotasettings"><strong>GetUserQuotaSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/userquotasettings</td>
        <td>Get the user quota settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsQuotaApi.md#saveroomquotasettings"><strong>SaveRoomQuotaSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/roomquotasettings</td>
        <td>Save the room quota settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsQuotaApi.md#settenantquotasettings"><strong>SetTenantQuotaSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/tenantquotasettings</td>
        <td>Save the tenant quota settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>RebrandingApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#deleteadditionalwhitelabelsettings"><strong>DeleteAdditionalWhiteLabelSettings</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/rebranding/additional</td>
        <td>Delete the additional white label settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#deletecompanywhitelabelsettings"><strong>DeleteCompanyWhiteLabelSettings</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/rebranding/company</td>
        <td>Delete the company white label settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getadditionalwhitelabelsettings"><strong>GetAdditionalWhiteLabelSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/rebranding/additional</td>
        <td>Get the additional white label settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getcompanywhitelabelsettings"><strong>GetCompanyWhiteLabelSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/rebranding/company</td>
        <td>Get the company white label settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getenablewhitelabel"><strong>GetEnableWhitelabel</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/enablewhitelabel</td>
        <td>Check the white label availability</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getisdefaultwhitelabellogotext"><strong>GetIsDefaultWhiteLabelLogoText</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/whitelabel/logotext/isdefault</td>
        <td>Check the default white label logo text</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getisdefaultwhitelabellogos"><strong>GetIsDefaultWhiteLabelLogos</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/whitelabel/logos/isdefault</td>
        <td>Check the default white label logos</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getlicensordata"><strong>GetLicensorData</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/companywhitelabel</td>
        <td>Get the licensor data</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getwhitelabellogotext"><strong>GetWhiteLabelLogoText</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/whitelabel/logotext</td>
        <td>Get the white label logo text</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#getwhitelabellogos"><strong>GetWhiteLabelLogos</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/whitelabel/logos</td>
        <td>Get the white label logos</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#restorewhitelabellogotext"><strong>RestoreWhiteLabelLogoText</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/whitelabel/logotext/restore</td>
        <td>Restore the white label logo text</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#restorewhitelabellogos"><strong>RestoreWhiteLabelLogos</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/whitelabel/logos/restore</td>
        <td>Restore the white label logos</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#saveadditionalwhitelabelsettings"><strong>SaveAdditionalWhiteLabelSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/rebranding/additional</td>
        <td>Save the additional white label settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#savecompanywhitelabelsettings"><strong>SaveCompanyWhiteLabelSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/rebranding/company</td>
        <td>Save the company white label settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#savewhitelabellogotext"><strong>SaveWhiteLabelLogoText</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/whitelabel/logotext/save</td>
        <td>Save the white label logo text settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#savewhitelabelsettings"><strong>SaveWhiteLabelSettings</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/whitelabel/logos/save</td>
        <td>Save the white label logos</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsRebrandingApi.md#savewhitelabelsettingsfromfiles"><strong>SaveWhiteLabelSettingsFromFiles</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/whitelabel/logos/savefromfiles</td>
        <td>Save the white label logos from files</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SSOApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSSOApi.md#getdefaultssosettingsv2"><strong>GetDefaultSsoSettingsV2</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/ssov2/default</td>
        <td>Get the default SSO settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSSOApi.md#getssosettingsv2"><strong>GetSsoSettingsV2</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/ssov2</td>
        <td>Get the SSO settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSSOApi.md#getssosettingsv2constants"><strong>GetSsoSettingsV2Constants</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/ssov2/constants</td>
        <td>Get the SSO settings constants</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSSOApi.md#resetssosettingsv2"><strong>ResetSsoSettingsV2</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/ssov2</td>
        <td>Reset the SSO settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSSOApi.md#savessosettingsv2"><strong>SaveSsoSettingsV2</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/ssov2</td>
        <td>Save the SSO settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>SecurityApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#getenabledmodules"><strong>GetEnabledModules</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security/modules</td>
        <td>Get the enabled modules</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#getisproductadministrator"><strong>GetIsProductAdministrator</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security/administrator</td>
        <td>Check a product administrator</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#getpasswordsettings"><strong>GetPasswordSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security/password</td>
        <td>Get the password settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#getproductadministrators"><strong>GetProductAdministrators</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security/administrator/{productid}</td>
        <td>Get the product administrators</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#getwebitemsecurityinfo"><strong>GetWebItemSecurityInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security/{id}</td>
        <td>Get the module availability</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#getwebitemsettingssecurityinfo"><strong>GetWebItemSettingsSecurityInfo</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/security</td>
        <td>Get the security settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#setaccesstowebitems"><strong>SetAccessToWebItems</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/security/access</td>
        <td>Set the security settings to modules</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#setproductadministrator"><strong>SetProductAdministrator</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/security/administrator</td>
        <td>Set a product administrator</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#setwebitemsecurity"><strong>SetWebItemSecurity</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/security</td>
        <td>Set the module security settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsSecurityApi.md#updatepasswordsettings"><strong>UpdatePasswordSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/security/password</td>
        <td>Set the password settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>StatisticsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStatisticsApi.md#getspaceusagestatistics"><strong>GetSpaceUsageStatistics</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/statistics/spaceusage/{id}</td>
        <td>Get the space usage statistics</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>StorageApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#getallbackupstorages"><strong>GetAllBackupStorages</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/storage/backup</td>
        <td>Get the backup storages</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#getallcdnstorages"><strong>GetAllCdnStorages</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/storage/cdn</td>
        <td>Get the CDN storages</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#getallstorages"><strong>GetAllStorages</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/storage</td>
        <td>Get storages</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#getamazons3regions"><strong>GetAmazonS3Regions</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/storage/s3/regions</td>
        <td>Get Amazon regions</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#getstorageprogress"><strong>GetStorageProgress</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/storage/progress</td>
        <td>Get the storage progress</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#resetcdntodefault"><strong>ResetCdnToDefault</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/storage/cdn</td>
        <td>Reset the CDN storage settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#resetstoragetodefault"><strong>ResetStorageToDefault</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/storage</td>
        <td>Reset the storage settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#updatecdnstorage"><strong>UpdateCdnStorage</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/storage/cdn</td>
        <td>Update the CDN storage</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsStorageApi.md#updatestorage"><strong>UpdateStorage</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/storage</td>
        <td>Update a storage</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>TFASettingsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#gettfaappcodes"><strong>GetTfaAppCodes</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/tfaappcodes</td>
        <td>Get the TFA codes</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#gettfaconfirmurl"><strong>GetTfaConfirmUrl</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/tfaapp/confirm</td>
        <td>Get confirmation email</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#gettfasettings"><strong>GetTfaSettings</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/tfaapp</td>
        <td>Get the TFA settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#tfaappgeneratesetupcode"><strong>TfaAppGenerateSetupCode</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/tfaapp/setup</td>
        <td>Generate setup code</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#tfavalidateauthcode"><strong>TfaValidateAuthCode</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/tfaapp/validate</td>
        <td>Validate the TFA code</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#unlinktfaapp"><strong>UnlinkTfaApp</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/tfaappnewapp</td>
        <td>Unlink the TFA application</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#updatetfaappcodes"><strong>UpdateTfaAppCodes</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/tfaappnewcodes</td>
        <td>Update the TFA codes</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#updatetfasettings"><strong>UpdateTfaSettings</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/tfaapp</td>
        <td>Update the TFA settings</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTFASettingsApi.md#updatetfasettingslink"><strong>UpdateTfaSettingsLink</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/tfaappwithlink</td>
        <td>Get a confirmation email for updating TFA settings</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>TelegramApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTelegramApi.md#checktelegram"><strong>CheckTelegram</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/telegram/check</td>
        <td>Check the Telegram connection</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTelegramApi.md#linktelegram"><strong>LinkTelegram</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/telegram/link</td>
        <td>Get the Telegram link</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsTelegramApi.md#unlinktelegram"><strong>UnlinkTelegram</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/telegram/link</td>
        <td>Unlink Telegram</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>WebhooksApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#createwebhook"><strong>CreateWebhook</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/webhook</td>
        <td>Create a webhook</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#enablewebhook"><strong>EnableWebhook</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/webhook/enable</td>
        <td>Enable a webhook</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#gettenantwebhooks"><strong>GetTenantWebhooks</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/webhook</td>
        <td>Get webhooks</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#getwebhooktriggers"><strong>GetWebhookTriggers</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/webhook/triggers</td>
        <td>Get webhook triggers</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#getwebhookslogs"><strong>GetWebhooksLogs</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/webhooks/log</td>
        <td>Get webhook logs</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#removewebhook"><strong>RemoveWebhook</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/webhook/{id}</td>
        <td>Remove a webhook</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#retrywebhook"><strong>RetryWebhook</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/webhook/{id}/retry</td>
        <td>Retry a webhook</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#retrywebhooks"><strong>RetryWebhooks</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/webhook/retry</td>
        <td>Retry webhooks</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebhooksApi.md#updatewebhook"><strong>UpdateWebhook</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/webhook</td>
        <td>Update a webhook</td>
      </tr>
    <tr>
        <td colspan="3" style="text-align: center;"><strong>WebpluginsApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebpluginsApi.md#addwebpluginfromfile"><strong>AddWebPluginFromFile</strong></a></td>
        <td><strong>POST</strong> /api/2.0/settings/webplugins</td>
        <td>Add a web plugin</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebpluginsApi.md#deletewebplugin"><strong>DeleteWebPlugin</strong></a></td>
        <td><strong>DELETE</strong> /api/2.0/settings/webplugins/{name}</td>
        <td>Delete a web plugin</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebpluginsApi.md#getwebplugin"><strong>GetWebPlugin</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/webplugins/{name}</td>
        <td>Get a web plugin by name</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebpluginsApi.md#getwebplugins"><strong>GetWebPlugins</strong></a></td>
        <td><strong>GET</strong> /api/2.0/settings/webplugins</td>
        <td>Get web plugins</td>
      </tr>
      <tr>
        <td><a href="docs/SettingsWebpluginsApi.md#updatewebplugin"><strong>UpdateWebPlugin</strong></a></td>
        <td><strong>PUT</strong> /api/2.0/settings/webplugins/{name}</td>
        <td>Update a web plugin</td>
      </tr>
    </tbody>
  </table>

</details>
<details>
  <summary>ThirdParty</summary>

  <table>
    <tbody>
      <tr>
        <th>Method</th>
        <th>HTTP request</th>
        <th>Description</th>
      </tr>
      <tr>
        <td colspan="3" style="text-align: center;"><strong>ThirdPartyApi</strong></td>
      </tr>
      <tr>
        <td><a href="docs/ThirdPartyApi.md#getthirdpartycode"><strong>GetThirdPartyCode</strong></a></td>
        <td><strong>GET</strong> /api/2.0/thirdparty/{provider}</td>
        <td>Get the code request</td>
      </tr>
    </tbody>
  </table>

</details>

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
 - [Model.BackupServiceStateDto](docs/BackupServiceStateDto.md)
 - [Model.BackupServiceStateWrapper](docs/BackupServiceStateWrapper.md)
 - [Model.BackupStorageType](docs/BackupStorageType.md)
 - [Model.Balance](docs/Balance.md)
 - [Model.BalanceWrapper](docs/BalanceWrapper.md)
 - [Model.BaseBatchRequestDto](docs/BaseBatchRequestDto.md)
 - [Model.BaseBatchRequestDtoAllOfFileIds](docs/BaseBatchRequestDtoAllOfFileIds.md)
 - [Model.BaseBatchRequestDtoAllOfFolderIds](docs/BaseBatchRequestDtoAllOfFolderIds.md)
 - [Model.BaseStorageSettingsCdnStorageSettings](docs/BaseStorageSettingsCdnStorageSettings.md)
 - [Model.BaseStorageSettingsStorageSettings](docs/BaseStorageSettingsStorageSettings.md)
 - [Model.BatchRequestDto](docs/BatchRequestDto.md)
 - [Model.BatchRequestDtoAllOfDestFolderId](docs/BatchRequestDtoAllOfDestFolderId.md)
 - [Model.BatchRequestDtoAllOfFileIds](docs/BatchRequestDtoAllOfFileIds.md)
 - [Model.BatchRequestDtoAllOfFolderIds](docs/BatchRequestDtoAllOfFolderIds.md)
 - [Model.BatchTagsRequestDto](docs/BatchTagsRequestDto.md)
 - [Model.BooleanWrapper](docs/BooleanWrapper.md)
 - [Model.CapabilitiesDto](docs/CapabilitiesDto.md)
 - [Model.CapabilitiesWrapper](docs/CapabilitiesWrapper.md)
 - [Model.CdnStorageSettings](docs/CdnStorageSettings.md)
 - [Model.CdnStorageSettingsWrapper](docs/CdnStorageSettingsWrapper.md)
 - [Model.ChangeClientActivationRequest](docs/ChangeClientActivationRequest.md)
 - [Model.ChangeHistory](docs/ChangeHistory.md)
 - [Model.ChangeOwnerRequestDto](docs/ChangeOwnerRequestDto.md)
 - [Model.ChangeWalletServiceStateRequestDto](docs/ChangeWalletServiceStateRequestDto.md)
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
 - [Model.DeleteBatchRequestDtoAllOfFileIds](docs/DeleteBatchRequestDtoAllOfFileIds.md)
 - [Model.DeleteBatchRequestDtoAllOfFolderIds](docs/DeleteBatchRequestDtoAllOfFolderIds.md)
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
 - [Model.DownloadRequestDtoAllOfFileIds](docs/DownloadRequestDtoAllOfFileIds.md)
 - [Model.DownloadRequestDtoAllOfFolderIds](docs/DownloadRequestDtoAllOfFolderIds.md)
 - [Model.DownloadRequestItemDto](docs/DownloadRequestItemDto.md)
 - [Model.DownloadRequestItemDtoKey](docs/DownloadRequestItemDtoKey.md)
 - [Model.DraftLocationInteger](docs/DraftLocationInteger.md)
 - [Model.DuplicateRequestDto](docs/DuplicateRequestDto.md)
 - [Model.DuplicateRequestDtoAllOfFileIds](docs/DuplicateRequestDtoAllOfFileIds.md)
 - [Model.DuplicateRequestDtoAllOfFolderIds](docs/DuplicateRequestDtoAllOfFolderIds.md)
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
 - [Model.EmailInvitationDto](docs/EmailInvitationDto.md)
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
 - [Model.EmployeeWrapper](docs/EmployeeWrapper.md)
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
 - [Model.FileDtoIntegerAllOfViewAccessibility](docs/FileDtoIntegerAllOfViewAccessibility.md)
 - [Model.FileEntryBaseArrayWrapper](docs/FileEntryBaseArrayWrapper.md)
 - [Model.FileEntryBaseDto](docs/FileEntryBaseDto.md)
 - [Model.FileEntryBaseWrapper](docs/FileEntryBaseWrapper.md)
 - [Model.FileEntryDtoInteger](docs/FileEntryDtoInteger.md)
 - [Model.FileEntryDtoIntegerAllOfAvailableShareRights](docs/FileEntryDtoIntegerAllOfAvailableShareRights.md)
 - [Model.FileEntryDtoIntegerAllOfSecurity](docs/FileEntryDtoIntegerAllOfSecurity.md)
 - [Model.FileEntryDtoIntegerAllOfShareSettings](docs/FileEntryDtoIntegerAllOfShareSettings.md)
 - [Model.FileEntryDtoString](docs/FileEntryDtoString.md)
 - [Model.FileEntryIntegerArrayWrapper](docs/FileEntryIntegerArrayWrapper.md)
 - [Model.FileEntryType](docs/FileEntryType.md)
 - [Model.FileIntegerArrayWrapper](docs/FileIntegerArrayWrapper.md)
 - [Model.FileIntegerWrapper](docs/FileIntegerWrapper.md)
 - [Model.FileLink](docs/FileLink.md)
 - [Model.FileLinkRequest](docs/FileLinkRequest.md)
 - [Model.FileLinkWrapper](docs/FileLinkWrapper.md)
 - [Model.FileOperationArrayWrapper](docs/FileOperationArrayWrapper.md)
 - [Model.FileOperationDto](docs/FileOperationDto.md)
 - [Model.FileOperationRequestBaseDto](docs/FileOperationRequestBaseDto.md)
 - [Model.FileOperationType](docs/FileOperationType.md)
 - [Model.FileOperationWrapper](docs/FileOperationWrapper.md)
 - [Model.FileReference](docs/FileReference.md)
 - [Model.FileReferenceData](docs/FileReferenceData.md)
 - [Model.FileReferenceWrapper](docs/FileReferenceWrapper.md)
 - [Model.FileShare](docs/FileShare.md)
 - [Model.FileShareArrayWrapper](docs/FileShareArrayWrapper.md)
 - [Model.FileShareDto](docs/FileShareDto.md)
 - [Model.FileShareLink](docs/FileShareLink.md)
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
 - [Model.FolderLinkRequest](docs/FolderLinkRequest.md)
 - [Model.FolderStringArrayWrapper](docs/FolderStringArrayWrapper.md)
 - [Model.FolderStringWrapper](docs/FolderStringWrapper.md)
 - [Model.FolderType](docs/FolderType.md)
 - [Model.FormFillingManageAction](docs/FormFillingManageAction.md)
 - [Model.FormFillingStatus](docs/FormFillingStatus.md)
 - [Model.FormGalleryDto](docs/FormGalleryDto.md)
 - [Model.FormRole](docs/FormRole.md)
 - [Model.FormRoleArrayWrapper](docs/FormRoleArrayWrapper.md)
 - [Model.FormRoleDto](docs/FormRoleDto.md)
 - [Model.FormsItemArrayWrapper](docs/FormsItemArrayWrapper.md)
 - [Model.FormsItemDto](docs/FormsItemDto.md)
 - [Model.GetReferenceDataDtoInteger](docs/GetReferenceDataDtoInteger.md)
 - [Model.GobackConfig](docs/GobackConfig.md)
 - [Model.GreetingSettingsRequestsDto](docs/GreetingSettingsRequestsDto.md)
 - [Model.GroupArrayWrapper](docs/GroupArrayWrapper.md)
 - [Model.GroupDto](docs/GroupDto.md)
 - [Model.GroupMemberSecurityRequestArrayWrapper](docs/GroupMemberSecurityRequestArrayWrapper.md)
 - [Model.GroupMemberSecurityRequestDto](docs/GroupMemberSecurityRequestDto.md)
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
 - [Model.ImportableApiEntity](docs/ImportableApiEntity.md)
 - [Model.InfoConfigDto](docs/InfoConfigDto.md)
 - [Model.Int32Wrapper](docs/Int32Wrapper.md)
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
 - [Model.Location](docs/Location.md)
 - [Model.LocationType](docs/LocationType.md)
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
 - [Model.ModuleWrapper](docs/ModuleWrapper.md)
 - [Model.NewItemsDtoFileEntryBaseDto](docs/NewItemsDtoFileEntryBaseDto.md)
 - [Model.NewItemsDtoRoomNewItemsDto](docs/NewItemsDtoRoomNewItemsDto.md)
 - [Model.NewItemsFileEntryBaseArrayWrapper](docs/NewItemsFileEntryBaseArrayWrapper.md)
 - [Model.NewItemsRoomNewItemsArrayWrapper](docs/NewItemsRoomNewItemsArrayWrapper.md)
 - [Model.NoContentResult](docs/NoContentResult.md)
 - [Model.NoContentResultWrapper](docs/NoContentResultWrapper.md)
 - [Model.NotificationChannelDto](docs/NotificationChannelDto.md)
 - [Model.NotificationChannelStatusDto](docs/NotificationChannelStatusDto.md)
 - [Model.NotificationChannelStatusWrapper](docs/NotificationChannelStatusWrapper.md)
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
 - [Model.RegStatus](docs/RegStatus.md)
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
 - [Model.ScheduleDto](docs/ScheduleDto.md)
 - [Model.ScheduleWrapper](docs/ScheduleWrapper.md)
 - [Model.ScopeResponse](docs/ScopeResponse.md)
 - [Model.SearchArea](docs/SearchArea.md)
 - [Model.SecurityArrayWrapper](docs/SecurityArrayWrapper.md)
 - [Model.SecurityDto](docs/SecurityDto.md)
 - [Model.SecurityInfoRequestDto](docs/SecurityInfoRequestDto.md)
 - [Model.SecurityInfoSimpleRequestDto](docs/SecurityInfoSimpleRequestDto.md)
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
 - [Model.StatusCodeResult](docs/StatusCodeResult.md)
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
 - [Model.TelegramStatusDto](docs/TelegramStatusDto.md)
 - [Model.TelegramStatusWrapper](docs/TelegramStatusWrapper.md)
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
 - [Model.TenantWalletService](docs/TenantWalletService.md)
 - [Model.TenantWalletServiceSettings](docs/TenantWalletServiceSettings.md)
 - [Model.TenantWalletServiceSettingsWrapper](docs/TenantWalletServiceSettingsWrapper.md)
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
 - [Model.WhiteLabelLogoType](docs/WhiteLabelLogoType.md)
 - [Model.WhiteLabelRequestsDto](docs/WhiteLabelRequestsDto.md)
 - [Model.WizardRequestsDto](docs/WizardRequestsDto.md)
 - [Model.WizardSettings](docs/WizardSettings.md)
 - [Model.WizardSettingsWrapper](docs/WizardSettingsWrapper.md)

</details>
