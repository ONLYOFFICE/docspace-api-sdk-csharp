// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authenticate a user
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        AuthenticationTokenWrapper AuthenticateMe(AuthRequestsDto? authRequestsDto = default);

        /// <summary>
        /// Authenticate a user
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        ApiResponse<AuthenticationTokenWrapper> AuthenticateMeWithHttpInfo(AuthRequestsDto? authRequestsDto = default);
        /// <summary>
        /// Authenticate a user by code
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS or two-factor authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        AuthenticationTokenWrapper AuthenticateMeFromBodyWithCode(string code, AuthRequestsDto? authRequestsDto = default);

        /// <summary>
        /// Authenticate a user by code
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS or two-factor authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        ApiResponse<AuthenticationTokenWrapper> AuthenticateMeFromBodyWithCodeWithHttpInfo(string code, AuthRequestsDto? authRequestsDto = default);
        /// <summary>
        /// Open confirmation email URL
        /// </summary>
        /// <remarks>
        /// Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>ConfirmWrapper</returns>
        ConfirmWrapper CheckConfirm(EmailValidationKeyModel? emailValidationKeyModel = default);

        /// <summary>
        /// Open confirmation email URL
        /// </summary>
        /// <remarks>
        /// Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>ApiResponse of ConfirmWrapper</returns>
        ApiResponse<ConfirmWrapper> CheckConfirmWithHttpInfo(EmailValidationKeyModel? emailValidationKeyModel = default);
        /// <summary>
        /// Check authentication
        /// </summary>
        /// <remarks>
        /// Checks if the current user is authenticated or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper GetIsAuthentificated();

        /// <summary>
        /// Check authentication
        /// </summary>
        /// <remarks>
        /// Checks if the current user is authenticated or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> GetIsAuthentificatedWithHttpInfo();
        /// <summary>
        /// Log out
        /// </summary>
        /// <remarks>
        /// Logs out of the current user account.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper Logout();

        /// <summary>
        /// Log out
        /// </summary>
        /// <remarks>
        /// Logs out of the current user account.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> LogoutWithHttpInfo();
        /// <summary>
        /// Set a mobile phone
        /// </summary>
        /// <remarks>
        /// Sets a mobile phone for the current user.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        AuthenticationTokenWrapper SaveMobilePhone(MobileRequestsDto? mobileRequestsDto = default);

        /// <summary>
        /// Set a mobile phone
        /// </summary>
        /// <remarks>
        /// Sets a mobile phone for the current user.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        ApiResponse<AuthenticationTokenWrapper> SaveMobilePhoneWithHttpInfo(MobileRequestsDto? mobileRequestsDto = default);
        /// <summary>
        /// Send SMS code
        /// </summary>
        /// <remarks>
        /// Sends SMS with an authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        AuthenticationTokenWrapper SendSmsCode(AuthRequestsDto? authRequestsDto = default);

        /// <summary>
        /// Send SMS code
        /// </summary>
        /// <remarks>
        /// Sends SMS with an authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        ApiResponse<AuthenticationTokenWrapper> SendSmsCodeWithHttpInfo(AuthRequestsDto? authRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Authenticate a user
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        System.Threading.Tasks.Task<AuthenticationTokenWrapper> AuthenticateMeAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Authenticate a user
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> AuthenticateMeWithHttpInfoAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authenticate a user by code
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS or two-factor authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        System.Threading.Tasks.Task<AuthenticationTokenWrapper> AuthenticateMeFromBodyWithCodeAsync(string code, AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Authenticate a user by code
        /// </summary>
        /// <remarks>
        /// Authenticates the current user by SMS or two-factor authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> AuthenticateMeFromBodyWithCodeWithHttpInfoAsync(string code, AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Open confirmation email URL
        /// </summary>
        /// <remarks>
        /// Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>Task of ConfirmWrapper</returns>
        System.Threading.Tasks.Task<ConfirmWrapper> CheckConfirmAsync(EmailValidationKeyModel? emailValidationKeyModel = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Open confirmation email URL
        /// </summary>
        /// <remarks>
        /// Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>Task of ApiResponse (ConfirmWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfirmWrapper>> CheckConfirmWithHttpInfoAsync(EmailValidationKeyModel? emailValidationKeyModel = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check authentication
        /// </summary>
        /// <remarks>
        /// Checks if the current user is authenticated or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> GetIsAuthentificatedAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check authentication
        /// </summary>
        /// <remarks>
        /// Checks if the current user is authenticated or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> GetIsAuthentificatedWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log out
        /// </summary>
        /// <remarks>
        /// Logs out of the current user account.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> LogoutAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Log out
        /// </summary>
        /// <remarks>
        /// Logs out of the current user account.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> LogoutWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a mobile phone
        /// </summary>
        /// <remarks>
        /// Sets a mobile phone for the current user.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        System.Threading.Tasks.Task<AuthenticationTokenWrapper> SaveMobilePhoneAsync(MobileRequestsDto? mobileRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a mobile phone
        /// </summary>
        /// <remarks>
        /// Sets a mobile phone for the current user.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> SaveMobilePhoneWithHttpInfoAsync(MobileRequestsDto? mobileRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send SMS code
        /// </summary>
        /// <remarks>
        /// Sends SMS with an authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        System.Threading.Tasks.Task<AuthenticationTokenWrapper> SendSmsCodeAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Send SMS code
        /// </summary>
        /// <remarks>
        /// Sends SMS with an authentication code.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> SendSmsCodeWithHttpInfoAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IAuthenticationApiSync, IAuthenticationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationApi : IDisposable, IAuthenticationApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AuthenticationApi(string basePath)
        {
            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AuthenticationApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
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
        public AuthenticationApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class using a Configuration object.
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
        public AuthenticationApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AuthenticationApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient.Dispose();
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
            return this.Configuration.BasePath;
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
        /// Authenticate a user Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        public AuthenticationTokenWrapper AuthenticateMe(AuthRequestsDto? authRequestsDto = default)
        {
            var localVarResponse = AuthenticateMeWithHttpInfo(authRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate a user Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        public ApiResponse<AuthenticationTokenWrapper> AuthenticateMeWithHttpInfo(AuthRequestsDto? authRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (authRequestsDto != null) localVarRequestOptions.Data = authRequestsDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<AuthenticationTokenWrapper>("/api/2.0/authentication", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AuthenticateMe", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authenticate a user Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        public async System.Threading.Tasks.Task<AuthenticationTokenWrapper> AuthenticateMeAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AuthenticationTokenWrapper> localVarResponse = await AuthenticateMeWithHttpInfoAsync(authRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate a user Authenticates the current user by SMS, authenticator app, or without two-factor authentication.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me/">REST API Reference for AuthenticateMe Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> AuthenticateMeWithHttpInfoAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (authRequestsDto != null) localVarRequestOptions.Data = authRequestsDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AuthenticationTokenWrapper>("/api/2.0/authentication", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AuthenticateMe", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authenticate a user by code Authenticates the current user by SMS or two-factor authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        public AuthenticationTokenWrapper AuthenticateMeFromBodyWithCode(string code, AuthRequestsDto? authRequestsDto = default)
        {
            var localVarResponse = AuthenticateMeFromBodyWithCodeWithHttpInfo(code, authRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate a user by code Authenticates the current user by SMS or two-factor authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        public ApiResponse<AuthenticationTokenWrapper> AuthenticateMeFromBodyWithCodeWithHttpInfo(string code, AuthRequestsDto? authRequestsDto = default)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling AuthenticationApi->AuthenticateMeFromBodyWithCode");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("code", ClientUtils.ParameterToString(code)); // path parameter
            if (authRequestsDto != null) localVarRequestOptions.Data = authRequestsDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<AuthenticationTokenWrapper>("/api/2.0/authentication/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AuthenticateMeFromBodyWithCode", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authenticate a user by code Authenticates the current user by SMS or two-factor authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        public async System.Threading.Tasks.Task<AuthenticationTokenWrapper> AuthenticateMeFromBodyWithCodeAsync(string code, AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AuthenticationTokenWrapper> localVarResponse = await AuthenticateMeFromBodyWithCodeWithHttpInfoAsync(code, authRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate a user by code Authenticates the current user by SMS or two-factor authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authenticate-me-from-body-with-code/">REST API Reference for AuthenticateMeFromBodyWithCode Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> AuthenticateMeFromBodyWithCodeWithHttpInfoAsync(string code, AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling AuthenticationApi->AuthenticateMeFromBodyWithCode");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("code", ClientUtils.ParameterToString(code)); // path parameter
            if (authRequestsDto != null) localVarRequestOptions.Data = authRequestsDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AuthenticationTokenWrapper>("/api/2.0/authentication/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AuthenticateMeFromBodyWithCode", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open confirmation email URL Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>ConfirmWrapper</returns>
        public ConfirmWrapper CheckConfirm(EmailValidationKeyModel? emailValidationKeyModel = default)
        {
            var localVarResponse = CheckConfirmWithHttpInfo(emailValidationKeyModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open confirmation email URL Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>ApiResponse of ConfirmWrapper</returns>
        public ApiResponse<ConfirmWrapper> CheckConfirmWithHttpInfo(EmailValidationKeyModel? emailValidationKeyModel = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (emailValidationKeyModel != null) localVarRequestOptions.Data = emailValidationKeyModel;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ConfirmWrapper>("/api/2.0/authentication/confirm", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckConfirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open confirmation email URL Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>Task of ConfirmWrapper</returns>
        public async System.Threading.Tasks.Task<ConfirmWrapper> CheckConfirmAsync(EmailValidationKeyModel? emailValidationKeyModel = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ConfirmWrapper> localVarResponse = await CheckConfirmWithHttpInfoAsync(emailValidationKeyModel, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open confirmation email URL Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailValidationKeyModel">The confirmation email parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-confirm/">REST API Reference for CheckConfirm Operation</seealso>
        /// <returns>Task of ApiResponse (ConfirmWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfirmWrapper>> CheckConfirmWithHttpInfoAsync(EmailValidationKeyModel? emailValidationKeyModel = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (emailValidationKeyModel != null) localVarRequestOptions.Data = emailValidationKeyModel;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ConfirmWrapper>("/api/2.0/authentication/confirm", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckConfirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check authentication Checks if the current user is authenticated or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper GetIsAuthentificated()
        {
            var localVarResponse = GetIsAuthentificatedWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check authentication Checks if the current user is authenticated or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> GetIsAuthentificatedWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<BooleanWrapper>("/api/2.0/authentication", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetIsAuthentificated", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check authentication Checks if the current user is authenticated or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> GetIsAuthentificatedAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await GetIsAuthentificatedWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check authentication Checks if the current user is authenticated or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-authentificated/">REST API Reference for GetIsAuthentificated Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> GetIsAuthentificatedWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/authentication", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetIsAuthentificated", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Log out Logs out of the current user account.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper Logout()
        {
            var localVarResponse = LogoutWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Log out Logs out of the current user account.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> LogoutWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Post<StringWrapper>("/api/2.0/authentication/logout", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("Logout", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Log out Logs out of the current user account.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> LogoutAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await LogoutWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Log out Logs out of the current user account.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/logout/">REST API Reference for Logout Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> LogoutWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/authentication/logout", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("Logout", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set a mobile phone Sets a mobile phone for the current user.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        public AuthenticationTokenWrapper SaveMobilePhone(MobileRequestsDto? mobileRequestsDto = default)
        {
            var localVarResponse = SaveMobilePhoneWithHttpInfo(mobileRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set a mobile phone Sets a mobile phone for the current user.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        public ApiResponse<AuthenticationTokenWrapper> SaveMobilePhoneWithHttpInfo(MobileRequestsDto? mobileRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (mobileRequestsDto != null) localVarRequestOptions.Data = mobileRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<AuthenticationTokenWrapper>("/api/2.0/authentication/setphone", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveMobilePhone", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set a mobile phone Sets a mobile phone for the current user.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        public async System.Threading.Tasks.Task<AuthenticationTokenWrapper> SaveMobilePhoneAsync(MobileRequestsDto? mobileRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AuthenticationTokenWrapper> localVarResponse = await SaveMobilePhoneWithHttpInfoAsync(mobileRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set a mobile phone Sets a mobile phone for the current user.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileRequestsDto">The parameters required for the mobile phone verification. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mobile-phone/">REST API Reference for SaveMobilePhone Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> SaveMobilePhoneWithHttpInfoAsync(MobileRequestsDto? mobileRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (mobileRequestsDto != null) localVarRequestOptions.Data = mobileRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AuthenticationTokenWrapper>("/api/2.0/authentication/setphone", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveMobilePhone", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send SMS code Sends SMS with an authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>AuthenticationTokenWrapper</returns>
        public AuthenticationTokenWrapper SendSmsCode(AuthRequestsDto? authRequestsDto = default)
        {
            var localVarResponse = SendSmsCodeWithHttpInfo(authRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send SMS code Sends SMS with an authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>ApiResponse of AuthenticationTokenWrapper</returns>
        public ApiResponse<AuthenticationTokenWrapper> SendSmsCodeWithHttpInfo(AuthRequestsDto? authRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (authRequestsDto != null) localVarRequestOptions.Data = authRequestsDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<AuthenticationTokenWrapper>("/api/2.0/authentication/sendsms", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SendSmsCode", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send SMS code Sends SMS with an authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>Task of AuthenticationTokenWrapper</returns>
        public async System.Threading.Tasks.Task<AuthenticationTokenWrapper> SendSmsCodeAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AuthenticationTokenWrapper> localVarResponse = await SendSmsCodeWithHttpInfoAsync(authRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send SMS code Sends SMS with an authentication code.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequestsDto">The parameters required for the user authentication requests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-sms-code/">REST API Reference for SendSmsCode Operation</seealso>
        /// <returns>Task of ApiResponse (AuthenticationTokenWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenWrapper>> SendSmsCodeWithHttpInfoAsync(AuthRequestsDto? authRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (authRequestsDto != null) localVarRequestOptions.Data = authRequestsDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AuthenticationTokenWrapper>("/api/2.0/authentication/sendsms", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SendSmsCode", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
