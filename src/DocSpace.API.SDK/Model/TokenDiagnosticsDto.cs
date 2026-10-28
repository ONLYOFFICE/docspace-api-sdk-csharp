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
    /// What the current token carries, for diagnostics.
    /// </summary>
    [DataContract(Name = "TokenDiagnosticsDto")]
    public partial class TokenDiagnosticsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDiagnosticsDto" /> class.
        /// </summary>
        /// <param name="name">The name of the authenticated identity..</param>
        /// <param name="claims">The claims of the identity, each formatted as type:value..</param>
        public TokenDiagnosticsDto(string name = default, List<string> claims = default)
        {
            this.Name = name;
            this.Claims = claims;
        }

        /// <summary>
        /// The name of the authenticated identity.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The claims of the identity, each formatted as type:value.
        /// </summary>
        /// <example>["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name:user@example.com"]</example>
        [DataMember(Name = "claims", EmitDefaultValue = true)]
        public List<string> Claims { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenDiagnosticsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Claims: ").Append(Claims).Append("\n");
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
