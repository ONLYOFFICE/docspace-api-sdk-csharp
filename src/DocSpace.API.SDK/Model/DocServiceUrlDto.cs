// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The document service URL parameters.
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
        /// <param name="version">The version of the document service. (required).</param>
        /// <param name="docServiceUrlApi">The document service URL API. (required).</param>
        /// <param name="docServiceUrl">The document service URL. (required).</param>
        /// <param name="docServicePreloadUrl">The URL used to preload the document service scripts. (required).</param>
        /// <param name="docServiceUrlInternal">The internal document service URL. (required).</param>
        /// <param name="docServicePortalUrl">The document service portal URL. (required).</param>
        /// <param name="docServiceSignatureHeader">The document service signature header. (required).</param>
        /// <param name="docServiceSslVerification">Specifies if the document service SSL verification is enabled. (required).</param>
        /// <param name="isDefault">Specifies if the document service is default. (required).</param>
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
        /// The version of the document service.
        /// </summary>
        /// <value>The version of the document service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The document service URL API.
        /// </summary>
        /// <value>The document service URL API.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrlApi", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrlApi { get; set; }

        /// <summary>
        /// The document service URL.
        /// </summary>
        /// <value>The document service URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrl { get; set; }

        /// <summary>
        /// The URL used to preload the document service scripts.
        /// </summary>
        /// <value>The URL used to preload the document service scripts.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServicePreloadUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServicePreloadUrl { get; set; }

        /// <summary>
        /// The internal document service URL.
        /// </summary>
        /// <value>The internal document service URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrlInternal", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrlInternal { get; set; }

        /// <summary>
        /// The document service portal URL.
        /// </summary>
        /// <value>The document service portal URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServicePortalUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServicePortalUrl { get; set; }

        /// <summary>
        /// The document service signature header.
        /// </summary>
        /// <value>The document service signature header.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceSignatureHeader", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceSignatureHeader { get; set; }

        /// <summary>
        /// Specifies if the document service SSL verification is enabled.
        /// </summary>
        /// <value>Specifies if the document service SSL verification is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "docServiceSslVerification", IsRequired = true, EmitDefaultValue = true)]
        public bool DocServiceSslVerification { get; set; }

        /// <summary>
        /// Specifies if the document service is default.
        /// </summary>
        /// <value>Specifies if the document service is default.</value>
        /*
        <example>true</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
