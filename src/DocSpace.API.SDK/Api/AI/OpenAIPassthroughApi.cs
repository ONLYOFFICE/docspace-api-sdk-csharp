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
namespace DocSpace.API.SDK.Api.AI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOpenAIPassthroughApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiOpenaiChatCompletions(string profileId, Dictionary<string, Object> requestBody);

        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiOpenaiChatCompletionsWithHttpInfo(string profileId, Dictionary<string, Object> requestBody);
        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiOpenaiImagesGenerations(string profileId, Dictionary<string, Object> requestBody);

        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiOpenaiImagesGenerationsWithHttpInfo(string profileId, Dictionary<string, Object> requestBody);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOpenAIPassthroughApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiOpenaiChatCompletionsAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiOpenaiChatCompletionsWithHttpInfoAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiOpenaiImagesGenerationsAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiOpenaiImagesGenerationsWithHttpInfoAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOpenAIPassthroughApi : IOpenAIPassthroughApiSync, IOpenAIPassthroughApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OpenAIPassthroughApi : IDisposable, IOpenAIPassthroughApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public OpenAIPassthroughApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public OpenAIPassthroughApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OpenAIPassthroughApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public OpenAIPassthroughApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class.
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
        public OpenAIPassthroughApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class using a Configuration object.
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
        public OpenAIPassthroughApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OpenAIPassthroughApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OpenAIPassthroughApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiOpenaiChatCompletions(string profileId, Dictionary<string, Object> requestBody)
        {
            var localVarResponse = AiOpenaiChatCompletionsWithHttpInfo(profileId, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiOpenaiChatCompletionsWithHttpInfo(string profileId, Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling OpenAIPassthroughApi->AiOpenaiChatCompletions");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling OpenAIPassthroughApi->AiOpenaiChatCompletions");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("profileId", ClientUtils.ParameterToString(profileId)); // path parameter
            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request
            var localVarResponse = Client.Post<AiSuccessResponse>("/api/2.0/ai/openai/{profileId}/v1/chat/completions", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiOpenaiChatCompletions", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiOpenaiChatCompletionsAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiOpenaiChatCompletionsWithHttpInfoAsync(profileId, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OpenAI-compatible chat completions proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-chat-completions/">REST API Reference for AiOpenaiChatCompletions Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiOpenaiChatCompletionsWithHttpInfoAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling OpenAIPassthroughApi->AiOpenaiChatCompletions");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling OpenAIPassthroughApi->AiOpenaiChatCompletions");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("profileId", ClientUtils.ParameterToString(profileId)); // path parameter
            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiSuccessResponse>("/api/2.0/ai/openai/{profileId}/v1/chat/completions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiOpenaiChatCompletions", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiOpenaiImagesGenerations(string profileId, Dictionary<string, Object> requestBody)
        {
            var localVarResponse = AiOpenaiImagesGenerationsWithHttpInfo(profileId, requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiOpenaiImagesGenerationsWithHttpInfo(string profileId, Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling OpenAIPassthroughApi->AiOpenaiImagesGenerations");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling OpenAIPassthroughApi->AiOpenaiImagesGenerations");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("profileId", ClientUtils.ParameterToString(profileId)); // path parameter
            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request
            var localVarResponse = Client.Post<AiSuccessResponse>("/api/2.0/ai/openai/{profileId}/v1/images/generations", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiOpenaiImagesGenerations", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiOpenaiImagesGenerationsAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiOpenaiImagesGenerationsWithHttpInfoAsync(profileId, requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OpenAI-compatible image generation proxied to the profile's provider
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-openai-images-generations/">REST API Reference for AiOpenaiImagesGenerations Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiOpenaiImagesGenerationsWithHttpInfoAsync(string profileId, Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling OpenAIPassthroughApi->AiOpenaiImagesGenerations");

            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling OpenAIPassthroughApi->AiOpenaiImagesGenerations");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("profileId", ClientUtils.ParameterToString(profileId)); // path parameter
            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiSuccessResponse>("/api/2.0/ai/openai/{profileId}/v1/images/generations", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiOpenaiImagesGenerations", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
