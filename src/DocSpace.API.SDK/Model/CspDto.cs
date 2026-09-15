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
    /// The Content Security Policy of the portal: the domains an administrator allowed, and the header built from them.
    /// </summary>
    [DataContract(Name = "CspDto")]
    public partial class CspDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CspDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CspDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CspDto" /> class.
        /// </summary>
        /// <param name="domains">The external hosts an administrator has allowed, each in the form it was saved in - a bare host, a host  with a scheme, or a wildcard such as &#x60;*.example.com&#x60;. An empty list means nobody has added one, not that  the portal serves no policy. (required).</param>
        /// <param name="header">The complete policy value the portal sends to browsers, assembled from &#x60;domains&#x60; together with the  portal&#39;s own sources and the integrations it has switched on. It is therefore wider than &#x60;domains&#x60; alone,  and is filled in even while that list is empty. (required).</param>
        public CspDto(List<string> domains = default, string header = default)
        {
            // to ensure "domains" is required (not null)
            if (domains == null)
            {
                throw new ArgumentNullException("domains is a required property for CspDto and cannot be null");
            }
            this.Domains = domains;
            // to ensure "header" is required (not null)
            if (header == null)
            {
                throw new ArgumentNullException("header is a required property for CspDto and cannot be null");
            }
            this.Header = header;
        }

        /// <summary>
        /// The external hosts an administrator has allowed, each in the form it was saved in - a bare host, a host  with a scheme, or a wildcard such as &#x60;*.example.com&#x60;. An empty list means nobody has added one, not that  the portal serves no policy.
        /// </summary>
        /// <example>["https://example.com","https://cdn.example.com"]</example>
        [DataMember(Name = "domains", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// The complete policy value the portal sends to browsers, assembled from &#x60;domains&#x60; together with the  portal&#39;s own sources and the integrations it has switched on. It is therefore wider than &#x60;domains&#x60; alone,  and is filled in even while that list is empty.
        /// </summary>
        /// <example>default-src 'self'; script-src 'self' https://example.com</example>
        [DataMember(Name = "header", IsRequired = true, EmitDefaultValue = true)]
        public string Header { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CspDto {\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
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
