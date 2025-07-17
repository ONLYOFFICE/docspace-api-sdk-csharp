/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The room security parameters.
    /// </summary>
    [DataContract(Name = "RoomSecurityDto")]
    public partial class RoomSecurityDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public RoomSecurityError? Error { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSecurityDto" /> class.
        /// </summary>
        /// <param name="members">The list of room members..</param>
        /// <param name="warning">The warning message..</param>
        /// <param name="error">error.</param>
        public RoomSecurityDto(List<FileShareDto> members = default, string warning = default, RoomSecurityError? error = default)
        {
            this.Members = members;
            this.Warning = warning;
            this.Error = error;
        }

        /// <summary>
        /// The list of room members.
        /// </summary>
        /// <value>The list of room members.</value>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<FileShareDto> Members { get; set; }

        /// <summary>
        /// The warning message.
        /// </summary>
        /// <value>The warning message.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "warning", EmitDefaultValue = true)]
        public string Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomSecurityDto {\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
