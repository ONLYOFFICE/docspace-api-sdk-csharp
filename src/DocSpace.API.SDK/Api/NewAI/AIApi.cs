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
namespace DocSpace.API.SDK.Api.NewAI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        NewAiChatEvent NewAiAiApproveToolCall(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest);

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        ApiResponse<NewAiChatEvent> NewAiAiApproveToolCallWithHttpInfo(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest);
        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        NewAiChatEvent NewAiAiDenyToolCall(NewAiAiToolCallData newAiAiToolCallData);

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        ApiResponse<NewAiChatEvent> NewAiAiDenyToolCallWithHttpInfo(NewAiAiToolCallData newAiAiToolCallData);
        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        NewAiChatEvent NewAiAiRegenerateStream(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest);

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        ApiResponse<NewAiChatEvent> NewAiAiRegenerateStreamWithHttpInfo(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest);
        /// <summary>
        /// Send
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        NewAiThreadMessageLike NewAiAiSend(NewAiAiSendRequest newAiAiSendRequest);

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        ApiResponse<NewAiThreadMessageLike> NewAiAiSendWithHttpInfo(NewAiAiSendRequest newAiAiSendRequest);
        /// <summary>
        /// Send custom
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        NewAiThreadMessageLike NewAiAiSendCustom(NewAiAiSendCustomRequest newAiAiSendCustomRequest);

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        ApiResponse<NewAiThreadMessageLike> NewAiAiSendCustomWithHttpInfo(NewAiAiSendCustomRequest newAiAiSendCustomRequest);
        /// <summary>
        /// Send with stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        NewAiChatEvent NewAiAiSendWithStream(NewAiAiSendStreamBody newAiAiSendStreamBody);

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        ApiResponse<NewAiChatEvent> NewAiAiSendWithStreamWithHttpInfo(NewAiAiSendStreamBody newAiAiSendStreamBody);
        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>NewAiOpenAIStreamChunk</returns>
        NewAiOpenAIStreamChunk NewAiAiSendWithStreamOpenAI(NewAiAiSendStreamBody newAiAiSendStreamBody);

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>ApiResponse of NewAiOpenAIStreamChunk</returns>
        ApiResponse<NewAiOpenAIStreamChunk> NewAiAiSendWithStreamOpenAIWithHttpInfo(NewAiAiSendStreamBody newAiAiSendStreamBody);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        Task<NewAiChatEvent> NewAiAiApproveToolCallAsync(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        Task<ApiResponse<NewAiChatEvent>> NewAiAiApproveToolCallWithHttpInfoAsync(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        Task<NewAiChatEvent> NewAiAiDenyToolCallAsync(NewAiAiToolCallData newAiAiToolCallData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        Task<ApiResponse<NewAiChatEvent>> NewAiAiDenyToolCallWithHttpInfoAsync(NewAiAiToolCallData newAiAiToolCallData, CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        Task<NewAiChatEvent> NewAiAiRegenerateStreamAsync(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        Task<ApiResponse<NewAiChatEvent>> NewAiAiRegenerateStreamWithHttpInfoAsync(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        Task<NewAiThreadMessageLike> NewAiAiSendAsync(NewAiAiSendRequest newAiAiSendRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        Task<ApiResponse<NewAiThreadMessageLike>> NewAiAiSendWithHttpInfoAsync(NewAiAiSendRequest newAiAiSendRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        Task<NewAiThreadMessageLike> NewAiAiSendCustomAsync(NewAiAiSendCustomRequest newAiAiSendCustomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        Task<ApiResponse<NewAiThreadMessageLike>> NewAiAiSendCustomWithHttpInfoAsync(NewAiAiSendCustomRequest newAiAiSendCustomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        Task<NewAiChatEvent> NewAiAiSendWithStreamAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        Task<ApiResponse<NewAiChatEvent>> NewAiAiSendWithStreamWithHttpInfoAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of NewAiOpenAIStreamChunk</returns>
        Task<NewAiOpenAIStreamChunk> NewAiAiSendWithStreamOpenAIAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiOpenAIStreamChunk)</returns>
        Task<ApiResponse<NewAiOpenAIStreamChunk>> NewAiAiSendWithStreamOpenAIWithHttpInfoAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApi : IAIApiSync, IAIApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AIApi : IDisposable, IAIApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AIApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AIApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AIApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AIApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
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
        public AIApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class using a Configuration object.
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
        public AIApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AIApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Approve tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        public NewAiChatEvent NewAiAiApproveToolCall(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest)
        {
            var localVarResponse = NewAiAiApproveToolCallWithHttpInfo(newAiAiApproveToolCallRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        public ApiResponse<NewAiChatEvent> NewAiAiApproveToolCallWithHttpInfo(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest)
        {
            // verify the required parameter 'newAiAiApproveToolCallRequest' is set
            if (newAiAiApproveToolCallRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiApproveToolCallRequest' when calling AIApi->NewAiAiApproveToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiApproveToolCallRequest != null) localVarRequestOptions.Data = newAiAiApproveToolCallRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiChatEvent>("/api/2.0/ai/ai/approve-tool-call", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiApproveToolCall", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        public async Task<NewAiChatEvent> NewAiAiApproveToolCallAsync(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiApproveToolCallWithHttpInfoAsync(newAiAiApproveToolCallRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/">REST API Reference for NewAiAiApproveToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        public async Task<ApiResponse<NewAiChatEvent>> NewAiAiApproveToolCallWithHttpInfoAsync(NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiApproveToolCallRequest' is set
            if (newAiAiApproveToolCallRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiApproveToolCallRequest' when calling AIApi->NewAiAiApproveToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiApproveToolCallRequest != null) localVarRequestOptions.Data = newAiAiApproveToolCallRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiChatEvent>("/api/2.0/ai/ai/approve-tool-call", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiApproveToolCall", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        public NewAiChatEvent NewAiAiDenyToolCall(NewAiAiToolCallData newAiAiToolCallData)
        {
            var localVarResponse = NewAiAiDenyToolCallWithHttpInfo(newAiAiToolCallData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        public ApiResponse<NewAiChatEvent> NewAiAiDenyToolCallWithHttpInfo(NewAiAiToolCallData newAiAiToolCallData)
        {
            // verify the required parameter 'newAiAiToolCallData' is set
            if (newAiAiToolCallData == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiToolCallData' when calling AIApi->NewAiAiDenyToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiToolCallData != null) localVarRequestOptions.Data = newAiAiToolCallData;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiChatEvent>("/api/2.0/ai/ai/deny-tool-call", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiDenyToolCall", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        public async Task<NewAiChatEvent> NewAiAiDenyToolCallAsync(NewAiAiToolCallData newAiAiToolCallData, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiDenyToolCallWithHttpInfoAsync(newAiAiToolCallData, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiToolCallData"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/">REST API Reference for NewAiAiDenyToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        public async Task<ApiResponse<NewAiChatEvent>> NewAiAiDenyToolCallWithHttpInfoAsync(NewAiAiToolCallData newAiAiToolCallData, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiToolCallData' is set
            if (newAiAiToolCallData == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiToolCallData' when calling AIApi->NewAiAiDenyToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiToolCallData != null) localVarRequestOptions.Data = newAiAiToolCallData;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiChatEvent>("/api/2.0/ai/ai/deny-tool-call", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiDenyToolCall", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        public NewAiChatEvent NewAiAiRegenerateStream(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest)
        {
            var localVarResponse = NewAiAiRegenerateStreamWithHttpInfo(newAiAiRegenerateStreamRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        public ApiResponse<NewAiChatEvent> NewAiAiRegenerateStreamWithHttpInfo(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest)
        {
            // verify the required parameter 'newAiAiRegenerateStreamRequest' is set
            if (newAiAiRegenerateStreamRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiRegenerateStreamRequest' when calling AIApi->NewAiAiRegenerateStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiRegenerateStreamRequest != null) localVarRequestOptions.Data = newAiAiRegenerateStreamRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiChatEvent>("/api/2.0/ai/ai/regenerate-stream", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiRegenerateStream", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        public async Task<NewAiChatEvent> NewAiAiRegenerateStreamAsync(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiRegenerateStreamWithHttpInfoAsync(newAiAiRegenerateStreamRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/">REST API Reference for NewAiAiRegenerateStream Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        public async Task<ApiResponse<NewAiChatEvent>> NewAiAiRegenerateStreamWithHttpInfoAsync(NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiRegenerateStreamRequest' is set
            if (newAiAiRegenerateStreamRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiRegenerateStreamRequest' when calling AIApi->NewAiAiRegenerateStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiRegenerateStreamRequest != null) localVarRequestOptions.Data = newAiAiRegenerateStreamRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiChatEvent>("/api/2.0/ai/ai/regenerate-stream", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiRegenerateStream", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        public NewAiThreadMessageLike NewAiAiSend(NewAiAiSendRequest newAiAiSendRequest)
        {
            var localVarResponse = NewAiAiSendWithHttpInfo(newAiAiSendRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        public ApiResponse<NewAiThreadMessageLike> NewAiAiSendWithHttpInfo(NewAiAiSendRequest newAiAiSendRequest)
        {
            // verify the required parameter 'newAiAiSendRequest' is set
            if (newAiAiSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendRequest' when calling AIApi->NewAiAiSend");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendRequest != null) localVarRequestOptions.Data = newAiAiSendRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiThreadMessageLike>("/api/2.0/ai/ai/send", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSend", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        public async Task<NewAiThreadMessageLike> NewAiAiSendAsync(NewAiAiSendRequest newAiAiSendRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiSendWithHttpInfoAsync(newAiAiSendRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/">REST API Reference for NewAiAiSend Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        public async Task<ApiResponse<NewAiThreadMessageLike>> NewAiAiSendWithHttpInfoAsync(NewAiAiSendRequest newAiAiSendRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiSendRequest' is set
            if (newAiAiSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendRequest' when calling AIApi->NewAiAiSend");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendRequest != null) localVarRequestOptions.Data = newAiAiSendRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiThreadMessageLike>("/api/2.0/ai/ai/send", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSend", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        public NewAiThreadMessageLike NewAiAiSendCustom(NewAiAiSendCustomRequest newAiAiSendCustomRequest)
        {
            var localVarResponse = NewAiAiSendCustomWithHttpInfo(newAiAiSendCustomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        public ApiResponse<NewAiThreadMessageLike> NewAiAiSendCustomWithHttpInfo(NewAiAiSendCustomRequest newAiAiSendCustomRequest)
        {
            // verify the required parameter 'newAiAiSendCustomRequest' is set
            if (newAiAiSendCustomRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendCustomRequest' when calling AIApi->NewAiAiSendCustom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendCustomRequest != null) localVarRequestOptions.Data = newAiAiSendCustomRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiThreadMessageLike>("/api/2.0/ai/ai/send-custom", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSendCustom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        public async Task<NewAiThreadMessageLike> NewAiAiSendCustomAsync(NewAiAiSendCustomRequest newAiAiSendCustomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiSendCustomWithHttpInfoAsync(newAiAiSendCustomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/">REST API Reference for NewAiAiSendCustom Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        public async Task<ApiResponse<NewAiThreadMessageLike>> NewAiAiSendCustomWithHttpInfoAsync(NewAiAiSendCustomRequest newAiAiSendCustomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiSendCustomRequest' is set
            if (newAiAiSendCustomRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendCustomRequest' when calling AIApi->NewAiAiSendCustom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendCustomRequest != null) localVarRequestOptions.Data = newAiAiSendCustomRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiThreadMessageLike>("/api/2.0/ai/ai/send-custom", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSendCustom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>NewAiChatEvent</returns>
        public NewAiChatEvent NewAiAiSendWithStream(NewAiAiSendStreamBody newAiAiSendStreamBody)
        {
            var localVarResponse = NewAiAiSendWithStreamWithHttpInfo(newAiAiSendStreamBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>ApiResponse of NewAiChatEvent</returns>
        public ApiResponse<NewAiChatEvent> NewAiAiSendWithStreamWithHttpInfo(NewAiAiSendStreamBody newAiAiSendStreamBody)
        {
            // verify the required parameter 'newAiAiSendStreamBody' is set
            if (newAiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendStreamBody' when calling AIApi->NewAiAiSendWithStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendStreamBody != null) localVarRequestOptions.Data = newAiAiSendStreamBody;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiChatEvent>("/api/2.0/ai/ai/send-with-stream", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSendWithStream", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>Task of NewAiChatEvent</returns>
        public async Task<NewAiChatEvent> NewAiAiSendWithStreamAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiSendWithStreamWithHttpInfoAsync(newAiAiSendStreamBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/">REST API Reference for NewAiAiSendWithStream Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiChatEvent)</returns>
        public async Task<ApiResponse<NewAiChatEvent>> NewAiAiSendWithStreamWithHttpInfoAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiSendStreamBody' is set
            if (newAiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendStreamBody' when calling AIApi->NewAiAiSendWithStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendStreamBody != null) localVarRequestOptions.Data = newAiAiSendStreamBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiChatEvent>("/api/2.0/ai/ai/send-with-stream", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSendWithStream", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>NewAiOpenAIStreamChunk</returns>
        public NewAiOpenAIStreamChunk NewAiAiSendWithStreamOpenAI(NewAiAiSendStreamBody newAiAiSendStreamBody)
        {
            var localVarResponse = NewAiAiSendWithStreamOpenAIWithHttpInfo(newAiAiSendStreamBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>ApiResponse of NewAiOpenAIStreamChunk</returns>
        public ApiResponse<NewAiOpenAIStreamChunk> NewAiAiSendWithStreamOpenAIWithHttpInfo(NewAiAiSendStreamBody newAiAiSendStreamBody)
        {
            // verify the required parameter 'newAiAiSendStreamBody' is set
            if (newAiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendStreamBody' when calling AIApi->NewAiAiSendWithStreamOpenAI");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["text/event-stream","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendStreamBody != null) localVarRequestOptions.Data = newAiAiSendStreamBody;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiOpenAIStreamChunk>("/api/2.0/ai/ai/send-with-stream-openai", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSendWithStreamOpenAI", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of NewAiOpenAIStreamChunk</returns>
        public async Task<NewAiOpenAIStreamChunk> NewAiAiSendWithStreamOpenAIAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAiSendWithStreamOpenAIWithHttpInfoAsync(newAiAiSendStreamBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAiSendStreamBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/">REST API Reference for NewAiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiOpenAIStreamChunk)</returns>
        public async Task<ApiResponse<NewAiOpenAIStreamChunk>> NewAiAiSendWithStreamOpenAIWithHttpInfoAsync(NewAiAiSendStreamBody newAiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAiSendStreamBody' is set
            if (newAiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'newAiAiSendStreamBody' when calling AIApi->NewAiAiSendWithStreamOpenAI");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "text/event-stream", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAiSendStreamBody != null) localVarRequestOptions.Data = newAiAiSendStreamBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiOpenAIStreamChunk>("/api/2.0/ai/ai/send-with-stream-openai", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAiSendWithStreamOpenAI", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
