# DocSpace.API.SDK.Model.AmazonS3RegionDto
An Amazon S3 region.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SystemName** | **string** | The region code to send as the region value when configuring an Amazon S3 storage or backup target. It is  the one field of this object that is an argument elsewhere; a code the server does not list here cannot be  reached, so pick one from this list rather than typing it. | [optional] 
**DisplayName** | **string** | The region name as Amazon writes it, in English regardless of the portal language, for showing in a  picker next to `systemName`. | [optional] 
**PartitionName** | **string** | The Amazon partition the region sits in - the ordinary commercial cloud, the Chinese one, or a government  one. Regions of different partitions are not reachable with the same credentials. | [optional] 
**PartitionDnsSuffix** | **string** | The domain the partition's service host names end in, which differs from partition to partition. | [optional] 
**PartitionRegionRegex** | **string** | The pattern every region code of this partition matches, for validating a code before sending it. | [optional] 
**HostnameTemplate** | **string** | How a service host name of the partition is assembled, with `{service}`, `{region}` and `{dnsSuffix}` to  be filled in. It is reference material - the portal builds its own endpoints from `systemName`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

