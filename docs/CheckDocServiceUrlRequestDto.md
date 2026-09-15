# DocSpace.API.SDK.Model.CheckDocServiceUrlRequestDto
The ONLYOFFICE Docs connection settings to store and verify.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocServiceUrl** | **string** | The public address of the Document Server, the one a browser loads the editor from. An empty value drops the  portal's own setting, so the address configured for the deployment takes over again. A value with no scheme is  stored with `http://` prepended, and an absolute address may not carry a query string. | 
**DocServiceUrlInternal** | **string** | The address the portal itself uses for its server-to-server calls to the Document Server, for deployments  where that traffic stays inside the private network. Left empty, those calls go to the public address instead. | [optional] 
**DocServiceUrlPortal** | **string** | The address of this portal as the Document Server has to call it back on in order to fetch and save a  document. Set it when the Document Server cannot resolve the portal by its public name; left empty, the  portal's own resolved address is used. | [optional] 
**DocServiceSignatureSecret** | **string** | The shared secret that requests between the portal and the Document Server are signed with; it has to be the  same value the Document Server itself is configured with, otherwise the verification of the new settings  fails. It is write-only: the document service location is reported without it. | [optional] 
**DocServiceSignatureHeader** | **string** | The name of the HTTP header the signature travels in, which has to match the header the Document Server  expects. A secret without a header is not a usable pair and is rejected. | [optional] 
**DocServiceSslVerification** | **bool?** | Whether the portal validates the TLS certificate of the Document Server. With verification on, a self-signed  certificate breaks the connection; with it off, any certificate is accepted, which is meant for test  deployments only. Omitting the field turns verification on. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

