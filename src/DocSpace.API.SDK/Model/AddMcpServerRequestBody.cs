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
    /// Parameters for creating a new custom MCP server.
    /// </summary>
    [DataContract(Name = "AddMcpServerRequestBody")]
    public partial class AddMcpServerRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMcpServerRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddMcpServerRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMcpServerRequestBody" /> class.
        /// </summary>
        /// <param name="name">Unique display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters. (required).</param>
        /// <param name="description">Human-readable description of the server&#39;s purpose and capabilities. Maximum 255 characters. (required).</param>
        /// <param name="endpoint">Base URL of the MCP server endpoint. Must be a valid, reachable URL. The system will verify connectivity during registration. (required).</param>
        /// <param name="headers">Optional HTTP headers to include with every request to the MCP server (e.g., authentication tokens or API keys)..</param>
        /// <param name="icon">Optional Base64-encoded icon image for the server. Used as the visual identifier in the UI..</param>
        public AddMcpServerRequestBody(string name = default, string description = default, string endpoint = default, Dictionary<string, string> headers = default, string icon = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddMcpServerRequestBody and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AddMcpServerRequestBody and cannot be null");
            }
            this.Description = description;
            // to ensure "endpoint" is required (not null)
            if (endpoint == null)
            {
                throw new ArgumentNullException("endpoint is a required property for AddMcpServerRequestBody and cannot be null");
            }
            this.Endpoint = endpoint;
            this.Headers = headers;
            this.Icon = icon;
        }

        /// <summary>
        /// Unique display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters.
        /// </summary>
        /// <value>Unique display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters.</value>
        /*
        <example>my-custom-server</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Human-readable description of the server&#39;s purpose and capabilities. Maximum 255 characters.
        /// </summary>
        /// <value>Human-readable description of the server&#39;s purpose and capabilities. Maximum 255 characters.</value>
        /*
        <example>Custom MCP server for project management tools</example>
        */
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Base URL of the MCP server endpoint. Must be a valid, reachable URL. The system will verify connectivity during registration.
        /// </summary>
        /// <value>Base URL of the MCP server endpoint. Must be a valid, reachable URL. The system will verify connectivity during registration.</value>
        /*
        <example>https://mcp.example.com/sse</example>
        */
        [DataMember(Name = "endpoint", IsRequired = true, EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Optional HTTP headers to include with every request to the MCP server (e.g., authentication tokens or API keys).
        /// </summary>
        /// <value>Optional HTTP headers to include with every request to the MCP server (e.g., authentication tokens or API keys).</value>
        /*
        <example>[{key&#x3D;some text, value&#x3D;some text}]</example>
        */
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Optional Base64-encoded icon image for the server. Used as the visual identifier in the UI.
        /// </summary>
        /// <value>Optional Base64-encoded icon image for the server. Used as the visual identifier in the UI.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddMcpServerRequestBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
