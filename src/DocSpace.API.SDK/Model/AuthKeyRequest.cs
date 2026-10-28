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
    /// One key of a provider and the value to store for it.
    /// </summary>
    [DataContract(Name = "AuthKeyRequest")]
    public partial class AuthKeyRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthKeyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKeyRequest" /> class.
        /// </summary>
        /// <param name="name">The key name, as &#x60;GET api/2.0/settings/authservice&#x60; lists it in &#x60;props&#x60;. (required).</param>
        /// <param name="value">The value to store. An empty string clears the key. (required).</param>
        /// <param name="title">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="type">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="options">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="dependsOn">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="dependsOnValue">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        public AuthKeyRequest(string name = default, string value = default, string title = default, string type = default, List<string> options = default, string dependsOn = default, string dependsOnValue = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AuthKeyRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for AuthKeyRequest and cannot be null");
            }
            this.Value = value;
            this.Title = title;
            this.Type = type;
            this.Options = options;
            this.DependsOn = dependsOn;
            this.DependsOnValue = dependsOnValue;
        }

        /// <summary>
        /// The key name, as &#x60;GET api/2.0/settings/authservice&#x60; lists it in &#x60;props&#x60;.
        /// </summary>
        /// <example>googleClientId</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The value to store. An empty string clears the key.
        /// </summary>
        /// <example>1234567890-abc.apps.googleusercontent.com</example>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>Client ID</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>text</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>["s3","gcs"]</example>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<string> Options { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>storageType</example>
        [DataMember(Name = "dependsOn", EmitDefaultValue = true)]
        public string DependsOn { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>s3</example>
        [DataMember(Name = "dependsOnValue", EmitDefaultValue = true)]
        public string DependsOnValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthKeyRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
            sb.Append("  DependsOnValue: ").Append(DependsOnValue).Append("\n");
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
            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 4000.", new [] { "Value" });
            }

            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 0.", new [] { "Value" });
            }

            yield break;
        }

    }


}
