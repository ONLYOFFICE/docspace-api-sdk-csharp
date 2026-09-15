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
    /// The progress of the job that creates a room out of a room template.
    /// </summary>
    [DataContract(Name = "RoomFromTemplateStatusDto")]
    public partial class RoomFromTemplateStatusDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomFromTemplateStatusDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomFromTemplateStatusDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomFromTemplateStatusDto" /> class.
        /// </summary>
        /// <param name="roomId">The room the job is creating. It is meaningful once the room exists, which is guaranteed only after  &#x60;isCompleted&#x60; turns true and &#x60;error&#x60; stays empty; until then it carries no usable id. (required).</param>
        /// <param name="progress">How far the job has got. The value climbs while the contents of the template are being copied into the new  room and reaches its maximum at the very end. (required).</param>
        /// <param name="error">Why the job stopped. It is empty while the job runs and after a successful one, and a filled value means that  no room was created, so the request has to be repeated rather than waited out. (required).</param>
        /// <param name="isCompleted">Whether the job has ended. It is set both after a successful creation and after a failure, so it is the flag  to poll for, while &#x60;error&#x60; is what separates the two outcomes. (required).</param>
        public RoomFromTemplateStatusDto(int roomId = default, double progress = default, string error = default, bool isCompleted = default)
        {
            this.RoomId = roomId;
            this.Progress = progress;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for RoomFromTemplateStatusDto and cannot be null");
            }
            this.Error = error;
            this.IsCompleted = isCompleted;
        }

        /// <summary>
        /// The room the job is creating. It is meaningful once the room exists, which is guaranteed only after  &#x60;isCompleted&#x60; turns true and &#x60;error&#x60; stays empty; until then it carries no usable id.
        /// </summary>
        /// <example>456</example>
        [DataMember(Name = "roomId", IsRequired = true, EmitDefaultValue = true)]
        public int RoomId { get; set; }

        /// <summary>
        /// How far the job has got. The value climbs while the contents of the template are being copied into the new  room and reaches its maximum at the very end.
        /// </summary>
        /// <example>50.0</example>
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public double Progress { get; set; }

        /// <summary>
        /// Why the job stopped. It is empty while the job runs and after a successful one, and a filled value means that  no room was created, so the request has to be repeated rather than waited out.
        /// </summary>
        /// <example>Room creation failed</example>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Whether the job has ended. It is set both after a successful creation and after a failure, so it is the flag  to poll for, while &#x60;error&#x60; is what separates the two outcomes.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCompleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomFromTemplateStatusDto {\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
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
