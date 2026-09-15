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
    /// Which storage provider the portal is pointed at, and the credentials it needs.
    /// </summary>
    [DataContract(Name = "StorageRequestsDto")]
    public partial class StorageRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRequestsDto" /> class.
        /// </summary>
        /// <param name="module">The storage provider to switch to, by the identifier the matching listing operation reports - &#x60;default&#x60; for  the built-in local storage. The provider has to be available on the server, which that listing reports as  &#x60;isSet&#x60;, otherwise the request is refused with 400; sending the module already in use changes nothing. (required).</param>
        /// <param name="props">The credentials the provider expects, as the name and value pairs it defines - a bucket, a region and an  access key for an Amazon S3 storage, for instance. Read the expected names from the entry of that provider in  the listing operation; they differ per provider, so there is no fixed set..</param>
        public StorageRequestsDto(string module = default, List<ItemKeyValuePairStringString> props = default)
        {
            // to ensure "module" is required (not null)
            if (module == null)
            {
                throw new ArgumentNullException("module is a required property for StorageRequestsDto and cannot be null");
            }
            this.Module = module;
            this.Props = props;
        }

        /// <summary>
        /// The storage provider to switch to, by the identifier the matching listing operation reports - &#x60;default&#x60; for  the built-in local storage. The provider has to be available on the server, which that listing reports as  &#x60;isSet&#x60;, otherwise the request is refused with 400; sending the module already in use changes nothing.
        /// </summary>
        /// <example>default</example>
        [DataMember(Name = "module", IsRequired = true, EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// The credentials the provider expects, as the name and value pairs it defines - a bucket, a region and an  access key for an Amazon S3 storage, for instance. Read the expected names from the entry of that provider in  the listing operation; they differ per provider, so there is no fixed set.
        /// </summary>
        /// <example>["item1","item2"]</example>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<ItemKeyValuePairStringString> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageRequestsDto {\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
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
