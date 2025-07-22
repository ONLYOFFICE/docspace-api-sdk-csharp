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
    /// The account information parameters.
    /// </summary>
    [DataContract(Name = "AccountInfoDto")]
    public partial class AccountInfoDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfoDto" /> class.
        /// </summary>
        /// <param name="provider">The account provider..</param>
        /// <param name="url">The account URL..</param>
        /// <param name="linked">Specifies if an account is linked with other profiles or not..</param>
        public AccountInfoDto(string provider = default, string url = default, bool linked = default)
        {
            this.Provider = provider;
            this.Url = url;
            this.Linked = linked;
        }

        /// <summary>
        /// The account provider.
        /// </summary>
        /// <value>The account provider.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// The account URL.
        /// </summary>
        /// <value>The account URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Specifies if an account is linked with other profiles or not.
        /// </summary>
        /// <value>Specifies if an account is linked with other profiles or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "linked", EmitDefaultValue = true)]
        public bool Linked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfoDto {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Linked: ").Append(Linked).Append("\n");
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
