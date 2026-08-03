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
    /// Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if &#x60;threadId&#x60; is given, otherwise create a new one with an auto-generated title derived from &#x60;firstMessage&#x60;.
    /// </summary>
    [DataContract(Name = "NewAiOpenOrCreateInput")]
    public partial class NewAiOpenOrCreateInput : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiOpenOrCreateInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiOpenOrCreateInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiOpenOrCreateInput" /> class.
        /// </summary>
        /// <param name="threadId">threadId.</param>
        /// <param name="profile">profile (required).</param>
        /// <param name="profileId">profileId (required).</param>
        /// <param name="firstMessage">firstMessage (required).</param>
        /// <param name="entityId">Opaque scope token persisted on a freshly created thread. Ignored when &#x60;threadId&#x60; is provided (the existing thread keeps its scope)..</param>
        public NewAiOpenOrCreateInput(string threadId = default, NewAiProfile profile = default, string profileId = default, NewAiThreadMessageLike firstMessage = default, string entityId = default)
        {
            // to ensure "profile" is required (not null)
            if (profile == null)
            {
                throw new ArgumentNullException("profile is a required property for NewAiOpenOrCreateInput and cannot be null");
            }
            this.Profile = profile;
            // to ensure "profileId" is required (not null)
            if (profileId == null)
            {
                throw new ArgumentNullException("profileId is a required property for NewAiOpenOrCreateInput and cannot be null");
            }
            this.ProfileId = profileId;
            // to ensure "firstMessage" is required (not null)
            if (firstMessage == null)
            {
                throw new ArgumentNullException("firstMessage is a required property for NewAiOpenOrCreateInput and cannot be null");
            }
            this.FirstMessage = firstMessage;
            this.ThreadId = threadId;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name = "threadId", EmitDefaultValue = false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", IsRequired = true, EmitDefaultValue = true)]
        public NewAiProfile Profile { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name = "profileId", IsRequired = true, EmitDefaultValue = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets FirstMessage
        /// </summary>
        [DataMember(Name = "firstMessage", IsRequired = true, EmitDefaultValue = true)]
        public NewAiThreadMessageLike FirstMessage { get; set; }

        /// <summary>
        /// Opaque scope token persisted on a freshly created thread. Ignored when &#x60;threadId&#x60; is provided (the existing thread keeps its scope).
        /// </summary>
        /// <value>Opaque scope token persisted on a freshly created thread. Ignored when &#x60;threadId&#x60; is provided (the existing thread keeps its scope).</value>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiOpenOrCreateInput {\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  FirstMessage: ").Append(FirstMessage).Append("\n");
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
