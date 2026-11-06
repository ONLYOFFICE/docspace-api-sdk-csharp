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
    public interface ISkillsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>AiSkillsGenerate200Response</returns>
        AiSkillsGenerate200Response AiSkillsGenerate(AiSkillsGenerateRequest aiSkillsGenerateRequest);

        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>ApiResponse of AiSkillsGenerate200Response</returns>
        ApiResponse<AiSkillsGenerate200Response> AiSkillsGenerateWithHttpInfo(AiSkillsGenerateRequest aiSkillsGenerateRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISkillsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>Task of AiSkillsGenerate200Response</returns>
        Task<AiSkillsGenerate200Response> AiSkillsGenerateAsync(AiSkillsGenerateRequest aiSkillsGenerateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>Task of ApiResponse (AiSkillsGenerate200Response)</returns>
        Task<ApiResponse<AiSkillsGenerate200Response>> AiSkillsGenerateWithHttpInfoAsync(AiSkillsGenerateRequest aiSkillsGenerateRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISkillsApi : ISkillsApiSync, ISkillsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SkillsApi : IDisposable, ISkillsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SkillsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SkillsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SkillsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SkillsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SkillsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SkillsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsApi"/> class.
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
        public SkillsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SkillsApi"/> class using a Configuration object.
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
        public SkillsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SkillsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SkillsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>AiSkillsGenerate200Response</returns>
        public AiSkillsGenerate200Response AiSkillsGenerate(AiSkillsGenerateRequest aiSkillsGenerateRequest)
        {
            var localVarResponse = AiSkillsGenerateWithHttpInfo(aiSkillsGenerateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>ApiResponse of AiSkillsGenerate200Response</returns>
        public ApiResponse<AiSkillsGenerate200Response> AiSkillsGenerateWithHttpInfo(AiSkillsGenerateRequest aiSkillsGenerateRequest)
        {
            // verify the required parameter 'aiSkillsGenerateRequest' is set
            if (aiSkillsGenerateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSkillsGenerateRequest' when calling SkillsApi->AiSkillsGenerate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSkillsGenerateRequest != null) localVarRequestOptions.Data = aiSkillsGenerateRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiSkillsGenerate200Response>("/api/2.0/ai/skills/generate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSkillsGenerate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>Task of AiSkillsGenerate200Response</returns>
        public async Task<AiSkillsGenerate200Response> AiSkillsGenerateAsync(AiSkillsGenerateRequest aiSkillsGenerateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSkillsGenerateWithHttpInfoAsync(aiSkillsGenerateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a skill
        /// </summary>
        /// <remarks>
        /// Writes the text of one skill from a title and the caller's description of the skill they need, for an Instructions room, without saving it: the caller shows the text for review and saves the version the user accepts as `<name>.md` through `POST api/2.0/files/{folderId}/insert`, where the Files service validates the frontmatter. `destId` is the integer id of the Instructions room, checked before the model runs: the caller has to be able to create files in it, and any other folder answers 400. `title` becomes the skill's `name`: it is lower-cased and every run of characters other than letters and digits is folded into one hyphen, so `Sales report` becomes `sales-report`. `description` is a specification of the skill, passed to the model as data, never as an instruction. The model bound to the `Chat` action - the `Default` slot when that action has no profile of its own - runs once, without tools, and writes the description and the body; the frontmatter is then rebuilt here, with the description flattened to one line, stripped of tags and cut to 1 024 characters, so the text as returned always passes the Files service's skill validation. The answer carries the skill's name and the whole file, frontmatter included.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSkillsGenerateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-skills-generate/">REST API Reference for AiSkillsGenerate Operation</seealso>
        /// <returns>Task of ApiResponse (AiSkillsGenerate200Response)</returns>
        public async Task<ApiResponse<AiSkillsGenerate200Response>> AiSkillsGenerateWithHttpInfoAsync(AiSkillsGenerateRequest aiSkillsGenerateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSkillsGenerateRequest' is set
            if (aiSkillsGenerateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSkillsGenerateRequest' when calling SkillsApi->AiSkillsGenerate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSkillsGenerateRequest != null) localVarRequestOptions.Data = aiSkillsGenerateRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiSkillsGenerate200Response>("/api/2.0/ai/skills/generate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSkillsGenerate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
