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
namespace DocSpace.API.SDK.Api.People
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper AddMember(MemberRequestDto? memberRequestDto = default);

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> AddMemberWithHttpInfo(MemberRequestDto? memberRequestDto = default);
        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>UserExistsResponseWrapper</returns>
        UserExistsResponseWrapper CheckUserExistsByEmail(string? email = default, string? encemail = default, string? culture = default);

        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>ApiResponse of UserExistsResponseWrapper</returns>
        ApiResponse<UserExistsResponseWrapper> CheckUserExistsByEmailWithHttpInfo(string? email = default, string? encemail = default, string? culture = default);
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper DeleteMember(string userid);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> DeleteMemberWithHttpInfo(string userid);
        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper DeleteProfile();

        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> DeleteProfileWithHttpInfo();
        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetAllProfiles(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetAllProfilesWithHttpInfo(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>TokenDiagnosticsWrapper</returns>
        TokenDiagnosticsWrapper GetClaims();

        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>ApiResponse of TokenDiagnosticsWrapper</returns>
        ApiResponse<TokenDiagnosticsWrapper> GetClaimsWithHttpInfo();
        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper GetProfileByEmail(string? email = default, string? encemail = default, string? culture = default);

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> GetProfileByEmailWithHttpInfo(string? email = default, string? encemail = default, string? culture = default);
        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper GetProfileByUserId(string userid);

        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> GetProfileByUserIdWithHttpInfo(string userid);
        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper GetSelfProfile();

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> GetSelfProfileWithHttpInfo();
        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        EmployeeArrayWrapper InviteUsers(InviteUsersRequestDto? inviteUsersRequestDto = default);

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        ApiResponse<EmployeeArrayWrapper> InviteUsersWithHttpInfo(InviteUsersRequestDto? inviteUsersRequestDto = default);
        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper RemoveUsers(UpdateMembersRequestDto? updateMembersRequestDto = default);

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> RemoveUsersWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default);
        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper ResendUserInvites(UpdateMembersRequestDto? updateMembersRequestDto = default);

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> ResendUserInvitesWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default);
        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper UpdateMember(string userid, UpdateMemberRequestDto updateMemberRequestDto);

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> UpdateMemberWithHttpInfo(string userid, UpdateMemberRequestDto updateMemberRequestDto);
        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper UpdateMemberCulture(string userid, Culture? culture = default);

        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> UpdateMemberCultureWithHttpInfo(string userid, Culture? culture = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> AddMemberAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> AddMemberWithHttpInfoAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>Task of UserExistsResponseWrapper</returns>
        Task<UserExistsResponseWrapper> CheckUserExistsByEmailAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>Task of ApiResponse (UserExistsResponseWrapper)</returns>
        Task<ApiResponse<UserExistsResponseWrapper>> CheckUserExistsByEmailWithHttpInfoAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> DeleteMemberAsync(string userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> DeleteMemberWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> DeleteProfileAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> DeleteProfileWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetAllProfilesAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetAllProfilesWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of TokenDiagnosticsWrapper</returns>
        Task<TokenDiagnosticsWrapper> GetClaimsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of ApiResponse (TokenDiagnosticsWrapper)</returns>
        Task<ApiResponse<TokenDiagnosticsWrapper>> GetClaimsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> GetProfileByEmailAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> GetProfileByEmailWithHttpInfoAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> GetProfileByUserIdAsync(string userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> GetProfileByUserIdWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> GetSelfProfileAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> GetSelfProfileWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        Task<EmployeeArrayWrapper> InviteUsersAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        Task<ApiResponse<EmployeeArrayWrapper>> InviteUsersWithHttpInfoAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> RemoveUsersAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> RemoveUsersWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> ResendUserInvitesAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> ResendUserInvitesWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> UpdateMemberAsync(string userid, UpdateMemberRequestDto updateMemberRequestDto, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberWithHttpInfoAsync(string userid, UpdateMemberRequestDto updateMemberRequestDto, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> UpdateMemberCultureAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberCultureWithHttpInfoAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApi : IProfilesApiSync, IProfilesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProfilesApi : IDisposable, IProfilesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ProfilesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ProfilesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ProfilesApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ProfilesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
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
        public ProfilesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class using a Configuration object.
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
        public ProfilesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProfilesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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

        private string? _fields;

        /// <summary>
        /// Specifies which fields should be included in the API response.
        /// </summary>
        /// <param name="fields">A comma-separated list of field paths to include in the response</param>
        /// <returns></returns>

        public ProfilesApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        
        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper AddMember(MemberRequestDto? memberRequestDto = default)
        {
            var localVarResponse = AddMemberWithHttpInfo(memberRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> AddMemberWithHttpInfo(MemberRequestDto? memberRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (memberRequestDto != null) localVarRequestOptions.Data = memberRequestDto;

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
            var localVarResponse = Client.Post<EmployeeFullWrapper>("/api/2.0/people", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddMember", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> AddMemberAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddMemberWithHttpInfoAsync(memberRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> AddMemberWithHttpInfoAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (memberRequestDto != null) localVarRequestOptions.Data = memberRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<EmployeeFullWrapper>("/api/2.0/people", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddMember", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>UserExistsResponseWrapper</returns>
        public UserExistsResponseWrapper CheckUserExistsByEmail(string? email = default, string? encemail = default, string? culture = default)
        {
            var localVarResponse = CheckUserExistsByEmailWithHttpInfo(email, encemail, culture);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>ApiResponse of UserExistsResponseWrapper</returns>
        public ApiResponse<UserExistsResponseWrapper> CheckUserExistsByEmailWithHttpInfo(string? email = default, string? encemail = default, string? culture = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "email", email));
            }
            if (encemail != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "encemail", encemail));
            }
            if (culture != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "culture", culture));
            }

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
            var localVarResponse = Client.Get<UserExistsResponseWrapper>("/api/2.0/people/exists", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckUserExistsByEmail", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>Task of UserExistsResponseWrapper</returns>
        public async Task<UserExistsResponseWrapper> CheckUserExistsByEmailAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckUserExistsByEmailWithHttpInfoAsync(email, encemail, culture, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check whether an email is taken
        /// </summary>
        /// <remarks>
        /// Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/">REST API Reference for CheckUserExistsByEmail Operation</seealso>
        /// <returns>Task of ApiResponse (UserExistsResponseWrapper)</returns>
        public async Task<ApiResponse<UserExistsResponseWrapper>> CheckUserExistsByEmailWithHttpInfoAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "email", email));
            }
            if (encemail != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "encemail", encemail));
            }
            if (culture != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "culture", culture));
            }

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

            var localVarResponse = await AsynchronousClient.GetAsync<UserExistsResponseWrapper>("/api/2.0/people/exists", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckUserExistsByEmail", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper DeleteMember(string userid)
        {
            var localVarResponse = DeleteMemberWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> DeleteMemberWithHttpInfo(string userid)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->DeleteMember");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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
            var localVarResponse = Client.Delete<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteMember", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> DeleteMemberAsync(string userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteMemberWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> DeleteMemberWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->DeleteMember");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteMember", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper DeleteProfile()
        {
            var localVarResponse = DeleteProfileWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> DeleteProfileWithHttpInfo()
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
            var localVarResponse = Client.Delete<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteProfile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> DeleteProfileAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteProfileWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Close my own profile
        /// </summary>
        /// <remarks>
        /// Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> DeleteProfileWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteProfile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetAllProfiles(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetAllProfilesWithHttpInfo(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetAllProfilesWithHttpInfo(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }

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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllProfiles", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetAllProfilesAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllProfilesWithHttpInfoAsync(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the active profiles
        /// </summary>
        /// <remarks>
        /// Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional)</param>
        /// <param name="startIndex">The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional)</param>
        /// <param name="filterBy">The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional)</param>
        /// <param name="sortBy">What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional)</param>
        /// <param name="sortOrder">The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional)</param>
        /// <param name="filterSeparator">The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional)</param>
        /// <param name="filterValue">The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetAllProfilesWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllProfiles", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>TokenDiagnosticsWrapper</returns>
        public TokenDiagnosticsWrapper GetClaims()
        {
            var localVarResponse = GetClaimsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>ApiResponse of TokenDiagnosticsWrapper</returns>
        public ApiResponse<TokenDiagnosticsWrapper> GetClaimsWithHttpInfo()
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
            var localVarResponse = Client.Get<TokenDiagnosticsWrapper>("/api/2.0/people/tokendiagnostics", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClaims", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of TokenDiagnosticsWrapper</returns>
        public async Task<TokenDiagnosticsWrapper> GetClaimsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClaimsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user claims
        /// </summary>
        /// <remarks>
        /// Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of ApiResponse (TokenDiagnosticsWrapper)</returns>
        public async Task<ApiResponse<TokenDiagnosticsWrapper>> GetClaimsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<TokenDiagnosticsWrapper>("/api/2.0/people/tokendiagnostics", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClaims", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper GetProfileByEmail(string? email = default, string? encemail = default, string? culture = default)
        {
            var localVarResponse = GetProfileByEmailWithHttpInfo(email, encemail, culture);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> GetProfileByEmailWithHttpInfo(string? email = default, string? encemail = default, string? culture = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "email", email));
            }
            if (encemail != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "encemail", encemail));
            }
            if (culture != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "culture", culture));
            }

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
            var localVarResponse = Client.Get<EmployeeFullWrapper>("/api/2.0/people/email", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByEmail", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> GetProfileByEmailAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProfileByEmailWithHttpInfoAsync(email, encemail, culture, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="encemail">The user encrypted email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> GetProfileByEmailWithHttpInfoAsync(string? email = default, string? encemail = default, string? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "email", email));
            }
            if (encemail != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "encemail", encemail));
            }
            if (culture != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "culture", culture));
            }

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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullWrapper>("/api/2.0/people/email", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByEmail", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper GetProfileByUserId(string userid)
        {
            var localVarResponse = GetProfileByUserIdWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> GetProfileByUserIdWithHttpInfo(string userid)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->GetProfileByUserId");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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
            var localVarResponse = Client.Get<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByUserId", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> GetProfileByUserIdAsync(string userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProfileByUserIdWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user ID
        /// </summary>
        /// <remarks>
        /// Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> GetProfileByUserIdWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->GetProfileByUserId");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByUserId", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper GetSelfProfile()
        {
            var localVarResponse = GetSelfProfileWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> GetSelfProfileWithHttpInfo()
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
            var localVarResponse = Client.Get<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSelfProfile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> GetSelfProfileAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSelfProfileWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> GetSelfProfileWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSelfProfile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        public EmployeeArrayWrapper InviteUsers(InviteUsersRequestDto? inviteUsersRequestDto = default)
        {
            var localVarResponse = InviteUsersWithHttpInfo(inviteUsersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        public ApiResponse<EmployeeArrayWrapper> InviteUsersWithHttpInfo(InviteUsersRequestDto? inviteUsersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inviteUsersRequestDto != null) localVarRequestOptions.Data = inviteUsersRequestDto;

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
            var localVarResponse = Client.Post<EmployeeArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InviteUsers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        public async Task<EmployeeArrayWrapper> InviteUsersAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await InviteUsersWithHttpInfoAsync(inviteUsersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeArrayWrapper>> InviteUsersWithHttpInfoAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inviteUsersRequestDto != null) localVarRequestOptions.Data = inviteUsersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<EmployeeArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InviteUsers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper RemoveUsers(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarResponse = RemoveUsersWithHttpInfo(updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> RemoveUsersWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveUsers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> RemoveUsersAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RemoveUsersWithHttpInfoAsync(updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> RemoveUsersWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveUsers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper ResendUserInvites(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarResponse = ResendUserInvitesWithHttpInfo(updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> ResendUserInvitesWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResendUserInvites", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> ResendUserInvitesAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ResendUserInvitesWithHttpInfoAsync(updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> ResendUserInvitesWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResendUserInvites", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper UpdateMember(string userid, UpdateMemberRequestDto updateMemberRequestDto)
        {
            var localVarResponse = UpdateMemberWithHttpInfo(userid, updateMemberRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> UpdateMemberWithHttpInfo(string userid, UpdateMemberRequestDto updateMemberRequestDto)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMember");

            // verify the required parameter 'updateMemberRequestDto' is set
            if (updateMemberRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'updateMemberRequestDto' when calling ProfilesApi->UpdateMember");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (updateMemberRequestDto != null) localVarRequestOptions.Data = updateMemberRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMember", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> UpdateMemberAsync(string userid, UpdateMemberRequestDto updateMemberRequestDto, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateMemberWithHttpInfoAsync(userid, updateMemberRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberWithHttpInfoAsync(string userid, UpdateMemberRequestDto updateMemberRequestDto, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMember");

            // verify the required parameter 'updateMemberRequestDto' is set
            if (updateMemberRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'updateMemberRequestDto' when calling ProfilesApi->UpdateMember");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (updateMemberRequestDto != null) localVarRequestOptions.Data = updateMemberRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMember", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper UpdateMemberCulture(string userid, Culture? culture = default)
        {
            var localVarResponse = UpdateMemberCultureWithHttpInfo(userid, culture);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> UpdateMemberCultureWithHttpInfo(string userid, Culture? culture = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMemberCulture");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (culture != null) localVarRequestOptions.Data = culture;

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
            var localVarResponse = Client.Put<EmployeeFullWrapper>("/api/2.0/people/{userid}/culture", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMemberCulture", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> UpdateMemberCultureAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateMemberCultureWithHttpInfoAsync(userid, culture, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user culture
        /// </summary>
        /// <remarks>
        /// Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture name parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberCultureWithHttpInfoAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMemberCulture");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (culture != null) localVarRequestOptions.Data = culture;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}/culture", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMemberCulture", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
