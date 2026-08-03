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
    /// Chat conversation metadata. Represents a single chat session (thread).
    /// </summary>
    [DataContract(Name = "AiThread")]
    public partial class AiThread : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThread" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThread() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThread" /> class.
        /// </summary>
        /// <param name="threadId">Unique thread identifier (UUID). (required).</param>
        /// <param name="title">Optional thread title. Auto-generated from the first message if not set..</param>
        /// <param name="lastEditDate">Timestamp (ms since epoch) of the last message in this thread. Used for sorting..</param>
        /// <param name="provider">provider.</param>
        /// <param name="model">model.</param>
        /// <param name="profileId">ID of the profile used for this thread. Links to  {@link  Profile.id } ..</param>
        public AiThread(string threadId = default, string title = default, decimal lastEditDate = default, AiTProvider provider = default, AiModel model = default, string profileId = default)
        {
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new ArgumentNullException("threadId is a required property for AiThread and cannot be null");
            }
            this.ThreadId = threadId;
            this.Title = title;
            this.LastEditDate = lastEditDate;
            this.Provider = provider;
            this.Model = model;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Unique thread identifier (UUID).
        /// </summary>
        /// <value>Unique thread identifier (UUID).</value>
        [DataMember(Name = "threadId", IsRequired = true, EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Optional thread title. Auto-generated from the first message if not set.
        /// </summary>
        /// <value>Optional thread title. Auto-generated from the first message if not set.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Timestamp (ms since epoch) of the last message in this thread. Used for sorting.
        /// </summary>
        /// <value>Timestamp (ms since epoch) of the last message in this thread. Used for sorting.</value>
        [DataMember(Name = "lastEditDate", EmitDefaultValue = false)]
        public decimal LastEditDate { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public AiTProvider Provider { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public AiModel Model { get; set; }

        /// <summary>
        /// ID of the profile used for this thread. Links to  {@link  Profile.id } .
        /// </summary>
        /// <value>ID of the profile used for this thread. Links to  {@link  Profile.id } .</value>
        [DataMember(Name = "profileId", EmitDefaultValue = false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiThread {\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  LastEditDate: ").Append(LastEditDate).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
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
