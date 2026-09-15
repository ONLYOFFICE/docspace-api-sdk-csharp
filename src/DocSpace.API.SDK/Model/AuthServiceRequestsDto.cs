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
    [DataContract(Name = "AuthServiceRequestsDto")]
    public partial class AuthServiceRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthServiceRequestsDto" /> class.
        /// </summary>
        /// <param name="name">The provider being configured, by its internal key such as &#x60;google&#x60; or &#x60;box&#x60;. Take it from the &#x60;name&#x60; of  &#x60;GET api/2.0/settings/authservice&#x60;; it is the only field that selects the provider, and a key this  installation does not know is refused the same way a provider that forbids changes is..</param>
        /// <param name="title">The provider name as it is shown in the interface. It is filled in by the portal when the providers are  listed and is ignored when keys are saved..</param>
        /// <param name="description">A sentence about what connecting the provider gives the portal, shown next to it in the interface. It is  filled in by the portal and ignored when keys are saved..</param>
        /// <param name="instruction">The steps an administrator has to take on the provider side to obtain the keys, shown in the interface. It is  filled in by the portal and ignored when keys are saved..</param>
        /// <param name="canSet">Whether this provider accepts keys through the API at all. A provider whose keys are fixed by the  installation reports &#x60;false&#x60;, and saving keys for it is refused; the field is reported by the portal and  ignored on the way in..</param>
        /// <param name="paid">Whether the provider is a paid option. A paid one can only be connected while the portal plan includes  third-party storage or the installation is licensed as self-hosted; the field is reported by the portal and  ignored on the way in..</param>
        /// <param name="props">The credentials the portal authenticates to the provider with, as the name and value pairs the provider  defines. Send the whole set the provider expects: leaving every value empty disconnects it, and a set that  fails the provider validation is cleared rather than stored half-applied. The listing operation reports the  values last saved, and a provider that forbids changes reports none at all..</param>
        public AuthServiceRequestsDto(string name = default, string title = default, string description = default, string instruction = default, bool canSet = default, bool paid = default, List<AuthKey> props = default)
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
        /// The provider being configured, by its internal key such as &#x60;google&#x60; or &#x60;box&#x60;. Take it from the &#x60;name&#x60; of  &#x60;GET api/2.0/settings/authservice&#x60;; it is the only field that selects the provider, and a key this  installation does not know is refused the same way a provider that forbids changes is.
        /// </summary>
        /// <example>google</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The provider name as it is shown in the interface. It is filled in by the portal when the providers are  listed and is ignored when keys are saved.
        /// </summary>
        /// <example>Google</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// A sentence about what connecting the provider gives the portal, shown next to it in the interface. It is  filled in by the portal and ignored when keys are saved.
        /// </summary>
        /// <example>Google OAuth authentication</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The steps an administrator has to take on the provider side to obtain the keys, shown in the interface. It is  filled in by the portal and ignored when keys are saved.
        /// </summary>
        /// <example>Configure your Google OAuth credentials</example>
        [DataMember(Name = "instruction", EmitDefaultValue = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Whether this provider accepts keys through the API at all. A provider whose keys are fixed by the  installation reports &#x60;false&#x60;, and saving keys for it is refused; the field is reported by the portal and  ignored on the way in.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canSet", EmitDefaultValue = true)]
        public bool CanSet { get; set; }

        /// <summary>
        /// Whether the provider is a paid option. A paid one can only be connected while the portal plan includes  third-party storage or the installation is licensed as self-hosted; the field is reported by the portal and  ignored on the way in.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "paid", EmitDefaultValue = true)]
        public bool Paid { get; set; }

        /// <summary>
        /// The credentials the portal authenticates to the provider with, as the name and value pairs the provider  defines. Send the whole set the provider expects: leaving every value empty disconnects it, and a set that  fails the provider validation is cleared rather than stored half-applied. The listing operation reports the  values last saved, and a provider that forbids changes reports none at all.
        /// </summary>
        /// <example>[{"name":"key","value":"value"}]</example>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<AuthKey> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthServiceRequestsDto {\n");
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
