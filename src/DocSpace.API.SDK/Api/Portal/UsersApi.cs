// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.Portal
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>InvitationLinkWrapper</returns>
        InvitationLinkWrapper CreateInvitationLink(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default);

        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>ApiResponse of InvitationLinkWrapper</returns>
        ApiResponse<InvitationLinkWrapper> CreateInvitationLinkWithHttpInfo(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default);
        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper DeleteInvitationLink(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default);

        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> DeleteInvitationLinkWithHttpInfo(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default);
        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>StringWrapper</returns>
        [Obsolete]
        StringWrapper GetInvitationLink(EmployeeType employeeType);

        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        [Obsolete]
        ApiResponse<StringWrapper> GetInvitationLinkWithHttpInfo(EmployeeType employeeType);
        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>InvitationLinkWrapper</returns>
        InvitationLinkWrapper GetInvitationLinkByEmployeeType(EmployeeType employeeType);

        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>ApiResponse of InvitationLinkWrapper</returns>
        ApiResponse<InvitationLinkWrapper> GetInvitationLinkByEmployeeTypeWithHttpInfo(EmployeeType employeeType);
        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>Int64Wrapper</returns>
        Int64Wrapper GetPortalUsersCount();

        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>ApiResponse of Int64Wrapper</returns>
        ApiResponse<Int64Wrapper> GetPortalUsersCountWithHttpInfo();
        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>UserInfoWrapper</returns>
        UserInfoWrapper GetUserById(Guid userID);

        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>ApiResponse of UserInfoWrapper</returns>
        ApiResponse<UserInfoWrapper> GetUserByIdWithHttpInfo(Guid userID);
        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns></returns>
        void MarkGiftMessageAsRead();

        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MarkGiftMessageAsReadWithHttpInfo();
        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns></returns>
        void SendCongratulations(Guid userid, string key);

        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendCongratulationsWithHttpInfo(Guid userid, string key);
        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>InvitationLinkWrapper</returns>
        InvitationLinkWrapper UpdateInvitationLink(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default);

        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>ApiResponse of InvitationLinkWrapper</returns>
        ApiResponse<InvitationLinkWrapper> UpdateInvitationLinkWithHttpInfo(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>Task of InvitationLinkWrapper</returns>
        Task<InvitationLinkWrapper> CreateInvitationLinkAsync(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (InvitationLinkWrapper)</returns>
        Task<ApiResponse<InvitationLinkWrapper>> CreateInvitationLinkWithHttpInfoAsync(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> DeleteInvitationLinkAsync(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> DeleteInvitationLinkWithHttpInfoAsync(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        [Obsolete]
        Task<StringWrapper> GetInvitationLinkAsync(EmployeeType employeeType, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        [Obsolete]
        Task<ApiResponse<StringWrapper>> GetInvitationLinkWithHttpInfoAsync(EmployeeType employeeType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>Task of InvitationLinkWrapper</returns>
        Task<InvitationLinkWrapper> GetInvitationLinkByEmployeeTypeAsync(EmployeeType employeeType, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>Task of ApiResponse (InvitationLinkWrapper)</returns>
        Task<ApiResponse<InvitationLinkWrapper>> GetInvitationLinkByEmployeeTypeWithHttpInfoAsync(EmployeeType employeeType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>Task of Int64Wrapper</returns>
        Task<Int64Wrapper> GetPortalUsersCountAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>Task of ApiResponse (Int64Wrapper)</returns>
        Task<ApiResponse<Int64Wrapper>> GetPortalUsersCountWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>Task of UserInfoWrapper</returns>
        Task<UserInfoWrapper> GetUserByIdAsync(Guid userID, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>Task of ApiResponse (UserInfoWrapper)</returns>
        Task<ApiResponse<UserInfoWrapper>> GetUserByIdWithHttpInfoAsync(Guid userID, CancellationToken cancellationToken = default);
        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns>Task of void</returns>
        Task MarkGiftMessageAsReadAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> MarkGiftMessageAsReadWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns>Task of void</returns>
        Task SendCongratulationsAsync(Guid userid, string key, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> SendCongratulationsWithHttpInfoAsync(Guid userid, string key, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>Task of InvitationLinkWrapper</returns>
        Task<InvitationLinkWrapper> UpdateInvitationLinkAsync(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (InvitationLinkWrapper)</returns>
        Task<ApiResponse<InvitationLinkWrapper>> UpdateInvitationLinkWithHttpInfoAsync(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IUsersApiSync, IUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IDisposable, IUsersApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public UsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public UsersApi(string basePath)
        {
            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public UsersApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UsersApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UsersApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class using a Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UsersApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public UsersApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            ApiClient.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value; 
        }


        
        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>InvitationLinkWrapper</returns>
        public InvitationLinkWrapper CreateInvitationLink(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default)
        {
            var localVarResponse = CreateInvitationLinkWithHttpInfo(invitationLinkCreateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>ApiResponse of InvitationLinkWrapper</returns>
        public ApiResponse<InvitationLinkWrapper> CreateInvitationLinkWithHttpInfo(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (invitationLinkCreateRequestDto != null) localVarRequestOptions.Data = invitationLinkCreateRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<InvitationLinkWrapper>("/api/2.0/portal/users/invitationlink", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateInvitationLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>Task of InvitationLinkWrapper</returns>
        public async Task<InvitationLinkWrapper> CreateInvitationLinkAsync(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateInvitationLinkWithHttpInfoAsync(invitationLinkCreateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an invitation link
        /// </summary>
        /// <remarks>
        /// Creates the portal's invitation link for one role and returns it together with the URL to share. A portal  keeps at most one link per role, so a call for a role that already has one is refused - read the existing link  with `GET api/2.0/portal/users/invitationlink/{employeeType}` and change it with  `PUT api/2.0/portal/users/invitationlink` instead. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`), `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or `User`,  and `expiration`, when given, has to lie in the future and is read in the portal time zone. The caller needs  the right to add users of that role, only the portal owner may create the DocSpace administrator link, and a  link for a paying role additionally needs a free paid seat in the portal quota. The call is mutating and not  idempotent. The answer carries the `id` needed to update or delete the link, the shortened `url`,  `maxUseCount` and `currentUseCount`, `expiration` in the portal time zone - empty for a link that never  expires - and `isExpired`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkCreateRequestDto">The role a new invitation link grants, and the limits placed on it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-invitation-link/">REST API Reference for CreateInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (InvitationLinkWrapper)</returns>
        public async Task<ApiResponse<InvitationLinkWrapper>> CreateInvitationLinkWithHttpInfoAsync(InvitationLinkCreateRequestDto? invitationLinkCreateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (invitationLinkCreateRequestDto != null) localVarRequestOptions.Data = invitationLinkCreateRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<InvitationLinkWrapper>("/api/2.0/portal/users/invitationlink", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateInvitationLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper DeleteInvitationLink(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default)
        {
            var localVarResponse = DeleteInvitationLinkWithHttpInfo(invitationLinkDeleteRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> DeleteInvitationLinkWithHttpInfo(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (invitationLinkDeleteRequestDto != null) localVarRequestOptions.Data = invitationLinkDeleteRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<StringWrapper>("/api/2.0/portal/users/invitationlink", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteInvitationLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> DeleteInvitationLinkAsync(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteInvitationLinkWithHttpInfoAsync(invitationLinkDeleteRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an invitation link
        /// </summary>
        /// <remarks>
        /// Deletes the portal's invitation link with the given `id`, so the URL shared from it stops letting anyone in;  accounts that already joined through it are not touched. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and the link has to exist - a second call with the same `id` is  answered as not found. The caller needs the right to add users of the link's role, and only the portal owner  may delete the DocSpace administrator link. The call is destructive and cannot be undone: a link for the same  role has to be created again with `POST api/2.0/portal/users/invitationlink`, and it gets a new `id`, a new  URL and a `currentUseCount` that starts from zero. Nothing is returned in the body. To stop invitations  without losing the links, switch inviting members off for the whole portal with  `PUT api/2.0/settings/invitationsettings` - the links then stay stored but are refused until it is switched on  again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkDeleteRequestDto">Which invitation link is withdrawn. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-invitation-link/">REST API Reference for DeleteInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> DeleteInvitationLinkWithHttpInfoAsync(InvitationLinkDeleteRequestDto? invitationLinkDeleteRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (invitationLinkDeleteRequestDto != null) localVarRequestOptions.Data = invitationLinkDeleteRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<StringWrapper>("/api/2.0/portal/users/invitationlink", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteInvitationLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>StringWrapper</returns>
        [Obsolete]
        public StringWrapper GetInvitationLink(EmployeeType employeeType)
        {
            var localVarResponse = GetInvitationLinkWithHttpInfo(employeeType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        [Obsolete]
        public ApiResponse<StringWrapper> GetInvitationLinkWithHttpInfo(EmployeeType employeeType)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("employeeType", ClientUtils.ParameterToString(employeeType)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/portal/users/invite/{employeeType}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetInvitationLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        [Obsolete]
        public async Task<StringWrapper> GetInvitationLinkAsync(EmployeeType employeeType, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetInvitationLinkWithHttpInfoAsync(employeeType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a legacy invitation link
        /// </summary>
        /// <remarks>
        /// Deprecated - use `POST api/2.0/portal/users/invitationlink` and the neighbouring operations under that path,  which store the link and let it be read, changed and revoked. Builds a shortened URL that lets whoever opens  it join this portal with the role given in the path, and returns it as a bare string; nothing is stored, so  the link can afterwards be neither listed nor withdrawn. Inviting members has to be enabled for the portal -  `GET api/2.0/settings/invitationsettings` reports that - otherwise the call is refused. The caller needs the  right to add users of the requested role and only the portal owner may ask for a DocSpace administrator link;  a caller without that right gets an empty string instead of an error, so treat an empty answer as a refusal.  The call changes nothing on the portal and may be repeated, each time returning an equivalent link. The URL  carries a confirmation key bound to the calling account and the portal alias; it has no use limit and stops  being accepted once the portal's e-mail key lifetime has passed, seven days by default - neither of the two  can be set per link, which is what the replacement operations add.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link/">REST API Reference for GetInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        [Obsolete]
        public async Task<ApiResponse<StringWrapper>> GetInvitationLinkWithHttpInfoAsync(EmployeeType employeeType, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("employeeType", ClientUtils.ParameterToString(employeeType)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/portal/users/invite/{employeeType}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetInvitationLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>InvitationLinkWrapper</returns>
        public InvitationLinkWrapper GetInvitationLinkByEmployeeType(EmployeeType employeeType)
        {
            var localVarResponse = GetInvitationLinkByEmployeeTypeWithHttpInfo(employeeType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>ApiResponse of InvitationLinkWrapper</returns>
        public ApiResponse<InvitationLinkWrapper> GetInvitationLinkByEmployeeTypeWithHttpInfo(EmployeeType employeeType)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("employeeType", ClientUtils.ParameterToString(employeeType)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<InvitationLinkWrapper>("/api/2.0/portal/users/invitationlink/{employeeType}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetInvitationLinkByEmployeeType", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>Task of InvitationLinkWrapper</returns>
        public async Task<InvitationLinkWrapper> GetInvitationLinkByEmployeeTypeAsync(EmployeeType employeeType, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetInvitationLinkByEmployeeTypeWithHttpInfoAsync(employeeType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an invitation link by role
        /// </summary>
        /// <remarks>
        /// Returns the portal's invitation link for one role - the URL to share, how long it lasts and how often it has  already been used. Inviting members has to be enabled for the portal  (`GET api/2.0/settings/invitationsettings`) and `employeeType` has to be `DocSpaceAdmin`, `RoomAdmin` or  `User`; the caller needs the right to add users of that role, only the portal owner may read the DocSpace  administrator link, and a link for a paying role is shown only while the portal quota still has a free paid  seat. The call is read-only and idempotent, but the `url` it returns is signed for the calling account, so two  administrators are handed two different URLs for one and the same link. A role that has no link yet is  answered with an empty body and 200 rather than a 404 - create the link with  `POST api/2.0/portal/users/invitationlink`. `expiration` is in the portal time zone and empty for a link  without a deadline, `isExpired` says whether that deadline has passed, and `currentUseCount` counts how many  accounts have already joined through the link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeType">The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` have a link; any  other role is refused. The portal keeps at most one link per role, so this value alone identifies it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-invitation-link-by-employee-type/">REST API Reference for GetInvitationLinkByEmployeeType Operation</seealso>
        /// <returns>Task of ApiResponse (InvitationLinkWrapper)</returns>
        public async Task<ApiResponse<InvitationLinkWrapper>> GetInvitationLinkByEmployeeTypeWithHttpInfoAsync(EmployeeType employeeType, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("employeeType", ClientUtils.ParameterToString(employeeType)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<InvitationLinkWrapper>("/api/2.0/portal/users/invitationlink/{employeeType}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetInvitationLinkByEmployeeType", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>Int64Wrapper</returns>
        public Int64Wrapper GetPortalUsersCount()
        {
            var localVarResponse = GetPortalUsersCountWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>ApiResponse of Int64Wrapper</returns>
        public ApiResponse<Int64Wrapper> GetPortalUsersCountWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<Int64Wrapper>("/api/2.0/portal/userscount", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalUsersCount", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>Task of Int64Wrapper</returns>
        public async Task<Int64Wrapper> GetPortalUsersCountAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalUsersCountWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a number of portal users
        /// </summary>
        /// <remarks>
        /// Returns how many accounts this portal currently has in the active state, whatever their role, so a client can  show the seat usage next to the allowance. Accounts that were invited but have not joined yet and accounts  that were disabled or removed are not counted. The caller needs the portal-settings right and is refused  without it; the call is read-only and idempotent, and the number moves as soon as an account joins, is  disabled or is deleted. The answer is a plain number, not an object. Compare it with `countUser` and  `countPaidUser` from `GET api/2.0/portal/quota` to see how much of the allowance is left, and with  `GET api/2.0/portal/quota/right` for the smallest quota that would still hold everyone. When the accounts  themselves are needed, and not only how many there are, list them with the People API instead - this operation  cannot filter by role, group or status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-users-count/">REST API Reference for GetPortalUsersCount Operation</seealso>
        /// <returns>Task of ApiResponse (Int64Wrapper)</returns>
        public async Task<ApiResponse<Int64Wrapper>> GetPortalUsersCountWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Int64Wrapper>("/api/2.0/portal/userscount", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalUsersCount", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>UserInfoWrapper</returns>
        public UserInfoWrapper GetUserById(Guid userID)
        {
            var localVarResponse = GetUserByIdWithHttpInfo(userID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>ApiResponse of UserInfoWrapper</returns>
        public ApiResponse<UserInfoWrapper> GetUserByIdWithHttpInfo(Guid userID)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userID", ClientUtils.ParameterToString(userID)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<UserInfoWrapper>("/api/2.0/portal/users/{userID}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserById", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>Task of UserInfoWrapper</returns>
        public async Task<UserInfoWrapper> GetUserByIdAsync(Guid userID, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserByIdWithHttpInfoAsync(userID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a portal user
        /// </summary>
        /// <remarks>
        /// Returns one user of this portal, addressed by ID, in the shape the portal stores the account: display name,  e-mail, contacts, role and status flags, and the dates of the profile. Nothing has to be called first, and the  call is read-only and idempotent. Who may be read is decided per pair of accounts: a caller always reads their  own profile, a DocSpace administrator reads anyone, a room administrator reads anyone except a guest they have  no relation with, and a user or a guest reads nobody but themselves - a pair that is not allowed is refused.  An ID that belongs to no account of this portal and an ID of a system account are both answered as not found,  so a 404 does not tell the two apart. `userID` in the path has to be a GUID; the calling user's own profile is  easier to fetch with `GET api/2.0/people/@self`. This operation hands back the internal user record - use  `GET api/2.0/people/{userid}` for the same user in the People format, with the group, quota and access  information a client usually needs.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userID">The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. An ID belonging to  no account of this portal and an ID of an internal system account are both answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-by-id/">REST API Reference for GetUserById Operation</seealso>
        /// <returns>Task of ApiResponse (UserInfoWrapper)</returns>
        public async Task<ApiResponse<UserInfoWrapper>> GetUserByIdWithHttpInfoAsync(Guid userID, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userID", ClientUtils.ParameterToString(userID)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<UserInfoWrapper>("/api/2.0/portal/users/{userID}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserById", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns></returns>
        public void MarkGiftMessageAsRead()
        {
            MarkGiftMessageAsReadWithHttpInfo();
        }

        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MarkGiftMessageAsReadWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/portal/present/mark", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MarkGiftMessageAsRead", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task MarkGiftMessageAsReadAsync(CancellationToken cancellationToken = default)
        {
            await MarkGiftMessageAsReadWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Mark a gift message as read
        /// </summary>
        /// <remarks>
        /// Marks the open-source gift message - the notice a server installation shows about its free edition - as read  for the calling user, so the client stops displaying it. Any signed-in user may call it and nothing has to be  called first. The flag is stored per user, so marking it read for one account leaves it unread for everybody  else on the portal. The call is mutating but idempotent: repeating it changes nothing. It never fails on the  caller's behalf - a storage error is written to the portal log and the operation still answers with a success,  so the answer is no proof that the flag was saved. Nothing is returned in the body, and no operation reads the  flag back or clears it again, which makes the change effectively permanent for that user. It touches only this  one notice: portal-wide announcements and the letters the portal sends are unaffected, and other per-user  settings are stored through the operations under `api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-gift-message-as-read/">REST API Reference for MarkGiftMessageAsRead Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> MarkGiftMessageAsReadWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/portal/present/mark", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MarkGiftMessageAsRead", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns></returns>
        public void SendCongratulations(Guid userid, string key)
        {
            SendCongratulationsWithHttpInfo(userid, key);
        }

        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendCongratulationsWithHttpInfo(Guid userid, string key)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling UsersApi->SendCongratulations");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Userid", userid));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Key", key));


            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/portal/sendcongratulations", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendCongratulations", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task SendCongratulationsAsync(Guid userid, string key, CancellationToken cancellationToken = default)
        {
            await SendCongratulationsWithHttpInfoAsync(userid, key, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Send congratulations
        /// </summary>
        /// <remarks>
        /// Sends the welcome letter that follows the registration of a new portal to the account named by `userid` and  switches on the second authentication factor the installation is configured to require after registration; on  a hosted portal in custom mode the registration data is mailed to the sales address as well. Open to  unauthenticated callers: in place of a token it needs `key`, the confirmation key of the sign-in link the  portal issued for that account, and that key is accepted for one hour after it was created - a wrong, foreign  or expired key answers 403 and sends nothing. Both parameters go in the query string. The call is meant to be  made once, right after registration; it is not idempotent, and every call within that hour sends the letters  again. When the installation asks for SMS or an authenticator app after registration, this call is what  enables that method for the whole portal, unless the new account is an internal test address. Nothing is  returned in the body and there is no operation that reports afterwards whether the letters were delivered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The account the welcome letter is addressed to, by portal user ID. The key in `key` has to have been issued  for this same account, so the pair is what authorises the call.</param>
        /// <param name="key">The confirmation key from the sign-in link the portal issued for that account, which stands in for a token  here. It is accepted for one hour after it was created; a wrong, foreign or expired key answers 403 and sends  nothing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-congratulations/">REST API Reference for SendCongratulations Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> SendCongratulationsWithHttpInfoAsync(Guid userid, string key, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling UsersApi->SendCongratulations");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Userid", userid));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Key", key));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/portal/sendcongratulations", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendCongratulations", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>InvitationLinkWrapper</returns>
        public InvitationLinkWrapper UpdateInvitationLink(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default)
        {
            var localVarResponse = UpdateInvitationLinkWithHttpInfo(invitationLinkUpdateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>ApiResponse of InvitationLinkWrapper</returns>
        public ApiResponse<InvitationLinkWrapper> UpdateInvitationLinkWithHttpInfo(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (invitationLinkUpdateRequestDto != null) localVarRequestOptions.Data = invitationLinkUpdateRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<InvitationLinkWrapper>("/api/2.0/portal/users/invitationlink", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateInvitationLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>Task of InvitationLinkWrapper</returns>
        public async Task<InvitationLinkWrapper> UpdateInvitationLinkAsync(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateInvitationLinkWithHttpInfoAsync(invitationLinkUpdateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an invitation link
        /// </summary>
        /// <remarks>
        /// Changes the deadline and the use limit of an existing invitation link, addressed by its `id`. The role of a  link cannot be changed - delete it and create a link for the other role instead. Inviting members has to be  enabled for the portal (`GET api/2.0/settings/invitationsettings`), the link has to exist, and `maxUseCount`  may not be lower than the number of uses the link already has, which  `GET api/2.0/portal/users/invitationlink/{employeeType}` reports as `currentUseCount`. An `expiration` in the  past is refused; the body is applied as a whole, so omitting `expiration` clears the deadline and omitting  `maxUseCount` removes the use limit. The caller needs the right to add users of the link's role and only the  portal owner may change the DocSpace administrator link. The call is mutating, and repeating it with the same  body leaves the link as it is. The whole link comes back as it now stands, with `url` signed for the calling  account - the URL therefore differs between administrators while the link behind it is the same.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationLinkUpdateRequestDto">The invitation link being changed, with the deadline and use limit it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-link/">REST API Reference for UpdateInvitationLink Operation</seealso>
        /// <returns>Task of ApiResponse (InvitationLinkWrapper)</returns>
        public async Task<ApiResponse<InvitationLinkWrapper>> UpdateInvitationLinkWithHttpInfoAsync(InvitationLinkUpdateRequestDto? invitationLinkUpdateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (invitationLinkUpdateRequestDto != null) localVarRequestOptions.Data = invitationLinkUpdateRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<InvitationLinkWrapper>("/api/2.0/portal/users/invitationlink", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateInvitationLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
