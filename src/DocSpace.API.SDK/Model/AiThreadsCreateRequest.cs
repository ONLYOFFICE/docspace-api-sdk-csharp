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
    /// AiThreadsCreateRequest
    /// </summary>
    [DataContract(Name = "aiThreadsCreate_request")]
    public partial class AiThreadsCreateRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadsCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThreadsCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadsCreateRequest" /> class.
        /// </summary>
        /// <param name="title">Thread title. (required).</param>
        /// <param name="profileId">Optional profile to bind..</param>
        /// <param name="entityId">Optional entity (room) scope..</param>
        public AiThreadsCreateRequest(string title = default, string profileId = default, string entityId = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AiThreadsCreateRequest and cannot be null");
            }
            this.Title = title;
            this.ProfileId = profileId;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Thread title.
        /// </summary>
        /// <value>Thread title.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Optional profile to bind.
        /// </summary>
        /// <value>Optional profile to bind.</value>
        [DataMember(Name = "profileId", EmitDefaultValue = false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Optional entity (room) scope.
        /// </summary>
        /// <value>Optional entity (room) scope.</value>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiThreadsCreateRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
