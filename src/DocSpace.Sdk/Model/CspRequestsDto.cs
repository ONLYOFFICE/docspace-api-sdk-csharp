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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for configuring the Content Security Policy (CSP) settings.
    /// </summary>
    [DataContract(Name = "CspRequestsDto")]
    public partial class CspRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CspRequestsDto" /> class.
        /// </summary>
        /// <param name="domains">The collection of allowed domains in the Content Security Policy (CSP)..</param>
        public CspRequestsDto(List<string> domains = default)
        {
            this.Domains = domains;
        }

        /// <summary>
        /// The collection of allowed domains in the Content Security Policy (CSP).
        /// </summary>
        /// <value>The collection of allowed domains in the Content Security Policy (CSP).</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "domains", EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CspRequestsDto {\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
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
