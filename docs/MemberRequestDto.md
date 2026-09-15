# DocSpace.API.SDK.Model.MemberRequestDto
The user request parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | The password in plain text. It is checked against the portal password policy and rejected with 400 when it is  too weak. When neither this field nor `passwordHash` is sent, a random password is generated and nobody  learns it, so the account can only be used after a password recovery. | [optional] 
**PasswordHash** | **string** | The password already hashed by the client, which is what the portal stores. It is a PBKDF2-HMACSHA256 hash of  the plain password, computed with the salt, the iteration count and the key size the portal settings publish,  and written as lowercase hexadecimal. When it is sent, `password` is ignored and the password policy is not  applied. | [optional] 
**Email** | **string** | The email address of the new account, up to 255 characters. It is required in practice and has to be a real  address, and it becomes the sign-in name of the account. | [optional] 
**Type** | **EmployeeType** | The type of the new account: `User`, `RoomAdmin` or `DocSpaceAdmin`. `Guest` is not accepted here, and the  value is ignored entirely when `fromInviteLink` is set, because the invitation link decides the type. When no  paid seat is free, the account is created as `User` whatever was asked for. | [optional] 
**IsUser** | **bool?** | Only chooses which entry the operation writes to the audit trail - the one for a guest or the one for a  member. It does not change the type of the account; `type` and the invitation link do that. | [optional] 
**FirstName** | **string** | The first name, up to 255 characters. It is checked together with `lastName`, and a pair the portal does not  accept as a name answers 400. | [optional] 
**LastName** | **string** | The last name, up to 255 characters. It is checked together with `firstName`, and a pair the portal does not  accept as a name answers 400. | [optional] 
**Department** | **List&lt;Guid&gt;** | The groups to put the new account into, by group ID. Read the IDs from `GET api/2.0/group`; an ID that  matches no group is skipped without an error. | [optional] 
**Location** | **string** | The free-text location shown on the profile. It is stored as it is given and is not validated. | [optional] 
**Comment** | **string** | The free-text note kept with the profile, shown to administrators. It is stored as it is given. | [optional] 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | The additional ways to reach the person, each as a type and a value pair. The type is a free-text label such  as `email`, `phone`, `skype` or `telegram`, and an entry with an empty value is dropped. | [optional] 
**Files** | **string** | The address the portal downloads the avatar from. It has to use HTTPS unless the request itself came over  HTTP, an address the portal refuses to fetch is rejected, and passing the default avatar path means no  avatar is downloaded. | [optional] 
**FromInviteLink** | **bool** | Set it to true when the account is created by somebody accepting an invitation, which makes `key` required  and lets the link decide the type. With the default false the caller has to hold the permission to add an  account of the requested type. | [optional] 
**Key** | **string** | The key of the invitation link being accepted, taken from the link itself. It is read only when  `fromInviteLink` is true, and an expired or already used key answers 403. | [optional] 
**CultureName** | **string** | The interface language of the new account, as a culture code. It is applied whether or not the portal has  that culture enabled, so send a code the portal supports. | [optional] 
**Target** | **Guid** | Not used. The handler reads nothing from this field, and it is kept only so that existing clients keep  working. | [optional] 
**Spam** | **bool?** | Whether the account agrees to receive tips, updates and offers. It defaults to false, which means no such  mail is sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

