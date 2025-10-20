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
    /// The CSP (Content Security Policy) parameters.
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
        /// <param name="domains">The list of CSP domains. (required).</param>
        /// <param name="header">The CSP header. (required).</param>
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
        /// The list of CSP domains.
        /// </summary>
        /// <value>The list of CSP domains.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "domains", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// The CSP header.
        /// </summary>
        /// <value>The CSP header.</value>
        /*
        <example>some text</example>
        */
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
