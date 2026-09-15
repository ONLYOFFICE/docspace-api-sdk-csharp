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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The document service location as this portal has it configured, together with the editor entry points a client  needs in order to open a document.
    /// </summary>
    [DataContract(Name = "DocServiceUrlDto")]
    public partial class DocServiceUrlDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocServiceUrlDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocServiceUrlDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocServiceUrlDto" /> class.
        /// </summary>
        /// <param name="version">The editor version the running Document Server reported. It is filled in only when the version was asked for,  and comes back empty otherwise. When the Document Server does not answer, a fallback version is reported  rather than an error, so a value here is no proof that the server is reachable. (required).</param>
        /// <param name="docServiceUrlApi">The absolute URL of the editor api script that a client has to load before it can open a document. It is  derived from the public Document Server address unless the deployment overrides it separately. (required).</param>
        /// <param name="docServiceUrl">The public Document Server address a browser loads the editor from. Empty means no document server is  configured for this portal, and documents cannot be opened for editing or viewing. (required).</param>
        /// <param name="docServicePreloadUrl">The absolute URL of a page a client may load in advance to warm the editor scripts up. Loading it is optional  and changes nothing on the portal. (required).</param>
        /// <param name="docServiceUrlInternal">The address the portal uses for its own server-to-server calls to the Document Server. When no private-network  address is configured, it repeats the public one. (required).</param>
        /// <param name="docServicePortalUrl">The address the Document Server is told to call this portal back on. Empty means nothing overrides it and the  portal&#39;s own resolved address is used. (required).</param>
        /// <param name="docServiceSignatureHeader">The name of the HTTP header that carries the signature on requests between the portal and the Document Server.  The secret itself is not part of the answer, so this only tells a client whether request signing is set up and  under which header. (required).</param>
        /// <param name="docServiceSslVerification">Whether the portal validates the TLS certificate of the Document Server. False means any certificate is  accepted, which is expected only in a test deployment. (required).</param>
        /// <param name="isDefault">Whether every one of these settings is still the one the deployment ships with. False means at least one of  the addresses, the signature settings or SSL verification has been overridden for this portal. (required).</param>
        public DocServiceUrlDto(string version = default, string docServiceUrlApi = default, string docServiceUrl = default, string docServicePreloadUrl = default, string docServiceUrlInternal = default, string docServicePortalUrl = default, string docServiceSignatureHeader = default, bool docServiceSslVerification = default, bool isDefault = default)
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for DocServiceUrlDto and cannot be null");
            }
            this.@Version = version;
            // to ensure "docServiceUrlApi" is required (not null)
            if (docServiceUrlApi == null)
            {
                throw new ArgumentNullException("docServiceUrlApi is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceUrlApi = docServiceUrlApi;
            // to ensure "docServiceUrl" is required (not null)
            if (docServiceUrl == null)
            {
                throw new ArgumentNullException("docServiceUrl is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceUrl = docServiceUrl;
            // to ensure "docServicePreloadUrl" is required (not null)
            if (docServicePreloadUrl == null)
            {
                throw new ArgumentNullException("docServicePreloadUrl is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServicePreloadUrl = docServicePreloadUrl;
            // to ensure "docServiceUrlInternal" is required (not null)
            if (docServiceUrlInternal == null)
            {
                throw new ArgumentNullException("docServiceUrlInternal is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceUrlInternal = docServiceUrlInternal;
            // to ensure "docServicePortalUrl" is required (not null)
            if (docServicePortalUrl == null)
            {
                throw new ArgumentNullException("docServicePortalUrl is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServicePortalUrl = docServicePortalUrl;
            // to ensure "docServiceSignatureHeader" is required (not null)
            if (docServiceSignatureHeader == null)
            {
                throw new ArgumentNullException("docServiceSignatureHeader is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceSignatureHeader = docServiceSignatureHeader;
            this.DocServiceSslVerification = docServiceSslVerification;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// The editor version the running Document Server reported. It is filled in only when the version was asked for,  and comes back empty otherwise. When the Document Server does not answer, a fallback version is reported  rather than an error, so a value here is no proof that the server is reachable.
        /// </summary>
        /// <example>8.0.1</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The absolute URL of the editor api script that a client has to load before it can open a document. It is  derived from the public Document Server address unless the deployment overrides it separately.
        /// </summary>
        /// <example>https://documentserver.example.com/web-apps/apps/api/documents/api.js</example>
        [DataMember(Name = "docServiceUrlApi", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrlApi { get; set; }

        /// <summary>
        /// The public Document Server address a browser loads the editor from. Empty means no document server is  configured for this portal, and documents cannot be opened for editing or viewing.
        /// </summary>
        /// <example>https://documentserver.example.com/</example>
        [DataMember(Name = "docServiceUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrl { get; set; }

        /// <summary>
        /// The absolute URL of a page a client may load in advance to warm the editor scripts up. Loading it is optional  and changes nothing on the portal.
        /// </summary>
        /// <example>https://documentserver.example.com/web-apps/apps/api/documents/preload.html</example>
        [DataMember(Name = "docServicePreloadUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServicePreloadUrl { get; set; }

        /// <summary>
        /// The address the portal uses for its own server-to-server calls to the Document Server. When no private-network  address is configured, it repeats the public one.
        /// </summary>
        /// <example>http://documentserver-internal.local/</example>
        [DataMember(Name = "docServiceUrlInternal", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrlInternal { get; set; }

        /// <summary>
        /// The address the Document Server is told to call this portal back on. Empty means nothing overrides it and the  portal&#39;s own resolved address is used.
        /// </summary>
        /// <example>https://portal.example.com/</example>
        [DataMember(Name = "docServicePortalUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServicePortalUrl { get; set; }

        /// <summary>
        /// The name of the HTTP header that carries the signature on requests between the portal and the Document Server.  The secret itself is not part of the answer, so this only tells a client whether request signing is set up and  under which header.
        /// </summary>
        /// <example>Authorization</example>
        [DataMember(Name = "docServiceSignatureHeader", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceSignatureHeader { get; set; }

        /// <summary>
        /// Whether the portal validates the TLS certificate of the Document Server. False means any certificate is  accepted, which is expected only in a test deployment.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "docServiceSslVerification", IsRequired = true, EmitDefaultValue = true)]
        public bool DocServiceSslVerification { get; set; }

        /// <summary>
        /// Whether every one of these settings is still the one the deployment ships with. False means at least one of  the addresses, the signature settings or SSL verification has been overridden for this portal.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocServiceUrlDto {\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  DocServiceUrlApi: ").Append(DocServiceUrlApi).Append("\n");
            sb.Append("  DocServiceUrl: ").Append(DocServiceUrl).Append("\n");
            sb.Append("  DocServicePreloadUrl: ").Append(DocServicePreloadUrl).Append("\n");
            sb.Append("  DocServiceUrlInternal: ").Append(DocServiceUrlInternal).Append("\n");
            sb.Append("  DocServicePortalUrl: ").Append(DocServicePortalUrl).Append("\n");
            sb.Append("  DocServiceSignatureHeader: ").Append(DocServiceSignatureHeader).Append("\n");
            sb.Append("  DocServiceSslVerification: ").Append(DocServiceSslVerification).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

    }


}
