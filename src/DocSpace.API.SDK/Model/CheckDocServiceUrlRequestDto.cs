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
    /// The ONLYOFFICE Docs connection settings to store and verify.
    /// </summary>
    [DataContract(Name = "CheckDocServiceUrlRequestDto")]
    public partial class CheckDocServiceUrlRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDocServiceUrlRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckDocServiceUrlRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDocServiceUrlRequestDto" /> class.
        /// </summary>
        /// <param name="docServiceUrl">The public address of the Document Server, the one a browser loads the editor from. An empty value drops the  portal&#39;s own setting, so the address configured for the deployment takes over again. A value with no scheme is  stored with &#x60;http://&#x60; prepended, and an absolute address may not carry a query string. (required).</param>
        /// <param name="docServiceUrlInternal">The address the portal itself uses for its server-to-server calls to the Document Server, for deployments  where that traffic stays inside the private network. Left empty, those calls go to the public address instead..</param>
        /// <param name="docServiceUrlPortal">The address of this portal as the Document Server has to call it back on in order to fetch and save a  document. Set it when the Document Server cannot resolve the portal by its public name; left empty, the  portal&#39;s own resolved address is used..</param>
        /// <param name="docServiceSignatureSecret">The shared secret that requests between the portal and the Document Server are signed with; it has to be the  same value the Document Server itself is configured with, otherwise the verification of the new settings  fails. It is write-only: the document service location is reported without it..</param>
        /// <param name="docServiceSignatureHeader">The name of the HTTP header the signature travels in, which has to match the header the Document Server  expects. A secret without a header is not a usable pair and is rejected..</param>
        /// <param name="docServiceSslVerification">Whether the portal validates the TLS certificate of the Document Server. With verification on, a self-signed  certificate breaks the connection; with it off, any certificate is accepted, which is meant for test  deployments only. Omitting the field turns verification on..</param>
        public CheckDocServiceUrlRequestDto(string docServiceUrl = default, string docServiceUrlInternal = default, string docServiceUrlPortal = default, string docServiceSignatureSecret = default, string docServiceSignatureHeader = default, bool? docServiceSslVerification = default)
        {
            // to ensure "docServiceUrl" is required (not null)
            if (docServiceUrl == null)
            {
                throw new ArgumentNullException("docServiceUrl is a required property for CheckDocServiceUrlRequestDto and cannot be null");
            }
            this.DocServiceUrl = docServiceUrl;
            this.DocServiceUrlInternal = docServiceUrlInternal;
            this.DocServiceUrlPortal = docServiceUrlPortal;
            this.DocServiceSignatureSecret = docServiceSignatureSecret;
            this.DocServiceSignatureHeader = docServiceSignatureHeader;
            this.DocServiceSslVerification = docServiceSslVerification;
        }

        /// <summary>
        /// The public address of the Document Server, the one a browser loads the editor from. An empty value drops the  portal&#39;s own setting, so the address configured for the deployment takes over again. A value with no scheme is  stored with &#x60;http://&#x60; prepended, and an absolute address may not carry a query string.
        /// </summary>
        /// <example>https://documentserver.example.com</example>
        [DataMember(Name = "docServiceUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrl { get; set; }

        /// <summary>
        /// The address the portal itself uses for its server-to-server calls to the Document Server, for deployments  where that traffic stays inside the private network. Left empty, those calls go to the public address instead.
        /// </summary>
        /// <example>https://documentserver-internal.example.com</example>
        [DataMember(Name = "docServiceUrlInternal", EmitDefaultValue = true)]
        public string DocServiceUrlInternal { get; set; }

        /// <summary>
        /// The address of this portal as the Document Server has to call it back on in order to fetch and save a  document. Set it when the Document Server cannot resolve the portal by its public name; left empty, the  portal&#39;s own resolved address is used.
        /// </summary>
        /// <example>https://portal.example.com</example>
        [DataMember(Name = "docServiceUrlPortal", EmitDefaultValue = true)]
        public string DocServiceUrlPortal { get; set; }

        /// <summary>
        /// The shared secret that requests between the portal and the Document Server are signed with; it has to be the  same value the Document Server itself is configured with, otherwise the verification of the new settings  fails. It is write-only: the document service location is reported without it.
        /// </summary>
        /// <example>secret-key-123</example>
        [DataMember(Name = "docServiceSignatureSecret", EmitDefaultValue = true)]
        public string DocServiceSignatureSecret { get; set; }

        /// <summary>
        /// The name of the HTTP header the signature travels in, which has to match the header the Document Server  expects. A secret without a header is not a usable pair and is rejected.
        /// </summary>
        /// <example>Authorization</example>
        [DataMember(Name = "docServiceSignatureHeader", EmitDefaultValue = true)]
        public string DocServiceSignatureHeader { get; set; }

        /// <summary>
        /// Whether the portal validates the TLS certificate of the Document Server. With verification on, a self-signed  certificate breaks the connection; with it off, any certificate is accepted, which is meant for test  deployments only. Omitting the field turns verification on.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "docServiceSslVerification", EmitDefaultValue = true)]
        public bool? DocServiceSslVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDocServiceUrlRequestDto {\n");
            sb.Append("  DocServiceUrl: ").Append(DocServiceUrl).Append("\n");
            sb.Append("  DocServiceUrlInternal: ").Append(DocServiceUrlInternal).Append("\n");
            sb.Append("  DocServiceUrlPortal: ").Append(DocServiceUrlPortal).Append("\n");
            sb.Append("  DocServiceSignatureSecret: ").Append(DocServiceSignatureSecret).Append("\n");
            sb.Append("  DocServiceSignatureHeader: ").Append(DocServiceSignatureHeader).Append("\n");
            sb.Append("  DocServiceSslVerification: ").Append(DocServiceSslVerification).Append("\n");
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
