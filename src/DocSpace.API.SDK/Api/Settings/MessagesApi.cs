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
namespace DocSpace.API.SDK.Api.Settings
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper EnableAdminMessageSettings(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default);

        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> EnableAdminMessageSettingsWithHttpInfo(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default);
        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SendAdminMail(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default);

        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SendAdminMailWithHttpInfo(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default);
        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SendJoinInviteMail(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default);

        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SendJoinInviteMailWithHttpInfo(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> EnableAdminMessageSettingsAsync(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> EnableAdminMessageSettingsWithHttpInfoAsync(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SendAdminMailAsync(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SendAdminMailWithHttpInfoAsync(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SendJoinInviteMailAsync(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SendJoinInviteMailWithHttpInfoAsync(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi : IMessagesApiSync, IMessagesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessagesApi : IDisposable, IMessagesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public MessagesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public MessagesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="MessagesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public MessagesApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MessagesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
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
        public MessagesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="MessagesApi"/> class using a Configuration object.
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
        public MessagesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MessagesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper EnableAdminMessageSettings(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default)
        {
            var localVarResponse = EnableAdminMessageSettingsWithHttpInfo(turnOnAdminMessageSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> EnableAdminMessageSettingsWithHttpInfo(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (turnOnAdminMessageSettingsRequestDto != null) localVarRequestOptions.Data = turnOnAdminMessageSettingsRequestDto;

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
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/settings/messagesettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EnableAdminMessageSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> EnableAdminMessageSettingsAsync(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await EnableAdminMessageSettingsWithHttpInfoAsync(turnOnAdminMessageSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable or disable administrator messages
        /// </summary>
        /// <remarks>
        /// Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="turnOnAdminMessageSettingsRequestDto">Whether the sign-in page offers the form for writing to the portal administrators. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/">REST API Reference for EnableAdminMessageSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> EnableAdminMessageSettingsWithHttpInfoAsync(TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (turnOnAdminMessageSettingsRequestDto != null) localVarRequestOptions.Data = turnOnAdminMessageSettingsRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/settings/messagesettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EnableAdminMessageSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SendAdminMail(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default)
        {
            var localVarResponse = SendAdminMailWithHttpInfo(adminMessageSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> SendAdminMailWithHttpInfo(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (adminMessageSettingsRequestsDto != null) localVarRequestOptions.Data = adminMessageSettingsRequestsDto;


            // make the HTTP request
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/settings/sendadmmail", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendAdminMail", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> SendAdminMailAsync(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SendAdminMailWithHttpInfoAsync(adminMessageSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send a message to the administrator
        /// </summary>
        /// <remarks>
        /// Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageSettingsRequestsDto">The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/">REST API Reference for SendAdminMail Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> SendAdminMailWithHttpInfoAsync(AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (adminMessageSettingsRequestsDto != null) localVarRequestOptions.Data = adminMessageSettingsRequestsDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/settings/sendadmmail", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendAdminMail", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SendJoinInviteMail(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default)
        {
            var localVarResponse = SendJoinInviteMailWithHttpInfo(adminMessageBaseSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> SendJoinInviteMailWithHttpInfo(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (adminMessageBaseSettingsRequestsDto != null) localVarRequestOptions.Data = adminMessageBaseSettingsRequestsDto;


            // make the HTTP request
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/settings/sendjoininvite", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendJoinInviteMail", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> SendJoinInviteMailAsync(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SendJoinInviteMailWithHttpInfoAsync(adminMessageBaseSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send an invitation email
        /// </summary>
        /// <remarks>
        /// Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="adminMessageBaseSettingsRequestsDto">Who is invited to join the portal, and in which language the invitation is written. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/">REST API Reference for SendJoinInviteMail Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> SendJoinInviteMailWithHttpInfoAsync(AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (adminMessageBaseSettingsRequestsDto != null) localVarRequestOptions.Data = adminMessageBaseSettingsRequestsDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/settings/sendjoininvite", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendJoinInviteMail", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
