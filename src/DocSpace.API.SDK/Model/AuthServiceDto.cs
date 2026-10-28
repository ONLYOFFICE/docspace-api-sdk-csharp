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
    /// One third-party authorization or storage provider and the keys the portal connects to it with.
    /// </summary>
    [DataContract(Name = "AuthServiceDto")]
    public partial class AuthServiceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthServiceDto" /> class.
        /// </summary>
        /// <param name="name">The internal key of the provider, such as &#x60;google&#x60; or &#x60;box&#x60;. It is the &#x60;name&#x60; that  &#x60;POST api/2.0/settings/authservice&#x60; takes to select the provider..</param>
        /// <param name="title">The provider name as it is shown in the interface..</param>
        /// <param name="description">A sentence about what connecting the provider gives the portal, shown next to it in the interface..</param>
        /// <param name="instruction">The steps an administrator has to take on the provider side to obtain the keys, shown in the interface..</param>
        /// <param name="canSet">Whether this provider accepts keys through the API at all. A provider whose keys are fixed by the  installation reports &#x60;false&#x60;, and saving keys for it is refused..</param>
        /// <param name="paid">Whether the provider is a paid option. A paid one can only be connected while the portal plan includes  third-party storage or the installation is licensed as self-hosted..</param>
        /// <param name="props">The keys the provider defines, with the values last saved and how the settings form shows each of them.  It is &#x60;null&#x60; for a provider that forbids changes (&#x60;canSet&#x60; is &#x60;false&#x60;): its keys are not read at all..</param>
        public AuthServiceDto(string name = default, string title = default, string description = default, string instruction = default, bool canSet = default, bool paid = default, List<AuthKeyDto> props = default)
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
        /// The internal key of the provider, such as &#x60;google&#x60; or &#x60;box&#x60;. It is the &#x60;name&#x60; that  &#x60;POST api/2.0/settings/authservice&#x60; takes to select the provider.
        /// </summary>
        /// <example>google</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The provider name as it is shown in the interface.
        /// </summary>
        /// <example>Google</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// A sentence about what connecting the provider gives the portal, shown next to it in the interface.
        /// </summary>
        /// <example>Google OAuth authentication</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The steps an administrator has to take on the provider side to obtain the keys, shown in the interface.
        /// </summary>
        /// <example>Configure your Google OAuth credentials</example>
        [DataMember(Name = "instruction", EmitDefaultValue = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Whether this provider accepts keys through the API at all. A provider whose keys are fixed by the  installation reports &#x60;false&#x60;, and saving keys for it is refused.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canSet", EmitDefaultValue = true)]
        public bool CanSet { get; set; }

        /// <summary>
        /// Whether the provider is a paid option. A paid one can only be connected while the portal plan includes  third-party storage or the installation is licensed as self-hosted.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "paid", EmitDefaultValue = true)]
        public bool Paid { get; set; }

        /// <summary>
        /// The keys the provider defines, with the values last saved and how the settings form shows each of them.  It is &#x60;null&#x60; for a provider that forbids changes (&#x60;canSet&#x60; is &#x60;false&#x60;): its keys are not read at all.
        /// </summary>
        /// <example>[{"name":"googleClientId","value":"1234567890-abc.apps.googleusercontent.com","title":"Client ID","type":"text"}]</example>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<AuthKeyDto> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthServiceDto {\n");
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
