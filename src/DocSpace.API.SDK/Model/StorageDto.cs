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
    /// One third-party storage provider the portal data can be kept in, with the keys it expects.
    /// </summary>
    [DataContract(Name = "StorageDto")]
    public partial class StorageDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDto" /> class.
        /// </summary>
        /// <param name="id">The provider&#39;s key, which is what &#x60;PUT api/2.0/settings/storage&#x60; and its CDN and backup counterparts take  as the storage to switch to. The built-in local storage has no entry of its own: a listing in which  nothing is &#x60;current&#x60; means the data sits locally. (required).</param>
        /// <param name="title">The provider name in the portal language, falling back to &#x60;id&#x60; when this build ships no wording for it. (required).</param>
        /// <param name="properties">The settings the provider expects, each with its key, its localised label and the value the server  currently holds. For the entry marked &#x60;current&#x60; the values come from the portal&#39;s saved storage settings  and for the others from the installation configuration, so a setting nobody has configured comes back with  an empty value rather than being left out..</param>
        /// <param name="current">Whether the portal is using this provider right now. At most one entry of a listing has it set. (required).</param>
        /// <param name="isSet">Whether the provider&#39;s keys are already filled in on the server, so it could be switched to without  sending credentials. It says nothing about whether the credentials still work. (required).</param>
        public StorageDto(string id = default, string title = default, List<AuthKey> properties = default, bool current = default, bool isSet = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for StorageDto and cannot be null");
            }
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for StorageDto and cannot be null");
            }
            this.Title = title;
            this.Current = current;
            this.IsSet = isSet;
            this.Properties = properties;
        }

        /// <summary>
        /// The provider&#39;s key, which is what &#x60;PUT api/2.0/settings/storage&#x60; and its CDN and backup counterparts take  as the storage to switch to. The built-in local storage has no entry of its own: a listing in which  nothing is &#x60;current&#x60; means the data sits locally.
        /// </summary>
        /// <example>s3</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The provider name in the portal language, falling back to &#x60;id&#x60; when this build ships no wording for it.
        /// </summary>
        /// <example>Amazon AWS S3</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The settings the provider expects, each with its key, its localised label and the value the server  currently holds. For the entry marked &#x60;current&#x60; the values come from the portal&#39;s saved storage settings  and for the others from the installation configuration, so a setting nobody has configured comes back with  an empty value rather than being left out.
        /// </summary>
        /// <example>[{"name":"acesskey","value":"AKIAIOSFODNN7EXAMPLE","title":"Access key"}]</example>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public List<AuthKey> Properties { get; set; }

        /// <summary>
        /// Whether the portal is using this provider right now. At most one entry of a listing has it set.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "current", IsRequired = true, EmitDefaultValue = true)]
        public bool Current { get; set; }

        /// <summary>
        /// Whether the provider&#39;s keys are already filled in on the server, so it could be switched to without  sending credentials. It says nothing about whether the credentials still work.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isSet", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  IsSet: ").Append(IsSet).Append("\n");
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
