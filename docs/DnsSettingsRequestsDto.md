# DocSpace.API.SDK.Model.DnsSettingsRequestsDto
The custom domain the portal answers on, and whether that mapping is in force.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsName** | **string** | The domain the portal is to be reachable under, as a bare hostname without a scheme. It must not collide with  the reserved base domain of the installation, and a name that fails validation is refused without disturbing  the mapping in force. It is read only while `enable` is true. | [optional] 
**Enable** | **bool** | Whether the custom domain is put in force. Setting it false clears the mapping and ignores `dnsName`; setting  it true also stops the previous domain from answering and rewrites any Content Security Policy entry that  named it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

