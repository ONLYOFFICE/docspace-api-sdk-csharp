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
    /// UpdateServerRequestBody
    /// </summary>
    [DataContract(Name = "UpdateServerRequestBody")]
    public partial class UpdateServerRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServerRequestBody" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="headers">headers.</param>
        /// <param name="updateIcon">updateIcon.</param>
        /// <param name="icon">icon.</param>
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
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>John Doe</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "endpoint", EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        /*
        <example>[{&quot;key&quot;:&quot;some text&quot;,&quot;value&quot;:&quot;some text&quot;}]</example>
        */
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or Sets UpdateIcon
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "updateIcon", EmitDefaultValue = true)]
        public bool UpdateIcon { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        /*
        <example>some text</example>
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
