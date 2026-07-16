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
    /// Parameters for completing an OAuth connection to an MCP server.
    /// </summary>
    [DataContract(Name = "ConnectServerRequestBody")]
    public partial class ConnectServerRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectServerRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectServerRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectServerRequestBody" /> class.
        /// </summary>
        /// <param name="code">OAuth authorization code received from the provider&#39;s redirect. Used to exchange for access and refresh tokens. (required).</param>
        public ConnectServerRequestBody(string code = default)
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for ConnectServerRequestBody and cannot be null");
            }
            this.Code = code;
        }

        /// <summary>
        /// OAuth authorization code received from the provider&#39;s redirect. Used to exchange for access and refresh tokens.
        /// </summary>
        /// <value>OAuth authorization code received from the provider&#39;s redirect. Used to exchange for access and refresh tokens.</value>
        /*
        <example>abc123def456</example>
        */
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectServerRequestBody {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
