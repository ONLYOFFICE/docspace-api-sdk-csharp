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
    /// The keys to store for one third-party authorization or storage provider.
    /// </summary>
    [DataContract(Name = "SaveAuthKeysRequestDto")]
    public partial class SaveAuthKeysRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAuthKeysRequestDto" /> class.
        /// </summary>
        /// <param name="name">The internal key of the provider, such as &#x60;google&#x60; or &#x60;box&#x60;. Take it from the &#x60;name&#x60; of  &#x60;GET api/2.0/settings/authservice&#x60;..</param>
        /// <param name="title">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="description">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="instruction">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="canSet">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="paid">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        /// <param name="props">The keys of the provider with their new values, by the key names &#x60;GET api/2.0/settings/authservice&#x60; lists in  &#x60;props&#x60;..</param>
        public SaveAuthKeysRequestDto(string name = default, string title = default, string description = default, string instruction = default, bool canSet = default, bool paid = default, List<AuthKeyRequest> props = default)
        {
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.Instruction = instruction;
            this.CanSet = canSet;
            this.Paid = paid;
            this.Props = props;
        }

        /// <summary>
        /// The internal key of the provider, such as &#x60;google&#x60; or &#x60;box&#x60;. Take it from the &#x60;name&#x60; of  &#x60;GET api/2.0/settings/authservice&#x60;.
        /// </summary>
        /// <example>google</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>Google</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>Lets users sign in with a Google account.</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>Create a project in the Google Cloud console and copy its OAuth client ID and secret.</example>
        [DataMember(Name = "instruction", EmitDefaultValue = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canSet", EmitDefaultValue = true)]
        public bool CanSet { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "paid", EmitDefaultValue = true)]
        public bool Paid { get; set; }

        /// <summary>
        /// The keys of the provider with their new values, by the key names &#x60;GET api/2.0/settings/authservice&#x60; lists in  &#x60;props&#x60;.
        /// </summary>
        /// <example>[{"name":"googleClientId","value":"1234567890-abc.apps.googleusercontent.com"}]</example>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<AuthKeyRequest> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveAuthKeysRequestDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  CanSet: ").Append(CanSet).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
