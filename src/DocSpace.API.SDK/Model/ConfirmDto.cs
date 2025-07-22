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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The confirmation parameters.
    /// </summary>
    [DataContract(Name = "ConfirmDto")]
    public partial class ConfirmDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public ValidationResult? Result { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmDto" /> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="roomId">The confirmation room ID..</param>
        /// <param name="title">The confirmation title..</param>
        public ConfirmDto(ValidationResult? result = default, string roomId = default, string title = default)
        {
            this.Result = result;
            this.RoomId = roomId;
            this.Title = title;
        }

        /// <summary>
        /// The confirmation room ID.
        /// </summary>
        /// <value>The confirmation room ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", EmitDefaultValue = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// The confirmation title.
        /// </summary>
        /// <value>The confirmation title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmDto {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
