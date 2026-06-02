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
    /// The authorization key parameters.
    /// </summary>
    [DataContract(Name = "AuthKey")]
    public partial class AuthKey : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKey" /> class.
        /// </summary>
        /// <param name="name">The authorization key name. (required).</param>
        /// <param name="value">The authorization key value. (required).</param>
        /// <param name="title">The authorization key title..</param>
        /// <param name="type">The field type: text, password, select, toggle..</param>
        /// <param name="options">The list of options for select type fields..</param>
        /// <param name="dependsOn">The name of another key this field depends on for visibility..</param>
        /// <param name="dependsOnValue">The value of ASC.Web.Studio.UserControls.Management.AuthKey.DependsOn key that makes this field visible..</param>
        public AuthKey(string name = default, string value = default, string title = default, string type = default, List<string> options = default, string dependsOn = default, string dependsOnValue = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AuthKey and cannot be null");
            }
            this.Name = name;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for AuthKey and cannot be null");
            }
            this.Value = value;
            this.Title = title;
            this.Type = type;
            this.Options = options;
            this.DependsOn = dependsOn;
            this.DependsOnValue = dependsOnValue;
        }

        /// <summary>
        /// The authorization key name.
        /// </summary>
        /// <value>The authorization key name.</value>
        /*
        <example>Auth-Key</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The authorization key value.
        /// </summary>
        /// <value>The authorization key value.</value>
        /*
        <example>abc123xyz456</example>
        */
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The authorization key title.
        /// </summary>
        /// <value>The authorization key title.</value>
        /*
        <example>API key</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The field type: text, password, select, toggle.
        /// </summary>
        /// <value>The field type: text, password, select, toggle.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The list of options for select type fields.
        /// </summary>
        /// <value>The list of options for select type fields.</value>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<string> Options { get; set; }

        /// <summary>
        /// The name of another key this field depends on for visibility.
        /// </summary>
        /// <value>The name of another key this field depends on for visibility.</value>
        [DataMember(Name = "dependsOn", EmitDefaultValue = true)]
        public string DependsOn { get; set; }

        /// <summary>
        /// The value of ASC.Web.Studio.UserControls.Management.AuthKey.DependsOn key that makes this field visible.
        /// </summary>
        /// <value>The value of ASC.Web.Studio.UserControls.Management.AuthKey.DependsOn key that makes this field visible.</value>
        [DataMember(Name = "dependsOnValue", EmitDefaultValue = true)]
        public string DependsOnValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthKey {\n");
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
