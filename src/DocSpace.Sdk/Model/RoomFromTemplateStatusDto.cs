// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The progress parameters of creating a room from the template.
    /// </summary>
    [DataContract(Name = "RoomFromTemplateStatusDto")]
    public partial class RoomFromTemplateStatusDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomFromTemplateStatusDto" /> class.
        /// </summary>
        /// <param name="roomId">The room ID..</param>
        /// <param name="progress">The progress of creating a room from the template..</param>
        /// <param name="error">The error message that is sent when a room is not created successfully from the template..</param>
        /// <param name="isCompleted">Specifies whether the process of creating a room from the template is completed..</param>
        public RoomFromTemplateStatusDto(int roomId = default, double progress = default, string error = default, bool isCompleted = default)
        {
            this.RoomId = roomId;
            this.Progress = progress;
            this.Error = error;
            this.IsCompleted = isCompleted;
        }

        /// <summary>
        /// The room ID.
        /// </summary>
        /// <value>The room ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", EmitDefaultValue = false)]
        public int RoomId { get; set; }

        /// <summary>
        /// The progress of creating a room from the template.
        /// </summary>
        /// <value>The progress of creating a room from the template.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public double Progress { get; set; }

        /// <summary>
        /// The error message that is sent when a room is not created successfully from the template.
        /// </summary>
        /// <value>The error message that is sent when a room is not created successfully from the template.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies whether the process of creating a room from the template is completed.
        /// </summary>
        /// <value>Specifies whether the process of creating a room from the template is completed.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
