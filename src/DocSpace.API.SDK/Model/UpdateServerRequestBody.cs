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
    /// Parameters for updating an existing MCP server. All fields are optional — only provided fields will be modified.
    /// </summary>
    [DataContract(Name = "UpdateServerRequestBody")]
    public partial class UpdateServerRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServerRequestBody" /> class.
        /// </summary>
        /// <param name="name">New display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters..</param>
        /// <param name="description">New human-readable description of the server&#39;s purpose. Maximum 255 characters..</param>
        /// <param name="endpoint">New base URL of the MCP server endpoint. If changed, the system will re-verify connectivity before saving..</param>
        /// <param name="headers">New HTTP headers to include with every request. If changed alongside the endpoint, connectivity is re-verified..</param>
        /// <param name="updateIcon">Set to true to update the server icon. When true, the Icon field value (or null to remove) will be applied..</param>
        /// <param name="icon">New Base64-encoded icon image for the server, or null to remove the existing icon. Only applied when UpdateIcon is true..</param>
        public UpdateServerRequestBody(string name = default, string description = default, string endpoint = default, Dictionary<string, string> headers = default, bool updateIcon = default, string icon = default)
        {
            this.Name = name;
            this.Description = description;
            this.Endpoint = endpoint;
            this.Headers = headers;
            this.UpdateIcon = updateIcon;
            this.Icon = icon;
        }

        /// <summary>
        /// New display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters.
        /// </summary>
        /// <value>New display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters.</value>
        /*
        <example>Updated MCP Server</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// New human-readable description of the server&#39;s purpose. Maximum 255 characters.
        /// </summary>
        /// <value>New human-readable description of the server&#39;s purpose. Maximum 255 characters.</value>
        /*
        <example>Updated server description</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// New base URL of the MCP server endpoint. If changed, the system will re-verify connectivity before saving.
        /// </summary>
        /// <value>New base URL of the MCP server endpoint. If changed, the system will re-verify connectivity before saving.</value>
        /*
        <example>https://mcp.example.com/sse</example>
        */
        [DataMember(Name = "endpoint", EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// New HTTP headers to include with every request. If changed alongside the endpoint, connectivity is re-verified.
        /// </summary>
        /// <value>New HTTP headers to include with every request. If changed alongside the endpoint, connectivity is re-verified.</value>
        /*
        <example>{"Authorization":"Bearer token123"}</example>
        */
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Set to true to update the server icon. When true, the Icon field value (or null to remove) will be applied.
        /// </summary>
        /// <value>Set to true to update the server icon. When true, the Icon field value (or null to remove) will be applied.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "updateIcon", EmitDefaultValue = true)]
        public bool UpdateIcon { get; set; }

        /// <summary>
        /// New Base64-encoded icon image for the server, or null to remove the existing icon. Only applied when UpdateIcon is true.
        /// </summary>
        /// <value>New Base64-encoded icon image for the server, or null to remove the existing icon. Only applied when UpdateIcon is true.</value>
        /*
        <example>https://example.com/icon.png</example>
        */
        [DataMember(Name = "icon", EmitDefaultValue = true)]
        public string Icon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerRequestBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  UpdateIcon: ").Append(UpdateIcon).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            yield break;
        }

    }


}
